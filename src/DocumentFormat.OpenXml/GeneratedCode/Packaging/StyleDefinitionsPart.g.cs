// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the StyleDefinitionsPart
    /// </summary>
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class StyleDefinitionsPart : StylesPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles";

        /// <summary>
        /// Creates an instance of the StyleDefinitionsPart OpenXmlType
        /// </summary>
        internal protected StyleDefinitionsPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "styles";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";
    }
}
