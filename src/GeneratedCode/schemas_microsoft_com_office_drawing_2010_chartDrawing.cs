// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing
{
/// <summary>
/// <para>Defines the ContentPart Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr14:contentPart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualContentPartProperties &lt;cdr14:nvContentPartPr></description></item>
///<item><description>ApplicationNonVisualDrawingProperties &lt;cdr14:nvPr></description></item>
///<item><description>Transform2D &lt;cdr14:xfrm></description></item>
///<item><description>OfficeArtExtensionList &lt;cdr14:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(NonVisualContentPartProperties),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ApplicationNonVisualDrawingProperties),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Transform2D),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(OfficeArtExtensionList),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContentPart : OpenXmlCompositeElement
{
    private const string tagName = "contentPart";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 47;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12774;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","bwMode" };
    private static byte[] attributeNamespaceIds = { 19,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> bwMode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[1]; }
        set { Attributes[1] = value; }
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
    if( 47 == namespaceId && "nvContentPartPr" == name)
    return new NonVisualContentPartProperties();
    
if( 47 == namespaceId && "nvPr" == name)
    return new ApplicationNonVisualDrawingProperties();
    
if( 47 == namespaceId && "xfrm" == name)
    return new Transform2D();
    
if( 47 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvContentPartPr","nvPr","xfrm","extLst" };
    private static readonly byte[] eleNamespaceIds = { 47,47,47,47 };
    
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
    /// <para> NonVisualContentPartProperties.</para>
    /// <para> Represents the following element tag in the schema: cdr14:nvContentPartPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr14 = http://schemas.microsoft.com/office/drawing/2010/chartDrawing
    /// </remark>
    public NonVisualContentPartProperties NonVisualContentPartProperties
    {
        get 
        {
            return GetElement<NonVisualContentPartProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ApplicationNonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: cdr14:nvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr14 = http://schemas.microsoft.com/office/drawing/2010/chartDrawing
    /// </remark>
    public ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
    {
        get 
        {
            return GetElement<ApplicationNonVisualDrawingProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Transform2D.</para>
    /// <para> Represents the following element tag in the schema: cdr14:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr14 = http://schemas.microsoft.com/office/drawing/2010/chartDrawing
    /// </remark>
    public Transform2D Transform2D
    {
        get 
        {
            return GetElement<Transform2D>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cdr14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr14 = http://schemas.microsoft.com/office/drawing/2010/chartDrawing
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get 
        {
            return GetElement<OfficeArtExtensionList>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 19 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "bwMode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ContentPart>(deep);
    }

   
}
/// <summary>
/// <para>Defines the NonVisualDrawingProperties Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr14:cNvPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnHover &lt;a:hlinkHover></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
{
    private const string tagName = "cNvPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 47;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12775;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","name","descr","hidden","title" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> descr.</para>
    /// <para>Represents the following attribute in the schema: descr </para>
    /// </summary>
    [SchemaAttr(0, "descr")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
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
    /// <para> HyperlinkOnClick.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkClick </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick HyperlinkOnClick
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "descr" == name)
    return new StringValue();
    
if( 0 == namespaceId && "hidden" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "title" == name)
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
        return CloneImp<NonVisualDrawingProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the NonVisualInkContentPartProperties Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr14:cNvContentPartPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks &lt;a14:cpLocks></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList &lt;a14:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NonVisualInkContentPartProperties : OpenXmlCompositeElement
{
    private const string tagName = "cNvContentPartPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 47;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12776;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "isComment" };
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
    /// <para> isComment.</para>
    /// <para>Represents the following attribute in the schema: isComment </para>
    /// </summary>
    [SchemaAttr(0, "isComment")]
    public BooleanValue IsComment
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class.
    /// </summary>
    public NonVisualInkContentPartProperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualInkContentPartProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualInkContentPartProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualInkContentPartProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 48 == namespaceId && "cpLocks" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks();
    
if( 48 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cpLocks","extLst" };
    private static readonly byte[] eleNamespaceIds = { 48,48 };
    
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
    /// <para> ContentPartLocks.</para>
    /// <para> Represents the following element tag in the schema: a14:cpLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks ContentPartLocks
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList OfficeArtExtensionList
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "isComment" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<NonVisualInkContentPartProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the NonVisualContentPartProperties Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr14:nvContentPartPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;cdr14:cNvPr></description></item>
///<item><description>NonVisualInkContentPartProperties &lt;cdr14:cNvContentPartPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(NonVisualDrawingProperties),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(NonVisualInkContentPartProperties),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NonVisualContentPartProperties : OpenXmlCompositeElement
{
    private const string tagName = "nvContentPartPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 47;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12777;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualContentPartProperties class.
    /// </summary>
    public NonVisualContentPartProperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the NonVisualContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualContentPartProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualContentPartProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualContentPartProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualContentPartProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 47 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 47 == namespaceId && "cNvContentPartPr" == name)
    return new NonVisualInkContentPartProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvContentPartPr" };
    private static readonly byte[] eleNamespaceIds = { 47,47 };
    
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
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: cdr14:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr14 = http://schemas.microsoft.com/office/drawing/2010/chartDrawing
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get 
        {
            return GetElement<NonVisualDrawingProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> NonVisualInkContentPartProperties.</para>
    /// <para> Represents the following element tag in the schema: cdr14:cNvContentPartPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdr14 = http://schemas.microsoft.com/office/drawing/2010/chartDrawing
    /// </remark>
    public NonVisualInkContentPartProperties NonVisualInkContentPartProperties
    {
        get 
        {
            return GetElement<NonVisualInkContentPartProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<NonVisualContentPartProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ApplicationNonVisualDrawingProperties Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr14:nvPr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ApplicationNonVisualDrawingProperties : OpenXmlLeafElement
{
    private const string tagName = "nvPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 47;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12778;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "macro","fPublished" };
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
    /// <para> macro.</para>
    /// <para>Represents the following attribute in the schema: macro </para>
    /// </summary>
    [SchemaAttr(0, "macro")]
    public StringValue Macro
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> fPublished.</para>
    /// <para>Represents the following attribute in the schema: fPublished </para>
    /// </summary>
    [SchemaAttr(0, "fPublished")]
    public BooleanValue Published
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class.
    /// </summary>
    public ApplicationNonVisualDrawingProperties():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "macro" == name)
    return new StringValue();
    
if( 0 == namespaceId && "fPublished" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ApplicationNonVisualDrawingProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Transform2D Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr14:xfrm.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Offset &lt;a:off></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Extents &lt;a:ext></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Offset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extents))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Transform2D : OpenXmlCompositeElement
{
    private const string tagName = "xfrm";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 47;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12779;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "rot","flipH","flipV" };
    private static byte[] attributeNamespaceIds = { 0,0,0 };
    
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
    /// <para> Rotation.</para>
    /// <para>Represents the following attribute in the schema: rot </para>
    /// </summary>
    [SchemaAttr(0, "rot")]
    public Int32Value Rotation
    {
        get { return (Int32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Flip.</para>
    /// <para>Represents the following attribute in the schema: flipH </para>
    /// </summary>
    [SchemaAttr(0, "flipH")]
    public BooleanValue HorizontalFlip
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Vertical Flip.</para>
    /// <para>Represents the following attribute in the schema: flipV </para>
    /// </summary>
    [SchemaAttr(0, "flipV")]
    public BooleanValue VerticalFlip
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

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
    /// <para> Offset.</para>
    /// <para> Represents the following element tag in the schema: a:off </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Offset Offset
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Offset>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Extents>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rot" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "flipH" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "flipV" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Transform2D>(deep);
    }

   
}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdr14:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    private const string tagName = "extLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 47;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12780;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Drawing.Extension();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<OfficeArtExtensionList>(deep);
    }

   
}
}
 
 
