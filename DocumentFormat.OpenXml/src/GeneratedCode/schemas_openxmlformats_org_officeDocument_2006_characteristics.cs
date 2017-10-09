﻿// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.AdditionalCharacteristics
{
/// <summary>
/// <para>Set of Additional Characteristics.</para>
/// <para> When the object is serialized out as xml, its qualified name is ac:additionalCharacteristics.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Characteristic &lt;ac:characteristic></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Characteristic))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AdditionalCharacteristicsInfo : OpenXmlPartRootElement
{
    private const string tagName = "additionalCharacteristics";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 8;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10822;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AdditionalCharacteristicsInfo class.
    /// </summary>
    public AdditionalCharacteristicsInfo():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AdditionalCharacteristicsInfo class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AdditionalCharacteristicsInfo(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AdditionalCharacteristicsInfo class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AdditionalCharacteristicsInfo(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AdditionalCharacteristicsInfo class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AdditionalCharacteristicsInfo(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 8 == namespaceId && "characteristic" == name)
    return new Characteristic();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AdditionalCharacteristicsInfo>(deep);
    }

   
}
/// <summary>
/// <para>Single Characteristic.</para>
/// <para> When the object is serialized out as xml, its qualified name is ac:characteristic.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Characteristic : OpenXmlLeafElement
{
    private const string tagName = "characteristic";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 8;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10823;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "name","relation","val","vocabulary" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0 };
    
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
    /// <para> Name of Characteristic.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Relationship of Value to Name.</para>
    /// <para>Represents the following attribute in the schema: relation </para>
    /// </summary>
    [SchemaAttr(0, "relation")]
    public EnumValue<DocumentFormat.OpenXml.AdditionalCharacteristics.RelationValues> Relation
    {
        get { return (EnumValue<DocumentFormat.OpenXml.AdditionalCharacteristics.RelationValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Characteristic Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Characteristic Grammar.</para>
    /// <para>Represents the following attribute in the schema: vocabulary </para>
    /// </summary>
    [SchemaAttr(0, "vocabulary")]
    public StringValue Vocabulary
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Characteristic class.
    /// </summary>
    public Characteristic():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "relation" == name)
    return new EnumValue<DocumentFormat.OpenXml.AdditionalCharacteristics.RelationValues>();
    
if( 0 == namespaceId && "val" == name)
    return new StringValue();
    
if( 0 == namespaceId && "vocabulary" == name)
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
        return CloneImp<Characteristic>(deep);
    }

   
}
/// <summary>
/// Characteristic Relationship Types 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum RelationValues
{  
	///<summary>
///Greater Than or Equal to.
///<para>When the item is serialized out as xml, its value is "ge".</para>
///</summary>
[EnumString("ge")]
GreaterThanOrEqualTo,
///<summary>
///Less Than or Equal To.
///<para>When the item is serialized out as xml, its value is "le".</para>
///</summary>
[EnumString("le")]
LessThanOrEqualTo,
///<summary>
///Greater Than.
///<para>When the item is serialized out as xml, its value is "gt".</para>
///</summary>
[EnumString("gt")]
GreaterThan,
///<summary>
///Less Than.
///<para>When the item is serialized out as xml, its value is "lt".</para>
///</summary>
[EnumString("lt")]
LessThan,
///<summary>
///Equal To.
///<para>When the item is serialized out as xml, its value is "eq".</para>
///</summary>
[EnumString("eq")]
EqualTo,
 
}
}
 
 
