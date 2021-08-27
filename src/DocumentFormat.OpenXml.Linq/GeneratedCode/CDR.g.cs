// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:cdr="http://schemas.openxmlformats.org/drawingml/2006/chartDrawing" namespace.
    /// </summary>
    public static class CDR
    {
        /// <summary>
        /// Defines the XML namespace associated with the cdr prefix.
        /// </summary>
        public static readonly XNamespace cdr = "http://schemas.openxmlformats.org/drawingml/2006/chartDrawing";

        /// <summary>
        /// Represents the cdr:absSizeAnchor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="C.userShapes" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cxnSp" />, <see cref="ext" />, <see cref="from" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="pic" />, <see cref="sp" />, <see cref="CDR14.contentPart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AbsoluteAnchorSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName absSizeAnchor = cdr + "absSizeAnchor";

        /// <summary>
        /// Represents the cdr:blipFill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pic" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blip" />, <see cref="A.srcRect" />, <see cref="A.stretch" />, <see cref="A.tile" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dpi" />, <see cref="NoNamespace.rotWithShape" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BlipFill.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName blipFill = cdr + "blipFill";

        /// <summary>
        /// Represents the cdr:cNvCxnSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvCxnSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.cxnSpLocks" />, <see cref="A.endCxn" />, <see cref="A.extLst" />, <see cref="A.stCxn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualConnectionShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvCxnSpPr = cdr + "cNvCxnSpPr";

        /// <summary>
        /// Represents the cdr:cNvGraphicFramePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvGraphicFramePr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.graphicFrameLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGraphicFrameDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvGraphicFramePr = cdr + "cNvGraphicFramePr";

        /// <summary>
        /// Represents the cdr:cNvGrpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvGrpSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.grpSpLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGroupShapeDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvGrpSpPr = cdr + "cNvGrpSpPr";

        /// <summary>
        /// Represents the cdr:cNvPicPr XML element.
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
        public static readonly XName cNvPicPr = cdr + "cNvPicPr";

        /// <summary>
        /// Represents the cdr:cNvPr XML element.
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
        public static readonly XName cNvPr = cdr + "cNvPr";

        /// <summary>
        /// Represents the cdr:cNvSpPr XML element.
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
        public static readonly XName cNvSpPr = cdr + "cNvSpPr";

        /// <summary>
        /// Represents the cdr:cxnSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absSizeAnchor" />, <see cref="grpSp" />, <see cref="relSizeAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="nvCxnSpPr" />, <see cref="spPr" />, <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fPublished" />, <see cref="NoNamespace.macro" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConnectionShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cxnSp = cdr + "cxnSp";

        /// <summary>
        /// Represents the cdr:ext XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absSizeAnchor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cx" />, <see cref="NoNamespace.cy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Extent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = cdr + "ext";

        /// <summary>
        /// Represents the cdr:from XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absSizeAnchor" />, <see cref="relSizeAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="x" />, <see cref="y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FromAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName from = cdr + "from";

        /// <summary>
        /// Represents the cdr:graphicFrame XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absSizeAnchor" />, <see cref="grpSp" />, <see cref="relSizeAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.graphic" />, <see cref="nvGraphicFramePr" />, <see cref="xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fPublished" />, <see cref="NoNamespace.macro" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GraphicFrame.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName graphicFrame = cdr + "graphicFrame";

        /// <summary>
        /// Represents the cdr:grpSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absSizeAnchor" />, <see cref="grpSp" />, <see cref="relSizeAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cxnSp" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="grpSpPr" />, <see cref="nvGrpSpPr" />, <see cref="pic" />, <see cref="sp" />, <see cref="CDR14.contentPart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSp = cdr + "grpSp";

        /// <summary>
        /// Represents the cdr:grpSpPr XML element.
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
        public static readonly XName grpSpPr = cdr + "grpSpPr";

        /// <summary>
        /// Represents the cdr:nvCxnSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cxnSp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvCxnSpPr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualConnectorShapeDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvCxnSpPr = cdr + "nvCxnSpPr";

        /// <summary>
        /// Represents the cdr:nvGraphicFramePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="graphicFrame" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvGraphicFramePr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGraphicFrameProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvGraphicFramePr = cdr + "nvGraphicFramePr";

        /// <summary>
        /// Represents the cdr:nvGrpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvGrpSpPr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGroupShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvGrpSpPr = cdr + "nvGrpSpPr";

        /// <summary>
        /// Represents the cdr:nvPicPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pic" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvPicPr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualPictureProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvPicPr = cdr + "nvPicPr";

        /// <summary>
        /// Represents the cdr:nvSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvPr" />, <see cref="cNvSpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvSpPr = cdr + "nvSpPr";

        /// <summary>
        /// Represents the cdr:pic XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absSizeAnchor" />, <see cref="grpSp" />, <see cref="relSizeAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="blipFill" />, <see cref="nvPicPr" />, <see cref="spPr" />, <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fPublished" />, <see cref="NoNamespace.macro" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Picture.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pic = cdr + "pic";

        /// <summary>
        /// Represents the cdr:relSizeAnchor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="C.userShapes" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cxnSp" />, <see cref="from" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="pic" />, <see cref="sp" />, <see cref="to" />, <see cref="CDR14.contentPart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RelativeAnchorSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName relSizeAnchor = cdr + "relSizeAnchor";

        /// <summary>
        /// Represents the cdr:sp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="absSizeAnchor" />, <see cref="grpSp" />, <see cref="relSizeAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="nvSpPr" />, <see cref="spPr" />, <see cref="style" />, <see cref="txBody" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fLocksText" />, <see cref="NoNamespace.fPublished" />, <see cref="NoNamespace.macro" />, <see cref="NoNamespace.textlink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sp = cdr + "sp";

        /// <summary>
        /// Represents the cdr:spPr XML element.
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
        public static readonly XName spPr = cdr + "spPr";

        /// <summary>
        /// Represents the cdr:style XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cxnSp" />, <see cref="pic" />, <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.effectRef" />, <see cref="A.fillRef" />, <see cref="A.fontRef" />, <see cref="A.lnRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Style.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName style = cdr + "style";

        /// <summary>
        /// Represents the cdr:to XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="relSizeAnchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="x" />, <see cref="y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ToAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName to = cdr + "to";

        /// <summary>
        /// Represents the cdr:txBody XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bodyPr" />, <see cref="A.lstStyle" />, <see cref="A.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBody.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txBody = cdr + "txBody";

        /// <summary>
        /// Represents the cdr:x XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="from" />, <see cref="to" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: XPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName x = cdr + "x";

        /// <summary>
        /// Represents the cdr:xfrm XML element.
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
        public static readonly XName xfrm = cdr + "xfrm";

        /// <summary>
        /// Represents the cdr:y XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="from" />, <see cref="to" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: YPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName y = cdr + "y";
    }
}
