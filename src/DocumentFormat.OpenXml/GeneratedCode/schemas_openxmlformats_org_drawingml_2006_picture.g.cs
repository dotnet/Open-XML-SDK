﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2010.Drawing.Pictures;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Drawing.Pictures
{
/// <summary>
/// <para>Picture.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is pic:pic.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualPictureProperties &lt;pic:nvPicPr></description></item>
///<item><description>BlipFill &lt;pic:blipFill></description></item>
///<item><description>ShapeProperties &lt;pic:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle &lt;pic14:style></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList &lt;pic14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualPictureProperties))]
    [ChildElementInfo(typeof(BlipFill))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(17, "pic")]
public partial class Picture : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10780;
    /// <inheritdoc/>
    public override string LocalName => "pic";
    internal override byte NamespaceId => 17;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
    
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
    
  
     
    
    
        private static readonly string[] eleTagNames = { "nvPicPr","blipFill","spPr","style","extLst" };
    private static readonly byte[] eleNamespaceIds = { 17,17,17,50,50 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Picture Properties.</para>
    /// <para> Represents the following element tag in the schema: pic:nvPicPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
    /// </remark>
    public NonVisualPictureProperties NonVisualPictureProperties
    {
        get => GetElement<NonVisualPictureProperties>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> Picture Fill.</para>
    /// <para> Represents the following element tag in the schema: pic:blipFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
    /// </remark>
    public BlipFill BlipFill
    {
        get => GetElement<BlipFill>(1);
        set => SetElement(1, value);
    }
    
    /// <summary>
    /// <para> Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: pic:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(2);
        set => SetElement(2, value);
    }
    
    /// <summary>
    /// <para> ShapeStyle.</para>
    /// <para> Represents the following element tag in the schema: pic14:style </para>
    /// </summary>
    /// <remark>
    /// xmlns:pic14 = http://schemas.microsoft.com/office/drawing/2010/picture
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle ShapeStyle
    {
        get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle>(3);
        set => SetElement(3, value);
    }
    
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: pic14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:pic14 = http://schemas.microsoft.com/office/drawing/2010/picture
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList>(4);
        set => SetElement(4, value);
    }
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Picture>(deep);

}
/// <summary>
/// <para>Non-Visual Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is pic:cNvPr.</para>
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
[SchemaAttr(17, "cNvPr")]
public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10781;
    /// <inheritdoc/>
    public override string LocalName => "cNvPr";
    internal override byte NamespaceId => 17;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id", 0)]
    public UInt32Value Id { get; set; }
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name", 1)]
    public StringValue Name { get; set; }
    /// <summary>
    /// <para> descr.</para>
    /// <para>Represents the following attribute in the schema: descr </para>
    /// </summary>
    [SchemaAttr(0, "descr", 2)]
    public StringValue Description { get; set; }
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden", 3)]
    public BooleanValue Hidden { get; set; }
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title", 4)]
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
/// <para>Non-Visual Picture Drawing Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is pic:cNvPicPr.</para>
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
[SchemaAttr(17, "cNvPicPr")]
public partial class NonVisualPictureDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10782;
    /// <inheritdoc/>
    public override string LocalName => "cNvPicPr";
    internal override byte NamespaceId => 17;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> preferRelativeResize.</para>
    /// <para>Represents the following attribute in the schema: preferRelativeResize </para>
    /// </summary>
    [SchemaAttr(0, "preferRelativeResize", 0)]
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
/// <para> When the object is serialized out as xml, its qualified name is pic:nvPicPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;pic:cNvPr></description></item>
///<item><description>NonVisualPictureDrawingProperties &lt;pic:cNvPicPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties))]
    [ChildElementInfo(typeof(NonVisualPictureDrawingProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(17, "nvPicPr")]
public partial class NonVisualPictureProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10783;
    /// <inheritdoc/>
    public override string LocalName => "nvPicPr";
    internal override byte NamespaceId => 17;
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
    
  
     
    
    
        private static readonly string[] eleTagNames = { "cNvPr","cNvPicPr" };
    private static readonly byte[] eleNamespaceIds = { 17,17 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: pic:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    
    /// <summary>
    /// <para> Non-Visual Picture Drawing Properties.</para>
    /// <para> Represents the following element tag in the schema: pic:cNvPicPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
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
/// <para> When the object is serialized out as xml, its qualified name is pic:blipFill.</para>
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
[SchemaAttr(17, "blipFill")]
public partial class BlipFill : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10784;
    /// <inheritdoc/>
    public override string LocalName => "blipFill";
    internal override byte NamespaceId => 17;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> DPI Setting.</para>
    /// <para>Represents the following attribute in the schema: dpi </para>
    /// </summary>
    [SchemaAttr(0, "dpi", 0)]
    public UInt32Value Dpi { get; set; }
    /// <summary>
    /// <para> Rotate With Shape.</para>
    /// <para>Represents the following attribute in the schema: rotWithShape </para>
    /// </summary>
    [SchemaAttr(0, "rotWithShape", 1)]
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
/// <para>Shape Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is pic:spPr.</para>
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
[SchemaAttr(17, "spPr")]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10785;
    /// <inheritdoc/>
    public override string LocalName => "spPr";
    internal override byte NamespaceId => 17;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;

    
    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode", 0)]
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
}
 
 
