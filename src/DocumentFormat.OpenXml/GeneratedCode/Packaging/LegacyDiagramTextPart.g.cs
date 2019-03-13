// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the LegacyDiagramTextPart
    /// </summary>
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class LegacyDiagramTextPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-office.legacyDiagramText";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/legacyDiagramText";

        /// <summary>
        /// Creates an instance of the LegacyDiagramTextPart OpenXmlType
        /// </summary>
        internal protected LegacyDiagramTextPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetFileExtension => ".bin";

        /// <inheritdoc/>
        internal sealed override string TargetName => "legacyDiagramText";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";
    }
}
