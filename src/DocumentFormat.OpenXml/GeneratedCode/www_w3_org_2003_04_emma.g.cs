// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2010.Ink;

namespace DocumentFormat.OpenXml.EMMA
{
/// <summary>
/// <para>Defines the DerivedFrom Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:derived-from.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "derived-from")]
[Id(ElementTypeIdConst)]
public partial class DerivedFrom : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12741;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> resource.</para>
    /// <para>Represents the following attribute in the schema: resource </para>
    /// </summary>
    [SchemaAttr(0, "resource")]
    [Index(0)]
    public StringValue Resource { get; set; }
	
    /// <summary>
    /// <para> composite.</para>
    /// <para>Represents the following attribute in the schema: composite </para>
    /// </summary>
    [SchemaAttr(0, "composite")]
    [Index(1)]
    public BooleanValue Composite { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the DerivedFrom class.
    /// </summary>
    public DerivedFrom():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DerivedFrom>(deep);

}
/// <summary>
/// <para>Defines the Info Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:info.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "info")]
[Id(ElementTypeIdConst)]
public partial class Info : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12742;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Info>(deep);

}
/// <summary>
/// <para>Defines the Lattice Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:lattice.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Arc &lt;emma:arc></description></item>
///<item><description>Node &lt;emma:node></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Arc))]
    [ChildElementInfo(typeof(Node))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "lattice")]
[Id(ElementTypeIdConst)]
public partial class Lattice : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12743;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> initial.</para>
    /// <para>Represents the following attribute in the schema: initial </para>
    /// </summary>
    [SchemaAttr(0, "initial")]
    [Index(0)]
    public IntegerValue Initial { get; set; }
	
    /// <summary>
    /// <para> final.</para>
    /// <para>Represents the following attribute in the schema: final </para>
    /// </summary>
    [SchemaAttr(0, "final")]
    [Index(1)]
    public ListValue<DecimalValue> Final { get; set; }
	
    /// <summary>
    /// <para> time-ref-uri.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-uri </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-uri")]
    [Index(2)]
    public StringValue TimeReference { get; set; }
	
    /// <summary>
    /// <para> time-ref-anchor-point.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-anchor-point")]
    [Index(3)]
    public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Lattice>(deep);

}
/// <summary>
/// <para>Defines the Literal Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:literal.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "literal")]
[Id(ElementTypeIdConst)]
public partial class Literal : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12744;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Literal>(deep);

}
/// <summary>
/// <para>Defines the Interpretation Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

    [ChildElementInfo(typeof(DerivedFrom))]
    [ChildElementInfo(typeof(Info))]
    [ChildElementInfo(typeof(Lattice))]
    [ChildElementInfo(typeof(Literal))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Ink.ContextNode))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "interpretation")]
[Id(ElementTypeIdConst)]
public partial class Interpretation : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12745;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> tokens.</para>
    /// <para>Represents the following attribute in the schema: emma:tokens </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "tokens")]
    [Index(1)]
    public StringValue Tokens { get; set; }
	
    /// <summary>
    /// <para> process.</para>
    /// <para>Represents the following attribute in the schema: emma:process </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "process")]
    [Index(2)]
    public StringValue Process { get; set; }
	
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: emma:lang </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "lang")]
    [Index(3)]
    public StringValue Language { get; set; }
	
    /// <summary>
    /// <para> signal.</para>
    /// <para>Represents the following attribute in the schema: emma:signal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal")]
    [Index(4)]
    public StringValue Signal { get; set; }
	
    /// <summary>
    /// <para> signal-size.</para>
    /// <para>Represents the following attribute in the schema: emma:signal-size </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal-size")]
    [Index(5)]
    public IntegerValue SignalSize { get; set; }
	
    /// <summary>
    /// <para> media-type.</para>
    /// <para>Represents the following attribute in the schema: emma:media-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "media-type")]
    [Index(6)]
    public StringValue MediaType { get; set; }
	
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    [Index(7)]
    public DecimalValue Confidence { get; set; }
	
    /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: emma:source </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "source")]
    [Index(8)]
    public StringValue Source { get; set; }
	
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: emma:start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "start")]
    [Index(9)]
    public UInt64Value Start { get; set; }
	
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: emma:end </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "end")]
    [Index(10)]
    public UInt64Value End { get; set; }
	
    /// <summary>
    /// <para> time-ref-uri.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-uri </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-uri")]
    [Index(11)]
    public StringValue TimeReference { get; set; }
	
    /// <summary>
    /// <para> time-ref-anchor-point.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-anchor-point")]
    [Index(12)]
    public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint { get; set; }
	
    /// <summary>
    /// <para> offset-to-start.</para>
    /// <para>Represents the following attribute in the schema: emma:offset-to-start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "offset-to-start")]
    [Index(13)]
    public IntegerValue OffsetToStart { get; set; }
	
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: emma:duration </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "duration")]
    [Index(14)]
    public IntegerValue Duration { get; set; }
	
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    [Index(15)]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium { get; set; }
	
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    [Index(16)]
    public ListValue<StringValue> Mode { get; set; }
	
    /// <summary>
    /// <para> function.</para>
    /// <para>Represents the following attribute in the schema: emma:function </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "function")]
    [Index(17)]
    public StringValue Function { get; set; }
	
    /// <summary>
    /// <para> verbal.</para>
    /// <para>Represents the following attribute in the schema: emma:verbal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "verbal")]
    [Index(18)]
    public BooleanValue Verbal { get; set; }
	
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    [Index(19)]
    public DecimalValue Cost { get; set; }
	
    /// <summary>
    /// <para> grammar-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:grammar-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "grammar-ref")]
    [Index(20)]
    public StringValue GrammarRef { get; set; }
	
    /// <summary>
    /// <para> endpoint-info-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-info-ref")]
    [Index(21)]
    public StringValue EndpointInfoRef { get; set; }
	
    /// <summary>
    /// <para> model-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:model-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "model-ref")]
    [Index(22)]
    public StringValue ModelRef { get; set; }
	
    /// <summary>
    /// <para> dialog-turn.</para>
    /// <para>Represents the following attribute in the schema: emma:dialog-turn </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "dialog-turn")]
    [Index(23)]
    public StringValue DialogTurn { get; set; }
	
    /// <summary>
    /// <para> no-input.</para>
    /// <para>Represents the following attribute in the schema: emma:no-input </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "no-input")]
    [Index(24)]
    public BooleanValue NoInput { get; set; }
	
    /// <summary>
    /// <para> uninterpreted.</para>
    /// <para>Represents the following attribute in the schema: emma:uninterpreted </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "uninterpreted")]
    [Index(25)]
    public BooleanValue Uninterpreted { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Interpretation>(deep);

}
/// <summary>
/// <para>Defines the OneOf Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

    [ChildElementInfo(typeof(DerivedFrom))]
    [ChildElementInfo(typeof(Info))]
    [ChildElementInfo(typeof(Interpretation))]
    [ChildElementInfo(typeof(OneOf))]
    [ChildElementInfo(typeof(Group))]
    [ChildElementInfo(typeof(Sequence))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "one-of")]
[Id(ElementTypeIdConst)]
public partial class OneOf : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12746;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> disjunction-type.</para>
    /// <para>Represents the following attribute in the schema: disjunction-type </para>
    /// </summary>
    [SchemaAttr(0, "disjunction-type")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.EMMA.DisjunctionTypeValues> DisjunctionType { get; set; }
	
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(1)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> tokens.</para>
    /// <para>Represents the following attribute in the schema: emma:tokens </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "tokens")]
    [Index(2)]
    public StringValue Tokens { get; set; }
	
    /// <summary>
    /// <para> process.</para>
    /// <para>Represents the following attribute in the schema: emma:process </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "process")]
    [Index(3)]
    public StringValue Process { get; set; }
	
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: emma:lang </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "lang")]
    [Index(4)]
    public StringValue Language { get; set; }
	
    /// <summary>
    /// <para> signal.</para>
    /// <para>Represents the following attribute in the schema: emma:signal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal")]
    [Index(5)]
    public StringValue Signal { get; set; }
	
    /// <summary>
    /// <para> signal-size.</para>
    /// <para>Represents the following attribute in the schema: emma:signal-size </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal-size")]
    [Index(6)]
    public IntegerValue SignalSize { get; set; }
	
    /// <summary>
    /// <para> media-type.</para>
    /// <para>Represents the following attribute in the schema: emma:media-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "media-type")]
    [Index(7)]
    public StringValue MediaType { get; set; }
	
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    [Index(8)]
    public DecimalValue Confidence { get; set; }
	
    /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: emma:source </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "source")]
    [Index(9)]
    public StringValue Source { get; set; }
	
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: emma:start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "start")]
    [Index(10)]
    public UInt64Value Start { get; set; }
	
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: emma:end </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "end")]
    [Index(11)]
    public UInt64Value End { get; set; }
	
    /// <summary>
    /// <para> time-ref-uri.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-uri </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-uri")]
    [Index(12)]
    public StringValue TimeReference { get; set; }
	
    /// <summary>
    /// <para> time-ref-anchor-point.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-anchor-point")]
    [Index(13)]
    public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint { get; set; }
	
    /// <summary>
    /// <para> offset-to-start.</para>
    /// <para>Represents the following attribute in the schema: emma:offset-to-start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "offset-to-start")]
    [Index(14)]
    public IntegerValue OffsetToStart { get; set; }
	
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: emma:duration </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "duration")]
    [Index(15)]
    public IntegerValue Duration { get; set; }
	
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    [Index(16)]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium { get; set; }
	
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    [Index(17)]
    public ListValue<StringValue> Mode { get; set; }
	
    /// <summary>
    /// <para> function.</para>
    /// <para>Represents the following attribute in the schema: emma:function </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "function")]
    [Index(18)]
    public StringValue Function { get; set; }
	
    /// <summary>
    /// <para> verbal.</para>
    /// <para>Represents the following attribute in the schema: emma:verbal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "verbal")]
    [Index(19)]
    public BooleanValue Verbal { get; set; }
	
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    [Index(20)]
    public DecimalValue Cost { get; set; }
	
    /// <summary>
    /// <para> grammar-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:grammar-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "grammar-ref")]
    [Index(21)]
    public StringValue GrammarRef { get; set; }
	
    /// <summary>
    /// <para> endpoint-info-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-info-ref")]
    [Index(22)]
    public StringValue EndpointInfoRef { get; set; }
	
    /// <summary>
    /// <para> model-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:model-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "model-ref")]
    [Index(23)]
    public StringValue ModelRef { get; set; }
	
    /// <summary>
    /// <para> dialog-turn.</para>
    /// <para>Represents the following attribute in the schema: emma:dialog-turn </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "dialog-turn")]
    [Index(24)]
    public StringValue DialogTurn { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OneOf>(deep);

}
/// <summary>
/// <para>Defines the Group Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

    [ChildElementInfo(typeof(DerivedFrom))]
    [ChildElementInfo(typeof(GroupInfo))]
    [ChildElementInfo(typeof(Info))]
    [ChildElementInfo(typeof(Interpretation))]
    [ChildElementInfo(typeof(OneOf))]
    [ChildElementInfo(typeof(Group))]
    [ChildElementInfo(typeof(Sequence))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "group")]
[Id(ElementTypeIdConst)]
public partial class Group : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12747;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> tokens.</para>
    /// <para>Represents the following attribute in the schema: emma:tokens </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "tokens")]
    [Index(1)]
    public StringValue Tokens { get; set; }
	
    /// <summary>
    /// <para> process.</para>
    /// <para>Represents the following attribute in the schema: emma:process </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "process")]
    [Index(2)]
    public StringValue Process { get; set; }
	
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: emma:lang </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "lang")]
    [Index(3)]
    public StringValue Language { get; set; }
	
    /// <summary>
    /// <para> signal.</para>
    /// <para>Represents the following attribute in the schema: emma:signal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal")]
    [Index(4)]
    public StringValue Signal { get; set; }
	
    /// <summary>
    /// <para> signal-size.</para>
    /// <para>Represents the following attribute in the schema: emma:signal-size </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal-size")]
    [Index(5)]
    public IntegerValue SignalSize { get; set; }
	
    /// <summary>
    /// <para> media-type.</para>
    /// <para>Represents the following attribute in the schema: emma:media-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "media-type")]
    [Index(6)]
    public StringValue MediaType { get; set; }
	
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    [Index(7)]
    public DecimalValue Confidence { get; set; }
	
    /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: emma:source </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "source")]
    [Index(8)]
    public StringValue Source { get; set; }
	
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: emma:start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "start")]
    [Index(9)]
    public UInt64Value Start { get; set; }
	
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: emma:end </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "end")]
    [Index(10)]
    public UInt64Value End { get; set; }
	
    /// <summary>
    /// <para> time-ref-uri.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-uri </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-uri")]
    [Index(11)]
    public StringValue TimeReference { get; set; }
	
    /// <summary>
    /// <para> time-ref-anchor-point.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-anchor-point")]
    [Index(12)]
    public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint { get; set; }
	
    /// <summary>
    /// <para> offset-to-start.</para>
    /// <para>Represents the following attribute in the schema: emma:offset-to-start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "offset-to-start")]
    [Index(13)]
    public IntegerValue OffsetToStart { get; set; }
	
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: emma:duration </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "duration")]
    [Index(14)]
    public IntegerValue Duration { get; set; }
	
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    [Index(15)]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium { get; set; }
	
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    [Index(16)]
    public ListValue<StringValue> Mode { get; set; }
	
    /// <summary>
    /// <para> function.</para>
    /// <para>Represents the following attribute in the schema: emma:function </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "function")]
    [Index(17)]
    public StringValue Function { get; set; }
	
    /// <summary>
    /// <para> verbal.</para>
    /// <para>Represents the following attribute in the schema: emma:verbal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "verbal")]
    [Index(18)]
    public BooleanValue Verbal { get; set; }
	
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    [Index(19)]
    public DecimalValue Cost { get; set; }
	
    /// <summary>
    /// <para> grammar-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:grammar-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "grammar-ref")]
    [Index(20)]
    public StringValue GrammarRef { get; set; }
	
    /// <summary>
    /// <para> endpoint-info-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-info-ref")]
    [Index(21)]
    public StringValue EndpointInfoRef { get; set; }
	
    /// <summary>
    /// <para> model-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:model-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "model-ref")]
    [Index(22)]
    public StringValue ModelRef { get; set; }
	
    /// <summary>
    /// <para> dialog-turn.</para>
    /// <para>Represents the following attribute in the schema: emma:dialog-turn </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "dialog-turn")]
    [Index(23)]
    public StringValue DialogTurn { get; set; }
	

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
/// <para>Defines the Sequence Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

    [ChildElementInfo(typeof(DerivedFrom))]
    [ChildElementInfo(typeof(Info))]
    [ChildElementInfo(typeof(Interpretation))]
    [ChildElementInfo(typeof(OneOf))]
    [ChildElementInfo(typeof(Group))]
    [ChildElementInfo(typeof(Sequence))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "sequence")]
[Id(ElementTypeIdConst)]
public partial class Sequence : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12748;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> tokens.</para>
    /// <para>Represents the following attribute in the schema: emma:tokens </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "tokens")]
    [Index(1)]
    public StringValue Tokens { get; set; }
	
    /// <summary>
    /// <para> process.</para>
    /// <para>Represents the following attribute in the schema: emma:process </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "process")]
    [Index(2)]
    public StringValue Process { get; set; }
	
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: emma:lang </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "lang")]
    [Index(3)]
    public StringValue Language { get; set; }
	
    /// <summary>
    /// <para> signal.</para>
    /// <para>Represents the following attribute in the schema: emma:signal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal")]
    [Index(4)]
    public StringValue Signal { get; set; }
	
    /// <summary>
    /// <para> signal-size.</para>
    /// <para>Represents the following attribute in the schema: emma:signal-size </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "signal-size")]
    [Index(5)]
    public IntegerValue SignalSize { get; set; }
	
    /// <summary>
    /// <para> media-type.</para>
    /// <para>Represents the following attribute in the schema: emma:media-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "media-type")]
    [Index(6)]
    public StringValue MediaType { get; set; }
	
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    [Index(7)]
    public DecimalValue Confidence { get; set; }
	
    /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: emma:source </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "source")]
    [Index(8)]
    public StringValue Source { get; set; }
	
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: emma:start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "start")]
    [Index(9)]
    public UInt64Value Start { get; set; }
	
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: emma:end </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "end")]
    [Index(10)]
    public UInt64Value End { get; set; }
	
    /// <summary>
    /// <para> time-ref-uri.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-uri </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-uri")]
    [Index(11)]
    public StringValue TimeReference { get; set; }
	
    /// <summary>
    /// <para> time-ref-anchor-point.</para>
    /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "time-ref-anchor-point")]
    [Index(12)]
    public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint { get; set; }
	
    /// <summary>
    /// <para> offset-to-start.</para>
    /// <para>Represents the following attribute in the schema: emma:offset-to-start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "offset-to-start")]
    [Index(13)]
    public IntegerValue OffsetToStart { get; set; }
	
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: emma:duration </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "duration")]
    [Index(14)]
    public IntegerValue Duration { get; set; }
	
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    [Index(15)]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium { get; set; }
	
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    [Index(16)]
    public ListValue<StringValue> Mode { get; set; }
	
    /// <summary>
    /// <para> function.</para>
    /// <para>Represents the following attribute in the schema: emma:function </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "function")]
    [Index(17)]
    public StringValue Function { get; set; }
	
    /// <summary>
    /// <para> verbal.</para>
    /// <para>Represents the following attribute in the schema: emma:verbal </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "verbal")]
    [Index(18)]
    public BooleanValue Verbal { get; set; }
	
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    [Index(19)]
    public DecimalValue Cost { get; set; }
	
    /// <summary>
    /// <para> grammar-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:grammar-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "grammar-ref")]
    [Index(20)]
    public StringValue GrammarRef { get; set; }
	
    /// <summary>
    /// <para> endpoint-info-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-info-ref")]
    [Index(21)]
    public StringValue EndpointInfoRef { get; set; }
	
    /// <summary>
    /// <para> model-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:model-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "model-ref")]
    [Index(22)]
    public StringValue ModelRef { get; set; }
	
    /// <summary>
    /// <para> dialog-turn.</para>
    /// <para>Represents the following attribute in the schema: emma:dialog-turn </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "dialog-turn")]
    [Index(23)]
    public StringValue DialogTurn { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sequence>(deep);

}
/// <summary>
/// <para>Defines the GroupInfo Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:group-info.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "group-info")]
[Id(ElementTypeIdConst)]
public partial class GroupInfo : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12749;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    [Index(0)]
    public StringValue Reference { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupInfo>(deep);

}
/// <summary>
/// <para>Defines the Derivation Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

    [ChildElementInfo(typeof(Interpretation))]
    [ChildElementInfo(typeof(OneOf))]
    [ChildElementInfo(typeof(Sequence))]
    [ChildElementInfo(typeof(Group))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "derivation")]
[Id(ElementTypeIdConst)]
public partial class Derivation : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12750;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Derivation>(deep);

}
/// <summary>
/// <para>Defines the Grammar Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:grammar.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "grammar")]
[Id(ElementTypeIdConst)]
public partial class Grammar : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12751;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    [Index(1)]
    public StringValue Reference { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Grammar class.
    /// </summary>
    public Grammar():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Grammar>(deep);

}
/// <summary>
/// <para>Defines the Model Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:model.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "model")]
[Id(ElementTypeIdConst)]
public partial class Model : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12752;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    [Index(1)]
    public StringValue Reference { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model>(deep);

}
/// <summary>
/// <para>Defines the EndPointInfo Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:endpoint-info.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>EndPoint &lt;emma:endpoint></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(EndPoint))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "endpoint-info")]
[Id(ElementTypeIdConst)]
public partial class EndPointInfo : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12753;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndPointInfo>(deep);

}
/// <summary>
/// <para>Defines the EndPoint Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:endpoint.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "endpoint")]
[Id(ElementTypeIdConst)]
public partial class EndPoint : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12754;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> endpoint-role.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-role </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-role")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.EMMA.EndPointRoleValues> EndpointRole { get; set; }
	
    /// <summary>
    /// <para> endpoint-address.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-address </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-address")]
    [Index(2)]
    public StringValue EndPointAddress { get; set; }
	
    /// <summary>
    /// <para> message-id.</para>
    /// <para>Represents the following attribute in the schema: emma:message-id </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "message-id")]
    [Index(3)]
    public StringValue MessageId { get; set; }
	
    /// <summary>
    /// <para> port-num.</para>
    /// <para>Represents the following attribute in the schema: emma:port-num </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "port-num")]
    [Index(4)]
    public IntegerValue PortNumber { get; set; }
	
    /// <summary>
    /// <para> port-type.</para>
    /// <para>Represents the following attribute in the schema: emma:port-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "port-type")]
    [Index(5)]
    public StringValue PortType { get; set; }
	
    /// <summary>
    /// <para> endpoint-pair-ref.</para>
    /// <para>Represents the following attribute in the schema: emma:endpoint-pair-ref </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "endpoint-pair-ref")]
    [Index(6)]
    public StringValue EndpointPairRef { get; set; }
	
    /// <summary>
    /// <para> service-name.</para>
    /// <para>Represents the following attribute in the schema: emma:service-name </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "service-name")]
    [Index(7)]
    public StringValue ServiceName { get; set; }
	
    /// <summary>
    /// <para> media-type.</para>
    /// <para>Represents the following attribute in the schema: emma:media-type </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "media-type")]
    [Index(8)]
    public StringValue MediaType { get; set; }
	
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    [Index(9)]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium { get; set; }
	
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    [Index(10)]
    public ListValue<StringValue> Mode { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndPoint>(deep);

}
/// <summary>
/// <para>Defines the Node Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:node.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Info &lt;emma:info></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Info))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "node")]
[Id(ElementTypeIdConst)]
public partial class Node : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12755;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> node-number.</para>
    /// <para>Represents the following attribute in the schema: node-number </para>
    /// </summary>
    [SchemaAttr(0, "node-number")]
    [Index(0)]
    public IntegerValue NodeNumber { get; set; }
	
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    [Index(1)]
    public DecimalValue Confidence { get; set; }
	
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    [Index(2)]
    public DecimalValue Cost { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Node>(deep);

}
/// <summary>
/// <para>Defines the Arc Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is emma:arc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Info &lt;emma:info></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Info))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "arc")]
[Id(ElementTypeIdConst)]
public partial class Arc : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12756;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> from.</para>
    /// <para>Represents the following attribute in the schema: from </para>
    /// </summary>
    [SchemaAttr(0, "from")]
    [Index(0)]
    public IntegerValue From { get; set; }
	
    /// <summary>
    /// <para> to.</para>
    /// <para>Represents the following attribute in the schema: to </para>
    /// </summary>
    [SchemaAttr(0, "to")]
    [Index(1)]
    public IntegerValue To { get; set; }
	
    /// <summary>
    /// <para> start.</para>
    /// <para>Represents the following attribute in the schema: emma:start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "start")]
    [Index(2)]
    public UInt64Value Start { get; set; }
	
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: emma:end </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "end")]
    [Index(3)]
    public UInt64Value End { get; set; }
	
    /// <summary>
    /// <para> offset-to-start.</para>
    /// <para>Represents the following attribute in the schema: emma:offset-to-start </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "offset-to-start")]
    [Index(4)]
    public IntegerValue OffsetToStart { get; set; }
	
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: emma:duration </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "duration")]
    [Index(5)]
    public IntegerValue Duration { get; set; }
	
    /// <summary>
    /// <para> confidence.</para>
    /// <para>Represents the following attribute in the schema: emma:confidence </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "confidence")]
    [Index(6)]
    public DecimalValue Confidence { get; set; }
	
    /// <summary>
    /// <para> cost.</para>
    /// <para>Represents the following attribute in the schema: emma:cost </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "cost")]
    [Index(7)]
    public DecimalValue Cost { get; set; }
	
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: emma:lang </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "lang")]
    [Index(8)]
    public StringValue Language { get; set; }
	
    /// <summary>
    /// <para> medium.</para>
    /// <para>Represents the following attribute in the schema: emma:medium </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "medium")]
    [Index(9)]
    public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium { get; set; }
	
    /// <summary>
    /// <para> mode.</para>
    /// <para>Represents the following attribute in the schema: emma:mode </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "mode")]
    [Index(10)]
    public ListValue<StringValue> Mode { get; set; }
	
    /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: emma:source </para>
    /// </summary>
///<remark> xmlns:emma=http://www.w3.org/2003/04/emma
///</remark>
    [SchemaAttr(44, "source")]
    [Index(11)]
    public StringValue Source { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Arc>(deep);

}
/// <summary>
/// <para>Defines the Emma Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

    [ChildElementInfo(typeof(Derivation))]
    [ChildElementInfo(typeof(Grammar))]
    [ChildElementInfo(typeof(Model))]
    [ChildElementInfo(typeof(EndPointInfo))]
    [ChildElementInfo(typeof(Info))]
    [ChildElementInfo(typeof(Interpretation))]
    [ChildElementInfo(typeof(OneOf))]
    [ChildElementInfo(typeof(Group))]
    [ChildElementInfo(typeof(Sequence))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(44, "emma")]
[Id(ElementTypeIdConst)]
public partial class Emma : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12757;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> version.</para>
    /// <para>Represents the following attribute in the schema: version </para>
    /// </summary>
    [SchemaAttr(0, "version")]
    [Index(0)]
    public StringValue Version { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Emma>(deep);

}
/// <summary>
/// Defines the EndPointRoleValues enumeration. 
/// </summary> 
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
 
 
