// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the FontPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class FontPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font";

        /// <summary>
        /// Creates an instance of the FontPart OpenXmlType
        /// </summary>
        internal protected FontPart()
        {
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => false;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetFileExtension => ".dat";

        /// <inheritdoc/>
        internal sealed override string TargetName => "font";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "fonts";
    }
}
