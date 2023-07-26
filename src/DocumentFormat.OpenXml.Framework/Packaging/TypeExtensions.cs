// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class TypeExtensions : Dictionary<string, string?>
    {
        internal TypeExtensions()
        {
            this["image/unknown"] = ".bin";
            this["image/bmp"] = ".bmp";
            this["image/gif"] = ".gif";
            this["image/png"] = ".png";
            this["image/jp2"] = ".jp2";
            this["image/tif"] = ".tif";
            this["image/tiff"] = ".tiff";
            this["image/xbm"] = ".xbm";
            this["image/x-icon"] = ".ico";
            this["image/x-pcx"] = ".pcx";
            this["image/x-pcz"] = ".pcz";
            this["image/x-emz"] = ".emz";
            this["image/x-wmz"] = ".wmz";
            this["image/jpeg"] = ".jpeg";
            this["image/x-emf"] = ".emf";
            this["image/x-wmf"] = ".wmf";
            this["image/svg+xml"] = ".svg";
            this["application/xml"] = ".xml";
            this["application/vnd.openxmlformats-officedocument.spreadsheetml.customProperty"] = ".xml";
            this["application/inkml+xml"] = ".xml";
            this["application/vnd.ms-office.activeX"] = ".bin";
            this["application/vnd.ms-office.activeX+xml"] = ".xml";
            this["application/vnd.openxmlformats-officedocument.oleObject"] = ".bin";
            this["application/vnd.ms-word.document.macroEnabled.12"] = ".docm";
            this["application/vnd.openxmlformats-officedocument.wordprocessingml.document"] = ".docx";
            this["application/vnd.ms-word.template.macroEnabled.12"] = ".dotm";
            this["application/vnd.openxmlformats-officedocument.wordprocessingml.template"] = ".dotx";
            this["application/vnd.ms-powerpoint.template.macroEnabled.12"] = ".potm";
            this["application/vnd.openxmlformats-officedocument.presentationml.template"] = ".potx";
            this["application/vnd.ms-powerpoint.addin.macroEnabled.12"] = ".ppam";
            this["application/vnd.ms-powerpoint.slideshow.macroEnabled.12"] = ".ppsm";
            this["application/vnd.openxmlformats-officedocument.presentationml.slideshow"] = ".ppsx";
            this["application/vnd.ms-powerpoint.presentation.macroEnabled.12"] = ".pptm";
            this["application/vnd.openxmlformats-officedocument.presentationml.presentation"] = ".pptx";
            this["application/vnd.ms-powerpoint.slide.macroEnabled.12"] = ".sldm";
            this["application/vnd.openxmlformats-officedocument.presentationml.slide"] = ".sldx";
            this["application/vnd.ms-officetheme"] = ".thmx";
            this["application/vnd.ms-excel.addin.macroEnabled.12"] = ".xlam";
            this["application/vnd.ms-excel.sheet.binary.macroEnabled.12"] = ".xlsb";
            this["application/vnd.ms-excel.sheet.macroEnabled.12"] = ".xlsm";
            this["application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"] = ".xlsx";
            this["application/vnd.ms-excel.template.macroEnabled.12"] = ".xltm";
            this["application/vnd.openxmlformats-officedocument.spreadsheetml.template"] = ".xltx";
            this["application/x-fontdata"] = ".fntdata";
            this["application/x-font-ttf"] = ".ttf";
            this["application/vnd.openxmlformats-officedocument.obfuscatedFont"] = ".odttf";
            this["application/vnd.openxmlformats-officedocument.wordprocessingml.mailMergeRecipientData+xml"] = ".xml";
            this["application/vnd.ms-word.mailMergeRecipientData+xml"] = ".xml";
        }
    }
}
