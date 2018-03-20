// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the PivotTablePart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class PivotTablePart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotTable+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable";
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinition _rootElement;

        /// <summary>
        /// Creates an instance of the PivotTablePart OpenXmlType
        /// </summary>
        internal protected PivotTablePart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinition;
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
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition",
                            PartConstraintRule.Create<PivotTableCacheDefinitionPart>(true, false)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => PivotTableDefinition;

        /// <summary>
        /// Gets the PivotTableCacheDefinitionPart of the PivotTablePart
        /// </summary>
        public PivotTableCacheDefinitionPart PivotTableCacheDefinitionPart => GetSubPartOfType<PivotTableCacheDefinitionPart>();

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinition PivotTableDefinition
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinition>();
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
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "pivotTable";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../pivotTables";

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
                case PivotTableCacheDefinitionPart.RelationshipTypeConstant:
                    return new PivotTableCacheDefinitionPart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
