// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:c16="http://schemas.microsoft.com/office/drawing/2014/chart" namespace.
    /// </summary>
    public static partial class C16
    {
        /// <summary>
        /// Defines the XML namespace associated with the c16 prefix.
        /// </summary>
        public static readonly XNamespace c16 = "http://schemas.microsoft.com/office/drawing/2014/chart";

        /// <summary>
        /// Represents the c16:bubble3D XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="categoryFilterException" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Bubble3DBoolean.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bubble3D = c16 + "bubble3D";

        /// <summary>
        /// Represents the c16:categoryFilterException XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="categoryFilterExceptions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bubble3D" />, <see cref="dLbl" />, <see cref="explosion" />, <see cref="invertIfNegative" />, <see cref="marker" />, <see cref="spPr" />, <see cref="uniqueId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CategoryFilterException.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName categoryFilterException = c16 + "categoryFilterException";

        /// <summary>
        /// Represents the c16:categoryFilterExceptions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="categoryFilterException" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CategoryFilterExceptions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName categoryFilterExceptions = c16 + "categoryFilterExceptions";

        /// <summary>
        /// Represents the c16:datapointuniqueidmap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ptentry" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartDataPointUniqueIDMap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName datapointuniqueidmap = c16 + "datapointuniqueidmap";

        /// <summary>
        /// Represents the c16:dLbl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="categoryFilterException" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.delete" />, <see cref="C.dLblPos" />, <see cref="C.extLst" />, <see cref="C.idx" />, <see cref="C.layout" />, <see cref="C.numFmt" />, <see cref="C.separator" />, <see cref="C.showBubbleSize" />, <see cref="C.showCatName" />, <see cref="C.showLegendKey" />, <see cref="C.showPercent" />, <see cref="C.showSerName" />, <see cref="C.showVal" />, <see cref="C.spPr" />, <see cref="C.tx" />, <see cref="C.txPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DLbl.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dLbl = c16 + "dLbl";

        /// <summary>
        /// Represents the c16:explosion XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.pivotSource" />, <see cref="categoryFilterException" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UnsignedIntegerType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName explosion = c16 + "explosion";

        /// <summary>
        /// Represents the c16:invertIfNegative XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="categoryFilterException" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InvertIfNegativeBoolean.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName invertIfNegative = c16 + "invertIfNegative";

        /// <summary>
        /// Represents the c16:marker XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="categoryFilterException" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.extLst" />, <see cref="C.size" />, <see cref="C.spPr" />, <see cref="C.symbol" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Marker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName marker = c16 + "marker";

        /// <summary>
        /// Represents the c16:numCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="C.numRef" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.extLst" />, <see cref="C.formatCode" />, <see cref="C.pt" />, <see cref="C.ptCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberDataType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numCache = c16 + "numCache";

        /// <summary>
        /// Represents the c16:pivotOptions16 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="showExpandCollapseFieldButtons" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotOptions16.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotOptions16 = c16 + "pivotOptions16";

        /// <summary>
        /// Represents the c16:ptentry XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="datapointuniqueidmap" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ptidx" />, <see cref="uniqueID_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartDataPointUniqueIDMapEntry.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ptentry = c16 + "ptentry";

        /// <summary>
        /// Represents the c16:ptidx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ptentry" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: XsdunsignedInt.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ptidx = c16 + "ptidx";

        /// <summary>
        /// Represents the c16:showExpandCollapseFieldButtons XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotOptions16" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BooleanFalse.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showExpandCollapseFieldButtons = c16 + "showExpandCollapseFieldButtons";

        /// <summary>
        /// Represents the c16:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="categoryFilterException" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = c16 + "spPr";

        /// <summary>
        /// Represents the c16:strCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="C.strRef" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="C.extLst" />, <see cref="C.pt" />, <see cref="C.ptCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StringDataType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strCache = c16 + "strCache";

        /// <summary>
        /// Represents the c16:uniqueId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="C.ext" />, <see cref="categoryFilterException" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UniqueIdChartUniqueID.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uniqueId = c16 + "uniqueId";

        /// <summary>
        /// Represents the c16:uniqueID XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ptentry" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UniqueID.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uniqueID_ = c16 + "uniqueID";
    }
}
