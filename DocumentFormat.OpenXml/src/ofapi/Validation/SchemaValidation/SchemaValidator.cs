// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Diagnostics;
using System.Globalization;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    /// <summary>
    /// Schema validator.
    /// </summary>
    internal class SchemaValidator : ICancelable
    {
        private SdbSchemaDatas _sdbSchemaDatas;
        private SchemaTypeValidator _schemaTypeValidator;
#if DEBUG
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
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
                throw new ArgumentOutOfRangeException("fileFormat", message);
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

    static class ValidationContextExtension
    {
        #region error building methods

        // helper methods to compose a  ValidationErrorInfo for schema validtion error.
        internal static ValidationErrorInfo ComposeSchemaValidationError(this ValidationContext validationContext, OpenXmlElement element, OpenXmlElement child, 
                                                       string messageId, params string[] args)
        {
            return ComposeValidationError(validationContext, ValidationErrorType.Schema, element, child, messageId, args);
        }

        // helper methods to compose a  ValidationErrorInfo for MC validation error.
        internal static ValidationErrorInfo ComposeMcValidationError(this ValidationContext validationContext, OpenXmlElement element, 
                                                       string messageId, params string[] args)
        {
            return ComposeValidationError(validationContext, ValidationErrorType.MarkupCompatibility, element, null, messageId, args);
        }

        internal static ValidationErrorInfo ComposeValidationError(this ValidationContext validationContext, ValidationErrorType errorType, OpenXmlElement element, OpenXmlElement child, 
                                                       string messageId, params string[] args)
        {
            ValidationErrorInfo errorInfo = new ValidationErrorInfo()
            {
                ErrorType = errorType,
                Part = validationContext.Part,
                Node = element,
                Id = messageId,
                RelatedNode = child,
                Description = string.Format(CultureInfo.CurrentUICulture, ValidationResources.ResourceManager.GetString(messageId), args)
            };

            return errorInfo;
        }

        #endregion
    }
}
