// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Schema validator.
    /// </summary>
    internal class SchemaValidator
    {
        private readonly SdbSchemaData _sdbSchemaDatas;
        private readonly SchemaTypeValidator _schemaTypeValidator;

        /// <summary>
        /// Initializes a new instance of the SchemaValidator.
        /// </summary>
        /// <param name="fileFormat">The target Open XML format.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the "fileFormat" parameter is not FileFormat.Office2007, FileFormat.Office2010 or FileFormat.O15.</exception>
        public SchemaValidator(FileFormatVersions fileFormat)
        {
            _sdbSchemaDatas = SdbSchemaData.GetSchemaData(fileFormat);
            _schemaTypeValidator = new SchemaTypeValidator(_sdbSchemaDatas);
        }

        /// <summary>
        /// Validate the DOM tree under the specified OpenXmlElement in the context.
        /// </summary>
        public void Validate(ValidationContext validationContext)
        {
            Debug.Assert(validationContext != null);
            Debug.Assert(validationContext.Element != null);

            var openxmlElement = validationContext.Element;

            Debug.Assert(!(openxmlElement is OpenXmlUnknownElement || openxmlElement is OpenXmlMiscNode));

            // Can not just validate AlternateContent / Choice / Fallback
            // Debug.Assert(!(openxmlElement is AlternateContent))
            Debug.Assert(!(openxmlElement is AlternateContentChoice || openxmlElement is AlternateContentFallback));

            ValidationTraverser.ValidatingTraverse(validationContext, ValidateElement, null);

            // validationContext.Element = openxmlElement;
            return;
        }

        /// <summary>
        /// Validate the OpenXmlElement in the context.
        /// </summary>
        /// <param name="validationContext"></param>
        /// <remarks>
        /// This method validates the OpenXmlElement itself only.
        /// </remarks>
        private void ValidateElement(ValidationContext validationContext)
        {
            _schemaTypeValidator.Validate(validationContext);
        }
    }
}
