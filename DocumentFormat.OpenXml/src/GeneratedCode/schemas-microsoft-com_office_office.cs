﻿// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Vml;

namespace DocumentFormat.OpenXml.Vml.Office
{
/// <summary>
/// <para>New Shape Defaults.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:shapedefaults.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Vml.Fill &lt;v:fill></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.ImageData &lt;v:imagedata></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Stroke &lt;v:stroke></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.TextBox &lt;v:textbox></description></item>
///<item><description>DocumentFormat.OpenXml.Vml.Shadow &lt;v:shadow></description></item>
///<item><description>Skew &lt;o:skew></description></item>
///<item><description>Extrusion &lt;o:extrusion></description></item>
///<item><description>Callout &lt;o:callout></description></item>
///<item><description>Lock &lt;o:lock></description></item>
///<item><description>ColorMostRecentlyUsed &lt;o:colormru></description></item>
///<item><description>ColorMenu &lt;o:colormenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Fill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.ImageData))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Stroke))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.TextBox))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Vml.Shadow))]
    [ChildElementInfo(typeof(Skew))]
    [ChildElementInfo(typeof(Extrusion))]
    [ChildElementInfo(typeof(Callout))]
    [ChildElementInfo(typeof(Lock))]
    [ChildElementInfo(typeof(ColorMostRecentlyUsed))]
    [ChildElementInfo(typeof(ColorMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ShapeDefaults : OpenXmlCompositeElement
{
    private const string tagName = "shapedefaults";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12470;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","spidmax","style","fill","fillcolor","stroke","strokecolor","allowincell","allowoverlap","insetmode" };
    private static byte[] attributeNamespaceIds = { 26,0,0,0,0,0,0,27,27,27 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape ID Optional Storage.</para>
    /// <para>Represents the following attribute in the schema: spidmax </para>
    /// </summary>
    [SchemaAttr(0, "spidmax")]
    public IntegerValue MaxShapeId
    {
        get { return (IntegerValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Shape Fill Toggle.</para>
    /// <para>Represents the following attribute in the schema: fill </para>
    /// </summary>
    [SchemaAttr(0, "fill")]
    public TrueFalseValue BeFilled
    {
        get { return (TrueFalseValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Default Fill Color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Toggle.</para>
    /// <para>Represents the following attribute in the schema: stroke </para>
    /// </summary>
    [SchemaAttr(0, "stroke")]
    public TrueFalseValue IsStroke
    {
        get { return (TrueFalseValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Shape Stroke Color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
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
        get { return (TrueFalseValue)Attributes[7]; }
        set { Attributes[7] = value; }
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
        get { return (TrueFalseValue)Attributes[8]; }
        set { Attributes[8] = value; }
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
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShapeDefaults class.
    /// </summary>
    public ShapeDefaults():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ShapeDefaults class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeDefaults(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeDefaults class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeDefaults(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeDefaults class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeDefaults(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "fill" == name)
    return new DocumentFormat.OpenXml.Vml.Fill();
    
if( 26 == namespaceId && "imagedata" == name)
    return new DocumentFormat.OpenXml.Vml.ImageData();
    
if( 26 == namespaceId && "stroke" == name)
    return new DocumentFormat.OpenXml.Vml.Stroke();
    
if( 26 == namespaceId && "textbox" == name)
    return new DocumentFormat.OpenXml.Vml.TextBox();
    
if( 26 == namespaceId && "shadow" == name)
    return new DocumentFormat.OpenXml.Vml.Shadow();
    
if( 27 == namespaceId && "skew" == name)
    return new Skew();
    
if( 27 == namespaceId && "extrusion" == name)
    return new Extrusion();
    
if( 27 == namespaceId && "callout" == name)
    return new Callout();
    
if( 27 == namespaceId && "lock" == name)
    return new Lock();
    
if( 27 == namespaceId && "colormru" == name)
    return new ColorMostRecentlyUsed();
    
if( 27 == namespaceId && "colormenu" == name)
    return new ColorMenu();
    

    return null;
}

        private static readonly string[] eleTagNames = { "fill","imagedata","stroke","textbox","shadow","skew","extrusion","callout","lock","colormru","colormenu" };
    private static readonly byte[] eleNamespaceIds = { 26,26,26,26,26,27,27,27,27,27,27 };
    
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
        get {return OpenXmlCompositeType.OneAll;}
    }
    
        /// <summary>
    /// <para> Fill.</para>
    /// <para> Represents the following element tag in the schema: v:fill </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Fill Fill
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.Fill>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ImageData.</para>
    /// <para> Represents the following element tag in the schema: v:imagedata </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public DocumentFormat.OpenXml.Vml.ImageData ImageData
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.ImageData>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Stroke.</para>
    /// <para> Represents the following element tag in the schema: v:stroke </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Stroke Stroke
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.Stroke>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> TextBox.</para>
    /// <para> Represents the following element tag in the schema: v:textbox </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public DocumentFormat.OpenXml.Vml.TextBox TextBox
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.TextBox>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Shadow.</para>
    /// <para> Represents the following element tag in the schema: v:shadow </para>
    /// </summary>
    /// <remark>
    /// xmlns:v = urn:schemas-microsoft-com:vml
    /// </remark>
    public DocumentFormat.OpenXml.Vml.Shadow Shadow
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Vml.Shadow>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> Skew.</para>
    /// <para> Represents the following element tag in the schema: o:skew </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public Skew Skew
    {
        get 
        {
            return GetElement<Skew>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }
    /// <summary>
    /// <para> Extrusion.</para>
    /// <para> Represents the following element tag in the schema: o:extrusion </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public Extrusion Extrusion
    {
        get 
        {
            return GetElement<Extrusion>(6);
        }
        set
        {
            SetElement(6, value);
        }
    }
    /// <summary>
    /// <para> Callout.</para>
    /// <para> Represents the following element tag in the schema: o:callout </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public Callout Callout
    {
        get 
        {
            return GetElement<Callout>(7);
        }
        set
        {
            SetElement(7, value);
        }
    }
    /// <summary>
    /// <para> Shape Protections.</para>
    /// <para> Represents the following element tag in the schema: o:lock </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public Lock Lock
    {
        get 
        {
            return GetElement<Lock>(8);
        }
        set
        {
            SetElement(8, value);
        }
    }
    /// <summary>
    /// <para> Most Recently Used Colors.</para>
    /// <para> Represents the following element tag in the schema: o:colormru </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public ColorMostRecentlyUsed ColorMostRecentlyUsed
    {
        get 
        {
            return GetElement<ColorMostRecentlyUsed>(9);
        }
        set
        {
            SetElement(9, value);
        }
    }
    /// <summary>
    /// <para> UI Default Colors.</para>
    /// <para> Represents the following element tag in the schema: o:colormenu </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public ColorMenu ColorMenu
    {
        get 
        {
            return GetElement<ColorMenu>(10);
        }
        set
        {
            SetElement(10, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "spidmax" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "style" == name)
    return new StringValue();
    
if( 0 == namespaceId && "fill" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "stroke" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 27 == namespaceId && "allowincell" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "allowoverlap" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "insetmode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ShapeDefaults>(deep);
    }

   
}
/// <summary>
/// <para>Shape Layout Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:shapelayout.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeIdMap &lt;o:idmap></description></item>
///<item><description>RegroupTable &lt;o:regrouptable></description></item>
///<item><description>Rules &lt;o:rules></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ShapeIdMap))]
    [ChildElementInfo(typeof(RegroupTable))]
    [ChildElementInfo(typeof(Rules))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ShapeLayout : OpenXmlCompositeElement
{
    private const string tagName = "shapelayout";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12471;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext" };
    private static byte[] attributeNamespaceIds = { 26 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShapeLayout class.
    /// </summary>
    public ShapeLayout():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ShapeLayout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeLayout(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeLayout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeLayout(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeLayout class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeLayout(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "idmap" == name)
    return new ShapeIdMap();
    
if( 27 == namespaceId && "regrouptable" == name)
    return new RegroupTable();
    
if( 27 == namespaceId && "rules" == name)
    return new Rules();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idmap","regrouptable","rules" };
    private static readonly byte[] eleNamespaceIds = { 27,27,27 };
    
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
        get {return OpenXmlCompositeType.OneAll;}
    }
    
        /// <summary>
    /// <para> Shape ID Map.</para>
    /// <para> Represents the following element tag in the schema: o:idmap </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public ShapeIdMap ShapeIdMap
    {
        get 
        {
            return GetElement<ShapeIdMap>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Shape Grouping History.</para>
    /// <para> Represents the following element tag in the schema: o:regrouptable </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public RegroupTable RegroupTable
    {
        get 
        {
            return GetElement<RegroupTable>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Rule Set.</para>
    /// <para> Represents the following element tag in the schema: o:rules </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public Rules Rules
    {
        get 
        {
            return GetElement<Rules>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ShapeLayout>(deep);
    }

   
}
/// <summary>
/// <para>Digital Signature Line.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:signatureline.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SignatureLine : OpenXmlLeafElement
{
    private const string tagName = "signatureline";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12472;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","issignatureline","id","provid","signinginstructionsset","allowcomments","showsigndate","suggestedsigner","suggestedsigner2","suggestedsigneremail","signinginstructions","addlxml","sigprovurl" };
    private static byte[] attributeNamespaceIds = { 26,0,0,0,0,0,0,27,27,27,0,0,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Signature Line Flag.</para>
    /// <para>Represents the following attribute in the schema: issignatureline </para>
    /// </summary>
    [SchemaAttr(0, "issignatureline")]
    public TrueFalseValue IsSignatureLine
    {
        get { return (TrueFalseValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Unique ID.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Signature Provider ID.</para>
    /// <para>Represents the following attribute in the schema: provid </para>
    /// </summary>
    [SchemaAttr(0, "provid")]
    public StringValue ProviderId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Use Signing Instructions Flag.</para>
    /// <para>Represents the following attribute in the schema: signinginstructionsset </para>
    /// </summary>
    [SchemaAttr(0, "signinginstructionsset")]
    public TrueFalseValue SigningInstructionsSet
    {
        get { return (TrueFalseValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> User-specified Comments Flag.</para>
    /// <para>Represents the following attribute in the schema: allowcomments </para>
    /// </summary>
    [SchemaAttr(0, "allowcomments")]
    public TrueFalseValue AllowComments
    {
        get { return (TrueFalseValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Show Signed Date Flag.</para>
    /// <para>Represents the following attribute in the schema: showsigndate </para>
    /// </summary>
    [SchemaAttr(0, "showsigndate")]
    public TrueFalseValue ShowSignDate
    {
        get { return (TrueFalseValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Suggested Signer Line 1.</para>
    /// <para>Represents the following attribute in the schema: o:suggestedsigner </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "suggestedsigner")]
    public StringValue SuggestedSigner
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Suggested Signer Line 2.</para>
    /// <para>Represents the following attribute in the schema: o:suggestedsigner2 </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "suggestedsigner2")]
    public StringValue SuggestedSigner2
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Suggested Signer E-mail Address.</para>
    /// <para>Represents the following attribute in the schema: o:suggestedsigneremail </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "suggestedsigneremail")]
    public StringValue SuggestedSignerEmail
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Instructions for Signing.</para>
    /// <para>Represents the following attribute in the schema: signinginstructions </para>
    /// </summary>
    [SchemaAttr(0, "signinginstructions")]
    public StringValue SigningInstructions
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> Additional Signature Information.</para>
    /// <para>Represents the following attribute in the schema: addlxml </para>
    /// </summary>
    [SchemaAttr(0, "addlxml")]
    public StringValue AdditionalXml
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> Signature Provider Download URL.</para>
    /// <para>Represents the following attribute in the schema: sigprovurl </para>
    /// </summary>
    [SchemaAttr(0, "sigprovurl")]
    public StringValue SignatureProviderUrl
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SignatureLine class.
    /// </summary>
    public SignatureLine():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "issignatureline" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "provid" == name)
    return new StringValue();
    
if( 0 == namespaceId && "signinginstructionsset" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "allowcomments" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "showsigndate" == name)
    return new TrueFalseValue();
    
if( 27 == namespaceId && "suggestedsigner" == name)
    return new StringValue();
    
if( 27 == namespaceId && "suggestedsigner2" == name)
    return new StringValue();
    
if( 27 == namespaceId && "suggestedsigneremail" == name)
    return new StringValue();
    
if( 0 == namespaceId && "signinginstructions" == name)
    return new StringValue();
    
if( 0 == namespaceId && "addlxml" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sigprovurl" == name)
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
        return CloneImp<SignatureLine>(deep);
    }

   
}
/// <summary>
/// <para>Ink.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:ink.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Ink : OpenXmlLeafElement
{
    private const string tagName = "ink";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12473;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "i","annotation" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
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
    /// <para> Ink Data.</para>
    /// <para>Represents the following attribute in the schema: i </para>
    /// </summary>
    [SchemaAttr(0, "i")]
    public Base64BinaryValue InkData
    {
        get { return (Base64BinaryValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Annotation Flag.</para>
    /// <para>Represents the following attribute in the schema: annotation </para>
    /// </summary>
    [SchemaAttr(0, "annotation")]
    public TrueFalseValue AnnotationFlag
    {
        get { return (TrueFalseValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Ink class.
    /// </summary>
    public Ink():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "i" == name)
    return new Base64BinaryValue();
    
if( 0 == namespaceId && "annotation" == name)
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
        return CloneImp<Ink>(deep);
    }

   
}
/// <summary>
/// <para>VML Diagram.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:diagram.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RelationTable &lt;o:relationtable></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RelationTable))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Diagram : OpenXmlCompositeElement
{
    private const string tagName = "diagram";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12474;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","dgmstyle","autoformat","reverse","autolayout","dgmscalex","dgmscaley","dgmfontsize","constrainbounds","dgmbasetextscale" };
    private static byte[] attributeNamespaceIds = { 26,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Style Options.</para>
    /// <para>Represents the following attribute in the schema: dgmstyle </para>
    /// </summary>
    [SchemaAttr(0, "dgmstyle")]
    public IntegerValue Style
    {
        get { return (IntegerValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Automatic Format.</para>
    /// <para>Represents the following attribute in the schema: autoformat </para>
    /// </summary>
    [SchemaAttr(0, "autoformat")]
    public TrueFalseValue AutoFormat
    {
        get { return (TrueFalseValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Reverse Direction.</para>
    /// <para>Represents the following attribute in the schema: reverse </para>
    /// </summary>
    [SchemaAttr(0, "reverse")]
    public TrueFalseValue Reverse
    {
        get { return (TrueFalseValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Automatic Layout.</para>
    /// <para>Represents the following attribute in the schema: autolayout </para>
    /// </summary>
    [SchemaAttr(0, "autolayout")]
    public TrueFalseValue AutoLayout
    {
        get { return (TrueFalseValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Layout X Scale.</para>
    /// <para>Represents the following attribute in the schema: dgmscalex </para>
    /// </summary>
    [SchemaAttr(0, "dgmscalex")]
    public IntegerValue ScaleX
    {
        get { return (IntegerValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Layout Y Scale.</para>
    /// <para>Represents the following attribute in the schema: dgmscaley </para>
    /// </summary>
    [SchemaAttr(0, "dgmscaley")]
    public IntegerValue ScaleY
    {
        get { return (IntegerValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Font Size.</para>
    /// <para>Represents the following attribute in the schema: dgmfontsize </para>
    /// </summary>
    [SchemaAttr(0, "dgmfontsize")]
    public IntegerValue FontSize
    {
        get { return (IntegerValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Layout Extents.</para>
    /// <para>Represents the following attribute in the schema: constrainbounds </para>
    /// </summary>
    [SchemaAttr(0, "constrainbounds")]
    public StringValue ConstrainBounds
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Base Font Size.</para>
    /// <para>Represents the following attribute in the schema: dgmbasetextscale </para>
    /// </summary>
    [SchemaAttr(0, "dgmbasetextscale")]
    public IntegerValue BaseTextScale
    {
        get { return (IntegerValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Diagram class.
    /// </summary>
    public Diagram():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Diagram class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Diagram(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Diagram class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Diagram(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Diagram class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Diagram(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "relationtable" == name)
    return new RelationTable();
    

    return null;
}

        private static readonly string[] eleTagNames = { "relationtable" };
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
    /// <para> Diagram Relationship Table.</para>
    /// <para> Represents the following element tag in the schema: o:relationtable </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public RelationTable RelationTable
    {
        get 
        {
            return GetElement<RelationTable>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "dgmstyle" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "autoformat" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "reverse" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "autolayout" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "dgmscalex" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "dgmscaley" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "dgmfontsize" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "constrainbounds" == name)
    return new StringValue();
    
if( 0 == namespaceId && "dgmbasetextscale" == name)
    return new IntegerValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Diagram>(deep);
    }

   
}
/// <summary>
/// <para>Skew Transform.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:skew.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Skew : OpenXmlLeafElement
{
    private const string tagName = "skew";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12475;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","id","on","offset","origin","matrix" };
    private static byte[] attributeNamespaceIds = { 26,0,0,0,0,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Skew ID.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Skew Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Skew Offset.</para>
    /// <para>Represents the following attribute in the schema: offset </para>
    /// </summary>
    [SchemaAttr(0, "offset")]
    public StringValue Offset
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Skew Origin.</para>
    /// <para>Represents the following attribute in the schema: origin </para>
    /// </summary>
    [SchemaAttr(0, "origin")]
    public StringValue Origin
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Skew Perspective Matrix.</para>
    /// <para>Represents the following attribute in the schema: matrix </para>
    /// </summary>
    [SchemaAttr(0, "matrix")]
    public StringValue Matrix
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Skew class.
    /// </summary>
    public Skew():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "on" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "offset" == name)
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
        return CloneImp<Skew>(deep);
    }

   
}
/// <summary>
/// <para>3D Extrusion.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:extrusion.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Extrusion : OpenXmlLeafElement
{
    private const string tagName = "extrusion";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12476;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","on","type","render","viewpointorigin","viewpoint","skewangle","skewamt","foredepth","backdepth","orientation","orientationangle","lockrotationcenter","autorotationcenter","rotationcenter","rotationangle","color","shininess","specularity","diffusity","metal","edge","facet","lightface","brightness","lightposition","lightlevel","lightharsh","lightposition2","lightlevel2","lightharsh2" };
    private static byte[] attributeNamespaceIds = { 26,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Render Mode.</para>
    /// <para>Represents the following attribute in the schema: render </para>
    /// </summary>
    [SchemaAttr(0, "render")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues> Render
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Viewpoint Origin.</para>
    /// <para>Represents the following attribute in the schema: viewpointorigin </para>
    /// </summary>
    [SchemaAttr(0, "viewpointorigin")]
    public StringValue ViewpointOrigin
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Viewpoint.</para>
    /// <para>Represents the following attribute in the schema: viewpoint </para>
    /// </summary>
    [SchemaAttr(0, "viewpoint")]
    public StringValue Viewpoint
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Skew Angle.</para>
    /// <para>Represents the following attribute in the schema: skewangle </para>
    /// </summary>
    [SchemaAttr(0, "skewangle")]
    public SingleValue SkewAngle
    {
        get { return (SingleValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Skew.</para>
    /// <para>Represents the following attribute in the schema: skewamt </para>
    /// </summary>
    [SchemaAttr(0, "skewamt")]
    public StringValue SkewAmount
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Forward Extrusion.</para>
    /// <para>Represents the following attribute in the schema: foredepth </para>
    /// </summary>
    [SchemaAttr(0, "foredepth")]
    public StringValue ForceDepth
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Backward Extrusion Depth.</para>
    /// <para>Represents the following attribute in the schema: backdepth </para>
    /// </summary>
    [SchemaAttr(0, "backdepth")]
    public StringValue BackDepth
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Rotation Axis.</para>
    /// <para>Represents the following attribute in the schema: orientation </para>
    /// </summary>
    [SchemaAttr(0, "orientation")]
    public StringValue Orientation
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> Rotation Around Axis.</para>
    /// <para>Represents the following attribute in the schema: orientationangle </para>
    /// </summary>
    [SchemaAttr(0, "orientationangle")]
    public SingleValue OrientationAngle
    {
        get { return (SingleValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> Rotation Toggle.</para>
    /// <para>Represents the following attribute in the schema: lockrotationcenter </para>
    /// </summary>
    [SchemaAttr(0, "lockrotationcenter")]
    public TrueFalseValue LockRotationCenter
    {
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> Center of Rotation Toggle.</para>
    /// <para>Represents the following attribute in the schema: autorotationcenter </para>
    /// </summary>
    [SchemaAttr(0, "autorotationcenter")]
    public TrueFalseValue AutoRotationCenter
    {
        get { return (TrueFalseValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> Rotation Center.</para>
    /// <para>Represents the following attribute in the schema: rotationcenter </para>
    /// </summary>
    [SchemaAttr(0, "rotationcenter")]
    public StringValue RotationCenter
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> X-Y Rotation Angle.</para>
    /// <para>Represents the following attribute in the schema: rotationangle </para>
    /// </summary>
    [SchemaAttr(0, "rotationangle")]
    public StringValue RotationAngle
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Color.</para>
    /// <para>Represents the following attribute in the schema: color </para>
    /// </summary>
    [SchemaAttr(0, "color")]
    public StringValue Color
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> Shininess.</para>
    /// <para>Represents the following attribute in the schema: shininess </para>
    /// </summary>
    [SchemaAttr(0, "shininess")]
    public SingleValue Shininess
    {
        get { return (SingleValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> Specularity.</para>
    /// <para>Represents the following attribute in the schema: specularity </para>
    /// </summary>
    [SchemaAttr(0, "specularity")]
    public StringValue Specularity
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> Diffuse Reflection.</para>
    /// <para>Represents the following attribute in the schema: diffusity </para>
    /// </summary>
    [SchemaAttr(0, "diffusity")]
    public StringValue Diffusity
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> Metallic Surface Toggle.</para>
    /// <para>Represents the following attribute in the schema: metal </para>
    /// </summary>
    [SchemaAttr(0, "metal")]
    public TrueFalseValue Metal
    {
        get { return (TrueFalseValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> Simulated Bevel.</para>
    /// <para>Represents the following attribute in the schema: edge </para>
    /// </summary>
    [SchemaAttr(0, "edge")]
    public StringValue Edge
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> Faceting Quality.</para>
    /// <para>Represents the following attribute in the schema: facet </para>
    /// </summary>
    [SchemaAttr(0, "facet")]
    public StringValue Facet
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> Shape Face Lighting Toggle.</para>
    /// <para>Represents the following attribute in the schema: lightface </para>
    /// </summary>
    [SchemaAttr(0, "lightface")]
    public TrueFalseValue LightFace
    {
        get { return (TrueFalseValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> Brightness.</para>
    /// <para>Represents the following attribute in the schema: brightness </para>
    /// </summary>
    [SchemaAttr(0, "brightness")]
    public StringValue Brightness
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> Primary Light Position.</para>
    /// <para>Represents the following attribute in the schema: lightposition </para>
    /// </summary>
    [SchemaAttr(0, "lightposition")]
    public StringValue LightPosition
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> Primary Light Intensity.</para>
    /// <para>Represents the following attribute in the schema: lightlevel </para>
    /// </summary>
    [SchemaAttr(0, "lightlevel")]
    public StringValue LightLevel
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> Primary Light Harshness Toggle.</para>
    /// <para>Represents the following attribute in the schema: lightharsh </para>
    /// </summary>
    [SchemaAttr(0, "lightharsh")]
    public TrueFalseValue LightHarsh
    {
        get { return (TrueFalseValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> Secondary Light Position.</para>
    /// <para>Represents the following attribute in the schema: lightposition2 </para>
    /// </summary>
    [SchemaAttr(0, "lightposition2")]
    public StringValue LightPosition2
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> Secondary Light Intensity.</para>
    /// <para>Represents the following attribute in the schema: lightlevel2 </para>
    /// </summary>
    [SchemaAttr(0, "lightlevel2")]
    public StringValue LightLevel2
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> Secondary Light Harshness Toggle.</para>
    /// <para>Represents the following attribute in the schema: lightharsh2 </para>
    /// </summary>
    [SchemaAttr(0, "lightharsh2")]
    public TrueFalseValue LightHarsh2
    {
        get { return (TrueFalseValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Extrusion class.
    /// </summary>
    public Extrusion():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "on" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues>();
    
if( 0 == namespaceId && "render" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues>();
    
if( 0 == namespaceId && "viewpointorigin" == name)
    return new StringValue();
    
if( 0 == namespaceId && "viewpoint" == name)
    return new StringValue();
    
if( 0 == namespaceId && "skewangle" == name)
    return new SingleValue();
    
if( 0 == namespaceId && "skewamt" == name)
    return new StringValue();
    
if( 0 == namespaceId && "foredepth" == name)
    return new StringValue();
    
if( 0 == namespaceId && "backdepth" == name)
    return new StringValue();
    
if( 0 == namespaceId && "orientation" == name)
    return new StringValue();
    
if( 0 == namespaceId && "orientationangle" == name)
    return new SingleValue();
    
if( 0 == namespaceId && "lockrotationcenter" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "autorotationcenter" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "rotationcenter" == name)
    return new StringValue();
    
if( 0 == namespaceId && "rotationangle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "color" == name)
    return new StringValue();
    
if( 0 == namespaceId && "shininess" == name)
    return new SingleValue();
    
if( 0 == namespaceId && "specularity" == name)
    return new StringValue();
    
if( 0 == namespaceId && "diffusity" == name)
    return new StringValue();
    
if( 0 == namespaceId && "metal" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "edge" == name)
    return new StringValue();
    
if( 0 == namespaceId && "facet" == name)
    return new StringValue();
    
if( 0 == namespaceId && "lightface" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "brightness" == name)
    return new StringValue();
    
if( 0 == namespaceId && "lightposition" == name)
    return new StringValue();
    
if( 0 == namespaceId && "lightlevel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "lightharsh" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "lightposition2" == name)
    return new StringValue();
    
if( 0 == namespaceId && "lightlevel2" == name)
    return new StringValue();
    
if( 0 == namespaceId && "lightharsh2" == name)
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
        return CloneImp<Extrusion>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Callout Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:callout.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Callout : OpenXmlLeafElement
{
    private const string tagName = "callout";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12477;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","on","type","gap","angle","dropauto","drop","distance","lengthspecified","length","accentbar","textborder","minusx","minusy" };
    private static byte[] attributeNamespaceIds = { 26,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Callout toggle.</para>
    /// <para>Represents the following attribute in the schema: on </para>
    /// </summary>
    [SchemaAttr(0, "on")]
    public TrueFalseValue On
    {
        get { return (TrueFalseValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Callout type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Callout gap.</para>
    /// <para>Represents the following attribute in the schema: gap </para>
    /// </summary>
    [SchemaAttr(0, "gap")]
    public StringValue Gap
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Callout angle.</para>
    /// <para>Represents the following attribute in the schema: angle </para>
    /// </summary>
    [SchemaAttr(0, "angle")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.AngleValues> Angle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.AngleValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Callout automatic drop toggle.</para>
    /// <para>Represents the following attribute in the schema: dropauto </para>
    /// </summary>
    [SchemaAttr(0, "dropauto")]
    public TrueFalseValue DropAuto
    {
        get { return (TrueFalseValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Callout drop position.</para>
    /// <para>Represents the following attribute in the schema: drop </para>
    /// </summary>
    [SchemaAttr(0, "drop")]
    public StringValue Drop
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Callout drop distance.</para>
    /// <para>Represents the following attribute in the schema: distance </para>
    /// </summary>
    [SchemaAttr(0, "distance")]
    public StringValue Distance
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Callout length toggle.</para>
    /// <para>Represents the following attribute in the schema: lengthspecified </para>
    /// </summary>
    [SchemaAttr(0, "lengthspecified")]
    public TrueFalseValue LengthSpecified
    {
        get { return (TrueFalseValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Callout length.</para>
    /// <para>Represents the following attribute in the schema: length </para>
    /// </summary>
    [SchemaAttr(0, "length")]
    public StringValue Length
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Callout accent bar toggle.</para>
    /// <para>Represents the following attribute in the schema: accentbar </para>
    /// </summary>
    [SchemaAttr(0, "accentbar")]
    public TrueFalseValue AccentBar
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> Callout text border toggle.</para>
    /// <para>Represents the following attribute in the schema: textborder </para>
    /// </summary>
    [SchemaAttr(0, "textborder")]
    public TrueFalseValue TextBorder
    {
        get { return (TrueFalseValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> Callout flip x.</para>
    /// <para>Represents the following attribute in the schema: minusx </para>
    /// </summary>
    [SchemaAttr(0, "minusx")]
    public TrueFalseValue MinusX
    {
        get { return (TrueFalseValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> Callout flip y.</para>
    /// <para>Represents the following attribute in the schema: minusy </para>
    /// </summary>
    [SchemaAttr(0, "minusy")]
    public TrueFalseValue MinusY
    {
        get { return (TrueFalseValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Callout class.
    /// </summary>
    public Callout():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "on" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "type" == name)
    return new StringValue();
    
if( 0 == namespaceId && "gap" == name)
    return new StringValue();
    
if( 0 == namespaceId && "angle" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.AngleValues>();
    
if( 0 == namespaceId && "dropauto" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "drop" == name)
    return new StringValue();
    
if( 0 == namespaceId && "distance" == name)
    return new StringValue();
    
if( 0 == namespaceId && "lengthspecified" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "length" == name)
    return new StringValue();
    
if( 0 == namespaceId && "accentbar" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "textborder" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "minusx" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "minusy" == name)
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
        return CloneImp<Callout>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Lock Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:lock.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Lock : OpenXmlLeafElement
{
    private const string tagName = "lock";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12478;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","position","selection","grouping","ungrouping","rotation","cropping","verticies","adjusthandles","text","aspectratio","shapetype" };
    private static byte[] attributeNamespaceIds = { 26,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Position Lock.</para>
    /// <para>Represents the following attribute in the schema: position </para>
    /// </summary>
    [SchemaAttr(0, "position")]
    public TrueFalseValue Position
    {
        get { return (TrueFalseValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Selection Lock.</para>
    /// <para>Represents the following attribute in the schema: selection </para>
    /// </summary>
    [SchemaAttr(0, "selection")]
    public TrueFalseValue Selection
    {
        get { return (TrueFalseValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Grouping Lock.</para>
    /// <para>Represents the following attribute in the schema: grouping </para>
    /// </summary>
    [SchemaAttr(0, "grouping")]
    public TrueFalseValue Grouping
    {
        get { return (TrueFalseValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Ungrouping Lock.</para>
    /// <para>Represents the following attribute in the schema: ungrouping </para>
    /// </summary>
    [SchemaAttr(0, "ungrouping")]
    public TrueFalseValue Ungrouping
    {
        get { return (TrueFalseValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Rotation Lock.</para>
    /// <para>Represents the following attribute in the schema: rotation </para>
    /// </summary>
    [SchemaAttr(0, "rotation")]
    public TrueFalseValue Rotation
    {
        get { return (TrueFalseValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Cropping Lock.</para>
    /// <para>Represents the following attribute in the schema: cropping </para>
    /// </summary>
    [SchemaAttr(0, "cropping")]
    public TrueFalseValue Cropping
    {
        get { return (TrueFalseValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Vertices Lock.</para>
    /// <para>Represents the following attribute in the schema: verticies </para>
    /// </summary>
    [SchemaAttr(0, "verticies")]
    public TrueFalseValue Verticies
    {
        get { return (TrueFalseValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Handles Lock.</para>
    /// <para>Represents the following attribute in the schema: adjusthandles </para>
    /// </summary>
    [SchemaAttr(0, "adjusthandles")]
    public TrueFalseValue AdjustHandles
    {
        get { return (TrueFalseValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Text Lock.</para>
    /// <para>Represents the following attribute in the schema: text </para>
    /// </summary>
    [SchemaAttr(0, "text")]
    public TrueFalseValue TextLock
    {
        get { return (TrueFalseValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Aspect Ratio Lock.</para>
    /// <para>Represents the following attribute in the schema: aspectratio </para>
    /// </summary>
    [SchemaAttr(0, "aspectratio")]
    public TrueFalseValue AspectRatio
    {
        get { return (TrueFalseValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> AutoShape Type Lock.</para>
    /// <para>Represents the following attribute in the schema: shapetype </para>
    /// </summary>
    [SchemaAttr(0, "shapetype")]
    public TrueFalseValue ShapeType
    {
        get { return (TrueFalseValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Lock class.
    /// </summary>
    public Lock():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "position" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "selection" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "grouping" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "ungrouping" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "rotation" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "cropping" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "verticies" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "adjusthandles" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "text" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "aspectratio" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "shapetype" == name)
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
        return CloneImp<Lock>(deep);
    }

   
}
/// <summary>
/// <para>Embedded OLE Object.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:OLEObject.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LinkType &lt;o:LinkType></description></item>
///<item><description>LockedField &lt;o:LockedField></description></item>
///<item><description>FieldCodes &lt;o:FieldCodes></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(LinkType))]
    [ChildElementInfo(typeof(LockedField))]
    [ChildElementInfo(typeof(FieldCodes))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class OleObject : OpenXmlCompositeElement
{
    private const string tagName = "OLEObject";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12479;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "Type","ProgID","ShapeID","DrawAspect","ObjectID","id","UpdateMode" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,19,0 };
    
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
    /// <para> OLE Object Type.</para>
    /// <para>Represents the following attribute in the schema: Type </para>
    /// </summary>
    [SchemaAttr(0, "Type")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.OleValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.OleValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> OLE Object Application.</para>
    /// <para>Represents the following attribute in the schema: ProgID </para>
    /// </summary>
    [SchemaAttr(0, "ProgID")]
    public StringValue ProgId
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> OLE Object Shape.</para>
    /// <para>Represents the following attribute in the schema: ShapeID </para>
    /// </summary>
    [SchemaAttr(0, "ShapeID")]
    public StringValue ShapeId
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> OLE Object Representation.</para>
    /// <para>Represents the following attribute in the schema: DrawAspect </para>
    /// </summary>
    [SchemaAttr(0, "DrawAspect")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues> DrawAspect
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> OLE Object Unique ID.</para>
    /// <para>Represents the following attribute in the schema: ObjectID </para>
    /// </summary>
    [SchemaAttr(0, "ObjectID")]
    public StringValue ObjectId
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Relationship.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> OLE Update Mode.</para>
    /// <para>Represents the following attribute in the schema: UpdateMode </para>
    /// </summary>
    [SchemaAttr(0, "UpdateMode")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues> UpdateMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues>)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OleObject class.
    /// </summary>
    public OleObject():base(){}
    
            /// <summary>
    ///Initializes a new instance of the OleObject class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OleObject(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OleObject class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OleObject(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OleObject class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OleObject(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "LinkType" == name)
    return new LinkType();
    
if( 27 == namespaceId && "LockedField" == name)
    return new LockedField();
    
if( 27 == namespaceId && "FieldCodes" == name)
    return new FieldCodes();
    

    return null;
}

        private static readonly string[] eleTagNames = { "LinkType","LockedField","FieldCodes" };
    private static readonly byte[] eleNamespaceIds = { 27,27,27 };
    
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
    /// <para> Embedded Object Alternate Image Request.</para>
    /// <para> Represents the following element tag in the schema: o:LinkType </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public LinkType LinkType
    {
        get 
        {
            return GetElement<LinkType>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Embedded Object Cannot Be Refreshed.</para>
    /// <para> Represents the following element tag in the schema: o:LockedField </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public LockedField LockedField
    {
        get 
        {
            return GetElement<LockedField>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> WordprocessingML Field Switches.</para>
    /// <para> Represents the following element tag in the schema: o:FieldCodes </para>
    /// </summary>
    /// <remark>
    /// xmlns:o = urn:schemas-microsoft-com:office:office
    /// </remark>
    public FieldCodes FieldCodes
    {
        get 
        {
            return GetElement<FieldCodes>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "Type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.OleValues>();
    
if( 0 == namespaceId && "ProgID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ShapeID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "DrawAspect" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues>();
    
if( 0 == namespaceId && "ObjectID" == name)
    return new StringValue();
    
if( 19 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "UpdateMode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<OleObject>(deep);
    }

   
}
/// <summary>
/// <para>Complex.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:complex.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Complex : OpenXmlLeafElement
{
    private const string tagName = "complex";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12480;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext" };
    private static byte[] attributeNamespaceIds = { 26 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Complex class.
    /// </summary>
    public Complex():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Complex>(deep);
    }

   
}
/// <summary>
/// <para>Text Box Left Stroke.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:left.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LeftStroke : StrokeChildType
{
    private const string tagName = "left";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12481;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the LeftStroke class.
    /// </summary>
    public LeftStroke():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LeftStroke>(deep);
    }

}
/// <summary>
/// <para>Text Box Top Stroke.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:top.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TopStroke : StrokeChildType
{
    private const string tagName = "top";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12482;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the TopStroke class.
    /// </summary>
    public TopStroke():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TopStroke>(deep);
    }

}
/// <summary>
/// <para>Text Box Right Stroke.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:right.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RightStroke : StrokeChildType
{
    private const string tagName = "right";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12483;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the RightStroke class.
    /// </summary>
    public RightStroke():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RightStroke>(deep);
    }

}
/// <summary>
/// <para>Text Box Bottom Stroke.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:bottom.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BottomStroke : StrokeChildType
{
    private const string tagName = "bottom";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12484;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the BottomStroke class.
    /// </summary>
    public BottomStroke():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BottomStroke>(deep);
    }

}
/// <summary>
/// <para>Text Box Interior Stroke.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:column.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColumnStroke : StrokeChildType
{
    private const string tagName = "column";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12485;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the ColumnStroke class.
    /// </summary>
    public ColumnStroke():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ColumnStroke>(deep);
    }

}
/// <summary>
/// Defines the StrokeChildType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class StrokeChildType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "ext","on","weight","color","color2","opacity","linestyle","miterlimit","joinstyle","endcap","dashstyle","insetpen","filltype","src","imageaspect","imagesize","imagealignshape","startarrow","startarrowwidth","startarrowlength","endarrow","endarrowwidth","endarrowlength","href","althref","title","forcedash" };
    private static byte[] attributeNamespaceIds = { 26,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,27,27,27,27 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
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
    /// <para> Stroke Alternate Pattern Color.</para>
    /// <para>Represents the following attribute in the schema: color2 </para>
    /// </summary>
    [SchemaAttr(0, "color2")]
    public StringValue Color2
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Opacity.</para>
    /// <para>Represents the following attribute in the schema: opacity </para>
    /// </summary>
    [SchemaAttr(0, "opacity")]
    public StringValue Opacity
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Line Style.</para>
    /// <para>Represents the following attribute in the schema: linestyle </para>
    /// </summary>
    [SchemaAttr(0, "linestyle")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues> LineStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues>)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Miter Joint Limit.</para>
    /// <para>Represents the following attribute in the schema: miterlimit </para>
    /// </summary>
    [SchemaAttr(0, "miterlimit")]
    public DecimalValue MiterLimit
    {
        get { return (DecimalValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Line End Join Style).</para>
    /// <para>Represents the following attribute in the schema: joinstyle </para>
    /// </summary>
    [SchemaAttr(0, "joinstyle")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues> JoinStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues>)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Line End Cap.</para>
    /// <para>Represents the following attribute in the schema: endcap </para>
    /// </summary>
    [SchemaAttr(0, "endcap")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues> EndCap
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues>)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Dash Pattern.</para>
    /// <para>Represents the following attribute in the schema: dashstyle </para>
    /// </summary>
    [SchemaAttr(0, "dashstyle")]
    public StringValue DashStyle
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> Inset Border From Path.</para>
    /// <para>Represents the following attribute in the schema: insetpen </para>
    /// </summary>
    [SchemaAttr(0, "insetpen")]
    public TrueFalseValue InsetPen
    {
        get { return (TrueFalseValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Style.</para>
    /// <para>Represents the following attribute in the schema: filltype </para>
    /// </summary>
    [SchemaAttr(0, "filltype")]
    public EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues> FillType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues>)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Location.</para>
    /// <para>Represents the following attribute in the schema: src </para>
    /// </summary>
    [SchemaAttr(0, "src")]
    public StringValue Source
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Aspect Ratio.</para>
    /// <para>Represents the following attribute in the schema: imageaspect </para>
    /// </summary>
    [SchemaAttr(0, "imageaspect")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> ImageAspect
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> Stroke Image Size.</para>
    /// <para>Represents the following attribute in the schema: imagesize </para>
    /// </summary>
    [SchemaAttr(0, "imagesize")]
    public StringValue ImageSize
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> Stoke Image Alignment.</para>
    /// <para>Represents the following attribute in the schema: imagealignshape </para>
    /// </summary>
    [SchemaAttr(0, "imagealignshape")]
    public TrueFalseValue ImageAlignShape
    {
        get { return (TrueFalseValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> Line Start Arrowhead.</para>
    /// <para>Represents the following attribute in the schema: startarrow </para>
    /// </summary>
    [SchemaAttr(0, "startarrow")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> StartArrow
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> Line Start Arrowhead Width.</para>
    /// <para>Represents the following attribute in the schema: startarrowwidth </para>
    /// </summary>
    [SchemaAttr(0, "startarrowwidth")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> StartArrowWidth
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> Line Start Arrowhead Length.</para>
    /// <para>Represents the following attribute in the schema: startarrowlength </para>
    /// </summary>
    [SchemaAttr(0, "startarrowlength")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> StartArrowLength
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> Line End Arrowhead.</para>
    /// <para>Represents the following attribute in the schema: endarrow </para>
    /// </summary>
    [SchemaAttr(0, "endarrow")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> EndArrow
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> Line End Arrowhead Width.</para>
    /// <para>Represents the following attribute in the schema: endarrowwidth </para>
    /// </summary>
    [SchemaAttr(0, "endarrowwidth")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> EndArrowWidth
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> Line End Arrowhead Length.</para>
    /// <para>Represents the following attribute in the schema: endarrowlength </para>
    /// </summary>
    [SchemaAttr(0, "endarrowlength")]
    public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> EndArrowLength
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>)Attributes[22]; }
        set { Attributes[22] = value; }
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
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
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
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
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
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
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
        get { return (TrueFalseValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "on" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "weight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "color" == name)
    return new StringValue();
    
if( 0 == namespaceId && "color2" == name)
    return new StringValue();
    
if( 0 == namespaceId && "opacity" == name)
    return new StringValue();
    
if( 0 == namespaceId && "linestyle" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues>();
    
if( 0 == namespaceId && "miterlimit" == name)
    return new DecimalValue();
    
if( 0 == namespaceId && "joinstyle" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues>();
    
if( 0 == namespaceId && "endcap" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues>();
    
if( 0 == namespaceId && "dashstyle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insetpen" == name)
    return new TrueFalseValue();
    
if( 0 == namespaceId && "filltype" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues>();
    
if( 0 == namespaceId && "src" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageaspect" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>();
    
if( 0 == namespaceId && "imagesize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imagealignshape" == name)
    return new TrueFalseValue();
    
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
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the StrokeChildType class.
    /// </summary>
    protected StrokeChildType(){}
    
    
    
}
/// <summary>
/// <para>Shape Clipping Path.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:clippath.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ClipPath : OpenXmlLeafElement
{
    private const string tagName = "clippath";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12486;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "v" };
    private static byte[] attributeNamespaceIds = { 27 };
    
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
    /// <para> Path Definition.</para>
    /// <para>Represents the following attribute in the schema: o:v </para>
    /// </summary>
///<remark> xmlns:o=urn:schemas-microsoft-com:office:office
///</remark>
    [SchemaAttr(27, "v")]
    public StringValue Value
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ClipPath class.
    /// </summary>
    public ClipPath():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "v" == name)
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
        return CloneImp<ClipPath>(deep);
    }

   
}
/// <summary>
/// <para>Shape Fill Extended Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:fill.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FillExtendedProperties : OpenXmlLeafElement
{
    private const string tagName = "fill";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12487;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","type" };
    private static byte[] attributeNamespaceIds = { 26,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Fill Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.FillValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.FillValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FillExtendedProperties class.
    /// </summary>
    public FillExtendedProperties():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.FillValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FillExtendedProperties>(deep);
    }

   
}
/// <summary>
/// <para>Shape ID Map.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:idmap.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ShapeIdMap : OpenXmlLeafElement
{
    private const string tagName = "idmap";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12488;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","data" };
    private static byte[] attributeNamespaceIds = { 26,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape IDs.</para>
    /// <para>Represents the following attribute in the schema: data </para>
    /// </summary>
    [SchemaAttr(0, "data")]
    public StringValue Data
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShapeIdMap class.
    /// </summary>
    public ShapeIdMap():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "data" == name)
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
        return CloneImp<ShapeIdMap>(deep);
    }

   
}
/// <summary>
/// <para>Shape Grouping History.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:regrouptable.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Entry &lt;o:entry></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Entry))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RegroupTable : OpenXmlCompositeElement
{
    private const string tagName = "regrouptable";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12489;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext" };
    private static byte[] attributeNamespaceIds = { 26 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RegroupTable class.
    /// </summary>
    public RegroupTable():base(){}
    
            /// <summary>
    ///Initializes a new instance of the RegroupTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RegroupTable(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RegroupTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RegroupTable(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RegroupTable class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RegroupTable(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "entry" == name)
    return new Entry();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RegroupTable>(deep);
    }

   
}
/// <summary>
/// <para>Rule Set.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:rules.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Rule &lt;o:r></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Rule))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Rules : OpenXmlCompositeElement
{
    private const string tagName = "rules";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12490;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext" };
    private static byte[] attributeNamespaceIds = { 26 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Rules class.
    /// </summary>
    public Rules():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Rules class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rules(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Rules class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rules(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Rules class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Rules(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "r" == name)
    return new Rule();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Rules>(deep);
    }

   
}
/// <summary>
/// <para>Regroup Entry.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:entry.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Entry : OpenXmlLeafElement
{
    private const string tagName = "entry";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12491;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "new","old" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
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
    /// <para> New Group ID.</para>
    /// <para>Represents the following attribute in the schema: new </para>
    /// </summary>
    [SchemaAttr(0, "new")]
    public Int32Value New
    {
        get { return (Int32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Old Group ID.</para>
    /// <para>Represents the following attribute in the schema: old </para>
    /// </summary>
    [SchemaAttr(0, "old")]
    public Int32Value Old
    {
        get { return (Int32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Entry class.
    /// </summary>
    public Entry():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "new" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "old" == name)
    return new Int32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Entry>(deep);
    }

   
}
/// <summary>
/// <para>Rule.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:r.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Proxy &lt;o:proxy></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Proxy))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Rule : OpenXmlCompositeElement
{
    private const string tagName = "r";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12492;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","type","how","idref" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0 };
    
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
    /// <para> Rule ID.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Rule Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Alignment Rule Type.</para>
    /// <para>Represents the following attribute in the schema: how </para>
    /// </summary>
    [SchemaAttr(0, "how")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues> How
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Rule Shape Reference.</para>
    /// <para>Represents the following attribute in the schema: idref </para>
    /// </summary>
    [SchemaAttr(0, "idref")]
    public StringValue ShapeReference
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Rule class.
    /// </summary>
    public Rule():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Rule class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rule(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Rule class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Rule(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Rule class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Rule(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "proxy" == name)
    return new Proxy();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues>();
    
if( 0 == namespaceId && "how" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues>();
    
if( 0 == namespaceId && "idref" == name)
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
        return CloneImp<Rule>(deep);
    }

   
}
/// <summary>
/// <para>Diagram Relationship Table.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:relationtable.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Relation &lt;o:rel></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Relation))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RelationTable : OpenXmlCompositeElement
{
    private const string tagName = "relationtable";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12493;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext" };
    private static byte[] attributeNamespaceIds = { 26 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RelationTable class.
    /// </summary>
    public RelationTable():base(){}
    
            /// <summary>
    ///Initializes a new instance of the RelationTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RelationTable(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RelationTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RelationTable(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RelationTable class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RelationTable(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 27 == namespaceId && "rel" == name)
    return new Relation();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RelationTable>(deep);
    }

   
}
/// <summary>
/// <para>Diagram Relationship.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:rel.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Relation : OpenXmlLeafElement
{
    private const string tagName = "rel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12494;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","idsrc","iddest","idcntr" };
    private static byte[] attributeNamespaceIds = { 26,0,0,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Relationship Source Shape.</para>
    /// <para>Represents the following attribute in the schema: idsrc </para>
    /// </summary>
    [SchemaAttr(0, "idsrc")]
    public StringValue SourceId
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Relationship Destination Shape.</para>
    /// <para>Represents the following attribute in the schema: iddest </para>
    /// </summary>
    [SchemaAttr(0, "iddest")]
    public StringValue DestinationId
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Diagram Relationship Center Shape.</para>
    /// <para>Represents the following attribute in the schema: idcntr </para>
    /// </summary>
    [SchemaAttr(0, "idcntr")]
    public StringValue CenterShapeId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Relation class.
    /// </summary>
    public Relation():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "idsrc" == name)
    return new StringValue();
    
if( 0 == namespaceId && "iddest" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idcntr" == name)
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
        return CloneImp<Relation>(deep);
    }

   
}
/// <summary>
/// <para>Embedded Object Alternate Image Request.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:LinkType.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LinkType : OpenXmlLeafTextElement
{
    private const string tagName = "LinkType";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12495;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LinkType class.
    /// </summary>
    public LinkType():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the LinkType class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public LinkType(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Office.OleLinkValues>(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LinkType>(deep);
    }

   
}
/// <summary>
/// <para>Embedded Object Cannot Be Refreshed.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:LockedField.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LockedField : OpenXmlLeafTextElement
{
    private const string tagName = "LockedField";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12496;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LockedField class.
    /// </summary>
    public LockedField():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the LockedField class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public LockedField(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new TrueFalseBlankValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LockedField>(deep);
    }

   
}
/// <summary>
/// <para>WordprocessingML Field Switches.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:FieldCodes.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FieldCodes : OpenXmlLeafTextElement
{
    private const string tagName = "FieldCodes";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12497;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the FieldCodes class.
    /// </summary>
    public FieldCodes():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the FieldCodes class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FieldCodes(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FieldCodes>(deep);
    }

   
}
/// <summary>
/// <para>Shape Reference.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:proxy.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Proxy : OpenXmlLeafElement
{
    private const string tagName = "proxy";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12498;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "start","end","idref","connectloc" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0 };
    
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
    /// <para> Start Point Connection Flag.</para>
    /// <para>Represents the following attribute in the schema: start </para>
    /// </summary>
    [SchemaAttr(0, "start")]
    public TrueFalseBlankValue Start
    {
        get { return (TrueFalseBlankValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> End Point Connection Flag.</para>
    /// <para>Represents the following attribute in the schema: end </para>
    /// </summary>
    [SchemaAttr(0, "end")]
    public TrueFalseBlankValue End
    {
        get { return (TrueFalseBlankValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Proxy Shape Reference.</para>
    /// <para>Represents the following attribute in the schema: idref </para>
    /// </summary>
    [SchemaAttr(0, "idref")]
    public StringValue ShapeReference
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Connection Location.</para>
    /// <para>Represents the following attribute in the schema: connectloc </para>
    /// </summary>
    [SchemaAttr(0, "connectloc")]
    public Int32Value ConnectionLocation
    {
        get { return (Int32Value)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Proxy class.
    /// </summary>
    public Proxy():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "start" == name)
    return new TrueFalseBlankValue();
    
if( 0 == namespaceId && "end" == name)
    return new TrueFalseBlankValue();
    
if( 0 == namespaceId && "idref" == name)
    return new StringValue();
    
if( 0 == namespaceId && "connectloc" == name)
    return new Int32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Proxy>(deep);
    }

   
}
/// <summary>
/// <para>Most Recently Used Colors.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:colormru.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorMostRecentlyUsed : OpenXmlLeafElement
{
    private const string tagName = "colormru";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12499;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","colors" };
    private static byte[] attributeNamespaceIds = { 26,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Recent colors.</para>
    /// <para>Represents the following attribute in the schema: colors </para>
    /// </summary>
    [SchemaAttr(0, "colors")]
    public StringValue Colors
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColorMostRecentlyUsed class.
    /// </summary>
    public ColorMostRecentlyUsed():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "colors" == name)
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
        return CloneImp<ColorMostRecentlyUsed>(deep);
    }

   
}
/// <summary>
/// <para>UI Default Colors.</para>
/// <para> When the object is serialized out as xml, its qualified name is o:colormenu.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorMenu : OpenXmlLeafElement
{
    private const string tagName = "colormenu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 27;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12500;
    
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
		if((15 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ext","strokecolor","fillcolor","shadowcolor","extrusioncolor" };
    private static byte[] attributeNamespaceIds = { 26,0,0,0,0 };
    
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
    /// <para> VML Extension Handling Behavior.</para>
    /// <para>Represents the following attribute in the schema: v:ext </para>
    /// </summary>
///<remark> xmlns:v=urn:schemas-microsoft-com:vml
///</remark>
    [SchemaAttr(26, "ext")]
    public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Default stroke color.</para>
    /// <para>Represents the following attribute in the schema: strokecolor </para>
    /// </summary>
    [SchemaAttr(0, "strokecolor")]
    public StringValue StrokeColor
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Default fill color.</para>
    /// <para>Represents the following attribute in the schema: fillcolor </para>
    /// </summary>
    [SchemaAttr(0, "fillcolor")]
    public StringValue FillColor
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Default shadow color.</para>
    /// <para>Represents the following attribute in the schema: shadowcolor </para>
    /// </summary>
    [SchemaAttr(0, "shadowcolor")]
    public StringValue ShadowColor
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Default extrusion color.</para>
    /// <para>Represents the following attribute in the schema: extrusioncolor </para>
    /// </summary>
    [SchemaAttr(0, "extrusioncolor")]
    public StringValue ExtrusionColor
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColorMenu class.
    /// </summary>
    public ColorMenu():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 26 == namespaceId && "ext" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>();
    
if( 0 == namespaceId && "strokecolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "fillcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "shadowcolor" == name)
    return new StringValue();
    
if( 0 == namespaceId && "extrusioncolor" == name)
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
        return CloneImp<ColorMenu>(deep);
    }

   
}
/// <summary>
/// Alignment Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AlignmentValues
{  
	///<summary>
///Top Alignment.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///Middle Alignment.
///<para>When the item is serialized out as xml, its value is "middle".</para>
///</summary>
[EnumString("middle")]
Middle,
///<summary>
///Bottom Alignment.
///<para>When the item is serialized out as xml, its value is "bottom".</para>
///</summary>
[EnumString("bottom")]
Bottom,
///<summary>
///Left Alignment.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///Center Alignment.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///Right Alignment.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,
 
}
/// <summary>
/// Screen Sizes Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ScreenSizeValues
{  
	///<summary>
///544x376 pixels.
///<para>When the item is serialized out as xml, its value is "544,376".</para>
///</summary>
[EnumString("544,376")]
Sz544x376,
///<summary>
///640x480 pixels.
///<para>When the item is serialized out as xml, its value is "640,480".</para>
///</summary>
[EnumString("640,480")]
Sz640x480,
///<summary>
///720x512 pixels.
///<para>When the item is serialized out as xml, its value is "720,512".</para>
///</summary>
[EnumString("720,512")]
Sz720x512,
///<summary>
///800x600 pixels.
///<para>When the item is serialized out as xml, its value is "800,600".</para>
///</summary>
[EnumString("800,600")]
Sz800x600,
///<summary>
///1024x768 pixels.
///<para>When the item is serialized out as xml, its value is "1024,768".</para>
///</summary>
[EnumString("1024,768")]
Sz1024x768,
///<summary>
///1152x862 pixels.
///<para>When the item is serialized out as xml, its value is "1152,862".</para>
///</summary>
[EnumString("1152,862")]
Sz1152x862,
 
}
/// <summary>
/// Inset Margin Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum InsetMarginValues
{  
	///<summary>
///Automatic Margins.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,
///<summary>
///Custom Margins.
///<para>When the item is serialized out as xml, its value is "custom".</para>
///</summary>
[EnumString("custom")]
Custom,
 
}
/// <summary>
/// Extrusion Color Types 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ColorModeValues
{  
	///<summary>
///Use Shape Fill Color.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,
///<summary>
///Use Custom Color.
///<para>When the item is serialized out as xml, its value is "custom".</para>
///</summary>
[EnumString("custom")]
Custom,
 
}
/// <summary>
/// Extrusion Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ExtrusionValues
{  
	///<summary>
///Perspective Projection.
///<para>When the item is serialized out as xml, its value is "perspective".</para>
///</summary>
[EnumString("perspective")]
Perspective,
///<summary>
///Parallel Projection.
///<para>When the item is serialized out as xml, its value is "parallel".</para>
///</summary>
[EnumString("parallel")]
Parallel,
 
}
/// <summary>
/// Extrusion Rendering Types 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ExtrusionRenderValues
{  
	///<summary>
///Solid.
///<para>When the item is serialized out as xml, its value is "solid".</para>
///</summary>
[EnumString("solid")]
Solid,
///<summary>
///Wireframe.
///<para>When the item is serialized out as xml, its value is "wireFrame".</para>
///</summary>
[EnumString("wireFrame")]
WireFrame,
///<summary>
///Bounding Cube.
///<para>When the item is serialized out as xml, its value is "boundingCube".</para>
///</summary>
[EnumString("boundingCube")]
BoundingCube,
 
}
/// <summary>
/// Extrusion Planes 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ExtrusionPlaneValues
{  
	///<summary>
///XY Plane.
///<para>When the item is serialized out as xml, its value is "XY".</para>
///</summary>
[EnumString("XY")]
XY,
///<summary>
///ZX Plane.
///<para>When the item is serialized out as xml, its value is "ZX".</para>
///</summary>
[EnumString("ZX")]
ZX,
///<summary>
///YZ Plane.
///<para>When the item is serialized out as xml, its value is "YZ".</para>
///</summary>
[EnumString("YZ")]
YZ,
 
}
/// <summary>
/// Callout Angles 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AngleValues
{  
	///<summary>
///Any Angle.
///<para>When the item is serialized out as xml, its value is "any".</para>
///</summary>
[EnumString("any")]
Any,
///<summary>
///30 degrees.
///<para>When the item is serialized out as xml, its value is "30".</para>
///</summary>
[EnumString("30")]
Degree30,
///<summary>
///45 degrees.
///<para>When the item is serialized out as xml, its value is "45".</para>
///</summary>
[EnumString("45")]
Degree45,
///<summary>
///60 degrees.
///<para>When the item is serialized out as xml, its value is "60".</para>
///</summary>
[EnumString("60")]
Degree60,
///<summary>
///90 degrees.
///<para>When the item is serialized out as xml, its value is "90".</para>
///</summary>
[EnumString("90")]
Degree90,
///<summary>
///Automatic Angle.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,
 
}
/// <summary>
/// Callout Placement 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum CalloutPlacementValues
{  
	///<summary>
///Top placement.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///Center placement.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///Bottom placement.
///<para>When the item is serialized out as xml, its value is "bottom".</para>
///</summary>
[EnumString("bottom")]
Bottom,
///<summary>
///User-defined placement.
///<para>When the item is serialized out as xml, its value is "user".</para>
///</summary>
[EnumString("user")]
User,
 
}
/// <summary>
/// Connector Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConnectorValues
{  
	///<summary>
///No Connector.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Straight Connector.
///<para>When the item is serialized out as xml, its value is "straight".</para>
///</summary>
[EnumString("straight")]
Straight,
///<summary>
///Elbow Connector.
///<para>When the item is serialized out as xml, its value is "elbow".</para>
///</summary>
[EnumString("elbow")]
Elbow,
///<summary>
///Curved Connector.
///<para>When the item is serialized out as xml, its value is "curved".</para>
///</summary>
[EnumString("curved")]
Curved,
 
}
/// <summary>
/// Alignment Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum HorizontalRuleAlignmentValues
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
 
}
/// <summary>
/// Connection Locations Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConnectValues
{  
	///<summary>
///No.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Four Connections.
///<para>When the item is serialized out as xml, its value is "rect".</para>
///</summary>
[EnumString("rect")]
Rectangle,
///<summary>
///Edit Point Connections.
///<para>When the item is serialized out as xml, its value is "segments".</para>
///</summary>
[EnumString("segments")]
Segments,
///<summary>
///Custom Connections.
///<para>When the item is serialized out as xml, its value is "custom".</para>
///</summary>
[EnumString("custom")]
Custom,
 
}
/// <summary>
/// Embedded Object Alternate Image Request Types 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OleLinkValues
{  
	///<summary>
///Other Image.
///<para>When the item is serialized out as xml, its value is "Picture".</para>
///</summary>
[EnumString("Picture")]
Picture,
///<summary>
///Bitmap Image.
///<para>When the item is serialized out as xml, its value is "Bitmap".</para>
///</summary>
[EnumString("Bitmap")]
Bitmap,
///<summary>
///Enhanced Metafile Image.
///<para>When the item is serialized out as xml, its value is "EnhancedMetaFile".</para>
///</summary>
[EnumString("EnhancedMetaFile")]
EnhancedMetaFile,
 
}
/// <summary>
/// OLE Connection Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OleValues
{  
	///<summary>
///Embedded Object.
///<para>When the item is serialized out as xml, its value is "Embed".</para>
///</summary>
[EnumString("Embed")]
Embed,
///<summary>
///Linked Object.
///<para>When the item is serialized out as xml, its value is "Link".</para>
///</summary>
[EnumString("Link")]
Link,
 
}
/// <summary>
/// OLE Object Representations 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OleDrawAspectValues
{  
	///<summary>
///Snapshot.
///<para>When the item is serialized out as xml, its value is "Content".</para>
///</summary>
[EnumString("Content")]
Content,
///<summary>
///Icon.
///<para>When the item is serialized out as xml, its value is "Icon".</para>
///</summary>
[EnumString("Icon")]
Icon,
 
}
/// <summary>
/// OLE Update Method Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OleUpdateModeValues
{  
	///<summary>
///Server Application Update.
///<para>When the item is serialized out as xml, its value is "Always".</para>
///</summary>
[EnumString("Always")]
Always,
///<summary>
///User Update.
///<para>When the item is serialized out as xml, its value is "OnCall".</para>
///</summary>
[EnumString("OnCall")]
OnCall,
 
}
/// <summary>
/// Shape Fill Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FillValues
{  
	///<summary>
///Centered Radial Gradient.
///<para>When the item is serialized out as xml, its value is "gradientCenter".</para>
///</summary>
[EnumString("gradientCenter")]
GradientCenter,
///<summary>
///Solid Fill.
///<para>When the item is serialized out as xml, its value is "solid".</para>
///</summary>
[EnumString("solid")]
Solid,
///<summary>
///Image Pattern.
///<para>When the item is serialized out as xml, its value is "pattern".</para>
///</summary>
[EnumString("pattern")]
Pattern,
///<summary>
///Tiled Image.
///<para>When the item is serialized out as xml, its value is "tile".</para>
///</summary>
[EnumString("tile")]
Tile,
///<summary>
///Stretch Image to Fit.
///<para>When the item is serialized out as xml, its value is "frame".</para>
///</summary>
[EnumString("frame")]
Frame,
///<summary>
///Unscaled Gradient.
///<para>When the item is serialized out as xml, its value is "gradientUnscaled".</para>
///</summary>
[EnumString("gradientUnscaled")]
GradientUnscaled,
///<summary>
///Radial Gradient.
///<para>When the item is serialized out as xml, its value is "gradientRadial".</para>
///</summary>
[EnumString("gradientRadial")]
GradientRadial,
///<summary>
///Linear Gradient.
///<para>When the item is serialized out as xml, its value is "gradient".</para>
///</summary>
[EnumString("gradient")]
Gradient,
///<summary>
///Use Background Fill.
///<para>When the item is serialized out as xml, its value is "background".</para>
///</summary>
[EnumString("background")]
Background,
 
}
/// <summary>
/// Rule Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum RuleValues
{  
	///<summary>
///Arc Rule.
///<para>When the item is serialized out as xml, its value is "arc".</para>
///</summary>
[EnumString("arc")]
Arc,
///<summary>
///Callout Rule.
///<para>When the item is serialized out as xml, its value is "callout".</para>
///</summary>
[EnumString("callout")]
Callout,
///<summary>
///Connector Rule.
///<para>When the item is serialized out as xml, its value is "connector".</para>
///</summary>
[EnumString("connector")]
Connector,
 
}
/// <summary>
/// Black And White Modes 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BlackAndWhiteModeValues
{  
	///<summary>
///Color.
///<para>When the item is serialized out as xml, its value is "color".</para>
///</summary>
[EnumString("color")]
Color,
///<summary>
///Automatic.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,
///<summary>
///Grayscale.
///<para>When the item is serialized out as xml, its value is "grayScale".</para>
///</summary>
[EnumString("grayScale")]
GrayScale,
///<summary>
///Light grayscale.
///<para>When the item is serialized out as xml, its value is "lightGrayScale".</para>
///</summary>
[EnumString("lightGrayScale")]
LightGrayScale,
///<summary>
///Inverse Grayscale.
///<para>When the item is serialized out as xml, its value is "inverseGray".</para>
///</summary>
[EnumString("inverseGray")]
InverseGray,
///<summary>
///Gray Outlines.
///<para>When the item is serialized out as xml, its value is "grayOutline".</para>
///</summary>
[EnumString("grayOutline")]
GrayOutline,
///<summary>
///Black And White.
///<para>When the item is serialized out as xml, its value is "highContrast".</para>
///</summary>
[EnumString("highContrast")]
HighContrast,
///<summary>
///Black.
///<para>When the item is serialized out as xml, its value is "black".</para>
///</summary>
[EnumString("black")]
Black,
///<summary>
///White.
///<para>When the item is serialized out as xml, its value is "white".</para>
///</summary>
[EnumString("white")]
White,
///<summary>
///Do Not Show.
///<para>When the item is serialized out as xml, its value is "undrawn".</para>
///</summary>
[EnumString("undrawn")]
Undrawn,
///<summary>
///Black Text And Lines.
///<para>When the item is serialized out as xml, its value is "blackTextAndLines".</para>
///</summary>
[EnumString("blackTextAndLines")]
BlackTextAndLines,
 
}
}
 
 
