// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2013.Drawing.Chart
{
/// <summary>
/// <para>Defines the PivotSource Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:pivotSource.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PivotTableName &lt;c:name></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.FormatId &lt;c:fmtId></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PivotTableName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatId))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "pivotSource")]
[Id(ElementTypeIdConst)]
public partial class PivotSource : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13209;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotSource class.
    /// </summary>
    public PivotSource():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotSource class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotSource(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotSource class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotSource(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotSource class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotSource(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Pivot Name.</para>
    /// <para> Represents the following element tag in the schema: c:name </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.PivotTableName PivotTableName
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PivotTableName>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Format ID.</para>
    /// <para> Represents the following element tag in the schema: c:fmtId </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.FormatId FormatId
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.FormatId>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(2);
        set => SetElement(2, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotSource>(deep);

}
/// <summary>
/// <para>Defines the NumberingFormat Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:numFmt.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "numFmt")]
[Id(ElementTypeIdConst)]
public partial class NumberingFormat : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13210;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Number Format Code.</para>
    /// <para>Represents the following attribute in the schema: formatCode </para>
    /// </summary>
    [SchemaAttr(0, "formatCode")]
    [Index(0)]
    public StringValue FormatCode { get; set; }
	
    /// <summary>
    /// <para> Linked to Source.</para>
    /// <para>Represents the following attribute in the schema: sourceLinked </para>
    /// </summary>
    [SchemaAttr(0, "sourceLinked")]
    [Index(1)]
    public BooleanValue SourceLinked { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the NumberingFormat class.
    /// </summary>
    public NumberingFormat():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberingFormat>(deep);

}
/// <summary>
/// <para>Defines the ShapeProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:spPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Transform2D &lt;a:xfrm></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Transform2D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "spPr")]
[Id(ElementTypeIdConst)]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13211;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ShapeProperties class.
    /// </summary>
    public ShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> 2D Transform for Individual Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);

}
/// <summary>
/// <para>Defines the Layout Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:layout.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ManualLayout &lt;c:manualLayout></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "layout")]
[Id(ElementTypeIdConst)]
public partial class Layout : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13212;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the Layout class.
    /// </summary>
    public Layout():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Layout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Layout(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Layout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Layout(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Layout class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Layout(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Manual Layout.</para>
    /// <para> Represents the following element tag in the schema: c:manualLayout </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.ManualLayout ManualLayout
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Layout>(deep);

}
/// <summary>
/// <para>Defines the FullReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:fullRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SequenceOfReferences &lt;c15:sqref></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SequenceOfReferences), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "fullRef")]
[Id(ElementTypeIdConst)]
public partial class FullReference : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13213;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FullReference class.
    /// </summary>
    public FullReference():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FullReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FullReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FullReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FullReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FullReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FullReference(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SequenceOfReferences.</para>
    /// <para> Represents the following element tag in the schema: c15:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public SequenceOfReferences SequenceOfReferences
	{
        get => GetElement<SequenceOfReferences>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FullReference>(deep);

}
/// <summary>
/// <para>Defines the LevelReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:levelRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SequenceOfReferences &lt;c15:sqref></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SequenceOfReferences), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "levelRef")]
[Id(ElementTypeIdConst)]
public partial class LevelReference : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13214;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the LevelReference class.
    /// </summary>
    public LevelReference():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LevelReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LevelReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LevelReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LevelReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LevelReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LevelReference(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SequenceOfReferences.</para>
    /// <para> Represents the following element tag in the schema: c15:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public SequenceOfReferences SequenceOfReferences
	{
        get => GetElement<SequenceOfReferences>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LevelReference>(deep);

}
/// <summary>
/// <para>Defines the FormulaReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:formulaRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SequenceOfReferences &lt;c15:sqref></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SequenceOfReferences), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "formulaRef")]
[Id(ElementTypeIdConst)]
public partial class FormulaReference : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13215;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FormulaReference class.
    /// </summary>
    public FormulaReference():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FormulaReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FormulaReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FormulaReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FormulaReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FormulaReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FormulaReference(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SequenceOfReferences.</para>
    /// <para> Represents the following element tag in the schema: c15:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public SequenceOfReferences SequenceOfReferences
	{
        get => GetElement<SequenceOfReferences>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaReference>(deep);

}
/// <summary>
/// <para>Defines the FilteredSeriesTitle Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredSeriesTitle.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartText &lt;c15:tx></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ChartText), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "filteredSeriesTitle")]
[Id(ElementTypeIdConst)]
public partial class FilteredSeriesTitle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13216;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FilteredSeriesTitle class.
    /// </summary>
    public FilteredSeriesTitle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FilteredSeriesTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredSeriesTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredSeriesTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredSeriesTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredSeriesTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredSeriesTitle(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ChartText.</para>
    /// <para> Represents the following element tag in the schema: c15:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public ChartText ChartText
	{
        get => GetElement<ChartText>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredSeriesTitle>(deep);

}
/// <summary>
/// <para>Defines the FilteredCategoryTitle Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredCategoryTitle.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AxisDataSourceType &lt;c15:cat></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AxisDataSourceType), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "filteredCategoryTitle")]
[Id(ElementTypeIdConst)]
public partial class FilteredCategoryTitle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13217;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FilteredCategoryTitle class.
    /// </summary>
    public FilteredCategoryTitle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FilteredCategoryTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredCategoryTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredCategoryTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredCategoryTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredCategoryTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredCategoryTitle(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> AxisDataSourceType.</para>
    /// <para> Represents the following element tag in the schema: c15:cat </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public AxisDataSourceType AxisDataSourceType
	{
        get => GetElement<AxisDataSourceType>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredCategoryTitle>(deep);

}
/// <summary>
/// <para>Defines the FilteredAreaSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredAreaSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AreaChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AreaChartSeries), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "filteredAreaSeries")]
[Id(ElementTypeIdConst)]
public partial class FilteredAreaSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13218;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FilteredAreaSeries class.
    /// </summary>
    public FilteredAreaSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FilteredAreaSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredAreaSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredAreaSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredAreaSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredAreaSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredAreaSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> AreaChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public AreaChartSeries AreaChartSeries
	{
        get => GetElement<AreaChartSeries>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredAreaSeries>(deep);

}
/// <summary>
/// <para>Defines the FilteredBarSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredBarSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BarChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BarChartSeries), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "filteredBarSeries")]
[Id(ElementTypeIdConst)]
public partial class FilteredBarSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13219;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FilteredBarSeries class.
    /// </summary>
    public FilteredBarSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FilteredBarSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredBarSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredBarSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredBarSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredBarSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredBarSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> BarChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public BarChartSeries BarChartSeries
	{
        get => GetElement<BarChartSeries>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredBarSeries>(deep);

}
/// <summary>
/// <para>Defines the FilteredBubbleSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredBubbleSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BubbleChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BubbleChartSeries), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "filteredBubbleSeries")]
[Id(ElementTypeIdConst)]
public partial class FilteredBubbleSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13220;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FilteredBubbleSeries class.
    /// </summary>
    public FilteredBubbleSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FilteredBubbleSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredBubbleSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredBubbleSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredBubbleSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredBubbleSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredBubbleSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> BubbleChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public BubbleChartSeries BubbleChartSeries
	{
        get => GetElement<BubbleChartSeries>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredBubbleSeries>(deep);

}
/// <summary>
/// <para>Defines the FilteredLineSeriesExtension Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredLineSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LineChartSeries), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "filteredLineSeries")]
[Id(ElementTypeIdConst)]
public partial class FilteredLineSeriesExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13221;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FilteredLineSeriesExtension class.
    /// </summary>
    public FilteredLineSeriesExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FilteredLineSeriesExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredLineSeriesExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredLineSeriesExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredLineSeriesExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredLineSeriesExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredLineSeriesExtension(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> LineChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public LineChartSeries LineChartSeries
	{
        get => GetElement<LineChartSeries>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredLineSeriesExtension>(deep);

}
/// <summary>
/// <para>Defines the FilteredPieSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredPieSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PieChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PieChartSeries), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "filteredPieSeries")]
[Id(ElementTypeIdConst)]
public partial class FilteredPieSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13222;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FilteredPieSeries class.
    /// </summary>
    public FilteredPieSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FilteredPieSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredPieSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredPieSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredPieSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredPieSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredPieSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PieChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public PieChartSeries PieChartSeries
	{
        get => GetElement<PieChartSeries>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredPieSeries>(deep);

}
/// <summary>
/// <para>Defines the FilteredRadarSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredRadarSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RadarChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RadarChartSeries), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "filteredRadarSeries")]
[Id(ElementTypeIdConst)]
public partial class FilteredRadarSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13223;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FilteredRadarSeries class.
    /// </summary>
    public FilteredRadarSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FilteredRadarSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredRadarSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredRadarSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredRadarSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredRadarSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredRadarSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> RadarChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public RadarChartSeries RadarChartSeries
	{
        get => GetElement<RadarChartSeries>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredRadarSeries>(deep);

}
/// <summary>
/// <para>Defines the FilteredScatterSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredScatterSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ScatterChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ScatterChartSeries), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "filteredScatterSeries")]
[Id(ElementTypeIdConst)]
public partial class FilteredScatterSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13224;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FilteredScatterSeries class.
    /// </summary>
    public FilteredScatterSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FilteredScatterSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredScatterSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredScatterSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredScatterSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredScatterSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredScatterSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ScatterChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public ScatterChartSeries ScatterChartSeries
	{
        get => GetElement<ScatterChartSeries>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredScatterSeries>(deep);

}
/// <summary>
/// <para>Defines the FilteredSurfaceSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:filteredSurfaceSeries.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SurfaceChartSeries &lt;c15:ser></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SurfaceChartSeries), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "filteredSurfaceSeries")]
[Id(ElementTypeIdConst)]
public partial class FilteredSurfaceSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13225;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the FilteredSurfaceSeries class.
    /// </summary>
    public FilteredSurfaceSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FilteredSurfaceSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredSurfaceSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredSurfaceSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FilteredSurfaceSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FilteredSurfaceSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FilteredSurfaceSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SurfaceChartSeries.</para>
    /// <para> Represents the following element tag in the schema: c15:ser </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public SurfaceChartSeries SurfaceChartSeries
	{
        get => GetElement<SurfaceChartSeries>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FilteredSurfaceSeries>(deep);

}
/// <summary>
/// <para>Defines the DataLabelsRange Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:datalabelsRange.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;c15:f></description></item>
///<item><description>DataLabelsRangeChache &lt;c15:dlblRangeCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Formula), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataLabelsRangeChache), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "datalabelsRange")]
[Id(ElementTypeIdConst)]
public partial class DataLabelsRange : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13226;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the DataLabelsRange class.
    /// </summary>
    public DataLabelsRange():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DataLabelsRange class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelsRange(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelsRange class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelsRange(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelsRange class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelsRange(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: c15:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public Formula Formula
	{
        get => GetElement<Formula>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> DataLabelsRangeChache.</para>
    /// <para> Represents the following element tag in the schema: c15:dlblRangeCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(1)]
    public DataLabelsRangeChache DataLabelsRangeChache
	{
        get => GetElement<DataLabelsRangeChache>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelsRange>(deep);

}
/// <summary>
/// <para>Defines the CategoryFilterExceptions Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:categoryFilterExceptions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CategoryFilterException &lt;c15:categoryFilterException></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(CategoryFilterException), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "categoryFilterExceptions")]
[Id(ElementTypeIdConst)]
public partial class CategoryFilterExceptions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13227;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class.
    /// </summary>
    public CategoryFilterExceptions():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterExceptions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterExceptions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryFilterExceptions(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterExceptions>(deep);

}
/// <summary>
/// <para>Defines the DataLabelFieldTable Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:dlblFieldTable.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DataLabelFieldTableEntry &lt;c15:dlblFTEntry></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DataLabelFieldTableEntry), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "dlblFieldTable")]
[Id(ElementTypeIdConst)]
public partial class DataLabelFieldTable : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13228;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTable class.
    /// </summary>
    public DataLabelFieldTable():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DataLabelFieldTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTable(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTable(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTable class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelFieldTable(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelFieldTable>(deep);

}
/// <summary>
/// <para>Defines the ExceptionForSave Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:xForSave.</para>
/// </summary>

[SchemaAttr(64, "xForSave")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ExceptionForSave : BooleanType
{
    internal const int ElementTypeIdConst = 13229;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the ExceptionForSave class.
    /// </summary>
    public ExceptionForSave():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExceptionForSave>(deep);

}
/// <summary>
/// <para>Defines the ShowDataLabelsRange Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:showDataLabelsRange.</para>
/// </summary>

[SchemaAttr(64, "showDataLabelsRange")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ShowDataLabelsRange : BooleanType
{
    internal const int ElementTypeIdConst = 13230;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the ShowDataLabelsRange class.
    /// </summary>
    public ShowDataLabelsRange():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowDataLabelsRange>(deep);

}
/// <summary>
/// <para>Defines the ShowLeaderLines Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:showLeaderLines.</para>
/// </summary>

[SchemaAttr(64, "showLeaderLines")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ShowLeaderLines : BooleanType
{
    internal const int ElementTypeIdConst = 13232;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the ShowLeaderLines class.
    /// </summary>
    public ShowLeaderLines():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowLeaderLines>(deep);

}
/// <summary>
/// <para>Defines the AutoGeneneratedCategories Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:autoCat.</para>
/// </summary>

[SchemaAttr(64, "autoCat")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class AutoGeneneratedCategories : BooleanType
{
    internal const int ElementTypeIdConst = 13234;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the AutoGeneneratedCategories class.
    /// </summary>
    public AutoGeneneratedCategories():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoGeneneratedCategories>(deep);

}
/// <summary>
/// <para>Defines the InvertIfNegativeBoolean Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:invertIfNegative.</para>
/// </summary>

[SchemaAttr(64, "invertIfNegative")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class InvertIfNegativeBoolean : BooleanType
{
    internal const int ElementTypeIdConst = 13248;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the InvertIfNegativeBoolean class.
    /// </summary>
    public InvertIfNegativeBoolean():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertIfNegativeBoolean>(deep);

}
/// <summary>
/// <para>Defines the Bubble3D Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:bubble3D.</para>
/// </summary>

[SchemaAttr(64, "bubble3D")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Bubble3D : BooleanType
{
    internal const int ElementTypeIdConst = 13249;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the Bubble3D class.
    /// </summary>
    public Bubble3D():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bubble3D>(deep);

}
/// <summary>
/// Defines the BooleanType class.
/// </summary>


public abstract partial class BooleanType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> Boolean Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }
	

    
    
    
    /// <summary>
    /// Initializes a new instance of the BooleanType class.
    /// </summary>
    protected BooleanType(){}
    
    
    
}
/// <summary>
/// <para>Defines the ChartText Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:tx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringReference &lt;c:strRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.RichText &lt;c:rich></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringLiteral &lt;c:strLit></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.RichText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "tx")]
[Id(ElementTypeIdConst)]
public partial class ChartText : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13231;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ChartText class.
    /// </summary>
    public ChartText():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ChartText class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartText(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartText class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartText(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartText class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartText(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> String Reference.</para>
    /// <para> Represents the following element tag in the schema: c:strRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.StringReference StringReference
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Rich Text.</para>
    /// <para> Represents the following element tag in the schema: c:rich </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.RichText RichText
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.RichText>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> String Literal.</para>
    /// <para> Represents the following element tag in the schema: c:strLit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.StringLiteral StringLiteral
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>(2);
        set => SetElement(2, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartText>(deep);

}
/// <summary>
/// <para>Defines the LeaderLines Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:leaderLines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "leaderLines")]
[Id(ElementTypeIdConst)]
public partial class LeaderLines : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13233;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the LeaderLines class.
    /// </summary>
    public LeaderLines():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LeaderLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LeaderLines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LeaderLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LeaderLines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LeaderLines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LeaderLines(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeaderLines>(deep);

}
/// <summary>
/// <para>Defines the SequenceOfReferences Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:sqref.</para>
/// </summary>

[SchemaAttr(64, "sqref")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SequenceOfReferences : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13235;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the SequenceOfReferences class.
    /// </summary>
    public SequenceOfReferences():base(){}
    
        /// <summary>
    /// Initializes a new instance of the SequenceOfReferences class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public SequenceOfReferences(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SequenceOfReferences>(deep);

}
/// <summary>
/// <para>Defines the Formula Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:f.</para>
/// </summary>

[SchemaAttr(64, "f")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Formula : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13245;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the Formula class.
    /// </summary>
    public Formula():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Formula class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Formula(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);

}
/// <summary>
/// <para>Defines the TextFieldGuid Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:txfldGUID.</para>
/// </summary>

[SchemaAttr(64, "txfldGUID")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class TextFieldGuid : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13253;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the TextFieldGuid class.
    /// </summary>
    public TextFieldGuid():base(){}
    
        /// <summary>
    /// Initializes a new instance of the TextFieldGuid class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public TextFieldGuid(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextFieldGuid>(deep);

}
/// <summary>
/// <para>Defines the AxisDataSourceType Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:cat.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference &lt;c:multiLvlStrRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberReference &lt;c:numRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral &lt;c:numLit></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringReference &lt;c:strRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringLiteral &lt;c:strLit></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "cat")]
[Id(ElementTypeIdConst)]
public partial class AxisDataSourceType : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13236;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the AxisDataSourceType class.
    /// </summary>
    public AxisDataSourceType():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AxisDataSourceType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisDataSourceType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisDataSourceType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisDataSourceType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisDataSourceType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AxisDataSourceType(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Multi Level String Reference.</para>
    /// <para> Represents the following element tag in the schema: c:multiLvlStrRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference MultiLevelStringReference
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Number Reference.</para>
    /// <para> Represents the following element tag in the schema: c:numRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.NumberReference NumberReference
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Number Literal.</para>
    /// <para> Represents the following element tag in the schema: c:numLit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral NumberLiteral
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> StringReference.</para>
    /// <para> Represents the following element tag in the schema: c:strRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.StringReference StringReference
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> String Literal.</para>
    /// <para> Represents the following element tag in the schema: c:strLit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.Charts.StringLiteral StringLiteral
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>(4);
        set => SetElement(4, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisDataSourceType>(deep);

}
/// <summary>
/// <para>Defines the BarChartSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative &lt;c:invertIfNegative></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Shape &lt;c:shape></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Shape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "ser")]
[Id(ElementTypeIdConst)]
public partial class BarChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13237;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the BarChartSeries class.
    /// </summary>
    public BarChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BarChartSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> InvertIfNegative.</para>
    /// <para> Represents the following element tag in the schema: c:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative InvertIfNegative
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(5);
        set => SetElement(5, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChartSeries>(deep);

}
/// <summary>
/// <para>Defines the LineChartSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Marker &lt;c:marker></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Smooth &lt;c:smooth></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "ser")]
[Id(ElementTypeIdConst)]
public partial class LineChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13238;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the LineChartSeries class.
    /// </summary>
    public LineChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LineChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LineChartSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.Charts.Marker Marker
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(5);
        set => SetElement(5, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChartSeries>(deep);

}
/// <summary>
/// <para>Defines the ScatterChartSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Marker &lt;c:marker></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.XValues &lt;c:xVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.YValues &lt;c:yVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Smooth &lt;c:smooth></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "ser")]
[Id(ElementTypeIdConst)]
public partial class ScatterChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13239;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartSeries class.
    /// </summary>
    public ScatterChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ScatterChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ScatterChartSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.Charts.Marker Marker
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(4);
        set => SetElement(4, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChartSeries>(deep);

}
/// <summary>
/// <para>Defines the AreaChartSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "ser")]
[Id(ElementTypeIdConst)]
public partial class AreaChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13240;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the AreaChartSeries class.
    /// </summary>
    public AreaChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AreaChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AreaChartSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(4);
        set => SetElement(4, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChartSeries>(deep);

}
/// <summary>
/// <para>Defines the PieChartSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Explosion &lt;c:explosion></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Explosion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "ser")]
[Id(ElementTypeIdConst)]
public partial class PieChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13241;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the PieChartSeries class.
    /// </summary>
    public PieChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PieChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PieChartSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> Explosion.</para>
    /// <para> Represents the following element tag in the schema: c:explosion </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Drawing.Charts.Explosion Explosion
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Explosion>(5);
        set => SetElement(5, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChartSeries>(deep);

}
/// <summary>
/// <para>Defines the BubbleChartSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative &lt;c:invertIfNegative></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Trendline &lt;c:trendline></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ErrorBars &lt;c:errBars></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.XValues &lt;c:xVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.YValues &lt;c:yVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.BubbleSize &lt;c:bubbleSize></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Bubble3D &lt;c:bubble3D></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "ser")]
[Id(ElementTypeIdConst)]
public partial class BubbleChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13242;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartSeries class.
    /// </summary>
    public BubbleChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BubbleChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BubbleChartSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> InvertIfNegative.</para>
    /// <para> Represents the following element tag in the schema: c:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative InvertIfNegative
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative>(5);
        set => SetElement(5, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChartSeries>(deep);

}
/// <summary>
/// <para>Defines the RadarChartSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Marker &lt;c:marker></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataPoint &lt;c:dPt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabels &lt;c:dLbls></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "ser")]
[Id(ElementTypeIdConst)]
public partial class RadarChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13243;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the RadarChartSeries class.
    /// </summary>
    public RadarChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RadarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadarChartSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Drawing.Charts.Marker Marker
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Marker>(5);
        set => SetElement(5, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChartSeries>(deep);

}
/// <summary>
/// <para>Defines the SurfaceChartSeries Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Order &lt;c:order></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SeriesText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData &lt;c:cat></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Values &lt;c:val></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Bubble3D &lt;c:bubble3D></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "ser")]
[Id(ElementTypeIdConst)]
public partial class SurfaceChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13244;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartSeries class.
    /// </summary>
    public SurfaceChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurfaceChartSeries(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.Order Order
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Order>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.SeriesText SeriesText
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.Charts.PictureOptions PictureOptions
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> CategoryAxisData.</para>
    /// <para> Represents the following element tag in the schema: c:cat </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData CategoryAxisData
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>(5);
        set => SetElement(5, value);
	}
    
    /// <summary>
    /// <para> Values.</para>
    /// <para> Represents the following element tag in the schema: c:val </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(6)]
    public DocumentFormat.OpenXml.Drawing.Charts.Values Values
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Values>(6);
        set => SetElement(6, value);
	}
    
    /// <summary>
    /// <para> Bubble3D.</para>
    /// <para> Represents the following element tag in the schema: c:bubble3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(7)]
    public DocumentFormat.OpenXml.Drawing.Charts.Bubble3D Bubble3D
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>(7);
        set => SetElement(7, value);
	}
    
    /// <summary>
    /// <para> SurfaceSerExtensionList.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(8)]
    public DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList SurfaceSerExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList>(8);
        set => SetElement(8, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChartSeries>(deep);

}
/// <summary>
/// <para>Defines the DataLabelsRangeChache Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:dlblRangeCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(64, "dlblRangeCache")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabelsRangeChache : StringDataType
{
    internal const int ElementTypeIdConst = 13246;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DataLabelsRangeChache class.
    /// </summary>
    public DataLabelsRangeChache():base(){}
        /// <summary>
    ///Initializes a new instance of the DataLabelsRangeChache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelsRangeChache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelsRangeChache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelsRangeChache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelsRangeChache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelsRangeChache(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelsRangeChache>(deep);

}
/// <summary>
/// <para>Defines the DataLabelFieldTableCache Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:dlblFieldTableCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(64, "dlblFieldTableCache")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataLabelFieldTableCache : StringDataType
{
    internal const int ElementTypeIdConst = 13254;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTableCache class.
    /// </summary>
    public DataLabelFieldTableCache():base(){}
        /// <summary>
    ///Initializes a new instance of the DataLabelFieldTableCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTableCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTableCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTableCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTableCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelFieldTableCache(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelFieldTableCache>(deep);

}
/// <summary>
/// Defines the StringDataType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList))]

public abstract partial class StringDataType : OpenXmlCompositeElement
{
        
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PointCount.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>(0);
        set => SetElement(0, value);
	}
    


    
    /// <summary>
    /// Initializes a new instance of the StringDataType class.
    /// </summary>
    protected StringDataType(){}
    
        /// <summary>
    ///Initializes a new instance of the StringDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected StringDataType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected StringDataType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected StringDataType(string outerXml)
        : base(outerXml)
    {
    }
    

    
}
/// <summary>
/// <para>Defines the Explosion Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:explosion.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "explosion")]
[Id(ElementTypeIdConst)]
public partial class Explosion : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13247;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Integer Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public UInt32Value Val { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Explosion class.
    /// </summary>
    public Explosion():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Explosion>(deep);

}
/// <summary>
/// <para>Defines the Marker Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:marker.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Symbol &lt;c:symbol></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Size &lt;c:size></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Symbol))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Size))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "marker")]
[Id(ElementTypeIdConst)]
public partial class Marker : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13250;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the Marker class.
    /// </summary>
    public Marker():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Marker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Marker(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Marker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Marker(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Marker class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Marker(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Symbol.</para>
    /// <para> Represents the following element tag in the schema: c:symbol </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Symbol Symbol
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Symbol>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Size.</para>
    /// <para> Represents the following element tag in the schema: c:size </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.Size Size
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Size>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(3);
        set => SetElement(3, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Marker>(deep);

}
/// <summary>
/// <para>Defines the DataLabel Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:dLbl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Delete &lt;c:delete></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Layout &lt;c:layout></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat &lt;c:numFmt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.TextProperties &lt;c:txPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition &lt;c:dLblPos></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey &lt;c:showLegendKey></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowValue &lt;c:showVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName &lt;c:showCatName></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName &lt;c:showSerName></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowPercent &lt;c:showPercent></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize &lt;c:showBubbleSize></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Separator &lt;c:separator></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowValue))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowPercent))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Separator))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "dLbl")]
[Id(ElementTypeIdConst)]
public partial class DataLabel : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13251;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the DataLabel class.
    /// </summary>
    public DataLabel():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DataLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabel(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);

}
/// <summary>
/// <para>Defines the CategoryFilterException Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:categoryFilterException.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SequenceOfReferences &lt;c15:sqref></description></item>
///<item><description>ShapeProperties &lt;c15:spPr></description></item>
///<item><description>Explosion &lt;c15:explosion></description></item>
///<item><description>InvertIfNegativeBoolean &lt;c15:invertIfNegative></description></item>
///<item><description>Bubble3D &lt;c15:bubble3D></description></item>
///<item><description>Marker &lt;c15:marker></description></item>
///<item><description>DataLabel &lt;c15:dLbl></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SequenceOfReferences), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Explosion), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(InvertIfNegativeBoolean), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Bubble3D), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Marker), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataLabel), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "categoryFilterException")]
[Id(ElementTypeIdConst)]
public partial class CategoryFilterException : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13252;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class.
    /// </summary>
    public CategoryFilterException():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CategoryFilterException class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterException(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterException(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryFilterException(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SequenceOfReferences.</para>
    /// <para> Represents the following element tag in the schema: c15:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public SequenceOfReferences SequenceOfReferences
	{
        get => GetElement<SequenceOfReferences>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c15:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(1)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Explosion.</para>
    /// <para> Represents the following element tag in the schema: c15:explosion </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(2)]
    public Explosion Explosion
	{
        get => GetElement<Explosion>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> InvertIfNegativeBoolean.</para>
    /// <para> Represents the following element tag in the schema: c15:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(3)]
    public InvertIfNegativeBoolean InvertIfNegativeBoolean
	{
        get => GetElement<InvertIfNegativeBoolean>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> Bubble3D.</para>
    /// <para> Represents the following element tag in the schema: c15:bubble3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(4)]
    public Bubble3D Bubble3D
	{
        get => GetElement<Bubble3D>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c15:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(5)]
    public Marker Marker
	{
        get => GetElement<Marker>(5);
        set => SetElement(5, value);
	}
    
    /// <summary>
    /// <para> DataLabel.</para>
    /// <para> Represents the following element tag in the schema: c15:dLbl </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(6)]
    public DataLabel DataLabel
	{
        get => GetElement<DataLabel>(6);
        set => SetElement(6, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterException>(deep);

}
/// <summary>
/// <para>Defines the DataLabelFieldTableEntry Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c15:dlblFTEntry.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TextFieldGuid &lt;c15:txfldGUID></description></item>
///<item><description>Formula &lt;c15:f></description></item>
///<item><description>DataLabelFieldTableCache &lt;c15:dlblFieldTableCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TextFieldGuid), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Formula), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DataLabelFieldTableCache), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(64, "dlblFTEntry")]
[Id(ElementTypeIdConst)]
public partial class DataLabelFieldTableEntry : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13255;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTableEntry class.
    /// </summary>
    public DataLabelFieldTableEntry():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DataLabelFieldTableEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTableEntry(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTableEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabelFieldTableEntry(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabelFieldTableEntry class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabelFieldTableEntry(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> TextFieldGuid.</para>
    /// <para> Represents the following element tag in the schema: c15:txfldGUID </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(0)]
    public TextFieldGuid TextFieldGuid
	{
        get => GetElement<TextFieldGuid>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: c15:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(1)]
    public Formula Formula
	{
        get => GetElement<Formula>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> DataLabelFieldTableCache.</para>
    /// <para> Represents the following element tag in the schema: c15:dlblFieldTableCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c15 = http://schemas.microsoft.com/office/drawing/2012/chart
    /// </remark>
	[Index(2)]
    public DataLabelFieldTableCache DataLabelFieldTableCache
	{
        get => GetElement<DataLabelFieldTableCache>(2);
        set => SetElement(2, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelFieldTableEntry>(deep);

}
}
 
 
