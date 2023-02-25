// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:oac="http://schemas.microsoft.com/office/drawing/2013/main/command" namespace.
    /// </summary>
    public static class OAC
    {
        /// <summary>
        /// Defines the XML namespace associated with the oac prefix.
        /// </summary>
        public static readonly XNamespace oac = "http://schemas.microsoft.com/office/drawing/2013/main/command";

        /// <summary>
        /// Represents the oac:cNvGrpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpCmd" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.grpSpLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGroupDrawingShapeProps.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvGrpSpPr = oac + "cNvGrpSpPr";

        /// <summary>
        /// Represents the oac:cNvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpCmd" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.descr" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingProps.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvPr = oac + "cNvPr";

        /// <summary>
        /// Represents the oac:cxnSpMk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpCmd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.creationId" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConnectorMoniker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cxnSpMk = oac + "cxnSpMk";

        /// <summary>
        /// Represents the oac:cxnSpMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConnectorMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cxnSpMkLst = oac + "cxnSpMkLst";

        /// <summary>
        /// Represents the oac:dcMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentContextMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dcMkLst = oac + "dcMkLst";

        /// <summary>
        /// Represents the oac:deMasterMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DeMasterMkLstDrawingElementMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName deMasterMkLst = oac + "deMasterMkLst";

        /// <summary>
        /// Represents the oac:deMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DeMkLstDrawingElementMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName deMkLst = oac + "deMkLst";

        /// <summary>
        /// Represents the oac:dgMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="grpCmd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DrawingMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dgMkLst = oac + "dgMkLst";

        /// <summary>
        /// Represents the oac:drSelLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DrawingSelectionStgList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName drSelLst = oac + "drSelLst";

        /// <summary>
        /// Represents the oac:editorSelLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EditorSelectionStgList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName editorSelLst = oac + "editorSelLst";

        /// <summary>
        /// Represents the oac:graphicFrameMk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpCmd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.creationId" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GraphicFrameMoniker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName graphicFrameMk = oac + "graphicFrameMk";

        /// <summary>
        /// Represents the oac:graphicFrameMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GraphicFrameMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName graphicFrameMkLst = oac + "graphicFrameMkLst";

        /// <summary>
        /// Represents the oac:graphicParentMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GraphicParentMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName graphicParentMkLst = oac + "graphicParentMkLst";

        /// <summary>
        /// Represents the oac:gridColMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableColumnMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gridColMkLst = oac + "gridColMkLst";

        /// <summary>
        /// Represents the oac:grpCmd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvGrpSpPr" />, <see cref="cNvPr" />, <see cref="cxnSpMk" />, <see cref="dgMkLst" />, <see cref="graphicFrameMk" />, <see cref="grpSpMk" />, <see cref="grpSpPr" />, <see cref="inkMk" />, <see cref="picMk" />, <see cref="spMk" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.grpId" />, <see cref="NoNamespace.preventRegroup" />, <see cref="NoNamespace.verId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupCommand.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpCmd = oac + "grpCmd";

        /// <summary>
        /// Represents the oac:grpSpMk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpCmd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.creationId" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShapeMoniker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSpMk = oac + "grpSpMk";

        /// <summary>
        /// Represents the oac:grpSpMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShapeMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSpMkLst = oac + "grpSpMkLst";

        /// <summary>
        /// Represents the oac:grpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpCmd" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSpPr = oac + "grpSpPr";

        /// <summary>
        /// Represents the oac:hlinkMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HyperlinkMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hlinkMkLst = oac + "hlinkMkLst";

        /// <summary>
        /// Represents the oac:imgData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ImgDataImgData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName imgData = oac + "imgData";

        /// <summary>
        /// Represents the oac:imgLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.tgt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ImgLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName imgLink = oac + "imgLink";

        /// <summary>
        /// Represents the oac:inkMk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpCmd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.creationId" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InkMoniker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName inkMk = oac + "inkMk";

        /// <summary>
        /// Represents the oac:inkMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InkMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName inkMkLst = oac + "inkMkLst";

        /// <summary>
        /// Represents the oac:model3DMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Model3DMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName model3DMkLst = oac + "model3DMkLst";

        /// <summary>
        /// Represents the oac:origImgData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OrigImgDataImgData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName origImgData = oac + "origImgData";

        /// <summary>
        /// Represents the oac:picMk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpCmd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.creationId" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PictureMoniker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName picMk = oac + "picMk";

        /// <summary>
        /// Represents the oac:picMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PictureMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName picMkLst = oac + "picMkLst";

        /// <summary>
        /// Represents the oac:spMk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpCmd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.creationId" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeMoniker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spMk = oac + "spMk";

        /// <summary>
        /// Represents the oac:spMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spMkLst = oac + "spMkLst";

        /// <summary>
        /// Represents the oac:tblMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblMkLst = oac + "tblMkLst";

        /// <summary>
        /// Represents the oac:tcMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCellMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tcMkLst = oac + "tcMkLst";

        /// <summary>
        /// Represents the oac:trMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableRowMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trMkLst = oac + "trMkLst";

        /// <summary>
        /// Represents the oac:txBodyMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBodyMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txBodyMkLst = oac + "txBodyMkLst";

        /// <summary>
        /// Represents the oac:txBodyPkg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBodyPackage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txBodyPkg = oac + "txBodyPkg";

        /// <summary>
        /// Represents the oac:txMkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P188.cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextCharRangeMonikerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txMkLst = oac + "txMkLst";

        /// <summary>
        /// Represents the oac:viewSelLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ViewSelectionStgList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName viewSelLst = oac + "viewSelLst";
    }
}
