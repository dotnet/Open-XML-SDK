// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines a provider which maintains a dictionary where the key is the content type and the value is a part extension.
    /// </summary>
    internal sealed class PartExtensionProvider : Dictionary<string, string>, IPartExtensionFeature
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartExtensionProvider"/> class that is empty.
        /// </summary>
        public PartExtensionProvider()
            : base(StringComparer.Ordinal)
        {
            AddKnownExtensions();
        }

        /// <summary>
        /// Check to make sure the content type and part extension is in the provider. If not, they will be added.
        /// </summary>
        /// <param name="contentType">The content type</param>
        /// <param name="extension">Part Extension (".xml") to be used for the part with the specified content type.</param>
        /// <exception cref="ArgumentNullException">Thrown when either parameter is null.</exception>
        public void Register(string contentType, string extension)
        {
            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (extension is null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            this[contentType] = extension;
        }

        public bool TryGetExtension(string contentType, [MaybeNullWhen(false)] out string extension)
            => TryGetValue(contentType, out extension);

        private void AddKnownExtensions()
        {
            this["image/unknown"] = ".bin";
            this["image/bmp"] = ".bmp";
            this["image/gif"] = ".gif";
            this["image/png"] = ".png";
            this["image/jp2"] = ".jp2";
            this["image/tif"] = ".tif";
            this["image/tiff"] = ".tiff";
            this["image/xbm"] = ".xbm";
            this["image/x-icon"] = ".ico";
            this["image/x-pcx"] = ".pcx";
            this["image/x-pcz"] = ".pcz";
            this["image/x-emz"] = ".emz";
            this["image/x-wmz"] = ".wmz";
            this["image/jpeg"] = ".jpeg";
            this["image/x-emf"] = ".emf";
            this["image/x-wmf"] = ".wmf";
            this["image/svg+xml"] = ".svg";
            this["audio/aiff"] = ".aiff";
            this["audio/midi"] = ".midi";
            this["audio/mp3"] = ".mp3";
            this["audio/mpegurl"] = ".m3u";
            this["audio/wav"] = ".wav";
            this["audio/x-ms-wma"] = ".wma";
            this["audio/mpeg"] = ".mpeg";
            this["audio/ogg"] = ".ogg";
            this["video/x-ms-asf-plugin"] = ".asx";
            this["video/avi"] = ".avi";
            this["video/mp4"] = ".mp4";
            this["video/mpg"] = ".mpg";
            this["video/mpeg"] = ".mpeg";
            this["video/x-ms-wmv"] = ".wmv";
            this["video/x-ms-wmx"] = ".wmx";
            this["video/x-ms-wvx"] = ".wvx";
            this["video/quicktime"] = ".mov";
            this["video/ogg"] = ".ogg";
            this["video/vc1"] = ".wmv";
        }
    }
}
