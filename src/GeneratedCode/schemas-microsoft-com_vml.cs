// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
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
/// <para> When the object is serialized out as xml, its qualified name is v:path.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Path : OpenXmlLeafElement
{
    private const string tagName = "path";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12577;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","v","limo","textboxrect","fillok","strokeok","shadowok","arrowok","gradientshapeok","textpathok","insetpenok","connecttype","connectlocs","connectangles","extrusionok" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,27,27,27,27 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Path Definition.</para>
    /// <para>Represents the following attribute in the schema: v </para>
    /// </summary>
    [SchemaAttr(0, "v")]
    public StringValue Value
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Limo Stretch Point.</para>
    /// <para>Represents the following attribute in the schema: limo </para>
    /// </summary>
    [SchemaAttr(0, "limo")]
    public StringValue Limo
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Text Box Bounding Box.</para>
    /// <para>Represents the following attribute in the schema: textboxrect </para>
    /// </summary>
    [SchemaAttr(0, "textboxrect")]
    public StringValue TextboxRectangle
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: fillok </para>
    /// </summary>
    [SchemaAttr(0, "fillok")]
    public TrueFalseValue AllowFill
    {
        get { return (TrueFalseValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: strokeok </para>
    /// </summary>
    [SchemaAttr(0, "strokeok")]
    public TrueFalseValue AllowStroke
    {
        get { return (TrueFalseValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Toggle.</para>
    /// <para>Represents the following attribute in the schema: shadowok </para>
    /// </summary>
    [SchemaAttr(0, "shadowok")]
    public TrueFalseValue AllowShading
    {
        get { return (TrueFalseValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Arrowhead Display Toggle.</para>
    /// <para>Represents the following attribute in the schema: arrowok </para>
    /// </summary>
    [SchemaAttr(0, "arrowok")]
    public TrueFalseValue ShowArrowhead
    {
        get { return (TrueFalseValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Gradient Shape Toggle.</para>
    /// <para>Represents the following attribute in the schema: gradientshapeok </para>
    /// </summary>
    [SchemaAttr(0, "gradientshapeok")]
    public TrueFalseValue AllowGradientShape
    {
        get { return (TrueFalseValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Text Path Toggle.</para>
    /// <para>Represents the following attribute in the schema: textpathok </para>
    /// </summary>
    [SchemaAttr(0, "textpathok")]
    public TrueFalseValue AllowTextPath
    {
        get { return (TrueFalseValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Inset Stroke From Path Flag.</para>
    /// <para>Represents the following attribute in the schema: insetpenok </para>
    /// </summary>
    [SchemaAttr(0, "insetpenok")]
    public TrueFalseValue AllowInsetPen
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues>)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Path class.
    /// </summary>
    public Path():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "v" == name)
    return new StringValue();
    
if( 0 == namespaceId && "limo" == name)
    return new StringValue();
    
if( 0 == namespaceId && "textboxrect" == name)
    return new StringValue();
    
if( 0 == namespaceId && "fillok" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokeok" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "shadowok" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "arrowok" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "gradientshapeok" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "textpathok" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "insetpenok" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "connecttype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues>();
    
if( 27 == namespaceId && "connectlocs" == name)
    return new StringValue();
    
if( 27 == namespaceId && "connectangles" == name)
    return new StringValue();
    
if( 27 == namespaceId && "extrusionok" == name)
    return new TrueFalseValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Path>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Formulas Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:formulas.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;v:f></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Formula))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Formulas : OpenXmlCompositeElement
{
    private const string tagName = "formulas";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12578;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Formulas>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ShapeHandles Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:handles.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeHandle &lt;v:h></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ShapeHandle))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ShapeHandles : OpenXmlCompositeElement
{
    private const string tagName = "handles";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12579;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ShapeHandles>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Fill Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:fill.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties &lt;o:fill></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Fill : OpenXmlCompositeElement
{
    private const string tagName = "fill";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12580;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","type","on","color","opacity","color2","src","href","althref","size","origin","position","aspect","colors","angle","alignshape","focus","focussize","focusposition","method","detectmouseclick","title","opacity2","recolor","rotate","id" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,27,27,0,0,0,0,0,0,0,0,0,0,0,27,27,27,0,0,19 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Fill Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Primary Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
    public StringValue Color
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Primary Color Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
    public StringValue Opacity
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Secondary Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
    public StringValue Color2
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Fill Image Source.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
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
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
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
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Fill Image Size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public StringValue Size
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Fill Image Origin.</para>
    /// <para>Represents the following attribute in the schema: origin </para>
    /// </summary>
    [SchemaAttr(0, "origin")]
    public StringValue Origin
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> Fill Image Position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    public StringValue Position
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> Image Aspect Ratio.</para>
    /// <para>Represents the following attribute in the schema: aspect </para>
    /// </summary>
    [SchemaAttr(0, "aspect")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> Aspect
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> Intermediate Colors.</para>
    /// <para>Represents the following attribute in the schema: colors </para>
    /// </summary>
    [SchemaAttr(0, "colors")]
    public StringValue Colors
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> Gradient Angle.</para>
    /// <para>Represents the following attribute in the schema: angle </para>
    /// </summary>
    [SchemaAttr(0, "angle")]
    public DecimalValue Angle
    {
        get { return (DecimalValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> Align Image With Shape.</para>
    /// <para>Represents the following attribute in the schema: alignshape </para>
    /// </summary>
    [SchemaAttr(0, "alignshape")]
    public TrueFalseValue AlignShape
    {
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> Gradient Center.</para>
    /// <para>Represents the following attribute in the schema: focus </para>
    /// </summary>
    [SchemaAttr(0, "focus")]
    public StringValue Focus
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> Radial Gradient Size.</para>
    /// <para>Represents the following attribute in the schema: focussize </para>
    /// </summary>
    [SchemaAttr(0, "focussize")]
    public StringValue FocusSize
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> Radial Gradient Center.</para>
    /// <para>Represents the following attribute in the schema: focusposition </para>
    /// </summary>
    [SchemaAttr(0, "focusposition")]
    public StringValue FocusPosition
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> Gradient Fill Method.</para>
    /// <para>Represents the following attribute in the schema: method </para>
    /// </summary>
    [SchemaAttr(0, "method")]
    public EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues> Method
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues>)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (TrueFalseValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> Recolor Fill as Picture.</para>
    /// <para>Represents the following attribute in the schema: recolor </para>
    /// </summary>
    [SchemaAttr(0, "recolor")]
    public TrueFalseValue Recolor
    {
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> Rotate Fill with Shape.</para>
    /// <para>Represents the following attribute in the schema: rotate </para>
    /// </summary>
    [SchemaAttr(0, "rotate")]
    public TrueFalseValue Rotate
    {
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> FillExtendedProperties.</para>
    /// <para> Represents the following element tag in the schema: o:fill </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties FillExtendedProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues>();
    
if( 0 == namespaceId && "on" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "color" == name)
    return new StringValue();
    
if( 0 == namespaceId && "opacity" == name)
    return new StringValue();
    
if( 0 == namespaceId && "color2" == name)
    return new StringValue();
    
if( 0 == namespaceId && "src" == name)
    return new StringValue();
    
if( 27 == namespaceId && "href" == name)
    return new StringValue();
    
if( 27 == namespaceId && "althref" == name)
    return new StringValue();
    
if( 0 == namespaceId && "size" == name)
    return new StringValue();
    
if( 0 == namespaceId && "origin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "position" == name)
    return new StringValue();
    
if( 0 == namespaceId && "aspect" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>();
    
if( 0 == namespaceId && "colors" == name)
    return new StringValue();
    
if( 0 == namespaceId && "angle" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "alignshape" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "focus" == name)
    return new StringValue();
    
if( 0 == namespaceId && "focussize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "focusposition" == name)
    return new StringValue();
    
if( 0 == namespaceId && "method" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues>();
    
if( 27 == namespaceId && "detectmouseclick" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "title" == name)
    return new StringValue();
    
if( 27 == namespaceId && "opacity2" == name)
    return new StringValue();
    
if( 0 == namespaceId && "recolor" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "rotate" == name)
    return new TrueFalseValue();
    
if( 19 == namespaceId && "id" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Fill>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Stroke Class.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.LeftStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.TopStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.RightStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.BottomStroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Office.ColumnStroke))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Stroke : OpenXmlCompositeElement
{
    private const string tagName = "stroke";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12581;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","on","weight","color","opacity","linestyle","miterlimit","joinstyle","endcap","dashstyle","filltype","src","imageaspect","imagesize","imagealignshape","color2","startarrow","startarrowwidth","startarrowlength","endarrow","endarrowwidth","endarrowlength","href","althref","title","forcedash","id","insetpen" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,27,27,27,27,19,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: weight </para>
    /// </summary>
    [SchemaAttr(0, "weight")]
    public StringValue Weight
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
    public StringValue Color
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
    public StringValue Opacity
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Line Style.</para>
    /// <para>Represents the following attribute in the schema: linestyle </para>
    /// </summary>
    [SchemaAttr(0, "linestyle")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues> LineStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Miter Joint Limit.</para>
    /// <para>Represents the following attribute in the schema: miterlimit </para>
    /// </summary>
    [SchemaAttr(0, "miterlimit")]
    public StringValue Miterlimit
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Line End Join Style.</para>
    /// <para>Represents the following attribute in the schema: joinstyle </para>
    /// </summary>
    [SchemaAttr(0, "joinstyle")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues> JoinStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues>)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Line End Cap.</para>
    /// <para>Represents the following attribute in the schema: endcap </para>
    /// </summary>
    [SchemaAttr(0, "endcap")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues> EndCap
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues>)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Dash Pattern.</para>
    /// <para>Represents the following attribute in the schema: dashstyle </para>
    /// </summary>
    [SchemaAttr(0, "dashstyle")]
    public StringValue DashStyle
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Style.</para>
    /// <para>Represents the following attribute in the schema: filltype </para>
    /// </summary>
    [SchemaAttr(0, "filltype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues> FillType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues>)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Location.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Aspect Ratio.</para>
    /// <para>Represents the following attribute in the schema: imageaspect </para>
    /// </summary>
    [SchemaAttr(0, "imageaspect")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> ImageAspect
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Size.</para>
    /// <para>Represents the following attribute in the schema: imagesize </para>
    /// </summary>
    [SchemaAttr(0, "imagesize")]
    public StringValue ImageSize
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> Stoke Image Alignment.</para>
    /// <para>Represents the following attribute in the schema: imagealignshape </para>
    /// </summary>
    [SchemaAttr(0, "imagealignshape")]
    public TrueFalseValue ImageAlignShape
    {
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Alternate Pattern Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
    public StringValue Color2
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> Line Start Arrowhead.</para>
    /// <para>Represents the following attribute in the schema: startarrow </para>
    /// </summary>
    [SchemaAttr(0, "startarrow")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> StartArrow
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> Line Start Arrowhead Width.</para>
    /// <para>Represents the following attribute in the schema: startarrowwidth </para>
    /// </summary>
    [SchemaAttr(0, "startarrowwidth")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> StartArrowWidth
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> Line Start Arrowhead Length.</para>
    /// <para>Represents the following attribute in the schema: startarrowlength </para>
    /// </summary>
    [SchemaAttr(0, "startarrowlength")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> StartArrowLength
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> Line End Arrowhead.</para>
    /// <para>Represents the following attribute in the schema: endarrow </para>
    /// </summary>
    [SchemaAttr(0, "endarrow")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> EndArrow
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> Line End Arrowhead Width.</para>
    /// <para>Represents the following attribute in the schema: endarrowwidth </para>
    /// </summary>
    [SchemaAttr(0, "endarrowwidth")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> EndArrowWidth
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> Line End Arrowhead Length.</para>
    /// <para>Represents the following attribute in the schema: endarrowlength </para>
    /// </summary>
    [SchemaAttr(0, "endarrowlength")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> EndArrowLength
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (TrueFalseValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue Insetpen
    {
        get { return (TrueFalseValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> LeftStroke.</para>
    /// <para> Represents the following element tag in the schema: o:left </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Office.LeftStroke LeftStroke
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.Office.LeftStroke>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.Office.TopStroke>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.Office.RightStroke>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.Office.BottomStroke>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "on" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "weight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "color" == name)
    return new StringValue();
    
if( 0 == namespaceId && "opacity" == name)
    return new StringValue();
    
if( 0 == namespaceId && "linestyle" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues>();
    
if( 0 == namespaceId && "miterlimit" == name)
    return new StringValue();
    
if( 0 == namespaceId && "joinstyle" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues>();
    
if( 0 == namespaceId && "endcap" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues>();
    
if( 0 == namespaceId && "dashstyle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "filltype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues>();
    
if( 0 == namespaceId && "src" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageaspect" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>();
    
if( 0 == namespaceId && "imagesize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imagealignshape" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "color2" == name)
    return new StringValue();
    
if( 0 == namespaceId && "startarrow" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>();
    
if( 0 == namespaceId && "startarrowwidth" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>();
    
if( 0 == namespaceId && "startarrowlength" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>();
    
if( 0 == namespaceId && "endarrow" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>();
    
if( 0 == namespaceId && "endarrowwidth" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>();
    
if( 0 == namespaceId && "endarrowlength" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>();
    
if( 27 == namespaceId && "href" == name)
    return new StringValue();
    
if( 27 == namespaceId && "althref" == name)
    return new StringValue();
    
if( 27 == namespaceId && "title" == name)
    return new StringValue();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 19 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Stroke>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Shadow Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:shadow.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Shadow : OpenXmlLeafElement
{
    private const string tagName = "shadow";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12582;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","on","type","obscured","color","opacity","offset","color2","offset2","origin","matrix" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Transparency.</para>
    /// <para>Represents the following attribute in the schema: obscured </para>
    /// </summary>
    [SchemaAttr(0, "obscured")]
    public TrueFalseValue Obscured
    {
        get { return (TrueFalseValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Primary Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
    public StringValue Color
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
    public StringValue Opacity
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Primary Offset.</para>
    /// <para>Represents the following attribute in the schema: offset </para>
    /// </summary>
    [SchemaAttr(0, "offset")]
    public StringValue Offset
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Secondary Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
    public StringValue Color2
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Secondary Offset.</para>
    /// <para>Represents the following attribute in the schema: offset2 </para>
    /// </summary>
    [SchemaAttr(0, "offset2")]
    public StringValue Offset2
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Origin.</para>
    /// <para>Represents the following attribute in the schema: origin </para>
    /// </summary>
    [SchemaAttr(0, "origin")]
    public StringValue Origin
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Shadow Perspective Matrix.</para>
    /// <para>Represents the following attribute in the schema: matrix </para>
    /// </summary>
    [SchemaAttr(0, "matrix")]
    public StringValue Matrix
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Shadow class.
    /// </summary>
    public Shadow():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "on" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues>();
    
if( 0 == namespaceId && "obscured" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "color" == name)
    return new StringValue();
    
if( 0 == namespaceId && "opacity" == name)
    return new StringValue();
    
if( 0 == namespaceId && "offset" == name)
    return new StringValue();
    
if( 0 == namespaceId && "color2" == name)
    return new StringValue();
    
if( 0 == namespaceId && "offset2" == name)
    return new StringValue();
    
if( 0 == namespaceId && "origin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "matrix" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Shadow>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TextBox Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:textbox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Wordprocessing.TextBoxContent &lt;w:txbxContent></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.TextBoxContent))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TextBox : OpenXmlCompositeElement
{
    private const string tagName = "textbox";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12583;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","inset","singleclick" };
    private static byte[] attributeNamespaceIds = { 0,0,0,27 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Text Box Inset.</para>
    /// <para>Represents the following attribute in the schema: inset </para>
    /// </summary>
    [SchemaAttr(0, "inset")]
    public StringValue Inset
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
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
        get { return (TrueFalseValue)Attributes[3]; }
        set { Attributes[3] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "inset" == name)
    return new StringValue();
    
if( 27 == namespaceId && "singleclick" == name)
    return new TrueFalseValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TextBox>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TextPath Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:textpath.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TextPath : OpenXmlLeafElement
{
    private const string tagName = "textpath";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12584;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","on","fitshape","fitpath","trim","xscale","string" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Text Path Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fit Toggle.</para>
    /// <para>Represents the following attribute in the schema: fitshape </para>
    /// </summary>
    [SchemaAttr(0, "fitshape")]
    public TrueFalseValue FitShape
    {
        get { return (TrueFalseValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Path Fit Toggle.</para>
    /// <para>Represents the following attribute in the schema: fitpath </para>
    /// </summary>
    [SchemaAttr(0, "fitpath")]
    public TrueFalseValue FitPath
    {
        get { return (TrueFalseValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Text Path Trim Toggle.</para>
    /// <para>Represents the following attribute in the schema: trim </para>
    /// </summary>
    [SchemaAttr(0, "trim")]
    public TrueFalseValue Trim
    {
        get { return (TrueFalseValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Text X-Scaling.</para>
    /// <para>Represents the following attribute in the schema: xscale </para>
    /// </summary>
    [SchemaAttr(0, "xscale")]
    public TrueFalseValue XScale
    {
        get { return (TrueFalseValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Text Path Text.</para>
    /// <para>Represents the following attribute in the schema: string </para>
    /// </summary>
    [SchemaAttr(0, "string")]
    public StringValue String
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TextPath class.
    /// </summary>
    public TextPath():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "on" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fitshape" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fitpath" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "trim" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "xscale" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "string" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TextPath>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ImageData Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:imagedata.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ImageData : OpenXmlLeafElement
{
    private const string tagName = "imagedata";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12585;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","chromakey","cropleft","croptop","cropright","cropbottom","gain","blacklevel","gamma","grayscale","bilevel","embosscolor","recolortarget","title","detectmouseclick","relid","id","pict","href" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,27,27,27,19,19,19 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Image Transparency Color.</para>
    /// <para>Represents the following attribute in the schema: chromakey </para>
    /// </summary>
    [SchemaAttr(0, "chromakey")]
    public StringValue ChromAKey
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Image Left Crop.</para>
    /// <para>Represents the following attribute in the schema: cropleft </para>
    /// </summary>
    [SchemaAttr(0, "cropleft")]
    public StringValue CropLeft
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Image Top Crop.</para>
    /// <para>Represents the following attribute in the schema: croptop </para>
    /// </summary>
    [SchemaAttr(0, "croptop")]
    public StringValue CropTop
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Image Right Crop.</para>
    /// <para>Represents the following attribute in the schema: cropright </para>
    /// </summary>
    [SchemaAttr(0, "cropright")]
    public StringValue CropRight
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Image Bottom Crop.</para>
    /// <para>Represents the following attribute in the schema: cropbottom </para>
    /// </summary>
    [SchemaAttr(0, "cropbottom")]
    public StringValue CropBottom
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Image Intensity.</para>
    /// <para>Represents the following attribute in the schema: gain </para>
    /// </summary>
    [SchemaAttr(0, "gain")]
    public StringValue Gain
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Image Brightness.</para>
    /// <para>Represents the following attribute in the schema: blacklevel </para>
    /// </summary>
    [SchemaAttr(0, "blacklevel")]
    public StringValue BlackLevel
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Image Gamma Correction.</para>
    /// <para>Represents the following attribute in the schema: gamma </para>
    /// </summary>
    [SchemaAttr(0, "gamma")]
    public StringValue Gamma
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Image Grayscale Toggle.</para>
    /// <para>Represents the following attribute in the schema: grayscale </para>
    /// </summary>
    [SchemaAttr(0, "grayscale")]
    public TrueFalseValue Grayscale
    {
        get { return (TrueFalseValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Image Bilevel Toggle.</para>
    /// <para>Represents the following attribute in the schema: bilevel </para>
    /// </summary>
    [SchemaAttr(0, "bilevel")]
    public TrueFalseValue BiLevel
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> Embossed Color.</para>
    /// <para>Represents the following attribute in the schema: embosscolor </para>
    /// </summary>
    [SchemaAttr(0, "embosscolor")]
    public StringValue EmbossColor
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> Black Recoloring Color.</para>
    /// <para>Represents the following attribute in the schema: recolortarget </para>
    /// </summary>
    [SchemaAttr(0, "recolortarget")]
    public StringValue RecolorTarget
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ImageData class.
    /// </summary>
    public ImageData():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "chromakey" == name)
    return new StringValue();
    
if( 0 == namespaceId && "cropleft" == name)
    return new StringValue();
    
if( 0 == namespaceId && "croptop" == name)
    return new StringValue();
    
if( 0 == namespaceId && "cropright" == name)
    return new StringValue();
    
if( 0 == namespaceId && "cropbottom" == name)
    return new StringValue();
    
if( 0 == namespaceId && "gain" == name)
    return new StringValue();
    
if( 0 == namespaceId && "blacklevel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "gamma" == name)
    return new StringValue();
    
if( 0 == namespaceId && "grayscale" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "bilevel" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "embosscolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "recolortarget" == name)
    return new StringValue();
    
if( 27 == namespaceId && "title" == name)
    return new StringValue();
    
if( 27 == namespaceId && "detectmouseclick" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "relid" == name)
    return new StringValue();
    
if( 19 == namespaceId && "id" == name)
    return new StringValue();
    
if( 19 == namespaceId && "pict" == name)
    return new StringValue();
    
if( 19 == namespaceId && "href" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ImageData>(deep);
    }

   
}
/// <summary>
/// <para>Shape Definition.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Shape : OpenXmlCompositeElement
{
    private const string tagName = "shape";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12586;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","href","target","class","title","alt","coordsize","coordorigin","wrapcoords","print","spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","bordertopcolor","borderleftcolor","borderbottomcolor","borderrightcolor","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","filled","fillcolor","stroked","strokecolor","strokeweight","insetpen","spt","connectortype","bwmode","bwpure","bwnormal","forcedash","oleicon","ole","preferrelative","cliptowrap","clip","type","adj","path","gfxdata","equationxml" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,0,0,0,27,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (TrueFalseValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (TrueFalseValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (TrueFalseValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (TrueFalseValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (SingleValue)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (TrueFalseValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
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
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
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
        get { return (IntegerValue)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (IntegerValue)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (IntegerValue)Attributes[32]; }
        set { Attributes[32] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39]; }
        set { Attributes[39] = value; }
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
        get { return (Int32Value)Attributes[40]; }
        set { Attributes[40] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41]; }
        set { Attributes[41] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42]; }
        set { Attributes[42] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43]; }
        set { Attributes[43] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44]; }
        set { Attributes[44] = value; }
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
        get { return (TrueFalseValue)Attributes[45]; }
        set { Attributes[45] = value; }
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
        get { return (TrueFalseValue)Attributes[46]; }
        set { Attributes[46] = value; }
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
        get { return (TrueFalseBlankValue)Attributes[47]; }
        set { Attributes[47] = value; }
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
        get { return (TrueFalseValue)Attributes[48]; }
        set { Attributes[48] = value; }
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
        get { return (TrueFalseValue)Attributes[49]; }
        set { Attributes[49] = value; }
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
        get { return (TrueFalseValue)Attributes[50]; }
        set { Attributes[50] = value; }
    }
    
    /// <summary>
    /// <para> Shape Type Reference.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[51]; }
        set { Attributes[51] = value; }
    }
    
    /// <summary>
    /// <para> Adjustment Parameters.</para>
    /// <para>Represents the following attribute in the schema: adj </para>
    /// </summary>
    [SchemaAttr(0, "adj")]
    public StringValue Adjustment
    {
        get { return (StringValue)Attributes[52]; }
        set { Attributes[52] = value; }
    }
    
    /// <summary>
    /// <para> Edge Path.</para>
    /// <para>Represents the following attribute in the schema: path </para>
    /// </summary>
    [SchemaAttr(0, "path")]
    public StringValue EdgePath
    {
        get { return (StringValue)Attributes[53]; }
        set { Attributes[53] = value; }
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
        get { return (Base64BinaryValue)Attributes[54]; }
        set { Attributes[54] = value; }
    }
    
    /// <summary>
    /// <para> Storage for Alternate Math Content.</para>
    /// <para>Represents the following attribute in the schema: equationxml </para>
    /// </summary>
    [SchemaAttr(0, "equationxml")]
    public StringValue EquationXml
    {
        get { return (StringValue)Attributes[55]; }
        set { Attributes[55] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "class" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordorigin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bordertopcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderleftcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderbottomcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderrightcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "filled" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroked" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "strokeweight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spt" == name)
    return new Int32Value();
    
if( 27 == namespaceId && "connectortype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "oleicon" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "ole" == name)
    return new TrueFalseBlankValue();
    
if( 27 == namespaceId && "preferrelative" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "cliptowrap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "clip" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "type" == name)
    return new StringValue();
    
if( 0 == namespaceId && "adj" == name)
    return new StringValue();
    
if( 0 == namespaceId && "path" == name)
    return new StringValue();
    
if( 27 == namespaceId && "gfxdata" == name)
    return new Base64BinaryValue();
    
if( 0 == namespaceId && "equationxml" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Shape>(deep);
    }

   
}
/// <summary>
/// <para>Shape Template.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Shapetype : OpenXmlCompositeElement
{
    private const string tagName = "shapetype";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12587;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","href","target","class","title","alt","coordsize","coordorigin","wrapcoords","print","spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","bordertopcolor","borderleftcolor","borderbottomcolor","borderrightcolor","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","filled","fillcolor","stroked","strokecolor","strokeweight","insetpen","spt","connectortype","bwmode","bwpure","bwnormal","forcedash","oleicon","ole","preferrelative","cliptowrap","clip","adj","path","master" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,0,0,27 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (TrueFalseValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (TrueFalseValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (TrueFalseValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (TrueFalseValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (SingleValue)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (TrueFalseValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
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
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
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
        get { return (IntegerValue)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (IntegerValue)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (IntegerValue)Attributes[32]; }
        set { Attributes[32] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39]; }
        set { Attributes[39] = value; }
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
        get { return (Int32Value)Attributes[40]; }
        set { Attributes[40] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41]; }
        set { Attributes[41] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42]; }
        set { Attributes[42] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43]; }
        set { Attributes[43] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44]; }
        set { Attributes[44] = value; }
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
        get { return (TrueFalseValue)Attributes[45]; }
        set { Attributes[45] = value; }
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
        get { return (TrueFalseValue)Attributes[46]; }
        set { Attributes[46] = value; }
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
        get { return (TrueFalseBlankValue)Attributes[47]; }
        set { Attributes[47] = value; }
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
        get { return (TrueFalseValue)Attributes[48]; }
        set { Attributes[48] = value; }
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
        get { return (TrueFalseValue)Attributes[49]; }
        set { Attributes[49] = value; }
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
        get { return (TrueFalseValue)Attributes[50]; }
        set { Attributes[50] = value; }
    }
    
    /// <summary>
    /// <para> Adjustment Parameters.</para>
    /// <para>Represents the following attribute in the schema: adj </para>
    /// </summary>
    [SchemaAttr(0, "adj")]
    public StringValue Adjustment
    {
        get { return (StringValue)Attributes[51]; }
        set { Attributes[51] = value; }
    }
    
    /// <summary>
    /// <para> Edge Path.</para>
    /// <para>Represents the following attribute in the schema: path </para>
    /// </summary>
    [SchemaAttr(0, "path")]
    public StringValue EdgePath
    {
        get { return (StringValue)Attributes[52]; }
        set { Attributes[52] = value; }
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
        get { return (StringValue)Attributes[53]; }
        set { Attributes[53] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "class" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordorigin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bordertopcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderleftcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderbottomcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderrightcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "filled" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroked" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "strokeweight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spt" == name)
    return new Int32Value();
    
if( 27 == namespaceId && "connectortype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "oleicon" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "ole" == name)
    return new TrueFalseBlankValue();
    
if( 27 == namespaceId && "preferrelative" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "cliptowrap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "clip" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "adj" == name)
    return new StringValue();
    
if( 0 == namespaceId && "path" == name)
    return new StringValue();
    
if( 27 == namespaceId && "master" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Shapetype>(deep);
    }

   
}
/// <summary>
/// <para>Shape Group.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Group : OpenXmlCompositeElement
{
    private const string tagName = "group";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12588;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","href","target","class","title","alt","coordsize","coordorigin","wrapcoords","print","spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","editas","tableproperties","tablelimits" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,27,27 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (TrueFalseValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (TrueFalseValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (TrueFalseValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (TrueFalseValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (SingleValue)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (TrueFalseValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (IntegerValue)Attributes[26]; }
        set { Attributes[26] = value; }
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
        get { return (IntegerValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
        get { return (IntegerValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> Group Diagram Type.</para>
    /// <para>Represents the following attribute in the schema: editas </para>
    /// </summary>
    [SchemaAttr(0, "editas")]
    public EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues> EditAs
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues>)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (StringValue)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (StringValue)Attributes[32]; }
        set { Attributes[32] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "class" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordorigin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "editas" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues>();
    
if( 27 == namespaceId && "tableproperties" == name)
    return new StringValue();
    
if( 27 == namespaceId && "tablelimits" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Group>(deep);
    }

   
}
/// <summary>
/// <para>Document Background.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:background.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Fill &lt;v:fill></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Fill))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Background : OpenXmlCompositeElement
{
    private const string tagName = "background";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12589;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","fill","fillcolor","bwmode","bwpure","bwnormal","targetscreensize" };
    private static byte[] attributeNamespaceIds = { 0,0,0,27,27,27,27 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: fill </para>
    /// </summary>
    [SchemaAttr(0, "fill")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue Fillcolor
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[3]; }
        set { Attributes[3] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[4]; }
        set { Attributes[4] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[5]; }
        set { Attributes[5] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues>)Attributes[6]; }
        set { Attributes[6] = value; }
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Fill.</para>
    /// <para> Represents the following element tag in the schema: v:fill </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public Fill Fill
    {
        get 
        {
            return GetElement<Fill>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "fill" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "targetscreensize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Background>(deep);
    }

   
}
/// <summary>
/// <para>Arc Segment.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Arc : OpenXmlCompositeElement
{
    private const string tagName = "arc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12590;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","bordertopcolor","borderleftcolor","borderbottomcolor","borderrightcolor","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","filled","fillcolor","stroked","strokecolor","strokeweight","insetpen","spt","connectortype","bwmode","bwpure","bwnormal","forcedash","oleicon","ole","preferrelative","cliptowrap","clip","id","style","href","target","title","alt","coordsize","coordorigin","wrapcoords","print","startangle","endangle" };
    private static byte[] attributeNamespaceIds = { 27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
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
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
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
        get { return (TrueFalseValue)Attributes[1]; }
        set { Attributes[1] = value; }
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
        get { return (IntegerValue)Attributes[2]; }
        set { Attributes[2] = value; }
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
        get { return (TrueFalseValue)Attributes[3]; }
        set { Attributes[3] = value; }
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
        get { return (TrueFalseValue)Attributes[4]; }
        set { Attributes[4] = value; }
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
        get { return (TrueFalseValue)Attributes[5]; }
        set { Attributes[5] = value; }
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
        get { return (TrueFalseValue)Attributes[6]; }
        set { Attributes[6] = value; }
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
        get { return (TrueFalseValue)Attributes[7]; }
        set { Attributes[7] = value; }
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
        get { return (TrueFalseValue)Attributes[8]; }
        set { Attributes[8] = value; }
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
        get { return (TrueFalseValue)Attributes[9]; }
        set { Attributes[9] = value; }
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
        get { return (SingleValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (TrueFalseValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (IntegerValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (IntegerValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (IntegerValue)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (Int32Value)Attributes[29]; }
        set { Attributes[29] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[32]; }
        set { Attributes[32] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[33]; }
        set { Attributes[33] = value; }
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
        get { return (TrueFalseValue)Attributes[34]; }
        set { Attributes[34] = value; }
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
        get { return (TrueFalseValue)Attributes[35]; }
        set { Attributes[35] = value; }
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
        get { return (TrueFalseBlankValue)Attributes[36]; }
        set { Attributes[36] = value; }
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
        get { return (TrueFalseValue)Attributes[37]; }
        set { Attributes[37] = value; }
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
        get { return (TrueFalseValue)Attributes[38]; }
        set { Attributes[38] = value; }
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
        get { return (TrueFalseValue)Attributes[39]; }
        set { Attributes[39] = value; }
    }
    
    /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[40]; }
        set { Attributes[40] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[41]; }
        set { Attributes[41] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[42]; }
        set { Attributes[42] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[43]; }
        set { Attributes[43] = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[44]; }
        set { Attributes[44] = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[45]; }
        set { Attributes[45] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[46]; }
        set { Attributes[46] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[47]; }
        set { Attributes[47] = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue Wrapcoords
    {
        get { return (StringValue)Attributes[48]; }
        set { Attributes[48] = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[49]; }
        set { Attributes[49] = value; }
    }
    
    /// <summary>
    /// <para> Starting Angle.</para>
    /// <para>Represents the following attribute in the schema: startangle </para>
    /// </summary>
    [SchemaAttr(0, "startangle")]
    public DecimalValue StartAngle
    {
        get { return (DecimalValue)Attributes[50]; }
        set { Attributes[50] = value; }
    }
    
    /// <summary>
    /// <para> Ending Angle.</para>
    /// <para>Represents the following attribute in the schema: endangle </para>
    /// </summary>
    [SchemaAttr(0, "endangle")]
    public DecimalValue EndAngle
    {
        get { return (DecimalValue)Attributes[51]; }
        set { Attributes[51] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bordertopcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderleftcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderbottomcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderrightcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "filled" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroked" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "strokeweight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spt" == name)
    return new Int32Value();
    
if( 27 == namespaceId && "connectortype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "oleicon" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "ole" == name)
    return new TrueFalseBlankValue();
    
if( 27 == namespaceId && "preferrelative" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "cliptowrap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "clip" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordorigin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "startangle" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "endangle" == name)
    return new DecimalValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Arc>(deep);
    }

   
}
/// <summary>
/// <para>Bezier Curve.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Curve : OpenXmlCompositeElement
{
    private const string tagName = "curve";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12591;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","href","target","class","title","alt","coordsize","coordorigin","wrapcoords","print","spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","bordertopcolor","borderleftcolor","borderbottomcolor","borderrightcolor","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","filled","fillcolor","stroked","strokecolor","strokeweight","insetpen","spt","connectortype","bwmode","bwpure","bwnormal","forcedash","oleicon","ole","preferrelative","cliptowrap","clip","from","control1","control2","to" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (TrueFalseValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (TrueFalseValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (TrueFalseValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (TrueFalseValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (SingleValue)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (TrueFalseValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
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
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
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
        get { return (IntegerValue)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (IntegerValue)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (IntegerValue)Attributes[32]; }
        set { Attributes[32] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39]; }
        set { Attributes[39] = value; }
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
        get { return (Int32Value)Attributes[40]; }
        set { Attributes[40] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41]; }
        set { Attributes[41] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42]; }
        set { Attributes[42] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43]; }
        set { Attributes[43] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44]; }
        set { Attributes[44] = value; }
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
        get { return (TrueFalseValue)Attributes[45]; }
        set { Attributes[45] = value; }
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
        get { return (TrueFalseValue)Attributes[46]; }
        set { Attributes[46] = value; }
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
        get { return (TrueFalseBlankValue)Attributes[47]; }
        set { Attributes[47] = value; }
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
        get { return (TrueFalseValue)Attributes[48]; }
        set { Attributes[48] = value; }
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
        get { return (TrueFalseValue)Attributes[49]; }
        set { Attributes[49] = value; }
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
        get { return (TrueFalseValue)Attributes[50]; }
        set { Attributes[50] = value; }
    }
    
    /// <summary>
    /// <para> Curve Starting Point.</para>
    /// <para>Represents the following attribute in the schema: from </para>
    /// </summary>
    [SchemaAttr(0, "from")]
    public StringValue From
    {
        get { return (StringValue)Attributes[51]; }
        set { Attributes[51] = value; }
    }
    
    /// <summary>
    /// <para> First Curve Control Point.</para>
    /// <para>Represents the following attribute in the schema: control1 </para>
    /// </summary>
    [SchemaAttr(0, "control1")]
    public StringValue Control1
    {
        get { return (StringValue)Attributes[52]; }
        set { Attributes[52] = value; }
    }
    
    /// <summary>
    /// <para> Second Curve Control Point.</para>
    /// <para>Represents the following attribute in the schema: control2 </para>
    /// </summary>
    [SchemaAttr(0, "control2")]
    public StringValue Control2
    {
        get { return (StringValue)Attributes[53]; }
        set { Attributes[53] = value; }
    }
    
    /// <summary>
    /// <para> Curve Ending Point.</para>
    /// <para>Represents the following attribute in the schema: to </para>
    /// </summary>
    [SchemaAttr(0, "to")]
    public StringValue To
    {
        get { return (StringValue)Attributes[54]; }
        set { Attributes[54] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "class" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordorigin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bordertopcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderleftcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderbottomcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderrightcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "filled" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroked" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "strokeweight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spt" == name)
    return new Int32Value();
    
if( 27 == namespaceId && "connectortype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "oleicon" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "ole" == name)
    return new TrueFalseBlankValue();
    
if( 27 == namespaceId && "preferrelative" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "cliptowrap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "clip" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "from" == name)
    return new StringValue();
    
if( 0 == namespaceId && "control1" == name)
    return new StringValue();
    
if( 0 == namespaceId && "control2" == name)
    return new StringValue();
    
if( 0 == namespaceId && "to" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Curve>(deep);
    }

   
}
/// <summary>
/// <para>Image File.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ImageFile : OpenXmlCompositeElement
{
    private const string tagName = "image";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12592;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","href","target","class","title","alt","coordsize","wrapcoords","print","spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","bordertopcolor","borderleftcolor","borderbottomcolor","borderrightcolor","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","filled","fillcolor","stroked","strokecolor","strokeweight","insetpen","spt","connectortype","bwmode","bwpure","bwnormal","forcedash","oleicon","ole","preferrelative","cliptowrap","clip","src","cropleft","croptop","cropright","cropbottom","gain","blacklevel","gamma","grayscale","bilevel" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> href.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> class.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> alt.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> coordsize.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> wrapcoords.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> print.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[9]; }
        set { Attributes[9] = value; }
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
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (TrueFalseValue)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (IntegerValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (TrueFalseValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (TrueFalseValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (TrueFalseValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (TrueFalseValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (SingleValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (TrueFalseValue)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
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
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (IntegerValue)Attributes[29]; }
        set { Attributes[29] = value; }
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
        get { return (IntegerValue)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (IntegerValue)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[38]; }
        set { Attributes[38] = value; }
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
        get { return (Int32Value)Attributes[39]; }
        set { Attributes[39] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[40]; }
        set { Attributes[40] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[41]; }
        set { Attributes[41] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42]; }
        set { Attributes[42] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43]; }
        set { Attributes[43] = value; }
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
        get { return (TrueFalseValue)Attributes[44]; }
        set { Attributes[44] = value; }
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
        get { return (TrueFalseValue)Attributes[45]; }
        set { Attributes[45] = value; }
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
        get { return (TrueFalseBlankValue)Attributes[46]; }
        set { Attributes[46] = value; }
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
        get { return (TrueFalseValue)Attributes[47]; }
        set { Attributes[47] = value; }
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
        get { return (TrueFalseValue)Attributes[48]; }
        set { Attributes[48] = value; }
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
        get { return (TrueFalseValue)Attributes[49]; }
        set { Attributes[49] = value; }
    }
    
    /// <summary>
    /// <para> Image Source.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[50]; }
        set { Attributes[50] = value; }
    }
    
    /// <summary>
    /// <para> Image Left Crop.</para>
    /// <para>Represents the following attribute in the schema: cropleft </para>
    /// </summary>
    [SchemaAttr(0, "cropleft")]
    public StringValue CropLeft
    {
        get { return (StringValue)Attributes[51]; }
        set { Attributes[51] = value; }
    }
    
    /// <summary>
    /// <para> Image Top Crop.</para>
    /// <para>Represents the following attribute in the schema: croptop </para>
    /// </summary>
    [SchemaAttr(0, "croptop")]
    public StringValue CropTop
    {
        get { return (StringValue)Attributes[52]; }
        set { Attributes[52] = value; }
    }
    
    /// <summary>
    /// <para> Image Right Crop.</para>
    /// <para>Represents the following attribute in the schema: cropright </para>
    /// </summary>
    [SchemaAttr(0, "cropright")]
    public StringValue CropRight
    {
        get { return (StringValue)Attributes[53]; }
        set { Attributes[53] = value; }
    }
    
    /// <summary>
    /// <para> Image Bottom Crop.</para>
    /// <para>Represents the following attribute in the schema: cropbottom </para>
    /// </summary>
    [SchemaAttr(0, "cropbottom")]
    public StringValue CropBottom
    {
        get { return (StringValue)Attributes[54]; }
        set { Attributes[54] = value; }
    }
    
    /// <summary>
    /// <para> Image Intensity.</para>
    /// <para>Represents the following attribute in the schema: gain </para>
    /// </summary>
    [SchemaAttr(0, "gain")]
    public StringValue Gain
    {
        get { return (StringValue)Attributes[55]; }
        set { Attributes[55] = value; }
    }
    
    /// <summary>
    /// <para> Image Brightness.</para>
    /// <para>Represents the following attribute in the schema: blacklevel </para>
    /// </summary>
    [SchemaAttr(0, "blacklevel")]
    public StringValue BlackLevel
    {
        get { return (StringValue)Attributes[56]; }
        set { Attributes[56] = value; }
    }
    
    /// <summary>
    /// <para> Image Gamma Correction.</para>
    /// <para>Represents the following attribute in the schema: gamma </para>
    /// </summary>
    [SchemaAttr(0, "gamma")]
    public StringValue Gamma
    {
        get { return (StringValue)Attributes[57]; }
        set { Attributes[57] = value; }
    }
    
    /// <summary>
    /// <para> Image Grayscale Toggle.</para>
    /// <para>Represents the following attribute in the schema: grayscale </para>
    /// </summary>
    [SchemaAttr(0, "grayscale")]
    public TrueFalseValue GrayScale
    {
        get { return (TrueFalseValue)Attributes[58]; }
        set { Attributes[58] = value; }
    }
    
    /// <summary>
    /// <para> Image Bilevel Toggle.</para>
    /// <para>Represents the following attribute in the schema: bilevel </para>
    /// </summary>
    [SchemaAttr(0, "bilevel")]
    public TrueFalseValue BiLevel
    {
        get { return (TrueFalseValue)Attributes[59]; }
        set { Attributes[59] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "class" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bordertopcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderleftcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderbottomcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderrightcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "filled" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroked" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "strokeweight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spt" == name)
    return new Int32Value();
    
if( 27 == namespaceId && "connectortype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "oleicon" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "ole" == name)
    return new TrueFalseBlankValue();
    
if( 27 == namespaceId && "preferrelative" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "cliptowrap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "clip" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "src" == name)
    return new StringValue();
    
if( 0 == namespaceId && "cropleft" == name)
    return new StringValue();
    
if( 0 == namespaceId && "croptop" == name)
    return new StringValue();
    
if( 0 == namespaceId && "cropright" == name)
    return new StringValue();
    
if( 0 == namespaceId && "cropbottom" == name)
    return new StringValue();
    
if( 0 == namespaceId && "gain" == name)
    return new StringValue();
    
if( 0 == namespaceId && "blacklevel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "gamma" == name)
    return new StringValue();
    
if( 0 == namespaceId && "grayscale" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "bilevel" == name)
    return new TrueFalseValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ImageFile>(deep);
    }

   
}
/// <summary>
/// <para>Line.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Line : OpenXmlCompositeElement
{
    private const string tagName = "line";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12593;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","href","target","class","title","alt","coordsize","coordorigin","wrapcoords","print","spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","bordertopcolor","borderleftcolor","borderbottomcolor","borderrightcolor","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","filled","fillcolor","stroked","strokecolor","strokeweight","insetpen","spt","connectortype","bwmode","bwpure","bwnormal","forcedash","oleicon","ole","preferrelative","cliptowrap","clip","from","to" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (TrueFalseValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (TrueFalseValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (TrueFalseValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (TrueFalseValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (SingleValue)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (TrueFalseValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
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
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
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
        get { return (IntegerValue)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (IntegerValue)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (IntegerValue)Attributes[32]; }
        set { Attributes[32] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39]; }
        set { Attributes[39] = value; }
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
        get { return (Int32Value)Attributes[40]; }
        set { Attributes[40] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41]; }
        set { Attributes[41] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42]; }
        set { Attributes[42] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43]; }
        set { Attributes[43] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44]; }
        set { Attributes[44] = value; }
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
        get { return (TrueFalseValue)Attributes[45]; }
        set { Attributes[45] = value; }
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
        get { return (TrueFalseValue)Attributes[46]; }
        set { Attributes[46] = value; }
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
        get { return (TrueFalseBlankValue)Attributes[47]; }
        set { Attributes[47] = value; }
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
        get { return (TrueFalseValue)Attributes[48]; }
        set { Attributes[48] = value; }
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
        get { return (TrueFalseValue)Attributes[49]; }
        set { Attributes[49] = value; }
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
        get { return (TrueFalseValue)Attributes[50]; }
        set { Attributes[50] = value; }
    }
    
    /// <summary>
    /// <para> Line Start.</para>
    /// <para>Represents the following attribute in the schema: from </para>
    /// </summary>
    [SchemaAttr(0, "from")]
    public StringValue From
    {
        get { return (StringValue)Attributes[51]; }
        set { Attributes[51] = value; }
    }
    
    /// <summary>
    /// <para> Line End Point.</para>
    /// <para>Represents the following attribute in the schema: to </para>
    /// </summary>
    [SchemaAttr(0, "to")]
    public StringValue To
    {
        get { return (StringValue)Attributes[52]; }
        set { Attributes[52] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "class" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordorigin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bordertopcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderleftcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderbottomcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderrightcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "filled" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroked" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "strokeweight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spt" == name)
    return new Int32Value();
    
if( 27 == namespaceId && "connectortype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "oleicon" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "ole" == name)
    return new TrueFalseBlankValue();
    
if( 27 == namespaceId && "preferrelative" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "cliptowrap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "clip" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "from" == name)
    return new StringValue();
    
if( 0 == namespaceId && "to" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Line>(deep);
    }

   
}
/// <summary>
/// <para>Oval.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Oval : OpenXmlCompositeElement
{
    private const string tagName = "oval";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12594;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","href","target","class","title","alt","coordsize","coordorigin","wrapcoords","print","spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","bordertopcolor","borderleftcolor","borderbottomcolor","borderrightcolor","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","filled","fillcolor","stroked","strokecolor","strokeweight","insetpen","spt","connectortype","bwmode","bwpure","bwnormal","forcedash","oleicon","ole","preferrelative","cliptowrap","clip" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (TrueFalseValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (TrueFalseValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (TrueFalseValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (TrueFalseValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (SingleValue)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (TrueFalseValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
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
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
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
        get { return (IntegerValue)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (IntegerValue)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (IntegerValue)Attributes[32]; }
        set { Attributes[32] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39]; }
        set { Attributes[39] = value; }
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
        get { return (Int32Value)Attributes[40]; }
        set { Attributes[40] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41]; }
        set { Attributes[41] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42]; }
        set { Attributes[42] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43]; }
        set { Attributes[43] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44]; }
        set { Attributes[44] = value; }
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
        get { return (TrueFalseValue)Attributes[45]; }
        set { Attributes[45] = value; }
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
        get { return (TrueFalseValue)Attributes[46]; }
        set { Attributes[46] = value; }
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
        get { return (TrueFalseBlankValue)Attributes[47]; }
        set { Attributes[47] = value; }
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
        get { return (TrueFalseValue)Attributes[48]; }
        set { Attributes[48] = value; }
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
        get { return (TrueFalseValue)Attributes[49]; }
        set { Attributes[49] = value; }
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
        get { return (TrueFalseValue)Attributes[50]; }
        set { Attributes[50] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "class" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordorigin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bordertopcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderleftcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderbottomcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderrightcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "filled" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroked" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "strokeweight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spt" == name)
    return new Int32Value();
    
if( 27 == namespaceId && "connectortype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "oleicon" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "ole" == name)
    return new TrueFalseBlankValue();
    
if( 27 == namespaceId && "preferrelative" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "cliptowrap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "clip" == name)
    return new TrueFalseValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Oval>(deep);
    }

   
}
/// <summary>
/// <para>Multiple Path Line.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PolyLine : OpenXmlCompositeElement
{
    private const string tagName = "polyline";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12595;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","href","target","class","title","alt","coordsize","coordorigin","wrapcoords","print","spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","bordertopcolor","borderleftcolor","borderbottomcolor","borderrightcolor","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","filled","fillcolor","stroked","strokecolor","strokeweight","insetpen","spt","connectortype","bwmode","bwpure","bwnormal","forcedash","oleicon","ole","preferrelative","cliptowrap","clip","points" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (TrueFalseValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (TrueFalseValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (TrueFalseValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (TrueFalseValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (SingleValue)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (TrueFalseValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
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
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
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
        get { return (IntegerValue)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (IntegerValue)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (IntegerValue)Attributes[32]; }
        set { Attributes[32] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39]; }
        set { Attributes[39] = value; }
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
        get { return (Int32Value)Attributes[40]; }
        set { Attributes[40] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41]; }
        set { Attributes[41] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42]; }
        set { Attributes[42] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43]; }
        set { Attributes[43] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44]; }
        set { Attributes[44] = value; }
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
        get { return (TrueFalseValue)Attributes[45]; }
        set { Attributes[45] = value; }
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
        get { return (TrueFalseValue)Attributes[46]; }
        set { Attributes[46] = value; }
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
        get { return (TrueFalseBlankValue)Attributes[47]; }
        set { Attributes[47] = value; }
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
        get { return (TrueFalseValue)Attributes[48]; }
        set { Attributes[48] = value; }
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
        get { return (TrueFalseValue)Attributes[49]; }
        set { Attributes[49] = value; }
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
        get { return (TrueFalseValue)Attributes[50]; }
        set { Attributes[50] = value; }
    }
    
    /// <summary>
    /// <para> Points for Compound Line.</para>
    /// <para>Represents the following attribute in the schema: points </para>
    /// </summary>
    [SchemaAttr(0, "points")]
    public StringValue Points
    {
        get { return (StringValue)Attributes[51]; }
        set { Attributes[51] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "class" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordorigin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bordertopcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderleftcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderbottomcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderrightcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "filled" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroked" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "strokeweight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spt" == name)
    return new Int32Value();
    
if( 27 == namespaceId && "connectortype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "oleicon" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "ole" == name)
    return new TrueFalseBlankValue();
    
if( 27 == namespaceId && "preferrelative" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "cliptowrap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "clip" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "points" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PolyLine>(deep);
    }

   
}
/// <summary>
/// <para>Rectangle.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Rectangle : OpenXmlCompositeElement
{
    private const string tagName = "rect";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12596;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","href","target","class","title","alt","coordsize","coordorigin","wrapcoords","print","spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","bordertopcolor","borderleftcolor","borderbottomcolor","borderrightcolor","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","filled","fillcolor","stroked","strokecolor","strokeweight","insetpen","spt","connectortype","bwmode","bwpure","bwnormal","forcedash","oleicon","ole","preferrelative","cliptowrap","clip" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Styling Properties.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Target.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink Display Target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> CSS Reference.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Shape Title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Alternate Text.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Size.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Coordinate Space Origin.</para>
    /// <para>Represents the following attribute in the schema: coordorigin </para>
    /// </summary>
    [SchemaAttr(0, "coordorigin")]
    public StringValue CoordinateOrigin
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Shape Bounding Polygon.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Print Toggle.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (IntegerValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (TrueFalseValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (TrueFalseValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (TrueFalseValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (TrueFalseValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (SingleValue)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (TrueFalseValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
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
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
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
        get { return (IntegerValue)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (IntegerValue)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (IntegerValue)Attributes[32]; }
        set { Attributes[32] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[39]; }
        set { Attributes[39] = value; }
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
        get { return (Int32Value)Attributes[40]; }
        set { Attributes[40] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[41]; }
        set { Attributes[41] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42]; }
        set { Attributes[42] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43]; }
        set { Attributes[43] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[44]; }
        set { Attributes[44] = value; }
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
        get { return (TrueFalseValue)Attributes[45]; }
        set { Attributes[45] = value; }
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
        get { return (TrueFalseValue)Attributes[46]; }
        set { Attributes[46] = value; }
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
        get { return (TrueFalseBlankValue)Attributes[47]; }
        set { Attributes[47] = value; }
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
        get { return (TrueFalseValue)Attributes[48]; }
        set { Attributes[48] = value; }
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
        get { return (TrueFalseValue)Attributes[49]; }
        set { Attributes[49] = value; }
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
        get { return (TrueFalseValue)Attributes[50]; }
        set { Attributes[50] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "class" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordorigin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bordertopcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderleftcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderbottomcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderrightcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "filled" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroked" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "strokeweight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spt" == name)
    return new Int32Value();
    
if( 27 == namespaceId && "connectortype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "oleicon" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "ole" == name)
    return new TrueFalseBlankValue();
    
if( 27 == namespaceId && "preferrelative" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "cliptowrap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "clip" == name)
    return new TrueFalseValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Rectangle>(deep);
    }

   
}
/// <summary>
/// <para>Rounded Rectangle.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RoundRectangle : OpenXmlCompositeElement
{
    private const string tagName = "roundrect";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12597;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","style","href","target","class","title","alt","coordsize","wrapcoords","print","spid","oned","regroupid","doubleclicknotify","button","userhidden","bullet","hr","hrstd","hrnoshade","hrpct","hralign","allowincell","allowoverlap","userdrawn","bordertopcolor","borderleftcolor","borderbottomcolor","borderrightcolor","dgmlayout","dgmnodekind","dgmlayoutmru","insetmode","filled","fillcolor","stroked","strokecolor","strokeweight","insetpen","spt","connectortype","bwmode","bwpure","bwnormal","forcedash","oleicon","ole","preferrelative","cliptowrap","clip","arcsize" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,27,0,0,0,0,0,0,27,27,27,27,27,27,27,27,27,27,27,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> href.</para>
    /// <para>Represents the following attribute in the schema: href </para>
    /// </summary>
    [SchemaAttr(0, "href")]
    public StringValue Href
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> class.</para>
    /// <para>Represents the following attribute in the schema: class </para>
    /// </summary>
    [SchemaAttr(0, "class")]
    public StringValue Class
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> alt.</para>
    /// <para>Represents the following attribute in the schema: alt </para>
    /// </summary>
    [SchemaAttr(0, "alt")]
    public StringValue Alternate
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> coordsize.</para>
    /// <para>Represents the following attribute in the schema: coordsize </para>
    /// </summary>
    [SchemaAttr(0, "coordsize")]
    public StringValue CoordinateSize
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> wrapcoords.</para>
    /// <para>Represents the following attribute in the schema: wrapcoords </para>
    /// </summary>
    [SchemaAttr(0, "wrapcoords")]
    public StringValue WrapCoordinates
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> print.</para>
    /// <para>Represents the following attribute in the schema: print </para>
    /// </summary>
    [SchemaAttr(0, "print")]
    public TrueFalseValue Print
    {
        get { return (TrueFalseValue)Attributes[9]; }
        set { Attributes[9] = value; }
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
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
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
        get { return (TrueFalseValue)Attributes[11]; }
        set { Attributes[11] = value; }
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
        get { return (IntegerValue)Attributes[12]; }
        set { Attributes[12] = value; }
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
        get { return (TrueFalseValue)Attributes[13]; }
        set { Attributes[13] = value; }
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
        get { return (TrueFalseValue)Attributes[14]; }
        set { Attributes[14] = value; }
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
        get { return (TrueFalseValue)Attributes[15]; }
        set { Attributes[15] = value; }
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
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
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
        get { return (TrueFalseValue)Attributes[17]; }
        set { Attributes[17] = value; }
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
        get { return (TrueFalseValue)Attributes[18]; }
        set { Attributes[18] = value; }
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
        get { return (TrueFalseValue)Attributes[19]; }
        set { Attributes[19] = value; }
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
        get { return (SingleValue)Attributes[20]; }
        set { Attributes[20] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>)Attributes[21]; }
        set { Attributes[21] = value; }
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
        get { return (TrueFalseValue)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (TrueFalseValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
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
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
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
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
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
        get { return (IntegerValue)Attributes[29]; }
        set { Attributes[29] = value; }
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
        get { return (IntegerValue)Attributes[30]; }
        set { Attributes[30] = value; }
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
        get { return (IntegerValue)Attributes[31]; }
        set { Attributes[31] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: filled </para>
    /// </summary>
    [SchemaAttr(0, "filled")]
    public TrueFalseValue Filled
    {
        get { return (TrueFalseValue)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroked </para>
    /// </summary>
    [SchemaAttr(0, "stroked")]
    public TrueFalseValue Stroked
    {
        get { return (TrueFalseValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Weight.</para>
    /// <para>Represents the following attribute in the schema: strokeweight </para>
    /// </summary>
    [SchemaAttr(0, "strokeweight")]
    public StringValue StrokeWeight
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[38]; }
        set { Attributes[38] = value; }
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
        get { return (Int32Value)Attributes[39]; }
        set { Attributes[39] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>)Attributes[40]; }
        set { Attributes[40] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[41]; }
        set { Attributes[41] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[42]; }
        set { Attributes[42] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>)Attributes[43]; }
        set { Attributes[43] = value; }
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
        get { return (TrueFalseValue)Attributes[44]; }
        set { Attributes[44] = value; }
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
        get { return (TrueFalseValue)Attributes[45]; }
        set { Attributes[45] = value; }
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
        get { return (TrueFalseBlankValue)Attributes[46]; }
        set { Attributes[46] = value; }
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
        get { return (TrueFalseValue)Attributes[47]; }
        set { Attributes[47] = value; }
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
        get { return (TrueFalseValue)Attributes[48]; }
        set { Attributes[48] = value; }
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
        get { return (TrueFalseValue)Attributes[49]; }
        set { Attributes[49] = value; }
    }
    
    /// <summary>
    /// <para> Rounded Corner Arc Size.</para>
    /// <para>Represents the following attribute in the schema: arcsize </para>
    /// </summary>
    [SchemaAttr(0, "arcsize")]
    public StringValue ArcSize
    {
        get { return (StringValue)Attributes[50]; }
        set { Attributes[50] = value; }
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

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "href" == name)
    return new StringValue();
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "class" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coordsize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "wrapcoords" == name)
    return new StringValue();
    
if( 0 == namespaceId && "print" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spid" == name)
    return new StringValue();
    
if( 27 == namespaceId && "oned" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "regroupid" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "doubleclicknotify" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "button" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userhidden" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bullet" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hr" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrstd" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrnoshade" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "hrpct" == name)
    return new SingleValue();
    
if( 27 == namespaceId && "hralign" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "userdrawn" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "bordertopcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderleftcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderbottomcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "borderrightcolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "dgmlayout" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmnodekind" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "dgmlayoutmru" == name)
    return new IntegerValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    
if( 0 == namespaceId && "filled" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroked" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "strokeweight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "spt" == name)
    return new Int32Value();
    
if( 27 == namespaceId && "connectortype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>();
    
if( 27 == namespaceId && "bwmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwpure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "bwnormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>();
    
if( 27 == namespaceId && "forcedash" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "oleicon" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "ole" == name)
    return new TrueFalseBlankValue();
    
if( 27 == namespaceId && "preferrelative" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "cliptowrap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "clip" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "arcsize" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RoundRectangle>(deep);
    }

   
}
/// <summary>
/// <para>Shape Handle.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:h.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ShapeHandle : OpenXmlLeafElement
{
    private const string tagName = "h";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12598;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "position","polar","map","invx","invy","switch","xrange","yrange","radiusrange" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Handle Position.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    public StringValue Position
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Handle Polar Center.</para>
    /// <para>Represents the following attribute in the schema: polar </para>
    /// </summary>
    [SchemaAttr(0, "polar")]
    public StringValue Polar
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Handle Coordinate Mapping.</para>
    /// <para>Represents the following attribute in the schema: map </para>
    /// </summary>
    [SchemaAttr(0, "map")]
    public StringValue Map
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Invert Handle's X Position.</para>
    /// <para>Represents the following attribute in the schema: invx </para>
    /// </summary>
    [SchemaAttr(0, "invx")]
    public TrueFalseBlankValue InvertX
    {
        get { return (TrueFalseBlankValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Invert Handle's Y Position.</para>
    /// <para>Represents the following attribute in the schema: invy </para>
    /// </summary>
    [SchemaAttr(0, "invy")]
    public TrueFalseBlankValue InvertY
    {
        get { return (TrueFalseBlankValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Handle Inversion Toggle.</para>
    /// <para>Represents the following attribute in the schema: switch </para>
    /// </summary>
    [SchemaAttr(0, "switch")]
    public TrueFalseBlankValue Switch
    {
        get { return (TrueFalseBlankValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Handle X Position Range.</para>
    /// <para>Represents the following attribute in the schema: xrange </para>
    /// </summary>
    [SchemaAttr(0, "xrange")]
    public StringValue XRange
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Handle Y Position Range.</para>
    /// <para>Represents the following attribute in the schema: yrange </para>
    /// </summary>
    [SchemaAttr(0, "yrange")]
    public StringValue YRange
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Handle Polar Radius Range.</para>
    /// <para>Represents the following attribute in the schema: radiusrange </para>
    /// </summary>
    [SchemaAttr(0, "radiusrange")]
    public StringValue RadiusRange
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShapeHandle class.
    /// </summary>
    public ShapeHandle():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "position" == name)
    return new StringValue();
    
if( 0 == namespaceId && "polar" == name)
    return new StringValue();
    
if( 0 == namespaceId && "map" == name)
    return new StringValue();
    
if( 0 == namespaceId && "invx" == name)
    return new TrueFalseBlankValue();
    
if( 0 == namespaceId && "invy" == name)
    return new TrueFalseBlankValue();
    
if( 0 == namespaceId && "switch" == name)
    return new TrueFalseBlankValue();
    
if( 0 == namespaceId && "xrange" == name)
    return new StringValue();
    
if( 0 == namespaceId && "yrange" == name)
    return new StringValue();
    
if( 0 == namespaceId && "radiusrange" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ShapeHandle>(deep);
    }

   
}
/// <summary>
/// <para>Single Formula.</para>
/// <para> When the object is serialized out as xml, its qualified name is v:f.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Formula : OpenXmlLeafElement
{
    private const string tagName = "f";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 26;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12599;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "eqn" };
    private static byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Equation.</para>
    /// <para>Represents the following attribute in the schema: eqn </para>
    /// </summary>
    [SchemaAttr(0, "eqn")]
    public StringValue Equation
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Formula class.
    /// </summary>
    public Formula():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "eqn" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Formula>(deep);
    }

   
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
 
 
