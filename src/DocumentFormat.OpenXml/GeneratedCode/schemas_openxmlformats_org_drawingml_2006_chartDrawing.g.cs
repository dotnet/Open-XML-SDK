// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Drawing.ChartDrawing
{
/// <summary>
/// <para>Relative Anchor Shape Size.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:relSizeAnchor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FromAnchor &lt;cdr:from></description></item>
///<item><description>ToAnchor &lt;cdr:to></description></item>
///<item><description>Shape &lt;cdr:sp></description></item>
///<item><description>GroupShape &lt;cdr:grpSp></description></item>
///<item><description>GraphicFrame &lt;cdr:graphicFrame></description></item>
///<item><description>ConnectionShape &lt;cdr:cxnSp></description></item>
///<item><description>Picture &lt;cdr:pic></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart &lt;cdr14:contentPart></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FromAnchor))]
    [ChildElementInfo(typeof(ToAnchor))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(GroupShape))]
    [ChildElementInfo(typeof(GraphicFrame))]
    [ChildElementInfo(typeof(ConnectionShape))]
    [ChildElementInfo(typeof(Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RelativeAnchorSize : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10652;
    /// <inheritdoc/>
    public override string LocalName => "relSizeAnchor";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RelativeAnchorSize class.
    /// </summary>
    public RelativeAnchorSize():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RelativeAnchorSize class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RelativeAnchorSize(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RelativeAnchorSize class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RelativeAnchorSize(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RelativeAnchorSize class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RelativeAnchorSize(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "from" == name)
    return new FromAnchor();
    
if( 12 == namespaceId && "to" == name)
    return new ToAnchor();
    
if( 12 == namespaceId && "sp" == name)
    return new Shape();
    
if( 12 == namespaceId && "grpSp" == name)
    return new GroupShape();
    
if( 12 == namespaceId && "graphicFrame" == name)
    return new GraphicFrame();
    
if( 12 == namespaceId && "cxnSp" == name)
    return new ConnectionShape();
    
if( 12 == namespaceId && "pic" == name)
    return new Picture();
    
if( 47 == namespaceId && "contentPart" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart();
    

    return null;
}

        private static readonly string[] eleTagNames = { "from","to","sp","grpSp","graphicFrame","cxnSp","pic","contentPart" };
    private static readonly byte[] eleNamespaceIds = { 12,12,12,12,12,12,12,47 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Starting Anchor Point.</para>
    /// <para> Represents the following element tag in the schema: cdr:from </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public FromAnchor FromAnchor
    {
        get => GetElement<FromAnchor>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Ending Anchor Point.</para>
    /// <para> Represents the following element tag in the schema: cdr:to </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public ToAnchor ToAnchor
    {
        get => GetElement<ToAnchor>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelativeAnchorSize>(deep);

}
/// <summary>
/// <para>Absolute Anchor Shape Size.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:absSizeAnchor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FromAnchor &lt;cdr:from></description></item>
///<item><description>Extent &lt;cdr:ext></description></item>
///<item><description>Shape &lt;cdr:sp></description></item>
///<item><description>GroupShape &lt;cdr:grpSp></description></item>
///<item><description>GraphicFrame &lt;cdr:graphicFrame></description></item>
///<item><description>ConnectionShape &lt;cdr:cxnSp></description></item>
///<item><description>Picture &lt;cdr:pic></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart &lt;cdr14:contentPart></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FromAnchor))]
    [ChildElementInfo(typeof(Extent))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(GroupShape))]
    [ChildElementInfo(typeof(GraphicFrame))]
    [ChildElementInfo(typeof(ConnectionShape))]
    [ChildElementInfo(typeof(Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AbsoluteAnchorSize : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10653;
    /// <inheritdoc/>
    public override string LocalName => "absSizeAnchor";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AbsoluteAnchorSize class.
    /// </summary>
    public AbsoluteAnchorSize():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AbsoluteAnchorSize class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AbsoluteAnchorSize(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AbsoluteAnchorSize class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AbsoluteAnchorSize(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AbsoluteAnchorSize class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AbsoluteAnchorSize(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "from" == name)
    return new FromAnchor();
    
if( 12 == namespaceId && "ext" == name)
    return new Extent();
    
if( 12 == namespaceId && "sp" == name)
    return new Shape();
    
if( 12 == namespaceId && "grpSp" == name)
    return new GroupShape();
    
if( 12 == namespaceId && "graphicFrame" == name)
    return new GraphicFrame();
    
if( 12 == namespaceId && "cxnSp" == name)
    return new ConnectionShape();
    
if( 12 == namespaceId && "pic" == name)
    return new Picture();
    
if( 47 == namespaceId && "contentPart" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart();
    

    return null;
}

        private static readonly string[] eleTagNames = { "from","ext","sp","grpSp","graphicFrame","cxnSp","pic","contentPart" };
    private static readonly byte[] eleNamespaceIds = { 12,12,12,12,12,12,12,47 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> FromAnchor.</para>
    /// <para> Represents the following element tag in the schema: cdr:from </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public FromAnchor FromAnchor
    {
        get => GetElement<FromAnchor>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Shape Extent.</para>
    /// <para> Represents the following element tag in the schema: cdr:ext </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public Extent Extent
    {
        get => GetElement<Extent>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AbsoluteAnchorSize>(deep);

}
/// <summary>
/// <para>Shape Definition.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:sp.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualShapeProperties &lt;cdr:nvSpPr></description></item>
///<item><description>ShapeProperties &lt;cdr:spPr></description></item>
///<item><description>Style &lt;cdr:style></description></item>
///<item><description>TextBody &lt;cdr:txBody></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualShapeProperties))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(Style))]
    [ChildElementInfo(typeof(TextBody))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Shape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10654;
    /// <inheritdoc/>
    public override string LocalName => "sp";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "macro"),
		AttributeTag.Create<StringValue>(0, "textlink"),
		AttributeTag.Create<BooleanValue>(0, "fLocksText"),
		AttributeTag.Create<BooleanValue>(0, "fPublished")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Reference to Custom Function.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    public StringValue Macro
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Link.</para>
    /// <para>Represents the following attribute in the schema: textlink </para>
    /// </summary>
    [SchemaAttr(0, "textlink")]
    public StringValue TextLink
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Lock Text.</para>
    /// <para>Represents the following attribute in the schema: fLocksText </para>
    /// </summary>
    [SchemaAttr(0, "fLocksText")]
    public BooleanValue LockText
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Publish to Server.</para>
    /// <para>Represents the following attribute in the schema: fPublished </para>
    /// </summary>
    [SchemaAttr(0, "fPublished")]
    public BooleanValue Published
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "nvSpPr" == name)
    return new NonVisualShapeProperties();
    
if( 12 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 12 == namespaceId && "style" == name)
    return new Style();
    
if( 12 == namespaceId && "txBody" == name)
    return new TextBody();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvSpPr","spPr","style","txBody" };
    private static readonly byte[] eleNamespaceIds = { 12,12,12,12 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:nvSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualShapeProperties NonVisualShapeProperties
    {
        get => GetElement<NonVisualShapeProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Shape Style.</para>
    /// <para> Represents the following element tag in the schema: cdr:style </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public Style Style
    {
        get => GetElement<Style>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Shape Text Body.</para>
    /// <para> Represents the following element tag in the schema: cdr:txBody </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public TextBody TextBody
    {
        get => GetElement<TextBody>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);

}
/// <summary>
/// <para>Group Shape.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:grpSp.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualGroupShapeProperties &lt;cdr:nvGrpSpPr></description></item>
///<item><description>GroupShapeProperties &lt;cdr:grpSpPr></description></item>
///<item><description>Shape &lt;cdr:sp></description></item>
///<item><description>GroupShape &lt;cdr:grpSp></description></item>
///<item><description>GraphicFrame &lt;cdr:graphicFrame></description></item>
///<item><description>ConnectionShape &lt;cdr:cxnSp></description></item>
///<item><description>Picture &lt;cdr:pic></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart &lt;cdr14:contentPart></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualGroupShapeProperties))]
    [ChildElementInfo(typeof(GroupShapeProperties))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(GroupShape))]
    [ChildElementInfo(typeof(GraphicFrame))]
    [ChildElementInfo(typeof(ConnectionShape))]
    [ChildElementInfo(typeof(Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class GroupShape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10655;
    /// <inheritdoc/>
    public override string LocalName => "grpSp";
    
    internal override byte NamespaceId => 12;
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "nvGrpSpPr" == name)
    return new NonVisualGroupShapeProperties();
    
if( 12 == namespaceId && "grpSpPr" == name)
    return new GroupShapeProperties();
    
if( 12 == namespaceId && "sp" == name)
    return new Shape();
    
if( 12 == namespaceId && "grpSp" == name)
    return new GroupShape();
    
if( 12 == namespaceId && "graphicFrame" == name)
    return new GraphicFrame();
    
if( 12 == namespaceId && "cxnSp" == name)
    return new ConnectionShape();
    
if( 12 == namespaceId && "pic" == name)
    return new Picture();
    
if( 47 == namespaceId && "contentPart" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvGrpSpPr","grpSpPr","sp","grpSp","graphicFrame","cxnSp","pic","contentPart" };
    private static readonly byte[] eleNamespaceIds = { 12,12,12,12,12,12,12,47 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Group Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:nvGrpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualGroupShapeProperties NonVisualGroupShapeProperties
    {
        get => GetElement<NonVisualGroupShapeProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Group Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:grpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public GroupShapeProperties GroupShapeProperties
    {
        get => GetElement<GroupShapeProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShape>(deep);

}
/// <summary>
/// <para>Graphic Frame.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:graphicFrame.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualGraphicFrameProperties &lt;cdr:nvGraphicFramePr></description></item>
///<item><description>Transform &lt;cdr:xfrm></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Graphic &lt;a:graphic></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualGraphicFrameProperties))]
    [ChildElementInfo(typeof(Transform))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Graphic))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class GraphicFrame : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10656;
    /// <inheritdoc/>
    public override string LocalName => "graphicFrame";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "macro"),
		AttributeTag.Create<BooleanValue>(0, "fPublished")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Reference to Custom Function.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    public StringValue Macro
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Publish To Server.</para>
    /// <para>Represents the following attribute in the schema: fPublished </para>
    /// </summary>
    [SchemaAttr(0, "fPublished")]
    public BooleanValue Published
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the GraphicFrame class.
    /// </summary>
    public GraphicFrame():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GraphicFrame class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GraphicFrame(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GraphicFrame class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GraphicFrame(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GraphicFrame class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GraphicFrame(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "nvGraphicFramePr" == name)
    return new NonVisualGraphicFrameProperties();
    
if( 12 == namespaceId && "xfrm" == name)
    return new Transform();
    
if( 10 == namespaceId && "graphic" == name)
    return new DocumentFormat.OpenXml.Drawing.Graphic();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvGraphicFramePr","xfrm","graphic" };
    private static readonly byte[] eleNamespaceIds = { 12,12,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Graphic Frame Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:nvGraphicFramePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualGraphicFrameProperties NonVisualGraphicFrameProperties
    {
        get => GetElement<NonVisualGraphicFrameProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Graphic Frame Transform.</para>
    /// <para> Represents the following element tag in the schema: cdr:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public Transform Transform
    {
        get => GetElement<Transform>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Graphical Object.</para>
    /// <para> Represents the following element tag in the schema: a:graphic </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Graphic Graphic
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Graphic>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrame>(deep);

}
/// <summary>
/// <para>Connection Shape.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:cxnSp.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualConnectorShapeDrawingProperties &lt;cdr:nvCxnSpPr></description></item>
///<item><description>ShapeProperties &lt;cdr:spPr></description></item>
///<item><description>Style &lt;cdr:style></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualConnectorShapeDrawingProperties))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(Style))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ConnectionShape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10657;
    /// <inheritdoc/>
    public override string LocalName => "cxnSp";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "macro"),
		AttributeTag.Create<BooleanValue>(0, "fPublished")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Reference to Custom Function.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    public StringValue Macro
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Publish to Server.</para>
    /// <para>Represents the following attribute in the schema: fPublished </para>
    /// </summary>
    [SchemaAttr(0, "fPublished")]
    public BooleanValue Published
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ConnectionShape class.
    /// </summary>
    public ConnectionShape():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ConnectionShape class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConnectionShape(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ConnectionShape class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConnectionShape(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ConnectionShape class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ConnectionShape(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "nvCxnSpPr" == name)
    return new NonVisualConnectorShapeDrawingProperties();
    
if( 12 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 12 == namespaceId && "style" == name)
    return new Style();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvCxnSpPr","spPr","style" };
    private static readonly byte[] eleNamespaceIds = { 12,12,12 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Connector Non Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:nvCxnSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualConnectorShapeDrawingProperties NonVisualConnectorShapeDrawingProperties
    {
        get => GetElement<NonVisualConnectorShapeDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Connection Shape Style.</para>
    /// <para> Represents the following element tag in the schema: cdr:style </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public Style Style
    {
        get => GetElement<Style>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectionShape>(deep);

}
/// <summary>
/// <para>Defines the Picture Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:pic.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualPictureProperties &lt;cdr:nvPicPr></description></item>
///<item><description>BlipFill &lt;cdr:blipFill></description></item>
///<item><description>ShapeProperties &lt;cdr:spPr></description></item>
///<item><description>Style &lt;cdr:style></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualPictureProperties))]
    [ChildElementInfo(typeof(BlipFill))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(Style))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Picture : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10658;
    /// <inheritdoc/>
    public override string LocalName => "pic";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "macro"),
		AttributeTag.Create<BooleanValue>(0, "fPublished")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Reference to Custom Function.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    public StringValue Macro
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Publish to Server.</para>
    /// <para>Represents the following attribute in the schema: fPublished </para>
    /// </summary>
    [SchemaAttr(0, "fPublished")]
    public BooleanValue Published
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Picture class.
    /// </summary>
    public Picture():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Picture class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Picture(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Picture class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Picture(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Picture class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Picture(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "nvPicPr" == name)
    return new NonVisualPictureProperties();
    
if( 12 == namespaceId && "blipFill" == name)
    return new BlipFill();
    
if( 12 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 12 == namespaceId && "style" == name)
    return new Style();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvPicPr","blipFill","spPr","style" };
    private static readonly byte[] eleNamespaceIds = { 12,12,12,12 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Picture Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:nvPicPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualPictureProperties NonVisualPictureProperties
    {
        get => GetElement<NonVisualPictureProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Picture Fill.</para>
    /// <para> Represents the following element tag in the schema: cdr:blipFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public BlipFill BlipFill
    {
        get => GetElement<BlipFill>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cdr:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Style.</para>
    /// <para> Represents the following element tag in the schema: cdr:style </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public Style Style
    {
        get => GetElement<Style>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Picture>(deep);

}
/// <summary>
/// <para>Chart Non Visual Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:cNvPr.</para>
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
public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10659;
    /// <inheritdoc/>
    public override string LocalName => "cNvPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "id"),
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<StringValue>(0, "descr"),
		AttributeTag.Create<BooleanValue>(0, "hidden"),
		AttributeTag.Create<StringValue>(0, "title")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> descr.</para>
    /// <para>Represents the following attribute in the schema: descr </para>
    /// </summary>
    [SchemaAttr(0, "descr")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "hlinkClick" == name)
    return new DocumentFormat.OpenXml.Drawing.HyperlinkOnClick();
    
if( 10 == namespaceId && "hlinkHover" == name)
    return new DocumentFormat.OpenXml.Drawing.HyperlinkOnHover();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList();
    

    return null;
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
/// <para>Non-Visual Shape Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:cNvSpPr.</para>
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
public partial class NonVisualShapeDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10660;
    /// <inheritdoc/>
    public override string LocalName => "cNvSpPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "txBox")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Text Box.</para>
    /// <para>Represents the following attribute in the schema: txBox </para>
    /// </summary>
    [SchemaAttr(0, "txBox")]
    public BooleanValue TextBox
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NonVisualShapeDrawingProperties class.
    /// </summary>
    public NonVisualShapeDrawingProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualShapeDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualShapeDrawingProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualShapeDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualShapeDrawingProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualShapeDrawingProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "spLocks" == name)
    return new DocumentFormat.OpenXml.Drawing.ShapeLocks();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
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
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualShapeDrawingProperties>(deep);

}
/// <summary>
/// <para>Non-Visual Shape Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:nvSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;cdr:cNvPr></description></item>
///<item><description>NonVisualShapeDrawingProperties &lt;cdr:cNvSpPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualShapeDrawingProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10661;
    /// <inheritdoc/>
    public override string LocalName => "nvSpPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualShapeProperties class.
    /// </summary>
    public NonVisualShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 12 == namespaceId && "cNvSpPr" == name)
    return new NonVisualShapeDrawingProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvSpPr" };
    private static readonly byte[] eleNamespaceIds = { 12,12 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Chart Non Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Non-Visual Shape Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:cNvSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualShapeDrawingProperties NonVisualShapeDrawingProperties
    {
        get => GetElement<NonVisualShapeDrawingProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualShapeProperties>(deep);

}
/// <summary>
/// <para>Shape Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:spPr.</para>
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
public partial class ShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10662;
    /// <inheritdoc/>
    public override string LocalName => "spPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
/// <para>Shape Style.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:style.</para>
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
public partial class Style : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10663;
    /// <inheritdoc/>
    public override string LocalName => "style";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Style class.
    /// </summary>
    public Style():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Style class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Style(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Style class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Style(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Style class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Style(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "lnRef" == name)
    return new DocumentFormat.OpenXml.Drawing.LineReference();
    
if( 10 == namespaceId && "fillRef" == name)
    return new DocumentFormat.OpenXml.Drawing.FillReference();
    
if( 10 == namespaceId && "effectRef" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectReference();
    
if( 10 == namespaceId && "fontRef" == name)
    return new DocumentFormat.OpenXml.Drawing.FontReference();
    

    return null;
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
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);

}
/// <summary>
/// <para>Shape Text Body.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:txBody.</para>
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
public partial class TextBody : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10664;
    /// <inheritdoc/>
    public override string LocalName => "txBody";
    
    internal override byte NamespaceId => 12;
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "bodyPr" == name)
    return new DocumentFormat.OpenXml.Drawing.BodyProperties();
    
if( 10 == namespaceId && "lstStyle" == name)
    return new DocumentFormat.OpenXml.Drawing.ListStyle();
    
if( 10 == namespaceId && "p" == name)
    return new DocumentFormat.OpenXml.Drawing.Paragraph();
    

    return null;
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
/// <para>Non-Visual Connection Shape Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:cNvCxnSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks &lt;a:cxnSpLocks></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.StartConnection &lt;a:stCxn></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EndConnection &lt;a:endCxn></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.StartConnection))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EndConnection))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualConnectionShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10665;
    /// <inheritdoc/>
    public override string LocalName => "cNvCxnSpPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualConnectionShapeProperties class.
    /// </summary>
    public NonVisualConnectionShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualConnectionShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualConnectionShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualConnectionShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualConnectionShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualConnectionShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualConnectionShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "cxnSpLocks" == name)
    return new DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks();
    
if( 10 == namespaceId && "stCxn" == name)
    return new DocumentFormat.OpenXml.Drawing.StartConnection();
    
if( 10 == namespaceId && "endCxn" == name)
    return new DocumentFormat.OpenXml.Drawing.EndConnection();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cxnSpLocks","stCxn","endCxn","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Connection Shape Locks.</para>
    /// <para> Represents the following element tag in the schema: a:cxnSpLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks ConnectionShapeLocks
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Connection Start.</para>
    /// <para> Represents the following element tag in the schema: a:stCxn </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.StartConnection StartConnection
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.StartConnection>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Connection End.</para>
    /// <para> Represents the following element tag in the schema: a:endCxn </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.EndConnection EndConnection
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.EndConnection>(2);
        set => SetElement(2, value);
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
        get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectionShapeProperties>(deep);

}
/// <summary>
/// <para>Connector Non Visual Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:nvCxnSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;cdr:cNvPr></description></item>
///<item><description>NonVisualConnectionShapeProperties &lt;cdr:cNvCxnSpPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualConnectionShapeProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualConnectorShapeDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10666;
    /// <inheritdoc/>
    public override string LocalName => "nvCxnSpPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class.
    /// </summary>
    public NonVisualConnectorShapeDrawingProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualConnectorShapeDrawingProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualConnectorShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualConnectorShapeDrawingProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 12 == namespaceId && "cNvCxnSpPr" == name)
    return new NonVisualConnectionShapeProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvCxnSpPr" };
    private static readonly byte[] eleNamespaceIds = { 12,12 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Chart Non Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Non-Visual Connection Shape Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:cNvCxnSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualConnectionShapeProperties NonVisualConnectionShapeProperties
    {
        get => GetElement<NonVisualConnectionShapeProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectorShapeDrawingProperties>(deep);

}
/// <summary>
/// <para>Non-Visual Picture Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:cNvPicPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.PictureLocks &lt;a:picLocks></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PictureLocks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualPictureDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10667;
    /// <inheritdoc/>
    public override string LocalName => "cNvPicPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "preferRelativeResize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> preferRelativeResize.</para>
    /// <para>Represents the following attribute in the schema: preferRelativeResize </para>
    /// </summary>
    [SchemaAttr(0, "preferRelativeResize")]
    public BooleanValue PreferRelativeResize
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NonVisualPictureDrawingProperties class.
    /// </summary>
    public NonVisualPictureDrawingProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualPictureDrawingProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualPictureDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualPictureDrawingProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualPictureDrawingProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "picLocks" == name)
    return new DocumentFormat.OpenXml.Drawing.PictureLocks();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "picLocks","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PictureLocks.</para>
    /// <para> Represents the following element tag in the schema: a:picLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.PictureLocks PictureLocks
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.PictureLocks>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> NonVisualPicturePropertiesExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList NonVisualPicturePropertiesExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureDrawingProperties>(deep);

}
/// <summary>
/// <para>Non-Visual Picture Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:nvPicPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;cdr:cNvPr></description></item>
///<item><description>NonVisualPictureDrawingProperties &lt;cdr:cNvPicPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualPictureDrawingProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualPictureProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10668;
    /// <inheritdoc/>
    public override string LocalName => "nvPicPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualPictureProperties class.
    /// </summary>
    public NonVisualPictureProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualPictureProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualPictureProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualPictureProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualPictureProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 12 == namespaceId && "cNvPicPr" == name)
    return new NonVisualPictureDrawingProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvPicPr" };
    private static readonly byte[] eleNamespaceIds = { 12,12 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: cdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Non-Visual Picture Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:cNvPicPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualPictureDrawingProperties NonVisualPictureDrawingProperties
    {
        get => GetElement<NonVisualPictureDrawingProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureProperties>(deep);

}
/// <summary>
/// <para>Picture Fill.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:blipFill.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Blip &lt;a:blip></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SourceRectangle &lt;a:srcRect></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Tile &lt;a:tile></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Stretch &lt;a:stretch></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Blip))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SourceRectangle))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Tile))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Stretch))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BlipFill : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10669;
    /// <inheritdoc/>
    public override string LocalName => "blipFill";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "dpi"),
		AttributeTag.Create<BooleanValue>(0, "rotWithShape")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> DPI Setting.</para>
    /// <para>Represents the following attribute in the schema: dpi </para>
    /// </summary>
    [SchemaAttr(0, "dpi")]
    public UInt32Value Dpi
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Rotate With Shape.</para>
    /// <para>Represents the following attribute in the schema: rotWithShape </para>
    /// </summary>
    [SchemaAttr(0, "rotWithShape")]
    public BooleanValue RotateWithShape
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BlipFill class.
    /// </summary>
    public BlipFill():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BlipFill class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BlipFill(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BlipFill class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BlipFill(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BlipFill class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BlipFill(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "blip" == name)
    return new DocumentFormat.OpenXml.Drawing.Blip();
    
if( 10 == namespaceId && "srcRect" == name)
    return new DocumentFormat.OpenXml.Drawing.SourceRectangle();
    
if( 10 == namespaceId && "tile" == name)
    return new DocumentFormat.OpenXml.Drawing.Tile();
    
if( 10 == namespaceId && "stretch" == name)
    return new DocumentFormat.OpenXml.Drawing.Stretch();
    

    return null;
}

        private static readonly string[] eleTagNames = { "blip","srcRect","tile","stretch" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Blip.</para>
    /// <para> Represents the following element tag in the schema: a:blip </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Blip Blip
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Blip>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Source Rectangle.</para>
    /// <para> Represents the following element tag in the schema: a:srcRect </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.SourceRectangle SourceRectangle
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.SourceRectangle>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BlipFill>(deep);

}
/// <summary>
/// <para>Non-Visual Graphic Frame Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:cNvGraphicFramePr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.GraphicFrameLocks &lt;a:graphicFrameLocks></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualGraphicFrameDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10670;
    /// <inheritdoc/>
    public override string LocalName => "cNvGraphicFramePr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class.
    /// </summary>
    public NonVisualGraphicFrameDrawingProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualGraphicFrameDrawingProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualGraphicFrameDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualGraphicFrameDrawingProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "graphicFrameLocks" == name)
    return new DocumentFormat.OpenXml.Drawing.GraphicFrameLocks();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "graphicFrameLocks","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Graphic Frame Locks.</para>
    /// <para> Represents the following element tag in the schema: a:graphicFrameLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.GraphicFrameLocks GraphicFrameLocks
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>(0);
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
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameDrawingProperties>(deep);

}
/// <summary>
/// <para>Non-Visual Graphic Frame Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:nvGraphicFramePr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;cdr:cNvPr></description></item>
///<item><description>NonVisualGraphicFrameDrawingProperties &lt;cdr:cNvGraphicFramePr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualGraphicFrameDrawingProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualGraphicFrameProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10671;
    /// <inheritdoc/>
    public override string LocalName => "nvGraphicFramePr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGraphicFrameProperties class.
    /// </summary>
    public NonVisualGraphicFrameProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualGraphicFrameProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualGraphicFrameProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGraphicFrameProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualGraphicFrameProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGraphicFrameProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualGraphicFrameProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 12 == namespaceId && "cNvGraphicFramePr" == name)
    return new NonVisualGraphicFrameDrawingProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvGraphicFramePr" };
    private static readonly byte[] eleNamespaceIds = { 12,12 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Non-Visual Graphic Frame Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:cNvGraphicFramePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualGraphicFrameDrawingProperties NonVisualGraphicFrameDrawingProperties
    {
        get => GetElement<NonVisualGraphicFrameDrawingProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameProperties>(deep);

}
/// <summary>
/// <para>Graphic Frame Transform.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:xfrm.</para>
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
public partial class Transform : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10672;
    /// <inheritdoc/>
    public override string LocalName => "xfrm";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "rot"),
		AttributeTag.Create<BooleanValue>(0, "flipH"),
		AttributeTag.Create<BooleanValue>(0, "flipV")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Rotation.</para>
    /// <para>Represents the following attribute in the schema: rot </para>
    /// </summary>
    [SchemaAttr(0, "rot")]
    public Int32Value Rotation
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Flip.</para>
    /// <para>Represents the following attribute in the schema: flipH </para>
    /// </summary>
    [SchemaAttr(0, "flipH")]
    public BooleanValue HorizontalFlip
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Vertical Flip.</para>
    /// <para>Represents the following attribute in the schema: flipV </para>
    /// </summary>
    [SchemaAttr(0, "flipV")]
    public BooleanValue VerticalFlip
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Transform class.
    /// </summary>
    public Transform():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Transform class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Transform(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Transform class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Transform(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Transform class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Transform(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "off" == name)
    return new DocumentFormat.OpenXml.Drawing.Offset();
    
if( 10 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Drawing.Extents();
    

    return null;
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
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform>(deep);

}
/// <summary>
/// <para>Non-Visual Group Shape Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:cNvGrpSpPr.</para>
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
public partial class NonVisualGroupShapeDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10673;
    /// <inheritdoc/>
    public override string LocalName => "cNvGrpSpPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class.
    /// </summary>
    public NonVisualGroupShapeDrawingProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualGroupShapeDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualGroupShapeDrawingProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualGroupShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualGroupShapeDrawingProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "grpSpLocks" == name)
    return new DocumentFormat.OpenXml.Drawing.GroupShapeLocks();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList();
    

    return null;
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
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupShapeDrawingProperties>(deep);

}
/// <summary>
/// <para>Relative X Coordinate.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:x.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class XPosition : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10674;
    /// <inheritdoc/>
    public override string LocalName => "x";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the XPosition class.
    /// </summary>
    public XPosition():base(){}
    
        /// <summary>
    /// Initializes a new instance of the XPosition class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public XPosition(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new DoubleValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<XPosition>(deep);

}
/// <summary>
/// <para>Relative Y Coordinate.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:y.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class YPosition : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10675;
    /// <inheritdoc/>
    public override string LocalName => "y";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the YPosition class.
    /// </summary>
    public YPosition():base(){}
    
        /// <summary>
    /// Initializes a new instance of the YPosition class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public YPosition(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new DoubleValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<YPosition>(deep);

}
/// <summary>
/// <para>Starting Anchor Point.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:from.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>XPosition &lt;cdr:x></description></item>
///<item><description>YPosition &lt;cdr:y></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FromAnchor : MarkerType
{
    internal const int ElementTypeIdConst = 10676;
    /// <inheritdoc/>
    public override string LocalName => "from";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the FromAnchor class.
    /// </summary>
    public FromAnchor():base(){}
        /// <summary>
    ///Initializes a new instance of the FromAnchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FromAnchor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FromAnchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FromAnchor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FromAnchor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FromAnchor(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FromAnchor>(deep);

}
/// <summary>
/// <para>Ending Anchor Point.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:to.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>XPosition &lt;cdr:x></description></item>
///<item><description>YPosition &lt;cdr:y></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ToAnchor : MarkerType
{
    internal const int ElementTypeIdConst = 10677;
    /// <inheritdoc/>
    public override string LocalName => "to";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ToAnchor class.
    /// </summary>
    public ToAnchor():base(){}
        /// <summary>
    ///Initializes a new instance of the ToAnchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ToAnchor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ToAnchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ToAnchor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ToAnchor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ToAnchor(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToAnchor>(deep);

}
/// <summary>
/// Defines the MarkerType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>XPosition &lt;cdr:x></description></item>
///<item><description>YPosition &lt;cdr:y></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(XPosition))]
    [ChildElementInfo(typeof(YPosition))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class MarkerType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "x" == name)
    return new XPosition();
    
if( 12 == namespaceId && "y" == name)
    return new YPosition();
    

    return null;
}

        private static readonly string[] eleTagNames = { "x","y" };
    private static readonly byte[] eleNamespaceIds = { 12,12 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Relative X Coordinate.</para>
    /// <para> Represents the following element tag in the schema: cdr:x </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public XPosition XPosition
    {
        get => GetElement<XPosition>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Relative Y Coordinate.</para>
    /// <para> Represents the following element tag in the schema: cdr:y </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public YPosition YPosition
    {
        get => GetElement<YPosition>(1);
        set => SetElement(1, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the MarkerType class.
    /// </summary>
    protected MarkerType(){}
    
        /// <summary>
    ///Initializes a new instance of the MarkerType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected MarkerType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MarkerType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected MarkerType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MarkerType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected MarkerType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Shape Extent.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:ext.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Extent : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10678;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int64Value>(0, "cx"),
		AttributeTag.Create<Int64Value>(0, "cy")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Extent Length.</para>
    /// <para>Represents the following attribute in the schema: cx </para>
    /// </summary>
    [SchemaAttr(0, "cx")]
    public Int64Value Cx
    {
        get { return (Int64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Extent Width.</para>
    /// <para>Represents the following attribute in the schema: cy </para>
    /// </summary>
    [SchemaAttr(0, "cy")]
    public Int64Value Cy
    {
        get { return (Int64Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Extent class.
    /// </summary>
    public Extent():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extent>(deep);

}
/// <summary>
/// <para>Non-Visual Group Shape Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:nvGrpSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;cdr:cNvPr></description></item>
///<item><description>NonVisualGroupShapeDrawingProperties &lt;cdr:cNvGrpSpPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualGroupShapeDrawingProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualGroupShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10679;
    /// <inheritdoc/>
    public override string LocalName => "nvGrpSpPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGroupShapeProperties class.
    /// </summary>
    public NonVisualGroupShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualGroupShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualGroupShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGroupShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualGroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualGroupShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualGroupShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 12 == namespaceId && "cNvGrpSpPr" == name)
    return new NonVisualGroupShapeDrawingProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvGrpSpPr" };
    private static readonly byte[] eleNamespaceIds = { 12,12 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Chart Non Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Non-Visual Group Shape Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: cdr:cNvGrpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
    /// </remark>
    public NonVisualGroupShapeDrawingProperties NonVisualGroupShapeDrawingProperties
    {
        get => GetElement<NonVisualGroupShapeDrawingProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupShapeProperties>(deep);

}
/// <summary>
/// <para>Group Shape Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr:grpSpPr.</para>
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
public partial class GroupShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10680;
    /// <inheritdoc/>
    public override string LocalName => "grpSpPr";
    
    internal override byte NamespaceId => 12;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "xfrm" == name)
    return new DocumentFormat.OpenXml.Drawing.TransformGroup();
    
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
    
if( 10 == namespaceId && "effectLst" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectList();
    
if( 10 == namespaceId && "effectDag" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectDag();
    
if( 10 == namespaceId && "scene3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Scene3DType();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
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
}
 
 
