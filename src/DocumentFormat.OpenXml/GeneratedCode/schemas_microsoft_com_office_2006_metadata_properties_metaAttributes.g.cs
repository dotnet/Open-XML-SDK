// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.MetaAttributes
{
/// <summary>
/// <para>Defines the Dummy Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ma:DummyContentTypeElement.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Dummy : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12713;
    /// <inheritdoc/>
    public override string LocalName => "DummyContentTypeElement";
    
    internal override byte NamespaceId => 41;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "decimals"),
		AttributeTag.Create<StringValue>(0, "default"),
		AttributeTag.Create<StringValue>(0, "description"),
		AttributeTag.Create<StringValue>(0, "displayName"),
		AttributeTag.Create<StringValue>(0, "fieldsID"),
		AttributeTag.Create<StringValue>(0, "format"),
		AttributeTag.Create<StringValue>(0, "hidden"),
		AttributeTag.Create<Int32Value>(0, "index"),
		AttributeTag.Create<StringValue>(0, "internalName"),
		AttributeTag.Create<Int32Value>(0, "LCID"),
		AttributeTag.Create<StringValue>(0, "list"),
		AttributeTag.Create<StringValue>(0, "percentage"),
		AttributeTag.Create<StringValue>(0, "readOnly"),
		AttributeTag.Create<StringValue>(0, "requiredMultiChoice"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues>>(0, "root"),
		AttributeTag.Create<StringValue>(0, "showField"),
		AttributeTag.Create<StringValue>(0, "web")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> decimals.</para>
    /// <para>Represents the following attribute in the schema: decimals </para>
    /// </summary>
    [SchemaAttr(0, "decimals")]
    public StringValue Decimals
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> default.</para>
    /// <para>Represents the following attribute in the schema: default </para>
    /// </summary>
    [SchemaAttr(0, "default")]
    public StringValue Default
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
    /// <para> displayName.</para>
    /// <para>Represents the following attribute in the schema: displayName </para>
    /// </summary>
    [SchemaAttr(0, "displayName")]
    public StringValue DisplayName
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> fieldsID.</para>
    /// <para>Represents the following attribute in the schema: fieldsID </para>
    /// </summary>
    [SchemaAttr(0, "fieldsID")]
    public StringValue FieldsID
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> format.</para>
    /// <para>Represents the following attribute in the schema: format </para>
    /// </summary>
    [SchemaAttr(0, "format")]
    public StringValue Format
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public StringValue Hidden
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> index.</para>
    /// <para>Represents the following attribute in the schema: index </para>
    /// </summary>
    [SchemaAttr(0, "index")]
    public Int32Value Index
    {
        get { return (Int32Value)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> internalName.</para>
    /// <para>Represents the following attribute in the schema: internalName </para>
    /// </summary>
    [SchemaAttr(0, "internalName")]
    public StringValue InternalName
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> LCID.</para>
    /// <para>Represents the following attribute in the schema: LCID </para>
    /// </summary>
    [SchemaAttr(0, "LCID")]
    public Int32Value LCID
    {
        get { return (Int32Value)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> list.</para>
    /// <para>Represents the following attribute in the schema: list </para>
    /// </summary>
    [SchemaAttr(0, "list")]
    public StringValue List
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> percentage.</para>
    /// <para>Represents the following attribute in the schema: percentage </para>
    /// </summary>
    [SchemaAttr(0, "percentage")]
    public StringValue Percentage
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> readOnly.</para>
    /// <para>Represents the following attribute in the schema: readOnly </para>
    /// </summary>
    [SchemaAttr(0, "readOnly")]
    public StringValue ReadOnly
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> requiredMultiChoice.</para>
    /// <para>Represents the following attribute in the schema: requiredMultiChoice </para>
    /// </summary>
    [SchemaAttr(0, "requiredMultiChoice")]
    public StringValue RequiredMultiChoice
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> root.</para>
    /// <para>Represents the following attribute in the schema: root </para>
    /// </summary>
    [SchemaAttr(0, "root")]
    public EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues> Root
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues>)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> showField.</para>
    /// <para>Represents the following attribute in the schema: showField </para>
    /// </summary>
    [SchemaAttr(0, "showField")]
    public StringValue ShowField
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> web.</para>
    /// <para>Represents the following attribute in the schema: web </para>
    /// </summary>
    [SchemaAttr(0, "web")]
    public StringValue Web
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Dummy class.
    /// </summary>
    public Dummy():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Dummy>(deep);

}
/// <summary>
/// Defines the TrueOnlyValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TrueOnlyValues
{  
	///<summary>
///true.
///<para>When the item is serialized out as xml, its value is "true".</para>
///</summary>
[EnumString("true")]
True,
 
}
}
 
 
