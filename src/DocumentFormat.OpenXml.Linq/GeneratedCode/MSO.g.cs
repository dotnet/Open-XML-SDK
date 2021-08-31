// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:mso="http://schemas.microsoft.com/office/2006/01/customui" namespace.
    /// </summary>
    public static class MSO
    {
        /// <summary>
        /// Defines the XML namespace associated with the mso prefix.
        /// </summary>
        public static readonly XNamespace mso = "http://schemas.microsoft.com/office/2006/01/customui";

        /// <summary>
        /// Represents the mso:box XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="box" />, <see cref="button" />, <see cref="buttonGroup" />, <see cref="checkBox" />, <see cref="comboBox" />, <see cref="control" />, <see cref="dropDown" />, <see cref="dynamicMenu" />, <see cref="editBox" />, <see cref="gallery" />, <see cref="labelControl" />, <see cref="menu" />, <see cref="splitButton" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.boxStyle" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Box.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName box = mso + "box";

        /// <summary>
        /// Represents the mso:button XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="dialogBoxLauncher" />, <see cref="documentControls" />, <see cref="dropDown" />, <see cref="gallery" />, <see cref="group" />, <see cref="menu" />, <see cref="officeMenu" />, <see cref="sharedControls" />, <see cref="splitButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Button, UnsizedButton, VisibleButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName button = mso + "button";

        /// <summary>
        /// Represents the mso:buttonGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="control" />, <see cref="dynamicMenu" />, <see cref="gallery" />, <see cref="menu" />, <see cref="splitButton" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ButtonGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName buttonGroup = mso + "buttonGroup";

        /// <summary>
        /// Represents the mso:checkBox XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="group" />, <see cref="menu" />, <see cref="officeMenu" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getPressed" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CheckBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName checkBox = mso + "checkBox";

        /// <summary>
        /// Represents the mso:comboBox XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="item" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getItemCount" />, <see cref="NoNamespace.getItemID" />, <see cref="NoNamespace.getItemImage" />, <see cref="NoNamespace.getItemLabel" />, <see cref="NoNamespace.getItemScreentip" />, <see cref="NoNamespace.getItemSupertip" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getText" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.invalidateContentOnDrop" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.maxLength" />, <see cref="NoNamespace.onChange" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showItemImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.sizeString" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ComboBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName comboBox = mso + "comboBox";

        /// <summary>
        /// Represents the mso:command XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="commands" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.onAction" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RepurposedCommand.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName command = mso + "command";

        /// <summary>
        /// Represents the mso:commands XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customUI" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="command" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RepurposedCommands.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commands = mso + "commands";

        /// <summary>
        /// Represents the mso:contextualTabs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ribbon" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tabSet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContextualTabSets.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contextualTabs = mso + "contextualTabs";

        /// <summary>
        /// Represents the mso:control XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="documentControls" />, <see cref="group" />, <see cref="menu" />, <see cref="officeMenu" />, <see cref="sharedControls" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ControlClone, QuickAccessToolbarControlClone, UnsizedControlClone.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName control = mso + "control";

        /// <summary>
        /// Represents the mso:customUI XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="commands" />, <see cref="ribbon" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.loadImage" />, <see cref="NoNamespace.onLoad" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomUI.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customUI = mso + "customUI";

        /// <summary>
        /// Represents the mso:dialogBoxLauncher XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DialogBoxLauncher.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dialogBoxLauncher = mso + "dialogBoxLauncher";

        /// <summary>
        /// Represents the mso:documentControls XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="qat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="control" />, <see cref="separator" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentSpecificQuickAccessToolbarControls.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName documentControls = mso + "documentControls";

        /// <summary>
        /// Represents the mso:dropDown XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="item" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getItemCount" />, <see cref="NoNamespace.getItemID" />, <see cref="NoNamespace.getItemImage" />, <see cref="NoNamespace.getItemLabel" />, <see cref="NoNamespace.getItemScreentip" />, <see cref="NoNamespace.getItemSupertip" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getSelectedItemID" />, <see cref="NoNamespace.getSelectedItemIndex" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showItemImage" />, <see cref="NoNamespace.showItemLabel" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.sizeString" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropDown.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropDown = mso + "dropDown";

        /// <summary>
        /// Represents the mso:dynamicMenu XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="group" />, <see cref="menu" />, <see cref="officeMenu" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getContent" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.invalidateContentOnDrop" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DynamicMenu, UnsizedDynamicMenu.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dynamicMenu = mso + "dynamicMenu";

        /// <summary>
        /// Represents the mso:editBox XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="group" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getText" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.maxLength" />, <see cref="NoNamespace.onChange" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.sizeString" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EditBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName editBox = mso + "editBox";

        /// <summary>
        /// Represents the mso:gallery XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="group" />, <see cref="menu" />, <see cref="officeMenu" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="item" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.columns" />, <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getItemCount" />, <see cref="NoNamespace.getItemHeight" />, <see cref="NoNamespace.getItemID" />, <see cref="NoNamespace.getItemImage" />, <see cref="NoNamespace.getItemLabel" />, <see cref="NoNamespace.getItemScreentip" />, <see cref="NoNamespace.getItemSupertip" />, <see cref="NoNamespace.getItemWidth" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getSelectedItemID" />, <see cref="NoNamespace.getSelectedItemIndex" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.invalidateContentOnDrop" />, <see cref="NoNamespace.itemHeight" />, <see cref="NoNamespace.itemWidth" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.rows" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showItemImage" />, <see cref="NoNamespace.showItemLabel" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.sizeString" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Gallery, UnsizedGallery.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gallery = mso + "gallery";

        /// <summary>
        /// Represents the mso:group XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tab" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="box" />, <see cref="button" />, <see cref="buttonGroup" />, <see cref="checkBox" />, <see cref="comboBox" />, <see cref="control" />, <see cref="dialogBoxLauncher" />, <see cref="dropDown" />, <see cref="dynamicMenu" />, <see cref="editBox" />, <see cref="gallery" />, <see cref="labelControl" />, <see cref="menu" />, <see cref="separator" />, <see cref="splitButton" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Group.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName group = mso + "group";

        /// <summary>
        /// Represents the mso:item XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="comboBox" />, <see cref="dropDown" />, <see cref="gallery" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.supertip" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Item.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName item = mso + "item";

        /// <summary>
        /// Represents the mso:labelControl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="group" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName labelControl = mso + "labelControl";

        /// <summary>
        /// Represents the mso:menu XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="group" />, <see cref="menu" />, <see cref="officeMenu" />, <see cref="splitButton" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="checkBox" />, <see cref="control" />, <see cref="dynamicMenu" />, <see cref="gallery" />, <see cref="menu" />, <see cref="menuSeparator" />, <see cref="splitButton" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getTitle" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.itemSize" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Menu, MenuWithTitle, UnsizedMenu.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName menu = mso + "menu";

        /// <summary>
        /// Represents the mso:menuSeparator XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="menu" />, <see cref="officeMenu" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getTitle" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MenuSeparator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName menuSeparator = mso + "menuSeparator";

        /// <summary>
        /// Represents the mso:officeMenu XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ribbon" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="checkBox" />, <see cref="control" />, <see cref="dynamicMenu" />, <see cref="gallery" />, <see cref="menu" />, <see cref="menuSeparator" />, <see cref="splitButton" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeMenu.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName officeMenu = mso + "officeMenu";

        /// <summary>
        /// Represents the mso:qat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ribbon" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="documentControls" />, <see cref="sharedControls" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: QuickAccessToolbar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName qat = mso + "qat";

        /// <summary>
        /// Represents the mso:ribbon XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customUI" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="contextualTabs" />, <see cref="officeMenu" />, <see cref="qat" />, <see cref="tabs" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.startFromScratch" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Ribbon.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ribbon = mso + "ribbon";

        /// <summary>
        /// Represents the mso:separator XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="documentControls" />, <see cref="group" />, <see cref="sharedControls" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VerticalSeparator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName separator = mso + "separator";

        /// <summary>
        /// Represents the mso:sharedControls XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="qat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="control" />, <see cref="separator" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SharedQatControls.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sharedControls = mso + "sharedControls";

        /// <summary>
        /// Represents the mso:splitButton XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="group" />, <see cref="menu" />, <see cref="officeMenu" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="menu" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SplitButton, SplitButtonWithTitle, UnsizedSplitButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName splitButton = mso + "splitButton";

        /// <summary>
        /// Represents the mso:tab XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tabs" />, <see cref="tabSet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="group" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tab.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tab = mso + "tab";

        /// <summary>
        /// Represents the mso:tabs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ribbon" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tab" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tabs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tabs = mso + "tabs";

        /// <summary>
        /// Represents the mso:tabSet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="contextualTabs" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tab" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContextualTabSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tabSet = mso + "tabSet";

        /// <summary>
        /// Represents the mso:toggleButton XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="group" />, <see cref="menu" />, <see cref="officeMenu" />, <see cref="splitButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getPressed" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ToggleButton, UnsizedToggleButton, VisibleToggleButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName toggleButton = mso + "toggleButton";
    }
}
