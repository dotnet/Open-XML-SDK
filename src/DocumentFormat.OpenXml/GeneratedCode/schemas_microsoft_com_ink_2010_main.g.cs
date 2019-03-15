// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office2010.Ink
{
/// <summary>
/// <para>Defines the ContextNode Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

    [ChildElementInfo(typeof(ContextNodeProperty))]
    [ChildElementInfo(typeof(SourceLink))]
    [ChildElementInfo(typeof(DestinationLink))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(45, "context")]
[Id(ElementTypeIdConst)]
public partial class ContextNode : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12758;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(1)]
    public StringValue Type { get; set; }
	
    /// <summary>
    /// <para> rotatedBoundingBox.</para>
    /// <para>Represents the following attribute in the schema: rotatedBoundingBox </para>
    /// </summary>
    [SchemaAttr(0, "rotatedBoundingBox")]
    [Index(2)]
    public ListValue<StringValue> RotatedBoundingBox { get; set; }
	
    /// <summary>
    /// <para> alignmentLevel.</para>
    /// <para>Represents the following attribute in the schema: alignmentLevel </para>
    /// </summary>
    [SchemaAttr(0, "alignmentLevel")]
    [Index(3)]
    public Int32Value AlignmentLevel { get; set; }
	
    /// <summary>
    /// <para> contentType.</para>
    /// <para>Represents the following attribute in the schema: contentType </para>
    /// </summary>
    [SchemaAttr(0, "contentType")]
    [Index(4)]
    public Int32Value ContentType { get; set; }
	
    /// <summary>
    /// <para> ascender.</para>
    /// <para>Represents the following attribute in the schema: ascender </para>
    /// </summary>
    [SchemaAttr(0, "ascender")]
    [Index(5)]
    public StringValue Ascender { get; set; }
	
    /// <summary>
    /// <para> descender.</para>
    /// <para>Represents the following attribute in the schema: descender </para>
    /// </summary>
    [SchemaAttr(0, "descender")]
    [Index(6)]
    public StringValue Descender { get; set; }
	
    /// <summary>
    /// <para> baseline.</para>
    /// <para>Represents the following attribute in the schema: baseline </para>
    /// </summary>
    [SchemaAttr(0, "baseline")]
    [Index(7)]
    public StringValue Baseline { get; set; }
	
    /// <summary>
    /// <para> midline.</para>
    /// <para>Represents the following attribute in the schema: midline </para>
    /// </summary>
    [SchemaAttr(0, "midline")]
    [Index(8)]
    public StringValue Midline { get; set; }
	
    /// <summary>
    /// <para> customRecognizerId.</para>
    /// <para>Represents the following attribute in the schema: customRecognizerId </para>
    /// </summary>
    [SchemaAttr(0, "customRecognizerId")]
    [Index(9)]
    public StringValue CustomRecognizerId { get; set; }
	
    /// <summary>
    /// <para> mathML.</para>
    /// <para>Represents the following attribute in the schema: mathML </para>
    /// </summary>
    [SchemaAttr(0, "mathML")]
    [Index(10)]
    public StringValue MathML { get; set; }
	
    /// <summary>
    /// <para> mathStruct.</para>
    /// <para>Represents the following attribute in the schema: mathStruct </para>
    /// </summary>
    [SchemaAttr(0, "mathStruct")]
    [Index(11)]
    public StringValue MathStruct { get; set; }
	
    /// <summary>
    /// <para> mathSymbol.</para>
    /// <para>Represents the following attribute in the schema: mathSymbol </para>
    /// </summary>
    [SchemaAttr(0, "mathSymbol")]
    [Index(12)]
    public StringValue MathSymbol { get; set; }
	
    /// <summary>
    /// <para> beginModifierType.</para>
    /// <para>Represents the following attribute in the schema: beginModifierType </para>
    /// </summary>
    [SchemaAttr(0, "beginModifierType")]
    [Index(13)]
    public StringValue BeginModifierType { get; set; }
	
    /// <summary>
    /// <para> endModifierType.</para>
    /// <para>Represents the following attribute in the schema: endModifierType </para>
    /// </summary>
    [SchemaAttr(0, "endModifierType")]
    [Index(14)]
    public StringValue EndModifierType { get; set; }
	
    /// <summary>
    /// <para> rotationAngle.</para>
    /// <para>Represents the following attribute in the schema: rotationAngle </para>
    /// </summary>
    [SchemaAttr(0, "rotationAngle")]
    [Index(15)]
    public Int32Value RotationAngle { get; set; }
	
    /// <summary>
    /// <para> hotPoints.</para>
    /// <para>Represents the following attribute in the schema: hotPoints </para>
    /// </summary>
    [SchemaAttr(0, "hotPoints")]
    [Index(16)]
    public ListValue<StringValue> HotPoints { get; set; }
	
    /// <summary>
    /// <para> centroid.</para>
    /// <para>Represents the following attribute in the schema: centroid </para>
    /// </summary>
    [SchemaAttr(0, "centroid")]
    [Index(17)]
    public StringValue Centroid { get; set; }
	
    /// <summary>
    /// <para> semanticType.</para>
    /// <para>Represents the following attribute in the schema: semanticType </para>
    /// </summary>
    [SchemaAttr(0, "semanticType")]
    [Index(18)]
    public StringValue SemanticType { get; set; }
	
    /// <summary>
    /// <para> shapeName.</para>
    /// <para>Represents the following attribute in the schema: shapeName </para>
    /// </summary>
    [SchemaAttr(0, "shapeName")]
    [Index(19)]
    public StringValue ShapeName { get; set; }
	
    /// <summary>
    /// <para> shapeGeometry.</para>
    /// <para>Represents the following attribute in the schema: shapeGeometry </para>
    /// </summary>
    [SchemaAttr(0, "shapeGeometry")]
    [Index(20)]
    public ListValue<StringValue> ShapeGeometry { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextNode>(deep);

}
/// <summary>
/// <para>Defines the ContextNodeProperty Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is msink:property.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(45, "property")]
[Id(ElementTypeIdConst)]
public partial class ContextNodeProperty : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12759;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(0)]
    public StringValue Type { get; set; }
	

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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextNodeProperty>(deep);

}
/// <summary>
/// <para>Defines the SourceLink Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is msink:sourceLink.</para>
/// </summary>

[SchemaAttr(45, "sourceLink")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SourceLink : ContextLinkType
{
    internal const int ElementTypeIdConst = 12760;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the SourceLink class.
    /// </summary>
    public SourceLink():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SourceLink>(deep);

}
/// <summary>
/// <para>Defines the DestinationLink Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is msink:destinationLink.</para>
/// </summary>

[SchemaAttr(45, "destinationLink")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DestinationLink : ContextLinkType
{
    internal const int ElementTypeIdConst = 12761;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DestinationLink class.
    /// </summary>
    public DestinationLink():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DestinationLink>(deep);

}
/// <summary>
/// Defines the ContextLinkType class.
/// </summary>


public abstract partial class ContextLinkType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> direction.</para>
    /// <para>Represents the following attribute in the schema: direction </para>
    /// </summary>
    [SchemaAttr(0, "direction")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Ink.LinkDirectionValues> Direction { get; set; }
	
    /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    [Index(1)]
    public StringValue Reference { get; set; }
	

    
    
    
    /// <summary>
    /// Initializes a new instance of the ContextLinkType class.
    /// </summary>
    protected ContextLinkType(){}
    
    
    
}
/// <summary>
/// Defines the KnownContextNodeTypeValues enumeration. 
/// </summary> 
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
 
 
