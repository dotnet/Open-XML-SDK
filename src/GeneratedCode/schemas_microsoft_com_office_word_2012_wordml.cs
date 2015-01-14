// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Office2013.Word
{
/// <summary>
/// <para>Defines the Color Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:color.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Color : OpenXmlLeafElement
{
    private const string tagName = "color";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13334;
    
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
    

    private static string[] attributeTagNames = { "val","themeColor","themeTint","themeShade" };
    private static byte[] attributeNamespaceIds = { 23,23,23,23 };
    
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
    /// <para> Run Content Color.</para>
    /// <para>Represents the following attribute in the schema: w:val </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Run Content Theme Color.</para>
    /// <para>Represents the following attribute in the schema: w:themeColor </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "themeColor")]
    public EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues> ThemeColor
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Run Content Theme Color Tint.</para>
    /// <para>Represents the following attribute in the schema: w:themeTint </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "themeTint")]
    public StringValue ThemeTint
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Run Content Theme Color Shade.</para>
    /// <para>Represents the following attribute in the schema: w:themeShade </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "themeShade")]
    public StringValue ThemeShade
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Color class.
    /// </summary>
    public Color():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 23 == namespaceId && "val" == name)
    return new StringValue();
    
if( 23 == namespaceId && "themeColor" == name)
    return new EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues>();
    
if( 23 == namespaceId && "themeTint" == name)
    return new StringValue();
    
if( 23 == namespaceId && "themeShade" == name)
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
        return CloneImp<Color>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataBinding Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:dataBinding.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataBinding : OpenXmlLeafElement
{
    private const string tagName = "dataBinding";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13335;
    
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
    

    private static string[] attributeTagNames = { "prefixMappings","xpath","storeItemID" };
    private static byte[] attributeNamespaceIds = { 23,23,23 };
    
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
    /// <para> XML Namespace Prefix Mappings.</para>
    /// <para>Represents the following attribute in the schema: w:prefixMappings </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "prefixMappings")]
    public StringValue PrefixMappings
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> XPath.</para>
    /// <para>Represents the following attribute in the schema: w:xpath </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "xpath")]
    public StringValue XPath
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Custom XML Data Storage ID.</para>
    /// <para>Represents the following attribute in the schema: w:storeItemID </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "storeItemID")]
    public StringValue StoreItemId
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataBinding class.
    /// </summary>
    public DataBinding():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 23 == namespaceId && "prefixMappings" == name)
    return new StringValue();
    
if( 23 == namespaceId && "xpath" == name)
    return new StringValue();
    
if( 23 == namespaceId && "storeItemID" == name)
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
        return CloneImp<DataBinding>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Appearance Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:appearance.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Appearance : OpenXmlLeafElement
{
    private const string tagName = "appearance";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13336;
    
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
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 69 };
    
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
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w15:val </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "val")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Appearance class.
    /// </summary>
    public Appearance():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Appearance>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CommentsEx Class. The root element of WordprocessingCommentsExPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:commentsEx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CommentEx &lt;w15:commentEx></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(CommentEx),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CommentsEx : OpenXmlPartRootElement
{
    private const string tagName = "commentsEx";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13337;
    
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
    /// CommentsEx constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the CommentsEx.</param>
    internal CommentsEx(WordprocessingCommentsExPart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(WordprocessingCommentsExPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the WordprocessingCommentsExPart associated with this element.
    /// </summary>
    public WordprocessingCommentsExPart WordprocessingCommentsExPart
    {
		get
		{
			return OpenXmlPart as WordprocessingCommentsExPart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the CommentsEx class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CommentsEx(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CommentsEx class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CommentsEx(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CommentsEx class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CommentsEx(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the CommentsEx class.
    /// </summary>
    public CommentsEx() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(WordprocessingCommentsExPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "commentEx" == name)
    return new CommentEx();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CommentsEx>(deep);
    }

}
/// <summary>
/// <para>Defines the People Class. The root element of WordprocessingPeoplePart.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:people.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Person &lt;w15:person></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Person),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class People : OpenXmlPartRootElement
{
    private const string tagName = "people";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13338;
    
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
    /// People constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the People.</param>
    internal People(WordprocessingPeoplePart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the WordprocessingPeoplePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(WordprocessingPeoplePart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the WordprocessingPeoplePart associated with this element.
    /// </summary>
    public WordprocessingPeoplePart WordprocessingPeoplePart
    {
		get
		{
			return OpenXmlPart as WordprocessingPeoplePart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the People class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public People(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the People class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public People(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the People class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public People(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the People class.
    /// </summary>
    public People() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the WordprocessingPeoplePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(WordprocessingPeoplePart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "person" == name)
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
        return CloneImp<People>(deep);
    }

}
/// <summary>
/// <para>Defines the SdtRepeatedSection Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:repeatingSection.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SectionTitle &lt;w15:sectionTitle></description></item>
///<item><description>DoNotAllowInsertDeleteSection &lt;w15:doNotAllowInsertDeleteSection></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SectionTitle),(FileFormatVersions)4)]
    [ChildElementInfo(typeof(DoNotAllowInsertDeleteSection),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SdtRepeatedSection : OpenXmlCompositeElement
{
    private const string tagName = "repeatingSection";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13339;
    
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
    /// Initializes a new instance of the SdtRepeatedSection class.
    /// </summary>
    public SdtRepeatedSection():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SdtRepeatedSection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SdtRepeatedSection(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SdtRepeatedSection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SdtRepeatedSection(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SdtRepeatedSection class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SdtRepeatedSection(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "sectionTitle" == name)
    return new SectionTitle();
    
if( 69 == namespaceId && "doNotAllowInsertDeleteSection" == name)
    return new DoNotAllowInsertDeleteSection();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sectionTitle","doNotAllowInsertDeleteSection" };
    private static readonly byte[] eleNamespaceIds = { 69,69 };
    
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
    /// <para> SectionTitle.</para>
    /// <para> Represents the following element tag in the schema: w15:sectionTitle </para>
    /// </summary>
    /// <remark>
    /// xmlns:w15 = http://schemas.microsoft.com/office/word/2012/wordml
    /// </remark>
    public SectionTitle SectionTitle
    {
        get 
        {
            return GetElement<SectionTitle>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> DoNotAllowInsertDeleteSection.</para>
    /// <para> Represents the following element tag in the schema: w15:doNotAllowInsertDeleteSection </para>
    /// </summary>
    /// <remark>
    /// xmlns:w15 = http://schemas.microsoft.com/office/word/2012/wordml
    /// </remark>
    public DoNotAllowInsertDeleteSection DoNotAllowInsertDeleteSection
    {
        get 
        {
            return GetElement<DoNotAllowInsertDeleteSection>(1);
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
        return CloneImp<SdtRepeatedSection>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SdtRepeatedSectionItem Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:repeatingSectionItem.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SdtRepeatedSectionItem : OpenXmlLeafElement
{
    private const string tagName = "repeatingSectionItem";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13340;
    
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
    /// Initializes a new instance of the SdtRepeatedSectionItem class.
    /// </summary>
    public SdtRepeatedSectionItem():base(){}
    
      
     
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SdtRepeatedSectionItem>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ChartTrackingRefBased Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:chartTrackingRefBased.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ChartTrackingRefBased : OnOffType
{
    private const string tagName = "chartTrackingRefBased";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13341;
    
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
    /// Initializes a new instance of the ChartTrackingRefBased class.
    /// </summary>
    public ChartTrackingRefBased():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ChartTrackingRefBased>(deep);
    }

}
/// <summary>
/// <para>Defines the DefaultCollapsed Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:collapsed.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DefaultCollapsed : OnOffType
{
    private const string tagName = "collapsed";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13342;
    
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
    /// Initializes a new instance of the DefaultCollapsed class.
    /// </summary>
    public DefaultCollapsed():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DefaultCollapsed>(deep);
    }

}
/// <summary>
/// <para>Defines the WebExtensionLinked Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:webExtensionLinked.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionLinked : OnOffType
{
    private const string tagName = "webExtensionLinked";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13345;
    
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
    /// Initializes a new instance of the WebExtensionLinked class.
    /// </summary>
    public WebExtensionLinked():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<WebExtensionLinked>(deep);
    }

}
/// <summary>
/// <para>Defines the WebExtensionCreated Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:webExtensionCreated.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionCreated : OnOffType
{
    private const string tagName = "webExtensionCreated";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13346;
    
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
    /// Initializes a new instance of the WebExtensionCreated class.
    /// </summary>
    public WebExtensionCreated():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<WebExtensionCreated>(deep);
    }

}
/// <summary>
/// <para>Defines the DoNotAllowInsertDeleteSection Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:doNotAllowInsertDeleteSection.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DoNotAllowInsertDeleteSection : OnOffType
{
    private const string tagName = "doNotAllowInsertDeleteSection";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13351;
    
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
    /// Initializes a new instance of the DoNotAllowInsertDeleteSection class.
    /// </summary>
    public DoNotAllowInsertDeleteSection():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DoNotAllowInsertDeleteSection>(deep);
    }

}
/// <summary>
/// Defines the OnOffType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OnOffType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 23 };
    
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
    /// <para> On/Off Value.</para>
    /// <para>Represents the following attribute in the schema: w:val </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "val")]
    public OnOffValue Val
    {
        get { return (OnOffValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 23 == namespaceId && "val" == name)
    return new OnOffValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the OnOffType class.
    /// </summary>
    protected OnOffType(){}
    
    
    
}
/// <summary>
/// <para>Defines the PersistentDocumentId Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:docId.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PersistentDocumentId : OpenXmlLeafElement
{
    private const string tagName = "docId";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13343;
    
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
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 69 };
    
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
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w15:val </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PersistentDocumentId class.
    /// </summary>
    public PersistentDocumentId():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "val" == name)
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
        return CloneImp<PersistentDocumentId>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FootnoteColumns Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:footnoteColumns.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FootnoteColumns : OpenXmlLeafElement
{
    private const string tagName = "footnoteColumns";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13344;
    
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
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 23 };
    
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
    /// <para> Decimal Number Value.</para>
    /// <para>Represents the following attribute in the schema: w:val </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "val")]
    public Int32Value Val
    {
        get { return (Int32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FootnoteColumns class.
    /// </summary>
    public FootnoteColumns():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 23 == namespaceId && "val" == name)
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
        return CloneImp<FootnoteColumns>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CommentEx Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:commentEx.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CommentEx : OpenXmlLeafElement
{
    private const string tagName = "commentEx";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13347;
    
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
    

    private static string[] attributeTagNames = { "paraId","paraIdParent","done" };
    private static byte[] attributeNamespaceIds = { 69,69,69 };
    
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
    /// <para> paraId.</para>
    /// <para>Represents the following attribute in the schema: w15:paraId </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "paraId")]
    public HexBinaryValue ParaId
    {
        get { return (HexBinaryValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> paraIdParent.</para>
    /// <para>Represents the following attribute in the schema: w15:paraIdParent </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "paraIdParent")]
    public HexBinaryValue ParaIdParent
    {
        get { return (HexBinaryValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> done.</para>
    /// <para>Represents the following attribute in the schema: w15:done </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "done")]
    public OnOffValue Done
    {
        get { return (OnOffValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CommentEx class.
    /// </summary>
    public CommentEx():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "paraId" == name)
    return new HexBinaryValue();
    
if( 69 == namespaceId && "paraIdParent" == name)
    return new HexBinaryValue();
    
if( 69 == namespaceId && "done" == name)
    return new OnOffValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CommentEx>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Person Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:person.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PresenceInfo &lt;w15:presenceInfo></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PresenceInfo),(FileFormatVersions)4)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Person : OpenXmlCompositeElement
{
    private const string tagName = "person";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13348;
    
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
    

    private static string[] attributeTagNames = { "author","contact" };
    private static byte[] attributeNamespaceIds = { 69,69 };
    
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
    /// <para> author.</para>
    /// <para>Represents the following attribute in the schema: w15:author </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "author")]
    public StringValue Author
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> contact.</para>
    /// <para>Represents the following attribute in the schema: w15:contact </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "contact")]
    public StringValue Contact
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
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
    if( 69 == namespaceId && "presenceInfo" == name)
    return new PresenceInfo();
    

    return null;
}

        private static readonly string[] eleTagNames = { "presenceInfo" };
    private static readonly byte[] eleNamespaceIds = { 69 };
    
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
    /// <para> PresenceInfo.</para>
    /// <para> Represents the following element tag in the schema: w15:presenceInfo </para>
    /// </summary>
    /// <remark>
    /// xmlns:w15 = http://schemas.microsoft.com/office/word/2012/wordml
    /// </remark>
    public PresenceInfo PresenceInfo
    {
        get 
        {
            return GetElement<PresenceInfo>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "author" == name)
    return new StringValue();
    
if( 69 == namespaceId && "contact" == name)
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
        return CloneImp<Person>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PresenceInfo Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:presenceInfo.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PresenceInfo : OpenXmlLeafElement
{
    private const string tagName = "presenceInfo";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13349;
    
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
    

    private static string[] attributeTagNames = { "providerId","userId" };
    private static byte[] attributeNamespaceIds = { 69,69 };
    
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
    /// <para> providerId.</para>
    /// <para>Represents the following attribute in the schema: w15:providerId </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "providerId")]
    public StringValue ProviderId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> userId.</para>
    /// <para>Represents the following attribute in the schema: w15:userId </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "userId")]
    public StringValue UserId
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PresenceInfo class.
    /// </summary>
    public PresenceInfo():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "providerId" == name)
    return new StringValue();
    
if( 69 == namespaceId && "userId" == name)
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
        return CloneImp<PresenceInfo>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SectionTitle Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:sectionTitle.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SectionTitle : OpenXmlLeafElement
{
    private const string tagName = "sectionTitle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 69;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13350;
    
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
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 23 };
    
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
    /// <para> String Value.</para>
    /// <para>Represents the following attribute in the schema: w:val </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SectionTitle class.
    /// </summary>
    public SectionTitle():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 23 == namespaceId && "val" == name)
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
        return CloneImp<SectionTitle>(deep);
    }

   
}
/// <summary>
/// Defines the SdtAppearance enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SdtAppearance
{  
	///<summary>
///boundingBox.
///<para>When the item is serialized out as xml, its value is "boundingBox".</para>
///</summary>
[EnumString("boundingBox")]
BoundingBox,
///<summary>
///tags.
///<para>When the item is serialized out as xml, its value is "tags".</para>
///</summary>
[EnumString("tags")]
Tags,
///<summary>
///hidden.
///<para>When the item is serialized out as xml, its value is "hidden".</para>
///</summary>
[EnumString("hidden")]
Hidden,
 
}
}
 
 
