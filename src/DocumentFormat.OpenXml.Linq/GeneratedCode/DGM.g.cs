// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:dgm="http://schemas.openxmlformats.org/drawingml/2006/diagram" namespace.
    /// </summary>
    public static class DGM
    {
        /// <summary>
        /// Defines the XML namespace associated with the dgm prefix.
        /// </summary>
        public static readonly XNamespace dgm = "http://schemas.openxmlformats.org/drawingml/2006/diagram";

        /// <summary>
        /// Represents the dgm:adj XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="adjLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Adjust.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName adj = dgm + "adj";

        /// <summary>
        /// Represents the dgm:adjLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="shape" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="adj" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AdjustList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName adjLst = dgm + "adjLst";

        /// <summary>
        /// Represents the dgm:alg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@else" />, <see cref="forEach" />, <see cref="@if" />, <see cref="layoutNode" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="param" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.rev" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Algorithm.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alg = dgm + "alg";

        /// <summary>
        /// Represents the dgm:animLvl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presLayoutVars" />, <see cref="varLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnimationLevel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName animLvl = dgm + "animLvl";

        /// <summary>
        /// Represents the dgm:animOne XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presLayoutVars" />, <see cref="varLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnimateOneByOne.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName animOne = dgm + "animOne";

        /// <summary>
        /// Represents the dgm:bg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataModel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.solidFill" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Background.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bg = dgm + "bg";

        /// <summary>
        /// Represents the dgm:bulletEnabled XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presLayoutVars" />, <see cref="varLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BulletEnabled.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bulletEnabled = dgm + "bulletEnabled";

        /// <summary>
        /// Represents the dgm:cat XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="catLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.pri" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Category, ColorTransformCategory, StyleDisplayCategory.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cat = dgm + "cat";

        /// <summary>
        /// Represents the dgm:catLst XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colorsDef" />, <see cref="colorsDefHdr" />, <see cref="layoutDef" />, <see cref="layoutDefHdr" />, <see cref="styleDef" />, <see cref="styleDefHdr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cat" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CategoryList, ColorTransformCategories, StyleDisplayCategories.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName catLst = dgm + "catLst";

        /// <summary>
        /// Represents the dgm:chMax XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presLayoutVars" />, <see cref="varLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MaxNumberOfChildren.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chMax = dgm + "chMax";

        /// <summary>
        /// Represents the dgm:choose XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@else" />, <see cref="forEach" />, <see cref="@if" />, <see cref="layoutNode" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="@else" />, <see cref="@if" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Choose.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName choose = dgm + "choose";

        /// <summary>
        /// Represents the dgm:chPref XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presLayoutVars" />, <see cref="varLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreferredNumberOfChildren.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chPref = dgm + "chPref";

        /// <summary>
        /// Represents the dgm:clrData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutDef" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dataModel" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.useDef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clrData = dgm + "clrData";

        /// <summary>
        /// Represents the dgm:colorsDef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="catLst" />, <see cref="desc" />, <see cref="extLst" />, <see cref="styleLbl" />, <see cref="title" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.minVer" />, <see cref="NoNamespace.uniqueId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorsDefinition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorsDef = dgm + "colorsDef";

        /// <summary>
        /// Represents the dgm:colorsDefHdr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="colorsDefHdrLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="catLst" />, <see cref="desc" />, <see cref="extLst" />, <see cref="title" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.minVer" />, <see cref="NoNamespace.resId" />, <see cref="NoNamespace.uniqueId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorsDefinitionHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorsDefHdr = dgm + "colorsDefHdr";

        /// <summary>
        /// Represents the dgm:colorsDefHdrLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="colorsDefHdr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorsDefinitionHeaderList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorsDefHdrLst = dgm + "colorsDefHdrLst";

        /// <summary>
        /// Represents the dgm:constr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="constrLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fact" />, <see cref="NoNamespace.@for" />, <see cref="NoNamespace.forName" />, <see cref="NoNamespace.op" />, <see cref="NoNamespace.ptType" />, <see cref="NoNamespace.refFor" />, <see cref="NoNamespace.refForName" />, <see cref="NoNamespace.refPtType" />, <see cref="NoNamespace.refType" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Constraint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName constr = dgm + "constr";

        /// <summary>
        /// Represents the dgm:constrLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@else" />, <see cref="forEach" />, <see cref="@if" />, <see cref="layoutNode" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="constr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Constraints.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName constrLst = dgm + "constrLst";

        /// <summary>
        /// Represents the dgm:cxn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cxnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.destId" />, <see cref="NoNamespace.destOrd" />, <see cref="NoNamespace.modelId" />, <see cref="NoNamespace.parTransId" />, <see cref="NoNamespace.presId" />, <see cref="NoNamespace.sibTransId" />, <see cref="NoNamespace.srcId" />, <see cref="NoNamespace.srcOrd" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Connection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cxn = dgm + "cxn";

        /// <summary>
        /// Represents the dgm:cxnLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataModel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cxn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConnectionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cxnLst = dgm + "cxnLst";

        /// <summary>
        /// Represents the dgm:dataModel XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="clrData" />, <see cref="sampData" />, <see cref="styleData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bg" />, <see cref="cxnLst" />, <see cref="extLst" />, <see cref="ptLst" />, <see cref="whole" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataModel, DataModelRoot.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataModel = dgm + "dataModel";

        /// <summary>
        /// Represents the dgm:desc XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colorsDef" />, <see cref="colorsDefHdr" />, <see cref="layoutDef" />, <see cref="layoutDefHdr" />, <see cref="styleDef" />, <see cref="styleDefHdr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.lang" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorTransformDescription, Description, StyleLabelDescription.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName desc = dgm + "desc";

        /// <summary>
        /// Represents the dgm:dir XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presLayoutVars" />, <see cref="varLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Direction.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dir = dgm + "dir";

        /// <summary>
        /// Represents the dgm:effectClrLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hueDir" />, <see cref="NoNamespace.meth" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EffectColorList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName effectClrLst = dgm + "effectClrLst";

        /// <summary>
        /// Represents the dgm:else XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="choose" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alg" />, <see cref="choose" />, <see cref="constrLst" />, <see cref="extLst" />, <see cref="forEach" />, <see cref="layoutNode" />, <see cref="presOf" />, <see cref="ruleLst" />, <see cref="shape" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DiagramChooseElse.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @else = dgm + "else";

        /// <summary>
        /// Represents the dgm:ext XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="DGM1611.autoBuNodeInfoLst" />, <see cref="DGM1612.lstStyle" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.uri" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DiagramDefinitionExtension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = dgm + "ext";

        /// <summary>
        /// Represents the dgm:extLst XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="alg" />, <see cref="colorsDef" />, <see cref="colorsDefHdr" />, <see cref="constr" />, <see cref="cxn" />, <see cref="dataModel" />, <see cref="@else" />, <see cref="forEach" />, <see cref="@if" />, <see cref="layoutDef" />, <see cref="layoutDefHdr" />, <see cref="layoutNode" />, <see cref="presOf" />, <see cref="pt" />, <see cref="rule" />, <see cref="shape" />, <see cref="styleDef" />, <see cref="styleDefHdr" />, <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />, <see cref="ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataModelExtensionList, DiagramDefinitionExtensionList, ExtensionList, PtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = dgm + "extLst";

        /// <summary>
        /// Represents the dgm:fillClrLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hueDir" />, <see cref="NoNamespace.meth" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FillColorList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fillClrLst = dgm + "fillClrLst";

        /// <summary>
        /// Represents the dgm:forEach XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@else" />, <see cref="forEach" />, <see cref="@if" />, <see cref="layoutNode" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alg" />, <see cref="choose" />, <see cref="constrLst" />, <see cref="extLst" />, <see cref="forEach" />, <see cref="layoutNode" />, <see cref="presOf" />, <see cref="ruleLst" />, <see cref="shape" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.axis" />, <see cref="NoNamespace.cnt" />, <see cref="NoNamespace.hideLastTrans" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.ptType" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.st" />, <see cref="NoNamespace.step" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ForEach.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName forEach = dgm + "forEach";

        /// <summary>
        /// Represents the dgm:hierBranch XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presLayoutVars" />, <see cref="varLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HierarchyBranch.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hierBranch = dgm + "hierBranch";

        /// <summary>
        /// Represents the dgm:if XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="choose" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alg" />, <see cref="choose" />, <see cref="constrLst" />, <see cref="extLst" />, <see cref="forEach" />, <see cref="layoutNode" />, <see cref="presOf" />, <see cref="ruleLst" />, <see cref="shape" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.arg" />, <see cref="NoNamespace.axis" />, <see cref="NoNamespace.cnt" />, <see cref="NoNamespace.func" />, <see cref="NoNamespace.hideLastTrans" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.op" />, <see cref="NoNamespace.ptType" />, <see cref="NoNamespace.st" />, <see cref="NoNamespace.step" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DiagramChooseIf.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @if = dgm + "if";

        /// <summary>
        /// Represents the dgm:layoutDef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="catLst" />, <see cref="clrData" />, <see cref="desc" />, <see cref="extLst" />, <see cref="layoutNode" />, <see cref="sampData" />, <see cref="styleData" />, <see cref="title" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.defStyle" />, <see cref="NoNamespace.minVer" />, <see cref="NoNamespace.uniqueId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LayoutDefinition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layoutDef = dgm + "layoutDef";

        /// <summary>
        /// Represents the dgm:layoutDefHdr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="layoutDefHdrLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="catLst" />, <see cref="desc" />, <see cref="extLst" />, <see cref="title" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.defStyle" />, <see cref="NoNamespace.minVer" />, <see cref="NoNamespace.resId" />, <see cref="NoNamespace.uniqueId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LayoutDefinitionHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layoutDefHdr = dgm + "layoutDefHdr";

        /// <summary>
        /// Represents the dgm:layoutDefHdrLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="layoutDefHdr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LayoutDefinitionHeaderList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layoutDefHdrLst = dgm + "layoutDefHdrLst";

        /// <summary>
        /// Represents the dgm:layoutNode XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@else" />, <see cref="forEach" />, <see cref="@if" />, <see cref="layoutDef" />, <see cref="layoutNode" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alg" />, <see cref="choose" />, <see cref="constrLst" />, <see cref="extLst" />, <see cref="forEach" />, <see cref="layoutNode" />, <see cref="presOf" />, <see cref="ruleLst" />, <see cref="shape" />, <see cref="varLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.chOrder" />, <see cref="NoNamespace.moveWith" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.styleLbl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LayoutNode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layoutNode = dgm + "layoutNode";

        /// <summary>
        /// Represents the dgm:linClrLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hueDir" />, <see cref="NoNamespace.meth" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineColorList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName linClrLst = dgm + "linClrLst";

        /// <summary>
        /// Represents the dgm:orgChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presLayoutVars" />, <see cref="varLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OrganizationChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName orgChart = dgm + "orgChart";

        /// <summary>
        /// Represents the dgm:param XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="alg" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.type" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Parameter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName param = dgm + "param";

        /// <summary>
        /// Represents the dgm:presLayoutVars XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="prSet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="animLvl" />, <see cref="animOne" />, <see cref="bulletEnabled" />, <see cref="chMax" />, <see cref="chPref" />, <see cref="dir" />, <see cref="hierBranch" />, <see cref="orgChart" />, <see cref="resizeHandles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PresentationLayoutVariables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName presLayoutVars = dgm + "presLayoutVars";

        /// <summary>
        /// Represents the dgm:presOf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@else" />, <see cref="forEach" />, <see cref="@if" />, <see cref="layoutNode" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.axis" />, <see cref="NoNamespace.cnt" />, <see cref="NoNamespace.hideLastTrans" />, <see cref="NoNamespace.ptType" />, <see cref="NoNamespace.st" />, <see cref="NoNamespace.step" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PresentationOf.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName presOf = dgm + "presOf";

        /// <summary>
        /// Represents the dgm:prSet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="presLayoutVars" />, <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.coherent3DOff" />, <see cref="NoNamespace.csCatId" />, <see cref="NoNamespace.csTypeId" />, <see cref="NoNamespace.custAng" />, <see cref="NoNamespace.custFlipHor" />, <see cref="NoNamespace.custFlipVert" />, <see cref="NoNamespace.custLinFactNeighborX" />, <see cref="NoNamespace.custLinFactNeighborY" />, <see cref="NoNamespace.custLinFactX" />, <see cref="NoNamespace.custLinFactY" />, <see cref="NoNamespace.custRadScaleInc" />, <see cref="NoNamespace.custRadScaleRad" />, <see cref="NoNamespace.custScaleX" />, <see cref="NoNamespace.custScaleY" />, <see cref="NoNamespace.custSzX" />, <see cref="NoNamespace.custSzY" />, <see cref="NoNamespace.custT" />, <see cref="NoNamespace.loCatId" />, <see cref="NoNamespace.loTypeId" />, <see cref="NoNamespace.phldr" />, <see cref="NoNamespace.phldrT" />, <see cref="NoNamespace.presAssocID" />, <see cref="NoNamespace.presName" />, <see cref="NoNamespace.presStyleCnt" />, <see cref="NoNamespace.presStyleIdx" />, <see cref="NoNamespace.presStyleLbl" />, <see cref="NoNamespace.qsCatId" />, <see cref="NoNamespace.qsTypeId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PropertySet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName prSet = dgm + "prSet";

        /// <summary>
        /// Represents the dgm:pt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ptLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="prSet" />, <see cref="spPr" />, <see cref="t" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cxnId" />, <see cref="NoNamespace.modelId" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Point.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pt = dgm + "pt";

        /// <summary>
        /// Represents the dgm:ptLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataModel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PointList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ptLst = dgm + "ptLst";

        /// <summary>
        /// Represents the dgm:relIds XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.cs" />, <see cref="R.dm" />, <see cref="R.lo" />, <see cref="R.qs" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RelationshipIds.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName relIds = dgm + "relIds";

        /// <summary>
        /// Represents the dgm:resizeHandles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presLayoutVars" />, <see cref="varLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ResizeHandles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName resizeHandles = dgm + "resizeHandles";

        /// <summary>
        /// Represents the dgm:rule XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ruleLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fact" />, <see cref="NoNamespace.@for" />, <see cref="NoNamespace.forName" />, <see cref="NoNamespace.max" />, <see cref="NoNamespace.ptType" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Rule.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rule = dgm + "rule";

        /// <summary>
        /// Represents the dgm:ruleLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@else" />, <see cref="forEach" />, <see cref="@if" />, <see cref="layoutNode" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rule" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RuleList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ruleLst = dgm + "ruleLst";

        /// <summary>
        /// Represents the dgm:sampData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutDef" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dataModel" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.useDef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SampleData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sampData = dgm + "sampData";

        /// <summary>
        /// Represents the dgm:scene3d XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleDef" />, <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.backdrop" />, <see cref="A.camera" />, <see cref="A.extLst" />, <see cref="A.lightRig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Scene3D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scene3d = dgm + "scene3d";

        /// <summary>
        /// Represents the dgm:shape XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@else" />, <see cref="forEach" />, <see cref="@if" />, <see cref="layoutNode" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="adjLst" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.blipPhldr" />, <see cref="NoNamespace.hideGeom" />, <see cref="NoNamespace.lkTxEntry" />, <see cref="R.blip" />, <see cref="NoNamespace.rot" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.zOrderOff" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shape = dgm + "shape";

        /// <summary>
        /// Represents the dgm:sp3d XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bevelB" />, <see cref="A.bevelT" />, <see cref="A.contourClr" />, <see cref="A.extLst" />, <see cref="A.extrusionClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.contourW" />, <see cref="NoNamespace.extrusionH" />, <see cref="NoNamespace.prstMaterial" />, <see cref="NoNamespace.z" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shape3D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sp3d = dgm + "sp3d";

        /// <summary>
        /// Represents the dgm:spPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.custGeom" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.extLst" />, <see cref="A.gradFill" />, <see cref="A.grpFill" />, <see cref="A.ln" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.prstGeom" />, <see cref="A.scene3d" />, <see cref="A.solidFill" />, <see cref="A.sp3d" />, <see cref="A.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spPr = dgm + "spPr";

        /// <summary>
        /// Represents the dgm:style XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="prSet" />, <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.effectRef" />, <see cref="A.fillRef" />, <see cref="A.fontRef" />, <see cref="A.lnRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Style.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName style = dgm + "style";

        /// <summary>
        /// Represents the dgm:styleData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutDef" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dataModel" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.useDef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StyleData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleData = dgm + "styleData";

        /// <summary>
        /// Represents the dgm:styleDef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="catLst" />, <see cref="desc" />, <see cref="extLst" />, <see cref="scene3d" />, <see cref="styleLbl" />, <see cref="title" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.minVer" />, <see cref="NoNamespace.uniqueId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StyleDefinition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleDef = dgm + "styleDef";

        /// <summary>
        /// Represents the dgm:styleDefHdr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="styleDefHdrLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="catLst" />, <see cref="desc" />, <see cref="extLst" />, <see cref="title" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.minVer" />, <see cref="NoNamespace.resId" />, <see cref="NoNamespace.uniqueId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StyleDefinitionHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleDefHdr = dgm + "styleDefHdr";

        /// <summary>
        /// Represents the dgm:styleDefHdrLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="styleDefHdr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StyleDefinitionHeaderList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleDefHdrLst = dgm + "styleDefHdrLst";

        /// <summary>
        /// Represents the dgm:styleLbl XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colorsDef" />, <see cref="styleDef" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="effectClrLst" />, <see cref="extLst" />, <see cref="fillClrLst" />, <see cref="linClrLst" />, <see cref="scene3d" />, <see cref="sp3d" />, <see cref="style" />, <see cref="txEffectClrLst" />, <see cref="txFillClrLst" />, <see cref="txLinClrLst" />, <see cref="txPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorTransformStyleLabel, StyleLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleLbl = dgm + "styleLbl";

        /// <summary>
        /// Represents the dgm:t XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bodyPr" />, <see cref="A.lstStyle" />, <see cref="A.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBody.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName t = dgm + "t";

        /// <summary>
        /// Represents the dgm:title XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colorsDef" />, <see cref="colorsDefHdr" />, <see cref="layoutDef" />, <see cref="layoutDefHdr" />, <see cref="styleDef" />, <see cref="styleDefHdr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.lang" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorDefinitionTitle, StyleDefinitionTitle, Title.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName title = dgm + "title";

        /// <summary>
        /// Represents the dgm:txEffectClrLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hueDir" />, <see cref="NoNamespace.meth" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextEffectColorList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txEffectClrLst = dgm + "txEffectClrLst";

        /// <summary>
        /// Represents the dgm:txFillClrLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hueDir" />, <see cref="NoNamespace.meth" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextFillColorList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txFillClrLst = dgm + "txFillClrLst";

        /// <summary>
        /// Represents the dgm:txLinClrLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hueDir" />, <see cref="NoNamespace.meth" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextLineColorList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txLinClrLst = dgm + "txLinClrLst";

        /// <summary>
        /// Represents the dgm:txPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleLbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.flatTx" />, <see cref="A.sp3d" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txPr = dgm + "txPr";

        /// <summary>
        /// Represents the dgm:varLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="layoutNode" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="animLvl" />, <see cref="animOne" />, <see cref="bulletEnabled" />, <see cref="chMax" />, <see cref="chPref" />, <see cref="dir" />, <see cref="hierBranch" />, <see cref="orgChart" />, <see cref="resizeHandles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VariableList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName varLst = dgm + "varLst";

        /// <summary>
        /// Represents the dgm:whole XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataModel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.ln" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Whole.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName whole = dgm + "whole";
    }
}
