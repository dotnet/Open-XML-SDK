// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
/// <summary>
/// <para>Defines the ControlCloneRegular Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:control.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ControlCloneRegular : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13099;
    /// <inheritdoc/>
    public override string LocalName => "control";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the ControlCloneRegular class.
    /// </summary>
    public ControlCloneRegular():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlCloneRegular>(deep);

}
/// <summary>
/// <para>Defines the ButtonRegular Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ButtonRegular : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13100;
    /// <inheritdoc/>
    public override string LocalName => "button";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the ButtonRegular class.
    /// </summary>
    public ButtonRegular():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonRegular>(deep);

}
/// <summary>
/// <para>Defines the CheckBox Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:checkBox.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CheckBox : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13101;
    /// <inheritdoc/>
    public override string LocalName => "checkBox";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
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
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
/// <para>Defines the GalleryRegular Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:gallery.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso14:item></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Item), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class GalleryRegular : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13102;
    /// <inheritdoc/>
    public override string LocalName => "gallery";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>>(0, "showInRibbon"),
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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    /// <para> showInRibbon.</para>
    /// <para>Represents the following attribute in the schema: showInRibbon </para>
    /// </summary>
    [SchemaAttr(0, "showInRibbon")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues> ShowInRibbon
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID")]
    public StringValue GetSelectedItemID
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the GalleryRegular class.
    /// </summary>
    public GalleryRegular():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GalleryRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GalleryRegular(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GalleryRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GalleryRegular(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GalleryRegular class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GalleryRegular(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "item" == name)
    return new Item();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GalleryRegular>(deep);

}
/// <summary>
/// <para>Defines the ToggleButtonRegular Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:toggleButton.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ToggleButtonRegular : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13103;
    /// <inheritdoc/>
    public override string LocalName => "toggleButton";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the ToggleButtonRegular class.
    /// </summary>
    public ToggleButtonRegular():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToggleButtonRegular>(deep);

}
/// <summary>
/// <para>Defines the MenuSeparator Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menuSeparator.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class MenuSeparator : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13104;
    /// <inheritdoc/>
    public override string LocalName => "menuSeparator";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
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
    public StringValue QualifiedId
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
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MenuSeparator class.
    /// </summary>
    public MenuSeparator():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuSeparator>(deep);

}
/// <summary>
/// <para>Defines the SplitButtonRegular Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso14:button></description></item>
///<item><description>VisibleToggleButton &lt;mso14:toggleButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VisibleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(VisibleToggleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SplitButtonRegular : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13105;
    /// <inheritdoc/>
    public override string LocalName => "splitButton";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the SplitButtonRegular class.
    /// </summary>
    public SplitButtonRegular():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SplitButtonRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButtonRegular(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButtonRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButtonRegular(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButtonRegular class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SplitButtonRegular(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButtonRegular>(deep);

}
/// <summary>
/// <para>Defines the MenuRegular Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
///<item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuSeparator), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class MenuRegular : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13106;
    /// <inheritdoc/>
    public override string LocalName => "menu";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>(0, "itemSize"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>)Attributes[0].Value; }
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the MenuRegular class.
    /// </summary>
    public MenuRegular():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MenuRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuRegular(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuRegular(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuRegular class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MenuRegular(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonRegular();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuRegular>(deep);

}
/// <summary>
/// <para>Defines the DynamicMenuRegular Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:dynamicMenu.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DynamicMenuRegular : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13107;
    /// <inheritdoc/>
    public override string LocalName => "dynamicMenu";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the DynamicMenuRegular class.
    /// </summary>
    public DynamicMenuRegular():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DynamicMenuRegular>(deep);

}
/// <summary>
/// <para>Defines the SplitButtonWithTitle Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso14:button></description></item>
///<item><description>VisibleToggleButton &lt;mso14:toggleButton></description></item>
///<item><description>MenuWithTitle &lt;mso14:menu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VisibleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(VisibleToggleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuWithTitle), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SplitButtonWithTitle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13108;
    /// <inheritdoc/>
    public override string LocalName => "splitButton";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuWithTitle();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButtonWithTitle>(deep);

}
/// <summary>
/// <para>Defines the MenuWithTitle Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
///<item><description>SplitButtonWithTitle &lt;mso14:splitButton></description></item>
///<item><description>MenuWithTitle &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuSeparator), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonWithTitle), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuWithTitle), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class MenuWithTitle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13109;
    /// <inheritdoc/>
    public override string LocalName => "menu";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>(0, "itemSize"),
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
    public StringValue QualifiedId
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
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>)Attributes[4].Value; }
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonWithTitle();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuWithTitle();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuWithTitle>(deep);

}
/// <summary>
/// <para>Defines the MenuSeparatorNoTitle Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menuSeparator.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class MenuSeparatorNoTitle : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13110;
    /// <inheritdoc/>
    public override string LocalName => "menuSeparator";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
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
    public StringValue QualifiedId
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
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MenuSeparatorNoTitle class.
    /// </summary>
    public MenuSeparatorNoTitle():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuSeparatorNoTitle>(deep);

}
/// <summary>
/// <para>Defines the ControlClone Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:control.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ControlClone : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13111;
    /// <inheritdoc/>
    public override string LocalName => "control";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0].Value; }
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
/// <para>Defines the LabelControl Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:labelControl.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LabelControl : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13112;
    /// <inheritdoc/>
    public override string LocalName => "labelControl";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the LabelControl class.
    /// </summary>
    public LabelControl():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LabelControl>(deep);

}
/// <summary>
/// <para>Defines the Button Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Button : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13113;
    /// <inheritdoc/>
    public override string LocalName => "button";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>(0, "size"),
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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0].Value; }
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:toggleButton.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ToggleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13114;
    /// <inheritdoc/>
    public override string LocalName => "toggleButton";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>(0, "size"),
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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0].Value; }
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
    public StringValue QualifiedId
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
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:editBox.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class EditBox : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13115;
    /// <inheritdoc/>
    public override string LocalName => "editBox";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:comboBox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso14:item></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Item), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ComboBox : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13116;
    /// <inheritdoc/>
    public override string LocalName => "comboBox";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "item" == name)
    return new Item();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ComboBox>(deep);

}
/// <summary>
/// <para>Defines the DropDownRegular Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:dropDown.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso14:item></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Item), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropDownRegular : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13117;
    /// <inheritdoc/>
    public override string LocalName => "dropDown";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the DropDownRegular class.
    /// </summary>
    public DropDownRegular():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DropDownRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropDownRegular(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DropDownRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropDownRegular(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DropDownRegular class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DropDownRegular(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "item" == name)
    return new Item();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropDownRegular>(deep);

}
/// <summary>
/// <para>Defines the Gallery Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:gallery.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso14:item></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Item), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Gallery : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13118;
    /// <inheritdoc/>
    public override string LocalName => "gallery";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>(0, "size"),
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
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>>(0, "showInRibbon"),
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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0].Value; }
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
    /// <para> showInRibbon.</para>
    /// <para>Represents the following attribute in the schema: showInRibbon </para>
    /// </summary>
    [SchemaAttr(0, "showInRibbon")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues> ShowInRibbon
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
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
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID")]
    public StringValue GetSelectedItemID
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
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
    if( 57 == namespaceId && "item" == name)
    return new Item();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Gallery>(deep);

}
/// <summary>
/// <para>Defines the Menu Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
///<item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuSeparator), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Menu : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13119;
    /// <inheritdoc/>
    public override string LocalName => "menu";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>(0, "itemSize"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0].Value; }
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>)Attributes[2].Value; }
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonRegular();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Menu>(deep);

}
/// <summary>
/// <para>Defines the DynamicMenu Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:dynamicMenu.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DynamicMenu : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13120;
    /// <inheritdoc/>
    public override string LocalName => "dynamicMenu";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0].Value; }
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso14:button></description></item>
///<item><description>VisibleToggleButton &lt;mso14:toggleButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VisibleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(VisibleToggleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SplitButton : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13121;
    /// <inheritdoc/>
    public override string LocalName => "splitButton";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>(0, "size"),
		AttributeTag.Create<StringValue>(0, "getSize"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0].Value; }
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButton>(deep);

}
/// <summary>
/// <para>Defines the Box Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:box.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlClone &lt;mso14:control></description></item>
///<item><description>LabelControl &lt;mso14:labelControl></description></item>
///<item><description>Button &lt;mso14:button></description></item>
///<item><description>ToggleButton &lt;mso14:toggleButton></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>EditBox &lt;mso14:editBox></description></item>
///<item><description>ComboBox &lt;mso14:comboBox></description></item>
///<item><description>DropDownRegular &lt;mso14:dropDown></description></item>
///<item><description>Gallery &lt;mso14:gallery></description></item>
///<item><description>Menu &lt;mso14:menu></description></item>
///<item><description>DynamicMenu &lt;mso14:dynamicMenu></description></item>
///<item><description>SplitButton &lt;mso14:splitButton></description></item>
///<item><description>Box &lt;mso14:box></description></item>
///<item><description>ButtonGroup &lt;mso14:buttonGroup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlClone), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LabelControl), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Button), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(EditBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ComboBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropDownRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Gallery), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Menu), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenu), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Box), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonGroup), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Box : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13122;
    /// <inheritdoc/>
    public override string LocalName => "box";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues>>(0, "boxStyle")
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
    public StringValue QualifiedId
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> boxStyle.</para>
    /// <para>Represents the following attribute in the schema: boxStyle </para>
    /// </summary>
    [SchemaAttr(0, "boxStyle")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues> BoxStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues>)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
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
    if( 57 == namespaceId && "control" == name)
    return new ControlClone();
    
if( 57 == namespaceId && "labelControl" == name)
    return new LabelControl();
    
if( 57 == namespaceId && "button" == name)
    return new Button();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "editBox" == name)
    return new EditBox();
    
if( 57 == namespaceId && "comboBox" == name)
    return new ComboBox();
    
if( 57 == namespaceId && "dropDown" == name)
    return new DropDownRegular();
    
if( 57 == namespaceId && "gallery" == name)
    return new Gallery();
    
if( 57 == namespaceId && "menu" == name)
    return new Menu();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenu();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButton();
    
if( 57 == namespaceId && "box" == name)
    return new Box();
    
if( 57 == namespaceId && "buttonGroup" == name)
    return new ButtonGroup();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Box>(deep);

}
/// <summary>
/// <para>Defines the ButtonGroup Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:buttonGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
///<item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
///<item><description>Separator &lt;mso14:separator></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Separator), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ButtonGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13123;
    /// <inheritdoc/>
    public override string LocalName => "buttonGroup";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
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
    public StringValue QualifiedId
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
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
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonRegular();
    
if( 57 == namespaceId && "separator" == name)
    return new Separator();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonGroup>(deep);

}
/// <summary>
/// <para>Defines the BackstageMenuButton Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageMenuButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13124;
    /// <inheritdoc/>
    public override string LocalName => "button";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "isDefinitive"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage")
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> isDefinitive.</para>
    /// <para>Represents the following attribute in the schema: isDefinitive </para>
    /// </summary>
    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
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
    /// Initializes a new instance of the BackstageMenuButton class.
    /// </summary>
    public BackstageMenuButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuButton>(deep);

}
/// <summary>
/// <para>Defines the BackstageMenuCheckBox Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:checkBox.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageMenuCheckBox : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13125;
    /// <inheritdoc/>
    public override string LocalName => "checkBox";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<StringValue>(0, "getPressed"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip")
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageMenuCheckBox class.
    /// </summary>
    public BackstageMenuCheckBox():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuCheckBox>(deep);

}
/// <summary>
/// <para>Defines the BackstageSubMenu Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageMenuGroup &lt;mso14:menuGroup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackstageMenuGroup), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageSubMenu : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13126;
    /// <inheritdoc/>
    public override string LocalName => "menu";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip")
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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
    /// Initializes a new instance of the BackstageSubMenu class.
    /// </summary>
    public BackstageSubMenu():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BackstageSubMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageSubMenu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageSubMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageSubMenu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageSubMenu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageSubMenu(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "menuGroup" == name)
    return new BackstageMenuGroup();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageSubMenu>(deep);

}
/// <summary>
/// <para>Defines the BackstageMenuToggleButton Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:toggleButton.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageMenuToggleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13127;
    /// <inheritdoc/>
    public override string LocalName => "toggleButton";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<StringValue>(0, "getPressed"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
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
    public StringValue QualifiedId
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageMenuToggleButton class.
    /// </summary>
    public BackstageMenuToggleButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuToggleButton>(deep);

}
/// <summary>
/// <para>Defines the BackstageGroupButton Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageGroupButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13128;
    /// <inheritdoc/>
    public override string LocalName => "button";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "expand"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values>>(0, "style"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "isDefinitive"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values> Style
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
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
    public StringValue QualifiedId
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> isDefinitive.</para>
    /// <para>Represents the following attribute in the schema: isDefinitive </para>
    /// </summary>
    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
    {
        get { return (BooleanValue)Attributes[10].Value; }
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
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageGroupButton class.
    /// </summary>
    public BackstageGroupButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageGroupButton>(deep);

}
/// <summary>
/// <para>Defines the BackstageCheckBox Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:checkBox.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageCheckBox : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13129;
    /// <inheritdoc/>
    public override string LocalName => "checkBox";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "expand"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<StringValue>(0, "getPressed"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[0].Value; }
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
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
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
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
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
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageCheckBox class.
    /// </summary>
    public BackstageCheckBox():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageCheckBox>(deep);

}
/// <summary>
/// <para>Defines the BackstageEditBox Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:editBox.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageEditBox : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13130;
    /// <inheritdoc/>
    public override string LocalName => "editBox";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "alignLabel"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "expand"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<StringValue>(0, "getText"),
		AttributeTag.Create<StringValue>(0, "onChange"),
		AttributeTag.Create<IntegerValue>(0, "maxLength"),
		AttributeTag.Create<StringValue>(0, "sizeString")
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getText.</para>
    /// <para>Represents the following attribute in the schema: getText </para>
    /// </summary>
    [SchemaAttr(0, "getText")]
    public StringValue GetText
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> onChange.</para>
    /// <para>Represents the following attribute in the schema: onChange </para>
    /// </summary>
    [SchemaAttr(0, "onChange")]
    public StringValue OnChange
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> maxLength.</para>
    /// <para>Represents the following attribute in the schema: maxLength </para>
    /// </summary>
    [SchemaAttr(0, "maxLength")]
    public IntegerValue MaxLength
    {
        get { return (IntegerValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageEditBox class.
    /// </summary>
    public BackstageEditBox():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageEditBox>(deep);

}
/// <summary>
/// <para>Defines the BackstageDropDown Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:dropDown.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ItemBackstageItem &lt;mso14:item></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ItemBackstageItem), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageDropDown : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13131;
    /// <inheritdoc/>
    public override string LocalName => "dropDown";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "alignLabel"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "expand"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<StringValue>(0, "getSelectedItemIndex"),
		AttributeTag.Create<StringValue>(0, "sizeString"),
		AttributeTag.Create<StringValue>(0, "getItemCount"),
		AttributeTag.Create<StringValue>(0, "getItemLabel"),
		AttributeTag.Create<StringValue>(0, "getItemID")
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
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
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
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
    /// Initializes a new instance of the BackstageDropDown class.
    /// </summary>
    public BackstageDropDown():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BackstageDropDown class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageDropDown(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageDropDown class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageDropDown(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageDropDown class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageDropDown(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "item" == name)
    return new ItemBackstageItem();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageDropDown>(deep);

}
/// <summary>
/// <para>Defines the RadioGroup Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:radioGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RadioButtonBackstageItem &lt;mso14:radioButton></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RadioButtonBackstageItem), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RadioGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13132;
    /// <inheritdoc/>
    public override string LocalName => "radioGroup";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "alignLabel"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "expand"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<StringValue>(0, "getSelectedItemIndex"),
		AttributeTag.Create<StringValue>(0, "getItemCount"),
		AttributeTag.Create<StringValue>(0, "getItemLabel"),
		AttributeTag.Create<StringValue>(0, "getItemID")
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
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
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RadioGroup class.
    /// </summary>
    public RadioGroup():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RadioGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadioGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadioGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadioGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadioGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadioGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "radioButton" == name)
    return new RadioButtonBackstageItem();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadioGroup>(deep);

}
/// <summary>
/// <para>Defines the BackstageComboBox Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:comboBox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ItemBackstageItem &lt;mso14:item></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ItemBackstageItem), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageComboBox : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13133;
    /// <inheritdoc/>
    public override string LocalName => "comboBox";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "alignLabel"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "expand"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<StringValue>(0, "getText"),
		AttributeTag.Create<StringValue>(0, "onChange"),
		AttributeTag.Create<StringValue>(0, "sizeString"),
		AttributeTag.Create<StringValue>(0, "getItemCount"),
		AttributeTag.Create<StringValue>(0, "getItemLabel"),
		AttributeTag.Create<StringValue>(0, "getItemID")
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getText.</para>
    /// <para>Represents the following attribute in the schema: getText </para>
    /// </summary>
    [SchemaAttr(0, "getText")]
    public StringValue GetText
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> onChange.</para>
    /// <para>Represents the following attribute in the schema: onChange </para>
    /// </summary>
    [SchemaAttr(0, "onChange")]
    public StringValue OnChange
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageComboBox class.
    /// </summary>
    public BackstageComboBox():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BackstageComboBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageComboBox(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageComboBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageComboBox(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageComboBox class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageComboBox(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "item" == name)
    return new ItemBackstageItem();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageComboBox>(deep);

}
/// <summary>
/// <para>Defines the Hyperlink Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:hyperlink.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Hyperlink : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13134;
    /// <inheritdoc/>
    public override string LocalName => "hyperlink";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "alignLabel"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "expand"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "getTarget")
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> getTarget.</para>
    /// <para>Represents the following attribute in the schema: getTarget </para>
    /// </summary>
    [SchemaAttr(0, "getTarget")]
    public StringValue GetTarget
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Hyperlink class.
    /// </summary>
    public Hyperlink():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Hyperlink>(deep);

}
/// <summary>
/// <para>Defines the BackstageLabelControl Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:labelControl.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageLabelControl : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13135;
    /// <inheritdoc/>
    public override string LocalName => "labelControl";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "alignLabel"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "expand"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<BooleanValue>(0, "noWrap")
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> noWrap.</para>
    /// <para>Represents the following attribute in the schema: noWrap </para>
    /// </summary>
    [SchemaAttr(0, "noWrap")]
    public BooleanValue NoWrap
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageLabelControl class.
    /// </summary>
    public BackstageLabelControl():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageLabelControl>(deep);

}
/// <summary>
/// <para>Defines the GroupBox Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:groupBox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroupButton &lt;mso14:button></description></item>
///<item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageEditBox &lt;mso14:editBox></description></item>
///<item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
///<item><description>RadioGroup &lt;mso14:radioGroup></description></item>
///<item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
///<item><description>Hyperlink &lt;mso14:hyperlink></description></item>
///<item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
///<item><description>GroupBox &lt;mso14:groupBox></description></item>
///<item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
///<item><description>ImageControl &lt;mso14:imageControl></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackstageGroupButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageCheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageEditBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageDropDown), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(RadioGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageComboBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Hyperlink), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageLabelControl), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GroupBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LayoutContainer), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ImageControl), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class GroupBox : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13136;
    /// <inheritdoc/>
    public override string LocalName => "groupBox";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "expand"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel")
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
    public StringValue QualifiedId
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
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3].Value; }
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
    /// Initializes a new instance of the GroupBox class.
    /// </summary>
    public GroupBox():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GroupBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupBox(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupBox(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupBox class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GroupBox(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new BackstageGroupButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new BackstageCheckBox();
    
if( 57 == namespaceId && "editBox" == name)
    return new BackstageEditBox();
    
if( 57 == namespaceId && "dropDown" == name)
    return new BackstageDropDown();
    
if( 57 == namespaceId && "radioGroup" == name)
    return new RadioGroup();
    
if( 57 == namespaceId && "comboBox" == name)
    return new BackstageComboBox();
    
if( 57 == namespaceId && "hyperlink" == name)
    return new Hyperlink();
    
if( 57 == namespaceId && "labelControl" == name)
    return new BackstageLabelControl();
    
if( 57 == namespaceId && "groupBox" == name)
    return new GroupBox();
    
if( 57 == namespaceId && "layoutContainer" == name)
    return new LayoutContainer();
    
if( 57 == namespaceId && "imageControl" == name)
    return new ImageControl();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupBox>(deep);

}
/// <summary>
/// <para>Defines the LayoutContainer Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:layoutContainer.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroupButton &lt;mso14:button></description></item>
///<item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageEditBox &lt;mso14:editBox></description></item>
///<item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
///<item><description>RadioGroup &lt;mso14:radioGroup></description></item>
///<item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
///<item><description>Hyperlink &lt;mso14:hyperlink></description></item>
///<item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
///<item><description>GroupBox &lt;mso14:groupBox></description></item>
///<item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
///<item><description>ImageControl &lt;mso14:imageControl></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackstageGroupButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageCheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageEditBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageDropDown), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(RadioGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageComboBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Hyperlink), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageLabelControl), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GroupBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LayoutContainer), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ImageControl), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LayoutContainer : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13137;
    /// <inheritdoc/>
    public override string LocalName => "layoutContainer";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "align"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>(0, "expand"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues>>(0, "layoutChildren")
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
    public StringValue QualifiedId
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
    /// <para> align.</para>
    /// <para>Represents the following attribute in the schema: align </para>
    /// </summary>
    [SchemaAttr(0, "align")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Align
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> layoutChildren.</para>
    /// <para>Represents the following attribute in the schema: layoutChildren </para>
    /// </summary>
    [SchemaAttr(0, "layoutChildren")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues> LayoutChildren
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LayoutContainer class.
    /// </summary>
    public LayoutContainer():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LayoutContainer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutContainer(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutContainer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutContainer(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutContainer class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LayoutContainer(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new BackstageGroupButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new BackstageCheckBox();
    
if( 57 == namespaceId && "editBox" == name)
    return new BackstageEditBox();
    
if( 57 == namespaceId && "dropDown" == name)
    return new BackstageDropDown();
    
if( 57 == namespaceId && "radioGroup" == name)
    return new RadioGroup();
    
if( 57 == namespaceId && "comboBox" == name)
    return new BackstageComboBox();
    
if( 57 == namespaceId && "hyperlink" == name)
    return new Hyperlink();
    
if( 57 == namespaceId && "labelControl" == name)
    return new BackstageLabelControl();
    
if( 57 == namespaceId && "groupBox" == name)
    return new GroupBox();
    
if( 57 == namespaceId && "layoutContainer" == name)
    return new LayoutContainer();
    
if( 57 == namespaceId && "imageControl" == name)
    return new ImageControl();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutContainer>(deep);

}
/// <summary>
/// <para>Defines the ImageControl Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:imageControl.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ImageControl : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13138;
    /// <inheritdoc/>
    public override string LocalName => "imageControl";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "altText"),
		AttributeTag.Create<StringValue>(0, "getAltText")
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
    public StringValue QualifiedId
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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
    /// <para> altText.</para>
    /// <para>Represents the following attribute in the schema: altText </para>
    /// </summary>
    [SchemaAttr(0, "altText")]
    public StringValue AltText
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getAltText.</para>
    /// <para>Represents the following attribute in the schema: getAltText </para>
    /// </summary>
    [SchemaAttr(0, "getAltText")]
    public StringValue GetAltText
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ImageControl class.
    /// </summary>
    public ImageControl():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageControl>(deep);

}
/// <summary>
/// <para>Defines the BackstageGroup Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:group.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PrimaryItem &lt;mso14:primaryItem></description></item>
///<item><description>TopItemsGroupControls &lt;mso14:topItems></description></item>
///<item><description>BottomItemsGroupControls &lt;mso14:bottomItems></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PrimaryItem), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TopItemsGroupControls), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BottomItemsGroupControls), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13139;
    /// <inheritdoc/>
    public override string LocalName => "group";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues>>(0, "style"),
		AttributeTag.Create<StringValue>(0, "getStyle"),
		AttributeTag.Create<StringValue>(0, "helperText"),
		AttributeTag.Create<StringValue>(0, "getHelperText"),
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
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
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues> Style
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues>)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getStyle.</para>
    /// <para>Represents the following attribute in the schema: getStyle </para>
    /// </summary>
    [SchemaAttr(0, "getStyle")]
    public StringValue GetStyle
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> helperText.</para>
    /// <para>Represents the following attribute in the schema: helperText </para>
    /// </summary>
    [SchemaAttr(0, "helperText")]
    public StringValue HelperText
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getHelperText.</para>
    /// <para>Represents the following attribute in the schema: getHelperText </para>
    /// </summary>
    [SchemaAttr(0, "getHelperText")]
    public StringValue GetHelperText
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
    /// Initializes a new instance of the BackstageGroup class.
    /// </summary>
    public BackstageGroup():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BackstageGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "primaryItem" == name)
    return new PrimaryItem();
    
if( 57 == namespaceId && "topItems" == name)
    return new TopItemsGroupControls();
    
if( 57 == namespaceId && "bottomItems" == name)
    return new BottomItemsGroupControls();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageGroup>(deep);

}
/// <summary>
/// <para>Defines the TaskGroup Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:taskGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TaskGroupCategory &lt;mso14:category></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TaskGroupCategory), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13140;
    /// <inheritdoc/>
    public override string LocalName => "taskGroup";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "helperText"),
		AttributeTag.Create<StringValue>(0, "getHelperText"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>>(0, "allowedTaskSizes")
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
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
    /// <para> helperText.</para>
    /// <para>Represents the following attribute in the schema: helperText </para>
    /// </summary>
    [SchemaAttr(0, "helperText")]
    public StringValue HelperText
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> getHelperText.</para>
    /// <para>Represents the following attribute in the schema: getHelperText </para>
    /// </summary>
    [SchemaAttr(0, "getHelperText")]
    public StringValue GetHelperText
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
    /// <para> allowedTaskSizes.</para>
    /// <para>Represents the following attribute in the schema: allowedTaskSizes </para>
    /// </summary>
    [SchemaAttr(0, "allowedTaskSizes")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues> AllowedTaskSizes
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TaskGroup class.
    /// </summary>
    public TaskGroup():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TaskGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TaskGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "category" == name)
    return new TaskGroupCategory();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskGroup>(deep);

}
/// <summary>
/// <para>Defines the MenuRoot Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
///<item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuSeparator), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class MenuRoot : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13141;
    /// <inheritdoc/>
    public override string LocalName => "menu";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "getTitle"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>(0, "itemSize")
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>)Attributes[2].Value; }
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
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonRegular();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuRoot>(deep);

}
/// <summary>
/// <para>Defines the CustomUI Class. The root element of RibbonAndBackstageCustomizationsPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:customUI.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Commands &lt;mso14:commands></description></item>
///<item><description>Ribbon &lt;mso14:ribbon></description></item>
///<item><description>Backstage &lt;mso14:backstage></description></item>
///<item><description>ContextMenus &lt;mso14:contextMenus></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Commands), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Ribbon), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Backstage), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ContextMenus), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CustomUI : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 13142;
    /// <inheritdoc/>
    public override string LocalName => "customUI";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
    

    
	internal CustomUI(RibbonAndBackstageCustomizationsPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the RibbonAndBackstageCustomizationsPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(RibbonAndBackstageCustomizationsPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the RibbonAndBackstageCustomizationsPart associated with this element.
    /// </summary>
    public RibbonAndBackstageCustomizationsPart RibbonAndBackstageCustomizationsPart
    {
		get => OpenXmlPart as RibbonAndBackstageCustomizationsPart;
		internal set => OpenXmlPart = value;
    }
    
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

    
    
    /// <summary>
    /// Initializes a new instance of the CustomUI class.
    /// </summary>
    public CustomUI():base(){}
    
    /// <summary>
    /// Saves the DOM into the RibbonAndBackstageCustomizationsPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(RibbonAndBackstageCustomizationsPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "commands" == name)
    return new Commands();
    
if( 57 == namespaceId && "ribbon" == name)
    return new Ribbon();
    
if( 57 == namespaceId && "backstage" == name)
    return new Backstage();
    
if( 57 == namespaceId && "contextMenus" == name)
    return new ContextMenus();
    

    return null;
}

        private static readonly string[] eleTagNames = { "commands","ribbon","backstage","contextMenus" };
    private static readonly byte[] eleNamespaceIds = { 57,57,57,57 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Commands.</para>
    /// <para> Represents the following element tag in the schema: mso14:commands </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public Commands Commands
    {
        get => GetElement<Commands>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Ribbon.</para>
    /// <para> Represents the following element tag in the schema: mso14:ribbon </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public Ribbon Ribbon
    {
        get => GetElement<Ribbon>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Backstage.</para>
    /// <para> Represents the following element tag in the schema: mso14:backstage </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public Backstage Backstage
    {
        get => GetElement<Backstage>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ContextMenus.</para>
    /// <para> Represents the following element tag in the schema: mso14:contextMenus </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public ContextMenus ContextMenus
    {
        get => GetElement<ContextMenus>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomUI>(deep);

}
/// <summary>
/// <para>Defines the Item Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:item.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Item : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13143;
    /// <inheritdoc/>
    public override string LocalName => "item";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class VisibleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13144;
    /// <inheritdoc/>
    public override string LocalName => "button";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:toggleButton.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class VisibleToggleButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13145;
    /// <inheritdoc/>
    public override string LocalName => "toggleButton";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
/// <para>Defines the Separator Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:separator.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Separator : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13146;
    /// <inheritdoc/>
    public override string LocalName => "separator";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
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
    public StringValue QualifiedId
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Separator class.
    /// </summary>
    public Separator():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Separator>(deep);

}
/// <summary>
/// <para>Defines the DialogBoxLauncher Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:dialogBoxLauncher.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ButtonRegular &lt;mso14:button></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DialogBoxLauncher : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13147;
    /// <inheritdoc/>
    public override string LocalName => "dialogBoxLauncher";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
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
    if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    

    return null;
}

        private static readonly string[] eleTagNames = { "button" };
    private static readonly byte[] eleNamespaceIds = { 57 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ButtonRegular.</para>
    /// <para> Represents the following element tag in the schema: mso14:button </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public ButtonRegular ButtonRegular
    {
        get => GetElement<ButtonRegular>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DialogBoxLauncher>(deep);

}
/// <summary>
/// <para>Defines the Group Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:group.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlClone &lt;mso14:control></description></item>
///<item><description>LabelControl &lt;mso14:labelControl></description></item>
///<item><description>Button &lt;mso14:button></description></item>
///<item><description>ToggleButton &lt;mso14:toggleButton></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>EditBox &lt;mso14:editBox></description></item>
///<item><description>ComboBox &lt;mso14:comboBox></description></item>
///<item><description>DropDownRegular &lt;mso14:dropDown></description></item>
///<item><description>Gallery &lt;mso14:gallery></description></item>
///<item><description>Menu &lt;mso14:menu></description></item>
///<item><description>DynamicMenu &lt;mso14:dynamicMenu></description></item>
///<item><description>SplitButton &lt;mso14:splitButton></description></item>
///<item><description>Box &lt;mso14:box></description></item>
///<item><description>ButtonGroup &lt;mso14:buttonGroup></description></item>
///<item><description>Separator &lt;mso14:separator></description></item>
///<item><description>DialogBoxLauncher &lt;mso14:dialogBoxLauncher></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlClone), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LabelControl), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Button), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(EditBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ComboBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropDownRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Gallery), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Menu), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenu), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Box), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Separator), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DialogBoxLauncher), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Group : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13148;
    /// <inheritdoc/>
    public override string LocalName => "group";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<BooleanValue>(0, "autoScale"),
		AttributeTag.Create<BooleanValue>(0, "centerVertically")
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// <para> autoScale.</para>
    /// <para>Represents the following attribute in the schema: autoScale </para>
    /// </summary>
    [SchemaAttr(0, "autoScale")]
    public BooleanValue AutoScale
    {
        get { return (BooleanValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> centerVertically.</para>
    /// <para>Represents the following attribute in the schema: centerVertically </para>
    /// </summary>
    [SchemaAttr(0, "centerVertically")]
    public BooleanValue CenterVertically
    {
        get { return (BooleanValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
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
    if( 57 == namespaceId && "control" == name)
    return new ControlClone();
    
if( 57 == namespaceId && "labelControl" == name)
    return new LabelControl();
    
if( 57 == namespaceId && "button" == name)
    return new Button();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "editBox" == name)
    return new EditBox();
    
if( 57 == namespaceId && "comboBox" == name)
    return new ComboBox();
    
if( 57 == namespaceId && "dropDown" == name)
    return new DropDownRegular();
    
if( 57 == namespaceId && "gallery" == name)
    return new Gallery();
    
if( 57 == namespaceId && "menu" == name)
    return new Menu();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenu();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButton();
    
if( 57 == namespaceId && "box" == name)
    return new Box();
    
if( 57 == namespaceId && "buttonGroup" == name)
    return new ButtonGroup();
    
if( 57 == namespaceId && "separator" == name)
    return new Separator();
    
if( 57 == namespaceId && "dialogBoxLauncher" == name)
    return new DialogBoxLauncher();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);

}
/// <summary>
/// <para>Defines the ControlCloneQat Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:control.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ControlCloneQat : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13149;
    /// <inheritdoc/>
    public override string LocalName => "control";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>(0, "size"),
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[5].Value; }
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the ControlCloneQat class.
    /// </summary>
    public ControlCloneQat():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlCloneQat>(deep);

}
/// <summary>
/// <para>Defines the SharedControlsQatItems Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:sharedControls.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneQat &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>Separator &lt;mso14:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SharedControlsQatItems : QatItemsType
{
    internal const int ElementTypeIdConst = 13150;
    /// <inheritdoc/>
    public override string LocalName => "sharedControls";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the SharedControlsQatItems class.
    /// </summary>
    public SharedControlsQatItems():base(){}
        /// <summary>
    ///Initializes a new instance of the SharedControlsQatItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedControlsQatItems(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedControlsQatItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedControlsQatItems(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedControlsQatItems class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SharedControlsQatItems(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedControlsQatItems>(deep);

}
/// <summary>
/// <para>Defines the DocumentControlsQatItems Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:documentControls.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneQat &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>Separator &lt;mso14:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DocumentControlsQatItems : QatItemsType
{
    internal const int ElementTypeIdConst = 13151;
    /// <inheritdoc/>
    public override string LocalName => "documentControls";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the DocumentControlsQatItems class.
    /// </summary>
    public DocumentControlsQatItems():base(){}
        /// <summary>
    ///Initializes a new instance of the DocumentControlsQatItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocumentControlsQatItems(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DocumentControlsQatItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocumentControlsQatItems(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DocumentControlsQatItems class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DocumentControlsQatItems(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentControlsQatItems>(deep);

}
/// <summary>
/// Defines the QatItemsType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneQat &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>Separator &lt;mso14:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlCloneQat), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Separator), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class QatItemsType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneQat();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "separator" == name)
    return new Separator();
    

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
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:tab.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Group &lt;mso14:group></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Group), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Tab : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13152;
    /// <inheritdoc/>
    public override string LocalName => "tab";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "group" == name)
    return new Group();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tab>(deep);

}
/// <summary>
/// <para>Defines the TabSet Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:tabSet.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Tab &lt;mso14:tab></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Tab), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TabSet : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13153;
    /// <inheritdoc/>
    public override string LocalName => "tabSet";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
    /// Initializes a new instance of the TabSet class.
    /// </summary>
    public TabSet():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TabSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TabSet(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TabSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TabSet(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TabSet class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TabSet(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "tab" == name)
    return new Tab();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabSet>(deep);

}
/// <summary>
/// <para>Defines the Command Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:command.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Command : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13154;
    /// <inheritdoc/>
    public override string LocalName => "command";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
    /// Initializes a new instance of the Command class.
    /// </summary>
    public Command():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Command>(deep);

}
/// <summary>
/// <para>Defines the QuickAccessToolbar Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:qat.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SharedControlsQatItems &lt;mso14:sharedControls></description></item>
///<item><description>DocumentControlsQatItems &lt;mso14:documentControls></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SharedControlsQatItems), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentControlsQatItems), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class QuickAccessToolbar : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13155;
    /// <inheritdoc/>
    public override string LocalName => "qat";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
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
    if( 57 == namespaceId && "sharedControls" == name)
    return new SharedControlsQatItems();
    
if( 57 == namespaceId && "documentControls" == name)
    return new DocumentControlsQatItems();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sharedControls","documentControls" };
    private static readonly byte[] eleNamespaceIds = { 57,57 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SharedControlsQatItems.</para>
    /// <para> Represents the following element tag in the schema: mso14:sharedControls </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public SharedControlsQatItems SharedControlsQatItems
    {
        get => GetElement<SharedControlsQatItems>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> DocumentControlsQatItems.</para>
    /// <para> Represents the following element tag in the schema: mso14:documentControls </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public DocumentControlsQatItems DocumentControlsQatItems
    {
        get => GetElement<DocumentControlsQatItems>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuickAccessToolbar>(deep);

}
/// <summary>
/// <para>Defines the Tabs Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:tabs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Tab &lt;mso14:tab></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Tab), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Tabs : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13156;
    /// <inheritdoc/>
    public override string LocalName => "tabs";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
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
    if( 57 == namespaceId && "tab" == name)
    return new Tab();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tabs>(deep);

}
/// <summary>
/// <para>Defines the ContextualTabs Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:contextualTabs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TabSet &lt;mso14:tabSet></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TabSet), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContextualTabs : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13157;
    /// <inheritdoc/>
    public override string LocalName => "contextualTabs";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabs class.
    /// </summary>
    public ContextualTabs():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ContextualTabs class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabs(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabs class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabs(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabs class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextualTabs(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "tabSet" == name)
    return new TabSet();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualTabs>(deep);

}
/// <summary>
/// <para>Defines the ContextMenu Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:contextMenu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
///<item><description>MenuSeparatorNoTitle &lt;mso14:menuSeparator></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlCloneRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(CheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GalleryRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ToggleButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SplitButtonRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DynamicMenuRegular), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MenuSeparatorNoTitle), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContextMenu : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13158;
    /// <inheritdoc/>
    public override string LocalName => "contextMenu";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "idMso")
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
    /// Initializes a new instance of the ContextMenu class.
    /// </summary>
    public ContextMenu():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ContextMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextMenu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextMenu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextMenu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextMenu(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonRegular();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    
if( 57 == namespaceId && "menuSeparator" == name)
    return new MenuSeparatorNoTitle();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextMenu>(deep);

}
/// <summary>
/// <para>Defines the ItemBackstageItem Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:item.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ItemBackstageItem : BackstageItemType
{
    internal const int ElementTypeIdConst = 13159;
    /// <inheritdoc/>
    public override string LocalName => "item";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the ItemBackstageItem class.
    /// </summary>
    public ItemBackstageItem():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ItemBackstageItem>(deep);

}
/// <summary>
/// <para>Defines the RadioButtonBackstageItem Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:radioButton.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RadioButtonBackstageItem : BackstageItemType
{
    internal const int ElementTypeIdConst = 13160;
    /// <inheritdoc/>
    public override string LocalName => "radioButton";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the RadioButtonBackstageItem class.
    /// </summary>
    public RadioButtonBackstageItem():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadioButtonBackstageItem>(deep);

}
/// <summary>
/// Defines the BackstageItemType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class BackstageItemType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel")
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
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BackstageItemType class.
    /// </summary>
    protected BackstageItemType(){}
    
    
    
}
/// <summary>
/// <para>Defines the BackstageRegularButton Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageRegularButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13161;
    /// <inheritdoc/>
    public override string LocalName => "button";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "isDefinitive"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
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
    public StringValue QualifiedId
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> isDefinitive.</para>
    /// <para>Represents the following attribute in the schema: isDefinitive </para>
    /// </summary>
    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
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
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageRegularButton class.
    /// </summary>
    public BackstageRegularButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageRegularButton>(deep);

}
/// <summary>
/// <para>Defines the BackstagePrimaryMenu Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageMenuGroup &lt;mso14:menuGroup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackstageMenuGroup), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstagePrimaryMenu : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13162;
    /// <inheritdoc/>
    public override string LocalName => "menu";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "screentip"),
		AttributeTag.Create<StringValue>(0, "getScreentip"),
		AttributeTag.Create<StringValue>(0, "supertip"),
		AttributeTag.Create<StringValue>(0, "getSupertip"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
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
    public StringValue QualifiedId
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
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstagePrimaryMenu class.
    /// </summary>
    public BackstagePrimaryMenu():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BackstagePrimaryMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstagePrimaryMenu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstagePrimaryMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstagePrimaryMenu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstagePrimaryMenu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstagePrimaryMenu(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "menuGroup" == name)
    return new BackstageMenuGroup();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstagePrimaryMenu>(deep);

}
/// <summary>
/// <para>Defines the BackstageMenuGroup Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menuGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageMenuButton &lt;mso14:button></description></item>
///<item><description>BackstageMenuCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageSubMenu &lt;mso14:menu></description></item>
///<item><description>BackstageMenuToggleButton &lt;mso14:toggleButton></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackstageMenuButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageMenuCheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageSubMenu), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageMenuToggleButton), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageMenuGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13163;
    /// <inheritdoc/>
    public override string LocalName => "menuGroup";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>(0, "itemSize")
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
    public StringValue QualifiedId
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
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageMenuGroup class.
    /// </summary>
    public BackstageMenuGroup():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BackstageMenuGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageMenuGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageMenuGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageMenuGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageMenuGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageMenuGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new BackstageMenuButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new BackstageMenuCheckBox();
    
if( 57 == namespaceId && "menu" == name)
    return new BackstageSubMenu();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new BackstageMenuToggleButton();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuGroup>(deep);

}
/// <summary>
/// <para>Defines the PrimaryItem Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:primaryItem.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageRegularButton &lt;mso14:button></description></item>
///<item><description>BackstagePrimaryMenu &lt;mso14:menu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackstageRegularButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstagePrimaryMenu), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PrimaryItem : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13164;
    /// <inheritdoc/>
    public override string LocalName => "primaryItem";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PrimaryItem class.
    /// </summary>
    public PrimaryItem():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PrimaryItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PrimaryItem(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PrimaryItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PrimaryItem(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PrimaryItem class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PrimaryItem(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new BackstageRegularButton();
    
if( 57 == namespaceId && "menu" == name)
    return new BackstagePrimaryMenu();
    

    return null;
}

        private static readonly string[] eleTagNames = { "button","menu" };
    private static readonly byte[] eleNamespaceIds = { 57,57 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> BackstageRegularButton.</para>
    /// <para> Represents the following element tag in the schema: mso14:button </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public BackstageRegularButton BackstageRegularButton
    {
        get => GetElement<BackstageRegularButton>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> BackstagePrimaryMenu.</para>
    /// <para> Represents the following element tag in the schema: mso14:menu </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public BackstagePrimaryMenu BackstagePrimaryMenu
    {
        get => GetElement<BackstagePrimaryMenu>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrimaryItem>(deep);

}
/// <summary>
/// <para>Defines the TopItemsGroupControls Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:topItems.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroupButton &lt;mso14:button></description></item>
///<item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageEditBox &lt;mso14:editBox></description></item>
///<item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
///<item><description>RadioGroup &lt;mso14:radioGroup></description></item>
///<item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
///<item><description>Hyperlink &lt;mso14:hyperlink></description></item>
///<item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
///<item><description>GroupBox &lt;mso14:groupBox></description></item>
///<item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
///<item><description>ImageControl &lt;mso14:imageControl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TopItemsGroupControls : GroupControlsType
{
    internal const int ElementTypeIdConst = 13165;
    /// <inheritdoc/>
    public override string LocalName => "topItems";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the TopItemsGroupControls class.
    /// </summary>
    public TopItemsGroupControls():base(){}
        /// <summary>
    ///Initializes a new instance of the TopItemsGroupControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TopItemsGroupControls(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TopItemsGroupControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TopItemsGroupControls(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TopItemsGroupControls class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TopItemsGroupControls(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TopItemsGroupControls>(deep);

}
/// <summary>
/// <para>Defines the BottomItemsGroupControls Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:bottomItems.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroupButton &lt;mso14:button></description></item>
///<item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageEditBox &lt;mso14:editBox></description></item>
///<item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
///<item><description>RadioGroup &lt;mso14:radioGroup></description></item>
///<item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
///<item><description>Hyperlink &lt;mso14:hyperlink></description></item>
///<item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
///<item><description>GroupBox &lt;mso14:groupBox></description></item>
///<item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
///<item><description>ImageControl &lt;mso14:imageControl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BottomItemsGroupControls : GroupControlsType
{
    internal const int ElementTypeIdConst = 13166;
    /// <inheritdoc/>
    public override string LocalName => "bottomItems";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the BottomItemsGroupControls class.
    /// </summary>
    public BottomItemsGroupControls():base(){}
        /// <summary>
    ///Initializes a new instance of the BottomItemsGroupControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BottomItemsGroupControls(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BottomItemsGroupControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BottomItemsGroupControls(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BottomItemsGroupControls class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BottomItemsGroupControls(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BottomItemsGroupControls>(deep);

}
/// <summary>
/// Defines the GroupControlsType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroupButton &lt;mso14:button></description></item>
///<item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageEditBox &lt;mso14:editBox></description></item>
///<item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
///<item><description>RadioGroup &lt;mso14:radioGroup></description></item>
///<item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
///<item><description>Hyperlink &lt;mso14:hyperlink></description></item>
///<item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
///<item><description>GroupBox &lt;mso14:groupBox></description></item>
///<item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
///<item><description>ImageControl &lt;mso14:imageControl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageGroupButton), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageCheckBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageEditBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageDropDown), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(RadioGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageComboBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Hyperlink), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageLabelControl), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GroupBox), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LayoutContainer), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ImageControl), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class GroupControlsType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new BackstageGroupButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new BackstageCheckBox();
    
if( 57 == namespaceId && "editBox" == name)
    return new BackstageEditBox();
    
if( 57 == namespaceId && "dropDown" == name)
    return new BackstageDropDown();
    
if( 57 == namespaceId && "radioGroup" == name)
    return new RadioGroup();
    
if( 57 == namespaceId && "comboBox" == name)
    return new BackstageComboBox();
    
if( 57 == namespaceId && "hyperlink" == name)
    return new Hyperlink();
    
if( 57 == namespaceId && "labelControl" == name)
    return new BackstageLabelControl();
    
if( 57 == namespaceId && "groupBox" == name)
    return new GroupBox();
    
if( 57 == namespaceId && "layoutContainer" == name)
    return new LayoutContainer();
    
if( 57 == namespaceId && "imageControl" == name)
    return new ImageControl();
    

    return null;
}

    
    
    /// <summary>
    /// Initializes a new instance of the GroupControlsType class.
    /// </summary>
    protected GroupControlsType(){}
    
        /// <summary>
    ///Initializes a new instance of the GroupControlsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected GroupControlsType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupControlsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected GroupControlsType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupControlsType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected GroupControlsType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the TaskGroupCategory Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:category.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TaskGroupTask &lt;mso14:task></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TaskGroupTask), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskGroupCategory : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13167;
    /// <inheritdoc/>
    public override string LocalName => "category";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel")
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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
    /// Initializes a new instance of the TaskGroupCategory class.
    /// </summary>
    public TaskGroupCategory():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TaskGroupCategory class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskGroupCategory(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskGroupCategory class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskGroupCategory(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskGroupCategory class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TaskGroupCategory(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "task" == name)
    return new TaskGroupTask();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskGroupCategory>(deep);

}
/// <summary>
/// <para>Defines the TaskGroupTask Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:task.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskGroupTask : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13168;
    /// <inheritdoc/>
    public override string LocalName => "task";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "isDefinitive"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> isDefinitive.</para>
    /// <para>Represents the following attribute in the schema: isDefinitive </para>
    /// </summary>
    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
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
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
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
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TaskGroupTask class.
    /// </summary>
    public TaskGroupTask():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskGroupTask>(deep);

}
/// <summary>
/// <para>Defines the TaskFormGroupCategory Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:category.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TaskFormGroupTask &lt;mso14:task></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TaskFormGroupTask), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskFormGroupCategory : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13169;
    /// <inheritdoc/>
    public override string LocalName => "category";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel")
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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
    /// Initializes a new instance of the TaskFormGroupCategory class.
    /// </summary>
    public TaskFormGroupCategory():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TaskFormGroupCategory class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroupCategory(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroupCategory class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroupCategory(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroupCategory class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TaskFormGroupCategory(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "task" == name)
    return new TaskFormGroupTask();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskFormGroupCategory>(deep);

}
/// <summary>
/// <para>Defines the TaskFormGroupTask Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:task.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroup &lt;mso14:group></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackstageGroup), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskFormGroupTask : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13170;
    /// <inheritdoc/>
    public override string LocalName => "task";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "getDescription"),
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
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
    /// Initializes a new instance of the TaskFormGroupTask class.
    /// </summary>
    public TaskFormGroupTask():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TaskFormGroupTask class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroupTask(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroupTask class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroupTask(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroupTask class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TaskFormGroupTask(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "group" == name)
    return new BackstageGroup();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskFormGroupTask>(deep);

}
/// <summary>
/// <para>Defines the TaskFormGroup Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:taskFormGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TaskFormGroupCategory &lt;mso14:category></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TaskFormGroupCategory), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskFormGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13171;
    /// <inheritdoc/>
    public override string LocalName => "taskFormGroup";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "helperText"),
		AttributeTag.Create<StringValue>(0, "getHelperText"),
		AttributeTag.Create<BooleanValue>(0, "showLabel"),
		AttributeTag.Create<StringValue>(0, "getShowLabel"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>>(0, "allowedTaskSizes")
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
    public StringValue QualifiedId
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> helperText.</para>
    /// <para>Represents the following attribute in the schema: helperText </para>
    /// </summary>
    [SchemaAttr(0, "helperText")]
    public StringValue HelperText
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> getHelperText.</para>
    /// <para>Represents the following attribute in the schema: getHelperText </para>
    /// </summary>
    [SchemaAttr(0, "getHelperText")]
    public StringValue GetHelperText
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> allowedTaskSizes.</para>
    /// <para>Represents the following attribute in the schema: allowedTaskSizes </para>
    /// </summary>
    [SchemaAttr(0, "allowedTaskSizes")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues> AllowedTaskSizes
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TaskFormGroup class.
    /// </summary>
    public TaskFormGroup():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TaskFormGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TaskFormGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "category" == name)
    return new TaskFormGroupCategory();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskFormGroup>(deep);

}
/// <summary>
/// <para>Defines the BackstageGroups Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:firstColumn.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TaskFormGroup &lt;mso14:taskFormGroup></description></item>
///<item><description>BackstageGroup &lt;mso14:group></description></item>
///<item><description>TaskGroup &lt;mso14:taskGroup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TaskFormGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TaskGroup), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageGroups : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13172;
    /// <inheritdoc/>
    public override string LocalName => "firstColumn";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BackstageGroups class.
    /// </summary>
    public BackstageGroups():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BackstageGroups class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageGroups(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageGroups class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageGroups(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageGroups class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageGroups(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "taskFormGroup" == name)
    return new TaskFormGroup();
    
if( 57 == namespaceId && "group" == name)
    return new BackstageGroup();
    
if( 57 == namespaceId && "taskGroup" == name)
    return new TaskGroup();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageGroups>(deep);

}
/// <summary>
/// <para>Defines the SimpleGroups Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:secondColumn.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroup &lt;mso14:group></description></item>
///<item><description>TaskGroup &lt;mso14:taskGroup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackstageGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TaskGroup), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SimpleGroups : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13173;
    /// <inheritdoc/>
    public override string LocalName => "secondColumn";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SimpleGroups class.
    /// </summary>
    public SimpleGroups():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SimpleGroups class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SimpleGroups(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SimpleGroups class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SimpleGroups(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SimpleGroups class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SimpleGroups(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "group" == name)
    return new BackstageGroup();
    
if( 57 == namespaceId && "taskGroup" == name)
    return new TaskGroup();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SimpleGroups>(deep);

}
/// <summary>
/// <para>Defines the BackstageTab Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:tab.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroups &lt;mso14:firstColumn></description></item>
///<item><description>SimpleGroups &lt;mso14:secondColumn></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackstageGroups), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SimpleGroups), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageTab : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13174;
    /// <inheritdoc/>
    public override string LocalName => "tab";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "getTitle"),
		AttributeTag.Create<IntegerValue>(0, "columnWidthPercent"),
		AttributeTag.Create<IntegerValue>(0, "firstColumnMinWidth"),
		AttributeTag.Create<IntegerValue>(0, "firstColumnMaxWidth"),
		AttributeTag.Create<IntegerValue>(0, "secondColumnMinWidth"),
		AttributeTag.Create<IntegerValue>(0, "secondColumnMaxWidth")
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> columnWidthPercent.</para>
    /// <para>Represents the following attribute in the schema: columnWidthPercent </para>
    /// </summary>
    [SchemaAttr(0, "columnWidthPercent")]
    public IntegerValue ColumnWidthPercent
    {
        get { return (IntegerValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> firstColumnMinWidth.</para>
    /// <para>Represents the following attribute in the schema: firstColumnMinWidth </para>
    /// </summary>
    [SchemaAttr(0, "firstColumnMinWidth")]
    public IntegerValue FirstColumnMinWidth
    {
        get { return (IntegerValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> firstColumnMaxWidth.</para>
    /// <para>Represents the following attribute in the schema: firstColumnMaxWidth </para>
    /// </summary>
    [SchemaAttr(0, "firstColumnMaxWidth")]
    public IntegerValue FirstColumnMaxWidth
    {
        get { return (IntegerValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> secondColumnMinWidth.</para>
    /// <para>Represents the following attribute in the schema: secondColumnMinWidth </para>
    /// </summary>
    [SchemaAttr(0, "secondColumnMinWidth")]
    public IntegerValue SecondColumnMinWidth
    {
        get { return (IntegerValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> secondColumnMaxWidth.</para>
    /// <para>Represents the following attribute in the schema: secondColumnMaxWidth </para>
    /// </summary>
    [SchemaAttr(0, "secondColumnMaxWidth")]
    public IntegerValue SecondColumnMaxWidth
    {
        get { return (IntegerValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageTab class.
    /// </summary>
    public BackstageTab():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BackstageTab class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageTab(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageTab class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageTab(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageTab class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageTab(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "firstColumn" == name)
    return new BackstageGroups();
    
if( 57 == namespaceId && "secondColumn" == name)
    return new SimpleGroups();
    

    return null;
}

        private static readonly string[] eleTagNames = { "firstColumn","secondColumn" };
    private static readonly byte[] eleNamespaceIds = { 57,57 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> BackstageGroups.</para>
    /// <para> Represents the following element tag in the schema: mso14:firstColumn </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public BackstageGroups BackstageGroups
    {
        get => GetElement<BackstageGroups>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> SimpleGroups.</para>
    /// <para> Represents the following element tag in the schema: mso14:secondColumn </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public SimpleGroups SimpleGroups
    {
        get => GetElement<SimpleGroups>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageTab>(deep);

}
/// <summary>
/// <para>Defines the BackstageFastCommandButton Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageFastCommandButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13175;
    /// <inheritdoc/>
    public override string LocalName => "button";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "idMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterMso"),
		AttributeTag.Create<StringValue>(0, "insertBeforeMso"),
		AttributeTag.Create<StringValue>(0, "insertAfterQ"),
		AttributeTag.Create<StringValue>(0, "insertBeforeQ"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "idQ"),
		AttributeTag.Create<StringValue>(0, "tag"),
		AttributeTag.Create<StringValue>(0, "onAction"),
		AttributeTag.Create<BooleanValue>(0, "isDefinitive"),
		AttributeTag.Create<BooleanValue>(0, "enabled"),
		AttributeTag.Create<StringValue>(0, "getEnabled"),
		AttributeTag.Create<StringValue>(0, "label"),
		AttributeTag.Create<StringValue>(0, "getLabel"),
		AttributeTag.Create<BooleanValue>(0, "visible"),
		AttributeTag.Create<StringValue>(0, "getVisible"),
		AttributeTag.Create<StringValue>(0, "keytip"),
		AttributeTag.Create<StringValue>(0, "getKeytip"),
		AttributeTag.Create<StringValue>(0, "image"),
		AttributeTag.Create<StringValue>(0, "imageMso"),
		AttributeTag.Create<StringValue>(0, "getImage")
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
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    public StringValue QualifiedId
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> isDefinitive.</para>
    /// <para>Represents the following attribute in the schema: isDefinitive </para>
    /// </summary>
    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
    {
        get { return (BooleanValue)Attributes[9].Value; }
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageFastCommandButton class.
    /// </summary>
    public BackstageFastCommandButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageFastCommandButton>(deep);

}
/// <summary>
/// <para>Defines the Commands Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:commands.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Command &lt;mso14:command></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Command), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Commands : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13176;
    /// <inheritdoc/>
    public override string LocalName => "commands";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Commands class.
    /// </summary>
    public Commands():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Commands class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Commands(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Commands class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Commands(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Commands class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Commands(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "command" == name)
    return new Command();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Commands>(deep);

}
/// <summary>
/// <para>Defines the Ribbon Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:ribbon.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuickAccessToolbar &lt;mso14:qat></description></item>
///<item><description>Tabs &lt;mso14:tabs></description></item>
///<item><description>ContextualTabs &lt;mso14:contextualTabs></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(QuickAccessToolbar), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Tabs), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ContextualTabs), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Ribbon : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13177;
    /// <inheritdoc/>
    public override string LocalName => "ribbon";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
    if( 57 == namespaceId && "qat" == name)
    return new QuickAccessToolbar();
    
if( 57 == namespaceId && "tabs" == name)
    return new Tabs();
    
if( 57 == namespaceId && "contextualTabs" == name)
    return new ContextualTabs();
    

    return null;
}

        private static readonly string[] eleTagNames = { "qat","tabs","contextualTabs" };
    private static readonly byte[] eleNamespaceIds = { 57,57,57 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneAll;
    
        /// <summary>
    /// <para> QuickAccessToolbar.</para>
    /// <para> Represents the following element tag in the schema: mso14:qat </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public QuickAccessToolbar QuickAccessToolbar
    {
        get => GetElement<QuickAccessToolbar>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Tabs.</para>
    /// <para> Represents the following element tag in the schema: mso14:tabs </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public Tabs Tabs
    {
        get => GetElement<Tabs>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ContextualTabs.</para>
    /// <para> Represents the following element tag in the schema: mso14:contextualTabs </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public ContextualTabs ContextualTabs
    {
        get => GetElement<ContextualTabs>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ribbon>(deep);

}
/// <summary>
/// <para>Defines the Backstage Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:backstage.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageTab &lt;mso14:tab></description></item>
///<item><description>BackstageFastCommandButton &lt;mso14:button></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackstageTab), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackstageFastCommandButton), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Backstage : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13178;
    /// <inheritdoc/>
    public override string LocalName => "backstage";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "onShow"),
		AttributeTag.Create<StringValue>(0, "onHide")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> onShow.</para>
    /// <para>Represents the following attribute in the schema: onShow </para>
    /// </summary>
    [SchemaAttr(0, "onShow")]
    public StringValue OnShow
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> onHide.</para>
    /// <para>Represents the following attribute in the schema: onHide </para>
    /// </summary>
    [SchemaAttr(0, "onHide")]
    public StringValue OnHide
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Backstage class.
    /// </summary>
    public Backstage():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Backstage class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Backstage(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Backstage class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Backstage(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Backstage class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Backstage(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "tab" == name)
    return new BackstageTab();
    
if( 57 == namespaceId && "button" == name)
    return new BackstageFastCommandButton();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Backstage>(deep);

}
/// <summary>
/// <para>Defines the ContextMenus Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:contextMenus.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ContextMenu &lt;mso14:contextMenu></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ContextMenu), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContextMenus : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13179;
    /// <inheritdoc/>
    public override string LocalName => "contextMenus";
    
    internal override byte NamespaceId => 57;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ContextMenus class.
    /// </summary>
    public ContextMenus():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ContextMenus class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextMenus(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextMenus class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextMenus(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextMenus class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextMenus(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "contextMenu" == name)
    return new ContextMenu();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextMenus>(deep);

}
/// <summary>
/// Defines the GalleryShowInRibbonValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum GalleryShowInRibbonValues
{  
	///<summary>
///false.
///<para>When the item is serialized out as xml, its value is "false".</para>
///</summary>
[EnumString("false")]
False,
///<summary>
///0.
///<para>When the item is serialized out as xml, its value is "0".</para>
///</summary>
[EnumString("0")]
Zero,
 
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
/// <summary>
/// Defines the TaskSizesValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TaskSizesValues
{  
	///<summary>
///largeMediumSmall.
///<para>When the item is serialized out as xml, its value is "largeMediumSmall".</para>
///</summary>
[EnumString("largeMediumSmall")]
LargeMediumSmall,
///<summary>
///largeMedium.
///<para>When the item is serialized out as xml, its value is "largeMedium".</para>
///</summary>
[EnumString("largeMedium")]
LargeMedium,
///<summary>
///large.
///<para>When the item is serialized out as xml, its value is "large".</para>
///</summary>
[EnumString("large")]
Large,
///<summary>
///mediumSmall.
///<para>When the item is serialized out as xml, its value is "mediumSmall".</para>
///</summary>
[EnumString("mediumSmall")]
MediumSmall,
///<summary>
///medium.
///<para>When the item is serialized out as xml, its value is "medium".</para>
///</summary>
[EnumString("medium")]
Medium,
///<summary>
///small.
///<para>When the item is serialized out as xml, its value is "small".</para>
///</summary>
[EnumString("small")]
Small,
 
}
/// <summary>
/// Defines the ExpandValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ExpandValues
{  
	///<summary>
///topLeft.
///<para>When the item is serialized out as xml, its value is "topLeft".</para>
///</summary>
[EnumString("topLeft")]
TopLeft,
///<summary>
///top.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///topRight.
///<para>When the item is serialized out as xml, its value is "topRight".</para>
///</summary>
[EnumString("topRight")]
TopRight,
///<summary>
///left.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///center.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///right.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,
///<summary>
///bottomLeft.
///<para>When the item is serialized out as xml, its value is "bottomLeft".</para>
///</summary>
[EnumString("bottomLeft")]
BottomLeft,
///<summary>
///bottom.
///<para>When the item is serialized out as xml, its value is "bottom".</para>
///</summary>
[EnumString("bottom")]
Bottom,
///<summary>
///bottomRight.
///<para>When the item is serialized out as xml, its value is "bottomRight".</para>
///</summary>
[EnumString("bottomRight")]
BottomRight,
 
}
/// <summary>
/// Defines the StyleValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StyleValues
{  
	///<summary>
///normal.
///<para>When the item is serialized out as xml, its value is "normal".</para>
///</summary>
[EnumString("normal")]
Normal,
///<summary>
///warning.
///<para>When the item is serialized out as xml, its value is "warning".</para>
///</summary>
[EnumString("warning")]
Warning,
///<summary>
///error.
///<para>When the item is serialized out as xml, its value is "error".</para>
///</summary>
[EnumString("error")]
Error,
 
}
/// <summary>
/// Defines the Style2Values enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum Style2Values
{  
	///<summary>
///normal.
///<para>When the item is serialized out as xml, its value is "normal".</para>
///</summary>
[EnumString("normal")]
Normal,
///<summary>
///borderless.
///<para>When the item is serialized out as xml, its value is "borderless".</para>
///</summary>
[EnumString("borderless")]
Borderless,
///<summary>
///large.
///<para>When the item is serialized out as xml, its value is "large".</para>
///</summary>
[EnumString("large")]
Large,
 
}
/// <summary>
/// Defines the LayoutChildrenValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LayoutChildrenValues
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
 
 
