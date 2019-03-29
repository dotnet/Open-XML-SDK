// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the ThumbnailPart
    /// </summary>
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class ThumbnailPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail";

        /// <summary>
        /// Creates an instance of the ThumbnailPart OpenXmlType
        /// </summary>
        internal protected ThumbnailPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetFileExtension => ".bin";

        /// <inheritdoc/>
        internal sealed override string TargetName => "thumbnail";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "docProps";
    }
}
