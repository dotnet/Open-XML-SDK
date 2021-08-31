// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:mso14="http://schemas.microsoft.com/office/2009/07/customui" namespace.
    /// </summary>
    public static class MSO14
    {
        /// <summary>
        /// Defines the XML namespace associated with the mso14 prefix.
        /// </summary>
        public static readonly XNamespace mso14 = "http://schemas.microsoft.com/office/2009/07/customui";

        /// <summary>
        /// Represents the mso14:backstage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customUI" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="tab" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.onHide" />, <see cref="NoNamespace.onShow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Backstage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName backstage = mso14 + "backstage";

        /// <summary>
        /// Represents the mso14:bottomItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="checkBox" />, <see cref="comboBox" />, <see cref="dropDown" />, <see cref="editBox" />, <see cref="groupBox" />, <see cref="hyperlink" />, <see cref="imageControl" />, <see cref="labelControl" />, <see cref="layoutContainer" />, <see cref="radioGroup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BottomItemsGroupControls.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bottomItems = mso14 + "bottomItems";

        /// <summary>
        /// Represents the mso14:box XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="box" />, <see cref="button" />, <see cref="buttonGroup" />, <see cref="checkBox" />, <see cref="comboBox" />, <see cref="control" />, <see cref="dropDown" />, <see cref="dynamicMenu" />, <see cref="editBox" />, <see cref="gallery" />, <see cref="labelControl" />, <see cref="menu" />, <see cref="splitButton" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.boxStyle" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Box.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName box = mso14 + "box";

        /// <summary>
        /// Represents the mso14:button XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="backstage" />, <see cref="bottomItems" />, <see cref="box" />, <see cref="buttonGroup" />, <see cref="contextMenu" />, <see cref="dialogBoxLauncher" />, <see cref="documentControls" />, <see cref="dropDown" />, <see cref="gallery" />, <see cref="group" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="menu" />, <see cref="menuGroup" />, <see cref="primaryItem" />, <see cref="sharedControls" />, <see cref="splitButton" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.expand" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.isDefinitive" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageFastCommandButton, BackstageGroupButton, BackstageMenuButton, BackstageRegularButton, Button, ButtonRegular, VisibleButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName button = mso14 + "button";

        /// <summary>
        /// Represents the mso14:buttonGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="control" />, <see cref="dynamicMenu" />, <see cref="gallery" />, <see cref="menu" />, <see cref="separator" />, <see cref="splitButton" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ButtonGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName buttonGroup = mso14 + "buttonGroup";

        /// <summary>
        /// Represents the mso14:category XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="taskFormGroup" />, <see cref="taskGroup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="task" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskFormGroupCategory, TaskGroupCategory.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName category = mso14 + "category";

        /// <summary>
        /// Represents the mso14:checkBox XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottomItems" />, <see cref="box" />, <see cref="contextMenu" />, <see cref="group" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="menu" />, <see cref="menuGroup" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.expand" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getPressed" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageCheckBox, BackstageMenuCheckBox, CheckBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName checkBox = mso14 + "checkBox";

        /// <summary>
        /// Represents the mso14:comboBox XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottomItems" />, <see cref="box" />, <see cref="group" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="item" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignLabel" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.expand" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getItemCount" />, <see cref="NoNamespace.getItemID" />, <see cref="NoNamespace.getItemImage" />, <see cref="NoNamespace.getItemLabel" />, <see cref="NoNamespace.getItemScreentip" />, <see cref="NoNamespace.getItemSupertip" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getText" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.invalidateContentOnDrop" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.maxLength" />, <see cref="NoNamespace.onChange" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showItemImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.sizeString" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageComboBox, ComboBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName comboBox = mso14 + "comboBox";

        /// <summary>
        /// Represents the mso14:command XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="commands" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.onAction" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Command.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName command = mso14 + "command";

        /// <summary>
        /// Represents the mso14:commands XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customUI" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="command" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Commands.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commands = mso14 + "commands";

        /// <summary>
        /// Represents the mso14:contextMenu XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="contextMenus" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="checkBox" />, <see cref="control" />, <see cref="dynamicMenu" />, <see cref="gallery" />, <see cref="menu" />, <see cref="menuSeparator" />, <see cref="splitButton" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idMso" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContextMenu.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contextMenu = mso14 + "contextMenu";

        /// <summary>
        /// Represents the mso14:contextMenus XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customUI" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="contextMenu" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContextMenus.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contextMenus = mso14 + "contextMenus";

        /// <summary>
        /// Represents the mso14:contextualTabs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ribbon" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tabSet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContextualTabs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contextualTabs = mso14 + "contextualTabs";

        /// <summary>
        /// Represents the mso14:control XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="contextMenu" />, <see cref="documentControls" />, <see cref="group" />, <see cref="menu" />, <see cref="sharedControls" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ControlClone, ControlCloneQat, ControlCloneRegular.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName control = mso14 + "control";

        /// <summary>
        /// Represents the mso14:customUI XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="backstage" />, <see cref="commands" />, <see cref="contextMenus" />, <see cref="ribbon" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.loadImage" />, <see cref="NoNamespace.onLoad" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomUI.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customUI = mso14 + "customUI";

        /// <summary>
        /// Represents the mso14:dialogBoxLauncher XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DialogBoxLauncher.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dialogBoxLauncher = mso14 + "dialogBoxLauncher";

        /// <summary>
        /// Represents the mso14:documentControls XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="qat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="control" />, <see cref="separator" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentControlsQatItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName documentControls = mso14 + "documentControls";

        /// <summary>
        /// Represents the mso14:dropDown XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottomItems" />, <see cref="box" />, <see cref="group" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="item" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignLabel" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.expand" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getItemCount" />, <see cref="NoNamespace.getItemID" />, <see cref="NoNamespace.getItemImage" />, <see cref="NoNamespace.getItemLabel" />, <see cref="NoNamespace.getItemScreentip" />, <see cref="NoNamespace.getItemSupertip" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getSelectedItemID" />, <see cref="NoNamespace.getSelectedItemIndex" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showItemImage" />, <see cref="NoNamespace.showItemLabel" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.sizeString" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageDropDown, DropDownRegular.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropDown = mso14 + "dropDown";

        /// <summary>
        /// Represents the mso14:dynamicMenu XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="contextMenu" />, <see cref="group" />, <see cref="menu" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getContent" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.invalidateContentOnDrop" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DynamicMenu, DynamicMenuRegular.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dynamicMenu = mso14 + "dynamicMenu";

        /// <summary>
        /// Represents the mso14:editBox XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottomItems" />, <see cref="box" />, <see cref="group" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignLabel" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.expand" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getText" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.maxLength" />, <see cref="NoNamespace.onChange" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.sizeString" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageEditBox, EditBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName editBox = mso14 + "editBox";

        /// <summary>
        /// Represents the mso14:firstColumn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tab" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="group" />, <see cref="taskFormGroup" />, <see cref="taskGroup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageGroups.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstColumn = mso14 + "firstColumn";

        /// <summary>
        /// Represents the mso14:gallery XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="contextMenu" />, <see cref="group" />, <see cref="menu" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="item" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.columns" />, <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getItemCount" />, <see cref="NoNamespace.getItemHeight" />, <see cref="NoNamespace.getItemID" />, <see cref="NoNamespace.getItemImage" />, <see cref="NoNamespace.getItemLabel" />, <see cref="NoNamespace.getItemScreentip" />, <see cref="NoNamespace.getItemSupertip" />, <see cref="NoNamespace.getItemWidth" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getSelectedItemID" />, <see cref="NoNamespace.getSelectedItemIndex" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.invalidateContentOnDrop" />, <see cref="NoNamespace.itemHeight" />, <see cref="NoNamespace.itemWidth" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.rows" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showInRibbon" />, <see cref="NoNamespace.showItemImage" />, <see cref="NoNamespace.showItemLabel" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.sizeString" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Gallery, GalleryRegular.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gallery = mso14 + "gallery";

        /// <summary>
        /// Represents the mso14:group XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="firstColumn" />, <see cref="secondColumn" />, <see cref="tab" />, <see cref="task" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bottomItems" />, <see cref="box" />, <see cref="button" />, <see cref="buttonGroup" />, <see cref="checkBox" />, <see cref="comboBox" />, <see cref="control" />, <see cref="dialogBoxLauncher" />, <see cref="dropDown" />, <see cref="dynamicMenu" />, <see cref="editBox" />, <see cref="gallery" />, <see cref="labelControl" />, <see cref="menu" />, <see cref="primaryItem" />, <see cref="separator" />, <see cref="splitButton" />, <see cref="toggleButton" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoScale" />, <see cref="NoNamespace.centerVertically" />, <see cref="NoNamespace.getHelperText" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getStyle" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.helperText" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageGroup, Group.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName group = mso14 + "group";

        /// <summary>
        /// Represents the mso14:groupBox XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottomItems" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="checkBox" />, <see cref="comboBox" />, <see cref="dropDown" />, <see cref="editBox" />, <see cref="groupBox" />, <see cref="hyperlink" />, <see cref="imageControl" />, <see cref="labelControl" />, <see cref="layoutContainer" />, <see cref="radioGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.expand" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.tag" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName groupBox = mso14 + "groupBox";

        /// <summary>
        /// Represents the mso14:hyperlink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottomItems" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignLabel" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.expand" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getTarget" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Hyperlink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hyperlink = mso14 + "hyperlink";

        /// <summary>
        /// Represents the mso14:imageControl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottomItems" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.altText" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getAltText" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ImageControl.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName imageControl = mso14 + "imageControl";

        /// <summary>
        /// Represents the mso14:item XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="comboBox" />, <see cref="dropDown" />, <see cref="gallery" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.supertip" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Item, ItemBackstageItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName item = mso14 + "item";

        /// <summary>
        /// Represents the mso14:labelControl XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottomItems" />, <see cref="box" />, <see cref="group" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignLabel" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.expand" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.noWrap" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageLabelControl, LabelControl.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName labelControl = mso14 + "labelControl";

        /// <summary>
        /// Represents the mso14:layoutContainer XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottomItems" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="checkBox" />, <see cref="comboBox" />, <see cref="dropDown" />, <see cref="editBox" />, <see cref="groupBox" />, <see cref="hyperlink" />, <see cref="imageControl" />, <see cref="labelControl" />, <see cref="layoutContainer" />, <see cref="radioGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.align" />, <see cref="NoNamespace.expand" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.layoutChildren" />, <see cref="NoNamespace.tag" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LayoutContainer.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layoutContainer = mso14 + "layoutContainer";

        /// <summary>
        /// Represents the mso14:menu XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="contextMenu" />, <see cref="group" />, <see cref="menu" />, <see cref="menuGroup" />, <see cref="primaryItem" />, <see cref="splitButton" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="checkBox" />, <see cref="control" />, <see cref="dynamicMenu" />, <see cref="gallery" />, <see cref="menu" />, <see cref="menuGroup" />, <see cref="menuSeparator" />, <see cref="splitButton" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.itemSize" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstagePrimaryMenu, BackstageSubMenu, Menu, MenuRegular.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName menu = mso14 + "menu";

        /// <summary>
        /// Represents the mso14:menuGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="menu" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="checkBox" />, <see cref="menu" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.itemSize" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.tag" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageMenuGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName menuGroup = mso14 + "menuGroup";

        /// <summary>
        /// Represents the mso14:menuSeparator XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="contextMenu" />, <see cref="menu" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getTitle" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MenuSeparator, MenuSeparatorNoTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName menuSeparator = mso14 + "menuSeparator";

        /// <summary>
        /// Represents the mso14:primaryItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="menu" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrimaryItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName primaryItem = mso14 + "primaryItem";

        /// <summary>
        /// Represents the mso14:qat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ribbon" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="documentControls" />, <see cref="sharedControls" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: QuickAccessToolbar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName qat = mso14 + "qat";

        /// <summary>
        /// Represents the mso14:radioButton XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="radioGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.label" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RadioButtonBackstageItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName radioButton = mso14 + "radioButton";

        /// <summary>
        /// Represents the mso14:radioGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottomItems" />, <see cref="groupBox" />, <see cref="layoutContainer" />, <see cref="topItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="radioButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignLabel" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.expand" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getItemCount" />, <see cref="NoNamespace.getItemID" />, <see cref="NoNamespace.getItemLabel" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getSelectedItemIndex" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RadioGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName radioGroup = mso14 + "radioGroup";

        /// <summary>
        /// Represents the mso14:ribbon XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customUI" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="contextualTabs" />, <see cref="qat" />, <see cref="tabs" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.startFromScratch" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Ribbon.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ribbon = mso14 + "ribbon";

        /// <summary>
        /// Represents the mso14:secondColumn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tab" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="group" />, <see cref="taskGroup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SimpleGroups.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName secondColumn = mso14 + "secondColumn";

        /// <summary>
        /// Represents the mso14:separator XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="buttonGroup" />, <see cref="documentControls" />, <see cref="group" />, <see cref="sharedControls" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Separator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName separator = mso14 + "separator";

        /// <summary>
        /// Represents the mso14:sharedControls XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="qat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="control" />, <see cref="separator" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SharedControlsQatItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sharedControls = mso14 + "sharedControls";

        /// <summary>
        /// Represents the mso14:splitButton XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="contextMenu" />, <see cref="group" />, <see cref="menu" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="menu" />, <see cref="toggleButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SplitButton, SplitButtonRegular.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName splitButton = mso14 + "splitButton";

        /// <summary>
        /// Represents the mso14:tab XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="backstage" />, <see cref="tabs" />, <see cref="tabSet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="firstColumn" />, <see cref="group" />, <see cref="secondColumn" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.columnWidthPercent" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.firstColumnMaxWidth" />, <see cref="NoNamespace.firstColumnMinWidth" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getTitle" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.secondColumnMaxWidth" />, <see cref="NoNamespace.secondColumnMinWidth" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.title" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageTab, Tab.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tab = mso14 + "tab";

        /// <summary>
        /// Represents the mso14:tabs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ribbon" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tab" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tabs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tabs = mso14 + "tabs";

        /// <summary>
        /// Represents the mso14:tabSet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="contextualTabs" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tab" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TabSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tabSet = mso14 + "tabSet";

        /// <summary>
        /// Represents the mso14:task XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="category" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="group" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.isDefinitive" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskFormGroupTask, TaskGroupTask.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName task = mso14 + "task";

        /// <summary>
        /// Represents the mso14:taskFormGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="firstColumn" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="category" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allowedTaskSizes" />, <see cref="NoNamespace.getHelperText" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.helperText" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskFormGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName taskFormGroup = mso14 + "taskFormGroup";

        /// <summary>
        /// Represents the mso14:taskGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="firstColumn" />, <see cref="secondColumn" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="category" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allowedTaskSizes" />, <see cref="NoNamespace.getHelperText" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.helperText" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TaskGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName taskGroup = mso14 + "taskGroup";

        /// <summary>
        /// Represents the mso14:toggleButton XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />, <see cref="buttonGroup" />, <see cref="contextMenu" />, <see cref="group" />, <see cref="menu" />, <see cref="menuGroup" />, <see cref="splitButton" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.getDescription" />, <see cref="NoNamespace.getEnabled" />, <see cref="NoNamespace.getImage" />, <see cref="NoNamespace.getKeytip" />, <see cref="NoNamespace.getLabel" />, <see cref="NoNamespace.getPressed" />, <see cref="NoNamespace.getScreentip" />, <see cref="NoNamespace.getShowImage" />, <see cref="NoNamespace.getShowLabel" />, <see cref="NoNamespace.getSize" />, <see cref="NoNamespace.getSupertip" />, <see cref="NoNamespace.getVisible" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.idMso" />, <see cref="NoNamespace.idQ" />, <see cref="NoNamespace.image" />, <see cref="NoNamespace.imageMso" />, <see cref="NoNamespace.insertAfterMso" />, <see cref="NoNamespace.insertAfterQ" />, <see cref="NoNamespace.insertBeforeMso" />, <see cref="NoNamespace.insertBeforeQ" />, <see cref="NoNamespace.keytip" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.onAction" />, <see cref="NoNamespace.screentip" />, <see cref="NoNamespace.showImage" />, <see cref="NoNamespace.showLabel" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.supertip" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.visible" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackstageMenuToggleButton, ToggleButton, ToggleButtonRegular, VisibleToggleButton.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName toggleButton = mso14 + "toggleButton";

        /// <summary>
        /// Represents the mso14:topItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="button" />, <see cref="checkBox" />, <see cref="comboBox" />, <see cref="dropDown" />, <see cref="editBox" />, <see cref="groupBox" />, <see cref="hyperlink" />, <see cref="imageControl" />, <see cref="labelControl" />, <see cref="layoutContainer" />, <see cref="radioGroup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopItemsGroupControls.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName topItems = mso14 + "topItems";
    }
}
