// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office.Excel;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
/// <summary>
/// <para>Defines the PivotCaches Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotCaches.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
/// </list>
/// </remarks>

[SchemaAttr(71, "pivotCaches")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PivotCaches : OpenXmlPivotCachesElement
{
    internal const int ElementTypeIdConst = 13356;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the PivotCaches class.
    /// </summary>
    public PivotCaches():base(){}
        /// <summary>
    ///Initializes a new instance of the PivotCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotCaches(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotCaches(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotCaches class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotCaches(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCaches>(deep);

}
/// <summary>
/// <para>Defines the TimelineCachePivotCaches Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineCachePivotCaches.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
/// </list>
/// </remarks>

[SchemaAttr(71, "timelineCachePivotCaches")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineCachePivotCaches : OpenXmlPivotCachesElement
{
    internal const int ElementTypeIdConst = 13362;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the TimelineCachePivotCaches class.
    /// </summary>
    public TimelineCachePivotCaches():base(){}
        /// <summary>
    ///Initializes a new instance of the TimelineCachePivotCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCachePivotCaches(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineCachePivotCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCachePivotCaches(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineCachePivotCaches class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TimelineCachePivotCaches(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCachePivotCaches>(deep);

}
/// <summary>
/// Defines the OpenXmlPivotCachesElement class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotCache))]

public abstract partial class OpenXmlPivotCachesElement : OpenXmlCompositeElement
{
        
    
    
    
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlPivotCachesElement class.
    /// </summary>
    protected OpenXmlPivotCachesElement(){}
    
        /// <summary>
    ///Initializes a new instance of the OpenXmlPivotCachesElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlPivotCachesElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlPivotCachesElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlPivotCachesElement(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlPivotCachesElement class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected OpenXmlPivotCachesElement(string outerXml)
        : base(outerXml)
    {
    }
    

    
}
/// <summary>
/// <para>Defines the PivotTableReferences Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTableReferences.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotTableReference &lt;x15:pivotTableReference></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotTableReference), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotTableReferences")]
[Id(ElementTypeIdConst)]
public partial class PivotTableReferences : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13357;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotTableReferences class.
    /// </summary>
    public PivotTableReferences():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotTableReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableReferences(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotTableReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableReferences(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotTableReferences class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotTableReferences(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableReferences>(deep);

}
/// <summary>
/// <para>Defines the QueryTable Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:queryTable.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "queryTable")]
[Id(ElementTypeIdConst)]
public partial class QueryTable : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13358;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> clipped.</para>
    /// <para>Represents the following attribute in the schema: clipped </para>
    /// </summary>
    [SchemaAttr(0, "clipped")]
    [Index(0)]
    public BooleanValue Clipped { get; set; }
	
    /// <summary>
    /// <para> sourceDataName.</para>
    /// <para>Represents the following attribute in the schema: sourceDataName </para>
    /// </summary>
    [SchemaAttr(0, "sourceDataName")]
    [Index(1)]
    public StringValue SourceDataName { get; set; }
	
    /// <summary>
    /// <para> drillThrough.</para>
    /// <para>Represents the following attribute in the schema: drillThrough </para>
    /// </summary>
    [SchemaAttr(0, "drillThrough")]
    [Index(2)]
    public BooleanValue DrillThrough { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the QueryTable class.
    /// </summary>
    public QueryTable():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<QueryTable>(deep);

}
/// <summary>
/// <para>Defines the WebExtensions Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:webExtensions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtension &lt;x15:webExtension></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(WebExtension), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "webExtensions")]
[Id(ElementTypeIdConst)]
public partial class WebExtensions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13359;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the WebExtensions class.
    /// </summary>
    public WebExtensions():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WebExtensions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensions(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensions>(deep);

}
/// <summary>
/// <para>Defines the TimelineCacheReferences Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineCacheRefs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineCacheReference &lt;x15:timelineCacheRef></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TimelineCacheReference), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "timelineCacheRefs")]
[Id(ElementTypeIdConst)]
public partial class TimelineCacheReferences : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13360;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the TimelineCacheReferences class.
    /// </summary>
    public TimelineCacheReferences():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TimelineCacheReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCacheReferences(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineCacheReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCacheReferences(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineCacheReferences class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TimelineCacheReferences(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCacheReferences>(deep);

}
/// <summary>
/// <para>Defines the TimelineReferences Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineRefs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineReference &lt;x15:timelineRef></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TimelineReference), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "timelineRefs")]
[Id(ElementTypeIdConst)]
public partial class TimelineReferences : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13361;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the TimelineReferences class.
    /// </summary>
    public TimelineReferences():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TimelineReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineReferences(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineReferences(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineReferences class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TimelineReferences(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineReferences>(deep);

}
/// <summary>
/// <para>Defines the WorkbookProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:workbookPr.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "workbookPr")]
[Id(ElementTypeIdConst)]
public partial class WorkbookProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13363;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> chartTrackingRefBase.</para>
    /// <para>Represents the following attribute in the schema: chartTrackingRefBase </para>
    /// </summary>
    [SchemaAttr(0, "chartTrackingRefBase")]
    [Index(0)]
    public BooleanValue ChartTrackingReferenceBase { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WorkbookProperties class.
    /// </summary>
    public WorkbookProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorkbookProperties>(deep);

}
/// <summary>
/// <para>Defines the TimelineStyles Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineStyles.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineStyle &lt;x15:timelineStyle></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TimelineStyle), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "timelineStyles")]
[Id(ElementTypeIdConst)]
public partial class TimelineStyles : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13364;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> defaultTimelineStyle.</para>
    /// <para>Represents the following attribute in the schema: defaultTimelineStyle </para>
    /// </summary>
    [SchemaAttr(0, "defaultTimelineStyle")]
    [Index(0)]
    public StringValue DefaultTimelineStyle { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TimelineStyles class.
    /// </summary>
    public TimelineStyles():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TimelineStyles class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineStyles(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineStyles class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineStyles(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineStyles class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TimelineStyles(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyles>(deep);

}
/// <summary>
/// <para>Defines the DifferentialFormats Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dxfs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat &lt;x:dxf></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "dxfs")]
[Id(ElementTypeIdConst)]
public partial class DifferentialFormats : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13365;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Format Count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    [Index(0)]
    public UInt32Value Count { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the DifferentialFormats class.
    /// </summary>
    public DifferentialFormats():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DifferentialFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DifferentialFormats(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DifferentialFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DifferentialFormats(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DifferentialFormats class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DifferentialFormats(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DifferentialFormats>(deep);

}
/// <summary>
/// <para>Defines the Connection Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:connection.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TextProperties &lt;x15:textPr></description></item>
///<item><description>ModelTextProperties &lt;x15:modelTextPr></description></item>
///<item><description>RangeProperties &lt;x15:rangePr></description></item>
///<item><description>OleDbPrpoperties &lt;x15:oledbPr></description></item>
///<item><description>DataFeedProperties &lt;x15:dataFeedPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TextProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ModelTextProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(RangeProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(OleDbPrpoperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataFeedProperties), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "connection")]
[Id(ElementTypeIdConst)]
public partial class Connection : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13366;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> model.</para>
    /// <para>Represents the following attribute in the schema: model </para>
    /// </summary>
    [SchemaAttr(0, "model")]
    [Index(1)]
    public BooleanValue Model { get; set; }
	
    /// <summary>
    /// <para> excludeFromRefreshAll.</para>
    /// <para>Represents the following attribute in the schema: excludeFromRefreshAll </para>
    /// </summary>
    [SchemaAttr(0, "excludeFromRefreshAll")]
    [Index(2)]
    public BooleanValue ExcludeFromRefreshAll { get; set; }
	
    /// <summary>
    /// <para> autoDelete.</para>
    /// <para>Represents the following attribute in the schema: autoDelete </para>
    /// </summary>
    [SchemaAttr(0, "autoDelete")]
    [Index(3)]
    public BooleanValue AutoDelete { get; set; }
	
    /// <summary>
    /// <para> usedByAddin.</para>
    /// <para>Represents the following attribute in the schema: usedByAddin </para>
    /// </summary>
    [SchemaAttr(0, "usedByAddin")]
    [Index(4)]
    public BooleanValue UsedByAddin { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Connection class.
    /// </summary>
    public Connection():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Connection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Connection(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Connection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Connection(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Connection class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Connection(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> TextProperties.</para>
    /// <para> Represents the following element tag in the schema: x15:textPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public TextProperties TextProperties
	{
        get => GetElement<TextProperties>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> ModelTextProperties.</para>
    /// <para> Represents the following element tag in the schema: x15:modelTextPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(1)]
    public ModelTextProperties ModelTextProperties
	{
        get => GetElement<ModelTextProperties>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> RangeProperties.</para>
    /// <para> Represents the following element tag in the schema: x15:rangePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(2)]
    public RangeProperties RangeProperties
	{
        get => GetElement<RangeProperties>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> OleDbPrpoperties.</para>
    /// <para> Represents the following element tag in the schema: x15:oledbPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(3)]
    public OleDbPrpoperties OleDbPrpoperties
	{
        get => GetElement<OleDbPrpoperties>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> DataFeedProperties.</para>
    /// <para> Represents the following element tag in the schema: x15:dataFeedPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(4)]
    public DataFeedProperties DataFeedProperties
	{
        get => GetElement<DataFeedProperties>(4);
        set => SetElement(4, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Connection>(deep);

}
/// <summary>
/// <para>Defines the CalculatedMember Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:calculatedMember.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "calculatedMember")]
[Id(ElementTypeIdConst)]
public partial class CalculatedMember : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13367;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> measureGroup.</para>
    /// <para>Represents the following attribute in the schema: measureGroup </para>
    /// </summary>
    [SchemaAttr(0, "measureGroup")]
    [Index(0)]
    public StringValue MeasureGroup { get; set; }
	
    /// <summary>
    /// <para> numberFormat.</para>
    /// <para>Represents the following attribute in the schema: numberFormat </para>
    /// </summary>
    [SchemaAttr(0, "numberFormat")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.CalculatedMemberNumberFormat> NumberFormat { get; set; }
	
    /// <summary>
    /// <para> measure.</para>
    /// <para>Represents the following attribute in the schema: measure </para>
    /// </summary>
    [SchemaAttr(0, "measure")]
    [Index(2)]
    public BooleanValue Measure { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the CalculatedMember class.
    /// </summary>
    public CalculatedMember():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CalculatedMember>(deep);

}
/// <summary>
/// <para>Defines the PivotTableUISettings Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTableUISettings.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FieldListActiveTabTopLevelEntity &lt;x15:activeTabTopLevelEntity></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FieldListActiveTabTopLevelEntity), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotTableUISettings")]
[Id(ElementTypeIdConst)]
public partial class PivotTableUISettings : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13368;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> sourceDataName.</para>
    /// <para>Represents the following attribute in the schema: sourceDataName </para>
    /// </summary>
    [SchemaAttr(0, "sourceDataName")]
    [Index(0)]
    public StringValue SourceDataName { get; set; }
	
    /// <summary>
    /// <para> relNeededHidden.</para>
    /// <para>Represents the following attribute in the schema: relNeededHidden </para>
    /// </summary>
    [SchemaAttr(0, "relNeededHidden")]
    [Index(1)]
    public BooleanValue RelNeededHidden { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PivotTableUISettings class.
    /// </summary>
    public PivotTableUISettings():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotTableUISettings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableUISettings(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotTableUISettings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableUISettings(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotTableUISettings class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotTableUISettings(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableUISettings>(deep);

}
/// <summary>
/// <para>Defines the PivotFilter Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotFilter.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotFilter")]
[Id(ElementTypeIdConst)]
public partial class PivotFilter : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13369;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> useWholeDay.</para>
    /// <para>Represents the following attribute in the schema: useWholeDay </para>
    /// </summary>
    [SchemaAttr(0, "useWholeDay")]
    [Index(0)]
    public BooleanValue UseWholeDay { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PivotFilter class.
    /// </summary>
    public PivotFilter():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotFilter>(deep);

}
/// <summary>
/// <para>Defines the CachedUniqueNames Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:cachedUniqueNames.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CachedUniqueName &lt;x15:cachedUniqueName></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(CachedUniqueName), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "cachedUniqueNames")]
[Id(ElementTypeIdConst)]
public partial class CachedUniqueNames : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13370;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the CachedUniqueNames class.
    /// </summary>
    public CachedUniqueNames():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CachedUniqueNames class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CachedUniqueNames(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CachedUniqueNames class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CachedUniqueNames(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CachedUniqueNames class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CachedUniqueNames(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CachedUniqueNames>(deep);

}
/// <summary>
/// <para>Defines the CacheHierarchy Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:cacheHierarchy.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "cacheHierarchy")]
[Id(ElementTypeIdConst)]
public partial class CacheHierarchy : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13371;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> aggregatedColumn.</para>
    /// <para>Represents the following attribute in the schema: aggregatedColumn </para>
    /// </summary>
    [SchemaAttr(0, "aggregatedColumn")]
    [Index(0)]
    public Int32Value AggregatedColumn { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the CacheHierarchy class.
    /// </summary>
    public CacheHierarchy():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CacheHierarchy>(deep);

}
/// <summary>
/// <para>Defines the TimelinePivotCacheDefinition Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelinePivotCacheDefinition.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "timelinePivotCacheDefinition")]
[Id(ElementTypeIdConst)]
public partial class TimelinePivotCacheDefinition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13372;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> timelineData.</para>
    /// <para>Represents the following attribute in the schema: timelineData </para>
    /// </summary>
    [SchemaAttr(0, "timelineData")]
    [Index(0)]
    public BooleanValue TimelineData { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TimelinePivotCacheDefinition class.
    /// </summary>
    public TimelinePivotCacheDefinition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelinePivotCacheDefinition>(deep);

}
/// <summary>
/// <para>Defines the PivotCacheIdVersion Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotCacheIdVersion.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotCacheIdVersion")]
[Id(ElementTypeIdConst)]
public partial class PivotCacheIdVersion : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13373;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> cacheIdSupportedVersion.</para>
    /// <para>Represents the following attribute in the schema: cacheIdSupportedVersion </para>
    /// </summary>
    [SchemaAttr(0, "cacheIdSupportedVersion")]
    [Index(0)]
    public ByteValue CacheIdSupportedVersion { get; set; }
	
    /// <summary>
    /// <para> cacheIdCreatedVersion.</para>
    /// <para>Represents the following attribute in the schema: cacheIdCreatedVersion </para>
    /// </summary>
    [SchemaAttr(0, "cacheIdCreatedVersion")]
    [Index(1)]
    public ByteValue CacheIdCreatedVersion { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PivotCacheIdVersion class.
    /// </summary>
    public PivotCacheIdVersion():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCacheIdVersion>(deep);

}
/// <summary>
/// <para>Defines the DataModel Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dataModel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ModelTables &lt;x15:modelTables></description></item>
///<item><description>ModelRelationships &lt;x15:modelRelationships></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ModelTables), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ModelRelationships), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "dataModel")]
[Id(ElementTypeIdConst)]
public partial class DataModel : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13374;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> minVersionLoad.</para>
    /// <para>Represents the following attribute in the schema: minVersionLoad </para>
    /// </summary>
    [SchemaAttr(0, "minVersionLoad")]
    [Index(0)]
    public ByteValue MinVersionLoad { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the DataModel class.
    /// </summary>
    public DataModel():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DataModel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataModel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataModel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataModel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataModel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataModel(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ModelTables.</para>
    /// <para> Represents the following element tag in the schema: x15:modelTables </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public ModelTables ModelTables
	{
        get => GetElement<ModelTables>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> ModelRelationships.</para>
    /// <para> Represents the following element tag in the schema: x15:modelRelationships </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(1)]
    public ModelRelationships ModelRelationships
	{
        get => GetElement<ModelRelationships>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(2)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(2);
        set => SetElement(2, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModel>(deep);

}
/// <summary>
/// <para>Defines the PivotTableData Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTableData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotRow &lt;x15:pivotRow></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotRow), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotTableData")]
[Id(ElementTypeIdConst)]
public partial class PivotTableData : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13375;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> rowCount.</para>
    /// <para>Represents the following attribute in the schema: rowCount </para>
    /// </summary>
    [SchemaAttr(0, "rowCount")]
    [Index(0)]
    public UInt32Value RowCount { get; set; }
	
    /// <summary>
    /// <para> columnCount.</para>
    /// <para>Represents the following attribute in the schema: columnCount </para>
    /// </summary>
    [SchemaAttr(0, "columnCount")]
    [Index(1)]
    public UInt32Value ColumnCount { get; set; }
	
    /// <summary>
    /// <para> cacheId.</para>
    /// <para>Represents the following attribute in the schema: cacheId </para>
    /// </summary>
    [SchemaAttr(0, "cacheId")]
    [Index(2)]
    public UInt32Value CacheId { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PivotTableData class.
    /// </summary>
    public PivotTableData():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotTableData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotTableData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotTableData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotTableData(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableData>(deep);

}
/// <summary>
/// <para>Defines the PivotCacheDecoupled Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotCacheDecoupled.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotCacheDecoupled")]
[Id(ElementTypeIdConst)]
public partial class PivotCacheDecoupled : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13376;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> decoupled.</para>
    /// <para>Represents the following attribute in the schema: decoupled </para>
    /// </summary>
    [SchemaAttr(0, "decoupled")]
    [Index(0)]
    public BooleanValue Decoupled { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PivotCacheDecoupled class.
    /// </summary>
    public PivotCacheDecoupled():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCacheDecoupled>(deep);

}
/// <summary>
/// <para>Defines the DataField Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dataField.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "dataField")]
[Id(ElementTypeIdConst)]
public partial class DataField : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13377;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> isCountDistinct.</para>
    /// <para>Represents the following attribute in the schema: isCountDistinct </para>
    /// </summary>
    [SchemaAttr(0, "isCountDistinct")]
    [Index(0)]
    public BooleanValue IsCountDistinct { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the DataField class.
    /// </summary>
    public DataField():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataField>(deep);

}
/// <summary>
/// <para>Defines the MovingPeriodState Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:movingPeriodState.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "movingPeriodState")]
[Id(ElementTypeIdConst)]
public partial class MovingPeriodState : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13378;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> referenceDateBegin.</para>
    /// <para>Represents the following attribute in the schema: referenceDateBegin </para>
    /// </summary>
    [SchemaAttr(0, "referenceDateBegin")]
    [Index(0)]
    public DateTimeValue ReferenceDateBegin { get; set; }
	
    /// <summary>
    /// <para> referencePeriod.</para>
    /// <para>Represents the following attribute in the schema: referencePeriod </para>
    /// </summary>
    [SchemaAttr(0, "referencePeriod")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep> ReferencePeriod { get; set; }
	
    /// <summary>
    /// <para> referenceMultiple.</para>
    /// <para>Represents the following attribute in the schema: referenceMultiple </para>
    /// </summary>
    [SchemaAttr(0, "referenceMultiple")]
    [Index(2)]
    public UInt32Value ReferenceMultiple { get; set; }
	
    /// <summary>
    /// <para> movingPeriod.</para>
    /// <para>Represents the following attribute in the schema: movingPeriod </para>
    /// </summary>
    [SchemaAttr(0, "movingPeriod")]
    [Index(3)]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep> MovingPeriod { get; set; }
	
    /// <summary>
    /// <para> movingMultiple.</para>
    /// <para>Represents the following attribute in the schema: movingMultiple </para>
    /// </summary>
    [SchemaAttr(0, "movingMultiple")]
    [Index(4)]
    public UInt32Value MovingMultiple { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the MovingPeriodState class.
    /// </summary>
    public MovingPeriodState():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MovingPeriodState>(deep);

}
/// <summary>
/// <para>Defines the SlicerCaches Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:slicerCaches.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.SlicerCache &lt;x14:slicerCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCache), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "slicerCaches")]
[Id(ElementTypeIdConst)]
public partial class SlicerCaches : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13379;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the SlicerCaches class.
    /// </summary>
    public SlicerCaches():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCaches(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCaches(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCaches class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerCaches(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCaches>(deep);

}
/// <summary>
/// <para>Defines the TableSlicerCache Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:tableSlicerCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "tableSlicerCache")]
[Id(ElementTypeIdConst)]
public partial class TableSlicerCache : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13380;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> tableId.</para>
    /// <para>Represents the following attribute in the schema: tableId </para>
    /// </summary>
    [SchemaAttr(0, "tableId")]
    [Index(0)]
    public UInt32Value TableId { get; set; }
	
    /// <summary>
    /// <para> column.</para>
    /// <para>Represents the following attribute in the schema: column </para>
    /// </summary>
    [SchemaAttr(0, "column")]
    [Index(1)]
    public UInt32Value Column { get; set; }
	
    /// <summary>
    /// <para> sortOrder.</para>
    /// <para>Represents the following attribute in the schema: sortOrder </para>
    /// </summary>
    [SchemaAttr(0, "sortOrder")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues> SortOrder { get; set; }
	
    /// <summary>
    /// <para> customListSort.</para>
    /// <para>Represents the following attribute in the schema: customListSort </para>
    /// </summary>
    [SchemaAttr(0, "customListSort")]
    [Index(3)]
    public BooleanValue CustomListSort { get; set; }
	
    /// <summary>
    /// <para> crossFilter.</para>
    /// <para>Represents the following attribute in the schema: crossFilter </para>
    /// </summary>
    [SchemaAttr(0, "crossFilter")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues> CrossFilter { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TableSlicerCache class.
    /// </summary>
    public TableSlicerCache():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TableSlicerCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TableSlicerCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TableSlicerCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TableSlicerCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TableSlicerCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TableSlicerCache(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableSlicerCache>(deep);

}
/// <summary>
/// <para>Defines the SlicerCacheHideItemsWithNoData Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:slicerCacheHideItemsWithNoData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SlicerCacheOlapLevelName &lt;x15:slicerCacheOlapLevelName></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SlicerCacheOlapLevelName), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "slicerCacheHideItemsWithNoData")]
[Id(ElementTypeIdConst)]
public partial class SlicerCacheHideItemsWithNoData : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13381;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    [Index(0)]
    public UInt32Value Count { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class.
    /// </summary>
    public SlicerCacheHideItemsWithNoData():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerCacheHideItemsWithNoData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCacheHideItemsWithNoData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCacheHideItemsWithNoData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerCacheHideItemsWithNoData(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheHideItemsWithNoData>(deep);

}
/// <summary>
/// <para>Defines the SlicerCachePivotTables Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:slicerCachePivotTables.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable &lt;x14:pivotTable></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "slicerCachePivotTables")]
[Id(ElementTypeIdConst)]
public partial class SlicerCachePivotTables : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13382;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the SlicerCachePivotTables class.
    /// </summary>
    public SlicerCachePivotTables():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerCachePivotTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCachePivotTables(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCachePivotTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCachePivotTables(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCachePivotTables class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerCachePivotTables(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCachePivotTables>(deep);

}
/// <summary>
/// <para>Defines the Survey Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:survey.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SurveyPrSurveyElementPr &lt;x15:surveyPr></description></item>
///<item><description>TitlePrSurveyElementPr &lt;x15:titlePr></description></item>
///<item><description>DescriptionPrSurveyElementPr &lt;x15:descriptionPr></description></item>
///<item><description>SurveyQuestions &lt;x15:questions></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SurveyPrSurveyElementPr), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(TitlePrSurveyElementPr), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DescriptionPrSurveyElementPr), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(SurveyQuestions), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "survey")]
[Id(ElementTypeIdConst)]
public partial class Survey : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13383;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public UInt32Value Id { get; set; }
	
    /// <summary>
    /// <para> guid.</para>
    /// <para>Represents the following attribute in the schema: guid </para>
    /// </summary>
    [SchemaAttr(0, "guid")]
    [Index(1)]
    public StringValue Guid { get; set; }
	
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [Index(2)]
    public StringValue Title { get; set; }
	
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    [Index(3)]
    public StringValue Description { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Survey class.
    /// </summary>
    public Survey():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Survey class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Survey(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Survey class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Survey(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Survey class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Survey(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SurveyPrSurveyElementPr.</para>
    /// <para> Represents the following element tag in the schema: x15:surveyPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public SurveyPrSurveyElementPr SurveyPrSurveyElementPr
	{
        get => GetElement<SurveyPrSurveyElementPr>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> TitlePrSurveyElementPr.</para>
    /// <para> Represents the following element tag in the schema: x15:titlePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(1)]
    public TitlePrSurveyElementPr TitlePrSurveyElementPr
	{
        get => GetElement<TitlePrSurveyElementPr>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> DescriptionPrSurveyElementPr.</para>
    /// <para> Represents the following element tag in the schema: x15:descriptionPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(2)]
    public DescriptionPrSurveyElementPr DescriptionPrSurveyElementPr
	{
        get => GetElement<DescriptionPrSurveyElementPr>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> SurveyQuestions.</para>
    /// <para> Represents the following element tag in the schema: x15:questions </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(3)]
    public SurveyQuestions SurveyQuestions
	{
        get => GetElement<SurveyQuestions>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(4)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(4);
        set => SetElement(4, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Survey>(deep);

}
/// <summary>
/// <para>Defines the Timelines Class. The root element of TimeLinePart.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Timeline &lt;x15:timeline></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Timeline), FileFormatVersions.Office2013)]

[SchemaAttr(71, "timelines")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Timelines : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 13384;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    
	internal Timelines(TimeLinePart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the TimeLinePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(TimeLinePart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the TimeLinePart associated with this element.
    /// </summary>
    public TimeLinePart TimeLinePart
    {
		get => OpenXmlPart as TimeLinePart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the Timelines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Timelines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Timelines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Timelines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Timelines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Timelines(string outerXml)
        : base(outerXml)
    {
    }
    

    
    
    /// <summary>
    /// Initializes a new instance of the Timelines class.
    /// </summary>
    public Timelines():base(){}
    
    /// <summary>
    /// Saves the DOM into the TimeLinePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(TimeLinePart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Timelines>(deep);

}
/// <summary>
/// <para>Defines the TimelineCacheDefinition Class. The root element of TimeLineCachePart.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineCacheDefinition.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineCachePivotTables &lt;x15:pivotTables></description></item>
///<item><description>TimelineState &lt;x15:state></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TimelineCachePivotTables), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(TimelineState), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

[SchemaAttr(71, "timelineCacheDefinition")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TimelineCacheDefinition : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 13385;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> sourceName.</para>
    /// <para>Represents the following attribute in the schema: sourceName </para>
    /// </summary>
    [SchemaAttr(0, "sourceName")]
    [Index(1)]
    public StringValue SourceName { get; set; }
	

    
	internal TimelineCacheDefinition(TimeLineCachePart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the TimeLineCachePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(TimeLineCachePart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the TimeLineCachePart associated with this element.
    /// </summary>
    public TimeLineCachePart TimeLineCachePart
    {
		get => OpenXmlPart as TimeLineCachePart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the TimelineCacheDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCacheDefinition(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineCacheDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCacheDefinition(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineCacheDefinition class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TimelineCacheDefinition(string outerXml)
        : base(outerXml)
    {
    }
    

    
    
    /// <summary>
    /// Initializes a new instance of the TimelineCacheDefinition class.
    /// </summary>
    public TimelineCacheDefinition():base(){}
    
    /// <summary>
    /// Saves the DOM into the TimeLineCachePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(TimeLineCachePart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> TimelineCachePivotTables.</para>
    /// <para> Represents the following element tag in the schema: x15:pivotTables </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public TimelineCachePivotTables TimelineCachePivotTables
	{
        get => GetElement<TimelineCachePivotTables>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> TimelineState.</para>
    /// <para> Represents the following element tag in the schema: x15:state </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(1)]
    public TimelineState TimelineState
	{
        get => GetElement<TimelineState>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(2)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(2);
        set => SetElement(2, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCacheDefinition>(deep);

}
/// <summary>
/// <para>Defines the PivotTableReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTableReference.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotTableReference")]
[Id(ElementTypeIdConst)]
public partial class PivotTableReference : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13386;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PivotTableReference class.
    /// </summary>
    public PivotTableReference():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableReference>(deep);

}
/// <summary>
/// <para>Defines the WebExtension Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:webExtension.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "webExtension")]
[Id(ElementTypeIdConst)]
public partial class WebExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13387;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> appRef.</para>
    /// <para>Represents the following attribute in the schema: appRef </para>
    /// </summary>
    [SchemaAttr(0, "appRef")]
    [Index(0)]
    public StringValue ApplicationReference { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WebExtension class.
    /// </summary>
    public WebExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WebExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtension(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: xne:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Office.Excel.Formula Formula
	{
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtension>(deep);

}
/// <summary>
/// <para>Defines the TimelineCacheReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineCacheRef.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "timelineCacheRef")]
[Id(ElementTypeIdConst)]
public partial class TimelineCacheReference : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13388;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TimelineCacheReference class.
    /// </summary>
    public TimelineCacheReference():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCacheReference>(deep);

}
/// <summary>
/// <para>Defines the TimelineReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineRef.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "timelineRef")]
[Id(ElementTypeIdConst)]
public partial class TimelineReference : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13389;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TimelineReference class.
    /// </summary>
    public TimelineReference():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineReference>(deep);

}
/// <summary>
/// <para>Defines the TimelineStyle Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineStyle.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineStyleElements &lt;x15:timelineStyleElements></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TimelineStyleElements), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "timelineStyle")]
[Id(ElementTypeIdConst)]
public partial class TimelineStyle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13390;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TimelineStyle class.
    /// </summary>
    public TimelineStyle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TimelineStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineStyle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineStyle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineStyle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TimelineStyle(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> TimelineStyleElements.</para>
    /// <para> Represents the following element tag in the schema: x15:timelineStyleElements </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public TimelineStyleElements TimelineStyleElements
	{
        get => GetElement<TimelineStyleElements>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyle>(deep);

}
/// <summary>
/// <para>Defines the TimelineStyleElement Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineStyleElement.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "timelineStyleElement")]
[Id(ElementTypeIdConst)]
public partial class TimelineStyleElement : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13391;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleType> Type { get; set; }
	
    /// <summary>
    /// <para> dxfId.</para>
    /// <para>Represents the following attribute in the schema: dxfId </para>
    /// </summary>
    [SchemaAttr(0, "dxfId")]
    [Index(1)]
    public UInt32Value FormatId { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TimelineStyleElement class.
    /// </summary>
    public TimelineStyleElement():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyleElement>(deep);

}
/// <summary>
/// <para>Defines the TimelineStyleElements Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timelineStyleElements.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineStyleElement &lt;x15:timelineStyleElement></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TimelineStyleElement), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "timelineStyleElements")]
[Id(ElementTypeIdConst)]
public partial class TimelineStyleElements : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13392;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the TimelineStyleElements class.
    /// </summary>
    public TimelineStyleElements():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TimelineStyleElements class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineStyleElements(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineStyleElements class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineStyleElements(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineStyleElements class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TimelineStyleElements(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyleElements>(deep);

}
/// <summary>
/// <para>Defines the DbTable Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dbTable.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "dbTable")]
[Id(ElementTypeIdConst)]
public partial class DbTable : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13393;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the DbTable class.
    /// </summary>
    public DbTable():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DbTable>(deep);

}
/// <summary>
/// <para>Defines the DbTables Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dbTables.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DbTable &lt;x15:dbTable></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DbTable), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "dbTables")]
[Id(ElementTypeIdConst)]
public partial class DbTables : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13394;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the DbTables class.
    /// </summary>
    public DbTables():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DbTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DbTables(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DbTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DbTables(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DbTables class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DbTables(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DbTables>(deep);

}
/// <summary>
/// <para>Defines the DbCommand Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dbCommand.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "dbCommand")]
[Id(ElementTypeIdConst)]
public partial class DbCommand : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13395;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> text.</para>
    /// <para>Represents the following attribute in the schema: text </para>
    /// </summary>
    [SchemaAttr(0, "text")]
    [Index(0)]
    public StringValue Text { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the DbCommand class.
    /// </summary>
    public DbCommand():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DbCommand>(deep);

}
/// <summary>
/// <para>Defines the TextProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:textPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.TextFields &lt;x:textFields></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.TextFields))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "textPr")]
[Id(ElementTypeIdConst)]
public partial class TextProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13396;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> prompt.</para>
    /// <para>Represents the following attribute in the schema: prompt </para>
    /// </summary>
    [SchemaAttr(0, "prompt")]
    [Index(0)]
    public BooleanValue Prompt { get; set; }
	
    /// <summary>
    /// <para> fileType.</para>
    /// <para>Represents the following attribute in the schema: fileType </para>
    /// </summary>
    [SchemaAttr(0, "fileType")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.FileTypeValues> FileType { get; set; }
	
    /// <summary>
    /// <para> codePage.</para>
    /// <para>Represents the following attribute in the schema: codePage </para>
    /// </summary>
    [SchemaAttr(0, "codePage")]
    [Index(2)]
    public UInt32Value CodePage { get; set; }
	
    /// <summary>
    /// <para> characterSet.</para>
    /// <para>Represents the following attribute in the schema: characterSet </para>
    /// </summary>
    [SchemaAttr(0, "characterSet")]
    [Index(3)]
    public StringValue TextCharacterSet { get; set; }
	
    /// <summary>
    /// <para> firstRow.</para>
    /// <para>Represents the following attribute in the schema: firstRow </para>
    /// </summary>
    [SchemaAttr(0, "firstRow")]
    [Index(4)]
    public UInt32Value FirstRow { get; set; }
	
    /// <summary>
    /// <para> sourceFile.</para>
    /// <para>Represents the following attribute in the schema: sourceFile </para>
    /// </summary>
    [SchemaAttr(0, "sourceFile")]
    [Index(5)]
    public StringValue SourceFile { get; set; }
	
    /// <summary>
    /// <para> delimited.</para>
    /// <para>Represents the following attribute in the schema: delimited </para>
    /// </summary>
    [SchemaAttr(0, "delimited")]
    [Index(6)]
    public BooleanValue Delimited { get; set; }
	
    /// <summary>
    /// <para> decimal.</para>
    /// <para>Represents the following attribute in the schema: decimal </para>
    /// </summary>
    [SchemaAttr(0, "decimal")]
    [Index(7)]
    public StringValue Decimal { get; set; }
	
    /// <summary>
    /// <para> thousands.</para>
    /// <para>Represents the following attribute in the schema: thousands </para>
    /// </summary>
    [SchemaAttr(0, "thousands")]
    [Index(8)]
    public StringValue Thousands { get; set; }
	
    /// <summary>
    /// <para> tab.</para>
    /// <para>Represents the following attribute in the schema: tab </para>
    /// </summary>
    [SchemaAttr(0, "tab")]
    [Index(9)]
    public BooleanValue TabAsDelimiter { get; set; }
	
    /// <summary>
    /// <para> space.</para>
    /// <para>Represents the following attribute in the schema: space </para>
    /// </summary>
    [SchemaAttr(0, "space")]
    [Index(10)]
    public BooleanValue Space { get; set; }
	
    /// <summary>
    /// <para> comma.</para>
    /// <para>Represents the following attribute in the schema: comma </para>
    /// </summary>
    [SchemaAttr(0, "comma")]
    [Index(11)]
    public BooleanValue Comma { get; set; }
	
    /// <summary>
    /// <para> semicolon.</para>
    /// <para>Represents the following attribute in the schema: semicolon </para>
    /// </summary>
    [SchemaAttr(0, "semicolon")]
    [Index(12)]
    public BooleanValue Semicolon { get; set; }
	
    /// <summary>
    /// <para> consecutive.</para>
    /// <para>Represents the following attribute in the schema: consecutive </para>
    /// </summary>
    [SchemaAttr(0, "consecutive")]
    [Index(13)]
    public BooleanValue Consecutive { get; set; }
	
    /// <summary>
    /// <para> qualifier.</para>
    /// <para>Represents the following attribute in the schema: qualifier </para>
    /// </summary>
    [SchemaAttr(0, "qualifier")]
    [Index(14)]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.QualifierValues> Qualifier { get; set; }
	
    /// <summary>
    /// <para> delimiter.</para>
    /// <para>Represents the following attribute in the schema: delimiter </para>
    /// </summary>
    [SchemaAttr(0, "delimiter")]
    [Index(15)]
    public StringValue Delimiter { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TextProperties class.
    /// </summary>
    public TextProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TextProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> TextFields.</para>
    /// <para> Represents the following element tag in the schema: x:textFields </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Spreadsheet.TextFields TextFields
	{
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.TextFields>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextProperties>(deep);

}
/// <summary>
/// <para>Defines the ModelTextProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:modelTextPr.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "modelTextPr")]
[Id(ElementTypeIdConst)]
public partial class ModelTextProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13397;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> headers.</para>
    /// <para>Represents the following attribute in the schema: headers </para>
    /// </summary>
    [SchemaAttr(0, "headers")]
    [Index(0)]
    public BooleanValue Headers { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ModelTextProperties class.
    /// </summary>
    public ModelTextProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTextProperties>(deep);

}
/// <summary>
/// <para>Defines the RangeProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:rangePr.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "rangePr")]
[Id(ElementTypeIdConst)]
public partial class RangeProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13398;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> sourceName.</para>
    /// <para>Represents the following attribute in the schema: sourceName </para>
    /// </summary>
    [SchemaAttr(0, "sourceName")]
    [Index(0)]
    public StringValue SourceName { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the RangeProperties class.
    /// </summary>
    public RangeProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RangeProperties>(deep);

}
/// <summary>
/// <para>Defines the OleDbPrpoperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:oledbPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DbTables &lt;x15:dbTables></description></item>
///<item><description>DbCommand &lt;x15:dbCommand></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DbTables), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DbCommand), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "oledbPr")]
[Id(ElementTypeIdConst)]
public partial class OleDbPrpoperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13399;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> connection.</para>
    /// <para>Represents the following attribute in the schema: connection </para>
    /// </summary>
    [SchemaAttr(0, "connection")]
    [Index(0)]
    public StringValue Connection { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the OleDbPrpoperties class.
    /// </summary>
    public OleDbPrpoperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OleDbPrpoperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OleDbPrpoperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OleDbPrpoperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OleDbPrpoperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OleDbPrpoperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OleDbPrpoperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> DbTables.</para>
    /// <para> Represents the following element tag in the schema: x15:dbTables </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public DbTables DbTables
	{
        get => GetElement<DbTables>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> DbCommand.</para>
    /// <para> Represents the following element tag in the schema: x15:dbCommand </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(1)]
    public DbCommand DbCommand
	{
        get => GetElement<DbCommand>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleDbPrpoperties>(deep);

}
/// <summary>
/// <para>Defines the DataFeedProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:dataFeedPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DbTables &lt;x15:dbTables></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DbTables), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "dataFeedPr")]
[Id(ElementTypeIdConst)]
public partial class DataFeedProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13400;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> connection.</para>
    /// <para>Represents the following attribute in the schema: connection </para>
    /// </summary>
    [SchemaAttr(0, "connection")]
    [Index(0)]
    public StringValue Connection { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the DataFeedProperties class.
    /// </summary>
    public DataFeedProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DataFeedProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataFeedProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataFeedProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataFeedProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataFeedProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataFeedProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> DbTables.</para>
    /// <para> Represents the following element tag in the schema: x15:dbTables </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public DbTables DbTables
	{
        get => GetElement<DbTables>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataFeedProperties>(deep);

}
/// <summary>
/// <para>Defines the FieldListActiveTabTopLevelEntity Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:activeTabTopLevelEntity.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "activeTabTopLevelEntity")]
[Id(ElementTypeIdConst)]
public partial class FieldListActiveTabTopLevelEntity : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13401;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(1)]
    public UInt32Value Type { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the FieldListActiveTabTopLevelEntity class.
    /// </summary>
    public FieldListActiveTabTopLevelEntity():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FieldListActiveTabTopLevelEntity>(deep);

}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Extension &lt;x:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "extLst")]
[Id(ElementTypeIdConst)]
public partial class ExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13402;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ExtensionList class.
    /// </summary>
    public ExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ExtensionList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);

}
/// <summary>
/// <para>Defines the CachedUniqueName Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:cachedUniqueName.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "cachedUniqueName")]
[Id(ElementTypeIdConst)]
public partial class CachedUniqueName : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13403;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> index.</para>
    /// <para>Represents the following attribute in the schema: index </para>
    /// </summary>
    [SchemaAttr(0, "index")]
    [Index(0)]
    public UInt32Value Index { get; set; }
	
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(1)]
    public StringValue Name { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the CachedUniqueName class.
    /// </summary>
    public CachedUniqueName():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CachedUniqueName>(deep);

}
/// <summary>
/// <para>Defines the ModelTable Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:modelTable.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "modelTable")]
[Id(ElementTypeIdConst)]
public partial class ModelTable : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13404;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(1)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> connection.</para>
    /// <para>Represents the following attribute in the schema: connection </para>
    /// </summary>
    [SchemaAttr(0, "connection")]
    [Index(2)]
    public StringValue Connection { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ModelTable class.
    /// </summary>
    public ModelTable():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTable>(deep);

}
/// <summary>
/// <para>Defines the ModelRelationship Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:modelRelationship.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "modelRelationship")]
[Id(ElementTypeIdConst)]
public partial class ModelRelationship : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13405;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> fromTable.</para>
    /// <para>Represents the following attribute in the schema: fromTable </para>
    /// </summary>
    [SchemaAttr(0, "fromTable")]
    [Index(0)]
    public StringValue FromTable { get; set; }
	
    /// <summary>
    /// <para> fromColumn.</para>
    /// <para>Represents the following attribute in the schema: fromColumn </para>
    /// </summary>
    [SchemaAttr(0, "fromColumn")]
    [Index(1)]
    public StringValue FromColumn { get; set; }
	
    /// <summary>
    /// <para> toTable.</para>
    /// <para>Represents the following attribute in the schema: toTable </para>
    /// </summary>
    [SchemaAttr(0, "toTable")]
    [Index(2)]
    public StringValue ToTable { get; set; }
	
    /// <summary>
    /// <para> toColumn.</para>
    /// <para>Represents the following attribute in the schema: toColumn </para>
    /// </summary>
    [SchemaAttr(0, "toColumn")]
    [Index(3)]
    public StringValue ToColumn { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ModelRelationship class.
    /// </summary>
    public ModelRelationship():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelRelationship>(deep);

}
/// <summary>
/// <para>Defines the ModelTables Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:modelTables.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ModelTable &lt;x15:modelTable></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ModelTable), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "modelTables")]
[Id(ElementTypeIdConst)]
public partial class ModelTables : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13406;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ModelTables class.
    /// </summary>
    public ModelTables():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ModelTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ModelTables(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ModelTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ModelTables(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ModelTables class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ModelTables(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTables>(deep);

}
/// <summary>
/// <para>Defines the ModelRelationships Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:modelRelationships.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ModelRelationship &lt;x15:modelRelationship></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ModelRelationship), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "modelRelationships")]
[Id(ElementTypeIdConst)]
public partial class ModelRelationships : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13407;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ModelRelationships class.
    /// </summary>
    public ModelRelationships():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ModelRelationships class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ModelRelationships(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ModelRelationships class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ModelRelationships(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ModelRelationships class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ModelRelationships(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelRelationships>(deep);

}
/// <summary>
/// <para>Defines the PivotValueCell Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:c.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Xstring &lt;x15:v></description></item>
///<item><description>PivotValueCellExtra &lt;x15:x></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Xstring), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(PivotValueCellExtra), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "c")]
[Id(ElementTypeIdConst)]
public partial class PivotValueCell : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13408;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> i.</para>
    /// <para>Represents the following attribute in the schema: i </para>
    /// </summary>
    [SchemaAttr(0, "i")]
    [Index(0)]
    public UInt32Value Item { get; set; }
	
    /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SXVCellType> Text { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PivotValueCell class.
    /// </summary>
    public PivotValueCell():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotValueCell class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotValueCell(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotValueCell class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotValueCell(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotValueCell class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotValueCell(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Xstring.</para>
    /// <para> Represents the following element tag in the schema: x15:v </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public Xstring Xstring
	{
        get => GetElement<Xstring>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> PivotValueCellExtra.</para>
    /// <para> Represents the following element tag in the schema: x15:x </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(1)]
    public PivotValueCellExtra PivotValueCellExtra
	{
        get => GetElement<PivotValueCellExtra>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotValueCell>(deep);

}
/// <summary>
/// <para>Defines the Xstring Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:v.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "v")]
[Id(ElementTypeIdConst)]
public partial class Xstring : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13409;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the Xstring class.
    /// </summary>
    public Xstring():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the Xstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Xstring(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xstring>(deep);

}
/// <summary>
/// <para>Defines the PivotValueCellExtra Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:x.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "x")]
[Id(ElementTypeIdConst)]
public partial class PivotValueCellExtra : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13410;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> in.</para>
    /// <para>Represents the following attribute in the schema: in </para>
    /// </summary>
    [SchemaAttr(0, "in")]
    [Index(0)]
    public UInt32Value FormatIndex { get; set; }
	
    /// <summary>
    /// <para> bc.</para>
    /// <para>Represents the following attribute in the schema: bc </para>
    /// </summary>
    [SchemaAttr(0, "bc")]
    [Index(1)]
    public HexBinaryValue BackgroundColor { get; set; }
	
    /// <summary>
    /// <para> fc.</para>
    /// <para>Represents the following attribute in the schema: fc </para>
    /// </summary>
    [SchemaAttr(0, "fc")]
    [Index(2)]
    public HexBinaryValue ForegroundColor { get; set; }
	
    /// <summary>
    /// <para> i.</para>
    /// <para>Represents the following attribute in the schema: i </para>
    /// </summary>
    [SchemaAttr(0, "i")]
    [Index(3)]
    public BooleanValue Italic { get; set; }
	
    /// <summary>
    /// <para> un.</para>
    /// <para>Represents the following attribute in the schema: un </para>
    /// </summary>
    [SchemaAttr(0, "un")]
    [Index(4)]
    public BooleanValue Underline { get; set; }
	
    /// <summary>
    /// <para> st.</para>
    /// <para>Represents the following attribute in the schema: st </para>
    /// </summary>
    [SchemaAttr(0, "st")]
    [Index(5)]
    public BooleanValue Strikethrough { get; set; }
	
    /// <summary>
    /// <para> b.</para>
    /// <para>Represents the following attribute in the schema: b </para>
    /// </summary>
    [SchemaAttr(0, "b")]
    [Index(6)]
    public BooleanValue Bold { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PivotValueCellExtra class.
    /// </summary>
    public PivotValueCellExtra():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotValueCellExtra>(deep);

}
/// <summary>
/// <para>Defines the PivotTableServerFormats Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTableServerFormats.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ServerFormat &lt;x15:serverFormat></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ServerFormat), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotTableServerFormats")]
[Id(ElementTypeIdConst)]
public partial class PivotTableServerFormats : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13411;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    [Index(0)]
    public UInt32Value Count { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PivotTableServerFormats class.
    /// </summary>
    public PivotTableServerFormats():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotTableServerFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableServerFormats(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotTableServerFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableServerFormats(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotTableServerFormats class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotTableServerFormats(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableServerFormats>(deep);

}
/// <summary>
/// <para>Defines the ServerFormat Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:serverFormat.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "serverFormat")]
[Id(ElementTypeIdConst)]
public partial class ServerFormat : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13412;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Culture.</para>
    /// <para>Represents the following attribute in the schema: culture </para>
    /// </summary>
    [SchemaAttr(0, "culture")]
    [Index(0)]
    public StringValue Culture { get; set; }
	
    /// <summary>
    /// <para> Format.</para>
    /// <para>Represents the following attribute in the schema: format </para>
    /// </summary>
    [SchemaAttr(0, "format")]
    [Index(1)]
    public StringValue Format { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ServerFormat class.
    /// </summary>
    public ServerFormat():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ServerFormat>(deep);

}
/// <summary>
/// <para>Defines the SlicerCacheOlapLevelName Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:slicerCacheOlapLevelName.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "slicerCacheOlapLevelName")]
[Id(ElementTypeIdConst)]
public partial class SlicerCacheOlapLevelName : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13413;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> uniqueName.</para>
    /// <para>Represents the following attribute in the schema: uniqueName </para>
    /// </summary>
    [SchemaAttr(0, "uniqueName")]
    [Index(0)]
    public StringValue UniqueName { get; set; }
	
    /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    [Index(1)]
    public UInt32Value Count { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the SlicerCacheOlapLevelName class.
    /// </summary>
    public SlicerCacheOlapLevelName():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheOlapLevelName>(deep);

}
/// <summary>
/// <para>Defines the SurveyPrSurveyElementPr Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:surveyPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(71, "surveyPr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SurveyPrSurveyElementPr : OpenXmlSurveyElementPrElement
{
    internal const int ElementTypeIdConst = 13414;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the SurveyPrSurveyElementPr class.
    /// </summary>
    public SurveyPrSurveyElementPr():base(){}
        /// <summary>
    ///Initializes a new instance of the SurveyPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurveyPrSurveyElementPr(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurveyPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurveyPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurveyPrSurveyElementPr class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurveyPrSurveyElementPr(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurveyPrSurveyElementPr>(deep);

}
/// <summary>
/// <para>Defines the TitlePrSurveyElementPr Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:titlePr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(71, "titlePr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TitlePrSurveyElementPr : OpenXmlSurveyElementPrElement
{
    internal const int ElementTypeIdConst = 13415;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the TitlePrSurveyElementPr class.
    /// </summary>
    public TitlePrSurveyElementPr():base(){}
        /// <summary>
    ///Initializes a new instance of the TitlePrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TitlePrSurveyElementPr(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TitlePrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TitlePrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TitlePrSurveyElementPr class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TitlePrSurveyElementPr(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TitlePrSurveyElementPr>(deep);

}
/// <summary>
/// <para>Defines the DescriptionPrSurveyElementPr Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:descriptionPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(71, "descriptionPr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DescriptionPrSurveyElementPr : OpenXmlSurveyElementPrElement
{
    internal const int ElementTypeIdConst = 13416;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DescriptionPrSurveyElementPr class.
    /// </summary>
    public DescriptionPrSurveyElementPr():base(){}
        /// <summary>
    ///Initializes a new instance of the DescriptionPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DescriptionPrSurveyElementPr(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DescriptionPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DescriptionPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DescriptionPrSurveyElementPr class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DescriptionPrSurveyElementPr(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DescriptionPrSurveyElementPr>(deep);

}
/// <summary>
/// <para>Defines the QuestionsPrSurveyElementPr Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:questionsPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(71, "questionsPr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class QuestionsPrSurveyElementPr : OpenXmlSurveyElementPrElement
{
    internal const int ElementTypeIdConst = 13418;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the QuestionsPrSurveyElementPr class.
    /// </summary>
    public QuestionsPrSurveyElementPr():base(){}
        /// <summary>
    ///Initializes a new instance of the QuestionsPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public QuestionsPrSurveyElementPr(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the QuestionsPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public QuestionsPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the QuestionsPrSurveyElementPr class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public QuestionsPrSurveyElementPr(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuestionsPrSurveyElementPr>(deep);

}
/// <summary>
/// <para>Defines the QuestionPrSurveyElementPr Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:questionPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(71, "questionPr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class QuestionPrSurveyElementPr : OpenXmlSurveyElementPrElement
{
    internal const int ElementTypeIdConst = 13420;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the QuestionPrSurveyElementPr class.
    /// </summary>
    public QuestionPrSurveyElementPr():base(){}
        /// <summary>
    ///Initializes a new instance of the QuestionPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public QuestionPrSurveyElementPr(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the QuestionPrSurveyElementPr class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public QuestionPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the QuestionPrSurveyElementPr class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public QuestionPrSurveyElementPr(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuestionPrSurveyElementPr>(deep);

}
/// <summary>
/// Defines the OpenXmlSurveyElementPrElement class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

public abstract partial class OpenXmlSurveyElementPrElement : OpenXmlCompositeElement
{
        
        /// <summary>
    /// <para> cssClass.</para>
    /// <para>Represents the following attribute in the schema: cssClass </para>
    /// </summary>
    [SchemaAttr(0, "cssClass")]
    [Index(0)]
    public StringValue CssClass { get; set; }
	
    /// <summary>
    /// <para> bottom.</para>
    /// <para>Represents the following attribute in the schema: bottom </para>
    /// </summary>
    [SchemaAttr(0, "bottom")]
    [Index(1)]
    public Int32Value Bottom { get; set; }
	
    /// <summary>
    /// <para> top.</para>
    /// <para>Represents the following attribute in the schema: top </para>
    /// </summary>
    [SchemaAttr(0, "top")]
    [Index(2)]
    public Int32Value Top { get; set; }
	
    /// <summary>
    /// <para> left.</para>
    /// <para>Represents the following attribute in the schema: left </para>
    /// </summary>
    [SchemaAttr(0, "left")]
    [Index(3)]
    public Int32Value Left { get; set; }
	
    /// <summary>
    /// <para> right.</para>
    /// <para>Represents the following attribute in the schema: right </para>
    /// </summary>
    [SchemaAttr(0, "right")]
    [Index(4)]
    public Int32Value Right { get; set; }
	
    /// <summary>
    /// <para> width.</para>
    /// <para>Represents the following attribute in the schema: width </para>
    /// </summary>
    [SchemaAttr(0, "width")]
    [Index(5)]
    public UInt32Value Width { get; set; }
	
    /// <summary>
    /// <para> height.</para>
    /// <para>Represents the following attribute in the schema: height </para>
    /// </summary>
    [SchemaAttr(0, "height")]
    [Index(6)]
    public UInt32Value Height { get; set; }
	
    /// <summary>
    /// <para> position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    [Index(7)]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SurveyPosition> Position { get; set; }
	

    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(0);
        set => SetElement(0, value);
	}
    


    
    /// <summary>
    /// Initializes a new instance of the OpenXmlSurveyElementPrElement class.
    /// </summary>
    protected OpenXmlSurveyElementPrElement(){}
    
        /// <summary>
    ///Initializes a new instance of the OpenXmlSurveyElementPrElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlSurveyElementPrElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlSurveyElementPrElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlSurveyElementPrElement(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlSurveyElementPrElement class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected OpenXmlSurveyElementPrElement(string outerXml)
        : base(outerXml)
    {
    }
    

    
}
/// <summary>
/// <para>Defines the SurveyQuestions Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:questions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuestionsPrSurveyElementPr &lt;x15:questionsPr></description></item>
///<item><description>SurveyQuestion &lt;x15:question></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(QuestionsPrSurveyElementPr), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(SurveyQuestion), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "questions")]
[Id(ElementTypeIdConst)]
public partial class SurveyQuestions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13417;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the SurveyQuestions class.
    /// </summary>
    public SurveyQuestions():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SurveyQuestions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurveyQuestions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurveyQuestions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurveyQuestions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurveyQuestions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurveyQuestions(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> QuestionsPrSurveyElementPr.</para>
    /// <para> Represents the following element tag in the schema: x15:questionsPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public QuestionsPrSurveyElementPr QuestionsPrSurveyElementPr
	{
        get => GetElement<QuestionsPrSurveyElementPr>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurveyQuestions>(deep);

}
/// <summary>
/// <para>Defines the SurveyQuestion Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:question.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuestionPrSurveyElementPr &lt;x15:questionPr></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(QuestionPrSurveyElementPr), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "question")]
[Id(ElementTypeIdConst)]
public partial class SurveyQuestion : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13419;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> binding.</para>
    /// <para>Represents the following attribute in the schema: binding </para>
    /// </summary>
    [SchemaAttr(0, "binding")]
    [Index(0)]
    public UInt32Value Binding { get; set; }
	
    /// <summary>
    /// <para> text.</para>
    /// <para>Represents the following attribute in the schema: text </para>
    /// </summary>
    [SchemaAttr(0, "text")]
    [Index(1)]
    public StringValue Text { get; set; }
	
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionType> Type { get; set; }
	
    /// <summary>
    /// <para> format.</para>
    /// <para>Represents the following attribute in the schema: format </para>
    /// </summary>
    [SchemaAttr(0, "format")]
    [Index(3)]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionFormat> Format { get; set; }
	
    /// <summary>
    /// <para> helpText.</para>
    /// <para>Represents the following attribute in the schema: helpText </para>
    /// </summary>
    [SchemaAttr(0, "helpText")]
    [Index(4)]
    public StringValue HelpText { get; set; }
	
    /// <summary>
    /// <para> required.</para>
    /// <para>Represents the following attribute in the schema: required </para>
    /// </summary>
    [SchemaAttr(0, "required")]
    [Index(5)]
    public BooleanValue Required { get; set; }
	
    /// <summary>
    /// <para> defaultValue.</para>
    /// <para>Represents the following attribute in the schema: defaultValue </para>
    /// </summary>
    [SchemaAttr(0, "defaultValue")]
    [Index(6)]
    public StringValue DefaultValue { get; set; }
	
    /// <summary>
    /// <para> decimalPlaces.</para>
    /// <para>Represents the following attribute in the schema: decimalPlaces </para>
    /// </summary>
    [SchemaAttr(0, "decimalPlaces")]
    [Index(7)]
    public UInt32Value DecimalPlaces { get; set; }
	
    /// <summary>
    /// <para> rowSource.</para>
    /// <para>Represents the following attribute in the schema: rowSource </para>
    /// </summary>
    [SchemaAttr(0, "rowSource")]
    [Index(8)]
    public StringValue RowSource { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the SurveyQuestion class.
    /// </summary>
    public SurveyQuestion():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SurveyQuestion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurveyQuestion(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurveyQuestion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurveyQuestion(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurveyQuestion class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurveyQuestion(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> QuestionPrSurveyElementPr.</para>
    /// <para> Represents the following element tag in the schema: x15:questionPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public QuestionPrSurveyElementPr QuestionPrSurveyElementPr
	{
        get => GetElement<QuestionPrSurveyElementPr>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(1)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurveyQuestion>(deep);

}
/// <summary>
/// <para>Defines the Timeline Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:timeline.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "timeline")]
[Id(ElementTypeIdConst)]
public partial class Timeline : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13421;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> cache.</para>
    /// <para>Represents the following attribute in the schema: cache </para>
    /// </summary>
    [SchemaAttr(0, "cache")]
    [Index(1)]
    public StringValue Cache { get; set; }
	
    /// <summary>
    /// <para> caption.</para>
    /// <para>Represents the following attribute in the schema: caption </para>
    /// </summary>
    [SchemaAttr(0, "caption")]
    [Index(2)]
    public StringValue Caption { get; set; }
	
    /// <summary>
    /// <para> showHeader.</para>
    /// <para>Represents the following attribute in the schema: showHeader </para>
    /// </summary>
    [SchemaAttr(0, "showHeader")]
    [Index(3)]
    public BooleanValue ShowHeader { get; set; }
	
    /// <summary>
    /// <para> showSelectionLabel.</para>
    /// <para>Represents the following attribute in the schema: showSelectionLabel </para>
    /// </summary>
    [SchemaAttr(0, "showSelectionLabel")]
    [Index(4)]
    public BooleanValue ShowSelectionLabel { get; set; }
	
    /// <summary>
    /// <para> showTimeLevel.</para>
    /// <para>Represents the following attribute in the schema: showTimeLevel </para>
    /// </summary>
    [SchemaAttr(0, "showTimeLevel")]
    [Index(5)]
    public BooleanValue ShowTimeLevel { get; set; }
	
    /// <summary>
    /// <para> showHorizontalScrollbar.</para>
    /// <para>Represents the following attribute in the schema: showHorizontalScrollbar </para>
    /// </summary>
    [SchemaAttr(0, "showHorizontalScrollbar")]
    [Index(6)]
    public BooleanValue ShowHorizontalScrollbar { get; set; }
	
    /// <summary>
    /// <para> level.</para>
    /// <para>Represents the following attribute in the schema: level </para>
    /// </summary>
    [SchemaAttr(0, "level")]
    [Index(7)]
    public UInt32Value Level { get; set; }
	
    /// <summary>
    /// <para> selectionLevel.</para>
    /// <para>Represents the following attribute in the schema: selectionLevel </para>
    /// </summary>
    [SchemaAttr(0, "selectionLevel")]
    [Index(8)]
    public UInt32Value SelectionLevel { get; set; }
	
    /// <summary>
    /// <para> scrollPosition.</para>
    /// <para>Represents the following attribute in the schema: scrollPosition </para>
    /// </summary>
    [SchemaAttr(0, "scrollPosition")]
    [Index(9)]
    public DateTimeValue ScrollPosition { get; set; }
	
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    [Index(10)]
    public StringValue Style { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Timeline class.
    /// </summary>
    public Timeline():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Timeline class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Timeline(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Timeline class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Timeline(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Timeline class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Timeline(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Timeline>(deep);

}
/// <summary>
/// <para>Defines the TimelineCachePivotTable Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTable.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotTable")]
[Id(ElementTypeIdConst)]
public partial class TimelineCachePivotTable : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13422;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> tabId.</para>
    /// <para>Represents the following attribute in the schema: tabId </para>
    /// </summary>
    [SchemaAttr(0, "tabId")]
    [Index(0)]
    public UInt32Value TabId { get; set; }
	
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(1)]
    public StringValue Name { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TimelineCachePivotTable class.
    /// </summary>
    public TimelineCachePivotTable():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCachePivotTable>(deep);

}
/// <summary>
/// <para>Defines the SelectionTimelineRange Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:selection.</para>
/// </summary>

[SchemaAttr(71, "selection")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SelectionTimelineRange : TimelineRange
{
    internal const int ElementTypeIdConst = 13423;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the SelectionTimelineRange class.
    /// </summary>
    public SelectionTimelineRange():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SelectionTimelineRange>(deep);

}
/// <summary>
/// <para>Defines the BoundsTimelineRange Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:bounds.</para>
/// </summary>

[SchemaAttr(71, "bounds")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class BoundsTimelineRange : TimelineRange
{
    internal const int ElementTypeIdConst = 13424;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the BoundsTimelineRange class.
    /// </summary>
    public BoundsTimelineRange():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BoundsTimelineRange>(deep);

}
/// <summary>
/// Defines the TimelineRange class.
/// </summary>


public abstract partial class TimelineRange : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> startDate.</para>
    /// <para>Represents the following attribute in the schema: startDate </para>
    /// </summary>
    [SchemaAttr(0, "startDate")]
    [Index(0)]
    public DateTimeValue StartDate { get; set; }
	
    /// <summary>
    /// <para> endDate.</para>
    /// <para>Represents the following attribute in the schema: endDate </para>
    /// </summary>
    [SchemaAttr(0, "endDate")]
    [Index(1)]
    public DateTimeValue EndDate { get; set; }
	

    
    
    
    /// <summary>
    /// Initializes a new instance of the TimelineRange class.
    /// </summary>
    protected TimelineRange(){}
    
    
    
}
/// <summary>
/// <para>Defines the AutoFilter Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:autoFilter.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.FilterColumn &lt;x:filterColumn></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.SortState &lt;x:sortState></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.FilterColumn))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SortState))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "autoFilter")]
[Id(ElementTypeIdConst)]
public partial class AutoFilter : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13425;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Cell or Range Reference.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    [Index(0)]
    public StringValue Reference { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the AutoFilter class.
    /// </summary>
    public AutoFilter():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AutoFilter class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AutoFilter(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AutoFilter class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AutoFilter(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AutoFilter class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AutoFilter(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoFilter>(deep);

}
/// <summary>
/// <para>Defines the TimelineCachePivotTables Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotTables.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TimelineCachePivotTable &lt;x15:pivotTable></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TimelineCachePivotTable), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotTables")]
[Id(ElementTypeIdConst)]
public partial class TimelineCachePivotTables : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13426;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the TimelineCachePivotTables class.
    /// </summary>
    public TimelineCachePivotTables():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TimelineCachePivotTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCachePivotTables(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineCachePivotTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineCachePivotTables(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineCachePivotTables class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TimelineCachePivotTables(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCachePivotTables>(deep);

}
/// <summary>
/// <para>Defines the TimelineState Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:state.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SelectionTimelineRange &lt;x15:selection></description></item>
///<item><description>BoundsTimelineRange &lt;x15:bounds></description></item>
///<item><description>MovingPeriodState &lt;x15:movingPeriodState></description></item>
///<item><description>ExtensionList &lt;x15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SelectionTimelineRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(BoundsTimelineRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(MovingPeriodState), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "state")]
[Id(ElementTypeIdConst)]
public partial class TimelineState : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13427;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> singleRangeFilterState.</para>
    /// <para>Represents the following attribute in the schema: singleRangeFilterState </para>
    /// </summary>
    [SchemaAttr(0, "singleRangeFilterState")]
    [Index(0)]
    public BooleanValue SingleRangeFilterState { get; set; }
	
    /// <summary>
    /// <para> minimalRefreshVersion.</para>
    /// <para>Represents the following attribute in the schema: minimalRefreshVersion </para>
    /// </summary>
    [SchemaAttr(0, "minimalRefreshVersion")]
    [Index(1)]
    public UInt32Value MinimalRefreshVersion { get; set; }
	
    /// <summary>
    /// <para> lastRefreshVersion.</para>
    /// <para>Represents the following attribute in the schema: lastRefreshVersion </para>
    /// </summary>
    [SchemaAttr(0, "lastRefreshVersion")]
    [Index(2)]
    public UInt32Value LastRefreshVersion { get; set; }
	
    /// <summary>
    /// <para> pivotCacheId.</para>
    /// <para>Represents the following attribute in the schema: pivotCacheId </para>
    /// </summary>
    [SchemaAttr(0, "pivotCacheId")]
    [Index(3)]
    public UInt32Value PivotCacheId { get; set; }
	
    /// <summary>
    /// <para> filterType.</para>
    /// <para>Represents the following attribute in the schema: filterType </para>
    /// </summary>
    [SchemaAttr(0, "filterType")]
    [Index(4)]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotFilterValues> FilterType { get; set; }
	
    /// <summary>
    /// <para> filterId.</para>
    /// <para>Represents the following attribute in the schema: filterId </para>
    /// </summary>
    [SchemaAttr(0, "filterId")]
    [Index(5)]
    public UInt32Value FilterId { get; set; }
	
    /// <summary>
    /// <para> filterTabId.</para>
    /// <para>Represents the following attribute in the schema: filterTabId </para>
    /// </summary>
    [SchemaAttr(0, "filterTabId")]
    [Index(6)]
    public UInt32Value FilterTabId { get; set; }
	
    /// <summary>
    /// <para> filterPivotName.</para>
    /// <para>Represents the following attribute in the schema: filterPivotName </para>
    /// </summary>
    [SchemaAttr(0, "filterPivotName")]
    [Index(7)]
    public StringValue FilterPivotName { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TimelineState class.
    /// </summary>
    public TimelineState():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TimelineState class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineState(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineState class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TimelineState(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TimelineState class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TimelineState(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SelectionTimelineRange.</para>
    /// <para> Represents the following element tag in the schema: x15:selection </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(0)]
    public SelectionTimelineRange SelectionTimelineRange
	{
        get => GetElement<SelectionTimelineRange>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> BoundsTimelineRange.</para>
    /// <para> Represents the following element tag in the schema: x15:bounds </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(1)]
    public BoundsTimelineRange BoundsTimelineRange
	{
        get => GetElement<BoundsTimelineRange>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> MovingPeriodState.</para>
    /// <para> Represents the following element tag in the schema: x15:movingPeriodState </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(2)]
    public MovingPeriodState MovingPeriodState
	{
        get => GetElement<MovingPeriodState>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
    /// </remark>
	[Index(3)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(3);
        set => SetElement(3, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineState>(deep);

}
/// <summary>
/// <para>Defines the PivotRow Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15:pivotRow.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotValueCell &lt;x15:c></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotValueCell), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(71, "pivotRow")]
[Id(ElementTypeIdConst)]
public partial class PivotRow : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13428;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    [Index(0)]
    public UInt32Value Reference { get; set; }
	
    /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    [Index(1)]
    public UInt32Value Count { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PivotRow class.
    /// </summary>
    public PivotRow():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotRow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotRow(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotRow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotRow(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotRow class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotRow(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotRow>(deep);

}
/// <summary>
/// Defines the TimelineStyleType enumeration. 
/// </summary> 
public enum TimelineStyleType
{  
	///<summary>
///selectionLabel.
///<para>When the item is serialized out as xml, its value is "selectionLabel".</para>
///</summary>
[EnumString("selectionLabel")]
SelectionLabel,
///<summary>
///timeLevel.
///<para>When the item is serialized out as xml, its value is "timeLevel".</para>
///</summary>
[EnumString("timeLevel")]
TimeLevel,
///<summary>
///periodLabel1.
///<para>When the item is serialized out as xml, its value is "periodLabel1".</para>
///</summary>
[EnumString("periodLabel1")]
PeriodLabel1,
///<summary>
///periodLabel2.
///<para>When the item is serialized out as xml, its value is "periodLabel2".</para>
///</summary>
[EnumString("periodLabel2")]
PeriodLabel2,
///<summary>
///selectedTimeBlock.
///<para>When the item is serialized out as xml, its value is "selectedTimeBlock".</para>
///</summary>
[EnumString("selectedTimeBlock")]
SelectedTimeBlock,
///<summary>
///unselectedTimeBlock.
///<para>When the item is serialized out as xml, its value is "unselectedTimeBlock".</para>
///</summary>
[EnumString("unselectedTimeBlock")]
UnselectedTimeBlock,
///<summary>
///selectedTimeBlockSpace.
///<para>When the item is serialized out as xml, its value is "selectedTimeBlockSpace".</para>
///</summary>
[EnumString("selectedTimeBlockSpace")]
SelectedTimeBlockSpace,
 
}
/// <summary>
/// Defines the CalculatedMemberNumberFormat enumeration. 
/// </summary> 
public enum CalculatedMemberNumberFormat
{  
	///<summary>
///default.
///<para>When the item is serialized out as xml, its value is "default".</para>
///</summary>
[EnumString("default")]
Default,
///<summary>
///number.
///<para>When the item is serialized out as xml, its value is "number".</para>
///</summary>
[EnumString("number")]
Number,
///<summary>
///percent.
///<para>When the item is serialized out as xml, its value is "percent".</para>
///</summary>
[EnumString("percent")]
Percent,
 
}
/// <summary>
/// Defines the SXVCellType enumeration. 
/// </summary> 
public enum SXVCellType
{  
	///<summary>
///b.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Boolean,
///<summary>
///n.
///<para>When the item is serialized out as xml, its value is "n".</para>
///</summary>
[EnumString("n")]
Number,
///<summary>
///e.
///<para>When the item is serialized out as xml, its value is "e".</para>
///</summary>
[EnumString("e")]
Error,
///<summary>
///str.
///<para>When the item is serialized out as xml, its value is "str".</para>
///</summary>
[EnumString("str")]
String,
///<summary>
///d.
///<para>When the item is serialized out as xml, its value is "d".</para>
///</summary>
[EnumString("d")]
Date,
///<summary>
///bl.
///<para>When the item is serialized out as xml, its value is "bl".</para>
///</summary>
[EnumString("bl")]
Blank,
 
}
/// <summary>
/// Defines the MovingPeriodStep enumeration. 
/// </summary> 
public enum MovingPeriodStep
{  
	///<summary>
///year.
///<para>When the item is serialized out as xml, its value is "year".</para>
///</summary>
[EnumString("year")]
Year,
///<summary>
///quarter.
///<para>When the item is serialized out as xml, its value is "quarter".</para>
///</summary>
[EnumString("quarter")]
Quarter,
///<summary>
///month.
///<para>When the item is serialized out as xml, its value is "month".</para>
///</summary>
[EnumString("month")]
Month,
///<summary>
///week.
///<para>When the item is serialized out as xml, its value is "week".</para>
///</summary>
[EnumString("week")]
Week,
///<summary>
///day.
///<para>When the item is serialized out as xml, its value is "day".</para>
///</summary>
[EnumString("day")]
Day,
 
}
/// <summary>
/// Defines the QuestionType enumeration. 
/// </summary> 
public enum QuestionType
{  
	///<summary>
///checkBox.
///<para>When the item is serialized out as xml, its value is "checkBox".</para>
///</summary>
[EnumString("checkBox")]
CheckBox,
///<summary>
///choice.
///<para>When the item is serialized out as xml, its value is "choice".</para>
///</summary>
[EnumString("choice")]
Choice,
///<summary>
///date.
///<para>When the item is serialized out as xml, its value is "date".</para>
///</summary>
[EnumString("date")]
Date,
///<summary>
///time.
///<para>When the item is serialized out as xml, its value is "time".</para>
///</summary>
[EnumString("time")]
Time,
///<summary>
///multipleLinesOfText.
///<para>When the item is serialized out as xml, its value is "multipleLinesOfText".</para>
///</summary>
[EnumString("multipleLinesOfText")]
MultipleLinesOfText,
///<summary>
///number.
///<para>When the item is serialized out as xml, its value is "number".</para>
///</summary>
[EnumString("number")]
Number,
///<summary>
///singleLineOfText.
///<para>When the item is serialized out as xml, its value is "singleLineOfText".</para>
///</summary>
[EnumString("singleLineOfText")]
SingleLineOfText,
 
}
/// <summary>
/// Defines the QuestionFormat enumeration. 
/// </summary> 
public enum QuestionFormat
{  
	///<summary>
///generalDate.
///<para>When the item is serialized out as xml, its value is "generalDate".</para>
///</summary>
[EnumString("generalDate")]
GeneralDate,
///<summary>
///longDate.
///<para>When the item is serialized out as xml, its value is "longDate".</para>
///</summary>
[EnumString("longDate")]
LongDate,
///<summary>
///shortDate.
///<para>When the item is serialized out as xml, its value is "shortDate".</para>
///</summary>
[EnumString("shortDate")]
ShortDate,
///<summary>
///longTime.
///<para>When the item is serialized out as xml, its value is "longTime".</para>
///</summary>
[EnumString("longTime")]
LongTime,
///<summary>
///shortTime.
///<para>When the item is serialized out as xml, its value is "shortTime".</para>
///</summary>
[EnumString("shortTime")]
ShortTime,
///<summary>
///generalNumber.
///<para>When the item is serialized out as xml, its value is "generalNumber".</para>
///</summary>
[EnumString("generalNumber")]
GeneralNumber,
///<summary>
///standard.
///<para>When the item is serialized out as xml, its value is "standard".</para>
///</summary>
[EnumString("standard")]
Standard,
///<summary>
///fixed.
///<para>When the item is serialized out as xml, its value is "fixed".</para>
///</summary>
[EnumString("fixed")]
Fixed,
///<summary>
///percent.
///<para>When the item is serialized out as xml, its value is "percent".</para>
///</summary>
[EnumString("percent")]
Percent,
///<summary>
///currency.
///<para>When the item is serialized out as xml, its value is "currency".</para>
///</summary>
[EnumString("currency")]
Currency,
 
}
/// <summary>
/// Defines the SurveyPosition enumeration. 
/// </summary> 
public enum SurveyPosition
{  
	///<summary>
///absolute.
///<para>When the item is serialized out as xml, its value is "absolute".</para>
///</summary>
[EnumString("absolute")]
Absolute,
///<summary>
///fixed.
///<para>When the item is serialized out as xml, its value is "fixed".</para>
///</summary>
[EnumString("fixed")]
Fixed,
///<summary>
///relative.
///<para>When the item is serialized out as xml, its value is "relative".</para>
///</summary>
[EnumString("relative")]
Relative,
///<summary>
///static.
///<para>When the item is serialized out as xml, its value is "static".</para>
///</summary>
[EnumString("static")]
Static,
///<summary>
///inherit.
///<para>When the item is serialized out as xml, its value is "inherit".</para>
///</summary>
[EnumString("inherit")]
Inherit,
 
}
}
 
 
