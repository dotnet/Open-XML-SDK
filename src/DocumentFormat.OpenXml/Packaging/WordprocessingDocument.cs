// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Reflection;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
    /// </summary>
    [PartConstraint(typeof(MainDocumentPart), true, false)]
    [PartConstraint(typeof(CoreFilePropertiesPart), false, false)]
    [PartConstraint(typeof(ExtendedFilePropertiesPart), false, false)]
    [PartConstraint(typeof(CustomFilePropertiesPart), false, false)]
    [PartConstraint(typeof(ThumbnailPart), false, false)]
    [PartConstraint(typeof(DigitalSignatureOriginPart), false, false)]
    [PartConstraint(typeof(QuickAccessToolbarCustomizationsPart), false, false)]
    [PartConstraint(typeof(RibbonExtensibilityPart), false, false)]
    [PartConstraint(typeof(RibbonAndBackstageCustomizationsPart), false, false)]
    [PartConstraint(typeof(WebExTaskpanesPart), false, false)]
    [PartConstraint(typeof(LabelInfoPart), false, false)]
    public partial class WordprocessingDocument : OpenXmlPackage
    {
        /// <summary>
        /// Gets the relationship type of the main part.
        /// </summary>
        internal sealed override string MainPartRelationshipType => MainDocumentPart.RelationshipTypeConstant;

        private static Dictionary<WordprocessingDocumentType, string>? _validMainPartContentType;

        private static Dictionary<WordprocessingDocumentType, string> MainPartContentTypes
        {
            get
            {
                if (_validMainPartContentType is null)
                {
                    _validMainPartContentType = new Dictionary<WordprocessingDocumentType, string>
                    {
                        { WordprocessingDocumentType.Document, @"application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml" },
                        { WordprocessingDocumentType.Template, @"application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml" },
                        { WordprocessingDocumentType.MacroEnabledDocument, @"application/vnd.ms-word.document.macroEnabled.main+xml" },
                        { WordprocessingDocumentType.MacroEnabledTemplate, @"application/vnd.ms-word.template.macroEnabledTemplate.main+xml" },
                    };
                }

                return _validMainPartContentType;
            }
        }

        /// <summary>
        /// Gets the list of valid content type for main part.
        /// </summary>
        internal sealed override ICollection<string> ValidMainPartContentTypes => MainPartContentTypes.Values;

        /// <summary>
        /// Creates a WordprocessingDocument.
        /// </summary>
        [Obsolete(ObsoleteMessage)]
        protected WordprocessingDocument()
        {
        }

        private WordprocessingDocument(in PackageLoader loader, OpenSettings settings)
            : base(loader, settings)
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
                return _documentType;
            }

            private set
            {
                ThrowIfObjectDisposed();
                _documentType = value;
            }
        }

        internal override ApplicationType ApplicationType => ApplicationType.Word;

        private void UpdateDocumentTypeFromContentType()
        {
            if (MainPartContentType is null)
            {
                throw new InvalidOperationException();
            }

            foreach (KeyValuePair<WordprocessingDocumentType, string> types in MainPartContentTypes)
            {
                if (types.Value == MainPartContentType)
                {
                    DocumentType = types.Key;
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
        /// Creates a new instance of the WordprocessingDocument class from the specified package.
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
            => new(PackageLoader.CreateCore(path), new OpenSettings { AutoSave = autoSave })
            {
                DocumentType = type,
                MainPartContentType = MainPartContentTypes[type],
            };

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
            => new(PackageLoader.CreateCore(stream), new OpenSettings { AutoSave = autoSave })
            {
                DocumentType = type,
                MainPartContentType = MainPartContentTypes[type],
            };

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the specified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package</param>
        /// <param name="type">The type of the WordprocessingDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Write access.</exception>
        public static WordprocessingDocument Create(Package package, WordprocessingDocumentType type, bool autoSave)
            => new(PackageLoader.CreateCore(package), new OpenSettings { AutoSave = autoSave })
            {
                DocumentType = type,
                MainPartContentType = MainPartContentTypes[type],
            };

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
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }

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
                {
                    return document;
                }

                // Otherwise, we'll have to do some more work.
                // Firstly, we'll change the document type from Template to Document.
                document.ChangeDocumentType(WordprocessingDocumentType.Document);

                // Secondly, we'll attach the template to our new document if so desired.
                if (isTemplateAttached)
                {
                    // Create a relative or absolute external relationship to the template.
                    // TODO: Check whether relative URIs are universally supported. They work in Office 2010.
                    var documentSettingsPart = document.MainDocumentPart?.DocumentSettingsPart;

                    if (documentSettingsPart is not null)
                    {
                        var relationship = documentSettingsPart.AddExternalRelationship(
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/attachedTemplate",
                            new Uri(path, UriHelper.RelativeOrAbsolute));
                        documentSettingsPart.Settings.AppendChild(new AttachedTemplate { Id = relationship.Id });
                    }
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
            return Open(path, isEditable, new OpenSettings());
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
        public static WordprocessingDocument Open(Stream stream, bool isEditable)
        {
            return Open(stream, isEditable, new OpenSettings());
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
            if (openSettings is null)
            {
                throw new ArgumentNullException(nameof(openSettings));
            }

            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess
                && !openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions.Any())
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }

            var doc = new WordprocessingDocument(PackageLoader.OpenCore(path, isEditable), openSettings);

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
        public static WordprocessingDocument Open(Stream stream, bool isEditable, OpenSettings openSettings)
        {
            if (openSettings is null)
            {
                throw new ArgumentNullException(nameof(openSettings));
            }

            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess
                && !openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions.Any())
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }

            var doc = new WordprocessingDocument(PackageLoader.OpenCore(stream, isEditable), openSettings);

            if (MainPartContentTypes[doc.DocumentType] != doc.MainPartContentType)
            {
                doc.UpdateDocumentTypeFromContentType();
            }

            return doc;
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the specified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when package is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when package is not opened with read access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not a valid Open XML document.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static WordprocessingDocument Open(Package package, OpenSettings openSettings)
        {
            if (openSettings is null)
            {
                throw new ArgumentNullException(nameof(openSettings));
            }

            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess
                && !openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions.Any())
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }

            var doc = new WordprocessingDocument(PackageLoader.OpenCore(package), openSettings);

            if (MainPartContentTypes[doc.DocumentType] != doc.MainPartContentType)
            {
                doc.UpdateDocumentTypeFromContentType();
            }

            return doc;
        }

        /// <summary>
        /// Creates a new instance of the WordprocessingDocument class from the specified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <returns>A new instance of WordprocessingDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Read (ReadWrite) access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not valid Open XML WordprocessingDocument.</exception>
        public static WordprocessingDocument Open(Package package)
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

            if (newType == DocumentType)
            {
                // same type, just return
                return;
            }

            if (FileOpenAccess == FileAccess.Read)
            {
                throw new IOException(ExceptionMessages.PackageAccessModeIsReadonly);
            }

            WordprocessingDocumentType oldType = DocumentType;

            DocumentType = newType;
            MainPartContentType = MainPartContentTypes[newType];

            if (MainDocumentPart is null)
            {
                return;
            }

            try
            {
                ChangeDocumentTypeInternal(static () => new MainDocumentPart());
            }
            catch (OpenXmlPackageException e)
            {
                if (e.Message == ExceptionMessages.CannotChangeDocumentType)
                {
                    DocumentType = oldType;
                    MainPartContentType = MainPartContentTypes[oldType];
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
            ThrowIfObjectDisposed();

            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            return relationshipType switch
            {
                MainDocumentPart.RelationshipTypeConstant => new MainDocumentPart(),
                CoreFilePropertiesPart.RelationshipTypeConstant => new CoreFilePropertiesPart(),
                ExtendedFilePropertiesPart.RelationshipTypeConstant => new ExtendedFilePropertiesPart(),
                CustomFilePropertiesPart.RelationshipTypeConstant => new CustomFilePropertiesPart(),
                ThumbnailPart.RelationshipTypeConstant => new ThumbnailPart(),
                DigitalSignatureOriginPart.RelationshipTypeConstant => new DigitalSignatureOriginPart(),
                QuickAccessToolbarCustomizationsPart.RelationshipTypeConstant => new QuickAccessToolbarCustomizationsPart(),
                RibbonExtensibilityPart.RelationshipTypeConstant => new RibbonExtensibilityPart(),
                RibbonAndBackstageCustomizationsPart.RelationshipTypeConstant => new RibbonAndBackstageCustomizationsPart(),
                WebExTaskpanesPart.RelationshipTypeConstant => new WebExTaskpanesPart(),
                LabelInfoPart.RelationshipTypeConstant => new LabelInfoPart(),
                _ => throw new ArgumentOutOfRangeException(nameof(relationshipType)),
            };
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
            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (typeof(MainDocumentPart).GetTypeInfo().IsAssignableFrom(typeof(T).GetTypeInfo()) && contentType != WordprocessingDocument.MainPartContentTypes[_documentType])
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
            MainDocumentPart childPart = new();
            InitPart(childPart, MainPartContentType);
            return childPart;
        }

        /// <summary>
        /// Adds a CoreFilePropertiesPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added CoreFilePropertiesPart.</returns>
        public CoreFilePropertiesPart AddCoreFilePropertiesPart()
        {
            CoreFilePropertiesPart childPart = new();
            InitPart(childPart, CoreFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a ExtendedFilePropertiesPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added ExtendedFilePropertiesPart.</returns>
        public ExtendedFilePropertiesPart AddExtendedFilePropertiesPart()
        {
            ExtendedFilePropertiesPart childPart = new();
            InitPart(childPart, ExtendedFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomFilePropertiesPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added CustomFilePropertiesPart.</returns>
        public CustomFilePropertiesPart AddCustomFilePropertiesPart()
        {
            CustomFilePropertiesPart childPart = new();
            InitPart(childPart, CustomFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a DigitalSignatureOriginPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added DigitalSignatureOriginPart.</returns>
        public DigitalSignatureOriginPart AddDigitalSignatureOriginPart()
        {
            DigitalSignatureOriginPart childPart = new();
            InitPart(childPart, DigitalSignatureOriginPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a ThumbnailPart to the WordprocessingDocument.
        /// </summary>
        /// <param name="contentType">The content type of the ThumbnailPart.</param>
        /// <returns>The newly added ThumbnailPart.</returns>
        public ThumbnailPart AddThumbnailPart(string contentType)
        {
            ThumbnailPart childPart = new();
            InitPart(childPart, contentType);
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
            InitPart(childPart, QuickAccessToolbarCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a RibbonExtensibilityPart to the WordprocessingDocument.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonExtensibilityPart AddRibbonExtensibilityPart()
        {
            RibbonExtensibilityPart childPart = new();
            InitPart(childPart, RibbonExtensibilityPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a RibbonAndBackstageCustomizationsPart to the WordprocessingDocument, this part is only available in Office2010.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonAndBackstageCustomizationsPart AddRibbonAndBackstageCustomizationsPart()
        {
            RibbonAndBackstageCustomizationsPart childPart = new();
            InitPart(childPart, RibbonAndBackstageCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a WebExTaskpanesPart to the WordprocessingDocument, this part is only available in Office2013.
        /// </summary>
        /// <returns>The newly added WebExTaskpanesPart.</returns>
        public WebExTaskpanesPart AddWebExTaskpanesPart()
        {
            WebExTaskpanesPart childPart = new();
            InitPart(childPart, WebExTaskpanesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a LabelInfoPart to the WordprocessingDocument, this part is only available in Office2021.
        /// </summary>
        /// <returns>The newly added LabelInfoPart.</returns>
        public LabelInfoPart AddLabelInfoPart()
        {
            LabelInfoPart childPart = new();
            InitPart(childPart, LabelInfoPart.ContentTypeConstant);
            return childPart;
        }

        /// <inheritdoc />
        public override OpenXmlPart? RootPart => MainDocumentPart;

        /// <summary>
        /// Gets the MainDocumentPart of the WordprocessingDocument.
        /// </summary>
        public MainDocumentPart? MainDocumentPart
        {
            get { return GetSubPartOfType<MainDocumentPart>(); }
        }

        /// <summary>
        /// Gets the CoreFilePropertiesPart of the WordprocessingDocument.
        /// </summary>
        public CoreFilePropertiesPart? CoreFilePropertiesPart
        {
            get { return GetSubPartOfType<CoreFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the ExtendedFilePropertiesPart of the WordprocessingDocument.
        /// </summary>
        public ExtendedFilePropertiesPart? ExtendedFilePropertiesPart
        {
            get { return GetSubPartOfType<ExtendedFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the CustomFilePropertiesPart of the WordprocessingDocument.
        /// </summary>
        public CustomFilePropertiesPart? CustomFilePropertiesPart
        {
            get { return GetSubPartOfType<CustomFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the ThumbnailPart of the WordprocessingDocument.
        /// </summary>
        public ThumbnailPart? ThumbnailPart
        {
            get { return GetSubPartOfType<ThumbnailPart>(); }
        }

        /// <summary>
        /// Gets the DigitalSignatureOriginPart of the WordprocessingDocument.
        /// </summary>
        public DigitalSignatureOriginPart? DigitalSignatureOriginPart
        {
            get { return GetSubPartOfType<DigitalSignatureOriginPart>(); }
        }

        /// <summary>
        /// Gets the RibbonExtensibilityPart of the WordprocessingDocument.
        /// </summary>
        public RibbonExtensibilityPart? RibbonExtensibilityPart
        {
            get { return GetSubPartOfType<RibbonExtensibilityPart>(); }
        }

        /// <summary>
        /// Gets the QuickAccessToolbarCustomizationsPart of the WordprocessingDocument.
        /// </summary>
        public QuickAccessToolbarCustomizationsPart? QuickAccessToolbarCustomizationsPart
        {
            get { return GetSubPartOfType<QuickAccessToolbarCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the RibbonAndBackstageCustomizationsPart of the WordprocessingDocument, only available in Office2010.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        public RibbonAndBackstageCustomizationsPart? RibbonAndBackstageCustomizationsPart
        {
            get { return GetSubPartOfType<RibbonAndBackstageCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the WebExTaskpanesPart of the WordprocessingDocument, only available in Office2013.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2013)]
        public WebExTaskpanesPart? WebExTaskpanesPart
        {
            get { return GetSubPartOfType<WebExTaskpanesPart>(); }
        }

        /// <summary>
        /// Gets the LabelInfoPart of the WordprocessingDocument, only available in Office2021.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2021)]
        public LabelInfoPart? LabelInfoPart
        {
            get { return GetSubPartOfType<LabelInfoPart>(); }
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

        internal override IFeatureCollection CreatePartFeatures(IFeatureCollection? other) => new PartContainerFeatureCollection(TypedFeatures.Shared, other);
    }
}
