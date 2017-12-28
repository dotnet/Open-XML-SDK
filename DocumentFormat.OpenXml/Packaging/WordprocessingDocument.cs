// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
    /// </summary>
    public class WordprocessingDocument : OpenXmlPackage
    {
        private static Dictionary<string, PartConstraintRule> _partConstraint;
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

        /// <summary>
        /// Gets part constraint data.
        /// </summary>
        /// <returns>The constraint data of the part.</returns>
        internal sealed override IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint == null)
            {
                Dictionary<string, PartConstraintRule> tempData = new Dictionary<string, PartConstraintRule>();
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", new PartConstraintRule("MainDocumentPart", null, true, false, FileFormatVersions.Office2007.AndLater()));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties", new PartConstraintRule("CoreFilePropertiesPart", CoreFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater()));
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties", new PartConstraintRule("ExtendedFilePropertiesPart", ExtendedFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater()));
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties", new PartConstraintRule("CustomFilePropertiesPart", CustomFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater()));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail", new PartConstraintRule("ThumbnailPart", null, false, false, FileFormatVersions.Office2007.AndLater()));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin", new PartConstraintRule("DigitalSignatureOriginPart", DigitalSignatureOriginPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater()));
                tempData.Add("http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization", new PartConstraintRule("QuickAccessToolbarCustomizationsPart", QuickAccessToolbarCustomizationsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater()));
                tempData.Add("http://schemas.microsoft.com/office/2006/relationships/ui/extensibility", new PartConstraintRule("RibbonExtensibilityPart", RibbonExtensibilityPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater()));
                tempData.Add("http://schemas.microsoft.com/office/2007/relationships/ui/extensibility", new PartConstraintRule("RibbonAndBackstageCustomizationsPart", RibbonAndBackstageCustomizationsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2010.AndLater()));
                tempData.Add("http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes", new PartConstraintRule("WebExTaskpanesPart", WebExTaskpanesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2013.AndLater()));
                _partConstraint = tempData;
            }
            return _partConstraint;
        }

        /// <summary>
        /// Gets the constraint rule of DataPartReferenceRelationship.
        /// </summary>
        /// <returns>The constraint data of the part.</returns>
        internal sealed override IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint == null)
            {
                Dictionary<string, PartConstraintRule> tempData = new Dictionary<string, PartConstraintRule>();

                _dataPartReferenceConstraint = tempData;
            }
            return _dataPartReferenceConstraint;
        }

        /// <summary>
        /// Gets the relationship type of the main part.
        /// </summary>
        internal sealed override string MainPartRelationshipType
        {
            get
            {
                return MainDocumentPart.RelationshipTypeConstant;
            }
        }

        private static Dictionary<WordprocessingDocumentType, string> _validMainPartContentType;

        private static Dictionary<WordprocessingDocumentType, string> MainPartContentTypes
        {
            get
            {
                if (_validMainPartContentType == null)
                {
                    Dictionary<WordprocessingDocumentType, string> tempData = new Dictionary<WordprocessingDocumentType, string>();
                    tempData.Add(WordprocessingDocumentType.Document, @"application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml");
                    tempData.Add(WordprocessingDocumentType.Template, @"application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml");
                    tempData.Add(WordprocessingDocumentType.MacroEnabledDocument, @"application/vnd.ms-word.document.macroEnabled.main+xml");
                    tempData.Add(WordprocessingDocumentType.MacroEnabledTemplate, @"application/vnd.ms-word.template.macroEnabledTemplate.main+xml");

                    _validMainPartContentType = tempData;
                }
                return _validMainPartContentType;
            }
        }

        /// <summary>
        /// Gets the list of valid content type for main part.
        /// </summary>
        internal sealed override ICollection<string> ValidMainPartContentTypes
        {
            get
            {
                return MainPartContentTypes.Values;
            }
        }

        /// <summary>
        /// Creates a WordprocessingDocument.
        /// </summary>
        protected WordprocessingDocument()
            : base()
        {
        }

        private WordprocessingDocumentType _documentType;
        /// <summary>
        /// Gets the type of the WordprocessingDocument.
        /// </summary>
        public WordprocessingDocumentType DocumentType
        {
            get
            {
                ThrowIfObjectDisposed();
                return this._documentType;
            }

            private set
            {
                ThrowIfObjectDisposed();
                this._documentType = value;
            }
        }

        private void UpdateDocumentTypeFromContentType()
        {
            if (this.MainPartContentType == null)
            {
                throw new InvalidOperationException();
            }

            foreach (KeyValuePair<WordprocessingDocumentType, string> types in MainPartContentTypes)
            {
                if (types.Value == this.MainPartContentType)
                {
                    this.DocumentType = types.Key;
                }
            }
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target WordprocessingDocument.</param>
        /// <param name="type">The type of the WordprocessingDocument.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        public static WordprocessingDocument Create(string path, WordprocessingDocumentType type)
        {
            return Create(path, type, true);
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to create the WordprocessingDocument.</param>
        /// <param name="type">The type of the WordprocessingDocument.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Write access.</exception>
        public static WordprocessingDocument Create(Stream stream, WordprocessingDocumentType type)
        {
            return Create(stream, type, true);
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="type">The type of the WordprocessingDocument.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Write access.</exception>
        public static WordprocessingDocument Create(Package package, WordprocessingDocumentType type)
        {
            return Create(package, type, true);
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target WordprocessingDocument.</param>
        /// <param name="type">The type of the WordprocessingDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        public static WordprocessingDocument Create(string path, WordprocessingDocumentType type, bool autoSave)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }
            WordprocessingDocument doc = new WordprocessingDocument();
            doc.DocumentType = type;
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = autoSave;
            doc.MainPartContentType = MainPartContentTypes[type];
            doc.CreateCore(path);
            return doc;
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to create the WordprocessingDocument.</param>
        /// <param name="type">The type of the WordprocessingDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Write access.</exception>
        public static WordprocessingDocument Create(Stream stream, WordprocessingDocumentType type, bool autoSave)
        {
            WordprocessingDocument doc = new WordprocessingDocument();
            doc.DocumentType = type;
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = autoSave;
            doc.MainPartContentType = MainPartContentTypes[type];
            doc.CreateCore(stream);
            return doc;
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package</param>
        /// <param name="type">The type of the WordprocessingDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Write access.</exception>
        public static WordprocessingDocument Create(Package package, WordprocessingDocumentType type, bool autoSave)
        {
            WordprocessingDocument doc = new WordprocessingDocument();
            doc.DocumentType = type;
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = autoSave;
            doc.MainPartContentType = MainPartContentTypes[type];
            doc.CreateCore(package);
            return doc;
        }

        /// <summary>
        /// Creates an editable WordprocessingDocument from a template, opened on
        /// a MemoryStream with expandable capacity. The template will be attached
        /// to the WordprocessingDocument.
        /// </summary>
        /// <remarks>
        /// Attaching the template has been chosen as the default behavior because
        /// this is also what happens when a document is created from a template
        /// (other than Normal.dotm) using Microsoft Word.
        /// </remarks>
        /// <param name="path">The path and file name of the template.</param>
        /// <returns>The new WordprocessingDocument based on and linked to the template.</returns>
        public static WordprocessingDocument CreateFromTemplate(string path)
        {
            return CreateFromTemplate(path, true);
        }

        /// <summary>
        /// Creates an editable WordprocessingDocument from a template, opened on
        /// a MemoryStream with expandable capacity.
        /// </summary>
        /// <remarks>
        /// This method is provided to offer the choice to not attach the template.
        /// When templates are attached in Microsoft Word, for example, the absolute
        /// path will be used in the relationship. These absolute paths are most
        /// often user-specific, however, so once documents are shared with other
        /// users, the relationship gets "broken" anyhow.
        /// </remarks>
        /// <param name="path">The path and file name of the template.</param>
        /// <param name="isTemplateAttached">True, if the template should be attached to the document.</param>
        /// <returns>The new WordprocessingDocument based on and linked to the template.</returns>
        public static WordprocessingDocument CreateFromTemplate(string path, bool isTemplateAttached)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            // Check extensions as the template must have a valid Word Open XML extension.
            string extension = Path.GetExtension(path);

            if (extension != ".docx" && extension != ".docm" && extension != ".dotx" && extension != ".dotm")
            {
                throw new ArgumentException($"Illegal template file: {path}", nameof(path));
            }

            using (WordprocessingDocument template = WordprocessingDocument.Open(path, false))
            {
                // We've opened the template in read-only mode to let multiple processes
                // open it without running into problems.
                WordprocessingDocument document = (WordprocessingDocument)template.Clone();

                // If the template is a document rather than a template, we are done.
                if (extension == ".docx" || extension == ".docm")
                    return document;

                // Otherwise, we'll have to do some more work.
                // Firstly, we'll change the document type from Template to Document.
                document.ChangeDocumentType(WordprocessingDocumentType.Document);

                // Secondly, we'll attach the template to our new document if so desired.
                if (isTemplateAttached)
                {
                    // Create a relative or absolute external relationship to the template.
                    // TODO: Check whether relative URIs are universally supported. They work in Office 2010.
                    MainDocumentPart mainDocumentPart = document.MainDocumentPart;
                    DocumentSettingsPart documentSettingsPart = mainDocumentPart.DocumentSettingsPart;
                    ExternalRelationship relationship = documentSettingsPart.AddExternalRelationship(
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/attachedTemplate",
                        new Uri(path, UriHelper.RelativeOrAbsolute));
                    documentSettingsPart.Settings.Append(
                        new DocumentFormat.OpenXml.Wordprocessing.AttachedTemplate() { Id = relationship.Id });
                }

                // We are done, so save and return.
                // TODO: Check whether it would be safe to return without saving.
                document.Save();
                return document;
            }
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target WordprocessingDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML WordprocessingDocument.</exception>
        public static WordprocessingDocument Open(string path, bool isEditable)
        {
            return WordprocessingDocument.Open(path, isEditable, new OpenSettings());
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to open the WordprocessingDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML WordprocessingDocument.</exception>
        public static WordprocessingDocument Open(System.IO.Stream stream, bool isEditable)
        {
            return WordprocessingDocument.Open(stream, isEditable, new OpenSettings());
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target WordprocessingDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML WordprocessingDocument.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static WordprocessingDocument Open(string path, bool isEditable, OpenSettings openSettings)
        {
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess
                && !openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions.Any())
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }
            WordprocessingDocument doc = new WordprocessingDocument();

            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = openSettings.AutoSave;
            doc.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode = openSettings.MarkupCompatibilityProcessSettings.ProcessMode;
            doc.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions = openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
            doc.MaxCharactersInPart = openSettings.MaxCharactersInPart;

            doc.OpenCore(path, isEditable);
            if (MainPartContentTypes[doc.DocumentType] != doc.MainPartContentType)
            {
                doc.UpdateDocumentTypeFromContentType();
            }
            return doc;
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to open the WordprocessingDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML WordprocessingDocument.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static WordprocessingDocument Open(System.IO.Stream stream, bool isEditable, OpenSettings openSettings)
        {
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess
                && !openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions.Any())
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }
            WordprocessingDocument doc = new WordprocessingDocument();
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = openSettings.AutoSave;
            doc.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode = openSettings.MarkupCompatibilityProcessSettings.ProcessMode;
            doc.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions = openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
            doc.MaxCharactersInPart = openSettings.MaxCharactersInPart;
            doc.OpenCore(stream, isEditable);
            if (MainPartContentTypes[doc.DocumentType] != doc.MainPartContentType)
            {
                doc.UpdateDocumentTypeFromContentType();
            }
            return doc;
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when package is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when package is not opened with read access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not a valid Open XML document.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static WordprocessingDocument Open(System.IO.Packaging.Package package, OpenSettings openSettings)
        {
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess
                && !openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions.Any())
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }
            WordprocessingDocument doc = new WordprocessingDocument();
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = openSettings.AutoSave;
            doc.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode = openSettings.MarkupCompatibilityProcessSettings.ProcessMode;
            doc.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions = openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
            doc.MaxCharactersInPart = openSettings.MaxCharactersInPart;
            doc.OpenCore(package);
            if (MainPartContentTypes[doc.DocumentType] != doc.MainPartContentType)
            {
                doc.UpdateDocumentTypeFromContentType();
            }
            return doc;
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML WordprocessingDocument.</exception>
        public static WordprocessingDocument Open(System.IO.Packaging.Package package)
        {
            return WordprocessingDocument.Open(package, new OpenSettings());
        }

        /// <summary>
        /// Changes the document type.
        /// </summary>
        /// <param name="newType">The new type of the document.</param>
        /// <remarks>The MainDocumentPart will be changed.</remarks>
        public void ChangeDocumentType(WordprocessingDocumentType newType)
        {
            ThrowIfObjectDisposed();

            if (newType == this.DocumentType)
            {
                // same type, just return
                return;
            }

            if (this.FileOpenAccess == FileAccess.Read)
            {
                throw new IOException(ExceptionMessages.PackageAccessModeIsReadonly);
            }

            WordprocessingDocumentType oldType = this.DocumentType;

            this.DocumentType = newType;
            this.MainPartContentType = MainPartContentTypes[newType];

            if (this.MainDocumentPart == null)
            {
                return;
            }

            try
            {
                ChangeDocumentTypeInternal<MainDocumentPart>();
            }
            catch (OpenXmlPackageException e)
            {
                if (e.Message == ExceptionMessages.CannotChangeDocumentType)
                {
                    this.DocumentType = oldType;
                    this.MainPartContentType = MainPartContentTypes[oldType];
                }
                throw;
            }
        }

        /// <summary>
        /// Creates an instance of OpenXmlPart according to the given relationship type.
        /// </summary>
        /// <param name="relationshipType">Relationship type.</param>
        /// <returns>An instance of OpenXmlPart.</returns>
        internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
        {
            this.ThrowIfObjectDisposed();

            if (relationshipType == null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }
            switch (relationshipType)
            {
                case MainDocumentPart.RelationshipTypeConstant:
                    return new MainDocumentPart();

                case CoreFilePropertiesPart.RelationshipTypeConstant:
                    return new CoreFilePropertiesPart();

                case ExtendedFilePropertiesPart.RelationshipTypeConstant:
                    return new ExtendedFilePropertiesPart();

                case CustomFilePropertiesPart.RelationshipTypeConstant:
                    return new CustomFilePropertiesPart();

                case ThumbnailPart.RelationshipTypeConstant:
                    return new ThumbnailPart();

                case DigitalSignatureOriginPart.RelationshipTypeConstant:
                    return new DigitalSignatureOriginPart();

                case QuickAccessToolbarCustomizationsPart.RelationshipTypeConstant:
                    return new QuickAccessToolbarCustomizationsPart();

                case RibbonExtensibilityPart.RelationshipTypeConstant:
                    return new RibbonExtensibilityPart();

                // Fix for O15:#258840
                case RibbonAndBackstageCustomizationsPart.RelationshipTypeConstant:
                    return new RibbonAndBackstageCustomizationsPart();

                case WebExTaskpanesPart.RelationshipTypeConstant:
                    return new WebExTaskpanesPart();
            }
            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }

        /// <summary>
        /// Adds a new part of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The class of the part.</typeparam>
        /// <param name="contentType">The content type of the part. Must match the defined content type if the part is fixed content type.</param>
        /// <param name="id">The relationship id. The id will be automaticly generated if this param is null.</param>
        /// <returns>The added part.</returns>
        /// <exception cref="OpenXmlPackageException">When the part is not allowed to be referenced by this part.</exception>
        /// <exception cref="ArgumentOutOfRangeException">When the part is fixed content type and the passed in contentType does not match the defined content type.</exception>
        /// <exception cref="ArgumentNullException">Thrown when "contentType" is null reference.</exception>
        /// <remarks>Mainly used for adding not-fixed content type part - ImagePart, etc</remarks>
        public override T AddNewPart<T>(string contentType, string id)
        {
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (typeof(MainDocumentPart).GetTypeInfo().IsAssignableFrom(typeof(T).GetTypeInfo()) && contentType != WordprocessingDocument.MainPartContentTypes[this._documentType])
            {
                throw new OpenXmlPackageException(ExceptionMessages.ErrorContentType);
            }

            return base.AddNewPart<T>(contentType, id);
        }

        /// <summary>
        /// Creates the MainDocumentPart and add it to this document.
        /// </summary>
        /// <returns>The newly added MainDocumentPart.</returns>
        public MainDocumentPart AddMainDocumentPart()
        {
            MainDocumentPart childPart = new MainDocumentPart();
            this.InitPart(childPart, this.MainPartContentType);
            return childPart;
        }

        /// <summary>
        /// Adds a CoreFilePropertiesPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added CoreFilePropertiesPart.</returns>
        public CoreFilePropertiesPart AddCoreFilePropertiesPart()
        {
            CoreFilePropertiesPart childPart = new CoreFilePropertiesPart();
            this.InitPart(childPart, CoreFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a ExtendedFilePropertiesPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added ExtendedFilePropertiesPart.</returns>
        public ExtendedFilePropertiesPart AddExtendedFilePropertiesPart()
        {
            ExtendedFilePropertiesPart childPart = new ExtendedFilePropertiesPart();
            this.InitPart(childPart, ExtendedFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomFilePropertiesPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added CustomFilePropertiesPart.</returns>
        public CustomFilePropertiesPart AddCustomFilePropertiesPart()
        {
            CustomFilePropertiesPart childPart = new CustomFilePropertiesPart();
            this.InitPart(childPart, CustomFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a DigitalSignatureOriginPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added DigitalSignatureOriginPart.</returns>
        public DigitalSignatureOriginPart AddDigitalSignatureOriginPart()
        {
            DigitalSignatureOriginPart childPart = new DigitalSignatureOriginPart();
            this.InitPart(childPart, DigitalSignatureOriginPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a ThumbnailPart to the WordprocessingDocument.
        /// </summary>
        /// <param name="contentType">The content type of the ThumbnailPart.</param>
        /// <returns>The newly added ThumbnailPart.</returns>
        public ThumbnailPart AddThumbnailPart(string contentType)
        {
            ThumbnailPart childPart = new ThumbnailPart();
            this.InitPart(childPart, contentType);
            return childPart;
        }
        /// <summary>
        /// Adds a ThumbnailPart to the WordprocessingDocument.
        /// </summary>
        /// <param name="partType">The type of the ThumbnailPart.</param>
        /// <returns>The newly added ThumbnailPart.</returns>
        public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType)
        {
            string contentType = ThumbnailPartTypeInfo.GetContentType(partType);
            string partExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
            PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);

            return AddThumbnailPart(contentType);
        }

        /// <summary>
        /// Adds a QuickAccessToolbarCustomizationsPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added QuickAccessToolbarCustomizationsPart.</returns>
        public QuickAccessToolbarCustomizationsPart AddQuickAccessToolbarCustomizationsPart()
        {
            QuickAccessToolbarCustomizationsPart childPart = new QuickAccessToolbarCustomizationsPart();
            this.InitPart(childPart, QuickAccessToolbarCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a RibbonExtensibilityPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonExtensibilityPart AddRibbonExtensibilityPart()
        {
            RibbonExtensibilityPart childPart = new RibbonExtensibilityPart();
            this.InitPart(childPart, RibbonExtensibilityPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a RibbonAndBackstageCustomizationsPart to the WordprocessingDocument, this part is only available in Office2010.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonAndBackstageCustomizationsPart AddRibbonAndBackstageCustomizationsPart()
        {
            RibbonAndBackstageCustomizationsPart childPart = new RibbonAndBackstageCustomizationsPart();
            this.InitPart(childPart, RibbonAndBackstageCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a WebExTaskpanesPart to the WordprocessingDocument, this part is only available in Office2013.
        /// </summary>
        /// <returns>The newly added WebExTaskpanesPart.</returns>
        public WebExTaskpanesPart AddWebExTaskpanesPart()
        {
            WebExTaskpanesPart childPart = new WebExTaskpanesPart();
            this.InitPart(childPart, WebExTaskpanesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Gets the MainDocumentPart of the WordprocessingDocument.
        /// </summary>
        public MainDocumentPart MainDocumentPart
        {
            get { return GetSubPartOfType<MainDocumentPart>(); }
        }
        /// <summary>
        /// Gets the CoreFilePropertiesPart of the WordprocessingDocument.
        /// </summary>
        public CoreFilePropertiesPart CoreFilePropertiesPart
        {
            get { return GetSubPartOfType<CoreFilePropertiesPart>(); }
        }
        /// <summary>
        /// Gets the ExtendedFilePropertiesPart of the WordprocessingDocument.
        /// </summary>
        public ExtendedFilePropertiesPart ExtendedFilePropertiesPart
        {
            get { return GetSubPartOfType<ExtendedFilePropertiesPart>(); }
        }
        /// <summary>
        /// Gets the CustomFilePropertiesPart of the WordprocessingDocument.
        /// </summary>
        public CustomFilePropertiesPart CustomFilePropertiesPart
        {
            get { return GetSubPartOfType<CustomFilePropertiesPart>(); }
        }
        /// <summary>
        /// Gets the ThumbnailPart of the WordprocessingDocument.
        /// </summary>
        public ThumbnailPart ThumbnailPart
        {
            get
            {
                return this.GetSubPartOfType<ThumbnailPart>();
            }
        }

        /// <summary>
        /// Gets the DigitalSignatureOriginPart of the WordprocessingDocument.
        /// </summary>
        public DigitalSignatureOriginPart DigitalSignatureOriginPart
        {
            get { return GetSubPartOfType<DigitalSignatureOriginPart>(); }
        }

        /// <summary>
        /// Gets the RibbonExtensibilityPart of the WordprocessingDocument.
        /// </summary>
        public RibbonExtensibilityPart RibbonExtensibilityPart
        {
            get { return GetSubPartOfType<RibbonExtensibilityPart>(); }
        }

        /// <summary>
        /// Gets the QuickAccessToolbarCustomizationsPart of the WordprocessingDocument.
        /// </summary>
        public QuickAccessToolbarCustomizationsPart QuickAccessToolbarCustomizationsPart
        {
            get { return GetSubPartOfType<QuickAccessToolbarCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the RibbonAndBackstageCustomizationsPart of the WordprocessingDocument, only available in Office2010.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        public RibbonAndBackstageCustomizationsPart RibbonAndBackstageCustomizationsPart
        {
            get { return GetSubPartOfType<RibbonAndBackstageCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the WebExTaskpanesPart of the WordprocessingDocument, only available in Office2013.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2013)]
        public WebExTaskpanesPart WebExTaskpanesPart
        {
            get { return GetSubPartOfType<WebExTaskpanesPart>(); }
        }

        #region cloning

        #region Stream-based cloning

        /// <summary>
        /// Creates a new OpenXmlPackage on the given stream.
        /// </summary>
        /// <param name="stream">The stream on which the concrete OpenXml package will be created.</param>
        /// <returns>A new instance of OpenXmlPackage.</returns>
        protected override OpenXmlPackage CreateClone(Stream stream)
        {
            return WordprocessingDocument.Create(stream, DocumentType, OpenSettings.AutoSave);
        }

        /// <summary>
        /// Opens the cloned OpenXml package on the given stream.
        /// </summary>
        /// <param name="stream">The stream on which the cloned OpenXml package will be opened.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of OpenXmlPackage.</returns>
        protected override OpenXmlPackage OpenClone(Stream stream, bool isEditable, OpenSettings openSettings)
        {
            return WordprocessingDocument.Open(stream, isEditable, openSettings);
        }

        #endregion Stream-based cloning

        #region File-based cloning

        /// <summary>
        /// Creates a new OpenXml package on the given file.
        /// </summary>
        /// <param name="path">The path and file name of the target OpenXml package.</param>
        /// <returns>A new instance of OpenXmlPackage.</returns>
        protected override OpenXmlPackage CreateClone(string path)
        {
            return WordprocessingDocument.Create(path, DocumentType, OpenSettings.AutoSave);
        }

        /// <summary>
        /// Opens the cloned OpenXml package on the given file.
        /// </summary>
        /// <param name="path">The path and file name of the target OpenXml package.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of OpenXmlPackage.</returns>
        protected override OpenXmlPackage OpenClone(string path, bool isEditable, OpenSettings openSettings)
        {
            return WordprocessingDocument.Open(path, isEditable, openSettings);
        }

        #endregion File-based cloning

        #region Package-based cloning

        /// <summary>
        /// Creates a new instance of OpenXmlPackage on the specified instance
        /// of Package.
        /// </summary>
        /// <param name="package">The specified instance of Package.</param>
        /// <returns>A new instance of OpenXmlPackage.</returns>
        protected override OpenXmlPackage CreateClone(Package package)
        {
            return WordprocessingDocument.Create(package, DocumentType, OpenSettings.AutoSave);
        }

        #endregion Package-based cloning

        #endregion cloning

        #region Flat OPC

        /// <summary>
        /// Converts an OpenXml package in OPC format to an <see cref="XDocument"/>
        /// in Flat OPC format.
        /// </summary>
        /// <returns>The OpenXml package in Flat OPC format.</returns>
        public override XDocument ToFlatOpcDocument()
        {
            return ToFlatOpcDocument(new XProcessingInstruction("mso-application", "progid=\"Word.Document\""));
        }

        /// <summary>
        /// Creates a new editable instance of WordprocessingDocument from an <see cref="XDocument"/>
        /// in Flat OPC format, opened on a <see cref="MemoryStream"/>.
        /// </summary>
        /// <param name="document">The document in Flat OPC format.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        public static WordprocessingDocument FromFlatOpcDocument(XDocument document)
        {
            return FromFlatOpcDocument(document, new MemoryStream(), true);
        }

        /// <summary>
        /// Creates a new instance of WordprocessingDocument from an <see cref="XDocument"/>
        /// in Flat OPC format.
        /// </summary>
        /// <param name="document">The document in Flat OPC format.</param>
        /// <param name="stream">The <see cref="Stream"/> on which the WordprocessingDocument will be created.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        public static WordprocessingDocument FromFlatOpcDocument(XDocument document, Stream stream, bool isEditable)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            return WordprocessingDocument.Open(FromFlatOpcDocumentCore(document, stream), isEditable);
        }

        /// <summary>
        /// Creates a new instance of WordprocessingDocument from an <see cref="XDocument"/>
        /// in Flat OPC format.
        /// </summary>
        /// <param name="document">The document in Flat OPC format.</param>
        /// <param name="path">The path and file name of the target WordprocessingDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        public static WordprocessingDocument FromFlatOpcDocument(XDocument document, string path, bool isEditable)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            return WordprocessingDocument.Open(FromFlatOpcDocumentCore(document, path), isEditable);
        }

        /// <summary>
        /// Creates a new instance of WordprocessingDocument from an <see cref="XDocument"/>
        /// in Flat OPC format.
        /// </summary>
        /// <param name="document">The document in Flat OPC format.</param>
        /// <param name="package">The <see cref="Package"/> of the target WordprocessingDocument.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        public static WordprocessingDocument FromFlatOpcDocument(XDocument document, Package package)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));
            if (package == null)
                throw new ArgumentNullException(nameof(package));

            return WordprocessingDocument.Open(FromFlatOpcDocumentCore(document, package));
        }

        /// <summary>
        /// Creates a new instance of WordprocessingDocument from a string
        /// in Flat OPC format on a <see cref="MemoryStream"/> with expandable
        /// capacity.
        /// </summary>
        /// <param name="text">The string in Flat OPC format.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        public static WordprocessingDocument FromFlatOpcString(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            return FromFlatOpcDocument(XDocument.Parse(text), new MemoryStream(), true);
        }

        /// <summary>
        /// Creates a new instance of WordprocessingDocument from a string
        /// in Flat OPC format on a
        /// </summary>
        /// <param name="text">The string in Flat OPC format.</param>
        /// <param name="stream">The <see cref="Stream"/> on which the WordprocessingDocument will be created.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        public static WordprocessingDocument FromFlatOpcString(string text, Stream stream, bool isEditable)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            return FromFlatOpcDocument(XDocument.Parse(text), stream, isEditable);
        }

        /// <summary>
        /// Creates a new instance of WordprocessingDocument from a string
        /// in Flat OPC format.
        /// </summary>
        /// <param name="text">The string in Flat OPC format.</param>
        /// <param name="path">The path and file name of the target WordprocessingDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        public static WordprocessingDocument FromFlatOpcString(string text, string path, bool isEditable)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            return FromFlatOpcDocument(XDocument.Parse(text), path, isEditable);
        }

        /// <summary>
        /// Creates a new instance of WordprocessingDocument from a string
        /// in Flat OPC format.
        /// </summary>
        /// <param name="text">The string in Flat OPC format.</param>
        /// <param name="package">The <see cref="Package"/> of the target WordprocessingDocument.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        public static WordprocessingDocument FromFlatOpcString(string text, Package package)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));
            if (package == null)
                throw new ArgumentNullException(nameof(package));

            return FromFlatOpcDocument(XDocument.Parse(text), package);
        }

        #endregion Flat OPC
    }
}
