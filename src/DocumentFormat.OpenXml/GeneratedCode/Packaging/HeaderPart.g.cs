// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the HeaderPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class HeaderPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/header";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the HeaderPart OpenXmlType
        /// </summary>
        internal protected HeaderPart()
        {
        }

        /// <summary>
        /// Gets the AlternativeFormatImportParts of the HeaderPart
        /// </summary>
        public IEnumerable<AlternativeFormatImportPart> AlternativeFormatImportParts => GetPartsOfType<AlternativeFormatImportPart>();

        /// <summary>
        /// Gets the ChartParts of the HeaderPart
        /// </summary>
        public IEnumerable<ChartPart> ChartParts => GetPartsOfType<ChartPart>();

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the DiagramColorsParts of the HeaderPart
        /// </summary>
        public IEnumerable<DiagramColorsPart> DiagramColorsParts => GetPartsOfType<DiagramColorsPart>();

        /// <summary>
        /// Gets the DiagramDataParts of the HeaderPart
        /// </summary>
        public IEnumerable<DiagramDataPart> DiagramDataParts => GetPartsOfType<DiagramDataPart>();

        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the HeaderPart
        /// </summary>
        public IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts => GetPartsOfType<DiagramLayoutDefinitionPart>();

        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the HeaderPart
        /// </summary>
        public IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts => GetPartsOfType<DiagramPersistLayoutPart>();

        /// <summary>
        /// Gets the DiagramStyleParts of the HeaderPart
        /// </summary>
        public IEnumerable<DiagramStylePart> DiagramStyleParts => GetPartsOfType<DiagramStylePart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceParts of the HeaderPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistencePart> EmbeddedControlPersistenceParts => GetPartsOfType<EmbeddedControlPersistencePart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the HeaderPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the HeaderPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the ImageParts of the HeaderPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "header";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        /// <summary>
        /// Adds a AlternativeFormatImportPart to the HeaderPart
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
        /// Adds a AlternativeFormatImportPart to the HeaderPart
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
        /// Adds a AlternativeFormatImportPart to the HeaderPart
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
        /// Adds a AlternativeFormatImportPart to the HeaderPart
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
        /// Adds a EmbeddedControlPersistencePart to the HeaderPart
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
        /// Adds a EmbeddedControlPersistencePart to the HeaderPart
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
        /// Adds a EmbeddedControlPersistencePart to the HeaderPart
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
        /// Adds a EmbeddedControlPersistencePart to the HeaderPart
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
        /// Adds a EmbeddedObjectPart to the HeaderPart
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
        /// Adds a EmbeddedPackagePart to the HeaderPart
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
        /// Adds a ImagePart to the HeaderPart
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
        /// Adds a ImagePart to the HeaderPart
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
        /// Adds a ImagePart to the HeaderPart
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
        /// Adds a ImagePart to the HeaderPart
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
        /// Adds a VideoReferenceRelationship to the HeaderPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
        {return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the HeaderPart
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
