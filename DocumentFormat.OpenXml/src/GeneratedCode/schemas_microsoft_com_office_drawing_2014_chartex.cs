// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing
{
/// <summary>
/// <para>Defines the ChartSpace Class. The root element of ExtendedChartPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:chartSpace.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartData &lt;cx:chartData></description></item>
///<item><description>Chart &lt;cx:chart></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ColorMappingType &lt;cx:clrMapOvr></description></item>
///<item><description>PrintSettings &lt;cx:printSettings></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ChartData),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Chart),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(TxPrTextBody),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ColorMappingType),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(PrintSettings),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ChartSpace : OpenXmlPartRootElement
{
    private const string tagName = "chartSpace";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13450;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    
    /// <summary>
    /// ChartSpace constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the ChartSpace.</param>
    internal ChartSpace(ExtendedChartPart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the ExtendedChartPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(ExtendedChartPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the ExtendedChartPart associated with this element.
    /// </summary>
    public ExtendedChartPart ExtendedChartPart
    {
		get
		{
			return OpenXmlPart as ExtendedChartPart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the ChartSpace class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartSpace(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartSpace class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartSpace(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartSpace class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartSpace(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the ChartSpace class.
    /// </summary>
    public ChartSpace() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the ExtendedChartPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(ExtendedChartPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "chartData" == name)
    return new ChartData();
    
if( 80 == namespaceId && "chart" == name)
    return new Chart();
    
if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "txPr" == name)
    return new TxPrTextBody();
    
if( 80 == namespaceId && "clrMapOvr" == name)
    return new ColorMappingType();
    
if( 80 == namespaceId && "printSettings" == name)
    return new PrintSettings();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "chartData","chart","spPr","txPr","clrMapOvr","printSettings","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80,80,80,80 };
    
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
    /// <para> ChartData.</para>
    /// <para> Represents the following element tag in the schema: cx:chartData </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ChartData ChartData
    {
        get 
        {
            return GetElement<ChartData>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Chart.</para>
    /// <para> Represents the following element tag in the schema: cx:chart </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public Chart Chart
    {
        get 
        {
            return GetElement<Chart>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get 
        {
            return GetElement<ShapeProperties>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public TxPrTextBody TxPrTextBody
    {
        get 
        {
            return GetElement<TxPrTextBody>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> ColorMappingType.</para>
    /// <para> Represents the following element tag in the schema: cx:clrMapOvr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ColorMappingType ColorMappingType
    {
        get 
        {
            return GetElement<ColorMappingType>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> PrintSettings.</para>
    /// <para> Represents the following element tag in the schema: cx:printSettings </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public PrintSettings PrintSettings
    {
        get 
        {
            return GetElement<PrintSettings>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ChartSpace>(deep);
    }

}
/// <summary>
/// <para>Defines the Extension2 Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Extension2 : OpenXmlCompositeElement
{
    private const string tagName = "ext";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13451;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "uri" };
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
    /// <para> uri.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Extension2 class.
    /// </summary>
    public Extension2():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Extension2 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Extension2(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Extension2 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Extension2(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Extension2 class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Extension2(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    
    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "uri" == name)
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
        return CloneImp<Extension2>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ChartStringValue Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:pt.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ChartStringValue : OpenXmlLeafTextElement
{
    private const string tagName = "pt";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13452;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "idx" };
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
    /// <para> idx.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    public UInt32Value Index
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ChartStringValue class.
    /// </summary>
    public ChartStringValue():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the ChartStringValue class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ChartStringValue(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "idx" == name)
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
        return CloneImp<ChartStringValue>(deep);
    }

   
}
/// <summary>
/// <para>Defines the NumericValue Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:pt.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class NumericValue : OpenXmlLeafTextElement
{
    private const string tagName = "pt";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13453;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "idx" };
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
    /// <para> idx.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    public UInt32Value Idx
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NumericValue class.
    /// </summary>
    public NumericValue():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the NumericValue class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public NumericValue(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new DoubleValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "idx" == name)
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
        return CloneImp<NumericValue>(deep);
    }

   
}
/// <summary>
/// <para>Defines the NumericDimension Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:numDim.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;cx:f></description></item>
///<item><description>NumericLevel &lt;cx:lvl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Formula),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(NumericLevel),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class NumericDimension : OpenXmlCompositeElement
{
    private const string tagName = "numDim";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13454;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "type" };
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
    /// <para> Dimension data type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NumericDimension class.
    /// </summary>
    public NumericDimension():base(){}
    
            /// <summary>
    ///Initializes a new instance of the NumericDimension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumericDimension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumericDimension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumericDimension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumericDimension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumericDimension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "f" == name)
    return new Formula();
    
if( 80 == namespaceId && "lvl" == name)
    return new NumericLevel();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<NumericDimension>(deep);
    }

   
}
/// <summary>
/// <para>Defines the StringDimension Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:strDim.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;cx:f></description></item>
///<item><description>StringLevel &lt;cx:lvl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Formula),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(StringLevel),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class StringDimension : OpenXmlCompositeElement
{
    private const string tagName = "strDim";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13455;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "type" };
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
    /// <para> Dimension data type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StringDimension class.
    /// </summary>
    public StringDimension():base(){}
    
            /// <summary>
    ///Initializes a new instance of the StringDimension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringDimension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StringDimension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringDimension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StringDimension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StringDimension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "f" == name)
    return new Formula();
    
if( 80 == namespaceId && "lvl" == name)
    return new StringLevel();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "type" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StringDimension>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Extension2 &lt;cx:ext></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Extension2),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
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
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13456;
    
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
		if((8 & (int)version) > 0)
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
    if( 80 == namespaceId && "ext" == name)
    return new Extension2();
    

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
/// <para>Defines the ExternalData Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:externalData.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ExternalData : OpenXmlLeafElement
{
    private const string tagName = "externalData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13457;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","autoUpdate" };
    private static byte[] attributeNamespaceIds = { 19,80 };
    
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
    /// <para> autoUpdate.</para>
    /// <para>Represents the following attribute in the schema: cx:autoUpdate </para>
    /// </summary>
///<remark> xmlns:cx=http://schemas.microsoft.com/office/drawing/2014/chartex
///</remark>
    [SchemaAttr(80, "autoUpdate")]
    public BooleanValue AutoUpdate
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ExternalData class.
    /// </summary>
    public ExternalData():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 19 == namespaceId && "id" == name)
    return new StringValue();
    
if( 80 == namespaceId && "autoUpdate" == name)
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
        return CloneImp<ExternalData>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Data Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:data.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumericDimension &lt;cx:numDim></description></item>
///<item><description>StringDimension &lt;cx:strDim></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(NumericDimension),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(StringDimension),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Data : OpenXmlCompositeElement
{
    private const string tagName = "data";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13458;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id" };
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
    /// Initializes a new instance of the Data class.
    /// </summary>
    public Data():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Data class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Data(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Data class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Data(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Data class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Data(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "numDim" == name)
    return new NumericDimension();
    
if( 80 == namespaceId && "strDim" == name)
    return new StringDimension();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
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
        return CloneImp<Data>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TextData Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:txData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;cx:f></description></item>
///<item><description>VXsdstring &lt;cx:v></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Formula),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(VXsdstring),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class TextData : OpenXmlCompositeElement
{
    private const string tagName = "txData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13459;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TextData class.
    /// </summary>
    public TextData():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TextData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "f" == name)
    return new Formula();
    
if( 80 == namespaceId && "v" == name)
    return new VXsdstring();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TextData>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RichTextBody Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:rich.</para>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RichTextBody : TextBodyType
{
    private const string tagName = "rich";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13460;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the RichTextBody class.
    /// </summary>
    public RichTextBody():base(){}
            /// <summary>
    ///Initializes a new instance of the RichTextBody class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RichTextBody(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RichTextBody class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RichTextBody(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RichTextBody class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RichTextBody(string outerXml)
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
        return CloneImp<RichTextBody>(deep);
    }

}
/// <summary>
/// <para>Defines the TxPrTextBody Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:txPr.</para>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class TxPrTextBody : TextBodyType
{
    private const string tagName = "txPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13463;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the TxPrTextBody class.
    /// </summary>
    public TxPrTextBody():base(){}
            /// <summary>
    ///Initializes a new instance of the TxPrTextBody class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TxPrTextBody(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TxPrTextBody class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TxPrTextBody(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TxPrTextBody class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TxPrTextBody(string outerXml)
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
        return CloneImp<TxPrTextBody>(deep);
    }

}
/// <summary>
/// Defines the TextBodyType class.
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
public abstract partial class TextBodyType : OpenXmlCompositeElement
{
        
    
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
    /// Initializes a new instance of the TextBodyType class.
    /// </summary>
    protected TextBodyType(){}
    
            /// <summary>
    ///Initializes a new instance of the TextBodyType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected TextBodyType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextBodyType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected TextBodyType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextBodyType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected TextBodyType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the Text Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:tx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TextData &lt;cx:txData></description></item>
///<item><description>RichTextBody &lt;cx:rich></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TextData),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(RichTextBody),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Text : OpenXmlCompositeElement
{
    private const string tagName = "tx";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13461;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Text class.
    /// </summary>
    public Text():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Text class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Text(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Text class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Text(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Text class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Text(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "txData" == name)
    return new TextData();
    
if( 80 == namespaceId && "rich" == name)
    return new RichTextBody();
    

    return null;
}

        private static readonly string[] eleTagNames = { "txData","rich" };
    private static readonly byte[] eleNamespaceIds = { 80,80 };
    
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
    /// <para> TextData.</para>
    /// <para> Represents the following element tag in the schema: cx:txData </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public TextData TextData
    {
        get 
        {
            return GetElement<TextData>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> RichTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:rich </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public RichTextBody RichTextBody
    {
        get 
        {
            return GetElement<RichTextBody>(1);
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
        return CloneImp<Text>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ShapeProperties Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:spPr.</para>
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
[OfficeAvailability(FileFormatVersions.Office2016)]
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
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13462;
    
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
		if((8 & (int)version) > 0)
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
/// <para>Defines the AxisUnitsLabel Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:unitsLabel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Text &lt;cx:tx></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Text),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(TxPrTextBody),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class AxisUnitsLabel : OpenXmlCompositeElement
{
    private const string tagName = "unitsLabel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13464;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AxisUnitsLabel class.
    /// </summary>
    public AxisUnitsLabel():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AxisUnitsLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisUnitsLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisUnitsLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisUnitsLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisUnitsLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AxisUnitsLabel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "tx" == name)
    return new Text();
    
if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "txPr" == name)
    return new TxPrTextBody();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "tx","spPr","txPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80 };
    
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
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: cx:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public Text Text
    {
        get 
        {
            return GetElement<Text>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public TxPrTextBody TxPrTextBody
    {
        get 
        {
            return GetElement<TxPrTextBody>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(3);
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
        return CloneImp<AxisUnitsLabel>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CategoryAxisScaling Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:catScaling.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class CategoryAxisScaling : OpenXmlLeafElement
{
    private const string tagName = "catScaling";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13465;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "gapWidth" };
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
    /// <para> gapWidth.</para>
    /// <para>Represents the following attribute in the schema: gapWidth </para>
    /// </summary>
    [SchemaAttr(0, "gapWidth")]
    public StringValue GapWidth
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CategoryAxisScaling class.
    /// </summary>
    public CategoryAxisScaling():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "gapWidth" == name)
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
        return CloneImp<CategoryAxisScaling>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ValueAxisScaling Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:valScaling.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ValueAxisScaling : OpenXmlLeafElement
{
    private const string tagName = "valScaling";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13466;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "max","min","majorUnit","minorUnit" };
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
    /// <para> max.</para>
    /// <para>Represents the following attribute in the schema: max </para>
    /// </summary>
    [SchemaAttr(0, "max")]
    public StringValue Max
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> min.</para>
    /// <para>Represents the following attribute in the schema: min </para>
    /// </summary>
    [SchemaAttr(0, "min")]
    public StringValue Min
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> majorUnit.</para>
    /// <para>Represents the following attribute in the schema: majorUnit </para>
    /// </summary>
    [SchemaAttr(0, "majorUnit")]
    public StringValue MajorUnit
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> minorUnit.</para>
    /// <para>Represents the following attribute in the schema: minorUnit </para>
    /// </summary>
    [SchemaAttr(0, "minorUnit")]
    public StringValue MinorUnit
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ValueAxisScaling class.
    /// </summary>
    public ValueAxisScaling():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "max" == name)
    return new StringValue();
    
if( 0 == namespaceId && "min" == name)
    return new StringValue();
    
if( 0 == namespaceId && "majorUnit" == name)
    return new StringValue();
    
if( 0 == namespaceId && "minorUnit" == name)
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
        return CloneImp<ValueAxisScaling>(deep);
    }

   
}
/// <summary>
/// <para>Defines the AxisTitle Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:title.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Text &lt;cx:tx></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Text),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(TxPrTextBody),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class AxisTitle : OpenXmlCompositeElement
{
    private const string tagName = "title";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13467;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AxisTitle class.
    /// </summary>
    public AxisTitle():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AxisTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AxisTitle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "tx" == name)
    return new Text();
    
if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "txPr" == name)
    return new TxPrTextBody();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "tx","spPr","txPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80 };
    
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
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: cx:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public Text Text
    {
        get 
        {
            return GetElement<Text>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public TxPrTextBody TxPrTextBody
    {
        get 
        {
            return GetElement<TxPrTextBody>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(3);
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
        return CloneImp<AxisTitle>(deep);
    }

   
}
/// <summary>
/// <para>Defines the AxisUnits Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:units.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AxisUnitsLabel &lt;cx:unitsLabel></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AxisUnitsLabel),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class AxisUnits : OpenXmlCompositeElement
{
    private const string tagName = "units";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13468;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "unit" };
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
    /// <para> unit.</para>
    /// <para>Represents the following attribute in the schema: unit </para>
    /// </summary>
    [SchemaAttr(0, "unit")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit> Unit
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the AxisUnits class.
    /// </summary>
    public AxisUnits():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AxisUnits class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisUnits(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisUnits class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AxisUnits(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisUnits class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AxisUnits(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "unitsLabel" == name)
    return new AxisUnitsLabel();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "unitsLabel","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80 };
    
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
    /// <para> AxisUnitsLabel.</para>
    /// <para> Represents the following element tag in the schema: cx:unitsLabel </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public AxisUnitsLabel AxisUnitsLabel
    {
        get 
        {
            return GetElement<AxisUnitsLabel>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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
    if( 0 == namespaceId && "unit" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AxisUnits>(deep);
    }

   
}
/// <summary>
/// <para>Defines the MajorGridlinesGridlines Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:majorGridlines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MajorGridlinesGridlines : OpenXmlGridlinesElement
{
    private const string tagName = "majorGridlines";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13469;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the MajorGridlinesGridlines class.
    /// </summary>
    public MajorGridlinesGridlines():base(){}
            /// <summary>
    ///Initializes a new instance of the MajorGridlinesGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MajorGridlinesGridlines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MajorGridlinesGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MajorGridlinesGridlines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MajorGridlinesGridlines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MajorGridlinesGridlines(string outerXml)
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
        return CloneImp<MajorGridlinesGridlines>(deep);
    }

}
/// <summary>
/// <para>Defines the MinorGridlinesGridlines Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:minorGridlines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MinorGridlinesGridlines : OpenXmlGridlinesElement
{
    private const string tagName = "minorGridlines";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13470;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the MinorGridlinesGridlines class.
    /// </summary>
    public MinorGridlinesGridlines():base(){}
            /// <summary>
    ///Initializes a new instance of the MinorGridlinesGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MinorGridlinesGridlines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MinorGridlinesGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MinorGridlinesGridlines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MinorGridlinesGridlines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MinorGridlinesGridlines(string outerXml)
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
        return CloneImp<MinorGridlinesGridlines>(deep);
    }

}
/// <summary>
/// Defines the OpenXmlGridlinesElement class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OpenXmlGridlinesElement : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "spPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80 };
    
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
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get 
        {
            return GetElement<ShapeProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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


    
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlGridlinesElement class.
    /// </summary>
    protected OpenXmlGridlinesElement(){}
    
            /// <summary>
    ///Initializes a new instance of the OpenXmlGridlinesElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlGridlinesElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlGridlinesElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlGridlinesElement(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlGridlinesElement class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected OpenXmlGridlinesElement(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the MajorTickMarksTickMarks Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:majorTickMarks.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MajorTickMarksTickMarks : OpenXmlTickMarksElement
{
    private const string tagName = "majorTickMarks";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13471;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the MajorTickMarksTickMarks class.
    /// </summary>
    public MajorTickMarksTickMarks():base(){}
            /// <summary>
    ///Initializes a new instance of the MajorTickMarksTickMarks class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MajorTickMarksTickMarks(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MajorTickMarksTickMarks class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MajorTickMarksTickMarks(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MajorTickMarksTickMarks class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MajorTickMarksTickMarks(string outerXml)
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
        return CloneImp<MajorTickMarksTickMarks>(deep);
    }

}
/// <summary>
/// <para>Defines the MinorTickMarksTickMarks Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:minorTickMarks.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MinorTickMarksTickMarks : OpenXmlTickMarksElement
{
    private const string tagName = "minorTickMarks";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13472;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the MinorTickMarksTickMarks class.
    /// </summary>
    public MinorTickMarksTickMarks():base(){}
            /// <summary>
    ///Initializes a new instance of the MinorTickMarksTickMarks class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MinorTickMarksTickMarks(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MinorTickMarksTickMarks class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MinorTickMarksTickMarks(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MinorTickMarksTickMarks class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MinorTickMarksTickMarks(string outerXml)
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
        return CloneImp<MinorTickMarksTickMarks>(deep);
    }

}
/// <summary>
/// Defines the OpenXmlTickMarksElement class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OpenXmlTickMarksElement : OpenXmlCompositeElement
{
    private static string[] attributeTagNames = { "type" };
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
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 80 };
    
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
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the OpenXmlTickMarksElement class.
    /// </summary>
    protected OpenXmlTickMarksElement(){}
    
            /// <summary>
    ///Initializes a new instance of the OpenXmlTickMarksElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlTickMarksElement(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlTickMarksElement class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OpenXmlTickMarksElement(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlTickMarksElement class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected OpenXmlTickMarksElement(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the TickLabels Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:tickLabels.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class TickLabels : OpenXmlCompositeElement
{
    private const string tagName = "tickLabels";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13473;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TickLabels class.
    /// </summary>
    public TickLabels():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TickLabels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TickLabels(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TickLabels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TickLabels(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TickLabels class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TickLabels(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 80 };
    
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
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TickLabels>(deep);
    }

   
}
/// <summary>
/// <para>Defines the NumberFormat Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:numFmt.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class NumberFormat : OpenXmlLeafElement
{
    private const string tagName = "numFmt";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13474;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "formatCode","sourceLinked" };
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
    /// <para> formatCode.</para>
    /// <para>Represents the following attribute in the schema: formatCode </para>
    /// </summary>
    [SchemaAttr(0, "formatCode")]
    public StringValue FormatCode
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> sourceLinked.</para>
    /// <para>Represents the following attribute in the schema: sourceLinked </para>
    /// </summary>
    [SchemaAttr(0, "sourceLinked")]
    public BooleanValue SourceLinked
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NumberFormat class.
    /// </summary>
    public NumberFormat():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "formatCode" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sourceLinked" == name)
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
        return CloneImp<NumberFormat>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Xsddouble Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:binSize.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Xsddouble : OpenXmlLeafTextElement
{
    private const string tagName = "binSize";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13475;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Xsddouble class.
    /// </summary>
    public Xsddouble():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the Xsddouble class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Xsddouble(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new DoubleValue(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Xsddouble>(deep);
    }

   
}
/// <summary>
/// <para>Defines the XsdunsignedInt Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:binCount.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class XsdunsignedInt : OpenXmlLeafTextElement
{
    private const string tagName = "binCount";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13476;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the XsdunsignedInt class.
    /// </summary>
    public XsdunsignedInt():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the XsdunsignedInt class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public XsdunsignedInt(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new UInt32Value(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<XsdunsignedInt>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Idx Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:idx.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Idx : OpenXmlLeafTextElement
{
    private const string tagName = "idx";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13477;
    
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
		if((8 & (int)version) > 0)
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
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Idx class.
    /// </summary>
    public Idx():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the Idx class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Idx(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
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
        return CloneImp<Idx>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ParentLabelLayout Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:parentLabelLayout.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ParentLabelLayout : OpenXmlLeafElement
{
    private const string tagName = "parentLabelLayout";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13478;
    
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
		if((8 & (int)version) > 0)
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
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal> ParentLabelLayoutVal
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ParentLabelLayout class.
    /// </summary>
    public ParentLabelLayout():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ParentLabelLayout>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SeriesElementVisibilities Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:visibility.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class SeriesElementVisibilities : OpenXmlLeafElement
{
    private const string tagName = "visibility";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13479;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "connectorLines","meanLine","meanMarker","nonoutliers","outliers" };
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
    /// <para> connectorLines.</para>
    /// <para>Represents the following attribute in the schema: connectorLines </para>
    /// </summary>
    [SchemaAttr(0, "connectorLines")]
    public BooleanValue ConnectorLines
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> meanLine.</para>
    /// <para>Represents the following attribute in the schema: meanLine </para>
    /// </summary>
    [SchemaAttr(0, "meanLine")]
    public BooleanValue MeanLine
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> meanMarker.</para>
    /// <para>Represents the following attribute in the schema: meanMarker </para>
    /// </summary>
    [SchemaAttr(0, "meanMarker")]
    public BooleanValue MeanMarker
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> nonoutliers.</para>
    /// <para>Represents the following attribute in the schema: nonoutliers </para>
    /// </summary>
    [SchemaAttr(0, "nonoutliers")]
    public BooleanValue Nonoutliers
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> outliers.</para>
    /// <para>Represents the following attribute in the schema: outliers </para>
    /// </summary>
    [SchemaAttr(0, "outliers")]
    public BooleanValue Outliers
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SeriesElementVisibilities class.
    /// </summary>
    public SeriesElementVisibilities():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "connectorLines" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "meanLine" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "meanMarker" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "nonoutliers" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "outliers" == name)
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
        return CloneImp<SeriesElementVisibilities>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Aggregation Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:aggregation.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Aggregation : OpenXmlLeafElement
{
    private const string tagName = "aggregation";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13480;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Aggregation class.
    /// </summary>
    public Aggregation():base(){}
    
      
     
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Aggregation>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Binning Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:binning.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Xsddouble &lt;cx:binSize></description></item>
///<item><description>XsdunsignedInt &lt;cx:binCount></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Xsddouble),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(XsdunsignedInt),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Binning : OpenXmlCompositeElement
{
    private const string tagName = "binning";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13481;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "intervalClosed","underflow","overflow" };
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
    /// <para> intervalClosed.</para>
    /// <para>Represents the following attribute in the schema: intervalClosed </para>
    /// </summary>
    [SchemaAttr(0, "intervalClosed")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide> IntervalClosed
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> underflow.</para>
    /// <para>Represents the following attribute in the schema: underflow </para>
    /// </summary>
    [SchemaAttr(0, "underflow")]
    public StringValue Underflow
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> overflow.</para>
    /// <para>Represents the following attribute in the schema: overflow </para>
    /// </summary>
    [SchemaAttr(0, "overflow")]
    public StringValue Overflow
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Binning class.
    /// </summary>
    public Binning():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Binning class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Binning(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Binning class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Binning(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Binning class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Binning(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "binSize" == name)
    return new Xsddouble();
    
if( 80 == namespaceId && "binCount" == name)
    return new XsdunsignedInt();
    

    return null;
}

        private static readonly string[] eleTagNames = { "binSize","binCount" };
    private static readonly byte[] eleNamespaceIds = { 80,80 };
    
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
    /// <para> Xsddouble.</para>
    /// <para> Represents the following element tag in the schema: cx:binSize </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public Xsddouble Xsddouble
    {
        get 
        {
            return GetElement<Xsddouble>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> XsdunsignedInt.</para>
    /// <para> Represents the following element tag in the schema: cx:binCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public XsdunsignedInt XsdunsignedInt
    {
        get 
        {
            return GetElement<XsdunsignedInt>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "intervalClosed" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.IntervalClosedSide>();
    
if( 0 == namespaceId && "underflow" == name)
    return new StringValue();
    
if( 0 == namespaceId && "overflow" == name)
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
        return CloneImp<Binning>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Statistics Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:statistics.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Statistics : OpenXmlLeafElement
{
    private const string tagName = "statistics";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13482;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "quartileMethod" };
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
    /// <para> quartileMethod.</para>
    /// <para>Represents the following attribute in the schema: quartileMethod </para>
    /// </summary>
    [SchemaAttr(0, "quartileMethod")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod> QuartileMethod
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Statistics class.
    /// </summary>
    public Statistics():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "quartileMethod" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Statistics>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Subtotals Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:subtotals.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Idx &lt;cx:idx></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Idx),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Subtotals : OpenXmlCompositeElement
{
    private const string tagName = "subtotals";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13483;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Subtotals class.
    /// </summary>
    public Subtotals():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Subtotals class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Subtotals(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Subtotals class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Subtotals(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Subtotals class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Subtotals(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "idx" == name)
    return new Idx();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Subtotals>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataLabelVisibilities Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:visibility.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DataLabelVisibilities : OpenXmlLeafElement
{
    private const string tagName = "visibility";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13484;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "seriesName","categoryName","value" };
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
    /// <para> seriesName.</para>
    /// <para>Represents the following attribute in the schema: seriesName </para>
    /// </summary>
    [SchemaAttr(0, "seriesName")]
    public BooleanValue SeriesName
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> categoryName.</para>
    /// <para>Represents the following attribute in the schema: categoryName </para>
    /// </summary>
    [SchemaAttr(0, "categoryName")]
    public BooleanValue CategoryName
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    public BooleanValue Value
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataLabelVisibilities class.
    /// </summary>
    public DataLabelVisibilities():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "seriesName" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "categoryName" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "value" == name)
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
        return CloneImp<DataLabelVisibilities>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SeparatorXsdstring Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:separator.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class SeparatorXsdstring : OpenXmlLeafTextElement
{
    private const string tagName = "separator";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13485;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the SeparatorXsdstring class.
    /// </summary>
    public SeparatorXsdstring():base(){}
    
           /// <summary>
    /// Initializes a new instance of the SeparatorXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public SeparatorXsdstring(string text):base(text)
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
        return CloneImp<SeparatorXsdstring>(deep);
    }

}
/// <summary>
/// <para>Defines the OddHeaderXsdstring Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:oddHeader.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class OddHeaderXsdstring : OpenXmlLeafTextElement
{
    private const string tagName = "oddHeader";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13500;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the OddHeaderXsdstring class.
    /// </summary>
    public OddHeaderXsdstring():base(){}
    
           /// <summary>
    /// Initializes a new instance of the OddHeaderXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public OddHeaderXsdstring(string text):base(text)
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
        return CloneImp<OddHeaderXsdstring>(deep);
    }

}
/// <summary>
/// <para>Defines the OddFooterXsdstring Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:oddFooter.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class OddFooterXsdstring : OpenXmlLeafTextElement
{
    private const string tagName = "oddFooter";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13501;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the OddFooterXsdstring class.
    /// </summary>
    public OddFooterXsdstring():base(){}
    
           /// <summary>
    /// Initializes a new instance of the OddFooterXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public OddFooterXsdstring(string text):base(text)
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
        return CloneImp<OddFooterXsdstring>(deep);
    }

}
/// <summary>
/// <para>Defines the EvenHeaderXsdstring Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:evenHeader.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class EvenHeaderXsdstring : OpenXmlLeafTextElement
{
    private const string tagName = "evenHeader";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13502;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the EvenHeaderXsdstring class.
    /// </summary>
    public EvenHeaderXsdstring():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EvenHeaderXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EvenHeaderXsdstring(string text):base(text)
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
        return CloneImp<EvenHeaderXsdstring>(deep);
    }

}
/// <summary>
/// <para>Defines the EvenFooterXsdstring Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:evenFooter.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class EvenFooterXsdstring : OpenXmlLeafTextElement
{
    private const string tagName = "evenFooter";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13503;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the EvenFooterXsdstring class.
    /// </summary>
    public EvenFooterXsdstring():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EvenFooterXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EvenFooterXsdstring(string text):base(text)
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
        return CloneImp<EvenFooterXsdstring>(deep);
    }

}
/// <summary>
/// <para>Defines the FirstHeaderXsdstring Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:firstHeader.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FirstHeaderXsdstring : OpenXmlLeafTextElement
{
    private const string tagName = "firstHeader";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13504;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the FirstHeaderXsdstring class.
    /// </summary>
    public FirstHeaderXsdstring():base(){}
    
           /// <summary>
    /// Initializes a new instance of the FirstHeaderXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FirstHeaderXsdstring(string text):base(text)
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
        return CloneImp<FirstHeaderXsdstring>(deep);
    }

}
/// <summary>
/// <para>Defines the FirstFooterXsdstring Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:firstFooter.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class FirstFooterXsdstring : OpenXmlLeafTextElement
{
    private const string tagName = "firstFooter";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13505;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the FirstFooterXsdstring class.
    /// </summary>
    public FirstFooterXsdstring():base(){}
    
           /// <summary>
    /// Initializes a new instance of the FirstFooterXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FirstFooterXsdstring(string text):base(text)
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
        return CloneImp<FirstFooterXsdstring>(deep);
    }

}
/// <summary>
/// <para>Cached text.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:v.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class VXsdstring : OpenXmlLeafTextElement
{
    private const string tagName = "v";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13516;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VXsdstring class.
    /// </summary>
    public VXsdstring():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VXsdstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VXsdstring(string text):base(text)
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
        return CloneImp<VXsdstring>(deep);
    }

}
/// <summary>
/// <para>Defines the DataLabel Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:dataLabel.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberFormat &lt;cx:numFmt></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>DataLabelVisibilities &lt;cx:visibility></description></item>
///<item><description>SeparatorXsdstring &lt;cx:separator></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(NumberFormat),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(TxPrTextBody),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(DataLabelVisibilities),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(SeparatorXsdstring),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DataLabel : OpenXmlCompositeElement
{
    private const string tagName = "dataLabel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13486;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "idx","pos" };
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
    /// <para> idx.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    public UInt32Value Idx
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> pos.</para>
    /// <para>Represents the following attribute in the schema: pos </para>
    /// </summary>
    [SchemaAttr(0, "pos")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos> Pos
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataLabel class.
    /// </summary>
    public DataLabel():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "numFmt" == name)
    return new NumberFormat();
    
if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "txPr" == name)
    return new TxPrTextBody();
    
if( 80 == namespaceId && "visibility" == name)
    return new DataLabelVisibilities();
    
if( 80 == namespaceId && "separator" == name)
    return new SeparatorXsdstring();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "numFmt","spPr","txPr","visibility","separator","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80,80,80 };
    
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
    /// <para> NumberFormat.</para>
    /// <para> Represents the following element tag in the schema: cx:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public NumberFormat NumberFormat
    {
        get 
        {
            return GetElement<NumberFormat>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public TxPrTextBody TxPrTextBody
    {
        get 
        {
            return GetElement<TxPrTextBody>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> DataLabelVisibilities.</para>
    /// <para> Represents the following element tag in the schema: cx:visibility </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public DataLabelVisibilities DataLabelVisibilities
    {
        get 
        {
            return GetElement<DataLabelVisibilities>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> SeparatorXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:separator </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public SeparatorXsdstring SeparatorXsdstring
    {
        get 
        {
            return GetElement<SeparatorXsdstring>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "idx" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "pos" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DataLabel>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataLabelHidden Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:dataLabelHidden.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DataLabelHidden : OpenXmlLeafElement
{
    private const string tagName = "dataLabelHidden";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13487;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "idx" };
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
    /// <para> idx.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    public UInt32Value Idx
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataLabelHidden class.
    /// </summary>
    public DataLabelHidden():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "idx" == name)
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
        return CloneImp<DataLabelHidden>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataPoint Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:dataPt.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DataPoint : OpenXmlCompositeElement
{
    private const string tagName = "dataPt";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13488;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "idx" };
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
    /// <para> idx.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    public UInt32Value Idx
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataPoint class.
    /// </summary>
    public DataPoint():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPoint(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataPoint(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataPoint class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataPoint(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "spPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80 };
    
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
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get 
        {
            return GetElement<ShapeProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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
    if( 0 == namespaceId && "idx" == name)
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
        return CloneImp<DataPoint>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataLabels Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:dataLabels.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberFormat &lt;cx:numFmt></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>DataLabelVisibilities &lt;cx:visibility></description></item>
///<item><description>SeparatorXsdstring &lt;cx:separator></description></item>
///<item><description>DataLabel &lt;cx:dataLabel></description></item>
///<item><description>DataLabelHidden &lt;cx:dataLabelHidden></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(NumberFormat),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(TxPrTextBody),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(DataLabelVisibilities),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(SeparatorXsdstring),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(DataLabel),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(DataLabelHidden),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DataLabels : OpenXmlCompositeElement
{
    private const string tagName = "dataLabels";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13489;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "pos" };
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
    /// <para> pos.</para>
    /// <para>Represents the following attribute in the schema: pos </para>
    /// </summary>
    [SchemaAttr(0, "pos")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos> Pos
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataLabels class.
    /// </summary>
    public DataLabels():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DataLabels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabels(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataLabels(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataLabels class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataLabels(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "numFmt" == name)
    return new NumberFormat();
    
if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "txPr" == name)
    return new TxPrTextBody();
    
if( 80 == namespaceId && "visibility" == name)
    return new DataLabelVisibilities();
    
if( 80 == namespaceId && "separator" == name)
    return new SeparatorXsdstring();
    
if( 80 == namespaceId && "dataLabel" == name)
    return new DataLabel();
    
if( 80 == namespaceId && "dataLabelHidden" == name)
    return new DataLabelHidden();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "numFmt","spPr","txPr","visibility","separator","dataLabel","dataLabelHidden","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80,80,80,80,80 };
    
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
    /// <para> NumberFormat.</para>
    /// <para> Represents the following element tag in the schema: cx:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public NumberFormat NumberFormat
    {
        get 
        {
            return GetElement<NumberFormat>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public TxPrTextBody TxPrTextBody
    {
        get 
        {
            return GetElement<TxPrTextBody>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> DataLabelVisibilities.</para>
    /// <para> Represents the following element tag in the schema: cx:visibility </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public DataLabelVisibilities DataLabelVisibilities
    {
        get 
        {
            return GetElement<DataLabelVisibilities>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> SeparatorXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:separator </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public SeparatorXsdstring SeparatorXsdstring
    {
        get 
        {
            return GetElement<SeparatorXsdstring>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "pos" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DataLabels>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DataId Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:dataId.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DataId : OpenXmlLeafElement
{
    private const string tagName = "dataId";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13490;
    
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
		if((8 & (int)version) > 0)
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
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataId class.
    /// </summary>
    public DataId():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
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
        return CloneImp<DataId>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SeriesLayoutProperties Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:layoutPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ParentLabelLayout &lt;cx:parentLabelLayout></description></item>
///<item><description>SeriesElementVisibilities &lt;cx:visibility></description></item>
///<item><description>Aggregation &lt;cx:aggregation></description></item>
///<item><description>Binning &lt;cx:binning></description></item>
///<item><description>Statistics &lt;cx:statistics></description></item>
///<item><description>Subtotals &lt;cx:subtotals></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ParentLabelLayout),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(SeriesElementVisibilities),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Aggregation),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Binning),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Statistics),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Subtotals),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class SeriesLayoutProperties : OpenXmlCompositeElement
{
    private const string tagName = "layoutPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13491;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SeriesLayoutProperties class.
    /// </summary>
    public SeriesLayoutProperties():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SeriesLayoutProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesLayoutProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesLayoutProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesLayoutProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesLayoutProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SeriesLayoutProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "parentLabelLayout" == name)
    return new ParentLabelLayout();
    
if( 80 == namespaceId && "visibility" == name)
    return new SeriesElementVisibilities();
    
if( 80 == namespaceId && "aggregation" == name)
    return new Aggregation();
    
if( 80 == namespaceId && "binning" == name)
    return new Binning();
    
if( 80 == namespaceId && "statistics" == name)
    return new Statistics();
    
if( 80 == namespaceId && "subtotals" == name)
    return new Subtotals();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "parentLabelLayout","visibility","aggregation","binning","statistics","subtotals","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80,80,80,80 };
    
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
    /// <para> ParentLabelLayout.</para>
    /// <para> Represents the following element tag in the schema: cx:parentLabelLayout </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ParentLabelLayout ParentLabelLayout
    {
        get 
        {
            return GetElement<ParentLabelLayout>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> SeriesElementVisibilities.</para>
    /// <para> Represents the following element tag in the schema: cx:visibility </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public SeriesElementVisibilities SeriesElementVisibilities
    {
        get 
        {
            return GetElement<SeriesElementVisibilities>(1);
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
        return CloneImp<SeriesLayoutProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the AxisId Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:axisId.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class AxisId : OpenXmlLeafTextElement
{
    private const string tagName = "axisId";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13492;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AxisId class.
    /// </summary>
    public AxisId():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the AxisId class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public AxisId(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new UInt32Value(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AxisId>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PlotSurface Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:plotSurface.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class PlotSurface : OpenXmlCompositeElement
{
    private const string tagName = "plotSurface";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13493;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PlotSurface class.
    /// </summary>
    public PlotSurface():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PlotSurface class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotSurface(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PlotSurface class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotSurface(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PlotSurface class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PlotSurface(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "spPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80 };
    
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
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get 
        {
            return GetElement<ShapeProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PlotSurface>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Series Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:series.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Text &lt;cx:tx></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>DataPoint &lt;cx:dataPt></description></item>
///<item><description>DataLabels &lt;cx:dataLabels></description></item>
///<item><description>DataId &lt;cx:dataId></description></item>
///<item><description>SeriesLayoutProperties &lt;cx:layoutPr></description></item>
///<item><description>AxisId &lt;cx:axisId></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Text),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(DataPoint),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(DataLabels),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(DataId),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(SeriesLayoutProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(AxisId),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Series : OpenXmlCompositeElement
{
    private const string tagName = "series";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13494;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "layoutId","hidden","ownerIdx","uniqueId","formatIdx" };
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
    /// <para> layoutId.</para>
    /// <para>Represents the following attribute in the schema: layoutId </para>
    /// </summary>
    [SchemaAttr(0, "layoutId")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout> LayoutId
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> ownerIdx.</para>
    /// <para>Represents the following attribute in the schema: ownerIdx </para>
    /// </summary>
    [SchemaAttr(0, "ownerIdx")]
    public UInt32Value OwnerIdx
    {
        get { return (UInt32Value)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> uniqueId.</para>
    /// <para>Represents the following attribute in the schema: uniqueId </para>
    /// </summary>
    [SchemaAttr(0, "uniqueId")]
    public StringValue UniqueId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> formatIdx.</para>
    /// <para>Represents the following attribute in the schema: formatIdx </para>
    /// </summary>
    [SchemaAttr(0, "formatIdx")]
    public UInt32Value FormatIdx
    {
        get { return (UInt32Value)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Series class.
    /// </summary>
    public Series():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Series class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Series(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Series class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Series(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Series class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Series(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "tx" == name)
    return new Text();
    
if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "dataPt" == name)
    return new DataPoint();
    
if( 80 == namespaceId && "dataLabels" == name)
    return new DataLabels();
    
if( 80 == namespaceId && "dataId" == name)
    return new DataId();
    
if( 80 == namespaceId && "layoutPr" == name)
    return new SeriesLayoutProperties();
    
if( 80 == namespaceId && "axisId" == name)
    return new AxisId();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "tx","spPr","dataPt","dataLabels","dataId","layoutPr","axisId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80,80,80,80,80 };
    
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
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: cx:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public Text Text
    {
        get 
        {
            return GetElement<Text>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "layoutId" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout>();
    
if( 0 == namespaceId && "hidden" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "ownerIdx" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "uniqueId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "formatIdx" == name)
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
        return CloneImp<Series>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PlotAreaRegion Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:plotAreaRegion.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PlotSurface &lt;cx:plotSurface></description></item>
///<item><description>Series &lt;cx:series></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PlotSurface),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Series),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class PlotAreaRegion : OpenXmlCompositeElement
{
    private const string tagName = "plotAreaRegion";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13495;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PlotAreaRegion class.
    /// </summary>
    public PlotAreaRegion():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PlotAreaRegion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotAreaRegion(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PlotAreaRegion class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotAreaRegion(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PlotAreaRegion class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PlotAreaRegion(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "plotSurface" == name)
    return new PlotSurface();
    
if( 80 == namespaceId && "series" == name)
    return new Series();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "plotSurface","series","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80 };
    
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
    /// <para> PlotSurface.</para>
    /// <para> Represents the following element tag in the schema: cx:plotSurface </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public PlotSurface PlotSurface
    {
        get 
        {
            return GetElement<PlotSurface>(0);
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
        return CloneImp<PlotAreaRegion>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Axis Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:axis.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CategoryAxisScaling &lt;cx:catScaling></description></item>
///<item><description>ValueAxisScaling &lt;cx:valScaling></description></item>
///<item><description>AxisTitle &lt;cx:title></description></item>
///<item><description>AxisUnits &lt;cx:units></description></item>
///<item><description>MajorGridlinesGridlines &lt;cx:majorGridlines></description></item>
///<item><description>MinorGridlinesGridlines &lt;cx:minorGridlines></description></item>
///<item><description>MajorTickMarksTickMarks &lt;cx:majorTickMarks></description></item>
///<item><description>MinorTickMarksTickMarks &lt;cx:minorTickMarks></description></item>
///<item><description>TickLabels &lt;cx:tickLabels></description></item>
///<item><description>NumberFormat &lt;cx:numFmt></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(CategoryAxisScaling),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ValueAxisScaling),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(AxisTitle),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(AxisUnits),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(MajorGridlinesGridlines),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(MinorGridlinesGridlines),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(MajorTickMarksTickMarks),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(MinorTickMarksTickMarks),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(TickLabels),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(NumberFormat),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(TxPrTextBody),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Axis : OpenXmlCompositeElement
{
    private const string tagName = "axis";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13496;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","hidden" };
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
    public UInt32Value Id
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Axis class.
    /// </summary>
    public Axis():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Axis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Axis(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Axis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Axis(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Axis class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Axis(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "catScaling" == name)
    return new CategoryAxisScaling();
    
if( 80 == namespaceId && "valScaling" == name)
    return new ValueAxisScaling();
    
if( 80 == namespaceId && "title" == name)
    return new AxisTitle();
    
if( 80 == namespaceId && "units" == name)
    return new AxisUnits();
    
if( 80 == namespaceId && "majorGridlines" == name)
    return new MajorGridlinesGridlines();
    
if( 80 == namespaceId && "minorGridlines" == name)
    return new MinorGridlinesGridlines();
    
if( 80 == namespaceId && "majorTickMarks" == name)
    return new MajorTickMarksTickMarks();
    
if( 80 == namespaceId && "minorTickMarks" == name)
    return new MinorTickMarksTickMarks();
    
if( 80 == namespaceId && "tickLabels" == name)
    return new TickLabels();
    
if( 80 == namespaceId && "numFmt" == name)
    return new NumberFormat();
    
if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "txPr" == name)
    return new TxPrTextBody();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "hidden" == name)
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
        return CloneImp<Axis>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ChartTitle Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:title.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Text &lt;cx:tx></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Text),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(TxPrTextBody),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ChartTitle : OpenXmlCompositeElement
{
    private const string tagName = "title";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13497;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "pos","align","overlay" };
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
    /// <para> pos.</para>
    /// <para>Represents the following attribute in the schema: pos </para>
    /// </summary>
    [SchemaAttr(0, "pos")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos> Pos
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> align.</para>
    /// <para>Represents the following attribute in the schema: align </para>
    /// </summary>
    [SchemaAttr(0, "align")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign> Align
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> overlay.</para>
    /// <para>Represents the following attribute in the schema: overlay </para>
    /// </summary>
    [SchemaAttr(0, "overlay")]
    public BooleanValue Overlay
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ChartTitle class.
    /// </summary>
    public ChartTitle():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ChartTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartTitle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "tx" == name)
    return new Text();
    
if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "txPr" == name)
    return new TxPrTextBody();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "tx","spPr","txPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80 };
    
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
    /// <para> Text.</para>
    /// <para> Represents the following element tag in the schema: cx:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public Text Text
    {
        get 
        {
            return GetElement<Text>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
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
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public TxPrTextBody TxPrTextBody
    {
        get 
        {
            return GetElement<TxPrTextBody>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "pos" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos>();
    
if( 0 == namespaceId && "align" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign>();
    
if( 0 == namespaceId && "overlay" == name)
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
        return CloneImp<ChartTitle>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PlotArea Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:plotArea.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PlotAreaRegion &lt;cx:plotAreaRegion></description></item>
///<item><description>Axis &lt;cx:axis></description></item>
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PlotAreaRegion),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Axis),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class PlotArea : OpenXmlCompositeElement
{
    private const string tagName = "plotArea";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13498;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PlotArea class.
    /// </summary>
    public PlotArea():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PlotArea class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotArea(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PlotArea class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PlotArea(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PlotArea class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PlotArea(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "plotAreaRegion" == name)
    return new PlotAreaRegion();
    
if( 80 == namespaceId && "axis" == name)
    return new Axis();
    
if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "plotAreaRegion","axis","spPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80 };
    
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
    /// <para> PlotAreaRegion.</para>
    /// <para> Represents the following element tag in the schema: cx:plotAreaRegion </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public PlotAreaRegion PlotAreaRegion
    {
        get 
        {
            return GetElement<PlotAreaRegion>(0);
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
        return CloneImp<PlotArea>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Legend Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:legend.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShapeProperties &lt;cx:spPr></description></item>
///<item><description>TxPrTextBody &lt;cx:txPr></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ShapeProperties),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(TxPrTextBody),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Legend : OpenXmlCompositeElement
{
    private const string tagName = "legend";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13499;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "pos","align","overlay" };
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
    /// <para> pos.</para>
    /// <para>Represents the following attribute in the schema: pos </para>
    /// </summary>
    [SchemaAttr(0, "pos")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos> Pos
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> align.</para>
    /// <para>Represents the following attribute in the schema: align </para>
    /// </summary>
    [SchemaAttr(0, "align")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign> Align
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> overlay.</para>
    /// <para>Represents the following attribute in the schema: overlay </para>
    /// </summary>
    [SchemaAttr(0, "overlay")]
    public BooleanValue Overlay
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Legend class.
    /// </summary>
    public Legend():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Legend class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Legend(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Legend class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Legend(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Legend class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Legend(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 80 == namespaceId && "txPr" == name)
    return new TxPrTextBody();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "spPr","txPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80 };
    
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
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: cx:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get 
        {
            return GetElement<ShapeProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> TxPrTextBody.</para>
    /// <para> Represents the following element tag in the schema: cx:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public TxPrTextBody TxPrTextBody
    {
        get 
        {
            return GetElement<TxPrTextBody>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "pos" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos>();
    
if( 0 == namespaceId && "align" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign>();
    
if( 0 == namespaceId && "overlay" == name)
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
        return CloneImp<Legend>(deep);
    }

   
}
/// <summary>
/// <para>Defines the HeaderFooter Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:headerFooter.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OddHeaderXsdstring &lt;cx:oddHeader></description></item>
///<item><description>OddFooterXsdstring &lt;cx:oddFooter></description></item>
///<item><description>EvenHeaderXsdstring &lt;cx:evenHeader></description></item>
///<item><description>EvenFooterXsdstring &lt;cx:evenFooter></description></item>
///<item><description>FirstHeaderXsdstring &lt;cx:firstHeader></description></item>
///<item><description>FirstFooterXsdstring &lt;cx:firstFooter></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(OddHeaderXsdstring),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(OddFooterXsdstring),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(EvenHeaderXsdstring),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(EvenFooterXsdstring),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(FirstHeaderXsdstring),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(FirstFooterXsdstring),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class HeaderFooter : OpenXmlCompositeElement
{
    private const string tagName = "headerFooter";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13506;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "alignWithMargins","differentOddEven","differentFirst" };
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
    /// <para> alignWithMargins.</para>
    /// <para>Represents the following attribute in the schema: alignWithMargins </para>
    /// </summary>
    [SchemaAttr(0, "alignWithMargins")]
    public BooleanValue AlignWithMargins
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> differentOddEven.</para>
    /// <para>Represents the following attribute in the schema: differentOddEven </para>
    /// </summary>
    [SchemaAttr(0, "differentOddEven")]
    public BooleanValue DifferentOddEven
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> differentFirst.</para>
    /// <para>Represents the following attribute in the schema: differentFirst </para>
    /// </summary>
    [SchemaAttr(0, "differentFirst")]
    public BooleanValue DifferentFirst
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the HeaderFooter class.
    /// </summary>
    public HeaderFooter():base(){}
    
            /// <summary>
    ///Initializes a new instance of the HeaderFooter class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HeaderFooter(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HeaderFooter class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HeaderFooter(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HeaderFooter class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HeaderFooter(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "oddHeader" == name)
    return new OddHeaderXsdstring();
    
if( 80 == namespaceId && "oddFooter" == name)
    return new OddFooterXsdstring();
    
if( 80 == namespaceId && "evenHeader" == name)
    return new EvenHeaderXsdstring();
    
if( 80 == namespaceId && "evenFooter" == name)
    return new EvenFooterXsdstring();
    
if( 80 == namespaceId && "firstHeader" == name)
    return new FirstHeaderXsdstring();
    
if( 80 == namespaceId && "firstFooter" == name)
    return new FirstFooterXsdstring();
    

    return null;
}

        private static readonly string[] eleTagNames = { "oddHeader","oddFooter","evenHeader","evenFooter","firstHeader","firstFooter" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80,80,80 };
    
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
    /// <para> OddHeaderXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:oddHeader </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public OddHeaderXsdstring OddHeaderXsdstring
    {
        get 
        {
            return GetElement<OddHeaderXsdstring>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> OddFooterXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:oddFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public OddFooterXsdstring OddFooterXsdstring
    {
        get 
        {
            return GetElement<OddFooterXsdstring>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> EvenHeaderXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:evenHeader </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public EvenHeaderXsdstring EvenHeaderXsdstring
    {
        get 
        {
            return GetElement<EvenHeaderXsdstring>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> EvenFooterXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:evenFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public EvenFooterXsdstring EvenFooterXsdstring
    {
        get 
        {
            return GetElement<EvenFooterXsdstring>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> FirstHeaderXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:firstHeader </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public FirstHeaderXsdstring FirstHeaderXsdstring
    {
        get 
        {
            return GetElement<FirstHeaderXsdstring>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> FirstFooterXsdstring.</para>
    /// <para> Represents the following element tag in the schema: cx:firstFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public FirstFooterXsdstring FirstFooterXsdstring
    {
        get 
        {
            return GetElement<FirstFooterXsdstring>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "alignWithMargins" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "differentOddEven" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "differentFirst" == name)
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
        return CloneImp<HeaderFooter>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PageMargins Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:pageMargins.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class PageMargins : OpenXmlLeafElement
{
    private const string tagName = "pageMargins";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13507;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "l","r","t","b","header","footer" };
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
    /// <para> l.</para>
    /// <para>Represents the following attribute in the schema: l </para>
    /// </summary>
    [SchemaAttr(0, "l")]
    public DoubleValue L
    {
        get { return (DoubleValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public DoubleValue R
    {
        get { return (DoubleValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public DoubleValue T
    {
        get { return (DoubleValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> b.</para>
    /// <para>Represents the following attribute in the schema: b </para>
    /// </summary>
    [SchemaAttr(0, "b")]
    public DoubleValue B
    {
        get { return (DoubleValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> header.</para>
    /// <para>Represents the following attribute in the schema: header </para>
    /// </summary>
    [SchemaAttr(0, "header")]
    public DoubleValue Header
    {
        get { return (DoubleValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> footer.</para>
    /// <para>Represents the following attribute in the schema: footer </para>
    /// </summary>
    [SchemaAttr(0, "footer")]
    public DoubleValue Footer
    {
        get { return (DoubleValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PageMargins class.
    /// </summary>
    public PageMargins():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "l" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "r" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "t" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "b" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "header" == name)
    return new DoubleValue();
    
if( 0 == namespaceId && "footer" == name)
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
        return CloneImp<PageMargins>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PageSetup Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:pageSetup.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class PageSetup : OpenXmlLeafElement
{
    private const string tagName = "pageSetup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13508;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "paperSize","firstPageNumber","orientation","blackAndWhite","draft","useFirstPageNumber","horizontalDpi","verticalDpi","copies" };
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
    /// <para> paperSize.</para>
    /// <para>Represents the following attribute in the schema: paperSize </para>
    /// </summary>
    [SchemaAttr(0, "paperSize")]
    public UInt32Value PaperSize
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> firstPageNumber.</para>
    /// <para>Represents the following attribute in the schema: firstPageNumber </para>
    /// </summary>
    [SchemaAttr(0, "firstPageNumber")]
    public UInt32Value FirstPageNumber
    {
        get { return (UInt32Value)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> orientation.</para>
    /// <para>Represents the following attribute in the schema: orientation </para>
    /// </summary>
    [SchemaAttr(0, "orientation")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation> Orientation
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> blackAndWhite.</para>
    /// <para>Represents the following attribute in the schema: blackAndWhite </para>
    /// </summary>
    [SchemaAttr(0, "blackAndWhite")]
    public BooleanValue BlackAndWhite
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> draft.</para>
    /// <para>Represents the following attribute in the schema: draft </para>
    /// </summary>
    [SchemaAttr(0, "draft")]
    public BooleanValue Draft
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> useFirstPageNumber.</para>
    /// <para>Represents the following attribute in the schema: useFirstPageNumber </para>
    /// </summary>
    [SchemaAttr(0, "useFirstPageNumber")]
    public BooleanValue UseFirstPageNumber
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> horizontalDpi.</para>
    /// <para>Represents the following attribute in the schema: horizontalDpi </para>
    /// </summary>
    [SchemaAttr(0, "horizontalDpi")]
    public Int32Value HorizontalDpi
    {
        get { return (Int32Value)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> verticalDpi.</para>
    /// <para>Represents the following attribute in the schema: verticalDpi </para>
    /// </summary>
    [SchemaAttr(0, "verticalDpi")]
    public Int32Value VerticalDpi
    {
        get { return (Int32Value)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> copies.</para>
    /// <para>Represents the following attribute in the schema: copies </para>
    /// </summary>
    [SchemaAttr(0, "copies")]
    public UInt32Value Copies
    {
        get { return (UInt32Value)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PageSetup class.
    /// </summary>
    public PageSetup():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "paperSize" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "firstPageNumber" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "orientation" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PageOrientation>();
    
if( 0 == namespaceId && "blackAndWhite" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "draft" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "useFirstPageNumber" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "horizontalDpi" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "verticalDpi" == name)
    return new Int32Value();
    
if( 0 == namespaceId && "copies" == name)
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
        return CloneImp<PageSetup>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ChartData Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:chartData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExternalData &lt;cx:externalData></description></item>
///<item><description>Data &lt;cx:data></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExternalData),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Data),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ChartData : OpenXmlCompositeElement
{
    private const string tagName = "chartData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13509;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ChartData class.
    /// </summary>
    public ChartData():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ChartData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "externalData" == name)
    return new ExternalData();
    
if( 80 == namespaceId && "data" == name)
    return new Data();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "externalData","data","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80 };
    
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
    /// <para> ExternalData.</para>
    /// <para> Represents the following element tag in the schema: cx:externalData </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ExternalData ExternalData
    {
        get 
        {
            return GetElement<ExternalData>(0);
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
        return CloneImp<ChartData>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Chart Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:chart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartTitle &lt;cx:title></description></item>
///<item><description>PlotArea &lt;cx:plotArea></description></item>
///<item><description>Legend &lt;cx:legend></description></item>
///<item><description>ExtensionList &lt;cx:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ChartTitle),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(PlotArea),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(Legend),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(ExtensionList),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Chart : OpenXmlCompositeElement
{
    private const string tagName = "chart";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13510;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Chart class.
    /// </summary>
    public Chart():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Chart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Chart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Chart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Chart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Chart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Chart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "title" == name)
    return new ChartTitle();
    
if( 80 == namespaceId && "plotArea" == name)
    return new PlotArea();
    
if( 80 == namespaceId && "legend" == name)
    return new Legend();
    
if( 80 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "title","plotArea","legend","extLst" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80,80 };
    
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
    /// <para> ChartTitle.</para>
    /// <para> Represents the following element tag in the schema: cx:title </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ChartTitle ChartTitle
    {
        get 
        {
            return GetElement<ChartTitle>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> PlotArea.</para>
    /// <para> Represents the following element tag in the schema: cx:plotArea </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public PlotArea PlotArea
    {
        get 
        {
            return GetElement<PlotArea>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Legend.</para>
    /// <para> Represents the following element tag in the schema: cx:legend </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public Legend Legend
    {
        get 
        {
            return GetElement<Legend>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: cx:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<ExtensionList>(3);
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
        return CloneImp<Chart>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ColorMappingType Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:clrMapOvr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ColorMappingType : OpenXmlCompositeElement
{
    private const string tagName = "clrMapOvr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13511;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "bg1","tx1","bg2","tx2","accent1","accent2","accent3","accent4","accent5","accent6","hlink","folHlink" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> Background 1.</para>
    /// <para>Represents the following attribute in the schema: bg1 </para>
    /// </summary>
    [SchemaAttr(0, "bg1")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background1
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> Text 1.</para>
    /// <para>Represents the following attribute in the schema: tx1 </para>
    /// </summary>
    [SchemaAttr(0, "tx1")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text1
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> Background 2.</para>
    /// <para>Represents the following attribute in the schema: bg2 </para>
    /// </summary>
    [SchemaAttr(0, "bg2")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background2
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> Text 2.</para>
    /// <para>Represents the following attribute in the schema: tx2 </para>
    /// </summary>
    [SchemaAttr(0, "tx2")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text2
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> Accent 1.</para>
    /// <para>Represents the following attribute in the schema: accent1 </para>
    /// </summary>
    [SchemaAttr(0, "accent1")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent1
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> Accent 2.</para>
    /// <para>Represents the following attribute in the schema: accent2 </para>
    /// </summary>
    [SchemaAttr(0, "accent2")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent2
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> Accent 3.</para>
    /// <para>Represents the following attribute in the schema: accent3 </para>
    /// </summary>
    [SchemaAttr(0, "accent3")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent3
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> Accent 4.</para>
    /// <para>Represents the following attribute in the schema: accent4 </para>
    /// </summary>
    [SchemaAttr(0, "accent4")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent4
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> Accent 5.</para>
    /// <para>Represents the following attribute in the schema: accent5 </para>
    /// </summary>
    [SchemaAttr(0, "accent5")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent5
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> Accent 6.</para>
    /// <para>Represents the following attribute in the schema: accent6 </para>
    /// </summary>
    [SchemaAttr(0, "accent6")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent6
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink.</para>
    /// <para>Represents the following attribute in the schema: hlink </para>
    /// </summary>
    [SchemaAttr(0, "hlink")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Hyperlink
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> Followed Hyperlink.</para>
    /// <para>Represents the following attribute in the schema: folHlink </para>
    /// </summary>
    [SchemaAttr(0, "folHlink")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> FollowedHyperlink
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColorMappingType class.
    /// </summary>
    public ColorMappingType():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ColorMappingType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorMappingType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorMappingType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorMappingType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorMappingType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorMappingType(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 10 };
    
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
    /// <para> Represents the following element tag in the schema: a:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "bg1" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "tx1" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "bg2" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "tx2" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "accent1" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "accent2" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "accent3" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "accent4" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "accent5" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "accent6" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "hlink" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    
if( 0 == namespaceId && "folHlink" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ColorMappingType>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PrintSettings Class.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:printSettings.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>HeaderFooter &lt;cx:headerFooter></description></item>
///<item><description>PageMargins &lt;cx:pageMargins></description></item>
///<item><description>PageSetup &lt;cx:pageSetup></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(HeaderFooter),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(PageMargins),(FileFormatVersions)8)]
    [ChildElementInfo(typeof(PageSetup),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class PrintSettings : OpenXmlCompositeElement
{
    private const string tagName = "printSettings";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13512;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PrintSettings class.
    /// </summary>
    public PrintSettings():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PrintSettings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PrintSettings(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PrintSettings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PrintSettings(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PrintSettings class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PrintSettings(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "headerFooter" == name)
    return new HeaderFooter();
    
if( 80 == namespaceId && "pageMargins" == name)
    return new PageMargins();
    
if( 80 == namespaceId && "pageSetup" == name)
    return new PageSetup();
    

    return null;
}

        private static readonly string[] eleTagNames = { "headerFooter","pageMargins","pageSetup" };
    private static readonly byte[] eleNamespaceIds = { 80,80,80 };
    
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
    /// <para> HeaderFooter.</para>
    /// <para> Represents the following element tag in the schema: cx:headerFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public HeaderFooter HeaderFooter
    {
        get 
        {
            return GetElement<HeaderFooter>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> PageMargins.</para>
    /// <para> Represents the following element tag in the schema: cx:pageMargins </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public PageMargins PageMargins
    {
        get 
        {
            return GetElement<PageMargins>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> PageSetup.</para>
    /// <para> Represents the following element tag in the schema: cx:pageSetup </para>
    /// </summary>
    /// <remark>
    /// xmlns:cx = http://schemas.microsoft.com/office/drawing/2014/chartex
    /// </remark>
    public PageSetup PageSetup
    {
        get 
        {
            return GetElement<PageSetup>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PrintSettings>(deep);
    }

   
}
/// <summary>
/// <para>Data reference.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:f.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Formula : OpenXmlLeafTextElement
{
    private const string tagName = "f";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13513;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "dir" };
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
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    public EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection> Dir
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Formula class.
    /// </summary>
    public Formula():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the Formula class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Formula(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "dir" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Formula>(deep);
    }

   
}
/// <summary>
/// <para>Optional cached data.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:lvl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartStringValue &lt;cx:pt></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ChartStringValue),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class StringLevel : OpenXmlCompositeElement
{
    private const string tagName = "lvl";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13514;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ptCount" };
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
    /// <para> ptCount.</para>
    /// <para>Represents the following attribute in the schema: ptCount </para>
    /// </summary>
    [SchemaAttr(0, "ptCount")]
    public UInt32Value PtCount
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StringLevel class.
    /// </summary>
    public StringLevel():base(){}
    
            /// <summary>
    ///Initializes a new instance of the StringLevel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringLevel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StringLevel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringLevel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StringLevel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StringLevel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "pt" == name)
    return new ChartStringValue();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "ptCount" == name)
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
        return CloneImp<StringLevel>(deep);
    }

   
}
/// <summary>
/// <para>Optional cached data.</para>
///<para>This class is only available in Office 2016.</para>
/// <para> When the object is serialized out as xml, its qualified name is cx:lvl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumericValue &lt;cx:pt></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(NumericValue),(FileFormatVersions)8)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class NumericLevel : OpenXmlCompositeElement
{
    private const string tagName = "lvl";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 80;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13515;
    
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
		if((8 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "ptCount","formatCode" };
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
    /// <para> ptCount.</para>
    /// <para>Represents the following attribute in the schema: ptCount </para>
    /// </summary>
    [SchemaAttr(0, "ptCount")]
    public UInt32Value PtCount
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> formatCode.</para>
    /// <para>Represents the following attribute in the schema: formatCode </para>
    /// </summary>
    [SchemaAttr(0, "formatCode")]
    public StringValue FormatCode
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NumericLevel class.
    /// </summary>
    public NumericLevel():base(){}
    
            /// <summary>
    ///Initializes a new instance of the NumericLevel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumericLevel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumericLevel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumericLevel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumericLevel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumericLevel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 80 == namespaceId && "pt" == name)
    return new NumericValue();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "ptCount" == name)
    return new UInt32Value();
    
if( 0 == namespaceId && "formatCode" == name)
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
        return CloneImp<NumericLevel>(deep);
    }

   
}
/// <summary>
/// Defines the FormulaDirection enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FormulaDirection
{  
	///<summary>
///col.
///<para>When the item is serialized out as xml, its value is "col".</para>
///</summary>
[EnumString("col")]
Col,
///<summary>
///row.
///<para>When the item is serialized out as xml, its value is "row".</para>
///</summary>
[EnumString("row")]
Row,
 
}
/// <summary>
/// Defines the StringDimensionType enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StringDimensionType
{  
	///<summary>
///cat.
///<para>When the item is serialized out as xml, its value is "cat".</para>
///</summary>
[EnumString("cat")]
Cat,
 
}
/// <summary>
/// Defines the NumericDimensionType enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum NumericDimensionType
{  
	///<summary>
///val.
///<para>When the item is serialized out as xml, its value is "val".</para>
///</summary>
[EnumString("val")]
Val,
///<summary>
///x.
///<para>When the item is serialized out as xml, its value is "x".</para>
///</summary>
[EnumString("x")]
X,
///<summary>
///y.
///<para>When the item is serialized out as xml, its value is "y".</para>
///</summary>
[EnumString("y")]
Y,
///<summary>
///size.
///<para>When the item is serialized out as xml, its value is "size".</para>
///</summary>
[EnumString("size")]
Size,
 
}
/// <summary>
/// Defines the SidePos enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SidePos
{  
	///<summary>
///l.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
L,
///<summary>
///t.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
T,
///<summary>
///r.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
R,
///<summary>
///b.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
B,
 
}
/// <summary>
/// Defines the PosAlign enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PosAlign
{  
	///<summary>
///min.
///<para>When the item is serialized out as xml, its value is "min".</para>
///</summary>
[EnumString("min")]
Min,
///<summary>
///ctr.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Ctr,
///<summary>
///max.
///<para>When the item is serialized out as xml, its value is "max".</para>
///</summary>
[EnumString("max")]
Max,
 
}
/// <summary>
/// Defines the AxisUnit enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AxisUnit
{  
	///<summary>
///hundreds.
///<para>When the item is serialized out as xml, its value is "hundreds".</para>
///</summary>
[EnumString("hundreds")]
Hundreds,
///<summary>
///thousands.
///<para>When the item is serialized out as xml, its value is "thousands".</para>
///</summary>
[EnumString("thousands")]
Thousands,
///<summary>
///tenThousands.
///<para>When the item is serialized out as xml, its value is "tenThousands".</para>
///</summary>
[EnumString("tenThousands")]
TenThousands,
///<summary>
///hundredThousands.
///<para>When the item is serialized out as xml, its value is "hundredThousands".</para>
///</summary>
[EnumString("hundredThousands")]
HundredThousands,
///<summary>
///millions.
///<para>When the item is serialized out as xml, its value is "millions".</para>
///</summary>
[EnumString("millions")]
Millions,
///<summary>
///tenMillions.
///<para>When the item is serialized out as xml, its value is "tenMillions".</para>
///</summary>
[EnumString("tenMillions")]
TenMillions,
///<summary>
///hundredMillions.
///<para>When the item is serialized out as xml, its value is "hundredMillions".</para>
///</summary>
[EnumString("hundredMillions")]
HundredMillions,
///<summary>
///billions.
///<para>When the item is serialized out as xml, its value is "billions".</para>
///</summary>
[EnumString("billions")]
Billions,
///<summary>
///trillions.
///<para>When the item is serialized out as xml, its value is "trillions".</para>
///</summary>
[EnumString("trillions")]
Trillions,
///<summary>
///percentage.
///<para>When the item is serialized out as xml, its value is "percentage".</para>
///</summary>
[EnumString("percentage")]
Percentage,
 
}
/// <summary>
/// Defines the TickMarksType enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TickMarksType
{  
	///<summary>
///in.
///<para>When the item is serialized out as xml, its value is "in".</para>
///</summary>
[EnumString("in")]
In,
///<summary>
///out.
///<para>When the item is serialized out as xml, its value is "out".</para>
///</summary>
[EnumString("out")]
Out,
///<summary>
///cross.
///<para>When the item is serialized out as xml, its value is "cross".</para>
///</summary>
[EnumString("cross")]
Cross,
///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
 
}
/// <summary>
/// Defines the SeriesLayout enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SeriesLayout
{  
	///<summary>
///boxWhisker.
///<para>When the item is serialized out as xml, its value is "boxWhisker".</para>
///</summary>
[EnumString("boxWhisker")]
BoxWhisker,
///<summary>
///clusteredColumn.
///<para>When the item is serialized out as xml, its value is "clusteredColumn".</para>
///</summary>
[EnumString("clusteredColumn")]
ClusteredColumn,
///<summary>
///paretoLine.
///<para>When the item is serialized out as xml, its value is "paretoLine".</para>
///</summary>
[EnumString("paretoLine")]
ParetoLine,
///<summary>
///sunburst.
///<para>When the item is serialized out as xml, its value is "sunburst".</para>
///</summary>
[EnumString("sunburst")]
Sunburst,
///<summary>
///treemap.
///<para>When the item is serialized out as xml, its value is "treemap".</para>
///</summary>
[EnumString("treemap")]
Treemap,
///<summary>
///waterfall.
///<para>When the item is serialized out as xml, its value is "waterfall".</para>
///</summary>
[EnumString("waterfall")]
Waterfall,
 
}
/// <summary>
/// Defines the ParentLabelLayoutVal enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ParentLabelLayoutVal
{  
	///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///banner.
///<para>When the item is serialized out as xml, its value is "banner".</para>
///</summary>
[EnumString("banner")]
Banner,
///<summary>
///overlapping.
///<para>When the item is serialized out as xml, its value is "overlapping".</para>
///</summary>
[EnumString("overlapping")]
Overlapping,
 
}
/// <summary>
/// Defines the IntervalClosedSide enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum IntervalClosedSide
{  
	///<summary>
///l.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
L,
///<summary>
///r.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
R,
 
}
/// <summary>
/// Defines the QuartileMethod enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum QuartileMethod
{  
	///<summary>
///inclusive.
///<para>When the item is serialized out as xml, its value is "inclusive".</para>
///</summary>
[EnumString("inclusive")]
Inclusive,
///<summary>
///exclusive.
///<para>When the item is serialized out as xml, its value is "exclusive".</para>
///</summary>
[EnumString("exclusive")]
Exclusive,
 
}
/// <summary>
/// Defines the DataLabelPos enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DataLabelPos
{  
	///<summary>
///bestFit.
///<para>When the item is serialized out as xml, its value is "bestFit".</para>
///</summary>
[EnumString("bestFit")]
BestFit,
///<summary>
///b.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
B,
///<summary>
///ctr.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Ctr,
///<summary>
///inBase.
///<para>When the item is serialized out as xml, its value is "inBase".</para>
///</summary>
[EnumString("inBase")]
InBase,
///<summary>
///inEnd.
///<para>When the item is serialized out as xml, its value is "inEnd".</para>
///</summary>
[EnumString("inEnd")]
InEnd,
///<summary>
///l.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
L,
///<summary>
///outEnd.
///<para>When the item is serialized out as xml, its value is "outEnd".</para>
///</summary>
[EnumString("outEnd")]
OutEnd,
///<summary>
///r.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
R,
///<summary>
///t.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
T,
 
}
/// <summary>
/// Defines the PageOrientation enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PageOrientation
{  
	///<summary>
///default.
///<para>When the item is serialized out as xml, its value is "default".</para>
///</summary>
[EnumString("default")]
Default,
///<summary>
///portrait.
///<para>When the item is serialized out as xml, its value is "portrait".</para>
///</summary>
[EnumString("portrait")]
Portrait,
///<summary>
///landscape.
///<para>When the item is serialized out as xml, its value is "landscape".</para>
///</summary>
[EnumString("landscape")]
Landscape,
 
}
}
 
 
