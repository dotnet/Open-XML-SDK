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

        /// <summary>
        /// The internal path to be used for the part name.
        /// </summary>
        internal override string TargetPath
        {
            get { return DefaultTargetPart; }
        }

        /// <summary>
        /// The file base name to be used for the part name in the package
        /// </summary>
        internal override string TargetName
        {
            get { return DefaultTargetName; }
        }

        /// <summary>
        /// The file extension to be used for the part in the package.
        /// </summary>
        internal override string TargetFileExtension
        {
            get { return DefaultTargetExt; }
        }
    }
}
