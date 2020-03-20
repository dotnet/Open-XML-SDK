﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
    /// <summary>
    /// <para>Defines the ColorStyle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:colorStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    ///   <item><description>ColorStyleVariation &lt;cs:variation></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]
    [ChildElementInfo(typeof(ColorStyleVariation), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]
    [SchemaAttr(65, "colorStyle")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ColorStyle : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorStyle class.
        /// </summary>
        public ColorStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ColorStyle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>meth, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: meth</para>
        /// </summary>
        [RequiredValidator()]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleMethodEnum>), UnionId = 0)]
        [StringValidator(UnionId = 0)]
        [SchemaAttr(0, "meth")]
        [Index(0)]
        public StringValue Method { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr(0, "id")]
        [Index(1)]
        public UInt32Value Id { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 0)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation), 0, 0, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorStyle>(deep);

        internal ColorStyle(ChartColorStylePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ChartColorStylePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ChartColorStylePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ChartColorStylePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ChartColorStylePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ChartColorStylePart associated with this element.
        /// </summary>
        public ChartColorStylePart ChartColorStylePart
        {
            get => OpenXmlPart as ChartColorStylePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ChartStyle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:chartStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AxisTitle &lt;cs:axisTitle></description></item>
    ///   <item><description>CategoryAxis &lt;cs:categoryAxis></description></item>
    ///   <item><description>ChartArea &lt;cs:chartArea></description></item>
    ///   <item><description>DataLabel &lt;cs:dataLabel></description></item>
    ///   <item><description>DataLabelCallout &lt;cs:dataLabelCallout></description></item>
    ///   <item><description>DataPoint &lt;cs:dataPoint></description></item>
    ///   <item><description>DataPoint3D &lt;cs:dataPoint3D></description></item>
    ///   <item><description>DataPointLine &lt;cs:dataPointLine></description></item>
    ///   <item><description>DataPointMarker &lt;cs:dataPointMarker></description></item>
    ///   <item><description>MarkerLayoutProperties &lt;cs:dataPointMarkerLayout></description></item>
    ///   <item><description>DataPointWireframe &lt;cs:dataPointWireframe></description></item>
    ///   <item><description>DataTableStyle &lt;cs:dataTable></description></item>
    ///   <item><description>DownBar &lt;cs:downBar></description></item>
    ///   <item><description>DropLine &lt;cs:dropLine></description></item>
    ///   <item><description>ErrorBar &lt;cs:errorBar></description></item>
    ///   <item><description>Floor &lt;cs:floor></description></item>
    ///   <item><description>GridlineMajor &lt;cs:gridlineMajor></description></item>
    ///   <item><description>GridlineMinor &lt;cs:gridlineMinor></description></item>
    ///   <item><description>HiLoLine &lt;cs:hiLoLine></description></item>
    ///   <item><description>LeaderLine &lt;cs:leaderLine></description></item>
    ///   <item><description>LegendStyle &lt;cs:legend></description></item>
    ///   <item><description>PlotArea &lt;cs:plotArea></description></item>
    ///   <item><description>PlotArea3D &lt;cs:plotArea3D></description></item>
    ///   <item><description>SeriesAxis &lt;cs:seriesAxis></description></item>
    ///   <item><description>SeriesLine &lt;cs:seriesLine></description></item>
    ///   <item><description>TitleStyle &lt;cs:title></description></item>
    ///   <item><description>TrendlineStyle &lt;cs:trendline></description></item>
    ///   <item><description>TrendlineLabel &lt;cs:trendlineLabel></description></item>
    ///   <item><description>UpBar &lt;cs:upBar></description></item>
    ///   <item><description>ValueAxis &lt;cs:valueAxis></description></item>
    ///   <item><description>Wall &lt;cs:wall></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(65, "chartStyle")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ChartStyle : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartStyle class.
        /// </summary>
        public ChartStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ChartStyle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr(0, "id")]
        [Index(0)]
        public UInt32Value Id { get; set; }

        /// <summary>
        /// <para>AxisTitle.</para>
        /// <para>Represents the following element tag in the schema: cs:axisTitle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public AxisTitle AxisTitle
        {
            get => GetElement<AxisTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CategoryAxis.</para>
        /// <para>Represents the following element tag in the schema: cs:categoryAxis.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public CategoryAxis CategoryAxis
        {
            get => GetElement<CategoryAxis>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartArea.</para>
        /// <para>Represents the following element tag in the schema: cs:chartArea.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public ChartArea ChartArea
        {
            get => GetElement<ChartArea>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabel.</para>
        /// <para>Represents the following element tag in the schema: cs:dataLabel.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DataLabel DataLabel
        {
            get => GetElement<DataLabel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabelCallout.</para>
        /// <para>Represents the following element tag in the schema: cs:dataLabelCallout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DataLabelCallout DataLabelCallout
        {
            get => GetElement<DataLabelCallout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataPoint.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPoint.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DataPoint DataPoint
        {
            get => GetElement<DataPoint>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataPoint3D.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPoint3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DataPoint3D DataPoint3D
        {
            get => GetElement<DataPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataPointLine.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPointLine.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DataPointLine DataPointLine
        {
            get => GetElement<DataPointLine>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataPointMarker.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPointMarker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DataPointMarker DataPointMarker
        {
            get => GetElement<DataPointMarker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MarkerLayoutProperties.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPointMarkerLayout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public MarkerLayoutProperties MarkerLayoutProperties
        {
            get => GetElement<MarkerLayoutProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataPointWireframe.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPointWireframe.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DataPointWireframe DataPointWireframe
        {
            get => GetElement<DataPointWireframe>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataTableStyle.</para>
        /// <para>Represents the following element tag in the schema: cs:dataTable.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DataTableStyle DataTableStyle
        {
            get => GetElement<DataTableStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DownBar.</para>
        /// <para>Represents the following element tag in the schema: cs:downBar.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DownBar DownBar
        {
            get => GetElement<DownBar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DropLine.</para>
        /// <para>Represents the following element tag in the schema: cs:dropLine.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DropLine DropLine
        {
            get => GetElement<DropLine>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ErrorBar.</para>
        /// <para>Represents the following element tag in the schema: cs:errorBar.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public ErrorBar ErrorBar
        {
            get => GetElement<ErrorBar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Floor.</para>
        /// <para>Represents the following element tag in the schema: cs:floor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public Floor Floor
        {
            get => GetElement<Floor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>GridlineMajor.</para>
        /// <para>Represents the following element tag in the schema: cs:gridlineMajor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public GridlineMajor GridlineMajor
        {
            get => GetElement<GridlineMajor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>GridlineMinor.</para>
        /// <para>Represents the following element tag in the schema: cs:gridlineMinor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public GridlineMinor GridlineMinor
        {
            get => GetElement<GridlineMinor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HiLoLine.</para>
        /// <para>Represents the following element tag in the schema: cs:hiLoLine.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public HiLoLine HiLoLine
        {
            get => GetElement<HiLoLine>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LeaderLine.</para>
        /// <para>Represents the following element tag in the schema: cs:leaderLine.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public LeaderLine LeaderLine
        {
            get => GetElement<LeaderLine>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LegendStyle.</para>
        /// <para>Represents the following element tag in the schema: cs:legend.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public LegendStyle LegendStyle
        {
            get => GetElement<LegendStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PlotArea.</para>
        /// <para>Represents the following element tag in the schema: cs:plotArea.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public PlotArea PlotArea
        {
            get => GetElement<PlotArea>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PlotArea3D.</para>
        /// <para>Represents the following element tag in the schema: cs:plotArea3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public PlotArea3D PlotArea3D
        {
            get => GetElement<PlotArea3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeriesAxis.</para>
        /// <para>Represents the following element tag in the schema: cs:seriesAxis.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public SeriesAxis SeriesAxis
        {
            get => GetElement<SeriesAxis>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeriesLine.</para>
        /// <para>Represents the following element tag in the schema: cs:seriesLine.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public SeriesLine SeriesLine
        {
            get => GetElement<SeriesLine>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TitleStyle.</para>
        /// <para>Represents the following element tag in the schema: cs:title.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public TitleStyle TitleStyle
        {
            get => GetElement<TitleStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TrendlineStyle.</para>
        /// <para>Represents the following element tag in the schema: cs:trendline.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public TrendlineStyle TrendlineStyle
        {
            get => GetElement<TrendlineStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TrendlineLabel.</para>
        /// <para>Represents the following element tag in the schema: cs:trendlineLabel.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public TrendlineLabel TrendlineLabel
        {
            get => GetElement<TrendlineLabel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>UpBar.</para>
        /// <para>Represents the following element tag in the schema: cs:upBar.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public UpBar UpBar
        {
            get => GetElement<UpBar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ValueAxis.</para>
        /// <para>Represents the following element tag in the schema: cs:valueAxis.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public ValueAxis ValueAxis
        {
            get => GetElement<ValueAxis>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Wall.</para>
        /// <para>Represents the following element tag in the schema: cs:wall.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public Wall Wall
        {
            get => GetElement<Wall>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cs:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartStyle>(deep);

        internal ChartStyle(ChartStylePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ChartStylePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ChartStylePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ChartStylePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ChartStylePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ChartStylePart associated with this element.
        /// </summary>
        public ChartStylePart ChartStylePart
        {
            get => OpenXmlPart as ChartStylePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ColorStyleVariation Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:variation.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Tint &lt;a:tint></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shade &lt;a:shade></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Complement &lt;a:comp></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Inverse &lt;a:inv></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Gray &lt;a:gray></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Alpha &lt;a:alpha></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaOffset &lt;a:alphaOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaModulation &lt;a:alphaMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Hue &lt;a:hue></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HueOffset &lt;a:hueOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HueModulation &lt;a:hueMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Saturation &lt;a:sat></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SaturationOffset &lt;a:satOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SaturationModulation &lt;a:satMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Luminance &lt;a:lum></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LuminanceOffset &lt;a:lumOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LuminanceModulation &lt;a:lumMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Red &lt;a:red></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RedOffset &lt;a:redOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RedModulation &lt;a:redMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Green &lt;a:green></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GreenOffset &lt;a:greenOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GreenModulation &lt;a:greenMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Blue &lt;a:blue></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlueOffset &lt;a:blueOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlueModulation &lt;a:blueMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Gamma &lt;a:gamma></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.InverseGamma &lt;a:invGamma></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(65, "variation")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ColorStyleVariation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorStyleVariation class.
        /// </summary>
        public ColorStyleVariation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorStyleVariation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorStyleVariation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ColorStyleVariation(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 0)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tint), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shade), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Complement), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Inverse), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Gray), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Alpha), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Hue), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HueOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HueModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Saturation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SaturationOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SaturationModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Luminance), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Red), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RedOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RedModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Green), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GreenOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GreenModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blue), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlueOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlueModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Gamma), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.InverseGamma), 1, 1)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorStyleVariation>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
    [SchemaAttr(65, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class OfficeArtExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the StyleColor Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:styleClr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Tint &lt;a:tint></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shade &lt;a:shade></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Complement &lt;a:comp></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Inverse &lt;a:inv></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Gray &lt;a:gray></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Alpha &lt;a:alpha></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaOffset &lt;a:alphaOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.AlphaModulation &lt;a:alphaMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Hue &lt;a:hue></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HueOffset &lt;a:hueOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HueModulation &lt;a:hueMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Saturation &lt;a:sat></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SaturationOffset &lt;a:satOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SaturationModulation &lt;a:satMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Luminance &lt;a:lum></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LuminanceOffset &lt;a:lumOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LuminanceModulation &lt;a:lumMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Red &lt;a:red></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RedOffset &lt;a:redOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RedModulation &lt;a:redMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Green &lt;a:green></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GreenOffset &lt;a:greenOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GreenModulation &lt;a:greenMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Blue &lt;a:blue></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlueOffset &lt;a:blueOff></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlueModulation &lt;a:blueMod></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Gamma &lt;a:gamma></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.InverseGamma &lt;a:invGamma></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(65, "styleClr")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class StyleColor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleColor class.
        /// </summary>
        public StyleColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public StyleColor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [NumberValidator(SimpleType = typeof(UInt32Value), UnionId = 0)]
        [EnumValidator(SimpleType = typeof(EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColorEnum>), UnionId = 0)]
        [StringValidator(UnionId = 0)]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public StringValue Val { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 0)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tint), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shade), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Complement), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Inverse), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Gray), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Alpha), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Hue), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HueOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HueModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Saturation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SaturationOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SaturationModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Luminance), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Red), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RedOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RedModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Green), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GreenOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GreenModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blue), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlueOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlueModulation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Gamma), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.InverseGamma), 1, 1)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleColor>(deep);
    }

    /// <summary>
    /// <para>Defines the LineReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:lnRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    ///   <item><description>StyleColor &lt;cs:styleClr></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "lnRef")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class LineReference : StyleReference
    {
        /// <summary>
        /// Initializes a new instance of the LineReference class.
        /// </summary>
        public LineReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public LineReference(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineReference>(deep);
    }

    /// <summary>
    /// <para>Defines the FillReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:fillRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    ///   <item><description>StyleColor &lt;cs:styleClr></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "fillRef")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FillReference : StyleReference
    {
        /// <summary>
        /// Initializes a new instance of the FillReference class.
        /// </summary>
        public FillReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public FillReference(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillReference>(deep);
    }

    /// <summary>
    /// <para>Defines the EffectReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:effectRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    ///   <item><description>StyleColor &lt;cs:styleClr></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "effectRef")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class EffectReference : StyleReference
    {
        /// <summary>
        /// Initializes a new instance of the EffectReference class.
        /// </summary>
        public EffectReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public EffectReference(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectReference>(deep);
    }

    /// <summary>
    /// <para>Defines the StyleReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    ///   <item><description>StyleColor &lt;cs:styleClr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]
    [ChildElementInfo(typeof(StyleColor), FileFormatVersions.Office2013)]
    public abstract partial class StyleReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleReference class.
        /// </summary>
        protected StyleReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StyleReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        protected StyleReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idx, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "idx")]
        [Index(0)]
        public UInt32Value Index { get; set; }

        /// <summary>
        /// <para>mods, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: mods</para>
        /// </summary>
        [SchemaAttr(0, "mods")]
        [Index(1)]
        public ListValue<StringValue> Modifiers { get; set; }
    }

    /// <summary>
    /// <para>Defines the LineWidthScale Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:lineWidthScale.</para>
    /// </summary>
    [NumberValidator(SimpleType = typeof(DoubleValue))]
    [SchemaAttr(65, "lineWidthScale")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class LineWidthScale : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LineWidthScale class.
        /// </summary>
        public LineWidthScale() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineWidthScale class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LineWidthScale(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new DoubleValue { InnerText = text };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineWidthScale>(deep);
    }

    /// <summary>
    /// <para>Defines the FontReference Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:fontRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    ///   <item><description>StyleColor &lt;cs:styleClr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]
    [ChildElementInfo(typeof(StyleColor), FileFormatVersions.Office2013)]
    [SchemaAttr(65, "fontRef")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class FontReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FontReference class.
        /// </summary>
        public FontReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FontReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FontReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public FontReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idx, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "idx")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues> Index { get; set; }

        /// <summary>
        /// <para>mods, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: mods</para>
        /// </summary>
        [SchemaAttr(0, "mods")]
        [Index(1)]
        public ListValue<StringValue> Modifiers { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FontReference>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Transform2D &lt;a:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(65, "spPr")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeProperties class.
        /// </summary>
        public ShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bwMode")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }

        /// <summary>
        /// <para>2D Transform for Individual Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                }
            },
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the TextCharacterPropertiesType Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:defRPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Highlight &lt;a:highlight></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.UnderlineFollowsText &lt;a:uLnTx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Underline &lt;a:uLn></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.UnderlineFillText &lt;a:uFillTx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.UnderlineFill &lt;a:uFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LatinFont &lt;a:latin></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EastAsianFont &lt;a:ea></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ComplexScriptFont &lt;a:cs></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SymbolFont &lt;a:sym></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver &lt;a:hlinkMouseOver></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RightToLeft &lt;a:rtl></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(65, "defRPr")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class TextCharacterPropertiesType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextCharacterPropertiesType class.
        /// </summary>
        public TextCharacterPropertiesType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextCharacterPropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextCharacterPropertiesType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public TextCharacterPropertiesType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>kumimoji</para>
        /// <para>Represents the following attribute in the schema: kumimoji</para>
        /// </summary>
        [SchemaAttr(0, "kumimoji")]
        [Index(0)]
        public BooleanValue Kumimoji { get; set; }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>
        [SchemaAttr(0, "lang")]
        [Index(1)]
        public StringValue Language { get; set; }

        /// <summary>
        /// <para>altLang</para>
        /// <para>Represents the following attribute in the schema: altLang</para>
        /// </summary>
        [SchemaAttr(0, "altLang")]
        [Index(2)]
        public StringValue AlternativeLanguage { get; set; }

        /// <summary>
        /// <para>sz</para>
        /// <para>Represents the following attribute in the schema: sz</para>
        /// </summary>
        [NumberValidator(MinInclusive = 100L, MaxInclusive = 400000L)]
        [SchemaAttr(0, "sz")]
        [Index(3)]
        public Int32Value FontSize { get; set; }

        /// <summary>
        /// <para>b</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>
        [SchemaAttr(0, "b")]
        [Index(4)]
        public BooleanValue Bold { get; set; }

        /// <summary>
        /// <para>i</para>
        /// <para>Represents the following attribute in the schema: i</para>
        /// </summary>
        [SchemaAttr(0, "i")]
        [Index(5)]
        public BooleanValue Italic { get; set; }

        /// <summary>
        /// <para>u</para>
        /// <para>Represents the following attribute in the schema: u</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "u")]
        [Index(6)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues> Underline { get; set; }

        /// <summary>
        /// <para>strike</para>
        /// <para>Represents the following attribute in the schema: strike</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "strike")]
        [Index(7)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues> Strike { get; set; }

        /// <summary>
        /// <para>kern</para>
        /// <para>Represents the following attribute in the schema: kern</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 400000L)]
        [SchemaAttr(0, "kern")]
        [Index(8)]
        public Int32Value Kerning { get; set; }

        /// <summary>
        /// <para>cap</para>
        /// <para>Represents the following attribute in the schema: cap</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "cap")]
        [Index(9)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues> Capital { get; set; }

        /// <summary>
        /// <para>spc</para>
        /// <para>Represents the following attribute in the schema: spc</para>
        /// </summary>
        [NumberValidator(MinInclusive = -400000L, MaxInclusive = 400000L)]
        [SchemaAttr(0, "spc")]
        [Index(10)]
        public Int32Value Spacing { get; set; }

        /// <summary>
        /// <para>normalizeH</para>
        /// <para>Represents the following attribute in the schema: normalizeH</para>
        /// </summary>
        [SchemaAttr(0, "normalizeH")]
        [Index(11)]
        public BooleanValue NormalizeHeight { get; set; }

        /// <summary>
        /// <para>baseline</para>
        /// <para>Represents the following attribute in the schema: baseline</para>
        /// </summary>
        [SchemaAttr(0, "baseline")]
        [Index(12)]
        public Int32Value Baseline { get; set; }

        /// <summary>
        /// <para>noProof</para>
        /// <para>Represents the following attribute in the schema: noProof</para>
        /// </summary>
        [SchemaAttr(0, "noProof")]
        [Index(13)]
        public BooleanValue NoProof { get; set; }

        /// <summary>
        /// <para>dirty</para>
        /// <para>Represents the following attribute in the schema: dirty</para>
        /// </summary>
        [SchemaAttr(0, "dirty")]
        [Index(14)]
        public BooleanValue Dirty { get; set; }

        /// <summary>
        /// <para>err</para>
        /// <para>Represents the following attribute in the schema: err</para>
        /// </summary>
        [SchemaAttr(0, "err")]
        [Index(15)]
        public BooleanValue SpellingError { get; set; }

        /// <summary>
        /// <para>smtClean</para>
        /// <para>Represents the following attribute in the schema: smtClean</para>
        /// </summary>
        [SchemaAttr(0, "smtClean")]
        [Index(16)]
        public BooleanValue SmtClean { get; set; }

        /// <summary>
        /// <para>smtId</para>
        /// <para>Represents the following attribute in the schema: smtId</para>
        /// </summary>
        [SchemaAttr(0, "smtId")]
        [Index(17)]
        public UInt32Value SmtId { get; set; }

        /// <summary>
        /// <para>bmk</para>
        /// <para>Represents the following attribute in the schema: bmk</para>
        /// </summary>
        [SchemaAttr(0, "bmk")]
        [Index(18)]
        public StringValue Bookmark { get; set; }

        /// <summary>
        /// <para>Outline.</para>
        /// <para>Represents the following element tag in the schema: a:ln.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Outline Outline
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Outline>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                }
            },
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Highlight), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.UnderlineFollowsText), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Underline), 0, 1)
                }
            },
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.UnderlineFillText), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.UnderlineFill), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LatinFont), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EastAsianFont), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ComplexScriptFont), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SymbolFont), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RightToLeft), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextCharacterPropertiesType>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:bodyPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetTextWrap &lt;a:prstTxWarp></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoAutoFit &lt;a:noAutofit></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NormalAutoFit &lt;a:normAutofit></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ShapeAutoFit &lt;a:spAutoFit></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.FlatText &lt;a:flatTx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetTextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoAutoFit))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NormalAutoFit))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapeAutoFit))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FlatText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
    [SchemaAttr(65, "bodyPr")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class TextBodyProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class.
        /// </summary>
        public TextBodyProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public TextBodyProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>
        [SchemaAttr(0, "rot")]
        [Index(0)]
        public Int32Value Rotation { get; set; }

        /// <summary>
        /// <para>Paragraph Spacing</para>
        /// <para>Represents the following attribute in the schema: spcFirstLastPara</para>
        /// </summary>
        [SchemaAttr(0, "spcFirstLastPara")]
        [Index(1)]
        public BooleanValue UseParagraphSpacing { get; set; }

        /// <summary>
        /// <para>Text Vertical Overflow</para>
        /// <para>Represents the following attribute in the schema: vertOverflow</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "vertOverflow")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues> VerticalOverflow { get; set; }

        /// <summary>
        /// <para>Text Horizontal Overflow</para>
        /// <para>Represents the following attribute in the schema: horzOverflow</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "horzOverflow")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues> HorizontalOverflow { get; set; }

        /// <summary>
        /// <para>Vertical Text</para>
        /// <para>Represents the following attribute in the schema: vert</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "vert")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues> Vertical { get; set; }

        /// <summary>
        /// <para>Text Wrapping Type</para>
        /// <para>Represents the following attribute in the schema: wrap</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "wrap")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues> Wrap { get; set; }

        /// <summary>
        /// <para>Left Inset</para>
        /// <para>Represents the following attribute in the schema: lIns</para>
        /// </summary>
        [SchemaAttr(0, "lIns")]
        [Index(6)]
        public Int32Value LeftInset { get; set; }

        /// <summary>
        /// <para>Top Inset</para>
        /// <para>Represents the following attribute in the schema: tIns</para>
        /// </summary>
        [SchemaAttr(0, "tIns")]
        [Index(7)]
        public Int32Value TopInset { get; set; }

        /// <summary>
        /// <para>Right Inset</para>
        /// <para>Represents the following attribute in the schema: rIns</para>
        /// </summary>
        [SchemaAttr(0, "rIns")]
        [Index(8)]
        public Int32Value RightInset { get; set; }

        /// <summary>
        /// <para>Bottom Inset</para>
        /// <para>Represents the following attribute in the schema: bIns</para>
        /// </summary>
        [SchemaAttr(0, "bIns")]
        [Index(9)]
        public Int32Value BottomInset { get; set; }

        /// <summary>
        /// <para>Number of Columns</para>
        /// <para>Represents the following attribute in the schema: numCol</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1L, MaxInclusive = 16L)]
        [SchemaAttr(0, "numCol")]
        [Index(10)]
        public Int32Value ColumnCount { get; set; }

        /// <summary>
        /// <para>Space Between Columns</para>
        /// <para>Represents the following attribute in the schema: spcCol</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L)]
        [SchemaAttr(0, "spcCol")]
        [Index(11)]
        public Int32Value ColumnSpacing { get; set; }

        /// <summary>
        /// <para>Columns Right-To-Left</para>
        /// <para>Represents the following attribute in the schema: rtlCol</para>
        /// </summary>
        [SchemaAttr(0, "rtlCol")]
        [Index(12)]
        public BooleanValue RightToLeftColumns { get; set; }

        /// <summary>
        /// <para>From WordArt</para>
        /// <para>Represents the following attribute in the schema: fromWordArt</para>
        /// </summary>
        [SchemaAttr(0, "fromWordArt")]
        [Index(13)]
        public BooleanValue FromWordArt { get; set; }

        /// <summary>
        /// <para>Anchor</para>
        /// <para>Represents the following attribute in the schema: anchor</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "anchor")]
        [Index(14)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues> Anchor { get; set; }

        /// <summary>
        /// <para>Anchor Center</para>
        /// <para>Represents the following attribute in the schema: anchorCtr</para>
        /// </summary>
        [SchemaAttr(0, "anchorCtr")]
        [Index(15)]
        public BooleanValue AnchorCenter { get; set; }

        /// <summary>
        /// <para>Force Anti-Alias</para>
        /// <para>Represents the following attribute in the schema: forceAA</para>
        /// </summary>
        [SchemaAttr(0, "forceAA")]
        [Index(16)]
        public BooleanValue ForceAntiAlias { get; set; }

        /// <summary>
        /// <para>Text Upright</para>
        /// <para>Represents the following attribute in the schema: upright</para>
        /// </summary>
        [SchemaAttr(0, "upright")]
        [Index(17)]
        public BooleanValue UpRight { get; set; }

        /// <summary>
        /// <para>Compatible Line Spacing</para>
        /// <para>Represents the following attribute in the schema: compatLnSpc</para>
        /// </summary>
        [SchemaAttr(0, "compatLnSpc")]
        [Index(18)]
        public BooleanValue CompatibleLineSpacing { get; set; }

        /// <summary>
        /// <para>Preset Text Shape.</para>
        /// <para>Represents the following element tag in the schema: a:prstTxWarp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetTextWrap PresetTextWrap
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetTextWrap), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoAutoFit), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NormalAutoFit), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapeAutoFit), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FlatText), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryAxisProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:categoryAxis.</para>
    /// </summary>
    [SchemaAttr(65, "categoryAxis")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class CategoryAxisProperties : AxisProperties
    {
        /// <summary>
        /// Initializes a new instance of the CategoryAxisProperties class.
        /// </summary>
        public CategoryAxisProperties() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxisProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesAxisProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:seriesAxis.</para>
    /// </summary>
    [SchemaAttr(65, "seriesAxis")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class SeriesAxisProperties : AxisProperties
    {
        /// <summary>
        /// Initializes a new instance of the SeriesAxisProperties class.
        /// </summary>
        public SeriesAxisProperties() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesAxisProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ValueAxisProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:valueAxis.</para>
    /// </summary>
    [SchemaAttr(65, "valueAxis")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ValueAxisProperties : AxisProperties
    {
        /// <summary>
        /// Initializes a new instance of the ValueAxisProperties class.
        /// </summary>
        public ValueAxisProperties() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValueAxisProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class AxisProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisProperties class.
        /// </summary>
        protected AxisProperties() : base()
        {
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "visible")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Visible { get; set; }

        /// <summary>
        /// <para>majorTick, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: majorTick</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "majorTick")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch> MajorTick { get; set; }

        /// <summary>
        /// <para>minorTick, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: minorTick</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "minorTick")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch> MinorTickProp { get; set; }

        /// <summary>
        /// <para>labelPosition, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: labelPosition</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "labelPosition")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickLabelPositionNinch> LabelPosition { get; set; }

        /// <summary>
        /// <para>majorGridlines, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: majorGridlines</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "majorGridlines")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> MajorGridlines { get; set; }

        /// <summary>
        /// <para>minorGridlines, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: minorGridlines</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "minorGridlines")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> MinorGridlinesProp { get; set; }

        /// <summary>
        /// <para>title, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "title")]
        [Index(6)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> TitleProp { get; set; }
    }

    /// <summary>
    /// <para>Defines the DataSeries Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataSeries.</para>
    /// </summary>
    [SchemaAttr(65, "dataSeries")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataSeries : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataSeries class.
        /// </summary>
        public DataSeries() : base()
        {
        }

        /// <summary>
        /// <para>overlap, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: overlap</para>
        /// </summary>
        [NumberValidator(MinInclusive = -100L, MaxInclusive = 100L)]
        [SchemaAttr(0, "overlap")]
        [Index(0)]
        public SByteValue Overlap { get; set; }

        /// <summary>
        /// <para>gapWidth, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: gapWidth</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 500L)]
        [SchemaAttr(0, "gapWidth")]
        [Index(1)]
        public UInt16Value GapWidth { get; set; }

        /// <summary>
        /// <para>gapDepth, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: gapDepth</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 500L)]
        [SchemaAttr(0, "gapDepth")]
        [Index(2)]
        public UInt16Value GapDepth { get; set; }

        /// <summary>
        /// <para>doughnutHoleSize, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: doughnutHoleSize</para>
        /// </summary>
        [NumberValidator(MinInclusive = 10L, MaxInclusive = 90L)]
        [SchemaAttr(0, "doughnutHoleSize")]
        [Index(3)]
        public ByteValue DoughnutHoleSize { get; set; }

        /// <summary>
        /// <para>markerVisible, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: markerVisible</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "markerVisible")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> MarkerVisible { get; set; }

        /// <summary>
        /// <para>hiloLines, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: hiloLines</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "hiloLines")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> HiloLines { get; set; }

        /// <summary>
        /// <para>dropLines, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: dropLines</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "dropLines")]
        [Index(6)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> DropLines { get; set; }

        /// <summary>
        /// <para>seriesLines, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: seriesLines</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "seriesLines")]
        [Index(7)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> SeriesLines { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabels Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataLabels.</para>
    /// </summary>
    [SchemaAttr(65, "dataLabels")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataLabels : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabels class.
        /// </summary>
        public DataLabels() : base()
        {
        }

        /// <summary>
        /// <para>position, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "position")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelsPosition> Position { get; set; }

        /// <summary>
        /// <para>value, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "value")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Value { get; set; }

        /// <summary>
        /// <para>seriesName, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: seriesName</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "seriesName")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> SeriesName { get; set; }

        /// <summary>
        /// <para>categoryName, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: categoryName</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "categoryName")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> CategoryName { get; set; }

        /// <summary>
        /// <para>legendKey, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: legendKey</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "legendKey")]
        [Index(4)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> LegendKey { get; set; }

        /// <summary>
        /// <para>percentage, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: percentage</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "percentage")]
        [Index(5)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Percentage { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabels>(deep);
    }

    /// <summary>
    /// <para>Defines the DataTable Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataTable.</para>
    /// </summary>
    [SchemaAttr(65, "dataTable")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataTable class.
        /// </summary>
        public DataTable() : base()
        {
        }

        /// <summary>
        /// <para>legendKeys, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: legendKeys</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "legendKeys")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> LegendKeys { get; set; }

        /// <summary>
        /// <para>horizontalBorder, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: horizontalBorder</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "horizontalBorder")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> HorizontalBorder { get; set; }

        /// <summary>
        /// <para>verticalBorder, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: verticalBorder</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "verticalBorder")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> VerticalBorder { get; set; }

        /// <summary>
        /// <para>outlineBorder, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: outlineBorder</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "outlineBorder")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> OutlineBorder { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataTable>(deep);
    }

    /// <summary>
    /// <para>Defines the Legend Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:legend.</para>
    /// </summary>
    [SchemaAttr(65, "legend")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Legend : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Legend class.
        /// </summary>
        public Legend() : base()
        {
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "visible")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Visible { get; set; }

        /// <summary>
        /// <para>includeInLayout, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: includeInLayout</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "includeInLayout")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> IncludeInLayout { get; set; }

        /// <summary>
        /// <para>position, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "position")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendPosition> Position { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Legend>(deep);
    }

    /// <summary>
    /// <para>Defines the Title Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:title.</para>
    /// </summary>
    [SchemaAttr(65, "title")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Title : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Title class.
        /// </summary>
        public Title() : base()
        {
        }

        /// <summary>
        /// <para>position, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "position")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitlePosition> Position { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Title>(deep);
    }

    /// <summary>
    /// <para>Defines the Trendline Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:trendline.</para>
    /// </summary>
    [SchemaAttr(65, "trendline")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Trendline : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Trendline class.
        /// </summary>
        public Trendline() : base()
        {
        }

        /// <summary>
        /// <para>add, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: add</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "add")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Add { get; set; }

        /// <summary>
        /// <para>equation, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: equation</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "equation")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> Equation { get; set; }

        /// <summary>
        /// <para>rsquared, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rsquared</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "rsquared")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> RSquared { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Trendline>(deep);
    }

    /// <summary>
    /// <para>Defines the View3DProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:view3D.</para>
    /// </summary>
    [SchemaAttr(65, "view3D")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class View3DProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the View3DProperties class.
        /// </summary>
        public View3DProperties() : base()
        {
        }

        /// <summary>
        /// <para>rotX, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rotX</para>
        /// </summary>
        [NumberValidator(MinInclusive = -90L, MaxInclusive = 90L)]
        [SchemaAttr(0, "rotX")]
        [Index(0)]
        public SByteValue RotX { get; set; }

        /// <summary>
        /// <para>rotY, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rotY</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 360L)]
        [SchemaAttr(0, "rotY")]
        [Index(1)]
        public UInt16Value RotY { get; set; }

        /// <summary>
        /// <para>rAngAx, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: rAngAx</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "rAngAx")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean> RightAngleAxes { get; set; }

        /// <summary>
        /// <para>perspective, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: perspective</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 240L)]
        [SchemaAttr(0, "perspective")]
        [Index(3)]
        public ByteValue Perspective { get; set; }

        /// <summary>
        /// <para>heightPercent, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: heightPercent</para>
        /// </summary>
        [NumberValidator(MinInclusive = 5L, MaxInclusive = 500L)]
        [SchemaAttr(0, "heightPercent")]
        [Index(4)]
        public UInt16Value HeightPercent { get; set; }

        /// <summary>
        /// <para>depthPercent, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: depthPercent</para>
        /// </summary>
        [NumberValidator(MinInclusive = 20L, MaxInclusive = 2000L)]
        [SchemaAttr(0, "depthPercent")]
        [Index(5)]
        public UInt16Value DepthPercent { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<View3DProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisTitle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:axisTitle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "axisTitle")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class AxisTitle : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the AxisTitle class.
        /// </summary>
        public AxisTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public AxisTitle(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryAxis Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:categoryAxis.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "categoryAxis")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class CategoryAxis : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the CategoryAxis class.
        /// </summary>
        public CategoryAxis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryAxis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public CategoryAxis(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxis>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartArea Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:chartArea.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "chartArea")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ChartArea : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the ChartArea class.
        /// </summary>
        public ChartArea() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartArea(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ChartArea(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartArea>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabel Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataLabel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "dataLabel")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataLabel : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataLabel class.
        /// </summary>
        public DataLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DataLabel(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelCallout Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataLabelCallout.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "dataLabelCallout")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataLabelCallout : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelCallout class.
        /// </summary>
        public DataLabelCallout() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelCallout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelCallout(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DataLabelCallout(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelCallout>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPoint Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPoint.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "dataPoint")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataPoint : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataPoint class.
        /// </summary>
        public DataPoint() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPoint(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DataPoint(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPoint3D Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPoint3D.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "dataPoint3D")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataPoint3D : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataPoint3D class.
        /// </summary>
        public DataPoint3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPoint3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DataPoint3D(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint3D>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPointLine Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPointLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "dataPointLine")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataPointLine : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataPointLine class.
        /// </summary>
        public DataPointLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPointLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DataPointLine(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPointLine>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPointMarker Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPointMarker.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "dataPointMarker")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataPointMarker : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataPointMarker class.
        /// </summary>
        public DataPointMarker() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPointMarker(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DataPointMarker(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPointMarker>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPointWireframe Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPointWireframe.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "dataPointWireframe")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataPointWireframe : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataPointWireframe class.
        /// </summary>
        public DataPointWireframe() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointWireframe class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPointWireframe(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DataPointWireframe(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPointWireframe>(deep);
    }

    /// <summary>
    /// <para>Defines the DataTableStyle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataTable.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "dataTable")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DataTableStyle : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataTableStyle class.
        /// </summary>
        public DataTableStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataTableStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataTableStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DataTableStyle(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataTableStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the DownBar Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:downBar.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "downBar")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DownBar : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DownBar class.
        /// </summary>
        public DownBar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DownBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DownBar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DownBar(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DownBar>(deep);
    }

    /// <summary>
    /// <para>Defines the DropLine Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dropLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "dropLine")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class DropLine : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DropLine class.
        /// </summary>
        public DropLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DropLine(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropLine>(deep);
    }

    /// <summary>
    /// <para>Defines the ErrorBar Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:errorBar.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "errorBar")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ErrorBar : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the ErrorBar class.
        /// </summary>
        public ErrorBar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ErrorBar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ErrorBar(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBar>(deep);
    }

    /// <summary>
    /// <para>Defines the Floor Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:floor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "floor")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Floor : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the Floor class.
        /// </summary>
        public Floor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Floor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Floor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Floor(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Floor>(deep);
    }

    /// <summary>
    /// <para>Defines the GridlineMajor Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:gridlineMajor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "gridlineMajor")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class GridlineMajor : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the GridlineMajor class.
        /// </summary>
        public GridlineMajor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GridlineMajor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GridlineMajor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public GridlineMajor(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GridlineMajor>(deep);
    }

    /// <summary>
    /// <para>Defines the GridlineMinor Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:gridlineMinor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "gridlineMinor")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class GridlineMinor : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the GridlineMinor class.
        /// </summary>
        public GridlineMinor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GridlineMinor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GridlineMinor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public GridlineMinor(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GridlineMinor>(deep);
    }

    /// <summary>
    /// <para>Defines the HiLoLine Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:hiLoLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "hiLoLine")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class HiLoLine : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the HiLoLine class.
        /// </summary>
        public HiLoLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiLoLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HiLoLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public HiLoLine(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiLoLine>(deep);
    }

    /// <summary>
    /// <para>Defines the LeaderLine Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:leaderLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "leaderLine")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class LeaderLine : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the LeaderLine class.
        /// </summary>
        public LeaderLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LeaderLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public LeaderLine(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeaderLine>(deep);
    }

    /// <summary>
    /// <para>Defines the LegendStyle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:legend.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "legend")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class LegendStyle : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the LegendStyle class.
        /// </summary>
        public LegendStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LegendStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LegendStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public LegendStyle(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegendStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the PlotArea Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:plotArea.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "plotArea")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class PlotArea : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the PlotArea class.
        /// </summary>
        public PlotArea() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotArea(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public PlotArea(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea>(deep);
    }

    /// <summary>
    /// <para>Defines the PlotArea3D Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:plotArea3D.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "plotArea3D")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class PlotArea3D : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the PlotArea3D class.
        /// </summary>
        public PlotArea3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotArea3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public PlotArea3D(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea3D>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesAxis Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:seriesAxis.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "seriesAxis")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class SeriesAxis : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the SeriesAxis class.
        /// </summary>
        public SeriesAxis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesAxis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public SeriesAxis(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesAxis>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesLine Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:seriesLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "seriesLine")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class SeriesLine : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the SeriesLine class.
        /// </summary>
        public SeriesLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public SeriesLine(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesLine>(deep);
    }

    /// <summary>
    /// <para>Defines the TitleStyle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:title.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "title")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class TitleStyle : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the TitleStyle class.
        /// </summary>
        public TitleStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitleStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitleStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public TitleStyle(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TitleStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the TrendlineStyle Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:trendline.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "trendline")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class TrendlineStyle : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the TrendlineStyle class.
        /// </summary>
        public TrendlineStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TrendlineStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public TrendlineStyle(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the TrendlineLabel Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:trendlineLabel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "trendlineLabel")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class TrendlineLabel : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the TrendlineLabel class.
        /// </summary>
        public TrendlineLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TrendlineLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public TrendlineLabel(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the UpBar Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:upBar.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "upBar")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class UpBar : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the UpBar class.
        /// </summary>
        public UpBar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UpBar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public UpBar(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UpBar>(deep);
    }

    /// <summary>
    /// <para>Defines the ValueAxis Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:valueAxis.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "valueAxis")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ValueAxis : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the ValueAxis class.
        /// </summary>
        public ValueAxis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValueAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ValueAxis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ValueAxis(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValueAxis>(deep);
    }

    /// <summary>
    /// <para>Defines the Wall Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:wall.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr(65, "wall")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class Wall : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the Wall class.
        /// </summary>
        public Wall() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Wall class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Wall(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Wall(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Wall>(deep);
    }

    /// <summary>
    /// <para>Defines the StyleEntry Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineReference &lt;cs:lnRef></description></item>
    ///   <item><description>LineWidthScale &lt;cs:lineWidthScale></description></item>
    ///   <item><description>FillReference &lt;cs:fillRef></description></item>
    ///   <item><description>EffectReference &lt;cs:effectRef></description></item>
    ///   <item><description>FontReference &lt;cs:fontRef></description></item>
    ///   <item><description>ShapeProperties &lt;cs:spPr></description></item>
    ///   <item><description>TextCharacterPropertiesType &lt;cs:defRPr></description></item>
    ///   <item><description>TextBodyProperties &lt;cs:bodyPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;cs:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(LineReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(LineWidthScale), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(FillReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(EffectReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(FontReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(TextCharacterPropertiesType), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(TextBodyProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]
    public abstract partial class StyleEntry : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleEntry class.
        /// </summary>
        protected StyleEntry() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StyleEntry(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        protected StyleEntry(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>mods, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: mods</para>
        /// </summary>
        [SchemaAttr(0, "mods")]
        [Index(0)]
        public ListValue<StringValue> Modifiers { get; set; }

        /// <summary>
        /// <para>LineReference.</para>
        /// <para>Represents the following element tag in the schema: cs:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public LineReference LineReference
        {
            get => GetElement<LineReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LineWidthScale.</para>
        /// <para>Represents the following element tag in the schema: cs:lineWidthScale.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public LineWidthScale LineWidthScale
        {
            get => GetElement<LineWidthScale>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillReference.</para>
        /// <para>Represents the following element tag in the schema: cs:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public FillReference FillReference
        {
            get => GetElement<FillReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectReference.</para>
        /// <para>Represents the following element tag in the schema: cs:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public EffectReference EffectReference
        {
            get => GetElement<EffectReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FontReference.</para>
        /// <para>Represents the following element tag in the schema: cs:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public FontReference FontReference
        {
            get => GetElement<FontReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cs:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextCharacterPropertiesType.</para>
        /// <para>Represents the following element tag in the schema: cs:defRPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public TextCharacterPropertiesType TextCharacterPropertiesType
        {
            get => GetElement<TextCharacterPropertiesType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextBodyProperties.</para>
        /// <para>Represents the following element tag in the schema: cs:bodyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public TextBodyProperties TextBodyProperties
        {
            get => GetElement<TextBodyProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cs:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    }

    /// <summary>
    /// <para>Defines the MarkerLayoutProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPointMarkerLayout.</para>
    /// </summary>
    [SchemaAttr(65, "dataPointMarkerLayout")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class MarkerLayoutProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MarkerLayoutProperties class.
        /// </summary>
        public MarkerLayoutProperties() : base()
        {
        }

        /// <summary>
        /// <para>symbol, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: symbol</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "symbol")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle> Symbol { get; set; }

        /// <summary>
        /// <para>size, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [NumberValidator(MinInclusive = 2L, MaxInclusive = 72L)]
        [SchemaAttr(0, "size")]
        [Index(1)]
        public ByteValue Size { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MarkerLayoutProperties>(deep);
    }

    /// <summary>
    /// Defines the ColorStyleMethodEnum enumeration.
    /// </summary>
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