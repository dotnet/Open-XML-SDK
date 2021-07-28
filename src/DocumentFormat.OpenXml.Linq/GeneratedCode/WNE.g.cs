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
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="acds" />, <see cref="keymap" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="acdName" />, <see cref="argValue" />, <see cref="fciBasedOn" />, <see cref="fciIndexBasedOn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AllocatedCommand, AllocatedCommandKeyboardCustomization.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName acd = wne + "acd";

        /// <summary>
        /// Represents the wne:acdEntry XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="acdManifest" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="acdName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AllocatedCommandManifestEntry.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName acdEntry = wne + "acdEntry";

        /// <summary>
        /// Represents the wne:acdManifest XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="toolbars" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acdEntry" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AllocatedCommandManifest.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName acdManifest = wne + "acdManifest";

        /// <summary>
        /// Represents the wne:acdName XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="acd" />, <see cref="acdEntry" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AllocatedCommand.AcceleratorName, AllocatedCommandKeyboardCustomization.AcceleratorName, AllocatedCommandManifestEntry.AcceleratorName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName acdName = wne + "acdName";

        /// <summary>
        /// Represents the wne:acds XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcg" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AllocatedCommands.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName acds = wne + "acds";

        /// <summary>
        /// Represents the wne:active XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="recipientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RecordIncluded.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName active = wne + "active";

        /// <summary>
        /// Represents the wne:argValue XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="acd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AllocatedCommand.ArgumentValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName argValue = wne + "argValue";

        /// <summary>
        /// Represents the wne:bEncrypt XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="mcd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Mcd.BEncrypt.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bEncrypt = wne + "bEncrypt";

        /// <summary>
        /// Represents the wne:chmPrimary XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: KeyMapEntry.CharacterMapPrimary.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chmPrimary = wne + "chmPrimary";

        /// <summary>
        /// Represents the wne:chmSecondary XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: KeyMapEntry.CharacterMapSecondary.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chmSecondary = wne + "chmSecondary";

        /// <summary>
        /// Represents the wne:cmg XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="mcd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Mcd.Cmg.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cmg = wne + "cmg";

        /// <summary>
        /// Represents the wne:docEvents XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="vbaSuppData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="eventDocBuildingBlockAfterInsert" />, <see cref="eventDocClose" />, <see cref="eventDocContentControlAfterInsert" />, <see cref="eventDocContentControlBeforeDelete" />, <see cref="eventDocContentControlContentUpdate" />, <see cref="eventDocContentControlOnEnter" />, <see cref="eventDocContentControlOnExit" />, <see cref="eventDocNew" />, <see cref="eventDocOpen" />, <see cref="eventDocStoreUpdate" />, <see cref="eventDocSync" />, <see cref="eventDocXmlAfterInsert" />, <see cref="eventDocXmlBeforeDelete" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocEvents.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docEvents = wne + "docEvents";

        /// <summary>
        /// Represents the wne:eventDocBuildingBlockAfterInsert XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocBuildingBlockAfterInsertXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocBuildingBlockAfterInsert = wne + "eventDocBuildingBlockAfterInsert";

        /// <summary>
        /// Represents the wne:eventDocClose XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocCloseXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocClose = wne + "eventDocClose";

        /// <summary>
        /// Represents the wne:eventDocContentControlAfterInsert XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocContentControlAfterInsertXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocContentControlAfterInsert = wne + "eventDocContentControlAfterInsert";

        /// <summary>
        /// Represents the wne:eventDocContentControlBeforeDelete XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocContentControlBeforeDeleteXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocContentControlBeforeDelete = wne + "eventDocContentControlBeforeDelete";

        /// <summary>
        /// Represents the wne:eventDocContentControlContentUpdate XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocContentControlUpdateXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocContentControlContentUpdate = wne + "eventDocContentControlContentUpdate";

        /// <summary>
        /// Represents the wne:eventDocContentControlOnEnter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocContentControlOnEnterXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocContentControlOnEnter = wne + "eventDocContentControlOnEnter";

        /// <summary>
        /// Represents the wne:eventDocContentControlOnExit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocContentControlOnExistXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocContentControlOnExit = wne + "eventDocContentControlOnExit";

        /// <summary>
        /// Represents the wne:eventDocNew XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocNewXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocNew = wne + "eventDocNew";

        /// <summary>
        /// Represents the wne:eventDocOpen XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocOpenXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocOpen = wne + "eventDocOpen";

        /// <summary>
        /// Represents the wne:eventDocStoreUpdate XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocStoreUpdateXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocStoreUpdate = wne + "eventDocStoreUpdate";

        /// <summary>
        /// Represents the wne:eventDocSync XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocSyncXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocSync = wne + "eventDocSync";

        /// <summary>
        /// Represents the wne:eventDocXmlAfterInsert XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocXmlAfterInsertXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocXmlAfterInsert = wne + "eventDocXmlAfterInsert";

        /// <summary>
        /// Represents the wne:eventDocXmlBeforeDelete XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docEvents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EventDocXmlBeforeDeleteXsdString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eventDocXmlBeforeDelete = wne + "eventDocXmlBeforeDelete";

        /// <summary>
        /// Represents the wne:fci XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="fciIndex" />, <see cref="fciName" />, <see cref="swArg" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FixedCommandKeyboardCustomization.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fci = wne + "fci";

        /// <summary>
        /// Represents the wne:fciBasedOn XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="acd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AllocatedCommand.CommandBasedOn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fciBasedOn = wne + "fciBasedOn";

        /// <summary>
        /// Represents the wne:fciIndex XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fci" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FixedCommandKeyboardCustomization.CommandIndex.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fciIndex = wne + "fciIndex";

        /// <summary>
        /// Represents the wne:fciIndexBasedOn XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="acd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AllocatedCommand.CommandIndexBasedOn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fciIndexBasedOn = wne + "fciIndexBasedOn";

        /// <summary>
        /// Represents the wne:fciName XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fci" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FixedCommandKeyboardCustomization.CommandName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fciName = wne + "fciName";

        /// <summary>
        /// Represents the wne:hash XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="recipientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RecordHashCode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hash = wne + "hash";

        /// <summary>
        /// Represents the wne:kcmPrimary XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: KeyMapEntry.KeyCodePrimary.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName kcmPrimary = wne + "kcmPrimary";

        /// <summary>
        /// Represents the wne:kcmSecondary XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: KeyMapEntry.KeyCodeSecondary.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName kcmSecondary = wne + "kcmSecondary";

        /// <summary>
        /// Represents the wne:keymap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="keymaps" />, <see cref="keymapsBad" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acd" />, <see cref="fci" />, <see cref="macro" />, <see cref="wch" />, <see cref="wll" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="chmPrimary" />, <see cref="chmSecondary" />, <see cref="kcmPrimary" />, <see cref="kcmSecondary" />, <see cref="mask" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: KeyMapEntry.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName keymap = wne + "keymap";

        /// <summary>
        /// Represents the wne:keymaps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcg" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: KeyMapCustomizations.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName keymaps = wne + "keymaps";

        /// <summary>
        /// Represents the wne:keymapsBad XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcg" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MismatchedKeyMapCustomization.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName keymapsBad = wne + "keymapsBad";

        /// <summary>
        /// Represents the wne:macro XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="macroName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MacroKeyboardCustomization.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName macro = wne + "macro";

        /// <summary>
        /// Represents the wne:macroName XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="macro" />, <see cref="mcd" />, <see cref="wll" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: MacroKeyboardCustomization.MacroName, Mcd.MacroName, WllMacroKeyboardCustomization.MacroName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName macroName = wne + "macroName";

        /// <summary>
        /// Represents the wne:mask XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: KeyMapEntry.Mask.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mask = wne + "mask";

        /// <summary>
        /// Represents the wne:mcd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mcds" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="bEncrypt" />, <see cref="cmg" />, <see cref="macroName" />, <see cref="menuHelp" />, <see cref="name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Mcd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mcd = wne + "mcd";

        /// <summary>
        /// Represents the wne:mcds XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="vbaSuppData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="mcd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Mcds.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mcds = wne + "mcds";

        /// <summary>
        /// Represents the wne:menuHelp XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="mcd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Mcd.MenuHelp.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName menuHelp = wne + "menuHelp";

        /// <summary>
        /// Represents the wne:name XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="mcd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Mcd.Name.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName name = wne + "name";

        /// <summary>
        /// Represents the wne:recipientData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="recipients" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="active" />, <see cref="hash" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SingleDataSourceRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName recipientData = wne + "recipientData";

        /// <summary>
        /// Represents the wne:recipients XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="recipientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MailMergeRecipients.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName recipients = wne + "recipients";

        /// <summary>
        /// Represents the wne:swArg XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fci" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FixedCommandKeyboardCustomization.Argument.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName swArg = wne + "swArg";

        /// <summary>
        /// Represents the wne:tcg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="acds" />, <see cref="keymaps" />, <see cref="keymapsBad" />, <see cref="toolbars" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TemplateCommandGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tcg = wne + "tcg";

        /// <summary>
        /// Represents the wne:toolbarData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="toolbars" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ToolbarData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName toolbarData = wne + "toolbarData";

        /// <summary>
        /// Represents the wne:toolbars XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcg" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acdManifest" />, <see cref="toolbarData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Toolbars.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName toolbars = wne + "toolbars";

        /// <summary>
        /// Represents the wne:val XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="active" />, <see cref="hash" />, <see cref="wch" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CharacterInsertion.Val, RecordHashCode.Val, RecordIncluded.Val.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName val = wne + "val";

        /// <summary>
        /// Represents the wne:vbaSuppData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="docEvents" />, <see cref="mcds" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VbaSuppData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vbaSuppData = wne + "vbaSuppData";

        /// <summary>
        /// Represents the wne:wch XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CharacterInsertion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wch = wne + "wch";

        /// <summary>
        /// Represents the wne:wll XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="keymap" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="macroName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WllMacroKeyboardCustomization.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wll = wne + "wll";
    }
}
