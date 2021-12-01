// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class ImagePartTypeInfo
    {
        internal static string GetContentType(ImagePartType imageType)
            => imageType switch
            {
                ImagePartType.Bmp => "image/bmp",
                ImagePartType.Gif => "image/gif",
                ImagePartType.Png => "image/png",
                ImagePartType.Tiff => "image/tiff",

                // ImagePartType.Xbm => "image/xbm",
                ImagePartType.Icon => "image/x-icon",
                ImagePartType.Pcx => "image/x-pcx",

                // ImagePartType.Pcz => "image/x-pcz",
                // ImagePartType.Pict => "image/pict",
                ImagePartType.Jpeg => "image/jpeg",
                ImagePartType.Emf => "image/x-emf",
                ImagePartType.Wmf => "image/x-wmf",
                ImagePartType.Svg => "image/svg+xml",
                _ => throw new ArgumentOutOfRangeException(nameof(imageType)),
            };

        internal static string GetTargetExtension(ImagePartType imageType)
            => imageType switch
            {
                ImagePartType.Bmp => ".bmp",
                ImagePartType.Gif => ".gif",
                ImagePartType.Png => ".png",
                ImagePartType.Tiff => ".tiff",

                // ImagePartType.Xbm => ".xbm",
                ImagePartType.Icon => ".ico",
                ImagePartType.Pcx => ".pcx",

                // ImagePartType.Pcz => ".pcz",
                // ImagePartType.Pict => ".pict",
                ImagePartType.Jpeg => ".jpg",
                ImagePartType.Emf => ".emf",
                ImagePartType.Wmf => ".wmf",
                ImagePartType.Svg => ".svg",
                _ => ".image",
            };

        internal static ImagePartType GetImagePartType(string extension)
            => extension.ToLower() switch
            {
                ".bmp" => ImagePartType.Bmp,
                ".emf" => ImagePartType.Emf,
                ".ico" => ImagePartType.Icon,
                ".jpg" => ImagePartType.Jpeg,
                ".jpeg" => ImagePartType.Jpeg,
                ".pcx" => ImagePartType.Pcx,
                ".png" => ImagePartType.Png,
                ".svg" => ImagePartType.Svg,
                ".tiff" => ImagePartType.Tiff,
                ".wmf" => ImagePartType.Wmf,
                _ => throw new NotSupportedException($"{extension} is not supported"),
            };
    }
}
