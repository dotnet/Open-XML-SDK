// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:dsp="http://schemas.microsoft.com/office/drawing/2008/diagram" namespace.
    /// </summary>
    public static class DSP
    {
        /// <summary>
        /// Defines the XML namespace associated with the dsp prefix.
        /// </summary>
        public static readonly XNamespace dsp = "http://schemas.microsoft.com/office/drawing/2008/diagram";

        /// <summary>
        /// Represents the dsp:cNvGrpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvGrpSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.grpSpLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGroupDrawingShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvGrpSpPr = dsp + "cNvGrpSpPr";

        /// <summary>
        /// Represents the dsp:cNvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvGrpSpPr" />, <see cref="nvSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.descr" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvPr = dsp + "cNvPr";

        /// <summary>
        /// Represents the dsp:cNvSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.spLocks" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.txBox" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvSpPr = dsp + "cNvSpPr";

        /// <summary>
        /// Represents the dsp:dataModelExt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.minVer" />, <see cref="NoNamespace.relId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataModelExtensionBlock.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataModelExt = dsp + "dataModelExt";

        /// <summary>
        /// Represents the dsp:drawing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="spTree" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Drawing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName drawing = dsp + "drawing";

        /// <summary>
        /// Represents the dsp:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="sp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = dsp + "extLst";

        /// <summary>
        /// Represents the dsp:grpSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="grpSp" />, <see cref="grpSpPr" />, <see cref="nvGrpSpPr" />, <see cref="sp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSp = dsp + "grpSp";

        /// <summary>
        /// Represents the dsp:grpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSpPr = dsp + "grpSpPr";

        /// <summary>
        /// Represents the dsp:nvGrpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvGrpSpPr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShapeNonVisualProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvGrpSpPr = dsp + "nvGrpSpPr";

        /// <summary>
        /// Represents the dsp:nvSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvPr" />, <see cref="cNvSpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeNonVisualProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvSpPr = dsp + "nvSpPr";

        /// <summary>
        /// Represents the dsp:sp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="nvSpPr" />, <see cref="spPr" />, <see cref="style" />, <see cref="txBody" />, <see cref="txXfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.modelId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sp = dsp + "sp";

        /// <summary>
        /// Represents the dsp:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = dsp + "spPr";

        /// <summary>
        /// Represents the dsp:spTree XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="drawing" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="grpSp" />, <see cref="grpSpPr" />, <see cref="nvGrpSpPr" />, <see cref="sp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeTree.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spTree = dsp + "spTree";

        /// <summary>
        /// Represents the dsp:style XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.effectRef" />, <see cref="A.fillRef" />, <see cref="A.fontRef" />, <see cref="A.lnRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName style = dsp + "style";

        /// <summary>
        /// Represents the dsp:txBody XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bodyPr" />, <see cref="A.lstStyle" />, <see cref="A.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBody.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txBody = dsp + "txBody";

        /// <summary>
        /// Represents the dsp:txXfrm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />, <see cref="A.off" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.flipH" />, <see cref="NoNamespace.flipV" />, <see cref="NoNamespace.rot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Transform2D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txXfrm = dsp + "txXfrm";
    }
}
