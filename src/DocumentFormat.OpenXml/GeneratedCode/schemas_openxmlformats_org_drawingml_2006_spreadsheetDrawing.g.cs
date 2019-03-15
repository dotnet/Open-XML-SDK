// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "twoCellAnchor")]
[Id(ElementTypeIdConst)]
public partial class TwoCellAnchor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10786;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Positioning and Resizing Behaviors.</para>
    /// <para>Represents the following attribute in the schema: editAs </para>
    /// </summary>
    [SchemaAttr(0, "editAs")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Spreadsheet.EditAsValues> EditAs { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Starting Anchor Point.</para>
    /// <para> Represents the following element tag in the schema: xdr:from </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "oneCellAnchor")]
[Id(ElementTypeIdConst)]
public partial class OneCellAnchor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10787;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> FromMarker.</para>
    /// <para> Represents the following element tag in the schema: xdr:from </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "absoluteAnchor")]
[Id(ElementTypeIdConst)]
public partial class AbsoluteAnchor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10788;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Position.</para>
    /// <para> Represents the following element tag in the schema: xdr:pos </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "sp")]
[Id(ElementTypeIdConst)]
public partial class Shape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10789;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Reference to Custom Function.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    [Index(0)]
    public StringValue Macro { get; set; }
	
    /// <summary>
    /// <para> Text Link.</para>
    /// <para>Represents the following attribute in the schema: textlink </para>
    /// </summary>
    [SchemaAttr(0, "textlink")]
    [Index(1)]
    public StringValue TextLink { get; set; }
	
    /// <summary>
    /// <para> Lock Text Flag.</para>
    /// <para>Represents the following attribute in the schema: fLocksText </para>
    /// </summary>
    [SchemaAttr(0, "fLocksText")]
    [Index(2)]
    public BooleanValue LockText { get; set; }
	
    /// <summary>
    /// <para> Publish to Server Flag.</para>
    /// <para>Represents the following attribute in the schema: fPublished </para>
    /// </summary>
    [SchemaAttr(0, "fPublished")]
    [Index(3)]
    public BooleanValue Published { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Shape.</para>
    /// <para> Represents the following element tag in the schema: xdr:nvSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "grpSp")]
[Id(ElementTypeIdConst)]
public partial class GroupShape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10790;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Group Shape.</para>
    /// <para> Represents the following element tag in the schema: xdr:nvGrpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "graphicFrame")]
[Id(ElementTypeIdConst)]
public partial class GraphicFrame : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10791;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Reference To Custom Function.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    [Index(0)]
    public StringValue Macro { get; set; }
	
    /// <summary>
    /// <para> Publish to Server Flag.</para>
    /// <para>Represents the following attribute in the schema: fPublished </para>
    /// </summary>
    [SchemaAttr(0, "fPublished")]
    [Index(1)]
    public BooleanValue Published { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Graphic Frame.</para>
    /// <para> Represents the following element tag in the schema: xdr:nvGraphicFramePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "cxnSp")]
[Id(ElementTypeIdConst)]
public partial class ConnectionShape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10792;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Reference to Custom Function.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    [Index(0)]
    public StringValue Macro { get; set; }
	
    /// <summary>
    /// <para> Publish to Server Flag.</para>
    /// <para>Represents the following attribute in the schema: fPublished </para>
    /// </summary>
    [SchemaAttr(0, "fPublished")]
    [Index(1)]
    public BooleanValue Published { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Connection Shape.</para>
    /// <para> Represents the following element tag in the schema: xdr:nvCxnSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "pic")]
[Id(ElementTypeIdConst)]
public partial class Picture : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10793;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Reference To Custom Function.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    [Index(0)]
    public StringValue Macro { get; set; }
	
    /// <summary>
    /// <para> Publish to Server Flag.</para>
    /// <para>Represents the following attribute in the schema: fPublished </para>
    /// </summary>
    [SchemaAttr(0, "fPublished")]
    [Index(1)]
    public BooleanValue Published { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Picture.</para>
    /// <para> Represents the following element tag in the schema: xdr:nvPicPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(18, "contentPart")]
[Id(ElementTypeIdConst)]
public partial class ContentPart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10794;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [Index(0)]
    public StringValue RelationshipId { get; set; }
	
    /// <summary>
    /// <para> bwMode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ExcelNonVisualContentPartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: xdr14:nvContentPartPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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

    [ChildElementInfo(typeof(TwoCellAnchor))]
    [ChildElementInfo(typeof(OneCellAnchor))]
    [ChildElementInfo(typeof(AbsoluteAnchor))]

[SchemaAttr(18, "wsDr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WorksheetDrawing : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 10795;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "nvSpPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10796;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "spPr")]
[Id(ElementTypeIdConst)]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10797;
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "style")]
[Id(ElementTypeIdConst)]
public partial class ShapeStyle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10798;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> LineReference.</para>
    /// <para> Represents the following element tag in the schema: a:lnRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "txBody")]
[Id(ElementTypeIdConst)]
public partial class TextBody : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10799;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Body Properties.</para>
    /// <para> Represents the following element tag in the schema: a:bodyPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "nvCxnSpPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualConnectionShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10800;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Connection Non-Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "nvPicPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualPictureProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10801;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "blipFill")]
[Id(ElementTypeIdConst)]
public partial class BlipFill : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10802;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Rotate With Shape.</para>
    /// <para>Represents the following attribute in the schema: rotWithShape </para>
    /// </summary>
    [SchemaAttr(0, "rotWithShape")]
    [Index(0)]
    public BooleanValue RotateWithShape { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Blip.</para>
    /// <para> Represents the following element tag in the schema: a:blip </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "nvGraphicFramePr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualGraphicFrameProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10803;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Connection Non-Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "xfrm")]
[Id(ElementTypeIdConst)]
public partial class Transform : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10804;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Rotation.</para>
    /// <para>Represents the following attribute in the schema: rot </para>
    /// </summary>
    [SchemaAttr(0, "rot")]
    [Index(0)]
    public Int32Value Rotation { get; set; }
	
    /// <summary>
    /// <para> Horizontal Flip.</para>
    /// <para>Represents the following attribute in the schema: flipH </para>
    /// </summary>
    [SchemaAttr(0, "flipH")]
    [Index(1)]
    public BooleanValue HorizontalFlip { get; set; }
	
    /// <summary>
    /// <para> Vertical Flip.</para>
    /// <para>Represents the following attribute in the schema: flipV </para>
    /// </summary>
    [SchemaAttr(0, "flipV")]
    [Index(2)]
    public BooleanValue VerticalFlip { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Offset.</para>
    /// <para> Represents the following element tag in the schema: a:off </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "col")]
[Id(ElementTypeIdConst)]
public partial class ColumnId : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10805;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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

[SchemaAttr(18, "colOff")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnOffset : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10806;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(18, "rowOff")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RowOffset : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10808;
    internal override int ElementTypeId => ElementTypeIdConst;

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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "row")]
[Id(ElementTypeIdConst)]
public partial class RowId : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10807;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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

[SchemaAttr(18, "from")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FromMarker : MarkerType
{
    internal const int ElementTypeIdConst = 10809;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(18, "to")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ToMarker : MarkerType
{
    internal const int ElementTypeIdConst = 10810;
    internal override int ElementTypeId => ElementTypeIdConst;

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

    [ChildElementInfo(typeof(ColumnId))]
    [ChildElementInfo(typeof(ColumnOffset))]
    [ChildElementInfo(typeof(RowId))]
    [ChildElementInfo(typeof(RowOffset))]

public abstract partial class MarkerType : OpenXmlCompositeElement
{
        
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Column).</para>
    /// <para> Represents the following element tag in the schema: xdr:col </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "clientData")]
[Id(ElementTypeIdConst)]
public partial class ClientData : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10811;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Locks With Sheet Flag.</para>
    /// <para>Represents the following attribute in the schema: fLocksWithSheet </para>
    /// </summary>
    [SchemaAttr(0, "fLocksWithSheet")]
    [Index(0)]
    public BooleanValue LockWithSheet { get; set; }
	
    /// <summary>
    /// <para> Prints With Sheet Flag.</para>
    /// <para>Represents the following attribute in the schema: fPrintsWithSheet </para>
    /// </summary>
    [SchemaAttr(0, "fPrintsWithSheet")]
    [Index(1)]
    public BooleanValue PrintWithSheet { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "ext")]
[Id(ElementTypeIdConst)]
public partial class Extent : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10812;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Extent Length.</para>
    /// <para>Represents the following attribute in the schema: cx </para>
    /// </summary>
    [SchemaAttr(0, "cx")]
    [Index(0)]
    public Int64Value Cx { get; set; }
	
    /// <summary>
    /// <para> Extent Width.</para>
    /// <para>Represents the following attribute in the schema: cy </para>
    /// </summary>
    [SchemaAttr(0, "cy")]
    [Index(1)]
    public Int64Value Cy { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "pos")]
[Id(ElementTypeIdConst)]
public partial class Position : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10813;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> X-Axis Coordinate.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    [Index(0)]
    public Int64Value X { get; set; }
	
    /// <summary>
    /// <para> Y-Axis Coordinate.</para>
    /// <para>Represents the following attribute in the schema: y </para>
    /// </summary>
    [SchemaAttr(0, "y")]
    [Index(1)]
    public Int64Value Y { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "cNvPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10814;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public UInt32Value Id { get; set; }
	
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(1)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> descr.</para>
    /// <para>Represents the following attribute in the schema: descr </para>
    /// </summary>
    [SchemaAttr(0, "descr")]
    [Index(2)]
    public StringValue Description { get; set; }
	
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    [Index(3)]
    public BooleanValue Hidden { get; set; }
	
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [Index(4)]
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> HyperlinkOnClick.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkClick </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "cNvSpPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualShapeDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10815;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Text Box.</para>
    /// <para>Represents the following attribute in the schema: txBox </para>
    /// </summary>
    [SchemaAttr(0, "txBox")]
    [Index(0)]
    public BooleanValue TextBox { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Shape Locks.</para>
    /// <para> Represents the following element tag in the schema: a:spLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "cNvCxnSpPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualConnectorShapeDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10816;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Connection Shape Locks.</para>
    /// <para> Represents the following element tag in the schema: a:cxnSpLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "cNvPicPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualPictureDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10817;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> preferRelativeResize.</para>
    /// <para>Represents the following attribute in the schema: preferRelativeResize </para>
    /// </summary>
    [SchemaAttr(0, "preferRelativeResize")]
    [Index(0)]
    public BooleanValue PreferRelativeResize { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PictureLocks.</para>
    /// <para> Represents the following element tag in the schema: a:picLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "cNvGraphicFramePr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualGraphicFrameDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10818;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Graphic Frame Locks.</para>
    /// <para> Represents the following element tag in the schema: a:graphicFrameLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "cNvGrpSpPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualGroupShapeDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10819;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> GroupShapeLocks.</para>
    /// <para> Represents the following element tag in the schema: a:grpSpLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "nvGrpSpPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualGroupShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10820;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Connection Non-Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: xdr:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(18, "grpSpPr")]
[Id(ElementTypeIdConst)]
public partial class GroupShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10821;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    [Index(0)]
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> 2D Transform for Grouped Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
 
 
