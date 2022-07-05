// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    internal class MCContext
    {
        internal delegate string? LookupNamespace(string prefix);

        private readonly IOpenXmlNamespaceResolver _resolver;
        private readonly Stack<string> _currentIgnorable;
        private readonly Stack<XmlQualifiedName> _currentPreserveAttr;
        private readonly Stack<XmlQualifiedName> _currentPreserveEle;
        private readonly Stack<XmlQualifiedName> _currentProcessContent;

        private readonly Stack<int> _pushedIgnor;
        private readonly Stack<int> _pushedPA;
        private readonly Stack<int> _pushedPE;
        private readonly Stack<int> _pushedPC;
        private readonly bool _noExceptionOnError;

        internal MCContext(IOpenXmlNamespaceResolver resolver)
        {
            _resolver = resolver;
            _currentIgnorable = new Stack<string>();
            _currentPreserveAttr = new Stack<XmlQualifiedName>();
            _currentPreserveEle = new Stack<XmlQualifiedName>();
            _currentProcessContent = new Stack<XmlQualifiedName>();

            _pushedIgnor = new Stack<int>();
            _pushedPA = new Stack<int>();
            _pushedPC = new Stack<int>();
            _pushedPE = new Stack<int>();
        }

        internal MCContext(IOpenXmlNamespaceResolver resolver, bool exceptionOnError)
            : this(resolver)
        {
            _noExceptionOnError = !exceptionOnError;
        }

        internal LookupNamespace? LookupNamespaceDelegate { get; set; }

        #region methods to maintain the MC Context
        internal void PushMCAttributes(MarkupCompatibilityAttributes attr)
        {
            _pushedIgnor.Push(PushIgnorable(attr));
            _pushedPA.Push(PushPreserveAttribute(attr));
            _pushedPE.Push(PushPreserveElement(attr));
            _pushedPC.Push(PushProcessContent(attr));
        }

        internal void PopMCAttributes()
        {
            PopIgnorable(_pushedIgnor.Pop());
            PopPreserveAttribute(_pushedPA.Pop());
            PopPreserveElement(_pushedPE.Pop());
            PopProcessContent(_pushedPC.Pop());
        }

        /// <summary>
        /// This method is for MC validation use. Only push Ignorable and ProcessContent.
        /// </summary>
        /// <param name="attr"></param>
        /// <param name="lookupNamespaceDelegate"></param>
        internal void PushMCAttributes2(MarkupCompatibilityAttributes? attr, LookupNamespace lookupNamespaceDelegate)
        {
            LookupNamespaceDelegate = lookupNamespaceDelegate;

            _pushedIgnor.Push(PushIgnorable(attr));
            _pushedPC.Push(PushProcessContent(attr));
        }

        /// <summary>
        /// This method is for MC validation use only.
        /// </summary>
        internal void PopMCAttributes2()
        {
            PopIgnorable(_pushedIgnor.Pop());
            PopProcessContent(_pushedPC.Pop());
        }

        /// <summary>
        /// This method is called by ParseQNameList() and ParsePrefixList().
        /// </summary>
        /// <param name="value">The value of the attribute.</param>
        /// <returns>True to stop parsing; False to continue.</returns>
        internal delegate bool OnInvalidValue(string value);

        internal IEnumerable<string> ParsePrefixList(string ignorable, OnInvalidValue onInvalidPrefix)
        {
            var prefixes = ignorable.Trim().Split(new char[] { ' ' });
            foreach (var prefix in prefixes)
            {
                var ns = LookupNamespaceDelegate?.Invoke(prefix);
                if (ns.IsNullOrEmpty())
                {
                    if (onInvalidPrefix(ignorable))
                    {
                        yield break;
                    }
                    else
                    {
                        continue;
                    }
                }

                yield return ns;
            }
        }

        internal IEnumerable<XmlQualifiedName> ParseQNameList(string qnameList, OnInvalidValue onInvalidQName)
        {
            Debug.Assert(!string.IsNullOrEmpty(qnameList));

            var qnames = qnameList.Trim().Split(new char[] { ' ' });
            foreach (var qname in qnames)
            {
                var items = qname.Split(':');
                if (items.Length != 2)
                {
                    if (onInvalidQName(qnameList))
                    {
                        yield break;
                    }
                    else
                    {
                        continue;
                    }
                }

                var ns = LookupNamespaceDelegate?.Invoke(items[0]);
                if (ns.IsNullOrEmpty())
                {
                    if (onInvalidQName(qnameList))
                    {
                        yield break;
                    }
                    else
                    {
                        continue;
                    }
                }

                yield return new XmlQualifiedName(items[1], ns);
            }
        }

        #endregion

        #region Exposed functions
        internal bool HasIgnorable()
        {
            return _currentIgnorable.Count > 0;
        }

        internal bool IsIgnorableNs(in OpenXmlNamespace ns)
        {
            if (_currentIgnorable.Count == 0)
            {
                return false;
            }

            if (ns.IsEmpty)
            {
                return false;
            }

            if (_currentIgnorable.Contains(ns.Uri))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsPreservedAttribute(in OpenXmlQualifiedName qname)
        {
            return ContainsQName(qname, _currentPreserveAttr);
        }

        internal bool IsPreservedElement(in OpenXmlQualifiedName qname)
        {
            return ContainsQName(qname, _currentPreserveEle);
        }

        internal bool IsProcessContent(in OpenXmlQualifiedName qname)
        {
            return ContainsQName(qname, _currentProcessContent);
        }

        internal bool IsProcessContent(OpenXmlElement element)
        {
            // TODO: performance tuning
            return ContainsQName(element.QName, _currentProcessContent);
        }

        internal AttributeAction GetAttributeAction(in OpenXmlQualifiedName qname, FileFormatVersions format)
        {
            if (format == (FileFormatVersions.Office2010 | FileFormatVersions.Office2007) || format.All())
            {
                return AttributeAction.Normal;
            }

            if (qname.Namespace.IsEmpty)
            {
                return AttributeAction.Normal;
            }

            if (_resolver.HasVersion(qname.Namespace, format))
            {
                return AttributeAction.Normal;
            }

            if (!IsIgnorableNs(qname.Namespace))
            {
                return AttributeAction.Normal;
            }

            if (IsPreservedAttribute(qname))
            {
                return AttributeAction.Normal;
            }

            return AttributeAction.Ignore;
        }

        internal ElementAction GetElementAction(OpenXmlElement element, FileFormatVersions format)
        {
            if (format == (FileFormatVersions.Office2010 | FileFormatVersions.Office2007) || format.All())
            {
                return ElementAction.Normal;
            }

            if (element is AlternateContent)
            {
                return ElementAction.ACBlock;
            }

            if (element.IsInVersion(format))
            {
                return ElementAction.Normal;
            }

            if (IsIgnorableNs(element.QName.Namespace))
            {
                if (IsPreservedElement(element.QName))
                {
                    return ElementAction.Normal;
                }

                if (IsProcessContent(element.QName))
                {
                    return ElementAction.ProcessContent;
                }

                return ElementAction.Ignore;
            }

            return ElementAction.Normal;
        }
        #endregion

        #region private methods
        private static bool ContainsQName(in OpenXmlQualifiedName input, Stack<XmlQualifiedName> stack)
        {
            var qname = new XmlQualifiedName(input.Name, input.Namespace.Uri);

            foreach (var qn in stack)
            {
                if (qn == qname ||
                    (qn.Name == "*" && qn.Namespace == input.Namespace.Uri))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// This method is called by ParseIgnorable() and ParseProcessContent().
        /// </summary>
        /// <param name="value">The value of the attribute.</param>
        /// <returns>True to stop parsing; False to continue.</returns>
        private bool OnMcContextError(string value)
        {
            if (_noExceptionOnError)
            {
                return false;
            }
            else
            {
                throw new InvalidMCContentException(SR.Format(ExceptionMessages.UnknowMCContent, value));
            }
        }

        private int PushIgnorable(MarkupCompatibilityAttributes? attr)
        {
            int ret = 0;
            if (attr is not null && attr.Ignorable is not null && !attr.Ignorable.Value.IsNullOrEmpty())
            {
                foreach (var ns in ParsePrefixList(attr.Ignorable.Value, OnMcContextError))
                {
                    _currentIgnorable.Push(ns);
                    ret++;
                }
            }

            return ret;
        }

        private int PushQName(Stack<XmlQualifiedName> stack, string value)
        {
            int ret = 0;

            foreach (var qn in ParseQNameList(value, OnMcContextError))
            {
                stack.Push(qn);
                ret++;
            }

            return ret;
        }

        private int PushPreserveAttribute(MarkupCompatibilityAttributes attr)
        {
            int ret = 0;
            if (attr is not null && attr.PreserveAttributes is not null && !attr.PreserveAttributes.Value.IsNullOrEmpty())
            {
                ret = PushQName(_currentPreserveAttr, attr.PreserveAttributes.Value);
            }

            return ret;
        }

        private int PushPreserveElement(MarkupCompatibilityAttributes attr)
        {
            int ret = 0;
            if (attr is not null && attr.PreserveElements is not null && !attr.PreserveElements.Value.IsNullOrEmpty())
            {
                ret = PushQName(_currentPreserveEle, attr.PreserveElements.Value);
            }

            return ret;
        }

        private int PushProcessContent(MarkupCompatibilityAttributes? attr)
        {
            int ret = 0;
            if (attr is not null && attr.ProcessContent is not null && !attr.ProcessContent.Value.IsNullOrEmpty())
            {
                ret = PushQName(_currentProcessContent, attr.ProcessContent.Value);
            }

            return ret;
        }

        private void PopIgnorable(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _currentIgnorable.Pop();
            }
        }

        private void PopPreserveAttribute(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _currentPreserveAttr.Pop();
            }
        }

        private void PopPreserveElement(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _currentPreserveEle.Pop();
            }
        }

        private void PopProcessContent(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _currentProcessContent.Pop();
            }
        }
        #endregion

        #region Helper functions
        internal OpenXmlCompositeElement? GetContentFromACBlock(AlternateContent acblk, FileFormatVersions format)
        {
            Debug.Assert(format != FileFormatVersions.Office2007.AndLater());

            foreach (var choice in acblk.ChildElements.OfType<AlternateContentChoice>())
            {
                if (choice.Requires is null)
                {
                    // should we throw exception here?
                    continue;
                }

                var reqs = choice.Requires.InnerText?.Trim();
                if (reqs.IsNullOrEmpty())
                {
                    // should we throw exception here?
                    continue;
                }

                bool chooce = true;
                foreach (var req in reqs.Split(new char[] { ' ' }))
                {
                    // fix bug 537858
                    // the LookupNamespaceDeleget is from xmlReader
                    // bug when we try to GetContentFromACBlock, the reader has already moved to the next element of ACB
                    // so we should use the element's LookupNamespace function to find it
                    // string ns = LookupNamespaceDelegate(req);
                    var uri = choice.LookupNamespace(req);

                    if (uri is null)
                    {
                        if (_noExceptionOnError)
                        {
                            chooce = false;
                            break;
                        }
                        else
                        {
                            throw new InvalidMCContentException(SR.Format(ExceptionMessages.UnknowMCContent, req));
                        }
                    }

                    var ns = new OpenXmlNamespace(uri);

                    if (!_resolver.HasVersion(ns, format))
                    {
                        chooce = false;
                        break;
                    }
                }

                if (chooce)
                {
                    return choice;
                }
            }

            var fallback = acblk.GetFirstChild<AlternateContentFallback>();
            if (fallback is not null)
            {
                return fallback;
            }

            return null;
        }
        #endregion
    }
}
