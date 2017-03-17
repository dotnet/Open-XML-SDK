// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Internal.SchemaValidation;

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
        internal static ValidationResult Validate(this SchemaValidator schemaValidator, OpenXmlElement openxmlElement)
        {
            Debug.Assert(openxmlElement != null);

            var validationResult = new ValidationResult();

            Debug.Assert(!(openxmlElement is OpenXmlUnknownElement || openxmlElement is OpenXmlMiscNode));

            // Can not just validate AlternateContent / Choice / Fallback
            Debug.Assert(!(openxmlElement is AlternateContentChoice || openxmlElement is AlternateContentFallback));

            var validationContext = new ValidationContext();
            validationContext.ValidationErrorEventHandler += validationResult.OnValidationError;

            validationContext.Element = openxmlElement;

            schemaValidator.Validate(validationContext);

            return validationResult;
        }
    }
}
