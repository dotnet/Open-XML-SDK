// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the AlternativeFormatImportPart
    /// </summary>
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class AlternativeFormatImportPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk";

        /// <summary>
        /// Creates an instance of the AlternativeFormatImportPart OpenXmlType
        /// </summary>
        internal protected AlternativeFormatImportPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetFileExtension => ".dat";

        /// <inheritdoc/>
        internal sealed override string TargetName => "afchunk";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";
    }
}
