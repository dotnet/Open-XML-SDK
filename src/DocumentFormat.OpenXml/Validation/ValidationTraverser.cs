// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation
{
    internal static class ValidationTraverser
    {
        /// <summary>
        /// Enumerate all the descendants elements of this element and do validating.
        /// Preorder traversing.
        /// </summary>
        /// <param name="validationContext"></param>
        /// <param name="validateAction">The delegate method to do the validating.</param>
        internal static void ValidatingTraverse(ValidationContext validationContext, Action<ValidationContext> validateAction)
        {
            Debug.Assert(validationContext != null);
            Debug.Assert(validationContext.McContext != null);
            Debug.Assert(validateAction != null);

            if (validationContext.IsCancelled)
            {
                return;
            }

            OpenXmlElement element = validationContext.Stack.Current.Element;

            // 1. Skip elements in ProcessContent.
            // 2. Select correct Choice / Fallback
            // Need bookkeep MC context
            // Need to collect MC context from ancestor

            // bookkeep MC context,
            // MC Spec: Compatibility-rule attributes shall affect the element to which they 1 are attached, including the element’s other attributes and contents.
            validationContext.McContext.PushMCAttributes2(element.MCAttributes, element.LookupNamespace);

            if (element.IsStrongTypedElement())
            {
                // only call validate on elements that defined in the format.
                if (validationContext.FileFormat.AtLeast(element.InitialVersion))
                {
                    validateAction(validationContext);
                }
                else if (validationContext.McContext.IsProcessContent(element))
                {
                    // do not validate this element.
                }

                foreach (OpenXmlElement child in element.ChildElements)
                {
                    using (validationContext.Stack.Push(element: child))
                    {
                        ValidatingTraverse(validationContext, validateAction);
                    }
                }
            }
            else if (element.IsUnknown())
            {
                // TODO: Issue: all types are weak types now, need to change the Framework to load strong typed elements!!!
                if (validationContext.McContext.IsProcessContent(element))
                {
                    // do validating on children elements.
                    foreach (OpenXmlElement child in element.ChildElements)
                    {
                        using (validationContext.Stack.Push(element: child))
                        {
                            ValidatingTraverse(validationContext, validateAction);
                        }
                    }
                }
            }
            else if (element.IsAlternateContent())
            {
                validateAction(validationContext);

                OpenXmlCompositeElement selectedContent;

                selectedContent = validationContext.McContext.GetContentFromACBlock((AlternateContent)element, validationContext.FileFormat);

                if (selectedContent != null)
                {
                    foreach (var child in selectedContent.ChildElements)
                    {
                        using (validationContext.Stack.Push(element: child))
                        {
                            ValidatingTraverse(validationContext, validateAction);
                        }
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
                Debug.Assert(element.Parent != null && element.Parent is AlternateContent);

                // should not be here, otherwise, wrong case ( the parent is not AlternateContent).
            }

            validationContext.McContext.PopMCAttributes2();
        }
    }
}
