// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:p14="http://schemas.microsoft.com/office/powerpoint/2010/main" namespace.
    /// </summary>
    public static class P14
    {
        /// <summary>
        /// Defines the XML namespace associated with the p14 prefix.
        /// </summary>
        public static readonly XNamespace p14 = "http://schemas.microsoft.com/office/powerpoint/2010/main";

        /// <summary>
        /// Represents the p14:bmk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bmkLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MediaBookmark.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bmk = p14 + "bmk";

        /// <summary>
        /// Represents the p14:bmkLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="media" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bmk" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MediaBookmarkList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bmkLst = p14 + "bmkLst";

        /// <summary>
        /// Represents the p14:bmkTgt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.tgtEl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bmkName" />, <see cref="NoNamespace.spid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BookmarkTarget.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bmkTgt = p14 + "bmkTgt";

        /// <summary>
        /// Represents the p14:bounceEnd XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="P.anim" />, <see cref="P.animMotion" />, <see cref="P.animRot" />, <see cref="P.animScale" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Animate.BounceEnd, AnimateMotion.BounceEnd, AnimateRotation.BounceEnd, AnimateScale.BounceEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bounceEnd = p14 + "bounceEnd";

        /// <summary>
        /// Represents the p14:browseMode XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.showStatus" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BrowseMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName browseMode = p14 + "browseMode";

        /// <summary>
        /// Represents the p14:bwMode XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="P.contentPart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ContentPart.BwMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bwMode = p14 + "bwMode";

        /// <summary>
        /// Represents the p14:cNvContentPartPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvContentPartPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A14.cpLocks" />, <see cref="A14.extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.isComment" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualInkContentPartProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvContentPartPr = p14 + "cNvContentPartPr";

        /// <summary>
        /// Represents the p14:cNvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvContentPartPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.extLst" />, <see cref="A.hlinkClick" />, <see cref="A.hlinkHover" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.descr" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cNvPr = p14 + "cNvPr";

        /// <summary>
        /// Represents the p14:conveyor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConveyorTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conveyor = p14 + "conveyor";

        /// <summary>
        /// Represents the p14:creationId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CreationId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName creationId = p14 + "creationId";

        /// <summary>
        /// Represents the p14:defaultImageDpi XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefaultImageDpi.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defaultImageDpi = p14 + "defaultImageDpi";

        /// <summary>
        /// Represents the p14:discardImageEditData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DiscardImageEditData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName discardImageEditData = p14 + "discardImageEditData";

        /// <summary>
        /// Represents the p14:doors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoorsTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doors = p14 + "doors";

        /// <summary>
        /// Represents the p14:dur XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="P.transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Transition.Duration.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dur = p14 + "dur";

        /// <summary>
        /// Represents the p14:extLst XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.contentPart" />, <see cref="media" />, <see cref="section" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="P.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mod" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList, ExtensionListModify.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = p14 + "extLst";

        /// <summary>
        /// Represents the p14:fade XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="media" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@in" />, <see cref="NoNamespace.@out" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MediaFade.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fade = p14 + "fade";

        /// <summary>
        /// Represents the p14:ferris XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FerrisTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ferris = p14 + "ferris";

        /// <summary>
        /// Represents the p14:flash XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FlashTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName flash = p14 + "flash";

        /// <summary>
        /// Represents the p14:flip XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FlipTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName flip = p14 + "flip";

        /// <summary>
        /// Represents the p14:flythrough XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />, <see cref="NoNamespace.hasBounce" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FlythroughTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName flythrough = p14 + "flythrough";

        /// <summary>
        /// Represents the p14:gallery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GalleryTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gallery = p14 + "gallery";

        /// <summary>
        /// Represents the p14:glitter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />, <see cref="NoNamespace.pattern" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GlitterTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName glitter = p14 + "glitter";

        /// <summary>
        /// Represents the p14:honeycomb XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HoneycombTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName honeycomb = p14 + "honeycomb";

        /// <summary>
        /// Represents the p14:laserClr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.hslClr" />, <see cref="A.prstClr" />, <see cref="A.schemeClr" />, <see cref="A.scrgbClr" />, <see cref="A.srgbClr" />, <see cref="A.sysClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LaserColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName laserClr = p14 + "laserClr";

        /// <summary>
        /// Represents the p14:laserTraceLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tracePtLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LaserTraceList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName laserTraceLst = p14 + "laserTraceLst";

        /// <summary>
        /// Represents the p14:media XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bmkLst" />, <see cref="extLst" />, <see cref="fade" />, <see cref="trim" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.embed" />, <see cref="R.link" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Media.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName media = p14 + "media";

        /// <summary>
        /// Represents the p14:modId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ModificationId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName modId = p14 + "modId";

        /// <summary>
        /// Represents the p14:nullEvt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showEvtLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.objId" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NullEventRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nullEvt = p14 + "nullEvt";

        /// <summary>
        /// Represents the p14:nvContentPartPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.contentPart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvContentPartPr" />, <see cref="cNvPr" />, <see cref="nvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NonVisualContentPartProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvContentPartPr = p14 + "nvContentPartPr";

        /// <summary>
        /// Represents the p14:nvPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nvContentPartPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.audioCd" />, <see cref="A.audioFile" />, <see cref="A.quickTimeFile" />, <see cref="A.videoFile" />, <see cref="A.wavAudioFile" />, <see cref="P.custDataLst" />, <see cref="P.extLst" />, <see cref="P.ph" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.isPhoto" />, <see cref="NoNamespace.userDrawn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ApplicationNonVisualDrawingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvPr = p14 + "nvPr";

        /// <summary>
        /// Represents the p14:pan XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PanTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pan = p14 + "pan";

        /// <summary>
        /// Represents the p14:pauseEvt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showEvtLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.objId" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PauseEventRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pauseEvt = p14 + "pauseEvt";

        /// <summary>
        /// Represents the p14:playEvt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showEvtLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.objId" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PlayEventRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName playEvt = p14 + "playEvt";

        /// <summary>
        /// Represents the p14:presetBounceEnd XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="P.cTn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CommonTimeNode.PresetBounceEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName presetBounceEnd = p14 + "presetBounceEnd";

        /// <summary>
        /// Represents the p14:prism XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />, <see cref="NoNamespace.isContent" />, <see cref="NoNamespace.isInverted" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrismTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName prism = p14 + "prism";

        /// <summary>
        /// Represents the p14:resumeEvt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showEvtLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.objId" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ResumeEventRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName resumeEvt = p14 + "resumeEvt";

        /// <summary>
        /// Represents the p14:reveal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />, <see cref="NoNamespace.thruBlk" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevealTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName reveal = p14 + "reveal";

        /// <summary>
        /// Represents the p14:ripple XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RippleTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ripple = p14 + "ripple";

        /// <summary>
        /// Represents the p14:section XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectionLst" />, <see cref="sectionPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="sldIdLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.slideIdLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Section, SectionOld.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName section = p14 + "section";

        /// <summary>
        /// Represents the p14:sectionLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="section" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SectionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sectionLst = p14 + "sectionLst";

        /// <summary>
        /// Represents the p14:sectionPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="section" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SectionProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sectionPr = p14 + "sectionPr";

        /// <summary>
        /// Represents the p14:seekEvt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showEvtLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.objId" />, <see cref="NoNamespace.seek" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SeekEventRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName seekEvt = p14 + "seekEvt";

        /// <summary>
        /// Represents the p14:showEvtLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="nullEvt" />, <see cref="pauseEvt" />, <see cref="playEvt" />, <see cref="resumeEvt" />, <see cref="seekEvt" />, <see cref="stopEvt" />, <see cref="triggerEvt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowEventRecordList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showEvtLst = p14 + "showEvtLst";

        /// <summary>
        /// Represents the p14:showMediaCtrls XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowMediaControls.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showMediaCtrls = p14 + "showMediaCtrls";

        /// <summary>
        /// Represents the p14:shred XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />, <see cref="NoNamespace.pattern" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShredTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shred = p14 + "shred";

        /// <summary>
        /// Represents the p14:sldId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sldIdLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SectionSlideIdListEntry.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldId = p14 + "sldId";

        /// <summary>
        /// Represents the p14:sldIdLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="section" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sldId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SectionSlideIdList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sldIdLst = p14 + "sldIdLst";

        /// <summary>
        /// Represents the p14:stopEvt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showEvtLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.objId" />, <see cref="NoNamespace.time" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StopEventRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stopEvt = p14 + "stopEvt";

        /// <summary>
        /// Represents the p14:switch XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SwitchTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @switch = p14 + "switch";

        /// <summary>
        /// Represents the p14:tracePt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tracePtLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.t" />, <see cref="NoNamespace.x" />, <see cref="NoNamespace.y" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TracePoint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tracePt = p14 + "tracePt";

        /// <summary>
        /// Represents the p14:tracePtLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="laserTraceLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tracePt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TracePointList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tracePtLst = p14 + "tracePtLst";

        /// <summary>
        /// Represents the p14:triggerEvt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="showEvtLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.objId" />, <see cref="NoNamespace.time" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TriggerEventRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName triggerEvt = p14 + "triggerEvt";

        /// <summary>
        /// Represents the p14:trim XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="media" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.end" />, <see cref="NoNamespace.st" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MediaTrim.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trim = p14 + "trim";

        /// <summary>
        /// Represents the p14:vortex XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VortexTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vortex = p14 + "vortex";

        /// <summary>
        /// Represents the p14:warp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WarpTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName warp = p14 + "warp";

        /// <summary>
        /// Represents the p14:wheelReverse XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.spokes" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WheelReverseTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wheelReverse = p14 + "wheelReverse";

        /// <summary>
        /// Represents the p14:window XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.transition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dir" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WindowTransition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName window = p14 + "window";

        /// <summary>
        /// Represents the p14:xfrm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="P.contentPart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />, <see cref="A.off" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.flipH" />, <see cref="NoNamespace.flipV" />, <see cref="NoNamespace.rot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Transform2D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xfrm = p14 + "xfrm";
    }
}
