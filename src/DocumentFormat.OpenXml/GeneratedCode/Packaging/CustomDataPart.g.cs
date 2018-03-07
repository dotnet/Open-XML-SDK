// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the CustomDataPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
    [ContentType(ContentTypeConstant)]
    public partial class CustomDataPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/binary";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2007/relationships/customData";

        /// <summary>
        /// Creates an instance of the CustomDataPart OpenXmlType
        /// </summary>
        internal protected CustomDataPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "customData";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "customData";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2010);
        }
    }
}
