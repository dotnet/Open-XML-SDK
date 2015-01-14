// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.MetaAttributes
{
/// <summary>
/// <para>Defines the Dummy Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ma:DummyContentTypeElement.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Dummy : OpenXmlLeafElement
{
    private const string tagName = "DummyContentTypeElement";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 41;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12713;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "decimals","default","description","displayName","fieldsID","format","hidden","index","internalName","LCID","list","percentage","readOnly","requiredMultiChoice","root","showField","web" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> decimals.</para>
    /// <para>Represents the following attribute in the schema: decimals </para>
    /// </summary>
    [SchemaAttr(0, "decimals")]
    public StringValue Decimals
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> default.</para>
    /// <para>Represents the following attribute in the schema: default </para>
    /// </summary>
    [SchemaAttr(0, "default")]
    public StringValue Default
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> displayName.</para>
    /// <para>Represents the following attribute in the schema: displayName </para>
    /// </summary>
    [SchemaAttr(0, "displayName")]
    public StringValue DisplayName
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> fieldsID.</para>
    /// <para>Represents the following attribute in the schema: fieldsID </para>
    /// </summary>
    [SchemaAttr(0, "fieldsID")]
    public StringValue FieldsID
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> format.</para>
    /// <para>Represents the following attribute in the schema: format </para>
    /// </summary>
    [SchemaAttr(0, "format")]
    public StringValue Format
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public StringValue Hidden
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> index.</para>
    /// <para>Represents the following attribute in the schema: index </para>
    /// </summary>
    [SchemaAttr(0, "index")]
    public Int32Value Index
    {
        get { return (Int32Value)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> internalName.</para>
    /// <para>Represents the following attribute in the schema: internalName </para>
    /// </summary>
    [SchemaAttr(0, "internalName")]
    public StringValue InternalName
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> LCID.</para>
    /// <para>Represents the following attribute in the schema: LCID </para>
    /// </summary>
    [SchemaAttr(0, "LCID")]
    public Int32Value LCID
    {
        get { return (Int32Value)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> list.</para>
    /// <para>Represents the following attribute in the schema: list </para>
    /// </summary>
    [SchemaAttr(0, "list")]
    public StringValue List
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> percentage.</para>
    /// <para>Represents the following attribute in the schema: percentage </para>
    /// </summary>
    [SchemaAttr(0, "percentage")]
    public StringValue Percentage
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> readOnly.</para>
    /// <para>Represents the following attribute in the schema: readOnly </para>
    /// </summary>
    [SchemaAttr(0, "readOnly")]
    public StringValue ReadOnly
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> requiredMultiChoice.</para>
    /// <para>Represents the following attribute in the schema: requiredMultiChoice </para>
    /// </summary>
    [SchemaAttr(0, "requiredMultiChoice")]
    public StringValue RequiredMultiChoice
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> root.</para>
    /// <para>Represents the following attribute in the schema: root </para>
    /// </summary>
    [SchemaAttr(0, "root")]
    public EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues> Root
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues>)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> showField.</para>
    /// <para>Represents the following attribute in the schema: showField </para>
    /// </summary>
    [SchemaAttr(0, "showField")]
    public StringValue ShowField
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> web.</para>
    /// <para>Represents the following attribute in the schema: web </para>
    /// </summary>
    [SchemaAttr(0, "web")]
    public StringValue Web
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Dummy class.
    /// </summary>
    public Dummy():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "decimals" == name)
    return new StringValue();
    
if( 0 == namespaceId && "default" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "displayName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "fieldsID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "format" == name)
    return new StringValue();
    
if( 0 == namespaceId && "hidden" == name)
    return new StringValue();
    
if( 0 == namespaceId && "index" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "internalName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "LCID" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "list" == name)
    return new StringValue();
    
if( 0 == namespaceId && "percentage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "readOnly" == name)
    return new StringValue();
    
if( 0 == namespaceId && "requiredMultiChoice" == name)
    return new StringValue();
    
if( 0 == namespaceId && "root" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues>();
    
if( 0 == namespaceId && "showField" == name)
    return new StringValue();
    
if( 0 == namespaceId && "web" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Dummy>(deep);
    }

   
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
 
 
