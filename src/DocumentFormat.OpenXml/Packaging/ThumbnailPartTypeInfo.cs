// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class ThumbnailPartTypeInfo
    {
        internal static string GetContentType(ThumbnailPartType imageType)
            => imageType switch
            {
                ThumbnailPartType.Jpeg => "image/jpeg",
                ThumbnailPartType.Emf => "image/x-emf",
                ThumbnailPartType.Wmf => "image/x-wmf",
                _ => throw new ArgumentOutOfRangeException(nameof(imageType)),
            };

        internal static string GetTargetExtension(ThumbnailPartType imageType)
            => imageType switch
            {
                ThumbnailPartType.Jpeg => ".jpg",
                ThumbnailPartType.Emf => ".emf",
                ThumbnailPartType.Wmf => ".wmf",
                _ => ".image",
            };

        internal static ThumbnailPartType GetThumbnailPartTypeFromContentType(string contenttype)
            => contenttype.ToLower(CultureInfo.CurrentCulture) switch
            {
                "image/jpeg" => ThumbnailPartType.Jpeg,
                "image/x-emf" => ThumbnailPartType.Emf,
                "image/x-wmf" => ThumbnailPartType.Wmf,
                _ => throw new NotSupportedException($"{contenttype} is not supported"),
            };

        internal static bool TryGetThumbnailPartTypeFromContentType(string contentType)
        {
            try
            {
                _ = GetThumbnailPartTypeFromContentType(contentType);
                return true;
            }
            catch (NotSupportedException)
            {
            }

            return false;
        }

        internal static bool TryGetContentType(ThumbnailPartType partType)
        {
            try
            {
                _ = GetContentType(partType);
                return true;
            }
            catch (NotSupportedException)
            {
            }

            return false;
        }
    }
}
