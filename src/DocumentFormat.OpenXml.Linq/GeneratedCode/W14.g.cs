// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:w14="http://schemas.microsoft.com/office/word/2010/wordml" namespace.
    /// </summary>
    public static class W14
    {
        /// <summary>
        /// Defines the XML namespace associated with the w14 prefix.
        /// </summary>
        public static readonly XNamespace w14 = "http://schemas.microsoft.com/office/word/2010/wordml";

        /// <summary>
        /// Represents the w14:algn XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />, <see cref="shadow" />, <see cref="textOutline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.Alignment, Shadow.Alignment, TextOutlineEffect.Alignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName algn = w14 + "algn";

        /// <summary>
        /// Represents the w14:alpha XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Alpha.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alpha = w14 + "alpha";

        /// <summary>
        /// Represents the w14:anchorId XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="W.@object" />, <see cref="W.pict" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EmbeddedObject.AnchorId, Picture.AnchorId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName anchorId = w14 + "anchorId";

        /// <summary>
        /// Represents the w14:ang XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lin" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LinearShadeProperties.Angle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ang = w14 + "ang";

        /// <summary>
        /// Represents the w14:b XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fillToRect" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FillToRectangle.Bottom.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName b = w14 + "b";

        /// <summary>
        /// Represents the w14:bevel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textOutline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BevelEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bevel = w14 + "bevel";

        /// <summary>
        /// Represents the w14:bevelB XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="props3d" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="h" />, <see cref="prst" />, <see cref="w" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BevelBottom.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bevelB = w14 + "bevelB";

        /// <summary>
        /// Represents the w14:bevelT XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="props3d" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="h" />, <see cref="prst" />, <see cref="w" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BevelTop.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bevelT = w14 + "bevelT";

        /// <summary>
        /// Represents the w14:blurRad XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />, <see cref="shadow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.BlurRadius, Shadow.BlurRadius.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName blurRad = w14 + "blurRad";

        /// <summary>
        /// Represents the w14:bwMode XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="contentPart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ContentPart.BlackWhiteMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bwMode = w14 + "bwMode";

        /// <summary>
        /// Represents the w14:camera XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="scene3d" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="prst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Camera.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName camera = w14 + "camera";

        /// <summary>
        /// Represents the w14:cap XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="textOutline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TextOutlineEffect.CapType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cap = w14 + "cap";

        /// <summary>
        /// Represents the w14:checkbox XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.sdtPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="@checked" />, <see cref="checkedState" />, <see cref="uncheckedState" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentCheckBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName checkbox = w14 + "checkbox";

        /// <summary>
        /// Represents the w14:checked XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="checkbox" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Checked.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @checked = w14 + "checked";

        /// <summary>
        /// Represents the w14:checkedState XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="checkbox" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="font" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CheckedState.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName checkedState = w14 + "checkedState";

        /// <summary>
        /// Represents the w14:cmpd XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="textOutline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TextOutlineEffect.Compound.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cmpd = w14 + "cmpd";

        /// <summary>
        /// Represents the w14:cntxtAlts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContextualAlternatives.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cntxtAlts = w14 + "cntxtAlts";

        /// <summary>
        /// Represents the w14:cNvContentPartPr XML element.
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
        public static readonly XName cNvContentPartPr = w14 + "cNvContentPartPr";

        /// <summary>
        /// Represents the w14:cNvPr XML element.
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
        public static readonly XName cNvPr = w14 + "cNvPr";

        /// <summary>
        /// Represents the w14:conflictDel XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="W.bdo" />, <see cref="W.body" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.docPartBody" />, <see cref="W.endnote" />, <see cref="W.fldSimple" />, <see cref="W.footnote" />, <see cref="W.ftr" />, <see cref="W.hdr" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rPr" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W.tbl" />, <see cref="W.tc" />, <see cref="W.tr" />, <see cref="W.trPr" />, <see cref="W.txbxContent" />, <see cref="conflictDel" />, <see cref="conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="W.bdo" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.r" />, <see cref="W.sdt" />, <see cref="conflictDel" />, <see cref="conflictIns" />, <see cref="customXmlConflictDelRangeEnd" />, <see cref="customXmlConflictDelRangeStart" />, <see cref="customXmlConflictInsRangeEnd" />, <see cref="customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.author" />, <see cref="W.date" />, <see cref="W.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConflictDeletion, RunConflictDeletion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conflictDel = w14 + "conflictDel";

        /// <summary>
        /// Represents the w14:conflictIns XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="W.bdo" />, <see cref="W.body" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.docPartBody" />, <see cref="W.endnote" />, <see cref="W.fldSimple" />, <see cref="W.footnote" />, <see cref="W.ftr" />, <see cref="W.hdr" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rPr" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W.tbl" />, <see cref="W.tc" />, <see cref="W.tr" />, <see cref="W.trPr" />, <see cref="W.txbxContent" />, <see cref="conflictDel" />, <see cref="conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="W.bdo" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.r" />, <see cref="W.sdt" />, <see cref="conflictDel" />, <see cref="conflictIns" />, <see cref="customXmlConflictDelRangeEnd" />, <see cref="customXmlConflictDelRangeStart" />, <see cref="customXmlConflictInsRangeEnd" />, <see cref="customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.author" />, <see cref="W.date" />, <see cref="W.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConflictInsertion, RunConflictInsertion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conflictIns = w14 + "conflictIns";

        /// <summary>
        /// Represents the w14:conflictMode XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConflictMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conflictMode = w14 + "conflictMode";

        /// <summary>
        /// Represents the w14:contentPart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="WPC.wpc_" />, <see cref="WPG.grpSp" />, <see cref="WPG.wgp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="nvContentPartPr" />, <see cref="xfrm" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="bwMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContentPart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contentPart = w14 + "contentPart";

        /// <summary>
        /// Represents the w14:contourClr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="props3d" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContourColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contourClr = w14 + "contourClr";

        /// <summary>
        /// Represents the w14:contourW XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="props3d" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Properties3D.ContourWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contourW = w14 + "contourW";

        /// <summary>
        /// Represents the w14:customXmlConflictDelRangeEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="W.bdo" />, <see cref="W.body" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.docPartBody" />, <see cref="W.endnote" />, <see cref="W.fldSimple" />, <see cref="W.footnote" />, <see cref="W.ftr" />, <see cref="W.hdr" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdt" />, <see cref="W.sdtContent" />, <see cref="W.tbl" />, <see cref="W.tc" />, <see cref="W.tr" />, <see cref="W.txbxContent" />, <see cref="conflictDel" />, <see cref="conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlConflictDeletionRangeEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlConflictDelRangeEnd = w14 + "customXmlConflictDelRangeEnd";

        /// <summary>
        /// Represents the w14:customXmlConflictDelRangeStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="W.bdo" />, <see cref="W.body" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.docPartBody" />, <see cref="W.endnote" />, <see cref="W.fldSimple" />, <see cref="W.footnote" />, <see cref="W.ftr" />, <see cref="W.hdr" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdt" />, <see cref="W.sdtContent" />, <see cref="W.tbl" />, <see cref="W.tc" />, <see cref="W.tr" />, <see cref="W.txbxContent" />, <see cref="conflictDel" />, <see cref="conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.author" />, <see cref="W.date" />, <see cref="W.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlConflictDeletionRangeStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlConflictDelRangeStart = w14 + "customXmlConflictDelRangeStart";

        /// <summary>
        /// Represents the w14:customXmlConflictInsRangeEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="W.bdo" />, <see cref="W.body" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.docPartBody" />, <see cref="W.endnote" />, <see cref="W.fldSimple" />, <see cref="W.footnote" />, <see cref="W.ftr" />, <see cref="W.hdr" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdt" />, <see cref="W.sdtContent" />, <see cref="W.tbl" />, <see cref="W.tc" />, <see cref="W.tr" />, <see cref="W.txbxContent" />, <see cref="conflictDel" />, <see cref="conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlConflictInsertionRangeEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlConflictInsRangeEnd = w14 + "customXmlConflictInsRangeEnd";

        /// <summary>
        /// Represents the w14:customXmlConflictInsRangeStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="W.bdo" />, <see cref="W.body" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.docPartBody" />, <see cref="W.endnote" />, <see cref="W.fldSimple" />, <see cref="W.footnote" />, <see cref="W.ftr" />, <see cref="W.hdr" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdt" />, <see cref="W.sdtContent" />, <see cref="W.tbl" />, <see cref="W.tc" />, <see cref="W.tr" />, <see cref="W.txbxContent" />, <see cref="conflictDel" />, <see cref="conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W.author" />, <see cref="W.date" />, <see cref="W.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlConflictInsertionRangeStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlConflictInsRangeStart = w14 + "customXmlConflictInsRangeStart";

        /// <summary>
        /// Represents the w14:defaultImageDpi XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefaultImageDpi.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defaultImageDpi = w14 + "defaultImageDpi";

        /// <summary>
        /// Represents the w14:dir XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lightRig" />, <see cref="reflection" />, <see cref="shadow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LightRig.LightDirectionType, Reflection.DirectionAngle, Shadow.DirectionAngle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dir = w14 + "dir";

        /// <summary>
        /// Represents the w14:discardImageEditingData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DiscardImageEditingData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName discardImageEditingData = w14 + "discardImageEditingData";

        /// <summary>
        /// Represents the w14:dist XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />, <see cref="shadow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.DistanceFromText, Shadow.DistanceFromText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dist = w14 + "dist";

        /// <summary>
        /// Represents the w14:docId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docId = w14 + "docId";

        /// <summary>
        /// Represents the w14:endA XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.EndingOpacity.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endA = w14 + "endA";

        /// <summary>
        /// Represents the w14:endPos XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.EndPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endPos = w14 + "endPos";

        /// <summary>
        /// Represents the w14:entityPicker XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.sdtPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EntityPickerEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName entityPicker = w14 + "entityPicker";

        /// <summary>
        /// Represents the w14:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="contentPart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = w14 + "extLst";

        /// <summary>
        /// Represents the w14:extrusionClr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="props3d" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtrusionColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extrusionClr = w14 + "extrusionClr";

        /// <summary>
        /// Represents the w14:extrusionH XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="props3d" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Properties3D.ExtrusionHeight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extrusionH = w14 + "extrusionH";

        /// <summary>
        /// Represents the w14:fadeDir XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.FadeDirection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fadeDir = w14 + "fadeDir";

        /// <summary>
        /// Represents the w14:fillToRect XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="path" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="b" />, <see cref="l" />, <see cref="r" />, <see cref="t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FillToRectangle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fillToRect = w14 + "fillToRect";

        /// <summary>
        /// Represents the w14:font XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="checkedState" />, <see cref="uncheckedState" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CheckedState.Font, UncheckedState.Font.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName font = w14 + "font";

        /// <summary>
        /// Represents the w14:glow XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="rad" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Glow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName glow = w14 + "glow";

        /// <summary>
        /// Represents the w14:gradFill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textFill" />, <see cref="textOutline" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="gsLst" />, <see cref="lin" />, <see cref="path" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GradientFillProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gradFill = w14 + "gradFill";

        /// <summary>
        /// Represents the w14:gs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="gsLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="pos" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GradientStop.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gs = w14 + "gs";

        /// <summary>
        /// Represents the w14:gsLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="gradFill" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="gs" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GradientStopList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gsLst = w14 + "gsLst";

        /// <summary>
        /// Represents the w14:h XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bevelB" />, <see cref="bevelT" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BevelBottom.Height, BevelTop.Height.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName h = w14 + "h";

        /// <summary>
        /// Represents the w14:hueMod XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HueModulation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hueMod = w14 + "hueMod";

        /// <summary>
        /// Represents the w14:id XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="styleSet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StyleSet.Id.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName id = w14 + "id";

        /// <summary>
        /// Represents the w14:kx XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />, <see cref="shadow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.HorizontalSkewAngle, Shadow.HorizontalSkewAngle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName kx = w14 + "kx";

        /// <summary>
        /// Represents the w14:ky XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />, <see cref="shadow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.VerticalSkewAngle, Shadow.VerticalSkewAngle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ky = w14 + "ky";

        /// <summary>
        /// Represents the w14:l XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fillToRect" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FillToRectangle.Left.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName l = w14 + "l";

        /// <summary>
        /// Represents the w14:lat XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SphereCoordinates.Lattitude.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lat = w14 + "lat";

        /// <summary>
        /// Represents the w14:ligatures XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Ligatures.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ligatures = w14 + "ligatures";

        /// <summary>
        /// Represents the w14:lightRig XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="scene3d" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rot" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="dir" />, <see cref="rig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LightRig.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lightRig = w14 + "lightRig";

        /// <summary>
        /// Represents the w14:lim XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="miter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LineJoinMiterProperties.Limit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lim = w14 + "lim";

        /// <summary>
        /// Represents the w14:lin XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="gradFill" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="ang" />, <see cref="scaled" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LinearShadeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lin = w14 + "lin";

        /// <summary>
        /// Represents the w14:lon XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SphereCoordinates.Longitude.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lon = w14 + "lon";

        /// <summary>
        /// Represents the w14:lum XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Luminance.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lum = w14 + "lum";

        /// <summary>
        /// Represents the w14:lumMod XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LuminanceModulation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lumMod = w14 + "lumMod";

        /// <summary>
        /// Represents the w14:lumOff XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LuminanceOffset.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lumOff = w14 + "lumOff";

        /// <summary>
        /// Represents the w14:miter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textOutline" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="lim" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineJoinMiterProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName miter = w14 + "miter";

        /// <summary>
        /// Represents the w14:noFill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textFill" />, <see cref="textOutline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoFillEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noFill = w14 + "noFill";

        /// <summary>
        /// Represents the w14:noSpellErr XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="W.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Paragraph.NoSpellError.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noSpellErr = w14 + "noSpellErr";

        /// <summary>
        /// Represents the w14:numForm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numForm = w14 + "numForm";

        /// <summary>
        /// Represents the w14:numSpacing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numSpacing = w14 + "numSpacing";

        /// <summary>
        /// Represents the w14:nvContentPartPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="contentPart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cNvContentPartPr" />, <see cref="cNvPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WordNonVisualContentPartShapeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nvContentPartPr = w14 + "nvContentPartPr";

        /// <summary>
        /// Represents the w14:paraId XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="W.p" />, <see cref="W.tr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Paragraph.ParagraphId, TableRow.ParagraphId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName paraId = w14 + "paraId";

        /// <summary>
        /// Represents the w14:path XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="gradFill" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="fillToRect" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="path" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PathShadeProperties.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="path" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PathShadeProperties.Path.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName path = w14 + "path";

        /// <summary>
        /// Represents the w14:pos XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="gs" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: GradientStop.StopPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pos = w14 + "pos";

        /// <summary>
        /// Represents the w14:props3d XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bevelB" />, <see cref="bevelT" />, <see cref="contourClr" />, <see cref="extrusionClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="contourW" />, <see cref="extrusionH" />, <see cref="prstMaterial" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Properties3D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName props3d = w14 + "props3d";

        /// <summary>
        /// Represents the w14:prst XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bevelB" />, <see cref="bevelT" />, <see cref="camera" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BevelBottom.PresetProfileType, BevelTop.PresetProfileType, Camera.PresetCameraType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName prst = w14 + "prst";

        /// <summary>
        /// Represents the w14:prstDash XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textOutline" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PresetLineDashProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName prstDash = w14 + "prstDash";

        /// <summary>
        /// Represents the w14:prstMaterial XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="props3d" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Properties3D.PresetMaterialType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName prstMaterial = w14 + "prstMaterial";

        /// <summary>
        /// Represents the w14:r XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fillToRect" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FillToRectangle.Right.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName r = w14 + "r";

        /// <summary>
        /// Represents the w14:rad XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="glow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Glow.GlowRadius.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rad = w14 + "rad";

        /// <summary>
        /// Represents the w14:reflection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="algn" />, <see cref="blurRad" />, <see cref="dir" />, <see cref="dist" />, <see cref="endA" />, <see cref="endPos" />, <see cref="fadeDir" />, <see cref="kx" />, <see cref="ky" />, <see cref="stA" />, <see cref="stPos" />, <see cref="sx" />, <see cref="sy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Reflection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName reflection = w14 + "reflection";

        /// <summary>
        /// Represents the w14:rev XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SphereCoordinates.Revolution.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rev = w14 + "rev";

        /// <summary>
        /// Represents the w14:rig XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lightRig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LightRig.LightRigType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rig = w14 + "rig";

        /// <summary>
        /// Represents the w14:rot XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lightRig" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="lat" />, <see cref="lon" />, <see cref="rev" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SphereCoordinates.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rot = w14 + "rot";

        /// <summary>
        /// Represents the w14:round XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textOutline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RoundEmpty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName round = w14 + "round";

        /// <summary>
        /// Represents the w14:sat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Saturation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sat = w14 + "sat";

        /// <summary>
        /// Represents the w14:satMod XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SaturationModulation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName satMod = w14 + "satMod";

        /// <summary>
        /// Represents the w14:satOff XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SaturationOffset.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName satOff = w14 + "satOff";

        /// <summary>
        /// Represents the w14:scaled XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lin" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LinearShadeProperties.Scaled.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scaled = w14 + "scaled";

        /// <summary>
        /// Represents the w14:scene3d XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="camera" />, <see cref="lightRig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Scene3D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scene3d = w14 + "scene3d";

        /// <summary>
        /// Represents the w14:schemeClr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="contourClr" />, <see cref="extrusionClr" />, <see cref="glow" />, <see cref="gs" />, <see cref="shadow" />, <see cref="solidFill" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alpha" />, <see cref="hueMod" />, <see cref="lum" />, <see cref="lumMod" />, <see cref="lumOff" />, <see cref="sat" />, <see cref="satMod" />, <see cref="satOff" />, <see cref="shade" />, <see cref="tint" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SchemeColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName schemeClr = w14 + "schemeClr";

        /// <summary>
        /// Represents the w14:shade XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shade.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shade = w14 + "shade";

        /// <summary>
        /// Represents the w14:shadow XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="algn" />, <see cref="blurRad" />, <see cref="dir" />, <see cref="dist" />, <see cref="kx" />, <see cref="ky" />, <see cref="sx" />, <see cref="sy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shadow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shadow = w14 + "shadow";

        /// <summary>
        /// Represents the w14:solidFill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textFill" />, <see cref="textOutline" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SolidColorFillProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName solidFill = w14 + "solidFill";

        /// <summary>
        /// Represents the w14:srgbClr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="contourClr" />, <see cref="extrusionClr" />, <see cref="glow" />, <see cref="gs" />, <see cref="shadow" />, <see cref="solidFill" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alpha" />, <see cref="hueMod" />, <see cref="lum" />, <see cref="lumMod" />, <see cref="lumOff" />, <see cref="sat" />, <see cref="satMod" />, <see cref="satOff" />, <see cref="shade" />, <see cref="tint" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RgbColorModelHex.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName srgbClr = w14 + "srgbClr";

        /// <summary>
        /// Represents the w14:stA XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.StartingOpacity.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stA = w14 + "stA";

        /// <summary>
        /// Represents the w14:stPos XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.StartPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stPos = w14 + "stPos";

        /// <summary>
        /// Represents the w14:styleSet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="stylisticSets" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StyleSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleSet = w14 + "styleSet";

        /// <summary>
        /// Represents the w14:stylisticSets XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="styleSet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StylisticSets.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stylisticSets = w14 + "stylisticSets";

        /// <summary>
        /// Represents the w14:sx XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />, <see cref="shadow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.HorizontalScalingFactor, Shadow.HorizontalScalingFactor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sx = w14 + "sx";

        /// <summary>
        /// Represents the w14:sy XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="reflection" />, <see cref="shadow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Reflection.VerticalScalingFactor, Shadow.VerticalScalingFactor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sy = w14 + "sy";

        /// <summary>
        /// Represents the w14:t XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fillToRect" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FillToRectangle.Top.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName t = w14 + "t";

        /// <summary>
        /// Represents the w14:textFill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="gradFill" />, <see cref="noFill" />, <see cref="solidFill" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FillTextEffect.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textFill = w14 + "textFill";

        /// <summary>
        /// Represents the w14:textId XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="W.p" />, <see cref="W.tr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Paragraph.TextId, TableRow.TextId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textId = w14 + "textId";

        /// <summary>
        /// Represents the w14:textOutline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="W.rPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bevel" />, <see cref="gradFill" />, <see cref="miter" />, <see cref="noFill" />, <see cref="prstDash" />, <see cref="round" />, <see cref="solidFill" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="algn" />, <see cref="cap" />, <see cref="cmpd" />, <see cref="w" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextOutlineEffect.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textOutline = w14 + "textOutline";

        /// <summary>
        /// Represents the w14:tint XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemeClr" />, <see cref="srgbClr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tint = w14 + "tint";

        /// <summary>
        /// Represents the w14:uncheckedState XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="checkbox" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="font" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UncheckedState.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uncheckedState = w14 + "uncheckedState";

        /// <summary>
        /// Represents the w14:val XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="alpha" />, <see cref="@checked" />, <see cref="checkedState" />, <see cref="cntxtAlts" />, <see cref="conflictMode" />, <see cref="defaultImageDpi" />, <see cref="discardImageEditingData" />, <see cref="docId" />, <see cref="hueMod" />, <see cref="ligatures" />, <see cref="lum" />, <see cref="lumMod" />, <see cref="lumOff" />, <see cref="numForm" />, <see cref="numSpacing" />, <see cref="prstDash" />, <see cref="sat" />, <see cref="satMod" />, <see cref="satOff" />, <see cref="schemeClr" />, <see cref="shade" />, <see cref="srgbClr" />, <see cref="styleSet" />, <see cref="tint" />, <see cref="uncheckedState" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Alpha.Val, Checked.Val, CheckedState.Val, ConflictMode.Val, ContextualAlternatives.Val, DefaultImageDpi.Val, DiscardImageEditingData.Val, DocumentId.Val, HueModulation.Val, Ligatures.Val, Luminance.Val, LuminanceModulation.Val, LuminanceOffset.Val, NumberingFormat.Val, NumberSpacing.Val, PresetLineDashProperties.Val, RgbColorModelHex.Val, Saturation.Val, SaturationModulation.Val, SaturationOffset.Val, SchemeColor.Val, Shade.Val, StyleSet.Val, Tint.Val, UncheckedState.Val.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName val = w14 + "val";

        /// <summary>
        /// Represents the w14:w XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bevelB" />, <see cref="bevelT" />, <see cref="textOutline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BevelBottom.Width, BevelTop.Width, TextOutlineEffect.LineWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName w = w14 + "w";

        /// <summary>
        /// Represents the w14:xfrm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="contentPart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />, <see cref="A.off" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.flipH" />, <see cref="NoNamespace.flipV" />, <see cref="NoNamespace.rot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Transform2D.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xfrm = w14 + "xfrm";
    }
}
