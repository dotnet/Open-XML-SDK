// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2010.Word.Drawing
{
/// <summary>
/// <para>Defines the PercentagePositionHeightOffset Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:pctPosHOffset.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PercentagePositionHeightOffset : OpenXmlLeafTextElement
{
    private const string tagName = "pctPosHOffset";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 51;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12889;
    
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
    /// Initializes a new instance of the PercentagePositionHeightOffset class.
    /// </summary>
    public PercentagePositionHeightOffset():base(){}
    
           /// <summary>
    /// Initializes a new instance of the PercentagePositionHeightOffset class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PercentagePositionHeightOffset(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Int32Value(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PercentagePositionHeightOffset>(deep);
    }

}
/// <summary>
/// <para>Defines the PercentagePositionVerticalOffset Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:pctPosVOffset.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PercentagePositionVerticalOffset : OpenXmlLeafTextElement
{
    private const string tagName = "pctPosVOffset";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 51;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12890;
    
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
    /// Initializes a new instance of the PercentagePositionVerticalOffset class.
    /// </summary>
    public PercentagePositionVerticalOffset():base(){}
    
           /// <summary>
    /// Initializes a new instance of the PercentagePositionVerticalOffset class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PercentagePositionVerticalOffset(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Int32Value(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PercentagePositionVerticalOffset>(deep);
    }

}
/// <summary>
/// <para>Defines the RelativeWidth Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:sizeRelH.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PercentageWidth &lt;wp14:pctWidth></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PercentageWidth),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RelativeWidth : OpenXmlCompositeElement
{
    private const string tagName = "sizeRelH";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 51;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12891;
    
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
    

    private static string[] attributeTagNames = { "relativeFrom" };
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
    /// <para> relativeFrom.</para>
    /// <para>Represents the following attribute in the schema: relativeFrom </para>
    /// </summary>
    [SchemaAttr(0, "relativeFrom")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues> ObjectId
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RelativeWidth class.
    /// </summary>
    public RelativeWidth():base(){}
    
            /// <summary>
    ///Initializes a new instance of the RelativeWidth class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RelativeWidth(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RelativeWidth class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RelativeWidth(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RelativeWidth class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RelativeWidth(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 51 == namespaceId && "pctWidth" == name)
    return new PercentageWidth();
    

    return null;
}

        private static readonly string[] eleTagNames = { "pctWidth" };
    private static readonly byte[] eleNamespaceIds = { 51 };
    
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
    /// <para> PercentageWidth.</para>
    /// <para> Represents the following element tag in the schema: wp14:pctWidth </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp14 = http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
    /// </remark>
    public PercentageWidth PercentageWidth
    {
        get 
        {
            return GetElement<PercentageWidth>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "relativeFrom" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RelativeWidth>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RelativeHeight Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:sizeRelV.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PercentageHeight &lt;wp14:pctHeight></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PercentageHeight),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RelativeHeight : OpenXmlCompositeElement
{
    private const string tagName = "sizeRelV";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 51;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12892;
    
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
    

    private static string[] attributeTagNames = { "relativeFrom" };
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
    /// <para> relativeFrom.</para>
    /// <para>Represents the following attribute in the schema: relativeFrom </para>
    /// </summary>
    [SchemaAttr(0, "relativeFrom")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues> RelativeFrom
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RelativeHeight class.
    /// </summary>
    public RelativeHeight():base(){}
    
            /// <summary>
    ///Initializes a new instance of the RelativeHeight class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RelativeHeight(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RelativeHeight class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RelativeHeight(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RelativeHeight class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RelativeHeight(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 51 == namespaceId && "pctHeight" == name)
    return new PercentageHeight();
    

    return null;
}

        private static readonly string[] eleTagNames = { "pctHeight" };
    private static readonly byte[] eleNamespaceIds = { 51 };
    
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
    /// <para> PercentageHeight.</para>
    /// <para> Represents the following element tag in the schema: wp14:pctHeight </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp14 = http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
    /// </remark>
    public PercentageHeight PercentageHeight
    {
        get 
        {
            return GetElement<PercentageHeight>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "relativeFrom" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RelativeHeight>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PercentageWidth Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:pctWidth.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PercentageWidth : OpenXmlLeafTextElement
{
    private const string tagName = "pctWidth";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 51;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12893;
    
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
    /// Initializes a new instance of the PercentageWidth class.
    /// </summary>
    public PercentageWidth():base(){}
    
           /// <summary>
    /// Initializes a new instance of the PercentageWidth class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PercentageWidth(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Int32Value(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PercentageWidth>(deep);
    }

}
/// <summary>
/// <para>Defines the PercentageHeight Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:pctHeight.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PercentageHeight : OpenXmlLeafTextElement
{
    private const string tagName = "pctHeight";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 51;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12894;
    
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
    /// Initializes a new instance of the PercentageHeight class.
    /// </summary>
    public PercentageHeight():base(){}
    
           /// <summary>
    /// Initializes a new instance of the PercentageHeight class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PercentageHeight(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new Int32Value(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PercentageHeight>(deep);
    }

}
/// <summary>
/// Defines the SizeRelativeHorizontallyValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SizeRelativeHorizontallyValues
{  
	///<summary>
///margin.
///<para>When the item is serialized out as xml, its value is "margin".</para>
///</summary>
[EnumString("margin")]
Margin,
///<summary>
///page.
///<para>When the item is serialized out as xml, its value is "page".</para>
///</summary>
[EnumString("page")]
Page,
///<summary>
///leftMargin.
///<para>When the item is serialized out as xml, its value is "leftMargin".</para>
///</summary>
[EnumString("leftMargin")]
LeftMargin,
///<summary>
///rightMargin.
///<para>When the item is serialized out as xml, its value is "rightMargin".</para>
///</summary>
[EnumString("rightMargin")]
RightMargin,
///<summary>
///insideMargin.
///<para>When the item is serialized out as xml, its value is "insideMargin".</para>
///</summary>
[EnumString("insideMargin")]
InsideMargin,
///<summary>
///outsideMargin.
///<para>When the item is serialized out as xml, its value is "outsideMargin".</para>
///</summary>
[EnumString("outsideMargin")]
OutsideMargin,
 
}
/// <summary>
/// Defines the SizeRelativeVerticallyValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SizeRelativeVerticallyValues
{  
	///<summary>
///margin.
///<para>When the item is serialized out as xml, its value is "margin".</para>
///</summary>
[EnumString("margin")]
Margin,
///<summary>
///page.
///<para>When the item is serialized out as xml, its value is "page".</para>
///</summary>
[EnumString("page")]
Page,
///<summary>
///topMargin.
///<para>When the item is serialized out as xml, its value is "topMargin".</para>
///</summary>
[EnumString("topMargin")]
TopMargin,
///<summary>
///bottomMargin.
///<para>When the item is serialized out as xml, its value is "bottomMargin".</para>
///</summary>
[EnumString("bottomMargin")]
BottomMargin,
///<summary>
///insideMargin.
///<para>When the item is serialized out as xml, its value is "insideMargin".</para>
///</summary>
[EnumString("insideMargin")]
InsideMargin,
///<summary>
///outsideMargin.
///<para>When the item is serialized out as xml, its value is "outsideMargin".</para>
///</summary>
[EnumString("outsideMargin")]
OutsideMargin,
 
}
}
 
 
