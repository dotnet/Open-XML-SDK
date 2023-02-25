// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:cx="http://schemas.microsoft.com/office/drawing/2014/chartex" namespace.
    /// </summary>
    public static class CX
    {
        /// <summary>
        /// Defines the XML namespace associated with the cx prefix.
        /// </summary>
        public static readonly XNamespace cx = "http://schemas.microsoft.com/office/drawing/2014/chartex";

        /// <summary>
        /// Represents the cx:address XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoLocation" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.address1" />, <see cref="NoNamespace.adminDistrict1" />, <see cref="NoNamespace.adminDistrict2" />, <see cref="NoNamespace.countryRegion" />, <see cref="NoNamespace.isoCountryCode" />, <see cref="NoNamespace.locality" />, <see cref="NoNamespace.postalCode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Address.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName address = cx + "address";

        /// <summary>
        /// Represents the cx:aggregation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Aggregation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName aggregation = cx + "aggregation";

        /// <summary>
        /// Represents the cx:autoUpdate XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="externalData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ExternalData.AutoUpdate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoUpdate = cx + "autoUpdate";

        /// <summary>
        /// Represents the cx:axis XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="catScaling" />, <see cref="extLst" />, <see cref="majorGridlines" />, <see cref="majorTickMarks" />, <see cref="minorGridlines" />, <see cref="minorTickMarks" />, <see cref="numFmt" />, <see cref="spPr" />, <see cref="tickLabels" />, <see cref="title" />, <see cref="txPr" />, <see cref="units" />, <see cref="valScaling" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Axis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName axis = cx + "axis";

        /// <summary>
        /// Represents the cx:axisId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="series" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AxisId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName axisId = cx + "axisId";

        /// <summary>
        /// Represents the cx:binary XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoCache" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Xsdbase64Binary.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName binary = cx + "binary";

        /// <summary>
        /// Represents the cx:binCount XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="binning" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BinCountXsdunsignedInt.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName binCount = cx + "binCount";

        /// <summary>
        /// Represents the cx:binning XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="binCount" />, <see cref="binSize" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.intervalClosed" />, <see cref="NoNamespace.overflow" />, <see cref="NoNamespace.underflow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Binning.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName binning = cx + "binning";

        /// <summary>
        /// Represents the cx:binSize XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="binning" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Xsddouble.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName binSize = cx + "binSize";

        /// <summary>
        /// Represents the cx:catScaling XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.gapWidth" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CategoryAxisScaling.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName catScaling = cx + "catScaling";

        /// <summary>
        /// Represents the cx:chart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="legend" />, <see cref="plotArea" />, <see cref="title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Chart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chart = cx + "chart";

        /// <summary>
        /// Represents the cx:chartData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="data" />, <see cref="externalData" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartData = cx + "chartData";

        /// <summary>
        /// Represents the cx:chartSpace XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="chart" />, <see cref="chartData" />, <see cref="clrMapOvr" />, <see cref="extLst" />, <see cref="fmtOvrs" />, <see cref="printSettings" />, <see cref="spPr" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartSpace.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartSpace = cx + "chartSpace";

        /// <summary>
        /// Represents the cx:clear XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoCache" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoChildEntitiesQueryResults" />, <see cref="geoDataEntityQueryResults" />, <see cref="geoDataPointToEntityQueryResults" />, <see cref="geoLocationQueryResults" />, <see cref="geoParentEntitiesQueryResults" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Clear.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clear = cx + "clear";

        /// <summary>
        /// Represents the cx:clrMapOvr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.accent1" />, <see cref="NoNamespace.accent2" />, <see cref="NoNamespace.accent3" />, <see cref="NoNamespace.accent4" />, <see cref="NoNamespace.accent5" />, <see cref="NoNamespace.accent6" />, <see cref="NoNamespace.bg1" />, <see cref="NoNamespace.bg2" />, <see cref="NoNamespace.folHlink" />, <see cref="NoNamespace.hlink" />, <see cref="NoNamespace.tx1" />, <see cref="NoNamespace.tx2" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorMappingType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clrMapOvr = cx + "clrMapOvr";

        /// <summary>
        /// Represents the cx:copyright XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="copyrights" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CopyrightXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName copyright = cx + "copyright";

        /// <summary>
        /// Represents the cx:copyrights XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="copyright" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Copyrights.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName copyrights = cx + "copyrights";

        /// <summary>
        /// Represents the cx:data XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="numDim" />, <see cref="strDim" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Data.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName data = cx + "data";

        /// <summary>
        /// Represents the cx:dataId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="series" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataId = cx + "dataId";

        /// <summary>
        /// Represents the cx:dataLabel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataLabels" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="numFmt" />, <see cref="separator" />, <see cref="spPr" />, <see cref="txPr" />, <see cref="visibility" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />, <see cref="NoNamespace.pos" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataLabel = cx + "dataLabel";

        /// <summary>
        /// Represents the cx:dataLabelHidden XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataLabels" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabelHidden.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataLabelHidden = cx + "dataLabelHidden";

        /// <summary>
        /// Represents the cx:dataLabels XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="series" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dataLabel" />, <see cref="dataLabelHidden" />, <see cref="extLst" />, <see cref="numFmt" />, <see cref="separator" />, <see cref="spPr" />, <see cref="txPr" />, <see cref="visibility" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.pos" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabels.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataLabels = cx + "dataLabels";

        /// <summary>
        /// Represents the cx:dataPt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="series" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataPoint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataPt = cx + "dataPt";

        /// <summary>
        /// Represents the cx:entityType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoChildTypes" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EntityType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName entityType = cx + "entityType";

        /// <summary>
        /// Represents the cx:evenFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EvenFooterXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName evenFooter = cx + "evenFooter";

        /// <summary>
        /// Represents the cx:evenHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EvenHeaderXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName evenHeader = cx + "evenHeader";

        /// <summary>
        /// Represents the cx:ext XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.uri" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Extension2.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = cx + "ext";

        /// <summary>
        /// Represents the cx:externalData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="autoUpdate" />, <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName externalData = cx + "externalData";

        /// <summary>
        /// Represents the cx:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />, <see cref="chart" />, <see cref="chartData" />, <see cref="chartSpace" />, <see cref="data" />, <see cref="dataLabel" />, <see cref="dataLabels" />, <see cref="dataPt" />, <see cref="fmtOvr" />, <see cref="layoutPr" />, <see cref="legend" />, <see cref="majorGridlines" />, <see cref="majorTickMarks" />, <see cref="minorGridlines" />, <see cref="minorTickMarks" />, <see cref="plotArea" />, <see cref="plotAreaRegion" />, <see cref="plotSurface" />, <see cref="series" />, <see cref="tickLabels" />, <see cref="title" />, <see cref="units" />, <see cref="unitsLabel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = cx + "extLst";

        /// <summary>
        /// Represents the cx:extremeValue XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="max" />, <see cref="min" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtremeValueColorPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extremeValue = cx + "extremeValue";

        /// <summary>
        /// Represents the cx:f XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numDim" />, <see cref="strDim" />, <see cref="txData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName f = cx + "f";

        /// <summary>
        /// Represents the cx:firstFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FirstFooterXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstFooter = cx + "firstFooter";

        /// <summary>
        /// Represents the cx:firstHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FirstHeaderXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstHeader = cx + "firstHeader";

        /// <summary>
        /// Represents the cx:fmtOvr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fmtOvrs" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="spPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormatOverride.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fmtOvr = cx + "fmtOvr";

        /// <summary>
        /// Represents the cx:fmtOvrs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="fmtOvr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormatOverrides.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fmtOvrs = cx + "fmtOvrs";

        /// <summary>
        /// Represents the cx:geoCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geography" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="binary" />, <see cref="clear" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.provider" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoCache = cx + "geoCache";

        /// <summary>
        /// Represents the cx:geoChildEntities XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoChildEntitiesQueryResult" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoHierarchyEntity" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoChildEntities.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoChildEntities = cx + "geoChildEntities";

        /// <summary>
        /// Represents the cx:geoChildEntitiesQuery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoChildEntitiesQueryResult" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoChildTypes" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.entityId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoChildEntitiesQuery.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoChildEntitiesQuery = cx + "geoChildEntitiesQuery";

        /// <summary>
        /// Represents the cx:geoChildEntitiesQueryResult XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoChildEntitiesQueryResults" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoChildEntities" />, <see cref="geoChildEntitiesQuery" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoChildEntitiesQueryResult.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoChildEntitiesQueryResult = cx + "geoChildEntitiesQueryResult";

        /// <summary>
        /// Represents the cx:geoChildEntitiesQueryResults XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="clear" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoChildEntitiesQueryResult" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoChildEntitiesQueryResults.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoChildEntitiesQueryResults = cx + "geoChildEntitiesQueryResults";

        /// <summary>
        /// Represents the cx:geoChildTypes XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoChildEntitiesQuery" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="entityType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoChildTypes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoChildTypes = cx + "geoChildTypes";

        /// <summary>
        /// Represents the cx:geoData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoDataEntityQueryResult" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="copyrights" />, <see cref="geoPolygons" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.east" />, <see cref="NoNamespace.entityId" />, <see cref="NoNamespace.entityName" />, <see cref="NoNamespace.north" />, <see cref="NoNamespace.south" />, <see cref="NoNamespace.west" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoData = cx + "geoData";

        /// <summary>
        /// Represents the cx:geoDataEntityQuery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoDataEntityQueryResult" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.entityId" />, <see cref="NoNamespace.entityType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoDataEntityQuery.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoDataEntityQuery = cx + "geoDataEntityQuery";

        /// <summary>
        /// Represents the cx:geoDataEntityQueryResult XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoDataEntityQueryResults" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoData" />, <see cref="geoDataEntityQuery" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoDataEntityQueryResult.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoDataEntityQueryResult = cx + "geoDataEntityQueryResult";

        /// <summary>
        /// Represents the cx:geoDataEntityQueryResults XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="clear" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoDataEntityQueryResult" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoDataEntityQueryResults.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoDataEntityQueryResults = cx + "geoDataEntityQueryResults";

        /// <summary>
        /// Represents the cx:geoDataPointQuery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoDataPointToEntityQueryResult" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.entityType" />, <see cref="NoNamespace.latitude" />, <see cref="NoNamespace.longitude" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoDataPointQuery.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoDataPointQuery = cx + "geoDataPointQuery";

        /// <summary>
        /// Represents the cx:geoDataPointToEntityQuery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoDataPointToEntityQueryResult" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.entityId" />, <see cref="NoNamespace.entityType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoDataPointToEntityQuery.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoDataPointToEntityQuery = cx + "geoDataPointToEntityQuery";

        /// <summary>
        /// Represents the cx:geoDataPointToEntityQueryResult XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoDataPointToEntityQueryResults" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoDataPointQuery" />, <see cref="geoDataPointToEntityQuery" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoDataPointToEntityQueryResult.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoDataPointToEntityQueryResult = cx + "geoDataPointToEntityQueryResult";

        /// <summary>
        /// Represents the cx:geoDataPointToEntityQueryResults XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="clear" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoDataPointToEntityQueryResult" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoDataPointToEntityQueryResults.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoDataPointToEntityQueryResults = cx + "geoDataPointToEntityQueryResults";

        /// <summary>
        /// Represents the cx:geoEntity XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoParentEntitiesQueryResult" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.entityName" />, <see cref="NoNamespace.entityType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoEntity.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoEntity = cx + "geoEntity";

        /// <summary>
        /// Represents the cx:geography XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoCache" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.attribution" />, <see cref="NoNamespace.cultureLanguage" />, <see cref="NoNamespace.cultureRegion" />, <see cref="NoNamespace.projectionType" />, <see cref="NoNamespace.viewedRegionType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Geography.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geography = cx + "geography";

        /// <summary>
        /// Represents the cx:geoHierarchyEntity XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoChildEntities" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.entityId" />, <see cref="NoNamespace.entityName" />, <see cref="NoNamespace.entityType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoHierarchyEntity.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoHierarchyEntity = cx + "geoHierarchyEntity";

        /// <summary>
        /// Represents the cx:geoLocation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoLocations" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="address" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.entityName" />, <see cref="NoNamespace.entityType" />, <see cref="NoNamespace.latitude" />, <see cref="NoNamespace.longitude" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoLocation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoLocation = cx + "geoLocation";

        /// <summary>
        /// Represents the cx:geoLocationQuery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoLocationQueryResult" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.adminDistrict1" />, <see cref="NoNamespace.adminDistrict2" />, <see cref="NoNamespace.countryRegion" />, <see cref="NoNamespace.entityType" />, <see cref="NoNamespace.postalCode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoLocationQuery.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoLocationQuery = cx + "geoLocationQuery";

        /// <summary>
        /// Represents the cx:geoLocationQueryResult XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoLocationQueryResults" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoLocationQuery" />, <see cref="geoLocations" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoLocationQueryResult.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoLocationQueryResult = cx + "geoLocationQueryResult";

        /// <summary>
        /// Represents the cx:geoLocationQueryResults XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="clear" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoLocationQueryResult" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoLocationQueryResults.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoLocationQueryResults = cx + "geoLocationQueryResults";

        /// <summary>
        /// Represents the cx:geoLocations XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoLocationQueryResult" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoLocation" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoLocations.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoLocations = cx + "geoLocations";

        /// <summary>
        /// Represents the cx:geoParentEntitiesQuery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoParentEntitiesQueryResult" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.entityId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoParentEntitiesQuery.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoParentEntitiesQuery = cx + "geoParentEntitiesQuery";

        /// <summary>
        /// Represents the cx:geoParentEntitiesQueryResult XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoParentEntitiesQueryResults" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoEntity" />, <see cref="geoParentEntitiesQuery" />, <see cref="geoParentEntity" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoParentEntitiesQueryResult.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoParentEntitiesQueryResult = cx + "geoParentEntitiesQueryResult";

        /// <summary>
        /// Represents the cx:geoParentEntitiesQueryResults XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="clear" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoParentEntitiesQueryResult" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoParentEntitiesQueryResults.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoParentEntitiesQueryResults = cx + "geoParentEntitiesQueryResults";

        /// <summary>
        /// Represents the cx:geoParentEntity XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoParentEntitiesQueryResult" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.entityId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoParentEntity.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoParentEntity = cx + "geoParentEntity";

        /// <summary>
        /// Represents the cx:geoPolygon XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoPolygons" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.numPoints" />, <see cref="NoNamespace.pcaRings" />, <see cref="NoNamespace.polygonId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoPolygon.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoPolygon = cx + "geoPolygon";

        /// <summary>
        /// Represents the cx:geoPolygons XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="geoData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="geoPolygon" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GeoPolygons.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName geoPolygons = cx + "geoPolygons";

        /// <summary>
        /// Represents the cx:headerFooter XML element.
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
        public static readonly XName headerFooter = cx + "headerFooter";

        /// <summary>
        /// Represents the cx:idx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="subtotals" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UnsignedIntegerType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName idx = cx + "idx";

        /// <summary>
        /// Represents the cx:layoutPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="series" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="aggregation" />, <see cref="binning" />, <see cref="extLst" />, <see cref="geography" />, <see cref="parentLabelLayout" />, <see cref="regionLabelLayout" />, <see cref="statistics" />, <see cref="subtotals" />, <see cref="visibility" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SeriesLayoutProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layoutPr = cx + "layoutPr";

        /// <summary>
        /// Represents the cx:legend XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="spPr" />, <see cref="txPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.align" />, <see cref="NoNamespace.overlay" />, <see cref="NoNamespace.pos" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Legend.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legend = cx + "legend";

        /// <summary>
        /// Represents the cx:lvl XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numDim" />, <see cref="strDim" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pt" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.formatCode" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.ptCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumericLevel, StringLevel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lvl = cx + "lvl";

        /// <summary>
        /// Represents the cx:majorGridlines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MajorGridlinesGridlines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName majorGridlines = cx + "majorGridlines";

        /// <summary>
        /// Represents the cx:majorTickMarks XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MajorTickMarksTickMarks.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName majorTickMarks = cx + "majorTickMarks";

        /// <summary>
        /// Represents the cx:max XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="valueColorPositions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extremeValue" />, <see cref="number" />, <see cref="percent" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MaxValueColorEndPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName max = cx + "max";

        /// <summary>
        /// Represents the cx:maxColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="valueColors" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MaxColorSolidColorFillProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName maxColor = cx + "maxColor";

        /// <summary>
        /// Represents the cx:mid XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="valueColorPositions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="number" />, <see cref="percent" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ValueColorMiddlePosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mid = cx + "mid";

        /// <summary>
        /// Represents the cx:midColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="valueColors" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MidColorSolidColorFillProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName midColor = cx + "midColor";

        /// <summary>
        /// Represents the cx:min XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="valueColorPositions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extremeValue" />, <see cref="number" />, <see cref="percent" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MinValueColorEndPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName min = cx + "min";

        /// <summary>
        /// Represents the cx:minColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="valueColors" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MinColorSolidColorFillProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName minColor = cx + "minColor";

        /// <summary>
        /// Represents the cx:minorGridlines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MinorGridlinesGridlines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName minorGridlines = cx + "minorGridlines";

        /// <summary>
        /// Represents the cx:minorTickMarks XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MinorTickMarksTickMarks.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName minorTickMarks = cx + "minorTickMarks";

        /// <summary>
        /// Represents the cx:nf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numDim" />, <see cref="strDim" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NfFormula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nf = cx + "nf";

        /// <summary>
        /// Represents the cx:number XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="max" />, <see cref="mid" />, <see cref="min" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberColorPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName number = cx + "number";

        /// <summary>
        /// Represents the cx:numDim XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="data" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="f" />, <see cref="lvl" />, <see cref="nf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumericDimension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numDim = cx + "numDim";

        /// <summary>
        /// Represents the cx:numFmt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />, <see cref="dataLabel" />, <see cref="dataLabels" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.formatCode" />, <see cref="NoNamespace.sourceLinked" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numFmt = cx + "numFmt";

        /// <summary>
        /// Represents the cx:oddFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OddFooterXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oddFooter = cx + "oddFooter";

        /// <summary>
        /// Represents the cx:oddHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OddHeaderXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oddHeader = cx + "oddHeader";

        /// <summary>
        /// Represents the cx:pageMargins XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="printSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.b" />, <see cref="NoNamespace.footer" />, <see cref="NoNamespace.header" />, <see cref="NoNamespace.l" />, <see cref="NoNamespace.r" />, <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageMargins.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageMargins = cx + "pageMargins";

        /// <summary>
        /// Represents the cx:pageSetup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="printSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.blackAndWhite" />, <see cref="NoNamespace.copies" />, <see cref="NoNamespace.draft" />, <see cref="NoNamespace.firstPageNumber" />, <see cref="NoNamespace.horizontalDpi" />, <see cref="NoNamespace.orientation" />, <see cref="NoNamespace.paperSize" />, <see cref="NoNamespace.useFirstPageNumber" />, <see cref="NoNamespace.verticalDpi" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageSetup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageSetup = cx + "pageSetup";

        /// <summary>
        /// Represents the cx:parentLabelLayout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParentLabelLayout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName parentLabelLayout = cx + "parentLabelLayout";

        /// <summary>
        /// Represents the cx:percent XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="max" />, <see cref="mid" />, <see cref="min" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PercentageColorPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName percent = cx + "percent";

        /// <summary>
        /// Represents the cx:plotArea XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axis" />, <see cref="extLst" />, <see cref="plotAreaRegion" />, <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlotArea.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName plotArea = cx + "plotArea";

        /// <summary>
        /// Represents the cx:plotAreaRegion XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="plotSurface" />, <see cref="series" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlotAreaRegion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName plotAreaRegion = cx + "plotAreaRegion";

        /// <summary>
        /// Represents the cx:plotSurface XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotAreaRegion" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="spPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlotSurface.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName plotSurface = cx + "plotSurface";

        /// <summary>
        /// Represents the cx:printSettings XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartSpace" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="headerFooter" />, <see cref="pageMargins" />, <see cref="pageSetup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintSettings.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName printSettings = cx + "printSettings";

        /// <summary>
        /// Represents the cx:pt XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartStringValue, NumericValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pt = cx + "pt";

        /// <summary>
        /// Represents the cx:regionLabelLayout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RegionLabelLayout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName regionLabelLayout = cx + "regionLabelLayout";

        /// <summary>
        /// Represents the cx:rich XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bodyPr" />, <see cref="A.lstStyle" />, <see cref="A.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichTextBody.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rich = cx + "rich";

        /// <summary>
        /// Represents the cx:separator XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataLabel" />, <see cref="dataLabels" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SeparatorXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName separator = cx + "separator";

        /// <summary>
        /// Represents the cx:series XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="plotAreaRegion" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axisId" />, <see cref="dataId" />, <see cref="dataLabels" />, <see cref="dataPt" />, <see cref="extLst" />, <see cref="layoutPr" />, <see cref="spPr" />, <see cref="tx" />, <see cref="valueColorPositions" />, <see cref="valueColors" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.formatIdx" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.layoutId" />, <see cref="NoNamespace.ownerIdx" />, <see cref="NoNamespace.uniqueId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Series.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName series = cx + "series";

        /// <summary>
        /// Represents the cx:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />, <see cref="chartSpace" />, <see cref="dataLabel" />, <see cref="dataLabels" />, <see cref="dataPt" />, <see cref="fmtOvr" />, <see cref="legend" />, <see cref="majorGridlines" />, <see cref="minorGridlines" />, <see cref="plotArea" />, <see cref="plotSurface" />, <see cref="series" />, <see cref="title" />, <see cref="unitsLabel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = cx + "spPr";

        /// <summary>
        /// Represents the cx:statistics XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.quartileMethod" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Statistics.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName statistics = cx + "statistics";

        /// <summary>
        /// Represents the cx:strDim XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="data" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="f" />, <see cref="lvl" />, <see cref="nf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StringDimension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strDim = cx + "strDim";

        /// <summary>
        /// Represents the cx:subtotals XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="idx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Subtotals.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName subtotals = cx + "subtotals";

        /// <summary>
        /// Represents the cx:tickLabels XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TickLabels.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tickLabels = cx + "tickLabels";

        /// <summary>
        /// Represents the cx:title XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />, <see cref="chart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="spPr" />, <see cref="tx" />, <see cref="txPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.align" />, <see cref="NoNamespace.overlay" />, <see cref="NoNamespace.pos" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AxisTitle, ChartTitle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName title = cx + "title";

        /// <summary>
        /// Represents the cx:tx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="series" />, <see cref="title" />, <see cref="unitsLabel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rich" />, <see cref="txData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Text.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tx = cx + "tx";

        /// <summary>
        /// Represents the cx:txData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="f" />, <see cref="v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txData = cx + "txData";

        /// <summary>
        /// Represents the cx:txPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />, <see cref="chartSpace" />, <see cref="dataLabel" />, <see cref="dataLabels" />, <see cref="legend" />, <see cref="title" />, <see cref="unitsLabel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bodyPr" />, <see cref="A.lstStyle" />, <see cref="A.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TxPrTextBody.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txPr = cx + "txPr";

        /// <summary>
        /// Represents the cx:units XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="unitsLabel" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.unit" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AxisUnits.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName units = cx + "units";

        /// <summary>
        /// Represents the cx:unitsLabel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="units" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="spPr" />, <see cref="tx" />, <see cref="txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AxisUnitsLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName unitsLabel = cx + "unitsLabel";

        /// <summary>
        /// Represents the cx:v XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="txData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VXsdstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName v = cx + "v";

        /// <summary>
        /// Represents the cx:valScaling XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="axis" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.majorUnit" />, <see cref="NoNamespace.max" />, <see cref="NoNamespace.min" />, <see cref="NoNamespace.minorUnit" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ValueAxisScaling.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName valScaling = cx + "valScaling";

        /// <summary>
        /// Represents the cx:valueColorPositions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="series" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="max" />, <see cref="mid" />, <see cref="min" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ValueColorPositions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName valueColorPositions = cx + "valueColorPositions";

        /// <summary>
        /// Represents the cx:valueColors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="series" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="maxColor" />, <see cref="midColor" />, <see cref="minColor" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ValueColors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName valueColors = cx + "valueColors";

        /// <summary>
        /// Represents the cx:visibility XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataLabel" />, <see cref="dataLabels" />, <see cref="layoutPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.categoryName" />, <see cref="NoNamespace.connectorLines" />, <see cref="NoNamespace.meanLine" />, <see cref="NoNamespace.meanMarker" />, <see cref="NoNamespace.nonoutliers" />, <see cref="NoNamespace.outliers" />, <see cref="NoNamespace.seriesName" />, <see cref="NoNamespace.value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataLabelVisibilities, SeriesElementVisibilities.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName visibility = cx + "visibility";
    }
}
