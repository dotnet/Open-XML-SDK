// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the GlossaryDocumentPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class GlossaryDocumentPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.document.glossary+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the GlossaryDocumentPart OpenXmlType
        /// </summary>
        internal protected GlossaryDocumentPart()
        {
        }

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts => GetPartsOfType<AlternativeFormatImportPart>();

        /// <summary>
        /// Gets the ChartParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<ChartPart> ChartParts => GetPartsOfType<ChartPart>();

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the CustomizationPart of the GlossaryDocumentPart
        /// </summary>
        public CustomizationPart CustomizationPart => GetSubPartOfType<CustomizationPart>();

        /// <summary>
        /// Gets the DiagramColorsParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<DiagramColorsPart> DiagramColorsParts => GetPartsOfType<DiagramColorsPart>();

        /// <summary>
        /// Gets the DiagramDataParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<DiagramDataPart> DiagramDataParts => GetPartsOfType<DiagramDataPart>();

        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts => GetPartsOfType<DiagramLayoutDefinitionPart>();

        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts => GetPartsOfType<DiagramPersistLayoutPart>();

        /// <summary>
        /// Gets the DiagramStyleParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<DiagramStylePart> DiagramStyleParts => GetPartsOfType<DiagramStylePart>();

        /// <summary>
        /// Gets the DocumentSettingsPart of the GlossaryDocumentPart
        /// </summary>
        public DocumentSettingsPart DocumentSettingsPart => GetSubPartOfType<DocumentSettingsPart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts => GetPartsOfType<EmbeddedControlPersistencePart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the EndnotesPart of the GlossaryDocumentPart
        /// </summary>
        public EndnotesPart EndnotesPart => GetSubPartOfType<EndnotesPart>();

        /// <summary>
        /// Gets the FontTablePart of the GlossaryDocumentPart
        /// </summary>
        public FontTablePart FontTablePart => GetSubPartOfType<FontTablePart>();

        /// <summary>
        /// Gets the FooterParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<FooterPart> FooterParts => GetPartsOfType<FooterPart>();

        /// <summary>
        /// Gets the FootnotesPart of the GlossaryDocumentPart
        /// </summary>
        public FootnotesPart FootnotesPart => GetSubPartOfType<FootnotesPart>();

        /// <summary>
        /// Gets the HeaderParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<HeaderPart> HeaderParts => GetPartsOfType<HeaderPart>();

        /// <summary>
        /// Gets the ImageParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <summary>
        /// Gets the NumberingDefinitionsPart of the GlossaryDocumentPart
        /// </summary>
        public NumberingDefinitionsPart NumberingDefinitionsPart => GetSubPartOfType<NumberingDefinitionsPart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the StyleDefinitionsPart of the GlossaryDocumentPart
        /// </summary>
        public StyleDefinitionsPart StyleDefinitionsPart => GetSubPartOfType<StyleDefinitionsPart>();

        /// <summary>
        /// Gets the StylesWithEffectsPart of the GlossaryDocumentPart
        /// </summary>
        public StylesWithEffectsPart StylesWithEffectsPart => GetSubPartOfType<StylesWithEffectsPart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "document";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "glossary";

        /// <summary>
        /// Gets the VbaProjectPart of the GlossaryDocumentPart
        /// </summary>
        public VbaProjectPart VbaProjectPart => GetSubPartOfType<VbaProjectPart>();

        /// <summary>
        /// Gets the WebSettingsPart of the GlossaryDocumentPart
        /// </summary>
        public WebSettingsPart WebSettingsPart => GetSubPartOfType<WebSettingsPart>();

        /// <summary>
        /// Gets the WordprocessingCommentsExPart of the GlossaryDocumentPart
        /// </summary>
        public WordprocessingCommentsExPart WordprocessingCommentsExPart => GetSubPartOfType<WordprocessingCommentsExPart>();

        /// <summary>
        /// Gets the WordprocessingCommentsPart of the GlossaryDocumentPart
        /// </summary>
        public WordprocessingCommentsPart WordprocessingCommentsPart => GetSubPartOfType<WordprocessingCommentsPart>();

        /// <summary>
        /// Gets the WordprocessingPeoplePart of the GlossaryDocumentPart
        /// </summary>
        public WordprocessingPeoplePart WordprocessingPeoplePart => GetSubPartOfType<WordprocessingPeoplePart>();

        /// <summary>
        /// Gets the WordprocessingPrinterSettingsParts of the GlossaryDocumentPart
        /// </summary>
        public IEnumerable<WordprocessingPrinterSettingsPart> WordprocessingPrinterSettingsParts => GetPartsOfType<WordprocessingPrinterSettingsPart>();

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart
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
        /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart
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
        /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart
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
        /// Adds a AlternativeFormatImportPart to the GlossaryDocumentPart
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
        /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart
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
        /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart
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
        /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart
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
        /// Adds a EmbeddedControlPersistencePart to the GlossaryDocumentPart
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
        /// Adds a EmbeddedObjectPart to the GlossaryDocumentPart
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
        /// Adds a EmbeddedPackagePart to the GlossaryDocumentPart
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
        /// Adds a ImagePart to the GlossaryDocumentPart
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
        /// Adds a ImagePart to the GlossaryDocumentPart
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
        /// Adds a ImagePart to the GlossaryDocumentPart
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
        /// Adds a ImagePart to the GlossaryDocumentPart
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
        /// Adds a VideoReferenceRelationship to the GlossaryDocumentPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
        {return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the GlossaryDocumentPart
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

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint is null)
            {
                _dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal)
                {
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/video",
                        new PartConstraintRule(nameof(VideoReferenceRelationship), null, false, true, FileFormatVersions.Office2007.AndLater())
                    }
                };
            }

            return _dataPartReferenceConstraint;
        }

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint is null)
            {
                _partConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal)
                {
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",
                        new PartConstraintRule(nameof(WordprocessingCommentsPart), WordprocessingCommentsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings",
                        new PartConstraintRule(nameof(DocumentSettingsPart), DocumentSettingsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes",
                        new PartConstraintRule(nameof(EndnotesPart), EndnotesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable",
                        new PartConstraintRule(nameof(FontTablePart), FontTablePart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes",
                        new PartConstraintRule(nameof(FootnotesPart), FootnotesPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering",
                        new PartConstraintRule(nameof(NumberingDefinitionsPart), NumberingDefinitionsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",
                        new PartConstraintRule(nameof(StyleDefinitionsPart), StyleDefinitionsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects",
                        new PartConstraintRule(nameof(StylesWithEffectsPart), StylesWithEffectsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2010.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings",
                        new PartConstraintRule(nameof(WebSettingsPart), WebSettingsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer",
                        new PartConstraintRule(nameof(FooterPart), FooterPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header",
                        new PartConstraintRule(nameof(HeaderPart), HeaderPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings",
                        new PartConstraintRule(nameof(WordprocessingPrinterSettingsPart), WordprocessingPrinterSettingsPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2006/relationships/keyMapCustomizations",
                        new PartConstraintRule(nameof(CustomizationPart), CustomizationPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2006/relationships/vbaProject",
                        new PartConstraintRule(nameof(VbaProjectPart), VbaProjectPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2011/relationships/commentsExtended",
                        new PartConstraintRule(nameof(WordprocessingCommentsExPart), WordprocessingCommentsExPart.ContentTypeConstant, false, false, FileFormatVersions.Office2013.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2011/relationships/people",
                        new PartConstraintRule(nameof(WordprocessingPeoplePart), WordprocessingPeoplePart.ContentTypeConstant, false, false, FileFormatVersions.Office2013.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk",
                        new PartConstraintRule(nameof(AlternativeFormatImportPart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart",
                        new PartConstraintRule(nameof(ChartPart), ChartPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors",
                        new PartConstraintRule(nameof(DiagramColorsPart), DiagramColorsPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData",
                        new PartConstraintRule(nameof(DiagramDataPart), DiagramDataPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing",
                        new PartConstraintRule(nameof(DiagramPersistLayoutPart), DiagramPersistLayoutPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout",
                        new PartConstraintRule(nameof(DiagramLayoutDefinitionPart), DiagramLayoutDefinitionPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle",
                        new PartConstraintRule(nameof(DiagramStylePart), DiagramStylePart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/control",
                        new PartConstraintRule(nameof(EmbeddedControlPersistencePart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",
                        new PartConstraintRule(nameof(EmbeddedObjectPart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",
                        new PartConstraintRule(nameof(EmbeddedPackagePart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
                        new PartConstraintRule(nameof(ImagePart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    }
                };
            }

            return _partConstraint;
        }
    }
}
