// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the CustomXmlPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class CustomXmlPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the CustomXmlPart OpenXmlType
        /// </summary>
        internal protected CustomXmlPart()
        {
        }

        /// <summary>
        /// Gets the CustomXmlPropertiesPart of the CustomXmlPart
        /// </summary>
        public CustomXmlPropertiesPart CustomXmlPropertiesPart => GetSubPartOfType<CustomXmlPropertiesPart>();

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => false;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "item";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../customXML";

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
                case CustomXmlPropertiesPart.RelationshipTypeConstant:
                    return new CustomXmlPropertiesPart();
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
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps",
                        PartConstraintRule.Create<CustomXmlPropertiesPart>(false, false)
                    }
                };
            }

            return _partConstraint;
        }
    }
}
