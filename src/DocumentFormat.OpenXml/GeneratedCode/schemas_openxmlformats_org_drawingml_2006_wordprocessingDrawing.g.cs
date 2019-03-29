// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2010.Word.Drawing;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Drawing.Wordprocessing
{
/// <summary>
/// <para>No Text Wrapping.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:wrapNone.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "wrapNone")]
[Id(ElementTypeIdConst)]
public partial class WrapNone : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10760;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the WrapNone class.
    /// </summary>
    public WrapNone():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapNone>(deep);

}
/// <summary>
/// <para>Square Wrapping.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:wrapSquare.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>EffectExtent &lt;wp:effectExtent></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(EffectExtent))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "wrapSquare")]
[Id(ElementTypeIdConst)]
public partial class WrapSquare : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10761;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Text Wrapping Location.</para>
    /// <para>Represents the following attribute in the schema: wrapText </para>
    /// </summary>
    [SchemaAttr(0, "wrapText")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues> WrapText { get; set; }
	
    /// <summary>
    /// <para> Distance From Text (Top).</para>
    /// <para>Represents the following attribute in the schema: distT </para>
    /// </summary>
    [SchemaAttr(0, "distT")]
    [Index(1)]
    public UInt32Value DistanceFromTop { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Bottom Edge.</para>
    /// <para>Represents the following attribute in the schema: distB </para>
    /// </summary>
    [SchemaAttr(0, "distB")]
    [Index(2)]
    public UInt32Value DistanceFromBottom { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: distL </para>
    /// </summary>
    [SchemaAttr(0, "distL")]
    [Index(3)]
    public UInt32Value DistanceFromLeft { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: distR </para>
    /// </summary>
    [SchemaAttr(0, "distR")]
    [Index(4)]
    public UInt32Value DistanceFromRight { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WrapSquare class.
    /// </summary>
    public WrapSquare():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WrapSquare class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WrapSquare(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WrapSquare class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WrapSquare(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WrapSquare class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WrapSquare(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Object Extents Including Effects.</para>
    /// <para> Represents the following element tag in the schema: wp:effectExtent </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public EffectExtent EffectExtent
	{
        get => GetElement<EffectExtent>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapSquare>(deep);

}
/// <summary>
/// <para>Tight Wrapping.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:wrapTight.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WrapPolygon &lt;wp:wrapPolygon></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(WrapPolygon))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "wrapTight")]
[Id(ElementTypeIdConst)]
public partial class WrapTight : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10762;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Text Wrapping Location.</para>
    /// <para>Represents the following attribute in the schema: wrapText </para>
    /// </summary>
    [SchemaAttr(0, "wrapText")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues> WrapText { get; set; }
	
    /// <summary>
    /// <para> Distance From Test on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: distL </para>
    /// </summary>
    [SchemaAttr(0, "distL")]
    [Index(1)]
    public UInt32Value DistanceFromLeft { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: distR </para>
    /// </summary>
    [SchemaAttr(0, "distR")]
    [Index(2)]
    public UInt32Value DistanceFromRight { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WrapTight class.
    /// </summary>
    public WrapTight():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WrapTight class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WrapTight(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WrapTight class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WrapTight(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WrapTight class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WrapTight(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Tight Wrapping Extents Polygon.</para>
    /// <para> Represents the following element tag in the schema: wp:wrapPolygon </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public WrapPolygon WrapPolygon
	{
        get => GetElement<WrapPolygon>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapTight>(deep);

}
/// <summary>
/// <para>Through Wrapping.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:wrapThrough.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WrapPolygon &lt;wp:wrapPolygon></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(WrapPolygon))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "wrapThrough")]
[Id(ElementTypeIdConst)]
public partial class WrapThrough : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10763;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Text Wrapping Location.</para>
    /// <para>Represents the following attribute in the schema: wrapText </para>
    /// </summary>
    [SchemaAttr(0, "wrapText")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues> WrapText { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: distL </para>
    /// </summary>
    [SchemaAttr(0, "distL")]
    [Index(1)]
    public UInt32Value DistanceFromLeft { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: distR </para>
    /// </summary>
    [SchemaAttr(0, "distR")]
    [Index(2)]
    public UInt32Value DistanceFromRight { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WrapThrough class.
    /// </summary>
    public WrapThrough():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WrapThrough class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WrapThrough(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WrapThrough class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WrapThrough(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WrapThrough class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WrapThrough(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Wrapping Polygon.</para>
    /// <para> Represents the following element tag in the schema: wp:wrapPolygon </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public WrapPolygon WrapPolygon
	{
        get => GetElement<WrapPolygon>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapThrough>(deep);

}
/// <summary>
/// <para>Top and Bottom Wrapping.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:wrapTopAndBottom.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>EffectExtent &lt;wp:effectExtent></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(EffectExtent))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "wrapTopAndBottom")]
[Id(ElementTypeIdConst)]
public partial class WrapTopBottom : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10764;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Distance From Text on Top Edge.</para>
    /// <para>Represents the following attribute in the schema: distT </para>
    /// </summary>
    [SchemaAttr(0, "distT")]
    [Index(0)]
    public UInt32Value DistanceFromTop { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Bottom Edge.</para>
    /// <para>Represents the following attribute in the schema: distB </para>
    /// </summary>
    [SchemaAttr(0, "distB")]
    [Index(1)]
    public UInt32Value DistanceFromBottom { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WrapTopBottom class.
    /// </summary>
    public WrapTopBottom():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WrapTopBottom class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WrapTopBottom(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WrapTopBottom class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WrapTopBottom(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WrapTopBottom class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WrapTopBottom(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Wrapping Boundaries.</para>
    /// <para> Represents the following element tag in the schema: wp:effectExtent </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public EffectExtent EffectExtent
	{
        get => GetElement<EffectExtent>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapTopBottom>(deep);

}
/// <summary>
/// <para>Inline DrawingML Object.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:inline.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Extent &lt;wp:extent></description></item>
///<item><description>EffectExtent &lt;wp:effectExtent></description></item>
///<item><description>DocProperties &lt;wp:docPr></description></item>
///<item><description>NonVisualGraphicFrameDrawingProperties &lt;wp:cNvGraphicFramePr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Graphic &lt;a:graphic></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Extent))]
    [ChildElementInfo(typeof(EffectExtent))]
    [ChildElementInfo(typeof(DocProperties))]
    [ChildElementInfo(typeof(NonVisualGraphicFrameDrawingProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Graphic))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "inline")]
[Id(ElementTypeIdConst)]
public partial class Inline : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10765;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Distance From Text on Top Edge.</para>
    /// <para>Represents the following attribute in the schema: distT </para>
    /// </summary>
    [SchemaAttr(0, "distT")]
    [Index(0)]
    public UInt32Value DistanceFromTop { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Bottom Edge.</para>
    /// <para>Represents the following attribute in the schema: distB </para>
    /// </summary>
    [SchemaAttr(0, "distB")]
    [Index(1)]
    public UInt32Value DistanceFromBottom { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: distL </para>
    /// </summary>
    [SchemaAttr(0, "distL")]
    [Index(2)]
    public UInt32Value DistanceFromLeft { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: distR </para>
    /// </summary>
    [SchemaAttr(0, "distR")]
    [Index(3)]
    public UInt32Value DistanceFromRight { get; set; }
	
    /// <summary>
    /// <para> anchorId.</para>
    /// <para>Represents the following attribute in the schema: wp14:anchorId </para>
    /// </summary>
///<remark> xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
///</remark>
    [SchemaAttr(51, "anchorId")]
    [Index(4)]
    public HexBinaryValue AnchorId { get; set; }
	
    /// <summary>
    /// <para> editId.</para>
    /// <para>Represents the following attribute in the schema: wp14:editId </para>
    /// </summary>
///<remark> xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
///</remark>
    [SchemaAttr(51, "editId")]
    [Index(5)]
    public HexBinaryValue EditId { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Inline class.
    /// </summary>
    public Inline():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Inline class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Inline(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Inline class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Inline(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Inline class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Inline(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Drawing Object Size.</para>
    /// <para> Represents the following element tag in the schema: wp:extent </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public Extent Extent
	{
        get => GetElement<Extent>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Inline Wrapping Extent.</para>
    /// <para> Represents the following element tag in the schema: wp:effectExtent </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(1)]
    public EffectExtent EffectExtent
	{
        get => GetElement<EffectExtent>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Drawing Object Non-Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: wp:docPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(2)]
    public DocProperties DocProperties
	{
        get => GetElement<DocProperties>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> Common DrawingML Non-Visual Properties.</para>
    /// <para> Represents the following element tag in the schema: wp:cNvGraphicFramePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(3)]
    public NonVisualGraphicFrameDrawingProperties NonVisualGraphicFrameDrawingProperties
	{
        get => GetElement<NonVisualGraphicFrameDrawingProperties>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> Graphic.</para>
    /// <para> Represents the following element tag in the schema: a:graphic </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.Graphic Graphic
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Graphic>(4);
        set => SetElement(4, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Inline>(deep);

}
/// <summary>
/// <para>Anchor for Floating DrawingML Object.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:anchor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SimplePosition &lt;wp:simplePos></description></item>
///<item><description>HorizontalPosition &lt;wp:positionH></description></item>
///<item><description>VerticalPosition &lt;wp:positionV></description></item>
///<item><description>Extent &lt;wp:extent></description></item>
///<item><description>EffectExtent &lt;wp:effectExtent></description></item>
///<item><description>WrapNone &lt;wp:wrapNone></description></item>
///<item><description>WrapSquare &lt;wp:wrapSquare></description></item>
///<item><description>WrapTight &lt;wp:wrapTight></description></item>
///<item><description>WrapThrough &lt;wp:wrapThrough></description></item>
///<item><description>WrapTopBottom &lt;wp:wrapTopAndBottom></description></item>
///<item><description>DocProperties &lt;wp:docPr></description></item>
///<item><description>NonVisualGraphicFrameDrawingProperties &lt;wp:cNvGraphicFramePr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Graphic &lt;a:graphic></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth &lt;wp14:sizeRelH></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight &lt;wp14:sizeRelV></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SimplePosition))]
    [ChildElementInfo(typeof(HorizontalPosition))]
    [ChildElementInfo(typeof(VerticalPosition))]
    [ChildElementInfo(typeof(Extent))]
    [ChildElementInfo(typeof(EffectExtent))]
    [ChildElementInfo(typeof(WrapNone))]
    [ChildElementInfo(typeof(WrapSquare))]
    [ChildElementInfo(typeof(WrapTight))]
    [ChildElementInfo(typeof(WrapThrough))]
    [ChildElementInfo(typeof(WrapTopBottom))]
    [ChildElementInfo(typeof(DocProperties))]
    [ChildElementInfo(typeof(NonVisualGraphicFrameDrawingProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Graphic))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "anchor")]
[Id(ElementTypeIdConst)]
public partial class Anchor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10766;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Distance From Text on Top Edge.</para>
    /// <para>Represents the following attribute in the schema: distT </para>
    /// </summary>
    [SchemaAttr(0, "distT")]
    [Index(0)]
    public UInt32Value DistanceFromTop { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Bottom Edge.</para>
    /// <para>Represents the following attribute in the schema: distB </para>
    /// </summary>
    [SchemaAttr(0, "distB")]
    [Index(1)]
    public UInt32Value DistanceFromBottom { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: distL </para>
    /// </summary>
    [SchemaAttr(0, "distL")]
    [Index(2)]
    public UInt32Value DistanceFromLeft { get; set; }
	
    /// <summary>
    /// <para> Distance From Text on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: distR </para>
    /// </summary>
    [SchemaAttr(0, "distR")]
    [Index(3)]
    public UInt32Value DistanceFromRight { get; set; }
	
    /// <summary>
    /// <para> Page Positioning.</para>
    /// <para>Represents the following attribute in the schema: simplePos </para>
    /// </summary>
    [SchemaAttr(0, "simplePos")]
    [Index(4)]
    public BooleanValue SimplePos { get; set; }
	
    /// <summary>
    /// <para> Relative Z-Ordering Position.</para>
    /// <para>Represents the following attribute in the schema: relativeHeight </para>
    /// </summary>
    [SchemaAttr(0, "relativeHeight")]
    [Index(5)]
    public UInt32Value RelativeHeight { get; set; }
	
    /// <summary>
    /// <para> Display Behind Document Text.</para>
    /// <para>Represents the following attribute in the schema: behindDoc </para>
    /// </summary>
    [SchemaAttr(0, "behindDoc")]
    [Index(6)]
    public BooleanValue BehindDoc { get; set; }
	
    /// <summary>
    /// <para> Lock Anchor.</para>
    /// <para>Represents the following attribute in the schema: locked </para>
    /// </summary>
    [SchemaAttr(0, "locked")]
    [Index(7)]
    public BooleanValue Locked { get; set; }
	
    /// <summary>
    /// <para> Layout In Table Cell.</para>
    /// <para>Represents the following attribute in the schema: layoutInCell </para>
    /// </summary>
    [SchemaAttr(0, "layoutInCell")]
    [Index(8)]
    public BooleanValue LayoutInCell { get; set; }
	
    /// <summary>
    /// <para> Hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    [Index(9)]
    public BooleanValue Hidden { get; set; }
	
    /// <summary>
    /// <para> Allow Objects to Overlap.</para>
    /// <para>Represents the following attribute in the schema: allowOverlap </para>
    /// </summary>
    [SchemaAttr(0, "allowOverlap")]
    [Index(10)]
    public BooleanValue AllowOverlap { get; set; }
	
    /// <summary>
    /// <para> editId.</para>
    /// <para>Represents the following attribute in the schema: wp14:editId </para>
    /// </summary>
///<remark> xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
///</remark>
    [SchemaAttr(51, "editId")]
    [Index(11)]
    public HexBinaryValue EditId { get; set; }
	
    /// <summary>
    /// <para> anchorId.</para>
    /// <para>Represents the following attribute in the schema: wp14:anchorId </para>
    /// </summary>
///<remark> xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
///</remark>
    [SchemaAttr(51, "anchorId")]
    [Index(12)]
    public HexBinaryValue AnchorId { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Anchor class.
    /// </summary>
    public Anchor():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Anchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Anchor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Anchor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Anchor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Anchor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Anchor(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Simple Positioning Coordinates.</para>
    /// <para> Represents the following element tag in the schema: wp:simplePos </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public SimplePosition SimplePosition
	{
        get => GetElement<SimplePosition>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Horizontal Positioning.</para>
    /// <para> Represents the following element tag in the schema: wp:positionH </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(1)]
    public HorizontalPosition HorizontalPosition
	{
        get => GetElement<HorizontalPosition>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Vertical Positioning.</para>
    /// <para> Represents the following element tag in the schema: wp:positionV </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(2)]
    public VerticalPosition VerticalPosition
	{
        get => GetElement<VerticalPosition>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> Inline Drawing Object Extents.</para>
    /// <para> Represents the following element tag in the schema: wp:extent </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(3)]
    public Extent Extent
	{
        get => GetElement<Extent>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> EffectExtent.</para>
    /// <para> Represents the following element tag in the schema: wp:effectExtent </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(4)]
    public EffectExtent EffectExtent
	{
        get => GetElement<EffectExtent>(4);
        set => SetElement(4, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Anchor>(deep);

}
/// <summary>
/// <para>Wrapping Polygon Start.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:start.</para>
/// </summary>

[SchemaAttr(16, "start")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StartPoint : Point2DType
{
    internal const int ElementTypeIdConst = 10767;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the StartPoint class.
    /// </summary>
    public StartPoint():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StartPoint>(deep);

}
/// <summary>
/// <para>Wrapping Polygon Line End Position.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:lineTo.</para>
/// </summary>

[SchemaAttr(16, "lineTo")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LineTo : Point2DType
{
    internal const int ElementTypeIdConst = 10768;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the LineTo class.
    /// </summary>
    public LineTo():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineTo>(deep);

}
/// <summary>
/// <para>Simple Positioning Coordinates.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:simplePos.</para>
/// </summary>

[SchemaAttr(16, "simplePos")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SimplePosition : Point2DType
{
    internal const int ElementTypeIdConst = 10771;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the SimplePosition class.
    /// </summary>
    public SimplePosition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SimplePosition>(deep);

}
/// <summary>
/// Defines the Point2DType class.
/// </summary>


public abstract partial class Point2DType : OpenXmlLeafElement
{
        
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
    /// Initializes a new instance of the Point2DType class.
    /// </summary>
    protected Point2DType(){}
    
    
    
}
/// <summary>
/// <para>Object Extents Including Effects.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:effectExtent.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "effectExtent")]
[Id(ElementTypeIdConst)]
public partial class EffectExtent : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10769;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Additional Extent on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: l </para>
    /// </summary>
    [SchemaAttr(0, "l")]
    [Index(0)]
    public Int64Value LeftEdge { get; set; }
	
    /// <summary>
    /// <para> Additional Extent on Top Edge.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    [Index(1)]
    public Int64Value TopEdge { get; set; }
	
    /// <summary>
    /// <para> Additional Extent on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    [Index(2)]
    public Int64Value RightEdge { get; set; }
	
    /// <summary>
    /// <para> Additional Extent on Bottom Edge.</para>
    /// <para>Represents the following attribute in the schema: b </para>
    /// </summary>
    [SchemaAttr(0, "b")]
    [Index(3)]
    public Int64Value BottomEdge { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the EffectExtent class.
    /// </summary>
    public EffectExtent():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectExtent>(deep);

}
/// <summary>
/// <para>Tight Wrapping Extents Polygon.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:wrapPolygon.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StartPoint &lt;wp:start></description></item>
///<item><description>LineTo &lt;wp:lineTo></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StartPoint))]
    [ChildElementInfo(typeof(LineTo))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "wrapPolygon")]
[Id(ElementTypeIdConst)]
public partial class WrapPolygon : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10770;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Wrapping Points Modified.</para>
    /// <para>Represents the following attribute in the schema: edited </para>
    /// </summary>
    [SchemaAttr(0, "edited")]
    [Index(0)]
    public BooleanValue Edited { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WrapPolygon class.
    /// </summary>
    public WrapPolygon():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WrapPolygon class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WrapPolygon(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WrapPolygon class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WrapPolygon(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WrapPolygon class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WrapPolygon(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Wrapping Polygon Start.</para>
    /// <para> Represents the following element tag in the schema: wp:start </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public StartPoint StartPoint
	{
        get => GetElement<StartPoint>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapPolygon>(deep);

}
/// <summary>
/// <para>Horizontal Positioning.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:positionH.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>HorizontalAlignment &lt;wp:align></description></item>
///<item><description>PositionOffset &lt;wp:posOffset></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset &lt;wp14:pctPosHOffset></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(HorizontalAlignment))]
    [ChildElementInfo(typeof(PositionOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "positionH")]
[Id(ElementTypeIdConst)]
public partial class HorizontalPosition : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10772;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Horizontal Position Relative Base.</para>
    /// <para>Represents the following attribute in the schema: relativeFrom </para>
    /// </summary>
    [SchemaAttr(0, "relativeFrom")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues> RelativeFrom { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the HorizontalPosition class.
    /// </summary>
    public HorizontalPosition():base(){}
    
        /// <summary>
    ///Initializes a new instance of the HorizontalPosition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HorizontalPosition(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HorizontalPosition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HorizontalPosition(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HorizontalPosition class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HorizontalPosition(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Relative Horizontal Alignment.</para>
    /// <para> Represents the following element tag in the schema: wp:align </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public HorizontalAlignment HorizontalAlignment
	{
        get => GetElement<HorizontalAlignment>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Absolute Position Offset.</para>
    /// <para> Represents the following element tag in the schema: wp:posOffset </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(1)]
    public PositionOffset PositionOffset
	{
        get => GetElement<PositionOffset>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> PercentagePositionHeightOffset.</para>
    /// <para> Represents the following element tag in the schema: wp14:pctPosHOffset </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp14 = http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset PercentagePositionHeightOffset
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset>(2);
        set => SetElement(2, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HorizontalPosition>(deep);

}
/// <summary>
/// <para>Vertical Positioning.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:positionV.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VerticalAlignment &lt;wp:align></description></item>
///<item><description>PositionOffset &lt;wp:posOffset></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset &lt;wp14:pctPosVOffset></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VerticalAlignment))]
    [ChildElementInfo(typeof(PositionOffset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "positionV")]
[Id(ElementTypeIdConst)]
public partial class VerticalPosition : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10773;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Vertical Position Relative Base.</para>
    /// <para>Represents the following attribute in the schema: relativeFrom </para>
    /// </summary>
    [SchemaAttr(0, "relativeFrom")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues> RelativeFrom { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the VerticalPosition class.
    /// </summary>
    public VerticalPosition():base(){}
    
        /// <summary>
    ///Initializes a new instance of the VerticalPosition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public VerticalPosition(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the VerticalPosition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public VerticalPosition(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the VerticalPosition class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public VerticalPosition(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Relative Vertical Alignment.</para>
    /// <para> Represents the following element tag in the schema: wp:align </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public VerticalAlignment VerticalAlignment
	{
        get => GetElement<VerticalAlignment>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> PositionOffset.</para>
    /// <para> Represents the following element tag in the schema: wp:posOffset </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
	[Index(1)]
    public PositionOffset PositionOffset
	{
        get => GetElement<PositionOffset>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> PercentagePositionVerticalOffset.</para>
    /// <para> Represents the following element tag in the schema: wp14:pctPosVOffset </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp14 = http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset PercentagePositionVerticalOffset
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset>(2);
        set => SetElement(2, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalPosition>(deep);

}
/// <summary>
/// <para>Inline Drawing Object Extents.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:extent.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "extent")]
[Id(ElementTypeIdConst)]
public partial class Extent : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10774;
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
/// <para>Drawing Object Non-Visual Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:docPr.</para>
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
[SchemaAttr(16, "docPr")]
[Id(ElementTypeIdConst)]
public partial class DocProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10775;
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
    /// Initializes a new instance of the DocProperties class.
    /// </summary>
    public DocProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DocProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DocProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DocProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DocProperties(string outerXml)
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
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocProperties>(deep);

}
/// <summary>
/// <para>Defines the NonVisualGraphicFrameDrawingProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:cNvGraphicFramePr.</para>
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
[SchemaAttr(16, "cNvGraphicFramePr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualGraphicFrameDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10776;
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
/// <para>Relative Vertical Alignment.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:align.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "align")]
[Id(ElementTypeIdConst)]
public partial class VerticalAlignment : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10777;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the VerticalAlignment class.
    /// </summary>
    public VerticalAlignment():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the VerticalAlignment class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VerticalAlignment(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignmentValues>(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalAlignment>(deep);

}
/// <summary>
/// <para>Defines the PositionOffset Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:posOffset.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "posOffset")]
[Id(ElementTypeIdConst)]
public partial class PositionOffset : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10778;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the PositionOffset class.
    /// </summary>
    public PositionOffset():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the PositionOffset class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PositionOffset(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PositionOffset>(deep);

}
/// <summary>
/// <para>Relative Horizontal Alignment.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:align.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(16, "align")]
[Id(ElementTypeIdConst)]
public partial class HorizontalAlignment : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10779;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the HorizontalAlignment class.
    /// </summary>
    public HorizontalAlignment():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the HorizontalAlignment class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public HorizontalAlignment(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignmentValues>(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HorizontalAlignment>(deep);

}
/// <summary>
/// Text Wrapping Location 
/// </summary> 
public enum WrapTextValues
{  
	///<summary>
///Both Sides.
///<para>When the item is serialized out as xml, its value is "bothSides".</para>
///</summary>
[EnumString("bothSides")]
BothSides,
///<summary>
///Left Side Only.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///Right Side Only.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,
///<summary>
///Largest Side Only.
///<para>When the item is serialized out as xml, its value is "largest".</para>
///</summary>
[EnumString("largest")]
Largest,
 
}
/// <summary>
/// Relative Horizontal Alignment Positions 
/// </summary> 
public enum HorizontalAlignmentValues
{  
	///<summary>
///Left Alignment.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///Right Alignment.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,
///<summary>
///Center Alignment.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///Inside.
///<para>When the item is serialized out as xml, its value is "inside".</para>
///</summary>
[EnumString("inside")]
Inside,
///<summary>
///Outside.
///<para>When the item is serialized out as xml, its value is "outside".</para>
///</summary>
[EnumString("outside")]
Outside,
 
}
/// <summary>
/// Horizontal Relative Positioning 
/// </summary> 
public enum HorizontalRelativePositionValues
{  
	///<summary>
///Page Margin.
///<para>When the item is serialized out as xml, its value is "margin".</para>
///</summary>
[EnumString("margin")]
Margin,
///<summary>
///Page Edge.
///<para>When the item is serialized out as xml, its value is "page".</para>
///</summary>
[EnumString("page")]
Page,
///<summary>
///Column.
///<para>When the item is serialized out as xml, its value is "column".</para>
///</summary>
[EnumString("column")]
Column,
///<summary>
///Character.
///<para>When the item is serialized out as xml, its value is "character".</para>
///</summary>
[EnumString("character")]
Character,
///<summary>
///Left Margin.
///<para>When the item is serialized out as xml, its value is "leftMargin".</para>
///</summary>
[EnumString("leftMargin")]
LeftMargin,
///<summary>
///Right Margin.
///<para>When the item is serialized out as xml, its value is "rightMargin".</para>
///</summary>
[EnumString("rightMargin")]
RightMargin,
///<summary>
///Inside Margin.
///<para>When the item is serialized out as xml, its value is "insideMargin".</para>
///</summary>
[EnumString("insideMargin")]
InsideMargin,
///<summary>
///Outside Margin.
///<para>When the item is serialized out as xml, its value is "outsideMargin".</para>
///</summary>
[EnumString("outsideMargin")]
OutsideMargin,
 
}
/// <summary>
/// Vertical Alignment Definition 
/// </summary> 
public enum VerticalAlignmentValues
{  
	///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "bottom".</para>
///</summary>
[EnumString("bottom")]
Bottom,
///<summary>
///Center Alignment.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///Inside.
///<para>When the item is serialized out as xml, its value is "inside".</para>
///</summary>
[EnumString("inside")]
Inside,
///<summary>
///Outside.
///<para>When the item is serialized out as xml, its value is "outside".</para>
///</summary>
[EnumString("outside")]
Outside,
 
}
/// <summary>
/// Vertical Relative Positioning 
/// </summary> 
public enum VerticalRelativePositionValues
{  
	///<summary>
///Page Margin.
///<para>When the item is serialized out as xml, its value is "margin".</para>
///</summary>
[EnumString("margin")]
Margin,
///<summary>
///Page Edge.
///<para>When the item is serialized out as xml, its value is "page".</para>
///</summary>
[EnumString("page")]
Page,
///<summary>
///Paragraph.
///<para>When the item is serialized out as xml, its value is "paragraph".</para>
///</summary>
[EnumString("paragraph")]
Paragraph,
///<summary>
///Line.
///<para>When the item is serialized out as xml, its value is "line".</para>
///</summary>
[EnumString("line")]
Line,
///<summary>
///Top Margin.
///<para>When the item is serialized out as xml, its value is "topMargin".</para>
///</summary>
[EnumString("topMargin")]
TopMargin,
///<summary>
///Bottom Margin.
///<para>When the item is serialized out as xml, its value is "bottomMargin".</para>
///</summary>
[EnumString("bottomMargin")]
BottomMargin,
///<summary>
///Inside Margin.
///<para>When the item is serialized out as xml, its value is "insideMargin".</para>
///</summary>
[EnumString("insideMargin")]
InsideMargin,
///<summary>
///Outside Margin.
///<para>When the item is serialized out as xml, its value is "outsideMargin".</para>
///</summary>
[EnumString("outsideMargin")]
OutsideMargin,
 
}
}
 
 
