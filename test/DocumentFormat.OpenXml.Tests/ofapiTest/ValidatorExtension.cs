﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Validation.Schema;
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
        /// <param name="openxmlElement">The root of the sub tree.</param>
        /// <returns>Returns the validation result in ValidationResult.</returns>
        /// <remarks>
        /// Only schema validating.
        /// </remarks>
        public static List<ValidationErrorInfo> Validate(this SchemaValidator schemaValidator, OpenXmlElement openxmlElement)
        {
            Debug.Assert(openxmlElement != null);

            Debug.Assert(!(openxmlElement is OpenXmlUnknownElement || openxmlElement is OpenXmlMiscNode));

            // Can not just validate AlternateContent / Choice / Fallback
            Debug.Assert(!(openxmlElement is AlternateContentChoice || openxmlElement is AlternateContentFallback));

            var validationContext = new ValidationContext
            {
                Element = openxmlElement,
            };

            schemaValidator.Validate(validationContext);

            return validationContext.Errors;
        }
    }
}
