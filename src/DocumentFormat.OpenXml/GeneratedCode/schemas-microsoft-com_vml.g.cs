// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Vml.Wordprocessing;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Presentation;

namespace DocumentFormat.OpenXml.Vml
{
/// <summary>
/// <para>Defines the Path Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:path.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Path : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12577;
    /// <inheritdoc/>
    public override string LocalName => "path";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "v"),
		AttributeTag.Create<StringValue>(0, "limo"),
		AttributeTag.Create<StringValue>(0, "textboxrect"),
		AttributeTag.Create<TrueFalseValue>(0, "fillok"),
		AttributeTag.Create<TrueFalseValue>(0, "strokeok"),
		AttributeTag.Create<TrueFalseValue>(0, "shadowok"),
		AttributeTag.Create<TrueFalseValue>(0, "arrowok"),
		AttributeTag.Create<TrueFalseValue>(0, "gradientshapeok"),
		AttributeTag.Create<TrueFalseValue>(0, "textpathok"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpenok"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues>>(27, "connecttype"),
		AttributeTag.Create<StringValue>(27, "connectlocs"),
		AttributeTag.Create<StringValue>(27, "connectangles"),
		AttributeTag.Create<TrueFalseValue>(27, "extrusionok")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Path Definition.</para>
    /// <para>Represents the following attribute in the schema: v </para>
    /// </summary>
    [SchemaAttr(0, "v")]
    public StringValue Value
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Limo Stretch Point.</para>
    /// <para>Represents the following attribute in the schema: limo </para>
    /// </summary>
    [SchemaAttr(0, "limo")]
    public StringValue Limo
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Box Bounding Box.</para>
    /// <para>Represents the following attribute in the schema: textboxrect </para>
    /// </summary>
    [SchemaAttr(0, "textboxrect")]
    public StringValue TextboxRectangle
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: fillok </para>
    /// </summary>
    [SchemaAttr(0, "fillok")]
    public TrueFalseValue AllowFill
    {
        get { return (TrueFalseValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: strokeok </para>
    /// </summary>
    [SchemaAttr(0, "strokeok")]
    public TrueFalseValue AllowStroke
    {
        get { return (TrueFalseValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Toggle.</para>
    /// <para>Represents the following attribute in the schema: shadowok </para>
    /// </summary>
    [SchemaAttr(0, "shadowok")]
    public TrueFalseValue AllowShading
    {
        get { return (TrueFalseValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Arrowhead Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: arrowok </para>
    /// </summary>
    [SchemaAttr(0, "arrowok")]
    public TrueFalseValue ShowArrowhead
    {
        get { return (TrueFalseValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Gradient Shape Toggle.</para>
    /// <para>Represents the following attribute in the schema: gradientshapeok </para>
    /// </summary>
    [SchemaAttr(0, "gradientshapeok")]
    public TrueFalseValue AllowGradientShape
    {
        get { return (TrueFalseValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Path Toggle.</para>
    /// <para>Represents the following attribute in the schema: textpathok </para>
    /// </summary>
    [SchemaAttr(0, "textpathok")]
    public TrueFalseValue AllowTextPath
    {
        get { return (TrueFalseValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Stroke From Path Flag.</para>
    /// <para>Represents the following attribute in the schema: insetpenok </para>
    /// </summary>
    [SchemaAttr(0, "insetpenok")]
    public TrueFalseValue AllowInsetPen
    {
        get { return (TrueFalseValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Connection Point Type.</para>
    /// <para>Represents the following attribute in the schema: o:connecttype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connecttype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues> ConnectionPointType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues>)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Connection Points.</para>
    /// <para>Represents the following attribute in the schema: o:connectlocs </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectlocs")]
    public StringValue ConnectionPoints
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Connection Point Connect Angles.</para>
    /// <para>Represents the following attribute in the schema: o:connectangles </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectangles")]
    public StringValue ConnectAngles
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:extrusionok </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "extrusionok")]
    public TrueFalseValue AllowExtrusion
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Path class.
    /// </summary>
    public Path():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Path>(deep);

}
/// <summary>
/// <para>Defines the Formulas Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:formulas.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;v:f></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Formula))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Formulas : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12578;
    /// <inheritdoc/>
    public override string LocalName => "formulas";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Formulas class.
    /// </summary>
    public Formulas():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Formulas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Formulas(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Formulas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Formulas(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Formulas class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Formulas(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "f" == name)
    return new Formula();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formulas>(deep);

}
/// <summary>
/// <para>Defines the ShapeHandles Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:handles.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeHandle &lt;v:h></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShapeHandle))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShapeHandles : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12579;
    /// <inheritdoc/>
    public override string LocalName => "handles";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ShapeHandles class.
    /// </summary>
    public ShapeHandles():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ShapeHandles class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeHandles(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeHandles class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeHandles(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeHandles class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeHandles(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "h" == name)
    return new ShapeHandle();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeHandles>(deep);

}
/// <summary>
/// <para>Defines the Fill Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:fill.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties &lt;o:fill></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Fill : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12580;
    /// <inheritdoc/>
    public override string LocalName => "fill";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues>>(0, "type"),
		AttributeTag.Create<TrueFalseValue>(0, "on"),
		AttributeTag.Create<StringValue>(0, "color"),
		AttributeTag.Create<StringValue>(0, "opacity"),
		AttributeTag.Create<StringValue>(0, "color2"),
		AttributeTag.Create<StringValue>(0, "src"),
		AttributeTag.Create<StringValue>(27, "href"),
		AttributeTag.Create<StringValue>(27, "althref"),
		AttributeTag.Create<StringValue>(0, "size"),
		AttributeTag.Create<StringValue>(0, "origin"),
		AttributeTag.Create<StringValue>(0, "position"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>>(0, "aspect"),
		AttributeTag.Create<StringValue>(0, "colors"),
		AttributeTag.Create<DecimalValue>(0, "angle"),
		AttributeTag.Create<TrueFalseValue>(0, "alignshape"),
		AttributeTag.Create<StringValue>(0, "focus"),
		AttributeTag.Create<StringValue>(0, "focussize"),
		AttributeTag.Create<StringValue>(0, "focusposition"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues>>(0, "method"),
		AttributeTag.Create<TrueFalseValue>(27, "detectmouseclick"),
		AttributeTag.Create<StringValue>(27, "title"),
		AttributeTag.Create<StringValue>(27, "opacity2"),
		AttributeTag.Create<TrueFalseValue>(0, "recolor"),
		AttributeTag.Create<TrueFalseValue>(0, "rotate"),
		AttributeTag.Create<StringValue>(19, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Primary Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
    public StringValue Color
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Primary Color Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
    public StringValue Opacity
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Secondary Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
    public StringValue Color2
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Image Source.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: o:href </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Image Reference Location.</para>
    /// <para>Represents the following attribute in the schema: o:althref </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "althref")]
    public StringValue AlternateImageReference
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Image Size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public StringValue Size
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Image Origin.</para>
    /// <para>Represents the following attribute in the schema: origin </para>
    /// </summary>
    [SchemaAttr(0, "origin")]
    public StringValue Origin
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Image Position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    public StringValue Position
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Aspect Ratio.</para>
    /// <para>Represents the following attribute in the schema: aspect </para>
    /// </summary>
    [SchemaAttr(0, "aspect")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> Aspect
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Intermediate Colors.</para>
    /// <para>Represents the following attribute in the schema: colors </para>
    /// </summary>
    [SchemaAttr(0, "colors")]
    public StringValue Colors
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Gradient Angle.</para>
    /// <para>Represents the following attribute in the schema: angle </para>
    /// </summary>
    [SchemaAttr(0, "angle")]
    public DecimalValue Angle
    {
        get { return (DecimalValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Align Image With Shape.</para>
    /// <para>Represents the following attribute in the schema: alignshape </para>
    /// </summary>
    [SchemaAttr(0, "alignshape")]
    public TrueFalseValue AlignShape
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Gradient Center.</para>
    /// <para>Represents the following attribute in the schema: focus </para>
    /// </summary>
    [SchemaAttr(0, "focus")]
    public StringValue Focus
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Radial Gradient Size.</para>
    /// <para>Represents the following attribute in the schema: focussize </para>
    /// </summary>
    [SchemaAttr(0, "focussize")]
    public StringValue FocusSize
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Radial Gradient Center.</para>
    /// <para>Represents the following attribute in the schema: focusposition </para>
    /// </summary>
    [SchemaAttr(0, "focusposition")]
    public StringValue FocusPosition
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Gradient Fill Method.</para>
    /// <para>Represents the following attribute in the schema: method </para>
    /// </summary>
    [SchemaAttr(0, "method")]
    public EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues> Method
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues>)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Detect Mouse Click.</para>
    /// <para>Represents the following attribute in the schema: o:detectmouseclick </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "detectmouseclick")]
    public TrueFalseValue DetectMouseClick
    {
        get { return (TrueFalseValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Title.</para>
    /// <para>Represents the following attribute in the schema: o:title </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Secondary Color Opacity.</para>
    /// <para>Represents the following attribute in the schema: o:opacity2 </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "opacity2")]
    public StringValue Opacity2
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Recolor Fill as Picture.</para>
    /// <para>Represents the following attribute in the schema: recolor </para>
    /// </summary>
    [SchemaAttr(0, "recolor")]
    public TrueFalseValue Recolor
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Rotate Fill with Shape.</para>
    /// <para>Represents the following attribute in the schema: rotate </para>
    /// </summary>
    [SchemaAttr(0, "rotate")]
    public TrueFalseValue Rotate
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Relationship to Part.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Fill class.
    /// </summary>
    public Fill():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Fill class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Fill(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Fill class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Fill(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Fill class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Fill(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "fill" == name)
    return new DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "fill" };
    private static readonly byte[] eleNamespaceIds = { 27 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> FillExtendedProperties.</para>
    /// <para> Represents the following element tag in the schema: o:fill </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties FillExtendedProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Fill>(deep);

}
/// <summary>
/// <para>Defines the Stroke Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:stroke.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Vml.Office.LeftStroke &lt;o:left></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.TopStroke &lt;o:top></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.RightStroke &lt;o:right></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.BottomStroke &lt;o:bottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ColumnStroke &lt;o:column></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.LeftStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.TopStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.RightStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.BottomStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ColumnStroke))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Stroke : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12581;
    /// <inheritdoc/>
    public override string LocalName => "stroke";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<TrueFalseValue>(0, "on"),
		AttributeTag.Create<StringValue>(0, "weight"),
		AttributeTag.Create<StringValue>(0, "color"),
		AttributeTag.Create<StringValue>(0, "opacity"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues>>(0, "linestyle"),
		AttributeTag.Create<StringValue>(0, "miterlimit"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues>>(0, "joinstyle"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues>>(0, "endcap"),
		AttributeTag.Create<StringValue>(0, "dashstyle"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues>>(0, "filltype"),
		AttributeTag.Create<StringValue>(0, "src"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>>(0, "imageaspect"),
		AttributeTag.Create<StringValue>(0, "imagesize"),
		AttributeTag.Create<TrueFalseValue>(0, "imagealignshape"),
		AttributeTag.Create<StringValue>(0, "color2"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>>(0, "startarrow"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>>(0, "startarrowwidth"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>>(0, "startarrowlength"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>>(0, "endarrow"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>>(0, "endarrowwidth"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>>(0, "endarrowlength"),
		AttributeTag.Create<StringValue>(27, "href"),
		AttributeTag.Create<StringValue>(27, "althref"),
		AttributeTag.Create<StringValue>(27, "title"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<StringValue>(19, "id"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: weight </para>
    /// </summary>
    [SchemaAttr(0, "weight")]
    public StringValue Weight
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
    public StringValue Color
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
    public StringValue Opacity
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Line Style.</para>
    /// <para>Represents the following attribute in the schema: linestyle </para>
    /// </summary>
    [SchemaAttr(0, "linestyle")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues> LineStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Miter Joint Limit.</para>
    /// <para>Represents the following attribute in the schema: miterlimit </para>
    /// </summary>
    [SchemaAttr(0, "miterlimit")]
    public StringValue Miterlimit
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Line End Join Style.</para>
    /// <para>Represents the following attribute in the schema: joinstyle </para>
    /// </summary>
    [SchemaAttr(0, "joinstyle")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues> JoinStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues>)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Line End Cap.</para>
    /// <para>Represents the following attribute in the schema: endcap </para>
    /// </summary>
    [SchemaAttr(0, "endcap")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues> EndCap
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues>)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Dash Pattern.</para>
    /// <para>Represents the following attribute in the schema: dashstyle </para>
    /// </summary>
    [SchemaAttr(0, "dashstyle")]
    public StringValue DashStyle
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Style.</para>
    /// <para>Represents the following attribute in the schema: filltype </para>
    /// </summary>
    [SchemaAttr(0, "filltype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues> FillType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues>)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Location.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Aspect Ratio.</para>
    /// <para>Represents the following attribute in the schema: imageaspect </para>
    /// </summary>
    [SchemaAttr(0, "imageaspect")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> ImageAspect
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Size.</para>
    /// <para>Represents the following attribute in the schema: imagesize </para>
    /// </summary>
    [SchemaAttr(0, "imagesize")]
    public StringValue ImageSize
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Stoke Image Alignment.</para>
    /// <para>Represents the following attribute in the schema: imagealignshape </para>
    /// </summary>
    [SchemaAttr(0, "imagealignshape")]
    public TrueFalseValue ImageAlignShape
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Alternate Pattern Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
    public StringValue Color2
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Line Start Arrowhead.</para>
    /// <para>Represents the following attribute in the schema: startarrow </para>
    /// </summary>
    [SchemaAttr(0, "startarrow")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> StartArrow
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Line Start Arrowhead Width.</para>
    /// <para>Represents the following attribute in the schema: startarrowwidth </para>
    /// </summary>
    [SchemaAttr(0, "startarrowwidth")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> StartArrowWidth
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Line Start Arrowhead Length.</para>
    /// <para>Represents the following attribute in the schema: startarrowlength </para>
    /// </summary>
    [SchemaAttr(0, "startarrowlength")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> StartArrowLength
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Line End Arrowhead.</para>
    /// <para>Represents the following attribute in the schema: endarrow </para>
    /// </summary>
    [SchemaAttr(0, "endarrow")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> EndArrow
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Line End Arrowhead Width.</para>
    /// <para>Represents the following attribute in the schema: endarrowwidth </para>
    /// </summary>
    [SchemaAttr(0, "endarrowwidth")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> EndArrowWidth
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Line End Arrowhead Length.</para>
    /// <para>Represents the following attribute in the schema: endarrowlength </para>
    /// </summary>
    [SchemaAttr(0, "endarrowlength")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> EndArrowLength
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Original Image Reference.</para>
    /// <para>Represents the following attribute in the schema: o:href </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Image Reference.</para>
    /// <para>Represents the following attribute in the schema: o:althref </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "althref")]
    public StringValue AlternateImageReference
    {
        get { return (StringValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Title.</para>
    /// <para>Represents the following attribute in the schema: o:title </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Relationship.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue Insetpen
    {
        get { return (TrueFalseValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Stroke class.
    /// </summary>
    public Stroke():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Stroke class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Stroke(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Stroke class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Stroke(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Stroke class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Stroke(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "left" == name)
    return new DocumentFormat.OpenXml.Vml.Office.LeftStroke();
    
if( 27 == namespaceId && "top" == name)
    return new DocumentFormat.OpenXml.Vml.Office.TopStroke();
    
if( 27 == namespaceId && "right" == name)
    return new DocumentFormat.OpenXml.Vml.Office.RightStroke();
    
if( 27 == namespaceId && "bottom" == name)
    return new DocumentFormat.OpenXml.Vml.Office.BottomStroke();
    
if( 27 == namespaceId && "column" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ColumnStroke();
    

    return null;
}

        private static readonly string[] eleTagNames = { "left","top","right","bottom","column" };
    private static readonly byte[] eleNamespaceIds = { 27,27,27,27,27 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> LeftStroke.</para>
    /// <para> Represents the following element tag in the schema: o:left </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.LeftStroke LeftStroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.LeftStroke>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> TopStroke.</para>
    /// <para> Represents the following element tag in the schema: o:top </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.TopStroke TopStroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.TopStroke>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> RightStroke.</para>
    /// <para> Represents the following element tag in the schema: o:right </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.RightStroke RightStroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.RightStroke>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> BottomStroke.</para>
    /// <para> Represents the following element tag in the schema: o:bottom </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.BottomStroke BottomStroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.BottomStroke>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> ColumnStroke.</para>
    /// <para> Represents the following element tag in the schema: o:column </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.ColumnStroke ColumnStroke
    {
        get => GetElement<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>(4);
        set => SetElement(4, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Stroke>(deep);

}
/// <summary>
/// <para>Defines the Shadow Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:shadow.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Shadow : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12582;
    /// <inheritdoc/>
    public override string LocalName => "shadow";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<TrueFalseValue>(0, "on"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues>>(0, "type"),
		AttributeTag.Create<TrueFalseValue>(0, "obscured"),
		AttributeTag.Create<StringValue>(0, "color"),
		AttributeTag.Create<StringValue>(0, "opacity"),
		AttributeTag.Create<StringValue>(0, "offset"),
		AttributeTag.Create<StringValue>(0, "color2"),
		AttributeTag.Create<StringValue>(0, "offset2"),
		AttributeTag.Create<StringValue>(0, "origin"),
		AttributeTag.Create<StringValue>(0, "matrix")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Transparency.</para>
    /// <para>Represents the following attribute in the schema: obscured </para>
    /// </summary>
    [SchemaAttr(0, "obscured")]
    public TrueFalseValue Obscured
    {
        get { return (TrueFalseValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Primary Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
    public StringValue Color
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
    public StringValue Opacity
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Primary Offset.</para>
    /// <para>Represents the following attribute in the schema: offset </para>
    /// </summary>
    [SchemaAttr(0, "offset")]
    public StringValue Offset
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Secondary Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
    public StringValue Color2
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Secondary Offset.</para>
    /// <para>Represents the following attribute in the schema: offset2 </para>
    /// </summary>
    [SchemaAttr(0, "offset2")]
    public StringValue Offset2
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Origin.</para>
    /// <para>Represents the following attribute in the schema: origin </para>
    /// </summary>
    [SchemaAttr(0, "origin")]
    public StringValue Origin
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Shadow Perspective Matrix.</para>
    /// <para>Represents the following attribute in the schema: matrix </para>
    /// </summary>
    [SchemaAttr(0, "matrix")]
    public StringValue Matrix
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Shadow class.
    /// </summary>
    public Shadow():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shadow>(deep);

}
/// <summary>
/// <para>Defines the TextBox Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:textbox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Wordprocessing.TextBoxContent &lt;w:txbxContent></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.TextBoxContent))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TextBox : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12583;
    /// <inheritdoc/>
    public override string LocalName => "textbox";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "inset"),
		AttributeTag.Create<TrueFalseValue>(27, "singleclick")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Box Inset.</para>
    /// <para>Represents the following attribute in the schema: inset </para>
    /// </summary>
    [SchemaAttr(0, "inset")]
    public StringValue Inset
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Box Single-Click Selection Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:singleclick </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "singleclick")]
    public TrueFalseValue SingleClick
    {
        get { return (TrueFalseValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TextBox class.
    /// </summary>
    public TextBox():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TextBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextBox(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextBox(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextBox class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextBox(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 23 == namespaceId && "txbxContent" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.TextBoxContent();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBox>(deep);

}
/// <summary>
/// <para>Defines the TextPath Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:textpath.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TextPath : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12584;
    /// <inheritdoc/>
    public override string LocalName => "textpath";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<TrueFalseValue>(0, "on"),
		AttributeTag.Create<TrueFalseValue>(0, "fitshape"),
		AttributeTag.Create<TrueFalseValue>(0, "fitpath"),
		AttributeTag.Create<TrueFalseValue>(0, "trim"),
		AttributeTag.Create<TrueFalseValue>(0, "xscale"),
		AttributeTag.Create<StringValue>(0, "string")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Path Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fit Toggle.</para>
    /// <para>Represents the following attribute in the schema: fitshape </para>
    /// </summary>
    [SchemaAttr(0, "fitshape")]
    public TrueFalseValue FitShape
    {
        get { return (TrueFalseValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Path Fit Toggle.</para>
    /// <para>Represents the following attribute in the schema: fitpath </para>
    /// </summary>
    [SchemaAttr(0, "fitpath")]
    public TrueFalseValue FitPath
    {
        get { return (TrueFalseValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Path Trim Toggle.</para>
    /// <para>Represents the following attribute in the schema: trim </para>
    /// </summary>
    [SchemaAttr(0, "trim")]
    public TrueFalseValue Trim
    {
        get { return (TrueFalseValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Text X-Scaling.</para>
    /// <para>Represents the following attribute in the schema: xscale </para>
    /// </summary>
    [SchemaAttr(0, "xscale")]
    public TrueFalseValue XScale
    {
        get { return (TrueFalseValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Path Text.</para>
    /// <para>Represents the following attribute in the schema: string </para>
    /// </summary>
    [SchemaAttr(0, "string")]
    public StringValue String
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TextPath class.
    /// </summary>
    public TextPath():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextPath>(deep);

}
/// <summary>
/// <para>Defines the ImageData Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:imagedata.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ImageData : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12585;
    /// <inheritdoc/>
    public override string LocalName => "imagedata";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "chromakey"),
		AttributeTag.Create<StringValue>(0, "cropleft"),
		AttributeTag.Create<StringValue>(0, "croptop"),
		AttributeTag.Create<StringValue>(0, "cropright"),
		AttributeTag.Create<StringValue>(0, "cropbottom"),
		AttributeTag.Create<StringValue>(0, "gain"),
		AttributeTag.Create<StringValue>(0, "blacklevel"),
		AttributeTag.Create<StringValue>(0, "gamma"),
		AttributeTag.Create<TrueFalseValue>(0, "grayscale"),
		AttributeTag.Create<TrueFalseValue>(0, "bilevel"),
		AttributeTag.Create<StringValue>(0, "embosscolor"),
		AttributeTag.Create<StringValue>(0, "recolortarget"),
		AttributeTag.Create<StringValue>(27, "title"),
		AttributeTag.Create<TrueFalseValue>(27, "detectmouseclick"),
		AttributeTag.Create<StringValue>(27, "relid"),
		AttributeTag.Create<StringValue>(19, "id"),
		AttributeTag.Create<StringValue>(19, "pict"),
		AttributeTag.Create<StringValue>(19, "href")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Transparency Color.</para>
    /// <para>Represents the following attribute in the schema: chromakey </para>
    /// </summary>
    [SchemaAttr(0, "chromakey")]
    public StringValue ChromAKey
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Left Crop.</para>
    /// <para>Represents the following attribute in the schema: cropleft </para>
    /// </summary>
    [SchemaAttr(0, "cropleft")]
    public StringValue CropLeft
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Top Crop.</para>
    /// <para>Represents the following attribute in the schema: croptop </para>
    /// </summary>
    [SchemaAttr(0, "croptop")]
    public StringValue CropTop
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Right Crop.</para>
    /// <para>Represents the following attribute in the schema: cropright </para>
    /// </summary>
    [SchemaAttr(0, "cropright")]
    public StringValue CropRight
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Bottom Crop.</para>
    /// <para>Represents the following attribute in the schema: cropbottom </para>
    /// </summary>
    [SchemaAttr(0, "cropbottom")]
    public StringValue CropBottom
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Intensity.</para>
    /// <para>Represents the following attribute in the schema: gain </para>
    /// </summary>
    [SchemaAttr(0, "gain")]
    public StringValue Gain
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Brightness.</para>
    /// <para>Represents the following attribute in the schema: blacklevel </para>
    /// </summary>
    [SchemaAttr(0, "blacklevel")]
    public StringValue BlackLevel
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Gamma Correction.</para>
    /// <para>Represents the following attribute in the schema: gamma </para>
    /// </summary>
    [SchemaAttr(0, "gamma")]
    public StringValue Gamma
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Grayscale Toggle.</para>
    /// <para>Represents the following attribute in the schema: grayscale </para>
    /// </summary>
    [SchemaAttr(0, "grayscale")]
    public TrueFalseValue Grayscale
    {
        get { return (TrueFalseValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Bilevel Toggle.</para>
    /// <para>Represents the following attribute in the schema: bilevel </para>
    /// </summary>
    [SchemaAttr(0, "bilevel")]
    public TrueFalseValue BiLevel
    {
        get { return (TrueFalseValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Embossed Color.</para>
    /// <para>Represents the following attribute in the schema: embosscolor </para>
    /// </summary>
    [SchemaAttr(0, "embosscolor")]
    public StringValue EmbossColor
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Black Recoloring Color.</para>
    /// <para>Represents the following attribute in the schema: recolortarget </para>
    /// </summary>
    [SchemaAttr(0, "recolortarget")]
    public StringValue RecolorTarget
    {
        get { return (StringValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Data Title.</para>
    /// <para>Represents the following attribute in the schema: o:title </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Detect Mouse Click.</para>
    /// <para>Represents the following attribute in the schema: o:detectmouseclick </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "detectmouseclick")]
    public TrueFalseValue DetectMouseClick
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Relationship to Part.</para>
    /// <para>Represents the following attribute in the schema: o:relid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "relid")]
    public StringValue RelId
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Explicit Relationship to Image Data.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Explicit Relationship to Alternate Image Data.</para>
    /// <para>Represents the following attribute in the schema: r:pict </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "pict")]
    public StringValue Picture
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Explicit Relationship to Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: r:href </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "href")]
    public StringValue RelHref
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ImageData class.
    /// </summary>
    public ImageData():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageData>(deep);

}
/// <summary>
/// <para>Shape Definition.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:shape.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Ink &lt;o:ink></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag &lt;pvml:iscomment></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Ink))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Shape : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12586;
    /// <inheritdoc/>
    public override string LocalName => "shape";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "class"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "coordorigin"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<StringValue>(27, "bordertopcolor"),
		AttributeTag.Create<StringValue>(27, "borderleftcolor"),
		AttributeTag.Create<StringValue>(27, "borderbottomcolor"),
		AttributeTag.Create<StringValue>(27, "borderrightcolor"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<TrueFalseValue>(0, "filled"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<TrueFalseValue>(0, "stroked"),
		AttributeTag.Create<StringValue>(0, "strokecolor"),
		AttributeTag.Create<StringValue>(0, "strokeweight"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen"),
		AttributeTag.Create<Int32Value>(27, "spt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>(27, "connectortype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<TrueFalseValue>(27, "oleicon"),
		AttributeTag.Create<TrueFalseBlankValue>(27, "ole"),
		AttributeTag.Create<TrueFalseValue>(27, "preferrelative"),
		AttributeTag.Create<TrueFalseValue>(27, "cliptowrap"),
		AttributeTag.Create<TrueFalseValue>(27, "clip"),
		AttributeTag.Create<StringValue>(0, "type"),
		AttributeTag.Create<StringValue>(0, "adj"),
		AttributeTag.Create<StringValue>(0, "path"),
		AttributeTag.Create<Base64BinaryValue>(27, "gfxdata"),
		AttributeTag.Create<StringValue>(0, "equationxml")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
        get { return (Int32Value)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
        get { return (TrueFalseValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
        get { return (TrueFalseBlankValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
        get { return (TrueFalseValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
        get { return (TrueFalseValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
        get { return (TrueFalseValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Type Reference.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[51].Value; }
        set { Attributes[51].Value = value; }
    }
    
    /// <summary>
    /// <para> Adjustment Parameters.</para>
    /// <para>Represents the following attribute in the schema: adj </para>
    /// </summary>
    [SchemaAttr(0, "adj")]
    public StringValue Adjustment
    {
        get { return (StringValue)Attributes[52].Value; }
        set { Attributes[52].Value = value; }
    }
    
    /// <summary>
    /// <para> Edge Path.</para>
    /// <para>Represents the following attribute in the schema: path </para>
    /// </summary>
    [SchemaAttr(0, "path")]
    public StringValue EdgePath
    {
        get { return (StringValue)Attributes[53].Value; }
        set { Attributes[53].Value = value; }
    }
    
    /// <summary>
    /// <para> Encoded Package.</para>
    /// <para>Represents the following attribute in the schema: o:gfxdata </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "gfxdata")]
    public Base64BinaryValue EncodedPackage
    {
        get { return (Base64BinaryValue)Attributes[54].Value; }
        set { Attributes[54].Value = value; }
    }
    
    /// <summary>
    /// <para> Storage for Alternate Math Content.</para>
    /// <para>Represents the following attribute in the schema: equationxml </para>
    /// </summary>
    [SchemaAttr(0, "equationxml")]
    public StringValue EquationXml
    {
        get { return (StringValue)Attributes[55].Value; }
        set { Attributes[55].Value = value; }
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
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    
if( 27 == namespaceId && "ink" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Ink();
    
if( 30 == namespaceId && "iscomment" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);

}
/// <summary>
/// <para>Shape Template.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:shapetype.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Complex &lt;o:complex></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Complex))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Shapetype : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12587;
    /// <inheritdoc/>
    public override string LocalName => "shapetype";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "class"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "coordorigin"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<StringValue>(27, "bordertopcolor"),
		AttributeTag.Create<StringValue>(27, "borderleftcolor"),
		AttributeTag.Create<StringValue>(27, "borderbottomcolor"),
		AttributeTag.Create<StringValue>(27, "borderrightcolor"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<TrueFalseValue>(0, "filled"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<TrueFalseValue>(0, "stroked"),
		AttributeTag.Create<StringValue>(0, "strokecolor"),
		AttributeTag.Create<StringValue>(0, "strokeweight"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen"),
		AttributeTag.Create<Int32Value>(27, "spt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>(27, "connectortype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<TrueFalseValue>(27, "oleicon"),
		AttributeTag.Create<TrueFalseBlankValue>(27, "ole"),
		AttributeTag.Create<TrueFalseValue>(27, "preferrelative"),
		AttributeTag.Create<TrueFalseValue>(27, "cliptowrap"),
		AttributeTag.Create<TrueFalseValue>(27, "clip"),
		AttributeTag.Create<StringValue>(0, "adj"),
		AttributeTag.Create<StringValue>(0, "path"),
		AttributeTag.Create<StringValue>(27, "master")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
        get { return (Int32Value)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
        get { return (TrueFalseValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
        get { return (TrueFalseBlankValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
        get { return (TrueFalseValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
        get { return (TrueFalseValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
        get { return (TrueFalseValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    
    /// <summary>
    /// <para> Adjustment Parameters.</para>
    /// <para>Represents the following attribute in the schema: adj </para>
    /// </summary>
    [SchemaAttr(0, "adj")]
    public StringValue Adjustment
    {
        get { return (StringValue)Attributes[51].Value; }
        set { Attributes[51].Value = value; }
    }
    
    /// <summary>
    /// <para> Edge Path.</para>
    /// <para>Represents the following attribute in the schema: path </para>
    /// </summary>
    [SchemaAttr(0, "path")]
    public StringValue EdgePath
    {
        get { return (StringValue)Attributes[52].Value; }
        set { Attributes[52].Value = value; }
    }
    
    /// <summary>
    /// <para> Master Element Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:master </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "master")]
    public StringValue Master
    {
        get { return (StringValue)Attributes[53].Value; }
        set { Attributes[53].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Shapetype class.
    /// </summary>
    public Shapetype():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Shapetype class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shapetype(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Shapetype class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shapetype(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Shapetype class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Shapetype(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    
if( 27 == namespaceId && "complex" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Complex();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shapetype>(deep);

}
/// <summary>
/// <para>Shape Group.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:group.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Group &lt;v:group></description></item>
///<item><description>Shape &lt;v:shape></description></item>
///<item><description>Shapetype &lt;v:shapetype></description></item>
///<item><description>Arc &lt;v:arc></description></item>
///<item><description>Curve &lt;v:curve></description></item>
///<item><description>ImageFile &lt;v:image></description></item>
///<item><description>Line &lt;v:line></description></item>
///<item><description>Oval &lt;v:oval></description></item>
///<item><description>PolyLine &lt;v:polyline></description></item>
///<item><description>Rectangle &lt;v:rect></description></item>
///<item><description>RoundRectangle &lt;v:roundrect></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Diagram &lt;o:diagram></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Group))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(Shapetype))]
    [ChildElementInfo(typeof(Arc))]
    [ChildElementInfo(typeof(Curve))]
    [ChildElementInfo(typeof(ImageFile))]
    [ChildElementInfo(typeof(Line))]
    [ChildElementInfo(typeof(Oval))]
    [ChildElementInfo(typeof(PolyLine))]
    [ChildElementInfo(typeof(Rectangle))]
    [ChildElementInfo(typeof(RoundRectangle))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Diagram))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Group : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12588;
    /// <inheritdoc/>
    public override string LocalName => "group";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "class"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "coordorigin"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues>>(0, "editas"),
		AttributeTag.Create<StringValue>(27, "tableproperties"),
		AttributeTag.Create<StringValue>(27, "tablelimits")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> spid.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> oned.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> regroupid.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> doubleclicknotify.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> button.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> userhidden.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> hr.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> hrstd.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> hrnoshade.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> hrpct.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> hralign.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> allowincell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> allowoverlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> userdrawn.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> dgmlayout.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> dgmnodekind.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> dgmlayoutmru.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> insetmode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Group Diagram Type.</para>
    /// <para>Represents the following attribute in the schema: editas </para>
    /// </summary>
    [SchemaAttr(0, "editas")]
    public EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues> EditAs
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues>)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Table Properties.</para>
    /// <para>Represents the following attribute in the schema: o:tableproperties </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "tableproperties")]
    public StringValue TableProperties
    {
        get { return (StringValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Table Row Height Limits.</para>
    /// <para>Represents the following attribute in the schema: o:tablelimits </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "tablelimits")]
    public StringValue TableLimits
    {
        get { return (StringValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Group class.
    /// </summary>
    public Group():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Group class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Group(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Group class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Group(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Group class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Group(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "group" == name)
    return new Group();
    
if( 26 == namespaceId && "shape" == name)
    return new Shape();
    
if( 26 == namespaceId && "shapetype" == name)
    return new Shapetype();
    
if( 26 == namespaceId && "arc" == name)
    return new Arc();
    
if( 26 == namespaceId && "curve" == name)
    return new Curve();
    
if( 26 == namespaceId && "image" == name)
    return new ImageFile();
    
if( 26 == namespaceId && "line" == name)
    return new Line();
    
if( 26 == namespaceId && "oval" == name)
    return new Oval();
    
if( 26 == namespaceId && "polyline" == name)
    return new PolyLine();
    
if( 26 == namespaceId && "rect" == name)
    return new Rectangle();
    
if( 26 == namespaceId && "roundrect" == name)
    return new RoundRectangle();
    
if( 27 == namespaceId && "diagram" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Diagram();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);

}
/// <summary>
/// <para>Document Background.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:background.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Fill &lt;v:fill></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Fill))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Background : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12589;
    /// <inheritdoc/>
    public override string LocalName => "background";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<TrueFalseValue>(0, "fill"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues>>(27, "targetscreensize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: fill </para>
    /// </summary>
    [SchemaAttr(0, "fill")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue Fillcolor
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Target Screen Size.</para>
    /// <para>Represents the following attribute in the schema: o:targetscreensize </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "targetscreensize")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues> TargetScreenSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues>)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Background class.
    /// </summary>
    public Background():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Background class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Background(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Background class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Background(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Background class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Background(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "fill" == name)
    return new Fill();
    

    return null;
}

        private static readonly string[] eleTagNames = { "fill" };
    private static readonly byte[] eleNamespaceIds = { 26 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Fill.</para>
    /// <para> Represents the following element tag in the schema: v:fill </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public Fill Fill
    {
        get => GetElement<Fill>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Background>(deep);

}
/// <summary>
/// <para>Arc Segment.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:arc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Arc : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12590;
    /// <inheritdoc/>
    public override string LocalName => "arc";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<StringValue>(27, "bordertopcolor"),
		AttributeTag.Create<StringValue>(27, "borderleftcolor"),
		AttributeTag.Create<StringValue>(27, "borderbottomcolor"),
		AttributeTag.Create<StringValue>(27, "borderrightcolor"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<TrueFalseValue>(0, "filled"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<TrueFalseValue>(0, "stroked"),
		AttributeTag.Create<StringValue>(0, "strokecolor"),
		AttributeTag.Create<StringValue>(0, "strokeweight"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen"),
		AttributeTag.Create<Int32Value>(27, "spt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>(27, "connectortype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<TrueFalseValue>(27, "oleicon"),
		AttributeTag.Create<TrueFalseBlankValue>(27, "ole"),
		AttributeTag.Create<TrueFalseValue>(27, "preferrelative"),
		AttributeTag.Create<TrueFalseValue>(27, "cliptowrap"),
		AttributeTag.Create<TrueFalseValue>(27, "clip"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "coordorigin"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<DecimalValue>(0, "startangle"),
		AttributeTag.Create<DecimalValue>(0, "endangle")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
        get { return (StringValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
        get { return (StringValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
        get { return (StringValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
        get { return (Int32Value)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
        get { return (TrueFalseValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
        get { return (TrueFalseBlankValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
        get { return (TrueFalseValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
        get { return (TrueFalseValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
        get { return (TrueFalseValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue Wrapcoords
    {
        get { return (StringValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> Starting Angle.</para>
    /// <para>Represents the following attribute in the schema: startangle </para>
    /// </summary>
    [SchemaAttr(0, "startangle")]
    public DecimalValue StartAngle
    {
        get { return (DecimalValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    
    /// <summary>
    /// <para> Ending Angle.</para>
    /// <para>Represents the following attribute in the schema: endangle </para>
    /// </summary>
    [SchemaAttr(0, "endangle")]
    public DecimalValue EndAngle
    {
        get { return (DecimalValue)Attributes[51].Value; }
        set { Attributes[51].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Arc class.
    /// </summary>
    public Arc():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Arc class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Arc(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Arc class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Arc(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Arc class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Arc(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Arc>(deep);

}
/// <summary>
/// <para>Bezier Curve.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:curve.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Curve : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12591;
    /// <inheritdoc/>
    public override string LocalName => "curve";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "class"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "coordorigin"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<StringValue>(27, "bordertopcolor"),
		AttributeTag.Create<StringValue>(27, "borderleftcolor"),
		AttributeTag.Create<StringValue>(27, "borderbottomcolor"),
		AttributeTag.Create<StringValue>(27, "borderrightcolor"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<TrueFalseValue>(0, "filled"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<TrueFalseValue>(0, "stroked"),
		AttributeTag.Create<StringValue>(0, "strokecolor"),
		AttributeTag.Create<StringValue>(0, "strokeweight"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen"),
		AttributeTag.Create<Int32Value>(27, "spt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>(27, "connectortype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<TrueFalseValue>(27, "oleicon"),
		AttributeTag.Create<TrueFalseBlankValue>(27, "ole"),
		AttributeTag.Create<TrueFalseValue>(27, "preferrelative"),
		AttributeTag.Create<TrueFalseValue>(27, "cliptowrap"),
		AttributeTag.Create<TrueFalseValue>(27, "clip"),
		AttributeTag.Create<StringValue>(0, "from"),
		AttributeTag.Create<StringValue>(0, "control1"),
		AttributeTag.Create<StringValue>(0, "control2"),
		AttributeTag.Create<StringValue>(0, "to")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
        get { return (Int32Value)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
        get { return (TrueFalseValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
        get { return (TrueFalseBlankValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
        get { return (TrueFalseValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
        get { return (TrueFalseValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
        get { return (TrueFalseValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    
    /// <summary>
    /// <para> Curve Starting Point.</para>
    /// <para>Represents the following attribute in the schema: from </para>
    /// </summary>
    [SchemaAttr(0, "from")]
    public StringValue From
    {
        get { return (StringValue)Attributes[51].Value; }
        set { Attributes[51].Value = value; }
    }
    
    /// <summary>
    /// <para> First Curve Control Point.</para>
    /// <para>Represents the following attribute in the schema: control1 </para>
    /// </summary>
    [SchemaAttr(0, "control1")]
    public StringValue Control1
    {
        get { return (StringValue)Attributes[52].Value; }
        set { Attributes[52].Value = value; }
    }
    
    /// <summary>
    /// <para> Second Curve Control Point.</para>
    /// <para>Represents the following attribute in the schema: control2 </para>
    /// </summary>
    [SchemaAttr(0, "control2")]
    public StringValue Control2
    {
        get { return (StringValue)Attributes[53].Value; }
        set { Attributes[53].Value = value; }
    }
    
    /// <summary>
    /// <para> Curve Ending Point.</para>
    /// <para>Represents the following attribute in the schema: to </para>
    /// </summary>
    [SchemaAttr(0, "to")]
    public StringValue To
    {
        get { return (StringValue)Attributes[54].Value; }
        set { Attributes[54].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Curve class.
    /// </summary>
    public Curve():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Curve class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Curve(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Curve class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Curve(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Curve class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Curve(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Curve>(deep);

}
/// <summary>
/// <para>Image File.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:image.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ImageFile : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12592;
    /// <inheritdoc/>
    public override string LocalName => "image";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "class"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<StringValue>(27, "bordertopcolor"),
		AttributeTag.Create<StringValue>(27, "borderleftcolor"),
		AttributeTag.Create<StringValue>(27, "borderbottomcolor"),
		AttributeTag.Create<StringValue>(27, "borderrightcolor"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<TrueFalseValue>(0, "filled"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<TrueFalseValue>(0, "stroked"),
		AttributeTag.Create<StringValue>(0, "strokecolor"),
		AttributeTag.Create<StringValue>(0, "strokeweight"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen"),
		AttributeTag.Create<Int32Value>(27, "spt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>(27, "connectortype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<TrueFalseValue>(27, "oleicon"),
		AttributeTag.Create<TrueFalseBlankValue>(27, "ole"),
		AttributeTag.Create<TrueFalseValue>(27, "preferrelative"),
		AttributeTag.Create<TrueFalseValue>(27, "cliptowrap"),
		AttributeTag.Create<TrueFalseValue>(27, "clip"),
		AttributeTag.Create<StringValue>(0, "src"),
		AttributeTag.Create<StringValue>(0, "cropleft"),
		AttributeTag.Create<StringValue>(0, "croptop"),
		AttributeTag.Create<StringValue>(0, "cropright"),
		AttributeTag.Create<StringValue>(0, "cropbottom"),
		AttributeTag.Create<StringValue>(0, "gain"),
		AttributeTag.Create<StringValue>(0, "blacklevel"),
		AttributeTag.Create<StringValue>(0, "gamma"),
		AttributeTag.Create<TrueFalseValue>(0, "grayscale"),
		AttributeTag.Create<TrueFalseValue>(0, "bilevel")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> href.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> class.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> alt.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> coordsize.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> wrapcoords.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> print.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
        get { return (Int32Value)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
        get { return (TrueFalseValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
        get { return (TrueFalseBlankValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
        get { return (TrueFalseValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
        get { return (TrueFalseValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
        get { return (TrueFalseValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Source.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Left Crop.</para>
    /// <para>Represents the following attribute in the schema: cropleft </para>
    /// </summary>
    [SchemaAttr(0, "cropleft")]
    public StringValue CropLeft
    {
        get { return (StringValue)Attributes[51].Value; }
        set { Attributes[51].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Top Crop.</para>
    /// <para>Represents the following attribute in the schema: croptop </para>
    /// </summary>
    [SchemaAttr(0, "croptop")]
    public StringValue CropTop
    {
        get { return (StringValue)Attributes[52].Value; }
        set { Attributes[52].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Right Crop.</para>
    /// <para>Represents the following attribute in the schema: cropright </para>
    /// </summary>
    [SchemaAttr(0, "cropright")]
    public StringValue CropRight
    {
        get { return (StringValue)Attributes[53].Value; }
        set { Attributes[53].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Bottom Crop.</para>
    /// <para>Represents the following attribute in the schema: cropbottom </para>
    /// </summary>
    [SchemaAttr(0, "cropbottom")]
    public StringValue CropBottom
    {
        get { return (StringValue)Attributes[54].Value; }
        set { Attributes[54].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Intensity.</para>
    /// <para>Represents the following attribute in the schema: gain </para>
    /// </summary>
    [SchemaAttr(0, "gain")]
    public StringValue Gain
    {
        get { return (StringValue)Attributes[55].Value; }
        set { Attributes[55].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Brightness.</para>
    /// <para>Represents the following attribute in the schema: blacklevel </para>
    /// </summary>
    [SchemaAttr(0, "blacklevel")]
    public StringValue BlackLevel
    {
        get { return (StringValue)Attributes[56].Value; }
        set { Attributes[56].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Gamma Correction.</para>
    /// <para>Represents the following attribute in the schema: gamma </para>
    /// </summary>
    [SchemaAttr(0, "gamma")]
    public StringValue Gamma
    {
        get { return (StringValue)Attributes[57].Value; }
        set { Attributes[57].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Grayscale Toggle.</para>
    /// <para>Represents the following attribute in the schema: grayscale </para>
    /// </summary>
    [SchemaAttr(0, "grayscale")]
    public TrueFalseValue GrayScale
    {
        get { return (TrueFalseValue)Attributes[58].Value; }
        set { Attributes[58].Value = value; }
    }
    
    /// <summary>
    /// <para> Image Bilevel Toggle.</para>
    /// <para>Represents the following attribute in the schema: bilevel </para>
    /// </summary>
    [SchemaAttr(0, "bilevel")]
    public TrueFalseValue BiLevel
    {
        get { return (TrueFalseValue)Attributes[59].Value; }
        set { Attributes[59].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ImageFile class.
    /// </summary>
    public ImageFile():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ImageFile class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ImageFile(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ImageFile class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ImageFile(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ImageFile class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ImageFile(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageFile>(deep);

}
/// <summary>
/// <para>Line.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:line.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Line : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12593;
    /// <inheritdoc/>
    public override string LocalName => "line";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "class"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "coordorigin"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<StringValue>(27, "bordertopcolor"),
		AttributeTag.Create<StringValue>(27, "borderleftcolor"),
		AttributeTag.Create<StringValue>(27, "borderbottomcolor"),
		AttributeTag.Create<StringValue>(27, "borderrightcolor"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<TrueFalseValue>(0, "filled"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<TrueFalseValue>(0, "stroked"),
		AttributeTag.Create<StringValue>(0, "strokecolor"),
		AttributeTag.Create<StringValue>(0, "strokeweight"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen"),
		AttributeTag.Create<Int32Value>(27, "spt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>(27, "connectortype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<TrueFalseValue>(27, "oleicon"),
		AttributeTag.Create<TrueFalseBlankValue>(27, "ole"),
		AttributeTag.Create<TrueFalseValue>(27, "preferrelative"),
		AttributeTag.Create<TrueFalseValue>(27, "cliptowrap"),
		AttributeTag.Create<TrueFalseValue>(27, "clip"),
		AttributeTag.Create<StringValue>(0, "from"),
		AttributeTag.Create<StringValue>(0, "to")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
        get { return (Int32Value)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
        get { return (TrueFalseValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
        get { return (TrueFalseBlankValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
        get { return (TrueFalseValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
        get { return (TrueFalseValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
        get { return (TrueFalseValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    
    /// <summary>
    /// <para> Line Start.</para>
    /// <para>Represents the following attribute in the schema: from </para>
    /// </summary>
    [SchemaAttr(0, "from")]
    public StringValue From
    {
        get { return (StringValue)Attributes[51].Value; }
        set { Attributes[51].Value = value; }
    }
    
    /// <summary>
    /// <para> Line End Point.</para>
    /// <para>Represents the following attribute in the schema: to </para>
    /// </summary>
    [SchemaAttr(0, "to")]
    public StringValue To
    {
        get { return (StringValue)Attributes[52].Value; }
        set { Attributes[52].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Line class.
    /// </summary>
    public Line():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Line class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Line(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Line class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Line(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Line class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Line(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Line>(deep);

}
/// <summary>
/// <para>Oval.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:oval.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Oval : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12594;
    /// <inheritdoc/>
    public override string LocalName => "oval";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "class"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "coordorigin"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<StringValue>(27, "bordertopcolor"),
		AttributeTag.Create<StringValue>(27, "borderleftcolor"),
		AttributeTag.Create<StringValue>(27, "borderbottomcolor"),
		AttributeTag.Create<StringValue>(27, "borderrightcolor"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<TrueFalseValue>(0, "filled"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<TrueFalseValue>(0, "stroked"),
		AttributeTag.Create<StringValue>(0, "strokecolor"),
		AttributeTag.Create<StringValue>(0, "strokeweight"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen"),
		AttributeTag.Create<Int32Value>(27, "spt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>(27, "connectortype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<TrueFalseValue>(27, "oleicon"),
		AttributeTag.Create<TrueFalseBlankValue>(27, "ole"),
		AttributeTag.Create<TrueFalseValue>(27, "preferrelative"),
		AttributeTag.Create<TrueFalseValue>(27, "cliptowrap"),
		AttributeTag.Create<TrueFalseValue>(27, "clip")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
        get { return (Int32Value)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
        get { return (TrueFalseValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
        get { return (TrueFalseBlankValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
        get { return (TrueFalseValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
        get { return (TrueFalseValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
        get { return (TrueFalseValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Oval class.
    /// </summary>
    public Oval():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Oval class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Oval(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Oval class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Oval(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Oval class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Oval(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Oval>(deep);

}
/// <summary>
/// <para>Multiple Path Line.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:polyline.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Ink &lt;o:ink></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Ink))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PolyLine : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12595;
    /// <inheritdoc/>
    public override string LocalName => "polyline";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "class"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "coordorigin"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<StringValue>(27, "bordertopcolor"),
		AttributeTag.Create<StringValue>(27, "borderleftcolor"),
		AttributeTag.Create<StringValue>(27, "borderbottomcolor"),
		AttributeTag.Create<StringValue>(27, "borderrightcolor"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<TrueFalseValue>(0, "filled"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<TrueFalseValue>(0, "stroked"),
		AttributeTag.Create<StringValue>(0, "strokecolor"),
		AttributeTag.Create<StringValue>(0, "strokeweight"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen"),
		AttributeTag.Create<Int32Value>(27, "spt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>(27, "connectortype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<TrueFalseValue>(27, "oleicon"),
		AttributeTag.Create<TrueFalseBlankValue>(27, "ole"),
		AttributeTag.Create<TrueFalseValue>(27, "preferrelative"),
		AttributeTag.Create<TrueFalseValue>(27, "cliptowrap"),
		AttributeTag.Create<TrueFalseValue>(27, "clip"),
		AttributeTag.Create<StringValue>(0, "points")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
        get { return (Int32Value)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
        get { return (TrueFalseValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
        get { return (TrueFalseBlankValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
        get { return (TrueFalseValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
        get { return (TrueFalseValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
        get { return (TrueFalseValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    
    /// <summary>
    /// <para> Points for Compound Line.</para>
    /// <para>Represents the following attribute in the schema: points </para>
    /// </summary>
    [SchemaAttr(0, "points")]
    public StringValue Points
    {
        get { return (StringValue)Attributes[51].Value; }
        set { Attributes[51].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PolyLine class.
    /// </summary>
    public PolyLine():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PolyLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PolyLine(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PolyLine class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PolyLine(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PolyLine class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PolyLine(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    
if( 27 == namespaceId && "ink" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Ink();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PolyLine>(deep);

}
/// <summary>
/// <para>Rectangle.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:rect.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Rectangle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12596;
    /// <inheritdoc/>
    public override string LocalName => "rect";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "class"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "coordorigin"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<StringValue>(27, "bordertopcolor"),
		AttributeTag.Create<StringValue>(27, "borderleftcolor"),
		AttributeTag.Create<StringValue>(27, "borderbottomcolor"),
		AttributeTag.Create<StringValue>(27, "borderrightcolor"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<TrueFalseValue>(0, "filled"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<TrueFalseValue>(0, "stroked"),
		AttributeTag.Create<StringValue>(0, "strokecolor"),
		AttributeTag.Create<StringValue>(0, "strokeweight"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen"),
		AttributeTag.Create<Int32Value>(27, "spt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>(27, "connectortype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<TrueFalseValue>(27, "oleicon"),
		AttributeTag.Create<TrueFalseBlankValue>(27, "ole"),
		AttributeTag.Create<TrueFalseValue>(27, "preferrelative"),
		AttributeTag.Create<TrueFalseValue>(27, "cliptowrap"),
		AttributeTag.Create<TrueFalseValue>(27, "clip")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
        get { return (StringValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
        get { return (Int32Value)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
        get { return (TrueFalseValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
        get { return (TrueFalseBlankValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
        get { return (TrueFalseValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
        get { return (TrueFalseValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
        get { return (TrueFalseValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Rectangle class.
    /// </summary>
    public Rectangle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Rectangle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rectangle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Rectangle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rectangle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Rectangle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Rectangle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rectangle>(deep);

}
/// <summary>
/// <para>Rounded Rectangle.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:roundrect.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Path &lt;v:path></description></item>
///<item><description>Formulas &lt;v:formulas></description></item>
///<item><description>ShapeHandles &lt;v:handles></description></item>
///<item><description>Fill &lt;v:fill></description></item>
///<item><description>Stroke &lt;v:stroke></description></item>
///<item><description>Shadow &lt;v:shadow></description></item>
///<item><description>TextBox &lt;v:textbox></description></item>
///<item><description>TextPath &lt;v:textpath></description></item>
///<item><description>ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Path))]
    [ChildElementInfo(typeof(Formulas))]
    [ChildElementInfo(typeof(ShapeHandles))]
    [ChildElementInfo(typeof(Fill))]
    [ChildElementInfo(typeof(Stroke))]
    [ChildElementInfo(typeof(Shadow))]
    [ChildElementInfo(typeof(TextBox))]
    [ChildElementInfo(typeof(TextPath))]
    [ChildElementInfo(typeof(ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Skew))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Callout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.Lock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RoundRectangle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12597;
    /// <inheritdoc/>
    public override string LocalName => "roundrect";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<StringValue>(0, "href"),
		AttributeTag.Create<StringValue>(0, "target"),
		AttributeTag.Create<StringValue>(0, "class"),
		AttributeTag.Create<StringValue>(0, "title"),
		AttributeTag.Create<StringValue>(0, "alt"),
		AttributeTag.Create<StringValue>(0, "coordsize"),
		AttributeTag.Create<StringValue>(0, "wrapcoords"),
		AttributeTag.Create<TrueFalseValue>(0, "print"),
		AttributeTag.Create<StringValue>(27, "spid"),
		AttributeTag.Create<TrueFalseValue>(27, "oned"),
		AttributeTag.Create<IntegerValue>(27, "regroupid"),
		AttributeTag.Create<TrueFalseValue>(27, "doubleclicknotify"),
		AttributeTag.Create<TrueFalseValue>(27, "button"),
		AttributeTag.Create<TrueFalseValue>(27, "userhidden"),
		AttributeTag.Create<TrueFalseValue>(27, "bullet"),
		AttributeTag.Create<TrueFalseValue>(27, "hr"),
		AttributeTag.Create<TrueFalseValue>(27, "hrstd"),
		AttributeTag.Create<TrueFalseValue>(27, "hrnoshade"),
		AttributeTag.Create<SingleValue>(27, "hrpct"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>(27, "hralign"),
		AttributeTag.Create<TrueFalseValue>(27, "allowincell"),
		AttributeTag.Create<TrueFalseValue>(27, "allowoverlap"),
		AttributeTag.Create<TrueFalseValue>(27, "userdrawn"),
		AttributeTag.Create<StringValue>(27, "bordertopcolor"),
		AttributeTag.Create<StringValue>(27, "borderleftcolor"),
		AttributeTag.Create<StringValue>(27, "borderbottomcolor"),
		AttributeTag.Create<StringValue>(27, "borderrightcolor"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayout"),
		AttributeTag.Create<IntegerValue>(27, "dgmnodekind"),
		AttributeTag.Create<IntegerValue>(27, "dgmlayoutmru"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>(27, "insetmode"),
		AttributeTag.Create<TrueFalseValue>(0, "filled"),
		AttributeTag.Create<StringValue>(0, "fillcolor"),
		AttributeTag.Create<TrueFalseValue>(0, "stroked"),
		AttributeTag.Create<StringValue>(0, "strokecolor"),
		AttributeTag.Create<StringValue>(0, "strokeweight"),
		AttributeTag.Create<TrueFalseValue>(0, "insetpen"),
		AttributeTag.Create<Int32Value>(27, "spt"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>(27, "connectortype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwmode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwpure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>(27, "bwnormal"),
		AttributeTag.Create<TrueFalseValue>(27, "forcedash"),
		AttributeTag.Create<TrueFalseValue>(27, "oleicon"),
		AttributeTag.Create<TrueFalseBlankValue>(27, "ole"),
		AttributeTag.Create<TrueFalseValue>(27, "preferrelative"),
		AttributeTag.Create<TrueFalseValue>(27, "cliptowrap"),
		AttributeTag.Create<TrueFalseValue>(27, "clip"),
		AttributeTag.Create<StringValue>(0, "arcsize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> href.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> class.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> alt.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> coordsize.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> wrapcoords.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> print.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional String.</para>
    /// <para>Represents the following attribute in the schema: o:spid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spid")]
    public StringValue OptionalString
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Handle Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oned </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oned")]
    public TrueFalseValue Oned
    {
        get { return (TrueFalseValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> Regroup ID.</para>
    /// <para>Represents the following attribute in the schema: o:regroupid </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "regroupid")]
    public IntegerValue RegroupId
    {
        get { return (IntegerValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> Double-click Notification Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:doubleclicknotify </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "doubleclicknotify")]
    public TrueFalseValue DoubleClickNotify
    {
        get { return (TrueFalseValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> Button Behavior Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:button </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "button")]
    public TrueFalseValue Button
    {
        get { return (TrueFalseValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> Hide Script Anchors.</para>
    /// <para>Represents the following attribute in the schema: o:userhidden </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userhidden")]
    public TrueFalseValue UserHidden
    {
        get { return (TrueFalseValue)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> Graphical Bullet.</para>
    /// <para>Represents the following attribute in the schema: o:bullet </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bullet")]
    public TrueFalseValue Bullet
    {
        get { return (TrueFalseValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hr </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hr")]
    public TrueFalseValue Horizontal
    {
        get { return (TrueFalseValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Standard Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrstd </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrstd")]
    public TrueFalseValue HorizontalStandard
    {
        get { return (TrueFalseValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule 3D Shading Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:hrnoshade </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrnoshade")]
    public TrueFalseValue HorizontalNoShade
    {
        get { return (TrueFalseValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Length Percentage.</para>
    /// <para>Represents the following attribute in the schema: o:hrpct </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hrpct")]
    public SingleValue HorizontalPercentage
    {
        get { return (SingleValue)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Rule Alignment.</para>
    /// <para>Represents the following attribute in the schema: o:hralign </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "hralign")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow in Table Cell.</para>
    /// <para>Represents the following attribute in the schema: o:allowincell </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowincell")]
    public TrueFalseValue AllowInCell
    {
        get { return (TrueFalseValue)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> Allow Shape Overlap.</para>
    /// <para>Represents the following attribute in the schema: o:allowoverlap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "allowoverlap")]
    public TrueFalseValue AllowOverlap
    {
        get { return (TrueFalseValue)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> Exists In Master Slide.</para>
    /// <para>Represents the following attribute in the schema: o:userdrawn </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "userdrawn")]
    public TrueFalseValue UserDrawn
    {
        get { return (TrueFalseValue)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Top Color.</para>
    /// <para>Represents the following attribute in the schema: o:bordertopcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bordertopcolor")]
    public StringValue BorderTopColor
    {
        get { return (StringValue)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Left Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderleftcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderleftcolor")]
    public StringValue BorderLeftColor
    {
        get { return (StringValue)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom Border Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderbottomcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderbottomcolor")]
    public StringValue BorderBottomColor
    {
        get { return (StringValue)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> Border Right Color.</para>
    /// <para>Represents the following attribute in the schema: o:borderrightcolor </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "borderrightcolor")]
    public StringValue BorderRightColor
    {
        get { return (StringValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayout </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayout")]
    public IntegerValue DiagramLayout
    {
        get { return (IntegerValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmnodekind </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmnodekind")]
    public IntegerValue DiagramNodeKind
    {
        get { return (IntegerValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    
    /// <summary>
    /// <para> Diagram Node Recent Layout Identifier.</para>
    /// <para>Represents the following attribute in the schema: o:dgmlayoutmru </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "dgmlayoutmru")]
    public IntegerValue DiagramLayoutMostRecentUsed
    {
        get { return (IntegerValue)Attributes[31].Value; }
        set { Attributes[31].Value = value; }
    }
    
    /// <summary>
    /// <para> Text Inset Mode.</para>
    /// <para>Represents the following attribute in the schema: o:insetmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "insetmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[32].Value; }
        set { Attributes[32].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[33].Value; }
        set { Attributes[33].Value = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[34].Value; }
        set { Attributes[34].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[35].Value; }
        set { Attributes[35].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[36].Value; }
        set { Attributes[36].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[37].Value; }
        set { Attributes[37].Value = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[38].Value; }
        set { Attributes[38].Value = value; }
    }
    
    /// <summary>
    /// <para> Optional Number.</para>
    /// <para>Represents the following attribute in the schema: o:spt </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "spt")]
    public Int32Value OptionalNumber
    {
        get { return (Int32Value)Attributes[39].Value; }
        set { Attributes[39].Value = value; }
    }
    
    /// <summary>
    /// <para> Shape Connector Type.</para>
    /// <para>Represents the following attribute in the schema: o:connectortype </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "connectortype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[40].Value; }
        set { Attributes[40].Value = value; }
    }
    
    /// <summary>
    /// <para> Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwmode </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwmode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[41].Value; }
        set { Attributes[41].Value = value; }
    }
    
    /// <summary>
    /// <para> Pure Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwpure </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwpure")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42].Value; }
        set { Attributes[42].Value = value; }
    }
    
    /// <summary>
    /// <para> Normal Black-and-White Mode.</para>
    /// <para>Represents the following attribute in the schema: o:bwnormal </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "bwnormal")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43].Value; }
        set { Attributes[43].Value = value; }
    }
    
    /// <summary>
    /// <para> Force Dashed Outline.</para>
    /// <para>Represents the following attribute in the schema: o:forcedash </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "forcedash")]
    public TrueFalseValue ForceDash
    {
        get { return (TrueFalseValue)Attributes[44].Value; }
        set { Attributes[44].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Icon Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:oleicon </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "oleicon")]
    public TrueFalseValue OleIcon
    {
        get { return (TrueFalseValue)Attributes[45].Value; }
        set { Attributes[45].Value = value; }
    }
    
    /// <summary>
    /// <para> Embedded Object Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:ole </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "ole")]
    public TrueFalseBlankValue Ole
    {
        get { return (TrueFalseBlankValue)Attributes[46].Value; }
        set { Attributes[46].Value = value; }
    }
    
    /// <summary>
    /// <para> Relative Resize Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:preferrelative </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "preferrelative")]
    public TrueFalseValue PreferRelative
    {
        get { return (TrueFalseValue)Attributes[47].Value; }
        set { Attributes[47].Value = value; }
    }
    
    /// <summary>
    /// <para> Clip to Wrapping Polygon.</para>
    /// <para>Represents the following attribute in the schema: o:cliptowrap </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "cliptowrap")]
    public TrueFalseValue ClipToWrap
    {
        get { return (TrueFalseValue)Attributes[48].Value; }
        set { Attributes[48].Value = value; }
    }
    
    /// <summary>
    /// <para> Clipping Toggle.</para>
    /// <para>Represents the following attribute in the schema: o:clip </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "clip")]
    public TrueFalseValue Clip
    {
        get { return (TrueFalseValue)Attributes[49].Value; }
        set { Attributes[49].Value = value; }
    }
    
    /// <summary>
    /// <para> Rounded Corner Arc Size.</para>
    /// <para>Represents the following attribute in the schema: arcsize </para>
    /// </summary>
    [SchemaAttr(0, "arcsize")]
    public StringValue ArcSize
    {
        get { return (StringValue)Attributes[50].Value; }
        set { Attributes[50].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RoundRectangle class.
    /// </summary>
    public RoundRectangle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RoundRectangle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RoundRectangle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RoundRectangle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RoundRectangle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RoundRectangle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RoundRectangle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "path" == name)
    return new Path();
    
if( 26 == namespaceId && "formulas" == name)
    return new Formulas();
    
if( 26 == namespaceId && "handles" == name)
    return new ShapeHandles();
    
if( 26 == namespaceId && "fill" == name)
    return new Fill();
    
if( 26 == namespaceId && "stroke" == name)
    return new Stroke();
    
if( 26 == namespaceId && "shadow" == name)
    return new Shadow();
    
if( 26 == namespaceId && "textbox" == name)
    return new TextBox();
    
if( 26 == namespaceId && "textpath" == name)
    return new TextPath();
    
if( 26 == namespaceId && "imagedata" == name)
    return new ImageData();
    
if( 27 == namespaceId && "skew" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new DocumentFormat.OpenXml.Vml.Office.Lock();
    
if( 27 == namespaceId && "clippath" == name)
    return new DocumentFormat.OpenXml.Vml.Office.ClipPath();
    
if( 27 == namespaceId && "signatureline" == name)
    return new DocumentFormat.OpenXml.Vml.Office.SignatureLine();
    
if( 28 == namespaceId && "wrap" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap();
    
if( 28 == namespaceId && "anchorlock" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock();
    
if( 28 == namespaceId && "bordertop" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();
    
if( 28 == namespaceId && "borderbottom" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder();
    
if( 28 == namespaceId && "borderleft" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder();
    
if( 28 == namespaceId && "borderright" == name)
    return new DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder();
    
if( 29 == namespaceId && "ClientData" == name)
    return new DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData();
    
if( 30 == namespaceId && "textdata" == name)
    return new DocumentFormat.OpenXml.Vml.Presentation.TextData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoundRectangle>(deep);

}
/// <summary>
/// <para>Shape Handle.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:h.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShapeHandle : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12598;
    /// <inheritdoc/>
    public override string LocalName => "h";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "position"),
		AttributeTag.Create<StringValue>(0, "polar"),
		AttributeTag.Create<StringValue>(0, "map"),
		AttributeTag.Create<TrueFalseBlankValue>(0, "invx"),
		AttributeTag.Create<TrueFalseBlankValue>(0, "invy"),
		AttributeTag.Create<TrueFalseBlankValue>(0, "switch"),
		AttributeTag.Create<StringValue>(0, "xrange"),
		AttributeTag.Create<StringValue>(0, "yrange"),
		AttributeTag.Create<StringValue>(0, "radiusrange")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Handle Position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    public StringValue Position
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Handle Polar Center.</para>
    /// <para>Represents the following attribute in the schema: polar </para>
    /// </summary>
    [SchemaAttr(0, "polar")]
    public StringValue Polar
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Handle Coordinate Mapping.</para>
    /// <para>Represents the following attribute in the schema: map </para>
    /// </summary>
    [SchemaAttr(0, "map")]
    public StringValue Map
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Invert Handle's X Position.</para>
    /// <para>Represents the following attribute in the schema: invx </para>
    /// </summary>
    [SchemaAttr(0, "invx")]
    public TrueFalseBlankValue InvertX
    {
        get { return (TrueFalseBlankValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Invert Handle's Y Position.</para>
    /// <para>Represents the following attribute in the schema: invy </para>
    /// </summary>
    [SchemaAttr(0, "invy")]
    public TrueFalseBlankValue InvertY
    {
        get { return (TrueFalseBlankValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Handle Inversion Toggle.</para>
    /// <para>Represents the following attribute in the schema: switch </para>
    /// </summary>
    [SchemaAttr(0, "switch")]
    public TrueFalseBlankValue Switch
    {
        get { return (TrueFalseBlankValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Handle X Position Range.</para>
    /// <para>Represents the following attribute in the schema: xrange </para>
    /// </summary>
    [SchemaAttr(0, "xrange")]
    public StringValue XRange
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Handle Y Position Range.</para>
    /// <para>Represents the following attribute in the schema: yrange </para>
    /// </summary>
    [SchemaAttr(0, "yrange")]
    public StringValue YRange
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Handle Polar Radius Range.</para>
    /// <para>Represents the following attribute in the schema: radiusrange </para>
    /// </summary>
    [SchemaAttr(0, "radiusrange")]
    public StringValue RadiusRange
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShapeHandle class.
    /// </summary>
    public ShapeHandle():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeHandle>(deep);

}
/// <summary>
/// <para>Single Formula.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:f.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Formula : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12599;
    /// <inheritdoc/>
    public override string LocalName => "f";
    
    internal override byte NamespaceId => 26;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "eqn")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Equation.</para>
    /// <para>Represents the following attribute in the schema: eqn </para>
    /// </summary>
    [SchemaAttr(0, "eqn")]
    public StringValue Equation
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Formula class.
    /// </summary>
    public Formula():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);

}
/// <summary>
/// VML Extension Handling Behaviors 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ExtensionHandlingBehaviorValues
{  
	///<summary>
///Not renderable.
///<para>When the item is serialized out as xml, its value is "view".</para>
///</summary>
[EnumString("view")]
View,
///<summary>
///Editable.
///<para>When the item is serialized out as xml, its value is "edit".</para>
///</summary>
[EnumString("edit")]
Edit,
///<summary>
///Renderable.
///<para>When the item is serialized out as xml, its value is "backwardCompatible".</para>
///</summary>
[EnumString("backwardCompatible")]
BackwardCompatible,
 
}
/// <summary>
/// Shape Fill Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FillTypeValues
{  
	///<summary>
///Solid Fill.
///<para>When the item is serialized out as xml, its value is "solid".</para>
///</summary>
[EnumString("solid")]
Solid,
///<summary>
///Linear Gradient.
///<para>When the item is serialized out as xml, its value is "gradient".</para>
///</summary>
[EnumString("gradient")]
Gradient,
///<summary>
///Radial Gradient.
///<para>When the item is serialized out as xml, its value is "gradientRadial".</para>
///</summary>
[EnumString("gradientRadial")]
GradientRadial,
///<summary>
///Tiled Image.
///<para>When the item is serialized out as xml, its value is "tile".</para>
///</summary>
[EnumString("tile")]
Tile,
///<summary>
///Image Pattern.
///<para>When the item is serialized out as xml, its value is "pattern".</para>
///</summary>
[EnumString("pattern")]
Pattern,
///<summary>
///Stretch Image to Fit.
///<para>When the item is serialized out as xml, its value is "frame".</para>
///</summary>
[EnumString("frame")]
Frame,
 
}
/// <summary>
/// Gradient Fill Computation Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FillMethodValues
{  
	///<summary>
///No Gradient Fill.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Linear Fill.
///<para>When the item is serialized out as xml, its value is "linear".</para>
///</summary>
[EnumString("linear")]
Linear,
///<summary>
///Sigma Fill.
///<para>When the item is serialized out as xml, its value is "sigma".</para>
///</summary>
[EnumString("sigma")]
Sigma,
///<summary>
///Application Default Fill.
///<para>When the item is serialized out as xml, its value is "any".</para>
///</summary>
[EnumString("any")]
Any,
///<summary>
///Linear Sigma Fill.
///<para>When the item is serialized out as xml, its value is "linear sigma".</para>
///</summary>
[EnumString("linear sigma")]
Linearsigma,
 
}
/// <summary>
/// Stroke Line Style 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeLineStyleValues
{  
	///<summary>
///Single Line.
///<para>When the item is serialized out as xml, its value is "single".</para>
///</summary>
[EnumString("single")]
Single,
///<summary>
///Two Thin Lines.
///<para>When the item is serialized out as xml, its value is "thinThin".</para>
///</summary>
[EnumString("thinThin")]
ThinThin,
///<summary>
///Thin Line Outside Thick Line.
///<para>When the item is serialized out as xml, its value is "thinThick".</para>
///</summary>
[EnumString("thinThick")]
ThinThick,
///<summary>
///Thick Line Outside Thin Line.
///<para>When the item is serialized out as xml, its value is "thickThin".</para>
///</summary>
[EnumString("thickThin")]
ThickThin,
///<summary>
///Thck Line Between Thin Lines.
///<para>When the item is serialized out as xml, its value is "thickBetweenThin".</para>
///</summary>
[EnumString("thickBetweenThin")]
ThickBetweenThin,
 
}
/// <summary>
/// Line Join Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeJoinStyleValues
{  
	///<summary>
///Round Joint.
///<para>When the item is serialized out as xml, its value is "round".</para>
///</summary>
[EnumString("round")]
Round,
///<summary>
///Bevel Joint.
///<para>When the item is serialized out as xml, its value is "bevel".</para>
///</summary>
[EnumString("bevel")]
Bevel,
///<summary>
///Miter Joint.
///<para>When the item is serialized out as xml, its value is "miter".</para>
///</summary>
[EnumString("miter")]
Miter,
 
}
/// <summary>
/// Stroke End Cap Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeEndCapValues
{  
	///<summary>
///Flat End.
///<para>When the item is serialized out as xml, its value is "flat".</para>
///</summary>
[EnumString("flat")]
Flat,
///<summary>
///Square End.
///<para>When the item is serialized out as xml, its value is "square".</para>
///</summary>
[EnumString("square")]
Square,
///<summary>
///Round End.
///<para>When the item is serialized out as xml, its value is "round".</para>
///</summary>
[EnumString("round")]
Round,
 
}
/// <summary>
/// Stroke Arrowhead Length 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeArrowLengthValues
{  
	///<summary>
///Short Arrowhead.
///<para>When the item is serialized out as xml, its value is "short".</para>
///</summary>
[EnumString("short")]
Short,
///<summary>
///Medium Arrowhead.
///<para>When the item is serialized out as xml, its value is "medium".</para>
///</summary>
[EnumString("medium")]
Medium,
///<summary>
///Long Arrowhead.
///<para>When the item is serialized out as xml, its value is "long".</para>
///</summary>
[EnumString("long")]
Long,
 
}
/// <summary>
/// Stroke Arrowhead Width 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeArrowWidthValues
{  
	///<summary>
///Narrow Arrowhead.
///<para>When the item is serialized out as xml, its value is "narrow".</para>
///</summary>
[EnumString("narrow")]
Narrow,
///<summary>
///Medium Arrowhead.
///<para>When the item is serialized out as xml, its value is "medium".</para>
///</summary>
[EnumString("medium")]
Medium,
///<summary>
///Wide Arrowhead.
///<para>When the item is serialized out as xml, its value is "wide".</para>
///</summary>
[EnumString("wide")]
Wide,
 
}
/// <summary>
/// Stroke Arrowhead Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeArrowValues
{  
	///<summary>
///No Arrowhead.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Block Arrowhead.
///<para>When the item is serialized out as xml, its value is "block".</para>
///</summary>
[EnumString("block")]
Block,
///<summary>
///Classic Arrowhead.
///<para>When the item is serialized out as xml, its value is "classic".</para>
///</summary>
[EnumString("classic")]
Classic,
///<summary>
///Oval Arrowhead.
///<para>When the item is serialized out as xml, its value is "oval".</para>
///</summary>
[EnumString("oval")]
Oval,
///<summary>
///Diamond Arrowhead.
///<para>When the item is serialized out as xml, its value is "diamond".</para>
///</summary>
[EnumString("diamond")]
Diamond,
///<summary>
///Open Arrowhead.
///<para>When the item is serialized out as xml, its value is "open".</para>
///</summary>
[EnumString("open")]
Open,
 
}
/// <summary>
/// Image Scaling Behavior 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ImageAspectValues
{  
	///<summary>
///Ignore Aspect Ratio.
///<para>When the item is serialized out as xml, its value is "ignore".</para>
///</summary>
[EnumString("ignore")]
Ignore,
///<summary>
///At Most.
///<para>When the item is serialized out as xml, its value is "atMost".</para>
///</summary>
[EnumString("atMost")]
AtMost,
///<summary>
///At Least.
///<para>When the item is serialized out as xml, its value is "atLeast".</para>
///</summary>
[EnumString("atLeast")]
AtLeast,
 
}
/// <summary>
/// Shape Grouping Types 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum EditAsValues
{  
	///<summary>
///Shape Canvas.
///<para>When the item is serialized out as xml, its value is "canvas".</para>
///</summary>
[EnumString("canvas")]
Canvas,
///<summary>
///Organization Chart Diagram.
///<para>When the item is serialized out as xml, its value is "orgchart".</para>
///</summary>
[EnumString("orgchart")]
OrganizationChart,
///<summary>
///Radial Diagram.
///<para>When the item is serialized out as xml, its value is "radial".</para>
///</summary>
[EnumString("radial")]
Radial,
///<summary>
///Cycle Diagram.
///<para>When the item is serialized out as xml, its value is "cycle".</para>
///</summary>
[EnumString("cycle")]
Cycle,
///<summary>
///Pyramid Diagram.
///<para>When the item is serialized out as xml, its value is "stacked".</para>
///</summary>
[EnumString("stacked")]
Stacked,
///<summary>
///Venn Diagram.
///<para>When the item is serialized out as xml, its value is "venn".</para>
///</summary>
[EnumString("venn")]
Venn,
///<summary>
///Bullseye Diagram.
///<para>When the item is serialized out as xml, its value is "bullseye".</para>
///</summary>
[EnumString("bullseye")]
Bullseye,
 
}
/// <summary>
/// Shadow Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ShadowValues
{  
	///<summary>
///Single Shadow.
///<para>When the item is serialized out as xml, its value is "single".</para>
///</summary>
[EnumString("single")]
Single,
///<summary>
///Double Shadow.
///<para>When the item is serialized out as xml, its value is "double".</para>
///</summary>
[EnumString("double")]
Double,
///<summary>
///Embossed Shadow.
///<para>When the item is serialized out as xml, its value is "emboss".</para>
///</summary>
[EnumString("emboss")]
Emboss,
///<summary>
///Perspective Shadow.
///<para>When the item is serialized out as xml, its value is "perspective".</para>
///</summary>
[EnumString("perspective")]
Perspective,
///<summary>
///shapeRelative.
///<para>When the item is serialized out as xml, its value is "shapeRelative".</para>
///</summary>
[EnumString("shapeRelative")]
ShapeRelative,
///<summary>
///drawingRelative.
///<para>When the item is serialized out as xml, its value is "drawingRelative".</para>
///</summary>
[EnumString("drawingRelative")]
DrawingRelative,
 
}
/// <summary>
/// Defines the StrokeFillTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StrokeFillTypeValues
{  
	///<summary>
///solid.
///<para>When the item is serialized out as xml, its value is "solid".</para>
///</summary>
[EnumString("solid")]
Solid,
///<summary>
///tile.
///<para>When the item is serialized out as xml, its value is "tile".</para>
///</summary>
[EnumString("tile")]
Tile,
///<summary>
///pattern.
///<para>When the item is serialized out as xml, its value is "pattern".</para>
///</summary>
[EnumString("pattern")]
Pattern,
///<summary>
///frame.
///<para>When the item is serialized out as xml, its value is "frame".</para>
///</summary>
[EnumString("frame")]
Frame,
 
}
}
 
 
