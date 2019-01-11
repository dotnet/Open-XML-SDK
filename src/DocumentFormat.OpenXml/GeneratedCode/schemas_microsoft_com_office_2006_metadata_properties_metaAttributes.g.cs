﻿// Copyright (c) Microsoft. All rights reserved.
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

    
    
        /// <summary>
    /// <para> decimals.</para>
    /// <para>Represents the following attribute in the schema: decimals </para>
    /// </summary>
    [SchemaAttr(0, "decimals")]
    [SchemaIndex(0)]
    public StringValue Decimals { get; set; }
    /// <summary>
    /// <para> default.</para>
    /// <para>Represents the following attribute in the schema: default </para>
    /// </summary>
    [SchemaAttr(0, "default")]
    [SchemaIndex(1)]
    public StringValue Default { get; set; }
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    [SchemaIndex(2)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> displayName.</para>
    /// <para>Represents the following attribute in the schema: displayName </para>
    /// </summary>
    [SchemaAttr(0, "displayName")]
    [SchemaIndex(3)]
    public StringValue DisplayName { get; set; }
    /// <summary>
    /// <para> fieldsID.</para>
    /// <para>Represents the following attribute in the schema: fieldsID </para>
    /// </summary>
    [SchemaAttr(0, "fieldsID")]
    [SchemaIndex(4)]
    public StringValue FieldsID { get; set; }
    /// <summary>
    /// <para> format.</para>
    /// <para>Represents the following attribute in the schema: format </para>
    /// </summary>
    [SchemaAttr(0, "format")]
    [SchemaIndex(5)]
    public StringValue Format { get; set; }
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    [SchemaIndex(6)]
    public StringValue Hidden { get; set; }
    /// <summary>
    /// <para> index.</para>
    /// <para>Represents the following attribute in the schema: index </para>
    /// </summary>
    [SchemaAttr(0, "index")]
    [SchemaIndex(7)]
    public Int32Value Index { get; set; }
    /// <summary>
    /// <para> internalName.</para>
    /// <para>Represents the following attribute in the schema: internalName </para>
    /// </summary>
    [SchemaAttr(0, "internalName")]
    [SchemaIndex(8)]
    public StringValue InternalName { get; set; }
    /// <summary>
    /// <para> LCID.</para>
    /// <para>Represents the following attribute in the schema: LCID </para>
    /// </summary>
    [SchemaAttr(0, "LCID")]
    [SchemaIndex(9)]
    public Int32Value LCID { get; set; }
    /// <summary>
    /// <para> list.</para>
    /// <para>Represents the following attribute in the schema: list </para>
    /// </summary>
    [SchemaAttr(0, "list")]
    [SchemaIndex(10)]
    public StringValue List { get; set; }
    /// <summary>
    /// <para> percentage.</para>
    /// <para>Represents the following attribute in the schema: percentage </para>
    /// </summary>
    [SchemaAttr(0, "percentage")]
    [SchemaIndex(11)]
    public StringValue Percentage { get; set; }
    /// <summary>
    /// <para> readOnly.</para>
    /// <para>Represents the following attribute in the schema: readOnly </para>
    /// </summary>
    [SchemaAttr(0, "readOnly")]
    [SchemaIndex(12)]
    public StringValue ReadOnly { get; set; }
    /// <summary>
    /// <para> requiredMultiChoice.</para>
    /// <para>Represents the following attribute in the schema: requiredMultiChoice </para>
    /// </summary>
    [SchemaAttr(0, "requiredMultiChoice")]
    [SchemaIndex(13)]
    public StringValue RequiredMultiChoice { get; set; }
    /// <summary>
    /// <para> root.</para>
    /// <para>Represents the following attribute in the schema: root </para>
    /// </summary>
    [SchemaAttr(0, "root")]
    [SchemaIndex(14)]
    public EnumValue<DocumentFormat.OpenXml.Office.MetaAttributes.TrueOnlyValues> Root { get; set; }
    /// <summary>
    /// <para> showField.</para>
    /// <para>Represents the following attribute in the schema: showField </para>
    /// </summary>
    [SchemaAttr(0, "showField")]
    [SchemaIndex(15)]
    public StringValue ShowField { get; set; }
    /// <summary>
    /// <para> web.</para>
    /// <para>Represents the following attribute in the schema: web </para>
    /// </summary>
    [SchemaAttr(0, "web")]
    [SchemaIndex(16)]
    public StringValue Web { get; set; }

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
 
 
