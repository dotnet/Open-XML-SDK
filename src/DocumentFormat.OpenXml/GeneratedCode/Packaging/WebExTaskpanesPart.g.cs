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
    public partial class WebExTaskpanesPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-office.webextensiontaskpanes+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/webextensiontaskpanes";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the WebExTaskpanesPart OpenXmlType
        /// </summary>
        internal protected WebExTaskpanesPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

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
                        "http://schemas.microsoft.com/office/2011/relationships/webextension",
                        new PartConstraintRule(nameof(WebExtensionPart), WebExtensionPart.ContentTypeConstant, false, true, FileFormatVersions.Office2013.AndLater())
                    }
                };
            }

            return _partConstraint;
        }

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2013);
        }
    }
}
