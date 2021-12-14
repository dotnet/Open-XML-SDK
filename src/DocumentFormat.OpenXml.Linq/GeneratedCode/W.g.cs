// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:w="http://schemas.openxmlformats.org/wordprocessingml/2006/main" namespace.
    /// </summary>
    public static class W
    {
        /// <summary>
        /// Defines the XML namespace associated with the w prefix.
        /// </summary>
        public static readonly XNamespace w = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";

        /// <summary>
        /// Represents the w:abstractNum XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numbering" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="lvl" />, <see cref="multiLevelType" />, <see cref="name" />, <see cref="nsid" />, <see cref="numStyleLink" />, <see cref="styleLink" />, <see cref="tmpl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="abstractNumId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AbstractNum.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName abstractNum = w + "abstractNum";

        /// <summary>
        /// Represents the w:abstractNumId XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="num" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AbstractNumId.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="abstractNum" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AbstractNum.AbstractNumberId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName abstractNumId = w + "abstractNumId";

        /// <summary>
        /// Represents the w:accent1 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Accent1.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName accent1 = w + "accent1";

        /// <summary>
        /// Represents the w:accent2 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Accent2.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName accent2 = w + "accent2";

        /// <summary>
        /// Represents the w:accent3 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Accent3.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName accent3 = w + "accent3";

        /// <summary>
        /// Represents the w:accent4 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Accent4.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName accent4 = w + "accent4";

        /// <summary>
        /// Represents the w:accent5 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Accent5.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName accent5 = w + "accent5";

        /// <summary>
        /// Represents the w:accent6 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Accent6.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName accent6 = w + "accent6";

        /// <summary>
        /// Represents the w:active XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="recipientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Active.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName active = w + "active";

        /// <summary>
        /// Represents the w:activeRecord XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ActiveRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName activeRecord = w + "activeRecord";

        /// <summary>
        /// Represents the w:activeWritingStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="appName" />, <see cref="checkStyle" />, <see cref="dllVersion" />, <see cref="lang" />, <see cref="nlCheck" />, <see cref="vendorID" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ActiveWritingStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName activeWritingStyle = w + "activeWritingStyle";

        /// <summary>
        /// Represents the w:actualPg XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="readModeInkLockDown" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ReadModeInkLockDown.UseActualPages.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName actualPg = w + "actualPg";

        /// <summary>
        /// Represents the w:addressFieldName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AddressFieldName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName addressFieldName = w + "addressFieldName";

        /// <summary>
        /// Represents the w:adjustLineHeightInTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AdjustLineHeightInTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName adjustLineHeightInTable = w + "adjustLineHeightInTable";

        /// <summary>
        /// Represents the w:adjustRightInd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AdjustRightIndent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName adjustRightInd = w + "adjustRightInd";

        /// <summary>
        /// Represents the w:after XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="spacing" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SpacingBetweenLines.After.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName after = w + "after";

        /// <summary>
        /// Represents the w:afterAutospacing XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="spacing" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SpacingBetweenLines.AfterAutoSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName afterAutospacing = w + "afterAutospacing";

        /// <summary>
        /// Represents the w:afterLines XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="spacing" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SpacingBetweenLines.AfterLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName afterLines = w + "afterLines";

        /// <summary>
        /// Represents the w:algIdExt XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.AlgorithmIdExtensibility, WriteProtection.AlgorithmIdExtensibility.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName algIdExt = w + "algIdExt";

        /// <summary>
        /// Represents the w:algIdExtSource XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.AlgorithmIdExtensibilitySource, WriteProtection.AlgorithmIdExtensibilitySource.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName algIdExtSource = w + "algIdExtSource";

        /// <summary>
        /// Represents the w:algorithmName XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.AlgorithmName, WriteProtection.AlgorithmName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName algorithmName = w + "algorithmName";

        /// <summary>
        /// Represents the w:alias XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtAlias.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alias = w + "alias";

        /// <summary>
        /// Represents the w:aliases XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Aliases.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName aliases = w + "aliases";

        /// <summary>
        /// Represents the w:alignBordersAndEdges XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AlignBorderAndEdges.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alignBordersAndEdges = w + "alignBordersAndEdges";

        /// <summary>
        /// Represents the w:alignment XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ptab" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PositionalTab.Alignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alignment = w + "alignment";

        /// <summary>
        /// Represents the w:alignTablesRowByRow XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AlignTablesRowByRow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alignTablesRowByRow = w + "alignTablesRowByRow";

        /// <summary>
        /// Represents the w:all XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="types" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocPartTypes.All.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName all = w + "all";

        /// <summary>
        /// Represents the w:allowPNG XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AllowPNG.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName allowPNG = w + "allowPNG";

        /// <summary>
        /// Represents the w:allowSpaceOfSameStyleInTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AllowSpaceOfSameStyleInTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName allowSpaceOfSameStyleInTable = w + "allowSpaceOfSameStyleInTable";

        /// <summary>
        /// Represents the w:allStyles XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.AllStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName allStyles = w + "allStyles";

        /// <summary>
        /// Represents the w:altChunk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="body" />, <see cref="comment" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="tc" />, <see cref="txbxContent" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altChunkPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AltChunk.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName altChunk = w + "altChunk";

        /// <summary>
        /// Represents the w:altChunkPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="altChunk" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="matchSrc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AltChunkProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName altChunkPr = w + "altChunkPr";

        /// <summary>
        /// Represents the w:alternateStyleNames XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.AlternateStyleNames.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alternateStyleNames = w + "alternateStyleNames";

        /// <summary>
        /// Represents the w:altName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AltName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName altName = w + "altName";

        /// <summary>
        /// Represents the w:alwaysMergeEmptyNamespace XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AlwaysMergeEmptyNamespace.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alwaysMergeEmptyNamespace = w + "alwaysMergeEmptyNamespace";

        /// <summary>
        /// Represents the w:alwaysShowPlaceholderText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AlwaysShowPlaceholderText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alwaysShowPlaceholderText = w + "alwaysShowPlaceholderText";

        /// <summary>
        /// Represents the w:anchor XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="hyperlink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Hyperlink.Anchor, HyperlinkRuby.Anchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName anchor = w + "anchor";

        /// <summary>
        /// Represents the w:anchorLock XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.AnchorLock.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName anchorLock = w + "anchorLock";

        /// <summary>
        /// Represents the w:annotationRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnnotationReferenceMark.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName annotationRef = w + "annotationRef";

        /// <summary>
        /// Represents the w:applyBreakingRules XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ApplyBreakingRules.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName applyBreakingRules = w + "applyBreakingRules";

        /// <summary>
        /// Represents the w:appName XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="activeWritingStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ActiveWritingStyle.ApplicationName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName appName = w + "appName";

        /// <summary>
        /// Represents the w:ascii XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rFonts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RunFonts.Ascii.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ascii = w + "ascii";

        /// <summary>
        /// Represents the w:asciiTheme XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rFonts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RunFonts.AsciiTheme.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName asciiTheme = w + "asciiTheme";

        /// <summary>
        /// Represents the w:attachedSchema XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AttachedSchema.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName attachedSchema = w + "attachedSchema";

        /// <summary>
        /// Represents the w:attachedTemplate XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AttachedTemplate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName attachedTemplate = w + "attachedTemplate";

        /// <summary>
        /// Represents the w:attr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customXmlPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="name" />, <see cref="uri" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlAttribute.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName attr = w + "attr";

        /// <summary>
        /// Represents the w:author XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cellDel" />, <see cref="cellIns" />, <see cref="cellMerge" />, <see cref="comment" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeStart" />, <see cref="numberingChange" />, <see cref="pPrChange" />, <see cref="rPrChange" />, <see cref="sectPrChange" />, <see cref="tblPrChange" />, <see cref="tblPrExChange" />, <see cref="tcPrChange" />, <see cref="trPrChange" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CellDeletion.Author, CellInsertion.Author, CellMerge.Author, Comment.Author, ConflictDeletion.Author, ConflictInsertion.Author, CustomXmlConflictDeletionRangeStart.Author, CustomXmlConflictInsertionRangeStart.Author, CustomXmlDelRangeStart.Author, CustomXmlInsRangeStart.Author, CustomXmlMoveFromRangeStart.Author, CustomXmlMoveToRangeStart.Author, Deleted.Author, DeletedMathControl.Author, DeletedRun.Author, Inserted.Author, InsertedMathControl.Author, InsertedRun.Author, MoveFrom.Author, MoveFromMathControl.Author, MoveFromRangeStart.Author, MoveFromRun.Author, MoveTo.Author, MoveToMathControl.Author, MoveToRangeStart.Author, MoveToRun.Author, NumberingChange.Author, ParagraphMarkRunPropertiesChange.Author, ParagraphPropertiesChange.Author, RunConflictDeletion.Author, RunConflictInsertion.Author, RunPropertiesChange.Author, SectionPropertiesChange.Author, TableCellPropertiesChange.Author, TablePropertiesChange.Author, TablePropertyExceptionsChange.Author, TableRowPropertiesChange.Author.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName author = w + "author";

        /// <summary>
        /// Represents the w:autoCaption XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="autoCaptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="caption" />, <see cref="name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoCaption.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoCaption = w + "autoCaption";

        /// <summary>
        /// Represents the w:autoCaptions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="captions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="autoCaption" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoCaptions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoCaptions = w + "autoCaptions";

        /// <summary>
        /// Represents the w:autofitToFirstFixedWidthCell XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutofitToFirstFixedWidthCell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autofitToFirstFixedWidthCell = w + "autofitToFirstFixedWidthCell";

        /// <summary>
        /// Represents the w:autoFormatOverride XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoFormatOverride.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoFormatOverride = w + "autoFormatOverride";

        /// <summary>
        /// Represents the w:autoHyphenation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoHyphenation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoHyphenation = w + "autoHyphenation";

        /// <summary>
        /// Represents the w:autoRedefine XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoRedefine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoRedefine = w + "autoRedefine";

        /// <summary>
        /// Represents the w:autoSpaceDE XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoSpaceDE.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoSpaceDE = w + "autoSpaceDE";

        /// <summary>
        /// Represents the w:autoSpaceDN XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoSpaceDN.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoSpaceDN = w + "autoSpaceDN";

        /// <summary>
        /// Represents the w:autoSpaceLikeWord95 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoSpaceLikeWord95.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoSpaceLikeWord95 = w + "autoSpaceLikeWord95";

        /// <summary>
        /// Represents the w:b XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Bold.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName b = w + "b";

        /// <summary>
        /// Represents the w:background XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="document" />, <see cref="glossaryDocument" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="V.background" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentBackground.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName background = w + "background";

        /// <summary>
        /// Represents the w:balanceSingleByteDoubleByteWidth XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BalanceSingleByteDoubleByteWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName balanceSingleByteDoubleByteWidth = w + "balanceSingleByteDoubleByteWidth";

        /// <summary>
        /// Represents the w:bar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pBdr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BarBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bar = w + "bar";

        /// <summary>
        /// Represents the w:basedOn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BasedOn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName basedOn = w + "basedOn";

        /// <summary>
        /// Represents the w:bCs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BoldComplexScript.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bCs = w + "bCs";

        /// <summary>
        /// Represents the w:bdo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bdo" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="sdt" />, <see cref="subDoc" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BidirectionalOverride.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bdo = w + "bdo";

        /// <summary>
        /// Represents the w:bdr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Border.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bdr = w + "bdr";

        /// <summary>
        /// Represents the w:before XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="spacing" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SpacingBetweenLines.Before.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName before = w + "before";

        /// <summary>
        /// Represents the w:beforeAutospacing XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="spacing" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SpacingBetweenLines.BeforeAutoSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName beforeAutospacing = w + "beforeAutospacing";

        /// <summary>
        /// Represents the w:beforeLines XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="spacing" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SpacingBetweenLines.BeforeLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName beforeLines = w + "beforeLines";

        /// <summary>
        /// Represents the w:behavior XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="behaviors" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Behavior.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName behavior = w + "behavior";

        /// <summary>
        /// Represents the w:behaviors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPartPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="behavior" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Behaviors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName behaviors = w + "behaviors";

        /// <summary>
        /// Represents the w:between XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pBdr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BetweenBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName between = w + "between";

        /// <summary>
        /// Represents the w:bg1 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Background1.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bg1 = w + "bg1";

        /// <summary>
        /// Represents the w:bg2 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Background2.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bg2 = w + "bg2";

        /// <summary>
        /// Represents the w:bibliography XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentBibliography.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bibliography = w + "bibliography";

        /// <summary>
        /// Represents the w:bidi XML element and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />, <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BiDi.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lang" />, <see cref="themeFontLang" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Languages.Bidi, ThemeFontLanguages.Bidi.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bidi = w + "bidi";

        /// <summary>
        /// Represents the w:bidiVisual XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BiDiVisual.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bidiVisual = w + "bidiVisual";

        /// <summary>
        /// Represents the w:blockQuote XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="div" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BlockQuote.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName blockQuote = w + "blockQuote";

        /// <summary>
        /// Represents the w:body XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="document" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altChunk" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="sectPr" />, <see cref="tbl" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Body.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName body = w + "body";

        /// <summary>
        /// Represents the w:bodyDiv XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="div" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BodyDiv.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bodyDiv = w + "bodyDiv";

        /// <summary>
        /// Represents the w:bookFoldPrinting XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BookFoldPrinting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bookFoldPrinting = w + "bookFoldPrinting";

        /// <summary>
        /// Represents the w:bookFoldPrintingSheets XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BookFoldPrintingSheets.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bookFoldPrintingSheets = w + "bookFoldPrintingSheets";

        /// <summary>
        /// Represents the w:bookFoldRevPrinting XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BookFoldReversePrinting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bookFoldRevPrinting = w + "bookFoldRevPrinting";

        /// <summary>
        /// Represents the w:bookmarkEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="displacedByCustomXml" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BookmarkEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bookmarkEnd = w + "bookmarkEnd";

        /// <summary>
        /// Represents the w:bookmarkStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="colFirst" />, <see cref="colLast" />, <see cref="displacedByCustomXml" />, <see cref="id" />, <see cref="name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BookmarkStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bookmarkStart = w + "bookmarkStart";

        /// <summary>
        /// Represents the w:bordersDoNotSurroundFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BordersDoNotSurroundFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bordersDoNotSurroundFooter = w + "bordersDoNotSurroundFooter";

        /// <summary>
        /// Represents the w:bordersDoNotSurroundHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BordersDoNotSurroundHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bordersDoNotSurroundHeader = w + "bordersDoNotSurroundHeader";

        /// <summary>
        /// Represents the w:bottom XML elements and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="divBdr" />, <see cref="pBdr" />, <see cref="pgBorders" />, <see cref="tblBorders" />, <see cref="tblCellMar" />, <see cref="tcBorders" />, <see cref="tcMar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="type" />, <see cref="val" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BottomBorder, BottomMargin.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgMar" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageMargin.Bottom.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bottom = w + "bottom";

        /// <summary>
        /// Represents the w:bottomFromText XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TablePositionProperties.BottomFromText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bottomFromText = w + "bottomFromText";

        /// <summary>
        /// Represents the w:br XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="clear" />, <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Break.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName br = w + "br";

        /// <summary>
        /// Represents the w:cachedColBalance XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CachedColumnBalance.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cachedColBalance = w + "cachedColBalance";

        /// <summary>
        /// Represents the w:calcOnExit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ffData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculateOnExit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calcOnExit = w + "calcOnExit";

        /// <summary>
        /// Represents the w:calendar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="date" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Calendar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calendar = w + "calendar";

        /// <summary>
        /// Represents the w:cantSplit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CantSplit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cantSplit = w + "cantSplit";

        /// <summary>
        /// Represents the w:caps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Caps.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName caps = w + "caps";

        /// <summary>
        /// Represents the w:caption XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="captions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="chapNum" />, <see cref="heading" />, <see cref="name" />, <see cref="noLabel" />, <see cref="numFmt" />, <see cref="pos" />, <see cref="sep" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Caption.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="autoCaption" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AutoCaption.Caption.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName caption = w + "caption";

        /// <summary>
        /// Represents the w:captions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="autoCaptions" />, <see cref="caption" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Captions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName captions = w + "captions";

        /// <summary>
        /// Represents the w:category XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPartPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="gallery" />, <see cref="name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Category.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName category = w + "category";

        /// <summary>
        /// Represents the w:cellDel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellDeletion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cellDel = w + "cellDel";

        /// <summary>
        /// Represents the w:cellIns XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellInsertion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cellIns = w + "cellIns";

        /// <summary>
        /// Represents the w:cellMerge XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />, <see cref="vMerge" />, <see cref="vMergeOrig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellMerge.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cellMerge = w + "cellMerge";

        /// <summary>
        /// Represents the w:chapNum XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="caption" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Caption.ChapterNumber.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chapNum = w + "chapNum";

        /// <summary>
        /// Represents the w:chapSep XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgNumType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageNumberType.ChapterSeparator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chapSep = w + "chapSep";

        /// <summary>
        /// Represents the w:chapStyle XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgNumType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageNumberType.ChapterStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chapStyle = w + "chapStyle";

        /// <summary>
        /// Represents the w:char XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="sym" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SymbolChar.Char.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @char = w + "char";

        /// <summary>
        /// Represents the w:characterSet XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="charset" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FontCharSet.StrictCharacterSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName characterSet = w + "characterSet";

        /// <summary>
        /// Represents the w:characterSpacingControl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CharacterSpacingControl.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName characterSpacingControl = w + "characterSpacingControl";

        /// <summary>
        /// Represents the w:charset XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="characterSet" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontCharSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName charset = w + "charset";

        /// <summary>
        /// Represents the w:charSpace XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="docGrid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocGrid.CharacterSpace.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName charSpace = w + "charSpace";

        /// <summary>
        /// Represents the w:checkBox XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ffData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="@checked" />, <see cref="@default" />, <see cref="size" />, <see cref="sizeAuto" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CheckBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName checkBox = w + "checkBox";

        /// <summary>
        /// Represents the w:checked XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="checkBox" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Checked.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @checked = w + "checked";

        /// <summary>
        /// Represents the w:checkErrors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CheckErrors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName checkErrors = w + "checkErrors";

        /// <summary>
        /// Represents the w:checkStyle XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="activeWritingStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ActiveWritingStyle.CheckStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName checkStyle = w + "checkStyle";

        /// <summary>
        /// Represents the w:citation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentCitation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName citation = w + "citation";

        /// <summary>
        /// Represents the w:clear XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="br" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Break.Clear.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clear = w + "clear";

        /// <summary>
        /// Represents the w:clearFormatting XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.ClearFormatting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clearFormatting = w + "clearFormatting";

        /// <summary>
        /// Represents the w:clickAndTypeStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ClickAndTypeStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clickAndTypeStyle = w + "clickAndTypeStyle";

        /// <summary>
        /// Represents the w:clrSchemeMapping XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="accent1" />, <see cref="accent2" />, <see cref="accent3" />, <see cref="accent4" />, <see cref="accent5" />, <see cref="accent6" />, <see cref="bg1" />, <see cref="bg2" />, <see cref="followedHyperlink" />, <see cref="hyperlink" />, <see cref="t1" />, <see cref="t2" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorSchemeMapping.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName clrSchemeMapping = w + "clrSchemeMapping";

        /// <summary>
        /// Represents the w:cnfStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />, <see cref="tcPr" />, <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="evenHBand" />, <see cref="evenVBand" />, <see cref="firstColumn" />, <see cref="firstRow" />, <see cref="firstRowFirstColumn" />, <see cref="firstRowLastColumn" />, <see cref="lastColumn" />, <see cref="lastRow" />, <see cref="lastRowFirstColumn" />, <see cref="lastRowLastColumn" />, <see cref="oddHBand" />, <see cref="oddVBand" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormatStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cnfStyle = w + "cnfStyle";

        /// <summary>
        /// Represents the w:code XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgSz" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageSize.Code.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName code = w + "code";

        /// <summary>
        /// Represents the w:col XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cols" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="space" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Column.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName col = w + "col";

        /// <summary>
        /// Represents the w:colDelim XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="odso" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnDelimiter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colDelim = w + "colDelim";

        /// <summary>
        /// Represents the w:colFirst XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bookmarkStart" />, <see cref="moveFromRangeStart" />, <see cref="moveToRangeStart" />, <see cref="permStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BookmarkStart.ColumnFirst, MoveFromRangeStart.ColumnFirst, MoveToRangeStart.ColumnFirst, PermStart.ColumnFirst.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colFirst = w + "colFirst";

        /// <summary>
        /// Represents the w:colLast XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bookmarkStart" />, <see cref="moveFromRangeStart" />, <see cref="moveToRangeStart" />, <see cref="permStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BookmarkStart.ColumnLast, MoveFromRangeStart.ColumnLast, MoveToRangeStart.ColumnLast, PermStart.ColumnLast.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colLast = w + "colLast";

        /// <summary>
        /// Represents the w:color XML element and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="framesetSplitbar" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Color.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="background" />, <see cref="bar" />, <see cref="bdr" />, <see cref="between" />, <see cref="bottom" />, <see cref="end" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="left" />, <see cref="right" />, <see cref="shd" />, <see cref="start" />, <see cref="tl2br" />, <see cref="top" />, <see cref="tr2bl" />, <see cref="u" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BarBorder.Color, BetweenBorder.Color, Border.Color, BottomBorder.Color, DocumentBackground.Color, EndBorder.Color, InsideHorizontalBorder.Color, InsideVerticalBorder.Color, LeftBorder.Color, RightBorder.Color, Shading.Color, StartBorder.Color, TopBorder.Color, TopLeftToBottomRightCellBorder.Color, TopRightToBottomLeftCellBorder.Color, Underline.Color.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName color = w + "color";

        /// <summary>
        /// Represents the w:cols XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="col" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="equalWidth" />, <see cref="num" />, <see cref="sep" />, <see cref="space" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Columns.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cols = w + "cols";

        /// <summary>
        /// Represents the w:column XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fieldMapData" />, <see cref="recipientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnIndex.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName column = w + "column";

        /// <summary>
        /// Represents the w:combine XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="eastAsianLayout" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EastAsianLayout.Combine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName combine = w + "combine";

        /// <summary>
        /// Represents the w:combineBrackets XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="eastAsianLayout" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EastAsianLayout.CombineBrackets.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName combineBrackets = w + "combineBrackets";

        /// <summary>
        /// Represents the w:comboBox XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="listItem" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="lastValue" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentComboBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName comboBox = w + "comboBox";

        /// <summary>
        /// Represents the w:comment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="comments" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altChunk" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="customXml" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="tbl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />, <see cref="initials" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Comment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName comment = w + "comment";

        /// <summary>
        /// Represents the w:commentRangeEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="displacedByCustomXml" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentRangeEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentRangeEnd = w + "commentRangeEnd";

        /// <summary>
        /// Represents the w:commentRangeStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="displacedByCustomXml" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentRangeStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentRangeStart = w + "commentRangeStart";

        /// <summary>
        /// Represents the w:commentReference XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentReference = w + "commentReference";

        /// <summary>
        /// Represents the w:comments XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="comment" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Comments.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="revisionView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RevisionView.Comments.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName comments = w + "comments";

        /// <summary>
        /// Represents the w:compat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="adjustLineHeightInTable" />, <see cref="alignTablesRowByRow" />, <see cref="allowSpaceOfSameStyleInTable" />, <see cref="applyBreakingRules" />, <see cref="autofitToFirstFixedWidthCell" />, <see cref="autoSpaceLikeWord95" />, <see cref="balanceSingleByteDoubleByteWidth" />, <see cref="cachedColBalance" />, <see cref="compatSetting" />, <see cref="convMailMergeEsc" />, <see cref="displayHangulFixedWidth" />, <see cref="doNotAutofitConstrainedTables" />, <see cref="doNotBreakConstrainedForcedTable" />, <see cref="doNotBreakWrappedTables" />, <see cref="doNotExpandShiftReturn" />, <see cref="doNotLeaveBackslashAlone" />, <see cref="doNotSnapToGridInCell" />, <see cref="doNotSuppressIndentation" />, <see cref="doNotSuppressParagraphBorders" />, <see cref="doNotUseEastAsianBreakRules" />, <see cref="doNotUseHTMLParagraphAutoSpacing" />, <see cref="doNotUseIndentAsNumberingTabStop" />, <see cref="doNotVertAlignCellWithSp" />, <see cref="doNotVertAlignInTxbx" />, <see cref="doNotWrapTextWithPunct" />, <see cref="footnoteLayoutLikeWW8" />, <see cref="forgetLastTabAlignment" />, <see cref="growAutofit" />, <see cref="layoutRawTableWidth" />, <see cref="layoutTableRowsApart" />, <see cref="lineWrapLikeWord6" />, <see cref="mwSmallCaps" />, <see cref="noColumnBalance" />, <see cref="noExtraLineSpacing" />, <see cref="noLeading" />, <see cref="noSpaceRaiseLower" />, <see cref="noTabHangInd" />, <see cref="printBodyTextBeforeHeader" />, <see cref="printColBlack" />, <see cref="selectFldWithFirstOrLastChar" />, <see cref="shapeLayoutLikeWW8" />, <see cref="showBreaksInFrames" />, <see cref="spaceForUL" />, <see cref="spacingInWholePoints" />, <see cref="splitPgBreakAndParaMark" />, <see cref="subFontBySize" />, <see cref="suppressBottomSpacing" />, <see cref="suppressSpacingAtTopOfPage" />, <see cref="suppressSpBfAfterPgBrk" />, <see cref="suppressTopSpacing" />, <see cref="suppressTopSpacingWP" />, <see cref="swapBordersFacingPages" />, <see cref="truncateFontHeightsLikeWP6" />, <see cref="ulTrailSpace" />, <see cref="underlineTabInNumList" />, <see cref="useAltKinsokuLineBreakRules" />, <see cref="useAnsiKerningPairs" />, <see cref="useFELayout" />, <see cref="useNormalStyleForList" />, <see cref="usePrinterMetrics" />, <see cref="useSingleBorderforContiguousCells" />, <see cref="useWord2002TableStyleRules" />, <see cref="useWord97LineBreakRules" />, <see cref="wpJustification" />, <see cref="wpSpaceWidth" />, <see cref="wrapTrailSpaces" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Compatibility.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName compat = w + "compat";

        /// <summary>
        /// Represents the w:compatSetting XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="name" />, <see cref="uri" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CompatibilitySetting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName compatSetting = w + "compatSetting";

        /// <summary>
        /// Represents the w:conformance XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="document" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Document.Conformance.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conformance = w + "conformance";

        /// <summary>
        /// Represents the w:connectString XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConnectString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName connectString = w + "connectString";

        /// <summary>
        /// Represents the w:consecutiveHyphenLimit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConsecutiveHyphenLimit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName consecutiveHyphenLimit = w + "consecutiveHyphenLimit";

        /// <summary>
        /// Represents the w:contentPart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContentPart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contentPart = w + "contentPart";

        /// <summary>
        /// Represents the w:contextualSpacing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContextualSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName contextualSpacing = w + "contextualSpacing";

        /// <summary>
        /// Represents the w:continuationSeparator XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContinuationSeparatorMark.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName continuationSeparator = w + "continuationSeparator";

        /// <summary>
        /// Represents the w:control XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@object" />, <see cref="pict" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="name" />, <see cref="shapeid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Control.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName control = w + "control";

        /// <summary>
        /// Represents the w:convMailMergeEsc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConvertMailMergeEscape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName convMailMergeEsc = w + "convMailMergeEsc";

        /// <summary>
        /// Represents the w:count XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="latentStyles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyles.Count.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName count = w + "count";

        /// <summary>
        /// Represents the w:countBy XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lnNumType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LineNumberType.CountBy.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName countBy = w + "countBy";

        /// <summary>
        /// Represents the w:cr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CarriageReturn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cr = w + "cr";

        /// <summary>
        /// Represents the w:cryptAlgorithmClass XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.CryptographicAlgorithmClass, WriteProtection.CryptographicAlgorithmClass.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cryptAlgorithmClass = w + "cryptAlgorithmClass";

        /// <summary>
        /// Represents the w:cryptAlgorithmSid XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.CryptographicAlgorithmSid, WriteProtection.CryptographicAlgorithmSid.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cryptAlgorithmSid = w + "cryptAlgorithmSid";

        /// <summary>
        /// Represents the w:cryptAlgorithmType XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.CryptographicAlgorithmType, WriteProtection.CryptographicAlgorithmType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cryptAlgorithmType = w + "cryptAlgorithmType";

        /// <summary>
        /// Represents the w:cryptProvider XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.CryptographicProvider, WriteProtection.CryptographicProvider.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cryptProvider = w + "cryptProvider";

        /// <summary>
        /// Represents the w:cryptProviderType XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.CryptographicProviderType, WriteProtection.CryptographicProviderType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cryptProviderType = w + "cryptProviderType";

        /// <summary>
        /// Represents the w:cryptProviderTypeExt XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.CryptographicProviderTypeExtensibility, WriteProtection.CryptographicProviderTypeExtensibility.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cryptProviderTypeExt = w + "cryptProviderTypeExt";

        /// <summary>
        /// Represents the w:cryptProviderTypeExtSource XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.CryptographicProviderTypeExtSource, WriteProtection.CryptographicProviderTypeExtSource.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cryptProviderTypeExtSource = w + "cryptProviderTypeExtSource";

        /// <summary>
        /// Represents the w:cryptSpinCount XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.CryptographicSpinCount, WriteProtection.CryptographicSpinCount.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cryptSpinCount = w + "cryptSpinCount";

        /// <summary>
        /// Represents the w:cs XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ComplexScript.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rFonts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RunFonts.ComplexScript.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cs = w + "cs";

        /// <summary>
        /// Represents the w:csb0 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="sig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FontSignature.CodePageSignature0.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName csb0 = w + "csb0";

        /// <summary>
        /// Represents the w:csb1 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="sig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FontSignature.CodePageSignature1.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName csb1 = w + "csb1";

        /// <summary>
        /// Represents the w:cstheme XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rFonts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RunFonts.ComplexScriptTheme.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cstheme = w + "cstheme";

        /// <summary>
        /// Represents the w:customMarkFollows XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="endnoteReference" />, <see cref="footnoteReference" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EndnoteReference.CustomMarkFollows, FootnoteReference.CustomMarkFollows.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customMarkFollows = w + "customMarkFollows";

        /// <summary>
        /// Represents the w:customStyle XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Style.CustomStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customStyle = w + "customStyle";

        /// <summary>
        /// Represents the w:customStyles XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.CustomStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customStyles = w + "customStyles";

        /// <summary>
        /// Represents the w:customXml XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="customXmlPr" />, <see cref="del" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="sdt" />, <see cref="subDoc" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.uri" />, <see cref="element" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlBlock, CustomXmlCell, CustomXmlRow, CustomXmlRuby, CustomXmlRun.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXml = w + "customXml";

        /// <summary>
        /// Represents the w:customXmlDelRangeEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlDelRangeEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlDelRangeEnd = w + "customXmlDelRangeEnd";

        /// <summary>
        /// Represents the w:customXmlDelRangeStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlDelRangeStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlDelRangeStart = w + "customXmlDelRangeStart";

        /// <summary>
        /// Represents the w:customXmlInsRangeEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlInsRangeEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlInsRangeEnd = w + "customXmlInsRangeEnd";

        /// <summary>
        /// Represents the w:customXmlInsRangeStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlInsRangeStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlInsRangeStart = w + "customXmlInsRangeStart";

        /// <summary>
        /// Represents the w:customXmlMoveFromRangeEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlMoveFromRangeEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlMoveFromRangeEnd = w + "customXmlMoveFromRangeEnd";

        /// <summary>
        /// Represents the w:customXmlMoveFromRangeStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlMoveFromRangeStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlMoveFromRangeStart = w + "customXmlMoveFromRangeStart";

        /// <summary>
        /// Represents the w:customXmlMoveToRangeEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlMoveToRangeEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlMoveToRangeEnd = w + "customXmlMoveToRangeEnd";

        /// <summary>
        /// Represents the w:customXmlMoveToRangeStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlMoveToRangeStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlMoveToRangeStart = w + "customXmlMoveToRangeStart";

        /// <summary>
        /// Represents the w:customXmlPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customXml" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="attr" />, <see cref="placeholder" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customXmlPr = w + "customXmlPr";

        /// <summary>
        /// Represents the w:dataBinding XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="prefixMappings" />, <see cref="storeItemID" />, <see cref="xpath" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataBinding.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataBinding = w + "dataBinding";

        /// <summary>
        /// Represents the w:dataSource XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataSourceReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataSource = w + "dataSource";

        /// <summary>
        /// Represents the w:dataType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataType = w + "dataType";

        /// <summary>
        /// Represents the w:date XML element and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="calendar" />, <see cref="dateFormat" />, <see cref="lid" />, <see cref="storeMappedDataAs" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="fullDate" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentDate.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cellDel" />, <see cref="cellIns" />, <see cref="cellMerge" />, <see cref="comment" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeStart" />, <see cref="numberingChange" />, <see cref="pPrChange" />, <see cref="rPrChange" />, <see cref="sectPrChange" />, <see cref="tblPrChange" />, <see cref="tblPrExChange" />, <see cref="tcPrChange" />, <see cref="trPrChange" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CellDeletion.Date, CellInsertion.Date, CellMerge.Date, Comment.Date, ConflictDeletion.Date, ConflictInsertion.Date, CustomXmlConflictDeletionRangeStart.Date, CustomXmlConflictInsertionRangeStart.Date, CustomXmlDelRangeStart.Date, CustomXmlInsRangeStart.Date, CustomXmlMoveFromRangeStart.Date, CustomXmlMoveToRangeStart.Date, Deleted.Date, DeletedMathControl.Date, DeletedRun.Date, Inserted.Date, InsertedMathControl.Date, InsertedRun.Date, MoveFrom.Date, MoveFromMathControl.Date, MoveFromRangeStart.Date, MoveFromRun.Date, MoveTo.Date, MoveToMathControl.Date, MoveToRangeStart.Date, MoveToRun.Date, NumberingChange.Date, ParagraphMarkRunPropertiesChange.Date, ParagraphPropertiesChange.Date, RunConflictDeletion.Date, RunConflictInsertion.Date, RunPropertiesChange.Date, SectionPropertiesChange.Date, TableCellPropertiesChange.Date, TablePropertiesChange.Date, TablePropertyExceptionsChange.Date, TableRowPropertiesChange.Date.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName date = w + "date";

        /// <summary>
        /// Represents the w:dateFormat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="date" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DateFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dateFormat = w + "dateFormat";

        /// <summary>
        /// Represents the w:dayLong XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DayLong.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dayLong = w + "dayLong";

        /// <summary>
        /// Represents the w:dayShort XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DayShort.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dayShort = w + "dayShort";

        /// <summary>
        /// Represents the w:ddList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ffData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="@default" />, <see cref="listEntry" />, <see cref="result" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropDownListFormField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ddList = w + "ddList";

        /// <summary>
        /// Represents the w:decimalSymbol XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DecimalSymbol.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName decimalSymbol = w + "decimalSymbol";

        /// <summary>
        /// Represents the w:decorated XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocPartName.Decorated.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName decorated = w + "decorated";

        /// <summary>
        /// Represents the w:default XML elements and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="checkBox" />, <see cref="ddList" />, <see cref="textInput" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefaultCheckBoxFormFieldState, DefaultDropDownListItemIndex, DefaultTextBoxFormFieldString.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Style.Default.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @default = w + "default";

        /// <summary>
        /// Represents the w:defaultTableStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefaultTableStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defaultTableStyle = w + "defaultTableStyle";

        /// <summary>
        /// Represents the w:defaultTabStop XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefaultTabStop.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defaultTabStop = w + "defaultTabStop";

        /// <summary>
        /// Represents the w:defLockedState XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="latentStyles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyles.DefaultLockedState.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defLockedState = w + "defLockedState";

        /// <summary>
        /// Represents the w:defQFormat XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="latentStyles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyles.DefaultPrimaryStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defQFormat = w + "defQFormat";

        /// <summary>
        /// Represents the w:defSemiHidden XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="latentStyles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyles.DefaultSemiHidden.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defSemiHidden = w + "defSemiHidden";

        /// <summary>
        /// Represents the w:defUIPriority XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="latentStyles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyles.DefaultUiPriority.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defUIPriority = w + "defUIPriority";

        /// <summary>
        /// Represents the w:defUnhideWhenUsed XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="latentStyles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyles.DefaultUnhideWhenUsed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName defUnhideWhenUsed = w + "defUnhideWhenUsed";

        /// <summary>
        /// Represents the w:del XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.ctrlPr" />, <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rPr" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="trPr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="dir" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="rPr" />, <see cref="sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Deleted, DeletedMathControl, DeletedRun.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName del = w + "del";

        /// <summary>
        /// Represents the w:delInstrText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="XML.space" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DeletedFieldCode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName delInstrText = w + "delInstrText";

        /// <summary>
        /// Represents the w:delText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="XML.space" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DeletedText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName delText = w + "delText";

        /// <summary>
        /// Represents the w:description XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPartPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Description.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName description = w + "description";

        /// <summary>
        /// Represents the w:destination XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Destination.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName destination = w + "destination";

        /// <summary>
        /// Represents the w:dir XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bdo" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="sdt" />, <see cref="subDoc" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BidirectionalEmbedding.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dir = w + "dir";

        /// <summary>
        /// Represents the w:directFormattingOnNumbering XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.DirectFormattingOnNumbering.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName directFormattingOnNumbering = w + "directFormattingOnNumbering";

        /// <summary>
        /// Represents the w:directFormattingOnParagraphs XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.DirectFormattingOnParagraphs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName directFormattingOnParagraphs = w + "directFormattingOnParagraphs";

        /// <summary>
        /// Represents the w:directFormattingOnRuns XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.DirectFormattingOnRuns.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName directFormattingOnRuns = w + "directFormattingOnRuns";

        /// <summary>
        /// Represents the w:directFormattingOnTables XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.DirectFormattingOnTables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName directFormattingOnTables = w + "directFormattingOnTables";

        /// <summary>
        /// Represents the w:dirty XML element and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rubyPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Dirty.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fldChar" />, <see cref="fldSimple" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FieldChar.Dirty, SimpleField.Dirty, SimpleFieldRuby.Dirty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dirty = w + "dirty";

        /// <summary>
        /// Represents the w:displacedByCustomXml XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BookmarkEnd.DisplacedByCustomXml, BookmarkStart.DisplacedByCustomXml, CommentRangeEnd.DisplacedByCustomXml, CommentRangeStart.DisplacedByCustomXml, MoveFromRangeEnd.DisplacedByCustomXml, MoveFromRangeStart.DisplacedByCustomXml, MoveToRangeEnd.DisplacedByCustomXml, MoveToRangeStart.DisplacedByCustomXml, PermEnd.DisplacedByCustomXml, PermStart.DisplacedByCustomXml.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName displacedByCustomXml = w + "displacedByCustomXml";

        /// <summary>
        /// Represents the w:display XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgBorders" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageBorders.Display.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName display = w + "display";

        /// <summary>
        /// Represents the w:displayBackgroundShape XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DisplayBackgroundShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName displayBackgroundShape = w + "displayBackgroundShape";

        /// <summary>
        /// Represents the w:displayHangulFixedWidth XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DisplayHangulFixedWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName displayHangulFixedWidth = w + "displayHangulFixedWidth";

        /// <summary>
        /// Represents the w:displayHorizontalDrawingGridEvery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DisplayHorizontalDrawingGrid.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName displayHorizontalDrawingGridEvery = w + "displayHorizontalDrawingGridEvery";

        /// <summary>
        /// Represents the w:displayText XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="listItem" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ListItem.DisplayText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName displayText = w + "displayText";

        /// <summary>
        /// Represents the w:displayVerticalDrawingGridEvery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DisplayVerticalDrawingGrid.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName displayVerticalDrawingGridEvery = w + "displayVerticalDrawingGridEvery";

        /// <summary>
        /// Represents the w:distance XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lnNumType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LineNumberType.Distance.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName distance = w + "distance";

        /// <summary>
        /// Represents the w:div XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="divs" />, <see cref="divsChild" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="blockQuote" />, <see cref="bodyDiv" />, <see cref="divBdr" />, <see cref="divsChild" />, <see cref="marBottom" />, <see cref="marLeft" />, <see cref="marRight" />, <see cref="marTop" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Div.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName div = w + "div";

        /// <summary>
        /// Represents the w:divBdr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="div" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bottom" />, <see cref="left" />, <see cref="right" />, <see cref="top" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DivBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName divBdr = w + "divBdr";

        /// <summary>
        /// Represents the w:divId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />, <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DivId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName divId = w + "divId";

        /// <summary>
        /// Represents the w:divs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="div" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Divs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName divs = w + "divs";

        /// <summary>
        /// Represents the w:divsChild XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="div" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="div" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DivsChild.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName divsChild = w + "divsChild";

        /// <summary>
        /// Represents the w:dllVersion XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="activeWritingStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ActiveWritingStyle.DllVersion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dllVersion = w + "dllVersion";

        /// <summary>
        /// Represents the w:docDefaults XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pPrDefault" />, <see cref="rPrDefault" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocDefaults.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docDefaults = w + "docDefaults";

        /// <summary>
        /// Represents the w:docGrid XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="charSpace" />, <see cref="linePitch" />, <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocGrid.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docGrid = w + "docGrid";

        /// <summary>
        /// Represents the w:docLocation XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="hyperlink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Hyperlink.DocLocation, HyperlinkRuby.DocLocation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docLocation = w + "docLocation";

        /// <summary>
        /// Represents the w:docPart XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docParts" />, <see cref="placeholder" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="docPartBody" />, <see cref="docPartPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocPart, DocPartReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docPart = w + "docPart";

        /// <summary>
        /// Represents the w:docPartBody XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altChunk" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="sectPr" />, <see cref="tbl" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocPartBody.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docPartBody = w + "docPartBody";

        /// <summary>
        /// Represents the w:docPartCategory XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPartList" />, <see cref="docPartObj" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocPartCategory.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docPartCategory = w + "docPartCategory";

        /// <summary>
        /// Represents the w:docPartGallery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPartList" />, <see cref="docPartObj" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocPartGallery.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docPartGallery = w + "docPartGallery";

        /// <summary>
        /// Represents the w:docPartList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="docPartCategory" />, <see cref="docPartGallery" />, <see cref="docPartUnique" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentDocPartList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docPartList = w + "docPartList";

        /// <summary>
        /// Represents the w:docPartObj XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="docPartCategory" />, <see cref="docPartGallery" />, <see cref="docPartUnique" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentDocPartObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docPartObj = w + "docPartObj";

        /// <summary>
        /// Represents the w:docPartPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPart" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="behaviors" />, <see cref="category" />, <see cref="description" />, <see cref="guid" />, <see cref="name" />, <see cref="style" />, <see cref="types" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocPartProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docPartPr = w + "docPartPr";

        /// <summary>
        /// Represents the w:docParts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="glossaryDocument" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="docPart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocParts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docParts = w + "docParts";

        /// <summary>
        /// Represents the w:docPartUnique XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPartList" />, <see cref="docPartObj" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocPartUnique.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docPartUnique = w + "docPartUnique";

        /// <summary>
        /// Represents the w:document XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="background" />, <see cref="body" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="conformance" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Document.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName document = w + "document";

        /// <summary>
        /// Represents the w:documentProtection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="algIdExt" />, <see cref="algIdExtSource" />, <see cref="algorithmName" />, <see cref="cryptAlgorithmClass" />, <see cref="cryptAlgorithmSid" />, <see cref="cryptAlgorithmType" />, <see cref="cryptProvider" />, <see cref="cryptProviderType" />, <see cref="cryptProviderTypeExt" />, <see cref="cryptProviderTypeExtSource" />, <see cref="cryptSpinCount" />, <see cref="edit" />, <see cref="enforcement" />, <see cref="formatting" />, <see cref="hash" />, <see cref="hashValue" />, <see cref="salt" />, <see cref="saltValue" />, <see cref="spinCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentProtection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName documentProtection = w + "documentProtection";

        /// <summary>
        /// Represents the w:documentType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName documentType = w + "documentType";

        /// <summary>
        /// Represents the w:docVar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docVars" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="name" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentVariable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docVar = w + "docVar";

        /// <summary>
        /// Represents the w:docVars XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="docVar" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentVariables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName docVars = w + "docVars";

        /// <summary>
        /// Represents the w:doNotAutoCompressPictures XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotAutoCompressPictures.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotAutoCompressPictures = w + "doNotAutoCompressPictures";

        /// <summary>
        /// Represents the w:doNotAutofitConstrainedTables XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotAutofitConstrainedTables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotAutofitConstrainedTables = w + "doNotAutofitConstrainedTables";

        /// <summary>
        /// Represents the w:doNotBreakConstrainedForcedTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotBreakConstrainedForcedTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotBreakConstrainedForcedTable = w + "doNotBreakConstrainedForcedTable";

        /// <summary>
        /// Represents the w:doNotBreakWrappedTables XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotBreakWrappedTables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotBreakWrappedTables = w + "doNotBreakWrappedTables";

        /// <summary>
        /// Represents the w:doNotDemarcateInvalidXml XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotDemarcateInvalidXml.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotDemarcateInvalidXml = w + "doNotDemarcateInvalidXml";

        /// <summary>
        /// Represents the w:doNotDisplayPageBoundaries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotDisplayPageBoundaries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotDisplayPageBoundaries = w + "doNotDisplayPageBoundaries";

        /// <summary>
        /// Represents the w:doNotExpandShiftReturn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotExpandShiftReturn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotExpandShiftReturn = w + "doNotExpandShiftReturn";

        /// <summary>
        /// Represents the w:doNotHyphenateCaps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotHyphenateCaps.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotHyphenateCaps = w + "doNotHyphenateCaps";

        /// <summary>
        /// Represents the w:doNotIncludeSubdocsInStats XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotIncludeSubdocsInStats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotIncludeSubdocsInStats = w + "doNotIncludeSubdocsInStats";

        /// <summary>
        /// Represents the w:doNotLeaveBackslashAlone XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotLeaveBackslashAlone.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotLeaveBackslashAlone = w + "doNotLeaveBackslashAlone";

        /// <summary>
        /// Represents the w:doNotOrganizeInFolder XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotOrganizeInFolder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotOrganizeInFolder = w + "doNotOrganizeInFolder";

        /// <summary>
        /// Represents the w:doNotRelyOnCSS XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotRelyOnCSS.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotRelyOnCSS = w + "doNotRelyOnCSS";

        /// <summary>
        /// Represents the w:doNotSaveAsSingleFile XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotSaveAsSingleFile.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotSaveAsSingleFile = w + "doNotSaveAsSingleFile";

        /// <summary>
        /// Represents the w:doNotShadeFormData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotShadeFormData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotShadeFormData = w + "doNotShadeFormData";

        /// <summary>
        /// Represents the w:doNotSnapToGridInCell XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotSnapToGridInCell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotSnapToGridInCell = w + "doNotSnapToGridInCell";

        /// <summary>
        /// Represents the w:doNotSuppressBlankLines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotSuppressBlankLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotSuppressBlankLines = w + "doNotSuppressBlankLines";

        /// <summary>
        /// Represents the w:doNotSuppressIndentation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotSuppressIndentation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotSuppressIndentation = w + "doNotSuppressIndentation";

        /// <summary>
        /// Represents the w:doNotSuppressParagraphBorders XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotSuppressParagraphBorders.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotSuppressParagraphBorders = w + "doNotSuppressParagraphBorders";

        /// <summary>
        /// Represents the w:doNotTrackFormatting XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotTrackFormatting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotTrackFormatting = w + "doNotTrackFormatting";

        /// <summary>
        /// Represents the w:doNotTrackMoves XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotTrackMoves.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotTrackMoves = w + "doNotTrackMoves";

        /// <summary>
        /// Represents the w:doNotUseEastAsianBreakRules XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotUseEastAsianBreakRules.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotUseEastAsianBreakRules = w + "doNotUseEastAsianBreakRules";

        /// <summary>
        /// Represents the w:doNotUseHTMLParagraphAutoSpacing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotUseHTMLParagraphAutoSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotUseHTMLParagraphAutoSpacing = w + "doNotUseHTMLParagraphAutoSpacing";

        /// <summary>
        /// Represents the w:doNotUseIndentAsNumberingTabStop XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotUseIndentAsNumberingTabStop.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotUseIndentAsNumberingTabStop = w + "doNotUseIndentAsNumberingTabStop";

        /// <summary>
        /// Represents the w:doNotUseLongFileNames XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotUseLongFileNames.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotUseLongFileNames = w + "doNotUseLongFileNames";

        /// <summary>
        /// Represents the w:doNotUseMarginsForDrawingGridOrigin XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotUseMarginsForDrawingGridOrigin.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotUseMarginsForDrawingGridOrigin = w + "doNotUseMarginsForDrawingGridOrigin";

        /// <summary>
        /// Represents the w:doNotValidateAgainstSchema XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotValidateAgainstSchema.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotValidateAgainstSchema = w + "doNotValidateAgainstSchema";

        /// <summary>
        /// Represents the w:doNotVertAlignCellWithSp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotVerticallyAlignCellWithShape.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotVertAlignCellWithSp = w + "doNotVertAlignCellWithSp";

        /// <summary>
        /// Represents the w:doNotVertAlignInTxbx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotVerticallyAlignInTextBox.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotVertAlignInTxbx = w + "doNotVertAlignInTxbx";

        /// <summary>
        /// Represents the w:doNotWrapTextWithPunct XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoNotWrapTextWithPunctuation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName doNotWrapTextWithPunct = w + "doNotWrapTextWithPunct";

        /// <summary>
        /// Represents the w:drawAspect XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="objectEmbed" />, <see cref="objectLink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ObjectEmbed.drawAspect, ObjectLink.drawAspect.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName drawAspect = w + "drawAspect";

        /// <summary>
        /// Represents the w:drawing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="numPicBullet" />, <see cref="@object" />, <see cref="r" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="WP.anchor" />, <see cref="WP.inline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Drawing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName drawing = w + "drawing";

        /// <summary>
        /// Represents the w:drawingGridHorizontalOrigin XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DrawingGridHorizontalOrigin.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName drawingGridHorizontalOrigin = w + "drawingGridHorizontalOrigin";

        /// <summary>
        /// Represents the w:drawingGridHorizontalSpacing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DrawingGridHorizontalSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName drawingGridHorizontalSpacing = w + "drawingGridHorizontalSpacing";

        /// <summary>
        /// Represents the w:drawingGridVerticalOrigin XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DrawingGridVerticalOrigin.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName drawingGridVerticalOrigin = w + "drawingGridVerticalOrigin";

        /// <summary>
        /// Represents the w:drawingGridVerticalSpacing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DrawingGridVerticalSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName drawingGridVerticalSpacing = w + "drawingGridVerticalSpacing";

        /// <summary>
        /// Represents the w:dropCap XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.DropCap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropCap = w + "dropCap";

        /// <summary>
        /// Represents the w:dropDownList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="listItem" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="lastValue" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentDropDownList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dropDownList = w + "dropDownList";

        /// <summary>
        /// Represents the w:dstrike XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DoubleStrike.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dstrike = w + "dstrike";

        /// <summary>
        /// Represents the w:dxaOrig XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="@object" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EmbeddedObject.DxaOriginal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dxaOrig = w + "dxaOrig";

        /// <summary>
        /// Represents the w:dyaOrig XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="@object" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EmbeddedObject.DyaOriginal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dyaOrig = w + "dyaOrig";

        /// <summary>
        /// Represents the w:dynamicAddress XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fieldMapData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DynamicAddress.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dynamicAddress = w + "dynamicAddress";

        /// <summary>
        /// Represents the w:eastAsia XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lang" />, <see cref="rFonts" />, <see cref="themeFontLang" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Languages.EastAsia, RunFonts.EastAsia, ThemeFontLanguages.EastAsia.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eastAsia = w + "eastAsia";

        /// <summary>
        /// Represents the w:eastAsianLayout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="combine" />, <see cref="combineBrackets" />, <see cref="id" />, <see cref="vert" />, <see cref="vertCompress" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EastAsianLayout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eastAsianLayout = w + "eastAsianLayout";

        /// <summary>
        /// Represents the w:eastAsiaTheme XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rFonts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RunFonts.EastAsiaTheme.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName eastAsiaTheme = w + "eastAsiaTheme";

        /// <summary>
        /// Represents the w:ed XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="permStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PermStart.Ed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ed = w + "ed";

        /// <summary>
        /// Represents the w:edGrp XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="permStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PermStart.EditorGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName edGrp = w + "edGrp";

        /// <summary>
        /// Represents the w:edit XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.Edit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName edit = w + "edit";

        /// <summary>
        /// Represents the w:effect XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextEffect.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName effect = w + "effect";

        /// <summary>
        /// Represents the w:element XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="customXml" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CustomXmlBlock.Element, CustomXmlCell.Element, CustomXmlRow.Element, CustomXmlRuby.Element, CustomXmlRun.Element.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName element = w + "element";

        /// <summary>
        /// Represents the w:em XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Emphasis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName em = w + "em";

        /// <summary>
        /// Represents the w:embedBold XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="fontKey" />, <see cref="subsetted" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EmbedBoldFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName embedBold = w + "embedBold";

        /// <summary>
        /// Represents the w:embedBoldItalic XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="fontKey" />, <see cref="subsetted" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EmbedBoldItalicFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName embedBoldItalic = w + "embedBoldItalic";

        /// <summary>
        /// Represents the w:embedItalic XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="fontKey" />, <see cref="subsetted" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EmbedItalicFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName embedItalic = w + "embedItalic";

        /// <summary>
        /// Represents the w:embedRegular XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="fontKey" />, <see cref="subsetted" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EmbedRegularFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName embedRegular = w + "embedRegular";

        /// <summary>
        /// Represents the w:embedSystemFonts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EmbedSystemFonts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName embedSystemFonts = w + "embedSystemFonts";

        /// <summary>
        /// Represents the w:embedTrueTypeFonts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EmbedTrueTypeFonts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName embedTrueTypeFonts = w + "embedTrueTypeFonts";

        /// <summary>
        /// Represents the w:emboss XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Emboss.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName emboss = w + "emboss";

        /// <summary>
        /// Represents the w:enabled XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ffData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Enabled.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName enabled = w + "enabled";

        /// <summary>
        /// Represents the w:encoding XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebPageEncoding.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName encoding = w + "encoding";

        /// <summary>
        /// Represents the w:end XML elements and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblBorders" />, <see cref="tblCellMar" />, <see cref="tcBorders" />, <see cref="tcMar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="type" />, <see cref="val" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndBorder, EndMargin.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.End.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName end = w + "end";

        /// <summary>
        /// Represents the w:endChars XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.EndCharacters.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endChars = w + "endChars";

        /// <summary>
        /// Represents the w:endnote XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="endnotePr" />, <see cref="endnotes" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altChunk" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="tbl" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />, <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Endnote, EndnoteSpecialReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endnote = w + "endnote";

        /// <summary>
        /// Represents the w:endnotePr XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />, <see cref="settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="endnote" />, <see cref="numFmt" />, <see cref="numRestart" />, <see cref="numStart" />, <see cref="pos" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndnoteDocumentWideProperties, EndnoteProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endnotePr = w + "endnotePr";

        /// <summary>
        /// Represents the w:endnoteRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndnoteReferenceMark.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endnoteRef = w + "endnoteRef";

        /// <summary>
        /// Represents the w:endnoteReference XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="customMarkFollows" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndnoteReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endnoteReference = w + "endnoteReference";

        /// <summary>
        /// Represents the w:endnotes XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="endnote" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Endnotes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endnotes = w + "endnotes";

        /// <summary>
        /// Represents the w:enforcement XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.Enforcement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName enforcement = w + "enforcement";

        /// <summary>
        /// Represents the w:entryMacro XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ffData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EntryMacro.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName entryMacro = w + "entryMacro";

        /// <summary>
        /// Represents the w:equalWidth XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cols" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Columns.EqualWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName equalWidth = w + "equalWidth";

        /// <summary>
        /// Represents the w:equation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentEquation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName equation = w + "equation";

        /// <summary>
        /// Represents the w:evenAndOddHeaders XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EvenAndOddHeaders.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName evenAndOddHeaders = w + "evenAndOddHeaders";

        /// <summary>
        /// Represents the w:evenHBand XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.EvenHorizontalBand.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName evenHBand = w + "evenHBand";

        /// <summary>
        /// Represents the w:evenVBand XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.EvenVerticalBand.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName evenVBand = w + "evenVBand";

        /// <summary>
        /// Represents the w:exitMacro XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ffData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExitMacro.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName exitMacro = w + "exitMacro";

        /// <summary>
        /// Represents the w:family XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontFamily.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName family = w + "family";

        /// <summary>
        /// Represents the w:ffData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fldChar" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="calcOnExit" />, <see cref="checkBox" />, <see cref="ddList" />, <see cref="enabled" />, <see cref="entryMacro" />, <see cref="exitMacro" />, <see cref="helpText" />, <see cref="name" />, <see cref="statusText" />, <see cref="textInput" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormFieldData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ffData = w + "ffData";

        /// <summary>
        /// Represents the w:fHdr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="odso" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FirstRowHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fHdr = w + "fHdr";

        /// <summary>
        /// Represents the w:fieldCodes XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="objectEmbed" />, <see cref="objectLink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ObjectEmbed.FieldCodes, ObjectLink.FieldCodes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fieldCodes = w + "fieldCodes";

        /// <summary>
        /// Represents the w:fieldMapData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="odso" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="column" />, <see cref="dynamicAddress" />, <see cref="lid" />, <see cref="mappedName" />, <see cref="name" />, <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FieldMapData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fieldMapData = w + "fieldMapData";

        /// <summary>
        /// Represents the w:fill XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="shd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Shading.Fill.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fill = w + "fill";

        /// <summary>
        /// Represents the w:first XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="paperSrc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PaperSource.First.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName first = w + "first";

        /// <summary>
        /// Represents the w:firstColumn XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />, <see cref="tblLook" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.FirstColumn, TableLook.FirstColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstColumn = w + "firstColumn";

        /// <summary>
        /// Represents the w:firstLine XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.FirstLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstLine = w + "firstLine";

        /// <summary>
        /// Represents the w:firstLineChars XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.FirstLineChars.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstLineChars = w + "firstLineChars";

        /// <summary>
        /// Represents the w:firstRow XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />, <see cref="tblLook" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.FirstRow, TableLook.FirstRow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstRow = w + "firstRow";

        /// <summary>
        /// Represents the w:firstRowFirstColumn XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.FirstRowFirstColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstRowFirstColumn = w + "firstRowFirstColumn";

        /// <summary>
        /// Represents the w:firstRowLastColumn XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.FirstRowLastColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstRowLastColumn = w + "firstRowLastColumn";

        /// <summary>
        /// Represents the w:fitText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FitText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fitText = w + "fitText";

        /// <summary>
        /// Represents the w:flatBorders XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="framesetSplitbar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FlatBorders.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName flatBorders = w + "flatBorders";

        /// <summary>
        /// Represents the w:fldChar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ffData" />, <see cref="fldData" />, <see cref="numberingChange" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="dirty" />, <see cref="fldCharType" />, <see cref="fldLock" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FieldChar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fldChar = w + "fldChar";

        /// <summary>
        /// Represents the w:fldCharType XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fldChar" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FieldChar.FieldCharType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fldCharType = w + "fldCharType";

        /// <summary>
        /// Represents the w:fldData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fldChar" />, <see cref="fldSimple" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FieldData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fldData = w + "fldData";

        /// <summary>
        /// Represents the w:fldLock XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fldChar" />, <see cref="fldSimple" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FieldChar.FieldLock, SimpleField.FieldLock, SimpleFieldRuby.FieldLock.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fldLock = w + "fldLock";

        /// <summary>
        /// Represents the w:fldSimple XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="customXml" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="dir" />, <see cref="fldData" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="sdt" />, <see cref="subDoc" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="dirty" />, <see cref="fldLock" />, <see cref="instr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SimpleField, SimpleFieldRuby.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fldSimple = w + "fldSimple";

        /// <summary>
        /// Represents the w:fmt XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgNumType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageNumberType.Format.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fmt = w + "fmt";

        /// <summary>
        /// Represents the w:followedHyperlink XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.FollowedHyperlink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName followedHyperlink = w + "followedHyperlink";

        /// <summary>
        /// Represents the w:font XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fonts" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altName" />, <see cref="charset" />, <see cref="embedBold" />, <see cref="embedBoldItalic" />, <see cref="embedItalic" />, <see cref="embedRegular" />, <see cref="family" />, <see cref="notTrueType" />, <see cref="panose1" />, <see cref="pitch" />, <see cref="sig" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Font.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="sym" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SymbolChar.Font.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName font = w + "font";

        /// <summary>
        /// Represents the w:fontKey XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="embedBold" />, <see cref="embedBoldItalic" />, <see cref="embedItalic" />, <see cref="embedRegular" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EmbedBoldFont.FontKey, EmbedBoldItalicFont.FontKey, EmbedItalicFont.FontKey, EmbedRegularFont.FontKey.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fontKey = w + "fontKey";

        /// <summary>
        /// Represents the w:fonts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="font" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Fonts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fonts = w + "fonts";

        /// <summary>
        /// Represents the w:fontSz XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="readModeInkLockDown" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ReadModeInkLockDown.FontSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fontSz = w + "fontSz";

        /// <summary>
        /// Represents the w:footer XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgMar" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageMargin.Footer.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName footer = w + "footer";

        /// <summary>
        /// Represents the w:footerReference XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FooterReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName footerReference = w + "footerReference";

        /// <summary>
        /// Represents the w:footnote XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="footnotePr" />, <see cref="footnotes" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altChunk" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="tbl" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />, <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Footnote, FootnoteSpecialReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName footnote = w + "footnote";

        /// <summary>
        /// Represents the w:footnoteLayoutLikeWW8 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FootnoteLayoutLikeWord8.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName footnoteLayoutLikeWW8 = w + "footnoteLayoutLikeWW8";

        /// <summary>
        /// Represents the w:footnotePr XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />, <see cref="settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="footnote" />, <see cref="numFmt" />, <see cref="numRestart" />, <see cref="numStart" />, <see cref="pos" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FootnoteDocumentWideProperties, FootnoteProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName footnotePr = w + "footnotePr";

        /// <summary>
        /// Represents the w:footnoteRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FootnoteReferenceMark.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName footnoteRef = w + "footnoteRef";

        /// <summary>
        /// Represents the w:footnoteReference XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="customMarkFollows" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FootnoteReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName footnoteReference = w + "footnoteReference";

        /// <summary>
        /// Represents the w:footnotes XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="footnote" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Footnotes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName footnotes = w + "footnotes";

        /// <summary>
        /// Represents the w:forceUpgrade XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ForceUpgrade.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName forceUpgrade = w + "forceUpgrade";

        /// <summary>
        /// Represents the w:forgetLastTabAlignment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ForgetLastTabAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName forgetLastTabAlignment = w + "forgetLastTabAlignment";

        /// <summary>
        /// Represents the w:format XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textInput" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Format.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="numFmt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: NumberingFormat.Format.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName format = w + "format";

        /// <summary>
        /// Represents the w:formatting XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="revisionView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.Formatting, RevisionView.Formatting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formatting = w + "formatting";

        /// <summary>
        /// Represents the w:formProt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormProtection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formProt = w + "formProt";

        /// <summary>
        /// Represents the w:formsDesign XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormsDesign.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formsDesign = w + "formsDesign";

        /// <summary>
        /// Represents the w:frame XML element and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frameset" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="linkedToFile" />, <see cref="marH" />, <see cref="marW" />, <see cref="name" />, <see cref="noResizeAllowed" />, <see cref="scrollbar" />, <see cref="sourceFileName" />, <see cref="sz" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Frame.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bar" />, <see cref="bdr" />, <see cref="between" />, <see cref="bottom" />, <see cref="end" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="left" />, <see cref="right" />, <see cref="start" />, <see cref="tl2br" />, <see cref="top" />, <see cref="tr2bl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BarBorder.Frame, BetweenBorder.Frame, Border.Frame, BottomBorder.Frame, EndBorder.Frame, InsideHorizontalBorder.Frame, InsideVerticalBorder.Frame, LeftBorder.Frame, RightBorder.Frame, StartBorder.Frame, TopBorder.Frame, TopLeftToBottomRightCellBorder.Frame, TopRightToBottomLeftCellBorder.Frame.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName frame = w + "frame";

        /// <summary>
        /// Represents the w:frameLayout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frameset" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FrameLayout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName frameLayout = w + "frameLayout";

        /// <summary>
        /// Represents the w:framePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="anchorLock" />, <see cref="dropCap" />, <see cref="h" />, <see cref="hAnchor" />, <see cref="hRule" />, <see cref="hSpace" />, <see cref="lines" />, <see cref="vAnchor" />, <see cref="vSpace" />, <see cref="w_" />, <see cref="wrap" />, <see cref="x" />, <see cref="xAlign" />, <see cref="y" />, <see cref="yAlign" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FrameProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName framePr = w + "framePr";

        /// <summary>
        /// Represents the w:frameset XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frameset" />, <see cref="webSettings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="frame" />, <see cref="frameLayout" />, <see cref="frameset" />, <see cref="framesetSplitbar" />, <see cref="sz" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Frameset.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName frameset = w + "frameset";

        /// <summary>
        /// Represents the w:framesetSplitbar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frameset" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />, <see cref="flatBorders" />, <see cref="noBorder" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FramesetSplitbar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName framesetSplitbar = w + "framesetSplitbar";

        /// <summary>
        /// Represents the w:ftr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altChunk" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="tbl" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Footer.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ftr = w + "ftr";

        /// <summary>
        /// Represents the w:fullDate XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="date" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SdtContentDate.FullDate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fullDate = w + "fullDate";

        /// <summary>
        /// Represents the w:gallery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="category" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Gallery.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gallery = w + "gallery";

        /// <summary>
        /// Represents the w:glossaryDocument XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="background" />, <see cref="docParts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GlossaryDocument.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName glossaryDocument = w + "glossaryDocument";

        /// <summary>
        /// Represents the w:grammar XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="proofState" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ProofState.Grammar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grammar = w + "grammar";

        /// <summary>
        /// Represents the w:gridAfter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GridAfter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gridAfter = w + "gridAfter";

        /// <summary>
        /// Represents the w:gridBefore XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GridBefore.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gridBefore = w + "gridBefore";

        /// <summary>
        /// Represents the w:gridCol XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblGrid" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GridColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gridCol = w + "gridCol";

        /// <summary>
        /// Represents the w:gridSpan XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GridSpan.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gridSpan = w + "gridSpan";

        /// <summary>
        /// Represents the w:group XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName group = w + "group";

        /// <summary>
        /// Represents the w:growAutofit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GrowAutofit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName growAutofit = w + "growAutofit";

        /// <summary>
        /// Represents the w:guid XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPartPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocPartId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName guid = w + "guid";

        /// <summary>
        /// Represents the w:gutter XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgMar" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageMargin.Gutter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gutter = w + "gutter";

        /// <summary>
        /// Represents the w:gutterAtTop XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GutterAtTop.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gutterAtTop = w + "gutterAtTop";

        /// <summary>
        /// Represents the w:h XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />, <see cref="pgSz" />, <see cref="readModeInkLockDown" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.Height, PageSize.Height, ReadModeInkLockDown.Height.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName h = w + "h";

        /// <summary>
        /// Represents the w:hAnchor XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.HorizontalPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hAnchor = w + "hAnchor";

        /// <summary>
        /// Represents the w:hanging XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.Hanging.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hanging = w + "hanging";

        /// <summary>
        /// Represents the w:hangingChars XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.HangingChars.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hangingChars = w + "hangingChars";

        /// <summary>
        /// Represents the w:hAnsi XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rFonts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RunFonts.HighAnsi.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hAnsi = w + "hAnsi";

        /// <summary>
        /// Represents the w:hAnsiTheme XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rFonts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RunFonts.HighAnsiTheme.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hAnsiTheme = w + "hAnsiTheme";

        /// <summary>
        /// Represents the w:hash XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.Hash, WriteProtection.Hash.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hash = w + "hash";

        /// <summary>
        /// Represents the w:hashValue XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.HashValue, WriteProtection.HashValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hashValue = w + "hashValue";

        /// <summary>
        /// Represents the w:hdr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altChunk" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="tbl" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Header.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hdr = w + "hdr";

        /// <summary>
        /// Represents the w:hdrShapeDefaults XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.shapedefaults" />, <see cref="O.shapelayout" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HeaderShapeDefaults.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hdrShapeDefaults = w + "hdrShapeDefaults";

        /// <summary>
        /// Represents the w:header XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgMar" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageMargin.Header.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName header = w + "header";

        /// <summary>
        /// Represents the w:headerReference XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HeaderReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName headerReference = w + "headerReference";

        /// <summary>
        /// Represents the w:headerSource XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HeaderSource.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName headerSource = w + "headerSource";

        /// <summary>
        /// Represents the w:heading XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="caption" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Caption.Heading.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName heading = w + "heading";

        /// <summary>
        /// Represents the w:headingStyles XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.HeadingStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName headingStyles = w + "headingStyles";

        /// <summary>
        /// Represents the w:helpText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ffData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HelpText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName helpText = w + "helpText";

        /// <summary>
        /// Represents the w:hidden XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />, <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Hidden, StyleHidden.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hidden = w + "hidden";

        /// <summary>
        /// Represents the w:hideGrammaticalErrors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HideGrammaticalErrors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hideGrammaticalErrors = w + "hideGrammaticalErrors";

        /// <summary>
        /// Represents the w:hideMark XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HideMark.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hideMark = w + "hideMark";

        /// <summary>
        /// Represents the w:hideSpellingErrors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HideSpellingErrors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hideSpellingErrors = w + "hideSpellingErrors";

        /// <summary>
        /// Represents the w:highlight XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Highlight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName highlight = w + "highlight";

        /// <summary>
        /// Represents the w:hint XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="rFonts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RunFonts.Hint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hint = w + "hint";

        /// <summary>
        /// Represents the w:history XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="hyperlink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Hyperlink.History, HyperlinkRuby.History.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName history = w + "history";

        /// <summary>
        /// Represents the w:hMerge XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HorizontalMerge.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hMerge = w + "hMerge";

        /// <summary>
        /// Represents the w:horzAnchor XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TablePositionProperties.HorizontalAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName horzAnchor = w + "horzAnchor";

        /// <summary>
        /// Represents the w:hps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rubyPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PhoneticGuideTextFontSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hps = w + "hps";

        /// <summary>
        /// Represents the w:hpsBaseText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rubyPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PhoneticGuideBaseTextSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hpsBaseText = w + "hpsBaseText";

        /// <summary>
        /// Represents the w:hpsRaise XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rubyPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PhoneticGuideRaise.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hpsRaise = w + "hpsRaise";

        /// <summary>
        /// Represents the w:hRule XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />, <see cref="trHeight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.HeightType, TableRowHeight.HeightType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hRule = w + "hRule";

        /// <summary>
        /// Represents the w:hSpace XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.HorizontalSpace.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hSpace = w + "hSpace";

        /// <summary>
        /// Represents the w:hyperlink XML elements and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="customXml" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="sdt" />, <see cref="subDoc" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="anchor" />, <see cref="docLocation" />, <see cref="history" />, <see cref="tgtFrame" />, <see cref="tooltip" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Hyperlink, HyperlinkRuby.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Hyperlink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hyperlink = w + "hyperlink";

        /// <summary>
        /// Represents the w:hyphenationZone XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HyphenationZone.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hyphenationZone = w + "hyphenationZone";

        /// <summary>
        /// Represents the w:i XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Italic.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName i = w + "i";

        /// <summary>
        /// Represents the w:iCs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ItalicComplexScript.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName iCs = w + "iCs";

        /// <summary>
        /// Represents the w:id XML element and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtId.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="cellDel" />, <see cref="cellIns" />, <see cref="cellMerge" />, <see cref="comment" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="commentReference" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="div" />, <see cref="eastAsianLayout" />, <see cref="endnote" />, <see cref="endnoteReference" />, <see cref="fitText" />, <see cref="footnote" />, <see cref="footnoteReference" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="numberingChange" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="pPrChange" />, <see cref="rPrChange" />, <see cref="sectPrChange" />, <see cref="tblGridChange" />, <see cref="tblPrChange" />, <see cref="tblPrExChange" />, <see cref="tcPrChange" />, <see cref="trPrChange" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BookmarkEnd.Id, BookmarkStart.Id, CellDeletion.Id, CellInsertion.Id, CellMerge.Id, Comment.Id, CommentRangeEnd.Id, CommentRangeStart.Id, CommentReference.Id, ConflictDeletion.Id, ConflictInsertion.Id, CustomXmlConflictDeletionRangeEnd.Id, CustomXmlConflictDeletionRangeStart.Id, CustomXmlConflictInsertionRangeEnd.Id, CustomXmlConflictInsertionRangeStart.Id, CustomXmlDelRangeEnd.Id, CustomXmlDelRangeStart.Id, CustomXmlInsRangeEnd.Id, CustomXmlInsRangeStart.Id, CustomXmlMoveFromRangeEnd.Id, CustomXmlMoveFromRangeStart.Id, CustomXmlMoveToRangeEnd.Id, CustomXmlMoveToRangeStart.Id, Deleted.Id, DeletedMathControl.Id, DeletedRun.Id, Div.Id, EastAsianLayout.Id, Endnote.Id, EndnoteReference.Id, EndnoteSpecialReference.Id, FitText.Id, Footnote.Id, FootnoteReference.Id, FootnoteSpecialReference.Id, Inserted.Id, InsertedMathControl.Id, InsertedRun.Id, MoveFrom.Id, MoveFromMathControl.Id, MoveFromRangeEnd.Id, MoveFromRangeStart.Id, MoveFromRun.Id, MoveTo.Id, MoveToMathControl.Id, MoveToRangeEnd.Id, MoveToRangeStart.Id, MoveToRun.Id, NumberingChange.Id, ParagraphMarkRunPropertiesChange.Id, ParagraphPropertiesChange.Id, PermEnd.Id, PermStart.Id, RunConflictDeletion.Id, RunConflictInsertion.Id, RunPropertiesChange.Id, SectionPropertiesChange.Id, TableCellPropertiesChange.Id, TableGridChange.Id, TablePropertiesChange.Id, TablePropertyExceptionsChange.Id, TableRowPropertiesChange.Id.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName id = w + "id";

        /// <summary>
        /// Represents the w:ignoreMixedContent XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IgnoreMixedContent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ignoreMixedContent = w + "ignoreMixedContent";

        /// <summary>
        /// Represents the w:ilvl XML element and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingLevelReference.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lvl" />, <see cref="lvlOverride" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Level.LevelIndex, LevelOverride.LevelIndex.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ilvl = w + "ilvl";

        /// <summary>
        /// Represents the w:imprint XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Imprint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName imprint = w + "imprint";

        /// <summary>
        /// Represents the w:ind XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="end" />, <see cref="endChars" />, <see cref="firstLine" />, <see cref="firstLineChars" />, <see cref="hanging" />, <see cref="hangingChars" />, <see cref="left" />, <see cref="leftChars" />, <see cref="right" />, <see cref="rightChars" />, <see cref="start" />, <see cref="startChars" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Indentation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ind = w + "ind";

        /// <summary>
        /// Represents the w:initials XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="comment" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Comment.Initials.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName initials = w + "initials";

        /// <summary>
        /// Represents the w:inkAnnotations XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="revisionView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RevisionView.InkAnnotations.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName inkAnnotations = w + "inkAnnotations";

        /// <summary>
        /// Represents the w:ins XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.ctrlPr" />, <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="numPr" />, <see cref="p" />, <see cref="rPr" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="trPr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="dir" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="rPr" />, <see cref="sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Inserted, InsertedMathControl, InsertedRun.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ins = w + "ins";

        /// <summary>
        /// Represents the w:insDel XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="revisionView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RevisionView.DisplayRevision.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName insDel = w + "insDel";

        /// <summary>
        /// Represents the w:insideH XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblBorders" />, <see cref="tcBorders" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InsideHorizontalBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName insideH = w + "insideH";

        /// <summary>
        /// Represents the w:insideV XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblBorders" />, <see cref="tcBorders" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InsideVerticalBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName insideV = w + "insideV";

        /// <summary>
        /// Represents the w:instr XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="fldSimple" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SimpleField.Instruction, SimpleFieldRuby.Instruction.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName instr = w + "instr";

        /// <summary>
        /// Represents the w:instrText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="XML.space" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FieldCode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName instrText = w + "instrText";

        /// <summary>
        /// Represents the w:isLgl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IsLegalNumberingStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName isLgl = w + "isLgl";

        /// <summary>
        /// Represents the w:jc XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />, <see cref="tblPr" />, <see cref="tblPrEx" />, <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Justification, TableJustification.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName jc = w + "jc";

        /// <summary>
        /// Represents the w:keepLines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: KeepLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName keepLines = w + "keepLines";

        /// <summary>
        /// Represents the w:keepNext XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: KeepNext.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName keepNext = w + "keepNext";

        /// <summary>
        /// Represents the w:kern XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Kern.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName kern = w + "kern";

        /// <summary>
        /// Represents the w:kinsoku XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Kinsoku.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName kinsoku = w + "kinsoku";

        /// <summary>
        /// Represents the w:lang XML element and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="bidi" />, <see cref="eastAsia" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Languages.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="activeWritingStyle" />, <see cref="noLineBreaksAfter" />, <see cref="noLineBreaksBefore" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ActiveWritingStyle.Language, NoLineBreaksAfterKinsoku.Language, NoLineBreaksBeforeKinsoku.Language.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lang = w + "lang";

        /// <summary>
        /// Represents the w:lastColumn XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />, <see cref="tblLook" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.LastColumn, TableLook.LastColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lastColumn = w + "lastColumn";

        /// <summary>
        /// Represents the w:lastRenderedPageBreak XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LastRenderedPageBreak.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lastRenderedPageBreak = w + "lastRenderedPageBreak";

        /// <summary>
        /// Represents the w:lastRow XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />, <see cref="tblLook" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.LastRow, TableLook.LastRow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lastRow = w + "lastRow";

        /// <summary>
        /// Represents the w:lastRowFirstColumn XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.LastRowFirstColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lastRowFirstColumn = w + "lastRowFirstColumn";

        /// <summary>
        /// Represents the w:lastRowLastColumn XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.LastRowLastColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lastRowLastColumn = w + "lastRowLastColumn";

        /// <summary>
        /// Represents the w:lastValue XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="comboBox" />, <see cref="dropDownList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SdtContentComboBox.LastValue, SdtContentDropDownList.LastValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lastValue = w + "lastValue";

        /// <summary>
        /// Represents the w:latentStyles XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="lsdException" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="count" />, <see cref="defLockedState" />, <see cref="defQFormat" />, <see cref="defSemiHidden" />, <see cref="defUIPriority" />, <see cref="defUnhideWhenUsed" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LatentStyles.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.LatentStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName latentStyles = w + "latentStyles";

        /// <summary>
        /// Represents the w:layoutRawTableWidth XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LayoutRawTableWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layoutRawTableWidth = w + "layoutRawTableWidth";

        /// <summary>
        /// Represents the w:layoutTableRowsApart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LayoutTableRowsApart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName layoutTableRowsApart = w + "layoutTableRowsApart";

        /// <summary>
        /// Represents the w:leader XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ptab" />, <see cref="tab" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PositionalTab.Leader, TabStop.Leader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName leader = w + "leader";

        /// <summary>
        /// Represents the w:left XML elements and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="divBdr" />, <see cref="pBdr" />, <see cref="pgBorders" />, <see cref="tblBorders" />, <see cref="tblCellMar" />, <see cref="tcBorders" />, <see cref="tcMar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="type" />, <see cref="val" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LeftBorder, LeftMargin, TableCellLeftMargin.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />, <see cref="pgMar" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.Left, PageMargin.Left.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName left = w + "left";

        /// <summary>
        /// Represents the w:leftChars XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.LeftChars.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName leftChars = w + "leftChars";

        /// <summary>
        /// Represents the w:leftFromText XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TablePositionProperties.LeftFromText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName leftFromText = w + "leftFromText";

        /// <summary>
        /// Represents the w:legacy XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="legacy" />, <see cref="legacyIndent" />, <see cref="legacySpace" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LegacyNumbering.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="legacy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LegacyNumbering.Legacy.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legacy = w + "legacy";

        /// <summary>
        /// Represents the w:legacyIndent XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="legacy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LegacyNumbering.LegacyIndent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legacyIndent = w + "legacyIndent";

        /// <summary>
        /// Represents the w:legacySpace XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="legacy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LegacyNumbering.LegacySpace.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legacySpace = w + "legacySpace";

        /// <summary>
        /// Represents the w:lid XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="date" />, <see cref="fieldMapData" />, <see cref="rubyPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LanguageId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lid = w + "lid";

        /// <summary>
        /// Represents the w:line XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="spacing" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SpacingBetweenLines.Line.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName line = w + "line";

        /// <summary>
        /// Represents the w:linePitch XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="docGrid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocGrid.LinePitch.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName linePitch = w + "linePitch";

        /// <summary>
        /// Represents the w:lineRule XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="spacing" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SpacingBetweenLines.LineRule.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lineRule = w + "lineRule";

        /// <summary>
        /// Represents the w:lines XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.Lines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lines = w + "lines";

        /// <summary>
        /// Represents the w:lineWrapLikeWord6 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineWrapLikeWord6.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lineWrapLikeWord6 = w + "lineWrapLikeWord6";

        /// <summary>
        /// Represents the w:link XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LinkedStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName link = w + "link";

        /// <summary>
        /// Represents the w:linkedToFile XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frame" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LinkedToFile.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName linkedToFile = w + "linkedToFile";

        /// <summary>
        /// Represents the w:linkStyles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LinkStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName linkStyles = w + "linkStyles";

        /// <summary>
        /// Represents the w:linkToQuery XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LinkToQuery.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName linkToQuery = w + "linkToQuery";

        /// <summary>
        /// Represents the w:listEntry XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ddList" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ListEntryFormField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName listEntry = w + "listEntry";

        /// <summary>
        /// Represents the w:listItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="comboBox" />, <see cref="dropDownList" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="displayText" />, <see cref="value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ListItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName listItem = w + "listItem";

        /// <summary>
        /// Represents the w:listSeparator XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ListSeparator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName listSeparator = w + "listSeparator";

        /// <summary>
        /// Represents the w:lnNumType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="countBy" />, <see cref="distance" />, <see cref="restart" />, <see cref="start" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LineNumberType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lnNumType = w + "lnNumType";

        /// <summary>
        /// Represents the w:lock XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Lock.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @lock = w + "lock";

        /// <summary>
        /// Represents the w:locked XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Locked.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lsdException" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyleExceptionInfo.Locked.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName locked = w + "locked";

        /// <summary>
        /// Represents the w:lockedField XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="objectLink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ObjectLink.LockedField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lockedField = w + "lockedField";

        /// <summary>
        /// Represents the w:lsdException XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="latentStyles" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="locked" />, <see cref="name" />, <see cref="qFormat" />, <see cref="semiHidden" />, <see cref="uiPriority" />, <see cref="unhideWhenUsed" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LatentStyleExceptionInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lsdException = w + "lsdException";

        /// <summary>
        /// Represents the w:lvl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="abstractNum" />, <see cref="lvlOverride" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="isLgl" />, <see cref="legacy" />, <see cref="lvlJc" />, <see cref="lvlPicBulletId" />, <see cref="lvlRestart" />, <see cref="lvlText" />, <see cref="numFmt" />, <see cref="pPr" />, <see cref="pStyle" />, <see cref="rPr" />, <see cref="start" />, <see cref="suff" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="ilvl" />, <see cref="tentative" />, <see cref="tplc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Level.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lvl = w + "lvl";

        /// <summary>
        /// Represents the w:lvlJc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LevelJustification.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lvlJc = w + "lvlJc";

        /// <summary>
        /// Represents the w:lvlOverride XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="num" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="lvl" />, <see cref="startOverride" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="ilvl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LevelOverride.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lvlOverride = w + "lvlOverride";

        /// <summary>
        /// Represents the w:lvlPicBulletId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LevelPictureBulletId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lvlPicBulletId = w + "lvlPicBulletId";

        /// <summary>
        /// Represents the w:lvlRestart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LevelRestart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lvlRestart = w + "lvlRestart";

        /// <summary>
        /// Represents the w:lvlText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="@null" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LevelText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lvlText = w + "lvlText";

        /// <summary>
        /// Represents the w:mailAsAttachment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MailAsAttachment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mailAsAttachment = w + "mailAsAttachment";

        /// <summary>
        /// Represents the w:mailMerge XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="activeRecord" />, <see cref="addressFieldName" />, <see cref="checkErrors" />, <see cref="connectString" />, <see cref="dataSource" />, <see cref="dataType" />, <see cref="destination" />, <see cref="doNotSuppressBlankLines" />, <see cref="headerSource" />, <see cref="linkToQuery" />, <see cref="mailAsAttachment" />, <see cref="mailSubject" />, <see cref="mainDocumentType" />, <see cref="odso" />, <see cref="query" />, <see cref="viewMergedData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MailMerge.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mailMerge = w + "mailMerge";

        /// <summary>
        /// Represents the w:mailSubject XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MailSubject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mailSubject = w + "mailSubject";

        /// <summary>
        /// Represents the w:mainDocumentType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MainDocumentType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mainDocumentType = w + "mainDocumentType";

        /// <summary>
        /// Represents the w:mappedName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fieldMapData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MappedName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mappedName = w + "mappedName";

        /// <summary>
        /// Represents the w:marBottom XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="div" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BottomMarginDiv.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName marBottom = w + "marBottom";

        /// <summary>
        /// Represents the w:marH XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frame" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MarginHeight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName marH = w + "marH";

        /// <summary>
        /// Represents the w:markup XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="revisionView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: RevisionView.Markup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName markup = w + "markup";

        /// <summary>
        /// Represents the w:marLeft XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="div" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LeftMarginDiv.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName marLeft = w + "marLeft";

        /// <summary>
        /// Represents the w:marRight XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="div" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RightMarginDiv.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName marRight = w + "marRight";

        /// <summary>
        /// Represents the w:marTop XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="div" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopMarginDiv.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName marTop = w + "marTop";

        /// <summary>
        /// Represents the w:marW XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frame" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MarginWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName marW = w + "marW";

        /// <summary>
        /// Represents the w:matchSrc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="altChunkPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MatchSource.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName matchSrc = w + "matchSrc";

        /// <summary>
        /// Represents the w:maxLength XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textInput" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MaxLength.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName maxLength = w + "maxLength";

        /// <summary>
        /// Represents the w:mirrorIndents XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MirrorIndents.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mirrorIndents = w + "mirrorIndents";

        /// <summary>
        /// Represents the w:mirrorMargins XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MirrorMargins.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mirrorMargins = w + "mirrorMargins";

        /// <summary>
        /// Represents the w:monthLong XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MonthLong.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName monthLong = w + "monthLong";

        /// <summary>
        /// Represents the w:monthShort XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MonthShort.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName monthShort = w + "monthShort";

        /// <summary>
        /// Represents the w:moveFrom XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.ctrlPr" />, <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rPr" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="dir" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="rPr" />, <see cref="sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MoveFrom, MoveFromMathControl, MoveFromRun.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName moveFrom = w + "moveFrom";

        /// <summary>
        /// Represents the w:moveFromRangeEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="displacedByCustomXml" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MoveFromRangeEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName moveFromRangeEnd = w + "moveFromRangeEnd";

        /// <summary>
        /// Represents the w:moveFromRangeStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="colFirst" />, <see cref="colLast" />, <see cref="date" />, <see cref="displacedByCustomXml" />, <see cref="id" />, <see cref="name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MoveFromRangeStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName moveFromRangeStart = w + "moveFromRangeStart";

        /// <summary>
        /// Represents the w:moveTo XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.ctrlPr" />, <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rPr" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="dir" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="rPr" />, <see cref="sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MoveTo, MoveToMathControl, MoveToRun.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName moveTo = w + "moveTo";

        /// <summary>
        /// Represents the w:moveToRangeEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="displacedByCustomXml" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MoveToRangeEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName moveToRangeEnd = w + "moveToRangeEnd";

        /// <summary>
        /// Represents the w:moveToRangeStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdt" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="colFirst" />, <see cref="colLast" />, <see cref="date" />, <see cref="displacedByCustomXml" />, <see cref="id" />, <see cref="name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MoveToRangeStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName moveToRangeStart = w + "moveToRangeStart";

        /// <summary>
        /// Represents the w:movie XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pict" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MovieReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName movie = w + "movie";

        /// <summary>
        /// Represents the w:multiLevelType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="abstractNum" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MultiLevelType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName multiLevelType = w + "multiLevelType";

        /// <summary>
        /// Represents the w:multiLine XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="text" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SdtContentText.MultiLine.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName multiLine = w + "multiLine";

        /// <summary>
        /// Represents the w:mwSmallCaps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MacWordSmallCaps.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mwSmallCaps = w + "mwSmallCaps";

        /// <summary>
        /// Represents the w:name XML elements and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="abstractNum" />, <see cref="category" />, <see cref="docPartPr" />, <see cref="ffData" />, <see cref="fieldMapData" />, <see cref="frame" />, <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="decorated" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AbstractNumDefinitionName, DocPartName, FormFieldName, FrameName, Name, StyleName.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="attr" />, <see cref="autoCaption" />, <see cref="bookmarkStart" />, <see cref="caption" />, <see cref="compatSetting" />, <see cref="control" />, <see cref="docVar" />, <see cref="font" />, <see cref="lsdException" />, <see cref="moveFromRangeStart" />, <see cref="moveToRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AutoCaption.Name, BookmarkStart.Name, Caption.Name, CompatibilitySetting.Name, Control.Name, CustomXmlAttribute.Name, DocumentVariable.Name, Font.Name, LatentStyleExceptionInfo.Name, MoveFromRangeStart.Name, MoveToRangeStart.Name.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName name = w + "name";

        /// <summary>
        /// Represents the w:next XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NextParagraphStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName next = w + "next";

        /// <summary>
        /// Represents the w:nlCheck XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="activeWritingStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ActiveWritingStyle.NaturalLanguageGrammarCheck.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nlCheck = w + "nlCheck";

        /// <summary>
        /// Represents the w:noBorder XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="framesetSplitbar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noBorder = w + "noBorder";

        /// <summary>
        /// Represents the w:noBreakHyphen XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoBreakHyphen.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noBreakHyphen = w + "noBreakHyphen";

        /// <summary>
        /// Represents the w:noColumnBalance XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoColumnBalance.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noColumnBalance = w + "noColumnBalance";

        /// <summary>
        /// Represents the w:noEndnote XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoEndnote.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noEndnote = w + "noEndnote";

        /// <summary>
        /// Represents the w:noExtraLineSpacing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoExtraLineSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noExtraLineSpacing = w + "noExtraLineSpacing";

        /// <summary>
        /// Represents the w:noHBand XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblLook" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TableLook.NoHorizontalBand.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noHBand = w + "noHBand";

        /// <summary>
        /// Represents the w:noLabel XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="caption" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Caption.NoLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noLabel = w + "noLabel";

        /// <summary>
        /// Represents the w:noLeading XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoLeading.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noLeading = w + "noLeading";

        /// <summary>
        /// Represents the w:noLineBreaksAfter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="lang" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoLineBreaksAfterKinsoku.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noLineBreaksAfter = w + "noLineBreaksAfter";

        /// <summary>
        /// Represents the w:noLineBreaksBefore XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="lang" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoLineBreaksBeforeKinsoku.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noLineBreaksBefore = w + "noLineBreaksBefore";

        /// <summary>
        /// Represents the w:noProof XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoProof.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noProof = w + "noProof";

        /// <summary>
        /// Represents the w:noPunctuationKerning XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoPunctuationKerning.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noPunctuationKerning = w + "noPunctuationKerning";

        /// <summary>
        /// Represents the w:noResizeAllowed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frame" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoResizeAllowed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noResizeAllowed = w + "noResizeAllowed";

        /// <summary>
        /// Represents the w:noSpaceRaiseLower XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoSpaceRaiseLower.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noSpaceRaiseLower = w + "noSpaceRaiseLower";

        /// <summary>
        /// Represents the w:noTabHangInd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoTabHangIndent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noTabHangInd = w + "noTabHangInd";

        /// <summary>
        /// Represents the w:notTrueType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NotTrueType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName notTrueType = w + "notTrueType";

        /// <summary>
        /// Represents the w:noVBand XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblLook" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TableLook.NoVerticalBand.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noVBand = w + "noVBand";

        /// <summary>
        /// Represents the w:noWrap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NoWrap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName noWrap = w + "noWrap";

        /// <summary>
        /// Represents the w:nsid XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="abstractNum" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Nsid.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nsid = w + "nsid";

        /// <summary>
        /// Represents the w:null XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lvlText" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LevelText.Null.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @null = w + "null";

        /// <summary>
        /// Represents the w:num XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numbering" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="abstractNumId" />, <see cref="lvlOverride" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="numId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingInstance.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cols" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Columns.ColumnCount.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName num = w + "num";

        /// <summary>
        /// Represents the w:numbering XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="abstractNum" />, <see cref="num" />, <see cref="numIdMacAtCleanup" />, <see cref="numPicBullet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Numbering.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numbering = w + "numbering";

        /// <summary>
        /// Represents the w:numberingChange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fldChar" />, <see cref="numPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />, <see cref="original" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numberingChange = w + "numberingChange";

        /// <summary>
        /// Represents the w:numberingStyles XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.NumberingStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numberingStyles = w + "numberingStyles";

        /// <summary>
        /// Represents the w:numFmt XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="endnotePr" />, <see cref="footnotePr" />, <see cref="lvl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="format" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingFormat.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="caption" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Caption.NumberFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numFmt = w + "numFmt";

        /// <summary>
        /// Represents the w:numId XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingId.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="num" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: NumberingInstance.NumberID.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numId = w + "numId";

        /// <summary>
        /// Represents the w:numIdMacAtCleanup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numbering" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingIdMacAtCleanup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numIdMacAtCleanup = w + "numIdMacAtCleanup";

        /// <summary>
        /// Represents the w:numPicBullet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="numbering" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="drawing" />, <see cref="pict" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="numPicBulletId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingPictureBullet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numPicBullet = w + "numPicBullet";

        /// <summary>
        /// Represents the w:numPicBulletId XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="numPicBullet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: NumberingPictureBullet.NumberingPictureBulletId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numPicBulletId = w + "numPicBulletId";

        /// <summary>
        /// Represents the w:numPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ilvl" />, <see cref="ins" />, <see cref="numberingChange" />, <see cref="numId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numPr = w + "numPr";

        /// <summary>
        /// Represents the w:numRestart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="endnotePr" />, <see cref="footnotePr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingRestart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numRestart = w + "numRestart";

        /// <summary>
        /// Represents the w:numStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="endnotePr" />, <see cref="footnotePr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numStart = w + "numStart";

        /// <summary>
        /// Represents the w:numStyleLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="abstractNum" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingStyleLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numStyleLink = w + "numStyleLink";

        /// <summary>
        /// Represents the w:object XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.OLEObject" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />, <see cref="control" />, <see cref="drawing" />, <see cref="objectEmbed" />, <see cref="objectLink" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="dxaOrig" />, <see cref="dyaOrig" />, <see cref="W14.anchorId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EmbeddedObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @object = w + "object";

        /// <summary>
        /// Represents the w:objectEmbed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@object" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="drawAspect" />, <see cref="fieldCodes" />, <see cref="progId" />, <see cref="shapeId_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ObjectEmbed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName objectEmbed = w + "objectEmbed";

        /// <summary>
        /// Represents the w:objectLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@object" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="drawAspect" />, <see cref="fieldCodes" />, <see cref="lockedField" />, <see cref="progId" />, <see cref="shapeId_" />, <see cref="updateMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ObjectLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName objectLink = w + "objectLink";

        /// <summary>
        /// Represents the w:oddHBand XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.OddHorizontalBand.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oddHBand = w + "oddHBand";

        /// <summary>
        /// Represents the w:oddVBand XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cnfStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ConditionalFormatStyle.OddVerticalBand.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oddVBand = w + "oddVBand";

        /// <summary>
        /// Represents the w:odso XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="colDelim" />, <see cref="fHdr" />, <see cref="fieldMapData" />, <see cref="recipientData" />, <see cref="src" />, <see cref="table" />, <see cref="type" />, <see cref="udl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataSourceObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName odso = w + "odso";

        /// <summary>
        /// Represents the w:offsetFrom XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgBorders" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageBorders.OffsetFrom.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName offsetFrom = w + "offsetFrom";

        /// <summary>
        /// Represents the w:oMath XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeMath.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oMath = w + "oMath";

        /// <summary>
        /// Represents the w:optimizeForBrowser XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OptimizeForBrowser.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName optimizeForBrowser = w + "optimizeForBrowser";

        /// <summary>
        /// Represents the w:orient XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgSz" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageSize.Orient.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName orient = w + "orient";

        /// <summary>
        /// Represents the w:original XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="numberingChange" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: NumberingChange.Original.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName original = w + "original";

        /// <summary>
        /// Represents the w:other XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="paperSrc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PaperSource.Other.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName other = w + "other";

        /// <summary>
        /// Represents the w:outline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Outline.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName outline = w + "outline";

        /// <summary>
        /// Represents the w:outlineLvl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OutlineLevel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName outlineLvl = w + "outlineLvl";

        /// <summary>
        /// Represents the w:overflowPunct XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OverflowPunctuation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName overflowPunct = w + "overflowPunct";

        /// <summary>
        /// Represents the w:p XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="sdtContent" />, <see cref="tc" />, <see cref="txbxContent" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="pPr" />, <see cref="proofErr" />, <see cref="r" />, <see cref="sdt" />, <see cref="subDoc" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="rsidDel" />, <see cref="rsidP" />, <see cref="rsidR" />, <see cref="rsidRDefault" />, <see cref="rsidRPr" />, <see cref="W14.noSpellErr" />, <see cref="W14.paraId" />, <see cref="W14.textId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Paragraph.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName p = w + "p";

        /// <summary>
        /// Represents the w:pageBreakBefore XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageBreakBefore.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageBreakBefore = w + "pageBreakBefore";

        /// <summary>
        /// Represents the w:panose1 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Panose1Number.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName panose1 = w + "panose1";

        /// <summary>
        /// Represents the w:paperSrc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="first" />, <see cref="other" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PaperSource.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName paperSrc = w + "paperSrc";

        /// <summary>
        /// Represents the w:pBdr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bar" />, <see cref="between" />, <see cref="bottom" />, <see cref="left" />, <see cref="right" />, <see cref="top" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParagraphBorders.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pBdr = w + "pBdr";

        /// <summary>
        /// Represents the w:percent XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="zoom" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Zoom.Percent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName percent = w + "percent";

        /// <summary>
        /// Represents the w:permEnd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="displacedByCustomXml" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PermEnd.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName permEnd = w + "permEnd";

        /// <summary>
        /// Represents the w:permStart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="colFirst" />, <see cref="colLast" />, <see cref="displacedByCustomXml" />, <see cref="ed" />, <see cref="edGrp" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PermStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName permStart = w + "permStart";

        /// <summary>
        /// Represents the w:personal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Personal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName personal = w + "personal";

        /// <summary>
        /// Represents the w:personalCompose XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PersonalCompose.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName personalCompose = w + "personalCompose";

        /// <summary>
        /// Represents the w:personalReply XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PersonalReply.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName personalReply = w + "personalReply";

        /// <summary>
        /// Represents the w:pgBorders XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bottom" />, <see cref="left" />, <see cref="right" />, <see cref="top" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="display" />, <see cref="offsetFrom" />, <see cref="zOrder" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageBorders.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pgBorders = w + "pgBorders";

        /// <summary>
        /// Represents the w:pgMar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="bottom" />, <see cref="footer" />, <see cref="gutter" />, <see cref="header" />, <see cref="left" />, <see cref="right" />, <see cref="top" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageMargin.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pgMar = w + "pgMar";

        /// <summary>
        /// Represents the w:pgNum XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageNumber.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pgNum = w + "pgNum";

        /// <summary>
        /// Represents the w:pgNumType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="chapSep" />, <see cref="chapStyle" />, <see cref="fmt" />, <see cref="start" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageNumberType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pgNumType = w + "pgNumType";

        /// <summary>
        /// Represents the w:pgSz XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="code" />, <see cref="h" />, <see cref="orient" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pgSz = w + "pgSz";

        /// <summary>
        /// Represents the w:pict XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="numPicBullet" />, <see cref="r" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.OLEObject" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.group" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />, <see cref="control" />, <see cref="movie" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="W14.anchorId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Picture, PictureBulletBase.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pict = w + "pict";

        /// <summary>
        /// Represents the w:picture XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentPicture.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName picture = w + "picture";

        /// <summary>
        /// Represents the w:pitch XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Pitch.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pitch = w + "pitch";

        /// <summary>
        /// Represents the w:pixelsPerInch XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PixelsPerInch.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pixelsPerInch = w + "pixelsPerInch";

        /// <summary>
        /// Represents the w:placeholder XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customXmlPr" />, <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="docPart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomXmlPlaceholder, SdtPlaceholder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName placeholder = w + "placeholder";

        /// <summary>
        /// Represents the w:pos XML elements and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="endnotePr" />, <see cref="footnotePr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndnotePosition, FootnotePosition.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="caption" />, <see cref="tab" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Caption.Position, TabStop.Position.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pos = w + "pos";

        /// <summary>
        /// Represents the w:position XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Position.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName position = w + "position";

        /// <summary>
        /// Represents the w:pPr XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />, <see cref="p" />, <see cref="pPrChange" />, <see cref="pPrDefault" />, <see cref="style" />, <see cref="tblStylePr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="adjustRightInd" />, <see cref="autoSpaceDE" />, <see cref="autoSpaceDN" />, <see cref="bidi" />, <see cref="cnfStyle" />, <see cref="contextualSpacing" />, <see cref="divId" />, <see cref="framePr" />, <see cref="ind" />, <see cref="jc" />, <see cref="keepLines" />, <see cref="keepNext" />, <see cref="kinsoku" />, <see cref="mirrorIndents" />, <see cref="numPr" />, <see cref="outlineLvl" />, <see cref="overflowPunct" />, <see cref="pageBreakBefore" />, <see cref="pBdr" />, <see cref="pPrChange" />, <see cref="pStyle" />, <see cref="rPr" />, <see cref="sectPr" />, <see cref="shd" />, <see cref="snapToGrid" />, <see cref="spacing" />, <see cref="suppressAutoHyphens" />, <see cref="suppressLineNumbers" />, <see cref="suppressOverlap" />, <see cref="tabs" />, <see cref="textAlignment" />, <see cref="textboxTightWrap" />, <see cref="textDirection" />, <see cref="topLinePunct" />, <see cref="widowControl" />, <see cref="wordWrap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParagraphProperties, ParagraphPropertiesBaseStyle, ParagraphPropertiesExtended, PreviousParagraphProperties, StyleParagraphProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pPr = w + "pPr";

        /// <summary>
        /// Represents the w:pPrChange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParagraphPropertiesChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pPrChange = w + "pPrChange";

        /// <summary>
        /// Represents the w:pPrDefault XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docDefaults" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParagraphPropertiesDefault.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pPrDefault = w + "pPrDefault";

        /// <summary>
        /// Represents the w:prefixMappings XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="dataBinding" />, <see cref="W15.dataBinding" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DataBinding.PrefixMappings.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName prefixMappings = w + "prefixMappings";

        /// <summary>
        /// Represents the w:printBodyTextBeforeHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintBodyTextBeforeHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName printBodyTextBeforeHeader = w + "printBodyTextBeforeHeader";

        /// <summary>
        /// Represents the w:printColBlack XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintColorBlackWhite.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName printColBlack = w + "printColBlack";

        /// <summary>
        /// Represents the w:printerSettings XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrinterSettingsReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName printerSettings = w + "printerSettings";

        /// <summary>
        /// Represents the w:printFormsData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintFormsData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName printFormsData = w + "printFormsData";

        /// <summary>
        /// Represents the w:printFractionalCharacterWidth XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintFractionalCharacterWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName printFractionalCharacterWidth = w + "printFractionalCharacterWidth";

        /// <summary>
        /// Represents the w:printPostScriptOverText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintPostScriptOverText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName printPostScriptOverText = w + "printPostScriptOverText";

        /// <summary>
        /// Represents the w:printTwoOnOne XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintTwoOnOne.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName printTwoOnOne = w + "printTwoOnOne";

        /// <summary>
        /// Represents the w:progId XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="objectEmbed" />, <see cref="objectLink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ObjectEmbed.ProgId, ObjectLink.ProgId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName progId = w + "progId";

        /// <summary>
        /// Represents the w:proofErr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ProofError.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName proofErr = w + "proofErr";

        /// <summary>
        /// Represents the w:proofState XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="grammar" />, <see cref="spelling" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ProofState.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName proofState = w + "proofState";

        /// <summary>
        /// Represents the w:pStyle XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />, <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParagraphStyleId, ParagraphStyleIdInLevel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pStyle = w + "pStyle";

        /// <summary>
        /// Represents the w:ptab XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="alignment" />, <see cref="leader" />, <see cref="relativeTo" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PositionalTab.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ptab = w + "ptab";

        /// <summary>
        /// Represents the w:qFormat XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrimaryStyle.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lsdException" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyleExceptionInfo.PrimaryStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName qFormat = w + "qFormat";

        /// <summary>
        /// Represents the w:query XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Query.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName query = w + "query";

        /// <summary>
        /// Represents the w:r XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.oMathPara" />, <see cref="bdo" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="annotationRef" />, <see cref="br" />, <see cref="commentReference" />, <see cref="continuationSeparator" />, <see cref="cr" />, <see cref="dayLong" />, <see cref="dayShort" />, <see cref="delInstrText" />, <see cref="delText" />, <see cref="drawing" />, <see cref="endnoteRef" />, <see cref="endnoteReference" />, <see cref="fldChar" />, <see cref="footnoteRef" />, <see cref="footnoteReference" />, <see cref="instrText" />, <see cref="lastRenderedPageBreak" />, <see cref="monthLong" />, <see cref="monthShort" />, <see cref="noBreakHyphen" />, <see cref="@object" />, <see cref="pgNum" />, <see cref="pict" />, <see cref="ptab" />, <see cref="rPr" />, <see cref="ruby" />, <see cref="separator" />, <see cref="softHyphen" />, <see cref="sym" />, <see cref="t" />, <see cref="tab" />, <see cref="yearLong" />, <see cref="yearShort" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="rsidDel" />, <see cref="rsidR" />, <see cref="rsidRPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Run.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName r = w + "r";

        /// <summary>
        /// Represents the w:readModeInkLockDown XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="actualPg" />, <see cref="fontSz" />, <see cref="h" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ReadModeInkLockDown.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName readModeInkLockDown = w + "readModeInkLockDown";

        /// <summary>
        /// Represents the w:recipientData XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="odso" />, <see cref="recipients" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="active" />, <see cref="column" />, <see cref="uniqueTag" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RecipientData, RecipientDataReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName recipientData = w + "recipientData";

        /// <summary>
        /// Represents the w:recipients XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="recipientData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Recipients.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName recipients = w + "recipients";

        /// <summary>
        /// Represents the w:recommended XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: WriteProtection.Recommended.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName recommended = w + "recommended";

        /// <summary>
        /// Represents the w:relativeTo XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ptab" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PositionalTab.RelativeTo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName relativeTo = w + "relativeTo";

        /// <summary>
        /// Represents the w:relyOnVML XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RelyOnVML.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName relyOnVML = w + "relyOnVML";

        /// <summary>
        /// Represents the w:removeDateAndTime XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RemoveDateAndTime.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName removeDateAndTime = w + "removeDateAndTime";

        /// <summary>
        /// Represents the w:removePersonalInformation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RemovePersonalInformation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName removePersonalInformation = w + "removePersonalInformation";

        /// <summary>
        /// Represents the w:restart XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lnNumType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LineNumberType.Restart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName restart = w + "restart";

        /// <summary>
        /// Represents the w:result XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ddList" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DropDownListSelection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName result = w + "result";

        /// <summary>
        /// Represents the w:revisionView XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="comments" />, <see cref="formatting" />, <see cref="inkAnnotations" />, <see cref="insDel" />, <see cref="markup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionView.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName revisionView = w + "revisionView";

        /// <summary>
        /// Represents the w:rFonts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="ascii" />, <see cref="asciiTheme" />, <see cref="cs" />, <see cref="cstheme" />, <see cref="eastAsia" />, <see cref="eastAsiaTheme" />, <see cref="hAnsi" />, <see cref="hAnsiTheme" />, <see cref="hint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RunFonts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rFonts = w + "rFonts";

        /// <summary>
        /// Represents the w:richText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentRichText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName richText = w + "richText";

        /// <summary>
        /// Represents the w:right XML elements and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="divBdr" />, <see cref="pBdr" />, <see cref="pgBorders" />, <see cref="tblBorders" />, <see cref="tblCellMar" />, <see cref="tcBorders" />, <see cref="tcMar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="type" />, <see cref="val" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RightBorder, RightMargin, TableCellRightMargin.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />, <see cref="pgMar" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.Right, PageMargin.Right.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName right = w + "right";

        /// <summary>
        /// Represents the w:rightChars XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.RightChars.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rightChars = w + "rightChars";

        /// <summary>
        /// Represents the w:rightFromText XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TablePositionProperties.RightFromText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rightFromText = w + "rightFromText";

        /// <summary>
        /// Represents the w:rPr XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.ctrlPr" />, <see cref="M.r" />, <see cref="del" />, <see cref="ins" />, <see cref="lvl" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="pPr" />, <see cref="r" />, <see cref="rPrChange" />, <see cref="rPrDefault" />, <see cref="sdtEndPr" />, <see cref="sdtPr" />, <see cref="style" />, <see cref="tblStylePr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="b" />, <see cref="bCs" />, <see cref="bdr" />, <see cref="caps" />, <see cref="color" />, <see cref="cs" />, <see cref="del" />, <see cref="dstrike" />, <see cref="eastAsianLayout" />, <see cref="effect" />, <see cref="em" />, <see cref="emboss" />, <see cref="fitText" />, <see cref="highlight" />, <see cref="i" />, <see cref="iCs" />, <see cref="imprint" />, <see cref="ins" />, <see cref="kern" />, <see cref="lang" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="noProof" />, <see cref="oMath" />, <see cref="outline" />, <see cref="position" />, <see cref="rFonts" />, <see cref="rPrChange" />, <see cref="rStyle" />, <see cref="rtl" />, <see cref="shadow" />, <see cref="shd" />, <see cref="smallCaps" />, <see cref="snapToGrid" />, <see cref="spacing" />, <see cref="specVanish" />, <see cref="strike" />, <see cref="sz" />, <see cref="szCs" />, <see cref="u" />, <see cref="vanish" />, <see cref="vertAlign" />, <see cref="w_" />, <see cref="webHidden" />, <see cref="W14.cntxtAlts" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.glow" />, <see cref="W14.ligatures" />, <see cref="W14.numForm" />, <see cref="W14.numSpacing" />, <see cref="W14.props3d" />, <see cref="W14.reflection" />, <see cref="W14.scene3d" />, <see cref="W14.shadow" />, <see cref="W14.stylisticSets" />, <see cref="W14.textFill" />, <see cref="W14.textOutline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingSymbolRunProperties, ParagraphMarkRunProperties, PreviousParagraphMarkRunProperties, PreviousRunProperties, RunProperties, RunPropertiesBaseStyle, StyleRunProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rPr = w + "rPr";

        /// <summary>
        /// Represents the w:rPrChange XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ParagraphMarkRunPropertiesChange, RunPropertiesChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rPrChange = w + "rPrChange";

        /// <summary>
        /// Represents the w:rPrDefault XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docDefaults" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RunPropertiesDefault.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rPrDefault = w + "rPrDefault";

        /// <summary>
        /// Represents the w:rsid XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rsids" />, <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Rsid.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsid = w + "rsid";

        /// <summary>
        /// Represents the w:rsidDel XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="p" />, <see cref="r" />, <see cref="sectPr" />, <see cref="tr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Paragraph.RsidParagraphDeletion, PreviousSectionProperties.RsidDel, Run.RsidRunDeletion, SectionProperties.RsidDel, TableRow.RsidTableRowDeletion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsidDel = w + "rsidDel";

        /// <summary>
        /// Represents the w:rsidP XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Paragraph.RsidParagraphProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsidP = w + "rsidP";

        /// <summary>
        /// Represents the w:rsidR XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="p" />, <see cref="r" />, <see cref="sectPr" />, <see cref="tr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Paragraph.RsidParagraphAddition, PreviousSectionProperties.RsidR, Run.RsidRunAddition, SectionProperties.RsidR, TableRow.RsidTableRowAddition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsidR = w + "rsidR";

        /// <summary>
        /// Represents the w:rsidRDefault XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Paragraph.RsidRunAdditionDefault.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsidRDefault = w + "rsidRDefault";

        /// <summary>
        /// Represents the w:rsidRoot XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rsids" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RsidRoot.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsidRoot = w + "rsidRoot";

        /// <summary>
        /// Represents the w:rsidRPr XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="p" />, <see cref="r" />, <see cref="sectPr" />, <see cref="tr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Paragraph.RsidParagraphMarkRevision, PreviousSectionProperties.RsidRPr, Run.RsidRunProperties, SectionProperties.RsidRPr, TableRow.RsidTableRowMarkRevision.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsidRPr = w + "rsidRPr";

        /// <summary>
        /// Represents the w:rsids XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rsid" />, <see cref="rsidRoot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Rsids.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsids = w + "rsids";

        /// <summary>
        /// Represents the w:rsidSect XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PreviousSectionProperties.RsidSect, SectionProperties.RsidSect.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsidSect = w + "rsidSect";

        /// <summary>
        /// Represents the w:rsidTr XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TableRow.RsidTableRowProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsidTr = w + "rsidTr";

        /// <summary>
        /// Represents the w:rStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RunStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rStyle = w + "rStyle";

        /// <summary>
        /// Represents the w:rt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ruby" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RubyContent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rt = w + "rt";

        /// <summary>
        /// Represents the w:rtl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RightToLeftText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rtl = w + "rtl";

        /// <summary>
        /// Represents the w:rtlGutter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GutterOnRight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rtlGutter = w + "rtlGutter";

        /// <summary>
        /// Represents the w:ruby XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rt" />, <see cref="rubyBase" />, <see cref="rubyPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Ruby.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ruby = w + "ruby";

        /// <summary>
        /// Represents the w:rubyAlign XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rubyPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RubyAlign.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rubyAlign = w + "rubyAlign";

        /// <summary>
        /// Represents the w:rubyBase XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ruby" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="sdt" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RubyBase.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rubyBase = w + "rubyBase";

        /// <summary>
        /// Represents the w:rubyPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ruby" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dirty" />, <see cref="hps" />, <see cref="hpsBaseText" />, <see cref="hpsRaise" />, <see cref="lid" />, <see cref="rubyAlign" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RubyProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rubyPr = w + "rubyPr";

        /// <summary>
        /// Represents the w:salt XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.Salt, WriteProtection.Salt.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName salt = w + "salt";

        /// <summary>
        /// Represents the w:saltValue XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.SaltValue, WriteProtection.SaltValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName saltValue = w + "saltValue";

        /// <summary>
        /// Represents the w:saveFormsData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SaveFormsData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName saveFormsData = w + "saveFormsData";

        /// <summary>
        /// Represents the w:saveInvalidXml XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SaveInvalidXml.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName saveInvalidXml = w + "saveInvalidXml";

        /// <summary>
        /// Represents the w:savePreviewPicture XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SavePreviewPicture.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName savePreviewPicture = w + "savePreviewPicture";

        /// <summary>
        /// Represents the w:saveSubsetFonts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SaveSubsetFonts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName saveSubsetFonts = w + "saveSubsetFonts";

        /// <summary>
        /// Represents the w:saveThroughXslt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />, <see cref="solutionID" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SaveThroughXslt.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName saveThroughXslt = w + "saveThroughXslt";

        /// <summary>
        /// Represents the w:saveXmlDataOnly XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SaveXmlDataOnly.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName saveXmlDataOnly = w + "saveXmlDataOnly";

        /// <summary>
        /// Represents the w:scrollbar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frame" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScrollbarVisibility.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scrollbar = w + "scrollbar";

        /// <summary>
        /// Represents the w:sdt XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.deg" />, <see cref="M.den" />, <see cref="M.e" />, <see cref="M.fName" />, <see cref="M.lim" />, <see cref="M.num" />, <see cref="M.oMath" />, <see cref="M.sub" />, <see cref="M.sup" />, <see cref="bdo" />, <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="del" />, <see cref="dir" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="fldSimple" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveTo" />, <see cref="p" />, <see cref="rt" />, <see cref="rubyBase" />, <see cref="sdtContent" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="txbxContent" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="sdtContent" />, <see cref="sdtEndPr" />, <see cref="sdtPr" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtBlock, SdtCell, SdtRow, SdtRun, SdtRunRuby.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sdt = w + "sdt";

        /// <summary>
        /// Represents the w:sdtContent XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.acc" />, <see cref="M.bar" />, <see cref="M.borderBox" />, <see cref="M.box" />, <see cref="M.d" />, <see cref="M.eqArr" />, <see cref="M.f" />, <see cref="M.func" />, <see cref="M.groupChr" />, <see cref="M.limLow" />, <see cref="M.limUpp" />, <see cref="M.m_" />, <see cref="M.nary" />, <see cref="M.oMath" />, <see cref="M.oMathPara" />, <see cref="M.phant" />, <see cref="M.r" />, <see cref="M.rad" />, <see cref="M.sPre" />, <see cref="M.sSub" />, <see cref="M.sSubSup" />, <see cref="M.sSup" />, <see cref="bdo" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="r" />, <see cref="sdt" />, <see cref="subDoc" />, <see cref="tbl" />, <see cref="tc" />, <see cref="tr" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentBlock, SdtContentCell, SdtContentRow, SdtContentRun, SdtContentRunRuby.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sdtContent = w + "sdtContent";

        /// <summary>
        /// Represents the w:sdtEndPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtEndCharProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sdtEndPr = w + "sdtEndPr";

        /// <summary>
        /// Represents the w:sdtPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdt" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alias" />, <see cref="bibliography" />, <see cref="citation" />, <see cref="comboBox" />, <see cref="dataBinding" />, <see cref="date" />, <see cref="docPartList" />, <see cref="docPartObj" />, <see cref="dropDownList" />, <see cref="equation" />, <see cref="group" />, <see cref="id" />, <see cref="@lock" />, <see cref="picture" />, <see cref="placeholder" />, <see cref="richText" />, <see cref="rPr" />, <see cref="showingPlcHdr" />, <see cref="tag" />, <see cref="temporary" />, <see cref="text" />, <see cref="W14.checkbox" />, <see cref="W14.entityPicker" />, <see cref="W15.appearance" />, <see cref="W15.color" />, <see cref="W15.dataBinding" />, <see cref="W15.repeatingSection" />, <see cref="W15.repeatingSectionItem" />, <see cref="W15.webExtensionCreated" />, <see cref="W15.webExtensionLinked" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sdtPr = w + "sdtPr";

        /// <summary>
        /// Represents the w:sectPr XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="body" />, <see cref="docPartBody" />, <see cref="pPr" />, <see cref="sectPrChange" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bidi" />, <see cref="cols" />, <see cref="docGrid" />, <see cref="endnotePr" />, <see cref="footerReference" />, <see cref="footnotePr" />, <see cref="formProt" />, <see cref="headerReference" />, <see cref="lnNumType" />, <see cref="noEndnote" />, <see cref="paperSrc" />, <see cref="pgBorders" />, <see cref="pgMar" />, <see cref="pgNumType" />, <see cref="pgSz" />, <see cref="printerSettings" />, <see cref="rtlGutter" />, <see cref="sectPrChange" />, <see cref="textDirection" />, <see cref="titlePg" />, <see cref="type" />, <see cref="vAlign" />, <see cref="W15.footnoteColumns" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="rsidDel" />, <see cref="rsidR" />, <see cref="rsidRPr" />, <see cref="rsidSect" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreviousSectionProperties, SectionProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sectPr = w + "sectPr";

        /// <summary>
        /// Represents the w:sectPrChange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SectionPropertiesChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sectPrChange = w + "sectPrChange";

        /// <summary>
        /// Represents the w:selectFldWithFirstOrLastChar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SelectFieldWithFirstOrLastChar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName selectFldWithFirstOrLastChar = w + "selectFldWithFirstOrLastChar";

        /// <summary>
        /// Represents the w:semiHidden XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SemiHidden.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lsdException" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyleExceptionInfo.SemiHidden.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName semiHidden = w + "semiHidden";

        /// <summary>
        /// Represents the w:sep XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="caption" />, <see cref="cols" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Caption.Separator, Columns.Separator.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sep = w + "sep";

        /// <summary>
        /// Represents the w:separator XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SeparatorMark.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName separator = w + "separator";

        /// <summary>
        /// Represents the w:settings XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="M.mathPr" />, <see cref="SL.schemaLibrary" />, <see cref="activeWritingStyle" />, <see cref="alignBordersAndEdges" />, <see cref="alwaysMergeEmptyNamespace" />, <see cref="alwaysShowPlaceholderText" />, <see cref="attachedSchema" />, <see cref="attachedTemplate" />, <see cref="autoFormatOverride" />, <see cref="autoHyphenation" />, <see cref="bookFoldPrinting" />, <see cref="bookFoldPrintingSheets" />, <see cref="bookFoldRevPrinting" />, <see cref="bordersDoNotSurroundFooter" />, <see cref="bordersDoNotSurroundHeader" />, <see cref="captions" />, <see cref="characterSpacingControl" />, <see cref="clickAndTypeStyle" />, <see cref="clrSchemeMapping" />, <see cref="compat" />, <see cref="consecutiveHyphenLimit" />, <see cref="decimalSymbol" />, <see cref="defaultTableStyle" />, <see cref="defaultTabStop" />, <see cref="displayBackgroundShape" />, <see cref="displayHorizontalDrawingGridEvery" />, <see cref="displayVerticalDrawingGridEvery" />, <see cref="documentProtection" />, <see cref="documentType" />, <see cref="docVars" />, <see cref="doNotAutoCompressPictures" />, <see cref="doNotDemarcateInvalidXml" />, <see cref="doNotDisplayPageBoundaries" />, <see cref="doNotHyphenateCaps" />, <see cref="doNotIncludeSubdocsInStats" />, <see cref="doNotShadeFormData" />, <see cref="doNotTrackFormatting" />, <see cref="doNotTrackMoves" />, <see cref="doNotUseMarginsForDrawingGridOrigin" />, <see cref="doNotValidateAgainstSchema" />, <see cref="drawingGridHorizontalOrigin" />, <see cref="drawingGridHorizontalSpacing" />, <see cref="drawingGridVerticalOrigin" />, <see cref="drawingGridVerticalSpacing" />, <see cref="embedSystemFonts" />, <see cref="embedTrueTypeFonts" />, <see cref="endnotePr" />, <see cref="evenAndOddHeaders" />, <see cref="footnotePr" />, <see cref="forceUpgrade" />, <see cref="formsDesign" />, <see cref="gutterAtTop" />, <see cref="hdrShapeDefaults" />, <see cref="hideGrammaticalErrors" />, <see cref="hideSpellingErrors" />, <see cref="hyphenationZone" />, <see cref="ignoreMixedContent" />, <see cref="linkStyles" />, <see cref="listSeparator" />, <see cref="mailMerge" />, <see cref="mirrorMargins" />, <see cref="noLineBreaksAfter" />, <see cref="noLineBreaksBefore" />, <see cref="noPunctuationKerning" />, <see cref="printFormsData" />, <see cref="printFractionalCharacterWidth" />, <see cref="printPostScriptOverText" />, <see cref="printTwoOnOne" />, <see cref="proofState" />, <see cref="readModeInkLockDown" />, <see cref="removeDateAndTime" />, <see cref="removePersonalInformation" />, <see cref="revisionView" />, <see cref="rsids" />, <see cref="saveFormsData" />, <see cref="saveInvalidXml" />, <see cref="savePreviewPicture" />, <see cref="saveSubsetFonts" />, <see cref="saveThroughXslt" />, <see cref="saveXmlDataOnly" />, <see cref="shapeDefaults" />, <see cref="showEnvelope" />, <see cref="showXMLTags" />, <see cref="strictFirstAndLastChars" />, <see cref="styleLockQFSet" />, <see cref="styleLockTheme" />, <see cref="stylePaneFormatFilter" />, <see cref="stylePaneSortMethod" />, <see cref="summaryLength" />, <see cref="themeFontLang" />, <see cref="trackRevisions" />, <see cref="uiCompat97To2003" />, <see cref="updateFields" />, <see cref="useXSLTWhenSaving" />, <see cref="view" />, <see cref="writeProtection" />, <see cref="zoom" />, <see cref="W14.conflictMode" />, <see cref="W14.defaultImageDpi" />, <see cref="W14.discardImageEditingData" />, <see cref="W14.docId" />, <see cref="W15.chartTrackingRefBased" />, <see cref="W15.docId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Settings.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName settings = w + "settings";

        /// <summary>
        /// Represents the w:shadow XML element and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shadow.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bar" />, <see cref="bdr" />, <see cref="between" />, <see cref="bottom" />, <see cref="end" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="left" />, <see cref="right" />, <see cref="start" />, <see cref="tl2br" />, <see cref="top" />, <see cref="tr2bl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BarBorder.Shadow, BetweenBorder.Shadow, Border.Shadow, BottomBorder.Shadow, EndBorder.Shadow, InsideHorizontalBorder.Shadow, InsideVerticalBorder.Shadow, LeftBorder.Shadow, RightBorder.Shadow, StartBorder.Shadow, TopBorder.Shadow, TopLeftToBottomRightCellBorder.Shadow, TopRightToBottomLeftCellBorder.Shadow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shadow = w + "shadow";

        /// <summary>
        /// Represents the w:shapeDefaults XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="O.shapedefaults" />, <see cref="O.shapelayout" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeDefaults.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shapeDefaults = w + "shapeDefaults";

        /// <summary>
        /// Represents the w:shapeid XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="control" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Control.ShapeId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shapeid = w + "shapeid";

        /// <summary>
        /// Represents the w:shapeId XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="objectEmbed" />, <see cref="objectLink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ObjectEmbed.ShapeId, ObjectLink.ShapeId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shapeId_ = w + "shapeId";

        /// <summary>
        /// Represents the w:shapeLayoutLikeWW8 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShapeLayoutLikeWord8.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shapeLayoutLikeWW8 = w + "shapeLayoutLikeWW8";

        /// <summary>
        /// Represents the w:shd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />, <see cref="rPr" />, <see cref="tblPr" />, <see cref="tblPrEx" />, <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="fill" />, <see cref="themeColor" />, <see cref="themeFill" />, <see cref="themeFillShade" />, <see cref="themeFillTint" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shading.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shd = w + "shd";

        /// <summary>
        /// Represents the w:showBreaksInFrames XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowBreaksInFrames.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showBreaksInFrames = w + "showBreaksInFrames";

        /// <summary>
        /// Represents the w:showEnvelope XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowEnvelope.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showEnvelope = w + "showEnvelope";

        /// <summary>
        /// Represents the w:showingPlcHdr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowingPlaceholder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showingPlcHdr = w + "showingPlcHdr";

        /// <summary>
        /// Represents the w:showXMLTags XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ShowXmlTags.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName showXMLTags = w + "showXMLTags";

        /// <summary>
        /// Represents the w:sig XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="csb0" />, <see cref="csb1" />, <see cref="usb0" />, <see cref="usb1" />, <see cref="usb2" />, <see cref="usb3" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontSignature.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sig = w + "sig";

        /// <summary>
        /// Represents the w:size XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="checkBox" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormFieldSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName size = w + "size";

        /// <summary>
        /// Represents the w:sizeAuto XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="checkBox" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutomaticallySizeFormField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sizeAuto = w + "sizeAuto";

        /// <summary>
        /// Represents the w:smallCaps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SmallCaps.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName smallCaps = w + "smallCaps";

        /// <summary>
        /// Represents the w:snapToGrid XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SnapToGrid.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName snapToGrid = w + "snapToGrid";

        /// <summary>
        /// Represents the w:softHyphen XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SoftHyphen.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName softHyphen = w + "softHyphen";

        /// <summary>
        /// Represents the w:solutionID XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="saveThroughXslt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SaveThroughXslt.SolutionId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName solutionID = w + "solutionID";

        /// <summary>
        /// Represents the w:sourceFileName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frame" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SourceFileReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sourceFileName = w + "sourceFileName";

        /// <summary>
        /// Represents the w:space XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bar" />, <see cref="bdr" />, <see cref="between" />, <see cref="bottom" />, <see cref="col" />, <see cref="cols" />, <see cref="end" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="left" />, <see cref="right" />, <see cref="start" />, <see cref="tl2br" />, <see cref="top" />, <see cref="tr2bl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BarBorder.Space, BetweenBorder.Space, Border.Space, BottomBorder.Space, Column.Space, Columns.Space, EndBorder.Space, InsideHorizontalBorder.Space, InsideVerticalBorder.Space, LeftBorder.Space, RightBorder.Space, StartBorder.Space, TopBorder.Space, TopLeftToBottomRightCellBorder.Space, TopRightToBottomLeftCellBorder.Space.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName space = w + "space";

        /// <summary>
        /// Represents the w:spaceForUL XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SpaceForUnderline.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spaceForUL = w + "spaceForUL";

        /// <summary>
        /// Represents the w:spacing XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="after" />, <see cref="afterAutospacing" />, <see cref="afterLines" />, <see cref="before" />, <see cref="beforeAutospacing" />, <see cref="beforeLines" />, <see cref="line" />, <see cref="lineRule" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Spacing, SpacingBetweenLines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spacing = w + "spacing";

        /// <summary>
        /// Represents the w:spacingInWholePoints XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SpacingInWholePoints.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spacingInWholePoints = w + "spacingInWholePoints";

        /// <summary>
        /// Represents the w:specVanish XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SpecVanish.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName specVanish = w + "specVanish";

        /// <summary>
        /// Represents the w:spelling XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="proofState" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ProofState.Spelling.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spelling = w + "spelling";

        /// <summary>
        /// Represents the w:spinCount XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="documentProtection" />, <see cref="writeProtection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DocumentProtection.SpinCount, WriteProtection.SpinCount.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName spinCount = w + "spinCount";

        /// <summary>
        /// Represents the w:splitPgBreakAndParaMark XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SplitPageBreakAndParagraphMark.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName splitPgBreakAndParaMark = w + "splitPgBreakAndParaMark";

        /// <summary>
        /// Represents the w:src XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="odso" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SourceReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName src = w + "src";

        /// <summary>
        /// Represents the w:start XML elements and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />, <see cref="tblBorders" />, <see cref="tblCellMar" />, <see cref="tcBorders" />, <see cref="tcMar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="type" />, <see cref="val" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StartBorder, StartMargin, StartNumberingValue.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />, <see cref="lnNumType" />, <see cref="pgNumType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.Start, LineNumberType.Start, PageNumberType.Start.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName start = w + "start";

        /// <summary>
        /// Represents the w:startChars XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="ind" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Indentation.StartCharacters.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName startChars = w + "startChars";

        /// <summary>
        /// Represents the w:startOverride XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvlOverride" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StartOverrideNumberingValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName startOverride = w + "startOverride";

        /// <summary>
        /// Represents the w:statusText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ffData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StatusText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName statusText = w + "statusText";

        /// <summary>
        /// Represents the w:storeItemID XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="dataBinding" />, <see cref="W15.dataBinding" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DataBinding.StoreItemId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName storeItemID = w + "storeItemID";

        /// <summary>
        /// Represents the w:storeMappedDataAs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="date" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtDateMappingType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName storeMappedDataAs = w + "storeMappedDataAs";

        /// <summary>
        /// Represents the w:strictFirstAndLastChars XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StrictFirstAndLastChars.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strictFirstAndLastChars = w + "strictFirstAndLastChars";

        /// <summary>
        /// Represents the w:strike XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Strike.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strike = w + "strike";

        /// <summary>
        /// Represents the w:style XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPartPr" />, <see cref="styles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="aliases" />, <see cref="autoRedefine" />, <see cref="basedOn" />, <see cref="hidden" />, <see cref="link" />, <see cref="locked" />, <see cref="name" />, <see cref="next" />, <see cref="personal" />, <see cref="personalCompose" />, <see cref="personalReply" />, <see cref="pPr" />, <see cref="qFormat" />, <see cref="rPr" />, <see cref="rsid" />, <see cref="semiHidden" />, <see cref="tblPr" />, <see cref="tblStylePr" />, <see cref="tcPr" />, <see cref="trPr" />, <see cref="uiPriority" />, <see cref="unhideWhenUsed" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="customStyle" />, <see cref="@default" />, <see cref="styleId" />, <see cref="type" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Style, StyleId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName style = w + "style";

        /// <summary>
        /// Represents the w:styleId XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Style.StyleId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleId = w + "styleId";

        /// <summary>
        /// Represents the w:styleLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="abstractNum" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StyleLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleLink = w + "styleLink";

        /// <summary>
        /// Represents the w:styleLockQFSet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StyleLockStylesPart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleLockQFSet = w + "styleLockQFSet";

        /// <summary>
        /// Represents the w:styleLockTheme XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StyleLockThemesPart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleLockTheme = w + "styleLockTheme";

        /// <summary>
        /// Represents the w:stylePaneFormatFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="allStyles" />, <see cref="alternateStyleNames" />, <see cref="clearFormatting" />, <see cref="customStyles" />, <see cref="directFormattingOnNumbering" />, <see cref="directFormattingOnParagraphs" />, <see cref="directFormattingOnRuns" />, <see cref="directFormattingOnTables" />, <see cref="headingStyles" />, <see cref="latentStyles" />, <see cref="numberingStyles" />, <see cref="stylesInUse" />, <see cref="tableStyles" />, <see cref="top3HeadingStyles" />, <see cref="val" />, <see cref="visibleStyles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StylePaneFormatFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stylePaneFormatFilter = w + "stylePaneFormatFilter";

        /// <summary>
        /// Represents the w:stylePaneSortMethod XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StylePaneSortMethods.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stylePaneSortMethod = w + "stylePaneSortMethod";

        /// <summary>
        /// Represents the w:styles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="docDefaults" />, <see cref="latentStyles" />, <see cref="style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Styles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styles = w + "styles";

        /// <summary>
        /// Represents the w:stylesInUse XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.StylesInUse.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stylesInUse = w + "stylesInUse";

        /// <summary>
        /// Represents the w:subDoc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bdo" />, <see cref="customXml" />, <see cref="dir" />, <see cref="fldSimple" />, <see cref="hyperlink" />, <see cref="p" />, <see cref="sdtContent" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SubDocumentReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName subDoc = w + "subDoc";

        /// <summary>
        /// Represents the w:subFontBySize XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SubFontBySize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName subFontBySize = w + "subFontBySize";

        /// <summary>
        /// Represents the w:subsetted XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="embedBold" />, <see cref="embedBoldItalic" />, <see cref="embedItalic" />, <see cref="embedRegular" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EmbedBoldFont.Subsetted, EmbedBoldItalicFont.Subsetted, EmbedItalicFont.Subsetted, EmbedRegularFont.Subsetted.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName subsetted = w + "subsetted";

        /// <summary>
        /// Represents the w:suff XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="lvl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LevelSuffix.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suff = w + "suff";

        /// <summary>
        /// Represents the w:summaryLength XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SummaryLength.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName summaryLength = w + "summaryLength";

        /// <summary>
        /// Represents the w:suppressAutoHyphens XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SuppressAutoHyphens.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suppressAutoHyphens = w + "suppressAutoHyphens";

        /// <summary>
        /// Represents the w:suppressBottomSpacing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SuppressBottomSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suppressBottomSpacing = w + "suppressBottomSpacing";

        /// <summary>
        /// Represents the w:suppressLineNumbers XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SuppressLineNumbers.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suppressLineNumbers = w + "suppressLineNumbers";

        /// <summary>
        /// Represents the w:suppressOverlap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SuppressOverlap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suppressOverlap = w + "suppressOverlap";

        /// <summary>
        /// Represents the w:suppressSpacingAtTopOfPage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SuppressSpacingAtTopOfPage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suppressSpacingAtTopOfPage = w + "suppressSpacingAtTopOfPage";

        /// <summary>
        /// Represents the w:suppressSpBfAfterPgBrk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SuppressSpacingBeforeAfterPageBreak.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suppressSpBfAfterPgBrk = w + "suppressSpBfAfterPgBrk";

        /// <summary>
        /// Represents the w:suppressTopSpacing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SuppressTopSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suppressTopSpacing = w + "suppressTopSpacing";

        /// <summary>
        /// Represents the w:suppressTopSpacingWP XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SuppressTopSpacingWordPerfect.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName suppressTopSpacingWP = w + "suppressTopSpacingWP";

        /// <summary>
        /// Represents the w:swapBordersFacingPages XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SwapBordersFacingPages.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName swapBordersFacingPages = w + "swapBordersFacingPages";

        /// <summary>
        /// Represents the w:sym XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="@char" />, <see cref="font" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SymbolChar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sym = w + "sym";

        /// <summary>
        /// Represents the w:sz XML elements and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="frame" />, <see cref="frameset" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontSize, FrameSize.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bar" />, <see cref="bdr" />, <see cref="between" />, <see cref="bottom" />, <see cref="end" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="left" />, <see cref="right" />, <see cref="start" />, <see cref="tl2br" />, <see cref="top" />, <see cref="tr2bl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BarBorder.Size, BetweenBorder.Size, Border.Size, BottomBorder.Size, EndBorder.Size, InsideHorizontalBorder.Size, InsideVerticalBorder.Size, LeftBorder.Size, RightBorder.Size, StartBorder.Size, TopBorder.Size, TopLeftToBottomRightCellBorder.Size, TopRightToBottomLeftCellBorder.Size.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sz = w + "sz";

        /// <summary>
        /// Represents the w:szCs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontSizeComplexScript.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName szCs = w + "szCs";

        /// <summary>
        /// Represents the w:t XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="XML.space" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Text.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName t = w + "t";

        /// <summary>
        /// Represents the w:t1 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Text1.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName t1 = w + "t1";

        /// <summary>
        /// Represents the w:t2 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="clrSchemeMapping" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ColorSchemeMapping.Text2.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName t2 = w + "t2";

        /// <summary>
        /// Represents the w:tab XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />, <see cref="tabs" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="leader" />, <see cref="pos" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TabChar, TabStop.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tab = w + "tab";

        /// <summary>
        /// Represents the w:table XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="odso" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataSourceTableName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName table = w + "table";

        /// <summary>
        /// Represents the w:tableStyles XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.TableStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tableStyles = w + "tableStyles";

        /// <summary>
        /// Represents the w:tabs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tab" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tabs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tabs = w + "tabs";

        /// <summary>
        /// Represents the w:tag XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tag.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tag = w + "tag";

        /// <summary>
        /// Represents the w:targetScreenSz XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webSettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TargetScreenSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName targetScreenSz = w + "targetScreenSz";

        /// <summary>
        /// Represents the w:tbl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="body" />, <see cref="comment" />, <see cref="customXml" />, <see cref="docPartBody" />, <see cref="endnote" />, <see cref="footnote" />, <see cref="ftr" />, <see cref="hdr" />, <see cref="sdtContent" />, <see cref="tc" />, <see cref="txbxContent" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="tblGrid" />, <see cref="tblPr" />, <see cref="tr" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Table.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tbl = w + "tbl";

        /// <summary>
        /// Represents the w:tblBorders XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />, <see cref="tblPrEx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bottom" />, <see cref="end" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="left" />, <see cref="right" />, <see cref="start" />, <see cref="top" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableBorders.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblBorders = w + "tblBorders";

        /// <summary>
        /// Represents the w:tblCaption XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCaption.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblCaption = w + "tblCaption";

        /// <summary>
        /// Represents the w:tblCellMar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />, <see cref="tblPrEx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bottom" />, <see cref="end" />, <see cref="left" />, <see cref="right" />, <see cref="start" />, <see cref="top" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCellMarginDefault.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblCellMar = w + "tblCellMar";

        /// <summary>
        /// Represents the w:tblCellSpacing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />, <see cref="tblPrEx" />, <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCellSpacing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblCellSpacing = w + "tblCellSpacing";

        /// <summary>
        /// Represents the w:tblDescription XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableDescription.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblDescription = w + "tblDescription";

        /// <summary>
        /// Represents the w:tblGrid XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tbl" />, <see cref="tblGridChange" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="gridCol" />, <see cref="tblGridChange" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreviousTableGrid, TableGrid.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblGrid = w + "tblGrid";

        /// <summary>
        /// Represents the w:tblGridChange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblGrid" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tblGrid" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableGridChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblGridChange = w + "tblGridChange";

        /// <summary>
        /// Represents the w:tblHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblHeader = w + "tblHeader";

        /// <summary>
        /// Represents the w:tblInd XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />, <see cref="tblPrEx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableIndentation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblInd = w + "tblInd";

        /// <summary>
        /// Represents the w:tblLayout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />, <see cref="tblPrEx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableLayout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblLayout = w + "tblLayout";

        /// <summary>
        /// Represents the w:tblLook XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />, <see cref="tblPrEx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="firstColumn" />, <see cref="firstRow" />, <see cref="lastColumn" />, <see cref="lastRow" />, <see cref="noHBand" />, <see cref="noVBand" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableLook.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblLook = w + "tblLook";

        /// <summary>
        /// Represents the w:tblOverlap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableOverlap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblOverlap = w + "tblOverlap";

        /// <summary>
        /// Represents the w:tblpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="bottomFromText" />, <see cref="horzAnchor" />, <see cref="leftFromText" />, <see cref="rightFromText" />, <see cref="tblpX" />, <see cref="tblpXSpec" />, <see cref="tblpY" />, <see cref="tblpYSpec" />, <see cref="topFromText" />, <see cref="vertAnchor" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TablePositionProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblpPr = w + "tblpPr";

        /// <summary>
        /// Represents the w:tblPr XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />, <see cref="tbl" />, <see cref="tblPrChange" />, <see cref="tblStylePr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bidiVisual" />, <see cref="jc" />, <see cref="shd" />, <see cref="tblBorders" />, <see cref="tblCaption" />, <see cref="tblCellMar" />, <see cref="tblCellSpacing" />, <see cref="tblDescription" />, <see cref="tblInd" />, <see cref="tblLayout" />, <see cref="tblLook" />, <see cref="tblOverlap" />, <see cref="tblpPr" />, <see cref="tblPrChange" />, <see cref="tblStyle" />, <see cref="tblStyleColBandSize" />, <see cref="tblStyleRowBandSize" />, <see cref="tblW" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreviousTableProperties, StyleTableProperties, TableProperties, TableStyleConditionalFormattingTableProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblPr = w + "tblPr";

        /// <summary>
        /// Represents the w:tblPrChange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tblPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TablePropertiesChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblPrChange = w + "tblPrChange";

        /// <summary>
        /// Represents the w:tblPrEx XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPrExChange" />, <see cref="tr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="jc" />, <see cref="shd" />, <see cref="tblBorders" />, <see cref="tblCellMar" />, <see cref="tblCellSpacing" />, <see cref="tblInd" />, <see cref="tblLayout" />, <see cref="tblLook" />, <see cref="tblPrExChange" />, <see cref="tblW" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreviousTablePropertyExceptions, TablePropertyExceptions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblPrEx = w + "tblPrEx";

        /// <summary>
        /// Represents the w:tblPrExChange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPrEx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tblPrEx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TablePropertyExceptionsChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblPrExChange = w + "tblPrExChange";

        /// <summary>
        /// Represents the w:tblpX XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TablePositionProperties.TablePositionX.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblpX = w + "tblpX";

        /// <summary>
        /// Represents the w:tblpXSpec XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TablePositionProperties.TablePositionXAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblpXSpec = w + "tblpXSpec";

        /// <summary>
        /// Represents the w:tblpY XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TablePositionProperties.TablePositionY.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblpY = w + "tblpY";

        /// <summary>
        /// Represents the w:tblpYSpec XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TablePositionProperties.TablePositionYAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblpYSpec = w + "tblpYSpec";

        /// <summary>
        /// Represents the w:tblStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblStyle = w + "tblStyle";

        /// <summary>
        /// Represents the w:tblStyleColBandSize XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableStyleColumnBandSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblStyleColBandSize = w + "tblStyleColBandSize";

        /// <summary>
        /// Represents the w:tblStylePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pPr" />, <see cref="rPr" />, <see cref="tblPr" />, <see cref="tcPr" />, <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableStyleProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblStylePr = w + "tblStylePr";

        /// <summary>
        /// Represents the w:tblStyleRowBandSize XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableStyleRowBandSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblStyleRowBandSize = w + "tblStyleRowBandSize";

        /// <summary>
        /// Represents the w:tblW XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tblPr" />, <see cref="tblPrEx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tblW = w + "tblW";

        /// <summary>
        /// Represents the w:tc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customXml" />, <see cref="sdtContent" />, <see cref="tr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altChunk" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="tbl" />, <see cref="tcPr" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tc = w + "tc";

        /// <summary>
        /// Represents the w:tcBorders XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bottom" />, <see cref="end" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="left" />, <see cref="right" />, <see cref="start" />, <see cref="tl2br" />, <see cref="top" />, <see cref="tr2bl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCellBorders.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tcBorders = w + "tcBorders";

        /// <summary>
        /// Represents the w:tcFitText XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCellFitText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tcFitText = w + "tcFitText";

        /// <summary>
        /// Represents the w:tcMar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bottom" />, <see cref="end" />, <see cref="left" />, <see cref="right" />, <see cref="start" />, <see cref="top" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCellMargin.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tcMar = w + "tcMar";

        /// <summary>
        /// Represents the w:tcPr XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />, <see cref="tblStylePr" />, <see cref="tc" />, <see cref="tcPrChange" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cellDel" />, <see cref="cellIns" />, <see cref="cellMerge" />, <see cref="cnfStyle" />, <see cref="gridSpan" />, <see cref="hideMark" />, <see cref="hMerge" />, <see cref="noWrap" />, <see cref="shd" />, <see cref="tcBorders" />, <see cref="tcFitText" />, <see cref="tcMar" />, <see cref="tcPrChange" />, <see cref="tcW" />, <see cref="textDirection" />, <see cref="vAlign" />, <see cref="vMerge" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreviousTableCellProperties, StyleTableCellProperties, TableCellProperties, TableStyleConditionalFormattingTableCellProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tcPr = w + "tcPr";

        /// <summary>
        /// Represents the w:tcPrChange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCellPropertiesChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tcPrChange = w + "tcPrChange";

        /// <summary>
        /// Represents the w:tcW XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCellWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tcW = w + "tcW";

        /// <summary>
        /// Represents the w:temporary XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TemporarySdt.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName temporary = w + "temporary";

        /// <summary>
        /// Represents the w:tentative XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lvl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Level.Tentative.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tentative = w + "tentative";

        /// <summary>
        /// Represents the w:text XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sdtPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="multiLine" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SdtContentText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName text = w + "text";

        /// <summary>
        /// Represents the w:textAlignment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textAlignment = w + "textAlignment";

        /// <summary>
        /// Represents the w:textboxTightWrap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBoxTightWrap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textboxTightWrap = w + "textboxTightWrap";

        /// <summary>
        /// Represents the w:textDirection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />, <see cref="sectPr" />, <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextDirection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textDirection = w + "textDirection";

        /// <summary>
        /// Represents the w:textInput XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ffData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="@default" />, <see cref="format" />, <see cref="maxLength" />, <see cref="type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextInput.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textInput = w + "textInput";

        /// <summary>
        /// Represents the w:tgtFrame XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="hyperlink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Hyperlink.TargetFrame, HyperlinkRuby.TargetFrame.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tgtFrame = w + "tgtFrame";

        /// <summary>
        /// Represents the w:themeColor XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="background" />, <see cref="bar" />, <see cref="bdr" />, <see cref="between" />, <see cref="bottom" />, <see cref="color" />, <see cref="end" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="left" />, <see cref="right" />, <see cref="shd" />, <see cref="start" />, <see cref="tl2br" />, <see cref="top" />, <see cref="tr2bl" />, <see cref="u" />, <see cref="W15.color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BarBorder.ThemeColor, BetweenBorder.ThemeColor, Border.ThemeColor, BottomBorder.ThemeColor, Color.ThemeColor, DocumentBackground.ThemeColor, EndBorder.ThemeColor, InsideHorizontalBorder.ThemeColor, InsideVerticalBorder.ThemeColor, LeftBorder.ThemeColor, RightBorder.ThemeColor, Shading.ThemeColor, StartBorder.ThemeColor, TopBorder.ThemeColor, TopLeftToBottomRightCellBorder.ThemeColor, TopRightToBottomLeftCellBorder.ThemeColor, Underline.ThemeColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName themeColor = w + "themeColor";

        /// <summary>
        /// Represents the w:themeFill XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="shd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Shading.ThemeFill.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName themeFill = w + "themeFill";

        /// <summary>
        /// Represents the w:themeFillShade XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="shd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Shading.ThemeFillShade.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName themeFillShade = w + "themeFillShade";

        /// <summary>
        /// Represents the w:themeFillTint XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="shd" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Shading.ThemeFillTint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName themeFillTint = w + "themeFillTint";

        /// <summary>
        /// Represents the w:themeFontLang XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="bidi" />, <see cref="eastAsia" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ThemeFontLanguages.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName themeFontLang = w + "themeFontLang";

        /// <summary>
        /// Represents the w:themeShade XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="background" />, <see cref="bar" />, <see cref="bdr" />, <see cref="between" />, <see cref="bottom" />, <see cref="color" />, <see cref="end" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="left" />, <see cref="right" />, <see cref="shd" />, <see cref="start" />, <see cref="tl2br" />, <see cref="top" />, <see cref="tr2bl" />, <see cref="u" />, <see cref="W15.color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BarBorder.ThemeShade, BetweenBorder.ThemeShade, Border.ThemeShade, BottomBorder.ThemeShade, Color.ThemeShade, DocumentBackground.ThemeShade, EndBorder.ThemeShade, InsideHorizontalBorder.ThemeShade, InsideVerticalBorder.ThemeShade, LeftBorder.ThemeShade, RightBorder.ThemeShade, Shading.ThemeShade, StartBorder.ThemeShade, TopBorder.ThemeShade, TopLeftToBottomRightCellBorder.ThemeShade, TopRightToBottomLeftCellBorder.ThemeShade, Underline.ThemeShade.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName themeShade = w + "themeShade";

        /// <summary>
        /// Represents the w:themeTint XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="background" />, <see cref="bar" />, <see cref="bdr" />, <see cref="between" />, <see cref="bottom" />, <see cref="color" />, <see cref="end" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="left" />, <see cref="right" />, <see cref="shd" />, <see cref="start" />, <see cref="tl2br" />, <see cref="top" />, <see cref="tr2bl" />, <see cref="u" />, <see cref="W15.color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BarBorder.ThemeTint, BetweenBorder.ThemeTint, Border.ThemeTint, BottomBorder.ThemeTint, Color.ThemeTint, DocumentBackground.ThemeTint, EndBorder.ThemeTint, InsideHorizontalBorder.ThemeTint, InsideVerticalBorder.ThemeTint, LeftBorder.ThemeTint, RightBorder.ThemeTint, Shading.ThemeTint, StartBorder.ThemeTint, TopBorder.ThemeTint, TopLeftToBottomRightCellBorder.ThemeTint, TopRightToBottomLeftCellBorder.ThemeTint, Underline.ThemeTint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName themeTint = w + "themeTint";

        /// <summary>
        /// Represents the w:titlePg XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TitlePage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName titlePg = w + "titlePg";

        /// <summary>
        /// Represents the w:tl2br XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcBorders" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopLeftToBottomRightCellBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tl2br = w + "tl2br";

        /// <summary>
        /// Represents the w:tmpl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="abstractNum" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TemplateCode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tmpl = w + "tmpl";

        /// <summary>
        /// Represents the w:tooltip XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="hyperlink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Hyperlink.Tooltip, HyperlinkRuby.Tooltip.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tooltip = w + "tooltip";

        /// <summary>
        /// Represents the w:top XML elements and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="divBdr" />, <see cref="pBdr" />, <see cref="pgBorders" />, <see cref="tblBorders" />, <see cref="tblCellMar" />, <see cref="tcBorders" />, <see cref="tcMar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="type" />, <see cref="val" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopBorder, TopMargin.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgMar" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageMargin.Top.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName top = w + "top";

        /// <summary>
        /// Represents the w:top3HeadingStyles XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.Top3HeadingStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName top3HeadingStyles = w + "top3HeadingStyles";

        /// <summary>
        /// Represents the w:topFromText XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TablePositionProperties.TopFromText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName topFromText = w + "topFromText";

        /// <summary>
        /// Represents the w:topLinePunct XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopLinePunctuation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName topLinePunct = w + "topLinePunct";

        /// <summary>
        /// Represents the w:tplc XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lvl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Level.TemplateCode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tplc = w + "tplc";

        /// <summary>
        /// Represents the w:tr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customXml" />, <see cref="sdtContent" />, <see cref="tbl" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="tblPrEx" />, <see cref="tc" />, <see cref="trPr" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="rsidDel" />, <see cref="rsidR" />, <see cref="rsidRPr" />, <see cref="rsidTr" />, <see cref="W14.paraId" />, <see cref="W14.textId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableRow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tr = w + "tr";

        /// <summary>
        /// Represents the w:tr2bl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcBorders" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="frame" />, <see cref="shadow" />, <see cref="space" />, <see cref="sz" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopRightToBottomLeftCellBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tr2bl = w + "tr2bl";

        /// <summary>
        /// Represents the w:trackRevisions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TrackRevisions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trackRevisions = w + "trackRevisions";

        /// <summary>
        /// Represents the w:trHeight XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="hRule" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableRowHeight.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trHeight = w + "trHeight";

        /// <summary>
        /// Represents the w:trPr XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />, <see cref="tblStylePr" />, <see cref="tr" />, <see cref="trPrChange" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cantSplit" />, <see cref="cnfStyle" />, <see cref="del" />, <see cref="divId" />, <see cref="gridAfter" />, <see cref="gridBefore" />, <see cref="hidden" />, <see cref="ins" />, <see cref="jc" />, <see cref="tblCellSpacing" />, <see cref="tblHeader" />, <see cref="trHeight" />, <see cref="trPrChange" />, <see cref="wAfter" />, <see cref="wBefore" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PreviousTableRowProperties, TableRowProperties, TableStyleConditionalFormattingTableRowProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trPr = w + "trPr";

        /// <summary>
        /// Represents the w:trPrChange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="author" />, <see cref="date" />, <see cref="id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableRowPropertiesChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trPrChange = w + "trPrChange";

        /// <summary>
        /// Represents the w:truncateFontHeightsLikeWP6 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TruncateFontHeightsLikeWordPerfect.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName truncateFontHeightsLikeWP6 = w + "truncateFontHeightsLikeWP6";

        /// <summary>
        /// Represents the w:txbxContent XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.textbox" />, <see cref="WPS.txbx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="altChunk" />, <see cref="bookmarkEnd" />, <see cref="bookmarkStart" />, <see cref="commentRangeEnd" />, <see cref="commentRangeStart" />, <see cref="contentPart" />, <see cref="customXml" />, <see cref="customXmlDelRangeEnd" />, <see cref="customXmlDelRangeStart" />, <see cref="customXmlInsRangeEnd" />, <see cref="customXmlInsRangeStart" />, <see cref="customXmlMoveFromRangeEnd" />, <see cref="customXmlMoveFromRangeStart" />, <see cref="customXmlMoveToRangeEnd" />, <see cref="customXmlMoveToRangeStart" />, <see cref="del" />, <see cref="ins" />, <see cref="moveFrom" />, <see cref="moveFromRangeEnd" />, <see cref="moveFromRangeStart" />, <see cref="moveTo" />, <see cref="moveToRangeEnd" />, <see cref="moveToRangeStart" />, <see cref="p" />, <see cref="permEnd" />, <see cref="permStart" />, <see cref="proofErr" />, <see cref="sdt" />, <see cref="tbl" />, <see cref="W14.conflictDel" />, <see cref="W14.conflictIns" />, <see cref="W14.customXmlConflictDelRangeEnd" />, <see cref="W14.customXmlConflictDelRangeStart" />, <see cref="W14.customXmlConflictInsRangeEnd" />, <see cref="W14.customXmlConflictInsRangeStart" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextBoxContent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName txbxContent = w + "txbxContent";

        /// <summary>
        /// Represents the w:type XML elements and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fieldMapData" />, <see cref="odso" />, <see cref="sectPr" />, <see cref="textInput" />, <see cref="types" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocPartType, MailMergeFieldType, MailMergeSource, SectionType, TextBoxFormFieldType.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bottom" />, <see cref="br" />, <see cref="docGrid" />, <see cref="end" />, <see cref="endnote" />, <see cref="footerReference" />, <see cref="footnote" />, <see cref="headerReference" />, <see cref="helpText" />, <see cref="left" />, <see cref="proofErr" />, <see cref="right" />, <see cref="start" />, <see cref="statusText" />, <see cref="style" />, <see cref="tblCellSpacing" />, <see cref="tblInd" />, <see cref="tblLayout" />, <see cref="tblStylePr" />, <see cref="tblW" />, <see cref="tcW" />, <see cref="top" />, <see cref="wAfter" />, <see cref="wBefore" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BottomMargin.Type, Break.Type, DocGrid.Type, EndMargin.Type, Endnote.Type, FooterReference.Type, Footnote.Type, HeaderReference.Type, HelpText.Type, LeftMargin.Type, ProofError.Type, RightMargin.Type, StartMargin.Type, StatusText.Type, Style.Type, TableCellLeftMargin.Type, TableCellRightMargin.Type, TableCellSpacing.Type, TableCellWidth.Type, TableIndentation.Type, TableLayout.Type, TableStyleProperties.Type, TableWidth.Type, TopMargin.Type, WidthAfterTableRow.Type, WidthBeforeTableRow.Type.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName type = w + "type";

        /// <summary>
        /// Represents the w:types XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="docPartPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="type" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="all" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocPartTypes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName types = w + "types";

        /// <summary>
        /// Represents the w:u XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="color" />, <see cref="themeColor" />, <see cref="themeShade" />, <see cref="themeTint" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Underline.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName u = w + "u";

        /// <summary>
        /// Represents the w:udl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="odso" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UdlConnectionString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName udl = w + "udl";

        /// <summary>
        /// Represents the w:uiCompat97To2003 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UICompatibleWith97To2003.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uiCompat97To2003 = w + "uiCompat97To2003";

        /// <summary>
        /// Represents the w:uiPriority XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UIPriority.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lsdException" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyleExceptionInfo.UiPriority.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uiPriority = w + "uiPriority";

        /// <summary>
        /// Represents the w:ulTrailSpace XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UnderlineTrailingSpaces.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ulTrailSpace = w + "ulTrailSpace";

        /// <summary>
        /// Represents the w:underlineTabInNumList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UnderlineTabInNumberingList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName underlineTabInNumList = w + "underlineTabInNumList";

        /// <summary>
        /// Represents the w:unhideWhenUsed XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="style" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UnhideWhenUsed.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="lsdException" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: LatentStyleExceptionInfo.UnhideWhenUsed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName unhideWhenUsed = w + "unhideWhenUsed";

        /// <summary>
        /// Represents the w:uniqueTag XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="recipientData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UniqueTag.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uniqueTag = w + "uniqueTag";

        /// <summary>
        /// Represents the w:updateFields XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UpdateFieldsOnOpen.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName updateFields = w + "updateFields";

        /// <summary>
        /// Represents the w:updateMode XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="objectLink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ObjectLink.UpdateMode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName updateMode = w + "updateMode";

        /// <summary>
        /// Represents the w:uri XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="attr" />, <see cref="compatSetting" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CompatibilitySetting.Uri, CustomXmlAttribute.Uri.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uri = w + "uri";

        /// <summary>
        /// Represents the w:usb0 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="sig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FontSignature.UnicodeSignature0.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName usb0 = w + "usb0";

        /// <summary>
        /// Represents the w:usb1 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="sig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FontSignature.UnicodeSignature1.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName usb1 = w + "usb1";

        /// <summary>
        /// Represents the w:usb2 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="sig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FontSignature.UnicodeSignature2.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName usb2 = w + "usb2";

        /// <summary>
        /// Represents the w:usb3 XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="sig" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FontSignature.UnicodeSignature3.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName usb3 = w + "usb3";

        /// <summary>
        /// Represents the w:useAltKinsokuLineBreakRules XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UseAltKinsokuLineBreakRules.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName useAltKinsokuLineBreakRules = w + "useAltKinsokuLineBreakRules";

        /// <summary>
        /// Represents the w:useAnsiKerningPairs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UseAnsiKerningPairs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName useAnsiKerningPairs = w + "useAnsiKerningPairs";

        /// <summary>
        /// Represents the w:useFELayout XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UseFarEastLayout.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName useFELayout = w + "useFELayout";

        /// <summary>
        /// Represents the w:useNormalStyleForList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UseNormalStyleForList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName useNormalStyleForList = w + "useNormalStyleForList";

        /// <summary>
        /// Represents the w:usePrinterMetrics XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UsePrinterMetrics.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName usePrinterMetrics = w + "usePrinterMetrics";

        /// <summary>
        /// Represents the w:useSingleBorderforContiguousCells XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UseSingleBorderForContiguousCells.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName useSingleBorderforContiguousCells = w + "useSingleBorderforContiguousCells";

        /// <summary>
        /// Represents the w:useWord2002TableStyleRules XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UseWord2002TableStyleRules.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName useWord2002TableStyleRules = w + "useWord2002TableStyleRules";

        /// <summary>
        /// Represents the w:useWord97LineBreakRules XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UseWord97LineBreakRules.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName useWord97LineBreakRules = w + "useWord97LineBreakRules";

        /// <summary>
        /// Represents the w:useXSLTWhenSaving XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UseXsltWhenSaving.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName useXSLTWhenSaving = w + "useXSLTWhenSaving";

        /// <summary>
        /// Represents the w:val XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="abstractNumId" />, <see cref="active" />, <see cref="activeRecord" />, <see cref="addressFieldName" />, <see cref="adjustLineHeightInTable" />, <see cref="adjustRightInd" />, <see cref="alias" />, <see cref="aliases" />, <see cref="alignBordersAndEdges" />, <see cref="alignTablesRowByRow" />, <see cref="allowPNG" />, <see cref="allowSpaceOfSameStyleInTable" />, <see cref="altName" />, <see cref="alwaysMergeEmptyNamespace" />, <see cref="alwaysShowPlaceholderText" />, <see cref="applyBreakingRules" />, <see cref="attachedSchema" />, <see cref="attr" />, <see cref="autofitToFirstFixedWidthCell" />, <see cref="autoFormatOverride" />, <see cref="autoHyphenation" />, <see cref="autoRedefine" />, <see cref="autoSpaceDE" />, <see cref="autoSpaceDN" />, <see cref="autoSpaceLikeWord95" />, <see cref="b" />, <see cref="balanceSingleByteDoubleByteWidth" />, <see cref="bar" />, <see cref="basedOn" />, <see cref="bCs" />, <see cref="bdo" />, <see cref="bdr" />, <see cref="behavior" />, <see cref="between" />, <see cref="bidi" />, <see cref="bidiVisual" />, <see cref="blockQuote" />, <see cref="bodyDiv" />, <see cref="bookFoldPrinting" />, <see cref="bookFoldPrintingSheets" />, <see cref="bookFoldRevPrinting" />, <see cref="bordersDoNotSurroundFooter" />, <see cref="bordersDoNotSurroundHeader" />, <see cref="bottom" />, <see cref="cachedColBalance" />, <see cref="calcOnExit" />, <see cref="calendar" />, <see cref="cantSplit" />, <see cref="caps" />, <see cref="characterSpacingControl" />, <see cref="charset" />, <see cref="@checked" />, <see cref="checkErrors" />, <see cref="clickAndTypeStyle" />, <see cref="cnfStyle" />, <see cref="colDelim" />, <see cref="color" />, <see cref="column" />, <see cref="compatSetting" />, <see cref="connectString" />, <see cref="consecutiveHyphenLimit" />, <see cref="contextualSpacing" />, <see cref="convMailMergeEsc" />, <see cref="cs" />, <see cref="dataType" />, <see cref="dateFormat" />, <see cref="decimalSymbol" />, <see cref="@default" />, <see cref="defaultTableStyle" />, <see cref="defaultTabStop" />, <see cref="description" />, <see cref="destination" />, <see cref="dir" />, <see cref="dirty" />, <see cref="displayBackgroundShape" />, <see cref="displayHangulFixedWidth" />, <see cref="displayHorizontalDrawingGridEvery" />, <see cref="displayVerticalDrawingGridEvery" />, <see cref="divId" />, <see cref="docPart" />, <see cref="docPartCategory" />, <see cref="docPartGallery" />, <see cref="docPartUnique" />, <see cref="documentType" />, <see cref="docVar" />, <see cref="doNotAutoCompressPictures" />, <see cref="doNotAutofitConstrainedTables" />, <see cref="doNotBreakConstrainedForcedTable" />, <see cref="doNotBreakWrappedTables" />, <see cref="doNotDemarcateInvalidXml" />, <see cref="doNotDisplayPageBoundaries" />, <see cref="doNotExpandShiftReturn" />, <see cref="doNotHyphenateCaps" />, <see cref="doNotIncludeSubdocsInStats" />, <see cref="doNotLeaveBackslashAlone" />, <see cref="doNotOrganizeInFolder" />, <see cref="doNotRelyOnCSS" />, <see cref="doNotSaveAsSingleFile" />, <see cref="doNotShadeFormData" />, <see cref="doNotSnapToGridInCell" />, <see cref="doNotSuppressBlankLines" />, <see cref="doNotSuppressIndentation" />, <see cref="doNotSuppressParagraphBorders" />, <see cref="doNotTrackFormatting" />, <see cref="doNotTrackMoves" />, <see cref="doNotUseEastAsianBreakRules" />, <see cref="doNotUseHTMLParagraphAutoSpacing" />, <see cref="doNotUseIndentAsNumberingTabStop" />, <see cref="doNotUseLongFileNames" />, <see cref="doNotUseMarginsForDrawingGridOrigin" />, <see cref="doNotValidateAgainstSchema" />, <see cref="doNotVertAlignCellWithSp" />, <see cref="doNotVertAlignInTxbx" />, <see cref="doNotWrapTextWithPunct" />, <see cref="drawingGridHorizontalOrigin" />, <see cref="drawingGridHorizontalSpacing" />, <see cref="drawingGridVerticalOrigin" />, <see cref="drawingGridVerticalSpacing" />, <see cref="dstrike" />, <see cref="dynamicAddress" />, <see cref="effect" />, <see cref="em" />, <see cref="embedSystemFonts" />, <see cref="embedTrueTypeFonts" />, <see cref="emboss" />, <see cref="enabled" />, <see cref="encoding" />, <see cref="end" />, <see cref="entryMacro" />, <see cref="evenAndOddHeaders" />, <see cref="exitMacro" />, <see cref="family" />, <see cref="fHdr" />, <see cref="fitText" />, <see cref="flatBorders" />, <see cref="footnoteLayoutLikeWW8" />, <see cref="forgetLastTabAlignment" />, <see cref="format" />, <see cref="formProt" />, <see cref="formsDesign" />, <see cref="frameLayout" />, <see cref="gallery" />, <see cref="gridAfter" />, <see cref="gridBefore" />, <see cref="gridSpan" />, <see cref="growAutofit" />, <see cref="guid" />, <see cref="gutterAtTop" />, <see cref="helpText" />, <see cref="hidden" />, <see cref="hideGrammaticalErrors" />, <see cref="hideMark" />, <see cref="hideSpellingErrors" />, <see cref="highlight" />, <see cref="hMerge" />, <see cref="hps" />, <see cref="hpsBaseText" />, <see cref="hpsRaise" />, <see cref="hyphenationZone" />, <see cref="i" />, <see cref="iCs" />, <see cref="id" />, <see cref="ignoreMixedContent" />, <see cref="ilvl" />, <see cref="imprint" />, <see cref="insideH" />, <see cref="insideV" />, <see cref="isLgl" />, <see cref="jc" />, <see cref="keepLines" />, <see cref="keepNext" />, <see cref="kern" />, <see cref="kinsoku" />, <see cref="lang" />, <see cref="layoutRawTableWidth" />, <see cref="layoutTableRowsApart" />, <see cref="left" />, <see cref="lid" />, <see cref="lineWrapLikeWord6" />, <see cref="link" />, <see cref="linkedToFile" />, <see cref="linkStyles" />, <see cref="linkToQuery" />, <see cref="listEntry" />, <see cref="listSeparator" />, <see cref="@lock" />, <see cref="locked" />, <see cref="lvlJc" />, <see cref="lvlPicBulletId" />, <see cref="lvlRestart" />, <see cref="lvlText" />, <see cref="mailAsAttachment" />, <see cref="mailSubject" />, <see cref="mainDocumentType" />, <see cref="mappedName" />, <see cref="marBottom" />, <see cref="marH" />, <see cref="marLeft" />, <see cref="marRight" />, <see cref="marTop" />, <see cref="marW" />, <see cref="matchSrc" />, <see cref="maxLength" />, <see cref="mirrorIndents" />, <see cref="mirrorMargins" />, <see cref="multiLevelType" />, <see cref="mwSmallCaps" />, <see cref="name" />, <see cref="next" />, <see cref="noBorder" />, <see cref="noColumnBalance" />, <see cref="noEndnote" />, <see cref="noExtraLineSpacing" />, <see cref="noLeading" />, <see cref="noLineBreaksAfter" />, <see cref="noLineBreaksBefore" />, <see cref="noProof" />, <see cref="noPunctuationKerning" />, <see cref="noResizeAllowed" />, <see cref="noSpaceRaiseLower" />, <see cref="noTabHangInd" />, <see cref="notTrueType" />, <see cref="noWrap" />, <see cref="nsid" />, <see cref="numFmt" />, <see cref="numId" />, <see cref="numIdMacAtCleanup" />, <see cref="numRestart" />, <see cref="numStart" />, <see cref="numStyleLink" />, <see cref="oMath" />, <see cref="optimizeForBrowser" />, <see cref="outline" />, <see cref="outlineLvl" />, <see cref="overflowPunct" />, <see cref="pageBreakBefore" />, <see cref="panose1" />, <see cref="personal" />, <see cref="personalCompose" />, <see cref="personalReply" />, <see cref="pitch" />, <see cref="pixelsPerInch" />, <see cref="placeholder" />, <see cref="pos" />, <see cref="position" />, <see cref="printBodyTextBeforeHeader" />, <see cref="printColBlack" />, <see cref="printFormsData" />, <see cref="printFractionalCharacterWidth" />, <see cref="printPostScriptOverText" />, <see cref="printTwoOnOne" />, <see cref="pStyle" />, <see cref="qFormat" />, <see cref="query" />, <see cref="relyOnVML" />, <see cref="removeDateAndTime" />, <see cref="removePersonalInformation" />, <see cref="result" />, <see cref="right" />, <see cref="rsid" />, <see cref="rsidRoot" />, <see cref="rStyle" />, <see cref="rtl" />, <see cref="rtlGutter" />, <see cref="rubyAlign" />, <see cref="saveFormsData" />, <see cref="saveInvalidXml" />, <see cref="savePreviewPicture" />, <see cref="saveSubsetFonts" />, <see cref="saveXmlDataOnly" />, <see cref="scrollbar" />, <see cref="selectFldWithFirstOrLastChar" />, <see cref="semiHidden" />, <see cref="shadow" />, <see cref="shapeLayoutLikeWW8" />, <see cref="shd" />, <see cref="showBreaksInFrames" />, <see cref="showEnvelope" />, <see cref="showingPlcHdr" />, <see cref="showXMLTags" />, <see cref="size" />, <see cref="sizeAuto" />, <see cref="smallCaps" />, <see cref="snapToGrid" />, <see cref="spaceForUL" />, <see cref="spacing" />, <see cref="spacingInWholePoints" />, <see cref="specVanish" />, <see cref="splitPgBreakAndParaMark" />, <see cref="start" />, <see cref="startOverride" />, <see cref="statusText" />, <see cref="storeMappedDataAs" />, <see cref="strictFirstAndLastChars" />, <see cref="strike" />, <see cref="style" />, <see cref="styleLink" />, <see cref="styleLockQFSet" />, <see cref="styleLockTheme" />, <see cref="stylePaneFormatFilter" />, <see cref="stylePaneSortMethod" />, <see cref="subFontBySize" />, <see cref="suff" />, <see cref="summaryLength" />, <see cref="suppressAutoHyphens" />, <see cref="suppressBottomSpacing" />, <see cref="suppressLineNumbers" />, <see cref="suppressOverlap" />, <see cref="suppressSpacingAtTopOfPage" />, <see cref="suppressSpBfAfterPgBrk" />, <see cref="suppressTopSpacing" />, <see cref="suppressTopSpacingWP" />, <see cref="swapBordersFacingPages" />, <see cref="sz" />, <see cref="szCs" />, <see cref="tab" />, <see cref="table" />, <see cref="tag" />, <see cref="targetScreenSz" />, <see cref="tblCaption" />, <see cref="tblDescription" />, <see cref="tblHeader" />, <see cref="tblLook" />, <see cref="tblOverlap" />, <see cref="tblStyle" />, <see cref="tblStyleColBandSize" />, <see cref="tblStyleRowBandSize" />, <see cref="tcFitText" />, <see cref="temporary" />, <see cref="textAlignment" />, <see cref="textboxTightWrap" />, <see cref="textDirection" />, <see cref="themeFontLang" />, <see cref="titlePg" />, <see cref="tl2br" />, <see cref="tmpl" />, <see cref="top" />, <see cref="topLinePunct" />, <see cref="tr2bl" />, <see cref="trackRevisions" />, <see cref="trHeight" />, <see cref="truncateFontHeightsLikeWP6" />, <see cref="type" />, <see cref="u" />, <see cref="udl" />, <see cref="uiCompat97To2003" />, <see cref="uiPriority" />, <see cref="ulTrailSpace" />, <see cref="underlineTabInNumList" />, <see cref="unhideWhenUsed" />, <see cref="uniqueTag" />, <see cref="updateFields" />, <see cref="useAltKinsokuLineBreakRules" />, <see cref="useAnsiKerningPairs" />, <see cref="useFELayout" />, <see cref="useNormalStyleForList" />, <see cref="usePrinterMetrics" />, <see cref="useSingleBorderforContiguousCells" />, <see cref="useWord2002TableStyleRules" />, <see cref="useWord97LineBreakRules" />, <see cref="useXSLTWhenSaving" />, <see cref="vAlign" />, <see cref="vanish" />, <see cref="vertAlign" />, <see cref="view" />, <see cref="viewMergedData" />, <see cref="vMerge" />, <see cref="w_" />, <see cref="webHidden" />, <see cref="widowControl" />, <see cref="wordWrap" />, <see cref="wpJustification" />, <see cref="wpSpaceWidth" />, <see cref="wrapTrailSpaces" />, <see cref="zoom" />, <see cref="W15.chartTrackingRefBased" />, <see cref="W15.collapsed" />, <see cref="W15.color" />, <see cref="W15.doNotAllowInsertDeleteSection" />, <see cref="W15.footnoteColumns" />, <see cref="W15.sectionTitle" />, <see cref="W15.webExtensionCreated" />, <see cref="W15.webExtensionLinked" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: AbstractNumDefinitionName.Val, AbstractNumId.Val, Active.Val, ActiveRecord.Val, AddressFieldName.Val, AdjustLineHeightInTable.Val, AdjustRightIndent.Val, Aliases.Val, AlignBorderAndEdges.Val, AlignTablesRowByRow.Val, AllowPNG.Val, AllowSpaceOfSameStyleInTable.Val, AltName.Val, AlwaysMergeEmptyNamespace.Val, AlwaysShowPlaceholderText.Val, ApplyBreakingRules.Val, AttachedSchema.Val, AutofitToFirstFixedWidthCell.Val, AutoFormatOverride.Val, AutoHyphenation.Val, AutomaticallySizeFormField.Val, AutoRedefine.Val, AutoSpaceDE.Val, AutoSpaceDN.Val, AutoSpaceLikeWord95.Val, BalanceSingleByteDoubleByteWidth.Val, BarBorder.Val, BasedOn.Val, Behavior.Val, BetweenBorder.Val, BiDi.Val, BidirectionalEmbedding.Val, BidirectionalOverride.Val, BiDiVisual.Val, BlockQuote.Val, BodyDiv.Val, Bold.Val, BoldComplexScript.Val, BookFoldPrinting.Val, BookFoldPrintingSheets.Val, BookFoldReversePrinting.Val, Border.Val, BordersDoNotSurroundFooter.Val, BordersDoNotSurroundHeader.Val, BottomBorder.Val, BottomMarginDiv.Val, CachedColumnBalance.Val, CalculateOnExit.Val, Calendar.Val, CantSplit.Val, Caps.Val, CharacterScale.Val, CharacterSpacingControl.Val, ChartTrackingRefBased.Val, Checked.Val, CheckErrors.Val, ClickAndTypeStyle.Val, Color.Val, ColumnDelimiter.Val, ColumnIndex.Val, CompatibilitySetting.Val, ComplexScript.Val, ConditionalFormatStyle.Val, ConnectString.Val, ConsecutiveHyphenLimit.Val, ContextualSpacing.Val, ConvertMailMergeEscape.Val, CustomXmlAttribute.Val, CustomXmlPlaceholder.Val, DataSourceTableName.Val, DataType.Val, DateFormat.Val, DecimalSymbol.Val, DefaultCheckBoxFormFieldState.Val, DefaultCollapsed.Val, DefaultDropDownListItemIndex.Val, DefaultTableStyle.Val, DefaultTabStop.Val, DefaultTextBoxFormFieldString.Val, Description.Val, Destination.Val, Dirty.Val, DisplayBackgroundShape.Val, DisplayHangulFixedWidth.Val, DisplayHorizontalDrawingGrid.Val, DisplayVerticalDrawingGrid.Val, DivId.Val, DocPartCategory.Val, DocPartGallery.Val, DocPartId.Val, DocPartName.Val, DocPartReference.Val, DocPartType.Val, DocPartUnique.Val, DocumentType.Val, DocumentVariable.Val, DoNotAllowInsertDeleteSection.Val, DoNotAutoCompressPictures.Val, DoNotAutofitConstrainedTables.Val, DoNotBreakConstrainedForcedTable.Val, DoNotBreakWrappedTables.Val, DoNotDemarcateInvalidXml.Val, DoNotDisplayPageBoundaries.Val, DoNotExpandShiftReturn.Val, DoNotHyphenateCaps.Val, DoNotIncludeSubdocsInStats.Val, DoNotLeaveBackslashAlone.Val, DoNotOrganizeInFolder.Val, DoNotRelyOnCSS.Val, DoNotSaveAsSingleFile.Val, DoNotShadeFormData.Val, DoNotSnapToGridInCell.Val, DoNotSuppressBlankLines.Val, DoNotSuppressIndentation.Val, DoNotSuppressParagraphBorders.Val, DoNotTrackFormatting.Val, DoNotTrackMoves.Val, DoNotUseEastAsianBreakRules.Val, DoNotUseHTMLParagraphAutoSpacing.Val, DoNotUseIndentAsNumberingTabStop.Val, DoNotUseLongFileNames.Val, DoNotUseMarginsForDrawingGridOrigin.Val, DoNotValidateAgainstSchema.Val, DoNotVerticallyAlignCellWithShape.Val, DoNotVerticallyAlignInTextBox.Val, DoNotWrapTextWithPunctuation.Val, DoubleStrike.Val, DrawingGridHorizontalOrigin.Val, DrawingGridHorizontalSpacing.Val, DrawingGridVerticalOrigin.Val, DrawingGridVerticalSpacing.Val, DropDownListSelection.Val, DynamicAddress.Val, EmbedSystemFonts.Val, EmbedTrueTypeFonts.Val, Emboss.Val, Emphasis.Val, Enabled.Val, EndBorder.Val, EndnotePosition.Val, EntryMacro.Val, EvenAndOddHeaders.Val, ExitMacro.Val, FirstRowHeader.Val, FitText.Val, FlatBorders.Val, FontCharSet.Val, FontFamily.Val, FontSize.Val, FontSizeComplexScript.Val, FootnoteColumns.Val, FootnoteLayoutLikeWord8.Val, FootnotePosition.Val, ForgetLastTabAlignment.Val, Format.Val, FormFieldName.Val, FormFieldSize.Val, FormProtection.Val, FormsDesign.Val, FrameLayout.Val, FrameName.Val, FrameSize.Val, Gallery.Val, GridAfter.Val, GridBefore.Val, GridSpan.Val, GrowAutofit.Val, GutterAtTop.Val, GutterOnRight.Val, HelpText.Val, Hidden.Val, HideGrammaticalErrors.Val, HideMark.Val, HideSpellingErrors.Val, Highlight.Val, HorizontalMerge.Val, HyphenationZone.Val, IgnoreMixedContent.Val, Imprint.Val, InsideHorizontalBorder.Val, InsideVerticalBorder.Val, IsLegalNumberingStyle.Val, Italic.Val, ItalicComplexScript.Val, Justification.Val, KeepLines.Val, KeepNext.Val, Kern.Val, Kinsoku.Val, LanguageId.Val, Languages.Val, LayoutRawTableWidth.Val, LayoutTableRowsApart.Val, LeftBorder.Val, LeftMarginDiv.Val, LevelJustification.Val, LevelPictureBulletId.Val, LevelRestart.Val, LevelSuffix.Val, LevelText.Val, LineWrapLikeWord6.Val, LinkedStyle.Val, LinkedToFile.Val, LinkStyles.Val, LinkToQuery.Val, ListEntryFormField.Val, ListSeparator.Val, Lock.Val, Locked.Val, MacWordSmallCaps.Val, MailAsAttachment.Val, MailMergeFieldType.Val, MailMergeSource.Val, MailSubject.Val, MainDocumentType.Val, MappedName.Val, MarginHeight.Val, MarginWidth.Val, MatchSource.Val, MaxLength.Val, MirrorIndents.Val, MirrorMargins.Val, MultiLevelType.Val, Name.Val, NextParagraphStyle.Val, NoBorder.Val, NoColumnBalance.Val, NoEndnote.Val, NoExtraLineSpacing.Val, NoLeading.Val, NoLineBreaksAfterKinsoku.Val, NoLineBreaksBeforeKinsoku.Val, NoProof.Val, NoPunctuationKerning.Val, NoResizeAllowed.Val, NoSpaceRaiseLower.Val, NoTabHangIndent.Val, NotTrueType.Val, NoWrap.Val, Nsid.Val, NumberingFormat.Val, NumberingId.Val, NumberingIdMacAtCleanup.Val, NumberingLevelReference.Val, NumberingRestart.Val, NumberingStart.Val, NumberingStyleLink.Val, OfficeMath.Val, OptimizeForBrowser.Val, Outline.Val, OutlineLevel.Val, OverflowPunctuation.Val, PageBreakBefore.Val, Panose1Number.Val, ParagraphStyleId.Val, ParagraphStyleIdInLevel.Val, Personal.Val, PersonalCompose.Val, PersonalReply.Val, PhoneticGuideBaseTextSize.Val, PhoneticGuideRaise.Val, PhoneticGuideTextFontSize.Val, Pitch.Val, PixelsPerInch.Val, Position.Val, PrimaryStyle.Val, PrintBodyTextBeforeHeader.Val, PrintColorBlackWhite.Val, PrintFormsData.Val, PrintFractionalCharacterWidth.Val, PrintPostScriptOverText.Val, PrintTwoOnOne.Val, Query.Val, RelyOnVML.Val, RemoveDateAndTime.Val, RemovePersonalInformation.Val, RightBorder.Val, RightMarginDiv.Val, RightToLeftText.Val, Rsid.Val, RsidRoot.Val, RubyAlign.Val, RunStyle.Val, SaveFormsData.Val, SaveInvalidXml.Val, SavePreviewPicture.Val, SaveSubsetFonts.Val, SaveXmlDataOnly.Val, ScrollbarVisibility.Val, SdtAlias.Val, SdtDateMappingType.Val, SdtId.Val, SectionTitle.Val, SectionType.Val, SelectFieldWithFirstOrLastChar.Val, SemiHidden.Val, Shading.Val, Shadow.Val, ShapeLayoutLikeWord8.Val, ShowBreaksInFrames.Val, ShowEnvelope.Val, ShowingPlaceholder.Val, ShowXmlTags.Val, SmallCaps.Val, SnapToGrid.Val, SpaceForUnderline.Val, Spacing.Val, SpacingInWholePoints.Val, SpecVanish.Val, SplitPageBreakAndParagraphMark.Val, StartBorder.Val, StartNumberingValue.Val, StartOverrideNumberingValue.Val, StatusText.Val, StrictFirstAndLastChars.Val, Strike.Val, StyleHidden.Val, StyleId.Val, StyleLink.Val, StyleLockStylesPart.Val, StyleLockThemesPart.Val, StyleName.Val, StylePaneFormatFilter.Val, StylePaneSortMethods.Val, SubFontBySize.Val, SummaryLength.Val, SuppressAutoHyphens.Val, SuppressBottomSpacing.Val, SuppressLineNumbers.Val, SuppressOverlap.Val, SuppressSpacingAtTopOfPage.Val, SuppressSpacingBeforeAfterPageBreak.Val, SuppressTopSpacing.Val, SuppressTopSpacingWordPerfect.Val, SwapBordersFacingPages.Val, TableCaption.Val, TableCellFitText.Val, TableCellVerticalAlignment.Val, TableDescription.Val, TableHeader.Val, TableJustification.Val, TableLook.Val, TableOverlap.Val, TableRowHeight.Val, TableStyle.Val, TableStyleColumnBandSize.Val, TableStyleRowBandSize.Val, TabStop.Val, Tag.Val, TargetScreenSize.Val, TemplateCode.Val, TemporarySdt.Val, TextAlignment.Val, TextBoxFormFieldType.Val, TextBoxTightWrap.Val, TextDirection.Val, TextEffect.Val, ThemeFontLanguages.Val, TitlePage.Val, TopBorder.Val, TopLeftToBottomRightCellBorder.Val, TopLinePunctuation.Val, TopMarginDiv.Val, TopRightToBottomLeftCellBorder.Val, TrackRevisions.Val, TruncateFontHeightsLikeWordPerfect.Val, UdlConnectionString.Val, UICompatibleWith97To2003.Val, UIPriority.Val, Underline.Val, UnderlineTabInNumberingList.Val, UnderlineTrailingSpaces.Val, UnhideWhenUsed.Val, UniqueTag.Val, UpdateFieldsOnOpen.Val, UseAltKinsokuLineBreakRules.Val, UseAnsiKerningPairs.Val, UseFarEastLayout.Val, UseNormalStyleForList.Val, UsePrinterMetrics.Val, UseSingleBorderForContiguousCells.Val, UseWord2002TableStyleRules.Val, UseWord97LineBreakRules.Val, UseXsltWhenSaving.Val, Vanish.Val, VerticalMerge.Val, VerticalTextAlignment.Val, VerticalTextAlignmentOnPage.Val, View.Val, ViewMergedData.Val, WebExtensionCreated.Val, WebExtensionLinked.Val, WebHidden.Val, WebPageEncoding.Val, WidowControl.Val, Width.Val, WordPerfectJustification.Val, WordPerfectSpaceWidth.Val, WordWrap.Val, WrapTrailSpaces.Val, Zoom.Val.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName val = w + "val";

        /// <summary>
        /// Represents the w:vAlign XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sectPr" />, <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableCellVerticalAlignment, VerticalTextAlignmentOnPage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vAlign = w + "vAlign";

        /// <summary>
        /// Represents the w:value XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="listItem" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ListItem.Value.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName value = w + "value";

        /// <summary>
        /// Represents the w:vAnchor XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.VerticalPosition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vAnchor = w + "vAnchor";

        /// <summary>
        /// Represents the w:vanish XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Vanish.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vanish = w + "vanish";

        /// <summary>
        /// Represents the w:vendorID XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="activeWritingStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: ActiveWritingStyle.VendorID.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vendorID = w + "vendorID";

        /// <summary>
        /// Represents the w:vert XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="eastAsianLayout" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EastAsianLayout.Vertical.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vert = w + "vert";

        /// <summary>
        /// Represents the w:vertAlign XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VerticalTextAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vertAlign = w + "vertAlign";

        /// <summary>
        /// Represents the w:vertAnchor XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="tblpPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: TablePositionProperties.VerticalAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vertAnchor = w + "vertAnchor";

        /// <summary>
        /// Represents the w:vertCompress XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="eastAsianLayout" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EastAsianLayout.VerticalCompress.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vertCompress = w + "vertCompress";

        /// <summary>
        /// Represents the w:view XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: View.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName view = w + "view";

        /// <summary>
        /// Represents the w:viewMergedData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mailMerge" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ViewMergedData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName viewMergedData = w + "viewMergedData";

        /// <summary>
        /// Represents the w:visibleStyles XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="stylePaneFormatFilter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: StylePaneFormatFilter.VisibleStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName visibleStyles = w + "visibleStyles";

        /// <summary>
        /// Represents the w:vMerge XML element and attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tcPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VerticalMerge.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cellMerge" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CellMerge.VerticalMerge.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vMerge = w + "vMerge";

        /// <summary>
        /// Represents the w:vMergeOrig XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="cellMerge" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CellMerge.VerticalMergeOriginal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vMergeOrig = w + "vMergeOrig";

        /// <summary>
        /// Represents the w:vSpace XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.VerticalSpace.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vSpace = w + "vSpace";

        /// <summary>
        /// Represents the w:w XML elements and attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="framesetSplitbar" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CharacterScale, Width.</description></item>
        /// </list>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="bottom" />, <see cref="col" />, <see cref="end" />, <see cref="framePr" />, <see cref="gridCol" />, <see cref="left" />, <see cref="pgSz" />, <see cref="readModeInkLockDown" />, <see cref="right" />, <see cref="start" />, <see cref="tblCellSpacing" />, <see cref="tblInd" />, <see cref="tblW" />, <see cref="tcW" />, <see cref="top" />, <see cref="wAfter" />, <see cref="wBefore" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: BottomMargin.Width, Column.Width, EndMargin.Width, FrameProperties.Width, GridColumn.Width, LeftMargin.Width, PageSize.Width, ReadModeInkLockDown.Width, RightMargin.Width, StartMargin.Width, TableCellLeftMargin.Width, TableCellRightMargin.Width, TableCellSpacing.Width, TableCellWidth.Width, TableIndentation.Width, TableWidth.Width, TopMargin.Width, WidthAfterTableRow.Width, WidthBeforeTableRow.Width.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName w_ = w + "w";

        /// <summary>
        /// Represents the w:wAfter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WidthAfterTableRow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wAfter = w + "wAfter";

        /// <summary>
        /// Represents the w:wBefore XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="trPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="type" />, <see cref="w_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WidthBeforeTableRow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wBefore = w + "wBefore";

        /// <summary>
        /// Represents the w:webHidden XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebHidden.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webHidden = w + "webHidden";

        /// <summary>
        /// Represents the w:webSettings XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="allowPNG" />, <see cref="divs" />, <see cref="doNotOrganizeInFolder" />, <see cref="doNotRelyOnCSS" />, <see cref="doNotSaveAsSingleFile" />, <see cref="doNotUseLongFileNames" />, <see cref="encoding" />, <see cref="frameset" />, <see cref="optimizeForBrowser" />, <see cref="pixelsPerInch" />, <see cref="relyOnVML" />, <see cref="targetScreenSz" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebSettings.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webSettings = w + "webSettings";

        /// <summary>
        /// Represents the w:widowControl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WidowControl.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName widowControl = w + "widowControl";

        /// <summary>
        /// Represents the w:wordWrap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WordWrap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wordWrap = w + "wordWrap";

        /// <summary>
        /// Represents the w:wpJustification XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WordPerfectJustification.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wpJustification = w + "wpJustification";

        /// <summary>
        /// Represents the w:wpSpaceWidth XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WordPerfectSpaceWidth.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wpSpaceWidth = w + "wpSpaceWidth";

        /// <summary>
        /// Represents the w:wrap XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.Wrap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrap = w + "wrap";

        /// <summary>
        /// Represents the w:wrapTrailSpaces XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="compat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WrapTrailSpaces.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName wrapTrailSpaces = w + "wrapTrailSpaces";

        /// <summary>
        /// Represents the w:writeProtection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="algIdExt" />, <see cref="algIdExtSource" />, <see cref="algorithmName" />, <see cref="cryptAlgorithmClass" />, <see cref="cryptAlgorithmSid" />, <see cref="cryptAlgorithmType" />, <see cref="cryptProvider" />, <see cref="cryptProviderType" />, <see cref="cryptProviderTypeExt" />, <see cref="cryptProviderTypeExtSource" />, <see cref="cryptSpinCount" />, <see cref="hash" />, <see cref="hashValue" />, <see cref="recommended" />, <see cref="salt" />, <see cref="saltValue" />, <see cref="spinCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WriteProtection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName writeProtection = w + "writeProtection";

        /// <summary>
        /// Represents the w:x XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.X.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName x = w + "x";

        /// <summary>
        /// Represents the w:xAlign XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.XAlign.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xAlign = w + "xAlign";

        /// <summary>
        /// Represents the w:xpath XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="dataBinding" />, <see cref="W15.dataBinding" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DataBinding.XPath.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xpath = w + "xpath";

        /// <summary>
        /// Represents the w:y XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.Y.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName y = w + "y";

        /// <summary>
        /// Represents the w:yAlign XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="framePr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: FrameProperties.YAlign.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName yAlign = w + "yAlign";

        /// <summary>
        /// Represents the w:yearLong XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: YearLong.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName yearLong = w + "yearLong";

        /// <summary>
        /// Represents the w:yearShort XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="M.r" />, <see cref="r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: YearShort.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName yearShort = w + "yearShort";

        /// <summary>
        /// Represents the w:zoom XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="settings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="percent" />, <see cref="val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Zoom.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName zoom = w + "zoom";

        /// <summary>
        /// Represents the w:zOrder XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="pgBorders" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: PageBorders.ZOrder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName zOrder = w + "zOrder";
    }
}
