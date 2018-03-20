// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the StylesWithEffectsPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
    [ContentType(ContentTypeConstant)]
    public partial class StylesWithEffectsPart : StylesPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-word.stylesWithEffects+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects";

        /// <summary>
        /// Creates an instance of the StylesWithEffectsPart OpenXmlType
        /// </summary>
        internal protected StylesWithEffectsPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "stylesWithEffects";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2010);
        }
    }
}
