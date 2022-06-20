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
    /// Defines SpreadsheetDocument - an OpenXmlPackage represents a Spreadsheet document.
    /// </summary>
    [PartConstraint(typeof(WorkbookPart), true, false)]
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
    public partial class SpreadsheetDocument : OpenXmlPackage
    {
        /// <summary>
        /// Gets the relationship type of the main part.
        /// </summary>
        internal sealed override string MainPartRelationshipType => WorkbookPart.RelationshipTypeConstant;

        private static Dictionary<SpreadsheetDocumentType, string>? _validMainPartContentType;

        private static Dictionary<SpreadsheetDocumentType, string> MainPartContentTypes
        {
            get
            {
                if (_validMainPartContentType is null)
                {
                    _validMainPartContentType = new Dictionary<SpreadsheetDocumentType, string>
                    {
                        { SpreadsheetDocumentType.Workbook, @"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml" },
                        { SpreadsheetDocumentType.Template, @"application/vnd.openxmlformats-officedocument.spreadsheetml.template.main+xml" },
                        { SpreadsheetDocumentType.MacroEnabledWorkbook, @"application/vnd.ms-excel.sheet.macroEnabled.main+xml" },
                        { SpreadsheetDocumentType.MacroEnabledTemplate, @"application/vnd.ms-excel.template.macroEnabled.main+xml" },
                        { SpreadsheetDocumentType.AddIn, @"application/vnd.ms-excel.addin.macroEnabled.main+xml" },
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
        /// Creates a SpreadsheetDocument.
        /// </summary>
        [Obsolete(ObsoleteMessage)]
        protected SpreadsheetDocument()
            : base()
        {
        }

        private SpreadsheetDocument(in PackageLoader loader, OpenSettings settings)
            : base(loader, settings)
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
                return _documentType;
            }

            private set
            {
                ThrowIfObjectDisposed();
                _documentType = value;
            }
        }

        internal override ApplicationType ApplicationType => ApplicationType.Excel;

        private void UpdateDocumentTypeFromContentType()
        {
            if (MainPartContentType is null)
            {
                throw new InvalidOperationException();
            }

            foreach (KeyValuePair<SpreadsheetDocumentType, string> types in MainPartContentTypes)
            {
                if (types.Value == MainPartContentType)
                {
                    DocumentType = types.Key;
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
        /// Creates a new instance of the SpreadsheetDocument class from the specified package.
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
            => new SpreadsheetDocument(PackageLoader.CreateCore(path), new OpenSettings { AutoSave = autoSave })
            {
                DocumentType = type,
                MainPartContentType = MainPartContentTypes[type],
            };

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
            => new SpreadsheetDocument(PackageLoader.CreateCore(stream), new OpenSettings { AutoSave = autoSave })
            {
                DocumentType = type,
                MainPartContentType = MainPartContentTypes[type],
            };

        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the specified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="type">The type of the SpreadsheetDocument.</param>
        /// <param name="autoSave">Whether to auto save the created document.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "package" is null reference.</exception>
        /// <exception cref="IOException">Thrown when "package" is not opened with Write access.</exception>
        public static SpreadsheetDocument Create(Package package, SpreadsheetDocumentType type, bool autoSave)
            => new SpreadsheetDocument(PackageLoader.CreateCore(package), new OpenSettings { AutoSave = autoSave })
            {
                DocumentType = type,
                MainPartContentType = MainPartContentTypes[type],
            };

        /// <summary>
        /// Creates an editable SpreadsheetDocument from a template, opened on
        /// a MemoryStream with expandable capacity.
        /// </summary>
        /// <param name="path">The path and file name of the template.</param>
        /// <returns>The new SpreadsheetDocument based on and linked to the template.</returns>
        public static SpreadsheetDocument CreateFromTemplate(string path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            // Check extensions as the template must have a valid Word Open XML extension.
            string extension = Path.GetExtension(path);

            if (extension != ".xlsx" && extension != ".xlsm" && extension != ".xltx" && extension != ".xltm")
            {
                throw new ArgumentException($"Illegal template file: {path}", nameof(path));
            }

            using (SpreadsheetDocument template = SpreadsheetDocument.Open(path, false))
            {
                // We've opened the template in read-only mode to let multiple processes or
                // threads open it without running into problems.
                SpreadsheetDocument document = (SpreadsheetDocument)template.Clone();

                // If the template is a document rather than a template, we are done.
                if (extension == ".xlsx" || extension == ".xlsm")
                {
                    return document;
                }

                // Otherwise, we'll have to do some more work.
                // Firstly, we'll change the document type from Template to Document.
                document.ChangeDocumentType(SpreadsheetDocumentType.Workbook);

                // We are done, so save and return.
                // TODO: Check whether it would be safe to return without saving.
                document.Save();
                return document;
            }
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
            if (openSettings is null)
            {
                throw new ArgumentNullException(nameof(openSettings));
            }

            if (openSettings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess
                && !openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions.Any())
            {
                throw new ArgumentException(ExceptionMessages.InvalidMCMode);
            }

            var doc = new SpreadsheetDocument(PackageLoader.OpenCore(path, isEditable), openSettings);

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
        public static SpreadsheetDocument Open(Stream stream, bool isEditable, OpenSettings openSettings)
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

            var doc = new SpreadsheetDocument(PackageLoader.OpenCore(stream, isEditable), openSettings);

            if (MainPartContentTypes[doc.DocumentType] != doc.MainPartContentType)
            {
                doc.UpdateDocumentTypeFromContentType();
            }

            return doc;
        }

        /// <summary>
        /// Creates a new instance of the SpreadsheetDocument class from the specified package.
        /// </summary>
        /// <param name="package">The specified OpenXml package.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of SpreadsheetDocument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when package is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when package is not opened with read access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not a valid Open XML document.</exception>
        /// <exception cref="ArgumentException">Thrown when specified to process the markup compatibility but the given target FileFormatVersion is incorrect.</exception>
        public static SpreadsheetDocument Open(Package package, OpenSettings openSettings)
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

            var doc = new SpreadsheetDocument(PackageLoader.OpenCore(package), openSettings);

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
        /// Creates a new instance of the SpreadsheetDocument class from the specified package.
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

            if (newType == DocumentType)
            {
                // same type, just return
                return;
            }

            if (FileOpenAccess == FileAccess.Read)
            {
                throw new IOException(ExceptionMessages.PackageAccessModeIsReadonly);
            }

            SpreadsheetDocumentType oldType = DocumentType;

            DocumentType = newType;
            MainPartContentType = MainPartContentTypes[newType];

            if (WorkbookPart is null)
            {
                return;
            }

            try
            {
                ChangeDocumentTypeInternal(static () => new WorkbookPart());
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
                WorkbookPart.RelationshipTypeConstant => new WorkbookPart(),
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
        /// <remarks>Mainly used for adding not-fixed content type part - ImagePart, etc.</remarks>
        public override T AddNewPart<T>(string contentType, string id)
        {
            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (typeof(WorkbookPart).GetTypeInfo().IsAssignableFrom(typeof(T).GetTypeInfo()) && contentType != SpreadsheetDocument.MainPartContentTypes[_documentType])
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
            InitPart(childPart, MainPartContentType);
            return childPart;
        }

        /// <summary>
        /// Add a CoreFilePropertiesPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added CoreFilePropertiesPart.</returns>
        public CoreFilePropertiesPart AddCoreFilePropertiesPart()
        {
            CoreFilePropertiesPart childPart = new CoreFilePropertiesPart();
            InitPart(childPart, CoreFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Add a ExtendedFilePropertiesPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added ExtendedFilePropertiesPart.</returns>
        public ExtendedFilePropertiesPart AddExtendedFilePropertiesPart()
        {
            ExtendedFilePropertiesPart childPart = new ExtendedFilePropertiesPart();
            InitPart(childPart, ExtendedFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Add a CustomFilePropertiesPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added CustomFilePropertiesPart.</returns>
        public CustomFilePropertiesPart AddCustomFilePropertiesPart()
        {
            CustomFilePropertiesPart childPart = new CustomFilePropertiesPart();
            InitPart(childPart, CustomFilePropertiesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Add a DigitalSignatureOriginPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added DigitalSignatureOriginPart.</returns>
        public DigitalSignatureOriginPart AddDigitalSignatureOriginPart()
        {
            DigitalSignatureOriginPart childPart = new DigitalSignatureOriginPart();
            InitPart(childPart, DigitalSignatureOriginPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Add a ThumbnailPart to the SpreadsheetDocument.
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
        public QuickAccessToolbarCustomizationsPart AddQuickAccessToolbarCustomizationsPart()
        {
            QuickAccessToolbarCustomizationsPart childPart = new QuickAccessToolbarCustomizationsPart();
            InitPart(childPart, QuickAccessToolbarCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a RibbonExtensibilityPart to the SpreadsheetDocument.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonExtensibilityPart AddRibbonExtensibilityPart()
        {
            RibbonExtensibilityPart childPart = new RibbonExtensibilityPart();
            InitPart(childPart, RibbonExtensibilityPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a RibbonAndBackstageCustomizationsPart to the SpreadsheetDocument, this part is only available in Office2010.
        /// </summary>
        /// <returns>The newly added RibbonExtensibilityPart.</returns>
        public RibbonAndBackstageCustomizationsPart AddRibbonAndBackstageCustomizationsPart()
        {
            RibbonAndBackstageCustomizationsPart childPart = new RibbonAndBackstageCustomizationsPart();
            InitPart(childPart, RibbonAndBackstageCustomizationsPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a WebExTaskpanesPart to the SpreadsheetDocument, this part is only available in Office2013.
        /// </summary>
        /// <returns>The newly added WebExTaskpanesPart.</returns>
        public WebExTaskpanesPart AddWebExTaskpanesPart()
        {
            WebExTaskpanesPart childPart = new WebExTaskpanesPart();
            InitPart(childPart, WebExTaskpanesPart.ContentTypeConstant);
            return childPart;
        }

        /// <summary>
        /// Adds a LabelInfoPart to the SpreadsheetDocument, this part is only available in Office2021.
        /// </summary>
        /// <returns>The newly added LabelInfoPart.</returns>
        public LabelInfoPart AddLabelInfoPart()
        {
            LabelInfoPart childPart = new LabelInfoPart();
            InitPart(childPart, LabelInfoPart.ContentTypeConstant);
            return childPart;
        }

        /// <inheritdoc />
        public override OpenXmlPart? RootPart => WorkbookPart;

        /// <summary>
        /// Gets the WorkbookPart of the SpreadsheetDocument.
        /// </summary>
        public WorkbookPart? WorkbookPart
        {
            get { return GetSubPartOfType<WorkbookPart>(); }
        }

        /// <summary>
        /// Gets the CoreFilePropertiesPart of the SpreadsheetDocument.
        /// </summary>
        public CoreFilePropertiesPart? CoreFilePropertiesPart
        {
            get { return GetSubPartOfType<CoreFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the ExtendedFilePropertiesPart of the SpreadsheetDocument.
        /// </summary>
        public ExtendedFilePropertiesPart? ExtendedFilePropertiesPart
        {
            get { return GetSubPartOfType<ExtendedFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the CustomFilePropertiesPart of the SpreadsheetDocument.
        /// </summary>
        public CustomFilePropertiesPart? CustomFilePropertiesPart
        {
            get { return GetSubPartOfType<CustomFilePropertiesPart>(); }
        }

        /// <summary>
        /// Gets the ThumbnailPart of the SpreadsheetDocument.
        /// </summary>
        public ThumbnailPart? ThumbnailPart
        {
            get { return GetSubPartOfType<ThumbnailPart>(); }
        }

        /// <summary>
        /// Gets the RibbonExtensibilityPart of the SpreadsheetDocument.
        /// </summary>
        public RibbonExtensibilityPart? RibbonExtensibilityPart
        {
            get { return GetSubPartOfType<RibbonExtensibilityPart>(); }
        }

        /// <summary>
        /// Gets the QuickAccessToolbarCustomizationsPart of the SpreadsheetDocument.
        /// </summary>
        public QuickAccessToolbarCustomizationsPart? QuickAccessToolbarCustomizationsPart
        {
            get { return GetSubPartOfType<QuickAccessToolbarCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the DigitalSignatureOriginPart of the SpreadsheetDocument.
        /// </summary>
        public DigitalSignatureOriginPart? DigitalSignatureOriginPart
        {
            get { return GetSubPartOfType<DigitalSignatureOriginPart>(); }
        }

        /// <summary>
        /// Gets the RibbonAndBackstageCustomizationsPart of the SpreadsheetDocument, only available in Office2010.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2010)]
        public RibbonAndBackstageCustomizationsPart? RibbonAndBackstageCustomizationsPart
        {
            get { return GetSubPartOfType<RibbonAndBackstageCustomizationsPart>(); }
        }

        /// <summary>
        /// Gets the WebExTaskpanesPart of the SpreadsheetDocument, only available in Office2013.
        /// </summary>
        [OfficeAvailability(FileFormatVersions.Office2013)]
        public WebExTaskpanesPart? WebExTaskpanesPart
        {
            get { return GetSubPartOfType<WebExTaskpanesPart>(); }
        }

        /// <summary>
        /// Gets the LabelInfoPart of the SpreadsheetDocument, only available in Office2021.
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
            return SpreadsheetDocument.Create(stream, DocumentType, OpenSettings.AutoSave);
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
            return SpreadsheetDocument.Open(stream, isEditable, openSettings);
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
            return SpreadsheetDocument.Create(path, DocumentType, OpenSettings.AutoSave);
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
            return SpreadsheetDocument.Open(path, isEditable, openSettings);
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
            return SpreadsheetDocument.Create(package, DocumentType, OpenSettings.AutoSave);
        }

        #endregion Package-based cloning

        #endregion cloning

        internal override IFeatureCollection CreatePartFeatures(IFeatureCollection? other) => new PartContainerFeatureCollection(TypedFeatures.Shared, other);
    }
}
