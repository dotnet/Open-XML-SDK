// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the TimeLinePart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    [ContentType(ContentTypeConstant)]
    public partial class TimeLinePart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.timeline+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/timeline";

        /// <summary>
        /// Creates an instance of the TimeLinePart OpenXmlType
        /// </summary>
        internal protected TimeLinePart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "timeline";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../timelines";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2013);
        }
    }
}
