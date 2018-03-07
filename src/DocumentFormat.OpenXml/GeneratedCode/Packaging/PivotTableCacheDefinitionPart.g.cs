// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the PivotTableCacheDefinitionPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class PivotTableCacheDefinitionPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition";
        private static PartConstraintCollection _partConstraints;

        /// <summary>
        /// Creates an instance of the PivotTableCacheDefinitionPart OpenXmlType
        /// </summary>
        internal protected PivotTableCacheDefinitionPart()
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
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords",
                            PartConstraintRule.Create<PivotTableCacheRecordsPart>(false, false)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        /// <summary>
        /// Gets the PivotTableCacheRecordsPart of the PivotTableCacheDefinitionPart
        /// </summary>
        public PivotTableCacheRecordsPart PivotTableCacheRecordsPart => GetSubPartOfType<PivotTableCacheRecordsPart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "pivotCacheDefinition";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../pivotCache";

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
                case PivotTableCacheRecordsPart.RelationshipTypeConstant:
                    return new PivotTableCacheRecordsPart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
