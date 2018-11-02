// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WrapNone : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10760;
    /// <inheritdoc/>
    public override string LocalName => "wrapNone";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WrapSquare : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10761;
    /// <inheritdoc/>
    public override string LocalName => "wrapSquare";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>>(0, "wrapText"),
		AttributeTag.Create<UInt32Value>(0, "distT"),
		AttributeTag.Create<UInt32Value>(0, "distB"),
		AttributeTag.Create<UInt32Value>(0, "distL"),
		AttributeTag.Create<UInt32Value>(0, "distR")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Text Wrapping Location.</para>
    /// <para>Represents the following attribute in the schema: wrapText </para>
    /// </summary>
    [SchemaAttr(0, "wrapText")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues> WrapText
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text (Top).</para>
    /// <para>Represents the following attribute in the schema: distT </para>
    /// </summary>
    [SchemaAttr(0, "distT")]
    public UInt32Value DistanceFromTop
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Bottom Edge.</para>
    /// <para>Represents the following attribute in the schema: distB </para>
    /// </summary>
    [SchemaAttr(0, "distB")]
    public UInt32Value DistanceFromBottom
    {
        get { return (UInt32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: distL </para>
    /// </summary>
    [SchemaAttr(0, "distL")]
    public UInt32Value DistanceFromLeft
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: distR </para>
    /// </summary>
    [SchemaAttr(0, "distR")]
    public UInt32Value DistanceFromRight
    {
        get { return (UInt32Value)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 16 == namespaceId && "effectExtent" == name)
    return new EffectExtent();
    

    return null;
}

        private static readonly string[] eleTagNames = { "effectExtent" };
    private static readonly byte[] eleNamespaceIds = { 16 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Object Extents Including Effects.</para>
    /// <para> Represents the following element tag in the schema: wp:effectExtent </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WrapTight : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10762;
    /// <inheritdoc/>
    public override string LocalName => "wrapTight";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>>(0, "wrapText"),
		AttributeTag.Create<UInt32Value>(0, "distL"),
		AttributeTag.Create<UInt32Value>(0, "distR")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Text Wrapping Location.</para>
    /// <para>Represents the following attribute in the schema: wrapText </para>
    /// </summary>
    [SchemaAttr(0, "wrapText")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues> WrapText
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Test on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: distL </para>
    /// </summary>
    [SchemaAttr(0, "distL")]
    public UInt32Value DistanceFromLeft
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: distR </para>
    /// </summary>
    [SchemaAttr(0, "distR")]
    public UInt32Value DistanceFromRight
    {
        get { return (UInt32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 16 == namespaceId && "wrapPolygon" == name)
    return new WrapPolygon();
    

    return null;
}

        private static readonly string[] eleTagNames = { "wrapPolygon" };
    private static readonly byte[] eleNamespaceIds = { 16 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Tight Wrapping Extents Polygon.</para>
    /// <para> Represents the following element tag in the schema: wp:wrapPolygon </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WrapThrough : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10763;
    /// <inheritdoc/>
    public override string LocalName => "wrapThrough";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>>(0, "wrapText"),
		AttributeTag.Create<UInt32Value>(0, "distL"),
		AttributeTag.Create<UInt32Value>(0, "distR")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Text Wrapping Location.</para>
    /// <para>Represents the following attribute in the schema: wrapText </para>
    /// </summary>
    [SchemaAttr(0, "wrapText")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues> WrapText
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: distL </para>
    /// </summary>
    [SchemaAttr(0, "distL")]
    public UInt32Value DistanceFromLeft
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: distR </para>
    /// </summary>
    [SchemaAttr(0, "distR")]
    public UInt32Value DistanceFromRight
    {
        get { return (UInt32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 16 == namespaceId && "wrapPolygon" == name)
    return new WrapPolygon();
    

    return null;
}

        private static readonly string[] eleTagNames = { "wrapPolygon" };
    private static readonly byte[] eleNamespaceIds = { 16 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Wrapping Polygon.</para>
    /// <para> Represents the following element tag in the schema: wp:wrapPolygon </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WrapTopBottom : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10764;
    /// <inheritdoc/>
    public override string LocalName => "wrapTopAndBottom";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "distT"),
		AttributeTag.Create<UInt32Value>(0, "distB")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Distance From Text on Top Edge.</para>
    /// <para>Represents the following attribute in the schema: distT </para>
    /// </summary>
    [SchemaAttr(0, "distT")]
    public UInt32Value DistanceFromTop
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Bottom Edge.</para>
    /// <para>Represents the following attribute in the schema: distB </para>
    /// </summary>
    [SchemaAttr(0, "distB")]
    public UInt32Value DistanceFromBottom
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 16 == namespaceId && "effectExtent" == name)
    return new EffectExtent();
    

    return null;
}

        private static readonly string[] eleTagNames = { "effectExtent" };
    private static readonly byte[] eleNamespaceIds = { 16 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Wrapping Boundaries.</para>
    /// <para> Represents the following element tag in the schema: wp:effectExtent </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Inline : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10765;
    /// <inheritdoc/>
    public override string LocalName => "inline";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "distT"),
		AttributeTag.Create<UInt32Value>(0, "distB"),
		AttributeTag.Create<UInt32Value>(0, "distL"),
		AttributeTag.Create<UInt32Value>(0, "distR"),
		AttributeTag.Create<HexBinaryValue>(51, "anchorId"),
		AttributeTag.Create<HexBinaryValue>(51, "editId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Distance From Text on Top Edge.</para>
    /// <para>Represents the following attribute in the schema: distT </para>
    /// </summary>
    [SchemaAttr(0, "distT")]
    public UInt32Value DistanceFromTop
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Bottom Edge.</para>
    /// <para>Represents the following attribute in the schema: distB </para>
    /// </summary>
    [SchemaAttr(0, "distB")]
    public UInt32Value DistanceFromBottom
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: distL </para>
    /// </summary>
    [SchemaAttr(0, "distL")]
    public UInt32Value DistanceFromLeft
    {
        get { return (UInt32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: distR </para>
    /// </summary>
    [SchemaAttr(0, "distR")]
    public UInt32Value DistanceFromRight
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> anchorId.</para>
    /// <para>Represents the following attribute in the schema: wp14:anchorId </para>
    /// </summary>
///<remark> xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
///</remark>
    [SchemaAttr(51, "anchorId")]
    public HexBinaryValue AnchorId
    {
        get { return (HexBinaryValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> editId.</para>
    /// <para>Represents the following attribute in the schema: wp14:editId </para>
    /// </summary>
///<remark> xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
///</remark>
    [SchemaAttr(51, "editId")]
    public HexBinaryValue EditId
    {
        get { return (HexBinaryValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 16 == namespaceId && "extent" == name)
    return new Extent();
    
if( 16 == namespaceId && "effectExtent" == name)
    return new EffectExtent();
    
if( 16 == namespaceId && "docPr" == name)
    return new DocProperties();
    
if( 16 == namespaceId && "cNvGraphicFramePr" == name)
    return new NonVisualGraphicFrameDrawingProperties();
    
if( 10 == namespaceId && "graphic" == name)
    return new DocumentFormat.OpenXml.Drawing.Graphic();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extent","effectExtent","docPr","cNvGraphicFramePr","graphic" };
    private static readonly byte[] eleNamespaceIds = { 16,16,16,16,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Drawing Object Size.</para>
    /// <para> Represents the following element tag in the schema: wp:extent </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Anchor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10766;
    /// <inheritdoc/>
    public override string LocalName => "anchor";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "distT"),
		AttributeTag.Create<UInt32Value>(0, "distB"),
		AttributeTag.Create<UInt32Value>(0, "distL"),
		AttributeTag.Create<UInt32Value>(0, "distR"),
		AttributeTag.Create<BooleanValue>(0, "simplePos"),
		AttributeTag.Create<UInt32Value>(0, "relativeHeight"),
		AttributeTag.Create<BooleanValue>(0, "behindDoc"),
		AttributeTag.Create<BooleanValue>(0, "locked"),
		AttributeTag.Create<BooleanValue>(0, "layoutInCell"),
		AttributeTag.Create<BooleanValue>(0, "hidden"),
		AttributeTag.Create<BooleanValue>(0, "allowOverlap"),
		AttributeTag.Create<HexBinaryValue>(51, "editId"),
		AttributeTag.Create<HexBinaryValue>(51, "anchorId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Distance From Text on Top Edge.</para>
    /// <para>Represents the following attribute in the schema: distT </para>
    /// </summary>
    [SchemaAttr(0, "distT")]
    public UInt32Value DistanceFromTop
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Bottom Edge.</para>
    /// <para>Represents the following attribute in the schema: distB </para>
    /// </summary>
    [SchemaAttr(0, "distB")]
    public UInt32Value DistanceFromBottom
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: distL </para>
    /// </summary>
    [SchemaAttr(0, "distL")]
    public UInt32Value DistanceFromLeft
    {
        get { return (UInt32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Distance From Text on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: distR </para>
    /// </summary>
    [SchemaAttr(0, "distR")]
    public UInt32Value DistanceFromRight
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Page Positioning.</para>
    /// <para>Represents the following attribute in the schema: simplePos </para>
    /// </summary>
    [SchemaAttr(0, "simplePos")]
    public BooleanValue SimplePos
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Z-Ordering Position.</para>
    /// <para>Represents the following attribute in the schema: relativeHeight </para>
    /// </summary>
    [SchemaAttr(0, "relativeHeight")]
    public UInt32Value RelativeHeight
    {
        get { return (UInt32Value)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Display Behind Document Text.</para>
    /// <para>Represents the following attribute in the schema: behindDoc </para>
    /// </summary>
    [SchemaAttr(0, "behindDoc")]
    public BooleanValue BehindDoc
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Lock Anchor.</para>
    /// <para>Represents the following attribute in the schema: locked </para>
    /// </summary>
    [SchemaAttr(0, "locked")]
    public BooleanValue Locked
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Layout In Table Cell.</para>
    /// <para>Represents the following attribute in the schema: layoutInCell </para>
    /// </summary>
    [SchemaAttr(0, "layoutInCell")]
    public BooleanValue LayoutInCell
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Objects to Overlap.</para>
    /// <para>Represents the following attribute in the schema: allowOverlap </para>
    /// </summary>
    [SchemaAttr(0, "allowOverlap")]
    public BooleanValue AllowOverlap
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> editId.</para>
    /// <para>Represents the following attribute in the schema: wp14:editId </para>
    /// </summary>
///<remark> xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
///</remark>
    [SchemaAttr(51, "editId")]
    public HexBinaryValue EditId
    {
        get { return (HexBinaryValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> anchorId.</para>
    /// <para>Represents the following attribute in the schema: wp14:anchorId </para>
    /// </summary>
///<remark> xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
///</remark>
    [SchemaAttr(51, "anchorId")]
    public HexBinaryValue AnchorId
    {
        get { return (HexBinaryValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 16 == namespaceId && "simplePos" == name)
    return new SimplePosition();
    
if( 16 == namespaceId && "positionH" == name)
    return new HorizontalPosition();
    
if( 16 == namespaceId && "positionV" == name)
    return new VerticalPosition();
    
if( 16 == namespaceId && "extent" == name)
    return new Extent();
    
if( 16 == namespaceId && "effectExtent" == name)
    return new EffectExtent();
    
if( 16 == namespaceId && "wrapNone" == name)
    return new WrapNone();
    
if( 16 == namespaceId && "wrapSquare" == name)
    return new WrapSquare();
    
if( 16 == namespaceId && "wrapTight" == name)
    return new WrapTight();
    
if( 16 == namespaceId && "wrapThrough" == name)
    return new WrapThrough();
    
if( 16 == namespaceId && "wrapTopAndBottom" == name)
    return new WrapTopBottom();
    
if( 16 == namespaceId && "docPr" == name)
    return new DocProperties();
    
if( 16 == namespaceId && "cNvGraphicFramePr" == name)
    return new NonVisualGraphicFrameDrawingProperties();
    
if( 10 == namespaceId && "graphic" == name)
    return new DocumentFormat.OpenXml.Drawing.Graphic();
    
if( 51 == namespaceId && "sizeRelH" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth();
    
if( 51 == namespaceId && "sizeRelV" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight();
    

    return null;
}

        private static readonly string[] eleTagNames = { "simplePos","positionH","positionV","extent","effectExtent","wrapNone","wrapSquare","wrapTight","wrapThrough","wrapTopAndBottom","docPr","cNvGraphicFramePr","graphic","sizeRelH","sizeRelV" };
    private static readonly byte[] eleNamespaceIds = { 16,16,16,16,16,16,16,16,16,16,16,16,10,51,51 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Simple Positioning Coordinates.</para>
    /// <para> Represents the following element tag in the schema: wp:simplePos </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StartPoint : Point2DType
{
    internal const int ElementTypeIdConst = 10767;
    /// <inheritdoc/>
    public override string LocalName => "start";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LineTo : Point2DType
{
    internal const int ElementTypeIdConst = 10768;
    /// <inheritdoc/>
    public override string LocalName => "lineTo";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SimplePosition : Point2DType
{
    internal const int ElementTypeIdConst = 10771;
    /// <inheritdoc/>
    public override string LocalName => "simplePos";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class Point2DType : OpenXmlLeafElement
{
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
    /// Initializes a new instance of the Point2DType class.
    /// </summary>
    protected Point2DType(){}
    
    
    
}
/// <summary>
/// <para>Object Extents Including Effects.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:effectExtent.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EffectExtent : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10769;
    /// <inheritdoc/>
    public override string LocalName => "effectExtent";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int64Value>(0, "l"),
		AttributeTag.Create<Int64Value>(0, "t"),
		AttributeTag.Create<Int64Value>(0, "r"),
		AttributeTag.Create<Int64Value>(0, "b")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Additional Extent on Left Edge.</para>
    /// <para>Represents the following attribute in the schema: l </para>
    /// </summary>
    [SchemaAttr(0, "l")]
    public Int64Value LeftEdge
    {
        get { return (Int64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Additional Extent on Top Edge.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public Int64Value TopEdge
    {
        get { return (Int64Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Additional Extent on Right Edge.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public Int64Value RightEdge
    {
        get { return (Int64Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Additional Extent on Bottom Edge.</para>
    /// <para>Represents the following attribute in the schema: b </para>
    /// </summary>
    [SchemaAttr(0, "b")]
    public Int64Value BottomEdge
    {
        get { return (Int64Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WrapPolygon : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10770;
    /// <inheritdoc/>
    public override string LocalName => "wrapPolygon";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "edited")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Wrapping Points Modified.</para>
    /// <para>Represents the following attribute in the schema: edited </para>
    /// </summary>
    [SchemaAttr(0, "edited")]
    public BooleanValue Edited
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 16 == namespaceId && "start" == name)
    return new StartPoint();
    
if( 16 == namespaceId && "lineTo" == name)
    return new LineTo();
    

    return null;
}

        private static readonly string[] eleTagNames = { "start","lineTo" };
    private static readonly byte[] eleNamespaceIds = { 16,16 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Wrapping Polygon Start.</para>
    /// <para> Represents the following element tag in the schema: wp:start </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HorizontalPosition : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10772;
    /// <inheritdoc/>
    public override string LocalName => "positionH";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues>>(0, "relativeFrom")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Horizontal Position Relative Base.</para>
    /// <para>Represents the following attribute in the schema: relativeFrom </para>
    /// </summary>
    [SchemaAttr(0, "relativeFrom")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues> RelativeFrom
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 16 == namespaceId && "align" == name)
    return new HorizontalAlignment();
    
if( 16 == namespaceId && "posOffset" == name)
    return new PositionOffset();
    
if( 51 == namespaceId && "pctPosHOffset" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset();
    

    return null;
}

        private static readonly string[] eleTagNames = { "align","posOffset","pctPosHOffset" };
    private static readonly byte[] eleNamespaceIds = { 16,16,51 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Relative Horizontal Alignment.</para>
    /// <para> Represents the following element tag in the schema: wp:align </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VerticalPosition : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10773;
    /// <inheritdoc/>
    public override string LocalName => "positionV";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues>>(0, "relativeFrom")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Vertical Position Relative Base.</para>
    /// <para>Represents the following attribute in the schema: relativeFrom </para>
    /// </summary>
    [SchemaAttr(0, "relativeFrom")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues> RelativeFrom
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 16 == namespaceId && "align" == name)
    return new VerticalAlignment();
    
if( 16 == namespaceId && "posOffset" == name)
    return new PositionOffset();
    
if( 51 == namespaceId && "pctPosVOffset" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset();
    

    return null;
}

        private static readonly string[] eleTagNames = { "align","posOffset","pctPosVOffset" };
    private static readonly byte[] eleNamespaceIds = { 16,16,51 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Relative Vertical Alignment.</para>
    /// <para> Represents the following element tag in the schema: wp:align </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
    /// </remark>
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Extent : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10774;
    /// <inheritdoc/>
    public override string LocalName => "extent";
    
    internal override byte NamespaceId => 16;
    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DocProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10775;
    /// <inheritdoc/>
    public override string LocalName => "docPr";
    
    internal override byte NamespaceId => 16;
    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NonVisualGraphicFrameDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10776;
    /// <inheritdoc/>
    public override string LocalName => "cNvGraphicFramePr";
    
    internal override byte NamespaceId => 16;
    
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
/// <para>Relative Vertical Alignment.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp:align.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VerticalAlignment : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10777;
    /// <inheritdoc/>
    public override string LocalName => "align";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PositionOffset : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10778;
    /// <inheritdoc/>
    public override string LocalName => "posOffset";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HorizontalAlignment : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10779;
    /// <inheritdoc/>
    public override string LocalName => "align";
    
    internal override byte NamespaceId => 16;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
 
 
