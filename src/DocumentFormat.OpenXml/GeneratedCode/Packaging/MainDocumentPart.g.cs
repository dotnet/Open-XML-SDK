// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the MainDocumentPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class MainDocumentPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
        private static PartConstraintCollection _dataPartConstraints;
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Wordprocessing.Document _rootElement;

        /// <summary>
        /// Creates an instance of the MainDocumentPart OpenXmlType
        /// </summary>
        internal protected MainDocumentPart()
        {
        }

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts => GetPartsOfType<AlternativeFormatImportPart>();

        /// <summary>
        /// Gets the ChartParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<ChartPart> ChartParts => GetPartsOfType<ChartPart>();

        /// <summary>
        /// Gets the CustomXmlParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<CustomXmlPart> CustomXmlParts => GetPartsOfType<CustomXmlPart>();

        /// <summary>
        /// Gets the CustomizationPart of the MainDocumentPart
        /// </summary>
        public CustomizationPart CustomizationPart => GetSubPartOfType<CustomizationPart>();

        /// <inheritdoc/>
        internal sealed override PartConstraintCollection DataPartReferenceConstraints
        {
            get
            {
                if (_dataPartConstraints is null)
                {
                    _dataPartConstraints = new PartConstraintCollection
                    {
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video",
                            PartConstraintRule.Create<VideoReferenceRelationship>(false, true)
                        }
                    };
                }

                return _dataPartConstraints;
            }
        }

        /// <summary>
        /// Gets the DiagramColorsParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<DiagramColorsPart> DiagramColorsParts => GetPartsOfType<DiagramColorsPart>();

        /// <summary>
        /// Gets the DiagramDataParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<DiagramDataPart> DiagramDataParts => GetPartsOfType<DiagramDataPart>();

        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts => GetPartsOfType<DiagramLayoutDefinitionPart>();

        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts => GetPartsOfType<DiagramPersistLayoutPart>();

        /// <summary>
        /// Gets the DiagramStyleParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<DiagramStylePart> DiagramStyleParts => GetPartsOfType<DiagramStylePart>();

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Wordprocessing.Document Document
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Wordprocessing.Document>();
                }

                return _rootElement;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        /// <summary>
        /// Gets the DocumentSettingsPart of the MainDocumentPart
        /// </summary>
        public DocumentSettingsPart DocumentSettingsPart => GetSubPartOfType<DocumentSettingsPart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts => GetPartsOfType<EmbeddedControlPersistencePart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the EndnotesPart of the MainDocumentPart
        /// </summary>
        public EndnotesPart EndnotesPart => GetSubPartOfType<EndnotesPart>();

        /// <summary>
        /// Gets the FontTablePart of the MainDocumentPart
        /// </summary>
        public FontTablePart FontTablePart => GetSubPartOfType<FontTablePart>();

        /// <summary>
        /// Gets the FooterParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<FooterPart> FooterParts => GetPartsOfType<FooterPart>();

        /// <summary>
        /// Gets the FootnotesPart of the MainDocumentPart
        /// </summary>
        public FootnotesPart FootnotesPart => GetSubPartOfType<FootnotesPart>();

        /// <summary>
        /// Gets the GlossaryDocumentPart of the MainDocumentPart
        /// </summary>
        public GlossaryDocumentPart GlossaryDocumentPart => GetSubPartOfType<GlossaryDocumentPart>();

        /// <summary>
        /// Gets the HeaderParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<HeaderPart> HeaderParts => GetPartsOfType<HeaderPart>();

        /// <summary>
        /// Gets the ImageParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Wordprocessing.Document;
            }
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => false;

        /// <summary>
        /// Gets the NumberingDefinitionsPart of the MainDocumentPart
        /// </summary>
        public NumberingDefinitionsPart NumberingDefinitionsPart => GetSubPartOfType<NumberingDefinitionsPart>();

        /// <inheritdoc/>
        internal sealed override PartConstraintCollection PartConstraints
        {
            get
            {
                if (_partConstraints is null)
                {
                    _partConstraints = new PartConstraintCollection
                    {
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml",
                            PartConstraintRule.Create<CustomXmlPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument",
                            PartConstraintRule.Create<GlossaryDocumentPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme",
                            PartConstraintRule.Create<ThemePart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail",
                            PartConstraintRule.Create<ThumbnailPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",
                            PartConstraintRule.Create<WordprocessingCommentsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings",
                            PartConstraintRule.Create<DocumentSettingsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes",
                            PartConstraintRule.Create<EndnotesPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable",
                            PartConstraintRule.Create<FontTablePart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes",
                            PartConstraintRule.Create<FootnotesPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering",
                            PartConstraintRule.Create<NumberingDefinitionsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",
                            PartConstraintRule.Create<StyleDefinitionsPart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects",
                            PartConstraintRule.Create<StylesWithEffectsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings",
                            PartConstraintRule.Create<WebSettingsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer",
                            PartConstraintRule.Create<FooterPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header",
                            PartConstraintRule.Create<HeaderPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings",
                            PartConstraintRule.Create<WordprocessingPrinterSettingsPart>(false, true)
                        },
                        {
                            "http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations",
                            PartConstraintRule.Create<CustomizationPart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2006/relationships/vbaProject",
                            PartConstraintRule.Create<VbaProjectPart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2011/relationships/commentsExtended",
                            PartConstraintRule.Create<WordprocessingCommentsExPart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2011/relationships/people",
                            PartConstraintRule.Create<WordprocessingPeoplePart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk",
                            PartConstraintRule.Create<AlternativeFormatImportPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart",
                            PartConstraintRule.Create<ChartPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors",
                            PartConstraintRule.Create<DiagramColorsPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData",
                            PartConstraintRule.Create<DiagramDataPart>(false, true)
                        },
                        {
                            "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing",
                            PartConstraintRule.Create<DiagramPersistLayoutPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout",
                            PartConstraintRule.Create<DiagramLayoutDefinitionPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle",
                            PartConstraintRule.Create<DiagramStylePart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control",
                            PartConstraintRule.Create<EmbeddedControlPersistencePart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",
                            PartConstraintRule.Create<EmbeddedObjectPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",
                            PartConstraintRule.Create<EmbeddedPackagePart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
                            PartConstraintRule.Create<ImagePart>(false, true)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => Document;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the StyleDefinitionsPart of the MainDocumentPart
        /// </summary>
        public StyleDefinitionsPart StyleDefinitionsPart => GetSubPartOfType<StyleDefinitionsPart>();

        /// <summary>
        /// Gets the StylesWithEffectsPart of the MainDocumentPart
        /// </summary>
        public StylesWithEffectsPart StylesWithEffectsPart => GetSubPartOfType<StylesWithEffectsPart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "document";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "word";

        /// <summary>
        /// Gets the ThemePart of the MainDocumentPart
        /// </summary>
        public ThemePart ThemePart => GetSubPartOfType<ThemePart>();

        /// <summary>
        /// Gets the ThumbnailPart of the MainDocumentPart
        /// </summary>
        public ThumbnailPart ThumbnailPart => GetSubPartOfType<ThumbnailPart>();

        /// <summary>
        /// Gets the VbaProjectPart of the MainDocumentPart
        /// </summary>
        public VbaProjectPart VbaProjectPart => GetSubPartOfType<VbaProjectPart>();

        /// <summary>
        /// Gets the WebSettingsPart of the MainDocumentPart
        /// </summary>
        public WebSettingsPart WebSettingsPart => GetSubPartOfType<WebSettingsPart>();

        /// <summary>
        /// Gets the WordprocessingCommentsExPart of the MainDocumentPart
        /// </summary>
        public WordprocessingCommentsExPart WordprocessingCommentsExPart => GetSubPartOfType<WordprocessingCommentsExPart>();

        /// <summary>
        /// Gets the WordprocessingCommentsPart of the MainDocumentPart
        /// </summary>
        public WordprocessingCommentsPart WordprocessingCommentsPart => GetSubPartOfType<WordprocessingCommentsPart>();

        /// <summary>
        /// Gets the WordprocessingPeoplePart of the MainDocumentPart
        /// </summary>
        public WordprocessingPeoplePart WordprocessingPeoplePart => GetSubPartOfType<WordprocessingPeoplePart>();

        /// <summary>
        /// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
        /// </summary>
        public IEnumerable<WordprocessingPrinterSettingsPart> WordprocessingPrinterSettingsParts => GetPartsOfType<WordprocessingPrinterSettingsPart>();

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the AlternativeFormatImportPart</param>
        /// <return>The newly added part</return>
        public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType)
        {
            var childPart = new AlternativeFormatImportPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the AlternativeFormatImportPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public AlternativeFormatImportPart AddAlternativeFormatImportPart(string contentType, string id)
        {
            var childPart = new AlternativeFormatImportPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the MainDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the AlternativeFormatImportPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType, string id)
        {
            var contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
            var partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddAlternativeFormatImportPart(contentType, id);
        }

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the MainDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the AlternativeFormatImportPart</param>
        /// <return>The newly added part</return>
        public AlternativeFormatImportPart AddAlternativeFormatImportPart(AlternativeFormatImportPartType partType)
        {
            var contentType = AlternativeFormatImportPartTypeInfo.GetContentType(partType);
            var partExtension = AlternativeFormatImportPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddAlternativeFormatImportPart(contentType);
        }

        /// <summary>
        /// Adds a CustomXmlPart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the CustomXmlPart</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(string contentType)
        {
            var childPart = new CustomXmlPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomXmlPart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the CustomXmlPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(string contentType, string id)
        {
            var childPart = new CustomXmlPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomXmlPart to the MainDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the CustomXmlPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType, string id)
        {
            var contentType = CustomXmlPartTypeInfo.GetContentType(partType);
            var partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddCustomXmlPart(contentType, id);
        }

        /// <summary>
        /// Adds a CustomXmlPart to the MainDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the CustomXmlPart</param>
        /// <return>The newly added part</return>
        public CustomXmlPart AddCustomXmlPart(CustomXmlPartType partType)
        {
            var contentType = CustomXmlPartTypeInfo.GetContentType(partType);
            var partExtension = CustomXmlPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddCustomXmlPart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistencePart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType)
        {
            var childPart = new EmbeddedControlPersistencePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistencePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(string contentType, string id)
        {
            var childPart = new EmbeddedControlPersistencePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the MainDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistencePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType, string id)
        {
            var contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistencePart(contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart to the MainDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistencePart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart(EmbeddedControlPersistencePartType partType)
        {
            var contentType = EmbeddedControlPersistencePartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistencePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistencePart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedObjectPart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedObjectPart</param>
        /// <return>The newly added part</return>
        public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
        {
            var childPart = new EmbeddedObjectPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedPackagePart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedPackagePart</param>
        /// <return>The newly added part</return>
        public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
        {
            var childPart = new EmbeddedPackagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType, string id)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the MainDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType, string id)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType, id);
        }

        /// <summary>
        /// Adds a ImagePart to the MainDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType);
        }

        /// <summary>
        /// Adds a ThumbnailPart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the ThumbnailPart</param>
        /// <return>The newly added part</return>
        public ThumbnailPart AddThumbnailPart(string contentType)
        {
            var childPart = new ThumbnailPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ThumbnailPart to the MainDocumentPart
        /// </summary>
        /// <param name="contentType">The content type of the ThumbnailPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ThumbnailPart AddThumbnailPart(string contentType, string id)
        {
            var childPart = new ThumbnailPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ThumbnailPart to the MainDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the ThumbnailPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType, string id)
        {
            var contentType = ThumbnailPartTypeInfo.GetContentType(partType);
            var partExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddThumbnailPart(contentType, id);
        }

        /// <summary>
        /// Adds a ThumbnailPart to the MainDocumentPart
        /// </summary>
        /// <param name="partType">The part type of the ThumbnailPart</param>
        /// <return>The newly added part</return>
        public ThumbnailPart AddThumbnailPart(ThumbnailPartType partType)
        {
            var contentType = ThumbnailPartTypeInfo.GetContentType(partType);
            var partExtension = ThumbnailPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddThumbnailPart(contentType);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the MainDocumentPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
        {return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the MainDocumentPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
        {return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
        }

        /// <inheritdoc/>
        internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
        {
            ThrowIfObjectDisposed();
            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            switch (relationshipType)
            {
                case CustomXmlPart.RelationshipTypeConstant:
                    return new CustomXmlPart();
                case GlossaryDocumentPart.RelationshipTypeConstant:
                    return new GlossaryDocumentPart();
                case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();
                case ThumbnailPart.RelationshipTypeConstant:
                    return new ThumbnailPart();
                case WordprocessingCommentsPart.RelationshipTypeConstant:
                    return new WordprocessingCommentsPart();
                case DocumentSettingsPart.RelationshipTypeConstant:
                    return new DocumentSettingsPart();
                case EndnotesPart.RelationshipTypeConstant:
                    return new EndnotesPart();
                case FontTablePart.RelationshipTypeConstant:
                    return new FontTablePart();
                case FootnotesPart.RelationshipTypeConstant:
                    return new FootnotesPart();
                case NumberingDefinitionsPart.RelationshipTypeConstant:
                    return new NumberingDefinitionsPart();
                case StyleDefinitionsPart.RelationshipTypeConstant:
                    return new StyleDefinitionsPart();
                case StylesWithEffectsPart.RelationshipTypeConstant:
                    return new StylesWithEffectsPart();
                case WebSettingsPart.RelationshipTypeConstant:
                    return new WebSettingsPart();
                case FooterPart.RelationshipTypeConstant:
                    return new FooterPart();
                case HeaderPart.RelationshipTypeConstant:
                    return new HeaderPart();
                case WordprocessingPrinterSettingsPart.RelationshipTypeConstant:
                    return new WordprocessingPrinterSettingsPart();
                case CustomizationPart.RelationshipTypeConstant:
                    return new CustomizationPart();
                case VbaProjectPart.RelationshipTypeConstant:
                    return new VbaProjectPart();
                case WordprocessingCommentsExPart.RelationshipTypeConstant:
                    return new WordprocessingCommentsExPart();
                case WordprocessingPeoplePart.RelationshipTypeConstant:
                    return new WordprocessingPeoplePart();
                case AlternativeFormatImportPart.RelationshipTypeConstant:
                    return new AlternativeFormatImportPart();
                case ChartPart.RelationshipTypeConstant:
                    return new ChartPart();
                case DiagramColorsPart.RelationshipTypeConstant:
                    return new DiagramColorsPart();
                case DiagramDataPart.RelationshipTypeConstant:
                    return new DiagramDataPart();
                case DiagramPersistLayoutPart.RelationshipTypeConstant:
                    return new DiagramPersistLayoutPart();
                case DiagramLayoutDefinitionPart.RelationshipTypeConstant:
                    return new DiagramLayoutDefinitionPart();
                case DiagramStylePart.RelationshipTypeConstant:
                    return new DiagramStylePart();
                case EmbeddedControlPersistencePart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistencePart();
                case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
                case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
                case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
