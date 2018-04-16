// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class AlternativeFormatImportPartTypeInfo
    {
        internal static string GetContentType(AlternativeFormatImportPartType partType)
        {
            switch (partType)
            {
                //case AlternativeFormatImportPartType.Text:
                //    return "application/text/plain";
                case AlternativeFormatImportPartType.Xhtml:
                    return "application/xhtml+xml";

                case AlternativeFormatImportPartType.Mht:
                    return "message/rfc822";

                case AlternativeFormatImportPartType.Xml:
                    return "application/xml";

                //case AlternativeFormatImportPartType.TextXml:
                //    return "text/xml";
                case AlternativeFormatImportPartType.TextPlain:
                    return "text/plain";

                case AlternativeFormatImportPartType.WordprocessingML:
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml";

                case AlternativeFormatImportPartType.OfficeWordMacroEnabled:
                    return "application/vnd.ms-word.document.macroEnabled.main+xml";

                case AlternativeFormatImportPartType.OfficeWordTemplate:
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml";

                case AlternativeFormatImportPartType.OfficeWordMacroEnabledTemplate:
                    return "application/vnd.ms-word.template.macroEnabledTemplate.main+xml";

                case AlternativeFormatImportPartType.Rtf:
                    return "application/rtf";

                case AlternativeFormatImportPartType.Html:
                    return "text/html";

                default:
                    throw new ArgumentOutOfRangeException(nameof(partType));
            }
        }

        internal static string GetTargetExtension(AlternativeFormatImportPartType imageType)
        {
            switch (imageType)
            {
                //case AlternativeFormatImportPartType.Text:
                //    return ".txt";
                case AlternativeFormatImportPartType.Xhtml:
                    return ".xhtml";

                case AlternativeFormatImportPartType.Mht:
                    return ".mht";

                case AlternativeFormatImportPartType.Xml:
                    return ".xml";

                //case AlternativeFormatImportPartType.TextXml:
                //    return ".xml";
                case AlternativeFormatImportPartType.TextPlain:
                    return ".txt";

                case AlternativeFormatImportPartType.WordprocessingML:
                    return ".docx";

                case AlternativeFormatImportPartType.OfficeWordMacroEnabled:
                    return ".docm";

                case AlternativeFormatImportPartType.OfficeWordTemplate:
                    return ".dotx";

                case AlternativeFormatImportPartType.OfficeWordMacroEnabledTemplate:
                    return ".dotm";

                case AlternativeFormatImportPartType.Rtf:
                    return ".rtf";

                case AlternativeFormatImportPartType.Html:
                    return ".htm";

                default:
                    return ".dat";
            }
        }
    }
}
