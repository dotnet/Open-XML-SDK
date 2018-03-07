// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the EmbeddedControlPersistenceBinaryDataPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class EmbeddedControlPersistenceBinaryDataPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary";

        /// <summary>
        /// Creates an instance of the EmbeddedControlPersistenceBinaryDataPart OpenXmlType
        /// </summary>
        internal protected EmbeddedControlPersistenceBinaryDataPart()
        {
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => false;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetFileExtension => ".bin";

        /// <inheritdoc/>
        internal sealed override string TargetName => "ActiveXControl";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";
    }
}
