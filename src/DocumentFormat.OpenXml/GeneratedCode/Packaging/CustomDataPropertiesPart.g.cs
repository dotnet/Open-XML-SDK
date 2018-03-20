// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the CustomDataPropertiesPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
    [ContentType(ContentTypeConstant)]
    public partial class CustomDataPropertiesPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.customDataProperties+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2007/relationships/customDataProps";
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Office2010.Excel.DatastoreItem _rootElement;

        /// <summary>
        /// Creates an instance of the CustomDataPropertiesPart OpenXmlType
        /// </summary>
        internal protected CustomDataPropertiesPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the CustomDataPart of the CustomDataPropertiesPart
        /// </summary>
        public CustomDataPart CustomDataPart => GetSubPartOfType<CustomDataPart>();

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2010.Excel.DatastoreItem DatastoreItem
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2010.Excel.DatastoreItem>();
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

        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2010.Excel.DatastoreItem;
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
                            "http://schemas.microsoft.com/office/2007/relationships/customData",
                            PartConstraintRule.Create<CustomDataPart>(false, false)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => DatastoreItem;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "customDataProps";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "customData";

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
                case CustomDataPart.RelationshipTypeConstant:
                    return new CustomDataPart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2010);
        }
    }
}
