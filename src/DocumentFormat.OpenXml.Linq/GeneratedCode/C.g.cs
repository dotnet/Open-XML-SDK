// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:c="http://schemas.openxmlformats.org/drawingml/2006/chart" namespace.
    /// </summary>
    public static class C
    {
        /// <summary>
        /// Defines the XML namespace associated with the c prefix.
        /// </summary>
        public static readonly XNamespace c = "http://schemas.openxmlformats.org/drawingml/2006/chart";

        /// <summary>
        /// Represents the c:applyToEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pictureOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ApplyToEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName applyToEnd = c + "applyToEnd";

        /// <summary>
        /// Represents the c:applyToFront XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pictureOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ApplyToFront.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName applyToFront = c + "applyToFront";

        /// <summary>
        /// Represents the c:applyToSides XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pictureOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ApplyToSides.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName applyToSides = c + "applyToSides";

        /// <summary>
        /// Represents the c:area3DChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="dLbls" />, <see cref="dropLines" />, <see cref="extLst" />, <see cref="gapDepth" />, <see cref="grouping" />, <see cref="ser" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Area3DChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName area3DChart = c + "area3DChart";

        /// <summary>
        /// Represents the c:areaChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="dLbls" />, <see cref="dropLines" />, <see cref="extLst" />, <see cref="grouping" />, <see cref="ser" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AreaChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName areaChart = c + "areaChart";

        /// <summary>
        /// Represents the c:auto XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoLabeled.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName auto = c + "auto";

        /// <summary>
        /// Represents the c:autoTitleDeleted XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoTitleDeleted.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoTitleDeleted = c + "autoTitleDeleted";

        /// <summary>
        /// Represents the c:autoUpdate XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="externalData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoUpdate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoUpdate = c + "autoUpdate";

        /// <summary>
        /// Represents the c:axId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="area3DChart" />, <see cref="areaChart" />, <see cref="bar3DChart" />, <see cref="barChart" />, <see cref="bubbleChart" />, <see cref="catAx" />, <see cref="dateAx" />, <see cref="line3DChart" />, <see cref="lineChart" />, <see cref="radarChart" />, <see cref="scatterChart" />, <see cref="serAx" />, <see cref="stockChart" />, <see cref="surface3DChart" />, <see cref="surfaceChart" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AxisId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName axId = c + "axId";

        /// <summary>
        /// Represents the c:axPos XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AxisPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName axPos = c + "axPos";

        /// <summary>
        /// Represents the c:backWall XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pictureOptions" />, <see cref="spPr" />, <see cref="thickness" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackWall.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName backWall = c + "backWall";

        /// <summary>
        /// Represents the c:backward XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trendline" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Backward.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName backward = c + "backward";

        /// <summary>
        /// Represents the c:bandFmt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bandFmts" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="idx" />, <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BandFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bandFmt = c + "bandFmt";

        /// <summary>
        /// Represents the c:bandFmts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="surface3DChart" />, <see cref="surfaceChart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bandFmt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BandFormats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bandFmts = c + "bandFmts";

        /// <summary>
        /// Represents the c:bar3DChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="barDir" />, <see cref="dLbls" />, <see cref="extLst" />, <see cref="gapDepth" />, <see cref="gapWidth" />, <see cref="grouping" />, <see cref="ser" />, <see cref="shape" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Bar3DChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bar3DChart = c + "bar3DChart";

        /// <summary>
        /// Represents the c:barChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="barDir" />, <see cref="dLbls" />, <see cref="extLst" />, <see cref="gapWidth" />, <see cref="grouping" />, <see cref="overlap" />, <see cref="ser" />, <see cref="serLines" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BarChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName barChart = c + "barChart";

        /// <summary>
        /// Represents the c:barDir XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bar3DChart" />, <see cref="barChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BarDirection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName barDir = c + "barDir";

        /// <summary>
        /// Represents the c:baseTimeUnit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dateAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BaseTimeUnit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName baseTimeUnit = c + "baseTimeUnit";

        /// <summary>
        /// Represents the c:bubble3D XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bubbleChart" />, <see cref="dPt" />, <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Bubble3D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bubble3D = c + "bubble3D";

        /// <summary>
        /// Represents the c:bubbleChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="bubble3D" />, <see cref="bubbleScale" />, <see cref="dLbls" />, <see cref="extLst" />, <see cref="ser" />, <see cref="showNegBubbles" />, <see cref="sizeRepresents" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BubbleChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bubbleChart = c + "bubbleChart";

        /// <summary>
        /// Represents the c:bubbleScale XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bubbleChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BubbleScale.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bubbleScale = c + "bubbleScale";

        /// <summary>
        /// Represents the c:bubbleSize XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="numLit" />, <see cref="numRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BubbleSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bubbleSize = c + "bubbleSize";

        /// <summary>
        /// Represents the c:builtInUnit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dispUnits" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BuiltInUnit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName builtInUnit = c + "builtInUnit";

        /// <summary>
        /// Represents the c:cat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="multiLvlStrRef" />, <see cref="numLit" />, <see cref="numRef" />, <see cref="strLit" />, <see cref="strRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CategoryAxisData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cat = c + "cat";

        /// <summary>
        /// Represents the c:catAx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="auto" />, <see cref="axId" />, <see cref="axPos" />, <see cref="crossAx" />, <see cref="crosses" />, <see cref="crossesAt" />, <see cref="delete" />, <see cref="extLst" />, <see cref="lblAlgn" />, <see cref="lblOffset" />, <see cref="majorGridlines" />, <see cref="majorTickMark" />, <see cref="minorGridlines" />, <see cref="minorTickMark" />, <see cref="noMultiLvlLbl" />, <see cref="numFmt" />, <see cref="scaling" />, <see cref="spPr" />, <see cref="tickLblPos" />, <see cref="tickLblSkip" />, <see cref="tickMarkSkip" />, <see cref="title" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CategoryAxis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName catAx = c + "catAx";

        /// <summary>
        /// Represents the c:chart XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="autoTitleDeleted" />, <see cref="backWall" />, <see cref="dispBlanksAs" />, <see cref="extLst" />, <see cref="floor" />, <see cref="legend" />, <see cref="pivotFmts" />, <see cref="plotArea" />, <see cref="plotVisOnly" />, <see cref="showDLblsOverMax" />, <see cref="sideWall" />, <see cref="title" />, <see cref="view3D" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Chart, ChartReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chart = c + "chart";

        /// <summary>
        /// Represents the c:chartObject XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="protection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartObject = c + "chartObject";

        /// <summary>
        /// Represents the c:chartSpace XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="chart" />, <see cref="clrMapOvr" />, <see cref="date1904" />, <see cref="externalData" />, <see cref="extLst" />, <see cref="lang" />, <see cref="pivotSource" />, <see cref="printSettings" />, <see cref="protection" />, <see cref="roundedCorners" />, <see cref="spPr" />, <see cref="style" />, <see cref="txPr" />, <see cref="userShapes" />, <see cref="C14.style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartSpace.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartSpace = c + "chartSpace";

        /// <summary>
        /// Represents the c:clrMapOvr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.accent1" />, <see cref="NoNamespace.accent2" />, <see cref="NoNamespace.accent3" />, <see cref="NoNamespace.accent4" />, <see cref="NoNamespace.accent5" />, <see cref="NoNamespace.accent6" />, <see cref="NoNamespace.bg1" />, <see cref="NoNamespace.bg2" />, <see cref="NoNamespace.folHlink" />, <see cref="NoNamespace.hlink" />, <see cref="NoNamespace.tx1" />, <see cref="NoNamespace.tx2" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorMapOverride.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clrMapOvr = c + "clrMapOvr";

        /// <summary>
        /// Represents the c:crossAx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CrossingAxis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName crossAx = c + "crossAx";

        /// <summary>
        /// Represents the c:crossBetween XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CrossBetween.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName crossBetween = c + "crossBetween";

        /// <summary>
        /// Represents the c:crosses XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Crosses.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName crosses = c + "crosses";

        /// <summary>
        /// Represents the c:crossesAt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CrossesAt.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName crossesAt = c + "crossesAt";

        /// <summary>
        /// Represents the c:custSplit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ofPieChart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="secondPiePt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomSplit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName custSplit = c + "custSplit";

        /// <summary>
        /// Represents the c:custUnit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dispUnits" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomDisplayUnit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName custUnit = c + "custUnit";

        /// <summary>
        /// Represents the c:data XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="protection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Data.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName data = c + "data";

        /// <summary>
        /// Represents the c:date1904 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Date1904.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName date1904 = c + "date1904";

        /// <summary>
        /// Represents the c:dateAx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="auto" />, <see cref="axId" />, <see cref="axPos" />, <see cref="baseTimeUnit" />, <see cref="crossAx" />, <see cref="crosses" />, <see cref="crossesAt" />, <see cref="delete" />, <see cref="extLst" />, <see cref="lblOffset" />, <see cref="majorGridlines" />, <see cref="majorTickMark" />, <see cref="majorTimeUnit" />, <see cref="majorUnit" />, <see cref="minorGridlines" />, <see cref="minorTickMark" />, <see cref="minorTimeUnit" />, <see cref="minorUnit" />, <see cref="numFmt" />, <see cref="scaling" />, <see cref="spPr" />, <see cref="tickLblPos" />, <see cref="title" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DateAxis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dateAx = c + "dateAx";

        /// <summary>
        /// Represents the c:delete XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="dLbl" />, <see cref="dLbls" />, <see cref="legendEntry" />, <see cref="serAx" />, <see cref="valAx" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Delete.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName delete = c + "delete";

        /// <summary>
        /// Represents the c:depthPercent XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="view3D" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DepthPercent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName depthPercent = c + "depthPercent";

        /// <summary>
        /// Represents the c:dispBlanksAs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DisplayBlanksAs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dispBlanksAs = c + "dispBlanksAs";

        /// <summary>
        /// Represents the c:dispEq XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trendline" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DisplayEquation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dispEq = c + "dispEq";

        /// <summary>
        /// Represents the c:dispRSqr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trendline" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DisplayRSquaredValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dispRSqr = c + "dispRSqr";

        /// <summary>
        /// Represents the c:dispUnits XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="valAx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="builtInUnit" />, <see cref="custUnit" />, <see cref="dispUnitsLbl" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DisplayUnits.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dispUnits = c + "dispUnits";

        /// <summary>
        /// Represents the c:dispUnitsLbl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dispUnits" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="layout" />, <see cref="spPr" />, <see cref="tx" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DisplayUnitsLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dispUnitsLbl = c + "dispUnitsLbl";

        /// <summary>
        /// Represents the c:dLbl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbls" />, <see cref="pivotFmt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="delete" />, <see cref="dLblPos" />, <see cref="extLst" />, <see cref="idx" />, <see cref="layout" />, <see cref="numFmt" />, <see cref="separator" />, <see cref="showBubbleSize" />, <see cref="showCatName" />, <see cref="showLegendKey" />, <see cref="showPercent" />, <see cref="showSerName" />, <see cref="showVal" />, <see cref="spPr" />, <see cref="tx" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dLbl = c + "dLbl";

        /// <summary>
        /// Represents the c:dLblPos XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbl" />, <see cref="dLbls" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabelPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dLblPos = c + "dLblPos";

        /// <summary>
        /// Represents the c:dLbls XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="area3DChart" />, <see cref="areaChart" />, <see cref="bar3DChart" />, <see cref="barChart" />, <see cref="bubbleChart" />, <see cref="doughnutChart" />, <see cref="line3DChart" />, <see cref="lineChart" />, <see cref="ofPieChart" />, <see cref="pie3DChart" />, <see cref="pieChart" />, <see cref="radarChart" />, <see cref="scatterChart" />, <see cref="ser" />, <see cref="stockChart" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="delete" />, <see cref="dLbl" />, <see cref="dLblPos" />, <see cref="extLst" />, <see cref="leaderLines" />, <see cref="numFmt" />, <see cref="separator" />, <see cref="showBubbleSize" />, <see cref="showCatName" />, <see cref="showLeaderLines" />, <see cref="showLegendKey" />, <see cref="showPercent" />, <see cref="showSerName" />, <see cref="showVal" />, <see cref="spPr" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabels.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dLbls = c + "dLbls";

        /// <summary>
        /// Represents the c:doughnutChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dLbls" />, <see cref="extLst" />, <see cref="firstSliceAng" />, <see cref="holeSize" />, <see cref="ser" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoughnutChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doughnutChart = c + "doughnutChart";

        /// <summary>
        /// Represents the c:downBars XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="upDownBars" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DownBars.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName downBars = c + "downBars";

        /// <summary>
        /// Represents the c:dPt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bubble3D" />, <see cref="explosion" />, <see cref="extLst" />, <see cref="idx" />, <see cref="invertIfNegative" />, <see cref="marker" />, <see cref="pictureOptions" />, <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataPoint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dPt = c + "dPt";

        /// <summary>
        /// Represents the c:dropLines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="area3DChart" />, <see cref="areaChart" />, <see cref="line3DChart" />, <see cref="lineChart" />, <see cref="stockChart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropLines = c + "dropLines";

        /// <summary>
        /// Represents the c:dTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="showHorzBorder" />, <see cref="showKeys" />, <see cref="showOutline" />, <see cref="showVertBorder" />, <see cref="spPr" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dTable = c + "dTable";

        /// <summary>
        /// Represents the c:errBars XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="errBarType" />, <see cref="errDir" />, <see cref="errValType" />, <see cref="extLst" />, <see cref="minus" />, <see cref="noEndCap" />, <see cref="plus" />, <see cref="spPr" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ErrorBars.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName errBars = c + "errBars";

        /// <summary>
        /// Represents the c:errBarType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="errBars" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ErrorBarType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName errBarType = c + "errBarType";

        /// <summary>
        /// Represents the c:errDir XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="errBars" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ErrorDirection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName errDir = c + "errDir";

        /// <summary>
        /// Represents the c:errValType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="errBars" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ErrorBarValueType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName errValType = c + "errValType";

        /// <summary>
        /// Represents the c:evenFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EvenFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName evenFooter = c + "evenFooter";

        /// <summary>
        /// Represents the c:evenHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EvenHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName evenHeader = c + "evenHeader";

        /// <summary>
        /// Represents the c:explosion XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dPt" />, <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Explosion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName explosion = c + "explosion";

        /// <summary>
        /// Represents the c:ext XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C14.invertSolidFillFmt" />, <see cref="C14.pivotOptions" />, <see cref="C14.sketchOptions" />, <see cref="C15.autoCat" />, <see cref="C15.categoryFilterExceptions" />, <see cref="C15.datalabelsRange" />, <see cref="C15.dlblFieldTable" />, <see cref="C15.filteredAreaSeries" />, <see cref="C15.filteredBarSeries" />, <see cref="C15.filteredBubbleSeries" />, <see cref="C15.filteredCategoryTitle" />, <see cref="C15.filteredLineSeries" />, <see cref="C15.filteredPieSeries" />, <see cref="C15.filteredRadarSeries" />, <see cref="C15.filteredScatterSeries" />, <see cref="C15.filteredSeriesTitle" />, <see cref="C15.filteredSurfaceSeries" />, <see cref="C15.formulaRef" />, <see cref="C15.fullRef" />, <see cref="C15.layout" />, <see cref="C15.leaderLines" />, <see cref="C15.levelRef" />, <see cref="C15.numFmt" />, <see cref="C15.pivotSource" />, <see cref="C15.showDataLabelsRange" />, <see cref="C15.showLeaderLines" />, <see cref="C15.spPr" />, <see cref="C15.tx" />, <see cref="C15.xForSave" />, <see cref="C16R3.dispNaAsBlank" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.uri" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Area3DChartExtension, AreaChartExtension, AreaSerExtension, Bar3DChartExtension, BarChartExtension, BarSerExtension, BubbleChartExtension, BubbleSerExtension, CatAxExtension, ChartSpaceExtension, DataDisplayOptions16, DateAxExtension, DLblExtension, DLblsExtension, Extension, Line3DChartExtension, LineChartExtension, LineSerExtension, MultiLvlStrRefExtension, NumRefExtension, Pie3DChartExtension, PieChartExtension, PieSerExtension, RadarChartExtension, RadarSerExtension, ScatterChartExtension, ScatterSerExtension, SerAxExtension, StockChartExtension, StrDataExtension, StrRefExtension, Surface3DChartExtension, SurfaceChartExtension, SurfaceSerExtension, ValAxExtension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = c + "ext";

        /// <summary>
        /// Represents the c:externalData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="autoUpdate" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName externalData = c + "externalData";

        /// <summary>
        /// Represents the c:extLst XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="area3DChart" />, <see cref="areaChart" />, <see cref="backWall" />, <see cref="bar3DChart" />, <see cref="barChart" />, <see cref="bubbleChart" />, <see cref="catAx" />, <see cref="chart" />, <see cref="chartSpace" />, <see cref="dateAx" />, <see cref="dispUnits" />, <see cref="dLbl" />, <see cref="dLbls" />, <see cref="doughnutChart" />, <see cref="dPt" />, <see cref="dTable" />, <see cref="errBars" />, <see cref="floor" />, <see cref="layout" />, <see cref="legend" />, <see cref="legendEntry" />, <see cref="line3DChart" />, <see cref="lineChart" />, <see cref="manualLayout" />, <see cref="marker" />, <see cref="multiLvlStrCache" />, <see cref="multiLvlStrRef" />, <see cref="numCache" />, <see cref="numLit" />, <see cref="numRef" />, <see cref="ofPieChart" />, <see cref="pie3DChart" />, <see cref="pieChart" />, <see cref="pivotFmt" />, <see cref="pivotSource" />, <see cref="plotArea" />, <see cref="radarChart" />, <see cref="scaling" />, <see cref="scatterChart" />, <see cref="ser" />, <see cref="serAx" />, <see cref="sideWall" />, <see cref="stockChart" />, <see cref="strCache" />, <see cref="strLit" />, <see cref="strRef" />, <see cref="surface3DChart" />, <see cref="surfaceChart" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLbl" />, <see cref="upDownBars" />, <see cref="valAx" />, <see cref="view3D" />, <see cref="C15.dLbl" />, <see cref="C15.dlblFieldTableCache" />, <see cref="C15.dlblRangeCache" />, <see cref="C15.layout" />, <see cref="C15.marker" />, <see cref="C15.pivotSource" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Area3DChartExtensionList, AreaChartExtensionList, AreaSerExtensionList, Bar3DChartExtensionList, BarChartExtensionList, BarSerExtensionList, BubbleChartExtensionList, BubbleSerExtensionList, CatAxExtensionList, ChartExtensionList, ChartSpaceExtensionList, DateAxExtensionList, DLblExtensionList, DLblsExtensionList, ExtensionList, Line3DChartExtensionList, LineChartExtensionList, LineSerExtensionList, MultiLvlStrRefExtensionList, NumRefExtensionList, Pie3DChartExtensionList, PieChartExtensionList, PieSerExtensionList, RadarChartExtensionList, RadarSerExtensionList, ScatterChartExtensionList, ScatterSerExtensionList, SerAxExtensionList, StockChartExtensionList, StrDataExtensionList, StrRefExtensionList, Surface3DChartExtensionList, SurfaceChartExtensionList, SurfaceSerExtensionList, ValAxExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = c + "extLst";

        /// <summary>
        /// Represents the c:f XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="multiLvlStrRef" />, <see cref="numRef" />, <see cref="strRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName f = c + "f";

        /// <summary>
        /// Represents the c:firstFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FirstFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstFooter = c + "firstFooter";

        /// <summary>
        /// Represents the c:firstHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FirstHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstHeader = c + "firstHeader";

        /// <summary>
        /// Represents the c:firstSliceAng XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="doughnutChart" />, <see cref="pieChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FirstSliceAngle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstSliceAng = c + "firstSliceAng";

        /// <summary>
        /// Represents the c:floor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pictureOptions" />, <see cref="spPr" />, <see cref="thickness" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Floor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName floor = c + "floor";

        /// <summary>
        /// Represents the c:fmtId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotSource" />, <see cref="C15.pivotSource" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormatId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fmtId = c + "fmtId";

        /// <summary>
        /// Represents the c:formatCode XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numCache" />, <see cref="numLit" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormatCode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formatCode = c + "formatCode";

        /// <summary>
        /// Represents the c:formatting XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="protection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formatting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formatting = c + "formatting";

        /// <summary>
        /// Represents the c:forward XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trendline" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Forward.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName forward = c + "forward";

        /// <summary>
        /// Represents the c:gapDepth XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="area3DChart" />, <see cref="bar3DChart" />, <see cref="line3DChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GapDepth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gapDepth = c + "gapDepth";

        /// <summary>
        /// Represents the c:gapWidth XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bar3DChart" />, <see cref="barChart" />, <see cref="ofPieChart" />, <see cref="upDownBars" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GapWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gapWidth = c + "gapWidth";

        /// <summary>
        /// Represents the c:grouping XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="area3DChart" />, <see cref="areaChart" />, <see cref="bar3DChart" />, <see cref="barChart" />, <see cref="line3DChart" />, <see cref="lineChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BarGrouping, Grouping.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grouping = c + "grouping";

        /// <summary>
        /// Represents the c:h XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="manualLayout" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Height.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName h = c + "h";

        /// <summary>
        /// Represents the c:headerFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="printSettings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="evenFooter" />, <see cref="evenHeader" />, <see cref="firstFooter" />, <see cref="firstHeader" />, <see cref="oddFooter" />, <see cref="oddHeader" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignWithMargins" />, <see cref="NoNamespace.differentFirst" />, <see cref="NoNamespace.differentOddEven" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HeaderFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName headerFooter = c + "headerFooter";

        /// <summary>
        /// Represents the c:hiLowLines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lineChart" />, <see cref="stockChart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HighLowLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hiLowLines = c + "hiLowLines";

        /// <summary>
        /// Represents the c:hMode XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="manualLayout" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HeightMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hMode = c + "hMode";

        /// <summary>
        /// Represents the c:holeSize XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="doughnutChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HoleSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName holeSize = c + "holeSize";

        /// <summary>
        /// Represents the c:hPercent XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="view3D" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HeightPercent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hPercent = c + "hPercent";

        /// <summary>
        /// Represents the c:idx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bandFmt" />, <see cref="dLbl" />, <see cref="dPt" />, <see cref="legendEntry" />, <see cref="pivotFmt" />, <see cref="ser" />, <see cref="C15.dLbl" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Index.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName idx = c + "idx";

        /// <summary>
        /// Represents the c:intercept XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trendline" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Intercept.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName intercept = c + "intercept";

        /// <summary>
        /// Represents the c:invertIfNegative XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dPt" />, <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InvertIfNegative.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName invertIfNegative = c + "invertIfNegative";

        /// <summary>
        /// Represents the c:lang XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EditingLanguage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lang = c + "lang";

        /// <summary>
        /// Represents the c:layout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dispUnitsLbl" />, <see cref="dLbl" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="title" />, <see cref="trendlineLbl" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="manualLayout" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Layout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layout = c + "layout";

        /// <summary>
        /// Represents the c:layoutTarget XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="manualLayout" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LayoutTarget.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layoutTarget = c + "layoutTarget";

        /// <summary>
        /// Represents the c:lblAlgn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LabelAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lblAlgn = c + "lblAlgn";

        /// <summary>
        /// Represents the c:lblOffset XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LabelOffset.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lblOffset = c + "lblOffset";

        /// <summary>
        /// Represents the c:leaderLines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbls" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LeaderLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName leaderLines = c + "leaderLines";

        /// <summary>
        /// Represents the c:legacyDrawingHF XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="printSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LegacyDrawingHeaderFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legacyDrawingHF = c + "legacyDrawingHF";

        /// <summary>
        /// Represents the c:legend XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="layout" />, <see cref="legendEntry" />, <see cref="legendPos" />, <see cref="overlay" />, <see cref="spPr" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Legend.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legend = c + "legend";

        /// <summary>
        /// Represents the c:legendEntry XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="legend" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="delete" />, <see cref="extLst" />, <see cref="idx" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LegendEntry.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legendEntry = c + "legendEntry";

        /// <summary>
        /// Represents the c:legendPos XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="legend" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LegendPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legendPos = c + "legendPos";

        /// <summary>
        /// Represents the c:line3DChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="dLbls" />, <see cref="dropLines" />, <see cref="extLst" />, <see cref="gapDepth" />, <see cref="grouping" />, <see cref="ser" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Line3DChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName line3DChart = c + "line3DChart";

        /// <summary>
        /// Represents the c:lineChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="dLbls" />, <see cref="dropLines" />, <see cref="extLst" />, <see cref="grouping" />, <see cref="hiLowLines" />, <see cref="marker" />, <see cref="ser" />, <see cref="smooth" />, <see cref="upDownBars" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lineChart = c + "lineChart";

        /// <summary>
        /// Represents the c:logBase XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="scaling" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LogBase.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName logBase = c + "logBase";

        /// <summary>
        /// Represents the c:lvl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="multiLvlStrCache" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Level.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lvl = c + "lvl";

        /// <summary>
        /// Represents the c:majorGridlines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MajorGridlines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName majorGridlines = c + "majorGridlines";

        /// <summary>
        /// Represents the c:majorTickMark XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MajorTickMark.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName majorTickMark = c + "majorTickMark";

        /// <summary>
        /// Represents the c:majorTimeUnit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dateAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MajorTimeUnit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName majorTimeUnit = c + "majorTimeUnit";

        /// <summary>
        /// Represents the c:majorUnit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dateAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MajorUnit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName majorUnit = c + "majorUnit";

        /// <summary>
        /// Represents the c:manualLayout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layout" />, <see cref="C15.layout" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="h" />, <see cref="hMode" />, <see cref="layoutTarget" />, <see cref="w" />, <see cref="wMode" />, <see cref="x" />, <see cref="xMode" />, <see cref="y" />, <see cref="yMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ManualLayout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName manualLayout = c + "manualLayout";

        /// <summary>
        /// Represents the c:marker XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dPt" />, <see cref="lineChart" />, <see cref="pivotFmt" />, <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="size" />, <see cref="spPr" />, <see cref="symbol" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Marker, ShowMarker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName marker = c + "marker";

        /// <summary>
        /// Represents the c:max XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="scaling" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MaxAxisValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName max = c + "max";

        /// <summary>
        /// Represents the c:min XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="scaling" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MinAxisValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName min = c + "min";

        /// <summary>
        /// Represents the c:minorGridlines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MinorGridlines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName minorGridlines = c + "minorGridlines";

        /// <summary>
        /// Represents the c:minorTickMark XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MinorTickMark.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName minorTickMark = c + "minorTickMark";

        /// <summary>
        /// Represents the c:minorTimeUnit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dateAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MinorTimeUnit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName minorTimeUnit = c + "minorTimeUnit";

        /// <summary>
        /// Represents the c:minorUnit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dateAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MinorUnit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName minorUnit = c + "minorUnit";

        /// <summary>
        /// Represents the c:minus XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="errBars" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="numLit" />, <see cref="numRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Minus.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName minus = c + "minus";

        /// <summary>
        /// Represents the c:multiLvlStrCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="multiLvlStrRef" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="lvl" />, <see cref="ptCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MultiLevelStringCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName multiLvlStrCache = c + "multiLvlStrCache";

        /// <summary>
        /// Represents the c:multiLvlStrRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cat" />, <see cref="xVal" />, <see cref="C15.cat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="f" />, <see cref="multiLvlStrCache" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MultiLevelStringReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName multiLvlStrRef = c + "multiLvlStrRef";

        /// <summary>
        /// Represents the c:name XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotSource" />, <see cref="trendline" />, <see cref="C15.pivotSource" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotTableName, TrendlineName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName name = c + "name";

        /// <summary>
        /// Represents the c:noEndCap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="errBars" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoEndCap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noEndCap = c + "noEndCap";

        /// <summary>
        /// Represents the c:noMultiLvlLbl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoMultiLevelLabels.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noMultiLvlLbl = c + "noMultiLvlLbl";

        /// <summary>
        /// Represents the c:numCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numRef" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="formatCode" />, <see cref="pt" />, <see cref="ptCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numCache = c + "numCache";

        /// <summary>
        /// Represents the c:numFmt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="dLbl" />, <see cref="dLbls" />, <see cref="serAx" />, <see cref="trendlineLbl" />, <see cref="valAx" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.formatCode" />, <see cref="NoNamespace.sourceLinked" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numFmt = c + "numFmt";

        /// <summary>
        /// Represents the c:numLit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bubbleSize" />, <see cref="cat" />, <see cref="minus" />, <see cref="plus" />, <see cref="val" />, <see cref="xVal" />, <see cref="yVal" />, <see cref="C15.cat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="formatCode" />, <see cref="pt" />, <see cref="ptCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberLiteral.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numLit = c + "numLit";

        /// <summary>
        /// Represents the c:numRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bubbleSize" />, <see cref="cat" />, <see cref="minus" />, <see cref="plus" />, <see cref="val" />, <see cref="xVal" />, <see cref="yVal" />, <see cref="C15.cat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="f" />, <see cref="numCache" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numRef = c + "numRef";

        /// <summary>
        /// Represents the c:oddFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OddFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oddFooter = c + "oddFooter";

        /// <summary>
        /// Represents the c:oddHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OddHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oddHeader = c + "oddHeader";

        /// <summary>
        /// Represents the c:ofPieChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="custSplit" />, <see cref="dLbls" />, <see cref="extLst" />, <see cref="gapWidth" />, <see cref="ofPieType" />, <see cref="secondPieSize" />, <see cref="ser" />, <see cref="serLines" />, <see cref="splitPos" />, <see cref="splitType" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfPieChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ofPieChart = c + "ofPieChart";

        /// <summary>
        /// Represents the c:ofPieType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ofPieChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfPieType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ofPieType = c + "ofPieType";

        /// <summary>
        /// Represents the c:order XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ser" />, <see cref="trendline" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Order, PolynomialOrder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName order = c + "order";

        /// <summary>
        /// Represents the c:orientation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="scaling" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Orientation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName orientation = c + "orientation";

        /// <summary>
        /// Represents the c:overlap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="barChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Overlap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName overlap = c + "overlap";

        /// <summary>
        /// Represents the c:overlay XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="legend" />, <see cref="title" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Overlay.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName overlay = c + "overlay";

        /// <summary>
        /// Represents the c:pageMargins XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="printSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.b" />, <see cref="NoNamespace.footer" />, <see cref="NoNamespace.header" />, <see cref="NoNamespace.l" />, <see cref="NoNamespace.r" />, <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageMargins.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageMargins = c + "pageMargins";

        /// <summary>
        /// Represents the c:pageSetup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="printSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.blackAndWhite" />, <see cref="NoNamespace.copies" />, <see cref="NoNamespace.draft" />, <see cref="NoNamespace.firstPageNumber" />, <see cref="NoNamespace.horizontalDpi" />, <see cref="NoNamespace.orientation" />, <see cref="NoNamespace.paperSize" />, <see cref="NoNamespace.useFirstPageNumber" />, <see cref="NoNamespace.verticalDpi" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageSetup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageSetup = c + "pageSetup";

        /// <summary>
        /// Represents the c:period XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trendline" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Period.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName period = c + "period";

        /// <summary>
        /// Represents the c:perspective XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="view3D" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Perspective.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName perspective = c + "perspective";

        /// <summary>
        /// Represents the c:pictureFormat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pictureOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PictureFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pictureFormat = c + "pictureFormat";

        /// <summary>
        /// Represents the c:pictureOptions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="backWall" />, <see cref="dPt" />, <see cref="floor" />, <see cref="ser" />, <see cref="sideWall" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="applyToEnd" />, <see cref="applyToFront" />, <see cref="applyToSides" />, <see cref="pictureFormat" />, <see cref="pictureStackUnit" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PictureOptions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pictureOptions = c + "pictureOptions";

        /// <summary>
        /// Represents the c:pictureStackUnit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pictureOptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PictureStackUnit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pictureStackUnit = c + "pictureStackUnit";

        /// <summary>
        /// Represents the c:pie3DChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dLbls" />, <see cref="extLst" />, <see cref="ser" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Pie3DChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pie3DChart = c + "pie3DChart";

        /// <summary>
        /// Represents the c:pieChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dLbls" />, <see cref="extLst" />, <see cref="firstSliceAng" />, <see cref="ser" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PieChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pieChart = c + "pieChart";

        /// <summary>
        /// Represents the c:pivotFmt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotFmts" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dLbl" />, <see cref="extLst" />, <see cref="idx" />, <see cref="marker" />, <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotFmt = c + "pivotFmt";

        /// <summary>
        /// Represents the c:pivotFmts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotFmt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotFormats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotFmts = c + "pivotFmts";

        /// <summary>
        /// Represents the c:pivotSource XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="fmtId" />, <see cref="name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotSource.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotSource = c + "pivotSource";

        /// <summary>
        /// Represents the c:plotArea XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="area3DChart" />, <see cref="areaChart" />, <see cref="bar3DChart" />, <see cref="barChart" />, <see cref="bubbleChart" />, <see cref="catAx" />, <see cref="dateAx" />, <see cref="doughnutChart" />, <see cref="dTable" />, <see cref="extLst" />, <see cref="layout" />, <see cref="line3DChart" />, <see cref="lineChart" />, <see cref="ofPieChart" />, <see cref="pie3DChart" />, <see cref="pieChart" />, <see cref="radarChart" />, <see cref="scatterChart" />, <see cref="serAx" />, <see cref="spPr" />, <see cref="stockChart" />, <see cref="surface3DChart" />, <see cref="surfaceChart" />, <see cref="valAx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlotArea.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName plotArea = c + "plotArea";

        /// <summary>
        /// Represents the c:plotVisOnly XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlotVisibleOnly.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName plotVisOnly = c + "plotVisOnly";

        /// <summary>
        /// Represents the c:plus XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="errBars" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="numLit" />, <see cref="numRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Plus.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName plus = c + "plus";

        /// <summary>
        /// Represents the c:printSettings XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="headerFooter" />, <see cref="legacyDrawingHF" />, <see cref="pageMargins" />, <see cref="pageSetup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintSettings.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName printSettings = c + "printSettings";

        /// <summary>
        /// Represents the c:protection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="chartObject" />, <see cref="data" />, <see cref="formatting" />, <see cref="selection" />, <see cref="userInterface" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Protection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName protection = c + "protection";

        /// <summary>
        /// Represents the c:pt XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />, <see cref="numCache" />, <see cref="numLit" />, <see cref="strCache" />, <see cref="strLit" />, <see cref="C15.dlblFieldTableCache" />, <see cref="C15.dlblRangeCache" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="v" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.formatCode" />, <see cref="NoNamespace.idx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumericPoint, StringPoint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pt = c + "pt";

        /// <summary>
        /// Represents the c:ptCount XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="multiLvlStrCache" />, <see cref="numCache" />, <see cref="numLit" />, <see cref="strCache" />, <see cref="strLit" />, <see cref="C15.dlblFieldTableCache" />, <see cref="C15.dlblRangeCache" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PointCount.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ptCount = c + "ptCount";

        /// <summary>
        /// Represents the c:radarChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="dLbls" />, <see cref="extLst" />, <see cref="radarStyle" />, <see cref="ser" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RadarChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName radarChart = c + "radarChart";

        /// <summary>
        /// Represents the c:radarStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="radarChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RadarStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName radarStyle = c + "radarStyle";

        /// <summary>
        /// Represents the c:rAngAx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="view3D" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RightAngleAxes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rAngAx = c + "rAngAx";

        /// <summary>
        /// Represents the c:rich XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tx" />, <see cref="C15.tx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bodyPr" />, <see cref="A.lstStyle" />, <see cref="A.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rich = c + "rich";

        /// <summary>
        /// Represents the c:rotX XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="view3D" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RotateX.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rotX = c + "rotX";

        /// <summary>
        /// Represents the c:rotY XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="view3D" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RotateY.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rotY = c + "rotY";

        /// <summary>
        /// Represents the c:roundedCorners XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RoundedCorners.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName roundedCorners = c + "roundedCorners";

        /// <summary>
        /// Represents the c:scaling XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="logBase" />, <see cref="max" />, <see cref="min" />, <see cref="orientation" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Scaling.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scaling = c + "scaling";

        /// <summary>
        /// Represents the c:scatterChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="dLbls" />, <see cref="extLst" />, <see cref="scatterStyle" />, <see cref="ser" />, <see cref="varyColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScatterChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scatterChart = c + "scatterChart";

        /// <summary>
        /// Represents the c:scatterStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="scatterChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScatterStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scatterStyle = c + "scatterStyle";

        /// <summary>
        /// Represents the c:secondPiePt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="custSplit" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SecondPiePoint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName secondPiePt = c + "secondPiePt";

        /// <summary>
        /// Represents the c:secondPieSize XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ofPieChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SecondPieSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName secondPieSize = c + "secondPieSize";

        /// <summary>
        /// Represents the c:selection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="protection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Selection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName selection = c + "selection";

        /// <summary>
        /// Represents the c:separator XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbl" />, <see cref="dLbls" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Separator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName separator = c + "separator";

        /// <summary>
        /// Represents the c:ser XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="area3DChart" />, <see cref="areaChart" />, <see cref="bar3DChart" />, <see cref="barChart" />, <see cref="bubbleChart" />, <see cref="doughnutChart" />, <see cref="line3DChart" />, <see cref="lineChart" />, <see cref="ofPieChart" />, <see cref="pie3DChart" />, <see cref="pieChart" />, <see cref="radarChart" />, <see cref="scatterChart" />, <see cref="stockChart" />, <see cref="surface3DChart" />, <see cref="surfaceChart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bubble3D" />, <see cref="bubbleSize" />, <see cref="cat" />, <see cref="dLbls" />, <see cref="dPt" />, <see cref="errBars" />, <see cref="explosion" />, <see cref="extLst" />, <see cref="idx" />, <see cref="invertIfNegative" />, <see cref="marker" />, <see cref="order" />, <see cref="pictureOptions" />, <see cref="shape" />, <see cref="smooth" />, <see cref="spPr" />, <see cref="trendline" />, <see cref="tx" />, <see cref="val" />, <see cref="xVal" />, <see cref="yVal" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AreaChartSeries, BarChartSeries, BubbleChartSeries, LineChartSeries, PieChartSeries, RadarChartSeries, ScatterChartSeries, SurfaceChartSeries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ser = c + "ser";

        /// <summary>
        /// Represents the c:serAx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="axPos" />, <see cref="crossAx" />, <see cref="crosses" />, <see cref="crossesAt" />, <see cref="delete" />, <see cref="extLst" />, <see cref="majorGridlines" />, <see cref="majorTickMark" />, <see cref="minorGridlines" />, <see cref="minorTickMark" />, <see cref="numFmt" />, <see cref="scaling" />, <see cref="spPr" />, <see cref="tickLblPos" />, <see cref="tickLblSkip" />, <see cref="tickMarkSkip" />, <see cref="title" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SeriesAxis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName serAx = c + "serAx";

        /// <summary>
        /// Represents the c:serLines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="barChart" />, <see cref="ofPieChart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SeriesLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName serLines = c + "serLines";

        /// <summary>
        /// Represents the c:shape XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bar3DChart" />, <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shape = c + "shape";

        /// <summary>
        /// Represents the c:showBubbleSize XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbl" />, <see cref="dLbls" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowBubbleSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showBubbleSize = c + "showBubbleSize";

        /// <summary>
        /// Represents the c:showCatName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbl" />, <see cref="dLbls" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowCategoryName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showCatName = c + "showCatName";

        /// <summary>
        /// Represents the c:showDLblsOverMax XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowDataLabelsOverMaximum.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showDLblsOverMax = c + "showDLblsOverMax";

        /// <summary>
        /// Represents the c:showHorzBorder XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dTable" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowHorizontalBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showHorzBorder = c + "showHorzBorder";

        /// <summary>
        /// Represents the c:showKeys XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dTable" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowKeys.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showKeys = c + "showKeys";

        /// <summary>
        /// Represents the c:showLeaderLines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbls" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowLeaderLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showLeaderLines = c + "showLeaderLines";

        /// <summary>
        /// Represents the c:showLegendKey XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbl" />, <see cref="dLbls" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowLegendKey.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showLegendKey = c + "showLegendKey";

        /// <summary>
        /// Represents the c:showNegBubbles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bubbleChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowNegativeBubbles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showNegBubbles = c + "showNegBubbles";

        /// <summary>
        /// Represents the c:showOutline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dTable" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowOutlineBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showOutline = c + "showOutline";

        /// <summary>
        /// Represents the c:showPercent XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbl" />, <see cref="dLbls" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowPercent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showPercent = c + "showPercent";

        /// <summary>
        /// Represents the c:showSerName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbl" />, <see cref="dLbls" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowSeriesName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showSerName = c + "showSerName";

        /// <summary>
        /// Represents the c:showVal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dLbl" />, <see cref="dLbls" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showVal = c + "showVal";

        /// <summary>
        /// Represents the c:showVertBorder XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dTable" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowVerticalBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showVertBorder = c + "showVertBorder";

        /// <summary>
        /// Represents the c:sideWall XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pictureOptions" />, <see cref="spPr" />, <see cref="thickness" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SideWall.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sideWall = c + "sideWall";

        /// <summary>
        /// Represents the c:size XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="marker" />, <see cref="C15.marker" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Size.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName size = c + "size";

        /// <summary>
        /// Represents the c:sizeRepresents XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bubbleChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SizeRepresents.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sizeRepresents = c + "sizeRepresents";

        /// <summary>
        /// Represents the c:smooth XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lineChart" />, <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Smooth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName smooth = c + "smooth";

        /// <summary>
        /// Represents the c:splitPos XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ofPieChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SplitPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName splitPos = c + "splitPos";

        /// <summary>
        /// Represents the c:splitType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ofPieChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SplitType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName splitType = c + "splitType";

        /// <summary>
        /// Represents the c:spPr XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="backWall" />, <see cref="bandFmt" />, <see cref="catAx" />, <see cref="chartSpace" />, <see cref="dateAx" />, <see cref="dispUnitsLbl" />, <see cref="dLbl" />, <see cref="dLbls" />, <see cref="downBars" />, <see cref="dPt" />, <see cref="dropLines" />, <see cref="dTable" />, <see cref="errBars" />, <see cref="floor" />, <see cref="hiLowLines" />, <see cref="leaderLines" />, <see cref="legend" />, <see cref="majorGridlines" />, <see cref="marker" />, <see cref="minorGridlines" />, <see cref="pivotFmt" />, <see cref="plotArea" />, <see cref="ser" />, <see cref="serAx" />, <see cref="serLines" />, <see cref="sideWall" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLbl" />, <see cref="upBars" />, <see cref="valAx" />, <see cref="C15.dLbl" />, <see cref="C15.leaderLines" />, <see cref="C15.marker" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartShapeProperties, ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = c + "spPr";

        /// <summary>
        /// Represents the c:stockChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="dLbls" />, <see cref="dropLines" />, <see cref="extLst" />, <see cref="hiLowLines" />, <see cref="ser" />, <see cref="upDownBars" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StockChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stockChart = c + "stockChart";

        /// <summary>
        /// Represents the c:strCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="strRef" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pt" />, <see cref="ptCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StringCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strCache = c + "strCache";

        /// <summary>
        /// Represents the c:strLit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cat" />, <see cref="tx" />, <see cref="xVal" />, <see cref="C15.cat" />, <see cref="C15.tx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pt" />, <see cref="ptCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StringLiteral.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strLit = c + "strLit";

        /// <summary>
        /// Represents the c:strRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cat" />, <see cref="tx" />, <see cref="xVal" />, <see cref="C15.cat" />, <see cref="C15.tx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="f" />, <see cref="strCache" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StringReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strRef = c + "strRef";

        /// <summary>
        /// Represents the c:style XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Style.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName style = c + "style";

        /// <summary>
        /// Represents the c:surface3DChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="bandFmts" />, <see cref="extLst" />, <see cref="ser" />, <see cref="varyColors" />, <see cref="wireframe" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Surface3DChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName surface3DChart = c + "surface3DChart";

        /// <summary>
        /// Represents the c:surfaceChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="bandFmts" />, <see cref="extLst" />, <see cref="ser" />, <see cref="wireframe" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SurfaceChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName surfaceChart = c + "surfaceChart";

        /// <summary>
        /// Represents the c:symbol XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="marker" />, <see cref="C15.marker" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Symbol.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName symbol = c + "symbol";

        /// <summary>
        /// Represents the c:thickness XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="backWall" />, <see cref="floor" />, <see cref="sideWall" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Thickness.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName thickness = c + "thickness";

        /// <summary>
        /// Represents the c:tickLblPos XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TickLabelPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tickLblPos = c + "tickLblPos";

        /// <summary>
        /// Represents the c:tickLblSkip XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="serAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TickLabelSkip.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tickLblSkip = c + "tickLblSkip";

        /// <summary>
        /// Represents the c:tickMarkSkip XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="serAx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TickMarkSkip.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tickMarkSkip = c + "tickMarkSkip";

        /// <summary>
        /// Represents the c:title XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="chart" />, <see cref="dateAx" />, <see cref="serAx" />, <see cref="valAx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="layout" />, <see cref="overlay" />, <see cref="spPr" />, <see cref="tx" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Title.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName title = c + "title";

        /// <summary>
        /// Represents the c:trendline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="backward" />, <see cref="dispEq" />, <see cref="dispRSqr" />, <see cref="extLst" />, <see cref="forward" />, <see cref="intercept" />, <see cref="name" />, <see cref="order" />, <see cref="period" />, <see cref="spPr" />, <see cref="trendlineLbl" />, <see cref="trendlineType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Trendline.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trendline = c + "trendline";

        /// <summary>
        /// Represents the c:trendlineLbl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trendline" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="layout" />, <see cref="numFmt" />, <see cref="spPr" />, <see cref="tx" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TrendlineLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trendlineLbl = c + "trendlineLbl";

        /// <summary>
        /// Represents the c:trendlineType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trendline" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TrendlineType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trendlineType = c + "trendlineType";

        /// <summary>
        /// Represents the c:tx XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dispUnitsLbl" />, <see cref="dLbl" />, <see cref="ser" />, <see cref="title" />, <see cref="trendlineLbl" />, <see cref="C15.dLbl" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rich" />, <see cref="strLit" />, <see cref="strRef" />, <see cref="v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartText, SeriesText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tx = c + "tx";

        /// <summary>
        /// Represents the c:txPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catAx" />, <see cref="chartSpace" />, <see cref="dateAx" />, <see cref="dispUnitsLbl" />, <see cref="dLbl" />, <see cref="dLbls" />, <see cref="dTable" />, <see cref="legend" />, <see cref="legendEntry" />, <see cref="serAx" />, <see cref="title" />, <see cref="trendlineLbl" />, <see cref="valAx" />, <see cref="C15.dLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bodyPr" />, <see cref="A.lstStyle" />, <see cref="A.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txPr = c + "txPr";

        /// <summary>
        /// Represents the c:upBars XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="upDownBars" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UpBars.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName upBars = c + "upBars";

        /// <summary>
        /// Represents the c:upDownBars XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lineChart" />, <see cref="stockChart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="downBars" />, <see cref="extLst" />, <see cref="gapWidth" />, <see cref="upBars" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UpDownBars.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName upDownBars = c + "upDownBars";

        /// <summary>
        /// Represents the c:userInterface XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="protection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UserInterface.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName userInterface = c + "userInterface";

        /// <summary>
        /// Represents the c:userShapes XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="CDR.absSizeAnchor" />, <see cref="CDR.relSizeAnchor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UserShapes, UserShapesReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName userShapes = c + "userShapes";

        /// <summary>
        /// Represents the c:v XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pt" />, <see cref="tx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumericValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName v = c + "v";

        /// <summary>
        /// Represents the c:val XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="errBars" />, <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="numLit" />, <see cref="numRef" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ErrorBarValue, Values.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName val = c + "val";

        /// <summary>
        /// Represents the c:valAx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axId" />, <see cref="axPos" />, <see cref="crossAx" />, <see cref="crossBetween" />, <see cref="crosses" />, <see cref="crossesAt" />, <see cref="delete" />, <see cref="dispUnits" />, <see cref="extLst" />, <see cref="majorGridlines" />, <see cref="majorTickMark" />, <see cref="majorUnit" />, <see cref="minorGridlines" />, <see cref="minorTickMark" />, <see cref="minorUnit" />, <see cref="numFmt" />, <see cref="scaling" />, <see cref="spPr" />, <see cref="tickLblPos" />, <see cref="title" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ValueAxis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName valAx = c + "valAx";

        /// <summary>
        /// Represents the c:varyColors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="area3DChart" />, <see cref="areaChart" />, <see cref="bar3DChart" />, <see cref="barChart" />, <see cref="bubbleChart" />, <see cref="doughnutChart" />, <see cref="line3DChart" />, <see cref="lineChart" />, <see cref="ofPieChart" />, <see cref="pie3DChart" />, <see cref="pieChart" />, <see cref="radarChart" />, <see cref="scatterChart" />, <see cref="surface3DChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VaryColors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName varyColors = c + "varyColors";

        /// <summary>
        /// Represents the c:view3D XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="depthPercent" />, <see cref="extLst" />, <see cref="hPercent" />, <see cref="perspective" />, <see cref="rAngAx" />, <see cref="rotX" />, <see cref="rotY" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: View3D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName view3D = c + "view3D";

        /// <summary>
        /// Represents the c:w XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="manualLayout" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Width.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName w = c + "w";

        /// <summary>
        /// Represents the c:wireframe XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="surface3DChart" />, <see cref="surfaceChart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Wireframe.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wireframe = c + "wireframe";

        /// <summary>
        /// Represents the c:wMode XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="manualLayout" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WidthMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wMode = c + "wMode";

        /// <summary>
        /// Represents the c:x XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="manualLayout" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Left.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName x = c + "x";

        /// <summary>
        /// Represents the c:xMode XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="manualLayout" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LeftMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xMode = c + "xMode";

        /// <summary>
        /// Represents the c:xVal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="multiLvlStrRef" />, <see cref="numLit" />, <see cref="numRef" />, <see cref="strLit" />, <see cref="strRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: XValues.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xVal = c + "xVal";

        /// <summary>
        /// Represents the c:y XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="manualLayout" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Top.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName y = c + "y";

        /// <summary>
        /// Represents the c:yMode XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="manualLayout" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName yMode = c + "yMode";

        /// <summary>
        /// Represents the c:yVal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ser" />, <see cref="C15.ser" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="numLit" />, <see cref="numRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: YValues.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName yVal = c + "yVal";
    }
}
