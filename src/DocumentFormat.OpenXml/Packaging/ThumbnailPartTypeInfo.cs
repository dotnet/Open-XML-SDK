// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class ThumbnailPartTypeInfo
    {
        internal static string GetContentType(ThumbnailPartType imageType)
        {
            switch (imageType)
            {
                case ThumbnailPartType.Jpeg:
                    return "image/jpeg";

                case ThumbnailPartType.Emf:
                    return "image/x-emf";

                case ThumbnailPartType.Wmf:
                    return "image/x-wmf";

                default:
                    throw new ArgumentOutOfRangeException(nameof(imageType));
            }
        }

        internal static string GetTargetExtension(ThumbnailPartType imageType)
        {
            switch (imageType)
            {
                case ThumbnailPartType.Jpeg:
                    return ".jpg";

                case ThumbnailPartType.Emf:
                    return ".emf";

                case ThumbnailPartType.Wmf:
                    return ".wmf";

                default:
                    return ".image";
            }
        }
    }
}
