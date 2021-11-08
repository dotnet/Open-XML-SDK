// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class MediaDataPartTypeInfo
    {
        internal static string GetContentType(this MediaDataPartType mediaDataPartType)
            => mediaDataPartType switch
            {
                MediaDataPartType.Aiff => "audio/aiff",

                // MediaDataPartType.Basic => "audio/basic",
                MediaDataPartType.Midi => "audio/midi",
                MediaDataPartType.Mp3 => "audio/mp3",
                MediaDataPartType.MpegUrl => "audio/mpegurl",
                MediaDataPartType.Wav => "audio/wav",

                // MediaDataPartType.Wax => "audio/x-ms-wax",
                MediaDataPartType.Wma => "audio/x-ms-wma",
                MediaDataPartType.MpegAudio => "audio/mpeg",
                MediaDataPartType.OggAudio => "audio/ogg",

                // *** Video types.
                // MediaDataPartType.Asf => "video/x-ms-asf",
                MediaDataPartType.Asx => "video/x-ms-asf-plugin",
                MediaDataPartType.Avi => "video/avi",

                // MediaDataPartType.Ivf => "video/x-ivf",
                MediaDataPartType.Mpg => "video/mpg",
                MediaDataPartType.MpegVideo => "video/mpeg",

                // MediaDataPartType.WM => "video/x-ms-wm",
                MediaDataPartType.Wmv => "video/x-ms-wmv",
                MediaDataPartType.Wmx => "video/x-ms-wmx",
                MediaDataPartType.Wvx => "video/x-ms-wvx",
                MediaDataPartType.Quicktime => "video/quicktime",
                MediaDataPartType.OggVideo => "video/ogg",
                MediaDataPartType.VC1 => "video/vc1",
                _ => throw new ArgumentOutOfRangeException(nameof(mediaDataPartType)),
            };

        internal static string GetTargetExtension(this MediaDataPartType mediaDataPartType)
            => mediaDataPartType switch
            {
                MediaDataPartType.Aiff => ".aiff",

                // MediaDataPartType.Basic => ".au",
                MediaDataPartType.Midi => ".midi",
                MediaDataPartType.Mp3 => ".mp3",
                MediaDataPartType.MpegUrl => ".m3u",
                MediaDataPartType.Wav => ".wav",

                // MediaDataPartType.Wax => ".wax",
                MediaDataPartType.Wma => ".wma",
                MediaDataPartType.MpegAudio => ".mpeg",
                MediaDataPartType.OggAudio => ".ogg",

                // Video types.
                // MediaDataPartType.Asf => ".asf",
                MediaDataPartType.Asx => ".asx",
                MediaDataPartType.Avi => ".avi",

                // MediaDataPartType.Ivf => ".ivf",
                MediaDataPartType.Mpg => ".mpg",
                MediaDataPartType.MpegVideo => ".mpeg",

                // MediaDataPartType.WM => ".wm",
                MediaDataPartType.Wmv => ".wmv",
                MediaDataPartType.Wmx => ".wmx",
                MediaDataPartType.Wvx => ".wvx",
                MediaDataPartType.Quicktime => ".mov",
                MediaDataPartType.OggVideo => ".ogg",
                MediaDataPartType.VC1 => ".wmv",
                _ => ".media",
            };
    }
}
