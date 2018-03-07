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
    public partial class MacroSheetPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.macrosheet+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/xlMacrosheet";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

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

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

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

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint is null)
            {
                _dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal) { };
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
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings",
                        new PartConstraintRule(nameof(SpreadsheetPrinterSettingsPart), SpreadsheetPrinterSettingsPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing",
                        new PartConstraintRule(nameof(DrawingsPart), DrawingsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing",
                        new PartConstraintRule(nameof(VmlDrawingPart), VmlDrawingPart.ContentTypeConstant, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments",
                        new PartConstraintRule(nameof(WorksheetCommentsPart), WorksheetCommentsPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty",
                        new PartConstraintRule(nameof(CustomPropertyPart), null, false, true, FileFormatVersions.Office2007.AndLater())
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
