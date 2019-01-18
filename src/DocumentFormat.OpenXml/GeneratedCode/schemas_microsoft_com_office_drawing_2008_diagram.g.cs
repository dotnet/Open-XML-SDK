// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office.Drawing
{
/// <summary>
/// <para>Defines the Drawing Class. The root element of DiagramPersistLayoutPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:drawing.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeTree &lt;dsp:spTree></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ShapeTree))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[SchemaAttr(56, "drawing")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Drawing : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 13083;
    /// <inheritdoc/>
    public override string LocalName => "drawing";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    
    
	internal Drawing(DiagramPersistLayoutPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the DiagramPersistLayoutPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(DiagramPersistLayoutPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the DiagramPersistLayoutPart associated with this element.
    /// </summary>
    public DiagramPersistLayoutPart DiagramPersistLayoutPart
    {
		get => OpenXmlPart as DiagramPersistLayoutPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the Drawing class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Drawing(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Drawing class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Drawing(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Drawing class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Drawing(string outerXml)
        : base(outerXml)
    {
    }
    

    
    
    /// <summary>
    /// Initializes a new instance of the Drawing class.
    /// </summary>
    public Drawing():base(){}
    
    /// <summary>
    /// Saves the DOM into the DiagramPersistLayoutPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(DiagramPersistLayoutPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    
        private static readonly string[] eleTagNames = { "spTree" };
    private static readonly byte[] eleNamespaceIds = { 56 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ShapeTree.</para>
    /// <para> Represents the following element tag in the schema: dsp:spTree </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public ShapeTree ShapeTree
    {
        get => GetElement<ShapeTree>(0);
        set => SetElement(0, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Drawing>(deep);

}
/// <summary>
/// <para>Defines the DataModelExtensionBlock Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:dataModelExt.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "dataModelExt")]
public partial class DataModelExtensionBlock : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13084;
    /// <inheritdoc/>
    public override string LocalName => "dataModelExt";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> relId.</para>
    /// <para>Represents the following attribute in the schema: relId </para>
    /// </summary>
    [SchemaAttr(0, "relId")]
    [SchemaIndex(0)]
    public StringValue RelId { get; set; }
    /// <summary>
    /// <para> minVer.</para>
    /// <para>Represents the following attribute in the schema: minVer </para>
    /// </summary>
    [SchemaAttr(0, "minVer")]
    [SchemaIndex(1)]
    public StringValue MinVer { get; set; }

    /// <summary>
    /// Initializes a new instance of the DataModelExtensionBlock class.
    /// </summary>
    public DataModelExtensionBlock():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModelExtensionBlock>(deep);

}
/// <summary>
/// <para>Defines the NonVisualDrawingProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:cNvPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnHover &lt;a:hlinkHover></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "cNvPr")]
public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13085;
    /// <inheritdoc/>
    public override string LocalName => "cNvPr";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [SchemaIndex(0)]
    public UInt32Value Id { get; set; }
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [SchemaIndex(1)]
    public StringValue Name { get; set; }
    /// <summary>
    /// <para> descr.</para>
    /// <para>Represents the following attribute in the schema: descr </para>
    /// </summary>
    [SchemaAttr(0, "descr")]
    [SchemaIndex(2)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    [SchemaIndex(3)]
    public BooleanValue Hidden { get; set; }
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [SchemaIndex(4)]
    public StringValue Title { get; set; }

    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class.
    /// </summary>
    public NonVisualDrawingProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualDrawingProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualDrawingProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "hlinkClick","hlinkHover","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> HyperlinkOnClick.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkClick </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick HyperlinkOnClick
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> HyperlinkOnHover.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkHover </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover HyperlinkOnHover
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>(1);
        set => SetElement(1, value);
    }
    
    /// <summary>
    /// <para> NonVisualDrawingPropertiesExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList NonVisualDrawingPropertiesExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>(2);
        set => SetElement(2, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);

}
/// <summary>
/// <para>Defines the NonVisualDrawingShapeProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:cNvSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.ShapeLocks &lt;a:spLocks></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapeLocks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "cNvSpPr")]
public partial class NonVisualDrawingShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13086;
    /// <inheritdoc/>
    public override string LocalName => "cNvSpPr";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Text Box.</para>
    /// <para>Represents the following attribute in the schema: txBox </para>
    /// </summary>
    [SchemaAttr(0, "txBox")]
    [SchemaIndex(0)]
    public BooleanValue TextBox { get; set; }

    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingShapeProperties class.
    /// </summary>
    public NonVisualDrawingShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualDrawingShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualDrawingShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualDrawingShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualDrawingShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "spLocks","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Shape Locks.</para>
    /// <para> Represents the following element tag in the schema: a:spLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.ShapeLocks ShapeLocks
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.ShapeLocks>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(1);
        set => SetElement(1, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingShapeProperties>(deep);

}
/// <summary>
/// <para>Defines the ShapeNonVisualProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:nvSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;dsp:cNvPr></description></item>
///<item><description>NonVisualDrawingShapeProperties &lt;dsp:cNvSpPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualDrawingShapeProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "nvSpPr")]
public partial class ShapeNonVisualProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13087;
    /// <inheritdoc/>
    public override string LocalName => "nvSpPr";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ShapeNonVisualProperties class.
    /// </summary>
    public ShapeNonVisualProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ShapeNonVisualProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeNonVisualProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeNonVisualProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeNonVisualProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeNonVisualProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeNonVisualProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "cNvPr","cNvSpPr" };
    private static readonly byte[] eleNamespaceIds = { 56,56 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: dsp:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> NonVisualDrawingShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: dsp:cNvSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public NonVisualDrawingShapeProperties NonVisualDrawingShapeProperties
    {
        get => GetElement<NonVisualDrawingShapeProperties>(1);
        set => SetElement(1, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeNonVisualProperties>(deep);

}
/// <summary>
/// <para>Defines the ShapeProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:spPr.</para>
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
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "spPr")]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13088;
    /// <inheritdoc/>
    public override string LocalName => "spPr";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    [SchemaIndex(0)]
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
/// <para>Defines the ShapeStyle Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:style.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.LineReference &lt;a:lnRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.FillReference &lt;a:fillRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectReference &lt;a:effectRef></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.FontReference &lt;a:fontRef></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LineReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FillReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FontReference))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "style")]
public partial class ShapeStyle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13089;
    /// <inheritdoc/>
    public override string LocalName => "style";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ShapeStyle class.
    /// </summary>
    public ShapeStyle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ShapeStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeStyle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeStyle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeStyle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeStyle(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "lnRef","fillRef","effectRef","fontRef" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> LineReference.</para>
    /// <para> Represents the following element tag in the schema: a:lnRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.LineReference LineReference
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.LineReference>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> FillReference.</para>
    /// <para> Represents the following element tag in the schema: a:fillRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.FillReference FillReference
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.FillReference>(1);
        set => SetElement(1, value);
    }
    
    /// <summary>
    /// <para> EffectReference.</para>
    /// <para> Represents the following element tag in the schema: a:effectRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.EffectReference EffectReference
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.EffectReference>(2);
        set => SetElement(2, value);
    }
    
    /// <summary>
    /// <para> Font Reference.</para>
    /// <para> Represents the following element tag in the schema: a:fontRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.FontReference FontReference
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.FontReference>(3);
        set => SetElement(3, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeStyle>(deep);

}
/// <summary>
/// <para>Defines the TextBody Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:txBody.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ListStyle))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Paragraph))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "txBody")]
public partial class TextBody : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13090;
    /// <inheritdoc/>
    public override string LocalName => "txBody";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    
    /// <summary>
    /// Initializes a new instance of the TextBody class.
    /// </summary>
    public TextBody():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TextBody class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextBody(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextBody class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextBody(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextBody class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextBody(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "bodyPr","lstStyle","p" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Body Properties.</para>
    /// <para> Represents the following element tag in the schema: a:bodyPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.BodyProperties BodyProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> Text List Styles.</para>
    /// <para> Represents the following element tag in the schema: a:lstStyle </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.ListStyle ListStyle
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>(1);
        set => SetElement(1, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBody>(deep);

}
/// <summary>
/// <para>Defines the Transform2D Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:txXfrm.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Offset &lt;a:off></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Extents &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Offset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extents))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "txXfrm")]
public partial class Transform2D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13091;
    /// <inheritdoc/>
    public override string LocalName => "txXfrm";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Rotation.</para>
    /// <para>Represents the following attribute in the schema: rot </para>
    /// </summary>
    [SchemaAttr(0, "rot")]
    [SchemaIndex(0)]
    public Int32Value Rotation { get; set; }
    /// <summary>
    /// <para> Horizontal Flip.</para>
    /// <para>Represents the following attribute in the schema: flipH </para>
    /// </summary>
    [SchemaAttr(0, "flipH")]
    [SchemaIndex(1)]
    public BooleanValue HorizontalFlip { get; set; }
    /// <summary>
    /// <para> Vertical Flip.</para>
    /// <para>Represents the following attribute in the schema: flipV </para>
    /// </summary>
    [SchemaAttr(0, "flipV")]
    [SchemaIndex(2)]
    public BooleanValue VerticalFlip { get; set; }

    /// <summary>
    /// Initializes a new instance of the Transform2D class.
    /// </summary>
    public Transform2D():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Transform2D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Transform2D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Transform2D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Transform2D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Transform2D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Transform2D(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "off","ext" };
    private static readonly byte[] eleNamespaceIds = { 10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Offset.</para>
    /// <para> Represents the following element tag in the schema: a:off </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Offset Offset
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> Extents.</para>
    /// <para> Represents the following element tag in the schema: a:ext </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Extents Extents
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>(1);
        set => SetElement(1, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);

}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "extLst")]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13092;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class.
    /// </summary>
    public OfficeArtExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OfficeArtExtensionList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);

}
/// <summary>
/// <para>Defines the NonVisualGroupDrawingShapeProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:cNvGrpSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.GroupShapeLocks &lt;a:grpSpLocks></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupShapeLocks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "cNvGrpSpPr")]
public partial class NonVisualGroupDrawingShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13093;
    /// <inheritdoc/>
    public override string LocalName => "cNvGrpSpPr";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGroupDrawingShapeProperties class.
    /// </summary>
    public NonVisualGroupDrawingShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualGroupDrawingShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualGroupDrawingShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGroupDrawingShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualGroupDrawingShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGroupDrawingShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualGroupDrawingShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "grpSpLocks","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> GroupShapeLocks.</para>
    /// <para> Represents the following element tag in the schema: a:grpSpLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.GroupShapeLocks GroupShapeLocks
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> NonVisualGroupDrawingShapePropsExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList NonVisualGroupDrawingShapePropsExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>(1);
        set => SetElement(1, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupDrawingShapeProperties>(deep);

}
/// <summary>
/// <para>Defines the GroupShapeNonVisualProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:nvGrpSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;dsp:cNvPr></description></item>
///<item><description>NonVisualGroupDrawingShapeProperties &lt;dsp:cNvGrpSpPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualGroupDrawingShapeProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "nvGrpSpPr")]
public partial class GroupShapeNonVisualProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13094;
    /// <inheritdoc/>
    public override string LocalName => "nvGrpSpPr";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    
    /// <summary>
    /// Initializes a new instance of the GroupShapeNonVisualProperties class.
    /// </summary>
    public GroupShapeNonVisualProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GroupShapeNonVisualProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupShapeNonVisualProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupShapeNonVisualProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupShapeNonVisualProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupShapeNonVisualProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GroupShapeNonVisualProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "cNvPr","cNvGrpSpPr" };
    private static readonly byte[] eleNamespaceIds = { 56,56 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: dsp:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> NonVisualGroupDrawingShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: dsp:cNvGrpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public NonVisualGroupDrawingShapeProperties NonVisualGroupDrawingShapeProperties
    {
        get => GetElement<NonVisualGroupDrawingShapeProperties>(1);
        set => SetElement(1, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeNonVisualProperties>(deep);

}
/// <summary>
/// <para>Defines the GroupShapeProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:grpSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.TransformGroup &lt;a:xfrm></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.TransformGroup))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "grpSpPr")]
public partial class GroupShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13095;
    /// <inheritdoc/>
    public override string LocalName => "grpSpPr";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    [SchemaIndex(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }

    /// <summary>
    /// Initializes a new instance of the GroupShapeProperties class.
    /// </summary>
    public GroupShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GroupShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GroupShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "xfrm","noFill","solidFill","gradFill","blipFill","pattFill","grpFill","effectLst","effectDag","scene3d","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10,10,10,10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> 2D Transform for Grouped Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.TransformGroup TransformGroup
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.TransformGroup>(0);
        set => SetElement(0, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeProperties>(deep);

}
/// <summary>
/// <para>Defines the Shape Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:sp.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeNonVisualProperties &lt;dsp:nvSpPr></description></item>
///<item><description>ShapeProperties &lt;dsp:spPr></description></item>
///<item><description>ShapeStyle &lt;dsp:style></description></item>
///<item><description>TextBody &lt;dsp:txBody></description></item>
///<item><description>Transform2D &lt;dsp:txXfrm></description></item>
///<item><description>OfficeArtExtensionList &lt;dsp:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShapeNonVisualProperties))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(ShapeStyle))]
    [ChildElementInfo(typeof(TextBody))]
    [ChildElementInfo(typeof(Transform2D))]
    [ChildElementInfo(typeof(OfficeArtExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(56, "sp")]
public partial class Shape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13096;
    /// <inheritdoc/>
    public override string LocalName => "sp";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> modelId.</para>
    /// <para>Represents the following attribute in the schema: modelId </para>
    /// </summary>
    [SchemaAttr(0, "modelId")]
    [SchemaIndex(0)]
    public StringValue ModelId { get; set; }

    /// <summary>
    /// Initializes a new instance of the Shape class.
    /// </summary>
    public Shape():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Shape class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shape(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Shape class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shape(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Shape class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Shape(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        private static readonly string[] eleTagNames = { "nvSpPr","spPr","style","txBody","txXfrm","extLst" };
    private static readonly byte[] eleNamespaceIds = { 56,56,56,56,56,56 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ShapeNonVisualProperties.</para>
    /// <para> Represents the following element tag in the schema: dsp:nvSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public ShapeNonVisualProperties ShapeNonVisualProperties
    {
        get => GetElement<ShapeNonVisualProperties>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: dsp:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
    }
    
    /// <summary>
    /// <para> ShapeStyle.</para>
    /// <para> Represents the following element tag in the schema: dsp:style </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public ShapeStyle ShapeStyle
    {
        get => GetElement<ShapeStyle>(2);
        set => SetElement(2, value);
    }
    
    /// <summary>
    /// <para> TextBody.</para>
    /// <para> Represents the following element tag in the schema: dsp:txBody </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public TextBody TextBody
    {
        get => GetElement<TextBody>(3);
        set => SetElement(3, value);
    }
    
    /// <summary>
    /// <para> Transform2D.</para>
    /// <para> Represents the following element tag in the schema: dsp:txXfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public Transform2D Transform2D
    {
        get => GetElement<Transform2D>(4);
        set => SetElement(4, value);
    }
    
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dsp:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<OfficeArtExtensionList>(5);
        set => SetElement(5, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);

}
/// <summary>
/// <para>Defines the GroupShape Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:grpSp.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>GroupShapeNonVisualProperties &lt;dsp:nvGrpSpPr></description></item>
///<item><description>GroupShapeProperties &lt;dsp:grpSpPr></description></item>
///<item><description>Shape &lt;dsp:sp></description></item>
///<item><description>GroupShape &lt;dsp:grpSp></description></item>
///<item><description>OfficeArtExtensionList &lt;dsp:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[SchemaAttr(56, "grpSp")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class GroupShape : GroupShapeType
{
    internal const int ElementTypeIdConst = 13097;
    /// <inheritdoc/>
    public override string LocalName => "grpSp";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    /// <summary>
    /// Initializes a new instance of the GroupShape class.
    /// </summary>
    public GroupShape():base(){}
        /// <summary>
    ///Initializes a new instance of the GroupShape class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupShape(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupShape class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupShape(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupShape class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GroupShape(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShape>(deep);

}
/// <summary>
/// <para>Defines the ShapeTree Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is dsp:spTree.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>GroupShapeNonVisualProperties &lt;dsp:nvGrpSpPr></description></item>
///<item><description>GroupShapeProperties &lt;dsp:grpSpPr></description></item>
///<item><description>Shape &lt;dsp:sp></description></item>
///<item><description>GroupShape &lt;dsp:grpSp></description></item>
///<item><description>OfficeArtExtensionList &lt;dsp:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[SchemaAttr(56, "spTree")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShapeTree : GroupShapeType
{
    internal const int ElementTypeIdConst = 13098;
    /// <inheritdoc/>
    public override string LocalName => "spTree";
    internal override byte NamespaceId => 56;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    /// <summary>
    /// Initializes a new instance of the ShapeTree class.
    /// </summary>
    public ShapeTree():base(){}
        /// <summary>
    ///Initializes a new instance of the ShapeTree class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeTree(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeTree class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeTree(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeTree class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeTree(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeTree>(deep);

}
/// <summary>
/// Defines the GroupShapeType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>GroupShapeNonVisualProperties &lt;dsp:nvGrpSpPr></description></item>
///<item><description>GroupShapeProperties &lt;dsp:grpSpPr></description></item>
///<item><description>Shape &lt;dsp:sp></description></item>
///<item><description>GroupShape &lt;dsp:grpSp></description></item>
///<item><description>OfficeArtExtensionList &lt;dsp:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(GroupShapeNonVisualProperties))]
    [ChildElementInfo(typeof(GroupShapeProperties))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(GroupShape))]
    [ChildElementInfo(typeof(OfficeArtExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class GroupShapeType : OpenXmlCompositeElement
{
        
    
    
        private static readonly string[] eleTagNames = { "nvGrpSpPr","grpSpPr","sp","grpSp","extLst" };
    private static readonly byte[] eleNamespaceIds = { 56,56,56,56,56 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> GroupShapeNonVisualProperties.</para>
    /// <para> Represents the following element tag in the schema: dsp:nvGrpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public GroupShapeNonVisualProperties GroupShapeNonVisualProperties
    {
        get => GetElement<GroupShapeNonVisualProperties>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> GroupShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: dsp:grpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:dsp = http://schemas.microsoft.com/office/drawing/2008/diagram
    /// </remark>
    public GroupShapeProperties GroupShapeProperties
    {
        get => GetElement<GroupShapeProperties>(1);
        set => SetElement(1, value);
    }
    


    
    /// <summary>
    /// Initializes a new instance of the GroupShapeType class.
    /// </summary>
    protected GroupShapeType(){}
    
        /// <summary>
    ///Initializes a new instance of the GroupShapeType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected GroupShapeType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupShapeType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected GroupShapeType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupShapeType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected GroupShapeType(string outerXml)
        : base(outerXml)
    {
    }
    

    
}
}
 
 
