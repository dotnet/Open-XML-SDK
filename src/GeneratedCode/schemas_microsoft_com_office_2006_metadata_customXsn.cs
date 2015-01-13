// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.CustomXsn
{
/// <summary>
/// <para>Defines the CustomXsn Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ntns:customXsn.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>XsnLocation &lt;ntns:xsnLocation></description></item>
///<item><description>CachedView &lt;ntns:cached></description></item>
///<item><description>OpenByDefault &lt;ntns:openByDefault></description></item>
///<item><description>Scope &lt;ntns:xsnScope></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(XsnLocation))]
    [ChildElementInfo(typeof(CachedView))]
    [ChildElementInfo(typeof(OpenByDefault))]
    [ChildElementInfo(typeof(Scope))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CustomXsn : OpenXmlCompositeElement
{
    private const string tagName = "customXsn";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 39;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12706;
    
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
    /// Initializes a new instance of the CustomXsn class.
    /// </summary>
    public CustomXsn():base(){}
    
            /// <summary>
    ///Initializes a new instance of the CustomXsn class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomXsn(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomXsn class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomXsn(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomXsn class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CustomXsn(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 39 == namespaceId && "xsnLocation" == name)
    return new XsnLocation();
    
if( 39 == namespaceId && "cached" == name)
    return new CachedView();
    
if( 39 == namespaceId && "openByDefault" == name)
    return new OpenByDefault();
    
if( 39 == namespaceId && "xsnScope" == name)
    return new Scope();
    

    return null;
}

        private static readonly string[] eleTagNames = { "xsnLocation","cached","openByDefault","xsnScope" };
    private static readonly byte[] eleNamespaceIds = { 39,39,39,39 };
    
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
    /// <para> XsnLocation.</para>
    /// <para> Represents the following element tag in the schema: ntns:xsnLocation </para>
    /// </summary>
    /// <remark>
    /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
    /// </remark>
    public XsnLocation XsnLocation
    {
        get 
        {
            return GetElement<XsnLocation>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> CachedView.</para>
    /// <para> Represents the following element tag in the schema: ntns:cached </para>
    /// </summary>
    /// <remark>
    /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
    /// </remark>
    public CachedView CachedView
    {
        get 
        {
            return GetElement<CachedView>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> OpenByDefault.</para>
    /// <para> Represents the following element tag in the schema: ntns:openByDefault </para>
    /// </summary>
    /// <remark>
    /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
    /// </remark>
    public OpenByDefault OpenByDefault
    {
        get 
        {
            return GetElement<OpenByDefault>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Scope.</para>
    /// <para> Represents the following element tag in the schema: ntns:xsnScope </para>
    /// </summary>
    /// <remark>
    /// xmlns:ntns = http://schemas.microsoft.com/office/2006/metadata/customXsn
    /// </remark>
    public Scope Scope
    {
        get 
        {
            return GetElement<Scope>(3);
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
        return CloneImp<CustomXsn>(deep);
    }

   
}
/// <summary>
/// <para>Defines the XsnLocation Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ntns:xsnLocation.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class XsnLocation : OpenXmlLeafTextElement
{
    private const string tagName = "xsnLocation";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 39;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12707;
    
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
    /// Initializes a new instance of the XsnLocation class.
    /// </summary>
    public XsnLocation():base(){}
    
           /// <summary>
    /// Initializes a new instance of the XsnLocation class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public XsnLocation(string text):base(text)
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
        return CloneImp<XsnLocation>(deep);
    }

}
/// <summary>
/// <para>Defines the CachedView Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ntns:cached.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CachedView : OpenXmlLeafTextElement
{
    private const string tagName = "cached";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 39;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12708;
    
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
    /// Initializes a new instance of the CachedView class.
    /// </summary>
    public CachedView():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CachedView class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CachedView(string text):base(text)
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
        return CloneImp<CachedView>(deep);
    }

}
/// <summary>
/// <para>Defines the OpenByDefault Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ntns:openByDefault.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class OpenByDefault : OpenXmlLeafTextElement
{
    private const string tagName = "openByDefault";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 39;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12709;
    
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
    /// Initializes a new instance of the OpenByDefault class.
    /// </summary>
    public OpenByDefault():base(){}
    
           /// <summary>
    /// Initializes a new instance of the OpenByDefault class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public OpenByDefault(string text):base(text)
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
        return CloneImp<OpenByDefault>(deep);
    }

}
/// <summary>
/// <para>Defines the Scope Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is ntns:xsnScope.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Scope : OpenXmlLeafTextElement
{
    private const string tagName = "xsnScope";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 39;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12710;
    
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
    /// Initializes a new instance of the Scope class.
    /// </summary>
    public Scope():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Scope class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Scope(string text):base(text)
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
        return CloneImp<Scope>(deep);
    }

}
}
 
 
