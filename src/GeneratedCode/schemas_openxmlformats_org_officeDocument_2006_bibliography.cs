// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Bibliography
{
/// <summary>
/// <para>Sources.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Sources.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Source &lt;b:Source></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Source))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Sources : OpenXmlPartRootElement
{
    private const string tagName = "Sources";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10824;
    
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
    

    private static string[] attributeTagNames = { "SelectedStyle","StyleName","URI" };
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
    /// <para> Selected Style.</para>
    /// <para>Represents the following attribute in the schema: SelectedStyle </para>
    /// </summary>
    [SchemaAttr(0, "SelectedStyle")]
    public StringValue SelectedStyle
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Documentation Style Name.</para>
    /// <para>Represents the following attribute in the schema: StyleName </para>
    /// </summary>
    [SchemaAttr(0, "StyleName")]
    public StringValue StyleName
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Uniform Resource Identifier.</para>
    /// <para>Represents the following attribute in the schema: URI </para>
    /// </summary>
    [SchemaAttr(0, "URI")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Sources class.
    /// </summary>
    public Sources():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Sources class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Sources(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Sources class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Sources(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Sources class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Sources(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 9 == namespaceId && "Source" == name)
    return new Source();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "SelectedStyle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "StyleName" == name)
    return new StringValue();
    
if( 0 == namespaceId && "URI" == name)
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
        return CloneImp<Sources>(deep);
    }

   
}
/// <summary>
/// <para>Person.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Person.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Last &lt;b:Last></description></item>
///<item><description>First &lt;b:First></description></item>
///<item><description>Middle &lt;b:Middle></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Last))]
    [ChildElementInfo(typeof(First))]
    [ChildElementInfo(typeof(Middle))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Person : OpenXmlCompositeElement
{
    private const string tagName = "Person";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10825;
    
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
    /// Initializes a new instance of the Person class.
    /// </summary>
    public Person():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Person class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Person(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Person class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Person(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Person class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Person(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 9 == namespaceId && "Last" == name)
    return new Last();
    
if( 9 == namespaceId && "First" == name)
    return new First();
    
if( 9 == namespaceId && "Middle" == name)
    return new Middle();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Person>(deep);
    }

   
}
/// <summary>
/// <para>Person's Last, or Family, Name.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Last.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Last : OpenXmlLeafTextElement
{
    private const string tagName = "Last";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10826;
    
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
    /// Initializes a new instance of the Last class.
    /// </summary>
    public Last():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Last class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Last(string text):base(text)
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
        return CloneImp<Last>(deep);
    }

}
/// <summary>
/// <para>Person's First, or Given, Name.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:First.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class First : OpenXmlLeafTextElement
{
    private const string tagName = "First";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10827;
    
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
    /// Initializes a new instance of the First class.
    /// </summary>
    public First():base(){}
    
           /// <summary>
    /// Initializes a new instance of the First class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public First(string text):base(text)
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
        return CloneImp<First>(deep);
    }

}
/// <summary>
/// <para>Person's Middle, or Other, Name.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Middle.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Middle : OpenXmlLeafTextElement
{
    private const string tagName = "Middle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10828;
    
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
    /// Initializes a new instance of the Middle class.
    /// </summary>
    public Middle():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Middle class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Middle(string text):base(text)
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
        return CloneImp<Middle>(deep);
    }

}
/// <summary>
/// <para>Corporate Author.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Corporate.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Corporate : OpenXmlLeafTextElement
{
    private const string tagName = "Corporate";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10830;
    
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
    /// Initializes a new instance of the Corporate class.
    /// </summary>
    public Corporate():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Corporate class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Corporate(string text):base(text)
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
        return CloneImp<Corporate>(deep);
    }

}
/// <summary>
/// <para>Abbreviated Case Number.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:AbbreviatedCaseNumber.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AbbreviatedCaseNumber : OpenXmlLeafTextElement
{
    private const string tagName = "AbbreviatedCaseNumber";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10847;
    
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
    /// Initializes a new instance of the AbbreviatedCaseNumber class.
    /// </summary>
    public AbbreviatedCaseNumber():base(){}
    
           /// <summary>
    /// Initializes a new instance of the AbbreviatedCaseNumber class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public AbbreviatedCaseNumber(string text):base(text)
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
        return CloneImp<AbbreviatedCaseNumber>(deep);
    }

}
/// <summary>
/// <para>Album Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:AlbumTitle.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AlbumTitle : OpenXmlLeafTextElement
{
    private const string tagName = "AlbumTitle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10848;
    
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
    /// Initializes a new instance of the AlbumTitle class.
    /// </summary>
    public AlbumTitle():base(){}
    
           /// <summary>
    /// Initializes a new instance of the AlbumTitle class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public AlbumTitle(string text):base(text)
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
        return CloneImp<AlbumTitle>(deep);
    }

}
/// <summary>
/// <para>Book Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:BookTitle.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BookTitle : OpenXmlLeafTextElement
{
    private const string tagName = "BookTitle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10850;
    
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
    /// Initializes a new instance of the BookTitle class.
    /// </summary>
    public BookTitle():base(){}
    
           /// <summary>
    /// Initializes a new instance of the BookTitle class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public BookTitle(string text):base(text)
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
        return CloneImp<BookTitle>(deep);
    }

}
/// <summary>
/// <para>Broadcaster.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Broadcaster.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Broadcaster : OpenXmlLeafTextElement
{
    private const string tagName = "Broadcaster";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10851;
    
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
    /// Initializes a new instance of the Broadcaster class.
    /// </summary>
    public Broadcaster():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Broadcaster class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Broadcaster(string text):base(text)
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
        return CloneImp<Broadcaster>(deep);
    }

}
/// <summary>
/// <para>Broadcast Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:BroadcastTitle.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BroadcastTitle : OpenXmlLeafTextElement
{
    private const string tagName = "BroadcastTitle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10852;
    
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
    /// Initializes a new instance of the BroadcastTitle class.
    /// </summary>
    public BroadcastTitle():base(){}
    
           /// <summary>
    /// Initializes a new instance of the BroadcastTitle class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public BroadcastTitle(string text):base(text)
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
        return CloneImp<BroadcastTitle>(deep);
    }

}
/// <summary>
/// <para>Case Number.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:CaseNumber.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CaseNumber : OpenXmlLeafTextElement
{
    private const string tagName = "CaseNumber";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10853;
    
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
    /// Initializes a new instance of the CaseNumber class.
    /// </summary>
    public CaseNumber():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CaseNumber class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CaseNumber(string text):base(text)
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
        return CloneImp<CaseNumber>(deep);
    }

}
/// <summary>
/// <para>Chapter Number.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:ChapterNumber.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ChapterNumber : OpenXmlLeafTextElement
{
    private const string tagName = "ChapterNumber";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10854;
    
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
    /// Initializes a new instance of the ChapterNumber class.
    /// </summary>
    public ChapterNumber():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ChapterNumber class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ChapterNumber(string text):base(text)
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
        return CloneImp<ChapterNumber>(deep);
    }

}
/// <summary>
/// <para>City.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:City.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class City : OpenXmlLeafTextElement
{
    private const string tagName = "City";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10855;
    
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
    /// Initializes a new instance of the City class.
    /// </summary>
    public City():base(){}
    
           /// <summary>
    /// Initializes a new instance of the City class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public City(string text):base(text)
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
        return CloneImp<City>(deep);
    }

}
/// <summary>
/// <para>Comments.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Comments.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Comments : OpenXmlLeafTextElement
{
    private const string tagName = "Comments";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10856;
    
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
    /// Initializes a new instance of the Comments class.
    /// </summary>
    public Comments():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Comments class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Comments(string text):base(text)
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
        return CloneImp<Comments>(deep);
    }

}
/// <summary>
/// <para>Conference or Proceedings Name.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:ConferenceName.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ConferenceName : OpenXmlLeafTextElement
{
    private const string tagName = "ConferenceName";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10857;
    
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
    /// Initializes a new instance of the ConferenceName class.
    /// </summary>
    public ConferenceName():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ConferenceName class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ConferenceName(string text):base(text)
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
        return CloneImp<ConferenceName>(deep);
    }

}
/// <summary>
/// <para>Country or Region.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:CountryRegion.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CountryRegion : OpenXmlLeafTextElement
{
    private const string tagName = "CountryRegion";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10858;
    
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
    /// Initializes a new instance of the CountryRegion class.
    /// </summary>
    public CountryRegion():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CountryRegion class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CountryRegion(string text):base(text)
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
        return CloneImp<CountryRegion>(deep);
    }

}
/// <summary>
/// <para>Court.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Court.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Court : OpenXmlLeafTextElement
{
    private const string tagName = "Court";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10859;
    
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
    /// Initializes a new instance of the Court class.
    /// </summary>
    public Court():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Court class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Court(string text):base(text)
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
        return CloneImp<Court>(deep);
    }

}
/// <summary>
/// <para>Day.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Day.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Day : OpenXmlLeafTextElement
{
    private const string tagName = "Day";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10860;
    
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
    /// Initializes a new instance of the Day class.
    /// </summary>
    public Day():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Day class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Day(string text):base(text)
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
        return CloneImp<Day>(deep);
    }

}
/// <summary>
/// <para>Day Accessed.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:DayAccessed.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DayAccessed : OpenXmlLeafTextElement
{
    private const string tagName = "DayAccessed";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10861;
    
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
    /// Initializes a new instance of the DayAccessed class.
    /// </summary>
    public DayAccessed():base(){}
    
           /// <summary>
    /// Initializes a new instance of the DayAccessed class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DayAccessed(string text):base(text)
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
        return CloneImp<DayAccessed>(deep);
    }

}
/// <summary>
/// <para>Department.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Department.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Department : OpenXmlLeafTextElement
{
    private const string tagName = "Department";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10862;
    
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
    /// Initializes a new instance of the Department class.
    /// </summary>
    public Department():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Department class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Department(string text):base(text)
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
        return CloneImp<Department>(deep);
    }

}
/// <summary>
/// <para>Distributor.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Distributor.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Distributor : OpenXmlLeafTextElement
{
    private const string tagName = "Distributor";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10863;
    
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
    /// Initializes a new instance of the Distributor class.
    /// </summary>
    public Distributor():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Distributor class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Distributor(string text):base(text)
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
        return CloneImp<Distributor>(deep);
    }

}
/// <summary>
/// <para>Editor.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Edition.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Edition : OpenXmlLeafTextElement
{
    private const string tagName = "Edition";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10864;
    
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
    /// Initializes a new instance of the Edition class.
    /// </summary>
    public Edition():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Edition class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Edition(string text):base(text)
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
        return CloneImp<Edition>(deep);
    }

}
/// <summary>
/// <para>GUID.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Guid.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class GuidString : OpenXmlLeafTextElement
{
    private const string tagName = "Guid";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10865;
    
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
    /// Initializes a new instance of the GuidString class.
    /// </summary>
    public GuidString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the GuidString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public GuidString(string text):base(text)
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
        return CloneImp<GuidString>(deep);
    }

}
/// <summary>
/// <para>Institution.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Institution.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Institution : OpenXmlLeafTextElement
{
    private const string tagName = "Institution";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10866;
    
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
    /// Initializes a new instance of the Institution class.
    /// </summary>
    public Institution():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Institution class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Institution(string text):base(text)
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
        return CloneImp<Institution>(deep);
    }

}
/// <summary>
/// <para>Internet Site Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:InternetSiteTitle.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class InternetSiteTitle : OpenXmlLeafTextElement
{
    private const string tagName = "InternetSiteTitle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10867;
    
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
    /// Initializes a new instance of the InternetSiteTitle class.
    /// </summary>
    public InternetSiteTitle():base(){}
    
           /// <summary>
    /// Initializes a new instance of the InternetSiteTitle class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public InternetSiteTitle(string text):base(text)
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
        return CloneImp<InternetSiteTitle>(deep);
    }

}
/// <summary>
/// <para>Issue.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Issue.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Issue : OpenXmlLeafTextElement
{
    private const string tagName = "Issue";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10868;
    
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
    /// Initializes a new instance of the Issue class.
    /// </summary>
    public Issue():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Issue class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Issue(string text):base(text)
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
        return CloneImp<Issue>(deep);
    }

}
/// <summary>
/// <para>Journal Name.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:JournalName.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class JournalName : OpenXmlLeafTextElement
{
    private const string tagName = "JournalName";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10869;
    
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
    /// Initializes a new instance of the JournalName class.
    /// </summary>
    public JournalName():base(){}
    
           /// <summary>
    /// Initializes a new instance of the JournalName class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public JournalName(string text):base(text)
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
        return CloneImp<JournalName>(deep);
    }

}
/// <summary>
/// <para>Locale ID.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:LCID.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LcId : OpenXmlLeafTextElement
{
    private const string tagName = "LCID";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10870;
    
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
    /// Initializes a new instance of the LcId class.
    /// </summary>
    public LcId():base(){}
    
           /// <summary>
    /// Initializes a new instance of the LcId class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public LcId(string text):base(text)
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
        return CloneImp<LcId>(deep);
    }

}
/// <summary>
/// <para>Medium.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Medium.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Medium : OpenXmlLeafTextElement
{
    private const string tagName = "Medium";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10871;
    
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
    /// Initializes a new instance of the Medium class.
    /// </summary>
    public Medium():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Medium class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Medium(string text):base(text)
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
        return CloneImp<Medium>(deep);
    }

}
/// <summary>
/// <para>Month.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Month.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Month : OpenXmlLeafTextElement
{
    private const string tagName = "Month";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10872;
    
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
    /// Initializes a new instance of the Month class.
    /// </summary>
    public Month():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Month class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Month(string text):base(text)
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
        return CloneImp<Month>(deep);
    }

}
/// <summary>
/// <para>Month Accessed.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:MonthAccessed.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MonthAccessed : OpenXmlLeafTextElement
{
    private const string tagName = "MonthAccessed";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10873;
    
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
    /// Initializes a new instance of the MonthAccessed class.
    /// </summary>
    public MonthAccessed():base(){}
    
           /// <summary>
    /// Initializes a new instance of the MonthAccessed class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public MonthAccessed(string text):base(text)
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
        return CloneImp<MonthAccessed>(deep);
    }

}
/// <summary>
/// <para>Number of Volumes.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:NumberVolumes.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class NumberVolumes : OpenXmlLeafTextElement
{
    private const string tagName = "NumberVolumes";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10874;
    
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
    /// Initializes a new instance of the NumberVolumes class.
    /// </summary>
    public NumberVolumes():base(){}
    
           /// <summary>
    /// Initializes a new instance of the NumberVolumes class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public NumberVolumes(string text):base(text)
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
        return CloneImp<NumberVolumes>(deep);
    }

}
/// <summary>
/// <para>Pages.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Pages.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Pages : OpenXmlLeafTextElement
{
    private const string tagName = "Pages";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10875;
    
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
    /// Initializes a new instance of the Pages class.
    /// </summary>
    public Pages():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Pages class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Pages(string text):base(text)
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
        return CloneImp<Pages>(deep);
    }

}
/// <summary>
/// <para>Patent Number.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:PatentNumber.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PatentNumber : OpenXmlLeafTextElement
{
    private const string tagName = "PatentNumber";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10876;
    
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
    /// Initializes a new instance of the PatentNumber class.
    /// </summary>
    public PatentNumber():base(){}
    
           /// <summary>
    /// Initializes a new instance of the PatentNumber class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PatentNumber(string text):base(text)
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
        return CloneImp<PatentNumber>(deep);
    }

}
/// <summary>
/// <para>Periodical Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:PeriodicalTitle.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PeriodicalTitle : OpenXmlLeafTextElement
{
    private const string tagName = "PeriodicalTitle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10877;
    
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
    /// Initializes a new instance of the PeriodicalTitle class.
    /// </summary>
    public PeriodicalTitle():base(){}
    
           /// <summary>
    /// Initializes a new instance of the PeriodicalTitle class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PeriodicalTitle(string text):base(text)
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
        return CloneImp<PeriodicalTitle>(deep);
    }

}
/// <summary>
/// <para>Production Company.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:ProductionCompany.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ProductionCompany : OpenXmlLeafTextElement
{
    private const string tagName = "ProductionCompany";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10878;
    
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
    /// Initializes a new instance of the ProductionCompany class.
    /// </summary>
    public ProductionCompany():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ProductionCompany class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ProductionCompany(string text):base(text)
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
        return CloneImp<ProductionCompany>(deep);
    }

}
/// <summary>
/// <para>Publication Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:PublicationTitle.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PublicationTitle : OpenXmlLeafTextElement
{
    private const string tagName = "PublicationTitle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10879;
    
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
    /// Initializes a new instance of the PublicationTitle class.
    /// </summary>
    public PublicationTitle():base(){}
    
           /// <summary>
    /// Initializes a new instance of the PublicationTitle class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PublicationTitle(string text):base(text)
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
        return CloneImp<PublicationTitle>(deep);
    }

}
/// <summary>
/// <para>Publisher.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Publisher.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Publisher : OpenXmlLeafTextElement
{
    private const string tagName = "Publisher";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10880;
    
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
    /// Initializes a new instance of the Publisher class.
    /// </summary>
    public Publisher():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Publisher class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Publisher(string text):base(text)
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
        return CloneImp<Publisher>(deep);
    }

}
/// <summary>
/// <para>Recording Number.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:RecordingNumber.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RecordingNumber : OpenXmlLeafTextElement
{
    private const string tagName = "RecordingNumber";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10881;
    
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
    /// Initializes a new instance of the RecordingNumber class.
    /// </summary>
    public RecordingNumber():base(){}
    
           /// <summary>
    /// Initializes a new instance of the RecordingNumber class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public RecordingNumber(string text):base(text)
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
        return CloneImp<RecordingNumber>(deep);
    }

}
/// <summary>
/// <para>Reference Order.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:RefOrder.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ReferenceOrder : OpenXmlLeafTextElement
{
    private const string tagName = "RefOrder";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10882;
    
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
    /// Initializes a new instance of the ReferenceOrder class.
    /// </summary>
    public ReferenceOrder():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ReferenceOrder class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ReferenceOrder(string text):base(text)
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
        return CloneImp<ReferenceOrder>(deep);
    }

}
/// <summary>
/// <para>Reporter.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Reporter.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Reporter : OpenXmlLeafTextElement
{
    private const string tagName = "Reporter";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10883;
    
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
    /// Initializes a new instance of the Reporter class.
    /// </summary>
    public Reporter():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Reporter class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Reporter(string text):base(text)
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
        return CloneImp<Reporter>(deep);
    }

}
/// <summary>
/// <para>Short Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:ShortTitle.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ShortTitle : OpenXmlLeafTextElement
{
    private const string tagName = "ShortTitle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10885;
    
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
    /// Initializes a new instance of the ShortTitle class.
    /// </summary>
    public ShortTitle():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ShortTitle class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ShortTitle(string text):base(text)
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
        return CloneImp<ShortTitle>(deep);
    }

}
/// <summary>
/// <para>Standard Number.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:StandardNumber.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StandardNumber : OpenXmlLeafTextElement
{
    private const string tagName = "StandardNumber";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10886;
    
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
    /// Initializes a new instance of the StandardNumber class.
    /// </summary>
    public StandardNumber():base(){}
    
           /// <summary>
    /// Initializes a new instance of the StandardNumber class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public StandardNumber(string text):base(text)
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
        return CloneImp<StandardNumber>(deep);
    }

}
/// <summary>
/// <para>State or Province.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:StateProvince.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StateProvince : OpenXmlLeafTextElement
{
    private const string tagName = "StateProvince";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10887;
    
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
    /// Initializes a new instance of the StateProvince class.
    /// </summary>
    public StateProvince():base(){}
    
           /// <summary>
    /// Initializes a new instance of the StateProvince class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public StateProvince(string text):base(text)
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
        return CloneImp<StateProvince>(deep);
    }

}
/// <summary>
/// <para>Station.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Station.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Station : OpenXmlLeafTextElement
{
    private const string tagName = "Station";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10888;
    
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
    /// Initializes a new instance of the Station class.
    /// </summary>
    public Station():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Station class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Station(string text):base(text)
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
        return CloneImp<Station>(deep);
    }

}
/// <summary>
/// <para>Tag.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Tag.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Tag : OpenXmlLeafTextElement
{
    private const string tagName = "Tag";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10889;
    
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
    /// Initializes a new instance of the Tag class.
    /// </summary>
    public Tag():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Tag class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Tag(string text):base(text)
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
        return CloneImp<Tag>(deep);
    }

}
/// <summary>
/// <para>Theater.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Theater.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Theater : OpenXmlLeafTextElement
{
    private const string tagName = "Theater";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10890;
    
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
    /// Initializes a new instance of the Theater class.
    /// </summary>
    public Theater():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Theater class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Theater(string text):base(text)
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
        return CloneImp<Theater>(deep);
    }

}
/// <summary>
/// <para>Thesis Type.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:ThesisType.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ThesisType : OpenXmlLeafTextElement
{
    private const string tagName = "ThesisType";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10891;
    
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
    /// Initializes a new instance of the ThesisType class.
    /// </summary>
    public ThesisType():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ThesisType class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ThesisType(string text):base(text)
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
        return CloneImp<ThesisType>(deep);
    }

}
/// <summary>
/// <para>Title.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Title.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Title : OpenXmlLeafTextElement
{
    private const string tagName = "Title";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10892;
    
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
    /// Initializes a new instance of the Title class.
    /// </summary>
    public Title():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Title class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Title(string text):base(text)
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
        return CloneImp<Title>(deep);
    }

}
/// <summary>
/// <para>Type.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Type.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PatentType : OpenXmlLeafTextElement
{
    private const string tagName = "Type";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10893;
    
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
    /// Initializes a new instance of the PatentType class.
    /// </summary>
    public PatentType():base(){}
    
           /// <summary>
    /// Initializes a new instance of the PatentType class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PatentType(string text):base(text)
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
        return CloneImp<PatentType>(deep);
    }

}
/// <summary>
/// <para>URL.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:URL.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class UrlString : OpenXmlLeafTextElement
{
    private const string tagName = "URL";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10894;
    
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
    /// Initializes a new instance of the UrlString class.
    /// </summary>
    public UrlString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the UrlString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public UrlString(string text):base(text)
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
        return CloneImp<UrlString>(deep);
    }

}
/// <summary>
/// <para>Version.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Version.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Version : OpenXmlLeafTextElement
{
    private const string tagName = "Version";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10895;
    
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
    /// Initializes a new instance of the Version class.
    /// </summary>
    public Version():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Version class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Version(string text):base(text)
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
        return CloneImp<Version>(deep);
    }

}
/// <summary>
/// <para>Volume.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Volume.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Volume : OpenXmlLeafTextElement
{
    private const string tagName = "Volume";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10896;
    
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
    /// Initializes a new instance of the Volume class.
    /// </summary>
    public Volume():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Volume class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Volume(string text):base(text)
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
        return CloneImp<Volume>(deep);
    }

}
/// <summary>
/// <para>Year.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Year.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Year : OpenXmlLeafTextElement
{
    private const string tagName = "Year";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10897;
    
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
    /// Initializes a new instance of the Year class.
    /// </summary>
    public Year():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Year class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Year(string text):base(text)
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
        return CloneImp<Year>(deep);
    }

}
/// <summary>
/// <para>Year Accessed.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:YearAccessed.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class YearAccessed : OpenXmlLeafTextElement
{
    private const string tagName = "YearAccessed";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10898;
    
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
    /// Initializes a new instance of the YearAccessed class.
    /// </summary>
    public YearAccessed():base(){}
    
           /// <summary>
    /// Initializes a new instance of the YearAccessed class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public YearAccessed(string text):base(text)
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
        return CloneImp<YearAccessed>(deep);
    }

}
/// <summary>
/// <para>Name List.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:NameList.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Person &lt;b:Person></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Person))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class NameList : OpenXmlCompositeElement
{
    private const string tagName = "NameList";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10829;
    
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
    /// Initializes a new instance of the NameList class.
    /// </summary>
    public NameList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the NameList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NameList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NameList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NameList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NameList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NameList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 9 == namespaceId && "Person" == name)
    return new Person();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<NameList>(deep);
    }

   
}
/// <summary>
/// <para>Artist.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Artist.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Artist : NameType
{
    private const string tagName = "Artist";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10831;
    
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
    /// Initializes a new instance of the Artist class.
    /// </summary>
    public Artist():base(){}
            /// <summary>
    ///Initializes a new instance of the Artist class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Artist(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Artist class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Artist(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Artist class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Artist(string outerXml)
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
        return CloneImp<Artist>(deep);
    }

}
/// <summary>
/// <para>Book Author.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:BookAuthor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BookAuthor : NameType
{
    private const string tagName = "BookAuthor";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10833;
    
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
    /// Initializes a new instance of the BookAuthor class.
    /// </summary>
    public BookAuthor():base(){}
            /// <summary>
    ///Initializes a new instance of the BookAuthor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BookAuthor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BookAuthor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BookAuthor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BookAuthor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BookAuthor(string outerXml)
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
        return CloneImp<BookAuthor>(deep);
    }

}
/// <summary>
/// <para>Compiler.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Compiler.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Compiler : NameType
{
    private const string tagName = "Compiler";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10834;
    
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
    /// Initializes a new instance of the Compiler class.
    /// </summary>
    public Compiler():base(){}
            /// <summary>
    ///Initializes a new instance of the Compiler class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Compiler(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Compiler class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Compiler(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Compiler class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Compiler(string outerXml)
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
        return CloneImp<Compiler>(deep);
    }

}
/// <summary>
/// <para>Composer.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Composer.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Composer : NameType
{
    private const string tagName = "Composer";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10835;
    
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
    /// Initializes a new instance of the Composer class.
    /// </summary>
    public Composer():base(){}
            /// <summary>
    ///Initializes a new instance of the Composer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Composer(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Composer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Composer(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Composer class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Composer(string outerXml)
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
        return CloneImp<Composer>(deep);
    }

}
/// <summary>
/// <para>Conductor.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Conductor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Conductor : NameType
{
    private const string tagName = "Conductor";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10836;
    
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
    /// Initializes a new instance of the Conductor class.
    /// </summary>
    public Conductor():base(){}
            /// <summary>
    ///Initializes a new instance of the Conductor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Conductor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Conductor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Conductor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Conductor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Conductor(string outerXml)
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
        return CloneImp<Conductor>(deep);
    }

}
/// <summary>
/// <para>Counsel.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Counsel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Counsel : NameType
{
    private const string tagName = "Counsel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10837;
    
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
    /// Initializes a new instance of the Counsel class.
    /// </summary>
    public Counsel():base(){}
            /// <summary>
    ///Initializes a new instance of the Counsel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Counsel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Counsel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Counsel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Counsel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Counsel(string outerXml)
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
        return CloneImp<Counsel>(deep);
    }

}
/// <summary>
/// <para>Director.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Director.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Director : NameType
{
    private const string tagName = "Director";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10838;
    
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
    /// Initializes a new instance of the Director class.
    /// </summary>
    public Director():base(){}
            /// <summary>
    ///Initializes a new instance of the Director class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Director(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Director class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Director(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Director class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Director(string outerXml)
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
        return CloneImp<Director>(deep);
    }

}
/// <summary>
/// <para>Editor.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Editor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Editor : NameType
{
    private const string tagName = "Editor";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10839;
    
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
    /// Initializes a new instance of the Editor class.
    /// </summary>
    public Editor():base(){}
            /// <summary>
    ///Initializes a new instance of the Editor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Editor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Editor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Editor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Editor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Editor(string outerXml)
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
        return CloneImp<Editor>(deep);
    }

}
/// <summary>
/// <para>Interviewee.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Interviewee.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Interviewee : NameType
{
    private const string tagName = "Interviewee";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10840;
    
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
    /// Initializes a new instance of the Interviewee class.
    /// </summary>
    public Interviewee():base(){}
            /// <summary>
    ///Initializes a new instance of the Interviewee class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Interviewee(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Interviewee class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Interviewee(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Interviewee class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Interviewee(string outerXml)
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
        return CloneImp<Interviewee>(deep);
    }

}
/// <summary>
/// <para>Interviewer.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Interviewer.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Interviewer : NameType
{
    private const string tagName = "Interviewer";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10841;
    
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
    /// Initializes a new instance of the Interviewer class.
    /// </summary>
    public Interviewer():base(){}
            /// <summary>
    ///Initializes a new instance of the Interviewer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Interviewer(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Interviewer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Interviewer(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Interviewer class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Interviewer(string outerXml)
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
        return CloneImp<Interviewer>(deep);
    }

}
/// <summary>
/// <para>Inventor.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Inventor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Inventor : NameType
{
    private const string tagName = "Inventor";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10842;
    
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
    /// Initializes a new instance of the Inventor class.
    /// </summary>
    public Inventor():base(){}
            /// <summary>
    ///Initializes a new instance of the Inventor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Inventor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Inventor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Inventor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Inventor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Inventor(string outerXml)
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
        return CloneImp<Inventor>(deep);
    }

}
/// <summary>
/// <para>Producer Name.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:ProducerName.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ProducerName : NameType
{
    private const string tagName = "ProducerName";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10844;
    
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
    /// Initializes a new instance of the ProducerName class.
    /// </summary>
    public ProducerName():base(){}
            /// <summary>
    ///Initializes a new instance of the ProducerName class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ProducerName(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ProducerName class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ProducerName(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ProducerName class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ProducerName(string outerXml)
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
        return CloneImp<ProducerName>(deep);
    }

}
/// <summary>
/// <para>Translator.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Translator.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Translator : NameType
{
    private const string tagName = "Translator";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10845;
    
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
    /// Initializes a new instance of the Translator class.
    /// </summary>
    public Translator():base(){}
            /// <summary>
    ///Initializes a new instance of the Translator class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Translator(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Translator class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Translator(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Translator class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Translator(string outerXml)
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
        return CloneImp<Translator>(deep);
    }

}
/// <summary>
/// <para>Writer.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Writer.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Writer : NameType
{
    private const string tagName = "Writer";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10846;
    
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
    /// Initializes a new instance of the Writer class.
    /// </summary>
    public Writer():base(){}
            /// <summary>
    ///Initializes a new instance of the Writer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Writer(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Writer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Writer(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Writer class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Writer(string outerXml)
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
        return CloneImp<Writer>(deep);
    }

}
/// <summary>
/// Defines the NameType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(NameList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class NameType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 9 == namespaceId && "NameList" == name)
    return new NameList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "NameList" };
    private static readonly byte[] eleNamespaceIds = { 9 };
    
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
    /// <para> Name List.</para>
    /// <para> Represents the following element tag in the schema: b:NameList </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public NameList NameList
    {
        get 
        {
            return GetElement<NameList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
    
    /// <summary>
    /// Initializes a new instance of the NameType class.
    /// </summary>
    protected NameType(){}
    
            /// <summary>
    ///Initializes a new instance of the NameType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected NameType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NameType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected NameType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NameType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected NameType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Author.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Author.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
///<item><description>Corporate &lt;b:Corporate></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Author : NameOrCorporateType
{
    private const string tagName = "Author";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10832;
    
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
    /// Initializes a new instance of the Author class.
    /// </summary>
    public Author():base(){}
            /// <summary>
    ///Initializes a new instance of the Author class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Author(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Author class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Author(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Author class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Author(string outerXml)
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
        return CloneImp<Author>(deep);
    }

}
/// <summary>
/// <para>Performer.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Performer.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
///<item><description>Corporate &lt;b:Corporate></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Performer : NameOrCorporateType
{
    private const string tagName = "Performer";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10843;
    
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
    /// Initializes a new instance of the Performer class.
    /// </summary>
    public Performer():base(){}
            /// <summary>
    ///Initializes a new instance of the Performer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Performer(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Performer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Performer(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Performer class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Performer(string outerXml)
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
        return CloneImp<Performer>(deep);
    }

}
/// <summary>
/// Defines the NameOrCorporateType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NameList &lt;b:NameList></description></item>
///<item><description>Corporate &lt;b:Corporate></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(NameList))]
    [ChildElementInfo(typeof(Corporate))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class NameOrCorporateType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 9 == namespaceId && "NameList" == name)
    return new NameList();
    
if( 9 == namespaceId && "Corporate" == name)
    return new Corporate();
    

    return null;
}

        private static readonly string[] eleTagNames = { "NameList","Corporate" };
    private static readonly byte[] eleNamespaceIds = { 9,9 };
    
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
    /// <para> NameList.</para>
    /// <para> Represents the following element tag in the schema: b:NameList </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public NameList NameList
    {
        get 
        {
            return GetElement<NameList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Corporate Author.</para>
    /// <para> Represents the following element tag in the schema: b:Corporate </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Corporate Corporate
    {
        get 
        {
            return GetElement<Corporate>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
    
    /// <summary>
    /// Initializes a new instance of the NameOrCorporateType class.
    /// </summary>
    protected NameOrCorporateType(){}
    
            /// <summary>
    ///Initializes a new instance of the NameOrCorporateType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected NameOrCorporateType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NameOrCorporateType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected NameOrCorporateType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NameOrCorporateType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected NameOrCorporateType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Contributors List.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Author.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Artist &lt;b:Artist></description></item>
///<item><description>Author &lt;b:Author></description></item>
///<item><description>BookAuthor &lt;b:BookAuthor></description></item>
///<item><description>Compiler &lt;b:Compiler></description></item>
///<item><description>Composer &lt;b:Composer></description></item>
///<item><description>Conductor &lt;b:Conductor></description></item>
///<item><description>Counsel &lt;b:Counsel></description></item>
///<item><description>Director &lt;b:Director></description></item>
///<item><description>Editor &lt;b:Editor></description></item>
///<item><description>Interviewee &lt;b:Interviewee></description></item>
///<item><description>Interviewer &lt;b:Interviewer></description></item>
///<item><description>Inventor &lt;b:Inventor></description></item>
///<item><description>Performer &lt;b:Performer></description></item>
///<item><description>ProducerName &lt;b:ProducerName></description></item>
///<item><description>Translator &lt;b:Translator></description></item>
///<item><description>Writer &lt;b:Writer></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Artist))]
    [ChildElementInfo(typeof(Author))]
    [ChildElementInfo(typeof(BookAuthor))]
    [ChildElementInfo(typeof(Compiler))]
    [ChildElementInfo(typeof(Composer))]
    [ChildElementInfo(typeof(Conductor))]
    [ChildElementInfo(typeof(Counsel))]
    [ChildElementInfo(typeof(Director))]
    [ChildElementInfo(typeof(Editor))]
    [ChildElementInfo(typeof(Interviewee))]
    [ChildElementInfo(typeof(Interviewer))]
    [ChildElementInfo(typeof(Inventor))]
    [ChildElementInfo(typeof(Performer))]
    [ChildElementInfo(typeof(ProducerName))]
    [ChildElementInfo(typeof(Translator))]
    [ChildElementInfo(typeof(Writer))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AuthorList : OpenXmlCompositeElement
{
    private const string tagName = "Author";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10849;
    
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
    /// Initializes a new instance of the AuthorList class.
    /// </summary>
    public AuthorList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AuthorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AuthorList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AuthorList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AuthorList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AuthorList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AuthorList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 9 == namespaceId && "Artist" == name)
    return new Artist();
    
if( 9 == namespaceId && "Author" == name)
    return new Author();
    
if( 9 == namespaceId && "BookAuthor" == name)
    return new BookAuthor();
    
if( 9 == namespaceId && "Compiler" == name)
    return new Compiler();
    
if( 9 == namespaceId && "Composer" == name)
    return new Composer();
    
if( 9 == namespaceId && "Conductor" == name)
    return new Conductor();
    
if( 9 == namespaceId && "Counsel" == name)
    return new Counsel();
    
if( 9 == namespaceId && "Director" == name)
    return new Director();
    
if( 9 == namespaceId && "Editor" == name)
    return new Editor();
    
if( 9 == namespaceId && "Interviewee" == name)
    return new Interviewee();
    
if( 9 == namespaceId && "Interviewer" == name)
    return new Interviewer();
    
if( 9 == namespaceId && "Inventor" == name)
    return new Inventor();
    
if( 9 == namespaceId && "Performer" == name)
    return new Performer();
    
if( 9 == namespaceId && "ProducerName" == name)
    return new ProducerName();
    
if( 9 == namespaceId && "Translator" == name)
    return new Translator();
    
if( 9 == namespaceId && "Writer" == name)
    return new Writer();
    

    return null;
}

        private static readonly string[] eleTagNames = { "Artist","Author","BookAuthor","Compiler","Composer","Conductor","Counsel","Director","Editor","Interviewee","Interviewer","Inventor","Performer","ProducerName","Translator","Writer" };
    private static readonly byte[] eleNamespaceIds = { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 };
    
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
    /// <para> Artist.</para>
    /// <para> Represents the following element tag in the schema: b:Artist </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Artist Artist
    {
        get 
        {
            return GetElement<Artist>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Author.</para>
    /// <para> Represents the following element tag in the schema: b:Author </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Author Author
    {
        get 
        {
            return GetElement<Author>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Book Author.</para>
    /// <para> Represents the following element tag in the schema: b:BookAuthor </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public BookAuthor BookAuthor
    {
        get 
        {
            return GetElement<BookAuthor>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Compiler.</para>
    /// <para> Represents the following element tag in the schema: b:Compiler </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Compiler Compiler
    {
        get 
        {
            return GetElement<Compiler>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Composer.</para>
    /// <para> Represents the following element tag in the schema: b:Composer </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Composer Composer
    {
        get 
        {
            return GetElement<Composer>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> Conductor.</para>
    /// <para> Represents the following element tag in the schema: b:Conductor </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Conductor Conductor
    {
        get 
        {
            return GetElement<Conductor>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }
    /// <summary>
    /// <para> Counsel.</para>
    /// <para> Represents the following element tag in the schema: b:Counsel </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Counsel Counsel
    {
        get 
        {
            return GetElement<Counsel>(6);
        }
        set
        {
            SetElement(6, value);
        }
    }
    /// <summary>
    /// <para> Director.</para>
    /// <para> Represents the following element tag in the schema: b:Director </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Director Director
    {
        get 
        {
            return GetElement<Director>(7);
        }
        set
        {
            SetElement(7, value);
        }
    }
    /// <summary>
    /// <para> Editor.</para>
    /// <para> Represents the following element tag in the schema: b:Editor </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Editor Editor
    {
        get 
        {
            return GetElement<Editor>(8);
        }
        set
        {
            SetElement(8, value);
        }
    }
    /// <summary>
    /// <para> Interviewee.</para>
    /// <para> Represents the following element tag in the schema: b:Interviewee </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Interviewee Interviewee
    {
        get 
        {
            return GetElement<Interviewee>(9);
        }
        set
        {
            SetElement(9, value);
        }
    }
    /// <summary>
    /// <para> Interviewer.</para>
    /// <para> Represents the following element tag in the schema: b:Interviewer </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Interviewer Interviewer
    {
        get 
        {
            return GetElement<Interviewer>(10);
        }
        set
        {
            SetElement(10, value);
        }
    }
    /// <summary>
    /// <para> Inventor.</para>
    /// <para> Represents the following element tag in the schema: b:Inventor </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Inventor Inventor
    {
        get 
        {
            return GetElement<Inventor>(11);
        }
        set
        {
            SetElement(11, value);
        }
    }
    /// <summary>
    /// <para> Performer.</para>
    /// <para> Represents the following element tag in the schema: b:Performer </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Performer Performer
    {
        get 
        {
            return GetElement<Performer>(12);
        }
        set
        {
            SetElement(12, value);
        }
    }
    /// <summary>
    /// <para> Producer Name.</para>
    /// <para> Represents the following element tag in the schema: b:ProducerName </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public ProducerName ProducerName
    {
        get 
        {
            return GetElement<ProducerName>(13);
        }
        set
        {
            SetElement(13, value);
        }
    }
    /// <summary>
    /// <para> Translator.</para>
    /// <para> Represents the following element tag in the schema: b:Translator </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Translator Translator
    {
        get 
        {
            return GetElement<Translator>(14);
        }
        set
        {
            SetElement(14, value);
        }
    }
    /// <summary>
    /// <para> Writer.</para>
    /// <para> Represents the following element tag in the schema: b:Writer </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Writer Writer
    {
        get 
        {
            return GetElement<Writer>(15);
        }
        set
        {
            SetElement(15, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AuthorList>(deep);
    }

   
}
/// <summary>
/// <para>Source Type.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:SourceType.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SourceType : OpenXmlLeafTextElement
{
    private const string tagName = "SourceType";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10884;
    
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
    /// Initializes a new instance of the SourceType class.
    /// </summary>
    public SourceType():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the SourceType class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public SourceType(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Bibliography.DataSourceValues>(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SourceType>(deep);
    }

   
}
/// <summary>
/// <para>Source.</para>
/// <para> When the object is serialized out as xml, its qualified name is b:Source.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AbbreviatedCaseNumber &lt;b:AbbreviatedCaseNumber></description></item>
///<item><description>AlbumTitle &lt;b:AlbumTitle></description></item>
///<item><description>AuthorList &lt;b:Author></description></item>
///<item><description>BookTitle &lt;b:BookTitle></description></item>
///<item><description>Broadcaster &lt;b:Broadcaster></description></item>
///<item><description>BroadcastTitle &lt;b:BroadcastTitle></description></item>
///<item><description>CaseNumber &lt;b:CaseNumber></description></item>
///<item><description>ChapterNumber &lt;b:ChapterNumber></description></item>
///<item><description>City &lt;b:City></description></item>
///<item><description>Comments &lt;b:Comments></description></item>
///<item><description>ConferenceName &lt;b:ConferenceName></description></item>
///<item><description>CountryRegion &lt;b:CountryRegion></description></item>
///<item><description>Court &lt;b:Court></description></item>
///<item><description>Day &lt;b:Day></description></item>
///<item><description>DayAccessed &lt;b:DayAccessed></description></item>
///<item><description>Department &lt;b:Department></description></item>
///<item><description>Distributor &lt;b:Distributor></description></item>
///<item><description>Edition &lt;b:Edition></description></item>
///<item><description>GuidString &lt;b:Guid></description></item>
///<item><description>Institution &lt;b:Institution></description></item>
///<item><description>InternetSiteTitle &lt;b:InternetSiteTitle></description></item>
///<item><description>Issue &lt;b:Issue></description></item>
///<item><description>JournalName &lt;b:JournalName></description></item>
///<item><description>LcId &lt;b:LCID></description></item>
///<item><description>Medium &lt;b:Medium></description></item>
///<item><description>Month &lt;b:Month></description></item>
///<item><description>MonthAccessed &lt;b:MonthAccessed></description></item>
///<item><description>NumberVolumes &lt;b:NumberVolumes></description></item>
///<item><description>Pages &lt;b:Pages></description></item>
///<item><description>PatentNumber &lt;b:PatentNumber></description></item>
///<item><description>PeriodicalTitle &lt;b:PeriodicalTitle></description></item>
///<item><description>ProductionCompany &lt;b:ProductionCompany></description></item>
///<item><description>PublicationTitle &lt;b:PublicationTitle></description></item>
///<item><description>Publisher &lt;b:Publisher></description></item>
///<item><description>RecordingNumber &lt;b:RecordingNumber></description></item>
///<item><description>ReferenceOrder &lt;b:RefOrder></description></item>
///<item><description>Reporter &lt;b:Reporter></description></item>
///<item><description>SourceType &lt;b:SourceType></description></item>
///<item><description>ShortTitle &lt;b:ShortTitle></description></item>
///<item><description>StandardNumber &lt;b:StandardNumber></description></item>
///<item><description>StateProvince &lt;b:StateProvince></description></item>
///<item><description>Station &lt;b:Station></description></item>
///<item><description>Tag &lt;b:Tag></description></item>
///<item><description>Theater &lt;b:Theater></description></item>
///<item><description>ThesisType &lt;b:ThesisType></description></item>
///<item><description>Title &lt;b:Title></description></item>
///<item><description>PatentType &lt;b:Type></description></item>
///<item><description>UrlString &lt;b:URL></description></item>
///<item><description>Version &lt;b:Version></description></item>
///<item><description>Volume &lt;b:Volume></description></item>
///<item><description>Year &lt;b:Year></description></item>
///<item><description>YearAccessed &lt;b:YearAccessed></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AbbreviatedCaseNumber))]
    [ChildElementInfo(typeof(AlbumTitle))]
    [ChildElementInfo(typeof(AuthorList))]
    [ChildElementInfo(typeof(BookTitle))]
    [ChildElementInfo(typeof(Broadcaster))]
    [ChildElementInfo(typeof(BroadcastTitle))]
    [ChildElementInfo(typeof(CaseNumber))]
    [ChildElementInfo(typeof(ChapterNumber))]
    [ChildElementInfo(typeof(City))]
    [ChildElementInfo(typeof(Comments))]
    [ChildElementInfo(typeof(ConferenceName))]
    [ChildElementInfo(typeof(CountryRegion))]
    [ChildElementInfo(typeof(Court))]
    [ChildElementInfo(typeof(Day))]
    [ChildElementInfo(typeof(DayAccessed))]
    [ChildElementInfo(typeof(Department))]
    [ChildElementInfo(typeof(Distributor))]
    [ChildElementInfo(typeof(Edition))]
    [ChildElementInfo(typeof(GuidString))]
    [ChildElementInfo(typeof(Institution))]
    [ChildElementInfo(typeof(InternetSiteTitle))]
    [ChildElementInfo(typeof(Issue))]
    [ChildElementInfo(typeof(JournalName))]
    [ChildElementInfo(typeof(LcId))]
    [ChildElementInfo(typeof(Medium))]
    [ChildElementInfo(typeof(Month))]
    [ChildElementInfo(typeof(MonthAccessed))]
    [ChildElementInfo(typeof(NumberVolumes))]
    [ChildElementInfo(typeof(Pages))]
    [ChildElementInfo(typeof(PatentNumber))]
    [ChildElementInfo(typeof(PeriodicalTitle))]
    [ChildElementInfo(typeof(ProductionCompany))]
    [ChildElementInfo(typeof(PublicationTitle))]
    [ChildElementInfo(typeof(Publisher))]
    [ChildElementInfo(typeof(RecordingNumber))]
    [ChildElementInfo(typeof(ReferenceOrder))]
    [ChildElementInfo(typeof(Reporter))]
    [ChildElementInfo(typeof(SourceType))]
    [ChildElementInfo(typeof(ShortTitle))]
    [ChildElementInfo(typeof(StandardNumber))]
    [ChildElementInfo(typeof(StateProvince))]
    [ChildElementInfo(typeof(Station))]
    [ChildElementInfo(typeof(Tag))]
    [ChildElementInfo(typeof(Theater))]
    [ChildElementInfo(typeof(ThesisType))]
    [ChildElementInfo(typeof(Title))]
    [ChildElementInfo(typeof(PatentType))]
    [ChildElementInfo(typeof(UrlString))]
    [ChildElementInfo(typeof(Version))]
    [ChildElementInfo(typeof(Volume))]
    [ChildElementInfo(typeof(Year))]
    [ChildElementInfo(typeof(YearAccessed))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Source : OpenXmlCompositeElement
{
    private const string tagName = "Source";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 9;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10899;
    
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
    /// Initializes a new instance of the Source class.
    /// </summary>
    public Source():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Source class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Source(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Source class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Source(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Source class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Source(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 9 == namespaceId && "AbbreviatedCaseNumber" == name)
    return new AbbreviatedCaseNumber();
    
if( 9 == namespaceId && "AlbumTitle" == name)
    return new AlbumTitle();
    
if( 9 == namespaceId && "Author" == name)
    return new AuthorList();
    
if( 9 == namespaceId && "BookTitle" == name)
    return new BookTitle();
    
if( 9 == namespaceId && "Broadcaster" == name)
    return new Broadcaster();
    
if( 9 == namespaceId && "BroadcastTitle" == name)
    return new BroadcastTitle();
    
if( 9 == namespaceId && "CaseNumber" == name)
    return new CaseNumber();
    
if( 9 == namespaceId && "ChapterNumber" == name)
    return new ChapterNumber();
    
if( 9 == namespaceId && "City" == name)
    return new City();
    
if( 9 == namespaceId && "Comments" == name)
    return new Comments();
    
if( 9 == namespaceId && "ConferenceName" == name)
    return new ConferenceName();
    
if( 9 == namespaceId && "CountryRegion" == name)
    return new CountryRegion();
    
if( 9 == namespaceId && "Court" == name)
    return new Court();
    
if( 9 == namespaceId && "Day" == name)
    return new Day();
    
if( 9 == namespaceId && "DayAccessed" == name)
    return new DayAccessed();
    
if( 9 == namespaceId && "Department" == name)
    return new Department();
    
if( 9 == namespaceId && "Distributor" == name)
    return new Distributor();
    
if( 9 == namespaceId && "Edition" == name)
    return new Edition();
    
if( 9 == namespaceId && "Guid" == name)
    return new GuidString();
    
if( 9 == namespaceId && "Institution" == name)
    return new Institution();
    
if( 9 == namespaceId && "InternetSiteTitle" == name)
    return new InternetSiteTitle();
    
if( 9 == namespaceId && "Issue" == name)
    return new Issue();
    
if( 9 == namespaceId && "JournalName" == name)
    return new JournalName();
    
if( 9 == namespaceId && "LCID" == name)
    return new LcId();
    
if( 9 == namespaceId && "Medium" == name)
    return new Medium();
    
if( 9 == namespaceId && "Month" == name)
    return new Month();
    
if( 9 == namespaceId && "MonthAccessed" == name)
    return new MonthAccessed();
    
if( 9 == namespaceId && "NumberVolumes" == name)
    return new NumberVolumes();
    
if( 9 == namespaceId && "Pages" == name)
    return new Pages();
    
if( 9 == namespaceId && "PatentNumber" == name)
    return new PatentNumber();
    
if( 9 == namespaceId && "PeriodicalTitle" == name)
    return new PeriodicalTitle();
    
if( 9 == namespaceId && "ProductionCompany" == name)
    return new ProductionCompany();
    
if( 9 == namespaceId && "PublicationTitle" == name)
    return new PublicationTitle();
    
if( 9 == namespaceId && "Publisher" == name)
    return new Publisher();
    
if( 9 == namespaceId && "RecordingNumber" == name)
    return new RecordingNumber();
    
if( 9 == namespaceId && "RefOrder" == name)
    return new ReferenceOrder();
    
if( 9 == namespaceId && "Reporter" == name)
    return new Reporter();
    
if( 9 == namespaceId && "SourceType" == name)
    return new SourceType();
    
if( 9 == namespaceId && "ShortTitle" == name)
    return new ShortTitle();
    
if( 9 == namespaceId && "StandardNumber" == name)
    return new StandardNumber();
    
if( 9 == namespaceId && "StateProvince" == name)
    return new StateProvince();
    
if( 9 == namespaceId && "Station" == name)
    return new Station();
    
if( 9 == namespaceId && "Tag" == name)
    return new Tag();
    
if( 9 == namespaceId && "Theater" == name)
    return new Theater();
    
if( 9 == namespaceId && "ThesisType" == name)
    return new ThesisType();
    
if( 9 == namespaceId && "Title" == name)
    return new Title();
    
if( 9 == namespaceId && "Type" == name)
    return new PatentType();
    
if( 9 == namespaceId && "URL" == name)
    return new UrlString();
    
if( 9 == namespaceId && "Version" == name)
    return new Version();
    
if( 9 == namespaceId && "Volume" == name)
    return new Volume();
    
if( 9 == namespaceId && "Year" == name)
    return new Year();
    
if( 9 == namespaceId && "YearAccessed" == name)
    return new YearAccessed();
    

    return null;
}

        private static readonly string[] eleTagNames = { "AbbreviatedCaseNumber","AlbumTitle","Author","BookTitle","Broadcaster","BroadcastTitle","CaseNumber","ChapterNumber","City","Comments","ConferenceName","CountryRegion","Court","Day","DayAccessed","Department","Distributor","Edition","Guid","Institution","InternetSiteTitle","Issue","JournalName","LCID","Medium","Month","MonthAccessed","NumberVolumes","Pages","PatentNumber","PeriodicalTitle","ProductionCompany","PublicationTitle","Publisher","RecordingNumber","RefOrder","Reporter","SourceType","ShortTitle","StandardNumber","StateProvince","Station","Tag","Theater","ThesisType","Title","Type","URL","Version","Volume","Year","YearAccessed" };
    private static readonly byte[] eleNamespaceIds = { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 };
    
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
    /// <para> Abbreviated Case Number.</para>
    /// <para> Represents the following element tag in the schema: b:AbbreviatedCaseNumber </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public AbbreviatedCaseNumber AbbreviatedCaseNumber
    {
        get 
        {
            return GetElement<AbbreviatedCaseNumber>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Album Title.</para>
    /// <para> Represents the following element tag in the schema: b:AlbumTitle </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public AlbumTitle AlbumTitle
    {
        get 
        {
            return GetElement<AlbumTitle>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Contributors List.</para>
    /// <para> Represents the following element tag in the schema: b:Author </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public AuthorList AuthorList
    {
        get 
        {
            return GetElement<AuthorList>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Book Title.</para>
    /// <para> Represents the following element tag in the schema: b:BookTitle </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public BookTitle BookTitle
    {
        get 
        {
            return GetElement<BookTitle>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> Broadcaster.</para>
    /// <para> Represents the following element tag in the schema: b:Broadcaster </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Broadcaster Broadcaster
    {
        get 
        {
            return GetElement<Broadcaster>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> Broadcast Title.</para>
    /// <para> Represents the following element tag in the schema: b:BroadcastTitle </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public BroadcastTitle BroadcastTitle
    {
        get 
        {
            return GetElement<BroadcastTitle>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }
    /// <summary>
    /// <para> Case Number.</para>
    /// <para> Represents the following element tag in the schema: b:CaseNumber </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public CaseNumber CaseNumber
    {
        get 
        {
            return GetElement<CaseNumber>(6);
        }
        set
        {
            SetElement(6, value);
        }
    }
    /// <summary>
    /// <para> Chapter Number.</para>
    /// <para> Represents the following element tag in the schema: b:ChapterNumber </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public ChapterNumber ChapterNumber
    {
        get 
        {
            return GetElement<ChapterNumber>(7);
        }
        set
        {
            SetElement(7, value);
        }
    }
    /// <summary>
    /// <para> City.</para>
    /// <para> Represents the following element tag in the schema: b:City </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public City City
    {
        get 
        {
            return GetElement<City>(8);
        }
        set
        {
            SetElement(8, value);
        }
    }
    /// <summary>
    /// <para> Comments.</para>
    /// <para> Represents the following element tag in the schema: b:Comments </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Comments Comments
    {
        get 
        {
            return GetElement<Comments>(9);
        }
        set
        {
            SetElement(9, value);
        }
    }
    /// <summary>
    /// <para> Conference or Proceedings Name.</para>
    /// <para> Represents the following element tag in the schema: b:ConferenceName </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public ConferenceName ConferenceName
    {
        get 
        {
            return GetElement<ConferenceName>(10);
        }
        set
        {
            SetElement(10, value);
        }
    }
    /// <summary>
    /// <para> Country or Region.</para>
    /// <para> Represents the following element tag in the schema: b:CountryRegion </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public CountryRegion CountryRegion
    {
        get 
        {
            return GetElement<CountryRegion>(11);
        }
        set
        {
            SetElement(11, value);
        }
    }
    /// <summary>
    /// <para> Court.</para>
    /// <para> Represents the following element tag in the schema: b:Court </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Court Court
    {
        get 
        {
            return GetElement<Court>(12);
        }
        set
        {
            SetElement(12, value);
        }
    }
    /// <summary>
    /// <para> Day.</para>
    /// <para> Represents the following element tag in the schema: b:Day </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Day Day
    {
        get 
        {
            return GetElement<Day>(13);
        }
        set
        {
            SetElement(13, value);
        }
    }
    /// <summary>
    /// <para> Day Accessed.</para>
    /// <para> Represents the following element tag in the schema: b:DayAccessed </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public DayAccessed DayAccessed
    {
        get 
        {
            return GetElement<DayAccessed>(14);
        }
        set
        {
            SetElement(14, value);
        }
    }
    /// <summary>
    /// <para> Department.</para>
    /// <para> Represents the following element tag in the schema: b:Department </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Department Department
    {
        get 
        {
            return GetElement<Department>(15);
        }
        set
        {
            SetElement(15, value);
        }
    }
    /// <summary>
    /// <para> Distributor.</para>
    /// <para> Represents the following element tag in the schema: b:Distributor </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Distributor Distributor
    {
        get 
        {
            return GetElement<Distributor>(16);
        }
        set
        {
            SetElement(16, value);
        }
    }
    /// <summary>
    /// <para> Editor.</para>
    /// <para> Represents the following element tag in the schema: b:Edition </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Edition Edition
    {
        get 
        {
            return GetElement<Edition>(17);
        }
        set
        {
            SetElement(17, value);
        }
    }
    /// <summary>
    /// <para> GUID.</para>
    /// <para> Represents the following element tag in the schema: b:Guid </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public GuidString GuidString
    {
        get 
        {
            return GetElement<GuidString>(18);
        }
        set
        {
            SetElement(18, value);
        }
    }
    /// <summary>
    /// <para> Institution.</para>
    /// <para> Represents the following element tag in the schema: b:Institution </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Institution Institution
    {
        get 
        {
            return GetElement<Institution>(19);
        }
        set
        {
            SetElement(19, value);
        }
    }
    /// <summary>
    /// <para> Internet Site Title.</para>
    /// <para> Represents the following element tag in the schema: b:InternetSiteTitle </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public InternetSiteTitle InternetSiteTitle
    {
        get 
        {
            return GetElement<InternetSiteTitle>(20);
        }
        set
        {
            SetElement(20, value);
        }
    }
    /// <summary>
    /// <para> Issue.</para>
    /// <para> Represents the following element tag in the schema: b:Issue </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Issue Issue
    {
        get 
        {
            return GetElement<Issue>(21);
        }
        set
        {
            SetElement(21, value);
        }
    }
    /// <summary>
    /// <para> Journal Name.</para>
    /// <para> Represents the following element tag in the schema: b:JournalName </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public JournalName JournalName
    {
        get 
        {
            return GetElement<JournalName>(22);
        }
        set
        {
            SetElement(22, value);
        }
    }
    /// <summary>
    /// <para> Locale ID.</para>
    /// <para> Represents the following element tag in the schema: b:LCID </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public LcId LcId
    {
        get 
        {
            return GetElement<LcId>(23);
        }
        set
        {
            SetElement(23, value);
        }
    }
    /// <summary>
    /// <para> Medium.</para>
    /// <para> Represents the following element tag in the schema: b:Medium </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Medium Medium
    {
        get 
        {
            return GetElement<Medium>(24);
        }
        set
        {
            SetElement(24, value);
        }
    }
    /// <summary>
    /// <para> Month.</para>
    /// <para> Represents the following element tag in the schema: b:Month </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Month Month
    {
        get 
        {
            return GetElement<Month>(25);
        }
        set
        {
            SetElement(25, value);
        }
    }
    /// <summary>
    /// <para> Month Accessed.</para>
    /// <para> Represents the following element tag in the schema: b:MonthAccessed </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public MonthAccessed MonthAccessed
    {
        get 
        {
            return GetElement<MonthAccessed>(26);
        }
        set
        {
            SetElement(26, value);
        }
    }
    /// <summary>
    /// <para> Number of Volumes.</para>
    /// <para> Represents the following element tag in the schema: b:NumberVolumes </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public NumberVolumes NumberVolumes
    {
        get 
        {
            return GetElement<NumberVolumes>(27);
        }
        set
        {
            SetElement(27, value);
        }
    }
    /// <summary>
    /// <para> Pages.</para>
    /// <para> Represents the following element tag in the schema: b:Pages </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Pages Pages
    {
        get 
        {
            return GetElement<Pages>(28);
        }
        set
        {
            SetElement(28, value);
        }
    }
    /// <summary>
    /// <para> Patent Number.</para>
    /// <para> Represents the following element tag in the schema: b:PatentNumber </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public PatentNumber PatentNumber
    {
        get 
        {
            return GetElement<PatentNumber>(29);
        }
        set
        {
            SetElement(29, value);
        }
    }
    /// <summary>
    /// <para> Periodical Title.</para>
    /// <para> Represents the following element tag in the schema: b:PeriodicalTitle </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public PeriodicalTitle PeriodicalTitle
    {
        get 
        {
            return GetElement<PeriodicalTitle>(30);
        }
        set
        {
            SetElement(30, value);
        }
    }
    /// <summary>
    /// <para> Production Company.</para>
    /// <para> Represents the following element tag in the schema: b:ProductionCompany </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public ProductionCompany ProductionCompany
    {
        get 
        {
            return GetElement<ProductionCompany>(31);
        }
        set
        {
            SetElement(31, value);
        }
    }
    /// <summary>
    /// <para> Publication Title.</para>
    /// <para> Represents the following element tag in the schema: b:PublicationTitle </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public PublicationTitle PublicationTitle
    {
        get 
        {
            return GetElement<PublicationTitle>(32);
        }
        set
        {
            SetElement(32, value);
        }
    }
    /// <summary>
    /// <para> Publisher.</para>
    /// <para> Represents the following element tag in the schema: b:Publisher </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Publisher Publisher
    {
        get 
        {
            return GetElement<Publisher>(33);
        }
        set
        {
            SetElement(33, value);
        }
    }
    /// <summary>
    /// <para> Recording Number.</para>
    /// <para> Represents the following element tag in the schema: b:RecordingNumber </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public RecordingNumber RecordingNumber
    {
        get 
        {
            return GetElement<RecordingNumber>(34);
        }
        set
        {
            SetElement(34, value);
        }
    }
    /// <summary>
    /// <para> Reference Order.</para>
    /// <para> Represents the following element tag in the schema: b:RefOrder </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public ReferenceOrder ReferenceOrder
    {
        get 
        {
            return GetElement<ReferenceOrder>(35);
        }
        set
        {
            SetElement(35, value);
        }
    }
    /// <summary>
    /// <para> Reporter.</para>
    /// <para> Represents the following element tag in the schema: b:Reporter </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Reporter Reporter
    {
        get 
        {
            return GetElement<Reporter>(36);
        }
        set
        {
            SetElement(36, value);
        }
    }
    /// <summary>
    /// <para> Source Type.</para>
    /// <para> Represents the following element tag in the schema: b:SourceType </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public SourceType SourceType
    {
        get 
        {
            return GetElement<SourceType>(37);
        }
        set
        {
            SetElement(37, value);
        }
    }
    /// <summary>
    /// <para> Short Title.</para>
    /// <para> Represents the following element tag in the schema: b:ShortTitle </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public ShortTitle ShortTitle
    {
        get 
        {
            return GetElement<ShortTitle>(38);
        }
        set
        {
            SetElement(38, value);
        }
    }
    /// <summary>
    /// <para> Standard Number.</para>
    /// <para> Represents the following element tag in the schema: b:StandardNumber </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public StandardNumber StandardNumber
    {
        get 
        {
            return GetElement<StandardNumber>(39);
        }
        set
        {
            SetElement(39, value);
        }
    }
    /// <summary>
    /// <para> State or Province.</para>
    /// <para> Represents the following element tag in the schema: b:StateProvince </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public StateProvince StateProvince
    {
        get 
        {
            return GetElement<StateProvince>(40);
        }
        set
        {
            SetElement(40, value);
        }
    }
    /// <summary>
    /// <para> Station.</para>
    /// <para> Represents the following element tag in the schema: b:Station </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Station Station
    {
        get 
        {
            return GetElement<Station>(41);
        }
        set
        {
            SetElement(41, value);
        }
    }
    /// <summary>
    /// <para> Tag.</para>
    /// <para> Represents the following element tag in the schema: b:Tag </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Tag Tag
    {
        get 
        {
            return GetElement<Tag>(42);
        }
        set
        {
            SetElement(42, value);
        }
    }
    /// <summary>
    /// <para> Theater.</para>
    /// <para> Represents the following element tag in the schema: b:Theater </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Theater Theater
    {
        get 
        {
            return GetElement<Theater>(43);
        }
        set
        {
            SetElement(43, value);
        }
    }
    /// <summary>
    /// <para> Thesis Type.</para>
    /// <para> Represents the following element tag in the schema: b:ThesisType </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public ThesisType ThesisType
    {
        get 
        {
            return GetElement<ThesisType>(44);
        }
        set
        {
            SetElement(44, value);
        }
    }
    /// <summary>
    /// <para> Title.</para>
    /// <para> Represents the following element tag in the schema: b:Title </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Title Title
    {
        get 
        {
            return GetElement<Title>(45);
        }
        set
        {
            SetElement(45, value);
        }
    }
    /// <summary>
    /// <para> Type.</para>
    /// <para> Represents the following element tag in the schema: b:Type </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public PatentType PatentType
    {
        get 
        {
            return GetElement<PatentType>(46);
        }
        set
        {
            SetElement(46, value);
        }
    }
    /// <summary>
    /// <para> URL.</para>
    /// <para> Represents the following element tag in the schema: b:URL </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public UrlString UrlString
    {
        get 
        {
            return GetElement<UrlString>(47);
        }
        set
        {
            SetElement(47, value);
        }
    }
    /// <summary>
    /// <para> Version.</para>
    /// <para> Represents the following element tag in the schema: b:Version </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Version Version
    {
        get 
        {
            return GetElement<Version>(48);
        }
        set
        {
            SetElement(48, value);
        }
    }
    /// <summary>
    /// <para> Volume.</para>
    /// <para> Represents the following element tag in the schema: b:Volume </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Volume Volume
    {
        get 
        {
            return GetElement<Volume>(49);
        }
        set
        {
            SetElement(49, value);
        }
    }
    /// <summary>
    /// <para> Year.</para>
    /// <para> Represents the following element tag in the schema: b:Year </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public Year Year
    {
        get 
        {
            return GetElement<Year>(50);
        }
        set
        {
            SetElement(50, value);
        }
    }
    /// <summary>
    /// <para> Year Accessed.</para>
    /// <para> Represents the following element tag in the schema: b:YearAccessed </para>
    /// </summary>
    /// <remark>
    /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
    /// </remark>
    public YearAccessed YearAccessed
    {
        get 
        {
            return GetElement<YearAccessed>(51);
        }
        set
        {
            SetElement(51, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Source>(deep);
    }

   
}
/// <summary>
/// Bibliographic Data Source Types 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DataSourceValues
{  
	///<summary>
///Article in a Periodical.
///<para>When the item is serialized out as xml, its value is "ArticleInAPeriodical".</para>
///</summary>
[EnumString("ArticleInAPeriodical")]
ArticleInAPeriodical,
///<summary>
///Book.
///<para>When the item is serialized out as xml, its value is "Book".</para>
///</summary>
[EnumString("Book")]
Book,
///<summary>
///Book Section.
///<para>When the item is serialized out as xml, its value is "BookSection".</para>
///</summary>
[EnumString("BookSection")]
BookSection,
///<summary>
///Journal Article.
///<para>When the item is serialized out as xml, its value is "JournalArticle".</para>
///</summary>
[EnumString("JournalArticle")]
JournalArticle,
///<summary>
///Conference Proceedings.
///<para>When the item is serialized out as xml, its value is "ConferenceProceedings".</para>
///</summary>
[EnumString("ConferenceProceedings")]
ConferenceProceedings,
///<summary>
///Reporter.
///<para>When the item is serialized out as xml, its value is "Report".</para>
///</summary>
[EnumString("Report")]
Report,
///<summary>
///Sound Recording.
///<para>When the item is serialized out as xml, its value is "SoundRecording".</para>
///</summary>
[EnumString("SoundRecording")]
SoundRecording,
///<summary>
///Performance.
///<para>When the item is serialized out as xml, its value is "Performance".</para>
///</summary>
[EnumString("Performance")]
Performance,
///<summary>
///Art.
///<para>When the item is serialized out as xml, its value is "Art".</para>
///</summary>
[EnumString("Art")]
Art,
///<summary>
///Document from Internet Site.
///<para>When the item is serialized out as xml, its value is "DocumentFromInternetSite".</para>
///</summary>
[EnumString("DocumentFromInternetSite")]
DocumentFromInternetSite,
///<summary>
///Internet Site.
///<para>When the item is serialized out as xml, its value is "InternetSite".</para>
///</summary>
[EnumString("InternetSite")]
InternetSite,
///<summary>
///Film.
///<para>When the item is serialized out as xml, its value is "Film".</para>
///</summary>
[EnumString("Film")]
Film,
///<summary>
///Interview.
///<para>When the item is serialized out as xml, its value is "Interview".</para>
///</summary>
[EnumString("Interview")]
Interview,
///<summary>
///Patent.
///<para>When the item is serialized out as xml, its value is "Patent".</para>
///</summary>
[EnumString("Patent")]
Patent,
///<summary>
///Electronic Source.
///<para>When the item is serialized out as xml, its value is "ElectronicSource".</para>
///</summary>
[EnumString("ElectronicSource")]
ElectronicSource,
///<summary>
///Case.
///<para>When the item is serialized out as xml, its value is "Case".</para>
///</summary>
[EnumString("Case")]
Case,
///<summary>
///Miscellaneous.
///<para>When the item is serialized out as xml, its value is "Misc".</para>
///</summary>
[EnumString("Misc")]
Miscellaneous,
 
}
}
 
 
