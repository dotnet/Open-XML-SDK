// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Reflection;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines PresentationDocument - an OpenXmlPackage represents a Presentation document
    /// </summary>
    [PartConstraint(typeof(PresentationPart), true, false)]
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
    public partial class PresentationDocument : OpenXmlPackage
    {
        /// <summary>
        /// Gets the relationship type of the main part.
        /// </summary>
        internal sealed override string MainPartRelationshipType => PresentationPart.RelationshipTypeConstant;

        private static Dictionary<PresentationDocumentType, string>? _validMainPartContentType;

        private static Dictionary<PresentationDocumentType, string> MainPartContentTypes
        {
            get
            {
                if (_validMainPartContentType is null)
                {
                    _validMainPartContentType = new Dictionary<PresentationDocumentType, string>
                    {
                        { PresentationDocumentType.Presentation, @"application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml" },
                        { PresentationDocumentType.Template, @"application/vnd.openxmlformats-officedocument.presentationml.template.main+xml" },
                        { PresentationDocumentType.Slideshow, @"application/vnd.openxmlformats-officedocument.presentationml.slideshow.main+xml" },
                        { PresentationDocumentType.MacroEnabledPresentation, @"application/vnd.ms-powerpoint.presentation.macroEnabled.main+xml" },
                        { PresentationDocumentType.MacroEnabledTemplate, @"application/vnd.ms-powerpoint.template.macroEnabled.main+xml" },
                        { PresentationDocumentType.MacroEnabledSlideshow, @"application/vnd.ms-powerpoint.slideshow.macroEnabled.main+xml" },
                        { PresentationDocumentType.AddIn, @"application/vnd.ms-powerpoint.addin.macroEnabled.main+xml" },
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
        /// Creates a PresentationDocument.
        /// </summary>
        [Obsolete(ObsoleteMessage)]
        protected PresentationDocument()
            : base()
        {
        }

        private PresentationDocument(in PackageLoader loader, OpenSettings settings)
            : base(loader, settings)
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
                return _documentType;
            }

            private set
            {
                ThrowIfObjectDisposed();
                _documentType = value;
            }
        }

        internal override ApplicationType ApplicationType => ApplicationType.PowerPoint;

        private void UpdateDocumentTypeFromContentType()
        {
            if (MainPartContentType is null)
            {
                throw new InvalidOperationException();
            }

            foreach (KeyValuePair<PresentationDocumentType, string> types in MainPartContentTypes)
            {
                if (types.Value == MainPartContentType)
                {
                    DocumentType = types.Key;
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
        /// Created a new instance of the PresentationDocument class from the specified package.
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
            => new PresentationDocument(PackageLoader.CreateCore(path), new OpenSettings { AutoSave = autoSave })
            {
                DocumentType = type,
                MainPartContentType = MainPartContentTypes[type],
            };

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
            => new PresentationDocument(PackageLoader.CreateCore(stream), new OpenSettings { AutoSave = autoSave })
            {
                DocumentType = type,
                MainPartContentType = MainPartContentTypes[type],
            };

        /// <summary>
        /// Creates a new instance of the PresentationDocument class from the specified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="type">The type of the PresentationDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Write access.</exception>
        public static PresentationDocument Create(Package package, PresentationDocumentType type, bool autoSave)
            => new PresentationDocument(PackageLoader.CreateCore(package), new OpenSettings { AutoSave = autoSave })
            {
                DocumentType = type,
                MainPartContentType = MainPartContentTypes[type],
            };

        /// <summary>
        /// Creates an editable PresentationDocument from a template, opened on
        /// a MemoryStream with expandable capacity.
        /// </summary>
        /// <param name="path">The path and file name of the template.</param>
        /// <returns>The new PresentationDocument based on the template.</returns>
        public static PresentationDocument CreateFromTemplate(string path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            // Check extensions as the template must have a valid Word Open XML extension.
            string extension = Path.GetExtension(path);
            if (extension != ".pptx" && extension != ".pptm" && extension != ".potx" && extension != ".potm")
            {
                throw new ArgumentException("Illegal template file: " + path, nameof(path));
            }

            using (PresentationDocument template = PresentationDocument.Open(path, false))
            {
                // We've opened the template in read-only mode to let multiple processes or
                // threads open it without running into problems.
                PresentationDocument document = (PresentationDocument)template.Clone();

                // If the template is a document rather than a template, we are done.
                if (extension == ".xlsx" || extension == ".xlsm")
                {
                    return document;
                }

                // Otherwise, we'll have to do some more work.
                document.ChangeDocumentType(PresentationDocumentType.Presentation);

                // We are done, so save and return.
                // TODO: Check whether it would be safe to return without saving.
                document.Save();
                return document;
            }
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
        /// Creates a new instance of the PresentationDocument class from the specified package.
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
            if (openSettings is null)
            {
                throw new ArgumentNullException(nameof(openSettings));
            }

            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess
                && !openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions.Any())
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }

            var doc = new PresentationDocument(PackageLoader.OpenCore(path, isEditable), openSettings);

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
        public static PresentationDocument Open(Stream stream, bool isEditable, OpenSettings openSettings)
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

            var doc = new PresentationDocument(PackageLoader.OpenCore(stream, isEditable), openSettings);

            if (MainPartContentTypes[doc.DocumentType] != doc.MainPartContentType)
            {
                doc.UpdateDocumentTypeFromContentType();
            }

            return doc;
        }

        /// <summary>
        /// Creates a new instance of the PresentationDocument class from the specified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of PresentationDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when package is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when package is not opened with read access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not a valid Open XML document.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static PresentationDocument Open(Package package, OpenSettings openSettings)
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

            var doc = new PresentationDocument(PackageLoader.OpenCore(package), openSettings);

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

            if (newType == DocumentType)
            {
                // same type, just return
                return;
            }

            if (FileOpenAccess == FileAccess.Read)
            {
                throw new IOException(ExceptionMessages.PackageAccessModeIsReadonly);
            }

            PresentationDocumentType oldType = DocumentType;

            DocumentType = newType;
            MainPartContentType = MainPartContentTypes[newType];

            if (PresentationPart is null)
            {
                return;
            }

            try
            {
                ChangeDocumentTypeInternal(static () => new PresentationPart());
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
                PresentationPart.RelationshipTypeConstant => new PresentationPart(),
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
        /// Creates the PresentationPart and add it to this document.
        /// </summary>
        /// <returns>The newly added PresentationPart.</returns>
        public PresentationPart AddPresentationPart()
        {
            PresentationPart childPart = new PresentationPart();
            InitPart(childPart, MainPartContentType);
            return childPart;
        }

        /// <summary>
        /// Adds a CoreFilePropertiesPart to the PresentationDocument.
        /// </summary>
        /// <returns>The newly added CoreFilePropertiesPart.</returns>
        public CoreFilePropertiesPart AddCoreFilePropertiesPart()
        {
            CoreFilePropertiesPart childPart = new CoreFilePropertiesPart();
            InitPart(childPart, CoreFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a ExtendedFilePropertiesPart to the PresentationDocument.
        /// </summary>
        /// <returns>The newly added ExtendedFilePropertiesPart.</returns>
        public ExtendedFilePropertiesPart AddExtendedFilePropertiesPart()
        {
            ExtendedFilePropertiesPart childPart = new ExtendedFilePropertiesPart();
            InitPart(childPart, ExtendedFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomFilePropertiesPart to the PresentationDocument.
        /// </summary>
        /// <returns>The newly added CustomFilePropertiesPart.</returns>
        public CustomFilePropertiesPart AddCustomFilePropertiesPart()
        {
            CustomFilePropertiesPart childPart = new CustomFilePropertiesPart();
            InitPart(childPart, CustomFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a DigitalSignatureOriginPart to the PresentationDocuments.
        /// </summary>
        /// <returns>The newly added DigitalSignatureOriginPart.</returns>
        public DigitalSignatureOriginPart AddDigitalSignatureOriginPart()
        {
            DigitalSignatureOriginPart childPart = new DigitalSignatureOriginPart();
            InitPart(childPart, DigitalSignatureOriginPart.ContentTypeConstant);
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
            InitPart(childPart, contentType);
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
        /// <param name="id">The relationship id. The id will be automatically generated if this param is null.</param>
        /// <returns>The added part.</returns>
        /// <exception cref="OpenXmlPackageException">When the part is not allowed to be referenced by this part.</exception>
        /// <exception cref="ArgumentOutOfRangeException">When the part is fixed content type and the passed in contentType does not match the defined content type.</exception>
        /// <exception cref="ArgumentNullException">Thrown when "contentType" is null reference.</exception>
        /// <remarks>Mainly used for adding not-fixed content type part - ImagePart, etc.</remarks>
        public override T AddNewPart<T>(string contentType, string id)
        {
            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (typeof(PresentationPart).GetTypeInfo().IsAssignableFrom(typeof(T).GetTypeInfo()) && contentType != PresentationDocument.MainPartContentTypes[_documentType])
            {
                throw new OpenXmlPackageException(ExceptionMessages.ErrorContentType);
            }

            return base.AddNewPart<T>(contentType, id);
        }

        /// <summary>
        /// Add a QuickAccessToolbarCustomizationsPart to the PresentationDocument.
        /// </summary>
        /// <returns>The newly added QuickAccessToolbarCustomizationsPart.</returns>
        public QuickAccessToolbarCustomizationsPart AddQuickAccessToolbarCustomizationsPart()
        {
            QuickAccessToolbarCustomizationsPart childPart = new QuickAccessToolbarCustomizationsPart();
            InitPart(childPart, QuickAccessToolbarCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Add a RibbonExtensibilityPart to the PresentationDocument.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonExtensibilityPart AddRibbonExtensibilityPart()
        {
            RibbonExtensibilityPart childPart = new RibbonExtensibilityPart();
            InitPart(childPart, RibbonExtensibilityPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Add a RibbonAndBackstageCustomizationsPart to the PresentationDocument, this part is only available in Office2010.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonAndBackstageCustomizationsPart AddRibbonAndBackstageCustomizationsPart()
        {
            RibbonAndBackstageCustomizationsPart childPart = new RibbonAndBackstageCustomizationsPart();
            InitPart(childPart, RibbonAndBackstageCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a WebExTaskpanesPart to the PresentationDocument, this part is only available in Office2013.
        /// </summary>
        /// <returns>The newly added WebExTaskpanesPart.</returns>
        public WebExTaskpanesPart AddWebExTaskpanesPart()
        {
            WebExTaskpanesPart childPart = new WebExTaskpanesPart();
            InitPart(childPart, WebExTaskpanesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a LabelInfoPart to the PresentationDocument, this part is only available in Office2021.
        /// </summary>
        /// <returns>The newly added WebExTaskpanesPart.</returns>
        public LabelInfoPart AddLabelInfoPart()
        {
            LabelInfoPart childPart = new LabelInfoPart();
            InitPart(childPart, LabelInfoPart.ContentTypeConstant);
            return childPart;
        }

        /// <inheritdoc />
        public override OpenXmlPart? RootPart => PresentationPart;

        /// <summary>
        /// Gets the PresentationPart of the PresentationDocument.
        /// </summary>
        public PresentationPart? PresentationPart
        {
            get { return GetSubPartOfType<PresentationPart>(); }
        }

        /// <summary>
        /// Gets the CoreFilePropertiesPart of the PresentationDocument.
        /// </summary>
        public CoreFilePropertiesPart? CoreFilePropertiesPart
        {
            get { return GetSubPartOfType<CoreFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the ExtendedFilePropertiesPart of the PresentationDocument.
        /// </summary>
        public ExtendedFilePropertiesPart? ExtendedFilePropertiesPart
        {
            get { return GetSubPartOfType<ExtendedFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the CustomFilePropertiesPart of the PresentationDocument.
        /// </summary>
        public CustomFilePropertiesPart? CustomFilePropertiesPart
        {
            get { return GetSubPartOfType<CustomFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the ThumbnailPart of the PresentationDocument.
        /// </summary>
        public ThumbnailPart? ThumbnailPart
        {
            get { return GetSubPartOfType<ThumbnailPart>(); }
        }

        /// <summary>
        /// Gets the DigitalSignatureOriginPart of the PresentationDocument.
        /// </summary>
        public DigitalSignatureOriginPart? DigitalSignatureOriginPart
        {
            get { return GetSubPartOfType<DigitalSignatureOriginPart>(); }
        }

        /// <summary>
        /// Gets the RibbonExtensibilityPart of the PresentationDocument.
        /// </summary>
        public RibbonExtensibilityPart? RibbonExtensibilityPart
        {
            get { return GetSubPartOfType<RibbonExtensibilityPart>(); }
        }

        /// <summary>
        /// Gets the QuickAccessToolbarCustomizationsPart of the PresentationDocument.
        /// </summary>
        public QuickAccessToolbarCustomizationsPart? QuickAccessToolbarCustomizationsPart
        {
            get { return GetSubPartOfType<QuickAccessToolbarCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the RibbonAndBackstageCustomizationsPart of the PresentationDocument, only available in Office2010.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        public RibbonAndBackstageCustomizationsPart? RibbonAndBackstageCustomizationsPart
        {
            get { return GetSubPartOfType<RibbonAndBackstageCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the WebExTaskpanesPart of the PresentationDocument, only available in Office2013.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2013)]
        public WebExTaskpanesPart? WebExTaskpanesPart
        {
            get { return GetSubPartOfType<WebExTaskpanesPart>(); }
        }

        /// <summary>
        /// Gets the LabelInfoPart of the PresentationDocument, only available in Office2021.
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
            return PresentationDocument.Create(stream, DocumentType, OpenSettings.AutoSave);
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
            return PresentationDocument.Open(stream, isEditable, openSettings);
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
            return PresentationDocument.Create(path, DocumentType, OpenSettings.AutoSave);
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
            return PresentationDocument.Open(path, isEditable, openSettings);
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
            return PresentationDocument.Create(package, DocumentType, OpenSettings.AutoSave);
        }

        #endregion Package-based cloning

        #endregion cloning

        internal override IFeatureCollection CreatePartFeatures(IFeatureCollection? other) => new PartContainerFeatureCollection(TypedFeatures.Shared, other);
    }
}
