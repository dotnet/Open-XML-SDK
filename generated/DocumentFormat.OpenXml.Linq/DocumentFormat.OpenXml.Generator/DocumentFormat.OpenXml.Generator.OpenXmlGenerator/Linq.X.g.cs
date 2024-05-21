// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:x="http://schemas.openxmlformats.org/spreadsheetml/2006/main" namespace.
    /// </summary>
    public static class X
    {
        /// <summary>
        /// Defines the XML namespace associated with the x prefix.
        /// </summary>
        public static readonly XNamespace x = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";

        /// <summary>
        /// Represents the x:alignment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dxf" />, <see cref="ndxf" />, <see cref="odxf" />, <see cref="xf" />, <see cref="X14.dxf" />, <see cref="XNSV.dxf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.horizontal" />, <see cref="NoNamespace.indent" />, <see cref="NoNamespace.justifyLastLine" />, <see cref="NoNamespace.mergeCell" />, <see cref="NoNamespace.readingOrder" />, <see cref="NoNamespace.relativeIndent" />, <see cref="NoNamespace.shrinkToFit" />, <see cref="NoNamespace.textRotation" />, <see cref="NoNamespace.vertical" />, <see cref="NoNamespace.wrapText" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Alignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alignment = x + "alignment";

        /// <summary>
        /// Represents the x:anchor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="commentPr" />, <see cref="controlPr" />, <see cref="objectPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="from" />, <see cref="to" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.moveWithCells" />, <see cref="NoNamespace.sizeWithCells" />, <see cref="NoNamespace.z_order" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ObjectAnchor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName anchor = x + "anchor";

        /// <summary>
        /// Represents the x:author XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="authors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Author.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName author = x + "author";

        /// <summary>
        /// Represents the x:authors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="comments" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="author" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Authors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName authors = x + "authors";

        /// <summary>
        /// Represents the x:autoFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customSheetView" />, <see cref="filter" />, <see cref="table" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="filterColumn" />, <see cref="sortState" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoFilter = x + "autoFilter";

        /// <summary>
        /// Represents the x:autoSortScope XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotField" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotArea" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AutoSortScope.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName autoSortScope = x + "autoSortScope";

        /// <summary>
        /// Represents the x:b XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="groupItems" />, <see cref="r" />, <see cref="rPr" />, <see cref="sharedItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="x_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.c" />, <see cref="NoNamespace.cp" />, <see cref="NoNamespace.f" />, <see cref="NoNamespace.u" />, <see cref="NoNamespace.v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Bold, BooleanItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName b = x + "b";

        /// <summary>
        /// Represents the x:bgColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="patternFill" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BackgroundColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bgColor = x + "bgColor";

        /// <summary>
        /// Represents the x:bk XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cellMetadata" />, <see cref="futureMetadata" />, <see cref="valueMetadata" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="rc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FutureMetadataBlock, MetadataBlock.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bk = x + "bk";

        /// <summary>
        /// Represents the x:bookViews XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="workbookView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BookViews.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bookViews = x + "bookViews";

        /// <summary>
        /// Represents the x:border XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="borders" />, <see cref="dxf" />, <see cref="ndxf" />, <see cref="odxf" />, <see cref="X14.dxf" />, <see cref="XNSV.dxf" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bottom" />, <see cref="diagonal" />, <see cref="end" />, <see cref="horizontal" />, <see cref="left" />, <see cref="right" />, <see cref="start" />, <see cref="top" />, <see cref="vertical" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.diagonalDown" />, <see cref="NoNamespace.diagonalUp" />, <see cref="NoNamespace.outline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Border.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName border = x + "border";

        /// <summary>
        /// Represents the x:borders XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="border" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Borders.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName borders = x + "borders";

        /// <summary>
        /// Represents the x:bottom XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="border" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BottomBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bottom = x + "bottom";

        /// <summary>
        /// Represents the x:brk XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colBreaks" />, <see cref="rowBreaks" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.man" />, <see cref="NoNamespace.max" />, <see cref="NoNamespace.min" />, <see cref="NoNamespace.pt" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Break.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName brk = x + "brk";

        /// <summary>
        /// Represents the x:c XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="calcChain" />, <see cref="row" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="f" />, <see cref="@is" />, <see cref="v" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.a" />, <see cref="NoNamespace.i" />, <see cref="NoNamespace.l" />, <see cref="NoNamespace.r" />, <see cref="NoNamespace.s" />, <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculationCell, Cell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName c = x + "c";

        /// <summary>
        /// Represents the x:cacheField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheFields" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="fieldGroup" />, <see cref="mpMap" />, <see cref="sharedItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.caption" />, <see cref="NoNamespace.databaseField" />, <see cref="NoNamespace.formula" />, <see cref="NoNamespace.hierarchy" />, <see cref="NoNamespace.level" />, <see cref="NoNamespace.mappingCount" />, <see cref="NoNamespace.memberPropertyField" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.numFmtId" />, <see cref="NoNamespace.propertyName" />, <see cref="NoNamespace.serverField" />, <see cref="NoNamespace.sqlType" />, <see cref="NoNamespace.uniqueList" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cacheField = x + "cacheField";

        /// <summary>
        /// Represents the x:cacheFields XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cacheField" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheFields.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cacheFields = x + "cacheFields";

        /// <summary>
        /// Represents the x:cacheHierarchies XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cacheHierarchy" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheHierarchies.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cacheHierarchies = x + "cacheHierarchies";

        /// <summary>
        /// Represents the x:cacheHierarchy XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheHierarchies" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="fieldsUsage" />, <see cref="groupLevels" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allCaption" />, <see cref="NoNamespace.allUniqueName" />, <see cref="NoNamespace.attribute" />, <see cref="NoNamespace.caption" />, <see cref="NoNamespace.count" />, <see cref="NoNamespace.defaultMemberUniqueName" />, <see cref="NoNamespace.dimensionUniqueName" />, <see cref="NoNamespace.displayFolder" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.iconSet" />, <see cref="NoNamespace.keyAttribute" />, <see cref="NoNamespace.measure" />, <see cref="NoNamespace.measureGroup" />, <see cref="NoNamespace.measures" />, <see cref="NoNamespace.memberValueDatatype" />, <see cref="NoNamespace.oneField" />, <see cref="NoNamespace.parentSet" />, <see cref="NoNamespace.set" />, <see cref="NoNamespace.time" />, <see cref="NoNamespace.unbalanced" />, <see cref="NoNamespace.unbalancedGroup" />, <see cref="NoNamespace.uniqueName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheHierarchy.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cacheHierarchy = x + "cacheHierarchy";

        /// <summary>
        /// Represents the x:cacheSource XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="consolidation" />, <see cref="extLst" />, <see cref="worksheetSource" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.connectionId" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheSource.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cacheSource = x + "cacheSource";

        /// <summary>
        /// Represents the x:calcChain XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="c" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculationChain.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calcChain = x + "calcChain";

        /// <summary>
        /// Represents the x:calcPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.calcCompleted" />, <see cref="NoNamespace.calcId" />, <see cref="NoNamespace.calcMode_" />, <see cref="NoNamespace.calcOnSave" />, <see cref="NoNamespace.concurrentCalc" />, <see cref="NoNamespace.concurrentManualCount" />, <see cref="NoNamespace.forceFullCalc" />, <see cref="NoNamespace.fullCalcOnLoad" />, <see cref="NoNamespace.fullPrecision" />, <see cref="NoNamespace.iterate" />, <see cref="NoNamespace.iterateCount" />, <see cref="NoNamespace.iterateDelta" />, <see cref="NoNamespace.refMode" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculationProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calcPr = x + "calcPr";

        /// <summary>
        /// Represents the x:calculatedColumnFormula XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tableColumn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculatedColumnFormula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calculatedColumnFormula = x + "calculatedColumnFormula";

        /// <summary>
        /// Represents the x:calculatedItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="calculatedItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pivotArea" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.field" />, <see cref="NoNamespace.formula" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculatedItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calculatedItem = x + "calculatedItem";

        /// <summary>
        /// Represents the x:calculatedItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="calculatedItem" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculatedItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calculatedItems = x + "calculatedItems";

        /// <summary>
        /// Represents the x:calculatedMember XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="calculatedMembers" />, <see cref="X14.calculatedMembers" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hierarchy" />, <see cref="NoNamespace.mdx" />, <see cref="NoNamespace.memberName" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.parent" />, <see cref="NoNamespace.set" />, <see cref="NoNamespace.solveOrder" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculatedMember.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calculatedMember = x + "calculatedMember";

        /// <summary>
        /// Represents the x:calculatedMembers XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="calculatedMember" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculatedMembers.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calculatedMembers = x + "calculatedMembers";

        /// <summary>
        /// Represents the x:cell XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="row" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="v" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.r" />, <see cref="NoNamespace.t" />, <see cref="NoNamespace.vm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalCell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cell = x + "cell";

        /// <summary>
        /// Represents the x:cellMetadata XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="metadata" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bk" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellMetadata.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cellMetadata = x + "cellMetadata";

        /// <summary>
        /// Represents the x:cellStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cellStyles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.builtinId" />, <see cref="NoNamespace.customBuiltin" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.iLevel" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.xfId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cellStyle = x + "cellStyle";

        /// <summary>
        /// Represents the x:cellStyles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cellStyle" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cellStyles = x + "cellStyles";

        /// <summary>
        /// Represents the x:cellStyleXfs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="xf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellStyleFormats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cellStyleXfs = x + "cellStyleXfs";

        /// <summary>
        /// Represents the x:cellWatch XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cellWatches" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellWatch.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cellWatch = x + "cellWatch";

        /// <summary>
        /// Represents the x:cellWatches XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cellWatch" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellWatches.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cellWatches = x + "cellWatches";

        /// <summary>
        /// Represents the x:cellXfs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="xf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellFormats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cellXfs = x + "cellXfs";

        /// <summary>
        /// Represents the x:cfRule XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="conditionalFormatting" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="colorScale" />, <see cref="dataBar" />, <see cref="extLst" />, <see cref="formula" />, <see cref="iconSet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.aboveAverage" />, <see cref="NoNamespace.bottom" />, <see cref="NoNamespace.dxfId_" />, <see cref="NoNamespace.equalAverage" />, <see cref="NoNamespace.@operator" />, <see cref="NoNamespace.percent" />, <see cref="NoNamespace.priority" />, <see cref="NoNamespace.rank" />, <see cref="NoNamespace.stdDev" />, <see cref="NoNamespace.stopIfTrue" />, <see cref="NoNamespace.text" />, <see cref="NoNamespace.timePeriod" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormattingRule.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cfRule = x + "cfRule";

        /// <summary>
        /// Represents the x:cfvo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colorScale" />, <see cref="dataBar" />, <see cref="iconSet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.gte" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormatValueObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cfvo = x + "cfvo";

        /// <summary>
        /// Represents the x:charset XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontCharSet, RunPropertyCharSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName charset = x + "charset";

        /// <summary>
        /// Represents the x:chartFormat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartFormats" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotArea" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.chart" />, <see cref="NoNamespace.format" />, <see cref="NoNamespace.series" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartFormat = x + "chartFormat";

        /// <summary>
        /// Represents the x:chartFormats XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="chartFormat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartFormats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartFormats = x + "chartFormats";

        /// <summary>
        /// Represents the x:chartsheet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="customSheetViews" />, <see cref="drawing" />, <see cref="drawingHF" />, <see cref="extLst" />, <see cref="headerFooter" />, <see cref="legacyDrawing" />, <see cref="legacyDrawingHF" />, <see cref="pageMargins" />, <see cref="pageSetup" />, <see cref="picture" />, <see cref="sheetPr" />, <see cref="sheetProtection" />, <see cref="sheetViews" />, <see cref="webPublishItems" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Chartsheet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName chartsheet = x + "chartsheet";

        /// <summary>
        /// Represents the x:col XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cols" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bestFit" />, <see cref="NoNamespace.collapsed" />, <see cref="NoNamespace.customWidth" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.max" />, <see cref="NoNamespace.min" />, <see cref="NoNamespace.outlineLevel" />, <see cref="NoNamespace.phonetic" />, <see cref="NoNamespace.style" />, <see cref="NoNamespace.width" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Column.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName col = x + "col";

        /// <summary>
        /// Represents the x:colBreaks XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customSheetView" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="brk" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnBreaks.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colBreaks = x + "colBreaks";

        /// <summary>
        /// Represents the x:colFields XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="field" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnFields.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colFields = x + "colFields";

        /// <summary>
        /// Represents the x:colHierarchiesUsage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="colHierarchyUsage" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnHierarchiesUsage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colHierarchiesUsage = x + "colHierarchiesUsage";

        /// <summary>
        /// Represents the x:colHierarchyUsage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colHierarchiesUsage" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnHierarchyUsage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colHierarchyUsage = x + "colHierarchyUsage";

        /// <summary>
        /// Represents the x:colItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="i" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colItems = x + "colItems";

        /// <summary>
        /// Represents the x:color XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bottom" />, <see cref="colorScale" />, <see cref="dataBar" />, <see cref="diagonal" />, <see cref="end" />, <see cref="font" />, <see cref="horizontal" />, <see cref="left" />, <see cref="mruColors" />, <see cref="right" />, <see cref="rPr" />, <see cref="start" />, <see cref="stop" />, <see cref="top" />, <see cref="vertical" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Color.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName color = x + "color";

        /// <summary>
        /// Represents the x:colorFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="filterColumn" />, <see cref="XNSV.filter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cellColor" />, <see cref="NoNamespace.dxfId_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorFilter = x + "colorFilter";

        /// <summary>
        /// Represents the x:colors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="indexedColors" />, <see cref="mruColors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Colors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colors = x + "colors";

        /// <summary>
        /// Represents the x:colorScale XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cfRule" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cfvo" />, <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorScale.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorScale = x + "colorScale";

        /// <summary>
        /// Represents the x:cols XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="col" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Columns.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cols = x + "cols";

        /// <summary>
        /// Represents the x:comment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="commentList" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="commentPr" />, <see cref="text" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.authorId" />, <see cref="NoNamespace.guid" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.shapeId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Comment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName comment = x + "comment";

        /// <summary>
        /// Represents the x:commentList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="comments" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="comment" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentList = x + "commentList";

        /// <summary>
        /// Represents the x:commentPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="comment" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.altText" />, <see cref="NoNamespace.autoFill" />, <see cref="NoNamespace.autoLine" />, <see cref="NoNamespace.autoScale" />, <see cref="NoNamespace.colHidden" />, <see cref="NoNamespace.defaultSize" />, <see cref="NoNamespace.disabled" />, <see cref="NoNamespace.justLastX" />, <see cref="NoNamespace.locked" />, <see cref="NoNamespace.lockText" />, <see cref="NoNamespace.print" />, <see cref="NoNamespace.rowHidden" />, <see cref="NoNamespace.textHAlign" />, <see cref="NoNamespace.textVAlign" />, <see cref="NoNamespace.uiObject" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName commentPr = x + "commentPr";

        /// <summary>
        /// Represents the x:comments XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="authors" />, <see cref="commentList" />, <see cref="extLst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Comments.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName comments = x + "comments";

        /// <summary>
        /// Represents the x:condense XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Condense.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName condense = x + "condense";

        /// <summary>
        /// Represents the x:conditionalFormat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="conditionalFormats" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pivotAreas" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.priority" />, <see cref="NoNamespace.scope" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conditionalFormat = x + "conditionalFormat";

        /// <summary>
        /// Represents the x:conditionalFormats XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="conditionalFormat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conditionalFormats = x + "conditionalFormats";

        /// <summary>
        /// Represents the x:conditionalFormatting XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cfRule" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.pivot" />, <see cref="NoNamespace.sqref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormatting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conditionalFormatting = x + "conditionalFormatting";

        /// <summary>
        /// Represents the x:connection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connections" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dbPr" />, <see cref="extLst" />, <see cref="olapPr" />, <see cref="parameters" />, <see cref="textPr" />, <see cref="webPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.background" />, <see cref="NoNamespace.credentials" />, <see cref="NoNamespace.deleted" />, <see cref="NoNamespace.description" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.interval" />, <see cref="NoNamespace.keepAlive" />, <see cref="NoNamespace.minRefreshableVersion" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.@new" />, <see cref="NoNamespace.odcFile" />, <see cref="NoNamespace.onlyUseConnectionFile" />, <see cref="NoNamespace.reconnectionMethod" />, <see cref="NoNamespace.refreshedVersion" />, <see cref="NoNamespace.refreshOnLoad" />, <see cref="NoNamespace.saveData" />, <see cref="NoNamespace.savePassword" />, <see cref="NoNamespace.singleSignOnId" />, <see cref="NoNamespace.sourceFile" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Connection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName connection = x + "connection";

        /// <summary>
        /// Represents the x:connections XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="connection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Connections.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName connections = x + "connections";

        /// <summary>
        /// Represents the x:consolidation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheSource" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pages" />, <see cref="rangeSets" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoPage" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Consolidation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName consolidation = x + "consolidation";

        /// <summary>
        /// Represents the x:control XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="controls" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="controlPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="R.id" />, <see cref="NoNamespace.shapeId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Control.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName control = x + "control";

        /// <summary>
        /// Represents the x:controlPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="control" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.altText" />, <see cref="NoNamespace.autoFill" />, <see cref="NoNamespace.autoLine" />, <see cref="NoNamespace.autoPict" />, <see cref="NoNamespace.cf" />, <see cref="NoNamespace.defaultSize" />, <see cref="NoNamespace.disabled" />, <see cref="NoNamespace.linkedCell" />, <see cref="NoNamespace.listFillRange" />, <see cref="NoNamespace.locked" />, <see cref="NoNamespace.macro" />, <see cref="NoNamespace.print" />, <see cref="R.id" />, <see cref="NoNamespace.recalcAlways" />, <see cref="NoNamespace.uiObject" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ControlProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName controlPr = x + "controlPr";

        /// <summary>
        /// Represents the x:controls XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dialogsheet" />, <see cref="worksheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="control" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Controls.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName controls = x + "controls";

        /// <summary>
        /// Represents the x:customFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customFilters" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@operator" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customFilter = x + "customFilter";

        /// <summary>
        /// Represents the x:customFilters XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="filterColumn" />, <see cref="XNSV.filter" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="customFilter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.and" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomFilters.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customFilters = x + "customFilters";

        /// <summary>
        /// Represents the x:customPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customProperties" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customPr = x + "customPr";

        /// <summary>
        /// Represents the x:customProperties XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="customPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customProperties = x + "customProperties";

        /// <summary>
        /// Represents the x:customSheetView XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customSheetViews" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="autoFilter" />, <see cref="colBreaks" />, <see cref="extLst" />, <see cref="headerFooter" />, <see cref="pageMargins" />, <see cref="pageSetup" />, <see cref="pane" />, <see cref="printOptions" />, <see cref="rowBreaks" />, <see cref="selection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.colorId" />, <see cref="NoNamespace.filter" />, <see cref="NoNamespace.filterUnique" />, <see cref="NoNamespace.fitToPage" />, <see cref="NoNamespace.guid" />, <see cref="NoNamespace.hiddenColumns" />, <see cref="NoNamespace.hiddenRows" />, <see cref="NoNamespace.outlineSymbols" />, <see cref="NoNamespace.printArea" />, <see cref="NoNamespace.scale" />, <see cref="NoNamespace.showAutoFilter" />, <see cref="NoNamespace.showFormulas" />, <see cref="NoNamespace.showGridLines" />, <see cref="NoNamespace.showPageBreaks" />, <see cref="NoNamespace.showRowCol" />, <see cref="NoNamespace.showRuler" />, <see cref="NoNamespace.state" />, <see cref="NoNamespace.topLeftCell" />, <see cref="NoNamespace.view" />, <see cref="NoNamespace.zeroValues" />, <see cref="NoNamespace.zoomToFit" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomChartsheetView, CustomSheetView.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customSheetView = x + "customSheetView";

        /// <summary>
        /// Represents the x:customSheetViews XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="customSheetView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomChartsheetViews, CustomSheetViews.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customSheetViews = x + "customSheetViews";

        /// <summary>
        /// Represents the x:customWorkbookView XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customWorkbookViews" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.activeSheetId" />, <see cref="NoNamespace.autoUpdate" />, <see cref="NoNamespace.changesSavedWin" />, <see cref="NoNamespace.guid" />, <see cref="NoNamespace.includeHiddenRowCol" />, <see cref="NoNamespace.includePrintSettings" />, <see cref="NoNamespace.maximized" />, <see cref="NoNamespace.mergeInterval" />, <see cref="NoNamespace.minimized" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.onlySync" />, <see cref="NoNamespace.personalView" />, <see cref="NoNamespace.showComments" />, <see cref="NoNamespace.showFormulaBar" />, <see cref="NoNamespace.showHorizontalScroll" />, <see cref="NoNamespace.showObjects" />, <see cref="NoNamespace.showSheetTabs" />, <see cref="NoNamespace.showStatusbar" />, <see cref="NoNamespace.showVerticalScroll" />, <see cref="NoNamespace.tabRatio" />, <see cref="NoNamespace.windowHeight" />, <see cref="NoNamespace.windowWidth" />, <see cref="NoNamespace.xWindow" />, <see cref="NoNamespace.yWindow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomWorkbookView.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customWorkbookView = x + "customWorkbookView";

        /// <summary>
        /// Represents the x:customWorkbookViews XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="customWorkbookView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomWorkbookViews.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customWorkbookViews = x + "customWorkbookViews";

        /// <summary>
        /// Represents the x:d XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="groupItems" />, <see cref="r" />, <see cref="sharedItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="x_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.c" />, <see cref="NoNamespace.cp" />, <see cref="NoNamespace.f" />, <see cref="NoNamespace.u" />, <see cref="NoNamespace.v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DateTimeItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName d = x + "d";

        /// <summary>
        /// Represents the x:dataBar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cfRule" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cfvo" />, <see cref="color" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.maxLength" />, <see cref="NoNamespace.minLength" />, <see cref="NoNamespace.showValue" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataBar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataBar = x + "dataBar";

        /// <summary>
        /// Represents the x:DataBinding XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Map_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.ConnectionID_" />, <see cref="NoNamespace.DataBindingLoadMode" />, <see cref="NoNamespace.DataBindingName" />, <see cref="NoNamespace.FileBinding" />, <see cref="NoNamespace.FileBindingName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataBinding.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName DataBinding = x + "DataBinding";

        /// <summary>
        /// Represents the x:dataConsolidate XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dataRefs" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.function" />, <see cref="NoNamespace.leftLabels" />, <see cref="NoNamespace.link" />, <see cref="NoNamespace.startLabels" />, <see cref="NoNamespace.topLabels" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataConsolidate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataConsolidate = x + "dataConsolidate";

        /// <summary>
        /// Represents the x:dataField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataFields" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.baseField" />, <see cref="NoNamespace.baseItem" />, <see cref="NoNamespace.fld" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.numFmtId" />, <see cref="NoNamespace.showDataAs" />, <see cref="NoNamespace.subtotal" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataField = x + "dataField";

        /// <summary>
        /// Represents the x:dataFields XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dataField" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataFields.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataFields = x + "dataFields";

        /// <summary>
        /// Represents the x:dataRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataRefs" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="R.id" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.sheet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataRef = x + "dataRef";

        /// <summary>
        /// Represents the x:dataRefs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataConsolidate" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dataRef" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataReferences.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataRefs = x + "dataRefs";

        /// <summary>
        /// Represents the x:dataValidation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataValidations" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="formula1" />, <see cref="formula2" />, <see cref="X12AC.list" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allowBlank" />, <see cref="NoNamespace.error" />, <see cref="NoNamespace.errorStyle" />, <see cref="NoNamespace.errorTitle" />, <see cref="NoNamespace.imeMode" />, <see cref="NoNamespace.@operator" />, <see cref="NoNamespace.prompt" />, <see cref="NoNamespace.promptTitle" />, <see cref="NoNamespace.showDropDown" />, <see cref="NoNamespace.showErrorMessage" />, <see cref="NoNamespace.showInputMessage" />, <see cref="NoNamespace.sqref" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataValidation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataValidation = x + "dataValidation";

        /// <summary>
        /// Represents the x:dataValidations XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dataValidation" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.disablePrompts" />, <see cref="NoNamespace.xWindow" />, <see cref="NoNamespace.yWindow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataValidations.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataValidations = x + "dataValidations";

        /// <summary>
        /// Represents the x:dateGroupItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="filters" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dateTimeGrouping" />, <see cref="NoNamespace.day" />, <see cref="NoNamespace.hour" />, <see cref="NoNamespace.minute" />, <see cref="NoNamespace.month" />, <see cref="NoNamespace.second" />, <see cref="NoNamespace.year" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DateGroupItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dateGroupItem = x + "dateGroupItem";

        /// <summary>
        /// Represents the x:dbPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.command" />, <see cref="NoNamespace.commandType" />, <see cref="NoNamespace.connection" />, <see cref="NoNamespace.serverCommand" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DatabaseProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dbPr = x + "dbPr";

        /// <summary>
        /// Represents the x:ddeItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ddeItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="values" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.advise" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.ole" />, <see cref="NoNamespace.preferPic" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DdeItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ddeItem = x + "ddeItem";

        /// <summary>
        /// Represents the x:ddeItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ddeLink" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ddeItem" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DdeItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ddeItems = x + "ddeItems";

        /// <summary>
        /// Represents the x:ddeLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="externalLink" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ddeItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.ddeService" />, <see cref="NoNamespace.ddeTopic" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DdeLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ddeLink = x + "ddeLink";

        /// <summary>
        /// Represents the x:definedName XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="definedNames" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.comment" />, <see cref="NoNamespace.customMenu" />, <see cref="NoNamespace.description" />, <see cref="NoNamespace.function" />, <see cref="NoNamespace.functionGroupId" />, <see cref="NoNamespace.help" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.localSheetId" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.publishToServer" />, <see cref="NoNamespace.refersTo" />, <see cref="NoNamespace.sheetId" />, <see cref="NoNamespace.shortcutKey" />, <see cref="NoNamespace.statusBar" />, <see cref="NoNamespace.vbProcedure" />, <see cref="NoNamespace.workbookParameter" />, <see cref="NoNamespace.xlm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefinedName, ExternalDefinedName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName definedName = x + "definedName";

        /// <summary>
        /// Represents the x:definedNames XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="externalBook" />, <see cref="workbook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="definedName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefinedNames, ExternalDefinedNames.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName definedNames = x + "definedNames";

        /// <summary>
        /// Represents the x:deletedField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="queryTableDeletedFields" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DeletedField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName deletedField = x + "deletedField";

        /// <summary>
        /// Represents the x:diagonal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="border" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DiagonalBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName diagonal = x + "diagonal";

        /// <summary>
        /// Represents the x:dialogsheet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="controls" />, <see cref="customSheetViews" />, <see cref="drawing" />, <see cref="drawingHF" />, <see cref="extLst" />, <see cref="headerFooter" />, <see cref="legacyDrawing" />, <see cref="legacyDrawingHF" />, <see cref="oleObjects" />, <see cref="pageMargins" />, <see cref="pageSetup" />, <see cref="printOptions" />, <see cref="sheetFormatPr" />, <see cref="sheetPr" />, <see cref="sheetProtection" />, <see cref="sheetViews" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DialogSheet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dialogsheet = x + "dialogsheet";

        /// <summary>
        /// Represents the x:dimension XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dimensions" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.caption" />, <see cref="NoNamespace.measure" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.uniqueName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Dimension, SheetDimension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dimension = x + "dimension";

        /// <summary>
        /// Represents the x:dimensions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dimension" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Dimensions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dimensions = x + "dimensions";

        /// <summary>
        /// Represents the x:discretePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fieldGroup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="x_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DiscreteProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName discretePr = x + "discretePr";

        /// <summary>
        /// Represents the x:drawing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Drawing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName drawing = x + "drawing";

        /// <summary>
        /// Represents the x:drawingHF XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cfe" />, <see cref="NoNamespace.cff" />, <see cref="NoNamespace.cfo" />, <see cref="NoNamespace.che" />, <see cref="NoNamespace.chf" />, <see cref="NoNamespace.cho" />, <see cref="NoNamespace.lfe" />, <see cref="NoNamespace.lff" />, <see cref="NoNamespace.lfo" />, <see cref="NoNamespace.lhe" />, <see cref="NoNamespace.lhf" />, <see cref="NoNamespace.lho" />, <see cref="R.id" />, <see cref="NoNamespace.rfe" />, <see cref="NoNamespace.rff" />, <see cref="NoNamespace.rfo" />, <see cref="NoNamespace.rhe" />, <see cref="NoNamespace.rhf" />, <see cref="NoNamespace.rho" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DrawingHeaderFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName drawingHF = x + "drawingHF";

        /// <summary>
        /// Represents the x:dxf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dxfs" />, <see cref="rfmt" />, <see cref="X14.dxfs" />, <see cref="X15.dxfs" />, <see cref="XLRD2.dxfs" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alignment" />, <see cref="border" />, <see cref="extLst" />, <see cref="fill" />, <see cref="font" />, <see cref="numFmt" />, <see cref="protection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DifferentialFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dxf = x + "dxf";

        /// <summary>
        /// Represents the x:dxfs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dxf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DifferentialFormats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dxfs = x + "dxfs";

        /// <summary>
        /// Represents the x:dynamicFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="filterColumn" />, <see cref="XNSV.filter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.maxVal" />, <see cref="NoNamespace.maxValIso" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.val" />, <see cref="NoNamespace.valIso" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DynamicFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dynamicFilter = x + "dynamicFilter";

        /// <summary>
        /// Represents the x:e XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="entries" />, <see cref="groupItems" />, <see cref="r" />, <see cref="sharedItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tpls" />, <see cref="x_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.b" />, <see cref="NoNamespace.bc" />, <see cref="NoNamespace.c" />, <see cref="NoNamespace.cp" />, <see cref="NoNamespace.f" />, <see cref="NoNamespace.fc" />, <see cref="NoNamespace.i" />, <see cref="NoNamespace.@in" />, <see cref="NoNamespace.st" />, <see cref="NoNamespace.u" />, <see cref="NoNamespace.un" />, <see cref="NoNamespace.v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ErrorItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName e = x + "e";

        /// <summary>
        /// Represents the x:end XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="border" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName end = x + "end";

        /// <summary>
        /// Represents the x:entries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tupleCache" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="e" />, <see cref="m" />, <see cref="n" />, <see cref="s" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Entries.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName entries = x + "entries";

        /// <summary>
        /// Represents the x:evenFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EvenFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName evenFooter = x + "evenFooter";

        /// <summary>
        /// Represents the x:evenHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EvenHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName evenHeader = x + "evenHeader";

        /// <summary>
        /// Represents the x:ext XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="extLst" />, <see cref="X14.extLst" />, <see cref="X15.extLst" />, <see cref="XLMSFORMS.extLst" />, <see cref="XLRD.extLst" />, <see cref="XLRD2.extLst" />, <see cref="XLRDWI.extLst" />, <see cref="XLTC.extLst" />, <see cref="XNSV.extLst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X14.cacheField" />, <see cref="X14.cacheHierarchy" />, <see cref="X14.calculatedMember" />, <see cref="X14.conditionalFormattings" />, <see cref="X14.connection" />, <see cref="X14.dataField" />, <see cref="X14.dataValidations" />, <see cref="X14.definedNames" />, <see cref="X14.dxfs" />, <see cref="X14.id" />, <see cref="X14.ignoredErrors" />, <see cref="X14.pivotCacheDefinition" />, <see cref="X14.pivotCaches" />, <see cref="X14.pivotField" />, <see cref="X14.pivotHierarchy" />, <see cref="X14.pivotTableDefinition" />, <see cref="X14.protectedRanges" />, <see cref="X14.slicerCaches" />, <see cref="X14.slicerList" />, <see cref="X14.slicerStyles" />, <see cref="X14.sourceConnection" />, <see cref="X14.sparklineGroups" />, <see cref="X14.table" />, <see cref="X14.workbookPr" />, <see cref="X15.cachedUniqueNames" />, <see cref="X15.cacheHierarchy" />, <see cref="X15.calculatedMember" />, <see cref="X15.connection" />, <see cref="X15.dataField" />, <see cref="X15.dataModel" />, <see cref="X15.dxfs" />, <see cref="X15.movingPeriodState" />, <see cref="X15.pivotCacheDecoupled" />, <see cref="X15.pivotCacheIdVersion" />, <see cref="X15.pivotCaches" />, <see cref="X15.pivotFilter" />, <see cref="X15.pivotTableData" />, <see cref="X15.pivotTableReferences" />, <see cref="X15.pivotTableUISettings" />, <see cref="X15.queryTable" />, <see cref="X15.slicerCacheHideItemsWithNoData" />, <see cref="X15.slicerCachePivotTables" />, <see cref="X15.slicerCaches" />, <see cref="X15.tableSlicerCache" />, <see cref="X15.timelineCachePivotCaches" />, <see cref="X15.timelineCacheRefs" />, <see cref="X15.timelinePivotCacheDefinition" />, <see cref="X15.timelineRefs" />, <see cref="X15.timelineStyles" />, <see cref="X15.webExtensions" />, <see cref="X15.workbookPr" />, <see cref="XLECS.externalCodeService" />, <see cref="XLMSFORMS.msForm" />, <see cref="XXPIM.implicitMeasureSupport" />, <see cref="XXPVI.cacheVersionInfo" />, <see cref="XXPVI.pivotVersionInfo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.uri" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheFieldExtension, CacheHierarchyExtension, CacheSourceExtension, CalculatedMemberExtension, ConditionalFormattingRuleExtension, ConnectionExtension, DataFieldExtension, Extension, PivotCacheDefinitionExtension, PivotFieldExtension, PivotFilterExtension, PivotHierarchyExtension, PivotTableDefinitionExtension, QueryTableExtension, SlicerCacheDefinitionExtension, StylesheetExtension, TableExtension, WorkbookExtension, WorksheetExtension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = x + "ext";

        /// <summary>
        /// Represents the x:extend XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Extend.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extend = x + "extend";

        /// <summary>
        /// Represents the x:externalBook XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="externalLink" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="definedNames" />, <see cref="sheetDataSet" />, <see cref="sheetNames" />, <see cref="XXL21.alternateUrls" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalBook.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName externalBook = x + "externalBook";

        /// <summary>
        /// Represents the x:externalLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="ddeLink" />, <see cref="externalBook" />, <see cref="extLst" />, <see cref="oleLink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName externalLink = x + "externalLink";

        /// <summary>
        /// Represents the x:externalReference XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="externalReferences" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName externalReference = x + "externalReference";

        /// <summary>
        /// Represents the x:externalReferences XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="externalReference" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalReferences.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName externalReferences = x + "externalReferences";

        /// <summary>
        /// Represents the x:extLst XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="autoFilter" />, <see cref="bk" />, <see cref="c" />, <see cref="cacheField" />, <see cref="cacheHierarchy" />, <see cref="cacheSource" />, <see cref="calcChain" />, <see cref="calculatedItem" />, <see cref="calculatedMember" />, <see cref="cellStyle" />, <see cref="cfRule" />, <see cref="cfvo" />, <see cref="chartsheet" />, <see cref="comments" />, <see cref="conditionalFormat" />, <see cref="conditionalFormatting" />, <see cref="connection" />, <see cref="customSheetView" />, <see cref="customWorkbookView" />, <see cref="dataField" />, <see cref="dialogsheet" />, <see cref="dxf" />, <see cref="externalLink" />, <see cref="filter" />, <see cref="filterColumn" />, <see cref="format" />, <see cref="futureMetadata" />, <see cref="groupLevel" />, <see cref="header" />, <see cref="ignoredErrors" />, <see cref="metadata" />, <see cref="nc" />, <see cref="ndxf" />, <see cref="oc" />, <see cref="odxf" />, <see cref="pageField" />, <see cref="pivotArea" />, <see cref="pivotCacheDefinition" />, <see cref="pivotCacheRecords" />, <see cref="pivotField" />, <see cref="pivotHierarchy" />, <see cref="pivotTableDefinition" />, <see cref="queryTable" />, <see cref="queryTableField" />, <see cref="queryTableRefresh" />, <see cref="rcc" />, <see cref="rdn" />, <see cref="reference" />, <see cref="rfmt" />, <see cref="row" />, <see cref="rsnm" />, <see cref="sheetView" />, <see cref="sheetViews" />, <see cref="singleXmlCell" />, <see cref="sortState" />, <see cref="sst" />, <see cref="styleSheet" />, <see cref="table" />, <see cref="tableColumn" />, <see cref="tupleCache" />, <see cref="userInfo" />, <see cref="volTypes" />, <see cref="workbook" />, <see cref="workbookView" />, <see cref="worksheet" />, <see cref="xf" />, <see cref="xmlCellPr" />, <see cref="xmlColumnPr" />, <see cref="xmlPr" />, <see cref="X14.dxf" />, <see cref="X14.pivotArea" />, <see cref="XNE.macrosheet" />, <see cref="XNSV.dxf" />, <see cref="XNSV.filter" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheFieldExtensionList, CacheHierarchyExtensionList, CacheSourceExtensionList, CalculatedMemberExtensionList, ConditionalFormattingRuleExtensionList, ConnectionExtensionList, DataFieldExtensionList, ExtensionList, PivotCacheDefinitionExtensionList, PivotFieldExtensionList, PivotFilterExtensionList, PivotHierarchyExtensionList, PivotTableDefinitionExtensionList, QueryTableExtensionList, StylesheetExtensionList, TableExtensionList, WorkbookExtensionList, WorksheetExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = x + "extLst";

        /// <summary>
        /// Represents the x:f XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="c" />, <see cref="nc" />, <see cref="oc" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.aca" />, <see cref="NoNamespace.bx" />, <see cref="NoNamespace.ca" />, <see cref="NoNamespace.del1" />, <see cref="NoNamespace.del2" />, <see cref="NoNamespace.dt2D" />, <see cref="NoNamespace.dtr" />, <see cref="NoNamespace.r1" />, <see cref="NoNamespace.r2" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.si" />, <see cref="NoNamespace.t" />, <see cref="XML.space" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellFormula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName f = x + "f";

        /// <summary>
        /// Represents the x:family XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontFamily, FontFamilyNumbering.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName family = x + "family";

        /// <summary>
        /// Represents the x:fgColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="patternFill" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ForegroundColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fgColor = x + "fgColor";

        /// <summary>
        /// Represents the x:field XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colFields" />, <see cref="rowFields" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Field.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName field = x + "field";

        /// <summary>
        /// Represents the x:fieldGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheField" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="discretePr" />, <see cref="groupItems" />, <see cref="rangePr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@base" />, <see cref="NoNamespace.par" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FieldGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fieldGroup = x + "fieldGroup";

        /// <summary>
        /// Represents the x:fieldsUsage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheHierarchy" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="fieldUsage" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FieldsUsage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fieldsUsage = x + "fieldsUsage";

        /// <summary>
        /// Represents the x:fieldUsage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fieldsUsage" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.x" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FieldUsage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fieldUsage = x + "fieldUsage";

        /// <summary>
        /// Represents the x:fileRecoveryPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoRecover" />, <see cref="NoNamespace.crashSave" />, <see cref="NoNamespace.dataExtractLoad" />, <see cref="NoNamespace.repairLoad" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FileRecoveryProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fileRecoveryPr = x + "fileRecoveryPr";

        /// <summary>
        /// Represents the x:fileSharing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.algorithmName" />, <see cref="NoNamespace.hashValue" />, <see cref="NoNamespace.readOnlyRecommended" />, <see cref="NoNamespace.reservationPassword" />, <see cref="NoNamespace.saltValue" />, <see cref="NoNamespace.spinCount" />, <see cref="NoNamespace.userName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FileSharing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fileSharing = x + "fileSharing";

        /// <summary>
        /// Represents the x:fileVersion XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.appName" />, <see cref="NoNamespace.codeName" />, <see cref="NoNamespace.lastEdited" />, <see cref="NoNamespace.lowestEdited" />, <see cref="NoNamespace.rupBuild" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FileVersion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fileVersion = x + "fileVersion";

        /// <summary>
        /// Represents the x:fill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dxf" />, <see cref="fills" />, <see cref="ndxf" />, <see cref="odxf" />, <see cref="X14.dxf" />, <see cref="XNSV.dxf" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="gradientFill" />, <see cref="patternFill" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Fill.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fill = x + "fill";

        /// <summary>
        /// Represents the x:fills XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="fill" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Fills.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fills = x + "fills";

        /// <summary>
        /// Represents the x:filter XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="filters" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="autoFilter" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.evalOrder" />, <see cref="NoNamespace.fld" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.iMeasureFld" />, <see cref="NoNamespace.iMeasureHier" />, <see cref="NoNamespace.mpFld" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.stringValue1" />, <see cref="NoNamespace.stringValue2" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Filter, PivotFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filter = x + "filter";

        /// <summary>
        /// Represents the x:filterColumn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="autoFilter" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="colorFilter" />, <see cref="customFilters" />, <see cref="dynamicFilter" />, <see cref="extLst" />, <see cref="filters" />, <see cref="iconFilter" />, <see cref="top10" />, <see cref="X14.customFilters" />, <see cref="X14.iconFilter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.colId" />, <see cref="NoNamespace.hiddenButton" />, <see cref="NoNamespace.showButton" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilterColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filterColumn = x + "filterColumn";

        /// <summary>
        /// Represents the x:filters XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="filterColumn" />, <see cref="pivotTableDefinition" />, <see cref="XNSV.filter" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dateGroupItem" />, <see cref="filter" />, <see cref="X14.filter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.blank" />, <see cref="NoNamespace.calendarType" />, <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Filters, PivotFilters.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filters = x + "filters";

        /// <summary>
        /// Represents the x:firstFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FirstFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstFooter = x + "firstFooter";

        /// <summary>
        /// Represents the x:firstHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FirstHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName firstHeader = x + "firstHeader";

        /// <summary>
        /// Represents the x:font XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dxf" />, <see cref="fonts" />, <see cref="ndxf" />, <see cref="odxf" />, <see cref="X14.dxf" />, <see cref="XNSV.dxf" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="b" />, <see cref="charset" />, <see cref="color" />, <see cref="condense" />, <see cref="extend" />, <see cref="family" />, <see cref="i" />, <see cref="name" />, <see cref="outline" />, <see cref="scheme" />, <see cref="shadow" />, <see cref="strike" />, <see cref="sz" />, <see cref="u" />, <see cref="vertAlign" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Font.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName font = x + "font";

        /// <summary>
        /// Represents the x:fonts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="X14AC.knownFonts" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Fonts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fonts = x + "fonts";

        /// <summary>
        /// Represents the x:format XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="formats" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pivotArea" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.action" />, <see cref="NoNamespace.dxfId_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Format.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName format = x + "format";

        /// <summary>
        /// Represents the x:formats XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="format" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formats = x + "formats";

        /// <summary>
        /// Represents the x:formula XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cfRule" />, <see cref="rdn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formula = x + "formula";

        /// <summary>
        /// Represents the x:formula1 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataValidation" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formula1.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formula1 = x + "formula1";

        /// <summary>
        /// Represents the x:formula2 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataValidation" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formula2.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formula2 = x + "formula2";

        /// <summary>
        /// Represents the x:from XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="XDR.col" />, <see cref="XDR.colOff" />, <see cref="XDR.row" />, <see cref="XDR.rowOff" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FromMarker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName from = x + "from";

        /// <summary>
        /// Represents the x:functionGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="functionGroups" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FunctionGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName functionGroup = x + "functionGroup";

        /// <summary>
        /// Represents the x:functionGroups XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="functionGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.builtInGroupCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FunctionGroups.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName functionGroups = x + "functionGroups";

        /// <summary>
        /// Represents the x:futureMetadata XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="metadata" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bk" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FutureMetadata.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName futureMetadata = x + "futureMetadata";

        /// <summary>
        /// Represents the x:gradientFill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fill" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="stop" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bottom" />, <see cref="NoNamespace.degree" />, <see cref="NoNamespace.left" />, <see cref="NoNamespace.right" />, <see cref="NoNamespace.top" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GradientFill.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName gradientFill = x + "gradientFill";

        /// <summary>
        /// Represents the x:group XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="groups" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="groupMembers" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.caption" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.uniqueName" />, <see cref="NoNamespace.uniqueParent" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Group.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName group = x + "group";

        /// <summary>
        /// Represents the x:groupItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fieldGroup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="b" />, <see cref="d" />, <see cref="e" />, <see cref="m" />, <see cref="n" />, <see cref="s" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName groupItems = x + "groupItems";

        /// <summary>
        /// Represents the x:groupLevel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="groupLevels" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="groups" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.caption" />, <see cref="NoNamespace.customRollUp" />, <see cref="NoNamespace.uniqueName" />, <see cref="NoNamespace.user" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupLevel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName groupLevel = x + "groupLevel";

        /// <summary>
        /// Represents the x:groupLevels XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheHierarchy" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="groupLevel" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupLevels.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName groupLevels = x + "groupLevels";

        /// <summary>
        /// Represents the x:groupMember XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="groupMembers" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.group" />, <see cref="NoNamespace.uniqueName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupMember.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName groupMember = x + "groupMember";

        /// <summary>
        /// Represents the x:groupMembers XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="group" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="groupMember" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupMembers.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName groupMembers = x + "groupMembers";

        /// <summary>
        /// Represents the x:groups XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="groupLevel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="group" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Groups.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName groups = x + "groups";

        /// <summary>
        /// Represents the x:header XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headers" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="reviewedList" />, <see cref="sheetIdMap" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dateTime" />, <see cref="NoNamespace.guid" />, <see cref="NoNamespace.maxRId" />, <see cref="NoNamespace.maxSheetId" />, <see cref="NoNamespace.minRId" />, <see cref="R.id" />, <see cref="NoNamespace.userName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Header.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName header = x + "header";

        /// <summary>
        /// Represents the x:headerFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="customSheetView" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="evenFooter" />, <see cref="evenHeader" />, <see cref="firstFooter" />, <see cref="firstHeader" />, <see cref="oddFooter" />, <see cref="oddHeader" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignWithMargins" />, <see cref="NoNamespace.differentFirst" />, <see cref="NoNamespace.differentOddEven" />, <see cref="NoNamespace.scaleWithDoc" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HeaderFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName headerFooter = x + "headerFooter";

        /// <summary>
        /// Represents the x:headers XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="header" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.diskRevisions" />, <see cref="NoNamespace.exclusive" />, <see cref="NoNamespace.guid" />, <see cref="NoNamespace.history" />, <see cref="NoNamespace.keepChangeHistory" />, <see cref="NoNamespace.lastGuid" />, <see cref="NoNamespace.preserveHistory" />, <see cref="NoNamespace.@protected" />, <see cref="NoNamespace.revisionId" />, <see cref="NoNamespace.shared" />, <see cref="NoNamespace.trackRevisions" />, <see cref="NoNamespace.version" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Headers.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName headers = x + "headers";

        /// <summary>
        /// Represents the x:horizontal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="border" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HorizontalBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName horizontal = x + "horizontal";

        /// <summary>
        /// Represents the x:hyperlink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="hyperlinks" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.display" />, <see cref="NoNamespace.location" />, <see cref="R.id" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.tooltip" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Hyperlink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hyperlink = x + "hyperlink";

        /// <summary>
        /// Represents the x:hyperlinks XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="hyperlink" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Hyperlinks.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName hyperlinks = x + "hyperlinks";

        /// <summary>
        /// Represents the x:i XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colItems" />, <see cref="font" />, <see cref="rowItems" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="x_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.i" />, <see cref="NoNamespace.r" />, <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Italic, RowItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName i = x + "i";

        /// <summary>
        /// Represents the x:iconFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="filterColumn" />, <see cref="XNSV.filter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.iconId" />, <see cref="NoNamespace.iconSet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IconFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName iconFilter = x + "iconFilter";

        /// <summary>
        /// Represents the x:iconSet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cfRule" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cfvo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.iconSet" />, <see cref="NoNamespace.percent" />, <see cref="NoNamespace.reverse" />, <see cref="NoNamespace.showValue" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IconSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName iconSet = x + "iconSet";

        /// <summary>
        /// Represents the x:ignoredError XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ignoredErrors" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.calculatedColumn" />, <see cref="NoNamespace.emptyCellReference" />, <see cref="NoNamespace.evalError" />, <see cref="NoNamespace.formula" />, <see cref="NoNamespace.formulaRange" />, <see cref="NoNamespace.listDataValidation" />, <see cref="NoNamespace.numberStoredAsText" />, <see cref="NoNamespace.sqref" />, <see cref="NoNamespace.twoDigitTextYear" />, <see cref="NoNamespace.unlockedFormula" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IgnoredError.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ignoredError = x + "ignoredError";

        /// <summary>
        /// Represents the x:ignoredErrors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="ignoredError" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IgnoredErrors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ignoredErrors = x + "ignoredErrors";

        /// <summary>
        /// Represents the x:indexedColors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colors" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rgbColor" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IndexedColors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName indexedColors = x + "indexedColors";

        /// <summary>
        /// Represents the x:inputCells XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="scenario" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.deleted" />, <see cref="NoNamespace.numFmtId" />, <see cref="NoNamespace.r" />, <see cref="NoNamespace.undone" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InputCells.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName inputCells = x + "inputCells";

        /// <summary>
        /// Represents the x:is XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="c" />, <see cref="nc" />, <see cref="oc" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="phoneticPr" />, <see cref="r" />, <see cref="rPh" />, <see cref="t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InlineString.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName @is = x + "is";

        /// <summary>
        /// Represents the x:item XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="items" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.c" />, <see cref="NoNamespace.d" />, <see cref="NoNamespace.e" />, <see cref="NoNamespace.f" />, <see cref="NoNamespace.h" />, <see cref="NoNamespace.m" />, <see cref="NoNamespace.n" />, <see cref="NoNamespace.s" />, <see cref="NoNamespace.sd" />, <see cref="NoNamespace.t" />, <see cref="NoNamespace.x" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Item.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName item = x + "item";

        /// <summary>
        /// Represents the x:items XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotField" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="item" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Items.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName items = x + "items";

        /// <summary>
        /// Represents the x:k XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mdx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.n" />, <see cref="NoNamespace.np" />, <see cref="NoNamespace.p" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MdxKpi.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName k = x + "k";

        /// <summary>
        /// Represents the x:kpi XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="kpis" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.caption" />, <see cref="NoNamespace.displayFolder" />, <see cref="NoNamespace.goal" />, <see cref="NoNamespace.measureGroup" />, <see cref="NoNamespace.parent" />, <see cref="NoNamespace.status" />, <see cref="NoNamespace.trend" />, <see cref="NoNamespace.uniqueName" />, <see cref="NoNamespace.value" />, <see cref="NoNamespace.weight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Kpi.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName kpi = x + "kpi";

        /// <summary>
        /// Represents the x:kpis XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="kpi" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Kpis.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName kpis = x + "kpis";

        /// <summary>
        /// Represents the x:left XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="border" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LeftBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName left = x + "left";

        /// <summary>
        /// Represents the x:legacyDrawing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LegacyDrawing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legacyDrawing = x + "legacyDrawing";

        /// <summary>
        /// Represents the x:legacyDrawingHF XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LegacyDrawingHeaderFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName legacyDrawingHF = x + "legacyDrawingHF";

        /// <summary>
        /// Represents the x:location XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.colPageCount" />, <see cref="NoNamespace.firstDataCol" />, <see cref="NoNamespace.firstDataRow" />, <see cref="NoNamespace.firstHeaderRow" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.rowPageCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Location.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName location = x + "location";

        /// <summary>
        /// Represents the x:m XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="entries" />, <see cref="groupItems" />, <see cref="r" />, <see cref="sharedItems" />, <see cref="tables" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tpls" />, <see cref="x_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.b" />, <see cref="NoNamespace.bc" />, <see cref="NoNamespace.c" />, <see cref="NoNamespace.cp" />, <see cref="NoNamespace.f" />, <see cref="NoNamespace.fc" />, <see cref="NoNamespace.i" />, <see cref="NoNamespace.@in" />, <see cref="NoNamespace.st" />, <see cref="NoNamespace.u" />, <see cref="NoNamespace.un" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MissingItem, MissingTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName m = x + "m";

        /// <summary>
        /// Represents the x:main XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="volType" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tp" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.first" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Main.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName main = x + "main";

        /// <summary>
        /// Represents the x:Map XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="MapInfo" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="DataBinding" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.Append" />, <see cref="NoNamespace.AutoFit" />, <see cref="NoNamespace.ID_" />, <see cref="NoNamespace.Name_" />, <see cref="NoNamespace.PreserveFormat" />, <see cref="NoNamespace.PreserveSortAFLayout" />, <see cref="NoNamespace.RootElement" />, <see cref="NoNamespace.SchemaID" />, <see cref="NoNamespace.ShowImportExportValidationErrors" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Map.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Map_ = x + "Map";

        /// <summary>
        /// Represents the x:map XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="maps" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dimension" />, <see cref="NoNamespace.measureGroup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MeasureDimensionMap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName map = x + "map";

        /// <summary>
        /// Represents the x:MapInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="Map_" />, <see cref="Schema" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.SelectionNamespaces" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MapInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName MapInfo = x + "MapInfo";

        /// <summary>
        /// Represents the x:maps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="map" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Maps.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName maps = x + "maps";

        /// <summary>
        /// Represents the x:mdx XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mdxMetadata" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="k" />, <see cref="ms" />, <see cref="p" />, <see cref="t" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.f" />, <see cref="NoNamespace.n" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Mdx.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mdx = x + "mdx";

        /// <summary>
        /// Represents the x:mdxMetadata XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="metadata" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="mdx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MdxMetadata.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mdxMetadata = x + "mdxMetadata";

        /// <summary>
        /// Represents the x:measureGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="measureGroups" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.caption" />, <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MeasureGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName measureGroup = x + "measureGroup";

        /// <summary>
        /// Represents the x:measureGroups XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="measureGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MeasureGroups.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName measureGroups = x + "measureGroups";

        /// <summary>
        /// Represents the x:member XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="members" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Member.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName member = x + "member";

        /// <summary>
        /// Represents the x:members XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotHierarchy" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="member" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.level" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Members.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName members = x + "members";

        /// <summary>
        /// Represents the x:mergeCell XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mergeCells" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MergeCell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mergeCell = x + "mergeCell";

        /// <summary>
        /// Represents the x:mergeCells XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="mergeCell" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MergeCells.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mergeCells = x + "mergeCells";

        /// <summary>
        /// Represents the x:metadata XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="cellMetadata" />, <see cref="extLst" />, <see cref="futureMetadata" />, <see cref="mdxMetadata" />, <see cref="metadataStrings" />, <see cref="metadataTypes" />, <see cref="valueMetadata" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Metadata.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName metadata = x + "metadata";

        /// <summary>
        /// Represents the x:metadataStrings XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="metadata" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="s" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MetadataStrings.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName metadataStrings = x + "metadataStrings";

        /// <summary>
        /// Represents the x:metadataType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="metadataTypes" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.adjust" />, <see cref="NoNamespace.assign" />, <see cref="NoNamespace.cellMeta" />, <see cref="NoNamespace.clearAll" />, <see cref="NoNamespace.clearComments" />, <see cref="NoNamespace.clearContents" />, <see cref="NoNamespace.clearFormats" />, <see cref="NoNamespace.coerce" />, <see cref="NoNamespace.copy" />, <see cref="NoNamespace.delete" />, <see cref="NoNamespace.edit" />, <see cref="NoNamespace.ghostCol" />, <see cref="NoNamespace.ghostRow" />, <see cref="NoNamespace.merge" />, <see cref="NoNamespace.minSupportedVersion" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.pasteAll" />, <see cref="NoNamespace.pasteBorders" />, <see cref="NoNamespace.pasteColWidths" />, <see cref="NoNamespace.pasteComments" />, <see cref="NoNamespace.pasteDataValidation" />, <see cref="NoNamespace.pasteFormats" />, <see cref="NoNamespace.pasteFormulas" />, <see cref="NoNamespace.pasteNumberFormats" />, <see cref="NoNamespace.pasteValues" />, <see cref="NoNamespace.rowColShift" />, <see cref="NoNamespace.splitAll" />, <see cref="NoNamespace.splitFirst" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MetadataType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName metadataType = x + "metadataType";

        /// <summary>
        /// Represents the x:metadataTypes XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="metadata" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="metadataType" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MetadataTypes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName metadataTypes = x + "metadataTypes";

        /// <summary>
        /// Represents the x:mp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mps" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.field" />, <see cref="NoNamespace.level" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.nameLen" />, <see cref="NoNamespace.pLen" />, <see cref="NoNamespace.pPos" />, <see cref="NoNamespace.showAsCaption" />, <see cref="NoNamespace.showCell" />, <see cref="NoNamespace.showTip" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MemberProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mp = x + "mp";

        /// <summary>
        /// Represents the x:mpMap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheField" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MemberPropertiesMap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mpMap = x + "mpMap";

        /// <summary>
        /// Represents the x:mps XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotHierarchy" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="mp" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MemberProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mps = x + "mps";

        /// <summary>
        /// Represents the x:mruColors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colors" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MruColors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mruColors = x + "mruColors";

        /// <summary>
        /// Represents the x:ms XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mdx" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="n" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.c" />, <see cref="NoNamespace.ns" />, <see cref="NoNamespace.o" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MdxSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ms = x + "ms";

        /// <summary>
        /// Represents the x:n XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="entries" />, <see cref="groupItems" />, <see cref="ms" />, <see cref="r" />, <see cref="sharedItems" />, <see cref="t" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tpls" />, <see cref="x_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.b" />, <see cref="NoNamespace.bc" />, <see cref="NoNamespace.c" />, <see cref="NoNamespace.cp" />, <see cref="NoNamespace.f" />, <see cref="NoNamespace.fc" />, <see cref="NoNamespace.i" />, <see cref="NoNamespace.@in" />, <see cref="NoNamespace.s" />, <see cref="NoNamespace.st" />, <see cref="NoNamespace.u" />, <see cref="NoNamespace.un" />, <see cref="NoNamespace.v" />, <see cref="NoNamespace.x" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NameIndex, NumberItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName n = x + "n";

        /// <summary>
        /// Represents the x:name XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName name = x + "name";

        /// <summary>
        /// Represents the x:nc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rcc" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="f" />, <see cref="@is" />, <see cref="v" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cm" />, <see cref="NoNamespace.ph" />, <see cref="NoNamespace.r" />, <see cref="NoNamespace.s" />, <see cref="NoNamespace.t" />, <see cref="NoNamespace.vm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NewCell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nc = x + "nc";

        /// <summary>
        /// Represents the x:ndxf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rcc" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alignment" />, <see cref="border" />, <see cref="extLst" />, <see cref="fill" />, <see cref="font" />, <see cref="numFmt" />, <see cref="protection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NewDifferentialFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ndxf = x + "ndxf";

        /// <summary>
        /// Represents the x:numFmt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dxf" />, <see cref="ndxf" />, <see cref="numFmts" />, <see cref="odxf" />, <see cref="X14.dxf" />, <see cref="XNSV.dxf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.formatCode" />, <see cref="NoNamespace.numFmtId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numFmt = x + "numFmt";

        /// <summary>
        /// Represents the x:numFmts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="numFmt" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NumberingFormats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName numFmts = x + "numFmts";

        /// <summary>
        /// Represents the x:objectPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oleObject" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.altText" />, <see cref="NoNamespace.autoFill" />, <see cref="NoNamespace.autoLine" />, <see cref="NoNamespace.autoPict" />, <see cref="NoNamespace.dde" />, <see cref="NoNamespace.defaultSize" />, <see cref="NoNamespace.disabled" />, <see cref="NoNamespace.locked" />, <see cref="NoNamespace.macro" />, <see cref="NoNamespace.print" />, <see cref="R.id" />, <see cref="NoNamespace.uiObject" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EmbeddedObjectProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName objectPr = x + "objectPr";

        /// <summary>
        /// Represents the x:oc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rcc" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="f" />, <see cref="@is" />, <see cref="v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OldCell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oc = x + "oc";

        /// <summary>
        /// Represents the x:oddFooter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OddFooter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oddFooter = x + "oddFooter";

        /// <summary>
        /// Represents the x:oddHeader XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headerFooter" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OddHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oddHeader = x + "oddHeader";

        /// <summary>
        /// Represents the x:odxf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rcc" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alignment" />, <see cref="border" />, <see cref="extLst" />, <see cref="fill" />, <see cref="font" />, <see cref="numFmt" />, <see cref="protection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OldDifferentialFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName odxf = x + "odxf";

        /// <summary>
        /// Represents the x:olapPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.local" />, <see cref="NoNamespace.localConnection" />, <see cref="NoNamespace.localRefresh" />, <see cref="NoNamespace.rowDrillCount" />, <see cref="NoNamespace.sendLocale" />, <see cref="NoNamespace.serverFill" />, <see cref="NoNamespace.serverFont" />, <see cref="NoNamespace.serverFontColor" />, <see cref="NoNamespace.serverNumberFormat" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OlapProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName olapPr = x + "olapPr";

        /// <summary>
        /// Represents the x:oldFormula XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rdn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OldFormula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oldFormula = x + "oldFormula";

        /// <summary>
        /// Represents the x:oleItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oleItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.advise" />, <see cref="NoNamespace.icon" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.preferPic" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oleItem = x + "oleItem";

        /// <summary>
        /// Represents the x:oleItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oleLink" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="oleItem" />, <see cref="X14.oleItem" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oleItems = x + "oleItems";

        /// <summary>
        /// Represents the x:oleLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="externalLink" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="oleItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.progId" />, <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oleLink = x + "oleLink";

        /// <summary>
        /// Represents the x:oleObject XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oleObjects" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="objectPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoLoad" />, <see cref="NoNamespace.dvAspect" />, <see cref="NoNamespace.link" />, <see cref="NoNamespace.oleUpdate" />, <see cref="NoNamespace.progId" />, <see cref="R.id" />, <see cref="NoNamespace.shapeId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oleObject = x + "oleObject";

        /// <summary>
        /// Represents the x:oleObjects XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="oleObject" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleObjects.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oleObjects = x + "oleObjects";

        /// <summary>
        /// Represents the x:oleSize XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oleSize = x + "oleSize";

        /// <summary>
        /// Represents the x:outline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Outline.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName outline = x + "outline";

        /// <summary>
        /// Represents the x:outlinePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sheetPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.applyStyles" />, <see cref="NoNamespace.showOutlineSymbols" />, <see cref="NoNamespace.summaryBelow" />, <see cref="NoNamespace.summaryRight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OutlineProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName outlinePr = x + "outlinePr";

        /// <summary>
        /// Represents the x:p XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mdx" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.n" />, <see cref="NoNamespace.np" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MdxMemberProp.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName p = x + "p";

        /// <summary>
        /// Represents the x:page XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pages" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pageItem" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Page.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName page = x + "page";

        /// <summary>
        /// Represents the x:pageField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pageFields" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cap" />, <see cref="NoNamespace.fld" />, <see cref="NoNamespace.hier" />, <see cref="NoNamespace.item" />, <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageField = x + "pageField";

        /// <summary>
        /// Represents the x:pageFields XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pageField" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageFields.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageFields = x + "pageFields";

        /// <summary>
        /// Represents the x:pageItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="page" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageItem = x + "pageItem";

        /// <summary>
        /// Represents the x:pageMargins XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="customSheetView" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.bottom" />, <see cref="NoNamespace.footer" />, <see cref="NoNamespace.header" />, <see cref="NoNamespace.left" />, <see cref="NoNamespace.right" />, <see cref="NoNamespace.top" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageMargins.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageMargins = x + "pageMargins";

        /// <summary>
        /// Represents the x:pages XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="consolidation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="page" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Pages.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pages = x + "pages";

        /// <summary>
        /// Represents the x:pageSetup XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="customSheetView" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.blackAndWhite" />, <see cref="NoNamespace.cellComments" />, <see cref="NoNamespace.copies" />, <see cref="NoNamespace.draft" />, <see cref="NoNamespace.errors" />, <see cref="NoNamespace.firstPageNumber" />, <see cref="NoNamespace.fitToHeight" />, <see cref="NoNamespace.fitToWidth" />, <see cref="NoNamespace.horizontalDpi" />, <see cref="NoNamespace.orientation" />, <see cref="NoNamespace.pageOrder" />, <see cref="NoNamespace.paperSize" />, <see cref="R.id" />, <see cref="NoNamespace.scale" />, <see cref="NoNamespace.useFirstPageNumber" />, <see cref="NoNamespace.usePrinterDefaults" />, <see cref="NoNamespace.verticalDpi" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartSheetPageSetup, PageSetup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageSetup = x + "pageSetup";

        /// <summary>
        /// Represents the x:pageSetUpPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sheetPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoPageBreaks" />, <see cref="NoNamespace.fitToPage" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PageSetupProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pageSetUpPr = x + "pageSetUpPr";

        /// <summary>
        /// Represents the x:pane XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customSheetView" />, <see cref="sheetView" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.activePane" />, <see cref="NoNamespace.state" />, <see cref="NoNamespace.topLeftCell" />, <see cref="NoNamespace.xSplit" />, <see cref="NoNamespace.ySplit" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Pane.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pane = x + "pane";

        /// <summary>
        /// Represents the x:parameter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="parameters" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.boolean" />, <see cref="NoNamespace.cell" />, <see cref="NoNamespace.@double" />, <see cref="NoNamespace.integer" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.parameterType" />, <see cref="NoNamespace.prompt" />, <see cref="NoNamespace.refreshOnChange" />, <see cref="NoNamespace.sqlType" />, <see cref="NoNamespace.@string" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Parameter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName parameter = x + "parameter";

        /// <summary>
        /// Represents the x:parameters XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="parameter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Parameters.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName parameters = x + "parameters";

        /// <summary>
        /// Represents the x:patternFill XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fill" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bgColor" />, <see cref="fgColor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.patternType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PatternFill.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName patternFill = x + "patternFill";

        /// <summary>
        /// Represents the x:phoneticPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@is" />, <see cref="si" />, <see cref="text" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignment" />, <see cref="NoNamespace.fontId" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PhoneticProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName phoneticPr = x + "phoneticPr";

        /// <summary>
        /// Represents the x:picture XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Picture.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName picture = x + "picture";

        /// <summary>
        /// Represents the x:pivotArea XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="autoSortScope" />, <see cref="calculatedItem" />, <see cref="chartFormat" />, <see cref="format" />, <see cref="pivotAreas" />, <see cref="pivotSelection" />, <see cref="X14.pivotAreas" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="references" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.axis" />, <see cref="NoNamespace.cacheIndex" />, <see cref="NoNamespace.collapsedLevelsAreSubtotals" />, <see cref="NoNamespace.dataOnly" />, <see cref="NoNamespace.field" />, <see cref="NoNamespace.fieldPosition" />, <see cref="NoNamespace.grandCol" />, <see cref="NoNamespace.grandRow" />, <see cref="NoNamespace.labelOnly" />, <see cref="NoNamespace.offset" />, <see cref="NoNamespace.outline" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotArea.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotArea = x + "pivotArea";

        /// <summary>
        /// Represents the x:pivotAreas XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="conditionalFormat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotArea" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotAreas.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotAreas = x + "pivotAreas";

        /// <summary>
        /// Represents the x:pivotCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCaches" />, <see cref="X14.pivotCaches" />, <see cref="X15.pivotCaches" />, <see cref="X15.timelineCachePivotCaches" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cacheId" />, <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCache = x + "pivotCache";

        /// <summary>
        /// Represents the x:pivotCacheDefinition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="cacheFields" />, <see cref="cacheHierarchies" />, <see cref="cacheSource" />, <see cref="calculatedItems" />, <see cref="calculatedMembers" />, <see cref="dimensions" />, <see cref="extLst" />, <see cref="kpis" />, <see cref="maps" />, <see cref="measureGroups" />, <see cref="tupleCache" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.backgroundQuery" />, <see cref="NoNamespace.createdVersion" />, <see cref="NoNamespace.enableRefresh" />, <see cref="NoNamespace.invalid" />, <see cref="NoNamespace.minRefreshableVersion" />, <see cref="NoNamespace.missingItemsLimit" />, <see cref="NoNamespace.optimizeMemory" />, <see cref="R.id" />, <see cref="NoNamespace.recordCount" />, <see cref="NoNamespace.refreshedBy" />, <see cref="NoNamespace.refreshedDate" />, <see cref="NoNamespace.refreshedDateIso" />, <see cref="NoNamespace.refreshedVersion" />, <see cref="NoNamespace.refreshOnLoad" />, <see cref="NoNamespace.saveData" />, <see cref="NoNamespace.supportAdvancedDrill" />, <see cref="NoNamespace.supportSubquery" />, <see cref="NoNamespace.tupleCache" />, <see cref="NoNamespace.upgradeOnRefresh" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCacheDefinition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCacheDefinition = x + "pivotCacheDefinition";

        /// <summary>
        /// Represents the x:pivotCacheRecords XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="r" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCacheRecords.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCacheRecords = x + "pivotCacheRecords";

        /// <summary>
        /// Represents the x:pivotCaches XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotCache" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCaches.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCaches = x + "pivotCaches";

        /// <summary>
        /// Represents the x:pivotField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotFields" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="autoSortScope" />, <see cref="extLst" />, <see cref="items" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allDrilled" />, <see cref="NoNamespace.autoShow" />, <see cref="NoNamespace.avgSubtotal" />, <see cref="NoNamespace.axis" />, <see cref="NoNamespace.compact" />, <see cref="NoNamespace.countASubtotal" />, <see cref="NoNamespace.countSubtotal" />, <see cref="NoNamespace.dataField" />, <see cref="NoNamespace.dataSourceSort" />, <see cref="NoNamespace.defaultAttributeDrillState" />, <see cref="NoNamespace.defaultSubtotal" />, <see cref="NoNamespace.dragOff" />, <see cref="NoNamespace.dragToCol" />, <see cref="NoNamespace.dragToData" />, <see cref="NoNamespace.dragToPage" />, <see cref="NoNamespace.dragToRow" />, <see cref="NoNamespace.hiddenLevel" />, <see cref="NoNamespace.hideNewItems" />, <see cref="NoNamespace.includeNewItemsInFilter" />, <see cref="NoNamespace.insertBlankRow" />, <see cref="NoNamespace.insertPageBreak" />, <see cref="NoNamespace.itemPageCount" />, <see cref="NoNamespace.maxSubtotal" />, <see cref="NoNamespace.measureFilter" />, <see cref="NoNamespace.minSubtotal" />, <see cref="NoNamespace.multipleItemSelectionAllowed" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.nonAutoSortDefault" />, <see cref="NoNamespace.numFmtId" />, <see cref="NoNamespace.outline" />, <see cref="NoNamespace.productSubtotal" />, <see cref="NoNamespace.rankBy" />, <see cref="NoNamespace.serverField" />, <see cref="NoNamespace.showAll" />, <see cref="NoNamespace.showDropDowns" />, <see cref="NoNamespace.showPropAsCaption" />, <see cref="NoNamespace.showPropCell" />, <see cref="NoNamespace.showPropTip" />, <see cref="NoNamespace.sortType" />, <see cref="NoNamespace.stdDevPSubtotal" />, <see cref="NoNamespace.stdDevSubtotal" />, <see cref="NoNamespace.subtotalCaption" />, <see cref="NoNamespace.subtotalTop" />, <see cref="NoNamespace.sumSubtotal" />, <see cref="NoNamespace.topAutoShow" />, <see cref="NoNamespace.uniqueMemberProperty" />, <see cref="NoNamespace.varPSubtotal" />, <see cref="NoNamespace.varSubtotal" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotField = x + "pivotField";

        /// <summary>
        /// Represents the x:pivotFields XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotField" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotFields.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotFields = x + "pivotFields";

        /// <summary>
        /// Represents the x:pivotHierarchies XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotHierarchy" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotHierarchies.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotHierarchies = x + "pivotHierarchies";

        /// <summary>
        /// Represents the x:pivotHierarchy XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotHierarchies" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="members" />, <see cref="mps" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.caption" />, <see cref="NoNamespace.dragOff" />, <see cref="NoNamespace.dragToCol" />, <see cref="NoNamespace.dragToData" />, <see cref="NoNamespace.dragToPage" />, <see cref="NoNamespace.dragToRow" />, <see cref="NoNamespace.includeNewItemsInFilter" />, <see cref="NoNamespace.multipleItemSelectionAllowed" />, <see cref="NoNamespace.outline" />, <see cref="NoNamespace.showInFieldList" />, <see cref="NoNamespace.subtotalTop" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotHierarchy.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotHierarchy = x + "pivotHierarchy";

        /// <summary>
        /// Represents the x:pivotSelection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sheetView" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotArea" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.activeCol" />, <see cref="NoNamespace.activeRow" />, <see cref="NoNamespace.axis" />, <see cref="NoNamespace.click" />, <see cref="NoNamespace.count" />, <see cref="NoNamespace.data" />, <see cref="NoNamespace.dimension" />, <see cref="NoNamespace.extendable" />, <see cref="NoNamespace.label" />, <see cref="NoNamespace.max" />, <see cref="NoNamespace.min" />, <see cref="NoNamespace.pane" />, <see cref="NoNamespace.previousCol" />, <see cref="NoNamespace.previousRow" />, <see cref="R.id" />, <see cref="NoNamespace.showHeader" />, <see cref="NoNamespace.start" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotSelection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotSelection = x + "pivotSelection";

        /// <summary>
        /// Represents the x:pivotTableDefinition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="chartFormats" />, <see cref="colFields" />, <see cref="colHierarchiesUsage" />, <see cref="colItems" />, <see cref="conditionalFormats" />, <see cref="dataFields" />, <see cref="extLst" />, <see cref="filters" />, <see cref="formats" />, <see cref="location" />, <see cref="pageFields" />, <see cref="pivotFields" />, <see cref="pivotHierarchies" />, <see cref="pivotTableStyleInfo" />, <see cref="rowFields" />, <see cref="rowHierarchiesUsage" />, <see cref="rowItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.applyAlignmentFormats" />, <see cref="NoNamespace.applyBorderFormats" />, <see cref="NoNamespace.applyFontFormats" />, <see cref="NoNamespace.applyNumberFormats" />, <see cref="NoNamespace.applyPatternFormats" />, <see cref="NoNamespace.applyWidthHeightFormats" />, <see cref="NoNamespace.asteriskTotals" />, <see cref="NoNamespace.autoFormatId" />, <see cref="NoNamespace.cacheId" />, <see cref="NoNamespace.chartFormat" />, <see cref="NoNamespace.colGrandTotals" />, <see cref="NoNamespace.colHeaderCaption" />, <see cref="NoNamespace.compact" />, <see cref="NoNamespace.compactData" />, <see cref="NoNamespace.createdVersion" />, <see cref="NoNamespace.customListSort" />, <see cref="NoNamespace.dataCaption" />, <see cref="NoNamespace.dataOnRows" />, <see cref="NoNamespace.dataPosition" />, <see cref="NoNamespace.disableFieldList" />, <see cref="NoNamespace.editData" />, <see cref="NoNamespace.enableDrill" />, <see cref="NoNamespace.enableFieldProperties" />, <see cref="NoNamespace.enableWizard" />, <see cref="NoNamespace.errorCaption" />, <see cref="NoNamespace.fieldListSortAscending" />, <see cref="NoNamespace.fieldPrintTitles" />, <see cref="NoNamespace.grandTotalCaption" />, <see cref="NoNamespace.gridDropZones" />, <see cref="NoNamespace.immersive" />, <see cref="NoNamespace.indent" />, <see cref="NoNamespace.itemPrintTitles" />, <see cref="NoNamespace.mdxSubqueries" />, <see cref="NoNamespace.mergeItem" />, <see cref="NoNamespace.minRefreshableVersion" />, <see cref="NoNamespace.missingCaption" />, <see cref="NoNamespace.multipleFieldFilters" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.outline" />, <see cref="NoNamespace.outlineData" />, <see cref="NoNamespace.pageOverThenDown" />, <see cref="NoNamespace.pageStyle" />, <see cref="NoNamespace.pageWrap" />, <see cref="NoNamespace.pivotTableStyle" />, <see cref="NoNamespace.preserveFormatting" />, <see cref="NoNamespace.printDrill" />, <see cref="NoNamespace.published" />, <see cref="NoNamespace.rowGrandTotals" />, <see cref="NoNamespace.rowHeaderCaption" />, <see cref="NoNamespace.showCalcMbrs" />, <see cref="NoNamespace.showDataDropDown" />, <see cref="NoNamespace.showDataTips" />, <see cref="NoNamespace.showDrill" />, <see cref="NoNamespace.showDropZones" />, <see cref="NoNamespace.showEmptyCol" />, <see cref="NoNamespace.showEmptyRow" />, <see cref="NoNamespace.showError" />, <see cref="NoNamespace.showHeaders" />, <see cref="NoNamespace.showItems" />, <see cref="NoNamespace.showMemberPropertyTips" />, <see cref="NoNamespace.showMissing" />, <see cref="NoNamespace.showMultipleLabel" />, <see cref="NoNamespace.subtotalHiddenItems" />, <see cref="NoNamespace.tag" />, <see cref="NoNamespace.updatedVersion" />, <see cref="NoNamespace.useAutoFormatting" />, <see cref="NoNamespace.vacatedStyle" />, <see cref="NoNamespace.visualTotals" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotTableDefinition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTableDefinition = x + "pivotTableDefinition";

        /// <summary>
        /// Represents the x:pivotTableStyleInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.showColHeaders" />, <see cref="NoNamespace.showColStripes" />, <see cref="NoNamespace.showLastColumn" />, <see cref="NoNamespace.showRowHeaders" />, <see cref="NoNamespace.showRowStripes" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotTableStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTableStyleInfo = x + "pivotTableStyleInfo";

        /// <summary>
        /// Represents the x:printOptions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customSheetView" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.gridLines" />, <see cref="NoNamespace.gridLinesSet" />, <see cref="NoNamespace.headings" />, <see cref="NoNamespace.horizontalCentered" />, <see cref="NoNamespace.verticalCentered" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PrintOptions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName printOptions = x + "printOptions";

        /// <summary>
        /// Represents the x:protectedRange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="protectedRanges" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.algorithmName" />, <see cref="NoNamespace.hashValue" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.password" />, <see cref="NoNamespace.saltValue" />, <see cref="NoNamespace.securityDescriptor" />, <see cref="NoNamespace.spinCount" />, <see cref="NoNamespace.sqref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ProtectedRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName protectedRange = x + "protectedRange";

        /// <summary>
        /// Represents the x:protectedRanges XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="protectedRange" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ProtectedRanges.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName protectedRanges = x + "protectedRanges";

        /// <summary>
        /// Represents the x:protection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dxf" />, <see cref="ndxf" />, <see cref="odxf" />, <see cref="xf" />, <see cref="X14.dxf" />, <see cref="XNSV.dxf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.locked" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Protection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName protection = x + "protection";

        /// <summary>
        /// Represents the x:query XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="queryCache" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tpls" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mdx" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Query.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName query = x + "query";

        /// <summary>
        /// Represents the x:queryCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tupleCache" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="query" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: QueryCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName queryCache = x + "queryCache";

        /// <summary>
        /// Represents the x:queryTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="queryTableRefresh" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.adjustColumnWidth" />, <see cref="NoNamespace.applyAlignmentFormats" />, <see cref="NoNamespace.applyBorderFormats" />, <see cref="NoNamespace.applyFontFormats" />, <see cref="NoNamespace.applyNumberFormats" />, <see cref="NoNamespace.applyPatternFormats" />, <see cref="NoNamespace.applyWidthHeightFormats" />, <see cref="NoNamespace.autoFormatId" />, <see cref="NoNamespace.backgroundRefresh" />, <see cref="NoNamespace.connectionId" />, <see cref="NoNamespace.disableEdit" />, <see cref="NoNamespace.disableRefresh" />, <see cref="NoNamespace.fillFormulas" />, <see cref="NoNamespace.firstBackgroundRefresh" />, <see cref="NoNamespace.growShrinkType" />, <see cref="NoNamespace.headers" />, <see cref="NoNamespace.intermediate" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.preserveFormatting" />, <see cref="NoNamespace.refreshOnLoad" />, <see cref="NoNamespace.removeDataOnSave" />, <see cref="NoNamespace.rowNumbers" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: QueryTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName queryTable = x + "queryTable";

        /// <summary>
        /// Represents the x:queryTableDeletedFields XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="queryTableRefresh" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="deletedField" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: QueryTableDeletedFields.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName queryTableDeletedFields = x + "queryTableDeletedFields";

        /// <summary>
        /// Represents the x:queryTableField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="queryTableFields" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.clipped" />, <see cref="NoNamespace.dataBound" />, <see cref="NoNamespace.fillFormulas" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.rowNumbers" />, <see cref="NoNamespace.tableColumnId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: QueryTableField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName queryTableField = x + "queryTableField";

        /// <summary>
        /// Represents the x:queryTableFields XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="queryTableRefresh" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="queryTableField" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: QueryTableFields.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName queryTableFields = x + "queryTableFields";

        /// <summary>
        /// Represents the x:queryTableRefresh XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="queryTable" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="queryTableDeletedFields" />, <see cref="queryTableFields" />, <see cref="sortState" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fieldIdWrapped" />, <see cref="NoNamespace.headersInLastRefresh" />, <see cref="NoNamespace.minimumVersion" />, <see cref="NoNamespace.nextId" />, <see cref="NoNamespace.preserveSortFilterLayout" />, <see cref="NoNamespace.unboundColumnsLeft" />, <see cref="NoNamespace.unboundColumnsRight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: QueryTableRefresh.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName queryTableRefresh = x + "queryTableRefresh";

        /// <summary>
        /// Represents the x:r XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@is" />, <see cref="pivotCacheRecords" />, <see cref="si" />, <see cref="text" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="b" />, <see cref="d" />, <see cref="e" />, <see cref="m" />, <see cref="n" />, <see cref="rPr" />, <see cref="s" />, <see cref="t" />, <see cref="x_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCacheRecord, Run.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName r = x + "r";

        /// <summary>
        /// Represents the x:raf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.applyAlignmentFormats" />, <see cref="NoNamespace.applyBorderFormats" />, <see cref="NoNamespace.applyFontFormats" />, <see cref="NoNamespace.applyNumberFormats" />, <see cref="NoNamespace.applyPatternFormats" />, <see cref="NoNamespace.applyWidthHeightFormats" />, <see cref="NoNamespace.autoFormatId" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.sheetId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionAutoFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName raf = x + "raf";

        /// <summary>
        /// Represents the x:rangePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="fieldGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoEnd" />, <see cref="NoNamespace.autoStart" />, <see cref="NoNamespace.endDate" />, <see cref="NoNamespace.endNum" />, <see cref="NoNamespace.groupBy" />, <see cref="NoNamespace.groupInterval" />, <see cref="NoNamespace.startDate" />, <see cref="NoNamespace.startNum" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RangeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rangePr = x + "rangePr";

        /// <summary>
        /// Represents the x:rangeSet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rangeSets" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.i1" />, <see cref="NoNamespace.i2" />, <see cref="NoNamespace.i3" />, <see cref="NoNamespace.i4" />, <see cref="NoNamespace.name" />, <see cref="R.id" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.sheet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RangeSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rangeSet = x + "rangeSet";

        /// <summary>
        /// Represents the x:rangeSets XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="consolidation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rangeSet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RangeSets.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rangeSets = x + "rangeSets";

        /// <summary>
        /// Represents the x:rc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bk" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.t" />, <see cref="NoNamespace.v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MetadataRecord.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rc = x + "rc";

        /// <summary>
        /// Represents the x:rcc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />, <see cref="rm" />, <see cref="rrc" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="nc" />, <see cref="ndxf" />, <see cref="oc" />, <see cref="odxf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dxf" />, <see cref="NoNamespace.endOfListFormulaUpdate" />, <see cref="NoNamespace.numFmtId" />, <see cref="NoNamespace.odxf" />, <see cref="NoNamespace.oldPh" />, <see cref="NoNamespace.oldQuotePrefix" />, <see cref="NoNamespace.ph" />, <see cref="NoNamespace.quotePrefix" />, <see cref="NoNamespace.ra" />, <see cref="NoNamespace.rId" />, <see cref="NoNamespace.s" />, <see cref="NoNamespace.sId" />, <see cref="NoNamespace.ua" />, <see cref="NoNamespace.xfDxf" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionCellChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rcc = x + "rcc";

        /// <summary>
        /// Represents the x:rcft XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.ra" />, <see cref="NoNamespace.rId" />, <see cref="NoNamespace.sheetId" />, <see cref="NoNamespace.ua" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionConflict.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rcft = x + "rcft";

        /// <summary>
        /// Represents the x:rcmt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.action" />, <see cref="NoNamespace.alwaysShow" />, <see cref="NoNamespace.author" />, <see cref="NoNamespace.cell" />, <see cref="NoNamespace.guid" />, <see cref="NoNamespace.hiddenColumn" />, <see cref="NoNamespace.hiddenRow" />, <see cref="NoNamespace.newLength" />, <see cref="NoNamespace.old" />, <see cref="NoNamespace.oldLength" />, <see cref="NoNamespace.sheetId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionComment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rcmt = x + "rcmt";

        /// <summary>
        /// Represents the x:rcv XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.action" />, <see cref="NoNamespace.guid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionCustomView.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rcv = x + "rcv";

        /// <summary>
        /// Represents the x:rdn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="formula" />, <see cref="oldFormula" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.comment" />, <see cref="NoNamespace.customMenu" />, <see cref="NoNamespace.customView" />, <see cref="NoNamespace.description" />, <see cref="NoNamespace.function" />, <see cref="NoNamespace.functionGroupId" />, <see cref="NoNamespace.help" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.localSheetId" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.oldComment" />, <see cref="NoNamespace.oldCustomMenu" />, <see cref="NoNamespace.oldDescription" />, <see cref="NoNamespace.oldFunction" />, <see cref="NoNamespace.oldFunctionGroupId" />, <see cref="NoNamespace.oldHelp" />, <see cref="NoNamespace.oldHidden" />, <see cref="NoNamespace.oldShortcutKey" />, <see cref="NoNamespace.oldStatusBar" />, <see cref="NoNamespace.ra" />, <see cref="NoNamespace.rId" />, <see cref="NoNamespace.shortcutKey" />, <see cref="NoNamespace.statusBar" />, <see cref="NoNamespace.ua" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionDefinedName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rdn = x + "rdn";

        /// <summary>
        /// Represents the x:reference XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="references" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="x_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.avgSubtotal" />, <see cref="NoNamespace.byPosition" />, <see cref="NoNamespace.count" />, <see cref="NoNamespace.countASubtotal" />, <see cref="NoNamespace.countSubtotal" />, <see cref="NoNamespace.defaultSubtotal" />, <see cref="NoNamespace.field" />, <see cref="NoNamespace.maxSubtotal" />, <see cref="NoNamespace.minSubtotal" />, <see cref="NoNamespace.productSubtotal" />, <see cref="NoNamespace.relative" />, <see cref="NoNamespace.selected" />, <see cref="NoNamespace.stdDevPSubtotal" />, <see cref="NoNamespace.stdDevSubtotal" />, <see cref="NoNamespace.sumSubtotal" />, <see cref="NoNamespace.varPSubtotal" />, <see cref="NoNamespace.varSubtotal" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotAreaReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName reference = x + "reference";

        /// <summary>
        /// Represents the x:references XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotArea" />, <see cref="X14.pivotArea" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="reference" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotAreaReferences.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName references = x + "references";

        /// <summary>
        /// Represents the x:reviewed XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="reviewedList" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.rId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Reviewed.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName reviewed = x + "reviewed";

        /// <summary>
        /// Represents the x:reviewedList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="header" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="reviewed" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ReviewedList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName reviewedList = x + "reviewedList";

        /// <summary>
        /// Represents the x:revisions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="raf" />, <see cref="rcc" />, <see cref="rcft" />, <see cref="rcmt" />, <see cref="rcv" />, <see cref="rdn" />, <see cref="rfmt" />, <see cref="ris" />, <see cref="rm" />, <see cref="rqt" />, <see cref="rrc" />, <see cref="rsnm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Revisions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName revisions = x + "revisions";

        /// <summary>
        /// Represents the x:rfmt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />, <see cref="rm" />, <see cref="rrc" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dxf" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.length" />, <see cref="NoNamespace.s" />, <see cref="NoNamespace.sheetId" />, <see cref="NoNamespace.sqref" />, <see cref="NoNamespace.start" />, <see cref="NoNamespace.xfDxf" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rfmt = x + "rfmt";

        /// <summary>
        /// Represents the x:rFont XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RunFont.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rFont = x + "rFont";

        /// <summary>
        /// Represents the x:rgbColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="indexedColors" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.rgb" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RgbColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rgbColor = x + "rgbColor";

        /// <summary>
        /// Represents the x:right XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="border" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RightBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName right = x + "right";

        /// <summary>
        /// Represents the x:ris XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.ra" />, <see cref="NoNamespace.rId" />, <see cref="NoNamespace.sheetId" />, <see cref="NoNamespace.sheetPosition" />, <see cref="NoNamespace.ua" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionInsertSheet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ris = x + "ris";

        /// <summary>
        /// Represents the x:rm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rcc" />, <see cref="rfmt" />, <see cref="undo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.destination" />, <see cref="NoNamespace.ra" />, <see cref="NoNamespace.rId" />, <see cref="NoNamespace.sheetId" />, <see cref="NoNamespace.source" />, <see cref="NoNamespace.sourceSheetId" />, <see cref="NoNamespace.ua" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionMove.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rm = x + "rm";

        /// <summary>
        /// Represents the x:row XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sheetData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="c" />, <see cref="cell" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.collapsed" />, <see cref="NoNamespace.customFormat" />, <see cref="NoNamespace.customHeight" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.ht" />, <see cref="NoNamespace.outlineLevel" />, <see cref="NoNamespace.ph" />, <see cref="NoNamespace.r" />, <see cref="NoNamespace.s" />, <see cref="NoNamespace.spans" />, <see cref="NoNamespace.thickBot" />, <see cref="NoNamespace.thickTop" />, <see cref="X14AC.dyDescent" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalRow, Row.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName row = x + "row";

        /// <summary>
        /// Represents the x:rowBreaks XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customSheetView" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="brk" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowBreaks.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rowBreaks = x + "rowBreaks";

        /// <summary>
        /// Represents the x:rowFields XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="field" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowFields.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rowFields = x + "rowFields";

        /// <summary>
        /// Represents the x:rowHierarchiesUsage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rowHierarchyUsage" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowHierarchiesUsage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rowHierarchiesUsage = x + "rowHierarchiesUsage";

        /// <summary>
        /// Represents the x:rowHierarchyUsage XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rowHierarchiesUsage" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowHierarchyUsage.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rowHierarchyUsage = x + "rowHierarchyUsage";

        /// <summary>
        /// Represents the x:rowItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="i" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rowItems = x + "rowItems";

        /// <summary>
        /// Represents the x:rPh XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@is" />, <see cref="si" />, <see cref="text" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="t" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.eb" />, <see cref="NoNamespace.sb" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PhoneticRun.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rPh = x + "rPh";

        /// <summary>
        /// Represents the x:rPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="r" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="b" />, <see cref="charset" />, <see cref="color" />, <see cref="condense" />, <see cref="extend" />, <see cref="family" />, <see cref="i" />, <see cref="outline" />, <see cref="rFont" />, <see cref="scheme" />, <see cref="shadow" />, <see cref="strike" />, <see cref="sz" />, <see cref="u" />, <see cref="vertAlign" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RunProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rPr = x + "rPr";

        /// <summary>
        /// Represents the x:rqt XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fieldId" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.sheetId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionQueryTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rqt = x + "rqt";

        /// <summary>
        /// Represents the x:rrc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rcc" />, <see cref="rfmt" />, <see cref="undo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.action" />, <see cref="NoNamespace.edge" />, <see cref="NoNamespace.eol" />, <see cref="NoNamespace.ra" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.rId" />, <see cref="NoNamespace.sId" />, <see cref="NoNamespace.ua" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionRowColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rrc = x + "rrc";

        /// <summary>
        /// Represents the x:rsnm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="revisions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.newName" />, <see cref="NoNamespace.oldName" />, <see cref="NoNamespace.ra" />, <see cref="NoNamespace.rId" />, <see cref="NoNamespace.sheetId" />, <see cref="NoNamespace.ua" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RevisionSheetName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rsnm = x + "rsnm";

        /// <summary>
        /// Represents the x:s XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="entries" />, <see cref="groupItems" />, <see cref="metadataStrings" />, <see cref="r" />, <see cref="sharedItems" />, <see cref="tables" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tpls" />, <see cref="x_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.b" />, <see cref="NoNamespace.bc" />, <see cref="NoNamespace.c" />, <see cref="NoNamespace.cp" />, <see cref="NoNamespace.f" />, <see cref="NoNamespace.fc" />, <see cref="NoNamespace.i" />, <see cref="NoNamespace.@in" />, <see cref="NoNamespace.st" />, <see cref="NoNamespace.u" />, <see cref="NoNamespace.un" />, <see cref="NoNamespace.v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CharacterValue, StringItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName s = x + "s";

        /// <summary>
        /// Represents the x:scenario XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="scenarios" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="inputCells" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.comment" />, <see cref="NoNamespace.count" />, <see cref="NoNamespace.hidden" />, <see cref="NoNamespace.locked" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.user" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Scenario.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scenario = x + "scenario";

        /// <summary>
        /// Represents the x:scenarios XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="scenario" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.current" />, <see cref="NoNamespace.show" />, <see cref="NoNamespace.sqref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Scenarios.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scenarios = x + "scenarios";

        /// <summary>
        /// Represents the x:Schema XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="MapInfo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.ID_" />, <see cref="NoNamespace.Namespace" />, <see cref="NoNamespace.SchemaRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Schema.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Schema = x + "Schema";

        /// <summary>
        /// Represents the x:scheme XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontScheme.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName scheme = x + "scheme";

        /// <summary>
        /// Represents the x:selection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customSheetView" />, <see cref="sheetView" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.activeCell" />, <see cref="NoNamespace.activeCellId" />, <see cref="NoNamespace.pane" />, <see cref="NoNamespace.sqref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Selection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName selection = x + "selection";

        /// <summary>
        /// Represents the x:serverFormat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="serverFormats" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.culture" />, <see cref="NoNamespace.format" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ServerFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName serverFormat = x + "serverFormat";

        /// <summary>
        /// Represents the x:serverFormats XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tupleCache" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="serverFormat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ServerFormats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName serverFormats = x + "serverFormats";

        /// <summary>
        /// Represents the x:set XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sets" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sortByTuple" />, <see cref="tpls" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.maxRank" />, <see cref="NoNamespace.queryFailed" />, <see cref="NoNamespace.setDefinition" />, <see cref="NoNamespace.sortType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TupleSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName set = x + "set";

        /// <summary>
        /// Represents the x:sets XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tupleCache" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="set" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Sets.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sets = x + "sets";

        /// <summary>
        /// Represents the x:shadow XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Shadow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName shadow = x + "shadow";

        /// <summary>
        /// Represents the x:sharedItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheField" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="b" />, <see cref="d" />, <see cref="e" />, <see cref="m" />, <see cref="n" />, <see cref="s" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.containsBlank" />, <see cref="NoNamespace.containsDate" />, <see cref="NoNamespace.containsInteger" />, <see cref="NoNamespace.containsMixedTypes" />, <see cref="NoNamespace.containsNonDate" />, <see cref="NoNamespace.containsNumber" />, <see cref="NoNamespace.containsSemiMixedTypes" />, <see cref="NoNamespace.containsString" />, <see cref="NoNamespace.count" />, <see cref="NoNamespace.longText" />, <see cref="NoNamespace.maxDate" />, <see cref="NoNamespace.maxValue" />, <see cref="NoNamespace.minDate" />, <see cref="NoNamespace.minValue" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SharedItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sharedItems = x + "sharedItems";

        /// <summary>
        /// Represents the x:sheet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sheets" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="R.id" />, <see cref="NoNamespace.sheetId" />, <see cref="NoNamespace.state" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Sheet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheet = x + "sheet";

        /// <summary>
        /// Represents the x:sheetCalcPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fullCalcOnLoad" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SheetCalculationProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetCalcPr = x + "sheetCalcPr";

        /// <summary>
        /// Represents the x:sheetData XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sheetDataSet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="row" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.refreshError" />, <see cref="NoNamespace.sheetId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalSheetData, SheetData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetData = x + "sheetData";

        /// <summary>
        /// Represents the x:sheetDataSet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="externalBook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sheetData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SheetDataSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetDataSet = x + "sheetDataSet";

        /// <summary>
        /// Represents the x:sheetFormatPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.baseColWidth" />, <see cref="NoNamespace.customHeight" />, <see cref="NoNamespace.defaultColWidth" />, <see cref="NoNamespace.defaultRowHeight" />, <see cref="NoNamespace.outlineLevelCol" />, <see cref="NoNamespace.outlineLevelRow" />, <see cref="NoNamespace.thickBottom" />, <see cref="NoNamespace.thickTop" />, <see cref="X14AC.dyDescent" />, <see cref="NoNamespace.zeroHeight" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SheetFormatProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetFormatPr = x + "sheetFormatPr";

        /// <summary>
        /// Represents the x:sheetId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sheetIdMap" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SheetId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetId = x + "sheetId";

        /// <summary>
        /// Represents the x:sheetIdMap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="header" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sheetId" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SheetIdMap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetIdMap = x + "sheetIdMap";

        /// <summary>
        /// Represents the x:sheetName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sheetNames" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SheetName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetName = x + "sheetName";

        /// <summary>
        /// Represents the x:sheetNames XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="externalBook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sheetName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SheetNames.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetNames = x + "sheetNames";

        /// <summary>
        /// Represents the x:sheetPr XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="outlinePr" />, <see cref="pageSetUpPr" />, <see cref="tabColor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.codeName" />, <see cref="NoNamespace.enableFormatConditionsCalculation" />, <see cref="NoNamespace.filterMode" />, <see cref="NoNamespace.published" />, <see cref="NoNamespace.syncHorizontal" />, <see cref="NoNamespace.syncRef" />, <see cref="NoNamespace.syncVertical" />, <see cref="NoNamespace.transitionEntry" />, <see cref="NoNamespace.transitionEvaluation" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartSheetProperties, SheetProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetPr = x + "sheetPr";

        /// <summary>
        /// Represents the x:sheetProtection XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.algorithmName" />, <see cref="NoNamespace.autoFilter" />, <see cref="NoNamespace.content" />, <see cref="NoNamespace.deleteColumns" />, <see cref="NoNamespace.deleteRows" />, <see cref="NoNamespace.formatCells" />, <see cref="NoNamespace.formatColumns" />, <see cref="NoNamespace.formatRows" />, <see cref="NoNamespace.hashValue" />, <see cref="NoNamespace.insertColumns" />, <see cref="NoNamespace.insertHyperlinks" />, <see cref="NoNamespace.insertRows" />, <see cref="NoNamespace.objects" />, <see cref="NoNamespace.password" />, <see cref="NoNamespace.pivotTables" />, <see cref="NoNamespace.saltValue" />, <see cref="NoNamespace.scenarios" />, <see cref="NoNamespace.selectLockedCells" />, <see cref="NoNamespace.selectUnlockedCells" />, <see cref="NoNamespace.sheet" />, <see cref="NoNamespace.sort" />, <see cref="NoNamespace.spinCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartSheetProtection, SheetProtection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetProtection = x + "sheetProtection";

        /// <summary>
        /// Represents the x:sheets XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sheet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Sheets.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheets = x + "sheets";

        /// <summary>
        /// Represents the x:sheetView XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sheetViews" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pane" />, <see cref="pivotSelection" />, <see cref="selection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.colorId" />, <see cref="NoNamespace.defaultGridColor" />, <see cref="NoNamespace.rightToLeft" />, <see cref="NoNamespace.showFormulas" />, <see cref="NoNamespace.showGridLines" />, <see cref="NoNamespace.showOutlineSymbols" />, <see cref="NoNamespace.showRowColHeaders" />, <see cref="NoNamespace.showRuler" />, <see cref="NoNamespace.showWhiteSpace" />, <see cref="NoNamespace.showZeros" />, <see cref="NoNamespace.tabSelected" />, <see cref="NoNamespace.topLeftCell" />, <see cref="NoNamespace.view" />, <see cref="NoNamespace.windowProtection" />, <see cref="NoNamespace.workbookViewId" />, <see cref="NoNamespace.zoomScale" />, <see cref="NoNamespace.zoomScaleNormal" />, <see cref="NoNamespace.zoomScalePageLayoutView" />, <see cref="NoNamespace.zoomScaleSheetLayoutView" />, <see cref="NoNamespace.zoomToFit" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartSheetView, SheetView.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetView = x + "sheetView";

        /// <summary>
        /// Represents the x:sheetViews XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="dialogsheet" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="sheetView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChartSheetViews, SheetViews.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sheetViews = x + "sheetViews";

        /// <summary>
        /// Represents the x:si XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sst" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="phoneticPr" />, <see cref="r" />, <see cref="rPh" />, <see cref="t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SharedStringItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName si = x + "si";

        /// <summary>
        /// Represents the x:singleXmlCell XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="singleXmlCells" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="xmlCellPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.connectionId" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SingleXmlCell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName singleXmlCell = x + "singleXmlCell";

        /// <summary>
        /// Represents the x:singleXmlCells XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="singleXmlCell" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SingleXmlCells.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName singleXmlCells = x + "singleXmlCells";

        /// <summary>
        /// Represents the x:sortByTuple XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="set" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tpl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SortByTuple.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sortByTuple = x + "sortByTuple";

        /// <summary>
        /// Represents the x:sortCondition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sortState" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.customList" />, <see cref="NoNamespace.descending" />, <see cref="NoNamespace.dxfId_" />, <see cref="NoNamespace.iconId" />, <see cref="NoNamespace.iconSet" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.sortBy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SortCondition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sortCondition = x + "sortCondition";

        /// <summary>
        /// Represents the x:sortState XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="autoFilter" />, <see cref="queryTableRefresh" />, <see cref="table" />, <see cref="worksheet" />, <see cref="XNE.macrosheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="sortCondition" />, <see cref="X14.sortCondition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.caseSensitive" />, <see cref="NoNamespace.columnSort" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.sortMethod" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SortState.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sortState = x + "sortState";

        /// <summary>
        /// Represents the x:sst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="si" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.uniqueCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SharedStringTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sst = x + "sst";

        /// <summary>
        /// Represents the x:start XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="border" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: StartBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName start = x + "start";

        /// <summary>
        /// Represents the x:stop XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="gradientFill" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.position" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GradientStop.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stop = x + "stop";

        /// <summary>
        /// Represents the x:stp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Subtopic.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName stp = x + "stp";

        /// <summary>
        /// Represents the x:strike XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Strike.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName strike = x + "strike";

        /// <summary>
        /// Represents the x:styleSheet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="borders" />, <see cref="cellStyles" />, <see cref="cellStyleXfs" />, <see cref="cellXfs" />, <see cref="colors" />, <see cref="dxfs" />, <see cref="extLst" />, <see cref="fills" />, <see cref="fonts" />, <see cref="numFmts" />, <see cref="tableStyles" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Stylesheet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName styleSheet = x + "styleSheet";

        /// <summary>
        /// Represents the x:sz XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FontSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sz = x + "sz";

        /// <summary>
        /// Represents the x:t XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="@is" />, <see cref="mdx" />, <see cref="r" />, <see cref="rPh" />, <see cref="si" />, <see cref="text" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="n" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.b" />, <see cref="NoNamespace.bc" />, <see cref="NoNamespace.c" />, <see cref="NoNamespace.ct" />, <see cref="NoNamespace.fc" />, <see cref="NoNamespace.fi" />, <see cref="NoNamespace.i" />, <see cref="NoNamespace.si" />, <see cref="NoNamespace.st" />, <see cref="NoNamespace.u" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MdxTuple, Text.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName t = x + "t";

        /// <summary>
        /// Represents the x:tabColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sheetPr" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TabColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tabColor = x + "tabColor";

        /// <summary>
        /// Represents the x:table XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="autoFilter" />, <see cref="extLst" />, <see cref="sortState" />, <see cref="tableColumns" />, <see cref="tableStyleInfo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.comment" />, <see cref="NoNamespace.connectionId" />, <see cref="NoNamespace.dataCellStyle" />, <see cref="NoNamespace.dataDxfId" />, <see cref="NoNamespace.displayName" />, <see cref="NoNamespace.headerRowBorderDxfId" />, <see cref="NoNamespace.headerRowCellStyle" />, <see cref="NoNamespace.headerRowCount" />, <see cref="NoNamespace.headerRowDxfId" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.insertRow" />, <see cref="NoNamespace.insertRowShift" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.published" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.tableBorderDxfId" />, <see cref="NoNamespace.tableType" />, <see cref="NoNamespace.totalsRowBorderDxfId" />, <see cref="NoNamespace.totalsRowCellStyle" />, <see cref="NoNamespace.totalsRowCount" />, <see cref="NoNamespace.totalsRowDxfId" />, <see cref="NoNamespace.totalsRowShown" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Table.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName table = x + "table";

        /// <summary>
        /// Represents the x:tableColumn XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tableColumns" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="calculatedColumnFormula" />, <see cref="extLst" />, <see cref="totalsRowFormula" />, <see cref="xmlColumnPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dataCellStyle" />, <see cref="NoNamespace.dataDxfId" />, <see cref="NoNamespace.headerRowCellStyle" />, <see cref="NoNamespace.headerRowDxfId" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.queryTableFieldId" />, <see cref="NoNamespace.totalsRowCellStyle" />, <see cref="NoNamespace.totalsRowDxfId" />, <see cref="NoNamespace.totalsRowFunction" />, <see cref="NoNamespace.totalsRowLabel" />, <see cref="NoNamespace.uniqueName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tableColumn = x + "tableColumn";

        /// <summary>
        /// Represents the x:tableColumns XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="table" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tableColumn" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableColumns.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tableColumns = x + "tableColumns";

        /// <summary>
        /// Represents the x:tablePart XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tableParts" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TablePart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tablePart = x + "tablePart";

        /// <summary>
        /// Represents the x:tableParts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tablePart" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableParts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tableParts = x + "tableParts";

        /// <summary>
        /// Represents the x:tables XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="m" />, <see cref="s" />, <see cref="x_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tables = x + "tables";

        /// <summary>
        /// Represents the x:tableStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tableStyles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tableStyleElement" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.pivot" />, <see cref="NoNamespace.table" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tableStyle = x + "tableStyle";

        /// <summary>
        /// Represents the x:tableStyleElement XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tableStyle" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dxfId_" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableStyleElement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tableStyleElement = x + "tableStyleElement";

        /// <summary>
        /// Represents the x:tableStyleInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="table" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.showColumnStripes" />, <see cref="NoNamespace.showFirstColumn" />, <see cref="NoNamespace.showLastColumn" />, <see cref="NoNamespace.showRowStripes" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableStyleInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tableStyleInfo = x + "tableStyleInfo";

        /// <summary>
        /// Represents the x:tableStyles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="styleSheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tableStyle" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.defaultPivotStyle" />, <see cref="NoNamespace.defaultTableStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tableStyles = x + "tableStyles";

        /// <summary>
        /// Represents the x:text XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="comment" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="phoneticPr" />, <see cref="r" />, <see cref="rPh" />, <see cref="t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CommentText.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName text = x + "text";

        /// <summary>
        /// Represents the x:textField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textFields" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.position" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textField = x + "textField";

        /// <summary>
        /// Represents the x:textFields XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="textPr" />, <see cref="X15.textPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="textField" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextFields.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textFields = x + "textFields";

        /// <summary>
        /// Represents the x:textPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="textFields" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.characterSet" />, <see cref="NoNamespace.codePage" />, <see cref="NoNamespace.comma" />, <see cref="NoNamespace.consecutive" />, <see cref="NoNamespace.@decimal" />, <see cref="NoNamespace.delimited" />, <see cref="NoNamespace.delimiter" />, <see cref="NoNamespace.fileType" />, <see cref="NoNamespace.firstRow" />, <see cref="NoNamespace.prompt" />, <see cref="NoNamespace.qualifier" />, <see cref="NoNamespace.semicolon" />, <see cref="NoNamespace.sourceFile" />, <see cref="NoNamespace.space" />, <see cref="NoNamespace.tab" />, <see cref="NoNamespace.thousands" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textPr = x + "textPr";

        /// <summary>
        /// Represents the x:to XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="anchor" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="XDR.col" />, <see cref="XDR.colOff" />, <see cref="XDR.row" />, <see cref="XDR.rowOff" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ToMarker.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName to = x + "to";

        /// <summary>
        /// Represents the x:top XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="border" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName top = x + "top";

        /// <summary>
        /// Represents the x:top10 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="filterColumn" />, <see cref="XNSV.filter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.filterVal" />, <see cref="NoNamespace.percent" />, <see cref="NoNamespace.top" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Top10.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName top10 = x + "top10";

        /// <summary>
        /// Represents the x:totalsRowFormula XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tableColumn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TotalsRowFormula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName totalsRowFormula = x + "totalsRowFormula";

        /// <summary>
        /// Represents the x:tp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="main" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="stp" />, <see cref="tr" />, <see cref="v" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Topic.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tp = x + "tp";

        /// <summary>
        /// Represents the x:tpl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sortByTuple" />, <see cref="tpls" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fld" />, <see cref="NoNamespace.hier" />, <see cref="NoNamespace.item" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tuple.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tpl = x + "tpl";

        /// <summary>
        /// Represents the x:tpls XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="e" />, <see cref="m" />, <see cref="n" />, <see cref="query" />, <see cref="s" />, <see cref="set" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tpl" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Tuples.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tpls = x + "tpls";

        /// <summary>
        /// Represents the x:tr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tp" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.r" />, <see cref="NoNamespace.s" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TopicReferences.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tr = x + "tr";

        /// <summary>
        /// Represents the x:tupleCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="entries" />, <see cref="extLst" />, <see cref="queryCache" />, <see cref="serverFormats" />, <see cref="sets" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TupleCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tupleCache = x + "tupleCache";

        /// <summary>
        /// Represents the x:u XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Underline.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName u = x + "u";

        /// <summary>
        /// Represents the x:undo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rm" />, <see cref="rrc" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.array" />, <see cref="NoNamespace.cs" />, <see cref="NoNamespace.dn" />, <see cref="NoNamespace.dr" />, <see cref="NoNamespace.exp" />, <see cref="NoNamespace.index" />, <see cref="NoNamespace.nf" />, <see cref="NoNamespace.r" />, <see cref="NoNamespace.ref3D" />, <see cref="NoNamespace.sId" />, <see cref="NoNamespace.v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Undo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName undo = x + "undo";

        /// <summary>
        /// Represents the x:userInfo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="users" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dateTime" />, <see cref="NoNamespace.guid" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: UserInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName userInfo = x + "userInfo";

        /// <summary>
        /// Represents the x:users XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="userInfo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Users.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName users = x + "users";

        /// <summary>
        /// Represents the x:v XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="c" />, <see cref="cell" />, <see cref="nc" />, <see cref="oc" />, <see cref="tp" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellValue, Xstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName v = x + "v";

        /// <summary>
        /// Represents the x:val XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DdeLinkValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName val = x + "val";

        /// <summary>
        /// Represents the x:value XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="values" />, <see cref="X14.values" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="val" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Value.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName value = x + "value";

        /// <summary>
        /// Represents the x:valueMetadata XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="metadata" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bk" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ValueMetadata.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName valueMetadata = x + "valueMetadata";

        /// <summary>
        /// Represents the x:values XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ddeItem" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="value" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cols" />, <see cref="NoNamespace.rows" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Values.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName values = x + "values";

        /// <summary>
        /// Represents the x:vertAlign XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="font" />, <see cref="rPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VerticalTextAlignment.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vertAlign = x + "vertAlign";

        /// <summary>
        /// Represents the x:vertical XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="border" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VerticalBorder.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName vertical = x + "vertical";

        /// <summary>
        /// Represents the x:volType XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="volTypes" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="main" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VolatileType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName volType = x + "volType";

        /// <summary>
        /// Represents the x:volTypes XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="volType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: VolatileTypes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName volTypes = x + "volTypes";

        /// <summary>
        /// Represents the x:webPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tables" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.consecutive" />, <see cref="NoNamespace.editPage" />, <see cref="NoNamespace.firstRow" />, <see cref="NoNamespace.htmlFormat" />, <see cref="NoNamespace.htmlTables" />, <see cref="NoNamespace.parsePre" />, <see cref="NoNamespace.post" />, <see cref="NoNamespace.sourceData" />, <see cref="NoNamespace.textDates" />, <see cref="NoNamespace.url" />, <see cref="NoNamespace.xl2000" />, <see cref="NoNamespace.xl97" />, <see cref="NoNamespace.xml" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebQueryProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webPr = x + "webPr";

        /// <summary>
        /// Represents the x:webPublishing XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allowPng" />, <see cref="NoNamespace.characterSet" />, <see cref="NoNamespace.codePage" />, <see cref="NoNamespace.css" />, <see cref="NoNamespace.dpi" />, <see cref="NoNamespace.longFileNames" />, <see cref="NoNamespace.targetScreenSize" />, <see cref="NoNamespace.thicket" />, <see cref="NoNamespace.vml" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebPublishing.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webPublishing = x + "webPublishing";

        /// <summary>
        /// Represents the x:webPublishItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webPublishItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoRepublish" />, <see cref="NoNamespace.destinationFile" />, <see cref="NoNamespace.divId" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.sourceObject" />, <see cref="NoNamespace.sourceRef" />, <see cref="NoNamespace.sourceType" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebPublishItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webPublishItem = x + "webPublishItem";

        /// <summary>
        /// Represents the x:webPublishItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="chartsheet" />, <see cref="worksheet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="webPublishItem" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebPublishItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webPublishItems = x + "webPublishItems";

        /// <summary>
        /// Represents the x:webPublishObject XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webPublishObjects" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoRepublish" />, <see cref="NoNamespace.destinationFile" />, <see cref="NoNamespace.divId" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.sourceObject" />, <see cref="NoNamespace.title" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebPublishObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webPublishObject = x + "webPublishObject";

        /// <summary>
        /// Represents the x:webPublishObjects XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="webPublishObject" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebPublishObjects.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webPublishObjects = x + "webPublishObjects";

        /// <summary>
        /// Represents the x:workbook XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="bookViews" />, <see cref="calcPr" />, <see cref="customWorkbookViews" />, <see cref="definedNames" />, <see cref="externalReferences" />, <see cref="extLst" />, <see cref="fileRecoveryPr" />, <see cref="fileSharing" />, <see cref="fileVersion" />, <see cref="functionGroups" />, <see cref="oleSize" />, <see cref="pivotCaches" />, <see cref="sheets" />, <see cref="webPublishing" />, <see cref="webPublishObjects" />, <see cref="workbookPr" />, <see cref="workbookProtection" />, <see cref="X15AC.absPath" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.conformance" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Workbook.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName workbook = x + "workbook";

        /// <summary>
        /// Represents the x:workbookPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allowRefreshQuery" />, <see cref="NoNamespace.autoCompressPictures" />, <see cref="NoNamespace.backupFile" />, <see cref="NoNamespace.checkCompatibility" />, <see cref="NoNamespace.codeName" />, <see cref="NoNamespace.date1904" />, <see cref="NoNamespace.dateCompatibility" />, <see cref="NoNamespace.defaultThemeVersion" />, <see cref="NoNamespace.filterPrivacy" />, <see cref="NoNamespace.hidePivotFieldList" />, <see cref="NoNamespace.promptedSolutions" />, <see cref="NoNamespace.publishItems" />, <see cref="NoNamespace.refreshAllConnections" />, <see cref="NoNamespace.saveExternalLinkValues" />, <see cref="NoNamespace.showBorderUnselectedTables" />, <see cref="NoNamespace.showInkAnnotation" />, <see cref="NoNamespace.showObjects" />, <see cref="NoNamespace.showPivotChartFilter" />, <see cref="NoNamespace.updateLinks" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WorkbookProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName workbookPr = x + "workbookPr";

        /// <summary>
        /// Represents the x:workbookProtection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="workbook" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.lockRevision" />, <see cref="NoNamespace.lockStructure" />, <see cref="NoNamespace.lockWindows" />, <see cref="NoNamespace.revisionsAlgorithmName" />, <see cref="NoNamespace.revisionsHashValue" />, <see cref="NoNamespace.revisionsPassword" />, <see cref="NoNamespace.revisionsSaltValue" />, <see cref="NoNamespace.revisionsSpinCount" />, <see cref="NoNamespace.workbookAlgorithmName" />, <see cref="NoNamespace.workbookHashValue" />, <see cref="NoNamespace.workbookPassword" />, <see cref="NoNamespace.workbookSaltValue" />, <see cref="NoNamespace.workbookSpinCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WorkbookProtection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName workbookProtection = x + "workbookProtection";

        /// <summary>
        /// Represents the x:workbookView XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="bookViews" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.activeTab" />, <see cref="NoNamespace.autoFilterDateGrouping" />, <see cref="NoNamespace.firstSheet" />, <see cref="NoNamespace.minimized" />, <see cref="NoNamespace.showHorizontalScroll" />, <see cref="NoNamespace.showSheetTabs" />, <see cref="NoNamespace.showVerticalScroll" />, <see cref="NoNamespace.tabRatio" />, <see cref="NoNamespace.visibility" />, <see cref="NoNamespace.windowHeight" />, <see cref="NoNamespace.windowWidth" />, <see cref="NoNamespace.xWindow" />, <see cref="NoNamespace.yWindow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WorkbookView.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName workbookView = x + "workbookView";

        /// <summary>
        /// Represents the x:worksheet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="autoFilter" />, <see cref="cellWatches" />, <see cref="colBreaks" />, <see cref="cols" />, <see cref="conditionalFormatting" />, <see cref="controls" />, <see cref="customProperties" />, <see cref="customSheetViews" />, <see cref="dataConsolidate" />, <see cref="dataValidations" />, <see cref="dimension" />, <see cref="drawing" />, <see cref="drawingHF" />, <see cref="extLst" />, <see cref="headerFooter" />, <see cref="hyperlinks" />, <see cref="ignoredErrors" />, <see cref="legacyDrawing" />, <see cref="legacyDrawingHF" />, <see cref="mergeCells" />, <see cref="oleObjects" />, <see cref="pageMargins" />, <see cref="pageSetup" />, <see cref="phoneticPr" />, <see cref="picture" />, <see cref="printOptions" />, <see cref="protectedRanges" />, <see cref="rowBreaks" />, <see cref="scenarios" />, <see cref="sheetCalcPr" />, <see cref="sheetData" />, <see cref="sheetFormatPr" />, <see cref="sheetPr" />, <see cref="sheetProtection" />, <see cref="sheetViews" />, <see cref="sortState" />, <see cref="tableParts" />, <see cref="webPublishItems" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Worksheet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName worksheet = x + "worksheet";

        /// <summary>
        /// Represents the x:worksheetSource XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheSource" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="R.id" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.sheet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WorksheetSource.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName worksheetSource = x + "worksheetSource";

        /// <summary>
        /// Represents the x:x XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="b" />, <see cref="d" />, <see cref="discretePr" />, <see cref="e" />, <see cref="i" />, <see cref="m" />, <see cref="n" />, <see cref="r" />, <see cref="reference" />, <see cref="s" />, <see cref="tables" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.v" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FieldItem, MemberPropertyIndex.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName x_ = x + "x";

        /// <summary>
        /// Represents the x:xf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cellStyleXfs" />, <see cref="cellXfs" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="alignment" />, <see cref="extLst" />, <see cref="protection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.applyAlignment" />, <see cref="NoNamespace.applyBorder" />, <see cref="NoNamespace.applyFill" />, <see cref="NoNamespace.applyFont" />, <see cref="NoNamespace.applyNumberFormat" />, <see cref="NoNamespace.applyProtection" />, <see cref="NoNamespace.borderId" />, <see cref="NoNamespace.fillId" />, <see cref="NoNamespace.fontId" />, <see cref="NoNamespace.numFmtId" />, <see cref="NoNamespace.pivotButton" />, <see cref="NoNamespace.quotePrefix" />, <see cref="NoNamespace.xfId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CellFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xf = x + "xf";

        /// <summary>
        /// Represents the x:xmlCellPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="singleXmlCell" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="xmlPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.uniqueName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: XmlCellProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xmlCellPr = x + "xmlCellPr";

        /// <summary>
        /// Represents the x:xmlColumnPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tableColumn" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.denormalized" />, <see cref="NoNamespace.mapId" />, <see cref="NoNamespace.xmlDataType" />, <see cref="NoNamespace.xpath" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: XmlColumnProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xmlColumnPr = x + "xmlColumnPr";

        /// <summary>
        /// Represents the x:xmlPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="xmlCellPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mapId" />, <see cref="NoNamespace.xmlDataType" />, <see cref="NoNamespace.xpath" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: XmlProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName xmlPr = x + "xmlPr";
    }
}
