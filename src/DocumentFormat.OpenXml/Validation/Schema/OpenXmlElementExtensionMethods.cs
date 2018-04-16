// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Static class to hold extension methods for OpenXmlElement.
    /// </summary>
    internal static partial class OpenXmlElementExtensionMethods
    {
        internal static OpenXmlElement GetFirstChildMc(this OpenXmlElement parent, MCContext mcContext, FileFormatVersions format)
        {
            var child = parent.GetFirstNonMiscElementChild();
            return parent.GetChildMc(child, mcContext, format);
        }

        internal static OpenXmlElement GetNextChildMc(this OpenXmlElement parent, OpenXmlElement child, MCContext mcContext, FileFormatVersions format)
        {
            var next = child.GetNextNonMiscElementSibling();
            var mcTier = child.Parent;

            if (next == null && mcTier != parent)
            {
                // the child must be under element in ProcessContent or ACB
                if (mcTier is AlternateContentChoice || mcTier is AlternateContentFallback)
                {
                    mcTier = mcTier.Parent;
                }

                Debug.Assert(mcTier != null);

                // there is no more next sibling in this level, then try to find the next siblig of the up level.
                return parent.GetNextChildMc(mcTier, mcContext, format);
            }

            return parent.GetChildMc(next, mcContext, format);
        }

        /// <summary>
        /// Gets the next child (skip all MC elements (skip ACB layer, skip Ignorable element.)).
        /// </summary>
        /// <param name="parent">The logic parent element.</param>
        /// <param name="child">The child element to be tested.</param>
        /// <param name="mcContext">Markup Compatibility context.</param>
        /// <param name="format">Targeting file format (Office2007 or Office201).</param>
        /// <returns>The logic child (when we apply a MC preprocessor).</returns>
        private static OpenXmlElement GetChildMc(this OpenXmlElement parent, OpenXmlElement child, MCContext mcContext, FileFormatVersions format)
        {
            // Use stack to cache the next siblings in different levels.
            Stack<OpenXmlElement> nextSiblings = new Stack<OpenXmlElement>();

            while (child != null)
            {
                var acb = child as AlternateContent;
                if (acb == null && child.IsInVersion(format))
                {
                    return child;
                }
                else
                {
                    mcContext.PushMCAttributes2(child.MCAttributes, child.LookupNamespace);
                    if (acb != null)
                    {
                        nextSiblings.Push(child.GetNextNonMiscElementSibling());
                        var select = mcContext.GetContentFromACBlock(acb, format);
                        if (select != null)
                        {
                            child = select.GetFirstNonMiscElementChild();
                        }
                        else
                        {
                            // The ACB has no children elements.
                            // case like: <acb/> <acb><choice/><fallback/></acb>
                            child = null;
                        }
                    }
                    else
                    {
                        // Ignorable element, skip it
                        if (mcContext.IsIgnorableNs(child.NamespaceUri))
                        {
                            // Any element marked with ProcessContent should be an Ignorable Element
                            if (mcContext.IsProcessContent(child))
                            {
                                nextSiblings.Push(child.GetNextNonMiscElementSibling());

                                child = child.GetFirstNonMiscElementChild();
                            }
                            else
                            {
                                child = child.GetNextNonMiscElementSibling();
                            }
                        }
                        else
                        {
                            mcContext.PopMCAttributes2();
                            return child;
                        }
                    }

                    mcContext.PopMCAttributes2();
                }

                while (child == null && nextSiblings.Count > 0)
                {
                    child = nextSiblings.Pop();
                }
            }

            // child is null.
            return child;
        }
    }
}
