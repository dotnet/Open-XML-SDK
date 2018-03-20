// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the HandoutMasterPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class HandoutMasterPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster";
        private static PartConstraintCollection _dataPartConstraints;
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Presentation.HandoutMaster _rootElement;

        /// <summary>
        /// Creates an instance of the HandoutMasterPart OpenXmlType
        /// </summary>
        internal protected HandoutMasterPart()
        {
        }

        /// <summary>
        /// Gets the ChartParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<ChartPart> ChartParts => GetPartsOfType<ChartPart>();

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the CustomXmlParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<CustomXmlPart> CustomXmlParts => GetPartsOfType<CustomXmlPart>();

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
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio",
                            PartConstraintRule.Create<AudioReferenceRelationship>(false, true)
                        },
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
        /// Gets the DiagramColorsParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<DiagramColorsPart> DiagramColorsParts => GetPartsOfType<DiagramColorsPart>();

        /// <summary>
        /// Gets the DiagramDataParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<DiagramDataPart> DiagramDataParts => GetPartsOfType<DiagramDataPart>();

        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts => GetPartsOfType<DiagramLayoutDefinitionPart>();

        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts => GetPartsOfType<DiagramPersistLayoutPart>();

        /// <summary>
        /// Gets the DiagramStyleParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<DiagramStylePart> DiagramStyleParts => GetPartsOfType<DiagramStylePart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts => GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Presentation.HandoutMaster HandoutMaster
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Presentation.HandoutMaster>();
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
        /// Gets the ImageParts of the HandoutMasterPart
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
                _rootElement = value as DocumentFormat.OpenXml.Presentation.HandoutMaster;
            }
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

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
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing",
                            PartConstraintRule.Create<VmlDrawingPart>(false, true)
                        },
                        {
                            "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary",
                            PartConstraintRule.Create<EmbeddedControlPersistenceBinaryDataPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme",
                            PartConstraintRule.Create<ThemePart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags",
                            PartConstraintRule.Create<UserDefinedTagsPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",
                            PartConstraintRule.Create<SlidePart>(false, false)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => HandoutMaster;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SlidePart of the HandoutMasterPart
        /// </summary>
        public SlidePart SlidePart => GetSubPartOfType<SlidePart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "handoutMaster";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "handoutMasters";

        /// <summary>
        /// Gets the ThemePart of the HandoutMasterPart
        /// </summary>
        public ThemePart ThemePart => GetSubPartOfType<ThemePart>();

        /// <summary>
        /// Gets the UserDefinedTagsParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts => GetPartsOfType<UserDefinedTagsPart>();

        /// <summary>
        /// Gets the VmlDrawingParts of the HandoutMasterPart
        /// </summary>
        public IEnumerable<VmlDrawingPart> VmlDrawingParts => GetPartsOfType<VmlDrawingPart>();

        /// <summary>
        /// Adds a AudioReferenceRelationship to the HandoutMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the AudioReferenceRelationship</param>
        /// <return>The newly added part</return>
        public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart)
        {return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a AudioReferenceRelationship to the HandoutMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the AudioReferenceRelationship</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
        {return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart, id);
        }

        /// <summary>
        /// Adds a CustomXmlPart to the HandoutMasterPart
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
        /// Adds a CustomXmlPart to the HandoutMasterPart
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
        /// Adds a CustomXmlPart to the HandoutMasterPart
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
        /// Adds a CustomXmlPart to the HandoutMasterPart
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
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the HandoutMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType)
        {
            var childPart = new EmbeddedControlPersistenceBinaryDataPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the HandoutMasterPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(string contentType, string id)
        {
            var childPart = new EmbeddedControlPersistenceBinaryDataPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the HandoutMasterPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType, string id)
        {
            var contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistenceBinaryDataPart(contentType, id);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart to the HandoutMasterPart
        /// </summary>
        /// <param name="partType">The part type of the EmbeddedControlPersistenceBinaryDataPart</param>
        /// <return>The newly added part</return>
        public EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart(EmbeddedControlPersistenceBinaryDataPartType partType)
        {
            var contentType = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetContentType(partType);
            var partExtension = EmbeddedControlPersistenceBinaryDataPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddEmbeddedControlPersistenceBinaryDataPart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedObjectPart to the HandoutMasterPart
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
        /// Adds a EmbeddedPackagePart to the HandoutMasterPart
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
        /// Adds a ImagePart to the HandoutMasterPart
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
        /// Adds a ImagePart to the HandoutMasterPart
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
        /// Adds a ImagePart to the HandoutMasterPart
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
        /// Adds a ImagePart to the HandoutMasterPart
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
        /// Adds a VideoReferenceRelationship to the HandoutMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
        {return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the HandoutMasterPart
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
                case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
                case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
                case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
                case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();
                case EmbeddedControlPersistenceBinaryDataPart.RelationshipTypeConstant:
                    return new EmbeddedControlPersistenceBinaryDataPart();
                case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();
                case UserDefinedTagsPart.RelationshipTypeConstant:
                    return new UserDefinedTagsPart();
                case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
