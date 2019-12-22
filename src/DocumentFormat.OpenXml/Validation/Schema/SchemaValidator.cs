// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

#pragma warning disable CA1822

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Schema validator.
    /// </summary>
    internal class SchemaValidator
    {
        /// <summary>
        /// Validate the DOM tree under the specified OpenXmlElement in the context.
        /// </summary>
        public void Validate(ValidationContext validationContext)
        {
            Debug.Assert(validationContext != null);
            Debug.Assert(validationContext.Stack.Current.Element != null);

            var openxmlElement = validationContext.Stack.Current.Element;

            Debug.Assert(!(openxmlElement is OpenXmlUnknownElement || openxmlElement is OpenXmlMiscNode));

            // Can not just validate AlternateContent / Choice / Fallback
            // Debug.Assert(!(openxmlElement is AlternateContent))
            Debug.Assert(!(openxmlElement is AlternateContentChoice || openxmlElement is AlternateContentFallback));

            ValidationTraverser.ValidatingTraverse(validationContext, SchemaTypeValidator.Validate, null);

            return;
        }
    }
}
