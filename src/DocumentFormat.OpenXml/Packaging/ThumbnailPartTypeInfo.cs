// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

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
    }
}
