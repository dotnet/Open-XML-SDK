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

        /// <summary>
        /// Creates an instance of the PivotTablePart OpenXmlType
        /// </summary>
        internal protected PivotTablePart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

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

        /// <summary>
        /// Gets the PivotTableCacheDefinitionPart of the PivotTablePart
        /// </summary>
        public PivotTableCacheDefinitionPart PivotTableCacheDefinitionPart => GetSubPartOfType<PivotTableCacheDefinitionPart>();

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
