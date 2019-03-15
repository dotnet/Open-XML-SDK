// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2010.Word.Drawing
{
/// <summary>
/// <para>Defines the PercentagePositionHeightOffset Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:pctPosHOffset.</para>
/// </summary>

[SchemaAttr(51, "pctPosHOffset")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PercentagePositionHeightOffset : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12889;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PercentagePositionHeightOffset>(deep);

}
/// <summary>
/// <para>Defines the PercentagePositionVerticalOffset Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:pctPosVOffset.</para>
/// </summary>

[SchemaAttr(51, "pctPosVOffset")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PercentagePositionVerticalOffset : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12890;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PercentagePositionVerticalOffset>(deep);

}
/// <summary>
/// <para>Defines the RelativeWidth Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:sizeRelH.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PercentageWidth &lt;wp14:pctWidth></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PercentageWidth), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(51, "sizeRelH")]
[Id(ElementTypeIdConst)]
public partial class RelativeWidth : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12891;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> relativeFrom.</para>
    /// <para>Represents the following attribute in the schema: relativeFrom </para>
    /// </summary>
    [SchemaAttr(0, "relativeFrom")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeHorizontallyValues> ObjectId { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PercentageWidth.</para>
    /// <para> Represents the following element tag in the schema: wp14:pctWidth </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp14 = http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public PercentageWidth PercentageWidth
	{
        get => GetElement<PercentageWidth>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelativeWidth>(deep);

}
/// <summary>
/// <para>Defines the RelativeHeight Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:sizeRelV.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PercentageHeight &lt;wp14:pctHeight></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PercentageHeight), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(51, "sizeRelV")]
[Id(ElementTypeIdConst)]
public partial class RelativeHeight : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12892;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> relativeFrom.</para>
    /// <para>Represents the following attribute in the schema: relativeFrom </para>
    /// </summary>
    [SchemaAttr(0, "relativeFrom")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues> RelativeFrom { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PercentageHeight.</para>
    /// <para> Represents the following element tag in the schema: wp14:pctHeight </para>
    /// </summary>
    /// <remark>
    /// xmlns:wp14 = http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
    /// </remark>
	[Index(0)]
    public PercentageHeight PercentageHeight
	{
        get => GetElement<PercentageHeight>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelativeHeight>(deep);

}
/// <summary>
/// <para>Defines the PercentageWidth Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:pctWidth.</para>
/// </summary>

[SchemaAttr(51, "pctWidth")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PercentageWidth : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12893;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PercentageWidth>(deep);

}
/// <summary>
/// <para>Defines the PercentageHeight Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wp14:pctHeight.</para>
/// </summary>

[SchemaAttr(51, "pctHeight")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PercentageHeight : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12894;
    internal override int ElementTypeId => ElementTypeIdConst;

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PercentageHeight>(deep);

}
/// <summary>
/// Defines the SizeRelativeHorizontallyValues enumeration. 
/// </summary> 
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
 
 
