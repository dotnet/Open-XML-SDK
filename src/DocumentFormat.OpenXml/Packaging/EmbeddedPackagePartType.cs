// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines EmbeddedPackagePartType - types of EmbeddedPackagePart.
    /// </summary>
    public static class EmbeddedPackagePartType
    {
        /// <summary>
        /// Defines type information for Docm embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Docm = new("application/vnd.ms-word.document.macroEnabled.12", ".docm");

        /// <summary>
        /// Defines type information for Docx embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Docx = new("application/vnd.openxmlformats-officedocument.wordprocessingml.document", ".docx");

        /// <summary>
        /// Defines type information for Dotm embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Dotm = new("application/vnd.ms-word.template.macroEnabled.12", ".dotm");

        /// <summary>
        /// Defines type information for Dotx embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Dotx = new("application/vnd.openxmlformats-officedocument.wordprocessingml.template", ".dotx");

        /// <summary>
        /// Defines type information for Potm embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Potm = new("application/vnd.ms-powerpoint.template.macroEnabled.12", ".potm");

        /// <summary>
        /// Defines type information for Potx embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Potx = new("application/vnd.openxmlformats-officedocument.presentationml.template", ".potx");

        /// <summary>
        /// Defines type information for Ppam embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Ppam = new("application/vnd.ms-powerpoint.addin.macroEnabled.12", ".ppam");

        /// <summary>
        /// Defines type information for Ppsm embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Ppsm = new("application/vnd.ms-powerpoint.slideshow.macroEnabled.12", ".ppsm");

        /// <summary>
        /// Defines type information for Ppsx embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Ppsx = new("application/vnd.openxmlformats-officedocument.presentationml.slideshow", ".ppsx");

        /// <summary>
        /// Defines type information for Pptm embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Pptm = new("application/vnd.ms-powerpoint.presentation.macroEnabled.12", ".pptm");

        /// <summary>
        /// Defines type information for Pptx embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Pptx = new("application/vnd.openxmlformats-officedocument.presentationml.presentation", ".pptx");

        /// <summary>
        /// Defines type information for Sldm embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Sldm = new("application/vnd.ms-powerpoint.slide.macroEnabled.12", ".sldm");

        /// <summary>
        /// Defines type information for Sldx embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Sldx = new("application/vnd.openxmlformats-officedocument.presentationml.slide", ".sldx");

        /// <summary>
        /// Defines type information for Thmx embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Thmx = new("application/vnd.ms-officetheme", ".thmx");

        /// <summary>
        /// Defines type information for Xlam embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Xlam = new("application/vnd.ms-excel.addin.macroEnabled.12", ".xlam");

        /// <summary>
        /// Defines type information for Xlsb embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Xlsb = new("application/vnd.ms-excel.sheet.binary.macroEnabled.12", ".xlsb");

        /// <summary>
        /// Defines type information for Xlsm embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Xlsm = new("application/vnd.ms-excel.sheet.macroEnabled.12", ".xlsm");

        /// <summary>
        /// Defines type information for Xlsx embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Xlsx = new("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", ".xlsx");

        /// <summary>
        /// Defines type information for Xltm embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Xltm = new("application/vnd.ms-excel.template.macroEnabled.12", ".xltm");

        /// <summary>
        /// Defines type information for Xltx embedded package part.
        /// </summary>
        public static readonly PartTypeInfo Xltx = new("application/vnd.openxmlformats-officedocument.spreadsheetml.template", ".xltx");
    }
}
