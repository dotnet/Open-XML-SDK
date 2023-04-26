// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class ImagePartTypeInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "Extensions")]
        internal static PartTypeInfo GetImagePartType(string extension)
            => extension.ToLowerInvariant() switch
            {
                ".bmp" => ImagePartType.Bmp,
                ".emf" => ImagePartType.Emf,
                ".gif" => ImagePartType.Gif,
                ".ico" => ImagePartType.Icon,
                ".jpg" => ImagePartType.Jpeg,
                ".jpeg" => ImagePartType.Jpeg,
                ".jp2" => ImagePartType.Jp2,
                ".pcx" => ImagePartType.Pcx,
                ".png" => ImagePartType.Png,
                ".svg" => ImagePartType.Svg,
                ".tif" => ImagePartType.Tif,
                ".tiff" => ImagePartType.Tiff,
                ".wmf" => ImagePartType.Wmf,
                _ => throw new NotSupportedException($"{extension} is not supported"),
            };
    }
}
