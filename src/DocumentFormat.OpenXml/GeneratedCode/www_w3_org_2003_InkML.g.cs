// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.InkML
{
/// <summary>
/// <para>Defines the Ink Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:ink.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Annotation &lt;inkml:annotation></description></item>
///<item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
///<item><description>Definitions &lt;inkml:definitions></description></item>
///<item><description>Context &lt;inkml:context></description></item>
///<item><description>Trace &lt;inkml:trace></description></item>
///<item><description>TraceGroup &lt;inkml:traceGroup></description></item>
///<item><description>TraceView &lt;inkml:traceView></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Annotation))]
    [ChildElementInfo(typeof(AnnotationXml))]
    [ChildElementInfo(typeof(Definitions))]
    [ChildElementInfo(typeof(Context))]
    [ChildElementInfo(typeof(Trace))]
    [ChildElementInfo(typeof(TraceGroup))]
    [ChildElementInfo(typeof(TraceView))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "ink")]
[Id(ElementTypeIdConst)]
public partial class Ink : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12714;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> documentID.</para>
    /// <para>Represents the following attribute in the schema: documentID </para>
    /// </summary>
    [SchemaAttr(0, "documentID")]
    [Index(0)]
    public StringValue DocumentId { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Ink class.
    /// </summary>
    public Ink():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Ink class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Ink(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Ink class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Ink(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Ink class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Ink(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ink>(deep);

}
/// <summary>
/// <para>Defines the Bind Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:bind.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "bind")]
[Id(ElementTypeIdConst)]
public partial class Bind : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12715;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> source.</para>
    /// <para>Represents the following attribute in the schema: source </para>
    /// </summary>
    [SchemaAttr(0, "source")]
    [Index(0)]
    public StringValue Source { get; set; }
	
    /// <summary>
    /// <para> target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    [Index(1)]
    public StringValue Target { get; set; }
	
    /// <summary>
    /// <para> column.</para>
    /// <para>Represents the following attribute in the schema: column </para>
    /// </summary>
    [SchemaAttr(0, "column")]
    [Index(2)]
    public StringValue Column { get; set; }
	
    /// <summary>
    /// <para> variable.</para>
    /// <para>Represents the following attribute in the schema: variable </para>
    /// </summary>
    [SchemaAttr(0, "variable")]
    [Index(3)]
    public StringValue Variable { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Bind class.
    /// </summary>
    public Bind():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bind>(deep);

}
/// <summary>
/// <para>Defines the Table Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:table.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "table")]
[Id(ElementTypeIdConst)]
public partial class Table : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12716;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> apply.</para>
    /// <para>Represents the following attribute in the schema: apply </para>
    /// </summary>
    [SchemaAttr(0, "apply")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.InkML.TableApplyValues> Apply { get; set; }
	
    /// <summary>
    /// <para> interpolation.</para>
    /// <para>Represents the following attribute in the schema: interpolation </para>
    /// </summary>
    [SchemaAttr(0, "interpolation")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.InkML.TableInterpolationValues> Interpolation { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Table class.
    /// </summary>
    public Table():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the Table class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Table(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Table>(deep);

}
/// <summary>
/// <para>Defines the Matrix Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:matrix.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "matrix")]
[Id(ElementTypeIdConst)]
public partial class Matrix : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12717;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Matrix class.
    /// </summary>
    public Matrix():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the Matrix class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Matrix(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Matrix>(deep);

}
/// <summary>
/// <para>Defines the Mapping Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:mapping.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Bind &lt;inkml:bind></description></item>
///<item><description>Table &lt;inkml:table></description></item>
///<item><description>Matrix &lt;inkml:matrix></description></item>
///<item><description>Mapping &lt;inkml:mapping></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Bind))]
    [ChildElementInfo(typeof(Table))]
    [ChildElementInfo(typeof(Matrix))]
    [ChildElementInfo(typeof(Mapping))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "mapping")]
[Id(ElementTypeIdConst)]
public partial class Mapping : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12718;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.InkML.MappingTypeValues> Type { get; set; }
	
    /// <summary>
    /// <para> mappingRef.</para>
    /// <para>Represents the following attribute in the schema: mappingRef </para>
    /// </summary>
    [SchemaAttr(0, "mappingRef")]
    [Index(2)]
    public StringValue MappingRef { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Mapping class.
    /// </summary>
    public Mapping():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Mapping class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Mapping(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Mapping class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Mapping(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Mapping class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Mapping(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mapping>(deep);

}
/// <summary>
/// <para>Defines the Channel Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:channel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Mapping &lt;inkml:mapping></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Mapping))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "channel")]
[Id(ElementTypeIdConst)]
public partial class Channel : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12719;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(1)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.InkML.ChannelDataTypeValues> Type { get; set; }
	
    /// <summary>
    /// <para> default.</para>
    /// <para>Represents the following attribute in the schema: default </para>
    /// </summary>
    [SchemaAttr(0, "default")]
    [Index(3)]
    public StringValue Default { get; set; }
	
    /// <summary>
    /// <para> min.</para>
    /// <para>Represents the following attribute in the schema: min </para>
    /// </summary>
    [SchemaAttr(0, "min")]
    [Index(4)]
    public DecimalValue Min { get; set; }
	
    /// <summary>
    /// <para> max.</para>
    /// <para>Represents the following attribute in the schema: max </para>
    /// </summary>
    [SchemaAttr(0, "max")]
    [Index(5)]
    public DecimalValue Max { get; set; }
	
    /// <summary>
    /// <para> orientation.</para>
    /// <para>Represents the following attribute in the schema: orientation </para>
    /// </summary>
    [SchemaAttr(0, "orientation")]
    [Index(6)]
    public EnumValue<DocumentFormat.OpenXml.InkML.ChannelValueOrientationValues> Orientation { get; set; }
	
    /// <summary>
    /// <para> respectTo.</para>
    /// <para>Represents the following attribute in the schema: respectTo </para>
    /// </summary>
    [SchemaAttr(0, "respectTo")]
    [Index(7)]
    public StringValue RespectTo { get; set; }
	
    /// <summary>
    /// <para> units.</para>
    /// <para>Represents the following attribute in the schema: units </para>
    /// </summary>
    [SchemaAttr(0, "units")]
    [Index(8)]
    public StringValue Units { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Channel class.
    /// </summary>
    public Channel():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Channel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Channel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Channel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Channel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Channel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Channel(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Channel>(deep);

}
/// <summary>
/// <para>Defines the IntermittentChannels Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:intermittentChannels.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Channel &lt;inkml:channel></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Channel))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "intermittentChannels")]
[Id(ElementTypeIdConst)]
public partial class IntermittentChannels : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12720;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the IntermittentChannels class.
    /// </summary>
    public IntermittentChannels():base(){}
    
        /// <summary>
    ///Initializes a new instance of the IntermittentChannels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public IntermittentChannels(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the IntermittentChannels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public IntermittentChannels(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the IntermittentChannels class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public IntermittentChannels(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntermittentChannels>(deep);

}
/// <summary>
/// <para>Defines the ChannelProperty Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:channelProperty.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "channelProperty")]
[Id(ElementTypeIdConst)]
public partial class ChannelProperty : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12721;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> channel.</para>
    /// <para>Represents the following attribute in the schema: channel </para>
    /// </summary>
    [SchemaAttr(0, "channel")]
    [Index(0)]
    public StringValue Channel { get; set; }
	
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(1)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    [Index(2)]
    public DecimalValue Value { get; set; }
	
    /// <summary>
    /// <para> units.</para>
    /// <para>Represents the following attribute in the schema: units </para>
    /// </summary>
    [SchemaAttr(0, "units")]
    [Index(3)]
    public StringValue Units { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ChannelProperty class.
    /// </summary>
    public ChannelProperty():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChannelProperty>(deep);

}
/// <summary>
/// <para>Defines the TraceFormat Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:traceFormat.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Channel &lt;inkml:channel></description></item>
///<item><description>IntermittentChannels &lt;inkml:intermittentChannels></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Channel))]
    [ChildElementInfo(typeof(IntermittentChannels))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "traceFormat")]
[Id(ElementTypeIdConst)]
public partial class TraceFormat : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12722;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TraceFormat class.
    /// </summary>
    public TraceFormat():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TraceFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceFormat(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceFormat(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceFormat class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TraceFormat(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TraceFormat>(deep);

}
/// <summary>
/// <para>Defines the SampleRate Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:sampleRate.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "sampleRate")]
[Id(ElementTypeIdConst)]
public partial class SampleRate : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12723;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> uniform.</para>
    /// <para>Represents the following attribute in the schema: uniform </para>
    /// </summary>
    [SchemaAttr(0, "uniform")]
    [Index(0)]
    public BooleanValue Uniform { get; set; }
	
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    [Index(1)]
    public DecimalValue Value { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the SampleRate class.
    /// </summary>
    public SampleRate():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SampleRate>(deep);

}
/// <summary>
/// <para>Defines the Latency Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:latency.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "latency")]
[Id(ElementTypeIdConst)]
public partial class Latency : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12724;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    [Index(0)]
    public DecimalValue Value { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Latency class.
    /// </summary>
    public Latency():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Latency>(deep);

}
/// <summary>
/// <para>Defines the ActiveArea Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:activeArea.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "activeArea")]
[Id(ElementTypeIdConst)]
public partial class ActiveArea : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12725;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    [Index(0)]
    public StringValue Size { get; set; }
	
    /// <summary>
    /// <para> height.</para>
    /// <para>Represents the following attribute in the schema: height </para>
    /// </summary>
    [SchemaAttr(0, "height")]
    [Index(1)]
    public DecimalValue Height { get; set; }
	
    /// <summary>
    /// <para> width.</para>
    /// <para>Represents the following attribute in the schema: width </para>
    /// </summary>
    [SchemaAttr(0, "width")]
    [Index(2)]
    public DecimalValue Width { get; set; }
	
    /// <summary>
    /// <para> units.</para>
    /// <para>Represents the following attribute in the schema: units </para>
    /// </summary>
    [SchemaAttr(0, "units")]
    [Index(3)]
    public StringValue Units { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ActiveArea class.
    /// </summary>
    public ActiveArea():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ActiveArea>(deep);

}
/// <summary>
/// <para>Defines the SourceProperty Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:srcProperty.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "srcProperty")]
[Id(ElementTypeIdConst)]
public partial class SourceProperty : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12726;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    [Index(1)]
    public DecimalValue Value { get; set; }
	
    /// <summary>
    /// <para> units.</para>
    /// <para>Represents the following attribute in the schema: units </para>
    /// </summary>
    [SchemaAttr(0, "units")]
    [Index(2)]
    public StringValue Units { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the SourceProperty class.
    /// </summary>
    public SourceProperty():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SourceProperty>(deep);

}
/// <summary>
/// <para>Defines the ChannelProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:channelProperties.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChannelProperty &lt;inkml:channelProperty></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ChannelProperty))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "channelProperties")]
[Id(ElementTypeIdConst)]
public partial class ChannelProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12727;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ChannelProperties class.
    /// </summary>
    public ChannelProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ChannelProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChannelProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChannelProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChannelProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChannelProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChannelProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChannelProperties>(deep);

}
/// <summary>
/// <para>Defines the Annotation Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:annotation.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "annotation")]
[Id(ElementTypeIdConst)]
public partial class Annotation : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12728;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(0)]
    public StringValue Type { get; set; }
	
    /// <summary>
    /// <para> encoding.</para>
    /// <para>Represents the following attribute in the schema: encoding </para>
    /// </summary>
    [SchemaAttr(0, "encoding")]
    [Index(1)]
    public StringValue Encoding { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Annotation class.
    /// </summary>
    public Annotation():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the Annotation class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Annotation(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Annotation>(deep);

}
/// <summary>
/// <para>Defines the AnnotationXml Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:annotationXML.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.EMMA.Emma &lt;emma:emma></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.EMMA.Emma))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "annotationXML")]
[Id(ElementTypeIdConst)]
public partial class AnnotationXml : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12729;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(0)]
    public StringValue Type { get; set; }
	
    /// <summary>
    /// <para> encoding.</para>
    /// <para>Represents the following attribute in the schema: encoding </para>
    /// </summary>
    [SchemaAttr(0, "encoding")]
    [Index(1)]
    public StringValue Encoding { get; set; }
	
    /// <summary>
    /// <para> href.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    [Index(2)]
    public StringValue Href { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the AnnotationXml class.
    /// </summary>
    public AnnotationXml():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AnnotationXml class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AnnotationXml(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AnnotationXml class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AnnotationXml(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AnnotationXml class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AnnotationXml(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Emma.</para>
    /// <para> Represents the following element tag in the schema: emma:emma </para>
    /// </summary>
    /// <remark>
    /// xmlns:emma = http://www.w3.org/2003/04/emma
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.EMMA.Emma Emma
	{
        get => GetElement<DocumentFormat.OpenXml.EMMA.Emma>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnnotationXml>(deep);

}
/// <summary>
/// <para>Defines the BrushProperty Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:brushProperty.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Annotation &lt;inkml:annotation></description></item>
///<item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Annotation))]
    [ChildElementInfo(typeof(AnnotationXml))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "brushProperty")]
[Id(ElementTypeIdConst)]
public partial class BrushProperty : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12730;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    [Index(1)]
    public StringValue Value { get; set; }
	
    /// <summary>
    /// <para> units.</para>
    /// <para>Represents the following attribute in the schema: units </para>
    /// </summary>
    [SchemaAttr(0, "units")]
    [Index(2)]
    public StringValue Units { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the BrushProperty class.
    /// </summary>
    public BrushProperty():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BrushProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BrushProperty(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BrushProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BrushProperty(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BrushProperty class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BrushProperty(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BrushProperty>(deep);

}
/// <summary>
/// <para>Defines the Canvas Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:canvas.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TraceFormat &lt;inkml:traceFormat></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TraceFormat))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "canvas")]
[Id(ElementTypeIdConst)]
public partial class Canvas : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12731;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> traceFormatRef.</para>
    /// <para>Represents the following attribute in the schema: traceFormatRef </para>
    /// </summary>
    [SchemaAttr(0, "traceFormatRef")]
    [Index(1)]
    public StringValue TraceFormatRef { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Canvas class.
    /// </summary>
    public Canvas():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Canvas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Canvas(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Canvas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Canvas(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Canvas class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Canvas(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> TraceFormat.</para>
    /// <para> Represents the following element tag in the schema: inkml:traceFormat </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(0)]
    public TraceFormat TraceFormat
	{
        get => GetElement<TraceFormat>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Canvas>(deep);

}
/// <summary>
/// <para>Defines the CanvasTransform Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:canvasTransform.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Mapping &lt;inkml:mapping></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Mapping))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "canvasTransform")]
[Id(ElementTypeIdConst)]
public partial class CanvasTransform : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12732;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> invertible.</para>
    /// <para>Represents the following attribute in the schema: invertible </para>
    /// </summary>
    [SchemaAttr(0, "invertible")]
    [Index(1)]
    public BooleanValue Invertible { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the CanvasTransform class.
    /// </summary>
    public CanvasTransform():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CanvasTransform class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CanvasTransform(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CanvasTransform class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CanvasTransform(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CanvasTransform class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CanvasTransform(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CanvasTransform>(deep);

}
/// <summary>
/// <para>Defines the InkSource Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:inkSource.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TraceFormat &lt;inkml:traceFormat></description></item>
///<item><description>SampleRate &lt;inkml:sampleRate></description></item>
///<item><description>Latency &lt;inkml:latency></description></item>
///<item><description>ActiveArea &lt;inkml:activeArea></description></item>
///<item><description>SourceProperty &lt;inkml:srcProperty></description></item>
///<item><description>ChannelProperties &lt;inkml:channelProperties></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TraceFormat))]
    [ChildElementInfo(typeof(SampleRate))]
    [ChildElementInfo(typeof(Latency))]
    [ChildElementInfo(typeof(ActiveArea))]
    [ChildElementInfo(typeof(SourceProperty))]
    [ChildElementInfo(typeof(ChannelProperties))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "inkSource")]
[Id(ElementTypeIdConst)]
public partial class InkSource : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12733;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> manufacturer.</para>
    /// <para>Represents the following attribute in the schema: manufacturer </para>
    /// </summary>
    [SchemaAttr(0, "manufacturer")]
    [Index(1)]
    public StringValue Manufacturer { get; set; }
	
    /// <summary>
    /// <para> model.</para>
    /// <para>Represents the following attribute in the schema: model </para>
    /// </summary>
    [SchemaAttr(0, "model")]
    [Index(2)]
    public StringValue Model { get; set; }
	
    /// <summary>
    /// <para> serialNo.</para>
    /// <para>Represents the following attribute in the schema: serialNo </para>
    /// </summary>
    [SchemaAttr(0, "serialNo")]
    [Index(3)]
    public StringValue SerialNo { get; set; }
	
    /// <summary>
    /// <para> specificationRef.</para>
    /// <para>Represents the following attribute in the schema: specificationRef </para>
    /// </summary>
    [SchemaAttr(0, "specificationRef")]
    [Index(4)]
    public StringValue SpecificationRef { get; set; }
	
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    [Index(5)]
    public StringValue Description { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the InkSource class.
    /// </summary>
    public InkSource():base(){}
    
        /// <summary>
    ///Initializes a new instance of the InkSource class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public InkSource(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the InkSource class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public InkSource(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the InkSource class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public InkSource(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> TraceFormat.</para>
    /// <para> Represents the following element tag in the schema: inkml:traceFormat </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(0)]
    public TraceFormat TraceFormat
	{
        get => GetElement<TraceFormat>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> SampleRate.</para>
    /// <para> Represents the following element tag in the schema: inkml:sampleRate </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(1)]
    public SampleRate SampleRate
	{
        get => GetElement<SampleRate>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Latency.</para>
    /// <para> Represents the following element tag in the schema: inkml:latency </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(2)]
    public Latency Latency
	{
        get => GetElement<Latency>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ActiveArea.</para>
    /// <para> Represents the following element tag in the schema: inkml:activeArea </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(3)]
    public ActiveArea ActiveArea
	{
        get => GetElement<ActiveArea>(3);
        set => SetElement(3, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkSource>(deep);

}
/// <summary>
/// <para>Defines the Brush Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:brush.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Annotation &lt;inkml:annotation></description></item>
///<item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
///<item><description>BrushProperty &lt;inkml:brushProperty></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Annotation))]
    [ChildElementInfo(typeof(AnnotationXml))]
    [ChildElementInfo(typeof(BrushProperty))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "brush")]
[Id(ElementTypeIdConst)]
public partial class Brush : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12734;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> brushRef.</para>
    /// <para>Represents the following attribute in the schema: brushRef </para>
    /// </summary>
    [SchemaAttr(0, "brushRef")]
    [Index(1)]
    public StringValue BrushRef { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Brush class.
    /// </summary>
    public Brush():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Brush class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Brush(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Brush class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Brush(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Brush class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Brush(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Brush>(deep);

}
/// <summary>
/// <para>Defines the Timestamp Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:timestamp.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "timestamp")]
[Id(ElementTypeIdConst)]
public partial class Timestamp : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12735;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> time.</para>
    /// <para>Represents the following attribute in the schema: time </para>
    /// </summary>
    [SchemaAttr(0, "time")]
    [Index(1)]
    public DecimalValue Time { get; set; }
	
    /// <summary>
    /// <para> timestampRef.</para>
    /// <para>Represents the following attribute in the schema: timestampRef </para>
    /// </summary>
    [SchemaAttr(0, "timestampRef")]
    [Index(2)]
    public StringValue TimestampRef { get; set; }
	
    /// <summary>
    /// <para> timeString.</para>
    /// <para>Represents the following attribute in the schema: timeString </para>
    /// </summary>
    [SchemaAttr(0, "timeString")]
    [Index(3)]
    public DateTimeValue TimeString { get; set; }
	
    /// <summary>
    /// <para> timeOffset.</para>
    /// <para>Represents the following attribute in the schema: timeOffset </para>
    /// </summary>
    [SchemaAttr(0, "timeOffset")]
    [Index(4)]
    public DecimalValue TimeOffset { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Timestamp class.
    /// </summary>
    public Timestamp():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Timestamp>(deep);

}
/// <summary>
/// <para>Defines the Trace Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:trace.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "trace")]
[Id(ElementTypeIdConst)]
public partial class Trace : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12736;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.InkML.TraceTypeValues> Type { get; set; }
	
    /// <summary>
    /// <para> continuation.</para>
    /// <para>Represents the following attribute in the schema: continuation </para>
    /// </summary>
    [SchemaAttr(0, "continuation")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.InkML.TraceContinuationValues> Continuation { get; set; }
	
    /// <summary>
    /// <para> priorRef.</para>
    /// <para>Represents the following attribute in the schema: priorRef </para>
    /// </summary>
    [SchemaAttr(0, "priorRef")]
    [Index(3)]
    public StringValue PriorRef { get; set; }
	
    /// <summary>
    /// <para> contextRef.</para>
    /// <para>Represents the following attribute in the schema: contextRef </para>
    /// </summary>
    [SchemaAttr(0, "contextRef")]
    [Index(4)]
    public StringValue ContextRef { get; set; }
	
    /// <summary>
    /// <para> brushRef.</para>
    /// <para>Represents the following attribute in the schema: brushRef </para>
    /// </summary>
    [SchemaAttr(0, "brushRef")]
    [Index(5)]
    public StringValue BrushRef { get; set; }
	
    /// <summary>
    /// <para> duration.</para>
    /// <para>Represents the following attribute in the schema: duration </para>
    /// </summary>
    [SchemaAttr(0, "duration")]
    [Index(6)]
    public DecimalValue Duration { get; set; }
	
    /// <summary>
    /// <para> timeOffset.</para>
    /// <para>Represents the following attribute in the schema: timeOffset </para>
    /// </summary>
    [SchemaAttr(0, "timeOffset")]
    [Index(7)]
    public DecimalValue TimeOffset { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Trace class.
    /// </summary>
    public Trace():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the Trace class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Trace(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Trace>(deep);

}
/// <summary>
/// <para>Defines the TraceGroup Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:traceGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Annotation &lt;inkml:annotation></description></item>
///<item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
///<item><description>Trace &lt;inkml:trace></description></item>
///<item><description>TraceGroup &lt;inkml:traceGroup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Annotation))]
    [ChildElementInfo(typeof(AnnotationXml))]
    [ChildElementInfo(typeof(Trace))]
    [ChildElementInfo(typeof(TraceGroup))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "traceGroup")]
[Id(ElementTypeIdConst)]
public partial class TraceGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12737;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> contextRef.</para>
    /// <para>Represents the following attribute in the schema: contextRef </para>
    /// </summary>
    [SchemaAttr(0, "contextRef")]
    [Index(1)]
    public StringValue ContextRef { get; set; }
	
    /// <summary>
    /// <para> brushRef.</para>
    /// <para>Represents the following attribute in the schema: brushRef </para>
    /// </summary>
    [SchemaAttr(0, "brushRef")]
    [Index(2)]
    public StringValue BrushRef { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TraceGroup class.
    /// </summary>
    public TraceGroup():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TraceGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TraceGroup(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TraceGroup>(deep);

}
/// <summary>
/// <para>Defines the TraceView Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:traceView.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Annotation &lt;inkml:annotation></description></item>
///<item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
///<item><description>TraceView &lt;inkml:traceView></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Annotation))]
    [ChildElementInfo(typeof(AnnotationXml))]
    [ChildElementInfo(typeof(TraceView))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "traceView")]
[Id(ElementTypeIdConst)]
public partial class TraceView : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12738;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> contextRef.</para>
    /// <para>Represents the following attribute in the schema: contextRef </para>
    /// </summary>
    [SchemaAttr(0, "contextRef")]
    [Index(1)]
    public StringValue ContextRef { get; set; }
	
    /// <summary>
    /// <para> traceDataRef.</para>
    /// <para>Represents the following attribute in the schema: traceDataRef </para>
    /// </summary>
    [SchemaAttr(0, "traceDataRef")]
    [Index(2)]
    public StringValue TraceDataRef { get; set; }
	
    /// <summary>
    /// <para> from.</para>
    /// <para>Represents the following attribute in the schema: from </para>
    /// </summary>
    [SchemaAttr(0, "from")]
    [Index(3)]
    public StringValue From { get; set; }
	
    /// <summary>
    /// <para> to.</para>
    /// <para>Represents the following attribute in the schema: to </para>
    /// </summary>
    [SchemaAttr(0, "to")]
    [Index(4)]
    public StringValue To { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TraceView class.
    /// </summary>
    public TraceView():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TraceView class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceView(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceView class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TraceView(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TraceView class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TraceView(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TraceView>(deep);

}
/// <summary>
/// <para>Defines the Context Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:context.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Canvas &lt;inkml:canvas></description></item>
///<item><description>CanvasTransform &lt;inkml:canvasTransform></description></item>
///<item><description>TraceFormat &lt;inkml:traceFormat></description></item>
///<item><description>InkSource &lt;inkml:inkSource></description></item>
///<item><description>Brush &lt;inkml:brush></description></item>
///<item><description>Timestamp &lt;inkml:timestamp></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Canvas))]
    [ChildElementInfo(typeof(CanvasTransform))]
    [ChildElementInfo(typeof(TraceFormat))]
    [ChildElementInfo(typeof(InkSource))]
    [ChildElementInfo(typeof(Brush))]
    [ChildElementInfo(typeof(Timestamp))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "context")]
[Id(ElementTypeIdConst)]
public partial class Context : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12739;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: xml:id </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> contextRef.</para>
    /// <para>Represents the following attribute in the schema: contextRef </para>
    /// </summary>
    [SchemaAttr(0, "contextRef")]
    [Index(1)]
    public StringValue ContextRef { get; set; }
	
    /// <summary>
    /// <para> canvasRef.</para>
    /// <para>Represents the following attribute in the schema: canvasRef </para>
    /// </summary>
    [SchemaAttr(0, "canvasRef")]
    [Index(2)]
    public StringValue CanvasRef { get; set; }
	
    /// <summary>
    /// <para> canvasTransformRef.</para>
    /// <para>Represents the following attribute in the schema: canvasTransformRef </para>
    /// </summary>
    [SchemaAttr(0, "canvasTransformRef")]
    [Index(3)]
    public StringValue CanvasTransformRef { get; set; }
	
    /// <summary>
    /// <para> traceFormatRef.</para>
    /// <para>Represents the following attribute in the schema: traceFormatRef </para>
    /// </summary>
    [SchemaAttr(0, "traceFormatRef")]
    [Index(4)]
    public StringValue TraceFromatRef { get; set; }
	
    /// <summary>
    /// <para> inkSourceRef.</para>
    /// <para>Represents the following attribute in the schema: inkSourceRef </para>
    /// </summary>
    [SchemaAttr(0, "inkSourceRef")]
    [Index(5)]
    public StringValue InkSourceRef { get; set; }
	
    /// <summary>
    /// <para> brushRef.</para>
    /// <para>Represents the following attribute in the schema: brushRef </para>
    /// </summary>
    [SchemaAttr(0, "brushRef")]
    [Index(6)]
    public StringValue BrushRef { get; set; }
	
    /// <summary>
    /// <para> timestampRef.</para>
    /// <para>Represents the following attribute in the schema: timestampRef </para>
    /// </summary>
    [SchemaAttr(0, "timestampRef")]
    [Index(7)]
    public StringValue TimestampRef { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Context class.
    /// </summary>
    public Context():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Context class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Context(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Context class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Context(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Context class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Context(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Canvas.</para>
    /// <para> Represents the following element tag in the schema: inkml:canvas </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(0)]
    public Canvas Canvas
	{
        get => GetElement<Canvas>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> CanvasTransform.</para>
    /// <para> Represents the following element tag in the schema: inkml:canvasTransform </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(1)]
    public CanvasTransform CanvasTransform
	{
        get => GetElement<CanvasTransform>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> TraceFormat.</para>
    /// <para> Represents the following element tag in the schema: inkml:traceFormat </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(2)]
    public TraceFormat TraceFormat
	{
        get => GetElement<TraceFormat>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> InkSource.</para>
    /// <para> Represents the following element tag in the schema: inkml:inkSource </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(3)]
    public InkSource InkSource
	{
        get => GetElement<InkSource>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> Brush.</para>
    /// <para> Represents the following element tag in the schema: inkml:brush </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(4)]
    public Brush Brush
	{
        get => GetElement<Brush>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> Timestamp.</para>
    /// <para> Represents the following element tag in the schema: inkml:timestamp </para>
    /// </summary>
    /// <remark>
    /// xmlns:inkml = http://www.w3.org/2003/InkML
    /// </remark>
	[Index(5)]
    public Timestamp Timestamp
	{
        get => GetElement<Timestamp>(5);
        set => SetElement(5, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Context>(deep);

}
/// <summary>
/// <para>Defines the Definitions Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is inkml:definitions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Brush &lt;inkml:brush></description></item>
///<item><description>Canvas &lt;inkml:canvas></description></item>
///<item><description>CanvasTransform &lt;inkml:canvasTransform></description></item>
///<item><description>Context &lt;inkml:context></description></item>
///<item><description>InkSource &lt;inkml:inkSource></description></item>
///<item><description>Mapping &lt;inkml:mapping></description></item>
///<item><description>Timestamp &lt;inkml:timestamp></description></item>
///<item><description>Trace &lt;inkml:trace></description></item>
///<item><description>TraceFormat &lt;inkml:traceFormat></description></item>
///<item><description>TraceGroup &lt;inkml:traceGroup></description></item>
///<item><description>TraceView &lt;inkml:traceView></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Brush))]
    [ChildElementInfo(typeof(Canvas))]
    [ChildElementInfo(typeof(CanvasTransform))]
    [ChildElementInfo(typeof(Context))]
    [ChildElementInfo(typeof(InkSource))]
    [ChildElementInfo(typeof(Mapping))]
    [ChildElementInfo(typeof(Timestamp))]
    [ChildElementInfo(typeof(Trace))]
    [ChildElementInfo(typeof(TraceFormat))]
    [ChildElementInfo(typeof(TraceGroup))]
    [ChildElementInfo(typeof(TraceView))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(43, "definitions")]
[Id(ElementTypeIdConst)]
public partial class Definitions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12740;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the Definitions class.
    /// </summary>
    public Definitions():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Definitions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Definitions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Definitions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Definitions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Definitions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Definitions(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Definitions>(deep);

}
/// <summary>
/// Defines the ChannelDataTypeValues enumeration. 
/// </summary> 
public enum ChannelDataTypeValues
{  
	///<summary>
///integer.
///<para>When the item is serialized out as xml, its value is "integer".</para>
///</summary>
[EnumString("integer")]
Integer,
///<summary>
///decimal.
///<para>When the item is serialized out as xml, its value is "decimal".</para>
///</summary>
[EnumString("decimal")]
Decimal,
///<summary>
///boolean.
///<para>When the item is serialized out as xml, its value is "boolean".</para>
///</summary>
[EnumString("boolean")]
Boolean,
 
}
/// <summary>
/// Defines the ChannelValueOrientationValues enumeration. 
/// </summary> 
public enum ChannelValueOrientationValues
{  
	///<summary>
///+ve.
///<para>When the item is serialized out as xml, its value is "+ve".</para>
///</summary>
[EnumString("+ve")]
PlusVe,
///<summary>
///-ve.
///<para>When the item is serialized out as xml, its value is "-ve".</para>
///</summary>
[EnumString("-ve")]
MinusVe,
 
}
/// <summary>
/// Defines the StandardChannelPropertyNameValues enumeration. 
/// </summary> 
public enum StandardChannelPropertyNameValues
{  
	///<summary>
///threshold.
///<para>When the item is serialized out as xml, its value is "threshold".</para>
///</summary>
[EnumString("threshold")]
Threshold,
///<summary>
///resolution.
///<para>When the item is serialized out as xml, its value is "resolution".</para>
///</summary>
[EnumString("resolution")]
Resolution,
///<summary>
///quantization.
///<para>When the item is serialized out as xml, its value is "quantization".</para>
///</summary>
[EnumString("quantization")]
Quantization,
///<summary>
///noise.
///<para>When the item is serialized out as xml, its value is "noise".</para>
///</summary>
[EnumString("noise")]
Noise,
///<summary>
///accuracy.
///<para>When the item is serialized out as xml, its value is "accuracy".</para>
///</summary>
[EnumString("accuracy")]
Accuracy,
///<summary>
///crossCoupling.
///<para>When the item is serialized out as xml, its value is "crossCoupling".</para>
///</summary>
[EnumString("crossCoupling")]
CrossCoupling,
///<summary>
///skew.
///<para>When the item is serialized out as xml, its value is "skew".</para>
///</summary>
[EnumString("skew")]
Skew,
///<summary>
///minBandwidth.
///<para>When the item is serialized out as xml, its value is "minBandwidth".</para>
///</summary>
[EnumString("minBandwidth")]
MinBandwidth,
///<summary>
///peakRate.
///<para>When the item is serialized out as xml, its value is "peakRate".</para>
///</summary>
[EnumString("peakRate")]
PeakRate,
///<summary>
///distortion.
///<para>When the item is serialized out as xml, its value is "distortion".</para>
///</summary>
[EnumString("distortion")]
Distortion,
 
}
/// <summary>
/// Defines the StandardBrushPropertyNameValues enumeration. 
/// </summary> 
public enum StandardBrushPropertyNameValues
{  
	///<summary>
///width.
///<para>When the item is serialized out as xml, its value is "width".</para>
///</summary>
[EnumString("width")]
Width,
///<summary>
///height.
///<para>When the item is serialized out as xml, its value is "height".</para>
///</summary>
[EnumString("height")]
Height,
///<summary>
///color.
///<para>When the item is serialized out as xml, its value is "color".</para>
///</summary>
[EnumString("color")]
Color,
///<summary>
///transparency.
///<para>When the item is serialized out as xml, its value is "transparency".</para>
///</summary>
[EnumString("transparency")]
Transparency,
///<summary>
///tip.
///<para>When the item is serialized out as xml, its value is "tip".</para>
///</summary>
[EnumString("tip")]
Tip,
///<summary>
///rasterOp.
///<para>When the item is serialized out as xml, its value is "rasterOp".</para>
///</summary>
[EnumString("rasterOp")]
RasterOp,
///<summary>
///antiAliased.
///<para>When the item is serialized out as xml, its value is "antiAliased".</para>
///</summary>
[EnumString("antiAliased")]
AntiAliased,
///<summary>
///fitToCurve.
///<para>When the item is serialized out as xml, its value is "fitToCurve".</para>
///</summary>
[EnumString("fitToCurve")]
FitToCurve,
///<summary>
///ignorePressure.
///<para>When the item is serialized out as xml, its value is "ignorePressure".</para>
///</summary>
[EnumString("ignorePressure")]
IgnorePressure,
 
}
/// <summary>
/// Defines the StandardChannelNameValues enumeration. 
/// </summary> 
public enum StandardChannelNameValues
{  
	///<summary>
///X.
///<para>When the item is serialized out as xml, its value is "X".</para>
///</summary>
[EnumString("X")]
XCoordinate,
///<summary>
///Y.
///<para>When the item is serialized out as xml, its value is "Y".</para>
///</summary>
[EnumString("Y")]
YCoordinate,
///<summary>
///Z.
///<para>When the item is serialized out as xml, its value is "Z".</para>
///</summary>
[EnumString("Z")]
ZCoordinate,
///<summary>
///F.
///<para>When the item is serialized out as xml, its value is "F".</para>
///</summary>
[EnumString("F")]
PenTipForce,
///<summary>
///TP.
///<para>When the item is serialized out as xml, its value is "TP".</para>
///</summary>
[EnumString("TP")]
TangentPressure,
///<summary>
///BP.
///<para>When the item is serialized out as xml, its value is "BP".</para>
///</summary>
[EnumString("BP")]
ButtonPressure,
///<summary>
///S.
///<para>When the item is serialized out as xml, its value is "S".</para>
///</summary>
[EnumString("S")]
TipSwitchState,
///<summary>
///B1.
///<para>When the item is serialized out as xml, its value is "B1".</para>
///</summary>
[EnumString("B1")]
SideButton1State,
///<summary>
///B2.
///<para>When the item is serialized out as xml, its value is "B2".</para>
///</summary>
[EnumString("B2")]
SideButton2State,
///<summary>
///B3.
///<para>When the item is serialized out as xml, its value is "B3".</para>
///</summary>
[EnumString("B3")]
SideButton3State,
///<summary>
///B4.
///<para>When the item is serialized out as xml, its value is "B4".</para>
///</summary>
[EnumString("B4")]
SideButton4State,
///<summary>
///E.
///<para>When the item is serialized out as xml, its value is "E".</para>
///</summary>
[EnumString("E")]
PenInverted,
///<summary>
///OTx.
///<para>When the item is serialized out as xml, its value is "OTx".</para>
///</summary>
[EnumString("OTx")]
TiltAlongXAxis,
///<summary>
///OTy.
///<para>When the item is serialized out as xml, its value is "OTy".</para>
///</summary>
[EnumString("OTy")]
TiltAlongYAxis,
///<summary>
///OA.
///<para>When the item is serialized out as xml, its value is "OA".</para>
///</summary>
[EnumString("OA")]
PenAzimuthAngle,
///<summary>
///OE.
///<para>When the item is serialized out as xml, its value is "OE".</para>
///</summary>
[EnumString("OE")]
PenElevationAngle,
///<summary>
///OR.
///<para>When the item is serialized out as xml, its value is "OR".</para>
///</summary>
[EnumString("OR")]
PexAxisRotation,
///<summary>
///RP.
///<para>When the item is serialized out as xml, its value is "RP".</para>
///</summary>
[EnumString("RP")]
PitchRotation,
///<summary>
///RR.
///<para>When the item is serialized out as xml, its value is "RR".</para>
///</summary>
[EnumString("RR")]
RollRotation,
///<summary>
///RY.
///<para>When the item is serialized out as xml, its value is "RY".</para>
///</summary>
[EnumString("RY")]
YawRotation,
///<summary>
///C.
///<para>When the item is serialized out as xml, its value is "C".</para>
///</summary>
[EnumString("C")]
ColorValue,
///<summary>
///CR.
///<para>When the item is serialized out as xml, its value is "CR".</para>
///</summary>
[EnumString("CR")]
RedColorValue,
///<summary>
///CG.
///<para>When the item is serialized out as xml, its value is "CG".</para>
///</summary>
[EnumString("CG")]
GreenColorValue,
///<summary>
///CB.
///<para>When the item is serialized out as xml, its value is "CB".</para>
///</summary>
[EnumString("CB")]
BlueColorValue,
///<summary>
///CC.
///<para>When the item is serialized out as xml, its value is "CC".</para>
///</summary>
[EnumString("CC")]
CyanColorValue,
///<summary>
///CM.
///<para>When the item is serialized out as xml, its value is "CM".</para>
///</summary>
[EnumString("CM")]
MegentaColorValue,
///<summary>
///CY.
///<para>When the item is serialized out as xml, its value is "CY".</para>
///</summary>
[EnumString("CY")]
YellowColorValue,
///<summary>
///CK.
///<para>When the item is serialized out as xml, its value is "CK".</para>
///</summary>
[EnumString("CK")]
BlackColorValue,
///<summary>
///W.
///<para>When the item is serialized out as xml, its value is "W".</para>
///</summary>
[EnumString("W")]
StrokesWidth,
///<summary>
///T.
///<para>When the item is serialized out as xml, its value is "T".</para>
///</summary>
[EnumString("T")]
Time,
///<summary>
///SN.
///<para>When the item is serialized out as xml, its value is "SN".</para>
///</summary>
[EnumString("SN")]
SerialNumber,
///<summary>
///TW.
///<para>When the item is serialized out as xml, its value is "TW".</para>
///</summary>
[EnumString("TW")]
TouchWidth,
///<summary>
///TH.
///<para>When the item is serialized out as xml, its value is "TH".</para>
///</summary>
[EnumString("TH")]
TouchHeight,
///<summary>
///TC.
///<para>When the item is serialized out as xml, its value is "TC".</para>
///</summary>
[EnumString("TC")]
FingerTouch,
 
}
/// <summary>
/// Defines the StandardLengthUnitsValues enumeration. 
/// </summary> 
public enum StandardLengthUnitsValues
{  
	///<summary>
///m.
///<para>When the item is serialized out as xml, its value is "m".</para>
///</summary>
[EnumString("m")]
Meter,
///<summary>
///cm.
///<para>When the item is serialized out as xml, its value is "cm".</para>
///</summary>
[EnumString("cm")]
Centimeter,
///<summary>
///mm.
///<para>When the item is serialized out as xml, its value is "mm".</para>
///</summary>
[EnumString("mm")]
Millimeter,
///<summary>
///in.
///<para>When the item is serialized out as xml, its value is "in".</para>
///</summary>
[EnumString("in")]
Inche,
///<summary>
///pt.
///<para>When the item is serialized out as xml, its value is "pt".</para>
///</summary>
[EnumString("pt")]
Point,
///<summary>
///pc.
///<para>When the item is serialized out as xml, its value is "pc".</para>
///</summary>
[EnumString("pc")]
Pica,
///<summary>
///em.
///<para>When the item is serialized out as xml, its value is "em".</para>
///</summary>
[EnumString("em")]
Em,
///<summary>
///ex.
///<para>When the item is serialized out as xml, its value is "ex".</para>
///</summary>
[EnumString("ex")]
Ex,
 
}
/// <summary>
/// Defines the StandardPerLengthUnitsValues enumeration. 
/// </summary> 
public enum StandardPerLengthUnitsValues
{  
	///<summary>
///1/m.
///<para>When the item is serialized out as xml, its value is "1/m".</para>
///</summary>
[EnumString("1/m")]
PerMeter,
///<summary>
///1/cm.
///<para>When the item is serialized out as xml, its value is "1/cm".</para>
///</summary>
[EnumString("1/cm")]
PerCentimeter,
///<summary>
///1/mm.
///<para>When the item is serialized out as xml, its value is "1/mm".</para>
///</summary>
[EnumString("1/mm")]
PerMillimeter,
///<summary>
///1/in.
///<para>When the item is serialized out as xml, its value is "1/in".</para>
///</summary>
[EnumString("1/in")]
PerInche,
///<summary>
///1/pt.
///<para>When the item is serialized out as xml, its value is "1/pt".</para>
///</summary>
[EnumString("1/pt")]
PerPoint,
///<summary>
///1/pc.
///<para>When the item is serialized out as xml, its value is "1/pc".</para>
///</summary>
[EnumString("1/pc")]
PerPica,
///<summary>
///1/em.
///<para>When the item is serialized out as xml, its value is "1/em".</para>
///</summary>
[EnumString("1/em")]
PerEm,
///<summary>
///1/ex.
///<para>When the item is serialized out as xml, its value is "1/ex".</para>
///</summary>
[EnumString("1/ex")]
PerEx,
 
}
/// <summary>
/// Defines the StandardTimeUnitsValues enumeration. 
/// </summary> 
public enum StandardTimeUnitsValues
{  
	///<summary>
///s.
///<para>When the item is serialized out as xml, its value is "s".</para>
///</summary>
[EnumString("s")]
Second,
///<summary>
///ms.
///<para>When the item is serialized out as xml, its value is "ms".</para>
///</summary>
[EnumString("ms")]
Millisecond,
 
}
/// <summary>
/// Defines the StandardPerTimeUnitsValues enumeration. 
/// </summary> 
public enum StandardPerTimeUnitsValues
{  
	///<summary>
///1/s.
///<para>When the item is serialized out as xml, its value is "1/s".</para>
///</summary>
[EnumString("1/s")]
PerSecond,
///<summary>
///1/ms.
///<para>When the item is serialized out as xml, its value is "1/ms".</para>
///</summary>
[EnumString("1/ms")]
PerMillisecond,
 
}
/// <summary>
/// Defines the StandardMassForceUnitsValues enumeration. 
/// </summary> 
public enum StandardMassForceUnitsValues
{  
	///<summary>
///Kg.
///<para>When the item is serialized out as xml, its value is "Kg".</para>
///</summary>
[EnumString("Kg")]
Kilogram,
///<summary>
///g.
///<para>When the item is serialized out as xml, its value is "g".</para>
///</summary>
[EnumString("g")]
Gram,
///<summary>
///mg.
///<para>When the item is serialized out as xml, its value is "mg".</para>
///</summary>
[EnumString("mg")]
Milligram,
///<summary>
///N.
///<para>When the item is serialized out as xml, its value is "N".</para>
///</summary>
[EnumString("N")]
Newton,
///<summary>
///lb.
///<para>When the item is serialized out as xml, its value is "lb".</para>
///</summary>
[EnumString("lb")]
Pond,
 
}
/// <summary>
/// Defines the StandardPerMassForceUnitsValues enumeration. 
/// </summary> 
public enum StandardPerMassForceUnitsValues
{  
	///<summary>
///1/Kg.
///<para>When the item is serialized out as xml, its value is "1/Kg".</para>
///</summary>
[EnumString("1/Kg")]
PerKilogram,
///<summary>
///1/g.
///<para>When the item is serialized out as xml, its value is "1/g".</para>
///</summary>
[EnumString("1/g")]
PerGram,
///<summary>
///1/mg.
///<para>When the item is serialized out as xml, its value is "1/mg".</para>
///</summary>
[EnumString("1/mg")]
PerMilligram,
///<summary>
///1/N.
///<para>When the item is serialized out as xml, its value is "1/N".</para>
///</summary>
[EnumString("1/N")]
PerNewton,
///<summary>
///1/lb.
///<para>When the item is serialized out as xml, its value is "1/lb".</para>
///</summary>
[EnumString("1/lb")]
PerPond,
 
}
/// <summary>
/// Defines the StandardAngleUnitsValues enumeration. 
/// </summary> 
public enum StandardAngleUnitsValues
{  
	///<summary>
///deg.
///<para>When the item is serialized out as xml, its value is "deg".</para>
///</summary>
[EnumString("deg")]
Degree,
///<summary>
///rad.
///<para>When the item is serialized out as xml, its value is "rad".</para>
///</summary>
[EnumString("rad")]
Radian,
 
}
/// <summary>
/// Defines the StandardPerAngleUnitsValues enumeration. 
/// </summary> 
public enum StandardPerAngleUnitsValues
{  
	///<summary>
///1/deg.
///<para>When the item is serialized out as xml, its value is "1/deg".</para>
///</summary>
[EnumString("1/deg")]
PerDegree,
///<summary>
///1/rad.
///<para>When the item is serialized out as xml, its value is "1/rad".</para>
///</summary>
[EnumString("1/rad")]
PerRadian,
 
}
/// <summary>
/// Defines the StandardOtherUnitsValues enumeration. 
/// </summary> 
public enum StandardOtherUnitsValues
{  
	///<summary>
///%.
///<para>When the item is serialized out as xml, its value is "%".</para>
///</summary>
[EnumString("%")]
Percentage,
///<summary>
///dev.
///<para>When the item is serialized out as xml, its value is "dev".</para>
///</summary>
[EnumString("dev")]
DeviceResolution,
///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
 
}
/// <summary>
/// Defines the StandardPerOtherUnitsValues enumeration. 
/// </summary> 
public enum StandardPerOtherUnitsValues
{  
	///<summary>
///1/%.
///<para>When the item is serialized out as xml, its value is "1/%".</para>
///</summary>
[EnumString("1/%")]
PerPercentage,
///<summary>
///1/dev.
///<para>When the item is serialized out as xml, its value is "1/dev".</para>
///</summary>
[EnumString("1/dev")]
PerDeviceResolution,
 
}
/// <summary>
/// Defines the TraceTypeValues enumeration. 
/// </summary> 
public enum TraceTypeValues
{  
	///<summary>
///penDown.
///<para>When the item is serialized out as xml, its value is "penDown".</para>
///</summary>
[EnumString("penDown")]
PenDown,
///<summary>
///penUp.
///<para>When the item is serialized out as xml, its value is "penUp".</para>
///</summary>
[EnumString("penUp")]
PenUp,
///<summary>
///indeterminate.
///<para>When the item is serialized out as xml, its value is "indeterminate".</para>
///</summary>
[EnumString("indeterminate")]
Indeterminate,
 
}
/// <summary>
/// Defines the TraceContinuationValues enumeration. 
/// </summary> 
public enum TraceContinuationValues
{  
	///<summary>
///begin.
///<para>When the item is serialized out as xml, its value is "begin".</para>
///</summary>
[EnumString("begin")]
Begin,
///<summary>
///end.
///<para>When the item is serialized out as xml, its value is "end".</para>
///</summary>
[EnumString("end")]
End,
///<summary>
///middle.
///<para>When the item is serialized out as xml, its value is "middle".</para>
///</summary>
[EnumString("middle")]
Middle,
 
}
/// <summary>
/// Defines the RasterOperationValues enumeration. 
/// </summary> 
public enum RasterOperationValues
{  
	///<summary>
///black.
///<para>When the item is serialized out as xml, its value is "black".</para>
///</summary>
[EnumString("black")]
Black,
///<summary>
///notMergePen.
///<para>When the item is serialized out as xml, its value is "notMergePen".</para>
///</summary>
[EnumString("notMergePen")]
NotMergePen,
///<summary>
///maskNotPen.
///<para>When the item is serialized out as xml, its value is "maskNotPen".</para>
///</summary>
[EnumString("maskNotPen")]
MaskNotPen,
///<summary>
///notCopyPen.
///<para>When the item is serialized out as xml, its value is "notCopyPen".</para>
///</summary>
[EnumString("notCopyPen")]
NotCopyPen,
///<summary>
///maskPenNot.
///<para>When the item is serialized out as xml, its value is "maskPenNot".</para>
///</summary>
[EnumString("maskPenNot")]
MaskPenNot,
///<summary>
///not.
///<para>When the item is serialized out as xml, its value is "not".</para>
///</summary>
[EnumString("not")]
Not,
///<summary>
///xOrPen.
///<para>When the item is serialized out as xml, its value is "xOrPen".</para>
///</summary>
[EnumString("xOrPen")]
XOrPen,
///<summary>
///notMaskPen.
///<para>When the item is serialized out as xml, its value is "notMaskPen".</para>
///</summary>
[EnumString("notMaskPen")]
NotMaskPen,
///<summary>
///maskPen.
///<para>When the item is serialized out as xml, its value is "maskPen".</para>
///</summary>
[EnumString("maskPen")]
MaskPen,
///<summary>
///notXOrPen.
///<para>When the item is serialized out as xml, its value is "notXOrPen".</para>
///</summary>
[EnumString("notXOrPen")]
NotXOrPen,
///<summary>
///noOperation.
///<para>When the item is serialized out as xml, its value is "noOperation".</para>
///</summary>
[EnumString("noOperation")]
NoOperation,
///<summary>
///mergeNotPen.
///<para>When the item is serialized out as xml, its value is "mergeNotPen".</para>
///</summary>
[EnumString("mergeNotPen")]
MergeNotPen,
///<summary>
///copyPen.
///<para>When the item is serialized out as xml, its value is "copyPen".</para>
///</summary>
[EnumString("copyPen")]
CopyPen,
///<summary>
///mergePenNot.
///<para>When the item is serialized out as xml, its value is "mergePenNot".</para>
///</summary>
[EnumString("mergePenNot")]
MergePenNot,
///<summary>
///mergePen.
///<para>When the item is serialized out as xml, its value is "mergePen".</para>
///</summary>
[EnumString("mergePen")]
MergePen,
///<summary>
///white.
///<para>When the item is serialized out as xml, its value is "white".</para>
///</summary>
[EnumString("white")]
White,
 
}
/// <summary>
/// Defines the PenTipShapeValues enumeration. 
/// </summary> 
public enum PenTipShapeValues
{  
	///<summary>
///ellipse.
///<para>When the item is serialized out as xml, its value is "ellipse".</para>
///</summary>
[EnumString("ellipse")]
Ellipse,
///<summary>
///rectangle.
///<para>When the item is serialized out as xml, its value is "rectangle".</para>
///</summary>
[EnumString("rectangle")]
Rectangle,
///<summary>
///drop.
///<para>When the item is serialized out as xml, its value is "drop".</para>
///</summary>
[EnumString("drop")]
Drop,
 
}
/// <summary>
/// Defines the MappingTypeValues enumeration. 
/// </summary> 
public enum MappingTypeValues
{  
	///<summary>
///identity.
///<para>When the item is serialized out as xml, its value is "identity".</para>
///</summary>
[EnumString("identity")]
Identity,
///<summary>
///lookup.
///<para>When the item is serialized out as xml, its value is "lookup".</para>
///</summary>
[EnumString("lookup")]
Lookup,
///<summary>
///affine.
///<para>When the item is serialized out as xml, its value is "affine".</para>
///</summary>
[EnumString("affine")]
Affine,
///<summary>
///mathml.
///<para>When the item is serialized out as xml, its value is "mathml".</para>
///</summary>
[EnumString("mathml")]
MathML,
///<summary>
///product.
///<para>When the item is serialized out as xml, its value is "product".</para>
///</summary>
[EnumString("product")]
Product,
///<summary>
///unknown.
///<para>When the item is serialized out as xml, its value is "unknown".</para>
///</summary>
[EnumString("unknown")]
Unknown,
 
}
/// <summary>
/// Defines the TableApplyValues enumeration. 
/// </summary> 
public enum TableApplyValues
{  
	///<summary>
///absolute.
///<para>When the item is serialized out as xml, its value is "absolute".</para>
///</summary>
[EnumString("absolute")]
Absolute,
///<summary>
///relative.
///<para>When the item is serialized out as xml, its value is "relative".</para>
///</summary>
[EnumString("relative")]
Relative,
 
}
/// <summary>
/// Defines the TableInterpolationValues enumeration. 
/// </summary> 
public enum TableInterpolationValues
{  
	///<summary>
///floor.
///<para>When the item is serialized out as xml, its value is "floor".</para>
///</summary>
[EnumString("floor")]
Floor,
///<summary>
///middle.
///<para>When the item is serialized out as xml, its value is "middle".</para>
///</summary>
[EnumString("middle")]
Middle,
///<summary>
///ceiling.
///<para>When the item is serialized out as xml, its value is "ceiling".</para>
///</summary>
[EnumString("ceiling")]
Ceiling,
///<summary>
///linear.
///<para>When the item is serialized out as xml, its value is "linear".</para>
///</summary>
[EnumString("linear")]
Linear,
///<summary>
///cubic.
///<para>When the item is serialized out as xml, its value is "cubic".</para>
///</summary>
[EnumString("cubic")]
Cubic,
 
}
}
 
 
