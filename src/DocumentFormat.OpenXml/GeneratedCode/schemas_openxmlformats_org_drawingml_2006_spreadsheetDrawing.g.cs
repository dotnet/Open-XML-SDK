// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2010.Excel.Drawing;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
/// <summary>
/// <para>Two Cell Anchor Shape Size.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:twoCellAnchor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FromMarker &lt;xdr:from></description></item>
///<item><description>ToMarker &lt;xdr:to></description></item>
///<item><description>Shape &lt;xdr:sp></description></item>
///<item><description>GroupShape &lt;xdr:grpSp></description></item>
///<item><description>GraphicFrame &lt;xdr:graphicFrame></description></item>
///<item><description>ConnectionShape &lt;xdr:cxnSp></description></item>
///<item><description>Picture &lt;xdr:pic></description></item>
///<item><description>ContentPart &lt;xdr:contentPart></description></item>
///<item><description>ClientData &lt;xdr:clientData></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FromMarker))]
    [ChildElementInfo(typeof(ToMarker))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(GroupShape))]
    [ChildElementInfo(typeof(GraphicFrame))]
    [ChildElementInfo(typeof(ConnectionShape))]
    [ChildElementInfo(typeof(Picture))]
    [ChildElementInfo(typeof(ContentPart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ClientData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TwoCellAnchor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10786;
    /// <inheritdoc/>
    public override string LocalName => "twoCellAnchor";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Spreadsheet.EditAsValues>>(0, "editAs")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Positioning and Resizing Behaviors.</para>
    /// <para>Represents the following attribute in the schema: editAs </para>
    /// </summary>
    [SchemaAttr(0, "editAs")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Spreadsheet.EditAsValues> EditAs
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Spreadsheet.EditAsValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TwoCellAnchor class.
    /// </summary>
    public TwoCellAnchor():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TwoCellAnchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TwoCellAnchor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TwoCellAnchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TwoCellAnchor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TwoCellAnchor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TwoCellAnchor(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 18 == namespaceId && "from" == name)
    return new FromMarker();
    
if( 18 == namespaceId && "to" == name)
    return new ToMarker();
    
if( 18 == namespaceId && "sp" == name)
    return new Shape();
    
if( 18 == namespaceId && "grpSp" == name)
    return new GroupShape();
    
if( 18 == namespaceId && "graphicFrame" == name)
    return new GraphicFrame();
    
if( 18 == namespaceId && "cxnSp" == name)
    return new ConnectionShape();
    
if( 18 == namespaceId && "pic" == name)
    return new Picture();
    
if( 18 == namespaceId && "contentPart" == name)
    return new ContentPart();
    
if( 18 == namespaceId && "clientData" == name)
    return new ClientData();
    

    return null;
}

        private static readonly string[] eleTagNames = { "from","to","sp","grpSp","graphicFrame","cxnSp","pic","contentPart","clientData" };
    private static readonly byte[] eleNamespaceIds = { 18,18,18,18,18,18,18,18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Starting Anchor Point.</para>
    /// <para> Represents the following element tag in the schema: xdr:from </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public FromMarker FromMarker
    {
        get => GetElement<FromMarker>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Ending Anchor Point.</para>
    /// <para> Represents the following element tag in the schema: xdr:to </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public ToMarker ToMarker
    {
        get => GetElement<ToMarker>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TwoCellAnchor>(deep);

}
/// <summary>
/// <para>One Cell Anchor Shape Size.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:oneCellAnchor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FromMarker &lt;xdr:from></description></item>
///<item><description>Extent &lt;xdr:ext></description></item>
///<item><description>Shape &lt;xdr:sp></description></item>
///<item><description>GroupShape &lt;xdr:grpSp></description></item>
///<item><description>GraphicFrame &lt;xdr:graphicFrame></description></item>
///<item><description>ConnectionShape &lt;xdr:cxnSp></description></item>
///<item><description>Picture &lt;xdr:pic></description></item>
///<item><description>ContentPart &lt;xdr:contentPart></description></item>
///<item><description>ClientData &lt;xdr:clientData></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FromMarker))]
    [ChildElementInfo(typeof(Extent))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(GroupShape))]
    [ChildElementInfo(typeof(GraphicFrame))]
    [ChildElementInfo(typeof(ConnectionShape))]
    [ChildElementInfo(typeof(Picture))]
    [ChildElementInfo(typeof(ContentPart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ClientData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class OneCellAnchor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10787;
    /// <inheritdoc/>
    public override string LocalName => "oneCellAnchor";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OneCellAnchor class.
    /// </summary>
    public OneCellAnchor():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OneCellAnchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OneCellAnchor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OneCellAnchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OneCellAnchor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OneCellAnchor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OneCellAnchor(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 18 == namespaceId && "from" == name)
    return new FromMarker();
    
if( 18 == namespaceId && "ext" == name)
    return new Extent();
    
if( 18 == namespaceId && "sp" == name)
    return new Shape();
    
if( 18 == namespaceId && "grpSp" == name)
    return new GroupShape();
    
if( 18 == namespaceId && "graphicFrame" == name)
    return new GraphicFrame();
    
if( 18 == namespaceId && "cxnSp" == name)
    return new ConnectionShape();
    
if( 18 == namespaceId && "pic" == name)
    return new Picture();
    
if( 18 == namespaceId && "contentPart" == name)
    return new ContentPart();
    
if( 18 == namespaceId && "clientData" == name)
    return new ClientData();
    

    return null;
}

        private static readonly string[] eleTagNames = { "from","ext","sp","grpSp","graphicFrame","cxnSp","pic","contentPart","clientData" };
    private static readonly byte[] eleNamespaceIds = { 18,18,18,18,18,18,18,18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> FromMarker.</para>
    /// <para> Represents the following element tag in the schema: xdr:from </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public FromMarker FromMarker
    {
        get => GetElement<FromMarker>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Extent.</para>
    /// <para> Represents the following element tag in the schema: xdr:ext </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public Extent Extent
    {
        get => GetElement<Extent>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OneCellAnchor>(deep);

}
/// <summary>
/// <para>Absolute Anchor Shape Size.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:absoluteAnchor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Position &lt;xdr:pos></description></item>
///<item><description>Extent &lt;xdr:ext></description></item>
///<item><description>Shape &lt;xdr:sp></description></item>
///<item><description>GroupShape &lt;xdr:grpSp></description></item>
///<item><description>GraphicFrame &lt;xdr:graphicFrame></description></item>
///<item><description>ConnectionShape &lt;xdr:cxnSp></description></item>
///<item><description>Picture &lt;xdr:pic></description></item>
///<item><description>ContentPart &lt;xdr:contentPart></description></item>
///<item><description>ClientData &lt;xdr:clientData></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Position))]
    [ChildElementInfo(typeof(Extent))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(GroupShape))]
    [ChildElementInfo(typeof(GraphicFrame))]
    [ChildElementInfo(typeof(ConnectionShape))]
    [ChildElementInfo(typeof(Picture))]
    [ChildElementInfo(typeof(ContentPart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ClientData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AbsoluteAnchor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10788;
    /// <inheritdoc/>
    public override string LocalName => "absoluteAnchor";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AbsoluteAnchor class.
    /// </summary>
    public AbsoluteAnchor():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AbsoluteAnchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AbsoluteAnchor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AbsoluteAnchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AbsoluteAnchor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AbsoluteAnchor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AbsoluteAnchor(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 18 == namespaceId && "pos" == name)
    return new Position();
    
if( 18 == namespaceId && "ext" == name)
    return new Extent();
    
if( 18 == namespaceId && "sp" == name)
    return new Shape();
    
if( 18 == namespaceId && "grpSp" == name)
    return new GroupShape();
    
if( 18 == namespaceId && "graphicFrame" == name)
    return new GraphicFrame();
    
if( 18 == namespaceId && "cxnSp" == name)
    return new ConnectionShape();
    
if( 18 == namespaceId && "pic" == name)
    return new Picture();
    
if( 18 == namespaceId && "contentPart" == name)
    return new ContentPart();
    
if( 18 == namespaceId && "clientData" == name)
    return new ClientData();
    

    return null;
}

        private static readonly string[] eleTagNames = { "pos","ext","sp","grpSp","graphicFrame","cxnSp","pic","contentPart","clientData" };
    private static readonly byte[] eleNamespaceIds = { 18,18,18,18,18,18,18,18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Position.</para>
    /// <para> Represents the following element tag in the schema: xdr:pos </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public Position Position
    {
        get => GetElement<Position>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Shape Extent.</para>
    /// <para> Represents the following element tag in the schema: xdr:ext </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public Extent Extent
    {
        get => GetElement<Extent>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AbsoluteAnchor>(deep);

}
/// <summary>
/// <para>Shape.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:sp.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualShapeProperties &lt;xdr:nvSpPr></description></item>
///<item><description>ShapeProperties &lt;xdr:spPr></description></item>
///<item><description>ShapeStyle &lt;xdr:style></description></item>
///<item><description>TextBody &lt;xdr:txBody></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualShapeProperties))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(ShapeStyle))]
    [ChildElementInfo(typeof(TextBody))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Shape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10789;
    /// <inheritdoc/>
    public override string LocalName => "sp";
    
    internal override byte NamespaceId => 18;
    
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
    /// <para> Lock Text Flag.</para>
    /// <para>Represents the following attribute in the schema: fLocksText </para>
    /// </summary>
    [SchemaAttr(0, "fLocksText")]
    public BooleanValue LockText
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Publish to Server Flag.</para>
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
    if( 18 == namespaceId && "nvSpPr" == name)
    return new NonVisualShapeProperties();
    
if( 18 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 18 == namespaceId && "style" == name)
    return new ShapeStyle();
    
if( 18 == namespaceId && "txBody" == name)
    return new TextBody();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvSpPr","spPr","style","txBody" };
    private static readonly byte[] eleNamespaceIds = { 18,18,18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Shape.</para>
    /// <para> Represents the following element tag in the schema: xdr:nvSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualShapeProperties NonVisualShapeProperties
    {
        get => GetElement<NonVisualShapeProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ShapeStyle.</para>
    /// <para> Represents the following element tag in the schema: xdr:style </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public ShapeStyle ShapeStyle
    {
        get => GetElement<ShapeStyle>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Shape Text Body.</para>
    /// <para> Represents the following element tag in the schema: xdr:txBody </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
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
/// <para> When the object is serialized out as xml, its qualified name is xdr:grpSp.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualGroupShapeProperties &lt;xdr:nvGrpSpPr></description></item>
///<item><description>GroupShapeProperties &lt;xdr:grpSpPr></description></item>
///<item><description>Shape &lt;xdr:sp></description></item>
///<item><description>GroupShape &lt;xdr:grpSp></description></item>
///<item><description>GraphicFrame &lt;xdr:graphicFrame></description></item>
///<item><description>ConnectionShape &lt;xdr:cxnSp></description></item>
///<item><description>Picture &lt;xdr:pic></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart &lt;xdr14:contentPart></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualGroupShapeProperties))]
    [ChildElementInfo(typeof(GroupShapeProperties))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(GroupShape))]
    [ChildElementInfo(typeof(GraphicFrame))]
    [ChildElementInfo(typeof(ConnectionShape))]
    [ChildElementInfo(typeof(Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class GroupShape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10790;
    /// <inheritdoc/>
    public override string LocalName => "grpSp";
    
    internal override byte NamespaceId => 18;
    
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
    if( 18 == namespaceId && "nvGrpSpPr" == name)
    return new NonVisualGroupShapeProperties();
    
if( 18 == namespaceId && "grpSpPr" == name)
    return new GroupShapeProperties();
    
if( 18 == namespaceId && "sp" == name)
    return new Shape();
    
if( 18 == namespaceId && "grpSp" == name)
    return new GroupShape();
    
if( 18 == namespaceId && "graphicFrame" == name)
    return new GraphicFrame();
    
if( 18 == namespaceId && "cxnSp" == name)
    return new ConnectionShape();
    
if( 18 == namespaceId && "pic" == name)
    return new Picture();
    
if( 54 == namespaceId && "contentPart" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvGrpSpPr","grpSpPr","sp","grpSp","graphicFrame","cxnSp","pic","contentPart" };
    private static readonly byte[] eleNamespaceIds = { 18,18,18,18,18,18,18,54 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Group Shape.</para>
    /// <para> Represents the following element tag in the schema: xdr:nvGrpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualGroupShapeProperties NonVisualGroupShapeProperties
    {
        get => GetElement<NonVisualGroupShapeProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Group Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:grpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
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
/// <para> When the object is serialized out as xml, its qualified name is xdr:graphicFrame.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualGraphicFrameProperties &lt;xdr:nvGraphicFramePr></description></item>
///<item><description>Transform &lt;xdr:xfrm></description></item>
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
    internal const int ElementTypeIdConst = 10791;
    /// <inheritdoc/>
    public override string LocalName => "graphicFrame";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "macro"),
		AttributeTag.Create<BooleanValue>(0, "fPublished")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Reference To Custom Function.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    public StringValue Macro
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Publish to Server Flag.</para>
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
    if( 18 == namespaceId && "nvGraphicFramePr" == name)
    return new NonVisualGraphicFrameProperties();
    
if( 18 == namespaceId && "xfrm" == name)
    return new Transform();
    
if( 10 == namespaceId && "graphic" == name)
    return new DocumentFormat.OpenXml.Drawing.Graphic();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvGraphicFramePr","xfrm","graphic" };
    private static readonly byte[] eleNamespaceIds = { 18,18,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Graphic Frame.</para>
    /// <para> Represents the following element tag in the schema: xdr:nvGraphicFramePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualGraphicFrameProperties NonVisualGraphicFrameProperties
    {
        get => GetElement<NonVisualGraphicFrameProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> 2D Transform for Graphic Frames.</para>
    /// <para> Represents the following element tag in the schema: xdr:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public Transform Transform
    {
        get => GetElement<Transform>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Graphic.</para>
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
/// <para> When the object is serialized out as xml, its qualified name is xdr:cxnSp.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualConnectionShapeProperties &lt;xdr:nvCxnSpPr></description></item>
///<item><description>ShapeProperties &lt;xdr:spPr></description></item>
///<item><description>ShapeStyle &lt;xdr:style></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualConnectionShapeProperties))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(ShapeStyle))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ConnectionShape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10792;
    /// <inheritdoc/>
    public override string LocalName => "cxnSp";
    
    internal override byte NamespaceId => 18;
    
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
    /// <para> Publish to Server Flag.</para>
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
    if( 18 == namespaceId && "nvCxnSpPr" == name)
    return new NonVisualConnectionShapeProperties();
    
if( 18 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 18 == namespaceId && "style" == name)
    return new ShapeStyle();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvCxnSpPr","spPr","style" };
    private static readonly byte[] eleNamespaceIds = { 18,18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Connection Shape.</para>
    /// <para> Represents the following element tag in the schema: xdr:nvCxnSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualConnectionShapeProperties NonVisualConnectionShapeProperties
    {
        get => GetElement<NonVisualConnectionShapeProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Connector Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ShapeStyle.</para>
    /// <para> Represents the following element tag in the schema: xdr:style </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public ShapeStyle ShapeStyle
    {
        get => GetElement<ShapeStyle>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectionShape>(deep);

}
/// <summary>
/// <para>Defines the Picture Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:pic.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualPictureProperties &lt;xdr:nvPicPr></description></item>
///<item><description>BlipFill &lt;xdr:blipFill></description></item>
///<item><description>ShapeProperties &lt;xdr:spPr></description></item>
///<item><description>ShapeStyle &lt;xdr:style></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualPictureProperties))]
    [ChildElementInfo(typeof(BlipFill))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(ShapeStyle))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Picture : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10793;
    /// <inheritdoc/>
    public override string LocalName => "pic";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "macro"),
		AttributeTag.Create<BooleanValue>(0, "fPublished")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Reference To Custom Function.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    public StringValue Macro
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Publish to Server Flag.</para>
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
    if( 18 == namespaceId && "nvPicPr" == name)
    return new NonVisualPictureProperties();
    
if( 18 == namespaceId && "blipFill" == name)
    return new BlipFill();
    
if( 18 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 18 == namespaceId && "style" == name)
    return new ShapeStyle();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvPicPr","blipFill","spPr","style" };
    private static readonly byte[] eleNamespaceIds = { 18,18,18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Picture.</para>
    /// <para> Represents the following element tag in the schema: xdr:nvPicPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualPictureProperties NonVisualPictureProperties
    {
        get => GetElement<NonVisualPictureProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Picture Fill.</para>
    /// <para> Represents the following element tag in the schema: xdr:blipFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public BlipFill BlipFill
    {
        get => GetElement<BlipFill>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: xdr:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Shape Style.</para>
    /// <para> Represents the following element tag in the schema: xdr:style </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public ShapeStyle ShapeStyle
    {
        get => GetElement<ShapeStyle>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Picture>(deep);

}
/// <summary>
/// <para>Defines the ContentPart Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:contentPart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties &lt;xdr14:nvContentPartPr></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties &lt;xdr14:nvPr></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D &lt;xdr14:xfrm></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList &lt;xdr14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContentPart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10794;
    /// <inheritdoc/>
    public override string LocalName => "contentPart";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(19, "id"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>(0, "bwMode")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> bwMode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ContentPart class.
    /// </summary>
    public ContentPart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ContentPart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContentPart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContentPart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContentPart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContentPart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContentPart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 54 == namespaceId && "nvContentPartPr" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties();
    
if( 54 == namespaceId && "nvPr" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties();
    
if( 54 == namespaceId && "xfrm" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D();
    
if( 54 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvContentPartPr","nvPr","xfrm","extLst" };
    private static readonly byte[] eleNamespaceIds = { 54,54,54,54 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ExcelNonVisualContentPartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: xdr14:nvContentPartPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties ExcelNonVisualContentPartShapeProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ApplicationNonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: xdr14:nvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Transform2D.</para>
    /// <para> Represents the following element tag in the schema: xdr14:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D Transform2D
    {
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: xdr14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentPart>(deep);

}
/// <summary>
/// <para>Worksheet Drawing. The root element of DrawingsPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:wsDr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TwoCellAnchor &lt;xdr:twoCellAnchor></description></item>
///<item><description>OneCellAnchor &lt;xdr:oneCellAnchor></description></item>
///<item><description>AbsoluteAnchor &lt;xdr:absoluteAnchor></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TwoCellAnchor))]
    [ChildElementInfo(typeof(OneCellAnchor))]
    [ChildElementInfo(typeof(AbsoluteAnchor))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WorksheetDrawing : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 10795;
    /// <inheritdoc/>
    public override string LocalName => "wsDr";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    
	internal WorksheetDrawing(DrawingsPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the DrawingsPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(DrawingsPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the DrawingsPart associated with this element.
    /// </summary>
    public DrawingsPart DrawingsPart
    {
		get => OpenXmlPart as DrawingsPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the WorksheetDrawing class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WorksheetDrawing(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WorksheetDrawing class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WorksheetDrawing(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WorksheetDrawing class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WorksheetDrawing(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the WorksheetDrawing class.
    /// </summary>
    public WorksheetDrawing():base(){}
    
    /// <summary>
    /// Saves the DOM into the DrawingsPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(DrawingsPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 18 == namespaceId && "twoCellAnchor" == name)
    return new TwoCellAnchor();
    
if( 18 == namespaceId && "oneCellAnchor" == name)
    return new OneCellAnchor();
    
if( 18 == namespaceId && "absoluteAnchor" == name)
    return new AbsoluteAnchor();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorksheetDrawing>(deep);

}
/// <summary>
/// <para>Non-Visual Properties for a Shape.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:nvSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;xdr:cNvPr></description></item>
///<item><description>NonVisualShapeDrawingProperties &lt;xdr:cNvSpPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualShapeDrawingProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10796;
    /// <inheritdoc/>
    public override string LocalName => "nvSpPr";
    
    internal override byte NamespaceId => 18;
    
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
    if( 18 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 18 == namespaceId && "cNvSpPr" == name)
    return new NonVisualShapeDrawingProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvSpPr" };
    private static readonly byte[] eleNamespaceIds = { 18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Connection Non-Visual Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
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
/// <para> When the object is serialized out as xml, its qualified name is xdr:spPr.</para>
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
    internal const int ElementTypeIdConst = 10797;
    /// <inheritdoc/>
    public override string LocalName => "spPr";
    
    internal override byte NamespaceId => 18;
    
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
/// <para>Defines the ShapeStyle Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:style.</para>
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
public partial class ShapeStyle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10798;
    /// <inheritdoc/>
    public override string LocalName => "style";
    
    internal override byte NamespaceId => 18;
    
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
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeStyle>(deep);

}
/// <summary>
/// <para>Shape Text Body.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:txBody.</para>
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
    internal const int ElementTypeIdConst = 10799;
    /// <inheritdoc/>
    public override string LocalName => "txBody";
    
    internal override byte NamespaceId => 18;
    
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
/// <para>Non-Visual Properties for a Connection Shape.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:nvCxnSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;xdr:cNvPr></description></item>
///<item><description>NonVisualConnectorShapeDrawingProperties &lt;xdr:cNvCxnSpPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualConnectorShapeDrawingProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualConnectionShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10800;
    /// <inheritdoc/>
    public override string LocalName => "nvCxnSpPr";
    
    internal override byte NamespaceId => 18;
    
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
    if( 18 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 18 == namespaceId && "cNvCxnSpPr" == name)
    return new NonVisualConnectorShapeDrawingProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvCxnSpPr" };
    private static readonly byte[] eleNamespaceIds = { 18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Connection Non-Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Non-Visual Connector Shape Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvCxnSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualConnectorShapeDrawingProperties NonVisualConnectorShapeDrawingProperties
    {
        get => GetElement<NonVisualConnectorShapeDrawingProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectionShapeProperties>(deep);

}
/// <summary>
/// <para>Non-Visual Properties for a Picture.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:nvPicPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;xdr:cNvPr></description></item>
///<item><description>NonVisualPictureDrawingProperties &lt;xdr:cNvPicPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualPictureDrawingProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualPictureProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10801;
    /// <inheritdoc/>
    public override string LocalName => "nvPicPr";
    
    internal override byte NamespaceId => 18;
    
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
    if( 18 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 18 == namespaceId && "cNvPicPr" == name)
    return new NonVisualPictureDrawingProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvPicPr" };
    private static readonly byte[] eleNamespaceIds = { 18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Non-Visual Picture Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPicPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
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
/// <para> When the object is serialized out as xml, its qualified name is xdr:blipFill.</para>
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
    internal const int ElementTypeIdConst = 10802;
    /// <inheritdoc/>
    public override string LocalName => "blipFill";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "rotWithShape")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Rotate With Shape.</para>
    /// <para>Represents the following attribute in the schema: rotWithShape </para>
    /// </summary>
    [SchemaAttr(0, "rotWithShape")]
    public BooleanValue RotateWithShape
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
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
/// <para>Non-Visual Properties for a Graphic Frame.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:nvGraphicFramePr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;xdr:cNvPr></description></item>
///<item><description>NonVisualGraphicFrameDrawingProperties &lt;xdr:cNvGraphicFramePr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualGraphicFrameDrawingProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualGraphicFrameProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10803;
    /// <inheritdoc/>
    public override string LocalName => "nvGraphicFramePr";
    
    internal override byte NamespaceId => 18;
    
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
    if( 18 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 18 == namespaceId && "cNvGraphicFramePr" == name)
    return new NonVisualGraphicFrameDrawingProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvGraphicFramePr" };
    private static readonly byte[] eleNamespaceIds = { 18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Connection Non-Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Non-Visual Graphic Frame Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvGraphicFramePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
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
/// <para>2D Transform for Graphic Frames.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:xfrm.</para>
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
    internal const int ElementTypeIdConst = 10804;
    /// <inheritdoc/>
    public override string LocalName => "xfrm";
    
    internal override byte NamespaceId => 18;
    
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
/// <para>Column).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:col.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnId : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10805;
    /// <inheritdoc/>
    public override string LocalName => "col";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ColumnId class.
    /// </summary>
    public ColumnId():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the ColumnId class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ColumnId(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnId>(deep);

}
/// <summary>
/// <para>Column Offset.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:colOff.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnOffset : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10806;
    /// <inheritdoc/>
    public override string LocalName => "colOff";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ColumnOffset class.
    /// </summary>
    public ColumnOffset():base(){}
    
        /// <summary>
    /// Initializes a new instance of the ColumnOffset class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ColumnOffset(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int64Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnOffset>(deep);

}
/// <summary>
/// <para>Row Offset.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:rowOff.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RowOffset : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10808;
    /// <inheritdoc/>
    public override string LocalName => "rowOff";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the RowOffset class.
    /// </summary>
    public RowOffset():base(){}
    
        /// <summary>
    /// Initializes a new instance of the RowOffset class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public RowOffset(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int64Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowOffset>(deep);

}
/// <summary>
/// <para>Row.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:row.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RowId : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10807;
    /// <inheritdoc/>
    public override string LocalName => "row";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RowId class.
    /// </summary>
    public RowId():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the RowId class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public RowId(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowId>(deep);

}
/// <summary>
/// <para>Starting Anchor Point.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:from.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ColumnId &lt;xdr:col></description></item>
///<item><description>ColumnOffset &lt;xdr:colOff></description></item>
///<item><description>RowId &lt;xdr:row></description></item>
///<item><description>RowOffset &lt;xdr:rowOff></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FromMarker : MarkerType
{
    internal const int ElementTypeIdConst = 10809;
    /// <inheritdoc/>
    public override string LocalName => "from";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the FromMarker class.
    /// </summary>
    public FromMarker():base(){}
        /// <summary>
    ///Initializes a new instance of the FromMarker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FromMarker(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FromMarker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FromMarker(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FromMarker class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FromMarker(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FromMarker>(deep);

}
/// <summary>
/// <para>Ending Anchor Point.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:to.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ColumnId &lt;xdr:col></description></item>
///<item><description>ColumnOffset &lt;xdr:colOff></description></item>
///<item><description>RowId &lt;xdr:row></description></item>
///<item><description>RowOffset &lt;xdr:rowOff></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ToMarker : MarkerType
{
    internal const int ElementTypeIdConst = 10810;
    /// <inheritdoc/>
    public override string LocalName => "to";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ToMarker class.
    /// </summary>
    public ToMarker():base(){}
        /// <summary>
    ///Initializes a new instance of the ToMarker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ToMarker(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ToMarker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ToMarker(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ToMarker class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ToMarker(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToMarker>(deep);

}
/// <summary>
/// Defines the MarkerType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ColumnId &lt;xdr:col></description></item>
///<item><description>ColumnOffset &lt;xdr:colOff></description></item>
///<item><description>RowId &lt;xdr:row></description></item>
///<item><description>RowOffset &lt;xdr:rowOff></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ColumnId))]
    [ChildElementInfo(typeof(ColumnOffset))]
    [ChildElementInfo(typeof(RowId))]
    [ChildElementInfo(typeof(RowOffset))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class MarkerType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 18 == namespaceId && "col" == name)
    return new ColumnId();
    
if( 18 == namespaceId && "colOff" == name)
    return new ColumnOffset();
    
if( 18 == namespaceId && "row" == name)
    return new RowId();
    
if( 18 == namespaceId && "rowOff" == name)
    return new RowOffset();
    

    return null;
}

        private static readonly string[] eleTagNames = { "col","colOff","row","rowOff" };
    private static readonly byte[] eleNamespaceIds = { 18,18,18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Column).</para>
    /// <para> Represents the following element tag in the schema: xdr:col </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public ColumnId ColumnId
    {
        get => GetElement<ColumnId>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Column Offset.</para>
    /// <para> Represents the following element tag in the schema: xdr:colOff </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public ColumnOffset ColumnOffset
    {
        get => GetElement<ColumnOffset>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Row.</para>
    /// <para> Represents the following element tag in the schema: xdr:row </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public RowId RowId
    {
        get => GetElement<RowId>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Row Offset.</para>
    /// <para> Represents the following element tag in the schema: xdr:rowOff </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public RowOffset RowOffset
    {
        get => GetElement<RowOffset>(3);
        set => SetElement(3, value);
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
/// <para>Client Data.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:clientData.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ClientData : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10811;
    /// <inheritdoc/>
    public override string LocalName => "clientData";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "fLocksWithSheet"),
		AttributeTag.Create<BooleanValue>(0, "fPrintsWithSheet")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Locks With Sheet Flag.</para>
    /// <para>Represents the following attribute in the schema: fLocksWithSheet </para>
    /// </summary>
    [SchemaAttr(0, "fLocksWithSheet")]
    public BooleanValue LockWithSheet
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Prints With Sheet Flag.</para>
    /// <para>Represents the following attribute in the schema: fPrintsWithSheet </para>
    /// </summary>
    [SchemaAttr(0, "fPrintsWithSheet")]
    public BooleanValue PrintWithSheet
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ClientData class.
    /// </summary>
    public ClientData():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClientData>(deep);

}
/// <summary>
/// <para>Defines the Extent Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:ext.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Extent : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10812;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 18;
    
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
/// <para>Position.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:pos.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Position : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10813;
    /// <inheritdoc/>
    public override string LocalName => "pos";
    
    internal override byte NamespaceId => 18;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int64Value>(0, "x"),
		AttributeTag.Create<Int64Value>(0, "y")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> X-Axis Coordinate.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    public Int64Value X
    {
        get { return (Int64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Y-Axis Coordinate.</para>
    /// <para>Represents the following attribute in the schema: y </para>
    /// </summary>
    [SchemaAttr(0, "y")]
    public Int64Value Y
    {
        get { return (Int64Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Position class.
    /// </summary>
    public Position():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Position>(deep);

}
/// <summary>
/// <para>Non-Visual Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:cNvPr.</para>
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
    internal const int ElementTypeIdConst = 10814;
    /// <inheritdoc/>
    public override string LocalName => "cNvPr";
    
    internal override byte NamespaceId => 18;
    
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
/// <para>Connection Non-Visual Shape Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:cNvSpPr.</para>
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
    internal const int ElementTypeIdConst = 10815;
    /// <inheritdoc/>
    public override string LocalName => "cNvSpPr";
    
    internal override byte NamespaceId => 18;
    
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
/// <para>Non-Visual Connector Shape Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:cNvCxnSpPr.</para>
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
public partial class NonVisualConnectorShapeDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10816;
    /// <inheritdoc/>
    public override string LocalName => "cNvCxnSpPr";
    
    internal override byte NamespaceId => 18;
    
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
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectorShapeDrawingProperties>(deep);

}
/// <summary>
/// <para>Non-Visual Picture Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:cNvPicPr.</para>
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
    internal const int ElementTypeIdConst = 10817;
    /// <inheritdoc/>
    public override string LocalName => "cNvPicPr";
    
    internal override byte NamespaceId => 18;
    
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
/// <para>Non-Visual Graphic Frame Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:cNvGraphicFramePr.</para>
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
    internal const int ElementTypeIdConst = 10818;
    /// <inheritdoc/>
    public override string LocalName => "cNvGraphicFramePr";
    
    internal override byte NamespaceId => 18;
    
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
/// <para>Non-Visual Group Shape Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:cNvGrpSpPr.</para>
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
    internal const int ElementTypeIdConst = 10819;
    /// <inheritdoc/>
    public override string LocalName => "cNvGrpSpPr";
    
    internal override byte NamespaceId => 18;
    
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
/// <para>Non-Visual Properties for a Group Shape.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is xdr:nvGrpSpPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;xdr:cNvPr></description></item>
///<item><description>NonVisualGroupShapeDrawingProperties &lt;xdr:cNvGrpSpPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualGroupShapeDrawingProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualGroupShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10820;
    /// <inheritdoc/>
    public override string LocalName => "nvGrpSpPr";
    
    internal override byte NamespaceId => 18;
    
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
    if( 18 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 18 == namespaceId && "cNvGrpSpPr" == name)
    return new NonVisualGroupShapeDrawingProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvGrpSpPr" };
    private static readonly byte[] eleNamespaceIds = { 18,18 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Connection Non-Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Non-Visual Group Shape Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvGrpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
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
/// <para> When the object is serialized out as xml, its qualified name is xdr:grpSpPr.</para>
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
    internal const int ElementTypeIdConst = 10821;
    /// <inheritdoc/>
    public override string LocalName => "grpSpPr";
    
    internal override byte NamespaceId => 18;
    
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
/// <summary>
/// Resizing Behaviors 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum EditAsValues
{  
	///<summary>
///Move and Resize With Anchor Cells.
///<para>When the item is serialized out as xml, its value is "twoCell".</para>
///</summary>
[EnumString("twoCell")]
TwoCell,
///<summary>
///Move With Cells but Do Not Resize.
///<para>When the item is serialized out as xml, its value is "oneCell".</para>
///</summary>
[EnumString("oneCell")]
OneCell,
///<summary>
///Do Not Move or Resize With Underlying Rows/Columns.
///<para>When the item is serialized out as xml, its value is "absolute".</para>
///</summary>
[EnumString("absolute")]
Absolute,
 
}
}
 
 
