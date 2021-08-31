// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xdr="http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing" namespace.
    /// </summary>
    public static class XDR
    {
        /// <summary>
        /// Defines the XML namespace associated with the xdr prefix.
        /// </summary>
        public static readonly XNamespace xdr = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing";

        /// <summary>
        /// Represents the xdr:absoluteAnchor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsDr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clientData" />, <see cref="contentPart" />, <see cref="cxnSp" />, <see cref="ext" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="pic" />, <see cref="pos" />, <see cref="sp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AbsoluteAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName absoluteAnchor = xdr + "absoluteAnchor";

        /// <summary>
        /// Represents the xdr:blipFill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pic" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blip" />, <see cref="A.srcRect" />, <see cref="A.stretch" />, <see cref="A.tile" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.rotWithShape" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BlipFill.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName blipFill = xdr + "blipFill";

        /// <summary>
        /// Represents the xdr:clientData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absoluteAnchor" />, <see cref="oneCellAnchor" />, <see cref="twoCellAnchor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fLocksWithSheet" />, <see cref="NoNamespace.fPrintsWithSheet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ClientData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clientData = xdr + "clientData";

        /// <summary>
        /// Represents the xdr:cNvCxnSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvCxnSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.cxnSpLocks" />, <see cref="A.endCxn" />, <see cref="A.extLst" />, <see cref="A.stCxn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualConnectorShapeDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvCxnSpPr = xdr + "cNvCxnSpPr";

        /// <summary>
        /// Represents the xdr:cNvGraphicFramePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvGraphicFramePr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.graphicFrameLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGraphicFrameDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvGraphicFramePr = xdr + "cNvGraphicFramePr";

        /// <summary>
        /// Represents the xdr:cNvGrpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvGrpSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.grpSpLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGroupShapeDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvGrpSpPr = xdr + "cNvGrpSpPr";

        /// <summary>
        /// Represents the xdr:cNvPicPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvPicPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.picLocks" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.preferRelativeResize" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualPictureDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvPicPr = xdr + "cNvPicPr";

        /// <summary>
        /// Represents the xdr:cNvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvCxnSpPr" />, <see cref="nvGraphicFramePr" />, <see cref="nvGrpSpPr" />, <see cref="nvPicPr" />, <see cref="nvSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.descr" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvPr = xdr + "cNvPr";

        /// <summary>
        /// Represents the xdr:cNvSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.spLocks" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.txBox" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualShapeDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvSpPr = xdr + "cNvSpPr";

        /// <summary>
        /// Represents the xdr:col XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.from" />, <see cref="X.to" />, <see cref="from" />, <see cref="to" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName col = xdr + "col";

        /// <summary>
        /// Represents the xdr:colOff XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.from" />, <see cref="X.to" />, <see cref="from" />, <see cref="to" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnOffset.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colOff = xdr + "colOff";

        /// <summary>
        /// Represents the xdr:contentPart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="absoluteAnchor" />, <see cref="oneCellAnchor" />, <see cref="twoCellAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="XDR14.extLst" />, <see cref="XDR14.nvContentPartPr" />, <see cref="XDR14.nvPr" />, <see cref="XDR14.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />, <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContentPart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contentPart = xdr + "contentPart";

        /// <summary>
        /// Represents the xdr:cxnSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absoluteAnchor" />, <see cref="grpSp" />, <see cref="oneCellAnchor" />, <see cref="twoCellAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="nvCxnSpPr" />, <see cref="spPr" />, <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fPublished" />, <see cref="NoNamespace.macro" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConnectionShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cxnSp = xdr + "cxnSp";

        /// <summary>
        /// Represents the xdr:ext XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absoluteAnchor" />, <see cref="oneCellAnchor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cx" />, <see cref="NoNamespace.cy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Extent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = xdr + "ext";

        /// <summary>
        /// Represents the xdr:from XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oneCellAnchor" />, <see cref="twoCellAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="col" />, <see cref="colOff" />, <see cref="row" />, <see cref="rowOff" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FromMarker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName from = xdr + "from";

        /// <summary>
        /// Represents the xdr:graphicFrame XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absoluteAnchor" />, <see cref="grpSp" />, <see cref="oneCellAnchor" />, <see cref="twoCellAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.graphic" />, <see cref="nvGraphicFramePr" />, <see cref="xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fPublished" />, <see cref="NoNamespace.macro" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GraphicFrame.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName graphicFrame = xdr + "graphicFrame";

        /// <summary>
        /// Represents the xdr:grpSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absoluteAnchor" />, <see cref="grpSp" />, <see cref="oneCellAnchor" />, <see cref="twoCellAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cxnSp" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="grpSpPr" />, <see cref="nvGrpSpPr" />, <see cref="pic" />, <see cref="sp" />, <see cref="XDR14.contentPart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSp = xdr + "grpSp";

        /// <summary>
        /// Represents the xdr:grpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSpPr = xdr + "grpSpPr";

        /// <summary>
        /// Represents the xdr:nvCxnSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cxnSp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvCxnSpPr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualConnectionShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvCxnSpPr = xdr + "nvCxnSpPr";

        /// <summary>
        /// Represents the xdr:nvGraphicFramePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="graphicFrame" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvGraphicFramePr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGraphicFrameProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvGraphicFramePr = xdr + "nvGraphicFramePr";

        /// <summary>
        /// Represents the xdr:nvGrpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvGrpSpPr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGroupShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvGrpSpPr = xdr + "nvGrpSpPr";

        /// <summary>
        /// Represents the xdr:nvPicPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pic" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvPicPr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualPictureProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvPicPr = xdr + "nvPicPr";

        /// <summary>
        /// Represents the xdr:nvSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvPr" />, <see cref="cNvSpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvSpPr = xdr + "nvSpPr";

        /// <summary>
        /// Represents the xdr:oneCellAnchor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsDr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clientData" />, <see cref="contentPart" />, <see cref="cxnSp" />, <see cref="ext" />, <see cref="from" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="pic" />, <see cref="sp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OneCellAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oneCellAnchor = xdr + "oneCellAnchor";

        /// <summary>
        /// Represents the xdr:pic XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absoluteAnchor" />, <see cref="grpSp" />, <see cref="oneCellAnchor" />, <see cref="twoCellAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="blipFill" />, <see cref="nvPicPr" />, <see cref="spPr" />, <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fPublished" />, <see cref="NoNamespace.macro" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Picture.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pic = xdr + "pic";

        /// <summary>
        /// Represents the xdr:pos XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absoluteAnchor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Position.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pos = xdr + "pos";

        /// <summary>
        /// Represents the xdr:row XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.from" />, <see cref="X.to" />, <see cref="from" />, <see cref="to" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName row = xdr + "row";

        /// <summary>
        /// Represents the xdr:rowOff XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.from" />, <see cref="X.to" />, <see cref="from" />, <see cref="to" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowOffset.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rowOff = xdr + "rowOff";

        /// <summary>
        /// Represents the xdr:sp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absoluteAnchor" />, <see cref="grpSp" />, <see cref="oneCellAnchor" />, <see cref="twoCellAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="nvSpPr" />, <see cref="spPr" />, <see cref="style" />, <see cref="txBody" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fLocksText" />, <see cref="NoNamespace.fPublished" />, <see cref="NoNamespace.macro" />, <see cref="NoNamespace.textlink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sp = xdr + "sp";

        /// <summary>
        /// Represents the xdr:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cxnSp" />, <see cref="pic" />, <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = xdr + "spPr";

        /// <summary>
        /// Represents the xdr:style XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cxnSp" />, <see cref="pic" />, <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.effectRef" />, <see cref="A.fillRef" />, <see cref="A.fontRef" />, <see cref="A.lnRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName style = xdr + "style";

        /// <summary>
        /// Represents the xdr:to XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="twoCellAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="col" />, <see cref="colOff" />, <see cref="row" />, <see cref="rowOff" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ToMarker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName to = xdr + "to";

        /// <summary>
        /// Represents the xdr:twoCellAnchor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsDr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clientData" />, <see cref="contentPart" />, <see cref="cxnSp" />, <see cref="from" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="pic" />, <see cref="sp" />, <see cref="to" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.editAs_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TwoCellAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName twoCellAnchor = xdr + "twoCellAnchor";

        /// <summary>
        /// Represents the xdr:txBody XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bodyPr" />, <see cref="A.lstStyle" />, <see cref="A.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBody.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txBody = xdr + "txBody";

        /// <summary>
        /// Represents the xdr:wsDr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="absoluteAnchor" />, <see cref="oneCellAnchor" />, <see cref="twoCellAnchor" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WorksheetDrawing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wsDr = xdr + "wsDr";

        /// <summary>
        /// Represents the xdr:xfrm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="graphicFrame" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />, <see cref="A.off" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.flipH" />, <see cref="NoNamespace.flipV" />, <see cref="NoNamespace.rot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Transform.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xfrm = xdr + "xfrm";
    }
}
