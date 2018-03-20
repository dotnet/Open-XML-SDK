// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the DialogsheetPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class DialogsheetPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet";
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Spreadsheet.DialogSheet _rootElement;

        /// <summary>
        /// Creates an instance of the DialogsheetPart OpenXmlType
        /// </summary>
        internal protected DialogsheetPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Spreadsheet.DialogSheet DialogSheet
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Spreadsheet.DialogSheet>();
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
        /// Gets the DrawingsPart of the DialogsheetPart
        /// </summary>
        public DrawingsPart DrawingsPart => GetSubPartOfType<DrawingsPart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the DialogsheetPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Spreadsheet.DialogSheet;
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
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject",
                            PartConstraintRule.Create<EmbeddedObjectPart>(false, true)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => DialogSheet;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SpreadsheetPrinterSettingsParts of the DialogsheetPart
        /// </summary>
        public IEnumerable<SpreadsheetPrinterSettingsPart> SpreadsheetPrinterSettingsParts => GetPartsOfType<SpreadsheetPrinterSettingsPart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "sheet";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "dialogsheets";

        /// <summary>
        /// Gets the VmlDrawingParts of the DialogsheetPart
        /// </summary>
        public IEnumerable<VmlDrawingPart> VmlDrawingParts => GetPartsOfType<VmlDrawingPart>();

        /// <summary>
        /// Adds a EmbeddedObjectPart to the DialogsheetPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedObjectPart</param>
        /// <return>The newly added part</return>
        public EmbeddedObjectPart AddEmbeddedObjectPart(string contentType)
        {
            var childPart = new EmbeddedObjectPart();
            InitPart(childPart, contentType);
            return childPart;
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
                case EmbeddedObjectPart.RelationshipTypeConstant:
                    return new EmbeddedObjectPart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
