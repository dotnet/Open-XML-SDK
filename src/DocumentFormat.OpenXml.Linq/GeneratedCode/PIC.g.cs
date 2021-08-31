// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:pic="http://schemas.openxmlformats.org/drawingml/2006/picture" namespace.
    /// </summary>
    public static class PIC
    {
        /// <summary>
        /// Defines the XML namespace associated with the pic prefix.
        /// </summary>
        public static readonly XNamespace pic = "http://schemas.openxmlformats.org/drawingml/2006/picture";

        /// <summary>
        /// Represents the pic:blipFill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pic_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blip" />, <see cref="A.srcRect" />, <see cref="A.stretch" />, <see cref="A.tile" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dpi" />, <see cref="NoNamespace.rotWithShape" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BlipFill.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName blipFill = pic + "blipFill";

        /// <summary>
        /// Represents the pic:cNvPicPr XML element.
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
        public static readonly XName cNvPicPr = pic + "cNvPicPr";

        /// <summary>
        /// Represents the pic:cNvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvPicPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.descr" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvPr = pic + "cNvPr";

        /// <summary>
        /// Represents the pic:nvPicPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pic_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvPicPr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualPictureProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvPicPr = pic + "nvPicPr";

        /// <summary>
        /// Represents the pic:pic XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="WPC.wpc_" />, <see cref="WPG.grpSp" />, <see cref="WPG.wgp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="blipFill" />, <see cref="nvPicPr" />, <see cref="spPr" />, <see cref="PIC14.extLst" />, <see cref="PIC14.style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Picture.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pic_ = pic + "pic";

        /// <summary>
        /// Represents the pic:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pic_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = pic + "spPr";
    }
}
