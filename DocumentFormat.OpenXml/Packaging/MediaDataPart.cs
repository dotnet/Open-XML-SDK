// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents a media (Audio, Video) data part in the document.
    /// </summary>
    public class MediaDataPart : DataPart
    {
        private const string DefaultTargetPart = "media";
        private const string DefaultTargetName = "mediadata";
        private const string DefaultTargetExt = ".bin";

        /// <summary>
        /// Initializes a new instance of the MediaDataPart class.
        /// </summary>
        internal MediaDataPart()
            : base()
        {
        }

        /// <inheritdoc/>
        internal override string TargetPath => DefaultTargetPart;

        /// <inheritdoc/>
        internal override string TargetName => DefaultTargetName;

        /// <inheritdoc/>
        internal override string TargetFileExtension => DefaultTargetExt;
    }
}
