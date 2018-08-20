// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotOptions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12762;
    /// <inheritdoc/>
    public override string LocalName => "pivotOptions";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 46 == namespaceId && "dropZoneFilter" == name)
    return new DropZoneFilter();
    
if( 46 == namespaceId && "dropZoneCategories" == name)
    return new DropZoneCategories();
    
if( 46 == namespaceId && "dropZoneData" == name)
    return new DropZoneData();
    
if( 46 == namespaceId && "dropZoneSeries" == name)
    return new DropZoneSeries();
    
if( 46 == namespaceId && "dropZonesVisible" == name)
    return new DropZonesVisible();
    

    return null;
}

        private static readonly string[] eleTagNames = { "dropZoneFilter","dropZoneCategories","dropZoneData","dropZoneSeries","dropZonesVisible" };
    private static readonly byte[] eleNamespaceIds = { 46,46,46,46,46 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> DropZoneFilter.</para>
    /// <para> Represents the following element tag in the schema: c14:dropZoneFilter </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SketchOptions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12763;
    /// <inheritdoc/>
    public override string LocalName => "sketchOptions";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 46 == namespaceId && "inSketchMode" == name)
    return new InSketchMode();
    
if( 46 == namespaceId && "showSketchBtn" == name)
    return new ShowSketchButton();
    

    return null;
}

        private static readonly string[] eleTagNames = { "inSketchMode","showSketchBtn" };
    private static readonly byte[] eleNamespaceIds = { 46,46 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> InSketchMode.</para>
    /// <para> Represents the following element tag in the schema: c14:inSketchMode </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class InvertSolidFillFormat : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12764;
    /// <inheritdoc/>
    public override string LocalName => "invertSolidFillFmt";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 46 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "spPr" };
    private static readonly byte[] eleNamespaceIds = { 46 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c14:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
    /// </remark>
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Style : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12765;
    /// <inheritdoc/>
    public override string LocalName => "style";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<ByteValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public ByteValue Val
    {
        get { return (ByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12766;
    /// <inheritdoc/>
    public override string LocalName => "spPr";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>(0, "bwMode")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "xfrm" == name)
    return new DocumentFormat.OpenXml.Drawing.Transform2D();
    
if( 10 == namespaceId && "custGeom" == name)
    return new DocumentFormat.OpenXml.Drawing.CustomGeometry();
    
if( 10 == namespaceId && "prstGeom" == name)
    return new DocumentFormat.OpenXml.Drawing.PresetGeometry();
    
if( 10 == namespaceId && "noFill" == name)
    return new DocumentFormat.OpenXml.Drawing.NoFill();
    
if( 10 == namespaceId && "solidFill" == name)
    return new DocumentFormat.OpenXml.Drawing.SolidFill();
    
if( 10 == namespaceId && "gradFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GradientFill();
    
if( 10 == namespaceId && "blipFill" == name)
    return new DocumentFormat.OpenXml.Drawing.BlipFill();
    
if( 10 == namespaceId && "pattFill" == name)
    return new DocumentFormat.OpenXml.Drawing.PatternFill();
    
if( 10 == namespaceId && "grpFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GroupFill();
    
if( 10 == namespaceId && "ln" == name)
    return new DocumentFormat.OpenXml.Drawing.Outline();
    
if( 10 == namespaceId && "effectLst" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectList();
    
if( 10 == namespaceId && "effectDag" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectDag();
    
if( 10 == namespaceId && "scene3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Scene3DType();
    
if( 10 == namespaceId && "sp3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Shape3DType();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "xfrm","custGeom","prstGeom","noFill","solidFill","gradFill","blipFill","pattFill","grpFill","ln","effectLst","effectDag","scene3d","sp3d","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10,10,10,10,10,10,10,10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> 2D Transform for Individual Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropZoneFilter : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12767;
    /// <inheritdoc/>
    public override string LocalName => "dropZoneFilter";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropZoneCategories : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12768;
    /// <inheritdoc/>
    public override string LocalName => "dropZoneCategories";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropZoneData : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12769;
    /// <inheritdoc/>
    public override string LocalName => "dropZoneData";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropZoneSeries : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12770;
    /// <inheritdoc/>
    public override string LocalName => "dropZoneSeries";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropZonesVisible : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12771;
    /// <inheritdoc/>
    public override string LocalName => "dropZonesVisible";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class InSketchMode : BooleanFalseType
{
    internal const int ElementTypeIdConst = 12772;
    /// <inheritdoc/>
    public override string LocalName => "inSketchMode";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class BooleanFalseType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ShowSketchButton : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12773;
    /// <inheritdoc/>
    public override string LocalName => "showSketchBtn";
    
    internal override byte NamespaceId => 46;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShowSketchButton class.
    /// </summary>
    public ShowSketchButton():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowSketchButton>(deep);

}
}
 
 
