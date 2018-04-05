// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines part media types.
    /// </summary>
    public enum MediaDataPartType
    {
        #region Audio Types

        /// <summary>
        /// Audio Interchange File Format (.aiff)
        /// </summary>
        Aiff,
        ///// <summary>
        ///// AU Audio File (.au)
        ///// </summary>
        //Basic,

        /// <summary>
        /// MIDI Audio (.mid)
        /// </summary>
        Midi,

        /// <summary>
        /// MP3 (.mp3)
        /// </summary>
        Mp3,

        /// <summary>
        /// MP3 Playlist File (.m3u)
        /// </summary>
        MpegUrl,

        /// <summary>
        /// WAV audio (.wav)
        /// </summary>
        Wav,
        ///// <summary>
        ///// Windows Media Audio Redirector (.wax)
        ///// </summary>
        //Wax,

        /// <summary>
        /// Windows Media Audio File (.wma)
        /// </summary>
        Wma,

        /// <summary>
        /// Mpeg audio (.mpeg)
        /// </summary>
        MpegAudio,

        /// <summary>
        /// Ogg Vorbis (.ogg)
        /// </summary>
        OggAudio,

        #endregion

        #region Video Types

        ///// <summary>
        ///// Advanced Streaming Format (.asf)
        ///// </summary>
        //Asf,

        /// <summary>
        /// Advanced Stream Redirector File (.asx)
        /// </summary>
        Asx,

        /// <summary>
        /// Audio Video Interleave File (.avi)
        /// </summary>
        Avi,
        ///// <summary>
        ///// Indeo Video File (.ivf)
        ///// </summary>
        //Ivf,

        /// <summary>
        /// MPEG 1 System Stream (.mpg)
        /// </summary>
        Mpg,

        /// <summary>
        /// MPEG 1 System Stream (.mpeg)
        /// </summary>
        MpegVideo,
        ///// <summary>
        ///// Windows Media A/V File (.wm)
        ///// </summary>
        //WM,

        /// <summary>
        /// Windows Media File (.wmv)
        /// </summary>
        Wmv,

        /// <summary>
        /// Windows Media Player A/V Shortcut (.wmx)
        /// </summary>
        Wmx,

        /// <summary>
        /// Windows Media Redirector (.wvx)
        /// </summary>
        Wvx,

        /// <summary>
        /// QuickTime video (.mov)
        /// </summary>
        Quicktime,

        /// <summary>
        ///  Ogg Stream (.ogg)
        /// </summary>
        OggVideo,

        /// <summary>
        /// VC-1 Stream (.wmv)
        /// </summary>
        VC1,

        #endregion
    }
}
