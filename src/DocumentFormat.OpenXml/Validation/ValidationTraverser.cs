// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation
{
    internal static class ValidationTraverser
    {
        public static IEnumerable<OpenXmlElement> Descendants(this OpenXmlElement? element, FileFormatVersions version = FileFormatVersions.Office2007, TraversalOptions options = TraversalOptions.None)
        {
            if (element is null)
            {
                return Cached.Array<OpenXmlElement>();
            }

            if ((options & TraversalOptions.SelectAlternateContent) == TraversalOptions.SelectAlternateContent)
            {
                return ValidatingTraverse(element, new MCContext(element.Features.GetNamespaceResolver(), false), version);
            }
            else
            {
                return element.Descendants();
            }
        }

        /// <summary>
        /// Enumerate all the descendants elements of this element and do validating.
        /// Preorder traversing.
        /// </summary>
        /// <param name="validationContext"></param>
        /// <param name="validateAction">The delegate method to do the validating.</param>
        internal static void ValidatingTraverse(ValidationContext validationContext, Action<ValidationContext> validateAction)
        {
            var children = ValidatingTraverse(validationContext.Stack.Current?.Element, validationContext.McContext, validationContext.FileFormat);

            foreach (var child in children)
            {
                if (validationContext.CheckIfCancelled())
                {
                    return;
                }

                using (validationContext.Stack.Push(element: child))
                {
                    validateAction(validationContext);
                }
            }
        }

        private static IEnumerable<OpenXmlElement> ValidatingTraverse(OpenXmlElement? inElement, MCContext mcContext, FileFormatVersions version)
        {
            if (inElement is null)
            {
                yield break;
            }

            var stack = new Stack<OpenXmlElement?>();

            stack.Push(inElement);

            while (stack.Count > 0)
            {
                var element = stack.Pop();

                if (element is null)
                {
                    mcContext.PopMCAttributes2();
                    continue;
                }

                // 1. Skip elements in ProcessContent.
                // 2. Select correct Choice / Fallback
                // Need bookkeep MC context
                // Need to collect MC context from ancestor

                // bookkeep MC context,
                // MC Spec: Compatibility-rule attributes shall affect the element to which they 1 are attached, including the element’s other attributes and contents.
                mcContext.PushMCAttributes2(element.MCAttributes, element.LookupNamespace);
                stack.Push(null);

                if (element.IsStrongTypedElement())
                {
                    // only call validate on elements that defined in the format.
                    if (version.AtLeast(element.InitialVersion))
                    {
                        yield return element;
                    }
                    else if (mcContext.IsProcessContent(element))
                    {
                        // do not validate this element.
                    }

                    foreach (var child in element.ChildElements)
                    {
                        stack.Push(child);
                    }
                }
                else if (element.IsUnknown())
                {
                    // TODO: Issue: all types are weak types now, need to change the Framework to load strong typed elements!!!
                    if (mcContext.IsProcessContent(element))
                    {
                        // do validating on children elements.
                        foreach (var child in element.ChildElements)
                        {
                            stack.Push(child);
                        }
                    }
                }
                else if (element.IsAlternateContent())
                {
                    yield return element;

                    var selectedContent = mcContext.GetContentFromACBlock((AlternateContent)element, version);

                    if (selectedContent is not null)
                    {
                        foreach (var child in selectedContent.ChildElements)
                        {
                            stack.Push(child);
                        }
                    }
                }
                else if (element.IsMiscNode())
                {
                    // non-element node
                    // just skip
                }
                else
                {
                    Debug.Assert(element is AlternateContentChoice || element is AlternateContentFallback);
                    Debug.Assert(element.Parent is not null && element.Parent is AlternateContent);

                    // should not be here, otherwise, wrong case ( the parent is not AlternateContent).
                }
            }
        }
    }
}
