// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines ImagePartType - types of ImagePart.
    ///
    /// Data from "dev12\msoutilstat\src\metro.cpp":
    ///
    /// <![CDATA[
    /// L".bin",    L"image/unknown",
    /// L".bmp",    L"image/bmp",
    /// L".gif",    L"image/gif",
    /// L".png",    L"image/png",
    /// L".tiff",   L"image/tiff",
    /// L".xbm",    L"image/xbm",
    /// L".ico",    L"image/x-icon",
    /// L".pcx",    L"image/x-pcx",
    /// L".pcz",    L"image/x-pcz",
    /// // Note: [danjump] EMZ and WMZ should never be used.
    /// L".emz",    L"image/x-emz",
    /// L".wmz",    L"image/x-wmz",
    /// // Note: [danjump] Jpeg-Wmf are used by thumbnail.  Don't add between them
    /// L".jpeg",   L"image/jpeg",
    /// L".emf",    L"image/x-emf",
    /// L".wmf",    L"image/x-wmf",
    /// ]]>
    /// </summary>
    public enum ImagePartType
    {
        /// <summary>
        /// Windows Bitmap Graphics (.bmp).
        /// </summary>
        Bmp,

        /// <summary>
        /// Graphic Interchange Format (.gif).
        /// </summary>
        Gif,

        /// <summary>
        /// Portable (Public) Network Graphic (.png).
        /// </summary>
        Png,

        /// <summary>
        /// Tagged Image Format File (.tiff).
        /// </summary>
        Tiff,
        ///// <summary>
        ///// X Bitmap Graphic (.xbm).
        ///// </summary>
        //Xbm,

        /// <summary>
        /// Windows Icon (.ico).
        /// </summary>
        Icon,

        /// <summary>
        /// PC Paintbrush Bitmap Graphic (.pcx).
        /// </summary>
        Pcx,
        ///// <summary>
        ///// Compressed Macintosh PICT (.pcz).
        ///// </summary>
        //Pcz,
        //Emz,
        //Wmz,
        ///// <summary>
        ///// Macintosh Quickdraw/PICT Drawing (.pict).
        ///// </summary>
        //Pict,

        /// <summary>
        /// JPEG/JIFF Image (.jpeg).
        /// </summary>
        Jpeg,

        /// <summary>
        /// Extended (Enhanced) Windows Metafile Format (.emf).
        /// </summary>
        Emf,

        /// <summary>
        /// Windows Metafile (.wmf).
        /// </summary>
        Wmf,
    }
}
