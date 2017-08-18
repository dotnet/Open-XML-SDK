﻿// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
/// <summary>
/// <para>Color Transform Definitions. The root element of DiagramColorsPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:colorsDef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ColorDefinitionTitle &lt;dgm:title></description></item>
///<item><description>ColorTransformDescription &lt;dgm:desc></description></item>
///<item><description>ColorTransformCategories &lt;dgm:catLst></description></item>
///<item><description>ColorTransformStyleLabel &lt;dgm:styleLbl></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ColorDefinitionTitle))]
    [ChildElementInfo(typeof(ColorTransformDescription))]
    [ChildElementInfo(typeof(ColorTransformCategories))]
    [ChildElementInfo(typeof(ColorTransformStyleLabel))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorsDefinition : OpenXmlPartRootElement
{
    private const string tagName = "colorsDef";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10682;
    
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
    

    private static string[] attributeTagNames = { "uniqueId","minVer" };
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
    /// <para> Unique ID.</para>
    /// <para>Represents the following attribute in the schema: uniqueId </para>
    /// </summary>
    [SchemaAttr(0, "uniqueId")]
    public StringValue UniqueId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Minimum Version.</para>
    /// <para>Represents the following attribute in the schema: minVer </para>
    /// </summary>
    [SchemaAttr(0, "minVer")]
    public StringValue MinVersion
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    
    /// <summary>
    /// ColorsDefinition constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the ColorsDefinition.</param>
    internal ColorsDefinition(DiagramColorsPart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the DiagramColorsPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(DiagramColorsPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the DiagramColorsPart associated with this element.
    /// </summary>
    public DiagramColorsPart DiagramColorsPart
    {
		get
		{
			return OpenXmlPart as DiagramColorsPart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the ColorsDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorsDefinition(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorsDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorsDefinition(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorsDefinition class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorsDefinition(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the ColorsDefinition class.
    /// </summary>
    public ColorsDefinition() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the DiagramColorsPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(DiagramColorsPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "title" == name)
    return new ColorDefinitionTitle();
    
if( 14 == namespaceId && "desc" == name)
    return new ColorTransformDescription();
    
if( 14 == namespaceId && "catLst" == name)
    return new ColorTransformCategories();
    
if( 14 == namespaceId && "styleLbl" == name)
    return new ColorTransformStyleLabel();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "uniqueId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "minVer" == name)
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
        return CloneImp<ColorsDefinition>(deep);
    }

}
/// <summary>
/// <para>Color Transform Header.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:colorsDefHdr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ColorDefinitionTitle &lt;dgm:title></description></item>
///<item><description>ColorTransformDescription &lt;dgm:desc></description></item>
///<item><description>ColorTransformCategories &lt;dgm:catLst></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ColorDefinitionTitle))]
    [ChildElementInfo(typeof(ColorTransformDescription))]
    [ChildElementInfo(typeof(ColorTransformCategories))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorsDefinitionHeader : OpenXmlCompositeElement
{
    private const string tagName = "colorsDefHdr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10683;
    
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
    

    private static string[] attributeTagNames = { "uniqueId","minVer","resId" };
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
    /// <para> Unique ID.</para>
    /// <para>Represents the following attribute in the schema: uniqueId </para>
    /// </summary>
    [SchemaAttr(0, "uniqueId")]
    public StringValue UniqueId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Minimum Version.</para>
    /// <para>Represents the following attribute in the schema: minVer </para>
    /// </summary>
    [SchemaAttr(0, "minVer")]
    public StringValue MinVersion
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Resource ID.</para>
    /// <para>Represents the following attribute in the schema: resId </para>
    /// </summary>
    [SchemaAttr(0, "resId")]
    public Int32Value ResourceId
    {
        get { return (Int32Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColorsDefinitionHeader class.
    /// </summary>
    public ColorsDefinitionHeader():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ColorsDefinitionHeader class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorsDefinitionHeader(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorsDefinitionHeader class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorsDefinitionHeader(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorsDefinitionHeader class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorsDefinitionHeader(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "title" == name)
    return new ColorDefinitionTitle();
    
if( 14 == namespaceId && "desc" == name)
    return new ColorTransformDescription();
    
if( 14 == namespaceId && "catLst" == name)
    return new ColorTransformCategories();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "uniqueId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "minVer" == name)
    return new StringValue();
    
if( 0 == namespaceId && "resId" == name)
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
        return CloneImp<ColorsDefinitionHeader>(deep);
    }

   
}
/// <summary>
/// <para>Color Transform Header List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:colorsDefHdrLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ColorsDefinitionHeader &lt;dgm:colorsDefHdr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ColorsDefinitionHeader))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorsDefinitionHeaderList : OpenXmlCompositeElement
{
    private const string tagName = "colorsDefHdrLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10684;
    
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
    /// Initializes a new instance of the ColorsDefinitionHeaderList class.
    /// </summary>
    public ColorsDefinitionHeaderList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ColorsDefinitionHeaderList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorsDefinitionHeaderList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorsDefinitionHeaderList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorsDefinitionHeaderList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorsDefinitionHeaderList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorsDefinitionHeaderList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "colorsDefHdr" == name)
    return new ColorsDefinitionHeader();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ColorsDefinitionHeaderList>(deep);
    }

   
}
/// <summary>
/// <para>Data Model. The root element of DiagramDataPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:dataModel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PointList &lt;dgm:ptLst></description></item>
///<item><description>ConnectionList &lt;dgm:cxnLst></description></item>
///<item><description>Background &lt;dgm:bg></description></item>
///<item><description>Whole &lt;dgm:whole></description></item>
///<item><description>DataModelExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PointList))]
    [ChildElementInfo(typeof(ConnectionList))]
    [ChildElementInfo(typeof(Background))]
    [ChildElementInfo(typeof(Whole))]
    [ChildElementInfo(typeof(DataModelExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DataModelRoot : OpenXmlPartRootElement
{
    private const string tagName = "dataModel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10685;
    
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
    /// DataModelRoot constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the DataModelRoot.</param>
    internal DataModelRoot(DiagramDataPart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the DiagramDataPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(DiagramDataPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the DiagramDataPart associated with this element.
    /// </summary>
    public DiagramDataPart DiagramDataPart
    {
		get
		{
			return OpenXmlPart as DiagramDataPart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the DataModelRoot class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataModelRoot(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataModelRoot class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataModelRoot(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataModelRoot class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataModelRoot(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the DataModelRoot class.
    /// </summary>
    public DataModelRoot() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the DiagramDataPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(DiagramDataPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "ptLst" == name)
    return new PointList();
    
if( 14 == namespaceId && "cxnLst" == name)
    return new ConnectionList();
    
if( 14 == namespaceId && "bg" == name)
    return new Background();
    
if( 14 == namespaceId && "whole" == name)
    return new Whole();
    
if( 14 == namespaceId && "extLst" == name)
    return new DataModelExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ptLst","cxnLst","bg","whole","extLst" };
    private static readonly byte[] eleNamespaceIds = { 14,14,14,14,14 };
    
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
    /// <para> Point List.</para>
    /// <para> Represents the following element tag in the schema: dgm:ptLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public PointList PointList
    {
        get 
        {
            return GetElement<PointList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Connection List.</para>
    /// <para> Represents the following element tag in the schema: dgm:cxnLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ConnectionList ConnectionList
    {
        get 
        {
            return GetElement<ConnectionList>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Background Formatting.</para>
    /// <para> Represents the following element tag in the schema: dgm:bg </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public Background Background
    {
        get 
        {
            return GetElement<Background>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Whole E2O Formatting.</para>
    /// <para> Represents the following element tag in the schema: dgm:whole </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public Whole Whole
    {
        get 
        {
            return GetElement<Whole>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> DataModelExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dgm:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public DataModelExtensionList DataModelExtensionList
    {
        get 
        {
            return GetElement<DataModelExtensionList>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DataModelRoot>(deep);
    }

}
/// <summary>
/// <para>Layout Definition. The root element of DiagramLayoutDefinitionPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:layoutDef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Title &lt;dgm:title></description></item>
///<item><description>Description &lt;dgm:desc></description></item>
///<item><description>CategoryList &lt;dgm:catLst></description></item>
///<item><description>SampleData &lt;dgm:sampData></description></item>
///<item><description>StyleData &lt;dgm:styleData></description></item>
///<item><description>ColorData &lt;dgm:clrData></description></item>
///<item><description>LayoutNode &lt;dgm:layoutNode></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Title))]
    [ChildElementInfo(typeof(Description))]
    [ChildElementInfo(typeof(CategoryList))]
    [ChildElementInfo(typeof(SampleData))]
    [ChildElementInfo(typeof(StyleData))]
    [ChildElementInfo(typeof(ColorData))]
    [ChildElementInfo(typeof(LayoutNode))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LayoutDefinition : OpenXmlPartRootElement
{
    private const string tagName = "layoutDef";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10686;
    
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
    

    private static string[] attributeTagNames = { "uniqueId","minVer","defStyle" };
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
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: uniqueId </para>
    /// </summary>
    [SchemaAttr(0, "uniqueId")]
    public StringValue UniqueId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Minimum Version.</para>
    /// <para>Represents the following attribute in the schema: minVer </para>
    /// </summary>
    [SchemaAttr(0, "minVer")]
    public StringValue MinVersion
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Default Style.</para>
    /// <para>Represents the following attribute in the schema: defStyle </para>
    /// </summary>
    [SchemaAttr(0, "defStyle")]
    public StringValue DefaultStyle
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    
    /// <summary>
    /// LayoutDefinition constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the LayoutDefinition.</param>
    internal LayoutDefinition(DiagramLayoutDefinitionPart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the DiagramLayoutDefinitionPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(DiagramLayoutDefinitionPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the DiagramLayoutDefinitionPart associated with this element.
    /// </summary>
    public DiagramLayoutDefinitionPart DiagramLayoutDefinitionPart
    {
		get
		{
			return OpenXmlPart as DiagramLayoutDefinitionPart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the LayoutDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutDefinition(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutDefinition(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutDefinition class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LayoutDefinition(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the LayoutDefinition class.
    /// </summary>
    public LayoutDefinition() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the DiagramLayoutDefinitionPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(DiagramLayoutDefinitionPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "title" == name)
    return new Title();
    
if( 14 == namespaceId && "desc" == name)
    return new Description();
    
if( 14 == namespaceId && "catLst" == name)
    return new CategoryList();
    
if( 14 == namespaceId && "sampData" == name)
    return new SampleData();
    
if( 14 == namespaceId && "styleData" == name)
    return new StyleData();
    
if( 14 == namespaceId && "clrData" == name)
    return new ColorData();
    
if( 14 == namespaceId && "layoutNode" == name)
    return new LayoutNode();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "uniqueId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "minVer" == name)
    return new StringValue();
    
if( 0 == namespaceId && "defStyle" == name)
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
        return CloneImp<LayoutDefinition>(deep);
    }

}
/// <summary>
/// <para>Layout Definition Header.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:layoutDefHdr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Title &lt;dgm:title></description></item>
///<item><description>Description &lt;dgm:desc></description></item>
///<item><description>CategoryList &lt;dgm:catLst></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Title))]
    [ChildElementInfo(typeof(Description))]
    [ChildElementInfo(typeof(CategoryList))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LayoutDefinitionHeader : OpenXmlCompositeElement
{
    private const string tagName = "layoutDefHdr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10687;
    
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
    

    private static string[] attributeTagNames = { "uniqueId","minVer","defStyle","resId" };
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
    /// <para> Unique Identifier.</para>
    /// <para>Represents the following attribute in the schema: uniqueId </para>
    /// </summary>
    [SchemaAttr(0, "uniqueId")]
    public StringValue UniqueId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Minimum Version.</para>
    /// <para>Represents the following attribute in the schema: minVer </para>
    /// </summary>
    [SchemaAttr(0, "minVer")]
    public StringValue MinVersion
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Default Style.</para>
    /// <para>Represents the following attribute in the schema: defStyle </para>
    /// </summary>
    [SchemaAttr(0, "defStyle")]
    public StringValue DefaultStyle
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Resource Identifier.</para>
    /// <para>Represents the following attribute in the schema: resId </para>
    /// </summary>
    [SchemaAttr(0, "resId")]
    public Int32Value ResourceId
    {
        get { return (Int32Value)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LayoutDefinitionHeader class.
    /// </summary>
    public LayoutDefinitionHeader():base(){}
    
            /// <summary>
    ///Initializes a new instance of the LayoutDefinitionHeader class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutDefinitionHeader(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutDefinitionHeader class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutDefinitionHeader(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutDefinitionHeader class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LayoutDefinitionHeader(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "title" == name)
    return new Title();
    
if( 14 == namespaceId && "desc" == name)
    return new Description();
    
if( 14 == namespaceId && "catLst" == name)
    return new CategoryList();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "uniqueId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "minVer" == name)
    return new StringValue();
    
if( 0 == namespaceId && "defStyle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "resId" == name)
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
        return CloneImp<LayoutDefinitionHeader>(deep);
    }

   
}
/// <summary>
/// <para>Diagram Layout Header List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:layoutDefHdrLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LayoutDefinitionHeader &lt;dgm:layoutDefHdr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(LayoutDefinitionHeader))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LayoutDefinitionHeaderList : OpenXmlCompositeElement
{
    private const string tagName = "layoutDefHdrLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10688;
    
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
    /// Initializes a new instance of the LayoutDefinitionHeaderList class.
    /// </summary>
    public LayoutDefinitionHeaderList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the LayoutDefinitionHeaderList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutDefinitionHeaderList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutDefinitionHeaderList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutDefinitionHeaderList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutDefinitionHeaderList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LayoutDefinitionHeaderList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "layoutDefHdr" == name)
    return new LayoutDefinitionHeader();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LayoutDefinitionHeaderList>(deep);
    }

   
}
/// <summary>
/// <para>Explicit Relationships to Diagram Parts.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:relIds.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RelationshipIds : OpenXmlLeafElement
{
    private const string tagName = "relIds";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10689;
    
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
    

    private static string[] attributeTagNames = { "dm","lo","qs","cs" };
    private static byte[] attributeNamespaceIds = { 19,19,19,19 };
    
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
    /// <para> Explicit Relationship to Diagram Data Part.</para>
    /// <para>Represents the following attribute in the schema: r:dm </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "dm")]
    public StringValue DataPart
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Explicit Relationship to Diagram Layout Definition Part.</para>
    /// <para>Represents the following attribute in the schema: r:lo </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "lo")]
    public StringValue LayoutPart
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Explicit Relationship to Style Definition Part.</para>
    /// <para>Represents the following attribute in the schema: r:qs </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "qs")]
    public StringValue StylePart
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Explicit Relationship to Diagram Colors Part.</para>
    /// <para>Represents the following attribute in the schema: r:cs </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "cs")]
    public StringValue ColorPart
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RelationshipIds class.
    /// </summary>
    public RelationshipIds():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 19 == namespaceId && "dm" == name)
    return new StringValue();
    
if( 19 == namespaceId && "lo" == name)
    return new StringValue();
    
if( 19 == namespaceId && "qs" == name)
    return new StringValue();
    
if( 19 == namespaceId && "cs" == name)
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
        return CloneImp<RelationshipIds>(deep);
    }

   
}
/// <summary>
/// <para>Style Definition. The root element of DiagramStylePart.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:styleDef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StyleDefinitionTitle &lt;dgm:title></description></item>
///<item><description>StyleLabelDescription &lt;dgm:desc></description></item>
///<item><description>StyleDisplayCategories &lt;dgm:catLst></description></item>
///<item><description>Scene3D &lt;dgm:scene3d></description></item>
///<item><description>StyleLabel &lt;dgm:styleLbl></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(StyleDefinitionTitle))]
    [ChildElementInfo(typeof(StyleLabelDescription))]
    [ChildElementInfo(typeof(StyleDisplayCategories))]
    [ChildElementInfo(typeof(Scene3D))]
    [ChildElementInfo(typeof(StyleLabel))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StyleDefinition : OpenXmlPartRootElement
{
    private const string tagName = "styleDef";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10690;
    
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
    

    private static string[] attributeTagNames = { "uniqueId","minVer" };
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
    /// <para> Unique Style ID.</para>
    /// <para>Represents the following attribute in the schema: uniqueId </para>
    /// </summary>
    [SchemaAttr(0, "uniqueId")]
    public StringValue UniqueId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Minimum Version.</para>
    /// <para>Represents the following attribute in the schema: minVer </para>
    /// </summary>
    [SchemaAttr(0, "minVer")]
    public StringValue MinVersion
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    
    /// <summary>
    /// StyleDefinition constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the StyleDefinition.</param>
    internal StyleDefinition(DiagramStylePart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the DiagramStylePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(DiagramStylePart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the DiagramStylePart associated with this element.
    /// </summary>
    public DiagramStylePart DiagramStylePart
    {
		get
		{
			return OpenXmlPart as DiagramStylePart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the StyleDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleDefinition(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleDefinition(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleDefinition class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StyleDefinition(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the StyleDefinition class.
    /// </summary>
    public StyleDefinition() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the DiagramStylePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(DiagramStylePart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "title" == name)
    return new StyleDefinitionTitle();
    
if( 14 == namespaceId && "desc" == name)
    return new StyleLabelDescription();
    
if( 14 == namespaceId && "catLst" == name)
    return new StyleDisplayCategories();
    
if( 14 == namespaceId && "scene3d" == name)
    return new Scene3D();
    
if( 14 == namespaceId && "styleLbl" == name)
    return new StyleLabel();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "uniqueId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "minVer" == name)
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
        return CloneImp<StyleDefinition>(deep);
    }

}
/// <summary>
/// <para>Style Definition Header.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:styleDefHdr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StyleDefinitionTitle &lt;dgm:title></description></item>
///<item><description>StyleLabelDescription &lt;dgm:desc></description></item>
///<item><description>StyleDisplayCategories &lt;dgm:catLst></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(StyleDefinitionTitle))]
    [ChildElementInfo(typeof(StyleLabelDescription))]
    [ChildElementInfo(typeof(StyleDisplayCategories))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StyleDefinitionHeader : OpenXmlCompositeElement
{
    private const string tagName = "styleDefHdr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10691;
    
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
    

    private static string[] attributeTagNames = { "uniqueId","minVer","resId" };
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
    /// <para> Unique Style ID.</para>
    /// <para>Represents the following attribute in the schema: uniqueId </para>
    /// </summary>
    [SchemaAttr(0, "uniqueId")]
    public StringValue UniqueId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Minimum Version.</para>
    /// <para>Represents the following attribute in the schema: minVer </para>
    /// </summary>
    [SchemaAttr(0, "minVer")]
    public StringValue MinVersion
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Resource ID.</para>
    /// <para>Represents the following attribute in the schema: resId </para>
    /// </summary>
    [SchemaAttr(0, "resId")]
    public Int32Value ResourceId
    {
        get { return (Int32Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StyleDefinitionHeader class.
    /// </summary>
    public StyleDefinitionHeader():base(){}
    
            /// <summary>
    ///Initializes a new instance of the StyleDefinitionHeader class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleDefinitionHeader(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleDefinitionHeader class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleDefinitionHeader(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleDefinitionHeader class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StyleDefinitionHeader(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "title" == name)
    return new StyleDefinitionTitle();
    
if( 14 == namespaceId && "desc" == name)
    return new StyleLabelDescription();
    
if( 14 == namespaceId && "catLst" == name)
    return new StyleDisplayCategories();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "uniqueId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "minVer" == name)
    return new StringValue();
    
if( 0 == namespaceId && "resId" == name)
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
        return CloneImp<StyleDefinitionHeader>(deep);
    }

   
}
/// <summary>
/// <para>List of Style Definition Headers.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:styleDefHdrLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StyleDefinitionHeader &lt;dgm:styleDefHdr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(StyleDefinitionHeader))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StyleDefinitionHeaderList : OpenXmlCompositeElement
{
    private const string tagName = "styleDefHdrLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10692;
    
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
    /// Initializes a new instance of the StyleDefinitionHeaderList class.
    /// </summary>
    public StyleDefinitionHeaderList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the StyleDefinitionHeaderList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleDefinitionHeaderList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleDefinitionHeaderList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleDefinitionHeaderList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleDefinitionHeaderList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StyleDefinitionHeaderList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "styleDefHdr" == name)
    return new StyleDefinitionHeader();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StyleDefinitionHeaderList>(deep);
    }

   
}
/// <summary>
/// <para>Color Transform Category.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:cat.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorTransformCategory : OpenXmlLeafElement
{
    private const string tagName = "cat";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10693;
    
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
    

    private static string[] attributeTagNames = { "type","pri" };
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
    /// <para> Category Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Priority.</para>
    /// <para>Represents the following attribute in the schema: pri </para>
    /// </summary>
    [SchemaAttr(0, "pri")]
    public UInt32Value Priority
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColorTransformCategory class.
    /// </summary>
    public ColorTransformCategory():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new StringValue();
    
if( 0 == namespaceId && "pri" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ColorTransformCategory>(deep);
    }

   
}
/// <summary>
/// <para>Fill Color List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:fillClrLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FillColorList : ColorsType
{
    private const string tagName = "fillClrLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10694;
    
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
    /// Initializes a new instance of the FillColorList class.
    /// </summary>
    public FillColorList():base(){}
            /// <summary>
    ///Initializes a new instance of the FillColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FillColorList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FillColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FillColorList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FillColorList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FillColorList(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FillColorList>(deep);
    }

}
/// <summary>
/// <para>Line Color List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:linClrLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LineColorList : ColorsType
{
    private const string tagName = "linClrLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10695;
    
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
    /// Initializes a new instance of the LineColorList class.
    /// </summary>
    public LineColorList():base(){}
            /// <summary>
    ///Initializes a new instance of the LineColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineColorList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LineColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineColorList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LineColorList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LineColorList(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LineColorList>(deep);
    }

}
/// <summary>
/// <para>Effect Color List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:effectClrLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EffectColorList : ColorsType
{
    private const string tagName = "effectClrLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10696;
    
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
    /// Initializes a new instance of the EffectColorList class.
    /// </summary>
    public EffectColorList():base(){}
            /// <summary>
    ///Initializes a new instance of the EffectColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EffectColorList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the EffectColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EffectColorList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the EffectColorList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public EffectColorList(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EffectColorList>(deep);
    }

}
/// <summary>
/// <para>Text Line Color List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:txLinClrLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TextLineColorList : ColorsType
{
    private const string tagName = "txLinClrLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10697;
    
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
    /// Initializes a new instance of the TextLineColorList class.
    /// </summary>
    public TextLineColorList():base(){}
            /// <summary>
    ///Initializes a new instance of the TextLineColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextLineColorList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextLineColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextLineColorList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextLineColorList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextLineColorList(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TextLineColorList>(deep);
    }

}
/// <summary>
/// <para>Text Fill Color List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:txFillClrLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TextFillColorList : ColorsType
{
    private const string tagName = "txFillClrLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10698;
    
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
    /// Initializes a new instance of the TextFillColorList class.
    /// </summary>
    public TextFillColorList():base(){}
            /// <summary>
    ///Initializes a new instance of the TextFillColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextFillColorList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextFillColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextFillColorList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextFillColorList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextFillColorList(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TextFillColorList>(deep);
    }

}
/// <summary>
/// <para>Text Effect Color List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:txEffectClrLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TextEffectColorList : ColorsType
{
    private const string tagName = "txEffectClrLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10699;
    
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
    /// Initializes a new instance of the TextEffectColorList class.
    /// </summary>
    public TextEffectColorList():base(){}
            /// <summary>
    ///Initializes a new instance of the TextEffectColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextEffectColorList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextEffectColorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextEffectColorList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextEffectColorList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextEffectColorList(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TextEffectColorList>(deep);
    }

}
/// <summary>
/// Defines the ColorsType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class ColorsType : OpenXmlCompositeElement
{
    private static string[] attributeTagNames = { "meth","hueDir" };
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
    /// <para> Color Application Method Type.</para>
    /// <para>Represents the following attribute in the schema: meth </para>
    /// </summary>
    [SchemaAttr(0, "meth")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues> Method
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Hue Direction.</para>
    /// <para>Represents the following attribute in the schema: hueDir </para>
    /// </summary>
    [SchemaAttr(0, "hueDir")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues> HueDirection
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "scrgbClr" == name)
    return new DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage();
    
if( 10 == namespaceId && "srgbClr" == name)
    return new DocumentFormat.OpenXml.Drawing.RgbColorModelHex();
    
if( 10 == namespaceId && "hslClr" == name)
    return new DocumentFormat.OpenXml.Drawing.HslColor();
    
if( 10 == namespaceId && "sysClr" == name)
    return new DocumentFormat.OpenXml.Drawing.SystemColor();
    
if( 10 == namespaceId && "schemeClr" == name)
    return new DocumentFormat.OpenXml.Drawing.SchemeColor();
    
if( 10 == namespaceId && "prstClr" == name)
    return new DocumentFormat.OpenXml.Drawing.PresetColor();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "meth" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues>();
    
if( 0 == namespaceId && "hueDir" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the ColorsType class.
    /// </summary>
    protected ColorsType(){}
    
            /// <summary>
    ///Initializes a new instance of the ColorsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected ColorsType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected ColorsType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorsType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected ColorsType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:extLst.</para>
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
public partial class ExtensionList : OpenXmlCompositeElement
{
    private const string tagName = "extLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10700;
    
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
    /// Initializes a new instance of the ExtensionList class.
    /// </summary>
    public ExtensionList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ExtensionList(string outerXml)
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
        return CloneImp<ExtensionList>(deep);
    }

   
}
/// <summary>
/// <para>Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:title.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorDefinitionTitle : OpenXmlLeafElement
{
    private const string tagName = "title";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10701;
    
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
    

    private static string[] attributeTagNames = { "lang","val" };
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
    /// <para> Language.</para>
    /// <para>Represents the following attribute in the schema: lang </para>
    /// </summary>
    [SchemaAttr(0, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Description Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColorDefinitionTitle class.
    /// </summary>
    public ColorDefinitionTitle():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 0 == namespaceId && "val" == name)
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
        return CloneImp<ColorDefinitionTitle>(deep);
    }

   
}
/// <summary>
/// <para>Description.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:desc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorTransformDescription : OpenXmlLeafElement
{
    private const string tagName = "desc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10702;
    
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
    

    private static string[] attributeTagNames = { "lang","val" };
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
    /// <para> Language.</para>
    /// <para>Represents the following attribute in the schema: lang </para>
    /// </summary>
    [SchemaAttr(0, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Description Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColorTransformDescription class.
    /// </summary>
    public ColorTransformDescription():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 0 == namespaceId && "val" == name)
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
        return CloneImp<ColorTransformDescription>(deep);
    }

   
}
/// <summary>
/// <para>Color Transform Category List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:catLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ColorTransformCategory &lt;dgm:cat></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ColorTransformCategory))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorTransformCategories : OpenXmlCompositeElement
{
    private const string tagName = "catLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10703;
    
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
    /// Initializes a new instance of the ColorTransformCategories class.
    /// </summary>
    public ColorTransformCategories():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ColorTransformCategories class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorTransformCategories(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorTransformCategories class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorTransformCategories(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorTransformCategories class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorTransformCategories(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "cat" == name)
    return new ColorTransformCategory();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ColorTransformCategories>(deep);
    }

   
}
/// <summary>
/// <para>Style Label.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:styleLbl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FillColorList &lt;dgm:fillClrLst></description></item>
///<item><description>LineColorList &lt;dgm:linClrLst></description></item>
///<item><description>EffectColorList &lt;dgm:effectClrLst></description></item>
///<item><description>TextLineColorList &lt;dgm:txLinClrLst></description></item>
///<item><description>TextFillColorList &lt;dgm:txFillClrLst></description></item>
///<item><description>TextEffectColorList &lt;dgm:txEffectClrLst></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(FillColorList))]
    [ChildElementInfo(typeof(LineColorList))]
    [ChildElementInfo(typeof(EffectColorList))]
    [ChildElementInfo(typeof(TextLineColorList))]
    [ChildElementInfo(typeof(TextFillColorList))]
    [ChildElementInfo(typeof(TextEffectColorList))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorTransformStyleLabel : OpenXmlCompositeElement
{
    private const string tagName = "styleLbl";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10704;
    
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
    

    private static string[] attributeTagNames = { "name" };
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
    /// <para> Name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColorTransformStyleLabel class.
    /// </summary>
    public ColorTransformStyleLabel():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ColorTransformStyleLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorTransformStyleLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorTransformStyleLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorTransformStyleLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorTransformStyleLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorTransformStyleLabel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "fillClrLst" == name)
    return new FillColorList();
    
if( 14 == namespaceId && "linClrLst" == name)
    return new LineColorList();
    
if( 14 == namespaceId && "effectClrLst" == name)
    return new EffectColorList();
    
if( 14 == namespaceId && "txLinClrLst" == name)
    return new TextLineColorList();
    
if( 14 == namespaceId && "txFillClrLst" == name)
    return new TextFillColorList();
    
if( 14 == namespaceId && "txEffectClrLst" == name)
    return new TextEffectColorList();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "fillClrLst","linClrLst","effectClrLst","txLinClrLst","txFillClrLst","txEffectClrLst","extLst" };
    private static readonly byte[] eleNamespaceIds = { 14,14,14,14,14,14,14 };
    
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
    /// <para> Fill Color List.</para>
    /// <para> Represents the following element tag in the schema: dgm:fillClrLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public FillColorList FillColorList
    {
        get 
        {
            return GetElement<FillColorList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Line Color List.</para>
    /// <para> Represents the following element tag in the schema: dgm:linClrLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public LineColorList LineColorList
    {
        get 
        {
            return GetElement<LineColorList>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Effect Color List.</para>
    /// <para> Represents the following element tag in the schema: dgm:effectClrLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public EffectColorList EffectColorList
    {
        get 
        {
            return GetElement<EffectColorList>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Text Line Color List.</para>
    /// <para> Represents the following element tag in the schema: dgm:txLinClrLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public TextLineColorList TextLineColorList
    {
        get 
        {
            return GetElement<TextLineColorList>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Text Fill Color List.</para>
    /// <para> Represents the following element tag in the schema: dgm:txFillClrLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public TextFillColorList TextFillColorList
    {
        get 
        {
            return GetElement<TextFillColorList>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> Text Effect Color List.</para>
    /// <para> Represents the following element tag in the schema: dgm:txEffectClrLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public TextEffectColorList TextEffectColorList
    {
        get 
        {
            return GetElement<TextEffectColorList>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dgm:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(6);
        }
        set
        {
            SetElement(6, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
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
        return CloneImp<ColorTransformStyleLabel>(deep);
    }

   
}
/// <summary>
/// <para>Point.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:pt.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PropertySet &lt;dgm:prSet></description></item>
///<item><description>ShapeProperties &lt;dgm:spPr></description></item>
///<item><description>TextBody &lt;dgm:t></description></item>
///<item><description>PtExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PropertySet))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(TextBody))]
    [ChildElementInfo(typeof(PtExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Point : OpenXmlCompositeElement
{
    private const string tagName = "pt";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10705;
    
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
    

    private static string[] attributeTagNames = { "modelId","type","cxnId" };
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
    /// <para> Model Identifier.</para>
    /// <para>Represents the following attribute in the schema: modelId </para>
    /// </summary>
    [SchemaAttr(0, "modelId")]
    public StringValue ModelId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Point Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Connection Identifier.</para>
    /// <para>Represents the following attribute in the schema: cxnId </para>
    /// </summary>
    [SchemaAttr(0, "cxnId")]
    public StringValue ConnectionId
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Point class.
    /// </summary>
    public Point():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Point class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Point(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Point class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Point(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Point class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Point(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "prSet" == name)
    return new PropertySet();
    
if( 14 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 14 == namespaceId && "t" == name)
    return new TextBody();
    
if( 14 == namespaceId && "extLst" == name)
    return new PtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "prSet","spPr","t","extLst" };
    private static readonly byte[] eleNamespaceIds = { 14,14,14,14 };
    
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
    /// <para> Property Set.</para>
    /// <para> Represents the following element tag in the schema: dgm:prSet </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public PropertySet PropertySet
    {
        get 
        {
            return GetElement<PropertySet>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: dgm:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get 
        {
            return GetElement<ShapeProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Text Body.</para>
    /// <para> Represents the following element tag in the schema: dgm:t </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public TextBody TextBody
    {
        get 
        {
            return GetElement<TextBody>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> PtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dgm:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public PtExtensionList PtExtensionList
    {
        get 
        {
            return GetElement<PtExtensionList>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "modelId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues>();
    
if( 0 == namespaceId && "cxnId" == name)
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
        return CloneImp<Point>(deep);
    }

   
}
/// <summary>
/// <para>Connection.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:cxn.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Connection : OpenXmlCompositeElement
{
    private const string tagName = "cxn";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10706;
    
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
    

    private static string[] attributeTagNames = { "modelId","type","srcId","destId","srcOrd","destOrd","parTransId","sibTransId","presId" };
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
    /// <para> Model Identifier.</para>
    /// <para>Represents the following attribute in the schema: modelId </para>
    /// </summary>
    [SchemaAttr(0, "modelId")]
    public StringValue ModelId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Point Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Source Identifier.</para>
    /// <para>Represents the following attribute in the schema: srcId </para>
    /// </summary>
    [SchemaAttr(0, "srcId")]
    public StringValue SourceId
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Destination Identifier.</para>
    /// <para>Represents the following attribute in the schema: destId </para>
    /// </summary>
    [SchemaAttr(0, "destId")]
    public StringValue DestinationId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Source Position.</para>
    /// <para>Represents the following attribute in the schema: srcOrd </para>
    /// </summary>
    [SchemaAttr(0, "srcOrd")]
    public UInt32Value SourcePosition
    {
        get { return (UInt32Value)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Destination Position.</para>
    /// <para>Represents the following attribute in the schema: destOrd </para>
    /// </summary>
    [SchemaAttr(0, "destOrd")]
    public UInt32Value DestinationPosition
    {
        get { return (UInt32Value)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Parent Transition Identifier.</para>
    /// <para>Represents the following attribute in the schema: parTransId </para>
    /// </summary>
    [SchemaAttr(0, "parTransId")]
    public StringValue ParentTransitionId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Sibling Transition Identifier.</para>
    /// <para>Represents the following attribute in the schema: sibTransId </para>
    /// </summary>
    [SchemaAttr(0, "sibTransId")]
    public StringValue SiblingTransitionId
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Presentation Identifier.</para>
    /// <para>Represents the following attribute in the schema: presId </para>
    /// </summary>
    [SchemaAttr(0, "presId")]
    public StringValue PresentationId
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Connection class.
    /// </summary>
    public Connection():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Connection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Connection(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Connection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Connection(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Connection class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Connection(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 14 };
    
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
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dgm:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "modelId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues>();
    
if( 0 == namespaceId && "srcId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "destId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "srcOrd" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "destOrd" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "parTransId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sibTransId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "presId" == name)
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
        return CloneImp<Connection>(deep);
    }

   
}
/// <summary>
/// <para>Constraint.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:constr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Constraint : OpenXmlCompositeElement
{
    private const string tagName = "constr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10707;
    
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
    

    private static string[] attributeTagNames = { "type","for","forName","ptType","refType","refFor","refForName","refPtType","op","val","fact" };
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
    /// <para> Constraint Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> For.</para>
    /// <para>Represents the following attribute in the schema: for </para>
    /// </summary>
    [SchemaAttr(0, "for")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues> For
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> For Name.</para>
    /// <para>Represents the following attribute in the schema: forName </para>
    /// </summary>
    [SchemaAttr(0, "forName")]
    public StringValue ForName
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Data Point Type.</para>
    /// <para>Represents the following attribute in the schema: ptType </para>
    /// </summary>
    [SchemaAttr(0, "ptType")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues> PointType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Reference Type.</para>
    /// <para>Represents the following attribute in the schema: refType </para>
    /// </summary>
    [SchemaAttr(0, "refType")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues> ReferenceType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Reference For.</para>
    /// <para>Represents the following attribute in the schema: refFor </para>
    /// </summary>
    [SchemaAttr(0, "refFor")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues> ReferenceFor
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Reference For Name.</para>
    /// <para>Represents the following attribute in the schema: refForName </para>
    /// </summary>
    [SchemaAttr(0, "refForName")]
    public StringValue ReferenceForName
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Reference Point Type.</para>
    /// <para>Represents the following attribute in the schema: refPtType </para>
    /// </summary>
    [SchemaAttr(0, "refPtType")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues> ReferencePointType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Operator.</para>
    /// <para>Represents the following attribute in the schema: op </para>
    /// </summary>
    [SchemaAttr(0, "op")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues> Operator
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues>)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public DoubleValue Val
    {
        get { return (DoubleValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Factor.</para>
    /// <para>Represents the following attribute in the schema: fact </para>
    /// </summary>
    [SchemaAttr(0, "fact")]
    public DoubleValue Fact
    {
        get { return (DoubleValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Constraint class.
    /// </summary>
    public Constraint():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Constraint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Constraint(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Constraint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Constraint(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Constraint class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Constraint(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 14 };
    
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
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dgm:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>();
    
if( 0 == namespaceId && "for" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>();
    
if( 0 == namespaceId && "forName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ptType" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>();
    
if( 0 == namespaceId && "refType" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>();
    
if( 0 == namespaceId && "refFor" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>();
    
if( 0 == namespaceId && "refForName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "refPtType" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>();
    
if( 0 == namespaceId && "op" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues>();
    
if( 0 == namespaceId && "val" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "fact" == name)
    return new DoubleValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Constraint>(deep);
    }

   
}
/// <summary>
/// <para>Rule.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:rule.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Rule : OpenXmlCompositeElement
{
    private const string tagName = "rule";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10708;
    
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
    

    private static string[] attributeTagNames = { "type","for","forName","ptType","val","fact","max" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0 };
    
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
    /// <para> Constraint Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> For.</para>
    /// <para>Represents the following attribute in the schema: for </para>
    /// </summary>
    [SchemaAttr(0, "for")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues> For
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> For Name.</para>
    /// <para>Represents the following attribute in the schema: forName </para>
    /// </summary>
    [SchemaAttr(0, "forName")]
    public StringValue ForName
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Data Point Type.</para>
    /// <para>Represents the following attribute in the schema: ptType </para>
    /// </summary>
    [SchemaAttr(0, "ptType")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues> PointType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public DoubleValue Val
    {
        get { return (DoubleValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Factor.</para>
    /// <para>Represents the following attribute in the schema: fact </para>
    /// </summary>
    [SchemaAttr(0, "fact")]
    public DoubleValue Fact
    {
        get { return (DoubleValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Max Value.</para>
    /// <para>Represents the following attribute in the schema: max </para>
    /// </summary>
    [SchemaAttr(0, "max")]
    public DoubleValue Max
    {
        get { return (DoubleValue)Attributes[6]; }
        set { Attributes[6] = value; }
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
    if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 14 };
    
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
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dgm:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>();
    
if( 0 == namespaceId && "for" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>();
    
if( 0 == namespaceId && "forName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ptType" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>();
    
if( 0 == namespaceId && "val" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "fact" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "max" == name)
    return new DoubleValue();
    

    
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
/// <para>Shape Adjust.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:adj.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Adjust : OpenXmlLeafElement
{
    private const string tagName = "adj";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10709;
    
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
    

    private static string[] attributeTagNames = { "idx","val" };
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
    /// <para> Adjust Handle Index.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    public UInt32Value Index
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public DoubleValue Val
    {
        get { return (DoubleValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Adjust class.
    /// </summary>
    public Adjust():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "idx" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "val" == name)
    return new DoubleValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Adjust>(deep);
    }

   
}
/// <summary>
/// <para>Shape Adjust List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:adjLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Adjust &lt;dgm:adj></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Adjust))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AdjustList : OpenXmlCompositeElement
{
    private const string tagName = "adjLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10710;
    
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
    /// Initializes a new instance of the AdjustList class.
    /// </summary>
    public AdjustList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AdjustList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AdjustList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AdjustList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AdjustList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AdjustList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AdjustList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "adj" == name)
    return new Adjust();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AdjustList>(deep);
    }

   
}
/// <summary>
/// <para>Parameter.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:param.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Parameter : OpenXmlLeafElement
{
    private const string tagName = "param";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10711;
    
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
    

    private static string[] attributeTagNames = { "type","val" };
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
    /// <para> Parameter Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Parameter class.
    /// </summary>
    public Parameter():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues>();
    
if( 0 == namespaceId && "val" == name)
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
        return CloneImp<Parameter>(deep);
    }

   
}
/// <summary>
/// <para>Algorithm.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:alg.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Parameter &lt;dgm:param></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Parameter))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Algorithm : OpenXmlCompositeElement
{
    private const string tagName = "alg";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10712;
    
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
    

    private static string[] attributeTagNames = { "type","rev" };
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
    /// <para> Algorithm Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Revision Number.</para>
    /// <para>Represents the following attribute in the schema: rev </para>
    /// </summary>
    [SchemaAttr(0, "rev")]
    public UInt32Value Revision
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Algorithm class.
    /// </summary>
    public Algorithm():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Algorithm class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Algorithm(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Algorithm class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Algorithm(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Algorithm class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Algorithm(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "param" == name)
    return new Parameter();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues>();
    
if( 0 == namespaceId && "rev" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Algorithm>(deep);
    }

   
}
/// <summary>
/// <para>Shape.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:shape.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AdjustList &lt;dgm:adjLst></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AdjustList))]
    [ChildElementInfo(typeof(ExtensionList))]
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
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10713;
    
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
    

    private static string[] attributeTagNames = { "rot","type","blip","zOrderOff","hideGeom","lkTxEntry","blipPhldr" };
    private static byte[] attributeNamespaceIds = { 0,0,19,0,0,0,0 };
    
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
    public DoubleValue Rotation
    {
        get { return (DoubleValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Shape Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Relationship to Image Part.</para>
    /// <para>Represents the following attribute in the schema: r:blip </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "blip")]
    public StringValue Blip
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Z-Order Offset.</para>
    /// <para>Represents the following attribute in the schema: zOrderOff </para>
    /// </summary>
    [SchemaAttr(0, "zOrderOff")]
    public Int32Value ZOrderOffset
    {
        get { return (Int32Value)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Hide Geometry.</para>
    /// <para>Represents the following attribute in the schema: hideGeom </para>
    /// </summary>
    [SchemaAttr(0, "hideGeom")]
    public BooleanValue HideGeometry
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Prevent Text Editing.</para>
    /// <para>Represents the following attribute in the schema: lkTxEntry </para>
    /// </summary>
    [SchemaAttr(0, "lkTxEntry")]
    public BooleanValue LockedText
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Image Placeholder.</para>
    /// <para>Represents the following attribute in the schema: blipPhldr </para>
    /// </summary>
    [SchemaAttr(0, "blipPhldr")]
    public BooleanValue BlipPlaceholder
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
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
    if( 14 == namespaceId && "adjLst" == name)
    return new AdjustList();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "adjLst","extLst" };
    private static readonly byte[] eleNamespaceIds = { 14,14 };
    
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
    /// <para> Shape Adjust List.</para>
    /// <para> Represents the following element tag in the schema: dgm:adjLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public AdjustList AdjustList
    {
        get 
        {
            return GetElement<AdjustList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dgm:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "rot" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "type" == name)
    return new StringValue();
    
if( 19 == namespaceId && "blip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "zOrderOff" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "hideGeom" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "lkTxEntry" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "blipPhldr" == name)
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
        return CloneImp<Shape>(deep);
    }

   
}
/// <summary>
/// <para>Presentation Of.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:presOf.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PresentationOf : OpenXmlCompositeElement
{
    private const string tagName = "presOf";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10714;
    
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
    

    private static string[] attributeTagNames = { "axis","ptType","hideLastTrans","st","cnt","step" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0 };
    
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
    /// <para> Axis.</para>
    /// <para>Represents the following attribute in the schema: axis </para>
    /// </summary>
    [SchemaAttr(0, "axis")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>> Axis
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Data Point Type.</para>
    /// <para>Represents the following attribute in the schema: ptType </para>
    /// </summary>
    [SchemaAttr(0, "ptType")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>> PointType
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Hide Last Transition.</para>
    /// <para>Represents the following attribute in the schema: hideLastTrans </para>
    /// </summary>
    [SchemaAttr(0, "hideLastTrans")]
    public ListValue<BooleanValue> HideLastTrans
    {
        get { return (ListValue<BooleanValue>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Start.</para>
    /// <para>Represents the following attribute in the schema: st </para>
    /// </summary>
    [SchemaAttr(0, "st")]
    public ListValue<Int32Value> Start
    {
        get { return (ListValue<Int32Value>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Count.</para>
    /// <para>Represents the following attribute in the schema: cnt </para>
    /// </summary>
    [SchemaAttr(0, "cnt")]
    public ListValue<UInt32Value> Count
    {
        get { return (ListValue<UInt32Value>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Step.</para>
    /// <para>Represents the following attribute in the schema: step </para>
    /// </summary>
    [SchemaAttr(0, "step")]
    public ListValue<Int32Value> Step
    {
        get { return (ListValue<Int32Value>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PresentationOf class.
    /// </summary>
    public PresentationOf():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PresentationOf class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PresentationOf(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PresentationOf class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PresentationOf(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PresentationOf class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PresentationOf(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 14 };
    
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
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dgm:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "axis" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>();
    
if( 0 == namespaceId && "ptType" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>();
    
if( 0 == namespaceId && "hideLastTrans" == name)
    return new ListValue<BooleanValue>();
    
if( 0 == namespaceId && "st" == name)
    return new ListValue<Int32Value>();
    
if( 0 == namespaceId && "cnt" == name)
    return new ListValue<UInt32Value>();
    
if( 0 == namespaceId && "step" == name)
    return new ListValue<Int32Value>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PresentationOf>(deep);
    }

   
}
/// <summary>
/// <para>Constraint List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:constrLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Constraint &lt;dgm:constr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Constraint))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Constraints : OpenXmlCompositeElement
{
    private const string tagName = "constrLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10715;
    
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
    /// Initializes a new instance of the Constraints class.
    /// </summary>
    public Constraints():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Constraints class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Constraints(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Constraints class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Constraints(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Constraints class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Constraints(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "constr" == name)
    return new Constraint();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Constraints>(deep);
    }

   
}
/// <summary>
/// <para>Rule List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:ruleLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Rule &lt;dgm:rule></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Rule))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RuleList : OpenXmlCompositeElement
{
    private const string tagName = "ruleLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10716;
    
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
    /// Initializes a new instance of the RuleList class.
    /// </summary>
    public RuleList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the RuleList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RuleList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RuleList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RuleList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RuleList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RuleList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "rule" == name)
    return new Rule();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RuleList>(deep);
    }

   
}
/// <summary>
/// <para>Variable List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:varLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OrganizationChart &lt;dgm:orgChart></description></item>
///<item><description>MaxNumberOfChildren &lt;dgm:chMax></description></item>
///<item><description>PreferredNumberOfChildren &lt;dgm:chPref></description></item>
///<item><description>BulletEnabled &lt;dgm:bulletEnabled></description></item>
///<item><description>Direction &lt;dgm:dir></description></item>
///<item><description>HierarchyBranch &lt;dgm:hierBranch></description></item>
///<item><description>AnimateOneByOne &lt;dgm:animOne></description></item>
///<item><description>AnimationLevel &lt;dgm:animLvl></description></item>
///<item><description>ResizeHandles &lt;dgm:resizeHandles></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VariableList : LayoutVariablePropertySetType
{
    private const string tagName = "varLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10717;
    
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
    /// Initializes a new instance of the VariableList class.
    /// </summary>
    public VariableList():base(){}
            /// <summary>
    ///Initializes a new instance of the VariableList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public VariableList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the VariableList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public VariableList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the VariableList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public VariableList(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VariableList>(deep);
    }

}
/// <summary>
/// <para>Presentation Layout Variables.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:presLayoutVars.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OrganizationChart &lt;dgm:orgChart></description></item>
///<item><description>MaxNumberOfChildren &lt;dgm:chMax></description></item>
///<item><description>PreferredNumberOfChildren &lt;dgm:chPref></description></item>
///<item><description>BulletEnabled &lt;dgm:bulletEnabled></description></item>
///<item><description>Direction &lt;dgm:dir></description></item>
///<item><description>HierarchyBranch &lt;dgm:hierBranch></description></item>
///<item><description>AnimateOneByOne &lt;dgm:animOne></description></item>
///<item><description>AnimationLevel &lt;dgm:animLvl></description></item>
///<item><description>ResizeHandles &lt;dgm:resizeHandles></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PresentationLayoutVariables : LayoutVariablePropertySetType
{
    private const string tagName = "presLayoutVars";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10731;
    
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
    /// Initializes a new instance of the PresentationLayoutVariables class.
    /// </summary>
    public PresentationLayoutVariables():base(){}
            /// <summary>
    ///Initializes a new instance of the PresentationLayoutVariables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PresentationLayoutVariables(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PresentationLayoutVariables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PresentationLayoutVariables(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PresentationLayoutVariables class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PresentationLayoutVariables(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PresentationLayoutVariables>(deep);
    }

}
/// <summary>
/// Defines the LayoutVariablePropertySetType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OrganizationChart &lt;dgm:orgChart></description></item>
///<item><description>MaxNumberOfChildren &lt;dgm:chMax></description></item>
///<item><description>PreferredNumberOfChildren &lt;dgm:chPref></description></item>
///<item><description>BulletEnabled &lt;dgm:bulletEnabled></description></item>
///<item><description>Direction &lt;dgm:dir></description></item>
///<item><description>HierarchyBranch &lt;dgm:hierBranch></description></item>
///<item><description>AnimateOneByOne &lt;dgm:animOne></description></item>
///<item><description>AnimationLevel &lt;dgm:animLvl></description></item>
///<item><description>ResizeHandles &lt;dgm:resizeHandles></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(OrganizationChart))]
    [ChildElementInfo(typeof(MaxNumberOfChildren))]
    [ChildElementInfo(typeof(PreferredNumberOfChildren))]
    [ChildElementInfo(typeof(BulletEnabled))]
    [ChildElementInfo(typeof(Direction))]
    [ChildElementInfo(typeof(HierarchyBranch))]
    [ChildElementInfo(typeof(AnimateOneByOne))]
    [ChildElementInfo(typeof(AnimationLevel))]
    [ChildElementInfo(typeof(ResizeHandles))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class LayoutVariablePropertySetType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "orgChart" == name)
    return new OrganizationChart();
    
if( 14 == namespaceId && "chMax" == name)
    return new MaxNumberOfChildren();
    
if( 14 == namespaceId && "chPref" == name)
    return new PreferredNumberOfChildren();
    
if( 14 == namespaceId && "bulletEnabled" == name)
    return new BulletEnabled();
    
if( 14 == namespaceId && "dir" == name)
    return new Direction();
    
if( 14 == namespaceId && "hierBranch" == name)
    return new HierarchyBranch();
    
if( 14 == namespaceId && "animOne" == name)
    return new AnimateOneByOne();
    
if( 14 == namespaceId && "animLvl" == name)
    return new AnimationLevel();
    
if( 14 == namespaceId && "resizeHandles" == name)
    return new ResizeHandles();
    

    return null;
}

        private static readonly string[] eleTagNames = { "orgChart","chMax","chPref","bulletEnabled","dir","hierBranch","animOne","animLvl","resizeHandles" };
    private static readonly byte[] eleNamespaceIds = { 14,14,14,14,14,14,14,14,14 };
    
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
    /// <para> Show Organization Chart User Interface.</para>
    /// <para> Represents the following element tag in the schema: dgm:orgChart </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public OrganizationChart OrganizationChart
    {
        get 
        {
            return GetElement<OrganizationChart>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Maximum Children.</para>
    /// <para> Represents the following element tag in the schema: dgm:chMax </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public MaxNumberOfChildren MaxNumberOfChildren
    {
        get 
        {
            return GetElement<MaxNumberOfChildren>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Preferred Number of Children.</para>
    /// <para> Represents the following element tag in the schema: dgm:chPref </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public PreferredNumberOfChildren PreferredNumberOfChildren
    {
        get 
        {
            return GetElement<PreferredNumberOfChildren>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Show Insert Bullet.</para>
    /// <para> Represents the following element tag in the schema: dgm:bulletEnabled </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public BulletEnabled BulletEnabled
    {
        get 
        {
            return GetElement<BulletEnabled>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Diagram Direction.</para>
    /// <para> Represents the following element tag in the schema: dgm:dir </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public Direction Direction
    {
        get 
        {
            return GetElement<Direction>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> Organization Chart Branch Style.</para>
    /// <para> Represents the following element tag in the schema: dgm:hierBranch </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public HierarchyBranch HierarchyBranch
    {
        get 
        {
            return GetElement<HierarchyBranch>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }
    /// <summary>
    /// <para> One by One Animation String.</para>
    /// <para> Represents the following element tag in the schema: dgm:animOne </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public AnimateOneByOne AnimateOneByOne
    {
        get 
        {
            return GetElement<AnimateOneByOne>(6);
        }
        set
        {
            SetElement(6, value);
        }
    }
    /// <summary>
    /// <para> Level Animation.</para>
    /// <para> Represents the following element tag in the schema: dgm:animLvl </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public AnimationLevel AnimationLevel
    {
        get 
        {
            return GetElement<AnimationLevel>(7);
        }
        set
        {
            SetElement(7, value);
        }
    }
    /// <summary>
    /// <para> Shape Resize Style.</para>
    /// <para> Represents the following element tag in the schema: dgm:resizeHandles </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ResizeHandles ResizeHandles
    {
        get 
        {
            return GetElement<ResizeHandles>(8);
        }
        set
        {
            SetElement(8, value);
        }
    }


    
    
    /// <summary>
    /// Initializes a new instance of the LayoutVariablePropertySetType class.
    /// </summary>
    protected LayoutVariablePropertySetType(){}
    
            /// <summary>
    ///Initializes a new instance of the LayoutVariablePropertySetType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected LayoutVariablePropertySetType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutVariablePropertySetType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected LayoutVariablePropertySetType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutVariablePropertySetType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected LayoutVariablePropertySetType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>For Each.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:forEach.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Algorithm &lt;dgm:alg></description></item>
///<item><description>Shape &lt;dgm:shape></description></item>
///<item><description>PresentationOf &lt;dgm:presOf></description></item>
///<item><description>Constraints &lt;dgm:constrLst></description></item>
///<item><description>RuleList &lt;dgm:ruleLst></description></item>
///<item><description>ForEach &lt;dgm:forEach></description></item>
///<item><description>LayoutNode &lt;dgm:layoutNode></description></item>
///<item><description>Choose &lt;dgm:choose></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Algorithm))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(PresentationOf))]
    [ChildElementInfo(typeof(Constraints))]
    [ChildElementInfo(typeof(RuleList))]
    [ChildElementInfo(typeof(ForEach))]
    [ChildElementInfo(typeof(LayoutNode))]
    [ChildElementInfo(typeof(Choose))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ForEach : OpenXmlCompositeElement
{
    private const string tagName = "forEach";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10718;
    
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
    

    private static string[] attributeTagNames = { "name","ref","axis","ptType","hideLastTrans","st","cnt","step" };
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
    /// <para> Name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Reference.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Axis.</para>
    /// <para>Represents the following attribute in the schema: axis </para>
    /// </summary>
    [SchemaAttr(0, "axis")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>> Axis
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Data Point Type.</para>
    /// <para>Represents the following attribute in the schema: ptType </para>
    /// </summary>
    [SchemaAttr(0, "ptType")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>> PointType
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Hide Last Transition.</para>
    /// <para>Represents the following attribute in the schema: hideLastTrans </para>
    /// </summary>
    [SchemaAttr(0, "hideLastTrans")]
    public ListValue<BooleanValue> HideLastTrans
    {
        get { return (ListValue<BooleanValue>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Start.</para>
    /// <para>Represents the following attribute in the schema: st </para>
    /// </summary>
    [SchemaAttr(0, "st")]
    public ListValue<Int32Value> Start
    {
        get { return (ListValue<Int32Value>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Count.</para>
    /// <para>Represents the following attribute in the schema: cnt </para>
    /// </summary>
    [SchemaAttr(0, "cnt")]
    public ListValue<UInt32Value> Count
    {
        get { return (ListValue<UInt32Value>)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Step.</para>
    /// <para>Represents the following attribute in the schema: step </para>
    /// </summary>
    [SchemaAttr(0, "step")]
    public ListValue<Int32Value> Step
    {
        get { return (ListValue<Int32Value>)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ForEach class.
    /// </summary>
    public ForEach():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ForEach class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ForEach(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ForEach class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ForEach(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ForEach class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ForEach(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "alg" == name)
    return new Algorithm();
    
if( 14 == namespaceId && "shape" == name)
    return new Shape();
    
if( 14 == namespaceId && "presOf" == name)
    return new PresentationOf();
    
if( 14 == namespaceId && "constrLst" == name)
    return new Constraints();
    
if( 14 == namespaceId && "ruleLst" == name)
    return new RuleList();
    
if( 14 == namespaceId && "forEach" == name)
    return new ForEach();
    
if( 14 == namespaceId && "layoutNode" == name)
    return new LayoutNode();
    
if( 14 == namespaceId && "choose" == name)
    return new Choose();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "ref" == name)
    return new StringValue();
    
if( 0 == namespaceId && "axis" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>();
    
if( 0 == namespaceId && "ptType" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>();
    
if( 0 == namespaceId && "hideLastTrans" == name)
    return new ListValue<BooleanValue>();
    
if( 0 == namespaceId && "st" == name)
    return new ListValue<Int32Value>();
    
if( 0 == namespaceId && "cnt" == name)
    return new ListValue<UInt32Value>();
    
if( 0 == namespaceId && "step" == name)
    return new ListValue<Int32Value>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ForEach>(deep);
    }

   
}
/// <summary>
/// <para>Layout Node.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:layoutNode.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Algorithm &lt;dgm:alg></description></item>
///<item><description>Shape &lt;dgm:shape></description></item>
///<item><description>PresentationOf &lt;dgm:presOf></description></item>
///<item><description>Constraints &lt;dgm:constrLst></description></item>
///<item><description>RuleList &lt;dgm:ruleLst></description></item>
///<item><description>VariableList &lt;dgm:varLst></description></item>
///<item><description>ForEach &lt;dgm:forEach></description></item>
///<item><description>LayoutNode &lt;dgm:layoutNode></description></item>
///<item><description>Choose &lt;dgm:choose></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Algorithm))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(PresentationOf))]
    [ChildElementInfo(typeof(Constraints))]
    [ChildElementInfo(typeof(RuleList))]
    [ChildElementInfo(typeof(VariableList))]
    [ChildElementInfo(typeof(ForEach))]
    [ChildElementInfo(typeof(LayoutNode))]
    [ChildElementInfo(typeof(Choose))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LayoutNode : OpenXmlCompositeElement
{
    private const string tagName = "layoutNode";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10719;
    
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
    

    private static string[] attributeTagNames = { "name","styleLbl","chOrder","moveWith" };
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
    /// <para> Name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Style Label.</para>
    /// <para>Represents the following attribute in the schema: styleLbl </para>
    /// </summary>
    [SchemaAttr(0, "styleLbl")]
    public StringValue StyleLabel
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Child Order.</para>
    /// <para>Represents the following attribute in the schema: chOrder </para>
    /// </summary>
    [SchemaAttr(0, "chOrder")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues> ChildOrder
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Move With.</para>
    /// <para>Represents the following attribute in the schema: moveWith </para>
    /// </summary>
    [SchemaAttr(0, "moveWith")]
    public StringValue MoveWith
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LayoutNode class.
    /// </summary>
    public LayoutNode():base(){}
    
            /// <summary>
    ///Initializes a new instance of the LayoutNode class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutNode(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutNode class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutNode(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutNode class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LayoutNode(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "alg" == name)
    return new Algorithm();
    
if( 14 == namespaceId && "shape" == name)
    return new Shape();
    
if( 14 == namespaceId && "presOf" == name)
    return new PresentationOf();
    
if( 14 == namespaceId && "constrLst" == name)
    return new Constraints();
    
if( 14 == namespaceId && "ruleLst" == name)
    return new RuleList();
    
if( 14 == namespaceId && "varLst" == name)
    return new VariableList();
    
if( 14 == namespaceId && "forEach" == name)
    return new ForEach();
    
if( 14 == namespaceId && "layoutNode" == name)
    return new LayoutNode();
    
if( 14 == namespaceId && "choose" == name)
    return new Choose();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "styleLbl" == name)
    return new StringValue();
    
if( 0 == namespaceId && "chOrder" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues>();
    
if( 0 == namespaceId && "moveWith" == name)
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
        return CloneImp<LayoutNode>(deep);
    }

   
}
/// <summary>
/// <para>Choose Element.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:choose.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DiagramChooseIf &lt;dgm:if></description></item>
///<item><description>DiagramChooseElse &lt;dgm:else></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DiagramChooseIf))]
    [ChildElementInfo(typeof(DiagramChooseElse))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Choose : OpenXmlCompositeElement
{
    private const string tagName = "choose";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10720;
    
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
    

    private static string[] attributeTagNames = { "name" };
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
    /// <para> Name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Choose class.
    /// </summary>
    public Choose():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Choose class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Choose(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Choose class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Choose(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Choose class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Choose(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "if" == name)
    return new DiagramChooseIf();
    
if( 14 == namespaceId && "else" == name)
    return new DiagramChooseElse();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
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
        return CloneImp<Choose>(deep);
    }

   
}
/// <summary>
/// <para>If.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:if.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Algorithm &lt;dgm:alg></description></item>
///<item><description>Shape &lt;dgm:shape></description></item>
///<item><description>PresentationOf &lt;dgm:presOf></description></item>
///<item><description>Constraints &lt;dgm:constrLst></description></item>
///<item><description>RuleList &lt;dgm:ruleLst></description></item>
///<item><description>ForEach &lt;dgm:forEach></description></item>
///<item><description>LayoutNode &lt;dgm:layoutNode></description></item>
///<item><description>Choose &lt;dgm:choose></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Algorithm))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(PresentationOf))]
    [ChildElementInfo(typeof(Constraints))]
    [ChildElementInfo(typeof(RuleList))]
    [ChildElementInfo(typeof(ForEach))]
    [ChildElementInfo(typeof(LayoutNode))]
    [ChildElementInfo(typeof(Choose))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DiagramChooseIf : OpenXmlCompositeElement
{
    private const string tagName = "if";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10721;
    
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
    

    private static string[] attributeTagNames = { "name","axis","ptType","hideLastTrans","st","cnt","step","func","arg","op","val" };
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
    /// <para> Name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Axis.</para>
    /// <para>Represents the following attribute in the schema: axis </para>
    /// </summary>
    [SchemaAttr(0, "axis")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>> Axis
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Data Point Type.</para>
    /// <para>Represents the following attribute in the schema: ptType </para>
    /// </summary>
    [SchemaAttr(0, "ptType")]
    public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>> PointType
    {
        get { return (ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Hide Last Transition.</para>
    /// <para>Represents the following attribute in the schema: hideLastTrans </para>
    /// </summary>
    [SchemaAttr(0, "hideLastTrans")]
    public ListValue<BooleanValue> HideLastTrans
    {
        get { return (ListValue<BooleanValue>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Start.</para>
    /// <para>Represents the following attribute in the schema: st </para>
    /// </summary>
    [SchemaAttr(0, "st")]
    public ListValue<Int32Value> Start
    {
        get { return (ListValue<Int32Value>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Count.</para>
    /// <para>Represents the following attribute in the schema: cnt </para>
    /// </summary>
    [SchemaAttr(0, "cnt")]
    public ListValue<UInt32Value> Count
    {
        get { return (ListValue<UInt32Value>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Step.</para>
    /// <para>Represents the following attribute in the schema: step </para>
    /// </summary>
    [SchemaAttr(0, "step")]
    public ListValue<Int32Value> Step
    {
        get { return (ListValue<Int32Value>)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Function.</para>
    /// <para>Represents the following attribute in the schema: func </para>
    /// </summary>
    [SchemaAttr(0, "func")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues> Function
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues>)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Argument.</para>
    /// <para>Represents the following attribute in the schema: arg </para>
    /// </summary>
    [SchemaAttr(0, "arg")]
    public StringValue Argument
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Operator.</para>
    /// <para>Represents the following attribute in the schema: op </para>
    /// </summary>
    [SchemaAttr(0, "op")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues> Operator
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues>)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DiagramChooseIf class.
    /// </summary>
    public DiagramChooseIf():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DiagramChooseIf class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DiagramChooseIf(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DiagramChooseIf class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DiagramChooseIf(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DiagramChooseIf class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DiagramChooseIf(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "alg" == name)
    return new Algorithm();
    
if( 14 == namespaceId && "shape" == name)
    return new Shape();
    
if( 14 == namespaceId && "presOf" == name)
    return new PresentationOf();
    
if( 14 == namespaceId && "constrLst" == name)
    return new Constraints();
    
if( 14 == namespaceId && "ruleLst" == name)
    return new RuleList();
    
if( 14 == namespaceId && "forEach" == name)
    return new ForEach();
    
if( 14 == namespaceId && "layoutNode" == name)
    return new LayoutNode();
    
if( 14 == namespaceId && "choose" == name)
    return new Choose();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "axis" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>();
    
if( 0 == namespaceId && "ptType" == name)
    return new ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>();
    
if( 0 == namespaceId && "hideLastTrans" == name)
    return new ListValue<BooleanValue>();
    
if( 0 == namespaceId && "st" == name)
    return new ListValue<Int32Value>();
    
if( 0 == namespaceId && "cnt" == name)
    return new ListValue<UInt32Value>();
    
if( 0 == namespaceId && "step" == name)
    return new ListValue<Int32Value>();
    
if( 0 == namespaceId && "func" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues>();
    
if( 0 == namespaceId && "arg" == name)
    return new StringValue();
    
if( 0 == namespaceId && "op" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues>();
    
if( 0 == namespaceId && "val" == name)
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
        return CloneImp<DiagramChooseIf>(deep);
    }

   
}
/// <summary>
/// <para>Else.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:else.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Algorithm &lt;dgm:alg></description></item>
///<item><description>Shape &lt;dgm:shape></description></item>
///<item><description>PresentationOf &lt;dgm:presOf></description></item>
///<item><description>Constraints &lt;dgm:constrLst></description></item>
///<item><description>RuleList &lt;dgm:ruleLst></description></item>
///<item><description>ForEach &lt;dgm:forEach></description></item>
///<item><description>LayoutNode &lt;dgm:layoutNode></description></item>
///<item><description>Choose &lt;dgm:choose></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Algorithm))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(PresentationOf))]
    [ChildElementInfo(typeof(Constraints))]
    [ChildElementInfo(typeof(RuleList))]
    [ChildElementInfo(typeof(ForEach))]
    [ChildElementInfo(typeof(LayoutNode))]
    [ChildElementInfo(typeof(Choose))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DiagramChooseElse : OpenXmlCompositeElement
{
    private const string tagName = "else";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10722;
    
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
    

    private static string[] attributeTagNames = { "name" };
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
    /// <para> Name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DiagramChooseElse class.
    /// </summary>
    public DiagramChooseElse():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DiagramChooseElse class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DiagramChooseElse(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DiagramChooseElse class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DiagramChooseElse(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DiagramChooseElse class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DiagramChooseElse(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "alg" == name)
    return new Algorithm();
    
if( 14 == namespaceId && "shape" == name)
    return new Shape();
    
if( 14 == namespaceId && "presOf" == name)
    return new PresentationOf();
    
if( 14 == namespaceId && "constrLst" == name)
    return new Constraints();
    
if( 14 == namespaceId && "ruleLst" == name)
    return new RuleList();
    
if( 14 == namespaceId && "forEach" == name)
    return new ForEach();
    
if( 14 == namespaceId && "layoutNode" == name)
    return new LayoutNode();
    
if( 14 == namespaceId && "choose" == name)
    return new Choose();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
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
        return CloneImp<DiagramChooseElse>(deep);
    }

   
}
/// <summary>
/// <para>Data Model.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:dataModel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PointList &lt;dgm:ptLst></description></item>
///<item><description>ConnectionList &lt;dgm:cxnLst></description></item>
///<item><description>Background &lt;dgm:bg></description></item>
///<item><description>Whole &lt;dgm:whole></description></item>
///<item><description>DataModelExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PointList))]
    [ChildElementInfo(typeof(ConnectionList))]
    [ChildElementInfo(typeof(Background))]
    [ChildElementInfo(typeof(Whole))]
    [ChildElementInfo(typeof(DataModelExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DataModel : OpenXmlCompositeElement
{
    private const string tagName = "dataModel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10723;
    
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
    /// Initializes a new instance of the DataModel class.
    /// </summary>
    public DataModel():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataModel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataModel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataModel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataModel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataModel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataModel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "ptLst" == name)
    return new PointList();
    
if( 14 == namespaceId && "cxnLst" == name)
    return new ConnectionList();
    
if( 14 == namespaceId && "bg" == name)
    return new Background();
    
if( 14 == namespaceId && "whole" == name)
    return new Whole();
    
if( 14 == namespaceId && "extLst" == name)
    return new DataModelExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ptLst","cxnLst","bg","whole","extLst" };
    private static readonly byte[] eleNamespaceIds = { 14,14,14,14,14 };
    
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
    /// <para> Point List.</para>
    /// <para> Represents the following element tag in the schema: dgm:ptLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public PointList PointList
    {
        get 
        {
            return GetElement<PointList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Connection List.</para>
    /// <para> Represents the following element tag in the schema: dgm:cxnLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ConnectionList ConnectionList
    {
        get 
        {
            return GetElement<ConnectionList>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Background Formatting.</para>
    /// <para> Represents the following element tag in the schema: dgm:bg </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public Background Background
    {
        get 
        {
            return GetElement<Background>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Whole E2O Formatting.</para>
    /// <para> Represents the following element tag in the schema: dgm:whole </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public Whole Whole
    {
        get 
        {
            return GetElement<Whole>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> DataModelExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dgm:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public DataModelExtensionList DataModelExtensionList
    {
        get 
        {
            return GetElement<DataModelExtensionList>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DataModel>(deep);
    }

   
}
/// <summary>
/// <para>Category.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:cat.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Category : OpenXmlLeafElement
{
    private const string tagName = "cat";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10724;
    
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
    

    private static string[] attributeTagNames = { "type","pri" };
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
    /// <para> Category Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Priority.</para>
    /// <para>Represents the following attribute in the schema: pri </para>
    /// </summary>
    [SchemaAttr(0, "pri")]
    public UInt32Value Priority
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Category class.
    /// </summary>
    public Category():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new StringValue();
    
if( 0 == namespaceId && "pri" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Category>(deep);
    }

   
}
/// <summary>
/// <para>Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:title.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Title : OpenXmlLeafElement
{
    private const string tagName = "title";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10725;
    
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
    

    private static string[] attributeTagNames = { "lang","val" };
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
    /// <para> Language.</para>
    /// <para>Represents the following attribute in the schema: lang </para>
    /// </summary>
    [SchemaAttr(0, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Title class.
    /// </summary>
    public Title():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 0 == namespaceId && "val" == name)
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
        return CloneImp<Title>(deep);
    }

   
}
/// <summary>
/// <para>Description.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:desc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Description : OpenXmlLeafElement
{
    private const string tagName = "desc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10726;
    
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
    

    private static string[] attributeTagNames = { "lang","val" };
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
    /// <para> Language.</para>
    /// <para>Represents the following attribute in the schema: lang </para>
    /// </summary>
    [SchemaAttr(0, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Description class.
    /// </summary>
    public Description():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 0 == namespaceId && "val" == name)
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
        return CloneImp<Description>(deep);
    }

   
}
/// <summary>
/// <para>Category List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:catLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Category &lt;dgm:cat></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Category))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CategoryList : OpenXmlCompositeElement
{
    private const string tagName = "catLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10727;
    
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
    /// Initializes a new instance of the CategoryList class.
    /// </summary>
    public CategoryList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the CategoryList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "cat" == name)
    return new Category();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CategoryList>(deep);
    }

   
}
/// <summary>
/// <para>Sample Data.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:sampData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DataModel &lt;dgm:dataModel></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SampleData : SampleDataType
{
    private const string tagName = "sampData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10728;
    
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
    /// Initializes a new instance of the SampleData class.
    /// </summary>
    public SampleData():base(){}
            /// <summary>
    ///Initializes a new instance of the SampleData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SampleData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SampleData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SampleData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SampleData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SampleData(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SampleData>(deep);
    }

}
/// <summary>
/// <para>Style Data.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:styleData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DataModel &lt;dgm:dataModel></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StyleData : SampleDataType
{
    private const string tagName = "styleData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10729;
    
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
    /// Initializes a new instance of the StyleData class.
    /// </summary>
    public StyleData():base(){}
            /// <summary>
    ///Initializes a new instance of the StyleData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StyleData(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StyleData>(deep);
    }

}
/// <summary>
/// <para>Color Transform Sample Data.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:clrData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DataModel &lt;dgm:dataModel></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColorData : SampleDataType
{
    private const string tagName = "clrData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10730;
    
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
    /// Initializes a new instance of the ColorData class.
    /// </summary>
    public ColorData():base(){}
            /// <summary>
    ///Initializes a new instance of the ColorData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorData(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ColorData>(deep);
    }

}
/// <summary>
/// Defines the SampleDataType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DataModel &lt;dgm:dataModel></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DataModel))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class SampleDataType : OpenXmlCompositeElement
{
    private static string[] attributeTagNames = { "useDef" };
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
    /// <para> Use Default.</para>
    /// <para>Represents the following attribute in the schema: useDef </para>
    /// </summary>
    [SchemaAttr(0, "useDef")]
    public BooleanValue UseDefault
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "dataModel" == name)
    return new DataModel();
    

    return null;
}

        private static readonly string[] eleTagNames = { "dataModel" };
    private static readonly byte[] eleNamespaceIds = { 14 };
    
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
    /// <para> Data Model.</para>
    /// <para> Represents the following element tag in the schema: dgm:dataModel </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public DataModel DataModel
    {
        get 
        {
            return GetElement<DataModel>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "useDef" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the SampleDataType class.
    /// </summary>
    protected SampleDataType(){}
    
            /// <summary>
    ///Initializes a new instance of the SampleDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected SampleDataType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SampleDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected SampleDataType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SampleDataType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected SampleDataType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Shape Style.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:style.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LineReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FillReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FontReference))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Style : OpenXmlCompositeElement
{
    private const string tagName = "style";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10732;
    
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
    /// <para> LineReference.</para>
    /// <para> Represents the following element tag in the schema: a:lnRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.LineReference LineReference
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.LineReference>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.FillReference>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.EffectReference>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.FontReference>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Style>(deep);
    }

   
}
/// <summary>
/// <para>Show Organization Chart User Interface.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:orgChart.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class OrganizationChart : OpenXmlLeafElement
{
    private const string tagName = "orgChart";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10733;
    
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
    

    private static string[] attributeTagNames = { "val" };
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
    /// <para> Show Organization Chart User Interface Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OrganizationChart class.
    /// </summary>
    public OrganizationChart():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
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
        return CloneImp<OrganizationChart>(deep);
    }

   
}
/// <summary>
/// <para>Maximum Children.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:chMax.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MaxNumberOfChildren : OpenXmlLeafElement
{
    private const string tagName = "chMax";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10734;
    
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
    

    private static string[] attributeTagNames = { "val" };
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
    /// <para> Maximum Children Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public Int32Value Val
    {
        get { return (Int32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MaxNumberOfChildren class.
    /// </summary>
    public MaxNumberOfChildren():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
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
        return CloneImp<MaxNumberOfChildren>(deep);
    }

   
}
/// <summary>
/// <para>Preferred Number of Children.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:chPref.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PreferredNumberOfChildren : OpenXmlLeafElement
{
    private const string tagName = "chPref";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10735;
    
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
    

    private static string[] attributeTagNames = { "val" };
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
    /// <para> Preferred Number of CHildren Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public Int32Value Val
    {
        get { return (Int32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PreferredNumberOfChildren class.
    /// </summary>
    public PreferredNumberOfChildren():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
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
        return CloneImp<PreferredNumberOfChildren>(deep);
    }

   
}
/// <summary>
/// <para>Show Insert Bullet.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:bulletEnabled.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BulletEnabled : OpenXmlLeafElement
{
    private const string tagName = "bulletEnabled";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10736;
    
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
    

    private static string[] attributeTagNames = { "val" };
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
    /// <para> Show Insert Bullet Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BulletEnabled class.
    /// </summary>
    public BulletEnabled():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
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
        return CloneImp<BulletEnabled>(deep);
    }

   
}
/// <summary>
/// <para>Diagram Direction.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:dir.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Direction : OpenXmlLeafElement
{
    private const string tagName = "dir";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10737;
    
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
    

    private static string[] attributeTagNames = { "val" };
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
    /// <para> Diagram Direction Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Direction class.
    /// </summary>
    public Direction():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Direction>(deep);
    }

   
}
/// <summary>
/// <para>Organization Chart Branch Style.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:hierBranch.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HierarchyBranch : OpenXmlLeafElement
{
    private const string tagName = "hierBranch";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10738;
    
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
    

    private static string[] attributeTagNames = { "val" };
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
    /// <para> Organization Chart Branch Style Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the HierarchyBranch class.
    /// </summary>
    public HierarchyBranch():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HierarchyBranch>(deep);
    }

   
}
/// <summary>
/// <para>One by One Animation String.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:animOne.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AnimateOneByOne : OpenXmlLeafElement
{
    private const string tagName = "animOne";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10739;
    
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
    

    private static string[] attributeTagNames = { "val" };
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
    /// <para> One By One Animation Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the AnimateOneByOne class.
    /// </summary>
    public AnimateOneByOne():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AnimateOneByOne>(deep);
    }

   
}
/// <summary>
/// <para>Level Animation.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:animLvl.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AnimationLevel : OpenXmlLeafElement
{
    private const string tagName = "animLvl";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10740;
    
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
    

    private static string[] attributeTagNames = { "val" };
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
    /// <para> Level Animation Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the AnimationLevel class.
    /// </summary>
    public AnimationLevel():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AnimationLevel>(deep);
    }

   
}
/// <summary>
/// <para>Shape Resize Style.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:resizeHandles.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ResizeHandles : OpenXmlLeafElement
{
    private const string tagName = "resizeHandles";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10741;
    
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
    

    private static string[] attributeTagNames = { "val" };
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
    /// <para> Shape Resize Style Type.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ResizeHandles class.
    /// </summary>
    public ResizeHandles():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ResizeHandles>(deep);
    }

   
}
/// <summary>
/// <para>Category.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:cat.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StyleDisplayCategory : OpenXmlLeafElement
{
    private const string tagName = "cat";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10742;
    
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
    

    private static string[] attributeTagNames = { "type","pri" };
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
    /// <para> Category Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Priority.</para>
    /// <para>Represents the following attribute in the schema: pri </para>
    /// </summary>
    [SchemaAttr(0, "pri")]
    public UInt32Value Priority
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StyleDisplayCategory class.
    /// </summary>
    public StyleDisplayCategory():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new StringValue();
    
if( 0 == namespaceId && "pri" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StyleDisplayCategory>(deep);
    }

   
}
/// <summary>
/// <para>3-D Scene.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:scene3d.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Camera &lt;a:camera></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.LightRig &lt;a:lightRig></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Backdrop &lt;a:backdrop></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Camera))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LightRig))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Backdrop))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Scene3D : OpenXmlCompositeElement
{
    private const string tagName = "scene3d";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10743;
    
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
    /// Initializes a new instance of the Scene3D class.
    /// </summary>
    public Scene3D():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Scene3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Scene3D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Scene3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Scene3D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Scene3D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Scene3D(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "camera" == name)
    return new DocumentFormat.OpenXml.Drawing.Camera();
    
if( 10 == namespaceId && "lightRig" == name)
    return new DocumentFormat.OpenXml.Drawing.LightRig();
    
if( 10 == namespaceId && "backdrop" == name)
    return new DocumentFormat.OpenXml.Drawing.Backdrop();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "camera","lightRig","backdrop","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10 };
    
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
    /// <para> Camera.</para>
    /// <para> Represents the following element tag in the schema: a:camera </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Camera Camera
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Camera>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Light Rig.</para>
    /// <para> Represents the following element tag in the schema: a:lightRig </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.LightRig LightRig
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.LightRig>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Backdrop Plane.</para>
    /// <para> Represents the following element tag in the schema: a:backdrop </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Backdrop Backdrop
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Backdrop>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Scene3D>(deep);
    }

   
}
/// <summary>
/// <para>3-D Shape Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:sp3d.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.BevelTop &lt;a:bevelT></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BevelBottom &lt;a:bevelB></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtrusionColor &lt;a:extrusionClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ContourColor &lt;a:contourClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BevelTop))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BevelBottom))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtrusionColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ContourColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Shape3D : OpenXmlCompositeElement
{
    private const string tagName = "sp3d";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10744;
    
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
    

    private static string[] attributeTagNames = { "z","extrusionH","contourW","prstMaterial" };
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
    /// <para> Shape Depth.</para>
    /// <para>Represents the following attribute in the schema: z </para>
    /// </summary>
    [SchemaAttr(0, "z")]
    public Int64Value Z
    {
        get { return (Int64Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Height.</para>
    /// <para>Represents the following attribute in the schema: extrusionH </para>
    /// </summary>
    [SchemaAttr(0, "extrusionH")]
    public Int64Value ExtrusionHeight
    {
        get { return (Int64Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Contour Width.</para>
    /// <para>Represents the following attribute in the schema: contourW </para>
    /// </summary>
    [SchemaAttr(0, "contourW")]
    public Int64Value ContourWidth
    {
        get { return (Int64Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Preset Material Type.</para>
    /// <para>Represents the following attribute in the schema: prstMaterial </para>
    /// </summary>
    [SchemaAttr(0, "prstMaterial")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues> PresetMaterial
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Shape3D class.
    /// </summary>
    public Shape3D():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Shape3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shape3D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Shape3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Shape3D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Shape3D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Shape3D(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "bevelT" == name)
    return new DocumentFormat.OpenXml.Drawing.BevelTop();
    
if( 10 == namespaceId && "bevelB" == name)
    return new DocumentFormat.OpenXml.Drawing.BevelBottom();
    
if( 10 == namespaceId && "extrusionClr" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtrusionColor();
    
if( 10 == namespaceId && "contourClr" == name)
    return new DocumentFormat.OpenXml.Drawing.ContourColor();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "bevelT","bevelB","extrusionClr","contourClr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10 };
    
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
    /// <para> Top Bevel.</para>
    /// <para> Represents the following element tag in the schema: a:bevelT </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.BevelTop BevelTop
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.BevelTop>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Bottom Bevel.</para>
    /// <para> Represents the following element tag in the schema: a:bevelB </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.BevelBottom BevelBottom
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.BevelBottom>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Extrusion Color.</para>
    /// <para> Represents the following element tag in the schema: a:extrusionClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.ExtrusionColor ExtrusionColor
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.ExtrusionColor>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Contour Color.</para>
    /// <para> Represents the following element tag in the schema: a:contourClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.ContourColor ContourColor
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.ContourColor>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "z" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "extrusionH" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "contourW" == name)
    return new Int64Value();
    
if( 0 == namespaceId && "prstMaterial" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Shape3D>(deep);
    }

   
}
/// <summary>
/// <para>Text Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:txPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.FlatText &lt;a:flatTx></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FlatText))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TextProperties : OpenXmlCompositeElement
{
    private const string tagName = "txPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10745;
    
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
    /// Initializes a new instance of the TextProperties class.
    /// </summary>
    public TextProperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TextProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "sp3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Shape3DType();
    
if( 10 == namespaceId && "flatTx" == name)
    return new DocumentFormat.OpenXml.Drawing.FlatText();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sp3d","flatTx" };
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
        get {return OpenXmlCompositeType.OneChoice;}
    }
    
        /// <summary>
    /// <para> Apply 3D shape properties.</para>
    /// <para> Represents the following element tag in the schema: a:sp3d </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Shape3DType Shape3DType
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Shape3DType>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> No text in 3D scene.</para>
    /// <para> Represents the following element tag in the schema: a:flatTx </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.FlatText FlatText
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.FlatText>(1);
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
        return CloneImp<TextProperties>(deep);
    }

   
}
/// <summary>
/// <para>Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:title.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StyleDefinitionTitle : OpenXmlLeafElement
{
    private const string tagName = "title";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10746;
    
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
    

    private static string[] attributeTagNames = { "lang","val" };
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
    /// <para> Natural Language.</para>
    /// <para>Represents the following attribute in the schema: lang </para>
    /// </summary>
    [SchemaAttr(0, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Description Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StyleDefinitionTitle class.
    /// </summary>
    public StyleDefinitionTitle():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 0 == namespaceId && "val" == name)
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
        return CloneImp<StyleDefinitionTitle>(deep);
    }

   
}
/// <summary>
/// <para>Style Label Description.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:desc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StyleLabelDescription : OpenXmlLeafElement
{
    private const string tagName = "desc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10747;
    
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
    

    private static string[] attributeTagNames = { "lang","val" };
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
    /// <para> Natural Language.</para>
    /// <para>Represents the following attribute in the schema: lang </para>
    /// </summary>
    [SchemaAttr(0, "lang")]
    public StringValue Language
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Description Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StyleLabelDescription class.
    /// </summary>
    public StyleLabelDescription():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "lang" == name)
    return new StringValue();
    
if( 0 == namespaceId && "val" == name)
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
        return CloneImp<StyleLabelDescription>(deep);
    }

   
}
/// <summary>
/// <para>Category List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:catLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StyleDisplayCategory &lt;dgm:cat></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(StyleDisplayCategory))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StyleDisplayCategories : OpenXmlCompositeElement
{
    private const string tagName = "catLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10748;
    
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
    /// Initializes a new instance of the StyleDisplayCategories class.
    /// </summary>
    public StyleDisplayCategories():base(){}
    
            /// <summary>
    ///Initializes a new instance of the StyleDisplayCategories class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleDisplayCategories(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleDisplayCategories class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleDisplayCategories(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleDisplayCategories class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StyleDisplayCategories(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "cat" == name)
    return new StyleDisplayCategory();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StyleDisplayCategories>(deep);
    }

   
}
/// <summary>
/// <para>Style Label.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:styleLbl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Scene3D &lt;dgm:scene3d></description></item>
///<item><description>Shape3D &lt;dgm:sp3d></description></item>
///<item><description>TextProperties &lt;dgm:txPr></description></item>
///<item><description>Style &lt;dgm:style></description></item>
///<item><description>ExtensionList &lt;dgm:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Scene3D))]
    [ChildElementInfo(typeof(Shape3D))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(Style))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StyleLabel : OpenXmlCompositeElement
{
    private const string tagName = "styleLbl";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10749;
    
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
    

    private static string[] attributeTagNames = { "name" };
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
    /// <para> Style Name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StyleLabel class.
    /// </summary>
    public StyleLabel():base(){}
    
            /// <summary>
    ///Initializes a new instance of the StyleLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StyleLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StyleLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StyleLabel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "scene3d" == name)
    return new Scene3D();
    
if( 14 == namespaceId && "sp3d" == name)
    return new Shape3D();
    
if( 14 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 14 == namespaceId && "style" == name)
    return new Style();
    
if( 14 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "scene3d","sp3d","txPr","style","extLst" };
    private static readonly byte[] eleNamespaceIds = { 14,14,14,14,14 };
    
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
    /// <para> 3-D Scene.</para>
    /// <para> Represents the following element tag in the schema: dgm:scene3d </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public Scene3D Scene3D
    {
        get 
        {
            return GetElement<Scene3D>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> 3-D Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: dgm:sp3d </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public Shape3D Shape3D
    {
        get 
        {
            return GetElement<Shape3D>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Text Properties.</para>
    /// <para> Represents the following element tag in the schema: dgm:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public TextProperties TextProperties
    {
        get 
        {
            return GetElement<TextProperties>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Shape Style.</para>
    /// <para> Represents the following element tag in the schema: dgm:style </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public Style Style
    {
        get 
        {
            return GetElement<Style>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: dgm:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
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
        return CloneImp<StyleLabel>(deep);
    }

   
}
/// <summary>
/// <para>Point List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:ptLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Point &lt;dgm:pt></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Point))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PointList : OpenXmlCompositeElement
{
    private const string tagName = "ptLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10750;
    
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
    /// Initializes a new instance of the PointList class.
    /// </summary>
    public PointList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PointList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PointList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PointList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PointList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PointList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PointList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "pt" == name)
    return new Point();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PointList>(deep);
    }

   
}
/// <summary>
/// <para>Connection List.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:cxnLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Connection &lt;dgm:cxn></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Connection))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ConnectionList : OpenXmlCompositeElement
{
    private const string tagName = "cxnLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10751;
    
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
    /// Initializes a new instance of the ConnectionList class.
    /// </summary>
    public ConnectionList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ConnectionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConnectionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ConnectionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConnectionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ConnectionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ConnectionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "cxn" == name)
    return new Connection();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ConnectionList>(deep);
    }

   
}
/// <summary>
/// <para>Background Formatting.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:bg.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Background : OpenXmlCompositeElement
{
    private const string tagName = "bg";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10752;
    
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
    

    return null;
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
/// <para>Whole E2O Formatting.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:whole.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Whole : OpenXmlCompositeElement
{
    private const string tagName = "whole";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10753;
    
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
    /// Initializes a new instance of the Whole class.
    /// </summary>
    public Whole():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Whole class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Whole(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Whole class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Whole(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Whole class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Whole(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "ln" == name)
    return new DocumentFormat.OpenXml.Drawing.Outline();
    
if( 10 == namespaceId && "effectLst" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectList();
    
if( 10 == namespaceId && "effectDag" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectDag();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ln","effectLst","effectDag" };
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
    /// <para> Outline.</para>
    /// <para> Represents the following element tag in the schema: a:ln </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Outline Outline
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Outline>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Whole>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataModelExtensionList Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.DataModelExtension &lt;a:ext></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.DataModelExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DataModelExtensionList : OpenXmlCompositeElement
{
    private const string tagName = "extLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10754;
    
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
    /// Initializes a new instance of the DataModelExtensionList class.
    /// </summary>
    public DataModelExtensionList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataModelExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataModelExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataModelExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataModelExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataModelExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataModelExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Drawing.DataModelExtension();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DataModelExtensionList>(deep);
    }

   
}
/// <summary>
/// <para>Property Set.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:prSet.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PresentationLayoutVariables &lt;dgm:presLayoutVars></description></item>
///<item><description>Style &lt;dgm:style></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PresentationLayoutVariables))]
    [ChildElementInfo(typeof(Style))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PropertySet : OpenXmlCompositeElement
{
    private const string tagName = "prSet";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10755;
    
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
    

    private static string[] attributeTagNames = { "presAssocID","presName","presStyleLbl","presStyleIdx","presStyleCnt","loTypeId","loCatId","qsTypeId","qsCatId","csTypeId","csCatId","coherent3DOff","phldrT","phldr","custAng","custFlipVert","custFlipHor","custSzX","custSzY","custScaleX","custScaleY","custT","custLinFactX","custLinFactY","custLinFactNeighborX","custLinFactNeighborY","custRadScaleRad","custRadScaleInc" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> Presentation Element Identifier.</para>
    /// <para>Represents the following attribute in the schema: presAssocID </para>
    /// </summary>
    [SchemaAttr(0, "presAssocID")]
    public StringValue PresentationElementId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Presentation Name.</para>
    /// <para>Represents the following attribute in the schema: presName </para>
    /// </summary>
    [SchemaAttr(0, "presName")]
    public StringValue PresentationName
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Presentation Style Label.</para>
    /// <para>Represents the following attribute in the schema: presStyleLbl </para>
    /// </summary>
    [SchemaAttr(0, "presStyleLbl")]
    public StringValue PresentationStyleLabel
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Presentation Style Index.</para>
    /// <para>Represents the following attribute in the schema: presStyleIdx </para>
    /// </summary>
    [SchemaAttr(0, "presStyleIdx")]
    public Int32Value PresentationStyleIndex
    {
        get { return (Int32Value)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Presentation Style Count.</para>
    /// <para>Represents the following attribute in the schema: presStyleCnt </para>
    /// </summary>
    [SchemaAttr(0, "presStyleCnt")]
    public Int32Value PresentationStyleCount
    {
        get { return (Int32Value)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Current Diagram Type.</para>
    /// <para>Represents the following attribute in the schema: loTypeId </para>
    /// </summary>
    [SchemaAttr(0, "loTypeId")]
    public StringValue LayoutTypeId
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Current Diagram Category.</para>
    /// <para>Represents the following attribute in the schema: loCatId </para>
    /// </summary>
    [SchemaAttr(0, "loCatId")]
    public StringValue LayoutCategoryId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Current Style Type.</para>
    /// <para>Represents the following attribute in the schema: qsTypeId </para>
    /// </summary>
    [SchemaAttr(0, "qsTypeId")]
    public StringValue QuickStyleTypeId
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Current Style Category.</para>
    /// <para>Represents the following attribute in the schema: qsCatId </para>
    /// </summary>
    [SchemaAttr(0, "qsCatId")]
    public StringValue QuickStyleCategoryId
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Color Transform Type Identifier.</para>
    /// <para>Represents the following attribute in the schema: csTypeId </para>
    /// </summary>
    [SchemaAttr(0, "csTypeId")]
    public StringValue ColorType
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Color Transform Category.</para>
    /// <para>Represents the following attribute in the schema: csCatId </para>
    /// </summary>
    [SchemaAttr(0, "csCatId")]
    public StringValue ColorCategoryId
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> Coherent 3D Behavior.</para>
    /// <para>Represents the following attribute in the schema: coherent3DOff </para>
    /// </summary>
    [SchemaAttr(0, "coherent3DOff")]
    public BooleanValue Coherent3D
    {
        get { return (BooleanValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> Placeholder Text.</para>
    /// <para>Represents the following attribute in the schema: phldrT </para>
    /// </summary>
    [SchemaAttr(0, "phldrT")]
    public StringValue PlaceholderText
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> Placeholder.</para>
    /// <para>Represents the following attribute in the schema: phldr </para>
    /// </summary>
    [SchemaAttr(0, "phldr")]
    public BooleanValue Placeholder
    {
        get { return (BooleanValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> Custom Rotation.</para>
    /// <para>Represents the following attribute in the schema: custAng </para>
    /// </summary>
    [SchemaAttr(0, "custAng")]
    public Int32Value Rotation
    {
        get { return (Int32Value)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> Custom Vertical Flip.</para>
    /// <para>Represents the following attribute in the schema: custFlipVert </para>
    /// </summary>
    [SchemaAttr(0, "custFlipVert")]
    public BooleanValue VerticalFlip
    {
        get { return (BooleanValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> Custom Horizontal Flip.</para>
    /// <para>Represents the following attribute in the schema: custFlipHor </para>
    /// </summary>
    [SchemaAttr(0, "custFlipHor")]
    public BooleanValue HorizontalFlip
    {
        get { return (BooleanValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> Fixed Width Override.</para>
    /// <para>Represents the following attribute in the schema: custSzX </para>
    /// </summary>
    [SchemaAttr(0, "custSzX")]
    public Int32Value FixedWidthOverride
    {
        get { return (Int32Value)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> Fixed Height Override.</para>
    /// <para>Represents the following attribute in the schema: custSzY </para>
    /// </summary>
    [SchemaAttr(0, "custSzY")]
    public Int32Value FixedHeightOverride
    {
        get { return (Int32Value)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> Width Scale.</para>
    /// <para>Represents the following attribute in the schema: custScaleX </para>
    /// </summary>
    [SchemaAttr(0, "custScaleX")]
    public Int32Value WidthScale
    {
        get { return (Int32Value)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> Height Scale.</para>
    /// <para>Represents the following attribute in the schema: custScaleY </para>
    /// </summary>
    [SchemaAttr(0, "custScaleY")]
    public Int32Value HightScale
    {
        get { return (Int32Value)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> Text Changed.</para>
    /// <para>Represents the following attribute in the schema: custT </para>
    /// </summary>
    [SchemaAttr(0, "custT")]
    public BooleanValue TextChanged
    {
        get { return (BooleanValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> Custom Factor Width.</para>
    /// <para>Represents the following attribute in the schema: custLinFactX </para>
    /// </summary>
    [SchemaAttr(0, "custLinFactX")]
    public Int32Value FactorWidth
    {
        get { return (Int32Value)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> Custom Factor Height.</para>
    /// <para>Represents the following attribute in the schema: custLinFactY </para>
    /// </summary>
    [SchemaAttr(0, "custLinFactY")]
    public Int32Value FactorHeight
    {
        get { return (Int32Value)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> Neighbor Offset Width.</para>
    /// <para>Represents the following attribute in the schema: custLinFactNeighborX </para>
    /// </summary>
    [SchemaAttr(0, "custLinFactNeighborX")]
    public Int32Value NeighborOffsetWidth
    {
        get { return (Int32Value)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> Neighbor Offset Height.</para>
    /// <para>Represents the following attribute in the schema: custLinFactNeighborY </para>
    /// </summary>
    [SchemaAttr(0, "custLinFactNeighborY")]
    public Int32Value NeighborOffsetHeight
    {
        get { return (Int32Value)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> Radius Scale.</para>
    /// <para>Represents the following attribute in the schema: custRadScaleRad </para>
    /// </summary>
    [SchemaAttr(0, "custRadScaleRad")]
    public Int32Value RadiusScale
    {
        get { return (Int32Value)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> Include Angle Scale.</para>
    /// <para>Represents the following attribute in the schema: custRadScaleInc </para>
    /// </summary>
    [SchemaAttr(0, "custRadScaleInc")]
    public Int32Value IncludeAngleScale
    {
        get { return (Int32Value)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PropertySet class.
    /// </summary>
    public PropertySet():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PropertySet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PropertySet(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PropertySet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PropertySet(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PropertySet class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PropertySet(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 14 == namespaceId && "presLayoutVars" == name)
    return new PresentationLayoutVariables();
    
if( 14 == namespaceId && "style" == name)
    return new Style();
    

    return null;
}

        private static readonly string[] eleTagNames = { "presLayoutVars","style" };
    private static readonly byte[] eleNamespaceIds = { 14,14 };
    
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
    /// <para> Presentation Layout Variables.</para>
    /// <para> Represents the following element tag in the schema: dgm:presLayoutVars </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public PresentationLayoutVariables PresentationLayoutVariables
    {
        get 
        {
            return GetElement<PresentationLayoutVariables>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Shape Style.</para>
    /// <para> Represents the following element tag in the schema: dgm:style </para>
    /// </summary>
    /// <remark>
    /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
    /// </remark>
    public Style Style
    {
        get 
        {
            return GetElement<Style>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "presAssocID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "presName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "presStyleLbl" == name)
    return new StringValue();
    
if( 0 == namespaceId && "presStyleIdx" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "presStyleCnt" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "loTypeId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "loCatId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "qsTypeId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "qsCatId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "csTypeId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "csCatId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "coherent3DOff" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "phldrT" == name)
    return new StringValue();
    
if( 0 == namespaceId && "phldr" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "custAng" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "custFlipVert" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "custFlipHor" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "custSzX" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "custSzY" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "custScaleX" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "custScaleY" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "custT" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "custLinFactX" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "custLinFactY" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "custLinFactNeighborX" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "custLinFactNeighborY" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "custRadScaleRad" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "custRadScaleInc" == name)
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
        return CloneImp<PropertySet>(deep);
    }

   
}
/// <summary>
/// <para>Shape Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:spPr.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    private const string tagName = "spPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10756;
    
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
    

    private static string[] attributeTagNames = { "bwMode" };
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
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
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
    /// <para> 2D Transform for Individual Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
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
        return CloneImp<ShapeProperties>(deep);
    }

   
}
/// <summary>
/// <para>Text Body.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:t.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ListStyle))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Paragraph))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TextBody : OpenXmlCompositeElement
{
    private const string tagName = "t";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10757;
    
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
    /// <para> Body Properties.</para>
    /// <para> Represents the following element tag in the schema: a:bodyPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.BodyProperties BodyProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>(1);
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
        return CloneImp<TextBody>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PtExtensionList Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is dgm:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.PtExtension &lt;a:ext></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PtExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PtExtensionList : OpenXmlCompositeElement
{
    private const string tagName = "extLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 14;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10758;
    
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
    /// Initializes a new instance of the PtExtensionList class.
    /// </summary>
    public PtExtensionList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PtExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PtExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PtExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Drawing.PtExtension();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PtExtensionList>(deep);
    }

   
}
/// <summary>
/// Color Application Method Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ColorApplicationMethodValues
{  
	///<summary>
///Span.
///<para>When the item is serialized out as xml, its value is "span".</para>
///</summary>
[EnumString("span")]
Span,
///<summary>
///Cycle.
///<para>When the item is serialized out as xml, its value is "cycle".</para>
///</summary>
[EnumString("cycle")]
Cycle,
///<summary>
///Repeat.
///<para>When the item is serialized out as xml, its value is "repeat".</para>
///</summary>
[EnumString("repeat")]
Repeat,
 
}
/// <summary>
/// Hue Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum HueDirectionValues
{  
	///<summary>
///Clockwise Hue Direction.
///<para>When the item is serialized out as xml, its value is "cw".</para>
///</summary>
[EnumString("cw")]
Clockwise,
///<summary>
///Counterclockwise Hue Direction.
///<para>When the item is serialized out as xml, its value is "ccw".</para>
///</summary>
[EnumString("ccw")]
Counterclockwise,
 
}
/// <summary>
/// Point Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PointValues
{  
	///<summary>
///Node.
///<para>When the item is serialized out as xml, its value is "node".</para>
///</summary>
[EnumString("node")]
Node,
///<summary>
///Assistant Element.
///<para>When the item is serialized out as xml, its value is "asst".</para>
///</summary>
[EnumString("asst")]
Assistant,
///<summary>
///Document.
///<para>When the item is serialized out as xml, its value is "doc".</para>
///</summary>
[EnumString("doc")]
Document,
///<summary>
///Presentation.
///<para>When the item is serialized out as xml, its value is "pres".</para>
///</summary>
[EnumString("pres")]
Presentation,
///<summary>
///Parent Transition.
///<para>When the item is serialized out as xml, its value is "parTrans".</para>
///</summary>
[EnumString("parTrans")]
ParentTransition,
///<summary>
///Sibling Transition.
///<para>When the item is serialized out as xml, its value is "sibTrans".</para>
///</summary>
[EnumString("sibTrans")]
SiblingTransition,
 
}
/// <summary>
/// Connection Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConnectionValues
{  
	///<summary>
///Parent Of.
///<para>When the item is serialized out as xml, its value is "parOf".</para>
///</summary>
[EnumString("parOf")]
ParentOf,
///<summary>
///Presentation Of.
///<para>When the item is serialized out as xml, its value is "presOf".</para>
///</summary>
[EnumString("presOf")]
PresentationOf,
///<summary>
///Presentation Parent Of.
///<para>When the item is serialized out as xml, its value is "presParOf".</para>
///</summary>
[EnumString("presParOf")]
PresentationParentOf,
///<summary>
///Unknown Relationship.
///<para>When the item is serialized out as xml, its value is "unknownRelationship".</para>
///</summary>
[EnumString("unknownRelationship")]
UnknownRelationship,
 
}
/// <summary>
/// Diagram Direction Definition 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DirectionValues
{  
	///<summary>
///Normal Direction.
///<para>When the item is serialized out as xml, its value is "norm".</para>
///</summary>
[EnumString("norm")]
Normal,
///<summary>
///Reversed Direction.
///<para>When the item is serialized out as xml, its value is "rev".</para>
///</summary>
[EnumString("rev")]
Reversed,
 
}
/// <summary>
/// Hierarchy Branch Style Definition 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum HierarchyBranchStyleValues
{  
	///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
///<summary>
///Hanging.
///<para>When the item is serialized out as xml, its value is "hang".</para>
///</summary>
[EnumString("hang")]
Hanging,
///<summary>
///Standard.
///<para>When the item is serialized out as xml, its value is "std".</para>
///</summary>
[EnumString("std")]
Standard,
///<summary>
///Initial.
///<para>When the item is serialized out as xml, its value is "init".</para>
///</summary>
[EnumString("init")]
Initial,
 
}
/// <summary>
/// One by One Animation Value Definition 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AnimateOneByOneValues
{  
	///<summary>
///Disable One-by-One.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///One By One.
///<para>When the item is serialized out as xml, its value is "one".</para>
///</summary>
[EnumString("one")]
One,
///<summary>
///By Branch One By One.
///<para>When the item is serialized out as xml, its value is "branch".</para>
///</summary>
[EnumString("branch")]
Branch,
 
}
/// <summary>
/// Animation Level String Definition 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AnimationLevelStringValues
{  
	///<summary>
///Disable Level At Once.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///By Level Animation.
///<para>When the item is serialized out as xml, its value is "lvl".</para>
///</summary>
[EnumString("lvl")]
Level,
///<summary>
///From Center Animation.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
 
}
/// <summary>
/// Resize Handle 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ResizeHandlesStringValues
{  
	///<summary>
///Exact.
///<para>When the item is serialized out as xml, its value is "exact".</para>
///</summary>
[EnumString("exact")]
Exact,
///<summary>
///Relative.
///<para>When the item is serialized out as xml, its value is "rel".</para>
///</summary>
[EnumString("rel")]
Relative,
 
}
/// <summary>
/// Algorithm Types 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AlgorithmValues
{  
	///<summary>
///Composite.
///<para>When the item is serialized out as xml, its value is "composite".</para>
///</summary>
[EnumString("composite")]
Composite,
///<summary>
///Connector Algorithm.
///<para>When the item is serialized out as xml, its value is "conn".</para>
///</summary>
[EnumString("conn")]
Connector,
///<summary>
///Cycle Algorithm.
///<para>When the item is serialized out as xml, its value is "cycle".</para>
///</summary>
[EnumString("cycle")]
Cycle,
///<summary>
///Hierarchy Child Algorithm.
///<para>When the item is serialized out as xml, its value is "hierChild".</para>
///</summary>
[EnumString("hierChild")]
HierarchyChild,
///<summary>
///Hierarchy Root Algorithm.
///<para>When the item is serialized out as xml, its value is "hierRoot".</para>
///</summary>
[EnumString("hierRoot")]
HierarchyRoot,
///<summary>
///Pyramid Algorithm.
///<para>When the item is serialized out as xml, its value is "pyra".</para>
///</summary>
[EnumString("pyra")]
Pyramid,
///<summary>
///Linear Algorithm.
///<para>When the item is serialized out as xml, its value is "lin".</para>
///</summary>
[EnumString("lin")]
Linear,
///<summary>
///Space Algorithm.
///<para>When the item is serialized out as xml, its value is "sp".</para>
///</summary>
[EnumString("sp")]
Space,
///<summary>
///Text Algorithm.
///<para>When the item is serialized out as xml, its value is "tx".</para>
///</summary>
[EnumString("tx")]
Text,
///<summary>
///Snake Algorithm.
///<para>When the item is serialized out as xml, its value is "snake".</para>
///</summary>
[EnumString("snake")]
Snake,
 
}
/// <summary>
/// Axis Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AxisValues
{  
	///<summary>
///Self.
///<para>When the item is serialized out as xml, its value is "self".</para>
///</summary>
[EnumString("self")]
Self,
///<summary>
///Child.
///<para>When the item is serialized out as xml, its value is "ch".</para>
///</summary>
[EnumString("ch")]
Child,
///<summary>
///Descendant.
///<para>When the item is serialized out as xml, its value is "des".</para>
///</summary>
[EnumString("des")]
Descendant,
///<summary>
///Descendant or Self.
///<para>When the item is serialized out as xml, its value is "desOrSelf".</para>
///</summary>
[EnumString("desOrSelf")]
DescendantOrSelf,
///<summary>
///Parent.
///<para>When the item is serialized out as xml, its value is "par".</para>
///</summary>
[EnumString("par")]
Parent,
///<summary>
///Ancestor.
///<para>When the item is serialized out as xml, its value is "ancst".</para>
///</summary>
[EnumString("ancst")]
Ancestor,
///<summary>
///Ancestor or Self.
///<para>When the item is serialized out as xml, its value is "ancstOrSelf".</para>
///</summary>
[EnumString("ancstOrSelf")]
AncestorOrSelf,
///<summary>
///Follow Sibling.
///<para>When the item is serialized out as xml, its value is "followSib".</para>
///</summary>
[EnumString("followSib")]
FollowSibling,
///<summary>
///Preceding Sibling.
///<para>When the item is serialized out as xml, its value is "precedSib".</para>
///</summary>
[EnumString("precedSib")]
PrecedingSibling,
///<summary>
///Follow.
///<para>When the item is serialized out as xml, its value is "follow".</para>
///</summary>
[EnumString("follow")]
Follow,
///<summary>
///Preceding.
///<para>When the item is serialized out as xml, its value is "preced".</para>
///</summary>
[EnumString("preced")]
Preceding,
///<summary>
///Root.
///<para>When the item is serialized out as xml, its value is "root".</para>
///</summary>
[EnumString("root")]
Root,
///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
 
}
/// <summary>
/// Boolean Constraint 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BoolOperatorValues
{  
	///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Equal.
///<para>When the item is serialized out as xml, its value is "equ".</para>
///</summary>
[EnumString("equ")]
Equal,
///<summary>
///Greater Than or Equal to.
///<para>When the item is serialized out as xml, its value is "gte".</para>
///</summary>
[EnumString("gte")]
GreaterThanOrEqualTo,
///<summary>
///Less Than or Equal to.
///<para>When the item is serialized out as xml, its value is "lte".</para>
///</summary>
[EnumString("lte")]
LessThanOrEqualTo,
 
}
/// <summary>
/// Child Order 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ChildOrderValues
{  
	///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
 
}
/// <summary>
/// Constraint Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConstraintValues
{  
	///<summary>
///Unknown.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Alignment Offset.
///<para>When the item is serialized out as xml, its value is "alignOff".</para>
///</summary>
[EnumString("alignOff")]
AlignmentOffset,
///<summary>
///Beginning Margin.
///<para>When the item is serialized out as xml, its value is "begMarg".</para>
///</summary>
[EnumString("begMarg")]
BeginningMargin,
///<summary>
///Bending Distance.
///<para>When the item is serialized out as xml, its value is "bendDist".</para>
///</summary>
[EnumString("bendDist")]
BendingDistance,
///<summary>
///Beginning Padding.
///<para>When the item is serialized out as xml, its value is "begPad".</para>
///</summary>
[EnumString("begPad")]
BeginningPadding,
///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
///<summary>
///Bottom Margin.
///<para>When the item is serialized out as xml, its value is "bMarg".</para>
///</summary>
[EnumString("bMarg")]
BottomMargin,
///<summary>
///Bottom Offset.
///<para>When the item is serialized out as xml, its value is "bOff".</para>
///</summary>
[EnumString("bOff")]
BottomOffset,
///<summary>
///Center Height.
///<para>When the item is serialized out as xml, its value is "ctrX".</para>
///</summary>
[EnumString("ctrX")]
CenterHeight,
///<summary>
///Center X Offset.
///<para>When the item is serialized out as xml, its value is "ctrXOff".</para>
///</summary>
[EnumString("ctrXOff")]
CenterXOffset,
///<summary>
///Center Width.
///<para>When the item is serialized out as xml, its value is "ctrY".</para>
///</summary>
[EnumString("ctrY")]
CenterWidth,
///<summary>
///Center Y Offset.
///<para>When the item is serialized out as xml, its value is "ctrYOff".</para>
///</summary>
[EnumString("ctrYOff")]
CenterYOffset,
///<summary>
///Connection Distance.
///<para>When the item is serialized out as xml, its value is "connDist".</para>
///</summary>
[EnumString("connDist")]
ConnectionDistance,
///<summary>
///Diameter.
///<para>When the item is serialized out as xml, its value is "diam".</para>
///</summary>
[EnumString("diam")]
Diameter,
///<summary>
///End Margin.
///<para>When the item is serialized out as xml, its value is "endMarg".</para>
///</summary>
[EnumString("endMarg")]
EndMargin,
///<summary>
///End Padding.
///<para>When the item is serialized out as xml, its value is "endPad".</para>
///</summary>
[EnumString("endPad")]
EndPadding,
///<summary>
///Height.
///<para>When the item is serialized out as xml, its value is "h".</para>
///</summary>
[EnumString("h")]
Height,
///<summary>
///Arrowhead Height.
///<para>When the item is serialized out as xml, its value is "hArH".</para>
///</summary>
[EnumString("hArH")]
ArrowheadHeight,
///<summary>
///Height Offset.
///<para>When the item is serialized out as xml, its value is "hOff".</para>
///</summary>
[EnumString("hOff")]
HeightOffset,
///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Left Margin.
///<para>When the item is serialized out as xml, its value is "lMarg".</para>
///</summary>
[EnumString("lMarg")]
LeftMargin,
///<summary>
///Left Offset.
///<para>When the item is serialized out as xml, its value is "lOff".</para>
///</summary>
[EnumString("lOff")]
LeftOffset,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
///<summary>
///Right Margin.
///<para>When the item is serialized out as xml, its value is "rMarg".</para>
///</summary>
[EnumString("rMarg")]
RightMargin,
///<summary>
///Right Offset.
///<para>When the item is serialized out as xml, its value is "rOff".</para>
///</summary>
[EnumString("rOff")]
RightOffset,
///<summary>
///Primary Font Size.
///<para>When the item is serialized out as xml, its value is "primFontSz".</para>
///</summary>
[EnumString("primFontSz")]
PrimaryFontSize,
///<summary>
///Pyramid Accent Ratio.
///<para>When the item is serialized out as xml, its value is "pyraAcctRatio".</para>
///</summary>
[EnumString("pyraAcctRatio")]
PyramidAccentRatio,
///<summary>
///Secondary Font Size.
///<para>When the item is serialized out as xml, its value is "secFontSz".</para>
///</summary>
[EnumString("secFontSz")]
SecondaryFontSize,
///<summary>
///Sibling Spacing.
///<para>When the item is serialized out as xml, its value is "sibSp".</para>
///</summary>
[EnumString("sibSp")]
SiblingSpacing,
///<summary>
///Secondary Sibling Spacing.
///<para>When the item is serialized out as xml, its value is "secSibSp".</para>
///</summary>
[EnumString("secSibSp")]
SecondarySiblingSpacing,
///<summary>
///Spacing.
///<para>When the item is serialized out as xml, its value is "sp".</para>
///</summary>
[EnumString("sp")]
Spacing,
///<summary>
///Stem Thickness.
///<para>When the item is serialized out as xml, its value is "stemThick".</para>
///</summary>
[EnumString("stemThick")]
StemThickness,
///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
///<summary>
///Top Margin.
///<para>When the item is serialized out as xml, its value is "tMarg".</para>
///</summary>
[EnumString("tMarg")]
TopMargin,
///<summary>
///Top Offset.
///<para>When the item is serialized out as xml, its value is "tOff".</para>
///</summary>
[EnumString("tOff")]
TopOffset,
///<summary>
///User Defined A.
///<para>When the item is serialized out as xml, its value is "userA".</para>
///</summary>
[EnumString("userA")]
UserDefinedA,
///<summary>
///User Defined B.
///<para>When the item is serialized out as xml, its value is "userB".</para>
///</summary>
[EnumString("userB")]
UserDefinedB,
///<summary>
///User Defined C.
///<para>When the item is serialized out as xml, its value is "userC".</para>
///</summary>
[EnumString("userC")]
UserDefinedC,
///<summary>
///User Defined D.
///<para>When the item is serialized out as xml, its value is "userD".</para>
///</summary>
[EnumString("userD")]
UserDefinedD,
///<summary>
///User Defined E.
///<para>When the item is serialized out as xml, its value is "userE".</para>
///</summary>
[EnumString("userE")]
UserDefinedE,
///<summary>
///User Defined F.
///<para>When the item is serialized out as xml, its value is "userF".</para>
///</summary>
[EnumString("userF")]
UserDefinedF,
///<summary>
///User Defined G.
///<para>When the item is serialized out as xml, its value is "userG".</para>
///</summary>
[EnumString("userG")]
UserDefinedG,
///<summary>
///User Defined H.
///<para>When the item is serialized out as xml, its value is "userH".</para>
///</summary>
[EnumString("userH")]
UserDefinedH,
///<summary>
///User Defined I.
///<para>When the item is serialized out as xml, its value is "userI".</para>
///</summary>
[EnumString("userI")]
UserDefinedI,
///<summary>
///User Defined J.
///<para>When the item is serialized out as xml, its value is "userJ".</para>
///</summary>
[EnumString("userJ")]
UserDefinedJ,
///<summary>
///User Defined K.
///<para>When the item is serialized out as xml, its value is "userK".</para>
///</summary>
[EnumString("userK")]
UserDefinedK,
///<summary>
///User Defined L.
///<para>When the item is serialized out as xml, its value is "userL".</para>
///</summary>
[EnumString("userL")]
UserDefinedL,
///<summary>
///User Defined M.
///<para>When the item is serialized out as xml, its value is "userM".</para>
///</summary>
[EnumString("userM")]
UserDefinedM,
///<summary>
///User Defined N.
///<para>When the item is serialized out as xml, its value is "userN".</para>
///</summary>
[EnumString("userN")]
UserDefinedN,
///<summary>
///User Defined O.
///<para>When the item is serialized out as xml, its value is "userO".</para>
///</summary>
[EnumString("userO")]
UserDefinedO,
///<summary>
///User Defined P.
///<para>When the item is serialized out as xml, its value is "userP".</para>
///</summary>
[EnumString("userP")]
UserDefinedP,
///<summary>
///User Defined Q.
///<para>When the item is serialized out as xml, its value is "userQ".</para>
///</summary>
[EnumString("userQ")]
UserDefinedQ,
///<summary>
///User Defined R.
///<para>When the item is serialized out as xml, its value is "userR".</para>
///</summary>
[EnumString("userR")]
UserDefinedR,
///<summary>
///User Defined S.
///<para>When the item is serialized out as xml, its value is "userS".</para>
///</summary>
[EnumString("userS")]
UserDefinedS,
///<summary>
///User Defined T.
///<para>When the item is serialized out as xml, its value is "userT".</para>
///</summary>
[EnumString("userT")]
UserDefinedT,
///<summary>
///User Defined U.
///<para>When the item is serialized out as xml, its value is "userU".</para>
///</summary>
[EnumString("userU")]
UserDefinedU,
///<summary>
///User Defined V.
///<para>When the item is serialized out as xml, its value is "userV".</para>
///</summary>
[EnumString("userV")]
UserDefinedV,
///<summary>
///User Defined W.
///<para>When the item is serialized out as xml, its value is "userW".</para>
///</summary>
[EnumString("userW")]
UserDefinedW,
///<summary>
///User Defined X.
///<para>When the item is serialized out as xml, its value is "userX".</para>
///</summary>
[EnumString("userX")]
UserDefinedX,
///<summary>
///User Defined Y.
///<para>When the item is serialized out as xml, its value is "userY".</para>
///</summary>
[EnumString("userY")]
UserDefinedY,
///<summary>
///User Defined Z.
///<para>When the item is serialized out as xml, its value is "userZ".</para>
///</summary>
[EnumString("userZ")]
UserDefinedZ,
///<summary>
///Width.
///<para>When the item is serialized out as xml, its value is "w".</para>
///</summary>
[EnumString("w")]
Width,
///<summary>
///Arrowhead Width.
///<para>When the item is serialized out as xml, its value is "wArH".</para>
///</summary>
[EnumString("wArH")]
ArrowheadWidth,
///<summary>
///Width Offset.
///<para>When the item is serialized out as xml, its value is "wOff".</para>
///</summary>
[EnumString("wOff")]
WidthOffset,
 
}
/// <summary>
/// Constraint Relationship 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConstraintRelationshipValues
{  
	///<summary>
///Self.
///<para>When the item is serialized out as xml, its value is "self".</para>
///</summary>
[EnumString("self")]
Self,
///<summary>
///Child.
///<para>When the item is serialized out as xml, its value is "ch".</para>
///</summary>
[EnumString("ch")]
Child,
///<summary>
///Descendant.
///<para>When the item is serialized out as xml, its value is "des".</para>
///</summary>
[EnumString("des")]
Descendant,
 
}
/// <summary>
/// Element Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ElementValues
{  
	///<summary>
///All.
///<para>When the item is serialized out as xml, its value is "all".</para>
///</summary>
[EnumString("all")]
All,
///<summary>
///Document.
///<para>When the item is serialized out as xml, its value is "doc".</para>
///</summary>
[EnumString("doc")]
Document,
///<summary>
///Node.
///<para>When the item is serialized out as xml, its value is "node".</para>
///</summary>
[EnumString("node")]
Node,
///<summary>
///Normal.
///<para>When the item is serialized out as xml, its value is "norm".</para>
///</summary>
[EnumString("norm")]
Normal,
///<summary>
///Non Normal.
///<para>When the item is serialized out as xml, its value is "nonNorm".</para>
///</summary>
[EnumString("nonNorm")]
NonNormal,
///<summary>
///Assistant.
///<para>When the item is serialized out as xml, its value is "asst".</para>
///</summary>
[EnumString("asst")]
Assistant,
///<summary>
///Non Assistant.
///<para>When the item is serialized out as xml, its value is "nonAsst".</para>
///</summary>
[EnumString("nonAsst")]
NonAssistant,
///<summary>
///Parent Transition.
///<para>When the item is serialized out as xml, its value is "parTrans".</para>
///</summary>
[EnumString("parTrans")]
ParentTransition,
///<summary>
///Presentation.
///<para>When the item is serialized out as xml, its value is "pres".</para>
///</summary>
[EnumString("pres")]
Presentation,
///<summary>
///Sibling Transition.
///<para>When the item is serialized out as xml, its value is "sibTrans".</para>
///</summary>
[EnumString("sibTrans")]
SiblingTransition,
 
}
/// <summary>
/// Parameter Identifier 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ParameterIdValues
{  
	///<summary>
///Horizontal Alignment.
///<para>When the item is serialized out as xml, its value is "horzAlign".</para>
///</summary>
[EnumString("horzAlign")]
HorizontalAlignment,
///<summary>
///Vertical Alignment.
///<para>When the item is serialized out as xml, its value is "vertAlign".</para>
///</summary>
[EnumString("vertAlign")]
VerticalAlignment,
///<summary>
///Child Direction.
///<para>When the item is serialized out as xml, its value is "chDir".</para>
///</summary>
[EnumString("chDir")]
ChildDirection,
///<summary>
///Child Alignment.
///<para>When the item is serialized out as xml, its value is "chAlign".</para>
///</summary>
[EnumString("chAlign")]
ChildAlignment,
///<summary>
///Secondary Child Alignment.
///<para>When the item is serialized out as xml, its value is "secChAlign".</para>
///</summary>
[EnumString("secChAlign")]
SecondaryChildAlignment,
///<summary>
///Linear Direction.
///<para>When the item is serialized out as xml, its value is "linDir".</para>
///</summary>
[EnumString("linDir")]
LinearDirection,
///<summary>
///Secondary Linear Direction.
///<para>When the item is serialized out as xml, its value is "secLinDir".</para>
///</summary>
[EnumString("secLinDir")]
SecondaryLinearDirection,
///<summary>
///Start Element.
///<para>When the item is serialized out as xml, its value is "stElem".</para>
///</summary>
[EnumString("stElem")]
StartElement,
///<summary>
///Bend Point.
///<para>When the item is serialized out as xml, its value is "bendPt".</para>
///</summary>
[EnumString("bendPt")]
BendPoint,
///<summary>
///Connection Route.
///<para>When the item is serialized out as xml, its value is "connRout".</para>
///</summary>
[EnumString("connRout")]
ConnectionRoute,
///<summary>
///Beginning Arrowhead Style.
///<para>When the item is serialized out as xml, its value is "begSty".</para>
///</summary>
[EnumString("begSty")]
BeginningArrowheadStyle,
///<summary>
///End Style.
///<para>When the item is serialized out as xml, its value is "endSty".</para>
///</summary>
[EnumString("endSty")]
EndStyle,
///<summary>
///Connector Dimension.
///<para>When the item is serialized out as xml, its value is "dim".</para>
///</summary>
[EnumString("dim")]
ConnectorDimension,
///<summary>
///Rotation Path.
///<para>When the item is serialized out as xml, its value is "rotPath".</para>
///</summary>
[EnumString("rotPath")]
RotationPath,
///<summary>
///Center Shape Mapping.
///<para>When the item is serialized out as xml, its value is "ctrShpMap".</para>
///</summary>
[EnumString("ctrShpMap")]
CenterShapeMapping,
///<summary>
///Node Horizontal Alignment.
///<para>When the item is serialized out as xml, its value is "nodeHorzAlign".</para>
///</summary>
[EnumString("nodeHorzAlign")]
NodeHorizontalAlignment,
///<summary>
///Node Vertical Alignment.
///<para>When the item is serialized out as xml, its value is "nodeVertAlign".</para>
///</summary>
[EnumString("nodeVertAlign")]
NodeVerticalAlignment,
///<summary>
///Fallback Scale.
///<para>When the item is serialized out as xml, its value is "fallback".</para>
///</summary>
[EnumString("fallback")]
FallbackScale,
///<summary>
///Text Direction.
///<para>When the item is serialized out as xml, its value is "txDir".</para>
///</summary>
[EnumString("txDir")]
TextDirection,
///<summary>
///Pyramid Accent Position.
///<para>When the item is serialized out as xml, its value is "pyraAcctPos".</para>
///</summary>
[EnumString("pyraAcctPos")]
PyramidAccentPosition,
///<summary>
///Pyramid Accent Text Margin.
///<para>When the item is serialized out as xml, its value is "pyraAcctTxMar".</para>
///</summary>
[EnumString("pyraAcctTxMar")]
PyramidAccentTextMargin,
///<summary>
///Text Block Direction.
///<para>When the item is serialized out as xml, its value is "txBlDir".</para>
///</summary>
[EnumString("txBlDir")]
TextBlockDirection,
///<summary>
///Text Anchor Horizontal.
///<para>When the item is serialized out as xml, its value is "txAnchorHorz".</para>
///</summary>
[EnumString("txAnchorHorz")]
TextAnchorHorizontal,
///<summary>
///Text Anchor Vertical.
///<para>When the item is serialized out as xml, its value is "txAnchorVert".</para>
///</summary>
[EnumString("txAnchorVert")]
TextAnchorVertical,
///<summary>
///Text Anchor Horizontal With Children.
///<para>When the item is serialized out as xml, its value is "txAnchorHorzCh".</para>
///</summary>
[EnumString("txAnchorHorzCh")]
TextAnchorHorizontalWithChildren,
///<summary>
///Text Anchor Vertical With Children.
///<para>When the item is serialized out as xml, its value is "txAnchorVertCh".</para>
///</summary>
[EnumString("txAnchorVertCh")]
TextAnchorVerticalWithChildren,
///<summary>
///Parent Text Left-to-Right Alignment.
///<para>When the item is serialized out as xml, its value is "parTxLTRAlign".</para>
///</summary>
[EnumString("parTxLTRAlign")]
ParentTextLeftToRightAlignment,
///<summary>
///Parent Text Right-to-Left Alignment.
///<para>When the item is serialized out as xml, its value is "parTxRTLAlign".</para>
///</summary>
[EnumString("parTxRTLAlign")]
ParentTextRightToLeftAlignment,
///<summary>
///Shape Text Left-to-Right Alignment.
///<para>When the item is serialized out as xml, its value is "shpTxLTRAlignCh".</para>
///</summary>
[EnumString("shpTxLTRAlignCh")]
ShapeTextLeftToRightAlignment,
///<summary>
///Shape Text Right-to-Left Alignment.
///<para>When the item is serialized out as xml, its value is "shpTxRTLAlignCh".</para>
///</summary>
[EnumString("shpTxRTLAlignCh")]
ShapeTextRightToLeftAlignment,
///<summary>
///Auto Text Rotation.
///<para>When the item is serialized out as xml, its value is "autoTxRot".</para>
///</summary>
[EnumString("autoTxRot")]
AutoTextRotation,
///<summary>
///Grow Direction.
///<para>When the item is serialized out as xml, its value is "grDir".</para>
///</summary>
[EnumString("grDir")]
GrowDirection,
///<summary>
///Flow Direction.
///<para>When the item is serialized out as xml, its value is "flowDir".</para>
///</summary>
[EnumString("flowDir")]
FlowDirection,
///<summary>
///Continue Direction.
///<para>When the item is serialized out as xml, its value is "contDir".</para>
///</summary>
[EnumString("contDir")]
ContinueDirection,
///<summary>
///Breakpoint.
///<para>When the item is serialized out as xml, its value is "bkpt".</para>
///</summary>
[EnumString("bkpt")]
Breakpoint,
///<summary>
///Offset.
///<para>When the item is serialized out as xml, its value is "off".</para>
///</summary>
[EnumString("off")]
Offset,
///<summary>
///Hierarchy Alignment.
///<para>When the item is serialized out as xml, its value is "hierAlign".</para>
///</summary>
[EnumString("hierAlign")]
HierarchyAlignment,
///<summary>
///Breakpoint Fixed Value.
///<para>When the item is serialized out as xml, its value is "bkPtFixedVal".</para>
///</summary>
[EnumString("bkPtFixedVal")]
BreakpointFixedValue,
///<summary>
///Start Bullets At Level.
///<para>When the item is serialized out as xml, its value is "stBulletLvl".</para>
///</summary>
[EnumString("stBulletLvl")]
StartBulletsAtLevel,
///<summary>
///Start Angle.
///<para>When the item is serialized out as xml, its value is "stAng".</para>
///</summary>
[EnumString("stAng")]
StartAngle,
///<summary>
///Span Angle.
///<para>When the item is serialized out as xml, its value is "spanAng".</para>
///</summary>
[EnumString("spanAng")]
SpanAngle,
///<summary>
///Aspect Ratio.
///<para>When the item is serialized out as xml, its value is "ar".</para>
///</summary>
[EnumString("ar")]
AspectRatio,
///<summary>
///Line Spacing Parent.
///<para>When the item is serialized out as xml, its value is "lnSpPar".</para>
///</summary>
[EnumString("lnSpPar")]
LineSpacingParent,
///<summary>
///Line Spacing After Parent Paragraph.
///<para>When the item is serialized out as xml, its value is "lnSpAfParP".</para>
///</summary>
[EnumString("lnSpAfParP")]
LineSpacingAfterParentParagraph,
///<summary>
///Line Spacing Children.
///<para>When the item is serialized out as xml, its value is "lnSpCh".</para>
///</summary>
[EnumString("lnSpCh")]
LineSpacingChildren,
///<summary>
///Line Spacing After Children Paragraph.
///<para>When the item is serialized out as xml, its value is "lnSpAfChP".</para>
///</summary>
[EnumString("lnSpAfChP")]
LineSpacingAfterChildrenParagraph,
///<summary>
///Route Shortest Distance.
///<para>When the item is serialized out as xml, its value is "rtShortDist".</para>
///</summary>
[EnumString("rtShortDist")]
RouteShortestDistance,
///<summary>
///Text Alignment.
///<para>When the item is serialized out as xml, its value is "alignTx".</para>
///</summary>
[EnumString("alignTx")]
TextAlignment,
///<summary>
///Pyramid Level Node.
///<para>When the item is serialized out as xml, its value is "pyraLvlNode".</para>
///</summary>
[EnumString("pyraLvlNode")]
PyramidLevelNode,
///<summary>
///Pyramid Accent Background Node.
///<para>When the item is serialized out as xml, its value is "pyraAcctBkgdNode".</para>
///</summary>
[EnumString("pyraAcctBkgdNode")]
PyramidAccentBackgroundNode,
///<summary>
///Pyramid Accent Text Node.
///<para>When the item is serialized out as xml, its value is "pyraAcctTxNode".</para>
///</summary>
[EnumString("pyraAcctTxNode")]
PyramidAccentTextNode,
///<summary>
///Source Node.
///<para>When the item is serialized out as xml, its value is "srcNode".</para>
///</summary>
[EnumString("srcNode")]
SourceNode,
///<summary>
///Destination Node.
///<para>When the item is serialized out as xml, its value is "dstNode".</para>
///</summary>
[EnumString("dstNode")]
DestinationNode,
///<summary>
///Beginning Points.
///<para>When the item is serialized out as xml, its value is "begPts".</para>
///</summary>
[EnumString("begPts")]
BeginningPoints,
///<summary>
///End Points.
///<para>When the item is serialized out as xml, its value is "endPts".</para>
///</summary>
[EnumString("endPts")]
EndPoints,
 
}
/// <summary>
/// Function Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FunctionValues
{  
	///<summary>
///Count.
///<para>When the item is serialized out as xml, its value is "cnt".</para>
///</summary>
[EnumString("cnt")]
Count,
///<summary>
///Position.
///<para>When the item is serialized out as xml, its value is "pos".</para>
///</summary>
[EnumString("pos")]
Position,
///<summary>
///Reverse Position.
///<para>When the item is serialized out as xml, its value is "revPos".</para>
///</summary>
[EnumString("revPos")]
ReversePosition,
///<summary>
///Position Even.
///<para>When the item is serialized out as xml, its value is "posEven".</para>
///</summary>
[EnumString("posEven")]
PositionEven,
///<summary>
///Position Odd.
///<para>When the item is serialized out as xml, its value is "posOdd".</para>
///</summary>
[EnumString("posOdd")]
PositionOdd,
///<summary>
///Variable.
///<para>When the item is serialized out as xml, its value is "var".</para>
///</summary>
[EnumString("var")]
Variable,
///<summary>
///Depth.
///<para>When the item is serialized out as xml, its value is "depth".</para>
///</summary>
[EnumString("depth")]
Depth,
///<summary>
///Max Depth.
///<para>When the item is serialized out as xml, its value is "maxDepth".</para>
///</summary>
[EnumString("maxDepth")]
MaxDepth,
 
}
/// <summary>
/// Function Operator 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FunctionOperatorValues
{  
	///<summary>
///Equal.
///<para>When the item is serialized out as xml, its value is "equ".</para>
///</summary>
[EnumString("equ")]
Equal,
///<summary>
///Not Equal To.
///<para>When the item is serialized out as xml, its value is "neq".</para>
///</summary>
[EnumString("neq")]
NotEqualTo,
///<summary>
///Greater Than.
///<para>When the item is serialized out as xml, its value is "gt".</para>
///</summary>
[EnumString("gt")]
GreaterThan,
///<summary>
///Less Than.
///<para>When the item is serialized out as xml, its value is "lt".</para>
///</summary>
[EnumString("lt")]
LessThan,
///<summary>
///Greater Than or Equal to.
///<para>When the item is serialized out as xml, its value is "gte".</para>
///</summary>
[EnumString("gte")]
GreaterThanOrEqualTo,
///<summary>
///Less Than or Equal to.
///<para>When the item is serialized out as xml, its value is "lte".</para>
///</summary>
[EnumString("lte")]
LessThanOrEqualTo,
 
}
/// <summary>
/// Horizontal Alignment 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum HorizontalAlignmentValues
{  
	///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Center.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
 
}
/// <summary>
/// Child Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ChildDirectionValues
{  
	///<summary>
///Horizontal.
///<para>When the item is serialized out as xml, its value is "horz".</para>
///</summary>
[EnumString("horz")]
Horizontal,
///<summary>
///Vertical.
///<para>When the item is serialized out as xml, its value is "vert".</para>
///</summary>
[EnumString("vert")]
Vertical,
 
}
/// <summary>
/// Child Alignment 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ChildAlignmentValues
{  
	///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
 
}
/// <summary>
/// Secondary Child Alignment 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SecondaryChildAlignmentValues
{  
	///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
 
}
/// <summary>
/// Linear Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LinearDirectionValues
{  
	///<summary>
///From Left.
///<para>When the item is serialized out as xml, its value is "fromL".</para>
///</summary>
[EnumString("fromL")]
FromLeft,
///<summary>
///From Right.
///<para>When the item is serialized out as xml, its value is "fromR".</para>
///</summary>
[EnumString("fromR")]
FromRight,
///<summary>
///From Top.
///<para>When the item is serialized out as xml, its value is "fromT".</para>
///</summary>
[EnumString("fromT")]
FromTop,
///<summary>
///From Bottom.
///<para>When the item is serialized out as xml, its value is "fromB".</para>
///</summary>
[EnumString("fromB")]
FromBottom,
 
}
/// <summary>
/// Secondary Linear Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SecondaryLinearDirectionValues
{  
	///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///From Left.
///<para>When the item is serialized out as xml, its value is "fromL".</para>
///</summary>
[EnumString("fromL")]
FromLeft,
///<summary>
///From Right.
///<para>When the item is serialized out as xml, its value is "fromR".</para>
///</summary>
[EnumString("fromR")]
FromRight,
///<summary>
///From Top.
///<para>When the item is serialized out as xml, its value is "fromT".</para>
///</summary>
[EnumString("fromT")]
FromTop,
///<summary>
///From Bottom.
///<para>When the item is serialized out as xml, its value is "fromB".</para>
///</summary>
[EnumString("fromB")]
FromBottom,
 
}
/// <summary>
/// Starting Element 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StartingElementValues
{  
	///<summary>
///Node.
///<para>When the item is serialized out as xml, its value is "node".</para>
///</summary>
[EnumString("node")]
Node,
///<summary>
///Transition.
///<para>When the item is serialized out as xml, its value is "trans".</para>
///</summary>
[EnumString("trans")]
Transition,
 
}
/// <summary>
/// Rotation Path 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum RotationPathValues
{  
	///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Along Path.
///<para>When the item is serialized out as xml, its value is "alongPath".</para>
///</summary>
[EnumString("alongPath")]
AlongPath,
 
}
/// <summary>
/// Center Shape Mapping 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum CenterShapeMappingValues
{  
	///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///First Node.
///<para>When the item is serialized out as xml, its value is "fNode".</para>
///</summary>
[EnumString("fNode")]
FirstNode,
 
}
/// <summary>
/// Bend Point 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BendPointValues
{  
	///<summary>
///Beginning.
///<para>When the item is serialized out as xml, its value is "beg".</para>
///</summary>
[EnumString("beg")]
Beginning,
///<summary>
///Default.
///<para>When the item is serialized out as xml, its value is "def".</para>
///</summary>
[EnumString("def")]
Default,
///<summary>
///End.
///<para>When the item is serialized out as xml, its value is "end".</para>
///</summary>
[EnumString("end")]
End,
 
}
/// <summary>
/// Connector Routing 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConnectorRoutingValues
{  
	///<summary>
///Straight.
///<para>When the item is serialized out as xml, its value is "stra".</para>
///</summary>
[EnumString("stra")]
Straight,
///<summary>
///Bending.
///<para>When the item is serialized out as xml, its value is "bend".</para>
///</summary>
[EnumString("bend")]
Bending,
///<summary>
///Curve.
///<para>When the item is serialized out as xml, its value is "curve".</para>
///</summary>
[EnumString("curve")]
Curve,
///<summary>
///Long Curve.
///<para>When the item is serialized out as xml, its value is "longCurve".</para>
///</summary>
[EnumString("longCurve")]
LongCurve,
 
}
/// <summary>
/// Arrowhead Styles 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ArrowheadStyleValues
{  
	///<summary>
///Auto.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,
///<summary>
///Arrowhead Present.
///<para>When the item is serialized out as xml, its value is "arr".</para>
///</summary>
[EnumString("arr")]
Arrow,
///<summary>
///No Arrowhead.
///<para>When the item is serialized out as xml, its value is "noArr".</para>
///</summary>
[EnumString("noArr")]
NoArrow,
 
}
/// <summary>
/// Connector Dimension 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConnectorDimensionValues
{  
	///<summary>
///1 Dimension.
///<para>When the item is serialized out as xml, its value is "1D".</para>
///</summary>
[EnumString("1D")]
OneDimension,
///<summary>
///2 Dimensions.
///<para>When the item is serialized out as xml, its value is "2D".</para>
///</summary>
[EnumString("2D")]
TwoDimension,
///<summary>
///Custom.
///<para>When the item is serialized out as xml, its value is "cust".</para>
///</summary>
[EnumString("cust")]
Custom,
 
}
/// <summary>
/// Connector Point 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConnectorPointValues
{  
	///<summary>
///Auto.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,
///<summary>
///Bottom Center.
///<para>When the item is serialized out as xml, its value is "bCtr".</para>
///</summary>
[EnumString("bCtr")]
BottomCenter,
///<summary>
///Center.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
///<summary>
///Middle Left.
///<para>When the item is serialized out as xml, its value is "midL".</para>
///</summary>
[EnumString("midL")]
MiddleLeft,
///<summary>
///Middle Right.
///<para>When the item is serialized out as xml, its value is "midR".</para>
///</summary>
[EnumString("midR")]
MiddleRight,
///<summary>
///Top Center.
///<para>When the item is serialized out as xml, its value is "tCtr".</para>
///</summary>
[EnumString("tCtr")]
TopCenter,
///<summary>
///Bottom Left.
///<para>When the item is serialized out as xml, its value is "bL".</para>
///</summary>
[EnumString("bL")]
BottomLeft,
///<summary>
///Bottom Right.
///<para>When the item is serialized out as xml, its value is "bR".</para>
///</summary>
[EnumString("bR")]
BottomRight,
///<summary>
///Top Left.
///<para>When the item is serialized out as xml, its value is "tL".</para>
///</summary>
[EnumString("tL")]
TopLeft,
///<summary>
///Top Right.
///<para>When the item is serialized out as xml, its value is "tR".</para>
///</summary>
[EnumString("tR")]
TopRight,
///<summary>
///Radial.
///<para>When the item is serialized out as xml, its value is "radial".</para>
///</summary>
[EnumString("radial")]
Radial,
 
}
/// <summary>
/// Node Horizontal Alignment 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum NodeHorizontalAlignmentValues
{  
	///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Center.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
 
}
/// <summary>
/// Node Vertical Alignment 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum NodeVerticalAlignmentValues
{  
	///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
///<summary>
///Middle.
///<para>When the item is serialized out as xml, its value is "mid".</para>
///</summary>
[EnumString("mid")]
Middle,
///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
 
}
/// <summary>
/// Fallback Dimension 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FallbackDimensionValues
{  
	///<summary>
///1 Dimension.
///<para>When the item is serialized out as xml, its value is "1D".</para>
///</summary>
[EnumString("1D")]
OneDimension,
///<summary>
///2 Dimensions.
///<para>When the item is serialized out as xml, its value is "2D".</para>
///</summary>
[EnumString("2D")]
TwoDimension,
 
}
/// <summary>
/// Text Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TextDirectionValues
{  
	///<summary>
///From Top.
///<para>When the item is serialized out as xml, its value is "fromT".</para>
///</summary>
[EnumString("fromT")]
FromTop,
///<summary>
///From Bottom.
///<para>When the item is serialized out as xml, its value is "fromB".</para>
///</summary>
[EnumString("fromB")]
FromBottom,
 
}
/// <summary>
/// Pyramid Accent Position 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PyramidAccentPositionValues
{  
	///<summary>
///Before.
///<para>When the item is serialized out as xml, its value is "bef".</para>
///</summary>
[EnumString("bef")]
Before,
///<summary>
///Pyramid Accent After.
///<para>When the item is serialized out as xml, its value is "aft".</para>
///</summary>
[EnumString("aft")]
After,
 
}
/// <summary>
/// Pyramid Accent Text Margin 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PyramidAccentTextMarginValues
{  
	///<summary>
///Step.
///<para>When the item is serialized out as xml, its value is "step".</para>
///</summary>
[EnumString("step")]
Step,
///<summary>
///Stack.
///<para>When the item is serialized out as xml, its value is "stack".</para>
///</summary>
[EnumString("stack")]
Stack,
 
}
/// <summary>
/// Text Block Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TextBlockDirectionValues
{  
	///<summary>
///Horizontal.
///<para>When the item is serialized out as xml, its value is "horz".</para>
///</summary>
[EnumString("horz")]
Horizontal,
///<summary>
///Vertical Direction.
///<para>When the item is serialized out as xml, its value is "vert".</para>
///</summary>
[EnumString("vert")]
Vertical,
 
}
/// <summary>
/// Text Anchor Horizontal 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TextAnchorHorizontalValues
{  
	///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Center.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
 
}
/// <summary>
/// Text Anchor Vertical 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TextAnchorVerticalValues
{  
	///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
///<summary>
///Middle.
///<para>When the item is serialized out as xml, its value is "mid".</para>
///</summary>
[EnumString("mid")]
Middle,
///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
 
}
/// <summary>
/// Text Alignment 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TextAlignmentValues
{  
	///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Center.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
 
}
/// <summary>
/// Auto Text Rotation 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AutoTextRotationValues
{  
	///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Upright.
///<para>When the item is serialized out as xml, its value is "upr".</para>
///</summary>
[EnumString("upr")]
Upright,
///<summary>
///Gravity.
///<para>When the item is serialized out as xml, its value is "grav".</para>
///</summary>
[EnumString("grav")]
Gravity,
 
}
/// <summary>
/// Grow Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum GrowDirectionValues
{  
	///<summary>
///Top Left.
///<para>When the item is serialized out as xml, its value is "tL".</para>
///</summary>
[EnumString("tL")]
TopLeft,
///<summary>
///Top Right.
///<para>When the item is serialized out as xml, its value is "tR".</para>
///</summary>
[EnumString("tR")]
TopRight,
///<summary>
///Bottom Left.
///<para>When the item is serialized out as xml, its value is "bL".</para>
///</summary>
[EnumString("bL")]
BottomLeft,
///<summary>
///Bottom Right.
///<para>When the item is serialized out as xml, its value is "bR".</para>
///</summary>
[EnumString("bR")]
BottomRight,
 
}
/// <summary>
/// Flow Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FlowDirectionValues
{  
	///<summary>
///Row.
///<para>When the item is serialized out as xml, its value is "row".</para>
///</summary>
[EnumString("row")]
Row,
///<summary>
///Column.
///<para>When the item is serialized out as xml, its value is "col".</para>
///</summary>
[EnumString("col")]
Column,
 
}
/// <summary>
/// Continue Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ContinueDirectionValues
{  
	///<summary>
///Reverse Direction.
///<para>When the item is serialized out as xml, its value is "revDir".</para>
///</summary>
[EnumString("revDir")]
ReverseDirection,
///<summary>
///Same Direction.
///<para>When the item is serialized out as xml, its value is "sameDir".</para>
///</summary>
[EnumString("sameDir")]
SameDirection,
 
}
/// <summary>
/// Breakpoint 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BreakpointValues
{  
	///<summary>
///End of Canvas.
///<para>When the item is serialized out as xml, its value is "endCnv".</para>
///</summary>
[EnumString("endCnv")]
EndCanvas,
///<summary>
///Balanced.
///<para>When the item is serialized out as xml, its value is "bal".</para>
///</summary>
[EnumString("bal")]
Balanced,
///<summary>
///Fixed.
///<para>When the item is serialized out as xml, its value is "fixed".</para>
///</summary>
[EnumString("fixed")]
Fixed,
 
}
/// <summary>
/// Offset 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OffsetValues
{  
	///<summary>
///Center.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
///<summary>
///Offset.
///<para>When the item is serialized out as xml, its value is "off".</para>
///</summary>
[EnumString("off")]
Offset,
 
}
/// <summary>
/// Hierarchy Alignment 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum HierarchyAlignmentValues
{  
	///<summary>
///Top Left.
///<para>When the item is serialized out as xml, its value is "tL".</para>
///</summary>
[EnumString("tL")]
TopLeft,
///<summary>
///Top Right.
///<para>When the item is serialized out as xml, its value is "tR".</para>
///</summary>
[EnumString("tR")]
TopRight,
///<summary>
///Top Center Children.
///<para>When the item is serialized out as xml, its value is "tCtrCh".</para>
///</summary>
[EnumString("tCtrCh")]
TopCenterChildren,
///<summary>
///Top Center Descendants.
///<para>When the item is serialized out as xml, its value is "tCtrDes".</para>
///</summary>
[EnumString("tCtrDes")]
TopCenterDescendants,
///<summary>
///Bottom Left.
///<para>When the item is serialized out as xml, its value is "bL".</para>
///</summary>
[EnumString("bL")]
BottomLeft,
///<summary>
///Bottom Right.
///<para>When the item is serialized out as xml, its value is "bR".</para>
///</summary>
[EnumString("bR")]
BottomRight,
///<summary>
///Bottom Center Child.
///<para>When the item is serialized out as xml, its value is "bCtrCh".</para>
///</summary>
[EnumString("bCtrCh")]
BottomCenterChild,
///<summary>
///Bottom Center Descendant.
///<para>When the item is serialized out as xml, its value is "bCtrDes".</para>
///</summary>
[EnumString("bCtrDes")]
BottomCenterDescendant,
///<summary>
///Left Top.
///<para>When the item is serialized out as xml, its value is "lT".</para>
///</summary>
[EnumString("lT")]
LeftTop,
///<summary>
///Left Bottom.
///<para>When the item is serialized out as xml, its value is "lB".</para>
///</summary>
[EnumString("lB")]
LeftBottom,
///<summary>
///Left Center Child.
///<para>When the item is serialized out as xml, its value is "lCtrCh".</para>
///</summary>
[EnumString("lCtrCh")]
LeftCenterChild,
///<summary>
///Left Center Descendant.
///<para>When the item is serialized out as xml, its value is "lCtrDes".</para>
///</summary>
[EnumString("lCtrDes")]
LeftCenterDescendant,
///<summary>
///Right Top.
///<para>When the item is serialized out as xml, its value is "rT".</para>
///</summary>
[EnumString("rT")]
RightTop,
///<summary>
///Right Bottom.
///<para>When the item is serialized out as xml, its value is "rB".</para>
///</summary>
[EnumString("rB")]
RightBottom,
///<summary>
///Right Center Children.
///<para>When the item is serialized out as xml, its value is "rCtrCh".</para>
///</summary>
[EnumString("rCtrCh")]
RightCenterChildren,
///<summary>
///Right Center Descendants.
///<para>When the item is serialized out as xml, its value is "rCtrDes".</para>
///</summary>
[EnumString("rCtrDes")]
RightCenterDescendants,
 
}
/// <summary>
/// Variable Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum VariableValues
{  
	///<summary>
///Unknown.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Organizational Chart Algorithm.
///<para>When the item is serialized out as xml, its value is "orgChart".</para>
///</summary>
[EnumString("orgChart")]
OrganizationalChart,
///<summary>
///Child Max.
///<para>When the item is serialized out as xml, its value is "chMax".</para>
///</summary>
[EnumString("chMax")]
ChildMax,
///<summary>
///Child Preference.
///<para>When the item is serialized out as xml, its value is "chPref".</para>
///</summary>
[EnumString("chPref")]
ChildPreference,
///<summary>
///Bullets Enabled.
///<para>When the item is serialized out as xml, its value is "bulEnabled".</para>
///</summary>
[EnumString("bulEnabled")]
BulletsEnabled,
///<summary>
///Direction.
///<para>When the item is serialized out as xml, its value is "dir".</para>
///</summary>
[EnumString("dir")]
Direction,
///<summary>
///Hierarchy Branch.
///<para>When the item is serialized out as xml, its value is "hierBranch".</para>
///</summary>
[EnumString("hierBranch")]
HierarchyBranch,
///<summary>
///Animate One.
///<para>When the item is serialized out as xml, its value is "animOne".</para>
///</summary>
[EnumString("animOne")]
AnimateOne,
///<summary>
///Animation Level.
///<para>When the item is serialized out as xml, its value is "animLvl".</para>
///</summary>
[EnumString("animLvl")]
AnimationLevel,
///<summary>
///Resize Handles.
///<para>When the item is serialized out as xml, its value is "resizeHandles".</para>
///</summary>
[EnumString("resizeHandles")]
ResizeHandles,
 
}
/// <summary>
/// Output Shape Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OutputShapeValues
{  
	///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Connection.
///<para>When the item is serialized out as xml, its value is "conn".</para>
///</summary>
[EnumString("conn")]
Connection,
 
}
/// <summary>
/// Vertical Alignment 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum VerticalAlignmentValues
{  
	///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
///<summary>
///Middle.
///<para>When the item is serialized out as xml, its value is "mid".</para>
///</summary>
[EnumString("mid")]
Middle,
///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///top.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top2010,
///<summary>
///center.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Middle2010,
///<summary>
///bottom.
///<para>When the item is serialized out as xml, its value is "bottom".</para>
///</summary>
[EnumString("bottom")]
Bottom2010,
 
}
}
 
 
