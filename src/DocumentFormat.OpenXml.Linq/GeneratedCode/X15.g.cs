// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:x15="http://schemas.microsoft.com/office/spreadsheetml/2010/11/main" namespace.
    /// </summary>
    public static class X15
    {
        /// <summary>
        /// Defines the XML namespace associated with the x15 prefix.
        /// </summary>
        public static readonly XNamespace x15 = "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main";

        /// <summary>
        /// Represents the x15:activeTabTopLevelEntity XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableUISettings" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FieldListActiveTabTopLevelEntity.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName activeTabTopLevelEntity = x15 + "activeTabTopLevelEntity";

        /// <summary>
        /// Represents the x15:bounds XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="state" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.endDate" />, <see cref="NoNamespace.startDate" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BoundsTimelineRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bounds = x15 + "bounds";

        /// <summary>
        /// Represents the x15:c XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotRow" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="v" />, <see cref="x" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.i" />, <see cref="NoNamespace.t" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotValueCell.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName c = x15 + "c";

        /// <summary>
        /// Represents the x15:cachedUniqueName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cachedUniqueNames" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.index" />, <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CachedUniqueName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cachedUniqueName = x15 + "cachedUniqueName";

        /// <summary>
        /// Represents the x15:cachedUniqueNames XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cachedUniqueName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CachedUniqueNames.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cachedUniqueNames = x15 + "cachedUniqueNames";

        /// <summary>
        /// Represents the x15:cacheHierarchy XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.aggregatedColumn" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheHierarchy.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cacheHierarchy = x15 + "cacheHierarchy";

        /// <summary>
        /// Represents the x15:calculatedMember XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.measure" />, <see cref="NoNamespace.measureGroup" />, <see cref="NoNamespace.numberFormat" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculatedMember.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calculatedMember = x15 + "calculatedMember";

        /// <summary>
        /// Represents the x15:connection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dataFeedPr" />, <see cref="modelTextPr" />, <see cref="oledbPr" />, <see cref="rangePr" />, <see cref="textPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.autoDelete" />, <see cref="NoNamespace.excludeFromRefreshAll" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.model" />, <see cref="NoNamespace.usedByAddin" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Connection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName connection = x15 + "connection";

        /// <summary>
        /// Represents the x15:dataFeedPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dbTables" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.connection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataFeedProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataFeedPr = x15 + "dataFeedPr";

        /// <summary>
        /// Represents the x15:dataField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.isCountDistinct" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataField = x15 + "dataField";

        /// <summary>
        /// Represents the x15:dataModel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="modelRelationships" />, <see cref="modelTables" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.minVersionLoad" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataModel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataModel = x15 + "dataModel";

        /// <summary>
        /// Represents the x15:dbCommand XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oledbPr" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.text" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DbCommand.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dbCommand = x15 + "dbCommand";

        /// <summary>
        /// Represents the x15:dbTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dbTables" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DbTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dbTable = x15 + "dbTable";

        /// <summary>
        /// Represents the x15:dbTables XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataFeedPr" />, <see cref="oledbPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dbTable" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DbTables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dbTables = x15 + "dbTables";

        /// <summary>
        /// Represents the x15:dxfs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.dxf" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DifferentialFormats.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dxfs = x15 + "dxfs";

        /// <summary>
        /// Represents the x15:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataModel" />, <see cref="pivotTableUISettings" />, <see cref="state" />, <see cref="tableSlicerCache" />, <see cref="timeline" />, <see cref="timelineCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = x15 + "extLst";

        /// <summary>
        /// Represents the x15:modelRelationship XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="modelRelationships" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fromColumn" />, <see cref="NoNamespace.fromTable" />, <see cref="NoNamespace.toColumn" />, <see cref="NoNamespace.toTable" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ModelRelationship.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName modelRelationship = x15 + "modelRelationship";

        /// <summary>
        /// Represents the x15:modelRelationships XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataModel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="modelRelationship" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ModelRelationships.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName modelRelationships = x15 + "modelRelationships";

        /// <summary>
        /// Represents the x15:modelTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="modelTables" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.connection" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ModelTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName modelTable = x15 + "modelTable";

        /// <summary>
        /// Represents the x15:modelTables XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataModel" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="modelTable" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ModelTables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName modelTables = x15 + "modelTables";

        /// <summary>
        /// Represents the x15:modelTextPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.headers" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ModelTextProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName modelTextPr = x15 + "modelTextPr";

        /// <summary>
        /// Represents the x15:movingPeriodState XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />, <see cref="state" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.movingMultiple" />, <see cref="NoNamespace.movingPeriod" />, <see cref="NoNamespace.referenceDateBegin" />, <see cref="NoNamespace.referenceMultiple" />, <see cref="NoNamespace.referencePeriod" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MovingPeriodState.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName movingPeriodState = x15 + "movingPeriodState";

        /// <summary>
        /// Represents the x15:oledbPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dbCommand" />, <see cref="dbTables" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.connection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleDbPrpoperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oledbPr = x15 + "oledbPr";

        /// <summary>
        /// Represents the x15:pivotCacheDecoupled XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.decoupled" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCacheDecoupled.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCacheDecoupled = x15 + "pivotCacheDecoupled";

        /// <summary>
        /// Represents the x15:pivotCacheIdVersion XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cacheIdCreatedVersion" />, <see cref="NoNamespace.cacheIdSupportedVersion" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCacheIdVersion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCacheIdVersion = x15 + "pivotCacheIdVersion";

        /// <summary>
        /// Represents the x15:pivotCaches XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.pivotCache" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCaches.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCaches = x15 + "pivotCaches";

        /// <summary>
        /// Represents the x15:pivotFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.useWholeDay" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotFilter = x15 + "pivotFilter";

        /// <summary>
        /// Represents the x15:pivotRow XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="c" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.r" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotRow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotRow = x15 + "pivotRow";

        /// <summary>
        /// Represents the x15:pivotTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTables" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.tabId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineCachePivotTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTable = x15 + "pivotTable";

        /// <summary>
        /// Represents the x15:pivotTableData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotRow" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cacheId" />, <see cref="NoNamespace.columnCount" />, <see cref="NoNamespace.rowCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotTableData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTableData = x15 + "pivotTableData";

        /// <summary>
        /// Represents the x15:pivotTableReference XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableReferences" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotTableReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTableReference = x15 + "pivotTableReference";

        /// <summary>
        /// Represents the x15:pivotTableReferences XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotTableReference" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotTableReferences.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTableReferences = x15 + "pivotTableReferences";

        /// <summary>
        /// Represents the x15:pivotTables XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timelineCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotTable" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineCachePivotTables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTables = x15 + "pivotTables";

        /// <summary>
        /// Represents the x15:pivotTableUISettings XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="activeTabTopLevelEntity" />, <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.relNeededHidden" />, <see cref="NoNamespace.sourceDataName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotTableUISettings.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTableUISettings = x15 + "pivotTableUISettings";

        /// <summary>
        /// Represents the x15:queryTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.clipped" />, <see cref="NoNamespace.drillThrough" />, <see cref="NoNamespace.sourceDataName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: QueryTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName queryTable = x15 + "queryTable";

        /// <summary>
        /// Represents the x15:rangePr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.sourceName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RangeProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rangePr = x15 + "rangePr";

        /// <summary>
        /// Represents the x15:selection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="state" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.endDate" />, <see cref="NoNamespace.startDate" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SelectionTimelineRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName selection = x15 + "selection";

        /// <summary>
        /// Represents the x15:slicerCacheHideItemsWithNoData XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="slicerCacheOlapLevelName" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerCacheHideItemsWithNoData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerCacheHideItemsWithNoData = x15 + "slicerCacheHideItemsWithNoData";

        /// <summary>
        /// Represents the x15:slicerCacheOlapLevelName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="slicerCacheHideItemsWithNoData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.uniqueName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerCacheOlapLevelName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerCacheOlapLevelName = x15 + "slicerCacheOlapLevelName";

        /// <summary>
        /// Represents the x15:slicerCachePivotTables XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X14.pivotTable" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerCachePivotTables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerCachePivotTables = x15 + "slicerCachePivotTables";

        /// <summary>
        /// Represents the x15:slicerCaches XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X14.slicerCache" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerCaches.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerCaches = x15 + "slicerCaches";

        /// <summary>
        /// Represents the x15:state XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timelineCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bounds" />, <see cref="extLst" />, <see cref="movingPeriodState" />, <see cref="selection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.filterId" />, <see cref="NoNamespace.filterPivotName" />, <see cref="NoNamespace.filterTabId" />, <see cref="NoNamespace.filterType" />, <see cref="NoNamespace.lastRefreshVersion" />, <see cref="NoNamespace.minimalRefreshVersion" />, <see cref="NoNamespace.pivotCacheId" />, <see cref="NoNamespace.singleRangeFilterState" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineState.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName state = x15 + "state";

        /// <summary>
        /// Represents the x15:tableSlicerCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.column" />, <see cref="NoNamespace.crossFilter" />, <see cref="NoNamespace.customListSort" />, <see cref="NoNamespace.sortOrder" />, <see cref="NoNamespace.tableId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TableSlicerCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tableSlicerCache = x15 + "tableSlicerCache";

        /// <summary>
        /// Represents the x15:textPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.textFields" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.characterSet" />, <see cref="NoNamespace.codePage" />, <see cref="NoNamespace.comma" />, <see cref="NoNamespace.consecutive" />, <see cref="NoNamespace.@decimal" />, <see cref="NoNamespace.delimited" />, <see cref="NoNamespace.delimiter" />, <see cref="NoNamespace.fileType" />, <see cref="NoNamespace.firstRow" />, <see cref="NoNamespace.prompt" />, <see cref="NoNamespace.qualifier" />, <see cref="NoNamespace.semicolon" />, <see cref="NoNamespace.sourceFile" />, <see cref="NoNamespace.space" />, <see cref="NoNamespace.tab" />, <see cref="NoNamespace.thousands" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textPr = x15 + "textPr";

        /// <summary>
        /// Represents the x15:timeline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timelines" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cache" />, <see cref="NoNamespace.caption" />, <see cref="NoNamespace.level" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.scrollPosition" />, <see cref="NoNamespace.selectionLevel" />, <see cref="NoNamespace.showHeader" />, <see cref="NoNamespace.showHorizontalScrollbar" />, <see cref="NoNamespace.showSelectionLabel" />, <see cref="NoNamespace.showTimeLevel" />, <see cref="NoNamespace.style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Timeline.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timeline = x15 + "timeline";

        /// <summary>
        /// Represents the x15:timelineCacheDefinition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pivotTables" />, <see cref="state" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.sourceName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineCacheDefinition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelineCacheDefinition = x15 + "timelineCacheDefinition";

        /// <summary>
        /// Represents the x15:timelineCachePivotCaches XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.pivotCache" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineCachePivotCaches.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelineCachePivotCaches = x15 + "timelineCachePivotCaches";

        /// <summary>
        /// Represents the x15:timelineCacheRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timelineCacheRefs" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineCacheReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelineCacheRef = x15 + "timelineCacheRef";

        /// <summary>
        /// Represents the x15:timelineCacheRefs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="timelineCacheRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineCacheReferences.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelineCacheRefs = x15 + "timelineCacheRefs";

        /// <summary>
        /// Represents the x15:timelinePivotCacheDefinition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.timelineData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelinePivotCacheDefinition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelinePivotCacheDefinition = x15 + "timelinePivotCacheDefinition";

        /// <summary>
        /// Represents the x15:timelineRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timelineRefs" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelineRef = x15 + "timelineRef";

        /// <summary>
        /// Represents the x15:timelineRefs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="timelineRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineReferences.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelineRefs = x15 + "timelineRefs";

        /// <summary>
        /// Represents the x15:timelines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="timeline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Timelines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelines = x15 + "timelines";

        /// <summary>
        /// Represents the x15:timelineStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timelineStyles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="timelineStyleElements" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelineStyle = x15 + "timelineStyle";

        /// <summary>
        /// Represents the x15:timelineStyleElement XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timelineStyleElements" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dxfId_" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineStyleElement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelineStyleElement = x15 + "timelineStyleElement";

        /// <summary>
        /// Represents the x15:timelineStyleElements XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="timelineStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="timelineStyleElement" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineStyleElements.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelineStyleElements = x15 + "timelineStyleElements";

        /// <summary>
        /// Represents the x15:timelineStyles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="timelineStyle" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.defaultTimelineStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TimelineStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timelineStyles = x15 + "timelineStyles";

        /// <summary>
        /// Represents the x15:v XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="c" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Xstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName v = x15 + "v";

        /// <summary>
        /// Represents the x15:webExtension XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="webExtensions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="XNE.f" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.appRef_" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webExtension = x15 + "webExtension";

        /// <summary>
        /// Represents the x15:webExtensions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="webExtension" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webExtensions = x15 + "webExtensions";

        /// <summary>
        /// Represents the x15:workbookPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.chartTrackingRefBase" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WorkbookProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName workbookPr = x15 + "workbookPr";

        /// <summary>
        /// Represents the x15:x XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="c" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.b" />, <see cref="NoNamespace.bc" />, <see cref="NoNamespace.fc" />, <see cref="NoNamespace.i" />, <see cref="NoNamespace.@in" />, <see cref="NoNamespace.st" />, <see cref="NoNamespace.un" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotValueCellExtra.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName x = x15 + "x";
    }
}
