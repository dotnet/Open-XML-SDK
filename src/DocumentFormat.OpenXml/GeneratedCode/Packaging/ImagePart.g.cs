﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the ImagePart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ImagePart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image";

        /// <summary>
        /// Creates an instance of the ImagePart OpenXmlType
        /// </summary>
        internal protected ImagePart()
        {
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => false;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetFileExtension => ".bin";

        /// <inheritdoc/>
        internal sealed override string TargetName => "image";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../media";
    }
}
