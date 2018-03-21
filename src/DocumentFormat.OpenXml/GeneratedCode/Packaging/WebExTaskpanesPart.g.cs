// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the WebExTaskpanesPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    [ContentType(ContentTypeConstant)]
    public partial class WebExTaskpanesPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-office.webextensiontaskpanes+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes";
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes _rootElement;

        /// <summary>
        /// Creates an instance of the WebExTaskpanesPart OpenXmlType
        /// </summary>
        internal protected WebExTaskpanesPart()
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
                _rootElement = value as DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes;
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
                            "http://schemas.microsoft.com/office/2011/relationships/webextension",
                            PartConstraintRule.Create<WebExtensionPart>(false, true)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => Taskpanes;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "taskpanes";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../webextensions";

        /// <inheritdoc/>
        internal sealed override string TargetPathOfExcel => "xl/webextensions";

        /// <inheritdoc/>
        internal sealed override string TargetPathOfPPT => "ppt/webextensions";

        /// <inheritdoc/>
        internal sealed override string TargetPathOfWord => "word/webextensions";

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes Taskpanes
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes>();
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
        /// Gets the WebExtensionParts of the WebExTaskpanesPart
        /// </summary>
        public IEnumerable<WebExtensionPart> WebExtensionParts => GetPartsOfType<WebExtensionPart>();

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
                case WebExtensionPart.RelationshipTypeConstant:
                    return new WebExtensionPart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2013);
        }
    }
}
