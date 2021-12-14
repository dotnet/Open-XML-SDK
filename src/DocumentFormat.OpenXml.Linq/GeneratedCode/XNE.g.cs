// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xne="http://schemas.microsoft.com/office/excel/2006/main" namespace.
    /// </summary>
    public static class XNE
    {
        /// <summary>
        /// Defines the XML namespace associated with the xne prefix.
        /// </summary>
        public static readonly XNamespace xne = "http://schemas.microsoft.com/office/excel/2006/main";

        /// <summary>
        /// Represents the xne:col XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colSortMap" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.newVal" />, <see cref="NoNamespace.oldVal" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnSortMapItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName col = xne + "col";

        /// <summary>
        /// Represents the xne:colSortMap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheetSortMap" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="col" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColumnSortMap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colSortMap = xne + "colSortMap";

        /// <summary>
        /// Represents the xne:f XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X14.cfRule" />, <see cref="X14.cfvo" />, <see cref="X14.formula1" />, <see cref="X14.formula2" />, <see cref="X14.sparkline" />, <see cref="X14.sparklineGroup" />, <see cref="X14.userEdit" />, <see cref="X15.webExtension" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Formula.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName f = xne + "f";

        /// <summary>
        /// Represents the xne:macrosheet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="X.autoFilter" />, <see cref="X.colBreaks" />, <see cref="X.cols" />, <see cref="X.conditionalFormatting" />, <see cref="X.customProperties" />, <see cref="X.customSheetViews" />, <see cref="X.dataConsolidate" />, <see cref="X.dimension" />, <see cref="X.drawing" />, <see cref="X.drawingHF" />, <see cref="X.extLst" />, <see cref="X.headerFooter" />, <see cref="X.legacyDrawing" />, <see cref="X.legacyDrawingHF" />, <see cref="X.oleObjects" />, <see cref="X.pageMargins" />, <see cref="X.pageSetup" />, <see cref="X.phoneticPr" />, <see cref="X.picture" />, <see cref="X.printOptions" />, <see cref="X.rowBreaks" />, <see cref="X.sheetData" />, <see cref="X.sheetFormatPr" />, <see cref="X.sheetPr" />, <see cref="X.sheetProtection" />, <see cref="X.sheetViews" />, <see cref="X.sortState" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Macrosheet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName macrosheet = xne + "macrosheet";

        /// <summary>
        /// Represents the xne:row XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rowSortMap" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.newVal" />, <see cref="NoNamespace.oldVal" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowSortMapItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName row = xne + "row";

        /// <summary>
        /// Represents the xne:rowSortMap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="worksheetSortMap" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="row" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowSortMap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rowSortMap = xne + "rowSortMap";

        /// <summary>
        /// Represents the xne:sqref XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X14.conditionalFormatting" />, <see cref="X14.dataValidation" />, <see cref="X14.ignoredError" />, <see cref="X14.protectedRange" />, <see cref="X14.sparkline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ReferenceSequence.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sqref = xne + "sqref";

        /// <summary>
        /// Represents the xne:worksheetSortMap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="colSortMap" />, <see cref="rowSortMap" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WorksheetSortMap.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName worksheetSortMap = xne + "worksheetSortMap";
    }
}
