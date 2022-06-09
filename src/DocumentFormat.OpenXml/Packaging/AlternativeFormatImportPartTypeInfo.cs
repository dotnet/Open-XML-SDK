// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class AlternativeFormatImportPartTypeInfo
    {
        internal static string GetContentType(AlternativeFormatImportPartType partType)
            => partType switch
            {
                // AlternativeFormatImportPartType.Text => "application/text/plain",
                AlternativeFormatImportPartType.Xhtml => "application/xhtml+xml",
                AlternativeFormatImportPartType.Mht => "message/rfc822",
                AlternativeFormatImportPartType.Xml => "application/xml",

                // AlternativeFormatImportPartType.TextXml => "text/xml",
                AlternativeFormatImportPartType.TextPlain => "text/plain",
                AlternativeFormatImportPartType.WordprocessingML => "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
                AlternativeFormatImportPartType.OfficeWordMacroEnabled => "application/vnd.ms-word.document.macroEnabled.main+xml",
                AlternativeFormatImportPartType.OfficeWordTemplate => "application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml",
                AlternativeFormatImportPartType.OfficeWordMacroEnabledTemplate => "application/vnd.ms-word.template.macroEnabledTemplate.main+xml",
                AlternativeFormatImportPartType.Rtf => "application/rtf",
                AlternativeFormatImportPartType.Html => "text/html",
                _ => throw new ArgumentOutOfRangeException(nameof(partType)),
            };

        internal static string GetTargetExtension(AlternativeFormatImportPartType imageType)
            => imageType switch
            {
                // AlternativeFormatImportPartType.Text => ".txt",
                AlternativeFormatImportPartType.Xhtml => ".xhtml",
                AlternativeFormatImportPartType.Mht => ".mht",
                AlternativeFormatImportPartType.Xml => ".xml",

                // AlternativeFormatImportPartType.TextXml => ".xml",
                AlternativeFormatImportPartType.TextPlain => ".txt",
                AlternativeFormatImportPartType.WordprocessingML => ".docx",
                AlternativeFormatImportPartType.OfficeWordMacroEnabled => ".docm",
                AlternativeFormatImportPartType.OfficeWordTemplate => ".dotx",
                AlternativeFormatImportPartType.OfficeWordMacroEnabledTemplate => ".dotm",
                AlternativeFormatImportPartType.Rtf => ".rtf",
                AlternativeFormatImportPartType.Html => ".htm",
                _ => ".dat",
            };
    }
}
