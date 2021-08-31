// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wpg="http://schemas.microsoft.com/office/word/2010/wordprocessingGroup" namespace.
    /// </summary>
    public static class WPG
    {
        /// <summary>
        /// Defines the XML namespace associated with the wpg prefix.
        /// </summary>
        public static readonly XNamespace wpg = "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup";

        /// <summary>
        /// Represents the wpg:cNvFrPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="WPC.graphicFrame" />, <see cref="graphicFrame" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.graphicFrameLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGraphicFrameProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvFrPr = wpg + "cNvFrPr";

        /// <summary>
        /// Represents the wpg:cNvGrpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="wgp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.grpSpLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGroupDrawingShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvGrpSpPr = wpg + "cNvGrpSpPr";

        /// <summary>
        /// Represents the wpg:cNvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="WPC.graphicFrame" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="wgp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.descr" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvPr = wpg + "cNvPr";

        /// <summary>
        /// Represents the wpg:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="WPC.graphicFrame" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="wgp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = wpg + "extLst";

        /// <summary>
        /// Represents the wpg:graphicFrame XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="wgp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.graphic" />, <see cref="cNvFrPr" />, <see cref="cNvPr" />, <see cref="extLst" />, <see cref="xfrm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GraphicFrame.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName graphicFrame = wpg + "graphicFrame";

        /// <summary>
        /// Represents the wpg:grpSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="wgp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="PIC.pic_" />, <see cref="W14.contentPart" />, <see cref="cNvGrpSpPr" />, <see cref="cNvPr" />, <see cref="extLst" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="grpSpPr" />, <see cref="WPS.wsp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSp = wpg + "grpSp";

        /// <summary>
        /// Represents the wpg:grpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="wgp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSpPr = wpg + "grpSpPr";

        /// <summary>
        /// Represents the wpg:wgp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="WPC.wpc_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="PIC.pic_" />, <see cref="W14.contentPart" />, <see cref="cNvGrpSpPr" />, <see cref="cNvPr" />, <see cref="extLst" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="grpSpPr" />, <see cref="WPS.wsp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WordprocessingGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wgp = wpg + "wgp";

        /// <summary>
        /// Represents the wpg:xfrm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="WPC.graphicFrame" />, <see cref="graphicFrame" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />, <see cref="A.off" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.flipH" />, <see cref="NoNamespace.flipV" />, <see cref="NoNamespace.rot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Transform2D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xfrm = wpg + "xfrm";
    }
}
