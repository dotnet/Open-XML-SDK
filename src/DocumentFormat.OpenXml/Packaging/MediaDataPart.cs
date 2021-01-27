// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO.Packaging;

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

        internal MediaDataPart(OpenXmlPackage openXmlPackage, PackagePart packagePart)
            : base(openXmlPackage, packagePart)
        {
        }

        internal MediaDataPart(OpenXmlPackage openXmlPackage, string contentType, string? extension)
            : base(openXmlPackage, contentType, extension)
        {
        }

        internal MediaDataPart(OpenXmlPackage openXmlPackage, MediaDataPartType mediaDataPartType)
            : base(openXmlPackage, mediaDataPartType)
        {
        }

        internal MediaDataPart(OpenXmlPackage openXmlPackage, string contentType, Uri partUri)
            : base(openXmlPackage, contentType, partUri)
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
