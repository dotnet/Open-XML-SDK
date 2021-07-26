// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wne="http://schemas.microsoft.com/office/word/2006/wordml" namespace.
    /// </summary>
    public static class WNE
    {
        /// <summary>
        /// Defines the XML namespace associated with the wne prefix.
        /// </summary>
        public static readonly XNamespace wne = "http://schemas.microsoft.com/office/word/2006/wordml";

        /// <summary>
        /// Represents the wne:acd XML elements.
        /// </summary>
        public static readonly XName acd = wne + "acd";

        /// <summary>
        /// Represents the wne:acdEntry XML element.
        /// </summary>
        public static readonly XName acdEntry = wne + "acdEntry";

        /// <summary>
        /// Represents the wne:acdManifest XML element.
        /// </summary>
        public static readonly XName acdManifest = wne + "acdManifest";

        /// <summary>
        /// Represents the wne:acdName XML attributes.
        /// </summary>
        public static readonly XName acdName = wne + "acdName";

        /// <summary>
        /// Represents the wne:acds XML element.
        /// </summary>
        public static readonly XName acds = wne + "acds";

        /// <summary>
        /// Represents the wne:active XML element.
        /// </summary>
        public static readonly XName active = wne + "active";

        /// <summary>
        /// Represents the wne:argValue XML attribute.
        /// </summary>
        public static readonly XName argValue = wne + "argValue";

        /// <summary>
        /// Represents the wne:bEncrypt XML attribute.
        /// </summary>
        public static readonly XName bEncrypt = wne + "bEncrypt";

        /// <summary>
        /// Represents the wne:chmPrimary XML attribute.
        /// </summary>
        public static readonly XName chmPrimary = wne + "chmPrimary";

        /// <summary>
        /// Represents the wne:chmSecondary XML attribute.
        /// </summary>
        public static readonly XName chmSecondary = wne + "chmSecondary";

        /// <summary>
        /// Represents the wne:cmg XML attribute.
        /// </summary>
        public static readonly XName cmg = wne + "cmg";

        /// <summary>
        /// Represents the wne:docEvents XML element.
        /// </summary>
        public static readonly XName docEvents = wne + "docEvents";

        /// <summary>
        /// Represents the wne:eventDocBuildingBlockAfterInsert XML element.
        /// </summary>
        public static readonly XName eventDocBuildingBlockAfterInsert = wne + "eventDocBuildingBlockAfterInsert";

        /// <summary>
        /// Represents the wne:eventDocClose XML element.
        /// </summary>
        public static readonly XName eventDocClose = wne + "eventDocClose";

        /// <summary>
        /// Represents the wne:eventDocContentControlAfterInsert XML element.
        /// </summary>
        public static readonly XName eventDocContentControlAfterInsert = wne + "eventDocContentControlAfterInsert";

        /// <summary>
        /// Represents the wne:eventDocContentControlBeforeDelete XML element.
        /// </summary>
        public static readonly XName eventDocContentControlBeforeDelete = wne + "eventDocContentControlBeforeDelete";

        /// <summary>
        /// Represents the wne:eventDocContentControlContentUpdate XML element.
        /// </summary>
        public static readonly XName eventDocContentControlContentUpdate = wne + "eventDocContentControlContentUpdate";

        /// <summary>
        /// Represents the wne:eventDocContentControlOnEnter XML element.
        /// </summary>
        public static readonly XName eventDocContentControlOnEnter = wne + "eventDocContentControlOnEnter";

        /// <summary>
        /// Represents the wne:eventDocContentControlOnExit XML element.
        /// </summary>
        public static readonly XName eventDocContentControlOnExit = wne + "eventDocContentControlOnExit";

        /// <summary>
        /// Represents the wne:eventDocNew XML element.
        /// </summary>
        public static readonly XName eventDocNew = wne + "eventDocNew";

        /// <summary>
        /// Represents the wne:eventDocOpen XML element.
        /// </summary>
        public static readonly XName eventDocOpen = wne + "eventDocOpen";

        /// <summary>
        /// Represents the wne:eventDocStoreUpdate XML element.
        /// </summary>
        public static readonly XName eventDocStoreUpdate = wne + "eventDocStoreUpdate";

        /// <summary>
        /// Represents the wne:eventDocSync XML element.
        /// </summary>
        public static readonly XName eventDocSync = wne + "eventDocSync";

        /// <summary>
        /// Represents the wne:eventDocXmlAfterInsert XML element.
        /// </summary>
        public static readonly XName eventDocXmlAfterInsert = wne + "eventDocXmlAfterInsert";

        /// <summary>
        /// Represents the wne:eventDocXmlBeforeDelete XML element.
        /// </summary>
        public static readonly XName eventDocXmlBeforeDelete = wne + "eventDocXmlBeforeDelete";

        /// <summary>
        /// Represents the wne:fci XML element.
        /// </summary>
        public static readonly XName fci = wne + "fci";

        /// <summary>
        /// Represents the wne:fciBasedOn XML attribute.
        /// </summary>
        public static readonly XName fciBasedOn = wne + "fciBasedOn";

        /// <summary>
        /// Represents the wne:fciIndex XML attribute.
        /// </summary>
        public static readonly XName fciIndex = wne + "fciIndex";

        /// <summary>
        /// Represents the wne:fciIndexBasedOn XML attribute.
        /// </summary>
        public static readonly XName fciIndexBasedOn = wne + "fciIndexBasedOn";

        /// <summary>
        /// Represents the wne:fciName XML attribute.
        /// </summary>
        public static readonly XName fciName = wne + "fciName";

        /// <summary>
        /// Represents the wne:hash XML element.
        /// </summary>
        public static readonly XName hash = wne + "hash";

        /// <summary>
        /// Represents the wne:kcmPrimary XML attribute.
        /// </summary>
        public static readonly XName kcmPrimary = wne + "kcmPrimary";

        /// <summary>
        /// Represents the wne:kcmSecondary XML attribute.
        /// </summary>
        public static readonly XName kcmSecondary = wne + "kcmSecondary";

        /// <summary>
        /// Represents the wne:keymap XML element.
        /// </summary>
        public static readonly XName keymap = wne + "keymap";

        /// <summary>
        /// Represents the wne:keymaps XML element.
        /// </summary>
        public static readonly XName keymaps = wne + "keymaps";

        /// <summary>
        /// Represents the wne:keymapsBad XML element.
        /// </summary>
        public static readonly XName keymapsBad = wne + "keymapsBad";

        /// <summary>
        /// Represents the wne:macro XML element.
        /// </summary>
        public static readonly XName macro = wne + "macro";

        /// <summary>
        /// Represents the wne:macroName XML attributes.
        /// </summary>
        public static readonly XName macroName = wne + "macroName";

        /// <summary>
        /// Represents the wne:mask XML attribute.
        /// </summary>
        public static readonly XName mask = wne + "mask";

        /// <summary>
        /// Represents the wne:mcd XML element.
        /// </summary>
        public static readonly XName mcd = wne + "mcd";

        /// <summary>
        /// Represents the wne:mcds XML element.
        /// </summary>
        public static readonly XName mcds = wne + "mcds";

        /// <summary>
        /// Represents the wne:menuHelp XML attribute.
        /// </summary>
        public static readonly XName menuHelp = wne + "menuHelp";

        /// <summary>
        /// Represents the wne:name XML attribute.
        /// </summary>
        public static readonly XName name = wne + "name";

        /// <summary>
        /// Represents the wne:recipientData XML element.
        /// </summary>
        public static readonly XName recipientData = wne + "recipientData";

        /// <summary>
        /// Represents the wne:recipients XML element.
        /// </summary>
        public static readonly XName recipients = wne + "recipients";

        /// <summary>
        /// Represents the wne:swArg XML attribute.
        /// </summary>
        public static readonly XName swArg = wne + "swArg";

        /// <summary>
        /// Represents the wne:tcg XML element.
        /// </summary>
        public static readonly XName tcg = wne + "tcg";

        /// <summary>
        /// Represents the wne:toolbarData XML element.
        /// </summary>
        public static readonly XName toolbarData = wne + "toolbarData";

        /// <summary>
        /// Represents the wne:toolbars XML element.
        /// </summary>
        public static readonly XName toolbars = wne + "toolbars";

        /// <summary>
        /// Represents the wne:val XML attributes.
        /// </summary>
        public static readonly XName val = wne + "val";

        /// <summary>
        /// Represents the wne:vbaSuppData XML element.
        /// </summary>
        public static readonly XName vbaSuppData = wne + "vbaSuppData";

        /// <summary>
        /// Represents the wne:wch XML element.
        /// </summary>
        public static readonly XName wch = wne + "wch";

        /// <summary>
        /// Represents the wne:wll XML element.
        /// </summary>
        public static readonly XName wll = wne + "wll";
    }
}
