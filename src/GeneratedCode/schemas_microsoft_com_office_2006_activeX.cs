// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.ActiveX
{
/// <summary>
/// <para>Defines the ActiveXControlData Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ax:ocx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ActiveXObjectProperty &lt;ax:ocxPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ActiveXObjectProperty))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ActiveXControlData : OpenXmlCompositeElement
{
    private const string tagName = "ocx";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 35;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12688;
    
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
    

    private static string[] attributeTagNames = { "classid","license","id","persistence" };
    private static byte[] attributeNamespaceIds = { 35,35,19,35 };
    
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
    /// <para> classid.</para>
    /// <para>Represents the following attribute in the schema: ax:classid </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "classid")]
    public StringValue ActiveXControlClassId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> license.</para>
    /// <para>Represents the following attribute in the schema: ax:license </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "license")]
    public StringValue License
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> persistence.</para>
    /// <para>Represents the following attribute in the schema: ax:persistence </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "persistence")]
    public EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues> Persistence
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ActiveXControlData class.
    /// </summary>
    public ActiveXControlData():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ActiveXControlData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ActiveXControlData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ActiveXControlData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ActiveXControlData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ActiveXControlData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ActiveXControlData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 35 == namespaceId && "ocxPr" == name)
    return new ActiveXObjectProperty();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 35 == namespaceId && "classid" == name)
    return new StringValue();
    
if( 35 == namespaceId && "license" == name)
    return new StringValue();
    
if( 19 == namespaceId && "id" == name)
    return new StringValue();
    
if( 35 == namespaceId && "persistence" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ActiveXControlData>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ActiveXObjectProperty Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ax:ocxPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SharedComFont &lt;ax:font></description></item>
///<item><description>SharedComPicture &lt;ax:picture></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SharedComFont))]
    [ChildElementInfo(typeof(SharedComPicture))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ActiveXObjectProperty : OpenXmlCompositeElement
{
    private const string tagName = "ocxPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 35;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12689;
    
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
    

    private static string[] attributeTagNames = { "name","value" };
    private static byte[] attributeNamespaceIds = { 35,35 };
    
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
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: ax:name </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: ax:value </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "value")]
    public StringValue Value
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ActiveXObjectProperty class.
    /// </summary>
    public ActiveXObjectProperty():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ActiveXObjectProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ActiveXObjectProperty(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ActiveXObjectProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ActiveXObjectProperty(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ActiveXObjectProperty class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ActiveXObjectProperty(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 35 == namespaceId && "font" == name)
    return new SharedComFont();
    
if( 35 == namespaceId && "picture" == name)
    return new SharedComPicture();
    

    return null;
}

        private static readonly string[] eleTagNames = { "font","picture" };
    private static readonly byte[] eleNamespaceIds = { 35,35 };
    
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
    /// <para> SharedComFont.</para>
    /// <para> Represents the following element tag in the schema: ax:font </para>
    /// </summary>
    /// <remark>
    /// xmlns:ax = http://schemas.microsoft.com/office/2006/activeX
    /// </remark>
    public SharedComFont SharedComFont
    {
        get 
        {
            return GetElement<SharedComFont>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> SharedComPicture.</para>
    /// <para> Represents the following element tag in the schema: ax:picture </para>
    /// </summary>
    /// <remark>
    /// xmlns:ax = http://schemas.microsoft.com/office/2006/activeX
    /// </remark>
    public SharedComPicture SharedComPicture
    {
        get 
        {
            return GetElement<SharedComPicture>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 35 == namespaceId && "name" == name)
    return new StringValue();
    
if( 35 == namespaceId && "value" == name)
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
        return CloneImp<ActiveXObjectProperty>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SharedComFont Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ax:font.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ActiveXObjectProperty &lt;ax:ocxPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ActiveXObjectProperty))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SharedComFont : OpenXmlCompositeElement
{
    private const string tagName = "font";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 35;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12690;
    
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
    

    private static string[] attributeTagNames = { "persistence","id" };
    private static byte[] attributeNamespaceIds = { 35,19 };
    
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
    /// <para> persistence.</para>
    /// <para>Represents the following attribute in the schema: ax:persistence </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "persistence")]
    public EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues> Persistence
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SharedComFont class.
    /// </summary>
    public SharedComFont():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SharedComFont class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedComFont(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedComFont class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedComFont(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedComFont class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SharedComFont(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 35 == namespaceId && "ocxPr" == name)
    return new ActiveXObjectProperty();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 35 == namespaceId && "persistence" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>();
    
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
        return CloneImp<SharedComFont>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SharedComPicture Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ax:picture.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SharedComPicture : OpenXmlLeafElement
{
    private const string tagName = "picture";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 35;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12691;
    
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
    

    private static string[] attributeTagNames = { "id" };
    private static byte[] attributeNamespaceIds = { 19 };
    
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
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SharedComPicture class.
    /// </summary>
    public SharedComPicture():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
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
        return CloneImp<SharedComPicture>(deep);
    }

   
}
/// <summary>
/// Defines the PersistenceValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PersistenceValues
{  
	///<summary>
///persistPropertyBag.
///<para>When the item is serialized out as xml, its value is "persistPropertyBag".</para>
///</summary>
[EnumString("persistPropertyBag")]
PersistPropertyBag,
///<summary>
///persistStream.
///<para>When the item is serialized out as xml, its value is "persistStream".</para>
///</summary>
[EnumString("persistStream")]
PersistStream,
///<summary>
///persistStreamInit.
///<para>When the item is serialized out as xml, its value is "persistStreamInit".</para>
///</summary>
[EnumString("persistStreamInit")]
PersistStreamInit,
///<summary>
///persistStorage.
///<para>When the item is serialized out as xml, its value is "persistStorage".</para>
///</summary>
[EnumString("persistStorage")]
PersistStorage,
 
}
}
 
 
