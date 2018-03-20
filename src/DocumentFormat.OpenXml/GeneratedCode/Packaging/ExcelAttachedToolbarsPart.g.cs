// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the ExcelAttachedToolbarsPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class ExcelAttachedToolbarsPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.attachedToolbars";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/attachedToolbars";

        /// <summary>
        /// Creates an instance of the ExcelAttachedToolbarsPart OpenXmlType
        /// </summary>
        internal protected ExcelAttachedToolbarsPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetFileExtension => ".bin";

        /// <inheritdoc/>
        internal sealed override string TargetName => "attachedToolbars";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";
    }
}
