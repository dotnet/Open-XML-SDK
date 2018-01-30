﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// DocumentValidator - defines a base class for document validator.
    /// </summary>
    internal sealed class DocumentValidator
    {
        private readonly SchemaValidator _schemaValidator;
        private readonly SemanticValidator _semanticValidator;
        private readonly ValidationSettings _validationSettings;

        /// <summary>
        /// Initializes a new instance of the DocumentValidator.
        /// </summary>
        /// <param name="settings">The validation settings.</param>
        /// <param name="schemaValidator">The schema validator to be used for schema validation.</param>
        /// <param name="semanticValidator">The semantic validator to be used for semantic validation.</param>
        public DocumentValidator(ValidationSettings settings, SchemaValidator schemaValidator, SemanticValidator semanticValidator)
        {
            _schemaValidator = schemaValidator;
            _semanticValidator = semanticValidator;
            _validationSettings = settings;
        }

        /// <summary>
        /// Validat the specified document.
        /// </summary>
        /// <param name="document">The document to be validated.</param>
        /// <returns>Return results in ValidationResult.</returns>
        public ValidationResult Validate(OpenXmlPackage document)
        {
            var result = CreateValidationResult();
            var context = CreateValidationContext(result);

            context.Package = document;

            // integrate the package validation.
            ValidatePackageStructure(document, result);

            foreach (var part in PartsToBeValidated(document))
            {
                // traverse from the part root element (by DOM or by Reader) in post-order
                // that means validate the children firt, then validate the parent
                // the validation engine call bookkeep information

                ValidatePart(part, context, result);
            }

            return result;
        }

        /// <summary>
        /// Validate the specified part.
        /// </summary>
        /// <param name="part">The OpenXmlPart to be validated.</param>
        /// <returns></returns>
        public ValidationResult Validate(OpenXmlPart part)
        {
            var result = CreateValidationResult();
            var context = CreateValidationContext(result);

            ValidatePart(part, context, result);

            return result;
        }

        private void ValidatePart(OpenXmlPart part, ValidationContext context, ValidationResult result)
        {
            // if the part is not defined in the specified version, then do not validate the content.
            if (!part.IsInVersion(_validationSettings.FileFormat))
            {
                return;
            }

            /*******************
             * DOM traversal is not performance bottleneck.
             * Is this the good way that we separate the schema validtion and the semantics validation?
             *******************/

            try
            {
                // Must be called before the call to PartRootElement { get; }
                bool partRootElementLoaded = part.IsRootElementLoaded;

                // schema validation
                context.Part = part;
                context.Element = part.PartRootElement;

                var lastErrorCount = result.Errors.Count;

                if (part.PartRootElement != null)
                {
                    _schemaValidator.Validate(context);

                    context.Element = part.PartRootElement;
                    _semanticValidator.ClearConstraintState(SemanticValidationLevel.PartOnly);
                    _semanticValidator.Validate(context);
                }

                if (!partRootElementLoaded && result.Errors.Count == lastErrorCount)
                {
                    // No new errors in this part. Release the DOM to GC memary.
                    part.SetPartRootElementToNull();
                }
            }
            catch (System.Xml.XmlException e)
            {
                var errorInfo = new ValidationErrorInfo
                {
                    ErrorType = ValidationErrorType.Schema,
                    Id = "ExceptionError",
                    Part = part,
                    Path = new XmlPath(part),
                    Description = string.Format(CultureInfo.CurrentUICulture, ValidationResources.ExceptionError, e.Message)
                };

                result.AddError(errorInfo);
            }
        }

        private ValidationContext CreateValidationContext(ValidationResult result)
        {
            var context = new ValidationContext
            {
                FileFormat = _validationSettings.FileFormat
            };

            context.ValidationErrorEventHandler += result.OnValidationError;

            _semanticValidator.ClearConstraintState(SemanticValidationLevel.PackageOnly);

            return context;
        }

        private ValidationResult CreateValidationResult()
        {
            var result = new ValidationResult
            {
                Valid = true,
                MaxNumberOfErrors = _validationSettings.MaxNumberOfErrors
            };

            result.MaxNumberOfErrorsEventHandler += _schemaValidator.OnCancel;
            result.MaxNumberOfErrorsEventHandler += _semanticValidator.OnCancel;

            return result;
        }

        private static OpenXmlPart GetMainPart(OpenXmlPackage package)
        {
            if (null == package)
            {
                throw new ArgumentNullException(nameof(package));
            }

            if (package is WordprocessingDocument word)
            {
                return word.MainDocumentPart;
            }
            else if (package is SpreadsheetDocument spreadsheet)
            {
                return spreadsheet.WorkbookPart;
            }
            else if (package is PresentationDocument presentation)
            {
                return presentation.PresentationPart;
            }
            else
            {
                throw new System.IO.InvalidDataException(ExceptionMessages.UnknownPackage);
            }
        }

        /// <summary>
        /// Gets all the parts needs to be validated.
        /// </summary>
        private IEnumerable<OpenXmlPart> PartsToBeValidated(OpenXmlPackage package)
        {
            var mainPart = GetMainPart(package);
            if (mainPart != null)
            {
                var parts = new Dictionary<OpenXmlPart, bool>();
                package.FindAllReachableParts(parts);

                foreach (var part in parts.Keys)
                {
                    // Only validate the parts defined in the specified version.
                    // Example: do not validate new Office2010 parts if the FileFormat is Office2007.
                    if (part.IsInVersion(_validationSettings.FileFormat))
                    {
                        yield return part;
                    }
                }
            }
        }

        private void ValidatePackageStructure(OpenXmlPackage document, ValidationResult result)
        {
            var documentName = document.GetType().Name;
#pragma warning disable CS0618 // Type or member is obsolete
            var packageValidationSettings = new OpenXmlPackageValidationSettings();
#pragma warning restore CS0618 // Type or member is obsolete

            packageValidationSettings.EventHandler += OnPackageValidationError;

            document.Validate(packageValidationSettings, _validationSettings.FileFormat);

#pragma warning disable CS0618 // Type or member is obsolete
            void OnPackageValidationError(Object sender, OpenXmlPackageValidationEventArgs e)
#pragma warning restore CS0618 // Type or member is obsolete
            {
                var errorInfo = new ValidationErrorInfo
                {
                    ErrorType = ValidationErrorType.Package,
                    Id = "Pkg_" + e.MessageId
                };

                string name;

                switch (errorInfo.Id)
                {
                    case "Pkg_PartIsNotAllowed":
                        Debug.Assert(e.SubPart != null);
                        name = e.Part != null ? GetPartNameAndUri(e.Part) : documentName;
                        errorInfo.Description = String.Format(CultureInfo.CurrentUICulture, ValidationResources.Pkg_PartIsNotAllowed, name, GetPartNameAndUri(e.SubPart));
                        break;

                    case "Pkg_RequiredPartDoNotExist":
                        errorInfo.Description = string.Format(CultureInfo.CurrentUICulture, ValidationResources.Pkg_RequiredPartDoNotExist, e.PartClassName);
                        break;

                    case "Pkg_OnlyOnePartAllowed":
                        name = e.Part != null ? GetPartNameAndUri(e.Part) : documentName;
                        errorInfo.Description = String.Format(CultureInfo.CurrentUICulture, ValidationResources.Pkg_OnlyOnePartAllowed, name, e.PartClassName);
#if DEBUG
                        Debug.Assert(e.SubPart != null);
                        errorInfo.RelatedPart = e.SubPart;
#endif
                        break;

                    case "Pkg_ExtendedPartIsOpenXmlPart":
                        Debug.Assert(e.SubPart != null);
                        errorInfo.Description = string.Format(CultureInfo.CurrentUICulture, ValidationResources.Pkg_ExtendedPartIsOpenXmlPart, GetPartUri(e.SubPart));
                        break;

                    case "Pkg_DataPartReferenceIsNotAllowed":
                        Debug.Assert(e.DataPartReferenceRelationship != null);
                        name = e.Part != null ? GetPartNameAndUri(e.Part) : documentName;
                        errorInfo.Description = String.Format(CultureInfo.CurrentUICulture, ValidationResources.Pkg_PartIsNotAllowed, name, e.DataPartReferenceRelationship.Uri);
                        break;

                    case "Pkg_InvalidContentTypePart":  // won't get this error.
                    default:
                        Debug.Assert(false, "Invalid package validation event.");
                        break;
                }

                if (e.Part != null)
                {
                    errorInfo.Part = e.Part;
                    errorInfo.Path = new XmlPath(e.Part);
                }
                errorInfo.RelatedPart = e.SubPart;

                result.AddError(errorInfo);
            }
        }

        private static string GetPartNameAndUri(OpenXmlPart part)
        {
            Debug.Assert(part != null);
            string partClassName = part.GetType().Name;
            // Example: WordprocessingCommentsPart{/word/comments.xml}
            return string.Format(CultureInfo.CurrentUICulture, "{0}{1}{2}{3}", partClassName, '{', part.Uri, '}');
        }

        private static string GetPartUri(OpenXmlPart part)
        {
            Debug.Assert(part != null);
            // Example: WordprocessingCommentsPart{/word/comments.xml}
            return string.Format(CultureInfo.CurrentUICulture, "{0}{1}{2}", '{', part.Uri, '}');
        }
    }
}
