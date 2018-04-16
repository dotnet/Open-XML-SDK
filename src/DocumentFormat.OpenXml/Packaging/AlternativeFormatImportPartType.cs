// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines AlternativeFormatImportPartType - types of AlternativeFormatImportPart.
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
    public enum AlternativeFormatImportPartType
    {
        /// <summary>
        /// Extensible HyperText Markup Language File (.xhtml).
        /// </summary>
        Xhtml,

        /// <summary>
        /// MHTML Document (.mht).
        /// </summary>
        Mht,

        /// <summary>
        /// application/xml (.xml).
        /// </summary>
        Xml,

        /// <summary>
        /// Text (.txt).
        /// </summary>
        TextPlain,

        /// <summary>
        /// Wordprocessing (.docx).
        /// </summary>
        WordprocessingML,

        /// <summary>
        /// Office Word Macro Enabled (.docm).
        /// </summary>
        OfficeWordMacroEnabled,

        /// <summary>
        /// Office Word Template (.dotx).
        /// </summary>
        OfficeWordTemplate,

        /// <summary>
        /// Office Word Macro Enabled Template (.dotm).
        /// </summary>
        OfficeWordMacroEnabledTemplate,

        /// <summary>
        /// Rich Text Format (.rtf).
        /// </summary>
        Rtf,

        /// <summary>
        /// HyperText Markup Language File (.htm).
        /// </summary>
        Html,
    }
}
