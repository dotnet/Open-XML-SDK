// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the TableDefinitionPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class TableDefinitionPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.spreadsheetml.table+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/table";
        private static PartConstraintCollection _partConstraints;

        /// <summary>
        /// Creates an instance of the TableDefinitionPart OpenXmlType
        /// </summary>
        internal protected TableDefinitionPart()
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
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable",
                            PartConstraintRule.Create<QueryTablePart>(false, true)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        /// <summary>
        /// Gets the QueryTableParts of the TableDefinitionPart
        /// </summary>
        public IEnumerable<QueryTablePart> QueryTableParts => GetPartsOfType<QueryTablePart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "table";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../tables";

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
                case QueryTablePart.RelationshipTypeConstant:
                    return new QueryTablePart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
