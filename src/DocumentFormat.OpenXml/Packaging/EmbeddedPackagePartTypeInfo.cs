﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class EmbeddedPackagePartTypeInfo
    {
        internal static string GetContentType(EmbeddedPackagePartType embeddedPackageType)
            => embeddedPackageType switch
            {
                EmbeddedPackagePartType.Docm => "application/vnd.ms-word.document.macroEnabled.12",

                EmbeddedPackagePartType.Docx => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",

                EmbeddedPackagePartType.Dotm => "application/vnd.ms-word.template.macroEnabled.12",

                EmbeddedPackagePartType.Dotx => "application/vnd.openxmlformats-officedocument.wordprocessingml.template",

                EmbeddedPackagePartType.Potm => "application/vnd.ms-powerpoint.template.macroEnabled.12",

                EmbeddedPackagePartType.Potx => "application/vnd.openxmlformats-officedocument.presentationml.template",

                EmbeddedPackagePartType.Ppam => "application/vnd.ms-powerpoint.addin.macroEnabled.12",

                EmbeddedPackagePartType.Ppsm => "application/vnd.ms-powerpoint.slideshow.macroEnabled.12",

                EmbeddedPackagePartType.Ppsx => "application/vnd.openxmlformats-officedocument.presentationml.slideshow",

                EmbeddedPackagePartType.Pptm => "application/vnd.ms-powerpoint.presentation.macroEnabled.12",

                EmbeddedPackagePartType.Pptx => "application/vnd.openxmlformats-officedocument.presentationml.presentation",

                EmbeddedPackagePartType.Sldm => "application/vnd.ms-powerpoint.slide.macroEnabled.12",

                EmbeddedPackagePartType.Sldx => "application/vnd.openxmlformats-officedocument.presentationml.slide",

                EmbeddedPackagePartType.Thmx => "application/vnd.ms-officetheme",

                EmbeddedPackagePartType.Xlam => "application/vnd.ms-excel.addin.macroEnabled.12",

                EmbeddedPackagePartType.Xlsb => "application/vnd.ms-excel.sheet.binary.macroEnabled.12",

                EmbeddedPackagePartType.Xlsm => "application/vnd.ms-excel.sheet.macroEnabled.12",

                EmbeddedPackagePartType.Xlsx => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",

                EmbeddedPackagePartType.Xltm => "application/vnd.ms-excel.template.macroEnabled.12",

                EmbeddedPackagePartType.Xltx => "application/vnd.openxmlformats-officedocument.spreadsheetml.template",

                _ => throw new ArgumentOutOfRangeException(nameof(embeddedPackageType)),

            };

        internal static string GetTargetExtension(EmbeddedPackagePartType embeddedPackageType)
            => embeddedPackageType switch
            {
                EmbeddedPackagePartType.Docm => ".docm",

                EmbeddedPackagePartType.Docx => ".docx",

                EmbeddedPackagePartType.Dotm => ".dotm",

                EmbeddedPackagePartType.Dotx => ".dotx",

                EmbeddedPackagePartType.Potm => ".potm",

                EmbeddedPackagePartType.Potx => ".potx",

                EmbeddedPackagePartType.Ppam => ".ppam",

                EmbeddedPackagePartType.Ppsm => ".ppsm",

                EmbeddedPackagePartType.Ppsx => ".ppsx",

                EmbeddedPackagePartType.Pptm => ".pptm",

                EmbeddedPackagePartType.Pptx => ".pptx",

                EmbeddedPackagePartType.Sldm => ".sldm",

                EmbeddedPackagePartType.Sldx => ".sldx",

                EmbeddedPackagePartType.Thmx => ".thmx",

                EmbeddedPackagePartType.Xlam => ".xlam",

                EmbeddedPackagePartType.Xlsb => ".xlsb",

                EmbeddedPackagePartType.Xlsm => ".xlsm",

                EmbeddedPackagePartType.Xlsx => ".xlsx",

                EmbeddedPackagePartType.Xltm => ".xltm",

                EmbeddedPackagePartType.Xltx => ".xltx",

                _ => ".package",
            };

        internal static EmbeddedPackagePartType GetEmbeddedPackagePartType(string extension)
            => extension.ToLower() switch
            {
                ".docm" => EmbeddedPackagePartType.Docm,

                ".docx" => EmbeddedPackagePartType.Docx,

                ".dotm" => EmbeddedPackagePartType.Dotm,

                ".dotx" => EmbeddedPackagePartType.Dotx,

                ".potm" => EmbeddedPackagePartType.Potm,

                ".potx" => EmbeddedPackagePartType.Potx,

                ".ppam" => EmbeddedPackagePartType.Ppam,

                ".ppsm" => EmbeddedPackagePartType.Ppsm,

                ".ppsx" => EmbeddedPackagePartType.Ppsx,

                ".pptm" => EmbeddedPackagePartType.Pptm,

                ".pptx" => EmbeddedPackagePartType.Pptx,

                ".sldm" => EmbeddedPackagePartType.Sldm,

                ".sldx" => EmbeddedPackagePartType.Sldx,

                ".thmx" => EmbeddedPackagePartType.Thmx,

                ".xlam" => EmbeddedPackagePartType.Xlam,

                ".xlsb" => EmbeddedPackagePartType.Xlsb,

                ".xlsm" => EmbeddedPackagePartType.Xlsm,

                ".xlsx" => EmbeddedPackagePartType.Xlsx,

                ".xltm" => EmbeddedPackagePartType.Xltm,

                ".xltx" => EmbeddedPackagePartType.Xltx,

                _ => throw new NotSupportedException($"{extension} is not supported"),
            };
    }
}
