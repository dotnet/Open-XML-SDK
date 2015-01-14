// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.CoverPageProps
{
/// <summary>
/// <para>Defines the CoverPageProperties Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cppr:CoverPageProperties.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PublishDate &lt;cppr:PublishDate></description></item>
///<item><description>DocumentAbstract &lt;cppr:Abstract></description></item>
///<item><description>CompanyAddress &lt;cppr:CompanyAddress></description></item>
///<item><description>CompanyPhoneNumber &lt;cppr:CompanyPhone></description></item>
///<item><description>CompanyFaxNumber &lt;cppr:CompanyFax></description></item>
///<item><description>CompanyEmailAddress &lt;cppr:CompanyEmail></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PublishDate))]
    [ChildElementInfo(typeof(DocumentAbstract))]
    [ChildElementInfo(typeof(CompanyAddress))]
    [ChildElementInfo(typeof(CompanyPhoneNumber))]
    [ChildElementInfo(typeof(CompanyFaxNumber))]
    [ChildElementInfo(typeof(CompanyEmailAddress))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CoverPageProperties : OpenXmlCompositeElement
{
    private const string tagName = "CoverPageProperties";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 36;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12692;
    
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
    /// Initializes a new instance of the CoverPageProperties class.
    /// </summary>
    public CoverPageProperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the CoverPageProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CoverPageProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CoverPageProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CoverPageProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CoverPageProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CoverPageProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 36 == namespaceId && "PublishDate" == name)
    return new PublishDate();
    
if( 36 == namespaceId && "Abstract" == name)
    return new DocumentAbstract();
    
if( 36 == namespaceId && "CompanyAddress" == name)
    return new CompanyAddress();
    
if( 36 == namespaceId && "CompanyPhone" == name)
    return new CompanyPhoneNumber();
    
if( 36 == namespaceId && "CompanyFax" == name)
    return new CompanyFaxNumber();
    
if( 36 == namespaceId && "CompanyEmail" == name)
    return new CompanyEmailAddress();
    

    return null;
}

        private static readonly string[] eleTagNames = { "PublishDate","Abstract","CompanyAddress","CompanyPhone","CompanyFax","CompanyEmail" };
    private static readonly byte[] eleNamespaceIds = { 36,36,36,36,36,36 };
    
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
    /// <para> PublishDate.</para>
    /// <para> Represents the following element tag in the schema: cppr:PublishDate </para>
    /// </summary>
    /// <remark>
    /// xmlns:cppr = http://schemas.microsoft.com/office/2006/coverPageProps
    /// </remark>
    public PublishDate PublishDate
    {
        get 
        {
            return GetElement<PublishDate>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> DocumentAbstract.</para>
    /// <para> Represents the following element tag in the schema: cppr:Abstract </para>
    /// </summary>
    /// <remark>
    /// xmlns:cppr = http://schemas.microsoft.com/office/2006/coverPageProps
    /// </remark>
    public DocumentAbstract DocumentAbstract
    {
        get 
        {
            return GetElement<DocumentAbstract>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> CompanyAddress.</para>
    /// <para> Represents the following element tag in the schema: cppr:CompanyAddress </para>
    /// </summary>
    /// <remark>
    /// xmlns:cppr = http://schemas.microsoft.com/office/2006/coverPageProps
    /// </remark>
    public CompanyAddress CompanyAddress
    {
        get 
        {
            return GetElement<CompanyAddress>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> CompanyPhoneNumber.</para>
    /// <para> Represents the following element tag in the schema: cppr:CompanyPhone </para>
    /// </summary>
    /// <remark>
    /// xmlns:cppr = http://schemas.microsoft.com/office/2006/coverPageProps
    /// </remark>
    public CompanyPhoneNumber CompanyPhoneNumber
    {
        get 
        {
            return GetElement<CompanyPhoneNumber>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> CompanyFaxNumber.</para>
    /// <para> Represents the following element tag in the schema: cppr:CompanyFax </para>
    /// </summary>
    /// <remark>
    /// xmlns:cppr = http://schemas.microsoft.com/office/2006/coverPageProps
    /// </remark>
    public CompanyFaxNumber CompanyFaxNumber
    {
        get 
        {
            return GetElement<CompanyFaxNumber>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> CompanyEmailAddress.</para>
    /// <para> Represents the following element tag in the schema: cppr:CompanyEmail </para>
    /// </summary>
    /// <remark>
    /// xmlns:cppr = http://schemas.microsoft.com/office/2006/coverPageProps
    /// </remark>
    public CompanyEmailAddress CompanyEmailAddress
    {
        get 
        {
            return GetElement<CompanyEmailAddress>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CoverPageProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PublishDate Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cppr:PublishDate.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PublishDate : OpenXmlLeafTextElement
{
    private const string tagName = "PublishDate";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 36;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12693;
    
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
    /// Initializes a new instance of the PublishDate class.
    /// </summary>
    public PublishDate():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the PublishDate class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PublishDate(string text):base(text)
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
        return CloneImp<PublishDate>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DocumentAbstract Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cppr:Abstract.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DocumentAbstract : OpenXmlLeafTextElement
{
    private const string tagName = "Abstract";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 36;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12694;
    
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
    /// Initializes a new instance of the DocumentAbstract class.
    /// </summary>
    public DocumentAbstract():base(){}
    
           /// <summary>
    /// Initializes a new instance of the DocumentAbstract class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DocumentAbstract(string text):base(text)
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
        return CloneImp<DocumentAbstract>(deep);
    }

}
/// <summary>
/// <para>Defines the CompanyAddress Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cppr:CompanyAddress.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CompanyAddress : OpenXmlLeafTextElement
{
    private const string tagName = "CompanyAddress";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 36;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12695;
    
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
    /// Initializes a new instance of the CompanyAddress class.
    /// </summary>
    public CompanyAddress():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CompanyAddress class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CompanyAddress(string text):base(text)
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
        return CloneImp<CompanyAddress>(deep);
    }

}
/// <summary>
/// <para>Defines the CompanyPhoneNumber Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cppr:CompanyPhone.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CompanyPhoneNumber : OpenXmlLeafTextElement
{
    private const string tagName = "CompanyPhone";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 36;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12696;
    
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
    /// Initializes a new instance of the CompanyPhoneNumber class.
    /// </summary>
    public CompanyPhoneNumber():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CompanyPhoneNumber class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CompanyPhoneNumber(string text):base(text)
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
        return CloneImp<CompanyPhoneNumber>(deep);
    }

}
/// <summary>
/// <para>Defines the CompanyFaxNumber Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cppr:CompanyFax.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CompanyFaxNumber : OpenXmlLeafTextElement
{
    private const string tagName = "CompanyFax";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 36;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12697;
    
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
    /// Initializes a new instance of the CompanyFaxNumber class.
    /// </summary>
    public CompanyFaxNumber():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CompanyFaxNumber class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CompanyFaxNumber(string text):base(text)
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
        return CloneImp<CompanyFaxNumber>(deep);
    }

}
/// <summary>
/// <para>Defines the CompanyEmailAddress Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is cppr:CompanyEmail.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CompanyEmailAddress : OpenXmlLeafTextElement
{
    private const string tagName = "CompanyEmail";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 36;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12698;
    
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
    /// Initializes a new instance of the CompanyEmailAddress class.
    /// </summary>
    public CompanyEmailAddress():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CompanyEmailAddress class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CompanyEmailAddress(string text):base(text)
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
        return CloneImp<CompanyEmailAddress>(deep);
    }

}
}
 
 
