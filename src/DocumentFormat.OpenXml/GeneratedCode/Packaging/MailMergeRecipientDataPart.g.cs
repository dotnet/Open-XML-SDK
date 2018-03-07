// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the MailMergeRecipientDataPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class MailMergeRecipientDataPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/recipientData";

        /// <summary>
        /// Creates an instance of the MailMergeRecipientDataPart OpenXmlType
        /// </summary>
        internal protected MailMergeRecipientDataPart()
        {
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => false;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "recipients";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";
    }
}
