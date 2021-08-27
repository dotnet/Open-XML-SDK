// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:m="http://schemas.openxmlformats.org/officeDocument/2006/math" namespace.
    /// </summary>
    public static class M
    {
        /// <summary>
        /// Defines the XML namespace associated with the m prefix.
        /// </summary>
        public static readonly XNamespace m = "http://schemas.openxmlformats.org/officeDocument/2006/math";

        /// <summary>
        /// Represents the m:acc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="accPr" />, <see cref="e" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Accent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName acc = m + "acc";

        /// <summary>
        /// Represents the m:accPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="acc" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="chr" />, <see cref="ctrlPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AccentProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName accPr = m + "accPr";

        /// <summary>
        /// Represents the m:aln XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="boxPr" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Alignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName aln = m + "aln";

        /// <summary>
        /// Represents the m:alnAt XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="brk" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Break.AlignAt.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alnAt = m + "alnAt";

        /// <summary>
        /// Represents the m:alnScr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sSubSupPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AlignScripts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alnScr = m + "alnScr";

        /// <summary>
        /// Represents the m:argPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="sub" />, <see cref="sup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="argSz" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ArgumentProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName argPr = m + "argPr";

        /// <summary>
        /// Represents the m:argSz XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="argPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ArgumentSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName argSz = m + "argSz";

        /// <summary>
        /// Represents the m:bar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="barPr" />, <see cref="e" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Bar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bar = m + "bar";

        /// <summary>
        /// Represents the m:barPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bar" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />, <see cref="pos" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BarProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName barPr = m + "barPr";

        /// <summary>
        /// Represents the m:baseJc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="eqArrPr" />, <see cref="mPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BaseJustification.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName baseJc = m + "baseJc";

        /// <summary>
        /// Represents the m:begChr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BeginChar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName begChr = m + "begChr";

        /// <summary>
        /// Represents the m:borderBox XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="borderBoxPr" />, <see cref="e" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BorderBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName borderBox = m + "borderBox";

        /// <summary>
        /// Represents the m:borderBoxPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="borderBox" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />, <see cref="hideBot" />, <see cref="hideLeft" />, <see cref="hideRight" />, <see cref="hideTop" />, <see cref="strikeBLTR" />, <see cref="strikeH" />, <see cref="strikeTLBR" />, <see cref="strikeV" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BorderBoxProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName borderBoxPr = m + "borderBoxPr";

        /// <summary>
        /// Represents the m:box XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="boxPr" />, <see cref="e" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Box.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName box = m + "box";

        /// <summary>
        /// Represents the m:boxPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="box" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="aln" />, <see cref="brk" />, <see cref="ctrlPr" />, <see cref="diff" />, <see cref="noBreak" />, <see cref="opEmu" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BoxProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName boxPr = m + "boxPr";

        /// <summary>
        /// Represents the m:brk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="boxPr" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="alnAt" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Break.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName brk = m + "brk";

        /// <summary>
        /// Represents the m:brkBin XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BreakBinary.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName brkBin = m + "brkBin";

        /// <summary>
        /// Represents the m:brkBinSub XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BreakBinarySubtraction.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName brkBinSub = m + "brkBinSub";

        /// <summary>
        /// Represents the m:cGp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnGap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cGp = m + "cGp";

        /// <summary>
        /// Represents the m:cGpRule XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnGapRule.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cGpRule = m + "cGpRule";

        /// <summary>
        /// Represents the m:chr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="accPr" />, <see cref="groupChrPr" />, <see cref="naryPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AccentChar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chr = m + "chr";

        /// <summary>
        /// Represents the m:count XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MatrixColumnCount.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName count = m + "count";

        /// <summary>
        /// Represents the m:cSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cSp = m + "cSp";

        /// <summary>
        /// Represents the m:ctrlPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="accPr" />, <see cref="barPr" />, <see cref="borderBoxPr" />, <see cref="boxPr" />, <see cref="deg" />, <see cref="den" />, <see cref="dPr" />, <see cref="e" />, <see cref="eqArrPr" />, <see cref="fName" />, <see cref="fPr" />, <see cref="funcPr" />, <see cref="groupChrPr" />, <see cref="lim" />, <see cref="limLowPr" />, <see cref="limUppPr" />, <see cref="mPr" />, <see cref="naryPr" />, <see cref="num" />, <see cref="phantPr" />, <see cref="radPr" />, <see cref="sPrePr" />, <see cref="sSubPr" />, <see cref="sSubSupPr" />, <see cref="sSupPr" />, <see cref="sub" />, <see cref="sup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="W.del" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.rPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ControlProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ctrlPr = m + "ctrlPr";

        /// <summary>
        /// Represents the m:d XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dPr" />, <see cref="e" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Delimiter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName d = m + "d";

        /// <summary>
        /// Represents the m:defJc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefaultJustification.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defJc = m + "defJc";

        /// <summary>
        /// Represents the m:deg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rad" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acc" />, <see cref="argPr" />, <see cref="bar" />, <see cref="borderBox" />, <see cref="box" />, <see cref="ctrlPr" />, <see cref="d" />, <see cref="eqArr" />, <see cref="f" />, <see cref="func" />, <see cref="groupChr" />, <see cref="limLow" />, <see cref="limUpp" />, <see cref="m_" />, <see cref="nary" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="phant" />, <see cref="r" />, <see cref="rad" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />, <see cref="sSup" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXml" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Degree.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName deg = m + "deg";

        /// <summary>
        /// Represents the m:degHide XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="radPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HideDegree.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName degHide = m + "degHide";

        /// <summary>
        /// Represents the m:den XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="f" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acc" />, <see cref="argPr" />, <see cref="bar" />, <see cref="borderBox" />, <see cref="box" />, <see cref="ctrlPr" />, <see cref="d" />, <see cref="eqArr" />, <see cref="f" />, <see cref="func" />, <see cref="groupChr" />, <see cref="limLow" />, <see cref="limUpp" />, <see cref="m_" />, <see cref="nary" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="phant" />, <see cref="r" />, <see cref="rad" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />, <see cref="sSup" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXml" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Denominator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName den = m + "den";

        /// <summary>
        /// Represents the m:diff XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="boxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Differential.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName diff = m + "diff";

        /// <summary>
        /// Represents the m:dispDef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DisplayDefaults.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dispDef = m + "dispDef";

        /// <summary>
        /// Represents the m:dPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="d" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="begChr" />, <see cref="ctrlPr" />, <see cref="endChr" />, <see cref="grow" />, <see cref="sepChr" />, <see cref="shp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DelimiterProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dPr = m + "dPr";

        /// <summary>
        /// Represents the m:e XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="acc" />, <see cref="bar" />, <see cref="borderBox" />, <see cref="box" />, <see cref="d" />, <see cref="eqArr" />, <see cref="func" />, <see cref="groupChr" />, <see cref="limLow" />, <see cref="limUpp" />, <see cref="mr" />, <see cref="nary" />, <see cref="phant" />, <see cref="rad" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />, <see cref="sSup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acc" />, <see cref="argPr" />, <see cref="bar" />, <see cref="borderBox" />, <see cref="box" />, <see cref="ctrlPr" />, <see cref="d" />, <see cref="eqArr" />, <see cref="f" />, <see cref="func" />, <see cref="groupChr" />, <see cref="limLow" />, <see cref="limUpp" />, <see cref="m_" />, <see cref="nary" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="phant" />, <see cref="r" />, <see cref="rad" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />, <see cref="sSup" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXml" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Base.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName e = m + "e";

        /// <summary>
        /// Represents the m:endChr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndChar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endChr = m + "endChr";

        /// <summary>
        /// Represents the m:eqArr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="eqArrPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EquationArray.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eqArr = m + "eqArr";

        /// <summary>
        /// Represents the m:eqArrPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="eqArr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="baseJc" />, <see cref="ctrlPr" />, <see cref="maxDist" />, <see cref="objDist" />, <see cref="rSp" />, <see cref="rSpRule" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EquationArrayProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eqArrPr = m + "eqArrPr";

        /// <summary>
        /// Represents the m:f XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="den" />, <see cref="fPr" />, <see cref="num" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Fraction.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName f = m + "f";

        /// <summary>
        /// Represents the m:fName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="func" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acc" />, <see cref="argPr" />, <see cref="bar" />, <see cref="borderBox" />, <see cref="box" />, <see cref="ctrlPr" />, <see cref="d" />, <see cref="eqArr" />, <see cref="f" />, <see cref="func" />, <see cref="groupChr" />, <see cref="limLow" />, <see cref="limUpp" />, <see cref="m_" />, <see cref="nary" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="phant" />, <see cref="r" />, <see cref="rad" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />, <see cref="sSup" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXml" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FunctionName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fName = m + "fName";

        /// <summary>
        /// Represents the m:fPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="f" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />, <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FractionProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fPr = m + "fPr";

        /// <summary>
        /// Represents the m:func XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="fName" />, <see cref="funcPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MathFunction.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName func = m + "func";

        /// <summary>
        /// Represents the m:funcPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="func" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FunctionProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName funcPr = m + "funcPr";

        /// <summary>
        /// Represents the m:groupChr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="groupChrPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupChar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName groupChr = m + "groupChr";

        /// <summary>
        /// Represents the m:groupChrPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="groupChr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="chr" />, <see cref="ctrlPr" />, <see cref="pos" />, <see cref="vertJc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupCharProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName groupChrPr = m + "groupChrPr";

        /// <summary>
        /// Represents the m:grow XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dPr" />, <see cref="naryPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GrowOperators.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grow = m + "grow";

        /// <summary>
        /// Represents the m:hideBot XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="borderBoxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HideBottom.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hideBot = m + "hideBot";

        /// <summary>
        /// Represents the m:hideLeft XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="borderBoxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HideLeft.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hideLeft = m + "hideLeft";

        /// <summary>
        /// Represents the m:hideRight XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="borderBoxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HideRight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hideRight = m + "hideRight";

        /// <summary>
        /// Represents the m:hideTop XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="borderBoxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HideTop.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hideTop = m + "hideTop";

        /// <summary>
        /// Represents the m:interSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InterSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName interSp = m + "interSp";

        /// <summary>
        /// Represents the m:intLim XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IntegralLimitLocation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName intLim = m + "intLim";

        /// <summary>
        /// Represents the m:intraSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IntraSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName intraSp = m + "intraSp";

        /// <summary>
        /// Represents the m:jc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oMathParaPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Justification.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName jc = m + "jc";

        /// <summary>
        /// Represents the m:lim XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="limLow" />, <see cref="limUpp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acc" />, <see cref="argPr" />, <see cref="bar" />, <see cref="borderBox" />, <see cref="box" />, <see cref="ctrlPr" />, <see cref="d" />, <see cref="eqArr" />, <see cref="f" />, <see cref="func" />, <see cref="groupChr" />, <see cref="limLow" />, <see cref="limUpp" />, <see cref="m_" />, <see cref="nary" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="phant" />, <see cref="r" />, <see cref="rad" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />, <see cref="sSup" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXml" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Limit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lim = m + "lim";

        /// <summary>
        /// Represents the m:limLoc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="naryPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LimitLocation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName limLoc = m + "limLoc";

        /// <summary>
        /// Represents the m:limLow XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="lim" />, <see cref="limLowPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LimitLower.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName limLow = m + "limLow";

        /// <summary>
        /// Represents the m:limLowPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="limLow" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LimitLowerProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName limLowPr = m + "limLowPr";

        /// <summary>
        /// Represents the m:limUpp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="lim" />, <see cref="limUppPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LimitUpper.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName limUpp = m + "limUpp";

        /// <summary>
        /// Represents the m:limUppPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="limUpp" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LimitUpperProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName limUppPr = m + "limUppPr";

        /// <summary>
        /// Represents the m:lit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Literal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lit = m + "lit";

        /// <summary>
        /// Represents the m:lMargin XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LeftMargin.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lMargin = m + "lMargin";

        /// <summary>
        /// Represents the m:m XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="mPr" />, <see cref="mr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Matrix.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName m_ = m + "m";

        /// <summary>
        /// Represents the m:mathFont XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MathFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mathFont = m + "mathFont";

        /// <summary>
        /// Represents the m:mathPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="brkBin" />, <see cref="brkBinSub" />, <see cref="defJc" />, <see cref="dispDef" />, <see cref="interSp" />, <see cref="intLim" />, <see cref="intraSp" />, <see cref="lMargin" />, <see cref="mathFont" />, <see cref="naryLim" />, <see cref="postSp" />, <see cref="preSp" />, <see cref="rMargin" />, <see cref="smallFrac" />, <see cref="wrapIndent" />, <see cref="wrapRight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MathProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mathPr = m + "mathPr";

        /// <summary>
        /// Represents the m:maxDist XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="eqArrPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MaxDistribution.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName maxDist = m + "maxDist";

        /// <summary>
        /// Represents the m:mc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mcs" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="mcPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MatrixColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mc = m + "mc";

        /// <summary>
        /// Represents the m:mcJc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MatrixColumnJustification.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mcJc = m + "mcJc";

        /// <summary>
        /// Represents the m:mcPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mc" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="count" />, <see cref="mcJc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MatrixColumnProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mcPr = m + "mcPr";

        /// <summary>
        /// Represents the m:mcs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="mc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MatrixColumns.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mcs = m + "mcs";

        /// <summary>
        /// Represents the m:mPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="m_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="baseJc" />, <see cref="cGp" />, <see cref="cGpRule" />, <see cref="cSp" />, <see cref="ctrlPr" />, <see cref="mcs" />, <see cref="plcHide" />, <see cref="rSp" />, <see cref="rSpRule" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MatrixProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mPr = m + "mPr";

        /// <summary>
        /// Represents the m:mr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="m_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MatrixRow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mr = m + "mr";

        /// <summary>
        /// Represents the m:nary XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="naryPr" />, <see cref="sub" />, <see cref="sup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Nary.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nary = m + "nary";

        /// <summary>
        /// Represents the m:naryLim XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NaryLimitLocation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName naryLim = m + "naryLim";

        /// <summary>
        /// Represents the m:naryPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nary" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="chr" />, <see cref="ctrlPr" />, <see cref="grow" />, <see cref="limLoc" />, <see cref="subHide" />, <see cref="supHide" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NaryProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName naryPr = m + "naryPr";

        /// <summary>
        /// Represents the m:noBreak XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="boxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoBreak.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noBreak = m + "noBreak";

        /// <summary>
        /// Represents the m:nor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NormalText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nor = m + "nor";

        /// <summary>
        /// Represents the m:num XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="f" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acc" />, <see cref="argPr" />, <see cref="bar" />, <see cref="borderBox" />, <see cref="box" />, <see cref="ctrlPr" />, <see cref="d" />, <see cref="eqArr" />, <see cref="f" />, <see cref="func" />, <see cref="groupChr" />, <see cref="limLow" />, <see cref="limUpp" />, <see cref="m_" />, <see cref="nary" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="phant" />, <see cref="r" />, <see cref="rad" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />, <see cref="sSup" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXml" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Numerator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName num = m + "num";

        /// <summary>
        /// Represents the m:objDist XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="eqArrPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ObjectDistribution.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName objDist = m + "objDist";

        /// <summary>
        /// Represents the m:oMath XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acc" />, <see cref="bar" />, <see cref="borderBox" />, <see cref="box" />, <see cref="d" />, <see cref="eqArr" />, <see cref="f" />, <see cref="func" />, <see cref="groupChr" />, <see cref="limLow" />, <see cref="limUpp" />, <see cref="m_" />, <see cref="nary" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="phant" />, <see cref="r" />, <see cref="rad" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />, <see cref="sSup" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXml" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeMath.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oMath = m + "oMath";

        /// <summary>
        /// Represents the m:oMathPara XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="oMath" />, <see cref="oMathParaPr" />, <see cref="r" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.r" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Paragraph.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oMathPara = m + "oMathPara";

        /// <summary>
        /// Represents the m:oMathParaPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oMathPara" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="jc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParagraphProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oMathParaPr = m + "oMathParaPr";

        /// <summary>
        /// Represents the m:opEmu XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="boxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OperatorEmulator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName opEmu = m + "opEmu";

        /// <summary>
        /// Represents the m:phant XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="phantPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Phantom.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName phant = m + "phant";

        /// <summary>
        /// Represents the m:phantPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="phant" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />, <see cref="show" />, <see cref="transp" />, <see cref="zeroAsc" />, <see cref="zeroDesc" />, <see cref="zeroWid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PhantomProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName phantPr = m + "phantPr";

        /// <summary>
        /// Represents the m:plcHide XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HidePlaceholder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName plcHide = m + "plcHide";

        /// <summary>
        /// Represents the m:pos XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="barPr" />, <see cref="groupChrPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Position.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pos = m + "pos";

        /// <summary>
        /// Represents the m:postSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PostSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName postSp = m + "postSp";

        /// <summary>
        /// Represents the m:preSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName preSp = m + "preSp";

        /// <summary>
        /// Represents the m:r XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rPr" />, <see cref="t" />, <see cref="W.annotationRef" />, <see cref="W.br" />, <see cref="W.commentReference" />, <see cref="W.continuationSeparator" />, <see cref="W.cr" />, <see cref="W.dayLong" />, <see cref="W.dayShort" />, <see cref="W.delInstrText" />, <see cref="W.delText" />, <see cref="W.drawing" />, <see cref="W.endnoteRef" />, <see cref="W.endnoteReference" />, <see cref="W.fldChar" />, <see cref="W.footnoteRef" />, <see cref="W.footnoteReference" />, <see cref="W.instrText" />, <see cref="W.lastRenderedPageBreak" />, <see cref="W.monthLong" />, <see cref="W.monthShort" />, <see cref="W.noBreakHyphen" />, <see cref="W.@object" />, <see cref="W.pgNum" />, <see cref="W.pict" />, <see cref="W.ptab" />, <see cref="W.rPr" />, <see cref="W.ruby" />, <see cref="W.separator" />, <see cref="W.softHyphen" />, <see cref="W.sym" />, <see cref="W.t" />, <see cref="W.tab" />, <see cref="W.yearLong" />, <see cref="W.yearShort" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Run.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName r = m + "r";

        /// <summary>
        /// Represents the m:rad XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="deg" />, <see cref="e" />, <see cref="radPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Radical.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rad = m + "rad";

        /// <summary>
        /// Represents the m:radPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rad" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />, <see cref="degHide" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RadicalProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName radPr = m + "radPr";

        /// <summary>
        /// Represents the m:rMargin XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RightMargin.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rMargin = m + "rMargin";

        /// <summary>
        /// Represents the m:rPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="r" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="aln" />, <see cref="brk" />, <see cref="lit" />, <see cref="nor" />, <see cref="scr" />, <see cref="sty" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RunProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rPr = m + "rPr";

        /// <summary>
        /// Represents the m:rSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="eqArrPr" />, <see cref="mPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rSp = m + "rSp";

        /// <summary>
        /// Represents the m:rSpRule XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="eqArrPr" />, <see cref="mPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowSpacingRule.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rSpRule = m + "rSpRule";

        /// <summary>
        /// Represents the m:scr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Script.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scr = m + "scr";

        /// <summary>
        /// Represents the m:sepChr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SeparatorChar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sepChr = m + "sepChr";

        /// <summary>
        /// Represents the m:show XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="phantPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowPhantom.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName show = m + "show";

        /// <summary>
        /// Represents the m:shp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shp = m + "shp";

        /// <summary>
        /// Represents the m:smallFrac XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SmallFraction.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName smallFrac = m + "smallFrac";

        /// <summary>
        /// Represents the m:sPre XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="sPrePr" />, <see cref="sub" />, <see cref="sup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreSubSuper.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sPre = m + "sPre";

        /// <summary>
        /// Represents the m:sPrePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sPre" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreSubSuperProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sPrePr = m + "sPrePr";

        /// <summary>
        /// Represents the m:sSub XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="sSubPr" />, <see cref="sub" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Subscript.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sSub = m + "sSub";

        /// <summary>
        /// Represents the m:sSubPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sSub" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SubscriptProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sSubPr = m + "sSubPr";

        /// <summary>
        /// Represents the m:sSubSup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="sSubSupPr" />, <see cref="sub" />, <see cref="sup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SubSuperscript.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sSubSup = m + "sSubSup";

        /// <summary>
        /// Represents the m:sSubSupPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sSubSup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alnScr" />, <see cref="ctrlPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SubSuperscriptProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sSubSupPr = m + "sSubSupPr";

        /// <summary>
        /// Represents the m:sSup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="deg" />, <see cref="den" />, <see cref="e" />, <see cref="fName" />, <see cref="lim" />, <see cref="num" />, <see cref="oMath" />, <see cref="sub" />, <see cref="sup" />, <see cref="W.bdo" />, <see cref="W.customXml" />, <see cref="W.del" />, <see cref="W.dir" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveTo" />, <see cref="W.p" />, <see cref="W.rt" />, <see cref="W.rubyBase" />, <see cref="W.sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="sSupPr" />, <see cref="sup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Superscript.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sSup = m + "sSup";

        /// <summary>
        /// Represents the m:sSupPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sSup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ctrlPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SuperscriptProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sSupPr = m + "sSupPr";

        /// <summary>
        /// Represents the m:strikeBLTR XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="borderBoxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StrikeBottomLeftToTopRight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strikeBLTR = m + "strikeBLTR";

        /// <summary>
        /// Represents the m:strikeH XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="borderBoxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StrikeHorizontal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strikeH = m + "strikeH";

        /// <summary>
        /// Represents the m:strikeTLBR XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="borderBoxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StrikeTopLeftToBottomRight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strikeTLBR = m + "strikeTLBR";

        /// <summary>
        /// Represents the m:strikeV XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="borderBoxPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StrikeVertical.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strikeV = m + "strikeV";

        /// <summary>
        /// Represents the m:sty XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Style.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sty = m + "sty";

        /// <summary>
        /// Represents the m:sub XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nary" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acc" />, <see cref="argPr" />, <see cref="bar" />, <see cref="borderBox" />, <see cref="box" />, <see cref="ctrlPr" />, <see cref="d" />, <see cref="eqArr" />, <see cref="f" />, <see cref="func" />, <see cref="groupChr" />, <see cref="limLow" />, <see cref="limUpp" />, <see cref="m_" />, <see cref="nary" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="phant" />, <see cref="r" />, <see cref="rad" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />, <see cref="sSup" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXml" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SubArgument.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sub = m + "sub";

        /// <summary>
        /// Represents the m:subHide XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="naryPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HideSubArgument.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName subHide = m + "subHide";

        /// <summary>
        /// Represents the m:sup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nary" />, <see cref="sPre" />, <see cref="sSubSup" />, <see cref="sSup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="acc" />, <see cref="argPr" />, <see cref="bar" />, <see cref="borderBox" />, <see cref="box" />, <see cref="ctrlPr" />, <see cref="d" />, <see cref="eqArr" />, <see cref="f" />, <see cref="func" />, <see cref="groupChr" />, <see cref="limLow" />, <see cref="limUpp" />, <see cref="m_" />, <see cref="nary" />, <see cref="oMath" />, <see cref="oMathPara" />, <see cref="phant" />, <see cref="r" />, <see cref="rad" />, <see cref="sPre" />, <see cref="sSub" />, <see cref="sSubSup" />, <see cref="sSup" />, <see cref="W.bookmarkEnd" />, <see cref="W.bookmarkStart" />, <see cref="W.commentRangeEnd" />, <see cref="W.commentRangeStart" />, <see cref="W.contentPart" />, <see cref="W.customXml" />, <see cref="W.customXmlDelRangeEnd" />, <see cref="W.customXmlDelRangeStart" />, <see cref="W.customXmlInsRangeEnd" />, <see cref="W.customXmlInsRangeStart" />, <see cref="W.customXmlMoveFromRangeEnd" />, <see cref="W.customXmlMoveFromRangeStart" />, <see cref="W.customXmlMoveToRangeEnd" />, <see cref="W.customXmlMoveToRangeStart" />, <see cref="W.del" />, <see cref="W.fldSimple" />, <see cref="W.hyperlink" />, <see cref="W.ins" />, <see cref="W.moveFrom" />, <see cref="W.moveFromRangeEnd" />, <see cref="W.moveFromRangeStart" />, <see cref="W.moveTo" />, <see cref="W.moveToRangeEnd" />, <see cref="W.moveToRangeStart" />, <see cref="W.permEnd" />, <see cref="W.permStart" />, <see cref="W.proofErr" />, <see cref="W.sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SuperArgument.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sup = m + "sup";

        /// <summary>
        /// Represents the m:supHide XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="naryPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HideSuperArgument.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName supHide = m + "supHide";

        /// <summary>
        /// Represents the m:t XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="XML.space" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Text.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName t = m + "t";

        /// <summary>
        /// Represents the m:transp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="phantPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Transparent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName transp = m + "transp";

        /// <summary>
        /// Represents the m:type XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FractionType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName type = m + "type";

        /// <summary>
        /// Represents the m:val XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="aln" />, <see cref="alnScr" />, <see cref="argSz" />, <see cref="baseJc" />, <see cref="begChr" />, <see cref="brk" />, <see cref="brkBin" />, <see cref="brkBinSub" />, <see cref="cGp" />, <see cref="cGpRule" />, <see cref="chr" />, <see cref="count" />, <see cref="cSp" />, <see cref="defJc" />, <see cref="degHide" />, <see cref="diff" />, <see cref="dispDef" />, <see cref="endChr" />, <see cref="grow" />, <see cref="hideBot" />, <see cref="hideLeft" />, <see cref="hideRight" />, <see cref="hideTop" />, <see cref="interSp" />, <see cref="intLim" />, <see cref="intraSp" />, <see cref="jc" />, <see cref="limLoc" />, <see cref="lit" />, <see cref="lMargin" />, <see cref="mathFont" />, <see cref="maxDist" />, <see cref="mcJc" />, <see cref="naryLim" />, <see cref="noBreak" />, <see cref="nor" />, <see cref="objDist" />, <see cref="opEmu" />, <see cref="plcHide" />, <see cref="pos" />, <see cref="postSp" />, <see cref="preSp" />, <see cref="rMargin" />, <see cref="rSp" />, <see cref="rSpRule" />, <see cref="scr" />, <see cref="sepChr" />, <see cref="show" />, <see cref="shp" />, <see cref="smallFrac" />, <see cref="strikeBLTR" />, <see cref="strikeH" />, <see cref="strikeTLBR" />, <see cref="strikeV" />, <see cref="sty" />, <see cref="subHide" />, <see cref="supHide" />, <see cref="transp" />, <see cref="type" />, <see cref="vertJc" />, <see cref="wrapIndent" />, <see cref="wrapRight" />, <see cref="zeroAsc" />, <see cref="zeroDesc" />, <see cref="zeroWid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AccentChar.Val, Alignment.Val, AlignScripts.Val, ArgumentSize.Val, BaseJustification.Val, BeginChar.Val, Break.Val, BreakBinary.Val, BreakBinarySubtraction.Val, ColumnGap.Val, ColumnGapRule.Val, ColumnSpacing.Val, DefaultJustification.Val, Differential.Val, DisplayDefaults.Val, EndChar.Val, FractionType.Val, GrowOperators.Val, HideBottom.Val, HideDegree.Val, HideLeft.Val, HidePlaceholder.Val, HideRight.Val, HideSubArgument.Val, HideSuperArgument.Val, HideTop.Val, IntegralLimitLocation.Val, InterSpacing.Val, IntraSpacing.Val, Justification.Val, LeftMargin.Val, LimitLocation.Val, Literal.Val, MathFont.Val, MatrixColumnCount.Val, MatrixColumnJustification.Val, MaxDistribution.Val, NaryLimitLocation.Val, NoBreak.Val, NormalText.Val, ObjectDistribution.Val, OperatorEmulator.Val, Position.Val, PostSpacing.Val, PreSpacing.Val, RightMargin.Val, RowSpacing.Val, RowSpacingRule.Val, Script.Val, SeparatorChar.Val, Shape.Val, ShowPhantom.Val, SmallFraction.Val, StrikeBottomLeftToTopRight.Val, StrikeHorizontal.Val, StrikeTopLeftToBottomRight.Val, StrikeVertical.Val, Style.Val, Transparent.Val, VerticalJustification.Val, WrapIndent.Val, WrapRight.Val, ZeroAscent.Val, ZeroDescent.Val, ZeroWidth.Val.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName val = m + "val";

        /// <summary>
        /// Represents the m:vertJc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="groupChrPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VerticalJustification.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vertJc = m + "vertJc";

        /// <summary>
        /// Represents the m:wrapIndent XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WrapIndent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrapIndent = m + "wrapIndent";

        /// <summary>
        /// Represents the m:wrapRight XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mathPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WrapRight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrapRight = m + "wrapRight";

        /// <summary>
        /// Represents the m:zeroAsc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="phantPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ZeroAscent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName zeroAsc = m + "zeroAsc";

        /// <summary>
        /// Represents the m:zeroDesc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="phantPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ZeroDescent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName zeroDesc = m + "zeroDesc";

        /// <summary>
        /// Represents the m:zeroWid XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="phantPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ZeroWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName zeroWid = m + "zeroWid";
    }
}
