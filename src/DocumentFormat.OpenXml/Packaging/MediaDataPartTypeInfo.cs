// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class MediaDataPartTypeInfo
    {
        internal static string GetContentType(this MediaDataPartType mediaDataPartType)
        {
            switch (mediaDataPartType)
            {
                case MediaDataPartType.Aiff:
                    return "audio/aiff";

                //case MediaDataPartType.Basic:
                //    return "audio/basic";
                case MediaDataPartType.Midi:
                    return "audio/midi";

                case MediaDataPartType.Mp3:
                    return "audio/mp3";

                case MediaDataPartType.MpegUrl:
                    return "audio/mpegurl";

                case MediaDataPartType.Wav:
                    return "audio/wav";

                //case MediaDataPartType.Wax:
                //    return "audio/x-ms-wax";
                case MediaDataPartType.Wma:
                    return "audio/x-ms-wma";

                case MediaDataPartType.MpegAudio:
                    return "audio/mpeg";

                case MediaDataPartType.OggAudio:
                    return "audio/ogg";

                // *** Video types.

                //case MediaDataPartType.Asf:
                //    return "video/x-ms-asf";
                case MediaDataPartType.Asx:
                    return "video/x-ms-asf-plugin";

                case MediaDataPartType.Avi:
                    return "video/avi";

                //case MediaDataPartType.Ivf:
                //    return "video/x-ivf";
                case MediaDataPartType.Mpg:
                    return "video/mpg";

                case MediaDataPartType.MpegVideo:
                    return "video/mpeg";

                //case MediaDataPartType.WM:
                //    return "video/x-ms-wm";
                case MediaDataPartType.Wmv:
                    return "video/x-ms-wmv";

                case MediaDataPartType.Wmx:
                    return "video/x-ms-wmx";

                case MediaDataPartType.Wvx:
                    return "video/x-ms-wvx";

                case MediaDataPartType.Quicktime:
                    return "video/quicktime";

                case MediaDataPartType.OggVideo:
                    return "video/ogg";

                case MediaDataPartType.VC1:
                    return "video/vc1";

                default:
                    throw new ArgumentOutOfRangeException(nameof(mediaDataPartType));
            }
        }

        internal static string GetTargetExtension(this MediaDataPartType mediaDataPartType)
        {
            switch (mediaDataPartType)
            {
                case MediaDataPartType.Aiff:
                    return ".aiff";

                //case MediaDataPartType.Basic:
                //    return ".au";
                case MediaDataPartType.Midi:
                    return ".midi";

                case MediaDataPartType.Mp3:
                    return ".mp3";

                case MediaDataPartType.MpegUrl:
                    return ".m3u";

                case MediaDataPartType.Wav:
                    return ".wav";

                //case MediaDataPartType.Wax:
                //    return ".wax";
                case MediaDataPartType.Wma:
                    return ".wma";

                case MediaDataPartType.MpegAudio:
                    return ".mpeg";

                case MediaDataPartType.OggAudio:
                    return ".ogg";

                // Video types.

                //case MediaDataPartType.Asf:
                //    return ".asf";
                case MediaDataPartType.Asx:
                    return ".asx";

                case MediaDataPartType.Avi:
                    return ".avi";

                //case MediaDataPartType.Ivf:
                //    return ".ivf";
                case MediaDataPartType.Mpg:
                    return ".mpg";

                case MediaDataPartType.MpegVideo:
                    return ".mpeg";

                //case MediaDataPartType.WM:
                //    return ".wm";
                case MediaDataPartType.Wmv:
                    return ".wmv";

                case MediaDataPartType.Wmx:
                    return ".wmx";

                case MediaDataPartType.Wvx:
                    return ".wvx";

                case MediaDataPartType.Quicktime:
                    return ".mov";

                case MediaDataPartType.OggVideo:
                    return ".ogg";

                case MediaDataPartType.VC1:
                    return ".wmv";

                default:
                    return ".media";
            }
        }
    }
}
