// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wp="http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing" namespace.
    /// </summary>
    public static class WP
    {
        /// <summary>
        /// Defines the XML namespace associated with the wp prefix.
        /// </summary>
        public static readonly XNamespace wp = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing";

        /// <summary>
        /// Represents the wp:align XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="positionH" />, <see cref="positionV" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HorizontalAlignment, VerticalAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName align = wp + "align";

        /// <summary>
        /// Represents the wp:anchor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.drawing" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.graphic" />, <see cref="cNvGraphicFramePr" />, <see cref="docPr" />, <see cref="effectExtent" />, <see cref="extent" />, <see cref="positionH" />, <see cref="positionV" />, <see cref="simplePos" />, <see cref="wrapNone" />, <see cref="wrapSquare" />, <see cref="wrapThrough" />, <see cref="wrapTight" />, <see cref="wrapTopAndBottom" />, <see cref="WP14.sizeRelH" />, <see cref="WP14.sizeRelV" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allowOverlap" />, <see cref="NoNamespace.behindDoc" />, <see cref="NoNamespace.distB" />, <see cref="NoNamespace.distL" />, <see cref="NoNamespace.distR" />, <see cref="NoNamespace.distT" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.layoutInCell" />, <see cref="NoNamespace.locked" />, <see cref="NoNamespace.relativeHeight" />, <see cref="NoNamespace.simplePos" />, <see cref="WP14.anchorId" />, <see cref="WP14.editId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Anchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName anchor = wp + "anchor";

        /// <summary>
        /// Represents the wp:cNvGraphicFramePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />, <see cref="inline" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.graphicFrameLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGraphicFrameDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvGraphicFramePr = wp + "cNvGraphicFramePr";

        /// <summary>
        /// Represents the wp:docPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />, <see cref="inline" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.descr" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docPr = wp + "docPr";

        /// <summary>
        /// Represents the wp:effectExtent XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />, <see cref="inline" />, <see cref="wrapSquare" />, <see cref="wrapTopAndBottom" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.b" />, <see cref="NoNamespace.l" />, <see cref="NoNamespace.r" />, <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EffectExtent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName effectExtent = wp + "effectExtent";

        /// <summary>
        /// Represents the wp:extent XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />, <see cref="inline" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cx" />, <see cref="NoNamespace.cy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Extent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extent = wp + "extent";

        /// <summary>
        /// Represents the wp:inline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.drawing" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.graphic" />, <see cref="cNvGraphicFramePr" />, <see cref="docPr" />, <see cref="effectExtent" />, <see cref="extent" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.distB" />, <see cref="NoNamespace.distL" />, <see cref="NoNamespace.distR" />, <see cref="NoNamespace.distT" />, <see cref="WP14.anchorId" />, <see cref="WP14.editId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Inline.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName inline = wp + "inline";

        /// <summary>
        /// Represents the wp:lineTo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wrapPolygon" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineTo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lineTo = wp + "lineTo";

        /// <summary>
        /// Represents the wp:positionH XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="align" />, <see cref="posOffset" />, <see cref="WP14.pctPosHOffset" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.relativeFrom" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HorizontalPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName positionH = wp + "positionH";

        /// <summary>
        /// Represents the wp:positionV XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="align" />, <see cref="posOffset" />, <see cref="WP14.pctPosVOffset" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.relativeFrom" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VerticalPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName positionV = wp + "positionV";

        /// <summary>
        /// Represents the wp:posOffset XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="positionH" />, <see cref="positionV" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PositionOffset.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName posOffset = wp + "posOffset";

        /// <summary>
        /// Represents the wp:simplePos XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SimplePosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName simplePos = wp + "simplePos";

        /// <summary>
        /// Represents the wp:start XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wrapPolygon" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StartPoint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName start = wp + "start";

        /// <summary>
        /// Represents the wp:wrapNone XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WrapNone.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrapNone = wp + "wrapNone";

        /// <summary>
        /// Represents the wp:wrapPolygon XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wrapThrough" />, <see cref="wrapTight" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="lineTo" />, <see cref="start" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.edited" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WrapPolygon.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrapPolygon = wp + "wrapPolygon";

        /// <summary>
        /// Represents the wp:wrapSquare XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="effectExtent" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.distB" />, <see cref="NoNamespace.distL" />, <see cref="NoNamespace.distR" />, <see cref="NoNamespace.distT" />, <see cref="NoNamespace.wrapText" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WrapSquare.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrapSquare = wp + "wrapSquare";

        /// <summary>
        /// Represents the wp:wrapThrough XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="wrapPolygon" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.distL" />, <see cref="NoNamespace.distR" />, <see cref="NoNamespace.wrapText" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WrapThrough.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrapThrough = wp + "wrapThrough";

        /// <summary>
        /// Represents the wp:wrapTight XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="wrapPolygon" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.distL" />, <see cref="NoNamespace.distR" />, <see cref="NoNamespace.wrapText" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WrapTight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrapTight = wp + "wrapTight";

        /// <summary>
        /// Represents the wp:wrapTopAndBottom XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="effectExtent" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.distB" />, <see cref="NoNamespace.distT" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WrapTopBottom.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrapTopAndBottom = wp + "wrapTopAndBottom";
    }
}
