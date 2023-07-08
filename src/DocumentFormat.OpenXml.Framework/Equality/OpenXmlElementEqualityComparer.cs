// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DocumentFormat.OpenXml
{
    internal sealed class OpenXmlElementEqualityComparer : IEqualityComparer<OpenXmlElement>
    {
        /// <summary>
        /// Gets the options regulating how equality is defined.
        /// </summary>
        internal OpenXmlElementEqualityOptions Options { get; }

        internal OpenXmlElementEqualityComparer(OpenXmlElementEqualityOptions options)
        {
            this.Options = options;
        }

        /// <summary>
        /// Determines equality for two given <see cref="OpenXmlElement"/>.
        /// </summary>
        /// <param name="x">First object.</param>
        /// <param name="y">Second object.</param>
        /// <returns></returns>
        public bool Equals(OpenXmlElement? x, OpenXmlElement? y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            if (x.GetType() != y.GetType())
            {
                return false;
            }

            if (!this.CheckAndEquateSpecialOptions(x, y))
            {
                return false;
            }

            if (x.HasChildren != y.HasChildren)
            {
                return false;
            }

            if (!OpenXmlElementEqualityComparer.PrefixAndQNameEqual(x, y, this.Options))
            {
                return false;
            }

            if (x is OpenXmlLeafTextElement)
            {
                if (!string.Equals(x.InnerText, y.InnerText, StringComparison.Ordinal))
                {
                    return false;
                }
            }

            if (x.HasChildren)
            {
                // DEVNOTE: Do not refactor this to use "simpler" for construct.
                // The indexer on ChildElement walks the linked list for each operation,
                // not maintaining state so it turns into a O(n^2) operation.
                OpenXmlElementList.Enumerator tChilds = x.ChildElements.GetEnumerator();
                OpenXmlElementList.Enumerator oChilds = y.ChildElements.GetEnumerator();

                int e1 = 0, e2 = 0;
                while (OpenXmlElementEqualityComparer.MoveNextAndTrackCount(ref tChilds, ref oChilds, ref e1, ref e2))
                {
                    if (!this.Equals(tChilds.Current, oChilds.Current))
                    {
                        return false;
                    }
                }

                // Different amount of children.
                if (e1 != e2)
                {
                    return false;
                }
            }

            for (int i = 0; i < x.ParsedState.Attributes.Length; i++)
            {
                var tAttr = x.ParsedState.Attributes[i];
                var oAttr = y.ParsedState.Attributes[i];

                if ((tAttr.Value == null && oAttr.Value != null) || (tAttr.Value != null && oAttr.Value == null))
                {
                    return false;
                }

                if (tAttr.Value == null)
                {
                    continue;
                }

                if (!tAttr.Value.Equals(oAttr.Value))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Handles checking of all options that changes the behaviour of equality based on options in <see cref="OpenXmlElementEqualityOptions"/>.
        /// </summary>
        private bool CheckAndEquateSpecialOptions(OpenXmlElement x, OpenXmlElement y)
        {
            if (!this.Options.RequireParsed)
            {
                if (!x.XmlParsed && !y.XmlParsed)
                {
                    return string.Equals(x.RawOuterXml, y.RawOuterXml, StringComparison.Ordinal);
                }
            }

            x.MakeSureParsed();
            y.MakeSureParsed();

            if (this.Options.IncludeExtendedAttributes)
            {
                if (x.ExtendedAttributes == null != (y.ExtendedAttributes == null))
                {
                    return false;
                }

                if (x.ExtendedAttributes != null && y.ExtendedAttributes != null)
                {
                    if (x.ExtendedAttributes.Count() != y.ExtendedAttributes.Count())
                    {
                        return false;
                    }

                    for (int i = 0; i < x.ExtendedAttributes.Count(); i++)
                    {
                        if (!x.ExtendedAttributes.ElementAt(i).Equals(y.ExtendedAttributes.ElementAt(i)))
                        {
                            return false;
                        }
                    }
                }
            }

            if (this.Options.IncludeMCAttributes)
            {
                if (x.MCAttributes == null != (y.MCAttributes == null) || (x.MCAttributes != null && !x.MCAttributes.Equals(y.MCAttributes)))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Calculates a hashcode based on the given <see cref="OpenXmlElement"/> object.
        /// </summary>
        /// <param name="obj">The object to get a hashcode for.</param>
        /// <returns></returns>
        public int GetHashCode([DisallowNull] OpenXmlElement obj)
        {
            if (obj == null)
            {
                return 0;
            }

            var hc = default(FrameworkHashCode);
            if (this.Options.IncludeMCAttributes)
            {
                hc.Add(obj.MCAttributes);
            }

            for (int i = 0; i < obj.ParsedState.Attributes.Length; i++)
            {
                if (obj.ParsedState.Attributes[i].Value != null)
                {
                    hc.Add(obj.ParsedState.Attributes[i].Value);
                }
            }

            if (this.Options.IncludeExtendedAttributes)
            {
                foreach (OpenXmlAttribute attr in obj.ExtendedAttributes)
                {
                    hc.Add(attr);
                }
            }

            if (obj.HasChildren)
            {
                foreach (OpenXmlElement child in obj.ChildElements)
                {
                    hc.Add(child);
                }
            }

            return hc.GetHash;
        }

        private static bool PrefixAndQNameEqual(OpenXmlElement x, OpenXmlElement y, OpenXmlElementEqualityOptions options)
        {
            OpenXmlQualifiedName tQName = x.ParsedState.Metadata.QName;
            OpenXmlQualifiedName oQName = y.ParsedState.Metadata.QName;

            if (!tQName.Equals(oQName))
            {
                return false;
            }

            if (options.SkipPrefixComparison)
            {
                return true;
            }

            string turi = tQName.Namespace.Uri;
            string ouri = oQName.Namespace.Uri;

            var tPrefix = x.LookupPrefixLocal(ouri);
            var oPrefix = y.LookupPrefixLocal(ouri);

            if (string.IsNullOrEmpty(tPrefix))
            {
               tPrefix = x.Features.GetNamespaceResolver().LookupPrefix(turi);
            }

            if (string.IsNullOrEmpty(oPrefix))
            {
                oPrefix = y.Features.GetNamespaceResolver().LookupPrefix(ouri);
            }

            return string.Equals(tPrefix, oPrefix, StringComparison.Ordinal);
        }

        private static bool MoveNextAndTrackCount(ref OpenXmlElementList.Enumerator e1, ref OpenXmlElementList.Enumerator e2, ref int e1ctr, ref int e2ctr)
        {
            if (e1.MoveNext())
            {
                e1ctr++;
                if (e2.MoveNext())
                {
                    e2ctr++;
                    return true;
                }
            }
            else if (e2.MoveNext())
            {
                e2ctr++;
            }

            return false;
        }
    }
}
