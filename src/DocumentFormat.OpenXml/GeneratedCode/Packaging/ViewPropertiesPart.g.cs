// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the ViewPropertiesPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class ViewPropertiesPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.presentationml.viewProps+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps";
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Presentation.ViewProperties _rootElement;

        /// <summary>
        /// Creates an instance of the ViewPropertiesPart OpenXmlType
        /// </summary>
        internal protected ViewPropertiesPart()
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
                _rootElement = value as DocumentFormat.OpenXml.Presentation.ViewProperties;
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
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",
                            PartConstraintRule.Create<SlidePart>(false, true)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => ViewProperties;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SlideParts of the ViewPropertiesPart
        /// </summary>
        public IEnumerable<SlidePart> SlideParts => GetPartsOfType<SlidePart>();

        /// <inheritdoc/>
        internal sealed override string TargetName => "viewProps";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Presentation.ViewProperties ViewProperties
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Presentation.ViewProperties>();
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
        internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
        {
            ThrowIfObjectDisposed();
            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            switch (relationshipType)
            {
                case SlidePart.RelationshipTypeConstant:
                    return new SlidePart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
