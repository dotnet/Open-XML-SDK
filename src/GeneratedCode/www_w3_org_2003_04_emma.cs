// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2010.Ink;

namespace DocumentFormat.OpenXml.EMMA
{
/// <summary>
/// <para>Defines the DerivedFrom Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:derived-from.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DerivedFrom : OpenXmlLeafElement
{
    private const string tagName = "derived-from";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12741;
    
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
    

    private static string[] attributeTagNames = { "resource","composite" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
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
    /// <para> resource.</para>
    /// <para>Represents the following attribute in the schema: resource </para>
    /// </summary>
    [SchemaAttr(0, "resource")]
    public StringValue Resource
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> composite.</para>
    /// <para>Represents the following attribute in the schema: composite </para>
    /// </summary>
    [SchemaAttr(0, "composite")]
    public BooleanValue Composite
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DerivedFrom class.
    /// </summary>
    public DerivedFrom():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "resource" == name)
    return new StringValue();
    
if( 0 == namespaceId && "composite" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DerivedFrom>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Info Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:info.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Info : OpenXmlCompositeElement
{
    private const string tagName = "info";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12742;
    
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
    

    private static string[] attributeTagNames = { "id" };
    private static byte[] attributeNamespaceIds = { 0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Info class.
    /// </summary>
    public Info():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Info class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Info(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Info class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Info(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Info class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Info(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    
    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
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
        return CloneImp<Info>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Lattice Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:lattice.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Arc &lt;emma:arc></description></item>
///<item><description>Node &lt;emma:node></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Arc))]
    [ChildElementInfo(typeof(Node))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Lattice : OpenXmlCompositeElement
{
    private const string tagName = "lattice";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12743;
    
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
    

    private static string[] attributeTagNames = { "initial","final","time-ref-uri","time-ref-anchor-point" };
    private static byte[] attributeNamespaceIds = { 0,0,44,44 };
    
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
    /// <para> initial.</para>
    /// <para>Represents the following attribute in the schema: initial </para>
    /// </summary>
    [SchemaAttr(0, "initial")]
    public IntegerValue Initial
    {
        get { return (IntegerValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> final.</para>
    /// <para>Represents the following attribute in the schema: final </para>
    /// </summary>
    [SchemaAttr(0, "final")]
    public ListValue<DecimalValue> Final
    {
        get { return (ListValue<DecimalValue>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> time-ref-uri.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-uri </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-uri")]
    public StringValue TimeReference
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> time-ref-anchor-point.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-anchor-point")]
    public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint
    {
        get { return (EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Lattice class.
    /// </summary>
    public Lattice():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Lattice class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Lattice(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Lattice class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Lattice(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Lattice class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Lattice(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 44 == namespaceId && "arc" == name)
    return new Arc();
    
if( 44 == namespaceId && "node" == name)
    return new Node();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "initial" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "final" == name)
    return new ListValue<DecimalValue>();
    
if( 44 == namespaceId && "time-ref-uri" == name)
    return new StringValue();
    
if( 44 == namespaceId && "time-ref-anchor-point" == name)
    return new EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Lattice>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Literal Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:literal.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Literal : OpenXmlLeafTextElement
{
    private const string tagName = "literal";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12744;
    
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
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Literal class.
    /// </summary>
    public Literal():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the Literal class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Literal(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Literal>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Interpretation Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:interpretation.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DerivedFrom &lt;emma:derived-from></description></item>
///<item><description>Info &lt;emma:info></description></item>
///<item><description>Lattice &lt;emma:lattice></description></item>
///<item><description>Literal &lt;emma:literal></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Ink.ContextNode &lt;msink:context></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DerivedFrom))]
    [ChildElementInfo(typeof(Info))]
    [ChildElementInfo(typeof(Lattice))]
    [ChildElementInfo(typeof(Literal))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Ink.ContextNode))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Interpretation : OpenXmlCompositeElement
{
    private const string tagName = "interpretation";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12745;
    
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
    

    private static string[] attributeTagNames = { "id","tokens","process","lang","signal","signal-size","media-type","confidence","source","start","end","time-ref-uri","time-ref-anchor-point","offset-to-start","duration","medium","mode","function","verbal","cost","grammar-ref","endpoint-info-ref","model-ref","dialog-turn","no-input","uninterpreted" };
    private static byte[] attributeNamespaceIds = { 0,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> tokens.</para>
    /// <para>Represents the following attribute in the schema: emma:tokens </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "tokens")]
    public StringValue Tokens
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> process.</para>
    /// <para>Represents the following attribute in the schema: emma:process </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "process")]
    public StringValue Process
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: emma:lang </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> signal.</para>
    /// <para>Represents the following attribute in the schema: emma:signal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal")]
    public StringValue Signal
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> signal-size.</para>
    /// <para>Represents the following attribute in the schema: emma:signal-size </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal-size")]
    public IntegerValue SignalSize
    {
        get { return (IntegerValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> media-type.</para>
    /// <para>Represents the following attribute in the schema: emma:media-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "media-type")]
    public StringValue MediaType
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    public DecimalValue Confidence
    {
        get { return (DecimalValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: emma:source </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "source")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: emma:start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "start")]
    public UInt64Value Start
    {
        get { return (UInt64Value)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: emma:end </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "end")]
    public UInt64Value End
    {
        get { return (UInt64Value)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> time-ref-uri.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-uri </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-uri")]
    public StringValue TimeReference
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> time-ref-anchor-point.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-anchor-point")]
    public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint
    {
        get { return (EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> offset-to-start.</para>
    /// <para>Represents the following attribute in the schema: emma:offset-to-start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "offset-to-start")]
    public IntegerValue OffsetToStart
    {
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: emma:duration </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "duration")]
    public IntegerValue Duration
    {
        get { return (IntegerValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    public ListValue<StringValue> Mode
    {
        get { return (ListValue<StringValue>)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> function.</para>
    /// <para>Represents the following attribute in the schema: emma:function </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "function")]
    public StringValue Function
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> verbal.</para>
    /// <para>Represents the following attribute in the schema: emma:verbal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "verbal")]
    public BooleanValue Verbal
    {
        get { return (BooleanValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    public DecimalValue Cost
    {
        get { return (DecimalValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> grammar-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:grammar-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "grammar-ref")]
    public StringValue GrammarRef
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> endpoint-info-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-info-ref")]
    public StringValue EndpointInfoRef
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> model-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:model-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "model-ref")]
    public StringValue ModelRef
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> dialog-turn.</para>
    /// <para>Represents the following attribute in the schema: emma:dialog-turn </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "dialog-turn")]
    public StringValue DialogTurn
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> no-input.</para>
    /// <para>Represents the following attribute in the schema: emma:no-input </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "no-input")]
    public BooleanValue NoInput
    {
        get { return (BooleanValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> uninterpreted.</para>
    /// <para>Represents the following attribute in the schema: emma:uninterpreted </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "uninterpreted")]
    public BooleanValue Uninterpreted
    {
        get { return (BooleanValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Interpretation class.
    /// </summary>
    public Interpretation():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Interpretation class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Interpretation(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Interpretation class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Interpretation(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Interpretation class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Interpretation(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 44 == namespaceId && "derived-from" == name)
    return new DerivedFrom();
    
if( 44 == namespaceId && "info" == name)
    return new Info();
    
if( 44 == namespaceId && "lattice" == name)
    return new Lattice();
    
if( 44 == namespaceId && "literal" == name)
    return new Literal();
    
if( 45 == namespaceId && "context" == name)
    return new DocumentFormat.OpenXml.Office2010.Ink.ContextNode();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 44 == namespaceId && "tokens" == name)
    return new StringValue();
    
if( 44 == namespaceId && "process" == name)
    return new StringValue();
    
if( 44 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 44 == namespaceId && "signal" == name)
    return new StringValue();
    
if( 44 == namespaceId && "signal-size" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "media-type" == name)
    return new StringValue();
    
if( 44 == namespaceId && "confidence" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "source" == name)
    return new StringValue();
    
if( 44 == namespaceId && "start" == name)
    return new UInt64Value();
    
if( 44 == namespaceId && "end" == name)
    return new UInt64Value();
    
if( 44 == namespaceId && "time-ref-uri" == name)
    return new StringValue();
    
if( 44 == namespaceId && "time-ref-anchor-point" == name)
    return new EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>();
    
if( 44 == namespaceId && "offset-to-start" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "duration" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "medium" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>();
    
if( 44 == namespaceId && "mode" == name)
    return new ListValue<StringValue>();
    
if( 44 == namespaceId && "function" == name)
    return new StringValue();
    
if( 44 == namespaceId && "verbal" == name)
    return new BooleanValue();
    
if( 44 == namespaceId && "cost" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "grammar-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "endpoint-info-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "model-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "dialog-turn" == name)
    return new StringValue();
    
if( 44 == namespaceId && "no-input" == name)
    return new BooleanValue();
    
if( 44 == namespaceId && "uninterpreted" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Interpretation>(deep);
    }

   
}
/// <summary>
/// <para>Defines the OneOf Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:one-of.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DerivedFrom &lt;emma:derived-from></description></item>
///<item><description>Info &lt;emma:info></description></item>
///<item><description>Interpretation &lt;emma:interpretation></description></item>
///<item><description>OneOf &lt;emma:one-of></description></item>
///<item><description>Group &lt;emma:group></description></item>
///<item><description>Sequence &lt;emma:sequence></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DerivedFrom))]
    [ChildElementInfo(typeof(Info))]
    [ChildElementInfo(typeof(Interpretation))]
    [ChildElementInfo(typeof(OneOf))]
    [ChildElementInfo(typeof(Group))]
    [ChildElementInfo(typeof(Sequence))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class OneOf : OpenXmlCompositeElement
{
    private const string tagName = "one-of";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12746;
    
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
    

    private static string[] attributeTagNames = { "disjunction-type","id","tokens","process","lang","signal","signal-size","media-type","confidence","source","start","end","time-ref-uri","time-ref-anchor-point","offset-to-start","duration","medium","mode","function","verbal","cost","grammar-ref","endpoint-info-ref","model-ref","dialog-turn" };
    private static byte[] attributeNamespaceIds = { 0,0,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44 };
    
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
    /// <para> disjunction-type.</para>
    /// <para>Represents the following attribute in the schema: disjunction-type </para>
    /// </summary>
    [SchemaAttr(0, "disjunction-type")]
    public EnumValue<DocumentFormat.OpenXml.EMMA.DisjunctionTypeValues> DisjunctionType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.EMMA.DisjunctionTypeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> tokens.</para>
    /// <para>Represents the following attribute in the schema: emma:tokens </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "tokens")]
    public StringValue Tokens
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> process.</para>
    /// <para>Represents the following attribute in the schema: emma:process </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "process")]
    public StringValue Process
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: emma:lang </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> signal.</para>
    /// <para>Represents the following attribute in the schema: emma:signal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal")]
    public StringValue Signal
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> signal-size.</para>
    /// <para>Represents the following attribute in the schema: emma:signal-size </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal-size")]
    public IntegerValue SignalSize
    {
        get { return (IntegerValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> media-type.</para>
    /// <para>Represents the following attribute in the schema: emma:media-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "media-type")]
    public StringValue MediaType
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    public DecimalValue Confidence
    {
        get { return (DecimalValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: emma:source </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "source")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: emma:start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "start")]
    public UInt64Value Start
    {
        get { return (UInt64Value)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: emma:end </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "end")]
    public UInt64Value End
    {
        get { return (UInt64Value)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> time-ref-uri.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-uri </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-uri")]
    public StringValue TimeReference
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> time-ref-anchor-point.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-anchor-point")]
    public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint
    {
        get { return (EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> offset-to-start.</para>
    /// <para>Represents the following attribute in the schema: emma:offset-to-start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "offset-to-start")]
    public IntegerValue OffsetToStart
    {
        get { return (IntegerValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: emma:duration </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "duration")]
    public IntegerValue Duration
    {
        get { return (IntegerValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    public ListValue<StringValue> Mode
    {
        get { return (ListValue<StringValue>)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> function.</para>
    /// <para>Represents the following attribute in the schema: emma:function </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "function")]
    public StringValue Function
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> verbal.</para>
    /// <para>Represents the following attribute in the schema: emma:verbal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "verbal")]
    public BooleanValue Verbal
    {
        get { return (BooleanValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    public DecimalValue Cost
    {
        get { return (DecimalValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> grammar-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:grammar-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "grammar-ref")]
    public StringValue GrammarRef
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> endpoint-info-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-info-ref")]
    public StringValue EndpointInfoRef
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> model-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:model-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "model-ref")]
    public StringValue ModelRef
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> dialog-turn.</para>
    /// <para>Represents the following attribute in the schema: emma:dialog-turn </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "dialog-turn")]
    public StringValue DialogTurn
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OneOf class.
    /// </summary>
    public OneOf():base(){}
    
            /// <summary>
    ///Initializes a new instance of the OneOf class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OneOf(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OneOf class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OneOf(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OneOf class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OneOf(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 44 == namespaceId && "derived-from" == name)
    return new DerivedFrom();
    
if( 44 == namespaceId && "info" == name)
    return new Info();
    
if( 44 == namespaceId && "interpretation" == name)
    return new Interpretation();
    
if( 44 == namespaceId && "one-of" == name)
    return new OneOf();
    
if( 44 == namespaceId && "group" == name)
    return new Group();
    
if( 44 == namespaceId && "sequence" == name)
    return new Sequence();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "disjunction-type" == name)
    return new EnumValue<DocumentFormat.OpenXml.EMMA.DisjunctionTypeValues>();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 44 == namespaceId && "tokens" == name)
    return new StringValue();
    
if( 44 == namespaceId && "process" == name)
    return new StringValue();
    
if( 44 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 44 == namespaceId && "signal" == name)
    return new StringValue();
    
if( 44 == namespaceId && "signal-size" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "media-type" == name)
    return new StringValue();
    
if( 44 == namespaceId && "confidence" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "source" == name)
    return new StringValue();
    
if( 44 == namespaceId && "start" == name)
    return new UInt64Value();
    
if( 44 == namespaceId && "end" == name)
    return new UInt64Value();
    
if( 44 == namespaceId && "time-ref-uri" == name)
    return new StringValue();
    
if( 44 == namespaceId && "time-ref-anchor-point" == name)
    return new EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>();
    
if( 44 == namespaceId && "offset-to-start" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "duration" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "medium" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>();
    
if( 44 == namespaceId && "mode" == name)
    return new ListValue<StringValue>();
    
if( 44 == namespaceId && "function" == name)
    return new StringValue();
    
if( 44 == namespaceId && "verbal" == name)
    return new BooleanValue();
    
if( 44 == namespaceId && "cost" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "grammar-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "endpoint-info-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "model-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "dialog-turn" == name)
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
        return CloneImp<OneOf>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Group Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:group.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DerivedFrom &lt;emma:derived-from></description></item>
///<item><description>GroupInfo &lt;emma:group-info></description></item>
///<item><description>Info &lt;emma:info></description></item>
///<item><description>Interpretation &lt;emma:interpretation></description></item>
///<item><description>OneOf &lt;emma:one-of></description></item>
///<item><description>Group &lt;emma:group></description></item>
///<item><description>Sequence &lt;emma:sequence></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DerivedFrom))]
    [ChildElementInfo(typeof(GroupInfo))]
    [ChildElementInfo(typeof(Info))]
    [ChildElementInfo(typeof(Interpretation))]
    [ChildElementInfo(typeof(OneOf))]
    [ChildElementInfo(typeof(Group))]
    [ChildElementInfo(typeof(Sequence))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Group : OpenXmlCompositeElement
{
    private const string tagName = "group";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12747;
    
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
    

    private static string[] attributeTagNames = { "id","tokens","process","lang","signal","signal-size","media-type","confidence","source","start","end","time-ref-uri","time-ref-anchor-point","offset-to-start","duration","medium","mode","function","verbal","cost","grammar-ref","endpoint-info-ref","model-ref","dialog-turn" };
    private static byte[] attributeNamespaceIds = { 0,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> tokens.</para>
    /// <para>Represents the following attribute in the schema: emma:tokens </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "tokens")]
    public StringValue Tokens
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> process.</para>
    /// <para>Represents the following attribute in the schema: emma:process </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "process")]
    public StringValue Process
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: emma:lang </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> signal.</para>
    /// <para>Represents the following attribute in the schema: emma:signal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal")]
    public StringValue Signal
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> signal-size.</para>
    /// <para>Represents the following attribute in the schema: emma:signal-size </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal-size")]
    public IntegerValue SignalSize
    {
        get { return (IntegerValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> media-type.</para>
    /// <para>Represents the following attribute in the schema: emma:media-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "media-type")]
    public StringValue MediaType
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    public DecimalValue Confidence
    {
        get { return (DecimalValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: emma:source </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "source")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: emma:start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "start")]
    public UInt64Value Start
    {
        get { return (UInt64Value)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: emma:end </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "end")]
    public UInt64Value End
    {
        get { return (UInt64Value)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> time-ref-uri.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-uri </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-uri")]
    public StringValue TimeReference
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> time-ref-anchor-point.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-anchor-point")]
    public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint
    {
        get { return (EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> offset-to-start.</para>
    /// <para>Represents the following attribute in the schema: emma:offset-to-start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "offset-to-start")]
    public IntegerValue OffsetToStart
    {
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: emma:duration </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "duration")]
    public IntegerValue Duration
    {
        get { return (IntegerValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    public ListValue<StringValue> Mode
    {
        get { return (ListValue<StringValue>)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> function.</para>
    /// <para>Represents the following attribute in the schema: emma:function </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "function")]
    public StringValue Function
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> verbal.</para>
    /// <para>Represents the following attribute in the schema: emma:verbal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "verbal")]
    public BooleanValue Verbal
    {
        get { return (BooleanValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    public DecimalValue Cost
    {
        get { return (DecimalValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> grammar-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:grammar-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "grammar-ref")]
    public StringValue GrammarRef
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> endpoint-info-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-info-ref")]
    public StringValue EndpointInfoRef
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> model-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:model-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "model-ref")]
    public StringValue ModelRef
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> dialog-turn.</para>
    /// <para>Represents the following attribute in the schema: emma:dialog-turn </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "dialog-turn")]
    public StringValue DialogTurn
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
    if( 44 == namespaceId && "derived-from" == name)
    return new DerivedFrom();
    
if( 44 == namespaceId && "group-info" == name)
    return new GroupInfo();
    
if( 44 == namespaceId && "info" == name)
    return new Info();
    
if( 44 == namespaceId && "interpretation" == name)
    return new Interpretation();
    
if( 44 == namespaceId && "one-of" == name)
    return new OneOf();
    
if( 44 == namespaceId && "group" == name)
    return new Group();
    
if( 44 == namespaceId && "sequence" == name)
    return new Sequence();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 44 == namespaceId && "tokens" == name)
    return new StringValue();
    
if( 44 == namespaceId && "process" == name)
    return new StringValue();
    
if( 44 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 44 == namespaceId && "signal" == name)
    return new StringValue();
    
if( 44 == namespaceId && "signal-size" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "media-type" == name)
    return new StringValue();
    
if( 44 == namespaceId && "confidence" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "source" == name)
    return new StringValue();
    
if( 44 == namespaceId && "start" == name)
    return new UInt64Value();
    
if( 44 == namespaceId && "end" == name)
    return new UInt64Value();
    
if( 44 == namespaceId && "time-ref-uri" == name)
    return new StringValue();
    
if( 44 == namespaceId && "time-ref-anchor-point" == name)
    return new EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>();
    
if( 44 == namespaceId && "offset-to-start" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "duration" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "medium" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>();
    
if( 44 == namespaceId && "mode" == name)
    return new ListValue<StringValue>();
    
if( 44 == namespaceId && "function" == name)
    return new StringValue();
    
if( 44 == namespaceId && "verbal" == name)
    return new BooleanValue();
    
if( 44 == namespaceId && "cost" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "grammar-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "endpoint-info-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "model-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "dialog-turn" == name)
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
        return CloneImp<Group>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Sequence Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:sequence.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DerivedFrom &lt;emma:derived-from></description></item>
///<item><description>Info &lt;emma:info></description></item>
///<item><description>Interpretation &lt;emma:interpretation></description></item>
///<item><description>OneOf &lt;emma:one-of></description></item>
///<item><description>Group &lt;emma:group></description></item>
///<item><description>Sequence &lt;emma:sequence></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DerivedFrom))]
    [ChildElementInfo(typeof(Info))]
    [ChildElementInfo(typeof(Interpretation))]
    [ChildElementInfo(typeof(OneOf))]
    [ChildElementInfo(typeof(Group))]
    [ChildElementInfo(typeof(Sequence))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Sequence : OpenXmlCompositeElement
{
    private const string tagName = "sequence";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12748;
    
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
    

    private static string[] attributeTagNames = { "id","tokens","process","lang","signal","signal-size","media-type","confidence","source","start","end","time-ref-uri","time-ref-anchor-point","offset-to-start","duration","medium","mode","function","verbal","cost","grammar-ref","endpoint-info-ref","model-ref","dialog-turn" };
    private static byte[] attributeNamespaceIds = { 0,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44,44 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> tokens.</para>
    /// <para>Represents the following attribute in the schema: emma:tokens </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "tokens")]
    public StringValue Tokens
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> process.</para>
    /// <para>Represents the following attribute in the schema: emma:process </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "process")]
    public StringValue Process
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: emma:lang </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> signal.</para>
    /// <para>Represents the following attribute in the schema: emma:signal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal")]
    public StringValue Signal
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> signal-size.</para>
    /// <para>Represents the following attribute in the schema: emma:signal-size </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal-size")]
    public IntegerValue SignalSize
    {
        get { return (IntegerValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> media-type.</para>
    /// <para>Represents the following attribute in the schema: emma:media-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "media-type")]
    public StringValue MediaType
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    public DecimalValue Confidence
    {
        get { return (DecimalValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: emma:source </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "source")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: emma:start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "start")]
    public UInt64Value Start
    {
        get { return (UInt64Value)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: emma:end </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "end")]
    public UInt64Value End
    {
        get { return (UInt64Value)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> time-ref-uri.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-uri </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-uri")]
    public StringValue TimeReference
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> time-ref-anchor-point.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-anchor-point")]
    public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint
    {
        get { return (EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> offset-to-start.</para>
    /// <para>Represents the following attribute in the schema: emma:offset-to-start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "offset-to-start")]
    public IntegerValue OffsetToStart
    {
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: emma:duration </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "duration")]
    public IntegerValue Duration
    {
        get { return (IntegerValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    public ListValue<StringValue> Mode
    {
        get { return (ListValue<StringValue>)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> function.</para>
    /// <para>Represents the following attribute in the schema: emma:function </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "function")]
    public StringValue Function
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> verbal.</para>
    /// <para>Represents the following attribute in the schema: emma:verbal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "verbal")]
    public BooleanValue Verbal
    {
        get { return (BooleanValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    public DecimalValue Cost
    {
        get { return (DecimalValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> grammar-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:grammar-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "grammar-ref")]
    public StringValue GrammarRef
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> endpoint-info-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-info-ref")]
    public StringValue EndpointInfoRef
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> model-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:model-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "model-ref")]
    public StringValue ModelRef
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> dialog-turn.</para>
    /// <para>Represents the following attribute in the schema: emma:dialog-turn </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "dialog-turn")]
    public StringValue DialogTurn
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Sequence class.
    /// </summary>
    public Sequence():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Sequence class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Sequence(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Sequence class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Sequence(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Sequence class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Sequence(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 44 == namespaceId && "derived-from" == name)
    return new DerivedFrom();
    
if( 44 == namespaceId && "info" == name)
    return new Info();
    
if( 44 == namespaceId && "interpretation" == name)
    return new Interpretation();
    
if( 44 == namespaceId && "one-of" == name)
    return new OneOf();
    
if( 44 == namespaceId && "group" == name)
    return new Group();
    
if( 44 == namespaceId && "sequence" == name)
    return new Sequence();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 44 == namespaceId && "tokens" == name)
    return new StringValue();
    
if( 44 == namespaceId && "process" == name)
    return new StringValue();
    
if( 44 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 44 == namespaceId && "signal" == name)
    return new StringValue();
    
if( 44 == namespaceId && "signal-size" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "media-type" == name)
    return new StringValue();
    
if( 44 == namespaceId && "confidence" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "source" == name)
    return new StringValue();
    
if( 44 == namespaceId && "start" == name)
    return new UInt64Value();
    
if( 44 == namespaceId && "end" == name)
    return new UInt64Value();
    
if( 44 == namespaceId && "time-ref-uri" == name)
    return new StringValue();
    
if( 44 == namespaceId && "time-ref-anchor-point" == name)
    return new EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>();
    
if( 44 == namespaceId && "offset-to-start" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "duration" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "medium" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>();
    
if( 44 == namespaceId && "mode" == name)
    return new ListValue<StringValue>();
    
if( 44 == namespaceId && "function" == name)
    return new StringValue();
    
if( 44 == namespaceId && "verbal" == name)
    return new BooleanValue();
    
if( 44 == namespaceId && "cost" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "grammar-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "endpoint-info-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "model-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "dialog-turn" == name)
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
        return CloneImp<Sequence>(deep);
    }

   
}
/// <summary>
/// <para>Defines the GroupInfo Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:group-info.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class GroupInfo : OpenXmlCompositeElement
{
    private const string tagName = "group-info";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12749;
    
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
    

    private static string[] attributeTagNames = { "ref" };
    private static byte[] attributeNamespaceIds = { 0 };
    
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
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the GroupInfo class.
    /// </summary>
    public GroupInfo():base(){}
    
            /// <summary>
    ///Initializes a new instance of the GroupInfo class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupInfo(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupInfo class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupInfo(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupInfo class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GroupInfo(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    
    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "ref" == name)
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
        return CloneImp<GroupInfo>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Derivation Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:derivation.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Interpretation &lt;emma:interpretation></description></item>
///<item><description>OneOf &lt;emma:one-of></description></item>
///<item><description>Sequence &lt;emma:sequence></description></item>
///<item><description>Group &lt;emma:group></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Interpretation))]
    [ChildElementInfo(typeof(OneOf))]
    [ChildElementInfo(typeof(Sequence))]
    [ChildElementInfo(typeof(Group))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Derivation : OpenXmlCompositeElement
{
    private const string tagName = "derivation";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12750;
    
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
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Derivation class.
    /// </summary>
    public Derivation():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Derivation class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Derivation(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Derivation class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Derivation(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Derivation class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Derivation(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 44 == namespaceId && "interpretation" == name)
    return new Interpretation();
    
if( 44 == namespaceId && "one-of" == name)
    return new OneOf();
    
if( 44 == namespaceId && "sequence" == name)
    return new Sequence();
    
if( 44 == namespaceId && "group" == name)
    return new Group();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Derivation>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Grammar Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:grammar.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Grammar : OpenXmlLeafElement
{
    private const string tagName = "grammar";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12751;
    
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
    

    private static string[] attributeTagNames = { "id","ref" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Grammar class.
    /// </summary>
    public Grammar():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ref" == name)
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
        return CloneImp<Grammar>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Model Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:model.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Model : OpenXmlCompositeElement
{
    private const string tagName = "model";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12752;
    
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
    

    private static string[] attributeTagNames = { "id","ref" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Model class.
    /// </summary>
    public Model():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Model class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Model(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Model class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Model(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Model class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Model(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    
    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ref" == name)
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
        return CloneImp<Model>(deep);
    }

   
}
/// <summary>
/// <para>Defines the EndPointInfo Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:endpoint-info.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>EndPoint &lt;emma:endpoint></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(EndPoint))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EndPointInfo : OpenXmlCompositeElement
{
    private const string tagName = "endpoint-info";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12753;
    
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
    

    private static string[] attributeTagNames = { "id" };
    private static byte[] attributeNamespaceIds = { 0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the EndPointInfo class.
    /// </summary>
    public EndPointInfo():base(){}
    
            /// <summary>
    ///Initializes a new instance of the EndPointInfo class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EndPointInfo(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the EndPointInfo class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EndPointInfo(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the EndPointInfo class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public EndPointInfo(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 44 == namespaceId && "endpoint" == name)
    return new EndPoint();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
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
        return CloneImp<EndPointInfo>(deep);
    }

   
}
/// <summary>
/// <para>Defines the EndPoint Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:endpoint.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EndPoint : OpenXmlCompositeElement
{
    private const string tagName = "endpoint";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12754;
    
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
    

    private static string[] attributeTagNames = { "id","endpoint-role","endpoint-address","message-id","port-num","port-type","endpoint-pair-ref","service-name","media-type","medium","mode" };
    private static byte[] attributeNamespaceIds = { 0,44,44,44,44,44,44,44,44,44,44 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> endpoint-role.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-role </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-role")]
    public EnumValue<DocumentFormat.OpenXml.EMMA.EndPointRoleValues> EndpointRole
    {
        get { return (EnumValue<DocumentFormat.OpenXml.EMMA.EndPointRoleValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> endpoint-address.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-address </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-address")]
    public StringValue EndPointAddress
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> message-id.</para>
    /// <para>Represents the following attribute in the schema: emma:message-id </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "message-id")]
    public StringValue MessageId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> port-num.</para>
    /// <para>Represents the following attribute in the schema: emma:port-num </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "port-num")]
    public IntegerValue PortNumber
    {
        get { return (IntegerValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> port-type.</para>
    /// <para>Represents the following attribute in the schema: emma:port-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "port-type")]
    public StringValue PortType
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> endpoint-pair-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-pair-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-pair-ref")]
    public StringValue EndpointPairRef
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> service-name.</para>
    /// <para>Represents the following attribute in the schema: emma:service-name </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "service-name")]
    public StringValue ServiceName
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> media-type.</para>
    /// <para>Represents the following attribute in the schema: emma:media-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "media-type")]
    public StringValue MediaType
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    public ListValue<StringValue> Mode
    {
        get { return (ListValue<StringValue>)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the EndPoint class.
    /// </summary>
    public EndPoint():base(){}
    
            /// <summary>
    ///Initializes a new instance of the EndPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EndPoint(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the EndPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EndPoint(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the EndPoint class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public EndPoint(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    
    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 44 == namespaceId && "endpoint-role" == name)
    return new EnumValue<DocumentFormat.OpenXml.EMMA.EndPointRoleValues>();
    
if( 44 == namespaceId && "endpoint-address" == name)
    return new StringValue();
    
if( 44 == namespaceId && "message-id" == name)
    return new StringValue();
    
if( 44 == namespaceId && "port-num" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "port-type" == name)
    return new StringValue();
    
if( 44 == namespaceId && "endpoint-pair-ref" == name)
    return new StringValue();
    
if( 44 == namespaceId && "service-name" == name)
    return new StringValue();
    
if( 44 == namespaceId && "media-type" == name)
    return new StringValue();
    
if( 44 == namespaceId && "medium" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>();
    
if( 44 == namespaceId && "mode" == name)
    return new ListValue<StringValue>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EndPoint>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Node Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:node.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Info &lt;emma:info></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Info))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Node : OpenXmlCompositeElement
{
    private const string tagName = "node";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12755;
    
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
    

    private static string[] attributeTagNames = { "node-number","confidence","cost" };
    private static byte[] attributeNamespaceIds = { 0,44,44 };
    
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
    /// <para> node-number.</para>
    /// <para>Represents the following attribute in the schema: node-number </para>
    /// </summary>
    [SchemaAttr(0, "node-number")]
    public IntegerValue NodeNumber
    {
        get { return (IntegerValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    public DecimalValue Confidence
    {
        get { return (DecimalValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    public DecimalValue Cost
    {
        get { return (DecimalValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Node class.
    /// </summary>
    public Node():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Node class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Node(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Node class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Node(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Node class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Node(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 44 == namespaceId && "info" == name)
    return new Info();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "node-number" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "confidence" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "cost" == name)
    return new DecimalValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Node>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Arc Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:arc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Info &lt;emma:info></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Info))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Arc : OpenXmlCompositeElement
{
    private const string tagName = "arc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12756;
    
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
    

    private static string[] attributeTagNames = { "from","to","start","end","offset-to-start","duration","confidence","cost","lang","medium","mode","source" };
    private static byte[] attributeNamespaceIds = { 0,0,44,44,44,44,44,44,44,44,44,44 };
    
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
    /// <para> from.</para>
    /// <para>Represents the following attribute in the schema: from </para>
    /// </summary>
    [SchemaAttr(0, "from")]
    public IntegerValue From
    {
        get { return (IntegerValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> to.</para>
    /// <para>Represents the following attribute in the schema: to </para>
    /// </summary>
    [SchemaAttr(0, "to")]
    public IntegerValue To
    {
        get { return (IntegerValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: emma:start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "start")]
    public UInt64Value Start
    {
        get { return (UInt64Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: emma:end </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "end")]
    public UInt64Value End
    {
        get { return (UInt64Value)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> offset-to-start.</para>
    /// <para>Represents the following attribute in the schema: emma:offset-to-start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "offset-to-start")]
    public IntegerValue OffsetToStart
    {
        get { return (IntegerValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: emma:duration </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "duration")]
    public IntegerValue Duration
    {
        get { return (IntegerValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    public DecimalValue Confidence
    {
        get { return (DecimalValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    public DecimalValue Cost
    {
        get { return (DecimalValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: emma:lang </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    public ListValue<StringValue> Mode
    {
        get { return (ListValue<StringValue>)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: emma:source </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "source")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Arc class.
    /// </summary>
    public Arc():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Arc class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Arc(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Arc class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Arc(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Arc class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Arc(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 44 == namespaceId && "info" == name)
    return new Info();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "from" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "to" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "start" == name)
    return new UInt64Value();
    
if( 44 == namespaceId && "end" == name)
    return new UInt64Value();
    
if( 44 == namespaceId && "offset-to-start" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "duration" == name)
    return new IntegerValue();
    
if( 44 == namespaceId && "confidence" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "cost" == name)
    return new DecimalValue();
    
if( 44 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 44 == namespaceId && "medium" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>();
    
if( 44 == namespaceId && "mode" == name)
    return new ListValue<StringValue>();
    
if( 44 == namespaceId && "source" == name)
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
        return CloneImp<Arc>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Emma Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:emma.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Derivation &lt;emma:derivation></description></item>
///<item><description>Grammar &lt;emma:grammar></description></item>
///<item><description>Model &lt;emma:model></description></item>
///<item><description>EndPointInfo &lt;emma:endpoint-info></description></item>
///<item><description>Info &lt;emma:info></description></item>
///<item><description>Interpretation &lt;emma:interpretation></description></item>
///<item><description>OneOf &lt;emma:one-of></description></item>
///<item><description>Group &lt;emma:group></description></item>
///<item><description>Sequence &lt;emma:sequence></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Derivation))]
    [ChildElementInfo(typeof(Grammar))]
    [ChildElementInfo(typeof(Model))]
    [ChildElementInfo(typeof(EndPointInfo))]
    [ChildElementInfo(typeof(Info))]
    [ChildElementInfo(typeof(Interpretation))]
    [ChildElementInfo(typeof(OneOf))]
    [ChildElementInfo(typeof(Group))]
    [ChildElementInfo(typeof(Sequence))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Emma : OpenXmlCompositeElement
{
    private const string tagName = "emma";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 44;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12757;
    
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
    

    private static string[] attributeTagNames = { "version" };
    private static byte[] attributeNamespaceIds = { 0 };
    
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
    /// <para> version.</para>
    /// <para>Represents the following attribute in the schema: version </para>
    /// </summary>
    [SchemaAttr(0, "version")]
    public StringValue Version
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Emma class.
    /// </summary>
    public Emma():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Emma class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Emma(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Emma class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Emma(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Emma class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Emma(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 44 == namespaceId && "derivation" == name)
    return new Derivation();
    
if( 44 == namespaceId && "grammar" == name)
    return new Grammar();
    
if( 44 == namespaceId && "model" == name)
    return new Model();
    
if( 44 == namespaceId && "endpoint-info" == name)
    return new EndPointInfo();
    
if( 44 == namespaceId && "info" == name)
    return new Info();
    
if( 44 == namespaceId && "interpretation" == name)
    return new Interpretation();
    
if( 44 == namespaceId && "one-of" == name)
    return new OneOf();
    
if( 44 == namespaceId && "group" == name)
    return new Group();
    
if( 44 == namespaceId && "sequence" == name)
    return new Sequence();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "version" == name)
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
        return CloneImp<Emma>(deep);
    }

   
}
/// <summary>
/// Defines the EndPointRoleValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum EndPointRoleValues
{  
	///<summary>
///source.
///<para>When the item is serialized out as xml, its value is "source".</para>
///</summary>
[EnumString("source")]
Source,
///<summary>
///sink.
///<para>When the item is serialized out as xml, its value is "sink".</para>
///</summary>
[EnumString("sink")]
Sink,
///<summary>
///reply-to.
///<para>When the item is serialized out as xml, its value is "reply-to".</para>
///</summary>
[EnumString("reply-to")]
Replyto,
///<summary>
///router.
///<para>When the item is serialized out as xml, its value is "router".</para>
///</summary>
[EnumString("router")]
Router,
 
}
/// <summary>
/// Defines the MediumValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum MediumValues
{  
	///<summary>
///acoustic.
///<para>When the item is serialized out as xml, its value is "acoustic".</para>
///</summary>
[EnumString("acoustic")]
Acoustic,
///<summary>
///tactile.
///<para>When the item is serialized out as xml, its value is "tactile".</para>
///</summary>
[EnumString("tactile")]
Tactile,
///<summary>
///visual.
///<para>When the item is serialized out as xml, its value is "visual".</para>
///</summary>
[EnumString("visual")]
Visual,
 
}
/// <summary>
/// Defines the AnchorPointValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AnchorPointValues
{  
	///<summary>
///start.
///<para>When the item is serialized out as xml, its value is "start".</para>
///</summary>
[EnumString("start")]
Start,
///<summary>
///end.
///<para>When the item is serialized out as xml, its value is "end".</para>
///</summary>
[EnumString("end")]
End,
 
}
/// <summary>
/// Defines the DisjunctionTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DisjunctionTypeValues
{  
	///<summary>
///recognition.
///<para>When the item is serialized out as xml, its value is "recognition".</para>
///</summary>
[EnumString("recognition")]
Recognition,
///<summary>
///understanding.
///<para>When the item is serialized out as xml, its value is "understanding".</para>
///</summary>
[EnumString("understanding")]
Understanding,
///<summary>
///multi-device.
///<para>When the item is serialized out as xml, its value is "multi-device".</para>
///</summary>
[EnumString("multi-device")]
Multidevice,
///<summary>
///multi-process.
///<para>When the item is serialized out as xml, its value is "multi-process".</para>
///</summary>
[EnumString("multi-process")]
Multiprocess,
 
}
}
 
 
