// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Internal.SchemaValidation;
using DocumentFormat.OpenXml.Internal.SemanticValidation;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Defines the OpenXmlValidator.
    /// </summary>
    public class OpenXmlValidator
    {
        #region data fields

        private ValidationSettings _settings;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SchemaValidator _schemaValidator;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SemanticValidator _docSmenaticValidator;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SemanticValidator _xlsSemanticValidator;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SemanticValidator _pptSemanticValidator;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SemanticValidator _fullSemanticValidator;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SpreadsheetDocumentValidator _spreadsheetDocumentValidator;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private WordprocessingDocumentValidator _wordprocessingDocumentValidator;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PresentationDocumentValidator _presentationDocumentValidator;

        #endregion

        #region private properties

        /// <summary>
        /// Schema validator
        /// </summary>
        private SchemaValidator SchemaValidator
        {
            get
            {
                if (this._schemaValidator == null)
                {
                    this._schemaValidator = new SchemaValidator(this._settings.FileFormat);
                }
                return this._schemaValidator;
            }
        }

        private SemanticValidator DocSmenaticValidator
        {
            get
            {
                if (this._docSmenaticValidator == null)
                {
                    this._docSmenaticValidator = new SemanticValidator(this._settings.FileFormat, ApplicationType.Word);
                }
                
                return _docSmenaticValidator;
            }
        }

        private SemanticValidator XlsSemanticValidator
        {
            get
            {
                if (this._xlsSemanticValidator == null)
                {
                    this._xlsSemanticValidator = new SemanticValidator(this._settings.FileFormat, ApplicationType.Excel);
                }

                return _xlsSemanticValidator;
            }
        }

        private SemanticValidator PptSemanticValidator
        {
            get 
            {
                if (this._pptSemanticValidator == null)
                {
                    this._pptSemanticValidator = new SemanticValidator(this._settings.FileFormat, ApplicationType.PowerPoint);
                }

                return _pptSemanticValidator; 
            }
        }

        private SemanticValidator FullSemanticValidator
        {
            get
            {
                if (this._fullSemanticValidator == null)
                {
                    this._fullSemanticValidator = new SemanticValidator(this._settings.FileFormat, ApplicationType.All);
                }

                return _fullSemanticValidator;
            }
        }

        /// <summary>
        /// Gets the SpreadsheetDocumentValidator.
        /// </summary>
        private SpreadsheetDocumentValidator SpreadsheetDocumentValidator
        {
            get
            {
                if (this._spreadsheetDocumentValidator == null)
                {
                    this._spreadsheetDocumentValidator = new SpreadsheetDocumentValidator(this._settings, this.SchemaValidator, this.XlsSemanticValidator);
                }
                return this._spreadsheetDocumentValidator;
            }
        }

        /// <summary>
        /// Gets the WordprocessingDocumentValidator.
        /// </summary>
        private WordprocessingDocumentValidator WordprocessingDocumentValidator
        {
            get
            {
                if (this._wordprocessingDocumentValidator == null)
                {
                    this._wordprocessingDocumentValidator = new WordprocessingDocumentValidator(this._settings, this.SchemaValidator, this.DocSmenaticValidator);
                }
                return this._wordprocessingDocumentValidator;
            }
        }

        /// <summary>
        /// Gets the PresentationDocumentValidator.
        /// </summary>
        private PresentationDocumentValidator PresentationDocumentValidator
        {
            get
            {
                if (this._presentationDocumentValidator == null)
                {
                    this._presentationDocumentValidator = new PresentationDocumentValidator(this._settings, this.SchemaValidator, this.PptSemanticValidator);
                }
                return this._presentationDocumentValidator;
            }
        }

        #endregion

        #region public constructors

        /// <summary>
        /// Initializes a new instance of the OpenXmlValidator.
        /// </summary>
        /// <remarks>
        /// Default to FileFormat.Office2007.
        /// </remarks>
        public OpenXmlValidator()
            : this(FileFormatVersions.Office2007)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlValidator.
        /// </summary>
        /// <param name="fileFormat">The target filr format to be validated aginst.</param>
        /// <remarks>
        /// Default to FileFormat.Office2007.
        /// </remarks>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the "fileFormat" parameter is not FileFormat.Office2007, FileFormat.Office2010 or FileFormat.O15.</exception>
        public OpenXmlValidator(FileFormatVersions fileFormat)
        {
            fileFormat.ThrowExceptionIfFileFormatNotSupported("fileFormat");
            this._settings = new ValidationSettings(fileFormat);
        }

        #endregion

        #region public properties

        /// <summary>
        /// Gets the target file format to be validated against.
        /// </summary>
        public FileFormatVersions FileFormat
        {
            get { return this._settings.FileFormat; }
        }

        /// <summary>
        /// Gets or sets the maximum number of errors the OpenXmlValidator will return.
        /// Default is 1000. A zero (0) value means no limitation.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throw when the value set is less than zero.</exception>
        public int MaxNumberOfErrors
        {
            get { return this._settings.MaxNumberOfErrors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }

                this._settings.MaxNumberOfErrors = value;
            }
        }

        #endregion

        #region public methods

         /// <summary>
        /// Validates the specified document.
        /// </summary>
        /// <param name="openXmlPackage">The target WordprocessingDocument, SpreadsheetDocument or PresentationDocument.</param>
        /// <returns>A set of validation erros.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the "openXmlPackage" parameter is null.</exception>
        public IEnumerable<ValidationErrorInfo> Validate(OpenXmlPackage openXmlPackage)
        {
            if (openXmlPackage == null)
            {
                throw new ArgumentNullException("openXmlPackage");
            }

            if (openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess &&
                openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != this.FileFormat)
            {
                string exceptionMessage = string.Format(System.Globalization.CultureInfo.CurrentUICulture,
                    ExceptionMessages.DocumentFileFormatVersionMismatch,
                    openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions, this.FileFormat);

                throw new InvalidOperationException(exceptionMessage);
            }

            // Do NOT use "yield return" in this method, as "yield return" are deferred executed.
            // Otherwise, the null check is not performed when the method is called, but rather, when the returned enumerator is moved for the first time. 
            // That means that the exception isn't thrown until possibly far, far away from the actual site of the error, which is potentially confusing.

            ValidationResult validationResult = null;
            switch (DocumentTypeDetector.GetDocumentType(openXmlPackage))
            {
                case OpenXmlDocumentType.Spreadsheet:
                    validationResult = this.SpreadsheetDocumentValidator.Validate(openXmlPackage as SpreadsheetDocument);
                    break;

                case OpenXmlDocumentType.Wordprocessing:
                    validationResult = this.WordprocessingDocumentValidator.Validate(openXmlPackage as WordprocessingDocument);
                    break;

                case OpenXmlDocumentType.Presentation:
                    validationResult = this.PresentationDocumentValidator.Validate(openXmlPackage as PresentationDocument);
                    break;

                default:
                    throw new System.IO.InvalidDataException(ExceptionMessages.UnknownPackage);
            }

            return this.YieldResult(validationResult);
        }

        /// <summary>
        /// Validates the specified content in the OpenXmlPart.
        /// </summary>
        /// <param name="openXmlPart">The target OpenXmlPart.</param>
        /// <returns>A set of validation erros.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the "openXmlPart" parameter is null.</exception>
        /// <exception cref="InvalidOperationException">Throw when the specified part is not a defined part in the specified FileFormat version.</exception>
        public IEnumerable<ValidationErrorInfo> Validate(OpenXmlPart openXmlPart)
        {
            if (openXmlPart == null)
            {
                throw new ArgumentNullException("openXmlPart");
            }

            var openXmlPackage = openXmlPart.OpenXmlPackage;
            if (openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess &&
                openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != this.FileFormat)
            {
                string exceptionMessage = string.Format(System.Globalization.CultureInfo.CurrentUICulture,
                    ExceptionMessages.DocumentFileFormatVersionMismatch,
                    openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions, this.FileFormat);

                throw new InvalidOperationException(exceptionMessage);
            }

            if (!openXmlPart.IsInVersion(this.FileFormat))
            {
                if (openXmlPart is ExtendedPart)
                {
                    throw new InvalidOperationException(ExceptionMessages.PartNotInVersion);
                }
                else
                {
                    string strMessage;

                    // All Office 2007 and 2010 parts are allowed in Office 2013.

                    switch (this.FileFormat)
                    {
                        case FileFormatVersions.Office2007:
                            strMessage = ExceptionMessages.PartIsNotInOffice2007;
                            break;

                        case FileFormatVersions.Office2010:
                            strMessage = ExceptionMessages.PartIsNotInOffice2010;
                            break;

                        case FileFormatVersions.Office2013: // Falls through...
                        default:
                            strMessage = ExceptionMessages.PartIsNotInOffice2013;
                            break;
                    }

                    throw new InvalidOperationException(strMessage);
                }
            }

            // Do NOT use "yield return" in this method, as "yield return" are deferred executed.
            // Otherwise, the null check is not performed when the method is called, but rather, when the returned enumerator is moved for the first time. 
            // That means that the exception isn't thrown until possibly far, far away from the actual site of the error, which is potentially confusing.

            OpenXmlPackage package = openXmlPart.OpenXmlPackage;
            Debug.Assert(package != null);

            ValidationResult validationResult = null;
            switch (DocumentTypeDetector.GetDocumentType(package))
            {
                case OpenXmlDocumentType.Spreadsheet:
                    validationResult = this.SpreadsheetDocumentValidator.Validate(openXmlPart);
                    break;

                case OpenXmlDocumentType.Wordprocessing:
                    validationResult = this.WordprocessingDocumentValidator.Validate(openXmlPart);
                    break;

                case OpenXmlDocumentType.Presentation:
                    validationResult = this.PresentationDocumentValidator.Validate(openXmlPart);
                    break;

                default:
                    throw new System.IO.InvalidDataException(ExceptionMessages.UnknownPackage);
            }

            return this.YieldResult(validationResult);
        }


        /// <summary>
        /// Validates the specified element.
        /// </summary>
        /// <param name="openXmlElement">The target OpenXmlElement.</param>
        /// <returns>A set of validation erros.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the "openXmlElement" parameter is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the "openXmlElement" is type of OpenXmlUnknownElement, OpenXmlMiscNode, AlternateContent, AlternateContentChoice or AlternateContentFallback.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the "openXmlElement" is not defined in the specified FileFormat.</exception>
        public IEnumerable<ValidationErrorInfo> Validate(OpenXmlElement openXmlElement)
        {
            if (openXmlElement == null)
            {
                throw new ArgumentNullException("openXmlElement");
            }

            if (openXmlElement is OpenXmlUnknownElement)
            {
                throw new ArgumentOutOfRangeException("openXmlElement", ExceptionMessages.CannotValidateUnknownElement);
            }

            if (openXmlElement is OpenXmlMiscNode)
            {
                throw new ArgumentOutOfRangeException("openXmlElement", ExceptionMessages.CannotValidateMiscNode);
            }

            if (openXmlElement is AlternateContent ||
                openXmlElement is AlternateContentChoice ||
                openXmlElement is AlternateContentFallback)
            {
                throw new ArgumentOutOfRangeException("openXmlElement", ExceptionMessages.CannotValidateAcbElement);
            }

            if (! openXmlElement.IsInVersion(this.FileFormat))
            {
                switch (this.FileFormat)
                {
                    case FileFormatVersions.Office2007:
                        throw new InvalidOperationException(ExceptionMessages.ElementIsNotInOffice2007);

                    case FileFormatVersions.Office2010:
                        throw new InvalidOperationException(ExceptionMessages.ElementIsNotInOffice2010);

                    case FileFormatVersions.Office2013:
                        throw new InvalidOperationException(ExceptionMessages.ElementIsNotInOffice2013);
                }
            }

            // TODO: if the FileFormat is Office2007, and the element is only in Office2010 and O15.
            // then this method should throw exceptions.

            var validationResult = new ValidationResult();
            validationResult.Valid = true;
            validationResult.MaxNumberOfErrors = this._settings.MaxNumberOfErrors;
            validationResult.MaxNumberOfErrorsEventHandler += this.SchemaValidator.OnCancel;
            var validationContext = new ValidationContext();
            // this.ValidationContext.Settings = new ValidationSettings(this.FileFormat, this.SchemaOnly);
            validationContext.FileFormat = this.FileFormat;
            validationContext.ValidationErrorEventHandler += validationResult.OnValidationError;
            validationContext.Element = openXmlElement;
            // Do NOT use "yield return" in this method, as "yield return" are deferred executed.
            // Otherwise, the null check is not performed when the method is called, but rather, when the returned enumerator is moved for the first time. 
            // That means that the exception isn't thrown until possibly far, far away from the actual site of the error, which is potentially confusing.

            this.SchemaValidator.Validate(validationContext);

            validationContext.Element = openXmlElement;
            this.FullSemanticValidator.Validate(validationContext);
            
            return this.YieldResult(validationResult);
        }

        #endregion

        #region private methods

        ///// <summary>
        ///// Validate the specified document.
        ///// </summary>
        ///// <param name="stream">The document stream.</param>
        ///// <returns>A set of validation erros.</returns>
        //private IEnumerable<ValidationErrorInfo> ValidateCore(Stream stream)
        //{
        //    yield break;
        //}

        ///// <summary>
        ///// Validate the specified document.
        ///// </summary>
        ///// <param name="openXmlPackage">The target OpenXmlPackage.</param>
        ///// <returns>A set of validation erros.</returns>
        //private IEnumerable<ValidationErrorInfo> ValidateCore(OpenXmlPackage openXmlPackage)
        //{
        //    yield break;
        //}

        ///// <summary>
        ///// Validate the specified content in the OpenXmlPart.
        ///// </summary>
        ///// <param name="OpenXmlPart">The target OpenXmlPart.</param>
        ///// <returns>A set of validation erros.</returns>
        //private IEnumerable<ValidationErrorInfo> ValidateCore(OpenXmlPart openXmlPart)
        //{
        //    yield break;
        //}


        ///// <summary>
        ///// Validate the specified element.
        ///// </summary>
        ///// <param name="openXmlElement">The target OpenXmlElement.</param>
        ///// <returns>A set of validation erros.</returns>
        //private IEnumerable<ValidationErrorInfo> ValidateCore(OpenXmlElement openXmlElement)
        //{
        //    var validationResult = this.SchemaValidator.Validate(openXmlElement);
        //    return this.YieldResult(validationResult);
        //}

        private IEnumerable<ValidationErrorInfo> YieldResult(ValidationResult validationResult)
        {
            if (validationResult != null && validationResult.Valid == false)
            {
                foreach (var error in validationResult.Errors)
                {
                    yield return error;
                }
            }
        }

        #endregion
    }
}
