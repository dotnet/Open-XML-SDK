// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Internal.SchemaValidation;
using DocumentFormat.OpenXml.Internal.SemanticValidation;

namespace DocumentFormat.OpenXml.Validation
{

    /// <summary>
    /// Implement this interface when the operation is cancelable
    /// </summary>
    internal interface ICancelable
    {
        /// <summary>
        /// On cancel event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        void OnCancel(object sender, EventArgs eventArgs);
    }

    /// <summary>
    /// DocumentValidator - defines a base class for document validator.
    /// </summary>
    internal abstract class DocumentValidator
    {
        /// <summary>
        /// Gets the schema validator for schema validation.
        /// </summary>
        internal SchemaValidator SchemaValidator
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the semantic validator for semantic validation.
        /// </summary>
        internal SemanticValidator SemanticValidator
        {
            get;
            private set;
        }

        /// <summary>
        /// The validation settings.
        /// </summary>
        protected ValidationSettings ValidationSettings
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the DocumentValidator.
        /// </summary>
        /// <param name="settings">The validation settings.</param>
        /// <param name="schemaValidator">The schema validator to be used for schema validation.</param>
        /// <param name="semanticValidator">The semantic validator to be used for semantic validation.</param>
        internal DocumentValidator(ValidationSettings settings, SchemaValidator schemaValidator, SemanticValidator semanticValidator)
        {
            this.SchemaValidator = schemaValidator;
            this.SemanticValidator = semanticValidator;
            this.ValidationSettings = settings;
        }

        /// <summary>
        /// Validat the specified document.
        /// </summary>
        /// <param name="document">The document to be validated.</param>
        /// <returns>Return results in ValidationResult.</returns>
        internal ValidationResult Validate(OpenXmlPackage document)
        {
            this.TargetDocument = document;

            this.PrepareValidation();

            this.ValidationContext.Package = document;

            // integrate the package validation.
            ValidatePackageStructure(document);

            foreach (var part in PartsToBeValidated)
            {
                // travser from the part root element (by DOM or by Reader) in post-order 
                // that means validate the children firt, then validate the parent
                // the validation engine call bookkeep information 

                this.ValidatePart(part);

            }

            this.FinishValidation();

            return this.ValidationResult;
        }

        /// <summary>
        /// Validate the specified part.
        /// </summary>
        /// <param name="part">The OpenXmlPart to be validated.</param>
        /// <returns></returns>
        internal ValidationResult Validate(OpenXmlPart part)
        {
            this.PrepareValidation();

            this.ValidatePart(part);

            return this.ValidationResult;
        }

        /// <summary>
        /// Validate the specified part.
        /// </summary>
        /// <param name="part">The OpenXmlPart to be validated.</param>
        internal void ValidatePart(OpenXmlPart part)
        {
            // if the part is not defined in the specified version, then do not validate the content.
            if ( ! part.IsInVersion(this.ValidationSettings.FileFormat))
            {
                return;
            }

            /*******************
             * DOM traverse is not performance bottleneck.
             * Is this the good way that we separate the schema validtion and the semantics validation?
             *******************/

            try
            {
                // Must be called before the call to PartRootElement { get; }
                bool partRootElementLoaded = part.IsRootElementLoaded;

                // schema validation
                this.ValidationContext.Part = part;
                this.ValidationContext.Element = part.PartRootElement;

                var lastErrorCount = this.ValidationResult.Errors.Count;

                if (part.PartRootElement != null)
                {
                    this.SchemaValidator.Validate(this.ValidationContext);

                    this.ValidationContext.Element = part.PartRootElement;
                    this.SemanticValidator.ClearConstraintState(SemanticValidationLevel.PartOnly);
                    this.SemanticValidator.Validate(this.ValidationContext);
                }

                if (!partRootElementLoaded &&
                    this.ValidationResult.Errors.Count == lastErrorCount)
                {
                    // No new errors in this part. Release the DOM to GC memary.
                    part.SetPartRootElementToNull();
                }
            }
            catch (System.Xml.XmlException e)
            {
                ValidationErrorInfo errorInfo = new ValidationErrorInfo();
                errorInfo.ErrorType = ValidationErrorType.Schema;
                errorInfo.Id = "ExceptionError";
                errorInfo.Part = part;
                errorInfo.Path = new XmlPath(part);
                errorInfo.Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture,
                    ValidationResources.ExceptionError, e.Message);
                this.ValidationResult.AddError(errorInfo);
            }
        }

        #region protected members

        /// <summary>
        /// Gets or sets the validation context.
        /// </summary>
        protected ValidationContext ValidationContext { get; set; }

        /// <summary>
        /// Gets or set the validtion result.
        /// </summary>
        protected ValidationResult ValidationResult { get; set; }

        /// <summary>
        /// Gets or sets the target document to be validated.
        /// </summary>
        protected abstract OpenXmlPackage TargetDocument { get; set; }
        
        /// <summary>
        /// Returns all the parts needs to be validated.
        /// </summary>
        protected abstract IEnumerable<OpenXmlPart> PartsToBeValidated { get; }

        /// <summary>
        /// Init
        /// </summary>
        /// <returns></returns>
        protected virtual bool PrepareValidation()
        {
            InitValidationContext();

            this.SemanticValidator.ClearConstraintState(SemanticValidationLevel.PackageOnly);
            
            return true;
        }

        protected void InitValidationContext()
        {
            this.ValidationResult = new ValidationResult();
            this.ValidationResult.Valid = true;
            this.ValidationResult.MaxNumberOfErrors = this.ValidationSettings.MaxNumberOfErrors;
            this.ValidationResult.MaxNumberOfErrorsEventHandler += this.SchemaValidator.OnCancel;
            this.ValidationResult.MaxNumberOfErrorsEventHandler += this.SemanticValidator.OnCancel;
            this.ValidationContext = new ValidationContext();
            // this.ValidationContext.Settings = new ValidationSettings(this.FileFormat, this.SchemaOnly);
            this.ValidationContext.FileFormat = this.ValidationSettings.FileFormat; ;
            this.ValidationContext.ValidationErrorEventHandler += this.ValidationResult.OnValidationError;
        }

        /// <summary>
        /// Do final work.
        /// </summary>
        /// <returns></returns>
        protected virtual bool FinishValidation()
        {
            return true;
        }

        #endregion

        #region private methods

#pragma warning disable 0618 // CS0618: A class member was marked with the Obsolete attribute, such that a warning will be issued when the class member is referenced.

        private void ValidatePackageStructure(OpenXmlPackage document)
        {
            OpenXmlPackageValidationSettings packageValidationSettings = new OpenXmlPackageValidationSettings();

            packageValidationSettings.EventHandler += this.OnPackageValidationError;

            document.Validate(packageValidationSettings, this.ValidationSettings.FileFormat);
            
            return;
        }

        private void OnPackageValidationError(Object sender, OpenXmlPackageValidationEventArgs e)
        {            
            ValidationErrorInfo errorInfo = new ValidationErrorInfo();
            errorInfo.ErrorType = ValidationErrorType.Package;
            errorInfo.Id = "Pkg_" + e.MessageId;

            string name;

            switch (errorInfo.Id)
            {
                case "Pkg_PartIsNotAllowed":
                    Debug.Assert(e.SubPart != null);
                    name = e.Part != null ? GetPartNameAndUri(e.Part) : GetDocumentName(this.TargetDocument);
                    errorInfo.Description = String.Format(CultureInfo.CurrentUICulture, ValidationResources.Pkg_PartIsNotAllowed, name, GetPartNameAndUri(e.SubPart));
                    break;

                case "Pkg_RequiredPartDoNotExist":
                    errorInfo.Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture,
                                                ValidationResources.Pkg_RequiredPartDoNotExist, e.PartClassName);
                    break;

                case "Pkg_OnlyOnePartAllowed":
                    name = e.Part != null ? GetPartNameAndUri(e.Part) : GetDocumentName(this.TargetDocument);
                    errorInfo.Description = String.Format(CultureInfo.CurrentUICulture, ValidationResources.Pkg_OnlyOnePartAllowed, name, e.PartClassName);
#if DEBUG
                    Debug.Assert(e.SubPart != null);
                    errorInfo.RelatedPart = e.SubPart;
#endif
                    break;

                case "Pkg_ExtendedPartIsOpenXmlPart":
                    Debug.Assert(e.SubPart != null);
                    errorInfo.Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture,
                                                ValidationResources.Pkg_ExtendedPartIsOpenXmlPart, GetPartUri(e.SubPart));
                    break;

                case "Pkg_DataPartReferenceIsNotAllowed":
                    Debug.Assert(e.DataPartReferenceRelationship != null);
                    name = e.Part != null ? GetPartNameAndUri(e.Part) : GetDocumentName(this.TargetDocument);
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

            this.ValidationResult.AddError(errorInfo);
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

        private static string GetDocumentName(OpenXmlPackage document)
        {
            return document.GetType().Name;
        }

        #endregion
    }
}
