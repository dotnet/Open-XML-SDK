// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Tests
{
    internal static class ValidatorExtension
    {
        /// <summary>
        /// Validate the DOM tree under the specified OpenXmlElement.
        /// </summary>
        /// <param name="schemaValidator">The schemaValidator.</param>
        /// <param name="openXmlElement">The root of the sub tree.</param>
        /// <returns>Returns the validation result in ValidationResult.</returns>
        /// <remarks>
        /// Only schema validating.
        /// </remarks>
        public static List<ValidationErrorInfo> Validate(this DocumentValidator schemaValidator, OpenXmlElement openXmlElement)
        {
            Debug.Assert(openXmlElement is not null);

            Debug.Assert(!(openXmlElement is OpenXmlUnknownElement || openXmlElement is OpenXmlMiscNode));

            // Can not just validate AlternateContent / Choice / Fallback
            Debug.Assert(!(openXmlElement is AlternateContentChoice || openXmlElement is AlternateContentFallback));

            var validationContext = new ValidationContext(new OpenXmlNamespaceResolver());

            validationContext.Stack.Push(element: openXmlElement);

            schemaValidator.Validate(validationContext);

            return validationContext.Errors;
        }
    }
}
