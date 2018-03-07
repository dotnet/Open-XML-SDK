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
        private readonly SdbSchemaDatas _sdbSchemaDatas;
        private readonly SchemaTypeValidator _schemaTypeValidator;

        /// <summary>
        /// Initializes a new instance of the SchemaValidator. Default to FileFormat.Office2007.
        /// </summary>
        public SchemaValidator()
            : this(FileFormatVersions.Office2007)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SchemaValidator.
        /// </summary>
        /// <param name="fileFormat">The target Open XML format.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the "fileFormat" parameter is not FileFormat.Office2007, FileFormat.Office2010 or FileFormat.O15.</exception>
        public SchemaValidator(FileFormatVersions fileFormat)
        {
            if (fileFormat == FileFormatVersions.Office2007)
            {
                _sdbSchemaDatas = SdbSchemaDatas.GetOffice2007SchemaDatas();
            }
            else if(fileFormat == FileFormatVersions.Office2010)
            {
                _sdbSchemaDatas = SdbSchemaDatas.GetOffice2010SchemaDatas();
            }
            else if (fileFormat == FileFormatVersions.Office2013)
            {
                _sdbSchemaDatas = SdbSchemaDatas.GetOffice2013SchemaDatas();
            }
            else if (fileFormat == FileFormatVersions.Office2016)
            {
                this._sdbSchemaDatas = SdbSchemaDatas.GetOffice2016SchemaDatas();
            }
            else
            {
                string message = String.Format(System.Globalization.CultureInfo.CurrentUICulture,
                                                    ExceptionMessages.FileFormatNotSupported,
                                                    fileFormat);
                throw new ArgumentOutOfRangeException(nameof(fileFormat), message);
            }

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
