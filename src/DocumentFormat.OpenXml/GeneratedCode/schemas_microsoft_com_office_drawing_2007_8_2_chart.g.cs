// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentFormat.OpenXml.Office2010.Drawing.Charts
{
/// <summary>
/// <para>Defines the PivotOptions Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:pivotOptions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DropZoneFilter &lt;c14:dropZoneFilter></description></item>
///<item><description>DropZoneCategories &lt;c14:dropZoneCategories></description></item>
///<item><description>DropZoneData &lt;c14:dropZoneData></description></item>
///<item><description>DropZoneSeries &lt;c14:dropZoneSeries></description></item>
///<item><description>DropZonesVisible &lt;c14:dropZonesVisible></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DropZoneFilter), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropZoneCategories), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropZoneData), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropZoneSeries), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropZonesVisible), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(46, "pivotOptions")]
[Id(ElementTypeIdConst)]
public partial class PivotOptions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12762;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotOptions class.
    /// </summary>
    public PivotOptions():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotOptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotOptions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotOptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotOptions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotOptions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotOptions(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> DropZoneFilter.</para>
    /// <para> Represents the following element tag in the schema: c14:dropZoneFilter </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
	[Index(0)]
    public DropZoneFilter DropZoneFilter
	{
        get => GetElement<DropZoneFilter>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> DropZoneCategories.</para>
    /// <para> Represents the following element tag in the schema: c14:dropZoneCategories </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
	[Index(1)]
    public DropZoneCategories DropZoneCategories
	{
        get => GetElement<DropZoneCategories>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> DropZoneData.</para>
    /// <para> Represents the following element tag in the schema: c14:dropZoneData </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
	[Index(2)]
    public DropZoneData DropZoneData
	{
        get => GetElement<DropZoneData>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> DropZoneSeries.</para>
    /// <para> Represents the following element tag in the schema: c14:dropZoneSeries </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
	[Index(3)]
    public DropZoneSeries DropZoneSeries
	{
        get => GetElement<DropZoneSeries>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> DropZonesVisible.</para>
    /// <para> Represents the following element tag in the schema: c14:dropZonesVisible </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
	[Index(4)]
    public DropZonesVisible DropZonesVisible
	{
        get => GetElement<DropZonesVisible>(4);
        set => SetElement(4, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotOptions>(deep);

}
/// <summary>
/// <para>Defines the SketchOptions Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:sketchOptions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>InSketchMode &lt;c14:inSketchMode></description></item>
///<item><description>ShowSketchButton &lt;c14:showSketchBtn></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(InSketchMode), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ShowSketchButton), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(46, "sketchOptions")]
[Id(ElementTypeIdConst)]
public partial class SketchOptions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12763;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the SketchOptions class.
    /// </summary>
    public SketchOptions():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SketchOptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SketchOptions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SketchOptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SketchOptions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SketchOptions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SketchOptions(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> InSketchMode.</para>
    /// <para> Represents the following element tag in the schema: c14:inSketchMode </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
	[Index(0)]
    public InSketchMode InSketchMode
	{
        get => GetElement<InSketchMode>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> ShowSketchButton.</para>
    /// <para> Represents the following element tag in the schema: c14:showSketchBtn </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
	[Index(1)]
    public ShowSketchButton ShowSketchButton
	{
        get => GetElement<ShowSketchButton>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SketchOptions>(deep);

}
/// <summary>
/// <para>Defines the InvertSolidFillFormat Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:invertSolidFillFmt.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;c14:spPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(46, "invertSolidFillFmt")]
[Id(ElementTypeIdConst)]
public partial class InvertSolidFillFormat : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12764;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the InvertSolidFillFormat class.
    /// </summary>
    public InvertSolidFillFormat():base(){}
    
        /// <summary>
    ///Initializes a new instance of the InvertSolidFillFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public InvertSolidFillFormat(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the InvertSolidFillFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public InvertSolidFillFormat(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the InvertSolidFillFormat class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public InvertSolidFillFormat(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c14:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
	[Index(0)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertSolidFillFormat>(deep);

}
/// <summary>
/// <para>Defines the Style Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:style.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(46, "style")]
[Id(ElementTypeIdConst)]
public partial class Style : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12765;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public ByteValue Val { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Style class.
    /// </summary>
    public Style():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);

}
/// <summary>
/// <para>Defines the ShapeProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:spPr.</para>
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(46, "spPr")]
[Id(ElementTypeIdConst)]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12766;
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
/// <para>Defines the DropZoneFilter Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:dropZoneFilter.</para>
/// </summary>

[SchemaAttr(46, "dropZoneFilter")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropZoneFilter : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12767;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DropZoneFilter class.
    /// </summary>
    public DropZoneFilter():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneFilter>(deep);

}
/// <summary>
/// <para>Defines the DropZoneCategories Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:dropZoneCategories.</para>
/// </summary>

[SchemaAttr(46, "dropZoneCategories")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropZoneCategories : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12768;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DropZoneCategories class.
    /// </summary>
    public DropZoneCategories():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneCategories>(deep);

}
/// <summary>
/// <para>Defines the DropZoneData Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:dropZoneData.</para>
/// </summary>

[SchemaAttr(46, "dropZoneData")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropZoneData : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12769;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DropZoneData class.
    /// </summary>
    public DropZoneData():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneData>(deep);

}
/// <summary>
/// <para>Defines the DropZoneSeries Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:dropZoneSeries.</para>
/// </summary>

[SchemaAttr(46, "dropZoneSeries")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropZoneSeries : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12770;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DropZoneSeries class.
    /// </summary>
    public DropZoneSeries():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneSeries>(deep);

}
/// <summary>
/// <para>Defines the DropZonesVisible Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:dropZonesVisible.</para>
/// </summary>

[SchemaAttr(46, "dropZonesVisible")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropZonesVisible : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12771;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DropZonesVisible class.
    /// </summary>
    public DropZonesVisible():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZonesVisible>(deep);

}
/// <summary>
/// <para>Defines the InSketchMode Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:inSketchMode.</para>
/// </summary>

[SchemaAttr(46, "inSketchMode")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class InSketchMode : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12772;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the InSketchMode class.
    /// </summary>
    public InSketchMode():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<InSketchMode>(deep);

}
/// <summary>
/// Defines the BooleanFalseType class.
/// </summary>


public abstract partial class BooleanFalseType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }
	

    
    
    
    /// <summary>
    /// Initializes a new instance of the BooleanFalseType class.
    /// </summary>
    protected BooleanFalseType(){}
    
    
    
}
/// <summary>
/// <para>Defines the ShowSketchButton Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c14:showSketchBtn.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(46, "showSketchBtn")]
[Id(ElementTypeIdConst)]
public partial class ShowSketchButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12773;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ShowSketchButton class.
    /// </summary>
    public ShowSketchButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowSketchButton>(deep);

}
}
 
 
