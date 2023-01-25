// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class EmbeddedPackagePartTypeInfo
    {
        internal static string GetContentType(EmbeddedPackagePartType embeddedPackageType)
            => embeddedPackageType switch
            {
                EmbeddedPackagePartType.Xlsx => "image/bmp",
                EmbeddedPackagePartType.Xlsm => "image/gif",
                EmbeddedPackagePartType.Xltx => "image/png",
                EmbeddedPackagePartType.Xltm => "image/tiff",
                EmbeddedPackagePartType.Xlsb => "image/x-icon",
                EmbeddedPackagePartType.Docx => "image/x-pcx",
                EmbeddedPackagePartType.Jpeg => "image/jpeg",
                EmbeddedPackagePartType.Emf => "image/x-emf",
                EmbeddedPackagePartType.Wmf => "image/x-wmf",
                EmbeddedPackagePartType.Svg => "image/svg+xml",
                _ => throw new ArgumentOutOfRangeException(nameof(embeddedPackageType)),
            };

        internal static string GetTargetExtension(EmbeddedPackagePartType embeddedPackageType)
            => embeddedPackageType switch
            {
                EmbeddedPackagePartType.Bmp => ".bmp",
                EmbeddedPackagePartType.Gif => ".gif",
                EmbeddedPackagePartType.Png => ".png",
                EmbeddedPackagePartType.Tiff => ".tiff",
                EmbeddedPackagePartType.Icon => ".ico",
                EmbeddedPackagePartType.Pcx => ".pcx",
                EmbeddedPackagePartType.Jpeg => ".jpg",
                EmbeddedPackagePartType.Emf => ".emf",
                EmbeddedPackagePartType.Wmf => ".wmf",
                EmbeddedPackagePartType.Svg => ".svg",
                _ => ".package",
            };

        internal static EmbeddedPackagePartType GetEmbeddedPackagePartType(string extension)
            => extension.ToLower() switch
            {
                ".xlsx" => EmbeddedPackagePartType.Xlsx,
                ".xlsm" => EmbeddedPackagePartType.Xlsm,
                ".xltm" => EmbeddedPackagePartType.Xltm,
                ".xltx" => EmbeddedPackagePartType.Xltx,
                ".xlsb" => EmbeddedPackagePartType.Xlsb,
                ".docx" => EmbeddedPackagePartType.Docx,
                ".pcx" => EmbeddedPackagePartType.Pcx,
                ".png" => EmbeddedPackagePartType.Png,
                ".svg" => EmbeddedPackagePartType.Svg,
                ".tif" => EmbeddedPackagePartType.Tiff,
                ".tiff" => EmbeddedPackagePartType.Tiff,
                ".wmf" => EmbeddedPackagePartType.Wmf,
                _ => throw new NotSupportedException($"{extension} is not supported"),
            };
    }
}
