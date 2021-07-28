// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wps="http://schemas.microsoft.com/office/word/2010/wordprocessingShape" namespace.
    /// </summary>
    public static class WPS
    {
        /// <summary>
        /// Defines the XML namespace associated with the wps prefix.
        /// </summary>
        public static readonly XNamespace wps = "http://schemas.microsoft.com/office/word/2010/wordprocessingShape";

        /// <summary>
        /// Represents the wps:bodyPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.flatTx" />, <see cref="A.noAutofit" />, <see cref="A.normAutofit" />, <see cref="A.prstTxWarp" />, <see cref="A.scene3d" />, <see cref="A.sp3d" />, <see cref="A.spAutoFit" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.anchor" />, <see cref="NoNamespace.anchorCtr" />, <see cref="NoNamespace.bIns" />, <see cref="NoNamespace.compatLnSpc" />, <see cref="NoNamespace.forceAA" />, <see cref="NoNamespace.fromWordArt" />, <see cref="NoNamespace.horzOverflow" />, <see cref="NoNamespace.lIns" />, <see cref="NoNamespace.numCol" />, <see cref="NoNamespace.rIns" />, <see cref="NoNamespace.rot" />, <see cref="NoNamespace.rtlCol" />, <see cref="NoNamespace.spcCol" />, <see cref="NoNamespace.spcFirstLastPara" />, <see cref="NoNamespace.tIns" />, <see cref="NoNamespace.upright" />, <see cref="NoNamespace.vert" />, <see cref="NoNamespace.vertOverflow" />, <see cref="NoNamespace.wrap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBodyProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bodyPr = wps + "bodyPr";

        /// <summary>
        /// Represents the wps:cNvCnPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.cxnSpLocks" />, <see cref="A.endCxn" />, <see cref="A.extLst" />, <see cref="A.stCxn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualConnectorProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvCnPr = wps + "cNvCnPr";

        /// <summary>
        /// Represents the wps:cNvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.descr" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvPr = wps + "cNvPr";

        /// <summary>
        /// Represents the wps:cNvSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.spLocks" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.txBox" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvSpPr = wps + "cNvSpPr";

        /// <summary>
        /// Represents the wps:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="linkedTxbx" />, <see cref="txbx" />, <see cref="wsp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = wps + "extLst";

        /// <summary>
        /// Represents the wps:linkedTxbx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.seq" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LinkedTextBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName linkedTxbx = wps + "linkedTxbx";

        /// <summary>
        /// Represents the wps:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = wps + "spPr";

        /// <summary>
        /// Represents the wps:style XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.effectRef" />, <see cref="A.fillRef" />, <see cref="A.fontRef" />, <see cref="A.lnRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName style = wps + "style";

        /// <summary>
        /// Represents the wps:txbx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="wsp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="W.txbxContent" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBoxInfo2.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txbx = wps + "txbx";

        /// <summary>
        /// Represents the wps:wsp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="WPC.wpc_" />, <see cref="WPG.grpSp" />, <see cref="WPG.wgp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyPr" />, <see cref="cNvCnPr" />, <see cref="cNvPr" />, <see cref="cNvSpPr" />, <see cref="extLst" />, <see cref="linkedTxbx" />, <see cref="spPr" />, <see cref="style" />, <see cref="txbx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.normalEastAsianFlow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WordprocessingShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wsp = wps + "wsp";
    }
}
