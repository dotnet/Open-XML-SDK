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
public partial class UnsizedControlClone : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12644;
    /// <inheritdoc/>
    public override string LocalName => "control";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    

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
public partial class UnsizedButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12645;
    /// <inheritdoc/>
    public override string LocalName => "button";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    

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
public partial class CheckBox : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12646;
    /// <inheritdoc/>
    public override string LocalName => "checkBox";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "getPressed"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    

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
public partial class UnsizedGallery : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12647;
    /// <inheritdoc/>
    public override string LocalName => "gallery";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<BooleanValue>(0, "invalidateContentOnDrop"),
		AttributeTag.Create<IntegerValue>(0, "columns"),
		AttributeTag.Create<IntegerValue>(0, "rows"),
		AttributeTag.Create<IntegerValue>(0, "itemWidth"),
		AttributeTag.Create<IntegerValue>(0, "itemHeight"),
		AttributeTag.Create<StringValue>(0, "getItemWidth"),
		AttributeTag.Create<StringValue>(0, "getItemHeight"),
		AttributeTag.Create<BooleanValue>(0, "showItemLabel"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<BooleanValue>(0, "showItemImage"),
		AttributeTag.Create<StringValue>(0, "getItemCount"),
		AttributeTag.Create<StringValue>(0, "getItemLabel"),
		AttributeTag.Create<StringValue>(0, "getItemScreentip"),
		AttributeTag.Create<StringValue>(0, "getItemSupertip"),
		AttributeTag.Create<StringValue>(0, "getItemImage"),
		AttributeTag.Create<StringValue>(0, "getItemID"),
		AttributeTag.Create<StringValue>(0, "sizeString"),
		AttributeTag.Create<StringValue>(0, "getSelectedItemID"),
		AttributeTag.Create<StringValue>(0, "getSelectedItemIndex"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop")]
    public BooleanValue InvalidateContentOnDrop
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> columns.</para>
    /// <para>Represents the following attribute in the schema: columns </para>
    /// </summary>
    [SchemaAttr(0, "columns")]
    public IntegerValue Columns
    {
        get { return (IntegerValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> rows.</para>
    /// <para>Represents the following attribute in the schema: rows </para>
    /// </summary>
    [SchemaAttr(0, "rows")]
    public IntegerValue Rows
    {
        get { return (IntegerValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> itemWidth.</para>
    /// <para>Represents the following attribute in the schema: itemWidth </para>
    /// </summary>
    [SchemaAttr(0, "itemWidth")]
    public IntegerValue ItemWidth
    {
        get { return (IntegerValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> itemHeight.</para>
    /// <para>Represents the following attribute in the schema: itemHeight </para>
    /// </summary>
    [SchemaAttr(0, "itemHeight")]
    public IntegerValue ItemHeight
    {
        get { return (IntegerValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemWidth.</para>
    /// <para>Represents the following attribute in the schema: getItemWidth </para>
    /// </summary>
    [SchemaAttr(0, "getItemWidth")]
    public StringValue GetItemWidth
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemHeight.</para>
    /// <para>Represents the following attribute in the schema: getItemHeight </para>
    /// </summary>
    [SchemaAttr(0, "getItemHeight")]
    public StringValue GetItemHeight
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> showItemLabel.</para>
    /// <para>Represents the following attribute in the schema: showItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "showItemLabel")]
    public BooleanValue ShowItemLabel
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID")]
    public StringValue GetSelectedItemID
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "item" == name)
    return new Item();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    

    return null;
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
public partial class UnsizedToggleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12648;
    /// <inheritdoc/>
    public override string LocalName => "toggleButton";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "getPressed"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    

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
public partial class MenuSeparator : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12649;
    /// <inheritdoc/>
    public override string LocalName => "menuSeparator";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "getTitle")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    

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
public partial class UnsizedSplitButton : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12650;
    /// <inheritdoc/>
    public override string LocalName => "splitButton";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    

    return null;
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
public partial class UnsizedMenu : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12651;
    /// <inheritdoc/>
    public override string LocalName => "menu";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>>(0, "itemSize"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 34 == namespaceId && "splitButton" == name)
    return new UnsizedSplitButton();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    

    return null;
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
public partial class UnsizedDynamicMenu : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12652;
    /// <inheritdoc/>
    public override string LocalName => "dynamicMenu";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "getContent"),
		AttributeTag.Create<BooleanValue>(0, "invalidateContentOnDrop"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getContent.</para>
    /// <para>Represents the following attribute in the schema: getContent </para>
    /// </summary>
    [SchemaAttr(0, "getContent")]
    public StringValue GetContent
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop")]
    public BooleanValue InvalidateContentOnDrop
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    

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
public partial class SplitButtonWithTitle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12653;
    /// <inheritdoc/>
    public override string LocalName => "splitButton";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 34 == namespaceId && "menu" == name)
    return new MenuWithTitle();
    

    return null;
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
public partial class MenuWithTitle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12654;
    /// <inheritdoc/>
    public override string LocalName => "menu";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>>(0, "itemSize"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "getTitle"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 34 == namespaceId && "splitButton" == name)
    return new SplitButtonWithTitle();
    
if( 34 == namespaceId && "menu" == name)
    return new MenuWithTitle();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    

    return null;
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
public partial class ControlClone : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12655;
    /// <inheritdoc/>
    public override string LocalName => "control";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    

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
public partial class TextLabel : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12656;
    /// <inheritdoc/>
    public override string LocalName => "labelControl";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    

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
public partial class Button : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12657;
    /// <inheritdoc/>
    public override string LocalName => "button";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    

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
public partial class ToggleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12658;
    /// <inheritdoc/>
    public override string LocalName => "toggleButton";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<StringValue>(0, "getPressed"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    

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
public partial class EditBox : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12659;
    /// <inheritdoc/>
    public override string LocalName => "editBox";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<IntegerValue>(0, "maxLength"),
		AttributeTag.Create<StringValue>(0, "getText"),
		AttributeTag.Create<StringValue>(0, "onChange"),
		AttributeTag.Create<StringValue>(0, "sizeString"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> maxLength.</para>
    /// <para>Represents the following attribute in the schema: maxLength </para>
    /// </summary>
    [SchemaAttr(0, "maxLength")]
    public IntegerValue MaxLength
    {
        get { return (IntegerValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getText.</para>
    /// <para>Represents the following attribute in the schema: getText </para>
    /// </summary>
    [SchemaAttr(0, "getText")]
    public StringValue GetText
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> onChange.</para>
    /// <para>Represents the following attribute in the schema: onChange </para>
    /// </summary>
    [SchemaAttr(0, "onChange")]
    public StringValue OnChange
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    

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
public partial class ComboBox : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12660;
    /// <inheritdoc/>
    public override string LocalName => "comboBox";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "showItemImage"),
		AttributeTag.Create<StringValue>(0, "getItemCount"),
		AttributeTag.Create<StringValue>(0, "getItemLabel"),
		AttributeTag.Create<StringValue>(0, "getItemScreentip"),
		AttributeTag.Create<StringValue>(0, "getItemSupertip"),
		AttributeTag.Create<StringValue>(0, "getItemImage"),
		AttributeTag.Create<StringValue>(0, "getItemID"),
		AttributeTag.Create<StringValue>(0, "sizeString"),
		AttributeTag.Create<BooleanValue>(0, "invalidateContentOnDrop"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<IntegerValue>(0, "maxLength"),
		AttributeTag.Create<StringValue>(0, "getText"),
		AttributeTag.Create<StringValue>(0, "onChange"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop")]
    public BooleanValue InvalidateContentOnDrop
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> maxLength.</para>
    /// <para>Represents the following attribute in the schema: maxLength </para>
    /// </summary>
    [SchemaAttr(0, "maxLength")]
    public IntegerValue MaxLength
    {
        get { return (IntegerValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getText.</para>
    /// <para>Represents the following attribute in the schema: getText </para>
    /// </summary>
    [SchemaAttr(0, "getText")]
    public StringValue GetText
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> onChange.</para>
    /// <para>Represents the following attribute in the schema: onChange </para>
    /// </summary>
    [SchemaAttr(0, "onChange")]
    public StringValue OnChange
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "item" == name)
    return new Item();
    

    return null;
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
public partial class DropDown : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12661;
    /// <inheritdoc/>
    public override string LocalName => "dropDown";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<BooleanValue>(0, "showItemImage"),
		AttributeTag.Create<StringValue>(0, "getItemCount"),
		AttributeTag.Create<StringValue>(0, "getItemLabel"),
		AttributeTag.Create<StringValue>(0, "getItemScreentip"),
		AttributeTag.Create<StringValue>(0, "getItemSupertip"),
		AttributeTag.Create<StringValue>(0, "getItemImage"),
		AttributeTag.Create<StringValue>(0, "getItemID"),
		AttributeTag.Create<StringValue>(0, "sizeString"),
		AttributeTag.Create<StringValue>(0, "getSelectedItemID"),
		AttributeTag.Create<StringValue>(0, "getSelectedItemIndex"),
		AttributeTag.Create<BooleanValue>(0, "showItemLabel"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID")]
    public StringValue GetSelectedItemID
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> showItemLabel.</para>
    /// <para>Represents the following attribute in the schema: showItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "showItemLabel")]
    public BooleanValue ShowItemLabel
    {
        get { return (BooleanValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "item" == name)
    return new Item();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    

    return null;
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
public partial class Gallery : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12662;
    /// <inheritdoc/>
    public override string LocalName => "gallery";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<BooleanValue>(0, "invalidateContentOnDrop"),
		AttributeTag.Create<IntegerValue>(0, "columns"),
		AttributeTag.Create<IntegerValue>(0, "rows"),
		AttributeTag.Create<IntegerValue>(0, "itemWidth"),
		AttributeTag.Create<IntegerValue>(0, "itemHeight"),
		AttributeTag.Create<StringValue>(0, "getItemWidth"),
		AttributeTag.Create<StringValue>(0, "getItemHeight"),
		AttributeTag.Create<BooleanValue>(0, "showItemLabel"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<BooleanValue>(0, "showItemImage"),
		AttributeTag.Create<StringValue>(0, "getItemCount"),
		AttributeTag.Create<StringValue>(0, "getItemLabel"),
		AttributeTag.Create<StringValue>(0, "getItemScreentip"),
		AttributeTag.Create<StringValue>(0, "getItemSupertip"),
		AttributeTag.Create<StringValue>(0, "getItemImage"),
		AttributeTag.Create<StringValue>(0, "getItemID"),
		AttributeTag.Create<StringValue>(0, "sizeString"),
		AttributeTag.Create<StringValue>(0, "getSelectedItemID"),
		AttributeTag.Create<StringValue>(0, "getSelectedItemIndex"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop")]
    public BooleanValue InvalidateContentOnDrop
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> columns.</para>
    /// <para>Represents the following attribute in the schema: columns </para>
    /// </summary>
    [SchemaAttr(0, "columns")]
    public IntegerValue Columns
    {
        get { return (IntegerValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> rows.</para>
    /// <para>Represents the following attribute in the schema: rows </para>
    /// </summary>
    [SchemaAttr(0, "rows")]
    public IntegerValue Rows
    {
        get { return (IntegerValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> itemWidth.</para>
    /// <para>Represents the following attribute in the schema: itemWidth </para>
    /// </summary>
    [SchemaAttr(0, "itemWidth")]
    public IntegerValue ItemWidth
    {
        get { return (IntegerValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> itemHeight.</para>
    /// <para>Represents the following attribute in the schema: itemHeight </para>
    /// </summary>
    [SchemaAttr(0, "itemHeight")]
    public IntegerValue ItemHeight
    {
        get { return (IntegerValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemWidth.</para>
    /// <para>Represents the following attribute in the schema: getItemWidth </para>
    /// </summary>
    [SchemaAttr(0, "getItemWidth")]
    public StringValue GetItemWidth
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemHeight.</para>
    /// <para>Represents the following attribute in the schema: getItemHeight </para>
    /// </summary>
    [SchemaAttr(0, "getItemHeight")]
    public StringValue GetItemHeight
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> showItemLabel.</para>
    /// <para>Represents the following attribute in the schema: showItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "showItemLabel")]
    public BooleanValue ShowItemLabel
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID")]
    public StringValue GetSelectedItemID
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "item" == name)
    return new Item();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    

    return null;
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
public partial class Menu : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12663;
    /// <inheritdoc/>
    public override string LocalName => "menu";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>>(0, "itemSize"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 34 == namespaceId && "splitButton" == name)
    return new UnsizedSplitButton();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    

    return null;
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
public partial class DynamicMenu : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12664;
    /// <inheritdoc/>
    public override string LocalName => "dynamicMenu";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "getContent"),
		AttributeTag.Create<BooleanValue>(0, "invalidateContentOnDrop"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getContent.</para>
    /// <para>Represents the following attribute in the schema: getContent </para>
    /// </summary>
    [SchemaAttr(0, "getContent")]
    public StringValue GetContent
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop")]
    public BooleanValue InvalidateContentOnDrop
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    

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
public partial class SplitButton : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12665;
    /// <inheritdoc/>
    public override string LocalName => "splitButton";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    

    return null;
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
public partial class Box : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12666;
    /// <inheritdoc/>
    public override string LocalName => "box";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues>>(0, "boxStyle")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> boxStyle.</para>
    /// <para>Represents the following attribute in the schema: boxStyle </para>
    /// </summary>
    [SchemaAttr(0, "boxStyle")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues> BoxStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues>)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new ControlClone();
    
if( 34 == namespaceId && "labelControl" == name)
    return new TextLabel();
    
if( 34 == namespaceId && "button" == name)
    return new Button();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new ToggleButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "editBox" == name)
    return new EditBox();
    
if( 34 == namespaceId && "comboBox" == name)
    return new ComboBox();
    
if( 34 == namespaceId && "dropDown" == name)
    return new DropDown();
    
if( 34 == namespaceId && "gallery" == name)
    return new Gallery();
    
if( 34 == namespaceId && "menu" == name)
    return new Menu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenu();
    
if( 34 == namespaceId && "splitButton" == name)
    return new SplitButton();
    
if( 34 == namespaceId && "box" == name)
    return new Box();
    
if( 34 == namespaceId && "buttonGroup" == name)
    return new ButtonGroup();
    

    return null;
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
public partial class ButtonGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12667;
    /// <inheritdoc/>
    public override string LocalName => "buttonGroup";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    
if( 34 == namespaceId && "splitButton" == name)
    return new UnsizedSplitButton();
    

    return null;
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
public partial class MenuRoot : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12668;
    /// <inheritdoc/>
    public override string LocalName => "menu";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "getTitle"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>>(0, "itemSize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 34 == namespaceId && "splitButton" == name)
    return new UnsizedSplitButton();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    

    return null;
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
public partial class CustomUI : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12669;
    /// <inheritdoc/>
    public override string LocalName => "customUI";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "onLoad"),
		AttributeTag.Create<StringValue>(0, "loadImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> onLoad.</para>
    /// <para>Represents the following attribute in the schema: onLoad </para>
    /// </summary>
    [SchemaAttr(0, "onLoad")]
    public StringValue OnLoad
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> loadImage.</para>
    /// <para>Represents the following attribute in the schema: loadImage </para>
    /// </summary>
    [SchemaAttr(0, "loadImage")]
    public StringValue LoadImage
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "commands" == name)
    return new RepurposedCommands();
    
if( 34 == namespaceId && "ribbon" == name)
    return new Ribbon();
    

    return null;
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
public partial class Item : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12670;
    /// <inheritdoc/>
    public override string LocalName => "item";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "supertip")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    

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
public partial class VisibleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12671;
    /// <inheritdoc/>
    public override string LocalName => "button";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    

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
public partial class VisibleToggleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12672;
    /// <inheritdoc/>
    public override string LocalName => "toggleButton";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "getPressed"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    

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
public partial class VerticalSeparator : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12673;
    /// <inheritdoc/>
    public override string LocalName => "separator";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    

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
public partial class DialogBoxLauncher : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12674;
    /// <inheritdoc/>
    public override string LocalName => "dialogBoxLauncher";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    

    return null;
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
public partial class Group : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12675;
    /// <inheritdoc/>
    public override string LocalName => "group";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new ControlClone();
    
if( 34 == namespaceId && "labelControl" == name)
    return new TextLabel();
    
if( 34 == namespaceId && "button" == name)
    return new Button();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new ToggleButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "editBox" == name)
    return new EditBox();
    
if( 34 == namespaceId && "comboBox" == name)
    return new ComboBox();
    
if( 34 == namespaceId && "dropDown" == name)
    return new DropDown();
    
if( 34 == namespaceId && "gallery" == name)
    return new Gallery();
    
if( 34 == namespaceId && "menu" == name)
    return new Menu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenu();
    
if( 34 == namespaceId && "splitButton" == name)
    return new SplitButton();
    
if( 34 == namespaceId && "box" == name)
    return new Box();
    
if( 34 == namespaceId && "buttonGroup" == name)
    return new ButtonGroup();
    
if( 34 == namespaceId && "separator" == name)
    return new VerticalSeparator();
    
if( 34 == namespaceId && "dialogBoxLauncher" == name)
    return new DialogBoxLauncher();
    

    return null;
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
public partial class QuickAccessToolbarControlClone : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12676;
    /// <inheritdoc/>
    public override string LocalName => "control";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<BooleanValue>(0, "showImage"),
		AttributeTag.Create<StringValue>(0, "getShowImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    

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
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SharedQatControls : QatItemsType
{
    internal const int ElementTypeIdConst = 12677;
    /// <inheritdoc/>
    public override string LocalName => "sharedControls";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DocumentSpecificQuickAccessToolbarControls : QatItemsType
{
    internal const int ElementTypeIdConst = 12678;
    /// <inheritdoc/>
    public override string LocalName => "documentControls";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new QuickAccessToolbarControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "separator" == name)
    return new VerticalSeparator();
    

    return null;
}

    
    
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
public partial class Tab : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12679;
    /// <inheritdoc/>
    public override string LocalName => "tab";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "group" == name)
    return new Group();
    

    return null;
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
public partial class ContextualTabSet : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12680;
    /// <inheritdoc/>
    public override string LocalName => "tabSet";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "tab" == name)
    return new Tab();
    

    return null;
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
public partial class RepurposedCommand : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12681;
    /// <inheritdoc/>
    public override string LocalName => "command";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "idMso")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

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
public partial class OfficeMenu : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12682;
    /// <inheritdoc/>
    public override string LocalName => "officeMenu";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 34 == namespaceId && "splitButton" == name)
    return new SplitButtonWithTitle();
    
if( 34 == namespaceId && "menu" == name)
    return new MenuWithTitle();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    

    return null;
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
public partial class QuickAccessToolbar : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12683;
    /// <inheritdoc/>
    public override string LocalName => "qat";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "sharedControls" == name)
    return new SharedQatControls();
    
if( 34 == namespaceId && "documentControls" == name)
    return new DocumentSpecificQuickAccessToolbarControls();
    

    return null;
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
public partial class Tabs : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12684;
    /// <inheritdoc/>
    public override string LocalName => "tabs";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "tab" == name)
    return new Tab();
    

    return null;
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
public partial class ContextualTabSets : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12685;
    /// <inheritdoc/>
    public override string LocalName => "contextualTabs";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "tabSet" == name)
    return new ContextualTabSet();
    

    return null;
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
public partial class RepurposedCommands : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12686;
    /// <inheritdoc/>
    public override string LocalName => "commands";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "command" == name)
    return new RepurposedCommand();
    

    return null;
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
public partial class Ribbon : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12687;
    /// <inheritdoc/>
    public override string LocalName => "ribbon";
    
    internal override byte NamespaceId => 34;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "startFromScratch")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> startFromScratch.</para>
    /// <para>Represents the following attribute in the schema: startFromScratch </para>
    /// </summary>
    [SchemaAttr(0, "startFromScratch")]
    public BooleanValue StartFromScratch
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "officeMenu" == name)
    return new OfficeMenu();
    
if( 34 == namespaceId && "qat" == name)
    return new QuickAccessToolbar();
    
if( 34 == namespaceId && "tabs" == name)
    return new Tabs();
    
if( 34 == namespaceId && "contextualTabs" == name)
    return new ContextualTabSets();
    

    return null;
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
 
 
