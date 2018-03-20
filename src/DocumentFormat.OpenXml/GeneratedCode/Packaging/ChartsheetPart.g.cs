// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the ChartsheetPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class ChartsheetPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.chartsheet+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet";
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Spreadsheet.Chartsheet _rootElement;

        /// <summary>
        /// Creates an instance of the ChartsheetPart OpenXmlType
        /// </summary>
        internal protected ChartsheetPart()
        {
        }

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Spreadsheet.Chartsheet Chartsheet
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Spreadsheet.Chartsheet>();
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
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the DrawingsPart of the ChartsheetPart
        /// </summary>
        public DrawingsPart DrawingsPart => GetSubPartOfType<DrawingsPart>();

        /// <summary>
        /// Gets the ImageParts of the ChartsheetPart
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
                _rootElement = value as DocumentFormat.OpenXml.Spreadsheet.Chartsheet;
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
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
                            PartConstraintRule.Create<ImagePart>(false, true)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => Chartsheet;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the ChartsheetPart
        /// </summary>
        public IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts => GetPartsOfType<SpreadsheetPrinterSettingsPart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "sheet";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "chartsheets";

        /// <summary>
        /// Gets the VmlDrawingParts of the ChartsheetPart
        /// </summary>
        public IEnumerable<VmlDrawingPart> VmlDrawingParts => GetPartsOfType<VmlDrawingPart>();

        /// <summary>
        /// Adds a ImagePart to the ChartsheetPart
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
        /// Adds a ImagePart to the ChartsheetPart
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
        /// Adds a ImagePart to the ChartsheetPart
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
        /// Adds a ImagePart to the ChartsheetPart
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
                case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
