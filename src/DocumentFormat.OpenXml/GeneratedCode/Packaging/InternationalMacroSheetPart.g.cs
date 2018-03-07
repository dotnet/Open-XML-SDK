// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the InternationalMacroSheetPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class InternationalMacroSheetPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.intlmacrosheet+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/xlIntlMacrosheet";
        private static PartConstraintCollection _partConstraints;

        /// <summary>
        /// Creates an instance of the InternationalMacroSheetPart OpenXmlType
        /// </summary>
        internal protected InternationalMacroSheetPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the CustomPropertyParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<CustomPropertyPart> CustomPropertyParts => GetPartsOfType<CustomPropertyPart>();

        /// <summary>
        /// Gets the DrawingsPart of the InternationalMacroSheetPart
        /// </summary>
        public DrawingsPart DrawingsPart => GetSubPartOfType<DrawingsPart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the ImageParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

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

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts => GetPartsOfType<SpreadsheetPrinterSettingsPart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "intlsheet";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "macrosheets";

        /// <summary>
        /// Gets the VmlDrawingParts of the InternationalMacroSheetPart
        /// </summary>
        public IEnumerable<VmlDrawingPart> VmlDrawingParts => GetPartsOfType<VmlDrawingPart>();

        /// <summary>
        /// Gets the WorksheetCommentsPart of the InternationalMacroSheetPart
        /// </summary>
        public WorksheetCommentsPart WorksheetCommentsPart => GetSubPartOfType<WorksheetCommentsPart>();

        /// <summary>
        /// Adds a CustomPropertyPart to the InternationalMacroSheetPart
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
        /// Adds a CustomPropertyPart to the InternationalMacroSheetPart
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
        /// Adds a CustomPropertyPart to the InternationalMacroSheetPart
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
        /// Adds a CustomPropertyPart to the InternationalMacroSheetPart
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
        /// Adds a EmbeddedObjectPart to the InternationalMacroSheetPart
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
        /// Adds a EmbeddedPackagePart to the InternationalMacroSheetPart
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
        /// Adds a ImagePart to the InternationalMacroSheetPart
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
        /// Adds a ImagePart to the InternationalMacroSheetPart
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
        /// Adds a ImagePart to the InternationalMacroSheetPart
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
        /// Adds a ImagePart to the InternationalMacroSheetPart
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
