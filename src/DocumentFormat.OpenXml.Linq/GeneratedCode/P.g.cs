// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:p="http://schemas.openxmlformats.org/presentationml/2006/main" namespace.
    /// </summary>
    public static class P
    {
        /// <summary>
        /// Defines the XML namespace associated with the p prefix.
        /// </summary>
        public static readonly XNamespace p = "http://schemas.openxmlformats.org/presentationml/2006/main";

        /// <summary>
        /// Represents the p:anim XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cBhvr" />, <see cref="tavLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.by" />, <see cref="NoNamespace.calcmode" />, <see cref="NoNamespace.from" />, <see cref="P14.bounceEnd" />, <see cref="NoNamespace.to" />, <see cref="NoNamespace.valueType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Animate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName anim = p + "anim";

        /// <summary>
        /// Represents the p:animClr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="by" />, <see cref="cBhvr" />, <see cref="from" />, <see cref="to" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.clrSpc" />, <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnimateColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName animClr = p + "animClr";

        /// <summary>
        /// Represents the p:animEffect XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cBhvr" />, <see cref="progress" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.filter" />, <see cref="NoNamespace.prLst" />, <see cref="NoNamespace.transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnimateEffect.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName animEffect = p + "animEffect";

        /// <summary>
        /// Represents the p:animMotion XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="by" />, <see cref="cBhvr" />, <see cref="from" />, <see cref="rCtr" />, <see cref="to" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.origin" />, <see cref="P14.bounceEnd" />, <see cref="NoNamespace.path" />, <see cref="NoNamespace.pathEditMode" />, <see cref="NoNamespace.ptsTypes" />, <see cref="NoNamespace.rAng" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnimateMotion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName animMotion = p + "animMotion";

        /// <summary>
        /// Represents the p:animRot XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cBhvr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.by" />, <see cref="NoNamespace.from" />, <see cref="P14.bounceEnd" />, <see cref="NoNamespace.to" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnimateRotation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName animRot = p + "animRot";

        /// <summary>
        /// Represents the p:animScale XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="by" />, <see cref="cBhvr" />, <see cref="from" />, <see cref="to" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="P14.bounceEnd" />, <see cref="NoNamespace.zoomContents" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnimateScale.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName animScale = p + "animScale";

        /// <summary>
        /// Represents the p:attrName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="attrNameLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AttributeName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName attrName = p + "attrName";

        /// <summary>
        /// Represents the p:attrNameLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cBhvr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="attrName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AttributeNameList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName attrNameLst = p + "attrNameLst";

        /// <summary>
        /// Represents the p:audio XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cMediaNode" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.isNarration" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Audio.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName audio = p + "audio";

        /// <summary>
        /// Represents the p:bg XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cSld" />, <see cref="spTgt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bgPr" />, <see cref="bgRef" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Background, BackgroundAnimation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bg = p + "bg";

        /// <summary>
        /// Represents the p:bgPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bg" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.blipFill" />, <see cref="A.effectDag" />, <see cref="A.effectLst" />, <see cref="A.gradFill" />, <see cref="A.noFill" />, <see cref="A.pattFill" />, <see cref="A.solidFill" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.shadeToTitle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackgroundProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bgPr = p + "bgPr";

        /// <summary>
        /// Represents the p:bgRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bg" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.idx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackgroundStyleReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bgRef = p + "bgRef";

        /// <summary>
        /// Represents the p:bldAsOne XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bldGraphic" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BuildAsOne.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bldAsOne = p + "bldAsOne";

        /// <summary>
        /// Represents the p:bldDgm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bldLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bld" />, <see cref="NoNamespace.grpId" />, <see cref="NoNamespace.spid" />, <see cref="NoNamespace.uiExpand" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BuildDiagram.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bldDgm = p + "bldDgm";

        /// <summary>
        /// Represents the p:bldGraphic XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bldLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bldAsOne" />, <see cref="bldSub" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.grpId" />, <see cref="NoNamespace.spid" />, <see cref="NoNamespace.uiExpand" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BuildGraphics.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bldGraphic = p + "bldGraphic";

        /// <summary>
        /// Represents the p:bldLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timing" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bldDgm" />, <see cref="bldGraphic" />, <see cref="bldOleChart" />, <see cref="bldP" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BuildList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bldLst = p + "bldLst";

        /// <summary>
        /// Represents the p:bldOleChart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bldLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.animBg" />, <see cref="NoNamespace.bld" />, <see cref="NoNamespace.grpId" />, <see cref="NoNamespace.spid" />, <see cref="NoNamespace.uiExpand" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BuildOleChart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bldOleChart = p + "bldOleChart";

        /// <summary>
        /// Represents the p:bldP XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bldLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tmplLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.advAuto" />, <see cref="NoNamespace.animBg" />, <see cref="NoNamespace.autoUpdateAnimBg" />, <see cref="NoNamespace.bldLvl" />, <see cref="NoNamespace.build" />, <see cref="NoNamespace.grpId" />, <see cref="NoNamespace.rev" />, <see cref="NoNamespace.spid" />, <see cref="NoNamespace.uiExpand" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BuildParagraph.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bldP = p + "bldP";

        /// <summary>
        /// Represents the p:bldSub XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bldGraphic" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bldChart" />, <see cref="A.bldDgm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BuildSubElement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bldSub = p + "bldSub";

        /// <summary>
        /// Represents the p:blinds XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BlindsTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName blinds = p + "blinds";

        /// <summary>
        /// Represents the p:blipFill XML element.
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
        public static readonly XName blipFill = p + "blipFill";

        /// <summary>
        /// Represents the p:bodyStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="txStyles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.defPPr" />, <see cref="A.extLst" />, <see cref="A.lvl1pPr" />, <see cref="A.lvl2pPr" />, <see cref="A.lvl3pPr" />, <see cref="A.lvl4pPr" />, <see cref="A.lvl5pPr" />, <see cref="A.lvl6pPr" />, <see cref="A.lvl7pPr" />, <see cref="A.lvl8pPr" />, <see cref="A.lvl9pPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BodyStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bodyStyle = p + "bodyStyle";

        /// <summary>
        /// Represents the p:bold XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="embeddedFont" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BoldFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bold = p + "bold";

        /// <summary>
        /// Represents the p:boldItalic XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="embeddedFont" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BoldItalicFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName boldItalic = p + "boldItalic";

        /// <summary>
        /// Represents the p:boolVal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="to" />, <see cref="val" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BooleanVariantValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName boolVal = p + "boolVal";

        /// <summary>
        /// Represents the p:browse XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.showScrollbar" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BrowseSlideMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName browse = p + "browse";

        /// <summary>
        /// Represents the p:by XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="animClr" />, <see cref="animMotion" />, <see cref="animScale" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="hsl" />, <see cref="rgb" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ByColor, ByPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName by = p + "by";

        /// <summary>
        /// Represents the p:cBhvr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anim" />, <see cref="animClr" />, <see cref="animEffect" />, <see cref="animMotion" />, <see cref="animRot" />, <see cref="animScale" />, <see cref="cmd" />, <see cref="set" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="attrNameLst" />, <see cref="cTn" />, <see cref="tgtEl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.accumulate" />, <see cref="NoNamespace.additive" />, <see cref="NoNamespace.by" />, <see cref="NoNamespace.from" />, <see cref="NoNamespace.@override" />, <see cref="NoNamespace.rctx" />, <see cref="NoNamespace.to" />, <see cref="NoNamespace.xfrmType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommonBehavior.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cBhvr = p + "cBhvr";

        /// <summary>
        /// Represents the p:charRg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="txEl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.end" />, <see cref="NoNamespace.st" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CharRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName charRg = p + "charRg";

        /// <summary>
        /// Represents the p:checker XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CheckerTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName checker = p + "checker";

        /// <summary>
        /// Represents the p:childTnLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cTn" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="anim" />, <see cref="animClr" />, <see cref="animEffect" />, <see cref="animMotion" />, <see cref="animRot" />, <see cref="animScale" />, <see cref="audio" />, <see cref="cmd" />, <see cref="excl" />, <see cref="par" />, <see cref="seq" />, <see cref="set" />, <see cref="video" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChildTimeNodeList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName childTnLst = p + "childTnLst";

        /// <summary>
        /// Represents the p:circle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CircleTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName circle = p + "circle";

        /// <summary>
        /// Represents the p:clrMap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="handoutMaster" />, <see cref="notesMaster" />, <see cref="sldMaster" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.accent1" />, <see cref="NoNamespace.accent2" />, <see cref="NoNamespace.accent3" />, <see cref="NoNamespace.accent4" />, <see cref="NoNamespace.accent5" />, <see cref="NoNamespace.accent6" />, <see cref="NoNamespace.bg1" />, <see cref="NoNamespace.bg2" />, <see cref="NoNamespace.folHlink" />, <see cref="NoNamespace.hlink" />, <see cref="NoNamespace.tx1" />, <see cref="NoNamespace.tx2" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorMap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clrMap = p + "clrMap";

        /// <summary>
        /// Represents the p:clrMapOvr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="notes" />, <see cref="sld" />, <see cref="sldLayout" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.masterClrMapping" />, <see cref="A.overrideClrMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorMapOverride.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clrMapOvr = p + "clrMapOvr";

        /// <summary>
        /// Represents the p:clrMru XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentationPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorMostRecentlyUsed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clrMru = p + "clrMru";

        /// <summary>
        /// Represents the p:clrVal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="to" />, <see cref="val" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clrVal = p + "clrVal";

        /// <summary>
        /// Represents the p:cm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cmLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pos" />, <see cref="text" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.authorId" />, <see cref="NoNamespace.dt" />, <see cref="NoNamespace.idx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Comment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cm = p + "cm";

        /// <summary>
        /// Represents the p:cmAuthor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cmAuthorLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.clrIdx" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.initials" />, <see cref="NoNamespace.lastIdx" />, <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentAuthor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cmAuthor = p + "cmAuthor";

        /// <summary>
        /// Represents the p:cmAuthorLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cmAuthor" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentAuthorList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cmAuthorLst = p + "cmAuthorLst";

        /// <summary>
        /// Represents the p:cmd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cBhvr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cmd" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Command.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cmd = p + "cmd";

        /// <summary>
        /// Represents the p:cMediaNode XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="audio" />, <see cref="video" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cTn" />, <see cref="tgtEl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mute" />, <see cref="NoNamespace.numSld" />, <see cref="NoNamespace.showWhenStopped" />, <see cref="NoNamespace.vol" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommonMediaNode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cMediaNode = p + "cMediaNode";

        /// <summary>
        /// Represents the p:cmLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cmLst = p + "cmLst";

        /// <summary>
        /// Represents the p:cNvCxnSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvCxnSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.cxnSpLocks" />, <see cref="A.endCxn" />, <see cref="A.extLst" />, <see cref="A.stCxn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualConnectorShapeDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvCxnSpPr = p + "cNvCxnSpPr";

        /// <summary>
        /// Represents the p:cNvGraphicFramePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvGraphicFramePr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.graphicFrameLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGraphicFrameDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvGraphicFramePr = p + "cNvGraphicFramePr";

        /// <summary>
        /// Represents the p:cNvGrpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvGrpSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.grpSpLocks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGroupShapeDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvGrpSpPr = p + "cNvGrpSpPr";

        /// <summary>
        /// Represents the p:cNvPicPr XML element.
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
        public static readonly XName cNvPicPr = p + "cNvPicPr";

        /// <summary>
        /// Represents the p:cNvPr XML element.
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
        public static readonly XName cNvPr = p + "cNvPr";

        /// <summary>
        /// Represents the p:cNvSpPr XML element.
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
        public static readonly XName cNvSpPr = p + "cNvSpPr";

        /// <summary>
        /// Represents the p:comb XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CombTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName comb = p + "comb";

        /// <summary>
        /// Represents the p:cond XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="endCondLst" />, <see cref="nextCondLst" />, <see cref="prevCondLst" />, <see cref="stCondLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rtn" />, <see cref="tgtEl" />, <see cref="tn" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.delay" />, <see cref="NoNamespace.evt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Condition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cond = p + "cond";

        /// <summary>
        /// Represents the p:contentPart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="grpSp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="P14.extLst" />, <see cref="P14.nvContentPartPr" />, <see cref="P14.xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="P14.bwMode" />, <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContentPart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contentPart = p + "contentPart";

        /// <summary>
        /// Represents the p:control XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="controls" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pic" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.imgH" />, <see cref="NoNamespace.imgW" />, <see cref="NoNamespace.name" />, <see cref="R.id" />, <see cref="NoNamespace.showAsIcon" />, <see cref="NoNamespace.spid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Control.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName control = p + "control";

        /// <summary>
        /// Represents the p:controls XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cSld" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="control" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ControlList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName controls = p + "controls";

        /// <summary>
        /// Represents the p:cover XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CoverTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cover = p + "cover";

        /// <summary>
        /// Represents the p:cSld XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="handoutMaster" />, <see cref="notes" />, <see cref="notesMaster" />, <see cref="sld" />, <see cref="sldLayout" />, <see cref="sldMaster" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bg" />, <see cref="controls" />, <see cref="custDataLst" />, <see cref="extLst" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommonSlideData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cSld = p + "cSld";

        /// <summary>
        /// Represents the p:cSldViewPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="notesViewPr" />, <see cref="slideViewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cViewPr" />, <see cref="guideLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.showGuides" />, <see cref="NoNamespace.snapToGrid" />, <see cref="NoNamespace.snapToObjects" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommonSlideViewProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cSldViewPr = p + "cSldViewPr";

        /// <summary>
        /// Represents the p:cTn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cBhvr" />, <see cref="cMediaNode" />, <see cref="excl" />, <see cref="par" />, <see cref="seq" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="childTnLst" />, <see cref="endCondLst" />, <see cref="endSync" />, <see cref="iterate" />, <see cref="stCondLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.accel" />, <see cref="NoNamespace.afterEffect" />, <see cref="NoNamespace.autoRev" />, <see cref="NoNamespace.bldLvl" />, <see cref="NoNamespace.decel" />, <see cref="NoNamespace.display" />, <see cref="NoNamespace.dur" />, <see cref="NoNamespace.evtFilter" />, <see cref="NoNamespace.fill" />, <see cref="NoNamespace.grpId" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.masterRel" />, <see cref="NoNamespace.nodePh" />, <see cref="NoNamespace.nodeType" />, <see cref="P14.presetBounceEnd" />, <see cref="NoNamespace.presetClass" />, <see cref="NoNamespace.presetID" />, <see cref="NoNamespace.presetSubtype" />, <see cref="NoNamespace.repeatCount" />, <see cref="NoNamespace.repeatDur" />, <see cref="NoNamespace.restart" />, <see cref="NoNamespace.spd" />, <see cref="NoNamespace.syncBehavior" />, <see cref="NoNamespace.tmFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommonTimeNode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cTn = p + "cTn";

        /// <summary>
        /// Represents the p:custData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="custDataLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomerData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName custData = p + "custData";

        /// <summary>
        /// Represents the p:custDataLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cSld" />, <see cref="nvPr" />, <see cref="presentation" />, <see cref="P14.nvPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="custData" />, <see cref="tags" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomerDataList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName custDataLst = p + "custDataLst";

        /// <summary>
        /// Represents the p:custShow XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="custShowLst" />, <see cref="htmlPubPr" />, <see cref="showPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="sldLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomShow, CustomShowReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName custShow = p + "custShow";

        /// <summary>
        /// Represents the p:custShowLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="custShow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomShowList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName custShowLst = p + "custShowLst";

        /// <summary>
        /// Represents the p:cut XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.thruBlk" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CutTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cut = p + "cut";

        /// <summary>
        /// Represents the p:cViewPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cSldViewPr" />, <see cref="notesTextViewPr" />, <see cref="outlineViewPr" />, <see cref="sorterViewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="origin" />, <see cref="scale" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.varScale" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommonViewProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cViewPr = p + "cViewPr";

        /// <summary>
        /// Represents the p:cxnSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="nvCxnSpPr" />, <see cref="spPr" />, <see cref="style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConnectionShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cxnSp = p + "cxnSp";

        /// <summary>
        /// Represents the p:defaultTextStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.defPPr" />, <see cref="A.extLst" />, <see cref="A.lvl1pPr" />, <see cref="A.lvl2pPr" />, <see cref="A.lvl3pPr" />, <see cref="A.lvl4pPr" />, <see cref="A.lvl5pPr" />, <see cref="A.lvl6pPr" />, <see cref="A.lvl7pPr" />, <see cref="A.lvl8pPr" />, <see cref="A.lvl9pPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefaultTextStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defaultTextStyle = p + "defaultTextStyle";

        /// <summary>
        /// Represents the p:diamond XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DiamondTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName diamond = p + "diamond";

        /// <summary>
        /// Represents the p:dissolve XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DissolveTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dissolve = p + "dissolve";

        /// <summary>
        /// Represents the p:embed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oleObj" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.followColorScheme" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleObjectEmbed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName embed = p + "embed";

        /// <summary>
        /// Represents the p:embeddedFont XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="embeddedFontLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bold" />, <see cref="boldItalic" />, <see cref="font" />, <see cref="italic" />, <see cref="regular" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EmbeddedFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName embeddedFont = p + "embeddedFont";

        /// <summary>
        /// Represents the p:embeddedFontLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="embeddedFont" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EmbeddedFontList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName embeddedFontLst = p + "embeddedFontLst";

        /// <summary>
        /// Represents the p:endCondLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cTn" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cond" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndConditionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endCondLst = p + "endCondLst";

        /// <summary>
        /// Represents the p:endSnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sndAc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndSoundAction.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endSnd = p + "endSnd";

        /// <summary>
        /// Represents the p:endSync XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cTn" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rtn" />, <see cref="tgtEl" />, <see cref="tn" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.delay" />, <see cref="NoNamespace.evt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndSync.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endSync = p + "endSync";

        /// <summary>
        /// Represents the p:excl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cTn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExclusiveTimeNode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName excl = p + "excl";

        /// <summary>
        /// Represents the p:ext XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="extLst" />, <see cref="P14.extLst" />, <see cref="P15.extLst" />, <see cref="P188.extLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A14.m" />, <see cref="P14.browseMode" />, <see cref="P14.creationId" />, <see cref="P14.defaultImageDpi" />, <see cref="P14.discardImageEditData" />, <see cref="P14.laserClr" />, <see cref="P14.laserTraceLst" />, <see cref="P14.media" />, <see cref="P14.modId" />, <see cref="P14.sectionLst" />, <see cref="P14.sectionPr" />, <see cref="P14.showEvtLst" />, <see cref="P14.showMediaCtrls" />, <see cref="P15.chartTrackingRefBased" />, <see cref="P15.notesGuideLst" />, <see cref="P15.presenceInfo" />, <see cref="P15.sldGuideLst" />, <see cref="P15.threadingInfo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.uri" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ApplicationNonVisualDrawingPropertiesExtension, CommentAuthorExtension, CommentExtension, CommonSlideDataExtension, Extension, HandoutMasterExtension, NotesMasterExtension, PresentationExtension, PresentationPropertiesExtension, ShowPropertiesExtension, SlideExtension, SlideLayoutExtension, SlideMasterExtension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = p + "ext";

        /// <summary>
        /// Represents the p:extLst XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bgPr" />, <see cref="cm" />, <see cref="cmAuthor" />, <see cref="control" />, <see cref="cSld" />, <see cref="custShow" />, <see cref="cxnSp" />, <see cref="embed" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="handoutMaster" />, <see cref="handoutMasterId" />, <see cref="hf" />, <see cref="htmlPubPr" />, <see cref="link" />, <see cref="normalViewPr" />, <see cref="notes" />, <see cref="notesMaster" />, <see cref="notesMasterId" />, <see cref="notesTextViewPr" />, <see cref="notesViewPr" />, <see cref="nvPr" />, <see cref="outlineViewPr" />, <see cref="ph" />, <see cref="photoAlbum" />, <see cref="pic" />, <see cref="presentation" />, <see cref="presentationPr" />, <see cref="prnPr" />, <see cref="showPr" />, <see cref="sld" />, <see cref="sldId" />, <see cref="sldLayout" />, <see cref="sldLayoutId" />, <see cref="sldMaster" />, <see cref="sldMasterId" />, <see cref="sldSyncPr" />, <see cref="slideViewPr" />, <see cref="sorterViewPr" />, <see cref="sp" />, <see cref="spTree" />, <see cref="timing" />, <see cref="transition" />, <see cref="txStyles" />, <see cref="viewPr" />, <see cref="webPr" />, <see cref="P14.nvPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mod" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ApplicationNonVisualDrawingPropertiesExtensionList, CommentAuthorExtensionList, CommentExtensionList, CommonSlideDataExtensionList, ExtensionList, ExtensionListWithModification, HandoutMasterExtensionList, NotesMasterExtensionList, PresentationExtensionList, PresentationPropertiesExtensionList, ShowPropertiesExtensionList, SlideExtensionList, SlideLayoutExtensionList, SlideMasterExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = p + "extLst";

        /// <summary>
        /// Represents the p:fade XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.thruBlk" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FadeTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fade = p + "fade";

        /// <summary>
        /// Represents the p:fltVal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="progress" />, <see cref="to" />, <see cref="val" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FloatVariantValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fltVal = p + "fltVal";

        /// <summary>
        /// Represents the p:font XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="embeddedFont" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.charset" />, <see cref="NoNamespace.panose" />, <see cref="NoNamespace.pitchFamily" />, <see cref="NoNamespace.typeface" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Font.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName font = p + "font";

        /// <summary>
        /// Represents the p:from XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="animClr" />, <see cref="animMotion" />, <see cref="animScale" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FromColor, FromPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName from = p + "from";

        /// <summary>
        /// Represents the p:graphicEl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="spTgt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.chart" />, <see cref="A.dgm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GraphicElement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName graphicEl = p + "graphicEl";

        /// <summary>
        /// Represents the p:graphicFrame XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.graphic" />, <see cref="extLst" />, <see cref="nvGraphicFramePr" />, <see cref="xfrm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GraphicFrame.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName graphicFrame = p + "graphicFrame";

        /// <summary>
        /// Represents the p:gridSpacing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="viewPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cx" />, <see cref="NoNamespace.cy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GridSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gridSpacing = p + "gridSpacing";

        /// <summary>
        /// Represents the p:grpSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="contentPart" />, <see cref="cxnSp" />, <see cref="extLst" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="grpSpPr" />, <see cref="nvGrpSpPr" />, <see cref="pic" />, <see cref="sp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grpSp = p + "grpSp";

        /// <summary>
        /// Represents the p:grpSpPr XML element.
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
        public static readonly XName grpSpPr = p + "grpSpPr";

        /// <summary>
        /// Represents the p:guide XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="guideLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.orient" />, <see cref="NoNamespace.pos" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Guide.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName guide = p + "guide";

        /// <summary>
        /// Represents the p:guideLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cSldViewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="guide" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GuideList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName guideLst = p + "guideLst";

        /// <summary>
        /// Represents the p:handoutMaster XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clrMap" />, <see cref="cSld" />, <see cref="extLst" />, <see cref="hf" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HandoutMaster.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName handoutMaster = p + "handoutMaster";

        /// <summary>
        /// Represents the p:handoutMasterId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="handoutMasterIdLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HandoutMasterId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName handoutMasterId = p + "handoutMasterId";

        /// <summary>
        /// Represents the p:handoutMasterIdLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="handoutMasterId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HandoutMasterIdList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName handoutMasterIdLst = p + "handoutMasterIdLst";

        /// <summary>
        /// Represents the p:hf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="handoutMaster" />, <see cref="notesMaster" />, <see cref="sldLayout" />, <see cref="sldMaster" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dt" />, <see cref="NoNamespace.ftr" />, <see cref="NoNamespace.hdr" />, <see cref="NoNamespace.sldNum" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HeaderFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hf = p + "hf";

        /// <summary>
        /// Represents the p:hsl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="by" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.h" />, <see cref="NoNamespace.l" />, <see cref="NoNamespace.s" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HslColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hsl = p + "hsl";

        /// <summary>
        /// Represents the p:htmlPubPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentationPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="custShow" />, <see cref="extLst" />, <see cref="sldAll" />, <see cref="sldRg" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.pubBrowser" />, <see cref="R.id" />, <see cref="NoNamespace.showSpeakerNotes" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HtmlPublishProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName htmlPubPr = p + "htmlPubPr";

        /// <summary>
        /// Represents the p:inkTgt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tgtEl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.spid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InkTarget.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName inkTgt = p + "inkTgt";

        /// <summary>
        /// Represents the p:intVal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="to" />, <see cref="val" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IntegerVariantValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName intVal = p + "intVal";

        /// <summary>
        /// Represents the p:italic XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="embeddedFont" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ItalicFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName italic = p + "italic";

        /// <summary>
        /// Represents the p:iterate XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cTn" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tmAbs" />, <see cref="tmPct" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.backwards" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Iterate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName iterate = p + "iterate";

        /// <summary>
        /// Represents the p:kinsoku XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.invalEndChars" />, <see cref="NoNamespace.invalStChars" />, <see cref="NoNamespace.lang" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Kinsoku.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName kinsoku = p + "kinsoku";

        /// <summary>
        /// Represents the p:kiosk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.restart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: KioskSlideMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName kiosk = p + "kiosk";

        /// <summary>
        /// Represents the p:link XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oleObj" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.updateAutomatic" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleObjectLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName link = p + "link";

        /// <summary>
        /// Represents the p:modifyVerifier XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.algIdExt" />, <see cref="NoNamespace.algIdExtSource" />, <see cref="NoNamespace.algorithmName" />, <see cref="NoNamespace.cryptAlgorithmClass" />, <see cref="NoNamespace.cryptAlgorithmSid" />, <see cref="NoNamespace.cryptAlgorithmType" />, <see cref="NoNamespace.cryptProvider" />, <see cref="NoNamespace.cryptProviderType" />, <see cref="NoNamespace.cryptProviderTypeExt" />, <see cref="NoNamespace.cryptProviderTypeExtSource" />, <see cref="NoNamespace.hashData" />, <see cref="NoNamespace.hashValue" />, <see cref="NoNamespace.saltData" />, <see cref="NoNamespace.saltValue" />, <see cref="NoNamespace.spinCount" />, <see cref="NoNamespace.spinValue" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ModificationVerifier.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName modifyVerifier = p + "modifyVerifier";

        /// <summary>
        /// Represents the p:newsflash XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NewsflashTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName newsflash = p + "newsflash";

        /// <summary>
        /// Represents the p:nextCondLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="seq" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cond" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NextConditionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nextCondLst = p + "nextCondLst";

        /// <summary>
        /// Represents the p:normalViewPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="viewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="restoredLeft" />, <see cref="restoredTop" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.horzBarState" />, <see cref="NoNamespace.preferSingleView" />, <see cref="NoNamespace.showOutlineIcons" />, <see cref="NoNamespace.snapVertSplitter" />, <see cref="NoNamespace.vertBarState" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NormalViewProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName normalViewPr = p + "normalViewPr";

        /// <summary>
        /// Represents the p:notes XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clrMapOvr" />, <see cref="cSld" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.showMasterPhAnim" />, <see cref="NoNamespace.showMasterSp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesSlide.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notes = p + "notes";

        /// <summary>
        /// Represents the p:notesMaster XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clrMap" />, <see cref="cSld" />, <see cref="extLst" />, <see cref="hf" />, <see cref="notesStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesMaster.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesMaster = p + "notesMaster";

        /// <summary>
        /// Represents the p:notesMasterId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="notesMasterIdLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesMasterId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesMasterId = p + "notesMasterId";

        /// <summary>
        /// Represents the p:notesMasterIdLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="notesMasterId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesMasterIdList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesMasterIdLst = p + "notesMasterIdLst";

        /// <summary>
        /// Represents the p:notesStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="notesMaster" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.defPPr" />, <see cref="A.extLst" />, <see cref="A.lvl1pPr" />, <see cref="A.lvl2pPr" />, <see cref="A.lvl3pPr" />, <see cref="A.lvl4pPr" />, <see cref="A.lvl5pPr" />, <see cref="A.lvl6pPr" />, <see cref="A.lvl7pPr" />, <see cref="A.lvl8pPr" />, <see cref="A.lvl9pPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesStyle = p + "notesStyle";

        /// <summary>
        /// Represents the p:notesSz XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cx" />, <see cref="NoNamespace.cy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesSz = p + "notesSz";

        /// <summary>
        /// Represents the p:notesTextViewPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="viewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cViewPr" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesTextViewProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesTextViewPr = p + "notesTextViewPr";

        /// <summary>
        /// Represents the p:notesViewPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="viewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cSldViewPr" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotesViewProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notesViewPr = p + "notesViewPr";

        /// <summary>
        /// Represents the p:nvCxnSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cxnSp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvCxnSpPr" />, <see cref="cNvPr" />, <see cref="nvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualConnectionShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvCxnSpPr = p + "nvCxnSpPr";

        /// <summary>
        /// Represents the p:nvGraphicFramePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="graphicFrame" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvGraphicFramePr" />, <see cref="cNvPr" />, <see cref="nvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGraphicFrameProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvGraphicFramePr = p + "nvGraphicFramePr";

        /// <summary>
        /// Represents the p:nvGrpSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvGrpSpPr" />, <see cref="cNvPr" />, <see cref="nvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualGroupShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvGrpSpPr = p + "nvGrpSpPr";

        /// <summary>
        /// Represents the p:nvPicPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pic" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvPicPr" />, <see cref="cNvPr" />, <see cref="nvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualPictureProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvPicPr = p + "nvPicPr";

        /// <summary>
        /// Represents the p:nvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvCxnSpPr" />, <see cref="nvGraphicFramePr" />, <see cref="nvGrpSpPr" />, <see cref="nvPicPr" />, <see cref="nvSpPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.audioCd" />, <see cref="A.audioFile" />, <see cref="A.quickTimeFile" />, <see cref="A.videoFile" />, <see cref="A.wavAudioFile" />, <see cref="custDataLst" />, <see cref="extLst" />, <see cref="ph" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.isPhoto" />, <see cref="NoNamespace.userDrawn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ApplicationNonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvPr = p + "nvPr";

        /// <summary>
        /// Represents the p:nvSpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvPr" />, <see cref="cNvSpPr" />, <see cref="nvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvSpPr = p + "nvSpPr";

        /// <summary>
        /// Represents the p:oleChartEl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="spTgt" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.lvl" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleChartElement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oleChartEl = p + "oleChartEl";

        /// <summary>
        /// Represents the p:oleObj XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="embed" />, <see cref="link" />, <see cref="pic" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.imgH" />, <see cref="NoNamespace.imgW" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.progId" />, <see cref="R.id" />, <see cref="NoNamespace.showAsIcon" />, <see cref="NoNamespace.spid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oleObj = p + "oleObj";

        /// <summary>
        /// Represents the p:origin XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cViewPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Origin.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName origin = p + "origin";

        /// <summary>
        /// Represents the p:otherStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="txStyles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.defPPr" />, <see cref="A.extLst" />, <see cref="A.lvl1pPr" />, <see cref="A.lvl2pPr" />, <see cref="A.lvl3pPr" />, <see cref="A.lvl4pPr" />, <see cref="A.lvl5pPr" />, <see cref="A.lvl6pPr" />, <see cref="A.lvl7pPr" />, <see cref="A.lvl8pPr" />, <see cref="A.lvl9pPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OtherStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName otherStyle = p + "otherStyle";

        /// <summary>
        /// Represents the p:outlineViewPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="viewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cViewPr" />, <see cref="extLst" />, <see cref="sldLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OutlineViewProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName outlineViewPr = p + "outlineViewPr";

        /// <summary>
        /// Represents the p:par XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />, <see cref="tnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cTn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParallelTimeNode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName par = p + "par";

        /// <summary>
        /// Represents the p:penClr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PenColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName penClr = p + "penClr";

        /// <summary>
        /// Represents the p:ph XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvPr" />, <see cref="P14.nvPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hasCustomPrompt" />, <see cref="NoNamespace.idx" />, <see cref="NoNamespace.orient" />, <see cref="NoNamespace.sz" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlaceholderShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ph = p + "ph";

        /// <summary>
        /// Represents the p:photoAlbum XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bw" />, <see cref="NoNamespace.frame" />, <see cref="NoNamespace.layout" />, <see cref="NoNamespace.showCaptions" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PhotoAlbum.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName photoAlbum = p + "photoAlbum";

        /// <summary>
        /// Represents the p:pic XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="control" />, <see cref="grpSp" />, <see cref="oleObj" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="blipFill" />, <see cref="extLst" />, <see cref="nvPicPr" />, <see cref="spPr" />, <see cref="style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Picture.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pic = p + "pic";

        /// <summary>
        /// Represents the p:plus XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlusTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName plus = p + "plus";

        /// <summary>
        /// Represents the p:pos XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Position.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pos = p + "pos";

        /// <summary>
        /// Represents the p:present XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PresenterSlideMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName present = p + "present";

        /// <summary>
        /// Represents the p:presentation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="custDataLst" />, <see cref="custShowLst" />, <see cref="defaultTextStyle" />, <see cref="embeddedFontLst" />, <see cref="extLst" />, <see cref="handoutMasterIdLst" />, <see cref="kinsoku" />, <see cref="modifyVerifier" />, <see cref="notesMasterIdLst" />, <see cref="notesSz" />, <see cref="photoAlbum" />, <see cref="sldIdLst" />, <see cref="sldMasterIdLst" />, <see cref="sldSz" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoCompressPictures" />, <see cref="NoNamespace.bookmarkIdSeed" />, <see cref="NoNamespace.compatMode" />, <see cref="NoNamespace.conformance" />, <see cref="NoNamespace.embedTrueTypeFonts" />, <see cref="NoNamespace.firstSlideNum" />, <see cref="NoNamespace.removePersonalInfoOnSave" />, <see cref="NoNamespace.rtl" />, <see cref="NoNamespace.saveSubsetFonts" />, <see cref="NoNamespace.serverZoom" />, <see cref="NoNamespace.showSpecialPlsOnTitleSld" />, <see cref="NoNamespace.strictFirstAndLastChars" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Presentation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName presentation = p + "presentation";

        /// <summary>
        /// Represents the p:presentationPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clrMru" />, <see cref="extLst" />, <see cref="htmlPubPr" />, <see cref="prnPr" />, <see cref="showPr" />, <see cref="webPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PresentationProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName presentationPr = p + "presentationPr";

        /// <summary>
        /// Represents the p:prevCondLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="seq" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cond" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreviousConditionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName prevCondLst = p + "prevCondLst";

        /// <summary>
        /// Represents the p:pRg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="txEl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.end" />, <see cref="NoNamespace.st" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParagraphIndexRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pRg = p + "pRg";

        /// <summary>
        /// Represents the p:prnPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentationPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.clrMode" />, <see cref="NoNamespace.frameSlides" />, <see cref="NoNamespace.hiddenSlides" />, <see cref="NoNamespace.prnWhat" />, <see cref="NoNamespace.scaleToFitPaper" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName prnPr = p + "prnPr";

        /// <summary>
        /// Represents the p:progress XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="animEffect" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="fltVal" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Progress.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName progress = p + "progress";

        /// <summary>
        /// Represents the p:pull XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PullTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pull = p + "pull";

        /// <summary>
        /// Represents the p:push XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PushTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName push = p + "push";

        /// <summary>
        /// Represents the p:random XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RandomTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName random = p + "random";

        /// <summary>
        /// Represents the p:randomBar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RandomBarTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName randomBar = p + "randomBar";

        /// <summary>
        /// Represents the p:rCtr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="animMotion" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RotationCenter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rCtr = p + "rCtr";

        /// <summary>
        /// Represents the p:regular XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="embeddedFont" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RegularFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName regular = p + "regular";

        /// <summary>
        /// Represents the p:restoredLeft XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="normalViewPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoAdjust" />, <see cref="NoNamespace.sz" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RestoredLeft.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName restoredLeft = p + "restoredLeft";

        /// <summary>
        /// Represents the p:restoredTop XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="normalViewPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoAdjust" />, <see cref="NoNamespace.sz" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RestoredTop.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName restoredTop = p + "restoredTop";

        /// <summary>
        /// Represents the p:rgb XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="by" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.b" />, <see cref="NoNamespace.g" />, <see cref="NoNamespace.r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RgbColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rgb = p + "rgb";

        /// <summary>
        /// Represents the p:rtn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cond" />, <see cref="endSync" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RuntimeNodeTrigger.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rtn = p + "rtn";

        /// <summary>
        /// Represents the p:scale XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cViewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.sx" />, <see cref="A.sy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScaleFactor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scale = p + "scale";

        /// <summary>
        /// Represents the p:seq XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cTn" />, <see cref="nextCondLst" />, <see cref="prevCondLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.concurrent" />, <see cref="NoNamespace.nextAc" />, <see cref="NoNamespace.prevAc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SequenceTimeNode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName seq = p + "seq";

        /// <summary>
        /// Represents the p:set XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cBhvr" />, <see cref="to" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SetBehavior.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName set = p + "set";

        /// <summary>
        /// Represents the p:showPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentationPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="browse" />, <see cref="custShow" />, <see cref="extLst" />, <see cref="kiosk" />, <see cref="penClr" />, <see cref="present" />, <see cref="sldAll" />, <see cref="sldRg" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.loop" />, <see cref="NoNamespace.showAnimation" />, <see cref="NoNamespace.showNarration" />, <see cref="NoNamespace.useTimings" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showPr = p + "showPr";

        /// <summary>
        /// Represents the p:sld XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="sldLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clrMapOvr" />, <see cref="cSld" />, <see cref="extLst" />, <see cref="timing" />, <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.collapse" />, <see cref="R.id" />, <see cref="NoNamespace.show" />, <see cref="NoNamespace.showMasterPhAnim" />, <see cref="NoNamespace.showMasterSp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OutlineViewSlideListEntry, Slide, SlideListEntry.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sld = p + "sld";

        /// <summary>
        /// Represents the p:sldAll XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="htmlPubPr" />, <see cref="showPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideAll.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldAll = p + "sldAll";

        /// <summary>
        /// Represents the p:sldId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sldIdLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldId = p + "sldId";

        /// <summary>
        /// Represents the p:sldIdLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sldId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideIdList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldIdLst = p + "sldIdLst";

        /// <summary>
        /// Represents the p:sldLayout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clrMapOvr" />, <see cref="cSld" />, <see cref="extLst" />, <see cref="hf" />, <see cref="timing" />, <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.matchingName" />, <see cref="NoNamespace.preserve" />, <see cref="NoNamespace.showMasterPhAnim" />, <see cref="NoNamespace.showMasterSp" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.userDrawn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideLayout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldLayout = p + "sldLayout";

        /// <summary>
        /// Represents the p:sldLayoutId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sldLayoutIdLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideLayoutId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldLayoutId = p + "sldLayoutId";

        /// <summary>
        /// Represents the p:sldLayoutIdLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sldMaster" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sldLayoutId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideLayoutIdList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldLayoutIdLst = p + "sldLayoutIdLst";

        /// <summary>
        /// Represents the p:sldLst XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="custShow" />, <see cref="outlineViewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sld" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OutlineViewSlideList, SlideList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldLst = p + "sldLst";

        /// <summary>
        /// Represents the p:sldMaster XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="clrMap" />, <see cref="cSld" />, <see cref="extLst" />, <see cref="hf" />, <see cref="sldLayoutIdLst" />, <see cref="timing" />, <see cref="transition" />, <see cref="txStyles" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.preserve" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideMaster.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldMaster = p + "sldMaster";

        /// <summary>
        /// Represents the p:sldMasterId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sldMasterIdLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideMasterId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldMasterId = p + "sldMasterId";

        /// <summary>
        /// Represents the p:sldMasterIdLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sldMasterId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideMasterIdList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldMasterIdLst = p + "sldMasterIdLst";

        /// <summary>
        /// Represents the p:sldRg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="htmlPubPr" />, <see cref="showPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.end" />, <see cref="NoNamespace.st" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldRg = p + "sldRg";

        /// <summary>
        /// Represents the p:sldSyncPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.clientInsertedTime" />, <see cref="NoNamespace.serverSldId" />, <see cref="NoNamespace.serverSldModifiedTime" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideSyncProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldSyncPr = p + "sldSyncPr";

        /// <summary>
        /// Represents the p:sldSz XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentation" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cx" />, <see cref="NoNamespace.cy" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldSz = p + "sldSz";

        /// <summary>
        /// Represents the p:sldTgt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tgtEl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideTarget.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldTgt = p + "sldTgt";

        /// <summary>
        /// Represents the p:slideViewPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="viewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cSldViewPr" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlideViewProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slideViewPr = p + "slideViewPr";

        /// <summary>
        /// Represents the p:snd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="stSnd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.builtIn" />, <see cref="NoNamespace.name" />, <see cref="R.embed" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Sound.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName snd = p + "snd";

        /// <summary>
        /// Represents the p:sndAc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="endSnd" />, <see cref="stSnd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SoundAction.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sndAc = p + "sndAc";

        /// <summary>
        /// Represents the p:sndTgt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tgtEl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.builtIn" />, <see cref="NoNamespace.name" />, <see cref="R.embed" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SoundTarget.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sndTgt = p + "sndTgt";

        /// <summary>
        /// Represents the p:sorterViewPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="viewPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cViewPr" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.showFormatting" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SorterViewProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sorterViewPr = p + "sorterViewPr";

        /// <summary>
        /// Represents the p:sp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="grpSp" />, <see cref="spTree" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="nvSpPr" />, <see cref="spPr" />, <see cref="style" />, <see cref="txBody" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.useBgFill" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sp = p + "sp";

        /// <summary>
        /// Represents the p:split XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />, <see cref="NoNamespace.orient" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SplitTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName split = p + "split";

        /// <summary>
        /// Represents the p:spPr XML element.
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
        public static readonly XName spPr = p + "spPr";

        /// <summary>
        /// Represents the p:spTgt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tgtEl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bg" />, <see cref="graphicEl" />, <see cref="oleChartEl" />, <see cref="subSp" />, <see cref="txEl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.spid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeTarget.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spTgt = p + "spTgt";

        /// <summary>
        /// Represents the p:spTree XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cSld" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="contentPart" />, <see cref="cxnSp" />, <see cref="extLst" />, <see cref="graphicFrame" />, <see cref="grpSp" />, <see cref="grpSpPr" />, <see cref="nvGrpSpPr" />, <see cref="pic" />, <see cref="sp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeTree.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spTree = p + "spTree";

        /// <summary>
        /// Represents the p:stCondLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cTn" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cond" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StartConditionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stCondLst = p + "stCondLst";

        /// <summary>
        /// Represents the p:strips XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StripsTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strips = p + "strips";

        /// <summary>
        /// Represents the p:strVal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="to" />, <see cref="val" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StringVariantValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strVal = p + "strVal";

        /// <summary>
        /// Represents the p:stSnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sndAc" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="snd" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.loop" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StartSoundAction.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stSnd = p + "stSnd";

        /// <summary>
        /// Represents the p:style XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cxnSp" />, <see cref="pic" />, <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.effectRef" />, <see cref="A.fillRef" />, <see cref="A.fontRef" />, <see cref="A.lnRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName style = p + "style";

        /// <summary>
        /// Represents the p:subSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="spTgt" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.spid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SubShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName subSp = p + "subSp";

        /// <summary>
        /// Represents the p:subTnLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cTn" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="anim" />, <see cref="animClr" />, <see cref="animEffect" />, <see cref="animMotion" />, <see cref="animRot" />, <see cref="animScale" />, <see cref="audio" />, <see cref="cmd" />, <see cref="excl" />, <see cref="par" />, <see cref="seq" />, <see cref="set" />, <see cref="video" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SubTimeNodeList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName subTnLst = p + "subTnLst";

        /// <summary>
        /// Represents the p:tag XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tagLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tag.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tag = p + "tag";

        /// <summary>
        /// Represents the p:tagLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tag" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TagList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tagLst = p + "tagLst";

        /// <summary>
        /// Represents the p:tags XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="custDataLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomerDataTags.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tags = p + "tags";

        /// <summary>
        /// Represents the p:tav XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tavLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="val" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fmla" />, <see cref="NoNamespace.tm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimeAnimateValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tav = p + "tav";

        /// <summary>
        /// Represents the p:tavLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anim" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tav" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimeAnimateValueList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tavLst = p + "tavLst";

        /// <summary>
        /// Represents the p:text XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Text.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName text = p + "text";

        /// <summary>
        /// Represents the p:tgtEl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cBhvr" />, <see cref="cMediaNode" />, <see cref="cond" />, <see cref="endSync" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="inkTgt" />, <see cref="sldTgt" />, <see cref="sndTgt" />, <see cref="spTgt" />, <see cref="P14.bmkTgt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TargetElement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tgtEl = p + "tgtEl";

        /// <summary>
        /// Represents the p:timing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sld" />, <see cref="sldLayout" />, <see cref="sldMaster" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bldLst" />, <see cref="extLst" />, <see cref="tnLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Timing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timing = p + "timing";

        /// <summary>
        /// Represents the p:titleStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="txStyles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.defPPr" />, <see cref="A.extLst" />, <see cref="A.lvl1pPr" />, <see cref="A.lvl2pPr" />, <see cref="A.lvl3pPr" />, <see cref="A.lvl4pPr" />, <see cref="A.lvl5pPr" />, <see cref="A.lvl6pPr" />, <see cref="A.lvl7pPr" />, <see cref="A.lvl8pPr" />, <see cref="A.lvl9pPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TitleStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName titleStyle = p + "titleStyle";

        /// <summary>
        /// Represents the p:tmAbs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="iterate" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimeAbsolute.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tmAbs = p + "tmAbs";

        /// <summary>
        /// Represents the p:tmPct XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="iterate" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimePercentage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tmPct = p + "tmPct";

        /// <summary>
        /// Represents the p:tmpl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tmplLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tnLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.lvl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Template.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tmpl = p + "tmpl";

        /// <summary>
        /// Represents the p:tmplLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bldP" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tmpl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TemplateList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tmplLst = p + "tmplLst";

        /// <summary>
        /// Represents the p:tn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cond" />, <see cref="endSync" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimeNode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tn = p + "tn";

        /// <summary>
        /// Represents the p:tnLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timing" />, <see cref="tmpl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="par" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimeNodeList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tnLst = p + "tnLst";

        /// <summary>
        /// Represents the p:to XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="animClr" />, <see cref="animMotion" />, <see cref="animScale" />, <see cref="set" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />, <see cref="boolVal" />, <see cref="clrVal" />, <see cref="fltVal" />, <see cref="intVal" />, <see cref="strVal" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ToColor, ToPosition, ToVariantValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName to = p + "to";

        /// <summary>
        /// Represents the p:transition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sld" />, <see cref="sldLayout" />, <see cref="sldMaster" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="blinds" />, <see cref="checker" />, <see cref="circle" />, <see cref="comb" />, <see cref="cover" />, <see cref="cut" />, <see cref="diamond" />, <see cref="dissolve" />, <see cref="extLst" />, <see cref="fade" />, <see cref="newsflash" />, <see cref="plus" />, <see cref="pull" />, <see cref="push" />, <see cref="random" />, <see cref="randomBar" />, <see cref="sndAc" />, <see cref="split" />, <see cref="strips" />, <see cref="wedge" />, <see cref="wheel" />, <see cref="wipe" />, <see cref="zoom" />, <see cref="P14.conveyor" />, <see cref="P14.doors" />, <see cref="P14.ferris" />, <see cref="P14.flash" />, <see cref="P14.flip" />, <see cref="P14.flythrough" />, <see cref="P14.gallery" />, <see cref="P14.glitter" />, <see cref="P14.honeycomb" />, <see cref="P14.pan" />, <see cref="P14.prism" />, <see cref="P14.reveal" />, <see cref="P14.ripple" />, <see cref="P14.shred" />, <see cref="P14.@switch" />, <see cref="P14.vortex" />, <see cref="P14.warp" />, <see cref="P14.wheelReverse" />, <see cref="P14.window" />, <see cref="P15.prstTrans" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.advClick" />, <see cref="NoNamespace.advTm" />, <see cref="P14.dur" />, <see cref="NoNamespace.spd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Transition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName transition = p + "transition";

        /// <summary>
        /// Represents the p:txBody XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.bodyPr" />, <see cref="A.lstStyle" />, <see cref="A.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBody.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txBody = p + "txBody";

        /// <summary>
        /// Represents the p:txEl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="spTgt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="charRg" />, <see cref="pRg" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextElement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txEl = p + "txEl";

        /// <summary>
        /// Represents the p:txStyles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sldMaster" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bodyStyle" />, <see cref="extLst" />, <see cref="otherStyle" />, <see cref="titleStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txStyles = p + "txStyles";

        /// <summary>
        /// Represents the p:val XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tav" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="boolVal" />, <see cref="clrVal" />, <see cref="fltVal" />, <see cref="intVal" />, <see cref="strVal" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VariantValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName val = p + "val";

        /// <summary>
        /// Represents the p:video XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="childTnLst" />, <see cref="subTnLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cMediaNode" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fullScrn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Video.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName video = p + "video";

        /// <summary>
        /// Represents the p:viewPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="gridSpacing" />, <see cref="normalViewPr" />, <see cref="notesTextViewPr" />, <see cref="notesViewPr" />, <see cref="outlineViewPr" />, <see cref="slideViewPr" />, <see cref="sorterViewPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.lastView" />, <see cref="NoNamespace.showComments" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ViewProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName viewPr = p + "viewPr";

        /// <summary>
        /// Represents the p:webPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="presentationPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allowPng" />, <see cref="NoNamespace.clr" />, <see cref="NoNamespace.encoding" />, <see cref="NoNamespace.imgSz" />, <see cref="NoNamespace.organizeInFolders" />, <see cref="NoNamespace.relyOnVml" />, <see cref="NoNamespace.resizeGraphics" />, <see cref="NoNamespace.showAnimation" />, <see cref="NoNamespace.useLongFilenames" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webPr = p + "webPr";

        /// <summary>
        /// Represents the p:wedge XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WedgeTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wedge = p + "wedge";

        /// <summary>
        /// Represents the p:wheel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.spokes" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WheelTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wheel = p + "wheel";

        /// <summary>
        /// Represents the p:wipe XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WipeTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wipe = p + "wipe";

        /// <summary>
        /// Represents the p:xfrm XML element.
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
        public static readonly XName xfrm = p + "xfrm";

        /// <summary>
        /// Represents the p:zoom XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ZoomTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName zoom = p + "zoom";
    }
}
