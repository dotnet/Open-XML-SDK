// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:c15="http://schemas.microsoft.com/office/drawing/2012/chart" namespace.
    /// </summary>
    public static class C15
    {
        /// <summary>
        /// Defines the XML namespace associated with the c15 prefix.
        /// </summary>
        public static readonly XNamespace c15 = "http://schemas.microsoft.com/office/drawing/2012/chart";

        /// <summary>
        /// Represents the c15:autoCat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoGeneneratedCategories.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoCat = c15 + "autoCat";

        /// <summary>
        /// Represents the c15:bubble3D XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="categoryFilterException" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Bubble3D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bubble3D = c15 + "bubble3D";

        /// <summary>
        /// Represents the c15:cat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="filteredCategoryTitle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.multiLvlStrRef" />, <see cref="C.numLit" />, <see cref="C.numRef" />, <see cref="C.strLit" />, <see cref="C.strRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AxisDataSourceType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cat = c15 + "cat";

        /// <summary>
        /// Represents the c15:categoryFilterException XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="categoryFilterExceptions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bubble3D" />, <see cref="dLbl" />, <see cref="explosion" />, <see cref="invertIfNegative" />, <see cref="marker" />, <see cref="spPr" />, <see cref="sqref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CategoryFilterException.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName categoryFilterException = c15 + "categoryFilterException";

        /// <summary>
        /// Represents the c15:categoryFilterExceptions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="categoryFilterException" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CategoryFilterExceptions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName categoryFilterExceptions = c15 + "categoryFilterExceptions";

        /// <summary>
        /// Represents the c15:datalabelsRange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dlblRangeCache" />, <see cref="f" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabelsRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName datalabelsRange = c15 + "datalabelsRange";

        /// <summary>
        /// Represents the c15:dLbl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="categoryFilterException" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.delete" />, <see cref="C.dLblPos" />, <see cref="C.extLst" />, <see cref="C.idx" />, <see cref="C.layout" />, <see cref="C.numFmt" />, <see cref="C.separator" />, <see cref="C.showBubbleSize" />, <see cref="C.showCatName" />, <see cref="C.showLegendKey" />, <see cref="C.showPercent" />, <see cref="C.showSerName" />, <see cref="C.showVal" />, <see cref="C.spPr" />, <see cref="C.tx" />, <see cref="C.txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dLbl = c15 + "dLbl";

        /// <summary>
        /// Represents the c15:dlblFieldTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dlblFTEntry" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabelFieldTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dlblFieldTable = c15 + "dlblFieldTable";

        /// <summary>
        /// Represents the c15:dlblFieldTableCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dlblFTEntry" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.extLst" />, <see cref="C.pt" />, <see cref="C.ptCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabelFieldTableCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dlblFieldTableCache = c15 + "dlblFieldTableCache";

        /// <summary>
        /// Represents the c15:dlblFTEntry XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dlblFieldTable" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dlblFieldTableCache" />, <see cref="f" />, <see cref="txfldGUID" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabelFieldTableEntry.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dlblFTEntry = c15 + "dlblFTEntry";

        /// <summary>
        /// Represents the c15:dlblRangeCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="datalabelsRange" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.extLst" />, <see cref="C.pt" />, <see cref="C.ptCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabelsRangeChache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dlblRangeCache = c15 + "dlblRangeCache";

        /// <summary>
        /// Represents the c15:explosion XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="categoryFilterException" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Explosion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName explosion = c15 + "explosion";

        /// <summary>
        /// Represents the c15:f XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="datalabelsRange" />, <see cref="dlblFTEntry" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName f = c15 + "f";

        /// <summary>
        /// Represents the c15:filteredAreaSeries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ser" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilteredAreaSeries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filteredAreaSeries = c15 + "filteredAreaSeries";

        /// <summary>
        /// Represents the c15:filteredBarSeries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ser" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilteredBarSeries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filteredBarSeries = c15 + "filteredBarSeries";

        /// <summary>
        /// Represents the c15:filteredBubbleSeries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ser" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilteredBubbleSeries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filteredBubbleSeries = c15 + "filteredBubbleSeries";

        /// <summary>
        /// Represents the c15:filteredCategoryTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cat" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilteredCategoryTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filteredCategoryTitle = c15 + "filteredCategoryTitle";

        /// <summary>
        /// Represents the c15:filteredLineSeries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ser" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilteredLineSeriesExtension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filteredLineSeries = c15 + "filteredLineSeries";

        /// <summary>
        /// Represents the c15:filteredPieSeries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ser" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilteredPieSeries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filteredPieSeries = c15 + "filteredPieSeries";

        /// <summary>
        /// Represents the c15:filteredRadarSeries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ser" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilteredRadarSeries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filteredRadarSeries = c15 + "filteredRadarSeries";

        /// <summary>
        /// Represents the c15:filteredScatterSeries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ser" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilteredScatterSeries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filteredScatterSeries = c15 + "filteredScatterSeries";

        /// <summary>
        /// Represents the c15:filteredSeriesTitle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilteredSeriesTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filteredSeriesTitle = c15 + "filteredSeriesTitle";

        /// <summary>
        /// Represents the c15:filteredSurfaceSeries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ser" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilteredSurfaceSeries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filteredSurfaceSeries = c15 + "filteredSurfaceSeries";

        /// <summary>
        /// Represents the c15:formulaRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sqref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormulaReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formulaRef = c15 + "formulaRef";

        /// <summary>
        /// Represents the c15:fullRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sqref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FullReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fullRef = c15 + "fullRef";

        /// <summary>
        /// Represents the c15:invertIfNegative XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="categoryFilterException" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InvertIfNegativeBoolean.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName invertIfNegative = c15 + "invertIfNegative";

        /// <summary>
        /// Represents the c15:layout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.extLst" />, <see cref="C.manualLayout" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Layout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layout = c15 + "layout";

        /// <summary>
        /// Represents the c15:leaderLines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LeaderLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName leaderLines = c15 + "leaderLines";

        /// <summary>
        /// Represents the c15:levelRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sqref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LevelReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName levelRef = c15 + "levelRef";

        /// <summary>
        /// Represents the c15:marker XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="categoryFilterException" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.extLst" />, <see cref="C.size" />, <see cref="C.spPr" />, <see cref="C.symbol" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Marker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName marker = c15 + "marker";

        /// <summary>
        /// Represents the c15:numFmt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.formatCode" />, <see cref="NoNamespace.sourceLinked" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numFmt = c15 + "numFmt";

        /// <summary>
        /// Represents the c15:pivotSource XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.extLst" />, <see cref="C.fmtId" />, <see cref="C.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotSource.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotSource = c15 + "pivotSource";

        /// <summary>
        /// Represents the c15:ser XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="filteredAreaSeries" />, <see cref="filteredBarSeries" />, <see cref="filteredBubbleSeries" />, <see cref="filteredLineSeries" />, <see cref="filteredPieSeries" />, <see cref="filteredRadarSeries" />, <see cref="filteredScatterSeries" />, <see cref="filteredSurfaceSeries" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.bubble3D" />, <see cref="C.bubbleSize" />, <see cref="C.cat" />, <see cref="C.dLbls" />, <see cref="C.dPt" />, <see cref="C.errBars" />, <see cref="C.explosion" />, <see cref="C.extLst" />, <see cref="C.idx" />, <see cref="C.invertIfNegative" />, <see cref="C.marker" />, <see cref="C.order" />, <see cref="C.pictureOptions" />, <see cref="C.shape" />, <see cref="C.smooth" />, <see cref="C.spPr" />, <see cref="C.trendline" />, <see cref="C.tx" />, <see cref="C.val" />, <see cref="C.xVal" />, <see cref="C.yVal" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AreaChartSeries, BarChartSeries, BubbleChartSeries, LineChartSeries, PieChartSeries, RadarChartSeries, ScatterChartSeries, SurfaceChartSeries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ser = c15 + "ser";

        /// <summary>
        /// Represents the c15:showDataLabelsRange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowDataLabelsRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showDataLabelsRange = c15 + "showDataLabelsRange";

        /// <summary>
        /// Represents the c15:showLeaderLines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowLeaderLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showLeaderLines = c15 + "showLeaderLines";

        /// <summary>
        /// Represents the c15:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />, <see cref="categoryFilterException" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = c15 + "spPr";

        /// <summary>
        /// Represents the c15:sqref XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="categoryFilterException" />, <see cref="formulaRef" />, <see cref="fullRef" />, <see cref="levelRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SequenceOfReferences.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sqref = c15 + "sqref";

        /// <summary>
        /// Represents the c15:tx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />, <see cref="filteredSeriesTitle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.rich" />, <see cref="C.strLit" />, <see cref="C.strRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tx = c15 + "tx";

        /// <summary>
        /// Represents the c15:txfldGUID XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dlblFTEntry" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextFieldGuid.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txfldGUID = c15 + "txfldGUID";

        /// <summary>
        /// Represents the c15:xForSave XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExceptionForSave.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xForSave = c15 + "xForSave";
    }
}
