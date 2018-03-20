// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the PresentationPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class PresentationPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Presentation.Presentation _rootElement;

        /// <summary>
        /// Creates an instance of the PresentationPart OpenXmlType
        /// </summary>
        internal protected PresentationPart()
        {
        }

        /// <summary>
        /// Gets the CommentAuthorsPart of the PresentationPart
        /// </summary>
        public CommentAuthorsPart CommentAuthorsPart => GetSubPartOfType<CommentAuthorsPart>();

        /// <summary>
        /// Gets the CustomXmlParts of the PresentationPart
        /// </summary>
        public IEnumerable<CustomXmlPart> CustomXmlParts => GetPartsOfType<CustomXmlPart>();

        /// <summary>
        /// Gets the FontParts of the PresentationPart
        /// </summary>
        public IEnumerable<FontPart> FontParts => GetPartsOfType<FontPart>();

        /// <summary>
        /// Gets the HandoutMasterPart of the PresentationPart
        /// </summary>
        public HandoutMasterPart HandoutMasterPart => GetSubPartOfType<HandoutMasterPart>();

        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Presentation.Presentation;
            }
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => false;

        /// <summary>
        /// Gets the LegacyDiagramTextInfoPart of the PresentationPart
        /// </summary>
        public LegacyDiagramTextInfoPart LegacyDiagramTextInfoPart => GetSubPartOfType<LegacyDiagramTextInfoPart>();

        /// <summary>
        /// Gets the NotesMasterPart of the PresentationPart
        /// </summary>
        public NotesMasterPart NotesMasterPart => GetSubPartOfType<NotesMasterPart>();

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
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font",
                            PartConstraintRule.Create<FontPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps",
                            PartConstraintRule.Create<PresentationPropertiesPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles",
                            PartConstraintRule.Create<TableStylesPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme",
                            PartConstraintRule.Create<ThemePart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps",
                            PartConstraintRule.Create<ViewPropertiesPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster",
                            PartConstraintRule.Create<NotesMasterPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",
                            PartConstraintRule.Create<SlidePart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster",
                            PartConstraintRule.Create<SlideMasterPart>(true, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags",
                            PartConstraintRule.Create<UserDefinedTagsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors",
                            PartConstraintRule.Create<CommentAuthorsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster",
                            PartConstraintRule.Create<HandoutMasterPart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2006/relationships/legacyDocTextInfo",
                            PartConstraintRule.Create<LegacyDiagramTextInfoPart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2006/relationships/vbaProject",
                            PartConstraintRule.Create<VbaProjectPart>(false, false)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => Presentation;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Presentation.Presentation Presentation
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Presentation.Presentation>();
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
        /// Gets the PresentationPropertiesPart of the PresentationPart
        /// </summary>
        public PresentationPropertiesPart PresentationPropertiesPart => GetSubPartOfType<PresentationPropertiesPart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SlideMasterParts of the PresentationPart
        /// </summary>
        public IEnumerable<SlideMasterPart> SlideMasterParts => GetPartsOfType<SlideMasterPart>();

        /// <summary>
        /// Gets the SlideParts of the PresentationPart
        /// </summary>
        public IEnumerable<SlidePart> SlideParts => GetPartsOfType<SlidePart>();

        /// <summary>
        /// Gets the TableStylesPart of the PresentationPart
        /// </summary>
        public TableStylesPart TableStylesPart => GetSubPartOfType<TableStylesPart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "presentation";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "ppt";

        /// <summary>
        /// Gets the ThemePart of the PresentationPart
        /// </summary>
        public ThemePart ThemePart => GetSubPartOfType<ThemePart>();

        /// <summary>
        /// Gets the UserDefinedTagsPart of the PresentationPart
        /// </summary>
        public UserDefinedTagsPart UserDefinedTagsPart => GetSubPartOfType<UserDefinedTagsPart>();

        /// <summary>
        /// Gets the VbaProjectPart of the PresentationPart
        /// </summary>
        public VbaProjectPart VbaProjectPart => GetSubPartOfType<VbaProjectPart>();

        /// <summary>
        /// Gets the ViewPropertiesPart of the PresentationPart
        /// </summary>
        public ViewPropertiesPart ViewPropertiesPart => GetSubPartOfType<ViewPropertiesPart>();

        /// <summary>
        /// Adds a CustomXmlPart to the PresentationPart
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
        /// Adds a CustomXmlPart to the PresentationPart
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
        /// Adds a CustomXmlPart to the PresentationPart
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
        /// Adds a CustomXmlPart to the PresentationPart
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
        /// Adds a FontPart to the PresentationPart
        /// </summary>
        /// <param name="contentType">The content type of the FontPart</param>
        /// <return>The newly added part</return>
        public FontPart AddFontPart(string contentType)
        {
            var childPart = new FontPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a FontPart to the PresentationPart
        /// </summary>
        /// <param name="contentType">The content type of the FontPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public FontPart AddFontPart(string contentType, string id)
        {
            var childPart = new FontPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a FontPart to the PresentationPart
        /// </summary>
        /// <param name="partType">The part type of the FontPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public FontPart AddFontPart(FontPartType partType, string id)
        {
            var contentType = FontPartTypeInfo.GetContentType(partType);
            var partExtension = FontPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddFontPart(contentType, id);
        }

        /// <summary>
        /// Adds a FontPart to the PresentationPart
        /// </summary>
        /// <param name="partType">The part type of the FontPart</param>
        /// <return>The newly added part</return>
        public FontPart AddFontPart(FontPartType partType)
        {
            var contentType = FontPartTypeInfo.GetContentType(partType);
            var partExtension = FontPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddFontPart(contentType);
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
                case FontPart.RelationshipTypeConstant:
                    return new FontPart();
                case PresentationPropertiesPart.RelationshipTypeConstant:
                    return new PresentationPropertiesPart();
                case TableStylesPart.RelationshipTypeConstant:
                    return new TableStylesPart();
                case ThemePart.RelationshipTypeConstant:
                    return new ThemePart();
                case ViewPropertiesPart.RelationshipTypeConstant:
                    return new ViewPropertiesPart();
                case NotesMasterPart.RelationshipTypeConstant:
                    return new NotesMasterPart();
                case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();
                case SlideMasterPart.RelationshipTypeConstant:
                    return new SlideMasterPart();
                case UserDefinedTagsPart.RelationshipTypeConstant:
                    return new UserDefinedTagsPart();
                case CommentAuthorsPart.RelationshipTypeConstant:
                    return new CommentAuthorsPart();
                case HandoutMasterPart.RelationshipTypeConstant:
                    return new HandoutMasterPart();
                case LegacyDiagramTextInfoPart.RelationshipTypeConstant:
                    return new LegacyDiagramTextInfoPart();
                case VbaProjectPart.RelationshipTypeConstant:
                    return new VbaProjectPart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
