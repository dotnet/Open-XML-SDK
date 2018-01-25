// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Defines the OpenXmlValidator.
    /// </summary>
    public class OpenXmlValidator
    {
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
        private DocumentValidator _spreadsheetDocumentValidator;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DocumentValidator _wordprocessingDocumentValidator;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DocumentValidator _presentationDocumentValidator;

        private SchemaValidator SchemaValidator
        {
            get
            {
                if (_schemaValidator == null)
                {
                    _schemaValidator = new SchemaValidator(_settings.FileFormat);
                }
                return _schemaValidator;
            }
        }

        private SemanticValidator DocSmenaticValidator
        {
            get
            {
                if (_docSmenaticValidator == null)
                {
                    _docSmenaticValidator = new SemanticValidator(_settings.FileFormat, ApplicationType.Word);
                }

                return _docSmenaticValidator;
            }
        }

        private SemanticValidator XlsSemanticValidator
        {
            get
            {
                if (_xlsSemanticValidator == null)
                {
                    _xlsSemanticValidator = new SemanticValidator(_settings.FileFormat, ApplicationType.Excel);
                }

                return _xlsSemanticValidator;
            }
        }

        private SemanticValidator PptSemanticValidator
        {
            get
            {
                if (_pptSemanticValidator == null)
                {
                    _pptSemanticValidator = new SemanticValidator(_settings.FileFormat, ApplicationType.PowerPoint);
                }

                return _pptSemanticValidator;
            }
        }

        private SemanticValidator FullSemanticValidator
        {
            get
            {
                if (_fullSemanticValidator == null)
                {
                    _fullSemanticValidator = new SemanticValidator(_settings.FileFormat, ApplicationType.All);
                }

                return _fullSemanticValidator;
            }
        }

        private DocumentValidator SpreadsheetDocumentValidator
        {
            get
            {
                if (_spreadsheetDocumentValidator == null)
                {
                    _spreadsheetDocumentValidator = new DocumentValidator(_settings, SchemaValidator, XlsSemanticValidator);
                }
                return _spreadsheetDocumentValidator;
            }
        }

        private DocumentValidator WordprocessingDocumentValidator
        {
            get
            {
                if (_wordprocessingDocumentValidator == null)
                {
                    _wordprocessingDocumentValidator = new DocumentValidator(_settings, SchemaValidator, DocSmenaticValidator);
                }
                return _wordprocessingDocumentValidator;
            }
        }

        private DocumentValidator PresentationDocumentValidator
        {
            get
            {
                if (_presentationDocumentValidator == null)
                {
                    _presentationDocumentValidator = new DocumentValidator(_settings, SchemaValidator, PptSemanticValidator);
                }
                return _presentationDocumentValidator;
            }
        }

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
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the <paramref name="fileFormat"/> parameter is not a known format.</exception>
        public OpenXmlValidator(FileFormatVersions fileFormat)
        {
            fileFormat.ThrowExceptionIfFileFormatNotSupported(nameof(fileFormat));
            _settings = new ValidationSettings(fileFormat);
        }

        /// <summary>
        /// Gets the target file format to be validated against.
        /// </summary>
        public FileFormatVersions FileFormat => _settings.FileFormat;

        /// <summary>
        /// Gets or sets the maximum number of errors the OpenXmlValidator will return.
        /// Default is 1000. A zero (0) value means no limitation.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throw when the value set is less than zero.</exception>
        public int MaxNumberOfErrors
        {
            get { return _settings.MaxNumberOfErrors; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _settings.MaxNumberOfErrors = value;
            }
        }

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
                throw new ArgumentNullException(nameof(openXmlPackage));
            }

            if (openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess &&
                openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormat)
            {
                string exceptionMessage = string.Format(System.Globalization.CultureInfo.CurrentUICulture,
                    ExceptionMessages.DocumentFileFormatVersionMismatch,
                    openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions, FileFormat);

                throw new InvalidOperationException(exceptionMessage);
            }

            return ValidateCore(openXmlPackage);
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
                throw new ArgumentNullException(nameof(openXmlPart));
            }

            var openXmlPackage = openXmlPart.OpenXmlPackage;
            if (openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess &&
                openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormat)
            {
                string exceptionMessage = string.Format(System.Globalization.CultureInfo.CurrentUICulture,
                    ExceptionMessages.DocumentFileFormatVersionMismatch,
                    openXmlPackage.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions, FileFormat);

                throw new InvalidOperationException(exceptionMessage);
            }

            if (!openXmlPart.IsInVersion(FileFormat))
            {
                if (openXmlPart is ExtendedPart)
                {
                    throw new InvalidOperationException(ExceptionMessages.PartNotInVersion);
                }
                else
                {
                    // All Office 2007 and 2010 parts are allowed in Office 2013.
                    switch (FileFormat)
                    {
                        case FileFormatVersions.Office2007:
                            throw new InvalidOperationException(ExceptionMessages.PartIsNotInOffice2007);
                        case FileFormatVersions.Office2010:
                            throw new InvalidOperationException(ExceptionMessages.PartIsNotInOffice2010);
                        case FileFormatVersions.Office2013: // Falls through...
                        default:
                            throw new InvalidOperationException(ExceptionMessages.PartIsNotInOffice2013);
                    }
                }
            }

            return ValidateCore(openXmlPart);
        }

        private IEnumerable<ValidationErrorInfo> ValidateCore(OpenXmlPart part)
        {
            var validator = GetValidator(part.OpenXmlPackage);
            var result = validator.Validate(part);

            return YieldResult(result);
        }

        private IEnumerable<ValidationErrorInfo> ValidateCore(OpenXmlPackage package)
        {
            var validator = GetValidator(package);
            var result = validator.Validate(package);

            return YieldResult(result);
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
                throw new ArgumentNullException(nameof(openXmlElement));
            }

            if (openXmlElement is OpenXmlUnknownElement)
            {
                throw new ArgumentOutOfRangeException(nameof(openXmlElement), ExceptionMessages.CannotValidateUnknownElement);
            }

            if (openXmlElement is OpenXmlMiscNode)
            {
                throw new ArgumentOutOfRangeException(nameof(openXmlElement), ExceptionMessages.CannotValidateMiscNode);
            }

            if (openXmlElement is AlternateContent ||
                openXmlElement is AlternateContentChoice ||
                openXmlElement is AlternateContentFallback)
            {
                throw new ArgumentOutOfRangeException(nameof(openXmlElement), ExceptionMessages.CannotValidateAcbElement);
            }

            if (!openXmlElement.IsInVersion(FileFormat))
            {
                switch (FileFormat)
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
            validationResult.MaxNumberOfErrors = _settings.MaxNumberOfErrors;
            validationResult.MaxNumberOfErrorsEventHandler += SchemaValidator.OnCancel;
            var validationContext = new ValidationContext();
            // this.ValidationContext.Settings = new ValidationSettings(this.FileFormat, this.SchemaOnly);
            validationContext.FileFormat = FileFormat;
            validationContext.ValidationErrorEventHandler += validationResult.OnValidationError;
            validationContext.Element = openXmlElement;
            // Do NOT use "yield return" in this method, as "yield return" are deferred executed.
            // Otherwise, the null check is not performed when the method is called, but rather, when the returned enumerator is moved for the first time.
            // That means that the exception isn't thrown until possibly far, far away from the actual site of the error, which is potentially confusing.

            SchemaValidator.Validate(validationContext);

            validationContext.Element = openXmlElement;
            FullSemanticValidator.Validate(validationContext);

            return YieldResult(validationResult);
        }

        private DocumentValidator GetValidator(OpenXmlPackage package)
        {
            if (package is SpreadsheetDocument)
            {
                return SpreadsheetDocumentValidator;
            }
            else if (package is WordprocessingDocument wordprocessing)
            {
                return WordprocessingDocumentValidator;
            }
            else if (package is PresentationDocument presentation)
            {
                return PresentationDocumentValidator;
            }

            throw new System.IO.InvalidDataException(ExceptionMessages.UnknownPackage);
        }

        private static IEnumerable<ValidationErrorInfo> YieldResult(ValidationResult validationResult)
        {
            if (validationResult != null && validationResult.Valid == false)
            {
                foreach (var error in validationResult.Errors)
                {
                    yield return error;
                }
            }
        }
    }
}
