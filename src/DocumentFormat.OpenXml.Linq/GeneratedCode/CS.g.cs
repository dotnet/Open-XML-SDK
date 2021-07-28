// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:cs="http://schemas.microsoft.com/office/drawing/2012/chartStyle" namespace.
    /// </summary>
    public static class CS
    {
        /// <summary>
        /// Defines the XML namespace associated with the cs prefix.
        /// </summary>
        public static readonly XNamespace cs = "http://schemas.microsoft.com/office/drawing/2012/chartStyle";

        /// <summary>
        /// Represents the cs:axisTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AxisTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName axisTitle = cs + "axisTitle";

        /// <summary>
        /// Represents the cs:bodyPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axisTitle" />, <see cref="categoryAxis" />, <see cref="chartArea" />, <see cref="dataLabel" />, <see cref="dataLabelCallout" />, <see cref="dataPoint" />, <see cref="dataPoint3D" />, <see cref="dataPointLine" />, <see cref="dataPointMarker" />, <see cref="dataPointWireframe" />, <see cref="dataTable" />, <see cref="downBar" />, <see cref="dropLine" />, <see cref="errorBar" />, <see cref="floor" />, <see cref="gridlineMajor" />, <see cref="gridlineMinor" />, <see cref="hiLoLine" />, <see cref="leaderLine" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="plotArea3D" />, <see cref="seriesAxis" />, <see cref="seriesLine" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLabel" />, <see cref="upBar" />, <see cref="valueAxis" />, <see cref="wall" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.flatTx" />, <see cref="A.noAutofit" />, <see cref="A.normAutofit" />, <see cref="A.prstTxWarp" />, <see cref="A.scene3d" />, <see cref="A.sp3d" />, <see cref="A.spAutoFit" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.anchor" />, <see cref="NoNamespace.anchorCtr" />, <see cref="NoNamespace.bIns" />, <see cref="NoNamespace.compatLnSpc" />, <see cref="NoNamespace.forceAA" />, <see cref="NoNamespace.fromWordArt" />, <see cref="NoNamespace.horzOverflow" />, <see cref="NoNamespace.lIns" />, <see cref="NoNamespace.numCol" />, <see cref="NoNamespace.rIns" />, <see cref="NoNamespace.rot" />, <see cref="NoNamespace.rtlCol" />, <see cref="NoNamespace.spcCol" />, <see cref="NoNamespace.spcFirstLastPara" />, <see cref="NoNamespace.tIns" />, <see cref="NoNamespace.upright" />, <see cref="NoNamespace.vert" />, <see cref="NoNamespace.vertOverflow" />, <see cref="NoNamespace.wrap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBodyProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bodyPr = cs + "bodyPr";

        /// <summary>
        /// Represents the cs:categoryAxis XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CategoryAxis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName categoryAxis = cs + "categoryAxis";

        /// <summary>
        /// Represents the cs:chartArea XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartArea.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartArea = cs + "chartArea";

        /// <summary>
        /// Represents the cs:chartStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axisTitle" />, <see cref="categoryAxis" />, <see cref="chartArea" />, <see cref="dataLabel" />, <see cref="dataLabelCallout" />, <see cref="dataPoint" />, <see cref="dataPoint3D" />, <see cref="dataPointLine" />, <see cref="dataPointMarker" />, <see cref="dataPointMarkerLayout" />, <see cref="dataPointWireframe" />, <see cref="dataTable" />, <see cref="downBar" />, <see cref="dropLine" />, <see cref="errorBar" />, <see cref="extLst" />, <see cref="floor" />, <see cref="gridlineMajor" />, <see cref="gridlineMinor" />, <see cref="hiLoLine" />, <see cref="leaderLine" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="plotArea3D" />, <see cref="seriesAxis" />, <see cref="seriesLine" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLabel" />, <see cref="upBar" />, <see cref="valueAxis" />, <see cref="wall" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartStyle = cs + "chartStyle";

        /// <summary>
        /// Represents the cs:colorStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />, <see cref="extLst" />, <see cref="variation" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.meth" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorStyle = cs + "colorStyle";

        /// <summary>
        /// Represents the cs:dataLabel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataLabel = cs + "dataLabel";

        /// <summary>
        /// Represents the cs:dataLabelCallout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabelCallout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataLabelCallout = cs + "dataLabelCallout";

        /// <summary>
        /// Represents the cs:dataPoint XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataPoint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataPoint = cs + "dataPoint";

        /// <summary>
        /// Represents the cs:dataPoint3D XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataPoint3D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataPoint3D = cs + "dataPoint3D";

        /// <summary>
        /// Represents the cs:dataPointLine XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataPointLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataPointLine = cs + "dataPointLine";

        /// <summary>
        /// Represents the cs:dataPointMarker XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataPointMarker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataPointMarker = cs + "dataPointMarker";

        /// <summary>
        /// Represents the cs:dataPointMarkerLayout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.size" />, <see cref="NoNamespace.symbol" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MarkerLayoutProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataPointMarkerLayout = cs + "dataPointMarkerLayout";

        /// <summary>
        /// Represents the cs:dataPointWireframe XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataPointWireframe.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataPointWireframe = cs + "dataPointWireframe";

        /// <summary>
        /// Represents the cs:dataTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataTableStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataTable = cs + "dataTable";

        /// <summary>
        /// Represents the cs:defRPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axisTitle" />, <see cref="categoryAxis" />, <see cref="chartArea" />, <see cref="dataLabel" />, <see cref="dataLabelCallout" />, <see cref="dataPoint" />, <see cref="dataPoint3D" />, <see cref="dataPointLine" />, <see cref="dataPointMarker" />, <see cref="dataPointWireframe" />, <see cref="dataTable" />, <see cref="downBar" />, <see cref="dropLine" />, <see cref="errorBar" />, <see cref="floor" />, <see cref="gridlineMajor" />, <see cref="gridlineMinor" />, <see cref="hiLoLine" />, <see cref="leaderLine" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="plotArea3D" />, <see cref="seriesAxis" />, <see cref="seriesLine" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLabel" />, <see cref="upBar" />, <see cref="valueAxis" />, <see cref="wall" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.cs" />, <see cref="A.ea" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.highlight" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkMouseOver" />, <see cref="A.latin" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.rtl" />, <see cref="A.solidFill" />, <see cref="A.sym" />, <see cref="A.uFill" />, <see cref="A.uFillTx" />, <see cref="A.uLn" />, <see cref="A.uLnTx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.altLang" />, <see cref="NoNamespace.b" />, <see cref="NoNamespace.baseline" />, <see cref="NoNamespace.bmk" />, <see cref="NoNamespace.cap" />, <see cref="NoNamespace.dirty" />, <see cref="NoNamespace.err" />, <see cref="NoNamespace.i" />, <see cref="NoNamespace.kern" />, <see cref="NoNamespace.kumimoji" />, <see cref="NoNamespace.lang" />, <see cref="NoNamespace.noProof" />, <see cref="NoNamespace.normalizeH" />, <see cref="NoNamespace.smtClean" />, <see cref="NoNamespace.smtId" />, <see cref="NoNamespace.spc" />, <see cref="NoNamespace.strike" />, <see cref="NoNamespace.sz" />, <see cref="NoNamespace.u" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextCharacterPropertiesType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defRPr = cs + "defRPr";

        /// <summary>
        /// Represents the cs:downBar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DownBar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName downBar = cs + "downBar";

        /// <summary>
        /// Represents the cs:dropLine XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropLine = cs + "dropLine";

        /// <summary>
        /// Represents the cs:effectRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axisTitle" />, <see cref="categoryAxis" />, <see cref="chartArea" />, <see cref="dataLabel" />, <see cref="dataLabelCallout" />, <see cref="dataPoint" />, <see cref="dataPoint3D" />, <see cref="dataPointLine" />, <see cref="dataPointMarker" />, <see cref="dataPointWireframe" />, <see cref="dataTable" />, <see cref="downBar" />, <see cref="dropLine" />, <see cref="errorBar" />, <see cref="floor" />, <see cref="gridlineMajor" />, <see cref="gridlineMinor" />, <see cref="hiLoLine" />, <see cref="leaderLine" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="plotArea3D" />, <see cref="seriesAxis" />, <see cref="seriesLine" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLabel" />, <see cref="upBar" />, <see cref="valueAxis" />, <see cref="wall" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />, <see cref="styleClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />, <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EffectReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName effectRef = cs + "effectRef";

        /// <summary>
        /// Represents the cs:errorBar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ErrorBar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName errorBar = cs + "errorBar";

        /// <summary>
        /// Represents the cs:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axisTitle" />, <see cref="categoryAxis" />, <see cref="chartArea" />, <see cref="chartStyle" />, <see cref="colorStyle" />, <see cref="dataLabel" />, <see cref="dataLabelCallout" />, <see cref="dataPoint" />, <see cref="dataPoint3D" />, <see cref="dataPointLine" />, <see cref="dataPointMarker" />, <see cref="dataPointWireframe" />, <see cref="dataTable" />, <see cref="downBar" />, <see cref="dropLine" />, <see cref="errorBar" />, <see cref="floor" />, <see cref="gridlineMajor" />, <see cref="gridlineMinor" />, <see cref="hiLoLine" />, <see cref="leaderLine" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="plotArea3D" />, <see cref="seriesAxis" />, <see cref="seriesLine" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLabel" />, <see cref="upBar" />, <see cref="valueAxis" />, <see cref="wall" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = cs + "extLst";

        /// <summary>
        /// Represents the cs:fillRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axisTitle" />, <see cref="categoryAxis" />, <see cref="chartArea" />, <see cref="dataLabel" />, <see cref="dataLabelCallout" />, <see cref="dataPoint" />, <see cref="dataPoint3D" />, <see cref="dataPointLine" />, <see cref="dataPointMarker" />, <see cref="dataPointWireframe" />, <see cref="dataTable" />, <see cref="downBar" />, <see cref="dropLine" />, <see cref="errorBar" />, <see cref="floor" />, <see cref="gridlineMajor" />, <see cref="gridlineMinor" />, <see cref="hiLoLine" />, <see cref="leaderLine" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="plotArea3D" />, <see cref="seriesAxis" />, <see cref="seriesLine" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLabel" />, <see cref="upBar" />, <see cref="valueAxis" />, <see cref="wall" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />, <see cref="styleClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />, <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FillReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fillRef = cs + "fillRef";

        /// <summary>
        /// Represents the cs:floor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Floor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName floor = cs + "floor";

        /// <summary>
        /// Represents the cs:fontRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axisTitle" />, <see cref="categoryAxis" />, <see cref="chartArea" />, <see cref="dataLabel" />, <see cref="dataLabelCallout" />, <see cref="dataPoint" />, <see cref="dataPoint3D" />, <see cref="dataPointLine" />, <see cref="dataPointMarker" />, <see cref="dataPointWireframe" />, <see cref="dataTable" />, <see cref="downBar" />, <see cref="dropLine" />, <see cref="errorBar" />, <see cref="floor" />, <see cref="gridlineMajor" />, <see cref="gridlineMinor" />, <see cref="hiLoLine" />, <see cref="leaderLine" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="plotArea3D" />, <see cref="seriesAxis" />, <see cref="seriesLine" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLabel" />, <see cref="upBar" />, <see cref="valueAxis" />, <see cref="wall" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />, <see cref="styleClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />, <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fontRef = cs + "fontRef";

        /// <summary>
        /// Represents the cs:gridlineMajor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GridlineMajor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gridlineMajor = cs + "gridlineMajor";

        /// <summary>
        /// Represents the cs:gridlineMinor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GridlineMinor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gridlineMinor = cs + "gridlineMinor";

        /// <summary>
        /// Represents the cs:hiLoLine XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HiLoLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hiLoLine = cs + "hiLoLine";

        /// <summary>
        /// Represents the cs:leaderLine XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LeaderLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName leaderLine = cs + "leaderLine";

        /// <summary>
        /// Represents the cs:legend XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LegendStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legend = cs + "legend";

        /// <summary>
        /// Represents the cs:lineWidthScale XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axisTitle" />, <see cref="categoryAxis" />, <see cref="chartArea" />, <see cref="dataLabel" />, <see cref="dataLabelCallout" />, <see cref="dataPoint" />, <see cref="dataPoint3D" />, <see cref="dataPointLine" />, <see cref="dataPointMarker" />, <see cref="dataPointWireframe" />, <see cref="dataTable" />, <see cref="downBar" />, <see cref="dropLine" />, <see cref="errorBar" />, <see cref="floor" />, <see cref="gridlineMajor" />, <see cref="gridlineMinor" />, <see cref="hiLoLine" />, <see cref="leaderLine" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="plotArea3D" />, <see cref="seriesAxis" />, <see cref="seriesLine" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLabel" />, <see cref="upBar" />, <see cref="valueAxis" />, <see cref="wall" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineWidthScale.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lineWidthScale = cs + "lineWidthScale";

        /// <summary>
        /// Represents the cs:lnRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axisTitle" />, <see cref="categoryAxis" />, <see cref="chartArea" />, <see cref="dataLabel" />, <see cref="dataLabelCallout" />, <see cref="dataPoint" />, <see cref="dataPoint3D" />, <see cref="dataPointLine" />, <see cref="dataPointMarker" />, <see cref="dataPointWireframe" />, <see cref="dataTable" />, <see cref="downBar" />, <see cref="dropLine" />, <see cref="errorBar" />, <see cref="floor" />, <see cref="gridlineMajor" />, <see cref="gridlineMinor" />, <see cref="hiLoLine" />, <see cref="leaderLine" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="plotArea3D" />, <see cref="seriesAxis" />, <see cref="seriesLine" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLabel" />, <see cref="upBar" />, <see cref="valueAxis" />, <see cref="wall" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />, <see cref="styleClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />, <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lnRef = cs + "lnRef";

        /// <summary>
        /// Represents the cs:plotArea XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlotArea.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName plotArea = cs + "plotArea";

        /// <summary>
        /// Represents the cs:plotArea3D XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlotArea3D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName plotArea3D = cs + "plotArea3D";

        /// <summary>
        /// Represents the cs:seriesAxis XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SeriesAxis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName seriesAxis = cs + "seriesAxis";

        /// <summary>
        /// Represents the cs:seriesLine XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SeriesLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName seriesLine = cs + "seriesLine";

        /// <summary>
        /// Represents the cs:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axisTitle" />, <see cref="categoryAxis" />, <see cref="chartArea" />, <see cref="dataLabel" />, <see cref="dataLabelCallout" />, <see cref="dataPoint" />, <see cref="dataPoint3D" />, <see cref="dataPointLine" />, <see cref="dataPointMarker" />, <see cref="dataPointWireframe" />, <see cref="dataTable" />, <see cref="downBar" />, <see cref="dropLine" />, <see cref="errorBar" />, <see cref="floor" />, <see cref="gridlineMajor" />, <see cref="gridlineMinor" />, <see cref="hiLoLine" />, <see cref="leaderLine" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="plotArea3D" />, <see cref="seriesAxis" />, <see cref="seriesLine" />, <see cref="title" />, <see cref="trendline" />, <see cref="trendlineLabel" />, <see cref="upBar" />, <see cref="valueAxis" />, <see cref="wall" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = cs + "spPr";

        /// <summary>
        /// Represents the cs:styleClr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="effectRef" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lnRef" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.alpha" />, <see cref="A.alphaMod" />, <see cref="A.alphaOff" />, <see cref="A.blue" />, <see cref="A.blueMod" />, <see cref="A.blueOff" />, <see cref="A.comp" />, <see cref="A.gamma" />, <see cref="A.gray" />, <see cref="A.green" />, <see cref="A.greenMod" />, <see cref="A.greenOff" />, <see cref="A.hue" />, <see cref="A.hueMod" />, <see cref="A.hueOff" />, <see cref="A.inv" />, <see cref="A.invGamma" />, <see cref="A.lum" />, <see cref="A.lumMod" />, <see cref="A.lumOff" />, <see cref="A.red" />, <see cref="A.redMod" />, <see cref="A.redOff" />, <see cref="A.sat" />, <see cref="A.satMod" />, <see cref="A.satOff" />, <see cref="A.shade" />, <see cref="A.tint" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StyleColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleClr = cs + "styleClr";

        /// <summary>
        /// Represents the cs:title XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TitleStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName title = cs + "title";

        /// <summary>
        /// Represents the cs:trendline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TrendlineStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trendline = cs + "trendline";

        /// <summary>
        /// Represents the cs:trendlineLabel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TrendlineLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trendlineLabel = cs + "trendlineLabel";

        /// <summary>
        /// Represents the cs:upBar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UpBar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName upBar = cs + "upBar";

        /// <summary>
        /// Represents the cs:valueAxis XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ValueAxis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName valueAxis = cs + "valueAxis";

        /// <summary>
        /// Represents the cs:variation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colorStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.alpha" />, <see cref="A.alphaMod" />, <see cref="A.alphaOff" />, <see cref="A.blue" />, <see cref="A.blueMod" />, <see cref="A.blueOff" />, <see cref="A.comp" />, <see cref="A.gamma" />, <see cref="A.gray" />, <see cref="A.green" />, <see cref="A.greenMod" />, <see cref="A.greenOff" />, <see cref="A.hue" />, <see cref="A.hueMod" />, <see cref="A.hueOff" />, <see cref="A.inv" />, <see cref="A.invGamma" />, <see cref="A.lum" />, <see cref="A.lumMod" />, <see cref="A.lumOff" />, <see cref="A.red" />, <see cref="A.redMod" />, <see cref="A.redOff" />, <see cref="A.sat" />, <see cref="A.satMod" />, <see cref="A.satOff" />, <see cref="A.shade" />, <see cref="A.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorStyleVariation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName variation = cs + "variation";

        /// <summary>
        /// Represents the cs:wall XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="defRPr" />, <see cref="effectRef" />, <see cref="extLst" />, <see cref="fillRef" />, <see cref="fontRef" />, <see cref="lineWidthScale" />, <see cref="lnRef" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mods" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Wall.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wall = cs + "wall";
    }
}
