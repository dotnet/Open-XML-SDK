// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
/// <summary>
/// <para>Defines the UnsizedControlClone Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:control.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "control")]
public partial class UnsizedControlClone : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12644;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 0)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 1)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 2)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 3)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 4)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 5)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 6)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 7)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 8)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 9)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 10)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 11)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 12)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 13)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 14)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 15)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 16)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 17)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 18)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 19)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 20)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 21)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 22)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 23)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 24)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 25)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the UnsizedControlClone class.
    /// </summary>
    public UnsizedControlClone():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedControlClone>(deep);

}
/// <summary>
/// <para>Defines the UnsizedButton Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:button.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "button")]
public partial class UnsizedButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12645;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 0)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 1)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 2)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 3)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 4)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 5)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 6)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 7)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 8)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 9)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 10)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 11)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 12)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 13)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 14)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 15)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 16)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 17)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 18)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 19)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 20)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 21)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 22)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 23)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 24)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 25)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 26)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 27)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 28)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 29)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the UnsizedButton class.
    /// </summary>
    public UnsizedButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedButton>(deep);

}
/// <summary>
/// <para>Defines the CheckBox Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:checkBox.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "checkBox")]
public partial class CheckBox : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12646;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed", 0)]
    public StringValue GetPressed { get; set; }
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 1)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 2)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 3)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 4)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 5)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 6)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 7)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 8)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 9)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 10)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 11)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 12)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 13)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 14)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 15)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 16)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 17)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 18)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 19)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 20)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 21)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 22)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 23)]
    public StringValue GetKeytip { get; set; }

    /// <summary>
    /// Initializes a new instance of the CheckBox class.
    /// </summary>
    public CheckBox():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CheckBox>(deep);

}
/// <summary>
/// <para>Defines the UnsizedGallery Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:gallery.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso:item></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Item))]
    [ChildElementInfo(typeof(UnsizedButton))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "gallery")]
public partial class UnsizedGallery : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12647;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 0)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 1)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop", 2)]
    public BooleanValue InvalidateContentOnDrop { get; set; }
    /// <summary>
    /// <para> columns.</para>
    /// <para>Represents the following attribute in the schema: columns </para>
    /// </summary>
    [SchemaAttr(0, "columns", 3)]
    public IntegerValue Columns { get; set; }
    /// <summary>
    /// <para> rows.</para>
    /// <para>Represents the following attribute in the schema: rows </para>
    /// </summary>
    [SchemaAttr(0, "rows", 4)]
    public IntegerValue Rows { get; set; }
    /// <summary>
    /// <para> itemWidth.</para>
    /// <para>Represents the following attribute in the schema: itemWidth </para>
    /// </summary>
    [SchemaAttr(0, "itemWidth", 5)]
    public IntegerValue ItemWidth { get; set; }
    /// <summary>
    /// <para> itemHeight.</para>
    /// <para>Represents the following attribute in the schema: itemHeight </para>
    /// </summary>
    [SchemaAttr(0, "itemHeight", 6)]
    public IntegerValue ItemHeight { get; set; }
    /// <summary>
    /// <para> getItemWidth.</para>
    /// <para>Represents the following attribute in the schema: getItemWidth </para>
    /// </summary>
    [SchemaAttr(0, "getItemWidth", 7)]
    public StringValue GetItemWidth { get; set; }
    /// <summary>
    /// <para> getItemHeight.</para>
    /// <para>Represents the following attribute in the schema: getItemHeight </para>
    /// </summary>
    [SchemaAttr(0, "getItemHeight", 8)]
    public StringValue GetItemHeight { get; set; }
    /// <summary>
    /// <para> showItemLabel.</para>
    /// <para>Represents the following attribute in the schema: showItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "showItemLabel", 9)]
    public BooleanValue ShowItemLabel { get; set; }
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 10)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 11)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 12)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 13)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 14)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 15)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage", 16)]
    public BooleanValue ShowItemImage { get; set; }
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount", 17)]
    public StringValue GetItemCount { get; set; }
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel", 18)]
    public StringValue GetItemLabel { get; set; }
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip", 19)]
    public StringValue GetItemScreentip { get; set; }
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip", 20)]
    public StringValue GetItemSupertip { get; set; }
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage", 21)]
    public StringValue GetItemImage { get; set; }
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID", 22)]
    public StringValue GetItemID { get; set; }
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString", 23)]
    public StringValue SizeString { get; set; }
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID", 24)]
    public StringValue GetSelectedItemID { get; set; }
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex", 25)]
    public StringValue GetSelectedItemIndex { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 26)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 27)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 28)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 29)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 30)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 31)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 32)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 33)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 34)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 35)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 36)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 37)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 38)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 39)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 40)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 41)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 42)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 43)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 44)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 45)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 46)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 47)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the UnsizedGallery class.
    /// </summary>
    public UnsizedGallery():base(){}
    
        /// <summary>
    ///Initializes a new instance of the UnsizedGallery class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedGallery(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedGallery class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedGallery(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedGallery class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public UnsizedGallery(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedGallery>(deep);

}
/// <summary>
/// <para>Defines the UnsizedToggleButton Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:toggleButton.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "toggleButton")]
public partial class UnsizedToggleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12648;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed", 0)]
    public StringValue GetPressed { get; set; }
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 1)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 2)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 3)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 4)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 5)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 6)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 7)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 8)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 9)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 10)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 11)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 12)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 13)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 14)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 15)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 16)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 17)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 18)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 19)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 20)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 21)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 22)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 23)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 24)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 25)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 26)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 27)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 28)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 29)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 30)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the UnsizedToggleButton class.
    /// </summary>
    public UnsizedToggleButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedToggleButton>(deep);

}
/// <summary>
/// <para>Defines the MenuSeparator Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:menuSeparator.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "menuSeparator")]
public partial class MenuSeparator : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12649;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 1)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 2)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 3)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 4)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 5)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title", 6)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle", 7)]
    public StringValue GetTitle { get; set; }

    /// <summary>
    /// Initializes a new instance of the MenuSeparator class.
    /// </summary>
    public MenuSeparator():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuSeparator>(deep);

}
/// <summary>
/// <para>Defines the UnsizedSplitButton Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso:button></description></item>
///<item><description>VisibleToggleButton &lt;mso:toggleButton></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VisibleButton))]
    [ChildElementInfo(typeof(VisibleToggleButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "splitButton")]
public partial class UnsizedSplitButton : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12650;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 0)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 1)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 2)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 3)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 4)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 5)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 6)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 7)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 8)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 9)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 10)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 11)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 12)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 13)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 14)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 15)]
    public StringValue GetShowLabel { get; set; }

    /// <summary>
    /// Initializes a new instance of the UnsizedSplitButton class.
    /// </summary>
    public UnsizedSplitButton():base(){}
    
        /// <summary>
    ///Initializes a new instance of the UnsizedSplitButton class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedSplitButton(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedSplitButton class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedSplitButton(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedSplitButton class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public UnsizedSplitButton(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedSplitButton>(deep);

}
/// <summary>
/// <para>Defines the UnsizedMenu Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
///<item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "menu")]
public partial class UnsizedMenu : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12651;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize", 0)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 1)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 2)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 3)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 4)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 5)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 6)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 7)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 8)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 9)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 10)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 11)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 12)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 13)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 14)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 15)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 16)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 17)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 18)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 19)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 20)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 21)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 22)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 23)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 24)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 25)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 26)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 27)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 28)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 29)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the UnsizedMenu class.
    /// </summary>
    public UnsizedMenu():base(){}
    
        /// <summary>
    ///Initializes a new instance of the UnsizedMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedMenu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedMenu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedMenu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public UnsizedMenu(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedMenu>(deep);

}
/// <summary>
/// <para>Defines the UnsizedDynamicMenu Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:dynamicMenu.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "dynamicMenu")]
public partial class UnsizedDynamicMenu : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12652;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 0)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 1)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 2)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 3)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 4)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 5)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> getContent.</para>
    /// <para>Represents the following attribute in the schema: getContent </para>
    /// </summary>
    [SchemaAttr(0, "getContent", 6)]
    public StringValue GetContent { get; set; }
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop", 7)]
    public BooleanValue InvalidateContentOnDrop { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 8)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 9)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 10)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 11)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 12)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 13)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 14)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 15)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 16)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 17)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 18)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 19)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 20)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 21)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 22)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 23)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 24)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 25)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 26)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 27)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 28)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 29)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 30)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the UnsizedDynamicMenu class.
    /// </summary>
    public UnsizedDynamicMenu():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedDynamicMenu>(deep);

}
/// <summary>
/// <para>Defines the SplitButtonWithTitle Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso:button></description></item>
///<item><description>VisibleToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuWithTitle &lt;mso:menu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VisibleButton))]
    [ChildElementInfo(typeof(VisibleToggleButton))]
    [ChildElementInfo(typeof(MenuWithTitle))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "splitButton")]
public partial class SplitButtonWithTitle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12653;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 0)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 1)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 2)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 3)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 4)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 5)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 6)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 7)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 8)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 9)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 10)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 11)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 12)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 13)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 14)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 15)]
    public StringValue GetShowLabel { get; set; }

    /// <summary>
    /// Initializes a new instance of the SplitButtonWithTitle class.
    /// </summary>
    public SplitButtonWithTitle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SplitButtonWithTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButtonWithTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButtonWithTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButtonWithTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButtonWithTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SplitButtonWithTitle(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButtonWithTitle>(deep);

}
/// <summary>
/// <para>Defines the MenuWithTitle Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
///<item><description>SplitButtonWithTitle &lt;mso:splitButton></description></item>
///<item><description>MenuWithTitle &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(SplitButtonWithTitle))]
    [ChildElementInfo(typeof(MenuWithTitle))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "menu")]
public partial class MenuWithTitle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12654;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 1)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 2)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 3)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize", 4)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize { get; set; }
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title", 5)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle", 6)]
    public StringValue GetTitle { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 7)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 8)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 9)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 10)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 11)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 12)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 13)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 14)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 15)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 16)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 17)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 18)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 19)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 20)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 21)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 22)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 23)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 24)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 25)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 26)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 27)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 28)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 29)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the MenuWithTitle class.
    /// </summary>
    public MenuWithTitle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MenuWithTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuWithTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuWithTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuWithTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuWithTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MenuWithTitle(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuWithTitle>(deep);

}
/// <summary>
/// <para>Defines the ControlClone Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:control.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "control")]
public partial class ControlClone : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12655;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size", 0)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize", 1)]
    public StringValue GetSize { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 2)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 3)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 4)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 5)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 6)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 7)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 8)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 9)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 10)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 11)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 12)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 13)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 14)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 15)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 16)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 17)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 18)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 19)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 20)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 21)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 22)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 23)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 24)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 25)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 26)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 27)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 28)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 29)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the ControlClone class.
    /// </summary>
    public ControlClone():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlClone>(deep);

}
/// <summary>
/// <para>Defines the TextLabel Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:labelControl.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "labelControl")]
public partial class TextLabel : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12656;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 1)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 2)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 3)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 4)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 5)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 6)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 7)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 8)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 9)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 10)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 11)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 12)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 13)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 14)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 15)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 16)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 17)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 18)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 19)]
    public StringValue GetShowLabel { get; set; }

    /// <summary>
    /// Initializes a new instance of the TextLabel class.
    /// </summary>
    public TextLabel():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextLabel>(deep);

}
/// <summary>
/// <para>Defines the Button Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:button.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "button")]
public partial class Button : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12657;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size", 0)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize", 1)]
    public StringValue GetSize { get; set; }
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 2)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 3)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 4)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 5)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 6)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 7)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 8)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 9)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 10)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 11)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 12)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 13)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 14)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 15)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 16)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 17)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 18)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 19)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 20)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 21)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 22)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 23)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 24)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 25)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 26)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 27)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 28)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 29)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 30)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 31)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the Button class.
    /// </summary>
    public Button():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Button>(deep);

}
/// <summary>
/// <para>Defines the ToggleButton Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:toggleButton.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "toggleButton")]
public partial class ToggleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12658;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size", 0)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize", 1)]
    public StringValue GetSize { get; set; }
    /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed", 2)]
    public StringValue GetPressed { get; set; }
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 3)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 4)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 5)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 6)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 7)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 8)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 9)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 10)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 11)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 12)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 13)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 14)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 15)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 16)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 17)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 18)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 19)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 20)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 21)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 22)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 23)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 24)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 25)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 26)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 27)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 28)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 29)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 30)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 31)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 32)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the ToggleButton class.
    /// </summary>
    public ToggleButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToggleButton>(deep);

}
/// <summary>
/// <para>Defines the EditBox Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:editBox.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "editBox")]
public partial class EditBox : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12659;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 0)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 1)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 2)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 3)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 4)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> maxLength.</para>
    /// <para>Represents the following attribute in the schema: maxLength </para>
    /// </summary>
    [SchemaAttr(0, "maxLength", 5)]
    public IntegerValue MaxLength { get; set; }
    /// <summary>
    /// <para> getText.</para>
    /// <para>Represents the following attribute in the schema: getText </para>
    /// </summary>
    [SchemaAttr(0, "getText", 6)]
    public StringValue GetText { get; set; }
    /// <summary>
    /// <para> onChange.</para>
    /// <para>Represents the following attribute in the schema: onChange </para>
    /// </summary>
    [SchemaAttr(0, "onChange", 7)]
    public StringValue OnChange { get; set; }
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString", 8)]
    public StringValue SizeString { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 9)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 10)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 11)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 12)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 13)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 14)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 15)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 16)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 17)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 18)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 19)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 20)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 21)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 22)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 23)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 24)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 25)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 26)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 27)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 28)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 29)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 30)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the EditBox class.
    /// </summary>
    public EditBox():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EditBox>(deep);

}
/// <summary>
/// <para>Defines the ComboBox Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:comboBox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso:item></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Item))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "comboBox")]
public partial class ComboBox : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12660;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage", 0)]
    public BooleanValue ShowItemImage { get; set; }
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount", 1)]
    public StringValue GetItemCount { get; set; }
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel", 2)]
    public StringValue GetItemLabel { get; set; }
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip", 3)]
    public StringValue GetItemScreentip { get; set; }
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip", 4)]
    public StringValue GetItemSupertip { get; set; }
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage", 5)]
    public StringValue GetItemImage { get; set; }
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID", 6)]
    public StringValue GetItemID { get; set; }
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString", 7)]
    public StringValue SizeString { get; set; }
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop", 8)]
    public BooleanValue InvalidateContentOnDrop { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 9)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 10)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 11)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 12)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 13)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> maxLength.</para>
    /// <para>Represents the following attribute in the schema: maxLength </para>
    /// </summary>
    [SchemaAttr(0, "maxLength", 14)]
    public IntegerValue MaxLength { get; set; }
    /// <summary>
    /// <para> getText.</para>
    /// <para>Represents the following attribute in the schema: getText </para>
    /// </summary>
    [SchemaAttr(0, "getText", 15)]
    public StringValue GetText { get; set; }
    /// <summary>
    /// <para> onChange.</para>
    /// <para>Represents the following attribute in the schema: onChange </para>
    /// </summary>
    [SchemaAttr(0, "onChange", 16)]
    public StringValue OnChange { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 17)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 18)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 19)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 20)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 21)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 22)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 23)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 24)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 25)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 26)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 27)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 28)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 29)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 30)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 31)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 32)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 33)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 34)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 35)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 36)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 37)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 38)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the ComboBox class.
    /// </summary>
    public ComboBox():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ComboBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ComboBox(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ComboBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ComboBox(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ComboBox class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ComboBox(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ComboBox>(deep);

}
/// <summary>
/// <para>Defines the DropDown Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:dropDown.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso:item></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Item))]
    [ChildElementInfo(typeof(UnsizedButton))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "dropDown")]
public partial class DropDown : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12661;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 0)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 1)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 2)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 3)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 4)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 5)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage", 6)]
    public BooleanValue ShowItemImage { get; set; }
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount", 7)]
    public StringValue GetItemCount { get; set; }
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel", 8)]
    public StringValue GetItemLabel { get; set; }
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip", 9)]
    public StringValue GetItemScreentip { get; set; }
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip", 10)]
    public StringValue GetItemSupertip { get; set; }
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage", 11)]
    public StringValue GetItemImage { get; set; }
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID", 12)]
    public StringValue GetItemID { get; set; }
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString", 13)]
    public StringValue SizeString { get; set; }
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID", 14)]
    public StringValue GetSelectedItemID { get; set; }
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex", 15)]
    public StringValue GetSelectedItemIndex { get; set; }
    /// <summary>
    /// <para> showItemLabel.</para>
    /// <para>Represents the following attribute in the schema: showItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "showItemLabel", 16)]
    public BooleanValue ShowItemLabel { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 17)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 18)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 19)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 20)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 21)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 22)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 23)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 24)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 25)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 26)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 27)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 28)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 29)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 30)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 31)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 32)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 33)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 34)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 35)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 36)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 37)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 38)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the DropDown class.
    /// </summary>
    public DropDown():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DropDown class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropDown(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DropDown class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropDown(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DropDown class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DropDown(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropDown>(deep);

}
/// <summary>
/// <para>Defines the Gallery Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:gallery.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso:item></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Item))]
    [ChildElementInfo(typeof(UnsizedButton))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "gallery")]
public partial class Gallery : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12662;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size", 0)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize", 1)]
    public StringValue GetSize { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 2)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 3)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop", 4)]
    public BooleanValue InvalidateContentOnDrop { get; set; }
    /// <summary>
    /// <para> columns.</para>
    /// <para>Represents the following attribute in the schema: columns </para>
    /// </summary>
    [SchemaAttr(0, "columns", 5)]
    public IntegerValue Columns { get; set; }
    /// <summary>
    /// <para> rows.</para>
    /// <para>Represents the following attribute in the schema: rows </para>
    /// </summary>
    [SchemaAttr(0, "rows", 6)]
    public IntegerValue Rows { get; set; }
    /// <summary>
    /// <para> itemWidth.</para>
    /// <para>Represents the following attribute in the schema: itemWidth </para>
    /// </summary>
    [SchemaAttr(0, "itemWidth", 7)]
    public IntegerValue ItemWidth { get; set; }
    /// <summary>
    /// <para> itemHeight.</para>
    /// <para>Represents the following attribute in the schema: itemHeight </para>
    /// </summary>
    [SchemaAttr(0, "itemHeight", 8)]
    public IntegerValue ItemHeight { get; set; }
    /// <summary>
    /// <para> getItemWidth.</para>
    /// <para>Represents the following attribute in the schema: getItemWidth </para>
    /// </summary>
    [SchemaAttr(0, "getItemWidth", 9)]
    public StringValue GetItemWidth { get; set; }
    /// <summary>
    /// <para> getItemHeight.</para>
    /// <para>Represents the following attribute in the schema: getItemHeight </para>
    /// </summary>
    [SchemaAttr(0, "getItemHeight", 10)]
    public StringValue GetItemHeight { get; set; }
    /// <summary>
    /// <para> showItemLabel.</para>
    /// <para>Represents the following attribute in the schema: showItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "showItemLabel", 11)]
    public BooleanValue ShowItemLabel { get; set; }
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 12)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 13)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 14)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 15)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 16)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 17)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage", 18)]
    public BooleanValue ShowItemImage { get; set; }
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount", 19)]
    public StringValue GetItemCount { get; set; }
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel", 20)]
    public StringValue GetItemLabel { get; set; }
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip", 21)]
    public StringValue GetItemScreentip { get; set; }
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip", 22)]
    public StringValue GetItemSupertip { get; set; }
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage", 23)]
    public StringValue GetItemImage { get; set; }
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID", 24)]
    public StringValue GetItemID { get; set; }
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString", 25)]
    public StringValue SizeString { get; set; }
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID", 26)]
    public StringValue GetSelectedItemID { get; set; }
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex", 27)]
    public StringValue GetSelectedItemIndex { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 28)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 29)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 30)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 31)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 32)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 33)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 34)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 35)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 36)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 37)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 38)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 39)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 40)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 41)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 42)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 43)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 44)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 45)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 46)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 47)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 48)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 49)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the Gallery class.
    /// </summary>
    public Gallery():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Gallery class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Gallery(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Gallery class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Gallery(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Gallery class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Gallery(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Gallery>(deep);

}
/// <summary>
/// <para>Defines the Menu Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
///<item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "menu")]
public partial class Menu : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12663;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size", 0)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize", 1)]
    public StringValue GetSize { get; set; }
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize", 2)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 3)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 4)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 5)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 6)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 7)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 8)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 9)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 10)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 11)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 12)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 13)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 14)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 15)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 16)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 17)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 18)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 19)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 20)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 21)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 22)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 23)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 24)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 25)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 26)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 27)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 28)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 29)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 30)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 31)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the Menu class.
    /// </summary>
    public Menu():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Menu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Menu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Menu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Menu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Menu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Menu(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Menu>(deep);

}
/// <summary>
/// <para>Defines the DynamicMenu Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:dynamicMenu.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "dynamicMenu")]
public partial class DynamicMenu : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12664;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size", 0)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize", 1)]
    public StringValue GetSize { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 2)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 3)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 4)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 5)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 6)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 7)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> getContent.</para>
    /// <para>Represents the following attribute in the schema: getContent </para>
    /// </summary>
    [SchemaAttr(0, "getContent", 8)]
    public StringValue GetContent { get; set; }
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop", 9)]
    public BooleanValue InvalidateContentOnDrop { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 10)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 11)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 12)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 13)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 14)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 15)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 16)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 17)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 18)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 19)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 20)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 21)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 22)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 23)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 24)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 25)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 26)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 27)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 28)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 29)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 30)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 31)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 32)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the DynamicMenu class.
    /// </summary>
    public DynamicMenu():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DynamicMenu>(deep);

}
/// <summary>
/// <para>Defines the SplitButton Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso:button></description></item>
///<item><description>VisibleToggleButton &lt;mso:toggleButton></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VisibleButton))]
    [ChildElementInfo(typeof(VisibleToggleButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "splitButton")]
public partial class SplitButton : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12665;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size", 0)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize", 1)]
    public StringValue GetSize { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 2)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 3)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 4)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 5)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 6)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 7)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 8)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 9)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 10)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 11)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 12)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 13)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 14)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 15)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 16)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 17)]
    public StringValue GetShowLabel { get; set; }

    /// <summary>
    /// Initializes a new instance of the SplitButton class.
    /// </summary>
    public SplitButton():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SplitButton class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButton(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButton class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButton(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButton class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SplitButton(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButton>(deep);

}
/// <summary>
/// <para>Defines the Box Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:box.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlClone &lt;mso:control></description></item>
///<item><description>TextLabel &lt;mso:labelControl></description></item>
///<item><description>Button &lt;mso:button></description></item>
///<item><description>ToggleButton &lt;mso:toggleButton></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>EditBox &lt;mso:editBox></description></item>
///<item><description>ComboBox &lt;mso:comboBox></description></item>
///<item><description>DropDown &lt;mso:dropDown></description></item>
///<item><description>Gallery &lt;mso:gallery></description></item>
///<item><description>Menu &lt;mso:menu></description></item>
///<item><description>DynamicMenu &lt;mso:dynamicMenu></description></item>
///<item><description>SplitButton &lt;mso:splitButton></description></item>
///<item><description>Box &lt;mso:box></description></item>
///<item><description>ButtonGroup &lt;mso:buttonGroup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlClone))]
    [ChildElementInfo(typeof(TextLabel))]
    [ChildElementInfo(typeof(Button))]
    [ChildElementInfo(typeof(ToggleButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(EditBox))]
    [ChildElementInfo(typeof(ComboBox))]
    [ChildElementInfo(typeof(DropDown))]
    [ChildElementInfo(typeof(Gallery))]
    [ChildElementInfo(typeof(Menu))]
    [ChildElementInfo(typeof(DynamicMenu))]
    [ChildElementInfo(typeof(SplitButton))]
    [ChildElementInfo(typeof(Box))]
    [ChildElementInfo(typeof(ButtonGroup))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "box")]
public partial class Box : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12666;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 1)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 2)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 3)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 4)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 5)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 6)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 7)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> boxStyle.</para>
    /// <para>Represents the following attribute in the schema: boxStyle </para>
    /// </summary>
    [SchemaAttr(0, "boxStyle", 8)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues> BoxStyle { get; set; }

    /// <summary>
    /// Initializes a new instance of the Box class.
    /// </summary>
    public Box():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Box class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Box(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Box class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Box(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Box class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Box(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Box>(deep);

}
/// <summary>
/// <para>Defines the ButtonGroup Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:buttonGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
///<item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "buttonGroup")]
public partial class ButtonGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12667;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 1)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 2)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 3)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 4)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 5)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 6)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 7)]
    public StringValue InsertBeforeQ { get; set; }

    /// <summary>
    /// Initializes a new instance of the ButtonGroup class.
    /// </summary>
    public ButtonGroup():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ButtonGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ButtonGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ButtonGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ButtonGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ButtonGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ButtonGroup(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonGroup>(deep);

}
/// <summary>
/// <para>Defines the MenuRoot Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
///<item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "menu")]
public partial class MenuRoot : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12668;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title", 0)]
    public StringValue Title { get; set; }
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle", 1)]
    public StringValue GetTitle { get; set; }
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize", 2)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize { get; set; }

    /// <summary>
    /// Initializes a new instance of the MenuRoot class.
    /// </summary>
    public MenuRoot():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MenuRoot class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuRoot(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuRoot class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuRoot(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuRoot class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MenuRoot(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuRoot>(deep);

}
/// <summary>
/// <para>Defines the CustomUI Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:customUI.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RepurposedCommands &lt;mso:commands></description></item>
///<item><description>Ribbon &lt;mso:ribbon></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RepurposedCommands))]
    [ChildElementInfo(typeof(Ribbon))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "customUI")]
public partial class CustomUI : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12669;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> onLoad.</para>
    /// <para>Represents the following attribute in the schema: onLoad </para>
    /// </summary>
    [SchemaAttr(0, "onLoad", 0)]
    public StringValue OnLoad { get; set; }
    /// <summary>
    /// <para> loadImage.</para>
    /// <para>Represents the following attribute in the schema: loadImage </para>
    /// </summary>
    [SchemaAttr(0, "loadImage", 1)]
    public StringValue LoadImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the CustomUI class.
    /// </summary>
    public CustomUI():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CustomUI class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomUI(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomUI class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomUI(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomUI class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CustomUI(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "commands","ribbon" };
    private static readonly byte[] eleNamespaceIds = { 34,34 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> RepurposedCommands.</para>
    /// <para> Represents the following element tag in the schema: mso:commands </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public RepurposedCommands RepurposedCommands
    {
        get => GetElement<RepurposedCommands>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> Ribbon.</para>
    /// <para> Represents the following element tag in the schema: mso:ribbon </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public Ribbon Ribbon
    {
        get => GetElement<Ribbon>(1);
        set => SetElement(1, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomUI>(deep);

}
/// <summary>
/// <para>Defines the Item Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:item.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "item")]
public partial class Item : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12670;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 1)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 2)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 3)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 4)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 5)]
    public StringValue Supertip { get; set; }

    /// <summary>
    /// Initializes a new instance of the Item class.
    /// </summary>
    public Item():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Item>(deep);

}
/// <summary>
/// <para>Defines the VisibleButton Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:button.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "button")]
public partial class VisibleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12671;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 0)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 1)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 2)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 3)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 4)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 5)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 6)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 7)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 8)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 9)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 10)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 11)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 12)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 13)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 14)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 15)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 16)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 17)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 18)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 19)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 20)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 21)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 22)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 23)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 24)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 25)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 26)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 27)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the VisibleButton class.
    /// </summary>
    public VisibleButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VisibleButton>(deep);

}
/// <summary>
/// <para>Defines the VisibleToggleButton Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:toggleButton.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "toggleButton")]
public partial class VisibleToggleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12672;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed", 0)]
    public StringValue GetPressed { get; set; }
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 1)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 2)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 3)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 4)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 5)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 6)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 7)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 8)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 9)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 10)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 11)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 12)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 13)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 14)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 15)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 16)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 17)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 18)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 19)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 20)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 21)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 22)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 23)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 24)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 25)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 26)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 27)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 28)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the VisibleToggleButton class.
    /// </summary>
    public VisibleToggleButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VisibleToggleButton>(deep);

}
/// <summary>
/// <para>Defines the VerticalSeparator Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:separator.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "separator")]
public partial class VerticalSeparator : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12673;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 1)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 2)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 3)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 4)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 5)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 6)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 7)]
    public StringValue InsertBeforeQ { get; set; }

    /// <summary>
    /// Initializes a new instance of the VerticalSeparator class.
    /// </summary>
    public VerticalSeparator():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalSeparator>(deep);

}
/// <summary>
/// <para>Defines the DialogBoxLauncher Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:dialogBoxLauncher.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedButton &lt;mso:button></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(UnsizedButton))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "dialogBoxLauncher")]
public partial class DialogBoxLauncher : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12674;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the DialogBoxLauncher class.
    /// </summary>
    public DialogBoxLauncher():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DialogBoxLauncher class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DialogBoxLauncher(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DialogBoxLauncher class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DialogBoxLauncher(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DialogBoxLauncher class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DialogBoxLauncher(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "button" };
    private static readonly byte[] eleNamespaceIds = { 34 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> UnsizedButton.</para>
    /// <para> Represents the following element tag in the schema: mso:button </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public UnsizedButton UnsizedButton
    {
        get => GetElement<UnsizedButton>(0);
        set => SetElement(0, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DialogBoxLauncher>(deep);

}
/// <summary>
/// <para>Defines the Group Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:group.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlClone &lt;mso:control></description></item>
///<item><description>TextLabel &lt;mso:labelControl></description></item>
///<item><description>Button &lt;mso:button></description></item>
///<item><description>ToggleButton &lt;mso:toggleButton></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>EditBox &lt;mso:editBox></description></item>
///<item><description>ComboBox &lt;mso:comboBox></description></item>
///<item><description>DropDown &lt;mso:dropDown></description></item>
///<item><description>Gallery &lt;mso:gallery></description></item>
///<item><description>Menu &lt;mso:menu></description></item>
///<item><description>DynamicMenu &lt;mso:dynamicMenu></description></item>
///<item><description>SplitButton &lt;mso:splitButton></description></item>
///<item><description>Box &lt;mso:box></description></item>
///<item><description>ButtonGroup &lt;mso:buttonGroup></description></item>
///<item><description>VerticalSeparator &lt;mso:separator></description></item>
///<item><description>DialogBoxLauncher &lt;mso:dialogBoxLauncher></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlClone))]
    [ChildElementInfo(typeof(TextLabel))]
    [ChildElementInfo(typeof(Button))]
    [ChildElementInfo(typeof(ToggleButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(EditBox))]
    [ChildElementInfo(typeof(ComboBox))]
    [ChildElementInfo(typeof(DropDown))]
    [ChildElementInfo(typeof(Gallery))]
    [ChildElementInfo(typeof(Menu))]
    [ChildElementInfo(typeof(DynamicMenu))]
    [ChildElementInfo(typeof(SplitButton))]
    [ChildElementInfo(typeof(Box))]
    [ChildElementInfo(typeof(ButtonGroup))]
    [ChildElementInfo(typeof(VerticalSeparator))]
    [ChildElementInfo(typeof(DialogBoxLauncher))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "group")]
public partial class Group : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12675;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 1)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 2)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 3)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 4)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 5)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 6)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 7)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 8)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 9)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 10)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 11)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 12)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 13)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 14)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 15)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 16)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 17)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 18)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 19)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 20)]
    public StringValue GetKeytip { get; set; }

    /// <summary>
    /// Initializes a new instance of the Group class.
    /// </summary>
    public Group():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Group class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Group(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Group class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Group(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Group class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Group(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);

}
/// <summary>
/// <para>Defines the QuickAccessToolbarControlClone Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:control.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "control")]
public partial class QuickAccessToolbarControlClone : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12676;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 1)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 2)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description", 3)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription", 4)]
    public StringValue GetDescription { get; set; }
    /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size", 5)]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size { get; set; }
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize", 6)]
    public StringValue GetSize { get; set; }
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image", 7)]
    public StringValue Image { get; set; }
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso", 8)]
    public StringValue ImageMso { get; set; }
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage", 9)]
    public StringValue GetImage { get; set; }
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip", 10)]
    public StringValue Screentip { get; set; }
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip", 11)]
    public StringValue GetScreentip { get; set; }
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip", 12)]
    public StringValue Supertip { get; set; }
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip", 13)]
    public StringValue GetSupertip { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 14)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 15)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 16)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 17)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 18)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 19)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 20)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 21)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 22)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 23)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 24)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 25)]
    public StringValue GetKeytip { get; set; }
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel", 26)]
    public BooleanValue ShowLabel { get; set; }
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel", 27)]
    public StringValue GetShowLabel { get; set; }
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage", 28)]
    public BooleanValue ShowImage { get; set; }
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage", 29)]
    public StringValue GetShowImage { get; set; }

    /// <summary>
    /// Initializes a new instance of the QuickAccessToolbarControlClone class.
    /// </summary>
    public QuickAccessToolbarControlClone():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuickAccessToolbarControlClone>(deep);

}
/// <summary>
/// <para>Defines the SharedQatControls Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:sharedControls.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuickAccessToolbarControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>VerticalSeparator &lt;mso:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[SchemaAttr(34, "sharedControls")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SharedQatControls : QatItemsType
{
    internal const int ElementTypeIdConst = 12677;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the SharedQatControls class.
    /// </summary>
    public SharedQatControls():base(){}
        /// <summary>
    ///Initializes a new instance of the SharedQatControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedQatControls(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedQatControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedQatControls(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedQatControls class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SharedQatControls(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedQatControls>(deep);

}
/// <summary>
/// <para>Defines the DocumentSpecificQuickAccessToolbarControls Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:documentControls.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuickAccessToolbarControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>VerticalSeparator &lt;mso:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[SchemaAttr(34, "documentControls")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DocumentSpecificQuickAccessToolbarControls : QatItemsType
{
    internal const int ElementTypeIdConst = 12678;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class.
    /// </summary>
    public DocumentSpecificQuickAccessToolbarControls():base(){}
        /// <summary>
    ///Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocumentSpecificQuickAccessToolbarControls(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocumentSpecificQuickAccessToolbarControls(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DocumentSpecificQuickAccessToolbarControls(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentSpecificQuickAccessToolbarControls>(deep);

}
/// <summary>
/// Defines the QatItemsType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuickAccessToolbarControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>VerticalSeparator &lt;mso:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(QuickAccessToolbarControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(VerticalSeparator))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class QatItemsType : OpenXmlCompositeElement
{
        
    
    
    
    
    /// <summary>
    /// Initializes a new instance of the QatItemsType class.
    /// </summary>
    protected QatItemsType(){}
    
        /// <summary>
    ///Initializes a new instance of the QatItemsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected QatItemsType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the QatItemsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected QatItemsType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the QatItemsType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected QatItemsType(string outerXml)
        : base(outerXml)
    {
    }
    

    
}
/// <summary>
/// <para>Defines the Tab Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:tab.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Group &lt;mso:group></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Group))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "tab")]
public partial class Tab : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12679;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public StringValue Id { get; set; }
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ", 1)]
    public StringValue IdQ { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 2)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag", 3)]
    public StringValue Tag { get; set; }
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label", 4)]
    public StringValue Label { get; set; }
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel", 5)]
    public StringValue GetLabel { get; set; }
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso", 6)]
    public StringValue InsertAfterMso { get; set; }
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso", 7)]
    public StringValue InsertBeforeMso { get; set; }
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ", 8)]
    public StringValue InsertAfterQ { get; set; }
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ", 9)]
    public StringValue InsertBeforeQ { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 10)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 11)]
    public StringValue GetVisible { get; set; }
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip", 12)]
    public StringValue Keytip { get; set; }
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip", 13)]
    public StringValue GetKeytip { get; set; }

    /// <summary>
    /// Initializes a new instance of the Tab class.
    /// </summary>
    public Tab():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Tab class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Tab(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Tab class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Tab(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Tab class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Tab(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tab>(deep);

}
/// <summary>
/// <para>Defines the ContextualTabSet Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:tabSet.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Tab &lt;mso:tab></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Tab))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "tabSet")]
public partial class ContextualTabSet : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12680;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 0)]
    public StringValue IdMso { get; set; }
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible", 1)]
    public BooleanValue Visible { get; set; }
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible", 2)]
    public StringValue GetVisible { get; set; }

    /// <summary>
    /// Initializes a new instance of the ContextualTabSet class.
    /// </summary>
    public ContextualTabSet():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ContextualTabSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabSet(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabSet(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabSet class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextualTabSet(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualTabSet>(deep);

}
/// <summary>
/// <para>Defines the RepurposedCommand Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:command.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "command")]
public partial class RepurposedCommand : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12681;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction", 0)]
    public StringValue OnAction { get; set; }
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled", 1)]
    public BooleanValue Enabled { get; set; }
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled", 2)]
    public StringValue GetEnabled { get; set; }
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso", 3)]
    public StringValue IdMso { get; set; }

    /// <summary>
    /// Initializes a new instance of the RepurposedCommand class.
    /// </summary>
    public RepurposedCommand():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RepurposedCommand>(deep);

}
/// <summary>
/// <para>Defines the OfficeMenu Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:officeMenu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
///<item><description>SplitButtonWithTitle &lt;mso:splitButton></description></item>
///<item><description>MenuWithTitle &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(SplitButtonWithTitle))]
    [ChildElementInfo(typeof(MenuWithTitle))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "officeMenu")]
public partial class OfficeMenu : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12682;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the OfficeMenu class.
    /// </summary>
    public OfficeMenu():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OfficeMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeMenu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeMenu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeMenu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OfficeMenu(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeMenu>(deep);

}
/// <summary>
/// <para>Defines the QuickAccessToolbar Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:qat.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SharedQatControls &lt;mso:sharedControls></description></item>
///<item><description>DocumentSpecificQuickAccessToolbarControls &lt;mso:documentControls></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SharedQatControls))]
    [ChildElementInfo(typeof(DocumentSpecificQuickAccessToolbarControls))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "qat")]
public partial class QuickAccessToolbar : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12683;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the QuickAccessToolbar class.
    /// </summary>
    public QuickAccessToolbar():base(){}
    
        /// <summary>
    ///Initializes a new instance of the QuickAccessToolbar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public QuickAccessToolbar(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the QuickAccessToolbar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public QuickAccessToolbar(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the QuickAccessToolbar class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public QuickAccessToolbar(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "sharedControls","documentControls" };
    private static readonly byte[] eleNamespaceIds = { 34,34 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SharedQatControls.</para>
    /// <para> Represents the following element tag in the schema: mso:sharedControls </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public SharedQatControls SharedQatControls
    {
        get => GetElement<SharedQatControls>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> DocumentSpecificQuickAccessToolbarControls.</para>
    /// <para> Represents the following element tag in the schema: mso:documentControls </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public DocumentSpecificQuickAccessToolbarControls DocumentSpecificQuickAccessToolbarControls
    {
        get => GetElement<DocumentSpecificQuickAccessToolbarControls>(1);
        set => SetElement(1, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuickAccessToolbar>(deep);

}
/// <summary>
/// <para>Defines the Tabs Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:tabs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Tab &lt;mso:tab></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Tab))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "tabs")]
public partial class Tabs : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12684;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the Tabs class.
    /// </summary>
    public Tabs():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Tabs class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Tabs(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Tabs class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Tabs(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Tabs class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Tabs(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tabs>(deep);

}
/// <summary>
/// <para>Defines the ContextualTabSets Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:contextualTabs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ContextualTabSet &lt;mso:tabSet></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ContextualTabSet))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "contextualTabs")]
public partial class ContextualTabSets : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12685;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabSets class.
    /// </summary>
    public ContextualTabSets():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ContextualTabSets class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabSets(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabSets class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabSets(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabSets class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextualTabSets(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualTabSets>(deep);

}
/// <summary>
/// <para>Defines the RepurposedCommands Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:commands.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RepurposedCommand &lt;mso:command></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RepurposedCommand))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "commands")]
public partial class RepurposedCommands : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12686;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the RepurposedCommands class.
    /// </summary>
    public RepurposedCommands():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RepurposedCommands class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RepurposedCommands(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RepurposedCommands class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RepurposedCommands(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RepurposedCommands class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RepurposedCommands(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RepurposedCommands>(deep);

}
/// <summary>
/// <para>Defines the Ribbon Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:ribbon.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfficeMenu &lt;mso:officeMenu></description></item>
///<item><description>QuickAccessToolbar &lt;mso:qat></description></item>
///<item><description>Tabs &lt;mso:tabs></description></item>
///<item><description>ContextualTabSets &lt;mso:contextualTabs></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OfficeMenu))]
    [ChildElementInfo(typeof(QuickAccessToolbar))]
    [ChildElementInfo(typeof(Tabs))]
    [ChildElementInfo(typeof(ContextualTabSets))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(34, "ribbon")]
public partial class Ribbon : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12687;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> startFromScratch.</para>
    /// <para>Represents the following attribute in the schema: startFromScratch </para>
    /// </summary>
    [SchemaAttr(0, "startFromScratch", 0)]
    public BooleanValue StartFromScratch { get; set; }

    /// <summary>
    /// Initializes a new instance of the Ribbon class.
    /// </summary>
    public Ribbon():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Ribbon class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Ribbon(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Ribbon class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Ribbon(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Ribbon class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Ribbon(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "officeMenu","qat","tabs","contextualTabs" };
    private static readonly byte[] eleNamespaceIds = { 34,34,34,34 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneAll;
    
        /// <summary>
    /// <para> OfficeMenu.</para>
    /// <para> Represents the following element tag in the schema: mso:officeMenu </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public OfficeMenu OfficeMenu
    {
        get => GetElement<OfficeMenu>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> QuickAccessToolbar.</para>
    /// <para> Represents the following element tag in the schema: mso:qat </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public QuickAccessToolbar QuickAccessToolbar
    {
        get => GetElement<QuickAccessToolbar>(1);
        set => SetElement(1, value);
    }
    
    /// <summary>
    /// <para> Tabs.</para>
    /// <para> Represents the following element tag in the schema: mso:tabs </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public Tabs Tabs
    {
        get => GetElement<Tabs>(2);
        set => SetElement(2, value);
    }
    
    /// <summary>
    /// <para> ContextualTabSets.</para>
    /// <para> Represents the following element tag in the schema: mso:contextualTabs </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public ContextualTabSets ContextualTabSets
    {
        get => GetElement<ContextualTabSets>(3);
        set => SetElement(3, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ribbon>(deep);

}
/// <summary>
/// Defines the SizeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SizeValues
{  
	///<summary>
///normal.
///<para>When the item is serialized out as xml, its value is "normal".</para>
///</summary>
[EnumString("normal")]
Normal,
///<summary>
///large.
///<para>When the item is serialized out as xml, its value is "large".</para>
///</summary>
[EnumString("large")]
Large,
 
}
/// <summary>
/// Defines the ItemSizeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ItemSizeValues
{  
	///<summary>
///normal.
///<para>When the item is serialized out as xml, its value is "normal".</para>
///</summary>
[EnumString("normal")]
Normal,
///<summary>
///large.
///<para>When the item is serialized out as xml, its value is "large".</para>
///</summary>
[EnumString("large")]
Large,
 
}
/// <summary>
/// Defines the BoxStyleValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BoxStyleValues
{  
	///<summary>
///horizontal.
///<para>When the item is serialized out as xml, its value is "horizontal".</para>
///</summary>
[EnumString("horizontal")]
Horizontal,
///<summary>
///vertical.
///<para>When the item is serialized out as xml, its value is "vertical".</para>
///</summary>
[EnumString("vertical")]
Vertical,
 
}
}
 
 
