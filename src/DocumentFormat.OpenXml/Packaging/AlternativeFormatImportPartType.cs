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
    /// // Note: EMZ and WMZ should never be used.
    /// L".emz",    L"image/x-emz",
    /// L".wmz",    L"image/x-wmz",
    /// // Note: Jpeg-Wmf are used by thumbnail.  Don't add between them
    /// L".jpeg",   L"image/jpeg",
    /// L".emf",    L"image/x-emf",
    /// L".wmf",    L"image/x-wmf",
    /// ]]>
    /// </summary>
    public static class AlternativeFormatImportPartType
    {
        /// <summary>
        /// Defines type information for Xhtml alternative format import part.
        /// </summary>
        public static readonly PartTypeInfo Xhtml = new("application/xhtml+xml", ".xhtml");

        /// <summary>
        /// Defines type information for Mht alternative format import part.
        /// </summary>
        public static readonly PartTypeInfo Mht = new("message/rfc822", ".mht");

        /// <summary>
        /// Defines type information for Xml alternative format import part.
        /// </summary>
        public static readonly PartTypeInfo Xml = new("application/xml", ".xml");

        /// <summary>
        /// Defines type information for TextPlain alternative format import part.
        /// </summary>
        public static readonly PartTypeInfo TextPlain = new("text/plain", ".txt");

        /// <summary>
        /// Defines type information for WordprocessingML alternative format import part.
        /// </summary>
        public static readonly PartTypeInfo WordprocessingML = new("application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml", ".docx");

        /// <summary>
        /// Defines type information for OfficeWordMacroEnabled alternative format import part.
        /// </summary>
        public static readonly PartTypeInfo OfficeWordMacroEnabled = new("application/vnd.ms-word.document.macroEnabled.main+xml", ".docm");

        /// <summary>
        /// Defines type information for OfficeWordTemplate alternative format import part.
        /// </summary>
        public static readonly PartTypeInfo OfficeWordTemplate = new("application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml", ".dotx");

        /// <summary>
        /// Defines type information for OfficeWordMacroEnabledTemplate alternative format import part.
        /// </summary>
        public static readonly PartTypeInfo OfficeWordMacroEnabledTemplate = new("application/vnd.ms-word.template.macroEnabledTemplate.main+xml", ".dotm");

        /// <summary>
        /// Defines type information for Rtf alternative format import part.
        /// </summary>
        public static readonly PartTypeInfo Rtf = new("application/rtf", ".rtf");

        /// <summary>
        /// Defines type information for Html alternative format import part.
        /// </summary>
        public static readonly PartTypeInfo Html = new("text/html", ".htm");
    }
}
