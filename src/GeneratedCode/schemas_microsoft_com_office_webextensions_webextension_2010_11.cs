// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2013.WebExtension
{
/// <summary>
/// <para>Defines the WebExtension Class. The root element of WebExtensionPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:webextension.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtensionStoreReference &lt;we:reference></description></item>
///<item><description>WebExtensionReferenceList &lt;we:alternateReferences></description></item>
///<item><description>WebExtensionPropertyBag &lt;we:properties></description></item>
///<item><description>WebExtensionBindingList &lt;we:bindings></description></item>
///<item><description>Snapshot &lt;we:snapshot></description></item>
///<item><description>OfficeArtExtensionList &lt;we:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(WebExtensionStoreReference),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(WebExtensionReferenceList),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(WebExtensionPropertyBag),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(WebExtensionBindingList),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(Snapshot),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(OfficeArtExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtension : OpenXmlPartRootElement
{
    private const string tagName = "webextension";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 66;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13310;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","frozen" };
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> frozen.</para>
    /// <para>Represents the following attribute in the schema: frozen </para>
    /// </summary>
    [SchemaAttr(0, "frozen")]
    public BooleanValue Fronzen
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    
    /// <summary>
    /// WebExtension constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the WebExtension.</param>
    internal WebExtension(WebExtensionPart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the WebExtensionPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(WebExtensionPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the WebExtensionPart associated with this element.
    /// </summary>
    public WebExtensionPart WebExtensionPart
    {
		get
		{
			return OpenXmlPart as WebExtensionPart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the WebExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtension(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the WebExtension class.
    /// </summary>
    public WebExtension() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the WebExtensionPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(WebExtensionPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 66 == namespaceId && "reference" == name)
    return new WebExtensionStoreReference();
    
if( 66 == namespaceId && "alternateReferences" == name)
    return new WebExtensionReferenceList();
    
if( 66 == namespaceId && "properties" == name)
    return new WebExtensionPropertyBag();
    
if( 66 == namespaceId && "bindings" == name)
    return new WebExtensionBindingList();
    
if( 66 == namespaceId && "snapshot" == name)
    return new Snapshot();
    
if( 66 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "reference","alternateReferences","properties","bindings","snapshot","extLst" };
    private static readonly byte[] eleNamespaceIds = { 66,66,66,66,66,66 };
    
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
    /// <para> WebExtensionStoreReference.</para>
    /// <para> Represents the following element tag in the schema: we:reference </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
    public WebExtensionStoreReference WebExtensionStoreReference
    {
        get 
        {
            return GetElement<WebExtensionStoreReference>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> WebExtensionReferenceList.</para>
    /// <para> Represents the following element tag in the schema: we:alternateReferences </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
    public WebExtensionReferenceList WebExtensionReferenceList
    {
        get 
        {
            return GetElement<WebExtensionReferenceList>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> WebExtensionPropertyBag.</para>
    /// <para> Represents the following element tag in the schema: we:properties </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
    public WebExtensionPropertyBag WebExtensionPropertyBag
    {
        get 
        {
            return GetElement<WebExtensionPropertyBag>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> WebExtensionBindingList.</para>
    /// <para> Represents the following element tag in the schema: we:bindings </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
    public WebExtensionBindingList WebExtensionBindingList
    {
        get 
        {
            return GetElement<WebExtensionBindingList>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Snapshot.</para>
    /// <para> Represents the following element tag in the schema: we:snapshot </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
    public Snapshot Snapshot
    {
        get 
        {
            return GetElement<Snapshot>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: we:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get 
        {
            return GetElement<OfficeArtExtensionList>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "frozen" == name)
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
        return CloneImp<WebExtension>(deep);
    }

}
/// <summary>
/// <para>Defines the WebExtensionReference Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:webextensionref.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionReference : OpenXmlLeafElement
{
    private const string tagName = "webextensionref";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 66;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13311;
    
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
		if((4 & (int)version) > 0)
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
    /// Initializes a new instance of the WebExtensionReference class.
    /// </summary>
    public WebExtensionReference():base(){}
    
      
     
    
    
    
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
        return CloneImp<WebExtensionReference>(deep);
    }

   
}
/// <summary>
/// <para>Defines the WebExtensionProperty Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:property.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionProperty : OpenXmlLeafElement
{
    private const string tagName = "property";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 66;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13312;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "name","value" };
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
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    public StringValue Value
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the WebExtensionProperty class.
    /// </summary>
    public WebExtensionProperty():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "name" == name)
    return new StringValue();
    
if( 0 == namespaceId && "value" == name)
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
        return CloneImp<WebExtensionProperty>(deep);
    }

   
}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:extLst.</para>
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
[OfficeAvailability(FileFormatVersions.Office2013)]
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
    
    private const byte tagNsId = 66;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13313;
    
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
		if((4 & (int)version) > 0)
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
/// <summary>
/// <para>Defines the WebExtensionBinding Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:binding.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfficeArtExtensionList &lt;we:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(OfficeArtExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionBinding : OpenXmlCompositeElement
{
    private const string tagName = "binding";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 66;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13314;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","type","appref" };
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public StringValue Type
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> appref.</para>
    /// <para>Represents the following attribute in the schema: appref </para>
    /// </summary>
    [SchemaAttr(0, "appref")]
    public StringValue AppReference
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the WebExtensionBinding class.
    /// </summary>
    public WebExtensionBinding():base(){}
    
            /// <summary>
    ///Initializes a new instance of the WebExtensionBinding class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionBinding(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionBinding class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionBinding(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionBinding class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionBinding(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 66 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 66 };
    
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
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: we:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get 
        {
            return GetElement<OfficeArtExtensionList>(0);
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
    return new StringValue();
    
if( 0 == namespaceId && "appref" == name)
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
        return CloneImp<WebExtensionBinding>(deep);
    }

   
}
/// <summary>
/// <para>Defines the WebExtensionStoreReference Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:reference.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfficeArtExtensionList &lt;we:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(OfficeArtExtensionList),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionStoreReference : OpenXmlCompositeElement
{
    private const string tagName = "reference";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 66;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13315;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","version","store","storeType" };
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> version.</para>
    /// <para>Represents the following attribute in the schema: version </para>
    /// </summary>
    [SchemaAttr(0, "version")]
    public StringValue Version
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> store.</para>
    /// <para>Represents the following attribute in the schema: store </para>
    /// </summary>
    [SchemaAttr(0, "store")]
    public StringValue Store
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> storeType.</para>
    /// <para>Represents the following attribute in the schema: storeType </para>
    /// </summary>
    [SchemaAttr(0, "storeType")]
    public StringValue StoreType
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the WebExtensionStoreReference class.
    /// </summary>
    public WebExtensionStoreReference():base(){}
    
            /// <summary>
    ///Initializes a new instance of the WebExtensionStoreReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionStoreReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionStoreReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionStoreReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionStoreReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionStoreReference(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 66 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 66 };
    
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
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: we:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get 
        {
            return GetElement<OfficeArtExtensionList>(0);
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
    
if( 0 == namespaceId && "version" == name)
    return new StringValue();
    
if( 0 == namespaceId && "store" == name)
    return new StringValue();
    
if( 0 == namespaceId && "storeType" == name)
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
        return CloneImp<WebExtensionStoreReference>(deep);
    }

   
}
/// <summary>
/// <para>Defines the WebExtensionReferenceList Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:alternateReferences.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtensionStoreReference &lt;we:reference></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(WebExtensionStoreReference),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionReferenceList : OpenXmlCompositeElement
{
    private const string tagName = "alternateReferences";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 66;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13316;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionReferenceList class.
    /// </summary>
    public WebExtensionReferenceList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the WebExtensionReferenceList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionReferenceList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionReferenceList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionReferenceList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionReferenceList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionReferenceList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 66 == namespaceId && "reference" == name)
    return new WebExtensionStoreReference();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<WebExtensionReferenceList>(deep);
    }

   
}
/// <summary>
/// <para>Defines the WebExtensionPropertyBag Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:properties.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtensionProperty &lt;we:property></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(WebExtensionProperty),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionPropertyBag : OpenXmlCompositeElement
{
    private const string tagName = "properties";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 66;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13317;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionPropertyBag class.
    /// </summary>
    public WebExtensionPropertyBag():base(){}
    
            /// <summary>
    ///Initializes a new instance of the WebExtensionPropertyBag class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionPropertyBag(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionPropertyBag class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionPropertyBag(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionPropertyBag class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionPropertyBag(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 66 == namespaceId && "property" == name)
    return new WebExtensionProperty();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<WebExtensionPropertyBag>(deep);
    }

   
}
/// <summary>
/// <para>Defines the WebExtensionBindingList Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:bindings.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtensionBinding &lt;we:binding></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(WebExtensionBinding),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionBindingList : OpenXmlCompositeElement
{
    private const string tagName = "bindings";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 66;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13318;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionBindingList class.
    /// </summary>
    public WebExtensionBindingList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the WebExtensionBindingList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionBindingList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionBindingList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionBindingList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionBindingList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionBindingList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 66 == namespaceId && "binding" == name)
    return new WebExtensionBinding();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<WebExtensionBindingList>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Snapshot Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:snapshot.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaBiLevel &lt;a:alphaBiLevel></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaCeiling &lt;a:alphaCeiling></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaFloor &lt;a:alphaFloor></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaInverse &lt;a:alphaInv></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaModulationEffect &lt;a:alphaMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaModulationFixed &lt;a:alphaModFix></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaReplace &lt;a:alphaRepl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BiLevel &lt;a:biLevel></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Blur &lt;a:blur></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ColorChange &lt;a:clrChange></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ColorReplacement &lt;a:clrRepl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Duotone &lt;a:duotone></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.FillOverlay &lt;a:fillOverlay></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Grayscale &lt;a:grayscl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Hsl &lt;a:hsl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.LuminanceEffect &lt;a:lum></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.TintEffect &lt;a:tint></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaBiLevel))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaCeiling))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaFloor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaInverse))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulationEffect))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaReplace))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BiLevel))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Blur))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ColorChange))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ColorReplacement))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Duotone))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FillOverlay))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Grayscale))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Hsl))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LuminanceEffect))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.TintEffect))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Snapshot : OpenXmlCompositeElement
{
    private const string tagName = "snapshot";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 66;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13319;
    
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
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "embed","link","cstate" };
    private static byte[] attributeNamespaceIds = { 19,19,0 };
    
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
    /// <para> Embedded Picture Reference.</para>
    /// <para>Represents the following attribute in the schema: r:embed </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "embed")]
    public StringValue Embed
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Linked Picture Reference.</para>
    /// <para>Represents the following attribute in the schema: r:link </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "link")]
    public StringValue Link
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> cstate.</para>
    /// <para>Represents the following attribute in the schema: cstate </para>
    /// </summary>
    [SchemaAttr(0, "cstate")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues> CompressionState
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Snapshot class.
    /// </summary>
    public Snapshot():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Snapshot class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Snapshot(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Snapshot class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Snapshot(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Snapshot class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Snapshot(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "alphaBiLevel" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaBiLevel();
    
if( 10 == namespaceId && "alphaCeiling" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaCeiling();
    
if( 10 == namespaceId && "alphaFloor" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaFloor();
    
if( 10 == namespaceId && "alphaInv" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaInverse();
    
if( 10 == namespaceId && "alphaMod" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaModulationEffect();
    
if( 10 == namespaceId && "alphaModFix" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaModulationFixed();
    
if( 10 == namespaceId && "alphaRepl" == name)
    return new DocumentFormat.OpenXml.Drawing.AlphaReplace();
    
if( 10 == namespaceId && "biLevel" == name)
    return new DocumentFormat.OpenXml.Drawing.BiLevel();
    
if( 10 == namespaceId && "blur" == name)
    return new DocumentFormat.OpenXml.Drawing.Blur();
    
if( 10 == namespaceId && "clrChange" == name)
    return new DocumentFormat.OpenXml.Drawing.ColorChange();
    
if( 10 == namespaceId && "clrRepl" == name)
    return new DocumentFormat.OpenXml.Drawing.ColorReplacement();
    
if( 10 == namespaceId && "duotone" == name)
    return new DocumentFormat.OpenXml.Drawing.Duotone();
    
if( 10 == namespaceId && "fillOverlay" == name)
    return new DocumentFormat.OpenXml.Drawing.FillOverlay();
    
if( 10 == namespaceId && "grayscl" == name)
    return new DocumentFormat.OpenXml.Drawing.Grayscale();
    
if( 10 == namespaceId && "hsl" == name)
    return new DocumentFormat.OpenXml.Drawing.Hsl();
    
if( 10 == namespaceId && "lum" == name)
    return new DocumentFormat.OpenXml.Drawing.LuminanceEffect();
    
if( 10 == namespaceId && "tint" == name)
    return new DocumentFormat.OpenXml.Drawing.TintEffect();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.BlipExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 19 == namespaceId && "embed" == name)
    return new StringValue();
    
if( 19 == namespaceId && "link" == name)
    return new StringValue();
    
if( 0 == namespaceId && "cstate" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Snapshot>(deep);
    }

   
}
}
 
 
