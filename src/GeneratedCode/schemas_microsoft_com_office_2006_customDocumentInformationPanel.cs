// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel
{
/// <summary>
/// <para>Defines the CustomPropertyEditors Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:customPropertyEditors.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShowOnOpen &lt;cdip:showOnOpen></description></item>
///<item><description>DefaultPropertyEditorNamespace &lt;cdip:defaultPropertyEditorNamespace></description></item>
///<item><description>CustomPropertyEditor &lt;cdip:customPropertyEditor></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ShowOnOpen))]
    [ChildElementInfo(typeof(DefaultPropertyEditorNamespace))]
    [ChildElementInfo(typeof(CustomPropertyEditor))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CustomPropertyEditors : OpenXmlCompositeElement
{
    private const string tagName = "customPropertyEditors";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 37;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12699;
    
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
    /// Initializes a new instance of the CustomPropertyEditors class.
    /// </summary>
    public CustomPropertyEditors():base(){}
    
            /// <summary>
    ///Initializes a new instance of the CustomPropertyEditors class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomPropertyEditors(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomPropertyEditors class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomPropertyEditors(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomPropertyEditors class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CustomPropertyEditors(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 37 == namespaceId && "showOnOpen" == name)
    return new ShowOnOpen();
    
if( 37 == namespaceId && "defaultPropertyEditorNamespace" == name)
    return new DefaultPropertyEditorNamespace();
    
if( 37 == namespaceId && "customPropertyEditor" == name)
    return new CustomPropertyEditor();
    

    return null;
}

        private static readonly string[] eleTagNames = { "showOnOpen","defaultPropertyEditorNamespace","customPropertyEditor" };
    private static readonly byte[] eleNamespaceIds = { 37,37,37 };
    
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
    /// <para> ShowOnOpen.</para>
    /// <para> Represents the following element tag in the schema: cdip:showOnOpen </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
    /// </remark>
    public ShowOnOpen ShowOnOpen
    {
        get 
        {
            return GetElement<ShowOnOpen>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> DefaultPropertyEditorNamespace.</para>
    /// <para> Represents the following element tag in the schema: cdip:defaultPropertyEditorNamespace </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
    /// </remark>
    public DefaultPropertyEditorNamespace DefaultPropertyEditorNamespace
    {
        get 
        {
            return GetElement<DefaultPropertyEditorNamespace>(1);
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
        return CloneImp<CustomPropertyEditors>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PropertyEditorNamespace Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:XMLNamespace.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PropertyEditorNamespace : OpenXmlLeafTextElement
{
    private const string tagName = "XMLNamespace";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 37;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12700;
    
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
    /// Initializes a new instance of the PropertyEditorNamespace class.
    /// </summary>
    public PropertyEditorNamespace():base(){}
    
           /// <summary>
    /// Initializes a new instance of the PropertyEditorNamespace class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PropertyEditorNamespace(string text):base(text)
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
        return CloneImp<PropertyEditorNamespace>(deep);
    }

}
/// <summary>
/// <para>Defines the DefaultPropertyEditorNamespace Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:defaultPropertyEditorNamespace.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DefaultPropertyEditorNamespace : OpenXmlLeafTextElement
{
    private const string tagName = "defaultPropertyEditorNamespace";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 37;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12703;
    
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
    /// Initializes a new instance of the DefaultPropertyEditorNamespace class.
    /// </summary>
    public DefaultPropertyEditorNamespace():base(){}
    
           /// <summary>
    /// Initializes a new instance of the DefaultPropertyEditorNamespace class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DefaultPropertyEditorNamespace(string text):base(text)
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
        return CloneImp<DefaultPropertyEditorNamespace>(deep);
    }

}
/// <summary>
/// <para>Defines the XsnFileLocation Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:XSNLocation.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class XsnFileLocation : OpenXmlLeafTextElement
{
    private const string tagName = "XSNLocation";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 37;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12701;
    
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
    /// Initializes a new instance of the XsnFileLocation class.
    /// </summary>
    public XsnFileLocation():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the XsnFileLocation class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public XsnFileLocation(string text):base(text)
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
        return CloneImp<XsnFileLocation>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ShowOnOpen Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:showOnOpen.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ShowOnOpen : OpenXmlLeafTextElement
{
    private const string tagName = "showOnOpen";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 37;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12702;
    
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
    /// Initializes a new instance of the ShowOnOpen class.
    /// </summary>
    public ShowOnOpen():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the ShowOnOpen class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ShowOnOpen(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new BooleanValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ShowOnOpen>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CustomPropertyEditor Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cdip:customPropertyEditor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PropertyEditorNamespace &lt;cdip:XMLNamespace></description></item>
///<item><description>XsnFileLocation &lt;cdip:XSNLocation></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PropertyEditorNamespace))]
    [ChildElementInfo(typeof(XsnFileLocation))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CustomPropertyEditor : OpenXmlCompositeElement
{
    private const string tagName = "customPropertyEditor";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 37;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12704;
    
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
    /// Initializes a new instance of the CustomPropertyEditor class.
    /// </summary>
    public CustomPropertyEditor():base(){}
    
            /// <summary>
    ///Initializes a new instance of the CustomPropertyEditor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomPropertyEditor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomPropertyEditor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomPropertyEditor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomPropertyEditor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CustomPropertyEditor(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 37 == namespaceId && "XMLNamespace" == name)
    return new PropertyEditorNamespace();
    
if( 37 == namespaceId && "XSNLocation" == name)
    return new XsnFileLocation();
    

    return null;
}

        private static readonly string[] eleTagNames = { "XMLNamespace","XSNLocation" };
    private static readonly byte[] eleNamespaceIds = { 37,37 };
    
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
    /// <para> PropertyEditorNamespace.</para>
    /// <para> Represents the following element tag in the schema: cdip:XMLNamespace </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
    /// </remark>
    public PropertyEditorNamespace PropertyEditorNamespace
    {
        get 
        {
            return GetElement<PropertyEditorNamespace>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> XsnFileLocation.</para>
    /// <para> Represents the following element tag in the schema: cdip:XSNLocation </para>
    /// </summary>
    /// <remark>
    /// xmlns:cdip = http://schemas.microsoft.com/office/2006/customDocumentInformationPanel
    /// </remark>
    public XsnFileLocation XsnFileLocation
    {
        get 
        {
            return GetElement<XsnFileLocation>(1);
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
        return CloneImp<CustomPropertyEditor>(deep);
    }

   
}
}
 
 
