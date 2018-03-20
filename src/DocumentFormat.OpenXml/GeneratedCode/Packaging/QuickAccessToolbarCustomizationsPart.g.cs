// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the QuickAccessToolbarCustomizationsPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class QuickAccessToolbarCustomizationsPart : CustomUIPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization";

        /// <summary>
        /// Creates an instance of the QuickAccessToolbarCustomizationsPart OpenXmlType
        /// </summary>
        internal protected QuickAccessToolbarCustomizationsPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "customUI";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "userCustomization";
    }
}
