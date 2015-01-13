// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation
{
    static class ValidationTraverser
    {

        internal delegate void ValidationAction(ValidationContext validationContext);

        /// <summary>
        /// Returns true to stop the traverse.
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        internal delegate bool GetStopSignal(ValidationContext validationContext);

        /// <summary>
        /// Enumerate all the descendants elements of this element and do validating.
        /// Preorder traversering.
        /// </summary>
        /// <param name="validationContext"></param>
        /// <param name="validateAction">The delegate method to do the validating.</param>
        /// <param name="finishAction">The delegate method to be called when the traverse finished.</param>
        /// <param name="getStopSignal">The delegate method which will fire stop signal.</param>
        internal static void ValidatingTraverse(ValidationContext validationContext, ValidationAction validateAction, ValidationAction finishAction, GetStopSignal getStopSignal)
        {
            Debug.Assert(validationContext != null);
            Debug.Assert(validationContext.McContext != null);
            Debug.Assert(validateAction != null);

            if (getStopSignal != null)
            {
                if (getStopSignal(validationContext))
                {
                    return;
                }
            }

            OpenXmlElement element = validationContext.Element;

            //specify whether ValidationAction is called
            bool validatingActed = false;

            // 1. Skip elements in ProcessContent.
            // 2. Select correct Choice / Fallback
            // Need bookkeep MC context
            // Need to collect MC context from ancestor

            // bookkeep MC context, 
            // MC Spec: Compatibility-rule attributes shall affect the element to which they 1 are attached, including the element’s other attributes and contents.
            validationContext.McContext.PushMCAttributes2(element.MCAttributes, prefix => element.LookupNamespace(prefix));

            if (element.IsStrongTypedElement())
            {
                // only call validate on elements that defined in the format.
                if (element.IsInVersion(validationContext.FileFormat))
                {
                    validateAction(validationContext);
                    validatingActed = true;
                }
                else if (validationContext.McContext.IsProcessContent(element))
                {
                    // do not validate this element.
                }

             
                foreach (OpenXmlElement child in element.ChildElements)
                {
                    validationContext.Element = child;
                    ValidatingTraverse(validationContext, validateAction, finishAction, getStopSignal);
                }

            }
            else if (element.ElementTypeId == ReservedElementTypeIds.OpenXmlUnknownElementId ||
                  element.ElementTypeId == ReservedElementTypeIds.OpenXmlUnknownElementId)
            {
                // TODO: Issue: all types are weak types now, need to change the Framework to load strong typed elements!!!
                if (validationContext.McContext.IsProcessContent(element))
                {
                    // do validating on children elements.

                    foreach (OpenXmlElement child in element.ChildElements)
                    {
                        validationContext.Element = child;
                        ValidatingTraverse(validationContext, validateAction, finishAction, getStopSignal);
                    }
                }
            }
            else if (element.ElementTypeId == ReservedElementTypeIds.AlternateContentId)
            {

                validateAction(validationContext);
                validatingActed = true;

                OpenXmlCompositeElement selectedContent;

                selectedContent = validationContext.McContext.GetContentFromACBlock((AlternateContent)element, validationContext.FileFormat);

                if (selectedContent != null)
                {
                    foreach (var child in selectedContent.ChildElements)
                    {
                        validationContext.Element = child;
                        ValidatingTraverse(validationContext, validateAction, finishAction, getStopSignal);
                    }
                }
            }
            else if (element.ElementTypeId == ReservedElementTypeIds.OpenXmlMiscNodeId)
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

            if (validatingActed && finishAction != null)
            {
                validationContext.Element = element;
                finishAction(validationContext);
            }
        }

    }
}
