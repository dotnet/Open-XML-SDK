// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xnsv="http://schemas.microsoft.com/office/spreadsheetml/2019/namedsheetviews" namespace.
    /// </summary>
    public static class XNSV
    {
        /// <summary>
        /// Defines the XML namespace associated with the xnsv prefix.
        /// </summary>
        public static readonly XNamespace xnsv = "http://schemas.microsoft.com/office/spreadsheetml/2019/namedsheetviews";

        /// <summary>
        /// Represents the xnsv:columnFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nsvFilter" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dxf" />, <see cref="extLst" />, <see cref="filter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.colId" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName columnFilter = xnsv + "columnFilter";

        /// <summary>
        /// Represents the xnsv:dxf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="columnFilter" />, <see cref="sortRule" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.alignment" />, <see cref="X.border" />, <see cref="X.extLst" />, <see cref="X.fill" />, <see cref="X.font" />, <see cref="X.numFmt" />, <see cref="X.protection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DifferentialFormatType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dxf = xnsv + "dxf";

        /// <summary>
        /// Represents the xnsv:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="columnFilter" />, <see cref="namedSheetView" />, <see cref="namedSheetViews" />, <see cref="nsvFilter" />, <see cref="sortRules" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = xnsv + "extLst";

        /// <summary>
        /// Represents the xnsv:filter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="columnFilter" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.colorFilter" />, <see cref="X.customFilters" />, <see cref="X.dynamicFilter" />, <see cref="X.extLst" />, <see cref="X.filters" />, <see cref="X.iconFilter" />, <see cref="X.top10" />, <see cref="X14.customFilters" />, <see cref="X14.iconFilter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.colId" />, <see cref="NoNamespace.hiddenButton" />, <see cref="NoNamespace.showButton" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FilterColumn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filter = xnsv + "filter";

        /// <summary>
        /// Represents the xnsv:namedSheetView XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="namedSheetViews" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="nsvFilter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NamedSheetView.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName namedSheetView = xnsv + "namedSheetView";

        /// <summary>
        /// Represents the xnsv:namedSheetViews XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="namedSheetView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NamedSheetViews.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName namedSheetViews = xnsv + "namedSheetViews";

        /// <summary>
        /// Represents the xnsv:nsvFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="namedSheetView" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="columnFilter" />, <see cref="extLst" />, <see cref="sortRules" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.filterId" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.tableId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NsvFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName nsvFilter = xnsv + "nsvFilter";

        /// <summary>
        /// Represents the xnsv:richSortCondition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sortRule" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.customList" />, <see cref="NoNamespace.descending" />, <see cref="NoNamespace.dxfId_" />, <see cref="NoNamespace.iconId" />, <see cref="NoNamespace.iconSet" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.richSortKey" />, <see cref="NoNamespace.sortBy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RichSortCondition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName richSortCondition = xnsv + "richSortCondition";

        /// <summary>
        /// Represents the xnsv:sortCondition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sortRule" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.customList" />, <see cref="NoNamespace.descending" />, <see cref="NoNamespace.dxfId_" />, <see cref="NoNamespace.iconId" />, <see cref="NoNamespace.iconSet" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.sortBy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SortCondition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sortCondition = xnsv + "sortCondition";

        /// <summary>
        /// Represents the xnsv:sortRule XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sortRules" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dxf" />, <see cref="richSortCondition" />, <see cref="sortCondition" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.colId" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SortRule.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sortRule = xnsv + "sortRule";

        /// <summary>
        /// Represents the xnsv:sortRules XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="nsvFilter" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="sortRule" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.caseSensitive" />, <see cref="NoNamespace.sortMethod" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SortRules.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sortRules = xnsv + "sortRules";
    }
}
