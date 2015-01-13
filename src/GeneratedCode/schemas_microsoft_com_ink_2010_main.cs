// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office2010.Ink
{
/// <summary>
/// <para>Defines the ContextNode Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is msink:context.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ContextNodeProperty &lt;msink:property></description></item>
///<item><description>SourceLink &lt;msink:sourceLink></description></item>
///<item><description>DestinationLink &lt;msink:destinationLink></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ContextNodeProperty))]
    [ChildElementInfo(typeof(SourceLink))]
    [ChildElementInfo(typeof(DestinationLink))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ContextNode : OpenXmlCompositeElement
{
    private const string tagName = "context";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 45;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12758;
    
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
    

    private static string[] attributeTagNames = { "id","type","rotatedBoundingBox","alignmentLevel","contentType","ascender","descender","baseline","midline","customRecognizerId","mathML","mathStruct","mathSymbol","beginModifierType","endModifierType","rotationAngle","hotPoints","centroid","semanticType","shapeName","shapeGeometry" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> rotatedBoundingBox.</para>
    /// <para>Represents the following attribute in the schema: rotatedBoundingBox </para>
    /// </summary>
    [SchemaAttr(0, "rotatedBoundingBox")]
    public ListValue<StringValue> RotatedBoundingBox
    {
        get { return (ListValue<StringValue>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> alignmentLevel.</para>
    /// <para>Represents the following attribute in the schema: alignmentLevel </para>
    /// </summary>
    [SchemaAttr(0, "alignmentLevel")]
    public Int32Value AlignmentLevel
    {
        get { return (Int32Value)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> contentType.</para>
    /// <para>Represents the following attribute in the schema: contentType </para>
    /// </summary>
    [SchemaAttr(0, "contentType")]
    public Int32Value ContentType
    {
        get { return (Int32Value)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> ascender.</para>
    /// <para>Represents the following attribute in the schema: ascender </para>
    /// </summary>
    [SchemaAttr(0, "ascender")]
    public StringValue Ascender
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> descender.</para>
    /// <para>Represents the following attribute in the schema: descender </para>
    /// </summary>
    [SchemaAttr(0, "descender")]
    public StringValue Descender
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> baseline.</para>
    /// <para>Represents the following attribute in the schema: baseline </para>
    /// </summary>
    [SchemaAttr(0, "baseline")]
    public StringValue Baseline
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> midline.</para>
    /// <para>Represents the following attribute in the schema: midline </para>
    /// </summary>
    [SchemaAttr(0, "midline")]
    public StringValue Midline
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> customRecognizerId.</para>
    /// <para>Represents the following attribute in the schema: customRecognizerId </para>
    /// </summary>
    [SchemaAttr(0, "customRecognizerId")]
    public StringValue CustomRecognizerId
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> mathML.</para>
    /// <para>Represents the following attribute in the schema: mathML </para>
    /// </summary>
    [SchemaAttr(0, "mathML")]
    public StringValue MathML
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> mathStruct.</para>
    /// <para>Represents the following attribute in the schema: mathStruct </para>
    /// </summary>
    [SchemaAttr(0, "mathStruct")]
    public StringValue MathStruct
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> mathSymbol.</para>
    /// <para>Represents the following attribute in the schema: mathSymbol </para>
    /// </summary>
    [SchemaAttr(0, "mathSymbol")]
    public StringValue MathSymbol
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> beginModifierType.</para>
    /// <para>Represents the following attribute in the schema: beginModifierType </para>
    /// </summary>
    [SchemaAttr(0, "beginModifierType")]
    public StringValue BeginModifierType
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> endModifierType.</para>
    /// <para>Represents the following attribute in the schema: endModifierType </para>
    /// </summary>
    [SchemaAttr(0, "endModifierType")]
    public StringValue EndModifierType
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> rotationAngle.</para>
    /// <para>Represents the following attribute in the schema: rotationAngle </para>
    /// </summary>
    [SchemaAttr(0, "rotationAngle")]
    public Int32Value RotationAngle
    {
        get { return (Int32Value)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> hotPoints.</para>
    /// <para>Represents the following attribute in the schema: hotPoints </para>
    /// </summary>
    [SchemaAttr(0, "hotPoints")]
    public ListValue<StringValue> HotPoints
    {
        get { return (ListValue<StringValue>)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> centroid.</para>
    /// <para>Represents the following attribute in the schema: centroid </para>
    /// </summary>
    [SchemaAttr(0, "centroid")]
    public StringValue Centroid
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> semanticType.</para>
    /// <para>Represents the following attribute in the schema: semanticType </para>
    /// </summary>
    [SchemaAttr(0, "semanticType")]
    public StringValue SemanticType
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> shapeName.</para>
    /// <para>Represents the following attribute in the schema: shapeName </para>
    /// </summary>
    [SchemaAttr(0, "shapeName")]
    public StringValue ShapeName
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> shapeGeometry.</para>
    /// <para>Represents the following attribute in the schema: shapeGeometry </para>
    /// </summary>
    [SchemaAttr(0, "shapeGeometry")]
    public ListValue<StringValue> ShapeGeometry
    {
        get { return (ListValue<StringValue>)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ContextNode class.
    /// </summary>
    public ContextNode():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ContextNode class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextNode(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextNode class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextNode(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextNode class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextNode(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 45 == namespaceId && "property" == name)
    return new ContextNodeProperty();
    
if( 45 == namespaceId && "sourceLink" == name)
    return new SourceLink();
    
if( 45 == namespaceId && "destinationLink" == name)
    return new DestinationLink();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "type" == name)
    return new StringValue();
    
if( 0 == namespaceId && "rotatedBoundingBox" == name)
    return new ListValue<StringValue>();
    
if( 0 == namespaceId && "alignmentLevel" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "contentType" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "ascender" == name)
    return new StringValue();
    
if( 0 == namespaceId && "descender" == name)
    return new StringValue();
    
if( 0 == namespaceId && "baseline" == name)
    return new StringValue();
    
if( 0 == namespaceId && "midline" == name)
    return new StringValue();
    
if( 0 == namespaceId && "customRecognizerId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "mathML" == name)
    return new StringValue();
    
if( 0 == namespaceId && "mathStruct" == name)
    return new StringValue();
    
if( 0 == namespaceId && "mathSymbol" == name)
    return new StringValue();
    
if( 0 == namespaceId && "beginModifierType" == name)
    return new StringValue();
    
if( 0 == namespaceId && "endModifierType" == name)
    return new StringValue();
    
if( 0 == namespaceId && "rotationAngle" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "hotPoints" == name)
    return new ListValue<StringValue>();
    
if( 0 == namespaceId && "centroid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "semanticType" == name)
    return new StringValue();
    
if( 0 == namespaceId && "shapeName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "shapeGeometry" == name)
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
        return CloneImp<ContextNode>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ContextNodeProperty Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is msink:property.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ContextNodeProperty : OpenXmlLeafTextElement
{
    private const string tagName = "property";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 45;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12759;
    
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
    

    private static string[] attributeTagNames = { "type" };
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
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ContextNodeProperty class.
    /// </summary>
    public ContextNodeProperty():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the ContextNodeProperty class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ContextNodeProperty(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new HexBinaryValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
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
        return CloneImp<ContextNodeProperty>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SourceLink Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is msink:sourceLink.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SourceLink : ContextLinkType
{
    private const string tagName = "sourceLink";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 45;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12760;
    
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
    /// Initializes a new instance of the SourceLink class.
    /// </summary>
    public SourceLink():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SourceLink>(deep);
    }

}
/// <summary>
/// <para>Defines the DestinationLink Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is msink:destinationLink.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DestinationLink : ContextLinkType
{
    private const string tagName = "destinationLink";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 45;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12761;
    
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
    /// Initializes a new instance of the DestinationLink class.
    /// </summary>
    public DestinationLink():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DestinationLink>(deep);
    }

}
/// <summary>
/// Defines the ContextLinkType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class ContextLinkType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "direction","ref" };
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
    /// <para> direction.</para>
    /// <para>Represents the following attribute in the schema: direction </para>
    /// </summary>
    [SchemaAttr(0, "direction")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Ink.LinkDirectionValues> Direction
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Ink.LinkDirectionValues>)Attributes[0]; }
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
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "direction" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.Ink.LinkDirectionValues>();
    
if( 0 == namespaceId && "ref" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the ContextLinkType class.
    /// </summary>
    protected ContextLinkType(){}
    
    
    
}
/// <summary>
/// Defines the KnownContextNodeTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum KnownContextNodeTypeValues
{  
	///<summary>
///root.
///<para>When the item is serialized out as xml, its value is "root".</para>
///</summary>
[EnumString("root")]
Root,
///<summary>
///unclassifiedInk.
///<para>When the item is serialized out as xml, its value is "unclassifiedInk".</para>
///</summary>
[EnumString("unclassifiedInk")]
UnclassifiedInk,
///<summary>
///writingRegion.
///<para>When the item is serialized out as xml, its value is "writingRegion".</para>
///</summary>
[EnumString("writingRegion")]
WritingRegion,
///<summary>
///analysisHint.
///<para>When the item is serialized out as xml, its value is "analysisHint".</para>
///</summary>
[EnumString("analysisHint")]
AnalysisHint,
///<summary>
///object.
///<para>When the item is serialized out as xml, its value is "object".</para>
///</summary>
[EnumString("object")]
Object,
///<summary>
///inkDrawing.
///<para>When the item is serialized out as xml, its value is "inkDrawing".</para>
///</summary>
[EnumString("inkDrawing")]
InkDrawing,
///<summary>
///image.
///<para>When the item is serialized out as xml, its value is "image".</para>
///</summary>
[EnumString("image")]
Image,
///<summary>
///paragraph.
///<para>When the item is serialized out as xml, its value is "paragraph".</para>
///</summary>
[EnumString("paragraph")]
Paragraph,
///<summary>
///line.
///<para>When the item is serialized out as xml, its value is "line".</para>
///</summary>
[EnumString("line")]
Line,
///<summary>
///inkBullet.
///<para>When the item is serialized out as xml, its value is "inkBullet".</para>
///</summary>
[EnumString("inkBullet")]
InkBullet,
///<summary>
///inkWord.
///<para>When the item is serialized out as xml, its value is "inkWord".</para>
///</summary>
[EnumString("inkWord")]
InkWord,
///<summary>
///textWord.
///<para>When the item is serialized out as xml, its value is "textWord".</para>
///</summary>
[EnumString("textWord")]
TextWord,
///<summary>
///customRecognizer.
///<para>When the item is serialized out as xml, its value is "customRecognizer".</para>
///</summary>
[EnumString("customRecognizer")]
CustomRecognizer,
///<summary>
///mathRegion.
///<para>When the item is serialized out as xml, its value is "mathRegion".</para>
///</summary>
[EnumString("mathRegion")]
MathRegion,
///<summary>
///mathEquation.
///<para>When the item is serialized out as xml, its value is "mathEquation".</para>
///</summary>
[EnumString("mathEquation")]
MathEquation,
///<summary>
///mathStruct.
///<para>When the item is serialized out as xml, its value is "mathStruct".</para>
///</summary>
[EnumString("mathStruct")]
MathStruct,
///<summary>
///mathSymbol.
///<para>When the item is serialized out as xml, its value is "mathSymbol".</para>
///</summary>
[EnumString("mathSymbol")]
MathSymbol,
///<summary>
///mathIdentifier.
///<para>When the item is serialized out as xml, its value is "mathIdentifier".</para>
///</summary>
[EnumString("mathIdentifier")]
MathIdentifier,
///<summary>
///mathOperator.
///<para>When the item is serialized out as xml, its value is "mathOperator".</para>
///</summary>
[EnumString("mathOperator")]
MathOperator,
///<summary>
///mathNumber.
///<para>When the item is serialized out as xml, its value is "mathNumber".</para>
///</summary>
[EnumString("mathNumber")]
MathNumber,
///<summary>
///nonInkDrawing.
///<para>When the item is serialized out as xml, its value is "nonInkDrawing".</para>
///</summary>
[EnumString("nonInkDrawing")]
NonInkDrawing,
///<summary>
///groupNode.
///<para>When the item is serialized out as xml, its value is "groupNode".</para>
///</summary>
[EnumString("groupNode")]
GroupNode,
///<summary>
///mixedDrawing.
///<para>When the item is serialized out as xml, its value is "mixedDrawing".</para>
///</summary>
[EnumString("mixedDrawing")]
MixedDrawing,
 
}
/// <summary>
/// Defines the LinkDirectionValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LinkDirectionValues
{  
	///<summary>
///to.
///<para>When the item is serialized out as xml, its value is "to".</para>
///</summary>
[EnumString("to")]
To,
///<summary>
///from.
///<para>When the item is serialized out as xml, its value is "from".</para>
///</summary>
[EnumString("from")]
From,
///<summary>
///with.
///<para>When the item is serialized out as xml, its value is "with".</para>
///</summary>
[EnumString("with")]
With,
 
}
/// <summary>
/// Defines the KnownSemanticTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum KnownSemanticTypeValues
{  
	///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///underline.
///<para>When the item is serialized out as xml, its value is "underline".</para>
///</summary>
[EnumString("underline")]
Underline,
///<summary>
///strikethrough.
///<para>When the item is serialized out as xml, its value is "strikethrough".</para>
///</summary>
[EnumString("strikethrough")]
Strikethrough,
///<summary>
///highlight.
///<para>When the item is serialized out as xml, its value is "highlight".</para>
///</summary>
[EnumString("highlight")]
Highlight,
///<summary>
///scratchOut.
///<para>When the item is serialized out as xml, its value is "scratchOut".</para>
///</summary>
[EnumString("scratchOut")]
ScratchOut,
///<summary>
///verticalRange.
///<para>When the item is serialized out as xml, its value is "verticalRange".</para>
///</summary>
[EnumString("verticalRange")]
VerticalRange,
///<summary>
///callout.
///<para>When the item is serialized out as xml, its value is "callout".</para>
///</summary>
[EnumString("callout")]
Callout,
///<summary>
///enclosure.
///<para>When the item is serialized out as xml, its value is "enclosure".</para>
///</summary>
[EnumString("enclosure")]
Enclosure,
///<summary>
///comment.
///<para>When the item is serialized out as xml, its value is "comment".</para>
///</summary>
[EnumString("comment")]
Comment,
///<summary>
///container.
///<para>When the item is serialized out as xml, its value is "container".</para>
///</summary>
[EnumString("container")]
Container,
///<summary>
///connector.
///<para>When the item is serialized out as xml, its value is "connector".</para>
///</summary>
[EnumString("connector")]
Connector,
 
}
}
 
 
