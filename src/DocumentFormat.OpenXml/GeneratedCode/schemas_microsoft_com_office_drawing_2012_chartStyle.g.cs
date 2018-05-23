// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
/// <summary>
/// <para>Defines the ColorStyle Class. The root element of ChartColorStylePart.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:colorStyle.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
///<item><description>ColorStyleVariation &lt;cs:variation></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]
    [ChildElementInfo(typeof(ColorStyleVariation), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ColorStyle : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 13256;
    /// <inheritdoc/>
    public override string LocalName => "colorStyle";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "meth"),
		AttributeTag.Create<UInt32Value>(0, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> meth.</para>
    /// <para>Represents the following attribute in the schema: meth </para>
    /// </summary>
    [SchemaAttr(0, "meth")]
    public StringValue Method
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    
	internal ColorStyle(ChartColorStylePart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the ChartColorStylePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(ChartColorStylePart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the ChartColorStylePart associated with this element.
    /// </summary>
    public ChartColorStylePart ChartColorStylePart
    {
		get => OpenXmlPart as ChartColorStylePart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the ColorStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorStyle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorStyle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorStyle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorStyle(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the ColorStyle class.
    /// </summary>
    public ColorStyle():base(){}
    
    /// <summary>
    /// Saves the DOM into the ChartColorStylePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(ChartColorStylePart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "scrgbClr" == name)
    return new DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage();
    
if( 10 == namespaceId && "srgbClr" == name)
    return new DocumentFormat.OpenXml.Drawing.RgbColorModelHex();
    
if( 10 == namespaceId && "hslClr" == name)
    return new DocumentFormat.OpenXml.Drawing.HslColor();
    
if( 10 == namespaceId && "sysClr" == name)
    return new DocumentFormat.OpenXml.Drawing.SystemColor();
    
if( 10 == namespaceId && "schemeClr" == name)
    return new DocumentFormat.OpenXml.Drawing.SchemeColor();
    
if( 10 == namespaceId && "prstClr" == name)
    return new DocumentFormat.OpenXml.Drawing.PresetColor();
    
if( 65 == namespaceId && "variation" == name)
    return new ColorStyleVariation();
    
if( 65 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorStyle>(deep);

}
/// <summary>
/// <para>Defines the ChartStyle Class. The root element of ChartStylePart.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:chartStyle.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AxisTitle &lt;cs:axisTitle></description></item>
///<item><description>CategoryAxis &lt;cs:categoryAxis></description></item>
///<item><description>ChartArea &lt;cs:chartArea></description></item>
///<item><description>DataLabel &lt;cs:dataLabel></description></item>
///<item><description>DataLabelCallout &lt;cs:dataLabelCallout></description></item>
///<item><description>DataPoint &lt;cs:dataPoint></description></item>
///<item><description>DataPoint3D &lt;cs:dataPoint3D></description></item>
///<item><description>DataPointLine &lt;cs:dataPointLine></description></item>
///<item><description>DataPointMarker &lt;cs:dataPointMarker></description></item>
///<item><description>MarkerLayoutProperties &lt;cs:dataPointMarkerLayout></description></item>
///<item><description>DataPointWireframe &lt;cs:dataPointWireframe></description></item>
///<item><description>DataTableStyle &lt;cs:dataTable></description></item>
///<item><description>DownBar &lt;cs:downBar></description></item>
///<item><description>DropLine &lt;cs:dropLine></description></item>
///<item><description>ErrorBar &lt;cs:errorBar></description></item>
///<item><description>Floor &lt;cs:floor></description></item>
///<item><description>GridlineMajor &lt;cs:gridlineMajor></description></item>
///<item><description>GridlineMinor &lt;cs:gridlineMinor></description></item>
///<item><description>HiLoLine &lt;cs:hiLoLine></description></item>
///<item><description>LeaderLine &lt;cs:leaderLine></description></item>
///<item><description>LegendStyle &lt;cs:legend></description></item>
///<item><description>PlotArea &lt;cs:plotArea></description></item>
///<item><description>PlotArea3D &lt;cs:plotArea3D></description></item>
///<item><description>SeriesAxis &lt;cs:seriesAxis></description></item>
///<item><description>SeriesLine &lt;cs:seriesLine></description></item>
///<item><description>TitleStyle &lt;cs:title></description></item>
///<item><description>TrendlineStyle &lt;cs:trendline></description></item>
///<item><description>TrendlineLabel &lt;cs:trendlineLabel></description></item>
///<item><description>UpBar &lt;cs:upBar></description></item>
///<item><description>ValueAxis &lt;cs:valueAxis></description></item>
///<item><description>Wall &lt;cs:wall></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AxisTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(CategoryAxis), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ChartArea), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataLabel), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataLabelCallout), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataPoint), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataPoint3D), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataPointLine), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataPointMarker), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(MarkerLayoutProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataPointWireframe), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataTableStyle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DownBar), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DropLine), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ErrorBar), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Floor), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(GridlineMajor), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(GridlineMinor), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(HiLoLine), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(LeaderLine), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(LegendStyle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(PlotArea), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(PlotArea3D), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(SeriesAxis), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(SeriesLine), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(TitleStyle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(TrendlineStyle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(TrendlineLabel), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(UpBar), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ValueAxis), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Wall), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ChartStyle : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 13257;
    /// <inheritdoc/>
    public override string LocalName => "chartStyle";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
	internal ChartStyle(ChartStylePart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the ChartStylePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(ChartStylePart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the ChartStylePart associated with this element.
    /// </summary>
    public ChartStylePart ChartStylePart
    {
		get => OpenXmlPart as ChartStylePart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the ChartStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartStyle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartStyle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartStyle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartStyle(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the ChartStyle class.
    /// </summary>
    public ChartStyle():base(){}
    
    /// <summary>
    /// Saves the DOM into the ChartStylePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(ChartStylePart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 65 == namespaceId && "axisTitle" == name)
    return new AxisTitle();
    
if( 65 == namespaceId && "categoryAxis" == name)
    return new CategoryAxis();
    
if( 65 == namespaceId && "chartArea" == name)
    return new ChartArea();
    
if( 65 == namespaceId && "dataLabel" == name)
    return new DataLabel();
    
if( 65 == namespaceId && "dataLabelCallout" == name)
    return new DataLabelCallout();
    
if( 65 == namespaceId && "dataPoint" == name)
    return new DataPoint();
    
if( 65 == namespaceId && "dataPoint3D" == name)
    return new DataPoint3D();
    
if( 65 == namespaceId && "dataPointLine" == name)
    return new DataPointLine();
    
if( 65 == namespaceId && "dataPointMarker" == name)
    return new DataPointMarker();
    
if( 65 == namespaceId && "dataPointMarkerLayout" == name)
    return new MarkerLayoutProperties();
    
if( 65 == namespaceId && "dataPointWireframe" == name)
    return new DataPointWireframe();
    
if( 65 == namespaceId && "dataTable" == name)
    return new DataTableStyle();
    
if( 65 == namespaceId && "downBar" == name)
    return new DownBar();
    
if( 65 == namespaceId && "dropLine" == name)
    return new DropLine();
    
if( 65 == namespaceId && "errorBar" == name)
    return new ErrorBar();
    
if( 65 == namespaceId && "floor" == name)
    return new Floor();
    
if( 65 == namespaceId && "gridlineMajor" == name)
    return new GridlineMajor();
    
if( 65 == namespaceId && "gridlineMinor" == name)
    return new GridlineMinor();
    
if( 65 == namespaceId && "hiLoLine" == name)
    return new HiLoLine();
    
if( 65 == namespaceId && "leaderLine" == name)
    return new LeaderLine();
    
if( 65 == namespaceId && "legend" == name)
    return new LegendStyle();
    
if( 65 == namespaceId && "plotArea" == name)
    return new PlotArea();
    
if( 65 == namespaceId && "plotArea3D" == name)
    return new PlotArea3D();
    
if( 65 == namespaceId && "seriesAxis" == name)
    return new SeriesAxis();
    
if( 65 == namespaceId && "seriesLine" == name)
    return new SeriesLine();
    
if( 65 == namespaceId && "title" == name)
    return new TitleStyle();
    
if( 65 == namespaceId && "trendline" == name)
    return new TrendlineStyle();
    
if( 65 == namespaceId && "trendlineLabel" == name)
    return new TrendlineLabel();
    
if( 65 == namespaceId && "upBar" == name)
    return new UpBar();
    
if( 65 == namespaceId && "valueAxis" == name)
    return new ValueAxis();
    
if( 65 == namespaceId && "wall" == name)
    return new Wall();
    
if( 65 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "axisTitle","categoryAxis","chartArea","dataLabel","dataLabelCallout","dataPoint","dataPoint3D","dataPointLine","dataPointMarker","dataPointMarkerLayout","dataPointWireframe","dataTable","downBar","dropLine","errorBar","floor","gridlineMajor","gridlineMinor","hiLoLine","leaderLine","legend","plotArea","plotArea3D","seriesAxis","seriesLine","title","trendline","trendlineLabel","upBar","valueAxis","wall","extLst" };
    private static readonly byte[] eleNamespaceIds = { 65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65,65 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> AxisTitle.</para>
    /// <para> Represents the following element tag in the schema: cs:axisTitle </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public AxisTitle AxisTitle
    {
        get => GetElement<AxisTitle>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> CategoryAxis.</para>
    /// <para> Represents the following element tag in the schema: cs:categoryAxis </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public CategoryAxis CategoryAxis
    {
        get => GetElement<CategoryAxis>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ChartArea.</para>
    /// <para> Represents the following element tag in the schema: cs:chartArea </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public ChartArea ChartArea
    {
        get => GetElement<ChartArea>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> DataLabel.</para>
    /// <para> Represents the following element tag in the schema: cs:dataLabel </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public DataLabel DataLabel
    {
        get => GetElement<DataLabel>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> DataLabelCallout.</para>
    /// <para> Represents the following element tag in the schema: cs:dataLabelCallout </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public DataLabelCallout DataLabelCallout
    {
        get => GetElement<DataLabelCallout>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> DataPoint.</para>
    /// <para> Represents the following element tag in the schema: cs:dataPoint </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public DataPoint DataPoint
    {
        get => GetElement<DataPoint>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> DataPoint3D.</para>
    /// <para> Represents the following element tag in the schema: cs:dataPoint3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public DataPoint3D DataPoint3D
    {
        get => GetElement<DataPoint3D>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> DataPointLine.</para>
    /// <para> Represents the following element tag in the schema: cs:dataPointLine </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public DataPointLine DataPointLine
    {
        get => GetElement<DataPointLine>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> DataPointMarker.</para>
    /// <para> Represents the following element tag in the schema: cs:dataPointMarker </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public DataPointMarker DataPointMarker
    {
        get => GetElement<DataPointMarker>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> MarkerLayoutProperties.</para>
    /// <para> Represents the following element tag in the schema: cs:dataPointMarkerLayout </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public MarkerLayoutProperties MarkerLayoutProperties
    {
        get => GetElement<MarkerLayoutProperties>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> DataPointWireframe.</para>
    /// <para> Represents the following element tag in the schema: cs:dataPointWireframe </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public DataPointWireframe DataPointWireframe
    {
        get => GetElement<DataPointWireframe>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> DataTableStyle.</para>
    /// <para> Represents the following element tag in the schema: cs:dataTable </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public DataTableStyle DataTableStyle
    {
        get => GetElement<DataTableStyle>(11);
        set => SetElement(11, value);
    }
    /// <summary>
    /// <para> DownBar.</para>
    /// <para> Represents the following element tag in the schema: cs:downBar </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public DownBar DownBar
    {
        get => GetElement<DownBar>(12);
        set => SetElement(12, value);
    }
    /// <summary>
    /// <para> DropLine.</para>
    /// <para> Represents the following element tag in the schema: cs:dropLine </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public DropLine DropLine
    {
        get => GetElement<DropLine>(13);
        set => SetElement(13, value);
    }
    /// <summary>
    /// <para> ErrorBar.</para>
    /// <para> Represents the following element tag in the schema: cs:errorBar </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public ErrorBar ErrorBar
    {
        get => GetElement<ErrorBar>(14);
        set => SetElement(14, value);
    }
    /// <summary>
    /// <para> Floor.</para>
    /// <para> Represents the following element tag in the schema: cs:floor </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public Floor Floor
    {
        get => GetElement<Floor>(15);
        set => SetElement(15, value);
    }
    /// <summary>
    /// <para> GridlineMajor.</para>
    /// <para> Represents the following element tag in the schema: cs:gridlineMajor </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public GridlineMajor GridlineMajor
    {
        get => GetElement<GridlineMajor>(16);
        set => SetElement(16, value);
    }
    /// <summary>
    /// <para> GridlineMinor.</para>
    /// <para> Represents the following element tag in the schema: cs:gridlineMinor </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public GridlineMinor GridlineMinor
    {
        get => GetElement<GridlineMinor>(17);
        set => SetElement(17, value);
    }
    /// <summary>
    /// <para> HiLoLine.</para>
    /// <para> Represents the following element tag in the schema: cs:hiLoLine </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public HiLoLine HiLoLine
    {
        get => GetElement<HiLoLine>(18);
        set => SetElement(18, value);
    }
    /// <summary>
    /// <para> LeaderLine.</para>
    /// <para> Represents the following element tag in the schema: cs:leaderLine </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public LeaderLine LeaderLine
    {
        get => GetElement<LeaderLine>(19);
        set => SetElement(19, value);
    }
    /// <summary>
    /// <para> LegendStyle.</para>
    /// <para> Represents the following element tag in the schema: cs:legend </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public LegendStyle LegendStyle
    {
        get => GetElement<LegendStyle>(20);
        set => SetElement(20, value);
    }
    /// <summary>
    /// <para> PlotArea.</para>
    /// <para> Represents the following element tag in the schema: cs:plotArea </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public PlotArea PlotArea
    {
        get => GetElement<PlotArea>(21);
        set => SetElement(21, value);
    }
    /// <summary>
    /// <para> PlotArea3D.</para>
    /// <para> Represents the following element tag in the schema: cs:plotArea3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public PlotArea3D PlotArea3D
    {
        get => GetElement<PlotArea3D>(22);
        set => SetElement(22, value);
    }
    /// <summary>
    /// <para> SeriesAxis.</para>
    /// <para> Represents the following element tag in the schema: cs:seriesAxis </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public SeriesAxis SeriesAxis
    {
        get => GetElement<SeriesAxis>(23);
        set => SetElement(23, value);
    }
    /// <summary>
    /// <para> SeriesLine.</para>
    /// <para> Represents the following element tag in the schema: cs:seriesLine </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public SeriesLine SeriesLine
    {
        get => GetElement<SeriesLine>(24);
        set => SetElement(24, value);
    }
    /// <summary>
    /// <para> TitleStyle.</para>
    /// <para> Represents the following element tag in the schema: cs:title </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public TitleStyle TitleStyle
    {
        get => GetElement<TitleStyle>(25);
        set => SetElement(25, value);
    }
    /// <summary>
    /// <para> TrendlineStyle.</para>
    /// <para> Represents the following element tag in the schema: cs:trendline </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public TrendlineStyle TrendlineStyle
    {
        get => GetElement<TrendlineStyle>(26);
        set => SetElement(26, value);
    }
    /// <summary>
    /// <para> TrendlineLabel.</para>
    /// <para> Represents the following element tag in the schema: cs:trendlineLabel </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public TrendlineLabel TrendlineLabel
    {
        get => GetElement<TrendlineLabel>(27);
        set => SetElement(27, value);
    }
    /// <summary>
    /// <para> UpBar.</para>
    /// <para> Represents the following element tag in the schema: cs:upBar </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public UpBar UpBar
    {
        get => GetElement<UpBar>(28);
        set => SetElement(28, value);
    }
    /// <summary>
    /// <para> ValueAxis.</para>
    /// <para> Represents the following element tag in the schema: cs:valueAxis </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public ValueAxis ValueAxis
    {
        get => GetElement<ValueAxis>(29);
        set => SetElement(29, value);
    }
    /// <summary>
    /// <para> Wall.</para>
    /// <para> Represents the following element tag in the schema: cs:wall </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public Wall Wall
    {
        get => GetElement<Wall>(30);
        set => SetElement(30, value);
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cs:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<OfficeArtExtensionList>(31);
        set => SetElement(31, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartStyle>(deep);

}
/// <summary>
/// <para>Defines the ColorStyleVariation Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:variation.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Tint &lt;a:tint></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Shade &lt;a:shade></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Complement &lt;a:comp></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Inverse &lt;a:inv></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Gray &lt;a:gray></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Alpha &lt;a:alpha></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaOffset &lt;a:alphaOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaModulation &lt;a:alphaMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Hue &lt;a:hue></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HueOffset &lt;a:hueOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HueModulation &lt;a:hueMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Saturation &lt;a:sat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SaturationOffset &lt;a:satOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SaturationModulation &lt;a:satMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Luminance &lt;a:lum></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.LuminanceOffset &lt;a:lumOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.LuminanceModulation &lt;a:lumMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Red &lt;a:red></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RedOffset &lt;a:redOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RedModulation &lt;a:redMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Green &lt;a:green></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GreenOffset &lt;a:greenOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GreenModulation &lt;a:greenMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Blue &lt;a:blue></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlueOffset &lt;a:blueOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlueModulation &lt;a:blueMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Gamma &lt;a:gamma></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.InverseGamma &lt;a:invGamma></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Tint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shade))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Complement))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Inverse))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Gray))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Alpha))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Hue))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HueOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HueModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Saturation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SaturationOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SaturationModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Luminance))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LuminanceOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LuminanceModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Red))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RedOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RedModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Green))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GreenOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GreenModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Blue))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlueOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlueModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Gamma))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.InverseGamma))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ColorStyleVariation : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13258;
    /// <inheritdoc/>
    public override string LocalName => "variation";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ColorStyleVariation class.
    /// </summary>
    public ColorStyleVariation():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ColorStyleVariation class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorStyleVariation(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorStyleVariation class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorStyleVariation(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorStyleVariation class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorStyleVariation(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "tint" == name)
    return new DocumentFormat.OpenXml.Drawing.Tint();
    
if( 10 == namespaceId && "shade" == name)
    return new DocumentFormat.OpenXml.Drawing.Shade();
    
if( 10 == namespaceId && "comp" == name)
    return new DocumentFormat.OpenXml.Drawing.Complement();
    
if( 10 == namespaceId && "inv" == name)
    return new DocumentFormat.OpenXml.Drawing.Inverse();
    
if( 10 == namespaceId && "gray" == name)
    return new DocumentFormat.OpenXml.Drawing.Gray();
    
if( 10 == namespaceId && "alpha" == name)
    return new DocumentFormat.OpenXml.Drawing.Alpha();
    
if( 10 == namespaceId && "alphaOff" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaOffset();
    
if( 10 == namespaceId && "alphaMod" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaModulation();
    
if( 10 == namespaceId && "hue" == name)
    return new DocumentFormat.OpenXml.Drawing.Hue();
    
if( 10 == namespaceId && "hueOff" == name)
    return new DocumentFormat.OpenXml.Drawing.HueOffset();
    
if( 10 == namespaceId && "hueMod" == name)
    return new DocumentFormat.OpenXml.Drawing.HueModulation();
    
if( 10 == namespaceId && "sat" == name)
    return new DocumentFormat.OpenXml.Drawing.Saturation();
    
if( 10 == namespaceId && "satOff" == name)
    return new DocumentFormat.OpenXml.Drawing.SaturationOffset();
    
if( 10 == namespaceId && "satMod" == name)
    return new DocumentFormat.OpenXml.Drawing.SaturationModulation();
    
if( 10 == namespaceId && "lum" == name)
    return new DocumentFormat.OpenXml.Drawing.Luminance();
    
if( 10 == namespaceId && "lumOff" == name)
    return new DocumentFormat.OpenXml.Drawing.LuminanceOffset();
    
if( 10 == namespaceId && "lumMod" == name)
    return new DocumentFormat.OpenXml.Drawing.LuminanceModulation();
    
if( 10 == namespaceId && "red" == name)
    return new DocumentFormat.OpenXml.Drawing.Red();
    
if( 10 == namespaceId && "redOff" == name)
    return new DocumentFormat.OpenXml.Drawing.RedOffset();
    
if( 10 == namespaceId && "redMod" == name)
    return new DocumentFormat.OpenXml.Drawing.RedModulation();
    
if( 10 == namespaceId && "green" == name)
    return new DocumentFormat.OpenXml.Drawing.Green();
    
if( 10 == namespaceId && "greenOff" == name)
    return new DocumentFormat.OpenXml.Drawing.GreenOffset();
    
if( 10 == namespaceId && "greenMod" == name)
    return new DocumentFormat.OpenXml.Drawing.GreenModulation();
    
if( 10 == namespaceId && "blue" == name)
    return new DocumentFormat.OpenXml.Drawing.Blue();
    
if( 10 == namespaceId && "blueOff" == name)
    return new DocumentFormat.OpenXml.Drawing.BlueOffset();
    
if( 10 == namespaceId && "blueMod" == name)
    return new DocumentFormat.OpenXml.Drawing.BlueModulation();
    
if( 10 == namespaceId && "gamma" == name)
    return new DocumentFormat.OpenXml.Drawing.Gamma();
    
if( 10 == namespaceId && "invGamma" == name)
    return new DocumentFormat.OpenXml.Drawing.InverseGamma();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorStyleVariation>(deep);

}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13259;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class.
    /// </summary>
    public OfficeArtExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OfficeArtExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Drawing.Extension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);

}
/// <summary>
/// <para>Defines the StyleColor Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:styleClr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Tint &lt;a:tint></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Shade &lt;a:shade></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Complement &lt;a:comp></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Inverse &lt;a:inv></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Gray &lt;a:gray></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Alpha &lt;a:alpha></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaOffset &lt;a:alphaOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaModulation &lt;a:alphaMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Hue &lt;a:hue></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HueOffset &lt;a:hueOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HueModulation &lt;a:hueMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Saturation &lt;a:sat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SaturationOffset &lt;a:satOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SaturationModulation &lt;a:satMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Luminance &lt;a:lum></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.LuminanceOffset &lt;a:lumOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.LuminanceModulation &lt;a:lumMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Red &lt;a:red></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RedOffset &lt;a:redOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RedModulation &lt;a:redMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Green &lt;a:green></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GreenOffset &lt;a:greenOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GreenModulation &lt;a:greenMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Blue &lt;a:blue></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlueOffset &lt;a:blueOff></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlueModulation &lt;a:blueMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Gamma &lt;a:gamma></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.InverseGamma &lt;a:invGamma></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Tint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shade))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Complement))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Inverse))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Gray))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Alpha))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Hue))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HueOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HueModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Saturation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SaturationOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SaturationModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Luminance))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LuminanceOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LuminanceModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Red))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RedOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RedModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Green))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GreenOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GreenModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Blue))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlueOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlueModulation))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Gamma))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.InverseGamma))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class StyleColor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13260;
    /// <inheritdoc/>
    public override string LocalName => "styleClr";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StyleColor class.
    /// </summary>
    public StyleColor():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StyleColor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleColor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleColor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleColor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleColor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StyleColor(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "tint" == name)
    return new DocumentFormat.OpenXml.Drawing.Tint();
    
if( 10 == namespaceId && "shade" == name)
    return new DocumentFormat.OpenXml.Drawing.Shade();
    
if( 10 == namespaceId && "comp" == name)
    return new DocumentFormat.OpenXml.Drawing.Complement();
    
if( 10 == namespaceId && "inv" == name)
    return new DocumentFormat.OpenXml.Drawing.Inverse();
    
if( 10 == namespaceId && "gray" == name)
    return new DocumentFormat.OpenXml.Drawing.Gray();
    
if( 10 == namespaceId && "alpha" == name)
    return new DocumentFormat.OpenXml.Drawing.Alpha();
    
if( 10 == namespaceId && "alphaOff" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaOffset();
    
if( 10 == namespaceId && "alphaMod" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaModulation();
    
if( 10 == namespaceId && "hue" == name)
    return new DocumentFormat.OpenXml.Drawing.Hue();
    
if( 10 == namespaceId && "hueOff" == name)
    return new DocumentFormat.OpenXml.Drawing.HueOffset();
    
if( 10 == namespaceId && "hueMod" == name)
    return new DocumentFormat.OpenXml.Drawing.HueModulation();
    
if( 10 == namespaceId && "sat" == name)
    return new DocumentFormat.OpenXml.Drawing.Saturation();
    
if( 10 == namespaceId && "satOff" == name)
    return new DocumentFormat.OpenXml.Drawing.SaturationOffset();
    
if( 10 == namespaceId && "satMod" == name)
    return new DocumentFormat.OpenXml.Drawing.SaturationModulation();
    
if( 10 == namespaceId && "lum" == name)
    return new DocumentFormat.OpenXml.Drawing.Luminance();
    
if( 10 == namespaceId && "lumOff" == name)
    return new DocumentFormat.OpenXml.Drawing.LuminanceOffset();
    
if( 10 == namespaceId && "lumMod" == name)
    return new DocumentFormat.OpenXml.Drawing.LuminanceModulation();
    
if( 10 == namespaceId && "red" == name)
    return new DocumentFormat.OpenXml.Drawing.Red();
    
if( 10 == namespaceId && "redOff" == name)
    return new DocumentFormat.OpenXml.Drawing.RedOffset();
    
if( 10 == namespaceId && "redMod" == name)
    return new DocumentFormat.OpenXml.Drawing.RedModulation();
    
if( 10 == namespaceId && "green" == name)
    return new DocumentFormat.OpenXml.Drawing.Green();
    
if( 10 == namespaceId && "greenOff" == name)
    return new DocumentFormat.OpenXml.Drawing.GreenOffset();
    
if( 10 == namespaceId && "greenMod" == name)
    return new DocumentFormat.OpenXml.Drawing.GreenModulation();
    
if( 10 == namespaceId && "blue" == name)
    return new DocumentFormat.OpenXml.Drawing.Blue();
    
if( 10 == namespaceId && "blueOff" == name)
    return new DocumentFormat.OpenXml.Drawing.BlueOffset();
    
if( 10 == namespaceId && "blueMod" == name)
    return new DocumentFormat.OpenXml.Drawing.BlueModulation();
    
if( 10 == namespaceId && "gamma" == name)
    return new DocumentFormat.OpenXml.Drawing.Gamma();
    
if( 10 == namespaceId && "invGamma" == name)
    return new DocumentFormat.OpenXml.Drawing.InverseGamma();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleColor>(deep);

}
/// <summary>
/// <para>Defines the LineReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:lnRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
///<item><description>StyleColor &lt;cs:styleClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class LineReference : StyleReference
{
    internal const int ElementTypeIdConst = 13261;
    /// <inheritdoc/>
    public override string LocalName => "lnRef";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the LineReference class.
    /// </summary>
    public LineReference():base(){}
        /// <summary>
    ///Initializes a new instance of the LineReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LineReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LineReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LineReference(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineReference>(deep);

}
/// <summary>
/// <para>Defines the FillReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:fillRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
///<item><description>StyleColor &lt;cs:styleClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FillReference : StyleReference
{
    internal const int ElementTypeIdConst = 13263;
    /// <inheritdoc/>
    public override string LocalName => "fillRef";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the FillReference class.
    /// </summary>
    public FillReference():base(){}
        /// <summary>
    ///Initializes a new instance of the FillReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FillReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FillReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FillReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FillReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FillReference(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillReference>(deep);

}
/// <summary>
/// <para>Defines the EffectReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:effectRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
///<item><description>StyleColor &lt;cs:styleClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class EffectReference : StyleReference
{
    internal const int ElementTypeIdConst = 13264;
    /// <inheritdoc/>
    public override string LocalName => "effectRef";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the EffectReference class.
    /// </summary>
    public EffectReference():base(){}
        /// <summary>
    ///Initializes a new instance of the EffectReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EffectReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the EffectReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EffectReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the EffectReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public EffectReference(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectReference>(deep);

}
/// <summary>
/// Defines the StyleReference class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
///<item><description>StyleColor &lt;cs:styleClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]
    [ChildElementInfo(typeof(StyleColor), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class StyleReference : OpenXmlCompositeElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "idx"),
		AttributeTag.Create<ListValue<StringValue>>(0, "mods")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> idx.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    public UInt32Value Index
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> mods.</para>
    /// <para>Represents the following attribute in the schema: mods </para>
    /// </summary>
    [SchemaAttr(0, "mods")]
    public ListValue<StringValue> Modifiers
    {
        get { return (ListValue<StringValue>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "scrgbClr" == name)
    return new DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage();
    
if( 10 == namespaceId && "srgbClr" == name)
    return new DocumentFormat.OpenXml.Drawing.RgbColorModelHex();
    
if( 10 == namespaceId && "hslClr" == name)
    return new DocumentFormat.OpenXml.Drawing.HslColor();
    
if( 10 == namespaceId && "sysClr" == name)
    return new DocumentFormat.OpenXml.Drawing.SystemColor();
    
if( 10 == namespaceId && "schemeClr" == name)
    return new DocumentFormat.OpenXml.Drawing.SchemeColor();
    
if( 10 == namespaceId && "prstClr" == name)
    return new DocumentFormat.OpenXml.Drawing.PresetColor();
    
if( 65 == namespaceId && "styleClr" == name)
    return new StyleColor();
    

    return null;
}

    
    
    /// <summary>
    /// Initializes a new instance of the StyleReference class.
    /// </summary>
    protected StyleReference(){}
    
        /// <summary>
    ///Initializes a new instance of the StyleReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected StyleReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected StyleReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected StyleReference(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the LineWidthScale Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:lineWidthScale.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class LineWidthScale : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13262;
    /// <inheritdoc/>
    public override string LocalName => "lineWidthScale";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LineWidthScale class.
    /// </summary>
    public LineWidthScale():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the LineWidthScale class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public LineWidthScale(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new DoubleValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineWidthScale>(deep);

}
/// <summary>
/// <para>Defines the FontReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:fontRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
///<item><description>StyleColor &lt;cs:styleClr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]
    [ChildElementInfo(typeof(StyleColor), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FontReference : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13265;
    /// <inheritdoc/>
    public override string LocalName => "fontRef";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues>>(0, "idx"),
		AttributeTag.Create<ListValue<StringValue>>(0, "mods")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> idx.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues> Index
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> mods.</para>
    /// <para>Represents the following attribute in the schema: mods </para>
    /// </summary>
    [SchemaAttr(0, "mods")]
    public ListValue<StringValue> Modifiers
    {
        get { return (ListValue<StringValue>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FontReference class.
    /// </summary>
    public FontReference():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FontReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FontReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FontReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FontReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FontReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FontReference(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "scrgbClr" == name)
    return new DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage();
    
if( 10 == namespaceId && "srgbClr" == name)
    return new DocumentFormat.OpenXml.Drawing.RgbColorModelHex();
    
if( 10 == namespaceId && "hslClr" == name)
    return new DocumentFormat.OpenXml.Drawing.HslColor();
    
if( 10 == namespaceId && "sysClr" == name)
    return new DocumentFormat.OpenXml.Drawing.SystemColor();
    
if( 10 == namespaceId && "schemeClr" == name)
    return new DocumentFormat.OpenXml.Drawing.SchemeColor();
    
if( 10 == namespaceId && "prstClr" == name)
    return new DocumentFormat.OpenXml.Drawing.PresetColor();
    
if( 65 == namespaceId && "styleClr" == name)
    return new StyleColor();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FontReference>(deep);

}
/// <summary>
/// <para>Defines the ShapeProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:spPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Transform2D &lt;a:xfrm></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Transform2D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13266;
    /// <inheritdoc/>
    public override string LocalName => "spPr";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>(0, "bwMode")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShapeProperties class.
    /// </summary>
    public ShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "xfrm" == name)
    return new DocumentFormat.OpenXml.Drawing.Transform2D();
    
if( 10 == namespaceId && "custGeom" == name)
    return new DocumentFormat.OpenXml.Drawing.CustomGeometry();
    
if( 10 == namespaceId && "prstGeom" == name)
    return new DocumentFormat.OpenXml.Drawing.PresetGeometry();
    
if( 10 == namespaceId && "noFill" == name)
    return new DocumentFormat.OpenXml.Drawing.NoFill();
    
if( 10 == namespaceId && "solidFill" == name)
    return new DocumentFormat.OpenXml.Drawing.SolidFill();
    
if( 10 == namespaceId && "gradFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GradientFill();
    
if( 10 == namespaceId && "blipFill" == name)
    return new DocumentFormat.OpenXml.Drawing.BlipFill();
    
if( 10 == namespaceId && "pattFill" == name)
    return new DocumentFormat.OpenXml.Drawing.PatternFill();
    
if( 10 == namespaceId && "grpFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GroupFill();
    
if( 10 == namespaceId && "ln" == name)
    return new DocumentFormat.OpenXml.Drawing.Outline();
    
if( 10 == namespaceId && "effectLst" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectList();
    
if( 10 == namespaceId && "effectDag" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectDag();
    
if( 10 == namespaceId && "scene3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Scene3DType();
    
if( 10 == namespaceId && "sp3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Shape3DType();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "xfrm","custGeom","prstGeom","noFill","solidFill","gradFill","blipFill","pattFill","grpFill","ln","effectLst","effectDag","scene3d","sp3d","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10,10,10,10,10,10,10,10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> 2D Transform for Individual Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);

}
/// <summary>
/// <para>Defines the TextCharacterPropertiesType Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:defRPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Highlight &lt;a:highlight></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.UnderlineFollowsText &lt;a:uLnTx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Underline &lt;a:uLn></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.UnderlineFillText &lt;a:uFillTx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.UnderlineFill &lt;a:uFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.LatinFont &lt;a:latin></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EastAsianFont &lt;a:ea></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ComplexScriptFont &lt;a:cs></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SymbolFont &lt;a:sym></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver &lt;a:hlinkMouseOver></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RightToLeft &lt;a:rtl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Highlight))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.UnderlineFollowsText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Underline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.UnderlineFillText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.UnderlineFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LatinFont))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EastAsianFont))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ComplexScriptFont))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SymbolFont))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RightToLeft))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TextCharacterPropertiesType : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13267;
    /// <inheritdoc/>
    public override string LocalName => "defRPr";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "kumimoji"),
		AttributeTag.Create<StringValue>(0, "lang"),
		AttributeTag.Create<StringValue>(0, "altLang"),
		AttributeTag.Create<Int32Value>(0, "sz"),
		AttributeTag.Create<BooleanValue>(0, "b"),
		AttributeTag.Create<BooleanValue>(0, "i"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues>>(0, "u"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues>>(0, "strike"),
		AttributeTag.Create<Int32Value>(0, "kern"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues>>(0, "cap"),
		AttributeTag.Create<Int32Value>(0, "spc"),
		AttributeTag.Create<BooleanValue>(0, "normalizeH"),
		AttributeTag.Create<Int32Value>(0, "baseline"),
		AttributeTag.Create<BooleanValue>(0, "noProof"),
		AttributeTag.Create<BooleanValue>(0, "dirty"),
		AttributeTag.Create<BooleanValue>(0, "err"),
		AttributeTag.Create<StringValue>(0, "bmk")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> kumimoji.</para>
    /// <para>Represents the following attribute in the schema: kumimoji </para>
    /// </summary>
    [SchemaAttr(0, "kumimoji")]
    public BooleanValue Kumimoji
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> lang.</para>
    /// <para>Represents the following attribute in the schema: lang </para>
    /// </summary>
    [SchemaAttr(0, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> altLang.</para>
    /// <para>Represents the following attribute in the schema: altLang </para>
    /// </summary>
    [SchemaAttr(0, "altLang")]
    public StringValue AlternativeLanguage
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> sz.</para>
    /// <para>Represents the following attribute in the schema: sz </para>
    /// </summary>
    [SchemaAttr(0, "sz")]
    public Int32Value FontSize
    {
        get { return (Int32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> b.</para>
    /// <para>Represents the following attribute in the schema: b </para>
    /// </summary>
    [SchemaAttr(0, "b")]
    public BooleanValue Bold
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> i.</para>
    /// <para>Represents the following attribute in the schema: i </para>
    /// </summary>
    [SchemaAttr(0, "i")]
    public BooleanValue Italic
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> u.</para>
    /// <para>Represents the following attribute in the schema: u </para>
    /// </summary>
    [SchemaAttr(0, "u")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues> Underline
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues>)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> strike.</para>
    /// <para>Represents the following attribute in the schema: strike </para>
    /// </summary>
    [SchemaAttr(0, "strike")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues> Strike
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues>)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> kern.</para>
    /// <para>Represents the following attribute in the schema: kern </para>
    /// </summary>
    [SchemaAttr(0, "kern")]
    public Int32Value Kerning
    {
        get { return (Int32Value)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> cap.</para>
    /// <para>Represents the following attribute in the schema: cap </para>
    /// </summary>
    [SchemaAttr(0, "cap")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues> Capital
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues>)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> spc.</para>
    /// <para>Represents the following attribute in the schema: spc </para>
    /// </summary>
    [SchemaAttr(0, "spc")]
    public Int32Value Spacing
    {
        get { return (Int32Value)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> normalizeH.</para>
    /// <para>Represents the following attribute in the schema: normalizeH </para>
    /// </summary>
    [SchemaAttr(0, "normalizeH")]
    public BooleanValue NormalizeHeight
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> baseline.</para>
    /// <para>Represents the following attribute in the schema: baseline </para>
    /// </summary>
    [SchemaAttr(0, "baseline")]
    public Int32Value Baseline
    {
        get { return (Int32Value)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> noProof.</para>
    /// <para>Represents the following attribute in the schema: noProof </para>
    /// </summary>
    [SchemaAttr(0, "noProof")]
    public BooleanValue NoProof
    {
        get { return (BooleanValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> dirty.</para>
    /// <para>Represents the following attribute in the schema: dirty </para>
    /// </summary>
    [SchemaAttr(0, "dirty")]
    public BooleanValue Dirty
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> err.</para>
    /// <para>Represents the following attribute in the schema: err </para>
    /// </summary>
    [SchemaAttr(0, "err")]
    public BooleanValue SpellingError
    {
        get { return (BooleanValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> bmk.</para>
    /// <para>Represents the following attribute in the schema: bmk </para>
    /// </summary>
    [SchemaAttr(0, "bmk")]
    public StringValue Bookmark
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TextCharacterPropertiesType class.
    /// </summary>
    public TextCharacterPropertiesType():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TextCharacterPropertiesType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextCharacterPropertiesType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextCharacterPropertiesType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextCharacterPropertiesType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextCharacterPropertiesType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextCharacterPropertiesType(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "ln" == name)
    return new DocumentFormat.OpenXml.Drawing.Outline();
    
if( 10 == namespaceId && "noFill" == name)
    return new DocumentFormat.OpenXml.Drawing.NoFill();
    
if( 10 == namespaceId && "solidFill" == name)
    return new DocumentFormat.OpenXml.Drawing.SolidFill();
    
if( 10 == namespaceId && "gradFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GradientFill();
    
if( 10 == namespaceId && "blipFill" == name)
    return new DocumentFormat.OpenXml.Drawing.BlipFill();
    
if( 10 == namespaceId && "pattFill" == name)
    return new DocumentFormat.OpenXml.Drawing.PatternFill();
    
if( 10 == namespaceId && "grpFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GroupFill();
    
if( 10 == namespaceId && "effectLst" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectList();
    
if( 10 == namespaceId && "effectDag" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectDag();
    
if( 10 == namespaceId && "highlight" == name)
    return new DocumentFormat.OpenXml.Drawing.Highlight();
    
if( 10 == namespaceId && "uLnTx" == name)
    return new DocumentFormat.OpenXml.Drawing.UnderlineFollowsText();
    
if( 10 == namespaceId && "uLn" == name)
    return new DocumentFormat.OpenXml.Drawing.Underline();
    
if( 10 == namespaceId && "uFillTx" == name)
    return new DocumentFormat.OpenXml.Drawing.UnderlineFillText();
    
if( 10 == namespaceId && "uFill" == name)
    return new DocumentFormat.OpenXml.Drawing.UnderlineFill();
    
if( 10 == namespaceId && "latin" == name)
    return new DocumentFormat.OpenXml.Drawing.LatinFont();
    
if( 10 == namespaceId && "ea" == name)
    return new DocumentFormat.OpenXml.Drawing.EastAsianFont();
    
if( 10 == namespaceId && "cs" == name)
    return new DocumentFormat.OpenXml.Drawing.ComplexScriptFont();
    
if( 10 == namespaceId && "sym" == name)
    return new DocumentFormat.OpenXml.Drawing.SymbolFont();
    
if( 10 == namespaceId && "hlinkClick" == name)
    return new DocumentFormat.OpenXml.Drawing.HyperlinkOnClick();
    
if( 10 == namespaceId && "hlinkMouseOver" == name)
    return new DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver();
    
if( 10 == namespaceId && "rtl" == name)
    return new DocumentFormat.OpenXml.Drawing.RightToLeft();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ln","noFill","solidFill","gradFill","blipFill","pattFill","grpFill","effectLst","effectDag","highlight","uLnTx","uLn","uFillTx","uFill","latin","ea","cs","sym","hlinkClick","hlinkMouseOver","rtl","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Outline.</para>
    /// <para> Represents the following element tag in the schema: a:ln </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Outline Outline
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Outline>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextCharacterPropertiesType>(deep);

}
/// <summary>
/// <para>Defines the TextBodyProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:bodyPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.PresetTextWrap &lt;a:prstTxWarp></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NoAutoFit &lt;a:noAutofit></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NormalAutoFit &lt;a:normAutofit></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ShapeAutoFit &lt;a:spAutoFit></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.FlatText &lt;a:flatTx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetTextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoAutoFit))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NormalAutoFit))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapeAutoFit))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FlatText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TextBodyProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13268;
    /// <inheritdoc/>
    public override string LocalName => "bodyPr";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "rot"),
		AttributeTag.Create<BooleanValue>(0, "spcFirstLastPara"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues>>(0, "vertOverflow"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues>>(0, "horzOverflow"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues>>(0, "vert"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues>>(0, "wrap"),
		AttributeTag.Create<Int32Value>(0, "lIns"),
		AttributeTag.Create<Int32Value>(0, "tIns"),
		AttributeTag.Create<Int32Value>(0, "rIns"),
		AttributeTag.Create<Int32Value>(0, "bIns"),
		AttributeTag.Create<Int32Value>(0, "numCol"),
		AttributeTag.Create<Int32Value>(0, "spcCol"),
		AttributeTag.Create<BooleanValue>(0, "rtlCol"),
		AttributeTag.Create<BooleanValue>(0, "fromWordArt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues>>(0, "anchor"),
		AttributeTag.Create<BooleanValue>(0, "anchorCtr"),
		AttributeTag.Create<BooleanValue>(0, "forceAA"),
		AttributeTag.Create<BooleanValue>(0, "upright"),
		AttributeTag.Create<BooleanValue>(0, "compatLnSpc")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Rotation.</para>
    /// <para>Represents the following attribute in the schema: rot </para>
    /// </summary>
    [SchemaAttr(0, "rot")]
    public Int32Value Rotation
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Paragraph Spacing.</para>
    /// <para>Represents the following attribute in the schema: spcFirstLastPara </para>
    /// </summary>
    [SchemaAttr(0, "spcFirstLastPara")]
    public BooleanValue UseParagraphSpacing
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Vertical Overflow.</para>
    /// <para>Represents the following attribute in the schema: vertOverflow </para>
    /// </summary>
    [SchemaAttr(0, "vertOverflow")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues> VerticalOverflow
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Horizontal Overflow.</para>
    /// <para>Represents the following attribute in the schema: horzOverflow </para>
    /// </summary>
    [SchemaAttr(0, "horzOverflow")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues> HorizontalOverflow
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Vertical Text.</para>
    /// <para>Represents the following attribute in the schema: vert </para>
    /// </summary>
    [SchemaAttr(0, "vert")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues> Vertical
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Wrapping Type.</para>
    /// <para>Represents the following attribute in the schema: wrap </para>
    /// </summary>
    [SchemaAttr(0, "wrap")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues> Wrap
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Left Inset.</para>
    /// <para>Represents the following attribute in the schema: lIns </para>
    /// </summary>
    [SchemaAttr(0, "lIns")]
    public Int32Value LeftInset
    {
        get { return (Int32Value)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Top Inset.</para>
    /// <para>Represents the following attribute in the schema: tIns </para>
    /// </summary>
    [SchemaAttr(0, "tIns")]
    public Int32Value TopInset
    {
        get { return (Int32Value)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Right Inset.</para>
    /// <para>Represents the following attribute in the schema: rIns </para>
    /// </summary>
    [SchemaAttr(0, "rIns")]
    public Int32Value RightInset
    {
        get { return (Int32Value)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Inset.</para>
    /// <para>Represents the following attribute in the schema: bIns </para>
    /// </summary>
    [SchemaAttr(0, "bIns")]
    public Int32Value BottomInset
    {
        get { return (Int32Value)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Number of Columns.</para>
    /// <para>Represents the following attribute in the schema: numCol </para>
    /// </summary>
    [SchemaAttr(0, "numCol")]
    public Int32Value ColumnCount
    {
        get { return (Int32Value)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Space Between Columns.</para>
    /// <para>Represents the following attribute in the schema: spcCol </para>
    /// </summary>
    [SchemaAttr(0, "spcCol")]
    public Int32Value ColumnSpacing
    {
        get { return (Int32Value)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Columns Right-To-Left.</para>
    /// <para>Represents the following attribute in the schema: rtlCol </para>
    /// </summary>
    [SchemaAttr(0, "rtlCol")]
    public BooleanValue RightToLeftColumns
    {
        get { return (BooleanValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> From WordArt.</para>
    /// <para>Represents the following attribute in the schema: fromWordArt </para>
    /// </summary>
    [SchemaAttr(0, "fromWordArt")]
    public BooleanValue FromWordArt
    {
        get { return (BooleanValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Anchor.</para>
    /// <para>Represents the following attribute in the schema: anchor </para>
    /// </summary>
    [SchemaAttr(0, "anchor")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues> Anchor
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues>)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Anchor Center.</para>
    /// <para>Represents the following attribute in the schema: anchorCtr </para>
    /// </summary>
    [SchemaAttr(0, "anchorCtr")]
    public BooleanValue AnchorCenter
    {
        get { return (BooleanValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Anti-Alias.</para>
    /// <para>Represents the following attribute in the schema: forceAA </para>
    /// </summary>
    [SchemaAttr(0, "forceAA")]
    public BooleanValue ForceAntiAlias
    {
        get { return (BooleanValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Upright.</para>
    /// <para>Represents the following attribute in the schema: upright </para>
    /// </summary>
    [SchemaAttr(0, "upright")]
    public BooleanValue UpRight
    {
        get { return (BooleanValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Compatible Line Spacing.</para>
    /// <para>Represents the following attribute in the schema: compatLnSpc </para>
    /// </summary>
    [SchemaAttr(0, "compatLnSpc")]
    public BooleanValue CompatibleLineSpacing
    {
        get { return (BooleanValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TextBodyProperties class.
    /// </summary>
    public TextBodyProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TextBodyProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextBodyProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextBodyProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextBodyProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextBodyProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextBodyProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "prstTxWarp" == name)
    return new DocumentFormat.OpenXml.Drawing.PresetTextWrap();
    
if( 10 == namespaceId && "noAutofit" == name)
    return new DocumentFormat.OpenXml.Drawing.NoAutoFit();
    
if( 10 == namespaceId && "normAutofit" == name)
    return new DocumentFormat.OpenXml.Drawing.NormalAutoFit();
    
if( 10 == namespaceId && "spAutoFit" == name)
    return new DocumentFormat.OpenXml.Drawing.ShapeAutoFit();
    
if( 10 == namespaceId && "scene3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Scene3DType();
    
if( 10 == namespaceId && "sp3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Shape3DType();
    
if( 10 == namespaceId && "flatTx" == name)
    return new DocumentFormat.OpenXml.Drawing.FlatText();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "prstTxWarp","noAutofit","normAutofit","spAutoFit","scene3d","sp3d","flatTx","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Preset Text Shape.</para>
    /// <para> Represents the following element tag in the schema: a:prstTxWarp </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.PresetTextWrap PresetTextWrap
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.PresetTextWrap>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyProperties>(deep);

}
/// <summary>
/// <para>Defines the CategoryAxisProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:categoryAxis.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CategoryAxisProperties : AxisProperties
{
    internal const int ElementTypeIdConst = 13269;
    /// <inheritdoc/>
    public override string LocalName => "categoryAxis";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the CategoryAxisProperties class.
    /// </summary>
    public CategoryAxisProperties():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxisProperties>(deep);

}
/// <summary>
/// <para>Defines the SeriesAxisProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:seriesAxis.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SeriesAxisProperties : AxisProperties
{
    internal const int ElementTypeIdConst = 13274;
    /// <inheritdoc/>
    public override string LocalName => "seriesAxis";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the SeriesAxisProperties class.
    /// </summary>
    public SeriesAxisProperties():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesAxisProperties>(deep);

}
/// <summary>
/// <para>Defines the ValueAxisProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:valueAxis.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ValueAxisProperties : AxisProperties
{
    internal const int ElementTypeIdConst = 13277;
    /// <inheritdoc/>
    public override string LocalName => "valueAxis";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the ValueAxisProperties class.
    /// </summary>
    public ValueAxisProperties():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValueAxisProperties>(deep);

}
/// <summary>
/// Defines the AxisProperties class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class AxisProperties : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "visible"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch>>(0, "majorTick"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch>>(0, "minorTick"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickLabelPositionNinch>>(0, "labelPosition"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "majorGridlines"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "minorGridlines"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "title")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Visible
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> majorTick.</para>
    /// <para>Represents the following attribute in the schema: majorTick </para>
    /// </summary>
    [SchemaAttr(0, "majorTick")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch> MajorTick
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> minorTick.</para>
    /// <para>Represents the following attribute in the schema: minorTick </para>
    /// </summary>
    [SchemaAttr(0, "minorTick")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch> MinorTickProp
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> labelPosition.</para>
    /// <para>Represents the following attribute in the schema: labelPosition </para>
    /// </summary>
    [SchemaAttr(0, "labelPosition")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickLabelPositionNinch> LabelPosition
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickLabelPositionNinch>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> majorGridlines.</para>
    /// <para>Represents the following attribute in the schema: majorGridlines </para>
    /// </summary>
    [SchemaAttr(0, "majorGridlines")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> MajorGridlines
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> minorGridlines.</para>
    /// <para>Represents the following attribute in the schema: minorGridlines </para>
    /// </summary>
    [SchemaAttr(0, "minorGridlines")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> MinorGridlinesProp
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> TitleProp
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AxisProperties class.
    /// </summary>
    protected AxisProperties(){}
    
    
    
}
/// <summary>
/// <para>Defines the DataSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataSeries.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataSeries : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13270;
    /// <inheritdoc/>
    public override string LocalName => "dataSeries";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<SByteValue>(0, "overlap"),
		AttributeTag.Create<UInt16Value>(0, "gapWidth"),
		AttributeTag.Create<UInt16Value>(0, "gapDepth"),
		AttributeTag.Create<ByteValue>(0, "doughnutHoleSize"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "markerVisible"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "hiloLines"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "dropLines"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "seriesLines")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> overlap.</para>
    /// <para>Represents the following attribute in the schema: overlap </para>
    /// </summary>
    [SchemaAttr(0, "overlap")]
    public SByteValue Overlap
    {
        get { return (SByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> gapWidth.</para>
    /// <para>Represents the following attribute in the schema: gapWidth </para>
    /// </summary>
    [SchemaAttr(0, "gapWidth")]
    public UInt16Value GapWidth
    {
        get { return (UInt16Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> gapDepth.</para>
    /// <para>Represents the following attribute in the schema: gapDepth </para>
    /// </summary>
    [SchemaAttr(0, "gapDepth")]
    public UInt16Value GapDepth
    {
        get { return (UInt16Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> doughnutHoleSize.</para>
    /// <para>Represents the following attribute in the schema: doughnutHoleSize </para>
    /// </summary>
    [SchemaAttr(0, "doughnutHoleSize")]
    public ByteValue DoughnutHoleSize
    {
        get { return (ByteValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> markerVisible.</para>
    /// <para>Represents the following attribute in the schema: markerVisible </para>
    /// </summary>
    [SchemaAttr(0, "markerVisible")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> MarkerVisible
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> hiloLines.</para>
    /// <para>Represents the following attribute in the schema: hiloLines </para>
    /// </summary>
    [SchemaAttr(0, "hiloLines")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> HiloLines
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> dropLines.</para>
    /// <para>Represents the following attribute in the schema: dropLines </para>
    /// </summary>
    [SchemaAttr(0, "dropLines")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> DropLines
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> seriesLines.</para>
    /// <para>Represents the following attribute in the schema: seriesLines </para>
    /// </summary>
    [SchemaAttr(0, "seriesLines")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> SeriesLines
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataSeries class.
    /// </summary>
    public DataSeries():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataSeries>(deep);

}
/// <summary>
/// <para>Defines the DataLabels Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataLabels.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabels : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13271;
    /// <inheritdoc/>
    public override string LocalName => "dataLabels";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelsPosition>>(0, "position"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "value"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "seriesName"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "categoryName"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "legendKey"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "percentage")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelsPosition> Position
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelsPosition>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Value
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> seriesName.</para>
    /// <para>Represents the following attribute in the schema: seriesName </para>
    /// </summary>
    [SchemaAttr(0, "seriesName")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> SeriesName
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> categoryName.</para>
    /// <para>Represents the following attribute in the schema: categoryName </para>
    /// </summary>
    [SchemaAttr(0, "categoryName")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> CategoryName
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> legendKey.</para>
    /// <para>Represents the following attribute in the schema: legendKey </para>
    /// </summary>
    [SchemaAttr(0, "legendKey")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> LegendKey
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> percentage.</para>
    /// <para>Represents the following attribute in the schema: percentage </para>
    /// </summary>
    [SchemaAttr(0, "percentage")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Percentage
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataLabels class.
    /// </summary>
    public DataLabels():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabels>(deep);

}
/// <summary>
/// <para>Defines the DataTable Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataTable.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataTable : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13272;
    /// <inheritdoc/>
    public override string LocalName => "dataTable";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "legendKeys"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "horizontalBorder"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "verticalBorder"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "outlineBorder")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> legendKeys.</para>
    /// <para>Represents the following attribute in the schema: legendKeys </para>
    /// </summary>
    [SchemaAttr(0, "legendKeys")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> LegendKeys
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> horizontalBorder.</para>
    /// <para>Represents the following attribute in the schema: horizontalBorder </para>
    /// </summary>
    [SchemaAttr(0, "horizontalBorder")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> HorizontalBorder
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> verticalBorder.</para>
    /// <para>Represents the following attribute in the schema: verticalBorder </para>
    /// </summary>
    [SchemaAttr(0, "verticalBorder")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> VerticalBorder
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> outlineBorder.</para>
    /// <para>Represents the following attribute in the schema: outlineBorder </para>
    /// </summary>
    [SchemaAttr(0, "outlineBorder")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> OutlineBorder
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataTable class.
    /// </summary>
    public DataTable():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataTable>(deep);

}
/// <summary>
/// <para>Defines the Legend Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:legend.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Legend : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13273;
    /// <inheritdoc/>
    public override string LocalName => "legend";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "visible"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "includeInLayout"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendPosition>>(0, "position")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Visible
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> includeInLayout.</para>
    /// <para>Represents the following attribute in the schema: includeInLayout </para>
    /// </summary>
    [SchemaAttr(0, "includeInLayout")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> IncludeInLayout
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendPosition> Position
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendPosition>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Legend class.
    /// </summary>
    public Legend():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Legend>(deep);

}
/// <summary>
/// <para>Defines the Title Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:title.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Title : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13275;
    /// <inheritdoc/>
    public override string LocalName => "title";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitlePosition>>(0, "position")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitlePosition> Position
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitlePosition>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Title class.
    /// </summary>
    public Title():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Title>(deep);

}
/// <summary>
/// <para>Defines the Trendline Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:trendline.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Trendline : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13276;
    /// <inheritdoc/>
    public override string LocalName => "trendline";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "add"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "equation"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "rsquared")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> add.</para>
    /// <para>Represents the following attribute in the schema: add </para>
    /// </summary>
    [SchemaAttr(0, "add")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Add
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> equation.</para>
    /// <para>Represents the following attribute in the schema: equation </para>
    /// </summary>
    [SchemaAttr(0, "equation")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Equation
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> rsquared.</para>
    /// <para>Represents the following attribute in the schema: rsquared </para>
    /// </summary>
    [SchemaAttr(0, "rsquared")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> RSquared
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Trendline class.
    /// </summary>
    public Trendline():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Trendline>(deep);

}
/// <summary>
/// <para>Defines the View3DProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:view3D.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class View3DProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13278;
    /// <inheritdoc/>
    public override string LocalName => "view3D";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<SByteValue>(0, "rotX"),
		AttributeTag.Create<UInt16Value>(0, "rotY"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>(0, "rAngAx"),
		AttributeTag.Create<ByteValue>(0, "perspective"),
		AttributeTag.Create<UInt16Value>(0, "heightPercent"),
		AttributeTag.Create<UInt16Value>(0, "depthPercent")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rotX.</para>
    /// <para>Represents the following attribute in the schema: rotX </para>
    /// </summary>
    [SchemaAttr(0, "rotX")]
    public SByteValue RotX
    {
        get { return (SByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> rotY.</para>
    /// <para>Represents the following attribute in the schema: rotY </para>
    /// </summary>
    [SchemaAttr(0, "rotY")]
    public UInt16Value RotY
    {
        get { return (UInt16Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> rAngAx.</para>
    /// <para>Represents the following attribute in the schema: rAngAx </para>
    /// </summary>
    [SchemaAttr(0, "rAngAx")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> RightAngleAxes
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> perspective.</para>
    /// <para>Represents the following attribute in the schema: perspective </para>
    /// </summary>
    [SchemaAttr(0, "perspective")]
    public ByteValue Perspective
    {
        get { return (ByteValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> heightPercent.</para>
    /// <para>Represents the following attribute in the schema: heightPercent </para>
    /// </summary>
    [SchemaAttr(0, "heightPercent")]
    public UInt16Value HeightPercent
    {
        get { return (UInt16Value)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> depthPercent.</para>
    /// <para>Represents the following attribute in the schema: depthPercent </para>
    /// </summary>
    [SchemaAttr(0, "depthPercent")]
    public UInt16Value DepthPercent
    {
        get { return (UInt16Value)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the View3DProperties class.
    /// </summary>
    public View3DProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<View3DProperties>(deep);

}
/// <summary>
/// <para>Defines the AxisTitle Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:axisTitle.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class AxisTitle : StyleEntry
{
    internal const int ElementTypeIdConst = 13279;
    /// <inheritdoc/>
    public override string LocalName => "axisTitle";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the AxisTitle class.
    /// </summary>
    public AxisTitle():base(){}
        /// <summary>
    ///Initializes a new instance of the AxisTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AxisTitle(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisTitle>(deep);

}
/// <summary>
/// <para>Defines the CategoryAxis Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:categoryAxis.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CategoryAxis : StyleEntry
{
    internal const int ElementTypeIdConst = 13280;
    /// <inheritdoc/>
    public override string LocalName => "categoryAxis";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the CategoryAxis class.
    /// </summary>
    public CategoryAxis():base(){}
        /// <summary>
    ///Initializes a new instance of the CategoryAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryAxis(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryAxis(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryAxis class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryAxis(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxis>(deep);

}
/// <summary>
/// <para>Defines the ChartArea Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:chartArea.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ChartArea : StyleEntry
{
    internal const int ElementTypeIdConst = 13281;
    /// <inheritdoc/>
    public override string LocalName => "chartArea";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the ChartArea class.
    /// </summary>
    public ChartArea():base(){}
        /// <summary>
    ///Initializes a new instance of the ChartArea class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartArea(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartArea class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartArea(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartArea class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartArea(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartArea>(deep);

}
/// <summary>
/// <para>Defines the DataLabel Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataLabel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabel : StyleEntry
{
    internal const int ElementTypeIdConst = 13282;
    /// <inheritdoc/>
    public override string LocalName => "dataLabel";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DataLabel class.
    /// </summary>
    public DataLabel():base(){}
        /// <summary>
    ///Initializes a new instance of the DataLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabel(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);

}
/// <summary>
/// <para>Defines the DataLabelCallout Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataLabelCallout.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabelCallout : StyleEntry
{
    internal const int ElementTypeIdConst = 13283;
    /// <inheritdoc/>
    public override string LocalName => "dataLabelCallout";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DataLabelCallout class.
    /// </summary>
    public DataLabelCallout():base(){}
        /// <summary>
    ///Initializes a new instance of the DataLabelCallout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelCallout(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelCallout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelCallout(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelCallout class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelCallout(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelCallout>(deep);

}
/// <summary>
/// <para>Defines the DataPoint Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataPoint.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataPoint : StyleEntry
{
    internal const int ElementTypeIdConst = 13284;
    /// <inheritdoc/>
    public override string LocalName => "dataPoint";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DataPoint class.
    /// </summary>
    public DataPoint():base(){}
        /// <summary>
    ///Initializes a new instance of the DataPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPoint(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPoint(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPoint class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataPoint(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint>(deep);

}
/// <summary>
/// <para>Defines the DataPoint3D Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataPoint3D.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataPoint3D : StyleEntry
{
    internal const int ElementTypeIdConst = 13285;
    /// <inheritdoc/>
    public override string LocalName => "dataPoint3D";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DataPoint3D class.
    /// </summary>
    public DataPoint3D():base(){}
        /// <summary>
    ///Initializes a new instance of the DataPoint3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPoint3D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPoint3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPoint3D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPoint3D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataPoint3D(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint3D>(deep);

}
/// <summary>
/// <para>Defines the DataPointLine Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataPointLine.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataPointLine : StyleEntry
{
    internal const int ElementTypeIdConst = 13286;
    /// <inheritdoc/>
    public override string LocalName => "dataPointLine";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DataPointLine class.
    /// </summary>
    public DataPointLine():base(){}
        /// <summary>
    ///Initializes a new instance of the DataPointLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPointLine(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPointLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPointLine(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPointLine class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataPointLine(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPointLine>(deep);

}
/// <summary>
/// <para>Defines the DataPointMarker Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataPointMarker.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataPointMarker : StyleEntry
{
    internal const int ElementTypeIdConst = 13287;
    /// <inheritdoc/>
    public override string LocalName => "dataPointMarker";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DataPointMarker class.
    /// </summary>
    public DataPointMarker():base(){}
        /// <summary>
    ///Initializes a new instance of the DataPointMarker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPointMarker(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPointMarker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPointMarker(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPointMarker class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataPointMarker(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPointMarker>(deep);

}
/// <summary>
/// <para>Defines the DataPointWireframe Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataPointWireframe.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataPointWireframe : StyleEntry
{
    internal const int ElementTypeIdConst = 13289;
    /// <inheritdoc/>
    public override string LocalName => "dataPointWireframe";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DataPointWireframe class.
    /// </summary>
    public DataPointWireframe():base(){}
        /// <summary>
    ///Initializes a new instance of the DataPointWireframe class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPointWireframe(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPointWireframe class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPointWireframe(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPointWireframe class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataPointWireframe(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPointWireframe>(deep);

}
/// <summary>
/// <para>Defines the DataTableStyle Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataTable.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataTableStyle : StyleEntry
{
    internal const int ElementTypeIdConst = 13290;
    /// <inheritdoc/>
    public override string LocalName => "dataTable";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DataTableStyle class.
    /// </summary>
    public DataTableStyle():base(){}
        /// <summary>
    ///Initializes a new instance of the DataTableStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataTableStyle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataTableStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataTableStyle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataTableStyle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataTableStyle(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataTableStyle>(deep);

}
/// <summary>
/// <para>Defines the DownBar Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:downBar.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DownBar : StyleEntry
{
    internal const int ElementTypeIdConst = 13291;
    /// <inheritdoc/>
    public override string LocalName => "downBar";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DownBar class.
    /// </summary>
    public DownBar():base(){}
        /// <summary>
    ///Initializes a new instance of the DownBar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DownBar(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DownBar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DownBar(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DownBar class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DownBar(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DownBar>(deep);

}
/// <summary>
/// <para>Defines the DropLine Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dropLine.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DropLine : StyleEntry
{
    internal const int ElementTypeIdConst = 13292;
    /// <inheritdoc/>
    public override string LocalName => "dropLine";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DropLine class.
    /// </summary>
    public DropLine():base(){}
        /// <summary>
    ///Initializes a new instance of the DropLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropLine(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DropLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropLine(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DropLine class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DropLine(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropLine>(deep);

}
/// <summary>
/// <para>Defines the ErrorBar Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:errorBar.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ErrorBar : StyleEntry
{
    internal const int ElementTypeIdConst = 13293;
    /// <inheritdoc/>
    public override string LocalName => "errorBar";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the ErrorBar class.
    /// </summary>
    public ErrorBar():base(){}
        /// <summary>
    ///Initializes a new instance of the ErrorBar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ErrorBar(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ErrorBar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ErrorBar(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ErrorBar class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ErrorBar(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBar>(deep);

}
/// <summary>
/// <para>Defines the Floor Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:floor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Floor : StyleEntry
{
    internal const int ElementTypeIdConst = 13294;
    /// <inheritdoc/>
    public override string LocalName => "floor";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the Floor class.
    /// </summary>
    public Floor():base(){}
        /// <summary>
    ///Initializes a new instance of the Floor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Floor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Floor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Floor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Floor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Floor(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Floor>(deep);

}
/// <summary>
/// <para>Defines the GridlineMajor Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:gridlineMajor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class GridlineMajor : StyleEntry
{
    internal const int ElementTypeIdConst = 13295;
    /// <inheritdoc/>
    public override string LocalName => "gridlineMajor";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the GridlineMajor class.
    /// </summary>
    public GridlineMajor():base(){}
        /// <summary>
    ///Initializes a new instance of the GridlineMajor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GridlineMajor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GridlineMajor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GridlineMajor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GridlineMajor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GridlineMajor(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GridlineMajor>(deep);

}
/// <summary>
/// <para>Defines the GridlineMinor Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:gridlineMinor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class GridlineMinor : StyleEntry
{
    internal const int ElementTypeIdConst = 13296;
    /// <inheritdoc/>
    public override string LocalName => "gridlineMinor";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the GridlineMinor class.
    /// </summary>
    public GridlineMinor():base(){}
        /// <summary>
    ///Initializes a new instance of the GridlineMinor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GridlineMinor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GridlineMinor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GridlineMinor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GridlineMinor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GridlineMinor(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GridlineMinor>(deep);

}
/// <summary>
/// <para>Defines the HiLoLine Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:hiLoLine.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class HiLoLine : StyleEntry
{
    internal const int ElementTypeIdConst = 13297;
    /// <inheritdoc/>
    public override string LocalName => "hiLoLine";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the HiLoLine class.
    /// </summary>
    public HiLoLine():base(){}
        /// <summary>
    ///Initializes a new instance of the HiLoLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiLoLine(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HiLoLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiLoLine(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HiLoLine class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HiLoLine(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiLoLine>(deep);

}
/// <summary>
/// <para>Defines the LeaderLine Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:leaderLine.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class LeaderLine : StyleEntry
{
    internal const int ElementTypeIdConst = 13298;
    /// <inheritdoc/>
    public override string LocalName => "leaderLine";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the LeaderLine class.
    /// </summary>
    public LeaderLine():base(){}
        /// <summary>
    ///Initializes a new instance of the LeaderLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LeaderLine(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LeaderLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LeaderLine(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LeaderLine class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LeaderLine(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeaderLine>(deep);

}
/// <summary>
/// <para>Defines the LegendStyle Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:legend.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class LegendStyle : StyleEntry
{
    internal const int ElementTypeIdConst = 13299;
    /// <inheritdoc/>
    public override string LocalName => "legend";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the LegendStyle class.
    /// </summary>
    public LegendStyle():base(){}
        /// <summary>
    ///Initializes a new instance of the LegendStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LegendStyle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LegendStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LegendStyle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LegendStyle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LegendStyle(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegendStyle>(deep);

}
/// <summary>
/// <para>Defines the PlotArea Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:plotArea.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PlotArea : StyleEntry
{
    internal const int ElementTypeIdConst = 13300;
    /// <inheritdoc/>
    public override string LocalName => "plotArea";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the PlotArea class.
    /// </summary>
    public PlotArea():base(){}
        /// <summary>
    ///Initializes a new instance of the PlotArea class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotArea(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PlotArea class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotArea(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PlotArea class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PlotArea(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea>(deep);

}
/// <summary>
/// <para>Defines the PlotArea3D Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:plotArea3D.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PlotArea3D : StyleEntry
{
    internal const int ElementTypeIdConst = 13301;
    /// <inheritdoc/>
    public override string LocalName => "plotArea3D";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the PlotArea3D class.
    /// </summary>
    public PlotArea3D():base(){}
        /// <summary>
    ///Initializes a new instance of the PlotArea3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotArea3D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PlotArea3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotArea3D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PlotArea3D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PlotArea3D(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea3D>(deep);

}
/// <summary>
/// <para>Defines the SeriesAxis Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:seriesAxis.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SeriesAxis : StyleEntry
{
    internal const int ElementTypeIdConst = 13302;
    /// <inheritdoc/>
    public override string LocalName => "seriesAxis";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the SeriesAxis class.
    /// </summary>
    public SeriesAxis():base(){}
        /// <summary>
    ///Initializes a new instance of the SeriesAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesAxis(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesAxis(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesAxis class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SeriesAxis(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesAxis>(deep);

}
/// <summary>
/// <para>Defines the SeriesLine Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:seriesLine.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SeriesLine : StyleEntry
{
    internal const int ElementTypeIdConst = 13303;
    /// <inheritdoc/>
    public override string LocalName => "seriesLine";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the SeriesLine class.
    /// </summary>
    public SeriesLine():base(){}
        /// <summary>
    ///Initializes a new instance of the SeriesLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesLine(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesLine(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesLine class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SeriesLine(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesLine>(deep);

}
/// <summary>
/// <para>Defines the TitleStyle Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:title.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TitleStyle : StyleEntry
{
    internal const int ElementTypeIdConst = 13304;
    /// <inheritdoc/>
    public override string LocalName => "title";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the TitleStyle class.
    /// </summary>
    public TitleStyle():base(){}
        /// <summary>
    ///Initializes a new instance of the TitleStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TitleStyle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TitleStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TitleStyle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TitleStyle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TitleStyle(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TitleStyle>(deep);

}
/// <summary>
/// <para>Defines the TrendlineStyle Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:trendline.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TrendlineStyle : StyleEntry
{
    internal const int ElementTypeIdConst = 13305;
    /// <inheritdoc/>
    public override string LocalName => "trendline";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the TrendlineStyle class.
    /// </summary>
    public TrendlineStyle():base(){}
        /// <summary>
    ///Initializes a new instance of the TrendlineStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TrendlineStyle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TrendlineStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TrendlineStyle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TrendlineStyle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TrendlineStyle(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineStyle>(deep);

}
/// <summary>
/// <para>Defines the TrendlineLabel Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:trendlineLabel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TrendlineLabel : StyleEntry
{
    internal const int ElementTypeIdConst = 13306;
    /// <inheritdoc/>
    public override string LocalName => "trendlineLabel";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the TrendlineLabel class.
    /// </summary>
    public TrendlineLabel():base(){}
        /// <summary>
    ///Initializes a new instance of the TrendlineLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TrendlineLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TrendlineLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TrendlineLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TrendlineLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TrendlineLabel(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineLabel>(deep);

}
/// <summary>
/// <para>Defines the UpBar Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:upBar.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class UpBar : StyleEntry
{
    internal const int ElementTypeIdConst = 13307;
    /// <inheritdoc/>
    public override string LocalName => "upBar";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the UpBar class.
    /// </summary>
    public UpBar():base(){}
        /// <summary>
    ///Initializes a new instance of the UpBar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UpBar(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UpBar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UpBar(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UpBar class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public UpBar(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UpBar>(deep);

}
/// <summary>
/// <para>Defines the ValueAxis Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:valueAxis.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ValueAxis : StyleEntry
{
    internal const int ElementTypeIdConst = 13308;
    /// <inheritdoc/>
    public override string LocalName => "valueAxis";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the ValueAxis class.
    /// </summary>
    public ValueAxis():base(){}
        /// <summary>
    ///Initializes a new instance of the ValueAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ValueAxis(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ValueAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ValueAxis(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ValueAxis class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ValueAxis(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValueAxis>(deep);

}
/// <summary>
/// <para>Defines the Wall Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:wall.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Wall : StyleEntry
{
    internal const int ElementTypeIdConst = 13309;
    /// <inheritdoc/>
    public override string LocalName => "wall";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the Wall class.
    /// </summary>
    public Wall():base(){}
        /// <summary>
    ///Initializes a new instance of the Wall class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Wall(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Wall class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Wall(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Wall class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Wall(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Wall>(deep);

}
/// <summary>
/// Defines the StyleEntry class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineReference &lt;cs:lnRef></description></item>
///<item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
///<item><description>FillReference &lt;cs:fillRef></description></item>
///<item><description>EffectReference &lt;cs:effectRef></description></item>
///<item><description>FontReference &lt;cs:fontRef></description></item>
///<item><description>ShapeProperties &lt;cs:spPr></description></item>
///<item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
///<item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
///<item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(LineReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(LineWidthScale), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(FillReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(EffectReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(FontReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(TextCharacterPropertiesType), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(TextBodyProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class StyleEntry : OpenXmlCompositeElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<ListValue<StringValue>>(0, "mods")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> mods.</para>
    /// <para>Represents the following attribute in the schema: mods </para>
    /// </summary>
    [SchemaAttr(0, "mods")]
    public ListValue<StringValue> Modifiers
    {
        get { return (ListValue<StringValue>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 65 == namespaceId && "lnRef" == name)
    return new LineReference();
    
if( 65 == namespaceId && "lineWidthScale" == name)
    return new LineWidthScale();
    
if( 65 == namespaceId && "fillRef" == name)
    return new FillReference();
    
if( 65 == namespaceId && "effectRef" == name)
    return new EffectReference();
    
if( 65 == namespaceId && "fontRef" == name)
    return new FontReference();
    
if( 65 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 65 == namespaceId && "defRPr" == name)
    return new TextCharacterPropertiesType();
    
if( 65 == namespaceId && "bodyPr" == name)
    return new TextBodyProperties();
    
if( 65 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "lnRef","lineWidthScale","fillRef","effectRef","fontRef","spPr","defRPr","bodyPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 65,65,65,65,65,65,65,65,65 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> LineReference.</para>
    /// <para> Represents the following element tag in the schema: cs:lnRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public LineReference LineReference
    {
        get => GetElement<LineReference>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> LineWidthScale.</para>
    /// <para> Represents the following element tag in the schema: cs:lineWidthScale </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public LineWidthScale LineWidthScale
    {
        get => GetElement<LineWidthScale>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> FillReference.</para>
    /// <para> Represents the following element tag in the schema: cs:fillRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public FillReference FillReference
    {
        get => GetElement<FillReference>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> EffectReference.</para>
    /// <para> Represents the following element tag in the schema: cs:effectRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public EffectReference EffectReference
    {
        get => GetElement<EffectReference>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> FontReference.</para>
    /// <para> Represents the following element tag in the schema: cs:fontRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public FontReference FontReference
    {
        get => GetElement<FontReference>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cs:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> TextCharacterPropertiesType.</para>
    /// <para> Represents the following element tag in the schema: cs:defRPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public TextCharacterPropertiesType TextCharacterPropertiesType
    {
        get => GetElement<TextCharacterPropertiesType>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> TextBodyProperties.</para>
    /// <para> Represents the following element tag in the schema: cs:bodyPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public TextBodyProperties TextBodyProperties
    {
        get => GetElement<TextBodyProperties>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cs:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<OfficeArtExtensionList>(8);
        set => SetElement(8, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the StyleEntry class.
    /// </summary>
    protected StyleEntry(){}
    
        /// <summary>
    ///Initializes a new instance of the StyleEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected StyleEntry(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected StyleEntry(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleEntry class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected StyleEntry(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the MarkerLayoutProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cs:dataPointMarkerLayout.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class MarkerLayoutProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13288;
    /// <inheritdoc/>
    public override string LocalName => "dataPointMarkerLayout";
    
    internal override byte NamespaceId => 65;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle>>(0, "symbol"),
		AttributeTag.Create<ByteValue>(0, "size")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> symbol.</para>
    /// <para>Represents the following attribute in the schema: symbol </para>
    /// </summary>
    [SchemaAttr(0, "symbol")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle> Symbol
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public ByteValue Size
    {
        get { return (ByteValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MarkerLayoutProperties class.
    /// </summary>
    public MarkerLayoutProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MarkerLayoutProperties>(deep);

}
/// <summary>
/// Defines the ColorStyleMethodEnum enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ColorStyleMethodEnum
{  
	///<summary>
///cycle.
///<para>When the item is serialized out as xml, its value is "cycle".</para>
///</summary>
[EnumString("cycle")]
Cycle,
///<summary>
///withinLinear.
///<para>When the item is serialized out as xml, its value is "withinLinear".</para>
///</summary>
[EnumString("withinLinear")]
WithinLinear,
///<summary>
///acrossLinear.
///<para>When the item is serialized out as xml, its value is "acrossLinear".</para>
///</summary>
[EnumString("acrossLinear")]
AcrossLinear,
///<summary>
///withinLinearReversed.
///<para>When the item is serialized out as xml, its value is "withinLinearReversed".</para>
///</summary>
[EnumString("withinLinearReversed")]
WithinLinearReversed,
///<summary>
///acrossLinearReversed.
///<para>When the item is serialized out as xml, its value is "acrossLinearReversed".</para>
///</summary>
[EnumString("acrossLinearReversed")]
AcrossLinearReversed,
 
}
/// <summary>
/// Defines the StyleReferenceModifierEnum enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StyleReferenceModifierEnum
{  
	///<summary>
///ignoreCSTransforms.
///<para>When the item is serialized out as xml, its value is "ignoreCSTransforms".</para>
///</summary>
[EnumString("ignoreCSTransforms")]
IgnoreCSTransforms,
 
}
/// <summary>
/// Defines the StyleColorEnum enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StyleColorEnum
{  
	///<summary>
///auto.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Automatic,
 
}
/// <summary>
/// Defines the StyleEntryModifierEnum enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StyleEntryModifierEnum
{  
	///<summary>
///allowNoFillOverride.
///<para>When the item is serialized out as xml, its value is "allowNoFillOverride".</para>
///</summary>
[EnumString("allowNoFillOverride")]
AllowNoFillOverride,
///<summary>
///allowNoLineOverride.
///<para>When the item is serialized out as xml, its value is "allowNoLineOverride".</para>
///</summary>
[EnumString("allowNoLineOverride")]
AllowNoLineOverride,
 
}
/// <summary>
/// Defines the MarkerStyle enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum MarkerStyle
{  
	///<summary>
///circle.
///<para>When the item is serialized out as xml, its value is "circle".</para>
///</summary>
[EnumString("circle")]
Circle,
///<summary>
///dash.
///<para>When the item is serialized out as xml, its value is "dash".</para>
///</summary>
[EnumString("dash")]
Dash,
///<summary>
///diamond.
///<para>When the item is serialized out as xml, its value is "diamond".</para>
///</summary>
[EnumString("diamond")]
Diamond,
///<summary>
///dot.
///<para>When the item is serialized out as xml, its value is "dot".</para>
///</summary>
[EnumString("dot")]
Dot,
///<summary>
///plus.
///<para>When the item is serialized out as xml, its value is "plus".</para>
///</summary>
[EnumString("plus")]
Plus,
///<summary>
///square.
///<para>When the item is serialized out as xml, its value is "square".</para>
///</summary>
[EnumString("square")]
Square,
///<summary>
///star.
///<para>When the item is serialized out as xml, its value is "star".</para>
///</summary>
[EnumString("star")]
Star,
///<summary>
///triangle.
///<para>When the item is serialized out as xml, its value is "triangle".</para>
///</summary>
[EnumString("triangle")]
Triangle,
///<summary>
///x.
///<para>When the item is serialized out as xml, its value is "x".</para>
///</summary>
[EnumString("x")]
X,
 
}
/// <summary>
/// Defines the Boolean enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum Boolean
{  
	///<summary>
///false.
///<para>When the item is serialized out as xml, its value is "false".</para>
///</summary>
[EnumString("false")]
False,
///<summary>
///true.
///<para>When the item is serialized out as xml, its value is "true".</para>
///</summary>
[EnumString("true")]
True,
///<summary>
///ninch.
///<para>When the item is serialized out as xml, its value is "ninch".</para>
///</summary>
[EnumString("ninch")]
Ninch,
 
}
/// <summary>
/// Defines the TickMarkNinch enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TickMarkNinch
{  
	///<summary>
///cross.
///<para>When the item is serialized out as xml, its value is "cross".</para>
///</summary>
[EnumString("cross")]
Cross,
///<summary>
///inside.
///<para>When the item is serialized out as xml, its value is "inside".</para>
///</summary>
[EnumString("inside")]
Inside,
///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///outside.
///<para>When the item is serialized out as xml, its value is "outside".</para>
///</summary>
[EnumString("outside")]
Outside,
///<summary>
///ninch.
///<para>When the item is serialized out as xml, its value is "ninch".</para>
///</summary>
[EnumString("ninch")]
Ninch,
 
}
/// <summary>
/// Defines the TickLabelPositionNinch enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TickLabelPositionNinch
{  
	///<summary>
///high.
///<para>When the item is serialized out as xml, its value is "high".</para>
///</summary>
[EnumString("high")]
High,
///<summary>
///low.
///<para>When the item is serialized out as xml, its value is "low".</para>
///</summary>
[EnumString("low")]
Low,
///<summary>
///nextToAxis.
///<para>When the item is serialized out as xml, its value is "nextToAxis".</para>
///</summary>
[EnumString("nextToAxis")]
NextToAxis,
///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///ninch.
///<para>When the item is serialized out as xml, its value is "ninch".</para>
///</summary>
[EnumString("ninch")]
Ninch,
 
}
/// <summary>
/// Defines the DataLabelsPosition enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DataLabelsPosition
{  
	///<summary>
///center.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///insideEnd.
///<para>When the item is serialized out as xml, its value is "insideEnd".</para>
///</summary>
[EnumString("insideEnd")]
InsideEnd,
///<summary>
///insideBase.
///<para>When the item is serialized out as xml, its value is "insideBase".</para>
///</summary>
[EnumString("insideBase")]
InsideBase,
///<summary>
///outsideEnd.
///<para>When the item is serialized out as xml, its value is "outsideEnd".</para>
///</summary>
[EnumString("outsideEnd")]
OutsideEnd,
///<summary>
///ninch.
///<para>When the item is serialized out as xml, its value is "ninch".</para>
///</summary>
[EnumString("ninch")]
Ninch,
 
}
/// <summary>
/// Defines the LegendPosition enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LegendPosition
{  
	///<summary>
///right.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,
///<summary>
///top.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///left.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///bottom.
///<para>When the item is serialized out as xml, its value is "bottom".</para>
///</summary>
[EnumString("bottom")]
Bottom,
///<summary>
///ninch.
///<para>When the item is serialized out as xml, its value is "ninch".</para>
///</summary>
[EnumString("ninch")]
Ninch,
 
}
/// <summary>
/// Defines the TitlePosition enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TitlePosition
{  
	///<summary>
///above.
///<para>When the item is serialized out as xml, its value is "above".</para>
///</summary>
[EnumString("above")]
Above,
///<summary>
///overlay.
///<para>When the item is serialized out as xml, its value is "overlay".</para>
///</summary>
[EnumString("overlay")]
Overlay,
///<summary>
///off.
///<para>When the item is serialized out as xml, its value is "off".</para>
///</summary>
[EnumString("off")]
Off,
///<summary>
///ninch.
///<para>When the item is serialized out as xml, its value is "ninch".</para>
///</summary>
[EnumString("ninch")]
Ninch,
 
}
}
 
 
