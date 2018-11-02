// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    internal class MCContext
    {
        internal delegate string LookupNamespace(string prefix);

        private Stack<string> _currentIgnorable;
        private Stack<XmlQualifiedName> _currentPreserveAttr;
        private Stack<XmlQualifiedName> _currentPreserveEle;
        private Stack<XmlQualifiedName> _currentProcessContent;

        private Stack<int> _pushedIgnor;
        private Stack<int> _pushedPA;
        private Stack<int> _pushedPE;
        private Stack<int> _pushedPC;
        private bool _noExceptionOnError;

        internal MCContext()
        {
            _currentIgnorable = new Stack<string>();
            _currentPreserveAttr = new Stack<XmlQualifiedName>();
            _currentPreserveEle = new Stack<XmlQualifiedName>();
            _currentProcessContent = new Stack<XmlQualifiedName>();

            _pushedIgnor = new Stack<int>();
            _pushedPA = new Stack<int>();
            _pushedPC = new Stack<int>();
            _pushedPE = new Stack<int>();
        }

        internal MCContext(bool exceptionOnError)
            : this()
        {
            _noExceptionOnError = !exceptionOnError;
        }

        internal LookupNamespace LookupNamespaceDelegate { get; set; }

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
        internal void PushMCAttributes2(MarkupCompatibilityAttributes attr, LookupNamespace lookupNamespaceDelegate)
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
            Debug.Assert(!string.IsNullOrEmpty(ignorable));

            var prefixes = ignorable.Trim().Split(new char[] { ' ' });
            foreach (var prefix in prefixes)
            {
                var ns = LookupNamespaceDelegate(prefix);
                if (string.IsNullOrEmpty(ns))
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

                var ns = LookupNamespaceDelegate(items[0]);
                if (string.IsNullOrEmpty(ns))
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

        internal bool IsIgnorableNs(byte namespaceId)
        {
            if (_currentIgnorable.Count == 0)
            {
                return false;
            }

            if (_currentIgnorable.Contains(NamespaceIdMap.GetNamespaceUri(namespaceId)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsIgnorableNs(string ns)
        {
            if (_currentIgnorable.Count == 0)
            {
                return false;
            }

            if (string.IsNullOrEmpty(ns))
            {
                return false;
            }

            if (_currentIgnorable.Contains(ns))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsPreservedAttribute(string ns, string localName)
        {
            return ContainsQName(localName, ns, _currentPreserveAttr);
        }

        internal bool IsPreservedElement(string ns, string localName)
        {
            return ContainsQName(localName, ns, _currentPreserveEle);
        }

        internal bool IsProcessContent(string ns, string localName)
        {
            return ContainsQName(localName, ns, _currentProcessContent);
        }

        internal bool IsProcessContent(OpenXmlElement element)
        {
            // TODO: performance tuning
            return ContainsQName(element.LocalName, element.NamespaceUri, _currentProcessContent);
        }

        internal AttributeAction GetAttributeAction(string ns, string localName, FileFormatVersions format)
        {
            if (format == (FileFormatVersions.Office2010 | FileFormatVersions.Office2007) || format.All())
            {
                return AttributeAction.Normal;
            }

            if (string.IsNullOrEmpty(ns))
            {
                return AttributeAction.Normal;
            }

            if (NamespaceIdMap.IsInFileFormat(ns, format))
            {
                return AttributeAction.Normal;
            }

            if (!IsIgnorableNs(ns))
            {
                return AttributeAction.Normal;
            }

            if (IsPreservedAttribute(ns, localName))
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

            if (IsIgnorableNs(element.NamespaceUri))
            {
                if (IsPreservedElement(element.NamespaceUri, element.LocalName))
                {
                    return ElementAction.Normal;
                }

                if (IsProcessContent(element.NamespaceUri, element.LocalName))
                {
                    return ElementAction.ProcessContent;
                }

                return ElementAction.Ignore;
            }

            return ElementAction.Normal;
        }
        #endregion

        #region private methods
        private static bool ContainsQName(string localName, string ns, Stack<XmlQualifiedName> stack)
        {
            XmlQualifiedName qname = new XmlQualifiedName(localName, ns);
            foreach (var qn in stack)
            {
                if (qn == qname ||
                    qn.Name == "*" && qn.Namespace == ns)
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

        private int PushIgnorable(MarkupCompatibilityAttributes attr)
        {
            int ret = 0;
            if (attr != null && attr.Ignorable != null && !string.IsNullOrEmpty(attr.Ignorable.Value))
            {
                foreach (var ns in ParsePrefixList(attr.Ignorable, OnMcContextError))
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
            if (attr != null && attr.PreserveAttributes != null && !string.IsNullOrEmpty(attr.PreserveAttributes.Value))
            {
                ret = PushQName(_currentPreserveAttr, attr.PreserveAttributes.Value);
            }

            return ret;
        }

        private int PushPreserveElement(MarkupCompatibilityAttributes attr)
        {
            int ret = 0;
            if (attr != null && attr.PreserveElements != null && !string.IsNullOrEmpty(attr.PreserveElements.Value))
            {
                ret = PushQName(_currentPreserveEle, attr.PreserveElements.Value);
            }

            return ret;
        }

        private int PushProcessContent(MarkupCompatibilityAttributes attr)
        {
            int ret = 0;
            if (attr != null && attr.ProcessContent != null && !string.IsNullOrEmpty(attr.ProcessContent.Value))
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
        internal OpenXmlCompositeElement GetContentFromACBlock(AlternateContent acblk, FileFormatVersions format)
        {
            Debug.Assert(format != FileFormatVersions.Office2007.AndLater());

            foreach (var choice in acblk.ChildElements.OfType<AlternateContentChoice>())
            {
                if (choice.Requires == null)
                {
                    //should we throw exception here?
                    continue;
                }

                string reqs = choice.Requires.InnerText.Trim();
                if (string.IsNullOrEmpty(reqs))
                {
                    //should we throw exception here?
                    continue;
                }

                bool chooce = true;
                foreach (var req in reqs.Split(new char[] { ' ' }))
                {
                    //fix bug 537858
                    //the LookupNamespaceDeleget is from xmlReader
                    //bug when we try to GetContentFromACBlock, the reader has already moved to the next element of ACB
                    //so we should use the element's LookupNamespace function to find it
                    //string ns = LookupNamespaceDelegate(req);
                    string ns = choice.LookupNamespace(req);
                    if (ns == null)
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

                    if (!NamespaceIdMap.IsInFileFormat(ns, format))
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
            if (fallback != null)
            {
                return fallback;
            }

            return null;
        }
        #endregion
    }
}
