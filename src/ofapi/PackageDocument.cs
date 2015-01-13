// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Packaging;
using System.Collections.Specialized;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
    /// </summary>
    public class WordprocessingDocument : OpenXmlPackage
    {
        private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
        private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

        /// <summary>
        /// Gets part constraint data.
        /// </summary>
        /// <returns>The constraint data of the part.</returns>
        internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint == null)
            {
                System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string, PartConstraintRule>();
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", new PartConstraintRule("MainDocumentPart", null, true, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties", new PartConstraintRule("CoreFilePropertiesPart", CoreFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties", new PartConstraintRule("ExtendedFilePropertiesPart", ExtendedFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties", new PartConstraintRule("CustomFilePropertiesPart", CustomFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail", new PartConstraintRule("ThumbnailPart", null, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin", new PartConstraintRule("DigitalSignatureOriginPart", DigitalSignatureOriginPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization", new PartConstraintRule("QuickAccessToolbarCustomizationsPart", QuickAccessToolbarCustomizationsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2006/relationships/ui/extensibility", new PartConstraintRule("RibbonExtensibilityPart", RibbonExtensibilityPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2007/relationships/ui/extensibility", new PartConstraintRule("RibbonAndBackstageCustomizationsPart", RibbonAndBackstageCustomizationsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes", new PartConstraintRule("WebExTaskpanesPart", WebExTaskpanesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2013));
                _partConstraint = tempData;
            }
            return _partConstraint;
        }

        /// <summary>
        /// Gets the constraint rule of DataPartReferenceRelationship.
        /// </summary>
        /// <returns>The constraint data of the part.</returns>
        internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint == null)
            {
                System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string, PartConstraintRule>();

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
                throw new ArgumentNullException("path");
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
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
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
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
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
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML WordprocessingDocument.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static WordprocessingDocument Open(System.IO.Packaging.Package package, OpenSettings openSettings)
        {
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
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
                throw new ArgumentNullException("relationshipType");
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
            throw new ArgumentOutOfRangeException("relationshipType");
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
                throw new ArgumentNullException("contentType");
            }

            if (typeof(MainDocumentPart).IsAssignableFrom(typeof(T)) && contentType != WordprocessingDocument.MainPartContentTypes[this._documentType])
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Toolbar")]
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Toolbar")]
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
    }
    
    /// <summary>
    /// Defines SpreadsheetDocument - an OpenXmlPackage represents a Spreadsheet document.
    /// </summary>
    public class SpreadsheetDocument : OpenXmlPackage
    {
        private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
        private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

        /// <summary>
        /// Gets part constraint data.
        /// </summary>
        /// <returns>The constraint data of the part.</returns>
        internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint == null)
            {
                System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string, PartConstraintRule>();
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", new PartConstraintRule("WorkbookPart", null, true, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties", new PartConstraintRule("CoreFilePropertiesPart", CoreFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties", new PartConstraintRule("ExtendedFilePropertiesPart", ExtendedFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties", new PartConstraintRule("CustomFilePropertiesPart", CustomFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail", new PartConstraintRule("ThumbnailPart", null, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin", new PartConstraintRule("DigitalSignatureOriginPart", DigitalSignatureOriginPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization", new PartConstraintRule("QuickAccessToolbarCustomizationsPart", QuickAccessToolbarCustomizationsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2006/relationships/ui/extensibility", new PartConstraintRule("RibbonExtensibilityPart", RibbonExtensibilityPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2007/relationships/ui/extensibility", new PartConstraintRule("RibbonAndBackstageCustomizationsPart", RibbonAndBackstageCustomizationsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes", new PartConstraintRule("WebExTaskpanesPart", WebExTaskpanesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2013));

                _partConstraint = tempData;
            }
            return _partConstraint;
        }

        /// <summary>
        /// Gets the constraint rule of DataPartReferenceRelationship.
        /// </summary>
        /// <returns>The constraint data of the part.</returns>
        internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint == null)
            {
                System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string, PartConstraintRule>();

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
                return WorkbookPart.RelationshipTypeConstant;
            }
        }

        private static Dictionary<SpreadsheetDocumentType, string> _validMainPartContentType;

        private static Dictionary<SpreadsheetDocumentType, string> MainPartContentTypes
        {
            get
            {
                if (_validMainPartContentType == null)
                {
                    Dictionary<SpreadsheetDocumentType, string> tempData = new Dictionary<SpreadsheetDocumentType, string>();
                    tempData.Add(SpreadsheetDocumentType.Workbook, @"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml");
                    tempData.Add(SpreadsheetDocumentType.Template, @"application/vnd.openxmlformats-officedocument.spreadsheetml.template.main+xml");
                    tempData.Add(SpreadsheetDocumentType.MacroEnabledWorkbook, @"application/vnd.ms-excel.sheet.macroEnabled.main+xml");
                    tempData.Add(SpreadsheetDocumentType.MacroEnabledTemplate, @"application/vnd.ms-excel.template.macroEnabled.main+xml");
                    tempData.Add(SpreadsheetDocumentType.AddIn, @"application/vnd.ms-excel.addin.macroEnabled.main+xml");

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
        /// Creates a SpreadsheetDocument.
        /// </summary>
        protected SpreadsheetDocument()
            : base()
        {
        }

        private SpreadsheetDocumentType _documentType;
        /// <summary>
        /// Gets the type of the SpreadsheetDocument.
        /// </summary>
        public SpreadsheetDocumentType DocumentType
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

            foreach (KeyValuePair<SpreadsheetDocumentType, string> types in MainPartContentTypes)
            {
                if (types.Value == this.MainPartContentType)
                {
                    this.DocumentType = types.Key;
                }
            }
        }


        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target SpreadsheetDocument.</param>
        /// <param name="type">The type of the SpreadsheetDocument.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        public static SpreadsheetDocument Create(string path, SpreadsheetDocumentType type)
        {
            return Create(path, type, true);
        }

        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to create the SpreadsheetDocument.</param>
        /// <param name="type">The type of the SpreadsheetDocument.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Write access.</exception>
        public static SpreadsheetDocument Create(Stream stream, SpreadsheetDocumentType type)
        {
            return Create(stream, type, true);
        }

        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="type">The type of the SpreadsheetDocument.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Write access.</exception>
        public static SpreadsheetDocument Create(Package package, SpreadsheetDocumentType type)
        {
            return Create(package, type, true);
        }

        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target SpreadsheetDocument.</param>
        /// <param name="type">The type of the SpreadsheetDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        public static SpreadsheetDocument Create(string path, SpreadsheetDocumentType type, bool autoSave)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("path");
            }
            SpreadsheetDocument doc = new SpreadsheetDocument();
            doc.DocumentType = type;
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = autoSave;
            doc.MainPartContentType = MainPartContentTypes[type];
            doc.CreateCore(path);
            return doc;
        }

        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to create the SpreadsheetDocument.</param>
        /// <param name="type">The type of the SpreadsheetDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Write access.</exception>
        public static SpreadsheetDocument Create(Stream stream, SpreadsheetDocumentType type, bool autoSave)
        {
            SpreadsheetDocument doc = new SpreadsheetDocument();
            doc.DocumentType = type;
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = autoSave;
            doc.MainPartContentType = MainPartContentTypes[type];
            doc.CreateCore(stream);
            return doc;
        }



        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="type">The type of the SpreadsheetDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Write access.</exception>
        public static SpreadsheetDocument Create(Package package, SpreadsheetDocumentType type, bool autoSave)
        {
            SpreadsheetDocument doc = new SpreadsheetDocument();
            doc.DocumentType = type;
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = autoSave;
            doc.MainPartContentType = MainPartContentTypes[type];
            doc.CreateCore(package);
            return doc;
        }

        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target SpreadsheetDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML SpreadsheetDocument.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static SpreadsheetDocument Open(string path, bool isEditable, OpenSettings openSettings)
        {
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }
            SpreadsheetDocument doc = new SpreadsheetDocument();
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
        /// Creates a new instance of the SpreadsheetDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to open the SpreadsheetDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML SpreadsheetDocument.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static SpreadsheetDocument Open(System.IO.Stream stream, bool isEditable, OpenSettings openSettings)
        {
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }
            SpreadsheetDocument doc = new SpreadsheetDocument();
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
        /// Creates a new instance of the SpreadsheetDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML SpreadsheetDocument.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static SpreadsheetDocument Open(System.IO.Packaging.Package package, OpenSettings openSettings)
        {
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }
            SpreadsheetDocument doc = new SpreadsheetDocument();
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
        /// Creates a new instance of the SpreadsheetDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target SpreadsheetDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML SpreadsheetDocument.</exception>
        public static SpreadsheetDocument Open(string path, bool isEditable)
        {
            return SpreadsheetDocument.Open(path, isEditable, new OpenSettings());
        }

        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to open the SpreadsheetDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML SpreadsheetDocument.</exception>
        public static SpreadsheetDocument Open(System.IO.Stream stream, bool isEditable)
        {
            return SpreadsheetDocument.Open(stream, isEditable, new OpenSettings());
        }

        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML SpreadsheetDocument.</exception>
        public static SpreadsheetDocument Open(System.IO.Packaging.Package package)
        {
            return SpreadsheetDocument.Open(package, new OpenSettings());
        }

        /// <summary>
        /// Changes the document type. 
        /// </summary>
        /// <param name="newType">The new type of the document.</param>
        /// <remarks>The WorkbookPart will be changed.</remarks>
        public void ChangeDocumentType(SpreadsheetDocumentType newType)
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

            SpreadsheetDocumentType oldType = this.DocumentType;

            this.DocumentType = newType;
            this.MainPartContentType = MainPartContentTypes[newType];

            if (this.WorkbookPart == null)
            {
                return;
            }

            try
            {
                ChangeDocumentTypeInternal<WorkbookPart>();
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
                throw new ArgumentNullException("relationshipType");
            }
            switch (relationshipType)
            {
                case WorkbookPart.RelationshipTypeConstant:
                    return new WorkbookPart();

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

                case RibbonAndBackstageCustomizationsPart.RelationshipTypeConstant:
                    return new RibbonAndBackstageCustomizationsPart();

                case WebExTaskpanesPart.RelationshipTypeConstant:
                    return new WebExTaskpanesPart();
            }
            throw new ArgumentOutOfRangeException("relationshipType");
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
        /// <remarks>Mainly used for adding not-fixed content type part - ImagePart, etc.</remarks>
        public override T AddNewPart<T>(string contentType, string id)
        {

            if (contentType == null)
            {
                throw new ArgumentNullException("contentType");
            }

            if (typeof(WorkbookPart).IsAssignableFrom(typeof(T)) && contentType != SpreadsheetDocument.MainPartContentTypes[this._documentType])
            {
                throw new OpenXmlPackageException(ExceptionMessages.ErrorContentType);
            }

            return base.AddNewPart<T>(contentType, id);
        }

        /// <summary>
        /// Created the WorkbookPart and add it to this document.
        /// </summary>
        /// <returns>The newly added WorkbookPart.</returns>
        public WorkbookPart AddWorkbookPart()
        {
            WorkbookPart childPart = new WorkbookPart();
            this.InitPart(childPart, this.MainPartContentType);
            return childPart;
        }

        /// <summary>
        /// Addd a CoreFilePropertiesPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added CoreFilePropertiesPart.</returns>
        public CoreFilePropertiesPart AddCoreFilePropertiesPart()
        {
            CoreFilePropertiesPart childPart = new CoreFilePropertiesPart();
            this.InitPart(childPart, CoreFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Addd a ExtendedFilePropertiesPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added ExtendedFilePropertiesPart.</returns>
        public ExtendedFilePropertiesPart AddExtendedFilePropertiesPart()
        {
            ExtendedFilePropertiesPart childPart = new ExtendedFilePropertiesPart();
            this.InitPart(childPart, ExtendedFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Addd a CustomFilePropertiesPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added CustomFilePropertiesPart.</returns>
        public CustomFilePropertiesPart AddCustomFilePropertiesPart()
        {
            CustomFilePropertiesPart childPart = new CustomFilePropertiesPart();
            this.InitPart(childPart, CustomFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Addd a DigitalSignatureOriginPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added DigitalSignatureOriginPart.</returns>
        public DigitalSignatureOriginPart AddDigitalSignatureOriginPart()
        {
            DigitalSignatureOriginPart childPart = new DigitalSignatureOriginPart();
            this.InitPart(childPart, DigitalSignatureOriginPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Addd a ThumbnailPart to the SpreadsheetDocument.
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
        /// Adds a ThumbnailPart to the SpreadsheetDocument.
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
        /// Adds a QuickAccessToolbarCustomizationsPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added QuickAccessToolbarCustomizationsPart.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Toolbar")]
        public QuickAccessToolbarCustomizationsPart AddQuickAccessToolbarCustomizationsPart()
        {
            QuickAccessToolbarCustomizationsPart childPart = new QuickAccessToolbarCustomizationsPart();
            this.InitPart(childPart, QuickAccessToolbarCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a RibbonExtensibilityPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonExtensibilityPart AddRibbonExtensibilityPart()
        {
            RibbonExtensibilityPart childPart = new RibbonExtensibilityPart();
            this.InitPart(childPart, RibbonExtensibilityPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a RibbonAndBackstageCustomizationsPart to the SpreadsheetDocument, this part is only available in Office2010.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonAndBackstageCustomizationsPart AddRibbonAndBackstageCustomizationsPart()
        {
            RibbonAndBackstageCustomizationsPart childPart = new RibbonAndBackstageCustomizationsPart();
            this.InitPart(childPart, RibbonAndBackstageCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a WebExTaskpanesPart to the SpreadsheetDocument, this part is only available in Office2013.
        /// </summary>
        /// <returns>The newly added WebExTaskpanesPart.</returns>
        public WebExTaskpanesPart AddWebExTaskpanesPart()
        {
            WebExTaskpanesPart childPart = new WebExTaskpanesPart();
            this.InitPart(childPart, WebExTaskpanesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Gets the WorkbookPart of the SpreadsheetDocument.
        /// </summary>
        public WorkbookPart WorkbookPart
        {
            get { return GetSubPartOfType<WorkbookPart>(); }
        }
        /// <summary>
        /// Gets the CoreFilePropertiesPart of the SpreadsheetDocument.
        /// </summary>
        public CoreFilePropertiesPart CoreFilePropertiesPart
        {
            get { return GetSubPartOfType<CoreFilePropertiesPart>(); }
        }
        /// <summary>
        /// Gets the ExtendedFilePropertiesPart of the SpreadsheetDocument.
        /// </summary>
        public ExtendedFilePropertiesPart ExtendedFilePropertiesPart
        {
            get { return GetSubPartOfType<ExtendedFilePropertiesPart>(); }
        }
        /// <summary>
        /// Gets the CustomFilePropertiesPart of the SpreadsheetDocument.
        /// </summary>
        public CustomFilePropertiesPart CustomFilePropertiesPart
        {
            get { return GetSubPartOfType<CustomFilePropertiesPart>(); }
        }
        /// <summary>
        /// Gets the ThumbnailPart of the SpreadsheetDocument.
        /// </summary>
        public ThumbnailPart ThumbnailPart
        {
            get
            {
                return this.GetSubPartOfType<ThumbnailPart>();
            }
        }

        /// <summary>
        /// Gets the RibbonExtensibilityPart of the SpreadsheetDocument.
        /// </summary>
        public RibbonExtensibilityPart RibbonExtensibilityPart
        {
            get { return GetSubPartOfType<RibbonExtensibilityPart>(); }
        }

        /// <summary>
        /// Gets the QuickAccessToolbarCustomizationsPart of the SpreadsheetDocument.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Toolbar")]
        public QuickAccessToolbarCustomizationsPart QuickAccessToolbarCustomizationsPart
        {
            get { return GetSubPartOfType<QuickAccessToolbarCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the DigitalSignatureOriginPart of the SpreadsheetDocument.
        /// </summary>
        public DigitalSignatureOriginPart DigitalSignatureOriginPart
        {
            get { return GetSubPartOfType<DigitalSignatureOriginPart>(); }
        }

        /// <summary>
        /// Gets the RibbonAndBackstageCustomizationsPart of the SpreadsheetDocument, only available in Office2010.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        public RibbonAndBackstageCustomizationsPart RibbonAndBackstageCustomizationsPart
        {
            get { return GetSubPartOfType<RibbonAndBackstageCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the WebExTaskpanesPart of the SpreadsheetDocument, only available in Office2013.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2013)]
        public WebExTaskpanesPart WebExTaskpanesPart
        {
            get { return GetSubPartOfType<WebExTaskpanesPart>(); }
        }
    }
    
    /// <summary>
    /// Defines PresentationDocument - an OpenXmlPackage represents a Presentation document
    /// </summary>
    public class PresentationDocument : OpenXmlPackage
    {
        private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _partConstraint;
        private static System.Collections.Generic.Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;

        /// <summary>
        /// Gets part constraint data.
        /// </summary>
        /// <returns>The constraint data of the part.</returns>
        internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint == null)
            {
                System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string, PartConstraintRule>();
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", new PartConstraintRule("PresentationPart", null, true, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties", new PartConstraintRule("CoreFilePropertiesPart", CoreFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties", new PartConstraintRule("ExtendedFilePropertiesPart", ExtendedFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties", new PartConstraintRule("CustomFilePropertiesPart", CustomFilePropertiesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail", new PartConstraintRule("ThumbnailPart", null, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin", new PartConstraintRule("DigitalSignatureOriginPart", DigitalSignatureOriginPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization", new PartConstraintRule("QuickAccessToolbarCustomizationsPart", QuickAccessToolbarCustomizationsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2006/relationships/ui/extensibility", new PartConstraintRule("RibbonExtensibilityPart", RibbonExtensibilityPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007 | FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2007/relationships/ui/extensibility", new PartConstraintRule("RibbonAndBackstageCustomizationsPart", RibbonAndBackstageCustomizationsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2010 | FileFormatVersions.Office2013));
                tempData.Add("http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes", new PartConstraintRule("WebExTaskpanesPart", WebExTaskpanesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2013));
                _partConstraint = tempData;
            }
            return _partConstraint;
        }

        /// <summary>
        /// Gets the constraint rule of DataPartReferenceRelationship.
        /// </summary>
        /// <returns>The constraint data of the part.</returns>
        internal sealed override System.Collections.Generic.IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint == null)
            {
                System.Collections.Generic.Dictionary<string, PartConstraintRule> tempData = new System.Collections.Generic.Dictionary<string, PartConstraintRule>();

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
                return PresentationPart.RelationshipTypeConstant;
            }
        }

        private static Dictionary<PresentationDocumentType, string> _validMainPartContentType;
        private static Dictionary<PresentationDocumentType, string> MainPartContentTypes
        {
            get
            {
                if (_validMainPartContentType == null)
                {
                    Dictionary<PresentationDocumentType, string> tempData = new Dictionary<PresentationDocumentType, string>();
                    tempData.Add(PresentationDocumentType.Presentation, @"application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml");
                    tempData.Add(PresentationDocumentType.Template, @"application/vnd.openxmlformats-officedocument.presentationml.template.main+xml");
                    tempData.Add(PresentationDocumentType.Slideshow, @"application/vnd.openxmlformats-officedocument.presentationml.slideshow.main+xml");
                    tempData.Add(PresentationDocumentType.MacroEnabledPresentation, @"application/vnd.ms-powerpoint.presentation.macroEnabled.main+xml");
                    tempData.Add(PresentationDocumentType.MacroEnabledTemplate, @"application/vnd.ms-powerpoint.template.macroEnabled.main+xml");
                    tempData.Add(PresentationDocumentType.MacroEnabledSlideshow, @"application/vnd.ms-powerpoint.slideshow.macroEnabled.main+xml");
                    tempData.Add(PresentationDocumentType.AddIn, @"application/vnd.ms-powerpoint.addin.macroEnabled.main+xml");

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
        /// Creates a PresentationDocument.
        /// </summary>
        protected PresentationDocument()
            : base()
        {
        }

        private PresentationDocumentType _documentType;

        /// <summary>
        /// Gets the type of the PresentationDocument.
        /// </summary>
        public PresentationDocumentType DocumentType
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

            foreach (KeyValuePair<PresentationDocumentType, string> types in MainPartContentTypes)
            {
                if (types.Value == this.MainPartContentType)
                {
                    this.DocumentType = types.Key;
                }
            }
        }

        /// <summary>
        /// Creates a new instance of the PresentationDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target PresentationDocument.</param>
        /// <param name="type">The type of the PresentationDocument.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        public static PresentationDocument Create(string path, PresentationDocumentType type)
        {
            return Create(path, type, true);
        }

        /// <summary>
        /// Created a new instance of the PresentationDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to create the PresentationDocument.</param>
        /// <param name="type">The type of the PresentationDocument.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Write access.</exception>
        public static PresentationDocument Create(Stream stream, PresentationDocumentType type)
        {
            return Create(stream, type, true);
        }

        /// <summary>
        /// Created a new instance of the PresentationDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="type">The type of the PresentationDocument.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Write access.</exception>
        public static PresentationDocument Create(Package package, PresentationDocumentType type)
        {
            return Create(package, type, true);
        }

        /// <summary>
        /// Created a new instance of the PresentationDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target PresentationDocument.</param>
        /// <param name="type">The type of the PresentationDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        public static PresentationDocument Create(string path, PresentationDocumentType type, bool autoSave)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(path);
            }
            PresentationDocument doc = new PresentationDocument();
            doc.DocumentType = type;
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = autoSave;
            doc.MainPartContentType = MainPartContentTypes[type];
            doc.CreateCore(path);
            return doc;
        }
        /// <summary>
        /// Creates a new instance of the PresentationDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to create the PresentationDocument.</param>
        /// <param name="type">The type of the PresentationDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Write access.</exception>
        public static PresentationDocument Create(Stream stream, PresentationDocumentType type, bool autoSave)
        {
            PresentationDocument doc = new PresentationDocument();
            doc.DocumentType = type;
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = autoSave;
            doc.MainPartContentType = MainPartContentTypes[type];
            doc.CreateCore(stream);
            return doc;
        }

        /// <summary>
        /// Creates a new instance of the PresentationDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="type">The type of the PresentationDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Write access.</exception>
        public static PresentationDocument Create(Package package, PresentationDocumentType type, bool autoSave)
        {
            PresentationDocument doc = new PresentationDocument();
            doc.DocumentType = type;
            doc.OpenSettings = new OpenSettings();
            doc.OpenSettings.AutoSave = autoSave;
            doc.MainPartContentType = MainPartContentTypes[type];
            doc.CreateCore(package);
            return doc;
        }


        /// <summary>
        /// Creates a new instance of the PresentationDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target PresentationDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML PresentationDocument.</exception>
        public static PresentationDocument Open(string path, bool isEditable)
        {
            return PresentationDocument.Open(path, isEditable, new OpenSettings());
        }

        /// <summary>
        /// Creates a new instance of the PresentationDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to open the PresentationDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML PresentationDocument.</exception>
        public static PresentationDocument Open(System.IO.Stream stream, bool isEditable)
        {
            return PresentationDocument.Open(stream, isEditable, new OpenSettings());
        }

        /// <summary>
        /// Creates a new instance of the PresentationDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML PresentationDocument.</exception>
        public static PresentationDocument Open(System.IO.Packaging.Package package)
        {
            return PresentationDocument.Open(package, new OpenSettings());
        }

        /// <summary>
        /// Creates a new instance of the PresentationDocument class from the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target PresentationDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "path" is null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML PresentationDocument.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static PresentationDocument Open(string path, bool isEditable, OpenSettings openSettings)
        {
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }
            PresentationDocument doc = new PresentationDocument();
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
        /// Creates a new instance of the PresentationDocument class from the IO stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to open the PresentationDocument.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "stream" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "stream" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML PresentationDocument.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static PresentationDocument Open(System.IO.Stream stream, bool isEditable, OpenSettings openSettings)
        {
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }
            PresentationDocument doc = new PresentationDocument();
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
        /// Creates a new instance of the PresentationDocument class from the spcified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML PresentationDocument.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static PresentationDocument Open(System.IO.Packaging.Package package, OpenSettings openSettings)
        {
            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess && (openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2007 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2010 && openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions != FileFormatVersions.Office2013))
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }
            PresentationDocument doc = new PresentationDocument();
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
        /// Changes the document type. 
        /// </summary>
        /// <param name="newType">The new type of the document.</param>
        /// <remarks>The PresentationPart will be changed.</remarks>
        public void ChangeDocumentType(PresentationDocumentType newType)
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

            PresentationDocumentType oldType = this.DocumentType;

            this.DocumentType = newType;
            this.MainPartContentType = MainPartContentTypes[newType];

            if (this.PresentationPart == null)
            {
                return;
            }

            try
            {
                ChangeDocumentTypeInternal<PresentationPart>();
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
                throw new ArgumentNullException("relationshipType");
            }
            switch (relationshipType)
            {
                case PresentationPart.RelationshipTypeConstant:
                    return new PresentationPart();

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

                case RibbonAndBackstageCustomizationsPart.RelationshipTypeConstant:
                    return new RibbonAndBackstageCustomizationsPart();

                case WebExTaskpanesPart.RelationshipTypeConstant:
                    return new WebExTaskpanesPart();
            }
            throw new ArgumentOutOfRangeException("relationshipType");
        }


        /// <summary>
        /// Creates the PresentationPart and add it to this document.
        /// </summary>
        /// <returns>The newly added PresentationPart.</returns>
        public PresentationPart AddPresentationPart()
        {
            PresentationPart childPart = new PresentationPart();
            this.InitPart(childPart, this.MainPartContentType);
            return childPart;
        }

        /// <summary>
        /// Adds a CoreFilePropertiesPart to the PresentationDocument.
        /// </summary>
        /// <returns>The newly added CoreFilePropertiesPart.</returns>
        public CoreFilePropertiesPart AddCoreFilePropertiesPart()
        {
            CoreFilePropertiesPart childPart = new CoreFilePropertiesPart();
            this.InitPart(childPart, CoreFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a ExtendedFilePropertiesPart to the PresentationDocument.
        /// </summary>
        /// <returns>The newly added ExtendedFilePropertiesPart.</returns>
        public ExtendedFilePropertiesPart AddExtendedFilePropertiesPart()
        {
            ExtendedFilePropertiesPart childPart = new ExtendedFilePropertiesPart();
            this.InitPart(childPart, ExtendedFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomFilePropertiesPart to the PresentationDocument.
        /// </summary>
        /// <returns>The newly added CustomFilePropertiesPart.</returns>
        public CustomFilePropertiesPart AddCustomFilePropertiesPart()
        {
            CustomFilePropertiesPart childPart = new CustomFilePropertiesPart();
            this.InitPart(childPart, CustomFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a DigitalSignatureOriginPart to the PresentationDocuments.
        /// </summary>
        /// <returns>The newly added DigitalSignatureOriginPart.</returns>
        public DigitalSignatureOriginPart AddDigitalSignatureOriginPart()
        {
            DigitalSignatureOriginPart childPart = new DigitalSignatureOriginPart();
            this.InitPart(childPart, DigitalSignatureOriginPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a ThumbnailPart to the PresentationDocument.
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
        /// Adds a ThumbnailPart to the PresentationDocument.
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
        /// Adds a new part of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The class of the part.</typeparam>
        /// <param name="contentType">The content type of the part. Must match the defined content type if the part is fixed content type.</param>
        /// <param name="id">The relationship id. The id will be automaticly generated if this param is null.</param>
        /// <returns>The added part.</returns>
        /// <exception cref="OpenXmlPackageException">When the part is not allowed to be referenced by this part.</exception>
        /// <exception cref="ArgumentOutOfRangeException">When the part is fixed content type and the passed in contentType does not match the defined content type.</exception>
        /// <exception cref="ArgumentNullException">Thrown when "contentType" is null reference.</exception>
        /// <remarks>Mainly used for adding not-fixed content type part - ImagePart, etc.</remarks>
        public override T AddNewPart<T>(string contentType, string id)
        {
            if (contentType == null)
            {
                throw new ArgumentNullException("contentType");
            }

            if (typeof(PresentationPart).IsAssignableFrom(typeof(T)) && contentType != PresentationDocument.MainPartContentTypes[this._documentType])
            {
                throw new OpenXmlPackageException(ExceptionMessages.ErrorContentType);
            }


            return base.AddNewPart<T>(contentType, id);
        }

        /// <summary>
        /// Add a QuickAccessToolbarCustomizationsPart to the PresentationDocument.
        /// </summary>
        /// <returns>The newly added QuickAccessToolbarCustomizationsPart.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Toolbar")]
        public QuickAccessToolbarCustomizationsPart AddQuickAccessToolbarCustomizationsPart()
        {
            QuickAccessToolbarCustomizationsPart childPart = new QuickAccessToolbarCustomizationsPart();
            this.InitPart(childPart, QuickAccessToolbarCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Add a RibbonExtensibilityPart to the PresentationDocument.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonExtensibilityPart AddRibbonExtensibilityPart()
        {
            RibbonExtensibilityPart childPart = new RibbonExtensibilityPart();
            this.InitPart(childPart, RibbonExtensibilityPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Add a RibbonAndBackstageCustomizationsPart to the PresentationDocument, this part is only available in Office2010.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonAndBackstageCustomizationsPart AddRibbonAndBackstageCustomizationsPart()
        {
            RibbonAndBackstageCustomizationsPart childPart = new RibbonAndBackstageCustomizationsPart();
            this.InitPart(childPart, RibbonAndBackstageCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a WebExTaskpanesPart to the PresentationDocument, this part is only available in Office2013.
        /// </summary>
        /// <returns>The newly added WebExTaskpanesPart.</returns>
        public WebExTaskpanesPart AddWebExTaskpanesPart()
        {
            WebExTaskpanesPart childPart = new WebExTaskpanesPart();
            this.InitPart(childPart, WebExTaskpanesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Gets the PresentationPart of the PresentationDocument.
        /// </summary>
        public PresentationPart PresentationPart
        {
            get { return GetSubPartOfType<PresentationPart>(); }
        }

        /// <summary>
        /// Gets the CoreFilePropertiesPart of the PresentationDocument.
        /// </summary>
        public CoreFilePropertiesPart CoreFilePropertiesPart
        {
            get { return GetSubPartOfType<CoreFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the ExtendedFilePropertiesPart of the PresentationDocument.
        /// </summary>
        public ExtendedFilePropertiesPart ExtendedFilePropertiesPart
        {
            get { return GetSubPartOfType<ExtendedFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the CustomFilePropertiesPart of the PresentationDocument.
        /// </summary>
        public CustomFilePropertiesPart CustomFilePropertiesPart
        {
            get { return GetSubPartOfType<CustomFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the ThumbnailPart of the PresentationDocument.
        /// </summary>
        public ThumbnailPart ThumbnailPart
        {
            get
            {
                return this.GetSubPartOfType<ThumbnailPart>();
            }
        }


        /// <summary>
        /// Gets the DigitalSignatureOriginPart of the PresentationDocument.
        /// </summary>
        public DigitalSignatureOriginPart DigitalSignatureOriginPart
        {
            get { return GetSubPartOfType<DigitalSignatureOriginPart>(); }
        }


        /// <summary>
        /// Gets the RibbonExtensibilityPart of the PresentationDocument.
        /// </summary>
        public RibbonExtensibilityPart RibbonExtensibilityPart
        {
            get { return GetSubPartOfType<RibbonExtensibilityPart>(); }
        }

        /// <summary>
        /// Gets the QuickAccessToolbarCustomizationsPart of the PresentationDocument.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Toolbar")]
        public QuickAccessToolbarCustomizationsPart QuickAccessToolbarCustomizationsPart
        {
            get { return GetSubPartOfType<QuickAccessToolbarCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the RibbonAndBackstageCustomizationsPart of the PresentationDocument, only available in Office2010.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        public RibbonAndBackstageCustomizationsPart RibbonAndBackstageCustomizationsPart
        {
            get { return GetSubPartOfType<RibbonAndBackstageCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the WebExTaskpanesPart of the PresentationDocument, only available in Office2013.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2013)]
        public WebExTaskpanesPart WebExTaskpanesPart
        {
            get { return GetSubPartOfType<WebExTaskpanesPart>(); }
        }
    }
}
