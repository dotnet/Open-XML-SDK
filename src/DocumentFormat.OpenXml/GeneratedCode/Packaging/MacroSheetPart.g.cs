// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the MacroSheetPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class MacroSheetPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.macrosheet+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/xlMacrosheet";
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Office.Excel.Macrosheet _rootElement;

        /// <summary>
        /// Creates an instance of the MacroSheetPart OpenXmlType
        /// </summary>
        internal protected MacroSheetPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the CustomPropertyParts of the MacroSheetPart
        /// </summary>
        public IEnumerable<CustomPropertyPart> CustomPropertyParts => GetPartsOfType<CustomPropertyPart>();

        /// <summary>
        /// Gets the DrawingsPart of the MacroSheetPart
        /// </summary>
        public DrawingsPart DrawingsPart => GetSubPartOfType<DrawingsPart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the MacroSheetPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the MacroSheetPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the ImageParts of the MacroSheetPart
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
                _rootElement = value as DocumentFormat.OpenXml.Office.Excel.Macrosheet;
            }
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office.Excel.Macrosheet Macrosheet
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office.Excel.Macrosheet>();
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
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings",
                            PartConstraintRule.Create<SpreadsheetPrinterSettingsPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing",
                            PartConstraintRule.Create<DrawingsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing",
                            PartConstraintRule.Create<VmlDrawingPart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",
                            PartConstraintRule.Create<WorksheetCommentsPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty",
                            PartConstraintRule.Create<CustomPropertyPart>(false, true)
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

        internal override OpenXmlPartRootElement PartRootElement => Macrosheet;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the MacroSheetPart
        /// </summary>
        public IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts => GetPartsOfType<SpreadsheetPrinterSettingsPart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "sheet";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "macrosheets";

        /// <summary>
        /// Gets the VmlDrawingParts of the MacroSheetPart
        /// </summary>
        public IEnumerable<VmlDrawingPart> VmlDrawingParts => GetPartsOfType<VmlDrawingPart>();

        /// <summary>
        /// Gets the WorksheetCommentsPart of the MacroSheetPart
        /// </summary>
        public WorksheetCommentsPart WorksheetCommentsPart => GetSubPartOfType<WorksheetCommentsPart>();

        /// <summary>
        /// Adds a CustomPropertyPart to the MacroSheetPart
        /// </summary>
        /// <param name="contentType">The content type of the CustomPropertyPart</param>
        /// <return>The newly added part</return>
        public CustomPropertyPart AddCustomPropertyPart(string contentType)
        {
            var childPart = new CustomPropertyPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomPropertyPart to the MacroSheetPart
        /// </summary>
        /// <param name="contentType">The content type of the CustomPropertyPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public CustomPropertyPart AddCustomPropertyPart(string contentType, string id)
        {
            var childPart = new CustomPropertyPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomPropertyPart to the MacroSheetPart
        /// </summary>
        /// <param name="partType">The part type of the CustomPropertyPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType, string id)
        {
            var contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
            var partExtension = CustomPropertyPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddCustomPropertyPart(contentType, id);
        }

        /// <summary>
        /// Adds a CustomPropertyPart to the MacroSheetPart
        /// </summary>
        /// <param name="partType">The part type of the CustomPropertyPart</param>
        /// <return>The newly added part</return>
        public CustomPropertyPart AddCustomPropertyPart(CustomPropertyPartType partType)
        {
            var contentType = CustomPropertyPartTypeInfo.GetContentType(partType);
            var partExtension = CustomPropertyPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddCustomPropertyPart(contentType);
        }

        /// <summary>
        /// Adds a EmbeddedObjectPart to the MacroSheetPart
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
        /// Adds a EmbeddedPackagePart to the MacroSheetPart
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
        /// Adds a ImagePart to the MacroSheetPart
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
        /// Adds a ImagePart to the MacroSheetPart
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
        /// Adds a ImagePart to the MacroSheetPart
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
        /// Adds a ImagePart to the MacroSheetPart
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
                case SpreadsheetPrinterSettingsPart.RelationshipTypeConstant:
                    return new SpreadsheetPrinterSettingsPart();
                case DrawingsPart.RelationshipTypeConstant:
                    return new DrawingsPart();
                case VmlDrawingPart.RelationshipTypeConstant:
                    return new VmlDrawingPart();
                case WorksheetCommentsPart.RelationshipTypeConstant:
                    return new WorksheetCommentsPart();
                case CustomPropertyPart.RelationshipTypeConstant:
                    return new CustomPropertyPart();
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
