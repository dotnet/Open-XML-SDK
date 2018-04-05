// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class ImagePartTypeInfo
    {
        internal static string GetContentType(ImagePartType imageType)
        {
            switch (imageType)
            {
                case ImagePartType.Bmp:
                    return "image/bmp";

                case ImagePartType.Gif:
                    return "image/gif";

                case ImagePartType.Png:
                    return "image/png";

                case ImagePartType.Tiff:
                    return "image/tiff";

                //case ImagePartType.Xbm:
                //    return "image/xbm";
                case ImagePartType.Icon:
                    return "image/x-icon";

                case ImagePartType.Pcx:
                    return "image/x-pcx";

                //case ImagePartType.Pcz:
                //    return "image/x-pcz";

                //case ImagePartType.Pict:
                //    return "image/pict";
                case ImagePartType.Jpeg:
                    return "image/jpeg";

                case ImagePartType.Emf:
                    return "image/x-emf";

                case ImagePartType.Wmf:
                    return "image/x-wmf";

                default:
                    throw new ArgumentOutOfRangeException(nameof(imageType));
            }
        }

        internal static string GetTargetExtension(ImagePartType imageType)
        {
            switch (imageType)
            {
                case ImagePartType.Bmp:
                    return ".bmp";

                case ImagePartType.Gif:
                    return ".gif";

                case ImagePartType.Png:
                    return ".png";

                case ImagePartType.Tiff:
                    return ".tiff";

                //case ImagePartType.Xbm:
                //    return ".xbm";
                case ImagePartType.Icon:
                    return ".ico";

                case ImagePartType.Pcx:
                    return ".pcx";

                //case ImagePartType.Pcz:
                //    return ".pcz";

                //case ImagePartType.Pict:
                //    return ".pict";
                case ImagePartType.Jpeg:
                    return ".jpg";

                case ImagePartType.Emf:
                    return ".emf";

                case ImagePartType.Wmf:
                    return ".wmf";

                default:
                    return ".image";
            }
        }
    }
}
