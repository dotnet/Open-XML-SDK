// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:x14="http://schemas.microsoft.com/office/spreadsheetml/2009/9/main" namespace.
    /// </summary>
    public static class X14
    {
        /// <summary>
        /// Defines the XML namespace associated with the x14 prefix.
        /// </summary>
        public static readonly XNamespace x14 = "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main";

        /// <summary>
        /// Represents the x14:argumentDescription XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="argumentDescriptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.index" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ArgumentDescription.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName argumentDescription = x14 + "argumentDescription";

        /// <summary>
        /// Represents the x14:argumentDescriptions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="definedName" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="argumentDescription" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ArgumentDescriptions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName argumentDescriptions = x14 + "argumentDescriptions";

        /// <summary>
        /// Represents the x14:axisColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataBar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BarAxisColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName axisColor = x14 + "axisColor";

        /// <summary>
        /// Represents the x14:borderColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataBar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BorderColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName borderColor = x14 + "borderColor";

        /// <summary>
        /// Represents the x14:cacheField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.ignore" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cacheField = x14 + "cacheField";

        /// <summary>
        /// Represents the x14:cacheHierarchy XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="setLevels" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.flattenHierarchies" />, <see cref="NoNamespace.hierarchizeDistinct" />, <see cref="NoNamespace.ignore" />, <see cref="NoNamespace.measuresSet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CacheHierarchy.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cacheHierarchy = x14 + "cacheHierarchy";

        /// <summary>
        /// Represents the x14:calculatedMember XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tupleSet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.displayFolder" />, <see cref="NoNamespace.dynamicSet" />, <see cref="NoNamespace.flattenHierarchies" />, <see cref="NoNamespace.hierarchizeDistinct" />, <see cref="NoNamespace.mdxLong" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculatedMember.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calculatedMember = x14 + "calculatedMember";

        /// <summary>
        /// Represents the x14:calculatedMembers XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="connection" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.calculatedMember" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CalculatedMembers.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName calculatedMembers = x14 + "calculatedMembers";

        /// <summary>
        /// Represents the x14:cfIcon XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="iconSet" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.iconId" />, <see cref="NoNamespace.iconSet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormattingIcon.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cfIcon = x14 + "cfIcon";

        /// <summary>
        /// Represents the x14:cfRule XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="conditionalFormatting" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="colorScale" />, <see cref="dataBar" />, <see cref="dxf" />, <see cref="extLst" />, <see cref="iconSet" />, <see cref="XNE.f" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.aboveAverage" />, <see cref="NoNamespace.activePresent" />, <see cref="NoNamespace.bottom" />, <see cref="NoNamespace.equalAverage" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.@operator" />, <see cref="NoNamespace.percent" />, <see cref="NoNamespace.priority" />, <see cref="NoNamespace.rank" />, <see cref="NoNamespace.stdDev" />, <see cref="NoNamespace.stopIfTrue" />, <see cref="NoNamespace.text" />, <see cref="NoNamespace.timePeriod" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormattingRule.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cfRule = x14 + "cfRule";

        /// <summary>
        /// Represents the x14:cfvo XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colorScale" />, <see cref="dataBar" />, <see cref="iconSet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="XNE.f" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.gte" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormattingValueObject.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cfvo = x14 + "cfvo";

        /// <summary>
        /// Represents the x14:color XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="colorScale" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Color.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName color = x14 + "color";

        /// <summary>
        /// Represents the x14:colorAxis XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklineGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AxisColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorAxis = x14 + "colorAxis";

        /// <summary>
        /// Represents the x14:colorFirst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklineGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FirstMarkerColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorFirst = x14 + "colorFirst";

        /// <summary>
        /// Represents the x14:colorHigh XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklineGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HighMarkerColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorHigh = x14 + "colorHigh";

        /// <summary>
        /// Represents the x14:colorLast XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklineGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LastMarkerColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorLast = x14 + "colorLast";

        /// <summary>
        /// Represents the x14:colorLow XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklineGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LowMarkerColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorLow = x14 + "colorLow";

        /// <summary>
        /// Represents the x14:colorMarkers XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklineGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MarkersColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorMarkers = x14 + "colorMarkers";

        /// <summary>
        /// Represents the x14:colorNegative XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklineGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NegativeColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorNegative = x14 + "colorNegative";

        /// <summary>
        /// Represents the x14:colorScale XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cfRule" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cfvo" />, <see cref="color" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColorScale.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorScale = x14 + "colorScale";

        /// <summary>
        /// Represents the x14:colorSeries XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklineGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SeriesColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colorSeries = x14 + "colorSeries";

        /// <summary>
        /// Represents the x14:conditionalFormat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="conditionalFormats" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pivotAreas" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.priority" />, <see cref="NoNamespace.scope" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conditionalFormat = x14 + "conditionalFormat";

        /// <summary>
        /// Represents the x14:conditionalFormats XML element.
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
        public static readonly XName conditionalFormats = x14 + "conditionalFormats";

        /// <summary>
        /// Represents the x14:conditionalFormatting XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="conditionalFormattings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cfRule" />, <see cref="extLst" />, <see cref="XNE.sqref" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.pivot" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormatting.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conditionalFormatting = x14 + "conditionalFormatting";

        /// <summary>
        /// Represents the x14:conditionalFormattings XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="conditionalFormatting" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConditionalFormattings.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName conditionalFormattings = x14 + "conditionalFormattings";

        /// <summary>
        /// Represents the x14:connection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="calculatedMembers" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.culture" />, <see cref="NoNamespace.embeddedDataId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Connection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName connection = x14 + "connection";

        /// <summary>
        /// Represents the x14:customFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="customFilters" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@operator" />, <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customFilter = x14 + "customFilter";

        /// <summary>
        /// Represents the x14:customFilters XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.filterColumn" />, <see cref="XNSV.filter" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="customFilter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.and" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CustomFilters.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName customFilters = x14 + "customFilters";

        /// <summary>
        /// Represents the x14:data XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="slicerCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="olap" />, <see cref="tabular" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerCacheData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName data = x14 + "data";

        /// <summary>
        /// Represents the x14:dataBar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cfRule" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="axisColor" />, <see cref="borderColor" />, <see cref="cfvo" />, <see cref="fillColor" />, <see cref="negativeBorderColor" />, <see cref="negativeFillColor" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.axisPosition" />, <see cref="NoNamespace.border" />, <see cref="NoNamespace.direction" />, <see cref="NoNamespace.gradient" />, <see cref="NoNamespace.maxLength" />, <see cref="NoNamespace.minLength" />, <see cref="NoNamespace.negativeBarBorderColorSameAsPositive" />, <see cref="NoNamespace.negativeBarColorSameAsPositive" />, <see cref="NoNamespace.showValue" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataBar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataBar = x14 + "dataBar";

        /// <summary>
        /// Represents the x14:dataField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.pivotShowAs" />, <see cref="NoNamespace.sourceField" />, <see cref="NoNamespace.uniqueName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataField = x14 + "dataField";

        /// <summary>
        /// Represents the x14:datastoreItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DatastoreItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName datastoreItem = x14 + "datastoreItem";

        /// <summary>
        /// Represents the x14:dataValidation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataValidations" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="formula1" />, <see cref="formula2" />, <see cref="XNE.sqref" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allowBlank" />, <see cref="NoNamespace.error" />, <see cref="NoNamespace.errorStyle" />, <see cref="NoNamespace.errorTitle" />, <see cref="NoNamespace.imeMode" />, <see cref="NoNamespace.@operator" />, <see cref="NoNamespace.prompt" />, <see cref="NoNamespace.promptTitle" />, <see cref="NoNamespace.showDropDown" />, <see cref="NoNamespace.showErrorMessage" />, <see cref="NoNamespace.showInputMessage" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataValidation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataValidation = x14 + "dataValidation";

        /// <summary>
        /// Represents the x14:dataValidations XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="dataValidation" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.disablePrompts" />, <see cref="NoNamespace.xWindow" />, <see cref="NoNamespace.yWindow" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataValidations.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dataValidations = x14 + "dataValidations";

        /// <summary>
        /// Represents the x14:definedName XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="definedNames" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="argumentDescriptions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefinedName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName definedName = x14 + "definedName";

        /// <summary>
        /// Represents the x14:definedNames XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="definedName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DefinedNames.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName definedNames = x14 + "definedNames";

        /// <summary>
        /// Represents the x14:dxf XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cfRule" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.alignment" />, <see cref="X.border" />, <see cref="X.extLst" />, <see cref="X.fill" />, <see cref="X.font" />, <see cref="X.numFmt" />, <see cref="X.protection" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DifferentialType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dxf = x14 + "dxf";

        /// <summary>
        /// Represents the x14:dxfs XML element.
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
        public static readonly XName dxfs = x14 + "dxfs";

        /// <summary>
        /// Represents the x14:editValue XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotChange" />, <see cref="userEdit" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.valueType" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotEditValue.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName editValue = x14 + "editValue";

        /// <summary>
        /// Represents the x14:extLst XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cfRule" />, <see cref="cfvo" />, <see cref="conditionalFormat" />, <see cref="conditionalFormatting" />, <see cref="datastoreItem" />, <see cref="formControlPr" />, <see cref="ignoredErrors" />, <see cref="itemLst" />, <see cref="olap" />, <see cref="pivotChange" />, <see cref="pivotEdit" />, <see cref="slicer" />, <see cref="slicerCacheDefinition" />, <see cref="tabular" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList, SlicerCacheDefinitionExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = x14 + "extLst";

        /// <summary>
        /// Represents the x14:fillColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataBar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FillColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName fillColor = x14 + "fillColor";

        /// <summary>
        /// Represents the x14:filter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.filters" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Filter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName filter = x14 + "filter";

        /// <summary>
        /// Represents the x14:formControlPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="itemLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@checked" />, <see cref="NoNamespace.colored" />, <see cref="NoNamespace.dropLines" />, <see cref="NoNamespace.dropStyle" />, <see cref="NoNamespace.dx" />, <see cref="NoNamespace.editVal" />, <see cref="NoNamespace.firstButton" />, <see cref="NoNamespace.fmlaGroup" />, <see cref="NoNamespace.fmlaLink" />, <see cref="NoNamespace.fmlaRange" />, <see cref="NoNamespace.fmlaTxbx" />, <see cref="NoNamespace.horiz" />, <see cref="NoNamespace.inc" />, <see cref="NoNamespace.justLastX" />, <see cref="NoNamespace.lockText" />, <see cref="NoNamespace.max" />, <see cref="NoNamespace.min" />, <see cref="NoNamespace.multiLine" />, <see cref="NoNamespace.multiSel" />, <see cref="NoNamespace.noThreeD" />, <see cref="NoNamespace.noThreeD2" />, <see cref="NoNamespace.objectType" />, <see cref="NoNamespace.page" />, <see cref="NoNamespace.passwordEdit" />, <see cref="NoNamespace.sel" />, <see cref="NoNamespace.seltype" />, <see cref="NoNamespace.textHAlign" />, <see cref="NoNamespace.textVAlign" />, <see cref="NoNamespace.val" />, <see cref="NoNamespace.verticalBar" />, <see cref="NoNamespace.widthMin" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: FormControlProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formControlPr = x14 + "formControlPr";

        /// <summary>
        /// Represents the x14:formula1 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataValidation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="XNE.f" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataValidationForumla1.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formula1 = x14 + "formula1";

        /// <summary>
        /// Represents the x14:formula2 XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataValidation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="XNE.f" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataValidationForumla2.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName formula2 = x14 + "formula2";

        /// <summary>
        /// Represents the x14:header XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="headers" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hierarchyName" />, <see cref="NoNamespace.uniqueName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TupleSetHeader.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName header = x14 + "header";

        /// <summary>
        /// Represents the x14:headers XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tupleSet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="header" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TupleSetHeaders.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName headers = x14 + "headers";

        /// <summary>
        /// Represents the x14:i XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="items" />, <see cref="range" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="p" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.c" />, <see cref="NoNamespace.n" />, <see cref="NoNamespace.nd" />, <see cref="NoNamespace.s" />, <see cref="NoNamespace.x" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OlapSlicerCacheItem, TabularSlicerCacheItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName i = x14 + "i";

        /// <summary>
        /// Represents the x14:iconFilter XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.filterColumn" />, <see cref="XNSV.filter" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.iconId" />, <see cref="NoNamespace.iconSet" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IconFilter.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName iconFilter = x14 + "iconFilter";

        /// <summary>
        /// Represents the x14:iconSet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cfRule" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="cfIcon" />, <see cref="cfvo" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.custom" />, <see cref="NoNamespace.iconSet" />, <see cref="NoNamespace.percent" />, <see cref="NoNamespace.reverse" />, <see cref="NoNamespace.showValue" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IconSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName iconSet = x14 + "iconSet";

        /// <summary>
        /// Represents the x14:id XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Id.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName id = x14 + "id";

        /// <summary>
        /// Represents the x14:ignoredError XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ignoredErrors" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="XNE.sqref" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.calculatedColumn" />, <see cref="NoNamespace.emptyCellReference" />, <see cref="NoNamespace.evalError" />, <see cref="NoNamespace.formula" />, <see cref="NoNamespace.formulaRange" />, <see cref="NoNamespace.listDataValidation" />, <see cref="NoNamespace.numberStoredAsText" />, <see cref="NoNamespace.twoDigitTextYear" />, <see cref="NoNamespace.unlockedFormula" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IgnoredError.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ignoredError = x14 + "ignoredError";

        /// <summary>
        /// Represents the x14:ignoredErrors XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="ignoredError" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IgnoredErrors.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ignoredErrors = x14 + "ignoredErrors";

        /// <summary>
        /// Represents the x14:item XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="itemLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ListItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName item = x14 + "item";

        /// <summary>
        /// Represents the x14:itemLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="formControlPr" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="item" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ListItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName itemLst = x14 + "itemLst";

        /// <summary>
        /// Represents the x14:items XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tabular" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="i" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TabularSlicerCacheItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName items = x14 + "items";

        /// <summary>
        /// Represents the x14:level XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="levels" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ranges" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />, <see cref="NoNamespace.crossFilter" />, <see cref="NoNamespace.sortOrder" />, <see cref="NoNamespace.sourceCaption" />, <see cref="NoNamespace.uniqueName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OlapSlicerCacheLevelData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName level = x14 + "level";

        /// <summary>
        /// Represents the x14:levels XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="olap" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="level" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OlapSlicerCacheLevelsData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName levels = x14 + "levels";

        /// <summary>
        /// Represents the x14:negativeBorderColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataBar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NegativeBorderColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName negativeBorderColor = x14 + "negativeBorderColor";

        /// <summary>
        /// Represents the x14:negativeFillColor XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="dataBar" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.auto" />, <see cref="NoNamespace.indexed" />, <see cref="NoNamespace.rgb" />, <see cref="NoNamespace.theme" />, <see cref="NoNamespace.tint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: NegativeFillColor.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName negativeFillColor = x14 + "negativeFillColor";

        /// <summary>
        /// Represents the x14:olap XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="data" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="levels" />, <see cref="selections" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.pivotCacheId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OlapSlicerCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName olap = x14 + "olap";

        /// <summary>
        /// Represents the x14:oleItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.oleItems" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="values" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.advise" />, <see cref="NoNamespace.icon" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.preferPic" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OleItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName oleItem = x14 + "oleItem";

        /// <summary>
        /// Represents the x14:p XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="i" />, <see cref="selection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.n" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OlapSlicerCacheItemParent.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName p = x14 + "p";

        /// <summary>
        /// Represents the x14:pivotArea XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotEdit" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.extLst" />, <see cref="X.references" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.axis" />, <see cref="NoNamespace.cacheIndex" />, <see cref="NoNamespace.collapsedLevelsAreSubtotals" />, <see cref="NoNamespace.dataOnly" />, <see cref="NoNamespace.field" />, <see cref="NoNamespace.fieldPosition" />, <see cref="NoNamespace.grandCol" />, <see cref="NoNamespace.grandRow" />, <see cref="NoNamespace.labelOnly" />, <see cref="NoNamespace.offset" />, <see cref="NoNamespace.outline" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotArea.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotArea = x14 + "pivotArea";

        /// <summary>
        /// Represents the x14:pivotAreas XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="conditionalFormat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.pivotArea" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotAreas.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotAreas = x14 + "pivotAreas";

        /// <summary>
        /// Represents the x14:pivotCacheDefinition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.pivotCacheId" />, <see cref="NoNamespace.slicerData" />, <see cref="NoNamespace.supportAddCalcMems" />, <see cref="NoNamespace.supportSubqueryCalcMem" />, <see cref="NoNamespace.supportSubqueryNonVisual" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCacheDefinition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCacheDefinition = x14 + "pivotCacheDefinition";

        /// <summary>
        /// Represents the x14:pivotCaches XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.pivotCache" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotCaches.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotCaches = x14 + "pivotCaches";

        /// <summary>
        /// Represents the x14:pivotChange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotChanges" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="editValue" />, <see cref="extLst" />, <see cref="tupleItems" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allocationMethod" />, <see cref="NoNamespace.weightExpression" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotChange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotChange = x14 + "pivotChange";

        /// <summary>
        /// Represents the x14:pivotChanges XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotChange" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotChanges.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotChanges = x14 + "pivotChanges";

        /// <summary>
        /// Represents the x14:pivotEdit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotEdits" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="pivotArea" />, <see cref="tupleItems" />, <see cref="userEdit" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotEdit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotEdit = x14 + "pivotEdit";

        /// <summary>
        /// Represents the x14:pivotEdits XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTableDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotEdit" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotEdits.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotEdits = x14 + "pivotEdits";

        /// <summary>
        /// Represents the x14:pivotField XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.fillDownLabels" />, <see cref="NoNamespace.ignore" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotField.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotField = x14 + "pivotField";

        /// <summary>
        /// Represents the x14:pivotHierarchy XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.ignore" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotHierarchy.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotHierarchy = x14 + "pivotHierarchy";

        /// <summary>
        /// Represents the x14:pivotTable XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotTables" />, <see cref="X15.slicerCachePivotTables" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.tabId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerCachePivotTable.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTable = x14 + "pivotTable";

        /// <summary>
        /// Represents the x14:pivotTableDefinition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="conditionalFormats" />, <see cref="pivotChanges" />, <see cref="pivotEdits" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.allocationMethod" />, <see cref="NoNamespace.altText" />, <see cref="NoNamespace.altTextSummary" />, <see cref="NoNamespace.autoApply" />, <see cref="NoNamespace.calculatedMembersInFilters" />, <see cref="NoNamespace.enableEdit" />, <see cref="NoNamespace.fillDownLabelsDefault" />, <see cref="NoNamespace.hideValuesRow" />, <see cref="NoNamespace.visualTotalsForSets" />, <see cref="NoNamespace.weightExpression" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotTableDefinition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTableDefinition = x14 + "pivotTableDefinition";

        /// <summary>
        /// Represents the x14:pivotTables XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="slicerCacheDefinition" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="pivotTable" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerCachePivotTables.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName pivotTables = x14 + "pivotTables";

        /// <summary>
        /// Represents the x14:protectedRange XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="protectedRanges" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="XNE.sqref" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.algorithmName" />, <see cref="NoNamespace.hashValue" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.password" />, <see cref="NoNamespace.saltValue" />, <see cref="NoNamespace.securityDescriptor" />, <see cref="NoNamespace.spinCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ProtectedRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName protectedRange = x14 + "protectedRange";

        /// <summary>
        /// Represents the x14:protectedRanges XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="protectedRange" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ProtectedRanges.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName protectedRanges = x14 + "protectedRanges";

        /// <summary>
        /// Represents the x14:range XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ranges" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="i" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.startItem" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OlapSlicerCacheRange.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName range = x14 + "range";

        /// <summary>
        /// Represents the x14:ranges XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="level" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="range" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OlapSlicerCacheRanges.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ranges = x14 + "ranges";

        /// <summary>
        /// Represents the x14:row XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="rows" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="rowItem" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TupleSetRow.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName row = x14 + "row";

        /// <summary>
        /// Represents the x14:rowItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="row" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.d" />, <see cref="NoNamespace.u" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TupleSetRowItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rowItem = x14 + "rowItem";

        /// <summary>
        /// Represents the x14:rows XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tupleSet" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="row" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TupleSetRows.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rows = x14 + "rows";

        /// <summary>
        /// Represents the x14:selection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="selections" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="p" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.n" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OlapSlicerCacheSelection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName selection = x14 + "selection";

        /// <summary>
        /// Represents the x14:selections XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="olap" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="selection" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OlapSlicerCacheSelections.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName selections = x14 + "selections";

        /// <summary>
        /// Represents the x14:setLevel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="setLevels" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.hierarchy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SetLevel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName setLevel = x14 + "setLevel";

        /// <summary>
        /// Represents the x14:setLevels XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="cacheHierarchy" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="setLevel" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.count" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SetLevels.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName setLevels = x14 + "setLevels";

        /// <summary>
        /// Represents the x14:slicer XML elements.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="slicerList" />, <see cref="slicers" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cache" />, <see cref="NoNamespace.caption" />, <see cref="NoNamespace.columnCount" />, <see cref="NoNamespace.level" />, <see cref="NoNamespace.lockedPosition" />, <see cref="NoNamespace.name" />, <see cref="R.id" />, <see cref="NoNamespace.rowHeight" />, <see cref="NoNamespace.showCaption" />, <see cref="NoNamespace.startItem" />, <see cref="NoNamespace.style" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Slicer, SlicerRef.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicer = x14 + "slicer";

        /// <summary>
        /// Represents the x14:slicerCache XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="slicerCaches" />, <see cref="X15.slicerCaches" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerCache = x14 + "slicerCache";

        /// <summary>
        /// Represents the x14:slicerCacheDefinition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="data" />, <see cref="extLst" />, <see cref="pivotTables" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.sourceName" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerCacheDefinition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerCacheDefinition = x14 + "slicerCacheDefinition";

        /// <summary>
        /// Represents the x14:slicerCaches XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="slicerCache" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerCaches.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerCaches = x14 + "slicerCaches";

        /// <summary>
        /// Represents the x14:slicerList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="slicer" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerList = x14 + "slicerList";

        /// <summary>
        /// Represents the x14:slicers XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="slicer" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Slicers.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicers = x14 + "slicers";

        /// <summary>
        /// Represents the x14:slicerStyle XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="slicerStyles" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="slicerStyleElements" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerStyle.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerStyle = x14 + "slicerStyle";

        /// <summary>
        /// Represents the x14:slicerStyleElement XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="slicerStyleElements" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dxfId_" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerStyleElement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerStyleElement = x14 + "slicerStyleElement";

        /// <summary>
        /// Represents the x14:slicerStyleElements XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="slicerStyle" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="slicerStyleElement" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerStyleElements.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerStyleElements = x14 + "slicerStyleElements";

        /// <summary>
        /// Represents the x14:slicerStyles XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="slicerStyle" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.defaultSlicerStyle" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SlicerStyles.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName slicerStyles = x14 + "slicerStyles";

        /// <summary>
        /// Represents the x14:sortCondition XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.sortState" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.customList" />, <see cref="NoNamespace.descending" />, <see cref="NoNamespace.dxfId_" />, <see cref="NoNamespace.iconId" />, <see cref="NoNamespace.iconSet" />, <see cref="NoNamespace.@ref" />, <see cref="NoNamespace.sortBy" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SortCondition.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sortCondition = x14 + "sortCondition";

        /// <summary>
        /// Represents the x14:sourceConnection XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SourceConnection.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sourceConnection = x14 + "sourceConnection";

        /// <summary>
        /// Represents the x14:sparkline XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklines" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="XNE.f" />, <see cref="XNE.sqref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Sparkline.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sparkline = x14 + "sparkline";

        /// <summary>
        /// Represents the x14:sparklineGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklineGroups" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="colorAxis" />, <see cref="colorFirst" />, <see cref="colorHigh" />, <see cref="colorLast" />, <see cref="colorLow" />, <see cref="colorMarkers" />, <see cref="colorNegative" />, <see cref="colorSeries" />, <see cref="sparklines" />, <see cref="XNE.f" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dateAxis" />, <see cref="NoNamespace.displayEmptyCellsAs" />, <see cref="NoNamespace.displayHidden" />, <see cref="NoNamespace.displayXAxis" />, <see cref="NoNamespace.first" />, <see cref="NoNamespace.high" />, <see cref="NoNamespace.last" />, <see cref="NoNamespace.lineWeight" />, <see cref="NoNamespace.low" />, <see cref="NoNamespace.manualMax" />, <see cref="NoNamespace.manualMin" />, <see cref="NoNamespace.markers" />, <see cref="NoNamespace.maxAxisType" />, <see cref="NoNamespace.minAxisType" />, <see cref="NoNamespace.negative" />, <see cref="NoNamespace.rightToLeft" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SparklineGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sparklineGroup = x14 + "sparklineGroup";

        /// <summary>
        /// Represents the x14:sparklineGroups XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sparklineGroup" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SparklineGroups.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sparklineGroups = x14 + "sparklineGroups";

        /// <summary>
        /// Represents the x14:sparklines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="sparklineGroup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="sparkline" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Sparklines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sparklines = x14 + "sparklines";

        /// <summary>
        /// Represents the x14:table XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.altText" />, <see cref="NoNamespace.altTextSummary" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Table.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName table = x14 + "table";

        /// <summary>
        /// Represents the x14:tabular XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="data" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="items" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.crossFilter" />, <see cref="NoNamespace.customListSort" />, <see cref="NoNamespace.pivotCacheId" />, <see cref="NoNamespace.showMissing" />, <see cref="NoNamespace.sortOrder" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TabularSlicerCache.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tabular = x14 + "tabular";

        /// <summary>
        /// Represents the x14:tupleItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="tupleItems" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Xstring.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tupleItem = x14 + "tupleItem";

        /// <summary>
        /// Represents the x14:tupleItems XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotChange" />, <see cref="pivotEdit" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="tupleItem" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TupleItems.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tupleItems = x14 + "tupleItems";

        /// <summary>
        /// Represents the x14:tupleSet XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="calculatedMember" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="headers" />, <see cref="rows" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.columnCount" />, <see cref="NoNamespace.rowCount" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TupleSet.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tupleSet = x14 + "tupleSet";

        /// <summary>
        /// Represents the x14:userEdit XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="pivotEdit" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="editValue" />, <see cref="XNE.f" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PivotUserEdit.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName userEdit = x14 + "userEdit";

        /// <summary>
        /// Represents the x14:values XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="oleItem" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.value" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.cols" />, <see cref="NoNamespace.rows" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DdeValues.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName values = x14 + "values";

        /// <summary>
        /// Represents the x14:workbookPr XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.accuracyVersion" />, <see cref="NoNamespace.defaultImageDpi" />, <see cref="NoNamespace.discardImageEditData" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WorkbookProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName workbookPr = x14 + "workbookPr";
    }
}
