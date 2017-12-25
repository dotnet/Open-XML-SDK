// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Schema validator.
    /// </summary>
    internal class SchemaValidator : ICancelable
    {
        private SdbSchemaDatas _sdbSchemaDatas;
        private SchemaTypeValidator _schemaTypeValidator;
#if DEBUG
        private FileFormatVersions _fileFormat;
#endif
        private bool _stopValidating;

        /// <summary>
        /// Initializes a new instance of the SchemaValidator. Default to FileFormat.Office2007.
        /// </summary>
        internal SchemaValidator()
            : this(FileFormatVersions.Office2007)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SchemaValidator.
        /// </summary>
        /// <param name="fileFormat">The target Open XML format.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the "fileFormat" parameter is not FileFormat.Office2007, FileFormat.Office2010 or FileFormat.O15.</exception>
        internal SchemaValidator(FileFormatVersions fileFormat)
        {
            if (fileFormat == FileFormatVersions.Office2007)
            {
                this._sdbSchemaDatas = SdbSchemaDatas.GetOffice2007SchemaDatas();
            }
            else if(fileFormat == FileFormatVersions.Office2010)
            {
                this._sdbSchemaDatas = SdbSchemaDatas.GetOffice2010SchemaDatas();
            }
            else if (fileFormat == FileFormatVersions.Office2013)
            {
                this._sdbSchemaDatas = SdbSchemaDatas.GetOffice2013SchemaDatas();
            }
            else
            {
                string message = String.Format(System.Globalization.CultureInfo.CurrentUICulture,
                                                    ExceptionMessages.FileFormatNotSupported,
                                                    fileFormat);
                throw new ArgumentOutOfRangeException(nameof(fileFormat), message);
            }

            this._schemaTypeValidator = new SchemaTypeValidator(this._sdbSchemaDatas);
#if DEBUG
            this._fileFormat = fileFormat;
#endif
        }

        /// <summary>
        /// Validate the DOM tree under the specified OpenXmlElement in the context.
        /// </summary>
        /// <param name="validationContext"></param>
        internal void Validate(ValidationContext validationContext)
        {
            Debug.Assert(validationContext != null);
            Debug.Assert(validationContext.Element != null);

            this._stopValidating = false;

            var openxmlElement = validationContext.Element;

            Debug.Assert(!(openxmlElement is OpenXmlUnknownElement || openxmlElement is OpenXmlMiscNode));

            // Can not just validate AlternateContent / Choice / Fallback
            // Debug.Assert(!(openxmlElement is AlternateContent))
            Debug.Assert(!(openxmlElement is AlternateContentChoice || openxmlElement is AlternateContentFallback));

            ValidationTraverser.ValidatingTraverse(validationContext, this.ValidateElement, null, this.StopSignal);

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
            this._schemaTypeValidator.Validate(validationContext);
        }

        private bool StopSignal(ValidationContext validationContext)
        {
            return this._stopValidating;
        }

        #region ICancelable Members

        /// <summary>
        /// On cancel event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public void OnCancel(object sender, EventArgs eventArgs)
        {
            this._stopValidating = true;
        }

        #endregion
    }
}
