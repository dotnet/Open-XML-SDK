// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the WordprocessingPrinterSettingsPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class WordprocessingPrinterSettingsPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.printerSettings";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings";

        /// <summary>
        /// Creates an instance of the WordprocessingPrinterSettingsPart OpenXmlType
        /// </summary>
        internal protected WordprocessingPrinterSettingsPart()
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
        internal sealed override string TargetName => "printerSettings";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../printerSettings";
    }
}
