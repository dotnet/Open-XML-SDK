// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using DocumentFormat.OpenXml.Office2010.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
/// <summary>
/// <para>Number Format.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:numFmt.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NumberingFormat : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10348;
    /// <inheritdoc/>
    public override string LocalName => "numFmt";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "formatCode"),
		AttributeTag.Create<BooleanValue>(0, "sourceLinked")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Number Format Code.</para>
    /// <para>Represents the following attribute in the schema: formatCode </para>
    /// </summary>
    [SchemaAttr(0, "formatCode")]
    public StringValue FormatCode
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Linked to Source.</para>
    /// <para>Represents the following attribute in the schema: sourceLinked </para>
    /// </summary>
    [SchemaAttr(0, "sourceLinked")]
    public BooleanValue SourceLinked
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NumberingFormat class.
    /// </summary>
    public NumberingFormat():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberingFormat>(deep);

}
/// <summary>
/// <para>Defines the ChartShapeProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:spPr.</para>
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
///<item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Transform2D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ChartShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10349;
    /// <inheritdoc/>
    public override string LocalName => "spPr";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>(0, "bwMode")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ChartShapeProperties class.
    /// </summary>
    public ChartShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ChartShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartShapeProperties(string outerXml)
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
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "xfrm","custGeom","prstGeom","noFill","solidFill","gradFill","blipFill","pattFill","ln","effectLst","effectDag","scene3d","sp3d","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10,10,10,10,10,10,10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> 2D Transform for Individual Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartShapeProperties>(deep);

}
/// <summary>
/// <para>Defines the TextProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:txPr.</para>
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
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TextProperties : TextBodyType
{
    internal const int ElementTypeIdConst = 10350;
    /// <inheritdoc/>
    public override string LocalName => "txPr";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the TextProperties class.
    /// </summary>
    public TextProperties():base(){}
        /// <summary>
    ///Initializes a new instance of the TextProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TextProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TextProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TextProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TextProperties(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextProperties>(deep);

}
/// <summary>
/// <para>Rich Text.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:rich.</para>
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
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RichText : TextBodyType
{
    internal const int ElementTypeIdConst = 10533;
    /// <inheritdoc/>
    public override string LocalName => "rich";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the RichText class.
    /// </summary>
    public RichText():base(){}
        /// <summary>
    ///Initializes a new instance of the RichText class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RichText(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RichText class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RichText(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RichText class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RichText(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichText>(deep);

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
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Body Properties.</para>
    /// <para> Represents the following element tag in the schema: a:bodyPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.BodyProperties BodyProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>(0);
        set => SetElement(0, value);
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
        get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>(1);
        set => SetElement(1, value);
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
/// <para>Data Label Position.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dLblPos.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DataLabelPosition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10351;
    /// <inheritdoc/>
    public override string LocalName => "dLblPos";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Data Label Position Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataLabelPosition class.
    /// </summary>
    public DataLabelPosition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelPosition>(deep);

}
/// <summary>
/// <para>Show Legend Key.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showLegendKey.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowLegendKey : BooleanType
{
    internal const int ElementTypeIdConst = 10352;
    /// <inheritdoc/>
    public override string LocalName => "showLegendKey";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowLegendKey class.
    /// </summary>
    public ShowLegendKey():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowLegendKey>(deep);

}
/// <summary>
/// <para>Show Value.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showVal.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowValue : BooleanType
{
    internal const int ElementTypeIdConst = 10353;
    /// <inheritdoc/>
    public override string LocalName => "showVal";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowValue class.
    /// </summary>
    public ShowValue():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowValue>(deep);

}
/// <summary>
/// <para>Show Category Name.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showCatName.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowCategoryName : BooleanType
{
    internal const int ElementTypeIdConst = 10354;
    /// <inheritdoc/>
    public override string LocalName => "showCatName";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowCategoryName class.
    /// </summary>
    public ShowCategoryName():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowCategoryName>(deep);

}
/// <summary>
/// <para>Show Series Name.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showSerName.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowSeriesName : BooleanType
{
    internal const int ElementTypeIdConst = 10355;
    /// <inheritdoc/>
    public override string LocalName => "showSerName";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowSeriesName class.
    /// </summary>
    public ShowSeriesName():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowSeriesName>(deep);

}
/// <summary>
/// <para>Show Percent.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showPercent.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowPercent : BooleanType
{
    internal const int ElementTypeIdConst = 10356;
    /// <inheritdoc/>
    public override string LocalName => "showPercent";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowPercent class.
    /// </summary>
    public ShowPercent():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowPercent>(deep);

}
/// <summary>
/// <para>Show Bubble Size.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showBubbleSize.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowBubbleSize : BooleanType
{
    internal const int ElementTypeIdConst = 10357;
    /// <inheritdoc/>
    public override string LocalName => "showBubbleSize";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowBubbleSize class.
    /// </summary>
    public ShowBubbleSize():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowBubbleSize>(deep);

}
/// <summary>
/// <para>Show Leader Lines.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showLeaderLines.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowLeaderLines : BooleanType
{
    internal const int ElementTypeIdConst = 10361;
    /// <inheritdoc/>
    public override string LocalName => "showLeaderLines";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowLeaderLines class.
    /// </summary>
    public ShowLeaderLines():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowLeaderLines>(deep);

}
/// <summary>
/// <para>Defines the VaryColors Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:varyColors.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VaryColors : BooleanType
{
    internal const int ElementTypeIdConst = 10367;
    /// <inheritdoc/>
    public override string LocalName => "varyColors";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the VaryColors class.
    /// </summary>
    public VaryColors():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VaryColors>(deep);

}
/// <summary>
/// <para>Wireframe.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:wireframe.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Wireframe : BooleanType
{
    internal const int ElementTypeIdConst = 10376;
    /// <inheritdoc/>
    public override string LocalName => "wireframe";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Wireframe class.
    /// </summary>
    public Wireframe():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Wireframe>(deep);

}
/// <summary>
/// <para>Delete.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:delete.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Delete : BooleanType
{
    internal const int ElementTypeIdConst = 10381;
    /// <inheritdoc/>
    public override string LocalName => "delete";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Delete class.
    /// </summary>
    public Delete():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Delete>(deep);

}
/// <summary>
/// <para>Overlay.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:overlay.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Overlay : BooleanType
{
    internal const int ElementTypeIdConst = 10417;
    /// <inheritdoc/>
    public override string LocalName => "overlay";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Overlay class.
    /// </summary>
    public Overlay():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Overlay>(deep);

}
/// <summary>
/// <para>Right Angle Axes.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:rAngAx.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RightAngleAxes : BooleanType
{
    internal const int ElementTypeIdConst = 10422;
    /// <inheritdoc/>
    public override string LocalName => "rAngAx";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the RightAngleAxes class.
    /// </summary>
    public RightAngleAxes():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RightAngleAxes>(deep);

}
/// <summary>
/// <para>Show Horizontal Border.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showHorzBorder.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowHorizontalBorder : BooleanType
{
    internal const int ElementTypeIdConst = 10424;
    /// <inheritdoc/>
    public override string LocalName => "showHorzBorder";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowHorizontalBorder class.
    /// </summary>
    public ShowHorizontalBorder():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowHorizontalBorder>(deep);

}
/// <summary>
/// <para>Show Vertical Border.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showVertBorder.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowVerticalBorder : BooleanType
{
    internal const int ElementTypeIdConst = 10425;
    /// <inheritdoc/>
    public override string LocalName => "showVertBorder";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowVerticalBorder class.
    /// </summary>
    public ShowVerticalBorder():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowVerticalBorder>(deep);

}
/// <summary>
/// <para>Show Outline Border.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showOutline.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowOutlineBorder : BooleanType
{
    internal const int ElementTypeIdConst = 10426;
    /// <inheritdoc/>
    public override string LocalName => "showOutline";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowOutlineBorder class.
    /// </summary>
    public ShowOutlineBorder():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowOutlineBorder>(deep);

}
/// <summary>
/// <para>Show Legend Keys.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showKeys.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowKeys : BooleanType
{
    internal const int ElementTypeIdConst = 10427;
    /// <inheritdoc/>
    public override string LocalName => "showKeys";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowKeys class.
    /// </summary>
    public ShowKeys():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowKeys>(deep);

}
/// <summary>
/// <para>Invert if Negative.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:invertIfNegative.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class InvertIfNegative : BooleanType
{
    internal const int ElementTypeIdConst = 10431;
    /// <inheritdoc/>
    public override string LocalName => "invertIfNegative";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the InvertIfNegative class.
    /// </summary>
    public InvertIfNegative():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertIfNegative>(deep);

}
/// <summary>
/// <para>3D Bubble.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:bubble3D.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Bubble3D : BooleanType
{
    internal const int ElementTypeIdConst = 10433;
    /// <inheritdoc/>
    public override string LocalName => "bubble3D";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Bubble3D class.
    /// </summary>
    public Bubble3D():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bubble3D>(deep);

}
/// <summary>
/// <para>Display R Squared Value.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dispRSqr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DisplayRSquaredValue : BooleanType
{
    internal const int ElementTypeIdConst = 10443;
    /// <inheritdoc/>
    public override string LocalName => "dispRSqr";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the DisplayRSquaredValue class.
    /// </summary>
    public DisplayRSquaredValue():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayRSquaredValue>(deep);

}
/// <summary>
/// <para>Display Equation.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dispEq.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DisplayEquation : BooleanType
{
    internal const int ElementTypeIdConst = 10444;
    /// <inheritdoc/>
    public override string LocalName => "dispEq";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the DisplayEquation class.
    /// </summary>
    public DisplayEquation():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayEquation>(deep);

}
/// <summary>
/// <para>No End Cap.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:noEndCap.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NoEndCap : BooleanType
{
    internal const int ElementTypeIdConst = 10449;
    /// <inheritdoc/>
    public override string LocalName => "noEndCap";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the NoEndCap class.
    /// </summary>
    public NoEndCap():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoEndCap>(deep);

}
/// <summary>
/// <para>Apply To Front.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:applyToFront.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ApplyToFront : BooleanType
{
    internal const int ElementTypeIdConst = 10463;
    /// <inheritdoc/>
    public override string LocalName => "applyToFront";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ApplyToFront class.
    /// </summary>
    public ApplyToFront():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplyToFront>(deep);

}
/// <summary>
/// <para>Apply To Sides.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:applyToSides.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ApplyToSides : BooleanType
{
    internal const int ElementTypeIdConst = 10464;
    /// <inheritdoc/>
    public override string LocalName => "applyToSides";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ApplyToSides class.
    /// </summary>
    public ApplyToSides():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplyToSides>(deep);

}
/// <summary>
/// <para>Apply to End.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:applyToEnd.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ApplyToEnd : BooleanType
{
    internal const int ElementTypeIdConst = 10465;
    /// <inheritdoc/>
    public override string LocalName => "applyToEnd";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ApplyToEnd class.
    /// </summary>
    public ApplyToEnd():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplyToEnd>(deep);

}
/// <summary>
/// <para>Auto Title Is Deleted.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:autoTitleDeleted.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AutoTitleDeleted : BooleanType
{
    internal const int ElementTypeIdConst = 10478;
    /// <inheritdoc/>
    public override string LocalName => "autoTitleDeleted";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the AutoTitleDeleted class.
    /// </summary>
    public AutoTitleDeleted():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoTitleDeleted>(deep);

}
/// <summary>
/// <para>Plot Visible Only.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:plotVisOnly.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PlotVisibleOnly : BooleanType
{
    internal const int ElementTypeIdConst = 10486;
    /// <inheritdoc/>
    public override string LocalName => "plotVisOnly";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the PlotVisibleOnly class.
    /// </summary>
    public PlotVisibleOnly():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotVisibleOnly>(deep);

}
/// <summary>
/// <para>Show Data Labels over Maximum.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showDLblsOverMax.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowDataLabelsOverMaximum : BooleanType
{
    internal const int ElementTypeIdConst = 10488;
    /// <inheritdoc/>
    public override string LocalName => "showDLblsOverMax";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowDataLabelsOverMaximum class.
    /// </summary>
    public ShowDataLabelsOverMaximum():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowDataLabelsOverMaximum>(deep);

}
/// <summary>
/// <para>Chart Object.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:chartObject.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ChartObject : BooleanType
{
    internal const int ElementTypeIdConst = 10489;
    /// <inheritdoc/>
    public override string LocalName => "chartObject";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ChartObject class.
    /// </summary>
    public ChartObject():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartObject>(deep);

}
/// <summary>
/// <para>Data Cannot Be Changed.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:data.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Data : BooleanType
{
    internal const int ElementTypeIdConst = 10490;
    /// <inheritdoc/>
    public override string LocalName => "data";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Data class.
    /// </summary>
    public Data():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Data>(deep);

}
/// <summary>
/// <para>Formatting.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:formatting.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Formatting : BooleanType
{
    internal const int ElementTypeIdConst = 10491;
    /// <inheritdoc/>
    public override string LocalName => "formatting";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Formatting class.
    /// </summary>
    public Formatting():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formatting>(deep);

}
/// <summary>
/// <para>Selection.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:selection.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Selection : BooleanType
{
    internal const int ElementTypeIdConst = 10492;
    /// <inheritdoc/>
    public override string LocalName => "selection";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Selection class.
    /// </summary>
    public Selection():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Selection>(deep);

}
/// <summary>
/// <para>User Interface.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:userInterface.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class UserInterface : BooleanType
{
    internal const int ElementTypeIdConst = 10493;
    /// <inheritdoc/>
    public override string LocalName => "userInterface";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the UserInterface class.
    /// </summary>
    public UserInterface():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UserInterface>(deep);

}
/// <summary>
/// <para>Update Automatically.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:autoUpdate.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AutoUpdate : BooleanType
{
    internal const int ElementTypeIdConst = 10500;
    /// <inheritdoc/>
    public override string LocalName => "autoUpdate";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the AutoUpdate class.
    /// </summary>
    public AutoUpdate():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoUpdate>(deep);

}
/// <summary>
/// <para>Defines the Smooth Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:smooth.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Smooth : BooleanType
{
    internal const int ElementTypeIdConst = 10585;
    /// <inheritdoc/>
    public override string LocalName => "smooth";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Smooth class.
    /// </summary>
    public Smooth():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Smooth>(deep);

}
/// <summary>
/// <para>Defines the ShowMarker Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:marker.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowMarker : BooleanType
{
    internal const int ElementTypeIdConst = 10600;
    /// <inheritdoc/>
    public override string LocalName => "marker";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowMarker class.
    /// </summary>
    public ShowMarker():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowMarker>(deep);

}
/// <summary>
/// <para>Defines the ShowNegativeBubbles Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:showNegBubbles.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowNegativeBubbles : BooleanType
{
    internal const int ElementTypeIdConst = 10617;
    /// <inheritdoc/>
    public override string LocalName => "showNegBubbles";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowNegativeBubbles class.
    /// </summary>
    public ShowNegativeBubbles():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowNegativeBubbles>(deep);

}
/// <summary>
/// <para>Defines the AutoLabeled Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:auto.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AutoLabeled : BooleanType
{
    internal const int ElementTypeIdConst = 10622;
    /// <inheritdoc/>
    public override string LocalName => "auto";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the AutoLabeled class.
    /// </summary>
    public AutoLabeled():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoLabeled>(deep);

}
/// <summary>
/// <para>Defines the NoMultiLevelLabels Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:noMultiLvlLbl.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NoMultiLevelLabels : BooleanType
{
    internal const int ElementTypeIdConst = 10627;
    /// <inheritdoc/>
    public override string LocalName => "noMultiLvlLbl";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the NoMultiLevelLabels class.
    /// </summary>
    public NoMultiLevelLabels():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoMultiLevelLabels>(deep);

}
/// <summary>
/// <para>Defines the Date1904 Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:date1904.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Date1904 : BooleanType
{
    internal const int ElementTypeIdConst = 10639;
    /// <inheritdoc/>
    public override string LocalName => "date1904";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Date1904 class.
    /// </summary>
    public Date1904():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Date1904>(deep);

}
/// <summary>
/// <para>Defines the RoundedCorners Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:roundedCorners.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RoundedCorners : BooleanType
{
    internal const int ElementTypeIdConst = 10641;
    /// <inheritdoc/>
    public override string LocalName => "roundedCorners";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the RoundedCorners class.
    /// </summary>
    public RoundedCorners():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoundedCorners>(deep);

}
/// <summary>
/// Defines the BooleanType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class BooleanType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Boolean Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BooleanType class.
    /// </summary>
    protected BooleanType(){}
    
    
    
}
/// <summary>
/// <para>Separator.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:separator.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Separator : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10358;
    /// <inheritdoc/>
    public override string LocalName => "separator";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Separator class.
    /// </summary>
    public Separator():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Separator class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Separator(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Separator>(deep);

}
/// <summary>
/// <para>Trendline Name.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:name.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TrendlineName : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10436;
    /// <inheritdoc/>
    public override string LocalName => "name";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the TrendlineName class.
    /// </summary>
    public TrendlineName():base(){}
    
        /// <summary>
    /// Initializes a new instance of the TrendlineName class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public TrendlineName(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineName>(deep);

}
/// <summary>
/// <para>Defines the Formula Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:f.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Formula : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10570;
    /// <inheritdoc/>
    public override string LocalName => "f";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);

}
/// <summary>
/// <para>Layout.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:layout.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ManualLayout &lt;c:manualLayout></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ManualLayout))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Layout : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10359;
    /// <inheritdoc/>
    public override string LocalName => "layout";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Layout class.
    /// </summary>
    public Layout():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Layout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Layout(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Layout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Layout(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Layout class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Layout(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "manualLayout" == name)
    return new ManualLayout();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "manualLayout","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Manual Layout.</para>
    /// <para> Represents the following element tag in the schema: c:manualLayout </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ManualLayout ManualLayout
    {
        get => GetElement<ManualLayout>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Layout>(deep);

}
/// <summary>
/// <para>Defines the ChartText Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:tx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StringReference &lt;c:strRef></description></item>
///<item><description>RichText &lt;c:rich></description></item>
///<item><description>StringLiteral &lt;c:strLit></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StringReference))]
    [ChildElementInfo(typeof(RichText))]
    [ChildElementInfo(typeof(StringLiteral))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ChartText : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10360;
    /// <inheritdoc/>
    public override string LocalName => "tx";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ChartText class.
    /// </summary>
    public ChartText():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ChartText class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartText(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartText class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartText(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartText class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartText(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "strRef" == name)
    return new StringReference();
    
if( 11 == namespaceId && "rich" == name)
    return new RichText();
    
if( 11 == namespaceId && "strLit" == name)
    return new StringLiteral();
    

    return null;
}

        private static readonly string[] eleTagNames = { "strRef","rich","strLit" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> String Reference.</para>
    /// <para> Represents the following element tag in the schema: c:strRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public StringReference StringReference
    {
        get => GetElement<StringReference>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Rich Text.</para>
    /// <para> Represents the following element tag in the schema: c:rich </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public RichText RichText
    {
        get => GetElement<RichText>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> String Literal.</para>
    /// <para> Represents the following element tag in the schema: c:strLit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public StringLiteral StringLiteral
    {
        get => GetElement<StringLiteral>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartText>(deep);

}
/// <summary>
/// <para>Leader Lines.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:leaderLines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LeaderLines : ChartLinesType
{
    internal const int ElementTypeIdConst = 10362;
    /// <inheritdoc/>
    public override string LocalName => "leaderLines";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the LeaderLines class.
    /// </summary>
    public LeaderLines():base(){}
        /// <summary>
    ///Initializes a new instance of the LeaderLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LeaderLines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LeaderLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LeaderLines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LeaderLines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LeaderLines(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeaderLines>(deep);

}
/// <summary>
/// <para>Drop Lines.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dropLines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DropLines : ChartLinesType
{
    internal const int ElementTypeIdConst = 10370;
    /// <inheritdoc/>
    public override string LocalName => "dropLines";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the DropLines class.
    /// </summary>
    public DropLines():base(){}
        /// <summary>
    ///Initializes a new instance of the DropLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropLines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DropLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropLines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DropLines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DropLines(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropLines>(deep);

}
/// <summary>
/// <para>Major Gridlines.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:majorGridlines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MajorGridlines : ChartLinesType
{
    internal const int ElementTypeIdConst = 10383;
    /// <inheritdoc/>
    public override string LocalName => "majorGridlines";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MajorGridlines class.
    /// </summary>
    public MajorGridlines():base(){}
        /// <summary>
    ///Initializes a new instance of the MajorGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MajorGridlines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MajorGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MajorGridlines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MajorGridlines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MajorGridlines(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorGridlines>(deep);

}
/// <summary>
/// <para>Minor Gridlines.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:minorGridlines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MinorGridlines : ChartLinesType
{
    internal const int ElementTypeIdConst = 10384;
    /// <inheritdoc/>
    public override string LocalName => "minorGridlines";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MinorGridlines class.
    /// </summary>
    public MinorGridlines():base(){}
        /// <summary>
    ///Initializes a new instance of the MinorGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MinorGridlines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MinorGridlines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MinorGridlines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MinorGridlines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MinorGridlines(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorGridlines>(deep);

}
/// <summary>
/// <para>Defines the SeriesLines Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:serLines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SeriesLines : ChartLinesType
{
    internal const int ElementTypeIdConst = 10461;
    /// <inheritdoc/>
    public override string LocalName => "serLines";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the SeriesLines class.
    /// </summary>
    public SeriesLines():base(){}
        /// <summary>
    ///Initializes a new instance of the SeriesLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesLines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesLines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesLines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SeriesLines(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesLines>(deep);

}
/// <summary>
/// <para>Defines the HighLowLines Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:hiLowLines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HighLowLines : ChartLinesType
{
    internal const int ElementTypeIdConst = 10565;
    /// <inheritdoc/>
    public override string LocalName => "hiLowLines";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HighLowLines class.
    /// </summary>
    public HighLowLines():base(){}
        /// <summary>
    ///Initializes a new instance of the HighLowLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HighLowLines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HighLowLines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HighLowLines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HighLowLines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HighLowLines(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HighLowLines>(deep);

}
/// <summary>
/// Defines the ChartLinesType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ChartShapeProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class ChartLinesType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "spPr" };
    private static readonly byte[] eleNamespaceIds = { 11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(0);
        set => SetElement(0, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the ChartLinesType class.
    /// </summary>
    protected ChartLinesType(){}
    
        /// <summary>
    ///Initializes a new instance of the ChartLinesType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected ChartLinesType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartLinesType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected ChartLinesType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartLinesType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected ChartLinesType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Index.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:idx.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Index : UnsignedIntegerType
{
    internal const int ElementTypeIdConst = 10363;
    /// <inheritdoc/>
    public override string LocalName => "idx";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Index class.
    /// </summary>
    public Index():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Index>(deep);

}
/// <summary>
/// <para>Order.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:order.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Order : UnsignedIntegerType
{
    internal const int ElementTypeIdConst = 10364;
    /// <inheritdoc/>
    public override string LocalName => "order";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Order class.
    /// </summary>
    public Order():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Order>(deep);

}
/// <summary>
/// <para>Axis ID.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:axId.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AxisId : UnsignedIntegerType
{
    internal const int ElementTypeIdConst = 10379;
    /// <inheritdoc/>
    public override string LocalName => "axId";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the AxisId class.
    /// </summary>
    public AxisId():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisId>(deep);

}
/// <summary>
/// <para>Crossing Axis ID.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:crossAx.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CrossingAxis : UnsignedIntegerType
{
    internal const int ElementTypeIdConst = 10389;
    /// <inheritdoc/>
    public override string LocalName => "crossAx";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the CrossingAxis class.
    /// </summary>
    public CrossingAxis():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CrossingAxis>(deep);

}
/// <summary>
/// <para>Point Count.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ptCount.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PointCount : UnsignedIntegerType
{
    internal const int ElementTypeIdConst = 10398;
    /// <inheritdoc/>
    public override string LocalName => "ptCount";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the PointCount class.
    /// </summary>
    public PointCount():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PointCount>(deep);

}
/// <summary>
/// <para>Second Pie Point.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:secondPiePt.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SecondPiePoint : UnsignedIntegerType
{
    internal const int ElementTypeIdConst = 10428;
    /// <inheritdoc/>
    public override string LocalName => "secondPiePt";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the SecondPiePoint class.
    /// </summary>
    public SecondPiePoint():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SecondPiePoint>(deep);

}
/// <summary>
/// <para>Explosion.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:explosion.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Explosion : UnsignedIntegerType
{
    internal const int ElementTypeIdConst = 10434;
    /// <inheritdoc/>
    public override string LocalName => "explosion";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Explosion class.
    /// </summary>
    public Explosion():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Explosion>(deep);

}
/// <summary>
/// <para>Format ID.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:fmtId.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FormatId : UnsignedIntegerType
{
    internal const int ElementTypeIdConst = 10506;
    /// <inheritdoc/>
    public override string LocalName => "fmtId";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the FormatId class.
    /// </summary>
    public FormatId():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormatId>(deep);

}
/// <summary>
/// Defines the UnsignedIntegerType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class UnsignedIntegerType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Integer Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the UnsignedIntegerType class.
    /// </summary>
    protected UnsignedIntegerType(){}
    
    
    
}
/// <summary>
/// <para>Series Text.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:tx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StringReference &lt;c:strRef></description></item>
///<item><description>NumericValue &lt;c:v></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StringReference))]
    [ChildElementInfo(typeof(NumericValue))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SeriesText : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10365;
    /// <inheritdoc/>
    public override string LocalName => "tx";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SeriesText class.
    /// </summary>
    public SeriesText():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SeriesText class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesText(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesText class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesText(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesText class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SeriesText(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "strRef" == name)
    return new StringReference();
    
if( 11 == namespaceId && "v" == name)
    return new NumericValue();
    

    return null;
}

        private static readonly string[] eleTagNames = { "strRef","v" };
    private static readonly byte[] eleNamespaceIds = { 11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> StringReference.</para>
    /// <para> Represents the following element tag in the schema: c:strRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public StringReference StringReference
    {
        get => GetElement<StringReference>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> NumericValue.</para>
    /// <para> Represents the following element tag in the schema: c:v </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumericValue NumericValue
    {
        get => GetElement<NumericValue>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesText>(deep);

}
/// <summary>
/// <para>Grouping.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:grouping.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Grouping : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10366;
    /// <inheritdoc/>
    public override string LocalName => "grouping";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Grouping Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Grouping class.
    /// </summary>
    public Grouping():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Grouping>(deep);

}
/// <summary>
/// <para>Defines the LineChartSeries Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>Order &lt;c:order></description></item>
///<item><description>SeriesText &lt;c:tx></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>Marker &lt;c:marker></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DataPoint &lt;c:dPt></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>Trendline &lt;c:trendline></description></item>
///<item><description>ErrorBars &lt;c:errBars></description></item>
///<item><description>CategoryAxisData &lt;c:cat></description></item>
///<item><description>Values &lt;c:val></description></item>
///<item><description>Smooth &lt;c:smooth></description></item>
///<item><description>LineSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(Order))]
    [ChildElementInfo(typeof(SeriesText))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(Marker))]
    [ChildElementInfo(typeof(PictureOptions))]
    [ChildElementInfo(typeof(DataPoint))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(Trendline))]
    [ChildElementInfo(typeof(ErrorBars))]
    [ChildElementInfo(typeof(CategoryAxisData))]
    [ChildElementInfo(typeof(Values))]
    [ChildElementInfo(typeof(Smooth))]
    [ChildElementInfo(typeof(LineSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LineChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10368;
    /// <inheritdoc/>
    public override string LocalName => "ser";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LineChartSeries class.
    /// </summary>
    public LineChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LineChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LineChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "order" == name)
    return new Order();
    
if( 11 == namespaceId && "tx" == name)
    return new SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "marker" == name)
    return new Marker();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new PictureOptions();
    
if( 11 == namespaceId && "dPt" == name)
    return new DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "trendline" == name)
    return new Trendline();
    
if( 11 == namespaceId && "errBars" == name)
    return new ErrorBars();
    
if( 11 == namespaceId && "cat" == name)
    return new CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new Values();
    
if( 11 == namespaceId && "smooth" == name)
    return new Smooth();
    
if( 11 == namespaceId && "extLst" == name)
    return new LineSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","marker","pictureOptions","dPt","dLbls","trendline","errBars","cat","val","smooth","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Order Order
    {
        get => GetElement<Order>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public SeriesText SeriesText
    {
        get => GetElement<SeriesText>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Marker Marker
    {
        get => GetElement<Marker>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureOptions PictureOptions
    {
        get => GetElement<PictureOptions>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChartSeries>(deep);

}
/// <summary>
/// <para>Data Labels.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dLbls.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DataLabel &lt;c:dLbl></description></item>
///<item><description>Delete &lt;c:delete></description></item>
///<item><description>NumberingFormat &lt;c:numFmt></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>DataLabelPosition &lt;c:dLblPos></description></item>
///<item><description>ShowLegendKey &lt;c:showLegendKey></description></item>
///<item><description>ShowValue &lt;c:showVal></description></item>
///<item><description>ShowCategoryName &lt;c:showCatName></description></item>
///<item><description>ShowSeriesName &lt;c:showSerName></description></item>
///<item><description>ShowPercent &lt;c:showPercent></description></item>
///<item><description>ShowBubbleSize &lt;c:showBubbleSize></description></item>
///<item><description>Separator &lt;c:separator></description></item>
///<item><description>ShowLeaderLines &lt;c:showLeaderLines></description></item>
///<item><description>LeaderLines &lt;c:leaderLines></description></item>
///<item><description>DLblsExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DataLabel))]
    [ChildElementInfo(typeof(Delete))]
    [ChildElementInfo(typeof(NumberingFormat))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(DataLabelPosition))]
    [ChildElementInfo(typeof(ShowLegendKey))]
    [ChildElementInfo(typeof(ShowValue))]
    [ChildElementInfo(typeof(ShowCategoryName))]
    [ChildElementInfo(typeof(ShowSeriesName))]
    [ChildElementInfo(typeof(ShowPercent))]
    [ChildElementInfo(typeof(ShowBubbleSize))]
    [ChildElementInfo(typeof(Separator))]
    [ChildElementInfo(typeof(ShowLeaderLines))]
    [ChildElementInfo(typeof(LeaderLines))]
    [ChildElementInfo(typeof(DLblsExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DataLabels : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10369;
    /// <inheritdoc/>
    public override string LocalName => "dLbls";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    if( 11 == namespaceId && "dLbl" == name)
    return new DataLabel();
    
if( 11 == namespaceId && "delete" == name)
    return new Delete();
    
if( 11 == namespaceId && "numFmt" == name)
    return new NumberingFormat();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "dLblPos" == name)
    return new DataLabelPosition();
    
if( 11 == namespaceId && "showLegendKey" == name)
    return new ShowLegendKey();
    
if( 11 == namespaceId && "showVal" == name)
    return new ShowValue();
    
if( 11 == namespaceId && "showCatName" == name)
    return new ShowCategoryName();
    
if( 11 == namespaceId && "showSerName" == name)
    return new ShowSeriesName();
    
if( 11 == namespaceId && "showPercent" == name)
    return new ShowPercent();
    
if( 11 == namespaceId && "showBubbleSize" == name)
    return new ShowBubbleSize();
    
if( 11 == namespaceId && "separator" == name)
    return new Separator();
    
if( 11 == namespaceId && "showLeaderLines" == name)
    return new ShowLeaderLines();
    
if( 11 == namespaceId && "leaderLines" == name)
    return new LeaderLines();
    
if( 11 == namespaceId && "extLst" == name)
    return new DLblsExtensionList();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabels>(deep);

}
/// <summary>
/// <para>Bar Direction.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:barDir.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BarDirection : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10371;
    /// <inheritdoc/>
    public override string LocalName => "barDir";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Bar Direction Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BarDirection class.
    /// </summary>
    public BarDirection():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarDirection>(deep);

}
/// <summary>
/// <para>Bar Grouping.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:grouping.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BarGrouping : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10372;
    /// <inheritdoc/>
    public override string LocalName => "grouping";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Bar Grouping Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BarGrouping class.
    /// </summary>
    public BarGrouping():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarGrouping>(deep);

}
/// <summary>
/// <para>Bar Chart Series.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>Order &lt;c:order></description></item>
///<item><description>SeriesText &lt;c:tx></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>InvertIfNegative &lt;c:invertIfNegative></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DataPoint &lt;c:dPt></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>Trendline &lt;c:trendline></description></item>
///<item><description>ErrorBars &lt;c:errBars></description></item>
///<item><description>CategoryAxisData &lt;c:cat></description></item>
///<item><description>Values &lt;c:val></description></item>
///<item><description>Shape &lt;c:shape></description></item>
///<item><description>BarSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(Order))]
    [ChildElementInfo(typeof(SeriesText))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(InvertIfNegative))]
    [ChildElementInfo(typeof(PictureOptions))]
    [ChildElementInfo(typeof(DataPoint))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(Trendline))]
    [ChildElementInfo(typeof(ErrorBars))]
    [ChildElementInfo(typeof(CategoryAxisData))]
    [ChildElementInfo(typeof(Values))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(BarSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BarChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10373;
    /// <inheritdoc/>
    public override string LocalName => "ser";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BarChartSeries class.
    /// </summary>
    public BarChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BarChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "order" == name)
    return new Order();
    
if( 11 == namespaceId && "tx" == name)
    return new SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "invertIfNegative" == name)
    return new InvertIfNegative();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new PictureOptions();
    
if( 11 == namespaceId && "dPt" == name)
    return new DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "trendline" == name)
    return new Trendline();
    
if( 11 == namespaceId && "errBars" == name)
    return new ErrorBars();
    
if( 11 == namespaceId && "cat" == name)
    return new CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new Values();
    
if( 11 == namespaceId && "shape" == name)
    return new Shape();
    
if( 11 == namespaceId && "extLst" == name)
    return new BarSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","invertIfNegative","pictureOptions","dPt","dLbls","trendline","errBars","cat","val","shape","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Order Order
    {
        get => GetElement<Order>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public SeriesText SeriesText
    {
        get => GetElement<SeriesText>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> InvertIfNegative.</para>
    /// <para> Represents the following element tag in the schema: c:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public InvertIfNegative InvertIfNegative
    {
        get => GetElement<InvertIfNegative>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureOptions PictureOptions
    {
        get => GetElement<PictureOptions>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChartSeries>(deep);

}
/// <summary>
/// <para>Area Chart Series.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>Order &lt;c:order></description></item>
///<item><description>SeriesText &lt;c:tx></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>DataPoint &lt;c:dPt></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>Trendline &lt;c:trendline></description></item>
///<item><description>ErrorBars &lt;c:errBars></description></item>
///<item><description>CategoryAxisData &lt;c:cat></description></item>
///<item><description>Values &lt;c:val></description></item>
///<item><description>AreaSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(Order))]
    [ChildElementInfo(typeof(SeriesText))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(PictureOptions))]
    [ChildElementInfo(typeof(DataPoint))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(Trendline))]
    [ChildElementInfo(typeof(ErrorBars))]
    [ChildElementInfo(typeof(CategoryAxisData))]
    [ChildElementInfo(typeof(Values))]
    [ChildElementInfo(typeof(AreaSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AreaChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10374;
    /// <inheritdoc/>
    public override string LocalName => "ser";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AreaChartSeries class.
    /// </summary>
    public AreaChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AreaChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AreaChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "order" == name)
    return new Order();
    
if( 11 == namespaceId && "tx" == name)
    return new SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new PictureOptions();
    
if( 11 == namespaceId && "dPt" == name)
    return new DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "trendline" == name)
    return new Trendline();
    
if( 11 == namespaceId && "errBars" == name)
    return new ErrorBars();
    
if( 11 == namespaceId && "cat" == name)
    return new CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new Values();
    
if( 11 == namespaceId && "extLst" == name)
    return new AreaSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","pictureOptions","dPt","dLbls","trendline","errBars","cat","val","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Order Order
    {
        get => GetElement<Order>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public SeriesText SeriesText
    {
        get => GetElement<SeriesText>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureOptions PictureOptions
    {
        get => GetElement<PictureOptions>(4);
        set => SetElement(4, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChartSeries>(deep);

}
/// <summary>
/// <para>Pie Chart Series.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>Order &lt;c:order></description></item>
///<item><description>SeriesText &lt;c:tx></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>Explosion &lt;c:explosion></description></item>
///<item><description>DataPoint &lt;c:dPt></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>CategoryAxisData &lt;c:cat></description></item>
///<item><description>Values &lt;c:val></description></item>
///<item><description>PieSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(Order))]
    [ChildElementInfo(typeof(SeriesText))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(PictureOptions))]
    [ChildElementInfo(typeof(Explosion))]
    [ChildElementInfo(typeof(DataPoint))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(CategoryAxisData))]
    [ChildElementInfo(typeof(Values))]
    [ChildElementInfo(typeof(PieSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PieChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10375;
    /// <inheritdoc/>
    public override string LocalName => "ser";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PieChartSeries class.
    /// </summary>
    public PieChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PieChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PieChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "order" == name)
    return new Order();
    
if( 11 == namespaceId && "tx" == name)
    return new SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new PictureOptions();
    
if( 11 == namespaceId && "explosion" == name)
    return new Explosion();
    
if( 11 == namespaceId && "dPt" == name)
    return new DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "cat" == name)
    return new CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new Values();
    
if( 11 == namespaceId && "extLst" == name)
    return new PieSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","pictureOptions","explosion","dPt","dLbls","cat","val","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Order Order
    {
        get => GetElement<Order>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public SeriesText SeriesText
    {
        get => GetElement<SeriesText>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureOptions PictureOptions
    {
        get => GetElement<PictureOptions>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Explosion.</para>
    /// <para> Represents the following element tag in the schema: c:explosion </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Explosion Explosion
    {
        get => GetElement<Explosion>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChartSeries>(deep);

}
/// <summary>
/// <para>Surface Chart Series.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>Order &lt;c:order></description></item>
///<item><description>SeriesText &lt;c:tx></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>CategoryAxisData &lt;c:cat></description></item>
///<item><description>Values &lt;c:val></description></item>
///<item><description>Bubble3D &lt;c:bubble3D></description></item>
///<item><description>SurfaceSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(Order))]
    [ChildElementInfo(typeof(SeriesText))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(PictureOptions))]
    [ChildElementInfo(typeof(CategoryAxisData))]
    [ChildElementInfo(typeof(Values))]
    [ChildElementInfo(typeof(Bubble3D))]
    [ChildElementInfo(typeof(SurfaceSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SurfaceChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10377;
    /// <inheritdoc/>
    public override string LocalName => "ser";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartSeries class.
    /// </summary>
    public SurfaceChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurfaceChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "order" == name)
    return new Order();
    
if( 11 == namespaceId && "tx" == name)
    return new SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new PictureOptions();
    
if( 11 == namespaceId && "cat" == name)
    return new CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new Values();
    
if( 11 == namespaceId && "bubble3D" == name)
    return new Bubble3D();
    
if( 11 == namespaceId && "extLst" == name)
    return new SurfaceSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","pictureOptions","cat","val","bubble3D","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Order Order
    {
        get => GetElement<Order>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public SeriesText SeriesText
    {
        get => GetElement<SeriesText>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureOptions PictureOptions
    {
        get => GetElement<PictureOptions>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> CategoryAxisData.</para>
    /// <para> Represents the following element tag in the schema: c:cat </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public CategoryAxisData CategoryAxisData
    {
        get => GetElement<CategoryAxisData>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Values.</para>
    /// <para> Represents the following element tag in the schema: c:val </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Values Values
    {
        get => GetElement<Values>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Bubble3D.</para>
    /// <para> Represents the following element tag in the schema: c:bubble3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Bubble3D Bubble3D
    {
        get => GetElement<Bubble3D>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> SurfaceSerExtensionList.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public SurfaceSerExtensionList SurfaceSerExtensionList
    {
        get => GetElement<SurfaceSerExtensionList>(8);
        set => SetElement(8, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChartSeries>(deep);

}
/// <summary>
/// <para>Band Formats.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:bandFmts.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BandFormat &lt;c:bandFmt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BandFormat))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BandFormats : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10378;
    /// <inheritdoc/>
    public override string LocalName => "bandFmts";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BandFormats class.
    /// </summary>
    public BandFormats():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BandFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BandFormats(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BandFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BandFormats(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BandFormats class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BandFormats(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "bandFmt" == name)
    return new BandFormat();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BandFormats>(deep);

}
/// <summary>
/// <para>Scaling.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:scaling.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LogBase &lt;c:logBase></description></item>
///<item><description>Orientation &lt;c:orientation></description></item>
///<item><description>MaxAxisValue &lt;c:max></description></item>
///<item><description>MinAxisValue &lt;c:min></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LogBase))]
    [ChildElementInfo(typeof(Orientation))]
    [ChildElementInfo(typeof(MaxAxisValue))]
    [ChildElementInfo(typeof(MinAxisValue))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Scaling : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10380;
    /// <inheritdoc/>
    public override string LocalName => "scaling";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Scaling class.
    /// </summary>
    public Scaling():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Scaling class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Scaling(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Scaling class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Scaling(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Scaling class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Scaling(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "logBase" == name)
    return new LogBase();
    
if( 11 == namespaceId && "orientation" == name)
    return new Orientation();
    
if( 11 == namespaceId && "max" == name)
    return new MaxAxisValue();
    
if( 11 == namespaceId && "min" == name)
    return new MinAxisValue();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "logBase","orientation","max","min","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Logarithmic Base.</para>
    /// <para> Represents the following element tag in the schema: c:logBase </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public LogBase LogBase
    {
        get => GetElement<LogBase>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Axis Orientation.</para>
    /// <para> Represents the following element tag in the schema: c:orientation </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Orientation Orientation
    {
        get => GetElement<Orientation>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Maximum.</para>
    /// <para> Represents the following element tag in the schema: c:max </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MaxAxisValue MaxAxisValue
    {
        get => GetElement<MaxAxisValue>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Minimum.</para>
    /// <para> Represents the following element tag in the schema: c:min </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MinAxisValue MinAxisValue
    {
        get => GetElement<MinAxisValue>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(4);
        set => SetElement(4, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scaling>(deep);

}
/// <summary>
/// <para>Axis Position.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:axPos.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AxisPosition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10382;
    /// <inheritdoc/>
    public override string LocalName => "axPos";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Axis Position Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the AxisPosition class.
    /// </summary>
    public AxisPosition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisPosition>(deep);

}
/// <summary>
/// <para>Title.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:title.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartText &lt;c:tx></description></item>
///<item><description>Layout &lt;c:layout></description></item>
///<item><description>Overlay &lt;c:overlay></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ChartText))]
    [ChildElementInfo(typeof(Layout))]
    [ChildElementInfo(typeof(Overlay))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Title : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10385;
    /// <inheritdoc/>
    public override string LocalName => "title";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Title class.
    /// </summary>
    public Title():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Title class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Title(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Title class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Title(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Title class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Title(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "tx" == name)
    return new ChartText();
    
if( 11 == namespaceId && "layout" == name)
    return new Layout();
    
if( 11 == namespaceId && "overlay" == name)
    return new Overlay();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "tx","layout","overlay","spPr","txPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Chart Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartText ChartText
    {
        get => GetElement<ChartText>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Layout.</para>
    /// <para> Represents the following element tag in the schema: c:layout </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Layout Layout
    {
        get => GetElement<Layout>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Overlay.</para>
    /// <para> Represents the following element tag in the schema: c:overlay </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Overlay Overlay
    {
        get => GetElement<Overlay>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> TextProperties.</para>
    /// <para> Represents the following element tag in the schema: c:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TextProperties TextProperties
    {
        get => GetElement<TextProperties>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Title>(deep);

}
/// <summary>
/// <para>Major Tick Mark.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:majorTickMark.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MajorTickMark : TickMarkType
{
    internal const int ElementTypeIdConst = 10386;
    /// <inheritdoc/>
    public override string LocalName => "majorTickMark";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MajorTickMark class.
    /// </summary>
    public MajorTickMark():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorTickMark>(deep);

}
/// <summary>
/// <para>Minor Tick Mark.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:minorTickMark.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MinorTickMark : TickMarkType
{
    internal const int ElementTypeIdConst = 10387;
    /// <inheritdoc/>
    public override string LocalName => "minorTickMark";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MinorTickMark class.
    /// </summary>
    public MinorTickMark():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorTickMark>(deep);

}
/// <summary>
/// Defines the TickMarkType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class TickMarkType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Tick Mark Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TickMarkType class.
    /// </summary>
    protected TickMarkType(){}
    
    
    
}
/// <summary>
/// <para>Tick Label Position.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:tickLblPos.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TickLabelPosition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10388;
    /// <inheritdoc/>
    public override string LocalName => "tickLblPos";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Tick Label Position Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TickLabelPosition class.
    /// </summary>
    public TickLabelPosition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TickLabelPosition>(deep);

}
/// <summary>
/// <para>Crosses.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:crosses.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Crosses : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10390;
    /// <inheritdoc/>
    public override string LocalName => "crosses";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Crosses Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Crosses class.
    /// </summary>
    public Crosses():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Crosses>(deep);

}
/// <summary>
/// <para>Crossing Value.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:crossesAt.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CrossesAt : DoubleType
{
    internal const int ElementTypeIdConst = 10391;
    /// <inheritdoc/>
    public override string LocalName => "crossesAt";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the CrossesAt class.
    /// </summary>
    public CrossesAt():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CrossesAt>(deep);

}
/// <summary>
/// <para>Left.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:x.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Left : DoubleType
{
    internal const int ElementTypeIdConst = 10412;
    /// <inheritdoc/>
    public override string LocalName => "x";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Left class.
    /// </summary>
    public Left():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Left>(deep);

}
/// <summary>
/// <para>Top.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:y.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Top : DoubleType
{
    internal const int ElementTypeIdConst = 10413;
    /// <inheritdoc/>
    public override string LocalName => "y";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Top class.
    /// </summary>
    public Top():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Top>(deep);

}
/// <summary>
/// <para>Width.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:w.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Width : DoubleType
{
    internal const int ElementTypeIdConst = 10414;
    /// <inheritdoc/>
    public override string LocalName => "w";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Width class.
    /// </summary>
    public Width():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Width>(deep);

}
/// <summary>
/// <para>Height.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:h.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Height : DoubleType
{
    internal const int ElementTypeIdConst = 10415;
    /// <inheritdoc/>
    public override string LocalName => "h";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Height class.
    /// </summary>
    public Height():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Height>(deep);

}
/// <summary>
/// <para>Forward.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:forward.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Forward : DoubleType
{
    internal const int ElementTypeIdConst = 10440;
    /// <inheritdoc/>
    public override string LocalName => "forward";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Forward class.
    /// </summary>
    public Forward():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Forward>(deep);

}
/// <summary>
/// <para>Backward.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:backward.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Backward : DoubleType
{
    internal const int ElementTypeIdConst = 10441;
    /// <inheritdoc/>
    public override string LocalName => "backward";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Backward class.
    /// </summary>
    public Backward():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Backward>(deep);

}
/// <summary>
/// <para>Intercept.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:intercept.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Intercept : DoubleType
{
    internal const int ElementTypeIdConst = 10442;
    /// <inheritdoc/>
    public override string LocalName => "intercept";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Intercept class.
    /// </summary>
    public Intercept():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Intercept>(deep);

}
/// <summary>
/// <para>Error Bar Value.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:val.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ErrorBarValue : DoubleType
{
    internal const int ElementTypeIdConst = 10452;
    /// <inheritdoc/>
    public override string LocalName => "val";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ErrorBarValue class.
    /// </summary>
    public ErrorBarValue():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBarValue>(deep);

}
/// <summary>
/// <para>Split Position.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:splitPos.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SplitPosition : DoubleType
{
    internal const int ElementTypeIdConst = 10458;
    /// <inheritdoc/>
    public override string LocalName => "splitPos";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the SplitPosition class.
    /// </summary>
    public SplitPosition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitPosition>(deep);

}
/// <summary>
/// <para>Custom Display Unit.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:custUnit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CustomDisplayUnit : DoubleType
{
    internal const int ElementTypeIdConst = 10468;
    /// <inheritdoc/>
    public override string LocalName => "custUnit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the CustomDisplayUnit class.
    /// </summary>
    public CustomDisplayUnit():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomDisplayUnit>(deep);

}
/// <summary>
/// <para>Maximum.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:max.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MaxAxisValue : DoubleType
{
    internal const int ElementTypeIdConst = 10473;
    /// <inheritdoc/>
    public override string LocalName => "max";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MaxAxisValue class.
    /// </summary>
    public MaxAxisValue():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MaxAxisValue>(deep);

}
/// <summary>
/// <para>Minimum.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:min.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MinAxisValue : DoubleType
{
    internal const int ElementTypeIdConst = 10474;
    /// <inheritdoc/>
    public override string LocalName => "min";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MinAxisValue class.
    /// </summary>
    public MinAxisValue():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinAxisValue>(deep);

}
/// <summary>
/// Defines the DoubleType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class DoubleType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<DoubleValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Floating Point Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public DoubleValue Val
    {
        get { return (DoubleValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DoubleType class.
    /// </summary>
    protected DoubleType(){}
    
    
    
}
/// <summary>
/// <para>Chart Space. The root element of ChartPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:chartSpace.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Date1904 &lt;c:date1904></description></item>
///<item><description>EditingLanguage &lt;c:lang></description></item>
///<item><description>RoundedCorners &lt;c:roundedCorners></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style &lt;c14:style></description></item>
///<item><description>Style &lt;c:style></description></item>
///<item><description>ColorMapOverride &lt;c:clrMapOvr></description></item>
///<item><description>PivotSource &lt;c:pivotSource></description></item>
///<item><description>Protection &lt;c:protection></description></item>
///<item><description>Chart &lt;c:chart></description></item>
///<item><description>ShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>ExternalData &lt;c:externalData></description></item>
///<item><description>PrintSettings &lt;c:printSettings></description></item>
///<item><description>UserShapesReference &lt;c:userShapes></description></item>
///<item><description>ChartSpaceExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Date1904))]
    [ChildElementInfo(typeof(EditingLanguage))]
    [ChildElementInfo(typeof(RoundedCorners))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Style))]
    [ChildElementInfo(typeof(ColorMapOverride))]
    [ChildElementInfo(typeof(PivotSource))]
    [ChildElementInfo(typeof(Protection))]
    [ChildElementInfo(typeof(Chart))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(ExternalData))]
    [ChildElementInfo(typeof(PrintSettings))]
    [ChildElementInfo(typeof(UserShapesReference))]
    [ChildElementInfo(typeof(ChartSpaceExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ChartSpace : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 10392;
    /// <inheritdoc/>
    public override string LocalName => "chartSpace";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    
	internal ChartSpace(ChartPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the ChartPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(ChartPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the ChartPart associated with this element.
    /// </summary>
    public ChartPart ChartPart
    {
		get => OpenXmlPart as ChartPart;
		internal set => OpenXmlPart = value;
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
    public ChartSpace():base(){}
    
    /// <summary>
    /// Saves the DOM into the ChartPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(ChartPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "date1904" == name)
    return new Date1904();
    
if( 11 == namespaceId && "lang" == name)
    return new EditingLanguage();
    
if( 11 == namespaceId && "roundedCorners" == name)
    return new RoundedCorners();
    
if( 46 == namespaceId && "style" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style();
    
if( 11 == namespaceId && "style" == name)
    return new Style();
    
if( 11 == namespaceId && "clrMapOvr" == name)
    return new ColorMapOverride();
    
if( 11 == namespaceId && "pivotSource" == name)
    return new PivotSource();
    
if( 11 == namespaceId && "protection" == name)
    return new Protection();
    
if( 11 == namespaceId && "chart" == name)
    return new Chart();
    
if( 11 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "externalData" == name)
    return new ExternalData();
    
if( 11 == namespaceId && "printSettings" == name)
    return new PrintSettings();
    
if( 11 == namespaceId && "userShapes" == name)
    return new UserShapesReference();
    
if( 11 == namespaceId && "extLst" == name)
    return new ChartSpaceExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "date1904","lang","roundedCorners","style","style","clrMapOvr","pivotSource","protection","chart","spPr","txPr","externalData","printSettings","userShapes","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,46,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Date1904.</para>
    /// <para> Represents the following element tag in the schema: c:date1904 </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Date1904 Date1904
    {
        get => GetElement<Date1904>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> EditingLanguage.</para>
    /// <para> Represents the following element tag in the schema: c:lang </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public EditingLanguage EditingLanguage
    {
        get => GetElement<EditingLanguage>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> RoundedCorners.</para>
    /// <para> Represents the following element tag in the schema: c:roundedCorners </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public RoundedCorners RoundedCorners
    {
        get => GetElement<RoundedCorners>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartSpace>(deep);

}
/// <summary>
/// <para>User Shapes. The root element of ChartDrawingPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:userShapes.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize &lt;cdr:relSizeAnchor></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize &lt;cdr:absSizeAnchor></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class UserShapes : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 10393;
    /// <inheritdoc/>
    public override string LocalName => "userShapes";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    
	internal UserShapes(ChartDrawingPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the ChartDrawingPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(ChartDrawingPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the ChartDrawingPart associated with this element.
    /// </summary>
    public ChartDrawingPart ChartDrawingPart
    {
		get => OpenXmlPart as ChartDrawingPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the UserShapes class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UserShapes(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UserShapes class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UserShapes(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UserShapes class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public UserShapes(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the UserShapes class.
    /// </summary>
    public UserShapes():base(){}
    
    /// <summary>
    /// Saves the DOM into the ChartDrawingPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(ChartDrawingPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 12 == namespaceId && "relSizeAnchor" == name)
    return new DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize();
    
if( 12 == namespaceId && "absSizeAnchor" == name)
    return new DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UserShapes>(deep);

}
/// <summary>
/// <para>Reference to Chart Part.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:chart.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ChartReference : RelationshipIdType
{
    internal const int ElementTypeIdConst = 10394;
    /// <inheritdoc/>
    public override string LocalName => "chart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ChartReference class.
    /// </summary>
    public ChartReference():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartReference>(deep);

}
/// <summary>
/// <para>Legacy Drawing for Headers and Footers.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:legacyDrawingHF.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LegacyDrawingHeaderFooter : RelationshipIdType
{
    internal const int ElementTypeIdConst = 10504;
    /// <inheritdoc/>
    public override string LocalName => "legacyDrawingHF";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the LegacyDrawingHeaderFooter class.
    /// </summary>
    public LegacyDrawingHeaderFooter():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegacyDrawingHeaderFooter>(deep);

}
/// <summary>
/// <para>Defines the UserShapesReference Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:userShapes.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class UserShapesReference : RelationshipIdType
{
    internal const int ElementTypeIdConst = 10649;
    /// <inheritdoc/>
    public override string LocalName => "userShapes";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the UserShapesReference class.
    /// </summary>
    public UserShapesReference():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UserShapesReference>(deep);

}
/// <summary>
/// Defines the RelationshipIdType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class RelationshipIdType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(19, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Relationship Reference.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RelationshipIdType class.
    /// </summary>
    protected RelationshipIdType(){}
    
    
    
}
/// <summary>
/// <para>Extension.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Extension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10395;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Uniform Resource Identifier.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Extension class.
    /// </summary>
    public Extension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Extension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Extension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Extension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Extension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Extension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Extension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    
    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extension>(deep);

}
/// <summary>
/// <para>Numeric Value.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:v.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NumericValue : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10396;
    /// <inheritdoc/>
    public override string LocalName => "v";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericValue>(deep);

}
/// <summary>
/// <para>Format Code.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:formatCode.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FormatCode : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10397;
    /// <inheritdoc/>
    public override string LocalName => "formatCode";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the FormatCode class.
    /// </summary>
    public FormatCode():base(){}
    
        /// <summary>
    /// Initializes a new instance of the FormatCode class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FormatCode(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormatCode>(deep);

}
/// <summary>
/// <para>Odd Header.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:oddHeader.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class OddHeader : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10494;
    /// <inheritdoc/>
    public override string LocalName => "oddHeader";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the OddHeader class.
    /// </summary>
    public OddHeader():base(){}
    
        /// <summary>
    /// Initializes a new instance of the OddHeader class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public OddHeader(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OddHeader>(deep);

}
/// <summary>
/// <para>Odd Footer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:oddFooter.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class OddFooter : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10495;
    /// <inheritdoc/>
    public override string LocalName => "oddFooter";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the OddFooter class.
    /// </summary>
    public OddFooter():base(){}
    
        /// <summary>
    /// Initializes a new instance of the OddFooter class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public OddFooter(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OddFooter>(deep);

}
/// <summary>
/// <para>Even Header.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:evenHeader.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EvenHeader : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10496;
    /// <inheritdoc/>
    public override string LocalName => "evenHeader";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the EvenHeader class.
    /// </summary>
    public EvenHeader():base(){}
    
        /// <summary>
    /// Initializes a new instance of the EvenHeader class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EvenHeader(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EvenHeader>(deep);

}
/// <summary>
/// <para>Even Footer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:evenFooter.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EvenFooter : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10497;
    /// <inheritdoc/>
    public override string LocalName => "evenFooter";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the EvenFooter class.
    /// </summary>
    public EvenFooter():base(){}
    
        /// <summary>
    /// Initializes a new instance of the EvenFooter class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EvenFooter(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EvenFooter>(deep);

}
/// <summary>
/// <para>First Header.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:firstHeader.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FirstHeader : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10498;
    /// <inheritdoc/>
    public override string LocalName => "firstHeader";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the FirstHeader class.
    /// </summary>
    public FirstHeader():base(){}
    
        /// <summary>
    /// Initializes a new instance of the FirstHeader class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FirstHeader(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstHeader>(deep);

}
/// <summary>
/// <para>First Footer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:firstFooter.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FirstFooter : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10499;
    /// <inheritdoc/>
    public override string LocalName => "firstFooter";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the FirstFooter class.
    /// </summary>
    public FirstFooter():base(){}
    
        /// <summary>
    /// Initializes a new instance of the FirstFooter class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FirstFooter(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstFooter>(deep);

}
/// <summary>
/// <para>Pivot Name.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:name.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PivotTableName : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10505;
    /// <inheritdoc/>
    public override string LocalName => "name";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the PivotTableName class.
    /// </summary>
    public PivotTableName():base(){}
    
        /// <summary>
    /// Initializes a new instance of the PivotTableName class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PivotTableName(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableName>(deep);

}
/// <summary>
/// <para>Numeric Point.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pt.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumericValue &lt;c:v></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NumericValue))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NumericPoint : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10399;
    /// <inheritdoc/>
    public override string LocalName => "pt";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "idx"),
		AttributeTag.Create<StringValue>(0, "formatCode")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Index.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    public UInt32Value Index
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Number Format.</para>
    /// <para>Represents the following attribute in the schema: formatCode </para>
    /// </summary>
    [SchemaAttr(0, "formatCode")]
    public StringValue FormatCode
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NumericPoint class.
    /// </summary>
    public NumericPoint():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NumericPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumericPoint(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumericPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumericPoint(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumericPoint class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumericPoint(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "v" == name)
    return new NumericValue();
    

    return null;
}

        private static readonly string[] eleTagNames = { "v" };
    private static readonly byte[] eleNamespaceIds = { 11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Numeric Value.</para>
    /// <para> Represents the following element tag in the schema: c:v </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumericValue NumericValue
    {
        get => GetElement<NumericValue>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericPoint>(deep);

}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Extension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Extension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10400;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    if( 11 == namespaceId && "ext" == name)
    return new Extension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);

}
/// <summary>
/// <para>Number Reference.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:numRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;c:f></description></item>
///<item><description>NumberingCache &lt;c:numCache></description></item>
///<item><description>NumRefExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Formula))]
    [ChildElementInfo(typeof(NumberingCache))]
    [ChildElementInfo(typeof(NumRefExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NumberReference : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10401;
    /// <inheritdoc/>
    public override string LocalName => "numRef";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NumberReference class.
    /// </summary>
    public NumberReference():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NumberReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumberReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumberReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumberReference(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "f" == name)
    return new Formula();
    
if( 11 == namespaceId && "numCache" == name)
    return new NumberingCache();
    
if( 11 == namespaceId && "extLst" == name)
    return new NumRefExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "f","numCache","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: c:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Formula Formula
    {
        get => GetElement<Formula>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> NumberingCache.</para>
    /// <para> Represents the following element tag in the schema: c:numCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumberingCache NumberingCache
    {
        get => GetElement<NumberingCache>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> NumRefExtensionList.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumRefExtensionList NumRefExtensionList
    {
        get => GetElement<NumRefExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberReference>(deep);

}
/// <summary>
/// <para>Number Literal.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:numLit.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FormatCode &lt;c:formatCode></description></item>
///<item><description>PointCount &lt;c:ptCount></description></item>
///<item><description>NumericPoint &lt;c:pt></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NumberLiteral : NumberDataType
{
    internal const int ElementTypeIdConst = 10402;
    /// <inheritdoc/>
    public override string LocalName => "numLit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the NumberLiteral class.
    /// </summary>
    public NumberLiteral():base(){}
        /// <summary>
    ///Initializes a new instance of the NumberLiteral class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumberLiteral(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberLiteral class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumberLiteral(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberLiteral class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumberLiteral(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberLiteral>(deep);

}
/// <summary>
/// <para>Defines the NumberingCache Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:numCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FormatCode &lt;c:formatCode></description></item>
///<item><description>PointCount &lt;c:ptCount></description></item>
///<item><description>NumericPoint &lt;c:pt></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NumberingCache : NumberDataType
{
    internal const int ElementTypeIdConst = 10571;
    /// <inheritdoc/>
    public override string LocalName => "numCache";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the NumberingCache class.
    /// </summary>
    public NumberingCache():base(){}
        /// <summary>
    ///Initializes a new instance of the NumberingCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumberingCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberingCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumberingCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberingCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumberingCache(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberingCache>(deep);

}
/// <summary>
/// Defines the NumberDataType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FormatCode &lt;c:formatCode></description></item>
///<item><description>PointCount &lt;c:ptCount></description></item>
///<item><description>NumericPoint &lt;c:pt></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(FormatCode))]
    [ChildElementInfo(typeof(PointCount))]
    [ChildElementInfo(typeof(NumericPoint))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class NumberDataType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "formatCode" == name)
    return new FormatCode();
    
if( 11 == namespaceId && "ptCount" == name)
    return new PointCount();
    
if( 11 == namespaceId && "pt" == name)
    return new NumericPoint();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "formatCode","ptCount","pt","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Format Code.</para>
    /// <para> Represents the following element tag in the schema: c:formatCode </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public FormatCode FormatCode
    {
        get => GetElement<FormatCode>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Point Count.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PointCount PointCount
    {
        get => GetElement<PointCount>(1);
        set => SetElement(1, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the NumberDataType class.
    /// </summary>
    protected NumberDataType(){}
    
        /// <summary>
    ///Initializes a new instance of the NumberDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected NumberDataType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected NumberDataType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberDataType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected NumberDataType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Level.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:lvl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StringPoint &lt;c:pt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StringPoint))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Level : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10403;
    /// <inheritdoc/>
    public override string LocalName => "lvl";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Level class.
    /// </summary>
    public Level():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Level class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Level(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Level class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Level(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Level class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Level(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "pt" == name)
    return new StringPoint();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Level>(deep);

}
/// <summary>
/// <para>Multi Level String Reference.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:multiLvlStrRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;c:f></description></item>
///<item><description>MultiLevelStringCache &lt;c:multiLvlStrCache></description></item>
///<item><description>MultiLvlStrRefExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Formula))]
    [ChildElementInfo(typeof(MultiLevelStringCache))]
    [ChildElementInfo(typeof(MultiLvlStrRefExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MultiLevelStringReference : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10404;
    /// <inheritdoc/>
    public override string LocalName => "multiLvlStrRef";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MultiLevelStringReference class.
    /// </summary>
    public MultiLevelStringReference():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MultiLevelStringReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLevelStringReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLevelStringReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLevelStringReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLevelStringReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MultiLevelStringReference(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "f" == name)
    return new Formula();
    
if( 11 == namespaceId && "multiLvlStrCache" == name)
    return new MultiLevelStringCache();
    
if( 11 == namespaceId && "extLst" == name)
    return new MultiLvlStrRefExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "f","multiLvlStrCache","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: c:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Formula Formula
    {
        get => GetElement<Formula>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> MultiLevelStringCache.</para>
    /// <para> Represents the following element tag in the schema: c:multiLvlStrCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MultiLevelStringCache MultiLevelStringCache
    {
        get => GetElement<MultiLevelStringCache>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> MultiLvlStrRefExtensionList.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MultiLvlStrRefExtensionList MultiLvlStrRefExtensionList
    {
        get => GetElement<MultiLvlStrRefExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLevelStringReference>(deep);

}
/// <summary>
/// <para>Defines the StringReference Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:strRef.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Formula &lt;c:f></description></item>
///<item><description>StringCache &lt;c:strCache></description></item>
///<item><description>StrRefExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Formula))]
    [ChildElementInfo(typeof(StringCache))]
    [ChildElementInfo(typeof(StrRefExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StringReference : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10405;
    /// <inheritdoc/>
    public override string LocalName => "strRef";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the StringReference class.
    /// </summary>
    public StringReference():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StringReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StringReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StringReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StringReference(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "f" == name)
    return new Formula();
    
if( 11 == namespaceId && "strCache" == name)
    return new StringCache();
    
if( 11 == namespaceId && "extLst" == name)
    return new StrRefExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "f","strCache","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: c:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Formula Formula
    {
        get => GetElement<Formula>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> StringCache.</para>
    /// <para> Represents the following element tag in the schema: c:strCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public StringCache StringCache
    {
        get => GetElement<StringCache>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> StrRefExtensionList.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public StrRefExtensionList StrRefExtensionList
    {
        get => GetElement<StrRefExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringReference>(deep);

}
/// <summary>
/// <para>String Literal.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:strLit.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PointCount &lt;c:ptCount></description></item>
///<item><description>StringPoint &lt;c:pt></description></item>
///<item><description>StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StringLiteral : StringDataType
{
    internal const int ElementTypeIdConst = 10406;
    /// <inheritdoc/>
    public override string LocalName => "strLit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the StringLiteral class.
    /// </summary>
    public StringLiteral():base(){}
        /// <summary>
    ///Initializes a new instance of the StringLiteral class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringLiteral(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StringLiteral class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringLiteral(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StringLiteral class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StringLiteral(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringLiteral>(deep);

}
/// <summary>
/// <para>Defines the StringCache Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:strCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PointCount &lt;c:ptCount></description></item>
///<item><description>StringPoint &lt;c:pt></description></item>
///<item><description>StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StringCache : StringDataType
{
    internal const int ElementTypeIdConst = 10574;
    /// <inheritdoc/>
    public override string LocalName => "strCache";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the StringCache class.
    /// </summary>
    public StringCache():base(){}
        /// <summary>
    ///Initializes a new instance of the StringCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StringCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StringCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StringCache(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringCache>(deep);

}
/// <summary>
/// Defines the StringDataType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PointCount &lt;c:ptCount></description></item>
///<item><description>StringPoint &lt;c:pt></description></item>
///<item><description>StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PointCount))]
    [ChildElementInfo(typeof(StringPoint))]
    [ChildElementInfo(typeof(StrDataExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class StringDataType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ptCount" == name)
    return new PointCount();
    
if( 11 == namespaceId && "pt" == name)
    return new StringPoint();
    
if( 11 == namespaceId && "extLst" == name)
    return new StrDataExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ptCount","pt","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PointCount.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PointCount PointCount
    {
        get => GetElement<PointCount>(0);
        set => SetElement(0, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the StringDataType class.
    /// </summary>
    protected StringDataType(){}
    
        /// <summary>
    ///Initializes a new instance of the StringDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected StringDataType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected StringDataType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected StringDataType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Layout Target.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:layoutTarget.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LayoutTarget : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10407;
    /// <inheritdoc/>
    public override string LocalName => "layoutTarget";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Layout Target Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LayoutTarget class.
    /// </summary>
    public LayoutTarget():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutTarget>(deep);

}
/// <summary>
/// <para>Left Mode.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:xMode.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LeftMode : LayoutModeType
{
    internal const int ElementTypeIdConst = 10408;
    /// <inheritdoc/>
    public override string LocalName => "xMode";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the LeftMode class.
    /// </summary>
    public LeftMode():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeftMode>(deep);

}
/// <summary>
/// <para>Top Mode.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:yMode.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TopMode : LayoutModeType
{
    internal const int ElementTypeIdConst = 10409;
    /// <inheritdoc/>
    public override string LocalName => "yMode";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the TopMode class.
    /// </summary>
    public TopMode():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TopMode>(deep);

}
/// <summary>
/// <para>Width Mode.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:wMode.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WidthMode : LayoutModeType
{
    internal const int ElementTypeIdConst = 10410;
    /// <inheritdoc/>
    public override string LocalName => "wMode";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the WidthMode class.
    /// </summary>
    public WidthMode():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WidthMode>(deep);

}
/// <summary>
/// <para>Height Mode.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:hMode.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HeightMode : LayoutModeType
{
    internal const int ElementTypeIdConst = 10411;
    /// <inheritdoc/>
    public override string LocalName => "hMode";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HeightMode class.
    /// </summary>
    public HeightMode():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeightMode>(deep);

}
/// <summary>
/// Defines the LayoutModeType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class LayoutModeType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Layout Mode Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LayoutModeType class.
    /// </summary>
    protected LayoutModeType(){}
    
    
    
}
/// <summary>
/// <para>Manual Layout.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:manualLayout.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LayoutTarget &lt;c:layoutTarget></description></item>
///<item><description>LeftMode &lt;c:xMode></description></item>
///<item><description>TopMode &lt;c:yMode></description></item>
///<item><description>WidthMode &lt;c:wMode></description></item>
///<item><description>HeightMode &lt;c:hMode></description></item>
///<item><description>Left &lt;c:x></description></item>
///<item><description>Top &lt;c:y></description></item>
///<item><description>Width &lt;c:w></description></item>
///<item><description>Height &lt;c:h></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LayoutTarget))]
    [ChildElementInfo(typeof(LeftMode))]
    [ChildElementInfo(typeof(TopMode))]
    [ChildElementInfo(typeof(WidthMode))]
    [ChildElementInfo(typeof(HeightMode))]
    [ChildElementInfo(typeof(Left))]
    [ChildElementInfo(typeof(Top))]
    [ChildElementInfo(typeof(Width))]
    [ChildElementInfo(typeof(Height))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ManualLayout : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10416;
    /// <inheritdoc/>
    public override string LocalName => "manualLayout";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ManualLayout class.
    /// </summary>
    public ManualLayout():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ManualLayout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ManualLayout(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ManualLayout class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ManualLayout(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ManualLayout class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ManualLayout(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "layoutTarget" == name)
    return new LayoutTarget();
    
if( 11 == namespaceId && "xMode" == name)
    return new LeftMode();
    
if( 11 == namespaceId && "yMode" == name)
    return new TopMode();
    
if( 11 == namespaceId && "wMode" == name)
    return new WidthMode();
    
if( 11 == namespaceId && "hMode" == name)
    return new HeightMode();
    
if( 11 == namespaceId && "x" == name)
    return new Left();
    
if( 11 == namespaceId && "y" == name)
    return new Top();
    
if( 11 == namespaceId && "w" == name)
    return new Width();
    
if( 11 == namespaceId && "h" == name)
    return new Height();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "layoutTarget","xMode","yMode","wMode","hMode","x","y","w","h","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Layout Target.</para>
    /// <para> Represents the following element tag in the schema: c:layoutTarget </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public LayoutTarget LayoutTarget
    {
        get => GetElement<LayoutTarget>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Left Mode.</para>
    /// <para> Represents the following element tag in the schema: c:xMode </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public LeftMode LeftMode
    {
        get => GetElement<LeftMode>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Top Mode.</para>
    /// <para> Represents the following element tag in the schema: c:yMode </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TopMode TopMode
    {
        get => GetElement<TopMode>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Width Mode.</para>
    /// <para> Represents the following element tag in the schema: c:wMode </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public WidthMode WidthMode
    {
        get => GetElement<WidthMode>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Height Mode.</para>
    /// <para> Represents the following element tag in the schema: c:hMode </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public HeightMode HeightMode
    {
        get => GetElement<HeightMode>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Left.</para>
    /// <para> Represents the following element tag in the schema: c:x </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Left Left
    {
        get => GetElement<Left>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Top.</para>
    /// <para> Represents the following element tag in the schema: c:y </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Top Top
    {
        get => GetElement<Top>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Width.</para>
    /// <para> Represents the following element tag in the schema: c:w </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Width Width
    {
        get => GetElement<Width>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Height.</para>
    /// <para> Represents the following element tag in the schema: c:h </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Height Height
    {
        get => GetElement<Height>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(9);
        set => SetElement(9, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ManualLayout>(deep);

}
/// <summary>
/// <para>X Rotation.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:rotX.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RotateX : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10418;
    /// <inheritdoc/>
    public override string LocalName => "rotX";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<SByteValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> X Rotation Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public SByteValue Val
    {
        get { return (SByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RotateX class.
    /// </summary>
    public RotateX():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RotateX>(deep);

}
/// <summary>
/// <para>Height Percent.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:hPercent.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HeightPercent : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10419;
    /// <inheritdoc/>
    public override string LocalName => "hPercent";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt16Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Height Percent Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt16Value Val
    {
        get { return (UInt16Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the HeightPercent class.
    /// </summary>
    public HeightPercent():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeightPercent>(deep);

}
/// <summary>
/// <para>Y Rotation.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:rotY.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RotateY : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10420;
    /// <inheritdoc/>
    public override string LocalName => "rotY";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt16Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Y Rotation Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt16Value Val
    {
        get { return (UInt16Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RotateY class.
    /// </summary>
    public RotateY():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RotateY>(deep);

}
/// <summary>
/// <para>Depth Percent.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:depthPercent.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DepthPercent : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10421;
    /// <inheritdoc/>
    public override string LocalName => "depthPercent";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt16Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Depth Percent Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt16Value Val
    {
        get { return (UInt16Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DepthPercent class.
    /// </summary>
    public DepthPercent():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DepthPercent>(deep);

}
/// <summary>
/// <para>Perspective.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:perspective.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Perspective : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10423;
    /// <inheritdoc/>
    public override string LocalName => "perspective";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<ByteValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Perspective Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public ByteValue Val
    {
        get { return (ByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Perspective class.
    /// </summary>
    public Perspective():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Perspective>(deep);

}
/// <summary>
/// <para>Symbol.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:symbol.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Symbol : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10429;
    /// <inheritdoc/>
    public override string LocalName => "symbol";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Marker Style Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Symbol class.
    /// </summary>
    public Symbol():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Symbol>(deep);

}
/// <summary>
/// <para>Size.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:size.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Size : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10430;
    /// <inheritdoc/>
    public override string LocalName => "size";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<ByteValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Marker Size Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public ByteValue Val
    {
        get { return (ByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Size class.
    /// </summary>
    public Size():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Size>(deep);

}
/// <summary>
/// <para>Marker.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:marker.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Symbol &lt;c:symbol></description></item>
///<item><description>Size &lt;c:size></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Symbol))]
    [ChildElementInfo(typeof(Size))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Marker : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10432;
    /// <inheritdoc/>
    public override string LocalName => "marker";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Marker class.
    /// </summary>
    public Marker():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Marker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Marker(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Marker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Marker(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Marker class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Marker(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "symbol" == name)
    return new Symbol();
    
if( 11 == namespaceId && "size" == name)
    return new Size();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "symbol","size","spPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Symbol.</para>
    /// <para> Represents the following element tag in the schema: c:symbol </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Symbol Symbol
    {
        get => GetElement<Symbol>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Size.</para>
    /// <para> Represents the following element tag in the schema: c:size </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Size Size
    {
        get => GetElement<Size>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Marker>(deep);

}
/// <summary>
/// <para>Defines the PictureOptions Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pictureOptions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ApplyToFront &lt;c:applyToFront></description></item>
///<item><description>ApplyToSides &lt;c:applyToSides></description></item>
///<item><description>ApplyToEnd &lt;c:applyToEnd></description></item>
///<item><description>PictureFormat &lt;c:pictureFormat></description></item>
///<item><description>PictureStackUnit &lt;c:pictureStackUnit></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ApplyToFront))]
    [ChildElementInfo(typeof(ApplyToSides))]
    [ChildElementInfo(typeof(ApplyToEnd))]
    [ChildElementInfo(typeof(PictureFormat))]
    [ChildElementInfo(typeof(PictureStackUnit))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PictureOptions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10435;
    /// <inheritdoc/>
    public override string LocalName => "pictureOptions";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PictureOptions class.
    /// </summary>
    public PictureOptions():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PictureOptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PictureOptions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PictureOptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PictureOptions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PictureOptions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PictureOptions(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "applyToFront" == name)
    return new ApplyToFront();
    
if( 11 == namespaceId && "applyToSides" == name)
    return new ApplyToSides();
    
if( 11 == namespaceId && "applyToEnd" == name)
    return new ApplyToEnd();
    
if( 11 == namespaceId && "pictureFormat" == name)
    return new PictureFormat();
    
if( 11 == namespaceId && "pictureStackUnit" == name)
    return new PictureStackUnit();
    

    return null;
}

        private static readonly string[] eleTagNames = { "applyToFront","applyToSides","applyToEnd","pictureFormat","pictureStackUnit" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Apply To Front.</para>
    /// <para> Represents the following element tag in the schema: c:applyToFront </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ApplyToFront ApplyToFront
    {
        get => GetElement<ApplyToFront>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Apply To Sides.</para>
    /// <para> Represents the following element tag in the schema: c:applyToSides </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ApplyToSides ApplyToSides
    {
        get => GetElement<ApplyToSides>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Apply to End.</para>
    /// <para> Represents the following element tag in the schema: c:applyToEnd </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ApplyToEnd ApplyToEnd
    {
        get => GetElement<ApplyToEnd>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Picture Format.</para>
    /// <para> Represents the following element tag in the schema: c:pictureFormat </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureFormat PictureFormat
    {
        get => GetElement<PictureFormat>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Picture Stack Unit.</para>
    /// <para> Represents the following element tag in the schema: c:pictureStackUnit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureStackUnit PictureStackUnit
    {
        get => GetElement<PictureStackUnit>(4);
        set => SetElement(4, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureOptions>(deep);

}
/// <summary>
/// <para>Trendline Type.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:trendlineType.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TrendlineType : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10437;
    /// <inheritdoc/>
    public override string LocalName => "trendlineType";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Trendline Type Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TrendlineType class.
    /// </summary>
    public TrendlineType():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineType>(deep);

}
/// <summary>
/// <para>Polynomial Trendline Order.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:order.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PolynomialOrder : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10438;
    /// <inheritdoc/>
    public override string LocalName => "order";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<ByteValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Order Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public ByteValue Val
    {
        get { return (ByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PolynomialOrder class.
    /// </summary>
    public PolynomialOrder():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PolynomialOrder>(deep);

}
/// <summary>
/// <para>Period.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:period.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Period : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10439;
    /// <inheritdoc/>
    public override string LocalName => "period";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Period Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Period class.
    /// </summary>
    public Period():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Period>(deep);

}
/// <summary>
/// <para>Trendline Label.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:trendlineLbl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Layout &lt;c:layout></description></item>
///<item><description>ChartText &lt;c:tx></description></item>
///<item><description>NumberingFormat &lt;c:numFmt></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Layout))]
    [ChildElementInfo(typeof(ChartText))]
    [ChildElementInfo(typeof(NumberingFormat))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TrendlineLabel : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10445;
    /// <inheritdoc/>
    public override string LocalName => "trendlineLbl";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TrendlineLabel class.
    /// </summary>
    public TrendlineLabel():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TrendlineLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TrendlineLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TrendlineLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TrendlineLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TrendlineLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TrendlineLabel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "layout" == name)
    return new Layout();
    
if( 11 == namespaceId && "tx" == name)
    return new ChartText();
    
if( 11 == namespaceId && "numFmt" == name)
    return new NumberingFormat();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "layout","tx","numFmt","spPr","txPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Layout.</para>
    /// <para> Represents the following element tag in the schema: c:layout </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Layout Layout
    {
        get => GetElement<Layout>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ChartText.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartText ChartText
    {
        get => GetElement<ChartText>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Number Format.</para>
    /// <para> Represents the following element tag in the schema: c:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumberingFormat NumberingFormat
    {
        get => GetElement<NumberingFormat>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> TextProperties.</para>
    /// <para> Represents the following element tag in the schema: c:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TextProperties TextProperties
    {
        get => GetElement<TextProperties>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineLabel>(deep);

}
/// <summary>
/// <para>Error Bar Direction.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:errDir.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ErrorDirection : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10446;
    /// <inheritdoc/>
    public override string LocalName => "errDir";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Error Bar Direction Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ErrorDirection class.
    /// </summary>
    public ErrorDirection():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorDirection>(deep);

}
/// <summary>
/// <para>Error Bar Type.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:errBarType.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ErrorBarType : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10447;
    /// <inheritdoc/>
    public override string LocalName => "errBarType";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Error Bar Type Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ErrorBarType class.
    /// </summary>
    public ErrorBarType():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBarType>(deep);

}
/// <summary>
/// <para>Error Bar Value Type.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:errValType.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ErrorBarValueType : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10448;
    /// <inheritdoc/>
    public override string LocalName => "errValType";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Error Bar Type Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ErrorBarValueType class.
    /// </summary>
    public ErrorBarValueType():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBarValueType>(deep);

}
/// <summary>
/// <para>Plus.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:plus.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberReference &lt;c:numRef></description></item>
///<item><description>NumberLiteral &lt;c:numLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Plus : NumberDataSourceType
{
    internal const int ElementTypeIdConst = 10450;
    /// <inheritdoc/>
    public override string LocalName => "plus";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Plus class.
    /// </summary>
    public Plus():base(){}
        /// <summary>
    ///Initializes a new instance of the Plus class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Plus(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Plus class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Plus(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Plus class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Plus(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Plus>(deep);

}
/// <summary>
/// <para>Minus.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:minus.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberReference &lt;c:numRef></description></item>
///<item><description>NumberLiteral &lt;c:numLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Minus : NumberDataSourceType
{
    internal const int ElementTypeIdConst = 10451;
    /// <inheritdoc/>
    public override string LocalName => "minus";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Minus class.
    /// </summary>
    public Minus():base(){}
        /// <summary>
    ///Initializes a new instance of the Minus class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Minus(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Minus class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Minus(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Minus class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Minus(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Minus>(deep);

}
/// <summary>
/// <para>Defines the Values Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:val.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberReference &lt;c:numRef></description></item>
///<item><description>NumberLiteral &lt;c:numLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Values : NumberDataSourceType
{
    internal const int ElementTypeIdConst = 10584;
    /// <inheritdoc/>
    public override string LocalName => "val";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Values class.
    /// </summary>
    public Values():base(){}
        /// <summary>
    ///Initializes a new instance of the Values class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Values(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Values class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Values(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Values class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Values(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Values>(deep);

}
/// <summary>
/// <para>Defines the YValues Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:yVal.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberReference &lt;c:numRef></description></item>
///<item><description>NumberLiteral &lt;c:numLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class YValues : NumberDataSourceType
{
    internal const int ElementTypeIdConst = 10588;
    /// <inheritdoc/>
    public override string LocalName => "yVal";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the YValues class.
    /// </summary>
    public YValues():base(){}
        /// <summary>
    ///Initializes a new instance of the YValues class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public YValues(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the YValues class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public YValues(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the YValues class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public YValues(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<YValues>(deep);

}
/// <summary>
/// <para>Defines the BubbleSize Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:bubbleSize.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberReference &lt;c:numRef></description></item>
///<item><description>NumberLiteral &lt;c:numLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BubbleSize : NumberDataSourceType
{
    internal const int ElementTypeIdConst = 10596;
    /// <inheritdoc/>
    public override string LocalName => "bubbleSize";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the BubbleSize class.
    /// </summary>
    public BubbleSize():base(){}
        /// <summary>
    ///Initializes a new instance of the BubbleSize class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleSize(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleSize class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleSize(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleSize class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BubbleSize(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleSize>(deep);

}
/// <summary>
/// Defines the NumberDataSourceType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberReference &lt;c:numRef></description></item>
///<item><description>NumberLiteral &lt;c:numLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(NumberReference))]
    [ChildElementInfo(typeof(NumberLiteral))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class NumberDataSourceType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "numRef" == name)
    return new NumberReference();
    
if( 11 == namespaceId && "numLit" == name)
    return new NumberLiteral();
    

    return null;
}

        private static readonly string[] eleTagNames = { "numRef","numLit" };
    private static readonly byte[] eleNamespaceIds = { 11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Number Reference.</para>
    /// <para> Represents the following element tag in the schema: c:numRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumberReference NumberReference
    {
        get => GetElement<NumberReference>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Number Literal.</para>
    /// <para> Represents the following element tag in the schema: c:numLit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumberLiteral NumberLiteral
    {
        get => GetElement<NumberLiteral>(1);
        set => SetElement(1, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the NumberDataSourceType class.
    /// </summary>
    protected NumberDataSourceType(){}
    
        /// <summary>
    ///Initializes a new instance of the NumberDataSourceType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected NumberDataSourceType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberDataSourceType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected NumberDataSourceType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberDataSourceType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected NumberDataSourceType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Gap Width.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:gapWidth.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class GapWidth : GapAmountType
{
    internal const int ElementTypeIdConst = 10453;
    /// <inheritdoc/>
    public override string LocalName => "gapWidth";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the GapWidth class.
    /// </summary>
    public GapWidth():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GapWidth>(deep);

}
/// <summary>
/// <para>Defines the GapDepth Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:gapDepth.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class GapDepth : GapAmountType
{
    internal const int ElementTypeIdConst = 10602;
    /// <inheritdoc/>
    public override string LocalName => "gapDepth";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the GapDepth class.
    /// </summary>
    public GapDepth():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GapDepth>(deep);

}
/// <summary>
/// Defines the GapAmountType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class GapAmountType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt16Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Gap Size Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt16Value Val
    {
        get { return (UInt16Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the GapAmountType class.
    /// </summary>
    protected GapAmountType(){}
    
    
    
}
/// <summary>
/// <para>Up Bars.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:upBars.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class UpBars : UpDownBarType
{
    internal const int ElementTypeIdConst = 10454;
    /// <inheritdoc/>
    public override string LocalName => "upBars";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the UpBars class.
    /// </summary>
    public UpBars():base(){}
        /// <summary>
    ///Initializes a new instance of the UpBars class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UpBars(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UpBars class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UpBars(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UpBars class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public UpBars(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UpBars>(deep);

}
/// <summary>
/// <para>Down Bars.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:downBars.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DownBars : UpDownBarType
{
    internal const int ElementTypeIdConst = 10455;
    /// <inheritdoc/>
    public override string LocalName => "downBars";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the DownBars class.
    /// </summary>
    public DownBars():base(){}
        /// <summary>
    ///Initializes a new instance of the DownBars class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DownBars(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DownBars class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DownBars(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DownBars class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DownBars(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DownBars>(deep);

}
/// <summary>
/// Defines the UpDownBarType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ChartShapeProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class UpDownBarType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "spPr" };
    private static readonly byte[] eleNamespaceIds = { 11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(0);
        set => SetElement(0, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the UpDownBarType class.
    /// </summary>
    protected UpDownBarType(){}
    
        /// <summary>
    ///Initializes a new instance of the UpDownBarType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected UpDownBarType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UpDownBarType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected UpDownBarType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UpDownBarType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected UpDownBarType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Pie of Pie or Bar of Pie Type.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ofPieType.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class OfPieType : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10456;
    /// <inheritdoc/>
    public override string LocalName => "ofPieType";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Pie of Pie or Bar of Pie Type Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OfPieType class.
    /// </summary>
    public OfPieType():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfPieType>(deep);

}
/// <summary>
/// <para>Split Type.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:splitType.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SplitType : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10457;
    /// <inheritdoc/>
    public override string LocalName => "splitType";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Split Type Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SplitType class.
    /// </summary>
    public SplitType():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitType>(deep);

}
/// <summary>
/// <para>Custom Split.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:custSplit.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SecondPiePoint &lt;c:secondPiePt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SecondPiePoint))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CustomSplit : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10459;
    /// <inheritdoc/>
    public override string LocalName => "custSplit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the CustomSplit class.
    /// </summary>
    public CustomSplit():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CustomSplit class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomSplit(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomSplit class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomSplit(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomSplit class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CustomSplit(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "secondPiePt" == name)
    return new SecondPiePoint();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomSplit>(deep);

}
/// <summary>
/// <para>Second Pie Size.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:secondPieSize.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SecondPieSize : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10460;
    /// <inheritdoc/>
    public override string LocalName => "secondPieSize";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt16Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Second Pie Size Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt16Value Val
    {
        get { return (UInt16Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SecondPieSize class.
    /// </summary>
    public SecondPieSize():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SecondPieSize>(deep);

}
/// <summary>
/// <para>Band Format.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:bandFmt.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BandFormat : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10462;
    /// <inheritdoc/>
    public override string LocalName => "bandFmt";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BandFormat class.
    /// </summary>
    public BandFormat():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BandFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BandFormat(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BandFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BandFormat(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BandFormat class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BandFormat(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","spPr" };
    private static readonly byte[] eleNamespaceIds = { 11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BandFormat>(deep);

}
/// <summary>
/// <para>Picture Format.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pictureFormat.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PictureFormat : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10466;
    /// <inheritdoc/>
    public override string LocalName => "pictureFormat";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Picture Format Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PictureFormat class.
    /// </summary>
    public PictureFormat():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureFormat>(deep);

}
/// <summary>
/// <para>Picture Stack Unit.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pictureStackUnit.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PictureStackUnit : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10467;
    /// <inheritdoc/>
    public override string LocalName => "pictureStackUnit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<DoubleValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Picture Stack Unit.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public DoubleValue Val
    {
        get { return (DoubleValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PictureStackUnit class.
    /// </summary>
    public PictureStackUnit():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureStackUnit>(deep);

}
/// <summary>
/// <para>Built in Display Unit Value.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:builtInUnit.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BuiltInUnit : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10469;
    /// <inheritdoc/>
    public override string LocalName => "builtInUnit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Built In Unit Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BuiltInUnit class.
    /// </summary>
    public BuiltInUnit():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BuiltInUnit>(deep);

}
/// <summary>
/// <para>Display Units Label.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dispUnitsLbl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Layout &lt;c:layout></description></item>
///<item><description>ChartText &lt;c:tx></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Layout))]
    [ChildElementInfo(typeof(ChartText))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DisplayUnitsLabel : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10470;
    /// <inheritdoc/>
    public override string LocalName => "dispUnitsLbl";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DisplayUnitsLabel class.
    /// </summary>
    public DisplayUnitsLabel():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DisplayUnitsLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DisplayUnitsLabel(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DisplayUnitsLabel class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DisplayUnitsLabel(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DisplayUnitsLabel class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DisplayUnitsLabel(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "layout" == name)
    return new Layout();
    
if( 11 == namespaceId && "tx" == name)
    return new ChartText();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "layout","tx","spPr","txPr" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Layout.</para>
    /// <para> Represents the following element tag in the schema: c:layout </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Layout Layout
    {
        get => GetElement<Layout>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ChartText.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartText ChartText
    {
        get => GetElement<ChartText>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> TextProperties.</para>
    /// <para> Represents the following element tag in the schema: c:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TextProperties TextProperties
    {
        get => GetElement<TextProperties>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayUnitsLabel>(deep);

}
/// <summary>
/// <para>Logarithmic Base.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:logBase.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LogBase : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10471;
    /// <inheritdoc/>
    public override string LocalName => "logBase";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<DoubleValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Logarithmic Base Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public DoubleValue Val
    {
        get { return (DoubleValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LogBase class.
    /// </summary>
    public LogBase():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LogBase>(deep);

}
/// <summary>
/// <para>Axis Orientation.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:orientation.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Orientation : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10472;
    /// <inheritdoc/>
    public override string LocalName => "orientation";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Orientation Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Orientation class.
    /// </summary>
    public Orientation():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Orientation>(deep);

}
/// <summary>
/// <para>Pivot Format.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pivotFmt.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>ShapeProperties &lt;c:spPr></description></item>
///<item><description>Marker &lt;c:marker></description></item>
///<item><description>DataLabel &lt;c:dLbl></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(Marker))]
    [ChildElementInfo(typeof(DataLabel))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PivotFormat : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10475;
    /// <inheritdoc/>
    public override string LocalName => "pivotFmt";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotFormat class.
    /// </summary>
    public PivotFormat():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotFormat(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotFormat(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotFormat class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotFormat(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 11 == namespaceId && "marker" == name)
    return new Marker();
    
if( 11 == namespaceId && "dLbl" == name)
    return new DataLabel();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","spPr","marker","dLbl","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Marker Marker
    {
        get => GetElement<Marker>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Data Label.</para>
    /// <para> Represents the following element tag in the schema: c:dLbl </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DataLabel DataLabel
    {
        get => GetElement<DataLabel>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(4);
        set => SetElement(4, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotFormat>(deep);

}
/// <summary>
/// <para>Legend Position.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:legendPos.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LegendPosition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10476;
    /// <inheritdoc/>
    public override string LocalName => "legendPos";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Legend Position Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LegendPosition class.
    /// </summary>
    public LegendPosition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegendPosition>(deep);

}
/// <summary>
/// <para>Legend Entry.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:legendEntry.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>Delete &lt;c:delete></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(Delete))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LegendEntry : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10477;
    /// <inheritdoc/>
    public override string LocalName => "legendEntry";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LegendEntry class.
    /// </summary>
    public LegendEntry():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LegendEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LegendEntry(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LegendEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LegendEntry(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LegendEntry class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LegendEntry(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "delete" == name)
    return new Delete();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","delete","txPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegendEntry>(deep);

}
/// <summary>
/// <para>Pivot Formats.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pivotFmts.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotFormat &lt;c:pivotFmt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotFormat))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PivotFormats : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10479;
    /// <inheritdoc/>
    public override string LocalName => "pivotFmts";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotFormats class.
    /// </summary>
    public PivotFormats():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotFormats(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotFormats(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotFormats class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotFormats(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "pivotFmt" == name)
    return new PivotFormat();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotFormats>(deep);

}
/// <summary>
/// <para>View In 3D.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:view3D.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RotateX &lt;c:rotX></description></item>
///<item><description>HeightPercent &lt;c:hPercent></description></item>
///<item><description>RotateY &lt;c:rotY></description></item>
///<item><description>DepthPercent &lt;c:depthPercent></description></item>
///<item><description>RightAngleAxes &lt;c:rAngAx></description></item>
///<item><description>Perspective &lt;c:perspective></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RotateX))]
    [ChildElementInfo(typeof(HeightPercent))]
    [ChildElementInfo(typeof(RotateY))]
    [ChildElementInfo(typeof(DepthPercent))]
    [ChildElementInfo(typeof(RightAngleAxes))]
    [ChildElementInfo(typeof(Perspective))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class View3D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10480;
    /// <inheritdoc/>
    public override string LocalName => "view3D";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the View3D class.
    /// </summary>
    public View3D():base(){}
    
        /// <summary>
    ///Initializes a new instance of the View3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public View3D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the View3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public View3D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the View3D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public View3D(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "rotX" == name)
    return new RotateX();
    
if( 11 == namespaceId && "hPercent" == name)
    return new HeightPercent();
    
if( 11 == namespaceId && "rotY" == name)
    return new RotateY();
    
if( 11 == namespaceId && "depthPercent" == name)
    return new DepthPercent();
    
if( 11 == namespaceId && "rAngAx" == name)
    return new RightAngleAxes();
    
if( 11 == namespaceId && "perspective" == name)
    return new Perspective();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "rotX","hPercent","rotY","depthPercent","rAngAx","perspective","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> X Rotation.</para>
    /// <para> Represents the following element tag in the schema: c:rotX </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public RotateX RotateX
    {
        get => GetElement<RotateX>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Height Percent.</para>
    /// <para> Represents the following element tag in the schema: c:hPercent </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public HeightPercent HeightPercent
    {
        get => GetElement<HeightPercent>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Y Rotation.</para>
    /// <para> Represents the following element tag in the schema: c:rotY </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public RotateY RotateY
    {
        get => GetElement<RotateY>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Depth Percent.</para>
    /// <para> Represents the following element tag in the schema: c:depthPercent </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DepthPercent DepthPercent
    {
        get => GetElement<DepthPercent>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Right Angle Axes.</para>
    /// <para> Represents the following element tag in the schema: c:rAngAx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public RightAngleAxes RightAngleAxes
    {
        get => GetElement<RightAngleAxes>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Perspective.</para>
    /// <para> Represents the following element tag in the schema: c:perspective </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Perspective Perspective
    {
        get => GetElement<Perspective>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(6);
        set => SetElement(6, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<View3D>(deep);

}
/// <summary>
/// <para>Floor.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:floor.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Thickness &lt;c:thickness></description></item>
///<item><description>ShapeProperties &lt;c:spPr></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Floor : SurfaceType
{
    internal const int ElementTypeIdConst = 10481;
    /// <inheritdoc/>
    public override string LocalName => "floor";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Floor class.
    /// </summary>
    public Floor():base(){}
        /// <summary>
    ///Initializes a new instance of the Floor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Floor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Floor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Floor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Floor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Floor(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Floor>(deep);

}
/// <summary>
/// <para>Side Wall.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:sideWall.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Thickness &lt;c:thickness></description></item>
///<item><description>ShapeProperties &lt;c:spPr></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SideWall : SurfaceType
{
    internal const int ElementTypeIdConst = 10482;
    /// <inheritdoc/>
    public override string LocalName => "sideWall";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the SideWall class.
    /// </summary>
    public SideWall():base(){}
        /// <summary>
    ///Initializes a new instance of the SideWall class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SideWall(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SideWall class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SideWall(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SideWall class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SideWall(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SideWall>(deep);

}
/// <summary>
/// <para>Back Wall.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:backWall.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Thickness &lt;c:thickness></description></item>
///<item><description>ShapeProperties &lt;c:spPr></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BackWall : SurfaceType
{
    internal const int ElementTypeIdConst = 10483;
    /// <inheritdoc/>
    public override string LocalName => "backWall";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the BackWall class.
    /// </summary>
    public BackWall():base(){}
        /// <summary>
    ///Initializes a new instance of the BackWall class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackWall(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackWall class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackWall(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackWall class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackWall(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackWall>(deep);

}
/// <summary>
/// Defines the SurfaceType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Thickness &lt;c:thickness></description></item>
///<item><description>ShapeProperties &lt;c:spPr></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Thickness))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(PictureOptions))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class SurfaceType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "thickness" == name)
    return new Thickness();
    
if( 11 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new PictureOptions();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "thickness","spPr","pictureOptions","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Thickness.</para>
    /// <para> Represents the following element tag in the schema: c:thickness </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Thickness Thickness
    {
        get => GetElement<Thickness>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Picture Options.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureOptions PictureOptions
    {
        get => GetElement<PictureOptions>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(3);
        set => SetElement(3, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the SurfaceType class.
    /// </summary>
    protected SurfaceType(){}
    
        /// <summary>
    ///Initializes a new instance of the SurfaceType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected SurfaceType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected SurfaceType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected SurfaceType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Plot Area.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:plotArea.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Layout &lt;c:layout></description></item>
///<item><description>AreaChart &lt;c:areaChart></description></item>
///<item><description>Area3DChart &lt;c:area3DChart></description></item>
///<item><description>LineChart &lt;c:lineChart></description></item>
///<item><description>Line3DChart &lt;c:line3DChart></description></item>
///<item><description>StockChart &lt;c:stockChart></description></item>
///<item><description>RadarChart &lt;c:radarChart></description></item>
///<item><description>ScatterChart &lt;c:scatterChart></description></item>
///<item><description>PieChart &lt;c:pieChart></description></item>
///<item><description>Pie3DChart &lt;c:pie3DChart></description></item>
///<item><description>DoughnutChart &lt;c:doughnutChart></description></item>
///<item><description>BarChart &lt;c:barChart></description></item>
///<item><description>Bar3DChart &lt;c:bar3DChart></description></item>
///<item><description>OfPieChart &lt;c:ofPieChart></description></item>
///<item><description>SurfaceChart &lt;c:surfaceChart></description></item>
///<item><description>Surface3DChart &lt;c:surface3DChart></description></item>
///<item><description>BubbleChart &lt;c:bubbleChart></description></item>
///<item><description>ValueAxis &lt;c:valAx></description></item>
///<item><description>CategoryAxis &lt;c:catAx></description></item>
///<item><description>DateAxis &lt;c:dateAx></description></item>
///<item><description>SeriesAxis &lt;c:serAx></description></item>
///<item><description>DataTable &lt;c:dTable></description></item>
///<item><description>ShapeProperties &lt;c:spPr></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Layout))]
    [ChildElementInfo(typeof(AreaChart))]
    [ChildElementInfo(typeof(Area3DChart))]
    [ChildElementInfo(typeof(LineChart))]
    [ChildElementInfo(typeof(Line3DChart))]
    [ChildElementInfo(typeof(StockChart))]
    [ChildElementInfo(typeof(RadarChart))]
    [ChildElementInfo(typeof(ScatterChart))]
    [ChildElementInfo(typeof(PieChart))]
    [ChildElementInfo(typeof(Pie3DChart))]
    [ChildElementInfo(typeof(DoughnutChart))]
    [ChildElementInfo(typeof(BarChart))]
    [ChildElementInfo(typeof(Bar3DChart))]
    [ChildElementInfo(typeof(OfPieChart))]
    [ChildElementInfo(typeof(SurfaceChart))]
    [ChildElementInfo(typeof(Surface3DChart))]
    [ChildElementInfo(typeof(BubbleChart))]
    [ChildElementInfo(typeof(ValueAxis))]
    [ChildElementInfo(typeof(CategoryAxis))]
    [ChildElementInfo(typeof(DateAxis))]
    [ChildElementInfo(typeof(SeriesAxis))]
    [ChildElementInfo(typeof(DataTable))]
    [ChildElementInfo(typeof(ShapeProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PlotArea : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10484;
    /// <inheritdoc/>
    public override string LocalName => "plotArea";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    if( 11 == namespaceId && "layout" == name)
    return new Layout();
    
if( 11 == namespaceId && "areaChart" == name)
    return new AreaChart();
    
if( 11 == namespaceId && "area3DChart" == name)
    return new Area3DChart();
    
if( 11 == namespaceId && "lineChart" == name)
    return new LineChart();
    
if( 11 == namespaceId && "line3DChart" == name)
    return new Line3DChart();
    
if( 11 == namespaceId && "stockChart" == name)
    return new StockChart();
    
if( 11 == namespaceId && "radarChart" == name)
    return new RadarChart();
    
if( 11 == namespaceId && "scatterChart" == name)
    return new ScatterChart();
    
if( 11 == namespaceId && "pieChart" == name)
    return new PieChart();
    
if( 11 == namespaceId && "pie3DChart" == name)
    return new Pie3DChart();
    
if( 11 == namespaceId && "doughnutChart" == name)
    return new DoughnutChart();
    
if( 11 == namespaceId && "barChart" == name)
    return new BarChart();
    
if( 11 == namespaceId && "bar3DChart" == name)
    return new Bar3DChart();
    
if( 11 == namespaceId && "ofPieChart" == name)
    return new OfPieChart();
    
if( 11 == namespaceId && "surfaceChart" == name)
    return new SurfaceChart();
    
if( 11 == namespaceId && "surface3DChart" == name)
    return new Surface3DChart();
    
if( 11 == namespaceId && "bubbleChart" == name)
    return new BubbleChart();
    
if( 11 == namespaceId && "valAx" == name)
    return new ValueAxis();
    
if( 11 == namespaceId && "catAx" == name)
    return new CategoryAxis();
    
if( 11 == namespaceId && "dateAx" == name)
    return new DateAxis();
    
if( 11 == namespaceId && "serAx" == name)
    return new SeriesAxis();
    
if( 11 == namespaceId && "dTable" == name)
    return new DataTable();
    
if( 11 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "layout","areaChart","area3DChart","lineChart","line3DChart","stockChart","radarChart","scatterChart","pieChart","pie3DChart","doughnutChart","barChart","bar3DChart","ofPieChart","surfaceChart","surface3DChart","bubbleChart","valAx","catAx","dateAx","serAx","dTable","spPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Layout.</para>
    /// <para> Represents the following element tag in the schema: c:layout </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Layout Layout
    {
        get => GetElement<Layout>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea>(deep);

}
/// <summary>
/// <para>Legend.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:legend.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LegendPosition &lt;c:legendPos></description></item>
///<item><description>LegendEntry &lt;c:legendEntry></description></item>
///<item><description>Layout &lt;c:layout></description></item>
///<item><description>Overlay &lt;c:overlay></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LegendPosition))]
    [ChildElementInfo(typeof(LegendEntry))]
    [ChildElementInfo(typeof(Layout))]
    [ChildElementInfo(typeof(Overlay))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Legend : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10485;
    /// <inheritdoc/>
    public override string LocalName => "legend";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    if( 11 == namespaceId && "legendPos" == name)
    return new LegendPosition();
    
if( 11 == namespaceId && "legendEntry" == name)
    return new LegendEntry();
    
if( 11 == namespaceId && "layout" == name)
    return new Layout();
    
if( 11 == namespaceId && "overlay" == name)
    return new Overlay();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "legendPos","legendEntry","layout","overlay","spPr","txPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Legend Position.</para>
    /// <para> Represents the following element tag in the schema: c:legendPos </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public LegendPosition LegendPosition
    {
        get => GetElement<LegendPosition>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Legend>(deep);

}
/// <summary>
/// <para>Display Blanks As.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dispBlanksAs.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DisplayBlanksAs : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10487;
    /// <inheritdoc/>
    public override string LocalName => "dispBlanksAs";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Display Blanks As Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DisplayBlanksAs class.
    /// </summary>
    public DisplayBlanksAs():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayBlanksAs>(deep);

}
/// <summary>
/// <para>Header and Footer.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:headerFooter.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OddHeader &lt;c:oddHeader></description></item>
///<item><description>OddFooter &lt;c:oddFooter></description></item>
///<item><description>EvenHeader &lt;c:evenHeader></description></item>
///<item><description>EvenFooter &lt;c:evenFooter></description></item>
///<item><description>FirstHeader &lt;c:firstHeader></description></item>
///<item><description>FirstFooter &lt;c:firstFooter></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OddHeader))]
    [ChildElementInfo(typeof(OddFooter))]
    [ChildElementInfo(typeof(EvenHeader))]
    [ChildElementInfo(typeof(EvenFooter))]
    [ChildElementInfo(typeof(FirstHeader))]
    [ChildElementInfo(typeof(FirstFooter))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HeaderFooter : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10501;
    /// <inheritdoc/>
    public override string LocalName => "headerFooter";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "alignWithMargins"),
		AttributeTag.Create<BooleanValue>(0, "differentOddEven"),
		AttributeTag.Create<BooleanValue>(0, "differentFirst")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Align With Margins.</para>
    /// <para>Represents the following attribute in the schema: alignWithMargins </para>
    /// </summary>
    [SchemaAttr(0, "alignWithMargins")]
    public BooleanValue AlignWithMargins
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Different Odd Even.</para>
    /// <para>Represents the following attribute in the schema: differentOddEven </para>
    /// </summary>
    [SchemaAttr(0, "differentOddEven")]
    public BooleanValue DifferentOddEven
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Different First.</para>
    /// <para>Represents the following attribute in the schema: differentFirst </para>
    /// </summary>
    [SchemaAttr(0, "differentFirst")]
    public BooleanValue DifferentFirst
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
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
    if( 11 == namespaceId && "oddHeader" == name)
    return new OddHeader();
    
if( 11 == namespaceId && "oddFooter" == name)
    return new OddFooter();
    
if( 11 == namespaceId && "evenHeader" == name)
    return new EvenHeader();
    
if( 11 == namespaceId && "evenFooter" == name)
    return new EvenFooter();
    
if( 11 == namespaceId && "firstHeader" == name)
    return new FirstHeader();
    
if( 11 == namespaceId && "firstFooter" == name)
    return new FirstFooter();
    

    return null;
}

        private static readonly string[] eleTagNames = { "oddHeader","oddFooter","evenHeader","evenFooter","firstHeader","firstFooter" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Odd Header.</para>
    /// <para> Represents the following element tag in the schema: c:oddHeader </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public OddHeader OddHeader
    {
        get => GetElement<OddHeader>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Odd Footer.</para>
    /// <para> Represents the following element tag in the schema: c:oddFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public OddFooter OddFooter
    {
        get => GetElement<OddFooter>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Even Header.</para>
    /// <para> Represents the following element tag in the schema: c:evenHeader </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public EvenHeader EvenHeader
    {
        get => GetElement<EvenHeader>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Even Footer.</para>
    /// <para> Represents the following element tag in the schema: c:evenFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public EvenFooter EvenFooter
    {
        get => GetElement<EvenFooter>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> First Header.</para>
    /// <para> Represents the following element tag in the schema: c:firstHeader </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public FirstHeader FirstHeader
    {
        get => GetElement<FirstHeader>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> First Footer.</para>
    /// <para> Represents the following element tag in the schema: c:firstFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public FirstFooter FirstFooter
    {
        get => GetElement<FirstFooter>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeaderFooter>(deep);

}
/// <summary>
/// <para>Page Margins.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pageMargins.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PageMargins : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10502;
    /// <inheritdoc/>
    public override string LocalName => "pageMargins";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<DoubleValue>(0, "l"),
		AttributeTag.Create<DoubleValue>(0, "r"),
		AttributeTag.Create<DoubleValue>(0, "t"),
		AttributeTag.Create<DoubleValue>(0, "b"),
		AttributeTag.Create<DoubleValue>(0, "header"),
		AttributeTag.Create<DoubleValue>(0, "footer")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Left.</para>
    /// <para>Represents the following attribute in the schema: l </para>
    /// </summary>
    [SchemaAttr(0, "l")]
    public DoubleValue Left
    {
        get { return (DoubleValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Right.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public DoubleValue Right
    {
        get { return (DoubleValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Top.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public DoubleValue Top
    {
        get { return (DoubleValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Bottom.</para>
    /// <para>Represents the following attribute in the schema: b </para>
    /// </summary>
    [SchemaAttr(0, "b")]
    public DoubleValue Bottom
    {
        get { return (DoubleValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Header.</para>
    /// <para>Represents the following attribute in the schema: header </para>
    /// </summary>
    [SchemaAttr(0, "header")]
    public DoubleValue Header
    {
        get { return (DoubleValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Footer.</para>
    /// <para>Represents the following attribute in the schema: footer </para>
    /// </summary>
    [SchemaAttr(0, "footer")]
    public DoubleValue Footer
    {
        get { return (DoubleValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PageMargins class.
    /// </summary>
    public PageMargins():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PageMargins>(deep);

}
/// <summary>
/// <para>Page Setup.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pageSetup.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PageSetup : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10503;
    /// <inheritdoc/>
    public override string LocalName => "pageSetup";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "paperSize"),
		AttributeTag.Create<Int32Value>(0, "firstPageNumber"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues>>(0, "orientation"),
		AttributeTag.Create<BooleanValue>(0, "blackAndWhite"),
		AttributeTag.Create<BooleanValue>(0, "draft"),
		AttributeTag.Create<BooleanValue>(0, "useFirstPageNumber"),
		AttributeTag.Create<Int32Value>(0, "horizontalDpi"),
		AttributeTag.Create<Int32Value>(0, "verticalDpi"),
		AttributeTag.Create<UInt32Value>(0, "copies")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Page Size.</para>
    /// <para>Represents the following attribute in the schema: paperSize </para>
    /// </summary>
    [SchemaAttr(0, "paperSize")]
    public UInt32Value PaperSize
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> First Page Number.</para>
    /// <para>Represents the following attribute in the schema: firstPageNumber </para>
    /// </summary>
    [SchemaAttr(0, "firstPageNumber")]
    public Int32Value FirstPageNumber
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Orientation.</para>
    /// <para>Represents the following attribute in the schema: orientation </para>
    /// </summary>
    [SchemaAttr(0, "orientation")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues> Orientation
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Black and White.</para>
    /// <para>Represents the following attribute in the schema: blackAndWhite </para>
    /// </summary>
    [SchemaAttr(0, "blackAndWhite")]
    public BooleanValue BlackAndWhite
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Draft.</para>
    /// <para>Represents the following attribute in the schema: draft </para>
    /// </summary>
    [SchemaAttr(0, "draft")]
    public BooleanValue Draft
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Use First Page Number.</para>
    /// <para>Represents the following attribute in the schema: useFirstPageNumber </para>
    /// </summary>
    [SchemaAttr(0, "useFirstPageNumber")]
    public BooleanValue UseFirstPageNumber
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal DPI.</para>
    /// <para>Represents the following attribute in the schema: horizontalDpi </para>
    /// </summary>
    [SchemaAttr(0, "horizontalDpi")]
    public Int32Value HorizontalDpi
    {
        get { return (Int32Value)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Vertical DPI.</para>
    /// <para>Represents the following attribute in the schema: verticalDpi </para>
    /// </summary>
    [SchemaAttr(0, "verticalDpi")]
    public Int32Value VerticalDpi
    {
        get { return (Int32Value)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Copies.</para>
    /// <para>Represents the following attribute in the schema: copies </para>
    /// </summary>
    [SchemaAttr(0, "copies")]
    public UInt32Value Copies
    {
        get { return (UInt32Value)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PageSetup class.
    /// </summary>
    public PageSetup():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PageSetup>(deep);

}
/// <summary>
/// <para>Defines the ShapeProperties Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:spPr.</para>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10507;
    /// <inheritdoc/>
    public override string LocalName => "spPr";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>(0, "bwMode")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
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
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> 2D Transform for Individual Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);

}
/// <summary>
/// <para>Data Label.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dLbl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>Delete &lt;c:delete></description></item>
///<item><description>Layout &lt;c:layout></description></item>
///<item><description>ChartText &lt;c:tx></description></item>
///<item><description>NumberingFormat &lt;c:numFmt></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>DataLabelPosition &lt;c:dLblPos></description></item>
///<item><description>ShowLegendKey &lt;c:showLegendKey></description></item>
///<item><description>ShowValue &lt;c:showVal></description></item>
///<item><description>ShowCategoryName &lt;c:showCatName></description></item>
///<item><description>ShowSeriesName &lt;c:showSerName></description></item>
///<item><description>ShowPercent &lt;c:showPercent></description></item>
///<item><description>ShowBubbleSize &lt;c:showBubbleSize></description></item>
///<item><description>Separator &lt;c:separator></description></item>
///<item><description>DLblExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(Delete))]
    [ChildElementInfo(typeof(Layout))]
    [ChildElementInfo(typeof(ChartText))]
    [ChildElementInfo(typeof(NumberingFormat))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(DataLabelPosition))]
    [ChildElementInfo(typeof(ShowLegendKey))]
    [ChildElementInfo(typeof(ShowValue))]
    [ChildElementInfo(typeof(ShowCategoryName))]
    [ChildElementInfo(typeof(ShowSeriesName))]
    [ChildElementInfo(typeof(ShowPercent))]
    [ChildElementInfo(typeof(ShowBubbleSize))]
    [ChildElementInfo(typeof(Separator))]
    [ChildElementInfo(typeof(DLblExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DataLabel : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10508;
    /// <inheritdoc/>
    public override string LocalName => "dLbl";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "delete" == name)
    return new Delete();
    
if( 11 == namespaceId && "layout" == name)
    return new Layout();
    
if( 11 == namespaceId && "tx" == name)
    return new ChartText();
    
if( 11 == namespaceId && "numFmt" == name)
    return new NumberingFormat();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "dLblPos" == name)
    return new DataLabelPosition();
    
if( 11 == namespaceId && "showLegendKey" == name)
    return new ShowLegendKey();
    
if( 11 == namespaceId && "showVal" == name)
    return new ShowValue();
    
if( 11 == namespaceId && "showCatName" == name)
    return new ShowCategoryName();
    
if( 11 == namespaceId && "showSerName" == name)
    return new ShowSeriesName();
    
if( 11 == namespaceId && "showPercent" == name)
    return new ShowPercent();
    
if( 11 == namespaceId && "showBubbleSize" == name)
    return new ShowBubbleSize();
    
if( 11 == namespaceId && "separator" == name)
    return new Separator();
    
if( 11 == namespaceId && "extLst" == name)
    return new DLblExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","delete","layout","tx","numFmt","spPr","txPr","dLblPos","showLegendKey","showVal","showCatName","showSerName","showPercent","showBubbleSize","separator","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);

}
/// <summary>
/// <para>Area Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:areaChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Grouping &lt;c:grouping></description></item>
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>AreaChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>DropLines &lt;c:dropLines></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>AreaChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Grouping))]
    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(AreaChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(DropLines))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(AreaChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AreaChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10509;
    /// <inheritdoc/>
    public override string LocalName => "areaChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AreaChart class.
    /// </summary>
    public AreaChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AreaChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AreaChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "grouping" == name)
    return new Grouping();
    
if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new AreaChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "dropLines" == name)
    return new DropLines();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new AreaChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "grouping","varyColors","ser","dLbls","dropLines","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Grouping.</para>
    /// <para> Represents the following element tag in the schema: c:grouping </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Grouping Grouping
    {
        get => GetElement<Grouping>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChart>(deep);

}
/// <summary>
/// <para>3D Area Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:area3DChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Grouping &lt;c:grouping></description></item>
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>AreaChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>DropLines &lt;c:dropLines></description></item>
///<item><description>GapDepth &lt;c:gapDepth></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>Area3DChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Grouping))]
    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(AreaChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(DropLines))]
    [ChildElementInfo(typeof(GapDepth))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(Area3DChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Area3DChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10510;
    /// <inheritdoc/>
    public override string LocalName => "area3DChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Area3DChart class.
    /// </summary>
    public Area3DChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Area3DChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Area3DChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Area3DChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Area3DChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Area3DChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Area3DChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "grouping" == name)
    return new Grouping();
    
if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new AreaChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "dropLines" == name)
    return new DropLines();
    
if( 11 == namespaceId && "gapDepth" == name)
    return new GapDepth();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new Area3DChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "grouping","varyColors","ser","dLbls","dropLines","gapDepth","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Grouping.</para>
    /// <para> Represents the following element tag in the schema: c:grouping </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Grouping Grouping
    {
        get => GetElement<Grouping>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Area3DChart>(deep);

}
/// <summary>
/// <para>Line Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:lineChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Grouping &lt;c:grouping></description></item>
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>LineChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>DropLines &lt;c:dropLines></description></item>
///<item><description>HighLowLines &lt;c:hiLowLines></description></item>
///<item><description>UpDownBars &lt;c:upDownBars></description></item>
///<item><description>ShowMarker &lt;c:marker></description></item>
///<item><description>Smooth &lt;c:smooth></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>LineChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Grouping))]
    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(LineChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(DropLines))]
    [ChildElementInfo(typeof(HighLowLines))]
    [ChildElementInfo(typeof(UpDownBars))]
    [ChildElementInfo(typeof(ShowMarker))]
    [ChildElementInfo(typeof(Smooth))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(LineChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LineChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10511;
    /// <inheritdoc/>
    public override string LocalName => "lineChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LineChart class.
    /// </summary>
    public LineChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LineChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LineChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "grouping" == name)
    return new Grouping();
    
if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new LineChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "dropLines" == name)
    return new DropLines();
    
if( 11 == namespaceId && "hiLowLines" == name)
    return new HighLowLines();
    
if( 11 == namespaceId && "upDownBars" == name)
    return new UpDownBars();
    
if( 11 == namespaceId && "marker" == name)
    return new ShowMarker();
    
if( 11 == namespaceId && "smooth" == name)
    return new Smooth();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new LineChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "grouping","varyColors","ser","dLbls","dropLines","hiLowLines","upDownBars","marker","smooth","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Grouping.</para>
    /// <para> Represents the following element tag in the schema: c:grouping </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Grouping Grouping
    {
        get => GetElement<Grouping>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChart>(deep);

}
/// <summary>
/// <para>3D Line Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:line3DChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Grouping &lt;c:grouping></description></item>
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>LineChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>DropLines &lt;c:dropLines></description></item>
///<item><description>GapDepth &lt;c:gapDepth></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>Line3DChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Grouping))]
    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(LineChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(DropLines))]
    [ChildElementInfo(typeof(GapDepth))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(Line3DChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Line3DChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10512;
    /// <inheritdoc/>
    public override string LocalName => "line3DChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Line3DChart class.
    /// </summary>
    public Line3DChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Line3DChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Line3DChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Line3DChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Line3DChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Line3DChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Line3DChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "grouping" == name)
    return new Grouping();
    
if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new LineChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "dropLines" == name)
    return new DropLines();
    
if( 11 == namespaceId && "gapDepth" == name)
    return new GapDepth();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new Line3DChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "grouping","varyColors","ser","dLbls","dropLines","gapDepth","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Grouping.</para>
    /// <para> Represents the following element tag in the schema: c:grouping </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Grouping Grouping
    {
        get => GetElement<Grouping>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Line3DChart>(deep);

}
/// <summary>
/// <para>Stock Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:stockChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>DropLines &lt;c:dropLines></description></item>
///<item><description>HighLowLines &lt;c:hiLowLines></description></item>
///<item><description>UpDownBars &lt;c:upDownBars></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>StockChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LineChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(DropLines))]
    [ChildElementInfo(typeof(HighLowLines))]
    [ChildElementInfo(typeof(UpDownBars))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(StockChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StockChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10513;
    /// <inheritdoc/>
    public override string LocalName => "stockChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the StockChart class.
    /// </summary>
    public StockChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StockChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StockChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StockChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StockChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StockChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StockChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ser" == name)
    return new LineChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "dropLines" == name)
    return new DropLines();
    
if( 11 == namespaceId && "hiLowLines" == name)
    return new HighLowLines();
    
if( 11 == namespaceId && "upDownBars" == name)
    return new UpDownBars();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new StockChartExtensionList();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StockChart>(deep);

}
/// <summary>
/// <para>Radar Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:radarChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RadarStyle &lt;c:radarStyle></description></item>
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>RadarChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>RadarChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RadarStyle))]
    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(RadarChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(RadarChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RadarChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10514;
    /// <inheritdoc/>
    public override string LocalName => "radarChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RadarChart class.
    /// </summary>
    public RadarChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RadarChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadarChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "radarStyle" == name)
    return new RadarStyle();
    
if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new RadarChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new RadarChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "radarStyle","varyColors","ser","dLbls","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> RadarStyle.</para>
    /// <para> Represents the following element tag in the schema: c:radarStyle </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public RadarStyle RadarStyle
    {
        get => GetElement<RadarStyle>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChart>(deep);

}
/// <summary>
/// <para>Scatter Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:scatterChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ScatterStyle &lt;c:scatterStyle></description></item>
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>ScatterChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>ScatterChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ScatterStyle))]
    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(ScatterChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(ScatterChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ScatterChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10515;
    /// <inheritdoc/>
    public override string LocalName => "scatterChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ScatterChart class.
    /// </summary>
    public ScatterChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ScatterChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ScatterChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "scatterStyle" == name)
    return new ScatterStyle();
    
if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new ScatterChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new ScatterChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "scatterStyle","varyColors","ser","dLbls","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ScatterStyle.</para>
    /// <para> Represents the following element tag in the schema: c:scatterStyle </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ScatterStyle ScatterStyle
    {
        get => GetElement<ScatterStyle>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChart>(deep);

}
/// <summary>
/// <para>Pie Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pieChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>PieChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>FirstSliceAngle &lt;c:firstSliceAng></description></item>
///<item><description>PieChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(PieChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(FirstSliceAngle))]
    [ChildElementInfo(typeof(PieChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PieChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10516;
    /// <inheritdoc/>
    public override string LocalName => "pieChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PieChart class.
    /// </summary>
    public PieChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PieChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PieChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new PieChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "firstSliceAng" == name)
    return new FirstSliceAngle();
    
if( 11 == namespaceId && "extLst" == name)
    return new PieChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "varyColors","ser","dLbls","firstSliceAng","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChart>(deep);

}
/// <summary>
/// <para>3D Pie Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pie3DChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>PieChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>Pie3DChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(PieChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(Pie3DChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Pie3DChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10517;
    /// <inheritdoc/>
    public override string LocalName => "pie3DChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Pie3DChart class.
    /// </summary>
    public Pie3DChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Pie3DChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Pie3DChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Pie3DChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Pie3DChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Pie3DChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Pie3DChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new PieChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "extLst" == name)
    return new Pie3DChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "varyColors","ser","dLbls","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Pie3DChart>(deep);

}
/// <summary>
/// <para>Doughnut Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:doughnutChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>PieChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>FirstSliceAngle &lt;c:firstSliceAng></description></item>
///<item><description>HoleSize &lt;c:holeSize></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(PieChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(FirstSliceAngle))]
    [ChildElementInfo(typeof(HoleSize))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DoughnutChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10518;
    /// <inheritdoc/>
    public override string LocalName => "doughnutChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DoughnutChart class.
    /// </summary>
    public DoughnutChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DoughnutChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DoughnutChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DoughnutChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DoughnutChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DoughnutChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DoughnutChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new PieChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "firstSliceAng" == name)
    return new FirstSliceAngle();
    
if( 11 == namespaceId && "holeSize" == name)
    return new HoleSize();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "varyColors","ser","dLbls","firstSliceAng","holeSize","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DoughnutChart>(deep);

}
/// <summary>
/// <para>Bar Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:barChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BarDirection &lt;c:barDir></description></item>
///<item><description>BarGrouping &lt;c:grouping></description></item>
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>BarChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>GapWidth &lt;c:gapWidth></description></item>
///<item><description>Overlap &lt;c:overlap></description></item>
///<item><description>SeriesLines &lt;c:serLines></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>BarChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BarDirection))]
    [ChildElementInfo(typeof(BarGrouping))]
    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(BarChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(GapWidth))]
    [ChildElementInfo(typeof(Overlap))]
    [ChildElementInfo(typeof(SeriesLines))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(BarChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BarChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10519;
    /// <inheritdoc/>
    public override string LocalName => "barChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BarChart class.
    /// </summary>
    public BarChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BarChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BarChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "barDir" == name)
    return new BarDirection();
    
if( 11 == namespaceId && "grouping" == name)
    return new BarGrouping();
    
if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new BarChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "gapWidth" == name)
    return new GapWidth();
    
if( 11 == namespaceId && "overlap" == name)
    return new Overlap();
    
if( 11 == namespaceId && "serLines" == name)
    return new SeriesLines();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new BarChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "barDir","grouping","varyColors","ser","dLbls","gapWidth","overlap","serLines","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Bar Direction.</para>
    /// <para> Represents the following element tag in the schema: c:barDir </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public BarDirection BarDirection
    {
        get => GetElement<BarDirection>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Bar Grouping.</para>
    /// <para> Represents the following element tag in the schema: c:grouping </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public BarGrouping BarGrouping
    {
        get => GetElement<BarGrouping>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChart>(deep);

}
/// <summary>
/// <para>3D Bar Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:bar3DChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BarDirection &lt;c:barDir></description></item>
///<item><description>BarGrouping &lt;c:grouping></description></item>
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>BarChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>GapWidth &lt;c:gapWidth></description></item>
///<item><description>GapDepth &lt;c:gapDepth></description></item>
///<item><description>Shape &lt;c:shape></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>Bar3DChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BarDirection))]
    [ChildElementInfo(typeof(BarGrouping))]
    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(BarChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(GapWidth))]
    [ChildElementInfo(typeof(GapDepth))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(Bar3DChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Bar3DChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10520;
    /// <inheritdoc/>
    public override string LocalName => "bar3DChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Bar3DChart class.
    /// </summary>
    public Bar3DChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Bar3DChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Bar3DChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Bar3DChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Bar3DChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Bar3DChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Bar3DChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "barDir" == name)
    return new BarDirection();
    
if( 11 == namespaceId && "grouping" == name)
    return new BarGrouping();
    
if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new BarChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "gapWidth" == name)
    return new GapWidth();
    
if( 11 == namespaceId && "gapDepth" == name)
    return new GapDepth();
    
if( 11 == namespaceId && "shape" == name)
    return new Shape();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new Bar3DChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "barDir","grouping","varyColors","ser","dLbls","gapWidth","gapDepth","shape","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Bar Direction.</para>
    /// <para> Represents the following element tag in the schema: c:barDir </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public BarDirection BarDirection
    {
        get => GetElement<BarDirection>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Bar Grouping.</para>
    /// <para> Represents the following element tag in the schema: c:grouping </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public BarGrouping BarGrouping
    {
        get => GetElement<BarGrouping>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bar3DChart>(deep);

}
/// <summary>
/// <para>Pie of Pie or Bar of Pie Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ofPieChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfPieType &lt;c:ofPieType></description></item>
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>PieChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>GapWidth &lt;c:gapWidth></description></item>
///<item><description>SplitType &lt;c:splitType></description></item>
///<item><description>SplitPosition &lt;c:splitPos></description></item>
///<item><description>CustomSplit &lt;c:custSplit></description></item>
///<item><description>SecondPieSize &lt;c:secondPieSize></description></item>
///<item><description>SeriesLines &lt;c:serLines></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OfPieType))]
    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(PieChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(GapWidth))]
    [ChildElementInfo(typeof(SplitType))]
    [ChildElementInfo(typeof(SplitPosition))]
    [ChildElementInfo(typeof(CustomSplit))]
    [ChildElementInfo(typeof(SecondPieSize))]
    [ChildElementInfo(typeof(SeriesLines))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class OfPieChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10521;
    /// <inheritdoc/>
    public override string LocalName => "ofPieChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OfPieChart class.
    /// </summary>
    public OfPieChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OfPieChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfPieChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OfPieChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfPieChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OfPieChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OfPieChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ofPieType" == name)
    return new OfPieType();
    
if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new PieChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "gapWidth" == name)
    return new GapWidth();
    
if( 11 == namespaceId && "splitType" == name)
    return new SplitType();
    
if( 11 == namespaceId && "splitPos" == name)
    return new SplitPosition();
    
if( 11 == namespaceId && "custSplit" == name)
    return new CustomSplit();
    
if( 11 == namespaceId && "secondPieSize" == name)
    return new SecondPieSize();
    
if( 11 == namespaceId && "serLines" == name)
    return new SeriesLines();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ofPieType","varyColors","ser","dLbls","gapWidth","splitType","splitPos","custSplit","secondPieSize","serLines","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Pie of Pie or Bar of Pie Type.</para>
    /// <para> Represents the following element tag in the schema: c:ofPieType </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public OfPieType OfPieType
    {
        get => GetElement<OfPieType>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfPieChart>(deep);

}
/// <summary>
/// <para>Surface Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:surfaceChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Wireframe &lt;c:wireframe></description></item>
///<item><description>SurfaceChartSeries &lt;c:ser></description></item>
///<item><description>BandFormats &lt;c:bandFmts></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>SurfaceChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Wireframe))]
    [ChildElementInfo(typeof(SurfaceChartSeries))]
    [ChildElementInfo(typeof(BandFormats))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(SurfaceChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SurfaceChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10522;
    /// <inheritdoc/>
    public override string LocalName => "surfaceChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChart class.
    /// </summary>
    public SurfaceChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SurfaceChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurfaceChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "wireframe" == name)
    return new Wireframe();
    
if( 11 == namespaceId && "ser" == name)
    return new SurfaceChartSeries();
    
if( 11 == namespaceId && "bandFmts" == name)
    return new BandFormats();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new SurfaceChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "wireframe","ser","bandFmts","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Wireframe.</para>
    /// <para> Represents the following element tag in the schema: c:wireframe </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Wireframe Wireframe
    {
        get => GetElement<Wireframe>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChart>(deep);

}
/// <summary>
/// <para>3D Surface Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:surface3DChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Wireframe &lt;c:wireframe></description></item>
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>SurfaceChartSeries &lt;c:ser></description></item>
///<item><description>BandFormats &lt;c:bandFmts></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>Surface3DChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Wireframe))]
    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(SurfaceChartSeries))]
    [ChildElementInfo(typeof(BandFormats))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(Surface3DChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Surface3DChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10523;
    /// <inheritdoc/>
    public override string LocalName => "surface3DChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Surface3DChart class.
    /// </summary>
    public Surface3DChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Surface3DChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Surface3DChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Surface3DChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Surface3DChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Surface3DChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Surface3DChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "wireframe" == name)
    return new Wireframe();
    
if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new SurfaceChartSeries();
    
if( 11 == namespaceId && "bandFmts" == name)
    return new BandFormats();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new Surface3DChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "wireframe","varyColors","ser","bandFmts","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Wireframe.</para>
    /// <para> Represents the following element tag in the schema: c:wireframe </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Wireframe Wireframe
    {
        get => GetElement<Wireframe>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Surface3DChart>(deep);

}
/// <summary>
/// <para>Bubble Charts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:bubbleChart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VaryColors &lt;c:varyColors></description></item>
///<item><description>BubbleChartSeries &lt;c:ser></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>Bubble3D &lt;c:bubble3D></description></item>
///<item><description>BubbleScale &lt;c:bubbleScale></description></item>
///<item><description>ShowNegativeBubbles &lt;c:showNegBubbles></description></item>
///<item><description>SizeRepresents &lt;c:sizeRepresents></description></item>
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>BubbleChartExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(VaryColors))]
    [ChildElementInfo(typeof(BubbleChartSeries))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(Bubble3D))]
    [ChildElementInfo(typeof(BubbleScale))]
    [ChildElementInfo(typeof(ShowNegativeBubbles))]
    [ChildElementInfo(typeof(SizeRepresents))]
    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(BubbleChartExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BubbleChart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10524;
    /// <inheritdoc/>
    public override string LocalName => "bubbleChart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BubbleChart class.
    /// </summary>
    public BubbleChart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BubbleChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BubbleChart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "varyColors" == name)
    return new VaryColors();
    
if( 11 == namespaceId && "ser" == name)
    return new BubbleChartSeries();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "bubble3D" == name)
    return new Bubble3D();
    
if( 11 == namespaceId && "bubbleScale" == name)
    return new BubbleScale();
    
if( 11 == namespaceId && "showNegBubbles" == name)
    return new ShowNegativeBubbles();
    
if( 11 == namespaceId && "sizeRepresents" == name)
    return new SizeRepresents();
    
if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "extLst" == name)
    return new BubbleChartExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "varyColors","ser","dLbls","bubble3D","bubbleScale","showNegBubbles","sizeRepresents","axId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> VaryColors.</para>
    /// <para> Represents the following element tag in the schema: c:varyColors </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public VaryColors VaryColors
    {
        get => GetElement<VaryColors>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChart>(deep);

}
/// <summary>
/// <para>Value Axis.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:valAx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>Scaling &lt;c:scaling></description></item>
///<item><description>Delete &lt;c:delete></description></item>
///<item><description>AxisPosition &lt;c:axPos></description></item>
///<item><description>MajorGridlines &lt;c:majorGridlines></description></item>
///<item><description>MinorGridlines &lt;c:minorGridlines></description></item>
///<item><description>Title &lt;c:title></description></item>
///<item><description>NumberingFormat &lt;c:numFmt></description></item>
///<item><description>MajorTickMark &lt;c:majorTickMark></description></item>
///<item><description>MinorTickMark &lt;c:minorTickMark></description></item>
///<item><description>TickLabelPosition &lt;c:tickLblPos></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>CrossingAxis &lt;c:crossAx></description></item>
///<item><description>Crosses &lt;c:crosses></description></item>
///<item><description>CrossesAt &lt;c:crossesAt></description></item>
///<item><description>CrossBetween &lt;c:crossBetween></description></item>
///<item><description>MajorUnit &lt;c:majorUnit></description></item>
///<item><description>MinorUnit &lt;c:minorUnit></description></item>
///<item><description>DisplayUnits &lt;c:dispUnits></description></item>
///<item><description>ValAxExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(Scaling))]
    [ChildElementInfo(typeof(Delete))]
    [ChildElementInfo(typeof(AxisPosition))]
    [ChildElementInfo(typeof(MajorGridlines))]
    [ChildElementInfo(typeof(MinorGridlines))]
    [ChildElementInfo(typeof(Title))]
    [ChildElementInfo(typeof(NumberingFormat))]
    [ChildElementInfo(typeof(MajorTickMark))]
    [ChildElementInfo(typeof(MinorTickMark))]
    [ChildElementInfo(typeof(TickLabelPosition))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(CrossingAxis))]
    [ChildElementInfo(typeof(Crosses))]
    [ChildElementInfo(typeof(CrossesAt))]
    [ChildElementInfo(typeof(CrossBetween))]
    [ChildElementInfo(typeof(MajorUnit))]
    [ChildElementInfo(typeof(MinorUnit))]
    [ChildElementInfo(typeof(DisplayUnits))]
    [ChildElementInfo(typeof(ValAxExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ValueAxis : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10525;
    /// <inheritdoc/>
    public override string LocalName => "valAx";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ValueAxis class.
    /// </summary>
    public ValueAxis():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ValueAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ValueAxis(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ValueAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ValueAxis(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ValueAxis class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ValueAxis(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "scaling" == name)
    return new Scaling();
    
if( 11 == namespaceId && "delete" == name)
    return new Delete();
    
if( 11 == namespaceId && "axPos" == name)
    return new AxisPosition();
    
if( 11 == namespaceId && "majorGridlines" == name)
    return new MajorGridlines();
    
if( 11 == namespaceId && "minorGridlines" == name)
    return new MinorGridlines();
    
if( 11 == namespaceId && "title" == name)
    return new Title();
    
if( 11 == namespaceId && "numFmt" == name)
    return new NumberingFormat();
    
if( 11 == namespaceId && "majorTickMark" == name)
    return new MajorTickMark();
    
if( 11 == namespaceId && "minorTickMark" == name)
    return new MinorTickMark();
    
if( 11 == namespaceId && "tickLblPos" == name)
    return new TickLabelPosition();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "crossAx" == name)
    return new CrossingAxis();
    
if( 11 == namespaceId && "crosses" == name)
    return new Crosses();
    
if( 11 == namespaceId && "crossesAt" == name)
    return new CrossesAt();
    
if( 11 == namespaceId && "crossBetween" == name)
    return new CrossBetween();
    
if( 11 == namespaceId && "majorUnit" == name)
    return new MajorUnit();
    
if( 11 == namespaceId && "minorUnit" == name)
    return new MinorUnit();
    
if( 11 == namespaceId && "dispUnits" == name)
    return new DisplayUnits();
    
if( 11 == namespaceId && "extLst" == name)
    return new ValAxExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "axId","scaling","delete","axPos","majorGridlines","minorGridlines","title","numFmt","majorTickMark","minorTickMark","tickLblPos","spPr","txPr","crossAx","crosses","crossesAt","crossBetween","majorUnit","minorUnit","dispUnits","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Axis ID.</para>
    /// <para> Represents the following element tag in the schema: c:axId </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public AxisId AxisId
    {
        get => GetElement<AxisId>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Scaling.</para>
    /// <para> Represents the following element tag in the schema: c:scaling </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Scaling Scaling
    {
        get => GetElement<Scaling>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Delete.</para>
    /// <para> Represents the following element tag in the schema: c:delete </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Delete Delete
    {
        get => GetElement<Delete>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Axis Position.</para>
    /// <para> Represents the following element tag in the schema: c:axPos </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public AxisPosition AxisPosition
    {
        get => GetElement<AxisPosition>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Major Gridlines.</para>
    /// <para> Represents the following element tag in the schema: c:majorGridlines </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MajorGridlines MajorGridlines
    {
        get => GetElement<MajorGridlines>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Minor Gridlines.</para>
    /// <para> Represents the following element tag in the schema: c:minorGridlines </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MinorGridlines MinorGridlines
    {
        get => GetElement<MinorGridlines>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Title.</para>
    /// <para> Represents the following element tag in the schema: c:title </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Title Title
    {
        get => GetElement<Title>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Number Format.</para>
    /// <para> Represents the following element tag in the schema: c:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumberingFormat NumberingFormat
    {
        get => GetElement<NumberingFormat>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Major Tick Mark.</para>
    /// <para> Represents the following element tag in the schema: c:majorTickMark </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MajorTickMark MajorTickMark
    {
        get => GetElement<MajorTickMark>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Minor Tick Mark.</para>
    /// <para> Represents the following element tag in the schema: c:minorTickMark </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MinorTickMark MinorTickMark
    {
        get => GetElement<MinorTickMark>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> Tick Label Position.</para>
    /// <para> Represents the following element tag in the schema: c:tickLblPos </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TickLabelPosition TickLabelPosition
    {
        get => GetElement<TickLabelPosition>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(11);
        set => SetElement(11, value);
    }
    /// <summary>
    /// <para> TextProperties.</para>
    /// <para> Represents the following element tag in the schema: c:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TextProperties TextProperties
    {
        get => GetElement<TextProperties>(12);
        set => SetElement(12, value);
    }
    /// <summary>
    /// <para> Crossing Axis ID.</para>
    /// <para> Represents the following element tag in the schema: c:crossAx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public CrossingAxis CrossingAxis
    {
        get => GetElement<CrossingAxis>(13);
        set => SetElement(13, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValueAxis>(deep);

}
/// <summary>
/// <para>Category Axis Data.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:catAx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>Scaling &lt;c:scaling></description></item>
///<item><description>Delete &lt;c:delete></description></item>
///<item><description>AxisPosition &lt;c:axPos></description></item>
///<item><description>MajorGridlines &lt;c:majorGridlines></description></item>
///<item><description>MinorGridlines &lt;c:minorGridlines></description></item>
///<item><description>Title &lt;c:title></description></item>
///<item><description>NumberingFormat &lt;c:numFmt></description></item>
///<item><description>MajorTickMark &lt;c:majorTickMark></description></item>
///<item><description>MinorTickMark &lt;c:minorTickMark></description></item>
///<item><description>TickLabelPosition &lt;c:tickLblPos></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>CrossingAxis &lt;c:crossAx></description></item>
///<item><description>Crosses &lt;c:crosses></description></item>
///<item><description>CrossesAt &lt;c:crossesAt></description></item>
///<item><description>AutoLabeled &lt;c:auto></description></item>
///<item><description>LabelAlignment &lt;c:lblAlgn></description></item>
///<item><description>LabelOffset &lt;c:lblOffset></description></item>
///<item><description>TickLabelSkip &lt;c:tickLblSkip></description></item>
///<item><description>TickMarkSkip &lt;c:tickMarkSkip></description></item>
///<item><description>NoMultiLevelLabels &lt;c:noMultiLvlLbl></description></item>
///<item><description>CatAxExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(Scaling))]
    [ChildElementInfo(typeof(Delete))]
    [ChildElementInfo(typeof(AxisPosition))]
    [ChildElementInfo(typeof(MajorGridlines))]
    [ChildElementInfo(typeof(MinorGridlines))]
    [ChildElementInfo(typeof(Title))]
    [ChildElementInfo(typeof(NumberingFormat))]
    [ChildElementInfo(typeof(MajorTickMark))]
    [ChildElementInfo(typeof(MinorTickMark))]
    [ChildElementInfo(typeof(TickLabelPosition))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(CrossingAxis))]
    [ChildElementInfo(typeof(Crosses))]
    [ChildElementInfo(typeof(CrossesAt))]
    [ChildElementInfo(typeof(AutoLabeled))]
    [ChildElementInfo(typeof(LabelAlignment))]
    [ChildElementInfo(typeof(LabelOffset))]
    [ChildElementInfo(typeof(TickLabelSkip))]
    [ChildElementInfo(typeof(TickMarkSkip))]
    [ChildElementInfo(typeof(NoMultiLevelLabels))]
    [ChildElementInfo(typeof(CatAxExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CategoryAxis : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10526;
    /// <inheritdoc/>
    public override string LocalName => "catAx";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the CategoryAxis class.
    /// </summary>
    public CategoryAxis():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CategoryAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryAxis(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryAxis(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryAxis class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryAxis(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "scaling" == name)
    return new Scaling();
    
if( 11 == namespaceId && "delete" == name)
    return new Delete();
    
if( 11 == namespaceId && "axPos" == name)
    return new AxisPosition();
    
if( 11 == namespaceId && "majorGridlines" == name)
    return new MajorGridlines();
    
if( 11 == namespaceId && "minorGridlines" == name)
    return new MinorGridlines();
    
if( 11 == namespaceId && "title" == name)
    return new Title();
    
if( 11 == namespaceId && "numFmt" == name)
    return new NumberingFormat();
    
if( 11 == namespaceId && "majorTickMark" == name)
    return new MajorTickMark();
    
if( 11 == namespaceId && "minorTickMark" == name)
    return new MinorTickMark();
    
if( 11 == namespaceId && "tickLblPos" == name)
    return new TickLabelPosition();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "crossAx" == name)
    return new CrossingAxis();
    
if( 11 == namespaceId && "crosses" == name)
    return new Crosses();
    
if( 11 == namespaceId && "crossesAt" == name)
    return new CrossesAt();
    
if( 11 == namespaceId && "auto" == name)
    return new AutoLabeled();
    
if( 11 == namespaceId && "lblAlgn" == name)
    return new LabelAlignment();
    
if( 11 == namespaceId && "lblOffset" == name)
    return new LabelOffset();
    
if( 11 == namespaceId && "tickLblSkip" == name)
    return new TickLabelSkip();
    
if( 11 == namespaceId && "tickMarkSkip" == name)
    return new TickMarkSkip();
    
if( 11 == namespaceId && "noMultiLvlLbl" == name)
    return new NoMultiLevelLabels();
    
if( 11 == namespaceId && "extLst" == name)
    return new CatAxExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "axId","scaling","delete","axPos","majorGridlines","minorGridlines","title","numFmt","majorTickMark","minorTickMark","tickLblPos","spPr","txPr","crossAx","crosses","crossesAt","auto","lblAlgn","lblOffset","tickLblSkip","tickMarkSkip","noMultiLvlLbl","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Axis ID.</para>
    /// <para> Represents the following element tag in the schema: c:axId </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public AxisId AxisId
    {
        get => GetElement<AxisId>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Scaling.</para>
    /// <para> Represents the following element tag in the schema: c:scaling </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Scaling Scaling
    {
        get => GetElement<Scaling>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Delete.</para>
    /// <para> Represents the following element tag in the schema: c:delete </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Delete Delete
    {
        get => GetElement<Delete>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Axis Position.</para>
    /// <para> Represents the following element tag in the schema: c:axPos </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public AxisPosition AxisPosition
    {
        get => GetElement<AxisPosition>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Major Gridlines.</para>
    /// <para> Represents the following element tag in the schema: c:majorGridlines </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MajorGridlines MajorGridlines
    {
        get => GetElement<MajorGridlines>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Minor Gridlines.</para>
    /// <para> Represents the following element tag in the schema: c:minorGridlines </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MinorGridlines MinorGridlines
    {
        get => GetElement<MinorGridlines>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Title.</para>
    /// <para> Represents the following element tag in the schema: c:title </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Title Title
    {
        get => GetElement<Title>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Number Format.</para>
    /// <para> Represents the following element tag in the schema: c:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumberingFormat NumberingFormat
    {
        get => GetElement<NumberingFormat>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Major Tick Mark.</para>
    /// <para> Represents the following element tag in the schema: c:majorTickMark </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MajorTickMark MajorTickMark
    {
        get => GetElement<MajorTickMark>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Minor Tick Mark.</para>
    /// <para> Represents the following element tag in the schema: c:minorTickMark </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MinorTickMark MinorTickMark
    {
        get => GetElement<MinorTickMark>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> Tick Label Position.</para>
    /// <para> Represents the following element tag in the schema: c:tickLblPos </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TickLabelPosition TickLabelPosition
    {
        get => GetElement<TickLabelPosition>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(11);
        set => SetElement(11, value);
    }
    /// <summary>
    /// <para> TextProperties.</para>
    /// <para> Represents the following element tag in the schema: c:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TextProperties TextProperties
    {
        get => GetElement<TextProperties>(12);
        set => SetElement(12, value);
    }
    /// <summary>
    /// <para> Crossing Axis ID.</para>
    /// <para> Represents the following element tag in the schema: c:crossAx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public CrossingAxis CrossingAxis
    {
        get => GetElement<CrossingAxis>(13);
        set => SetElement(13, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxis>(deep);

}
/// <summary>
/// <para>Date Axis.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dateAx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>Scaling &lt;c:scaling></description></item>
///<item><description>Delete &lt;c:delete></description></item>
///<item><description>AxisPosition &lt;c:axPos></description></item>
///<item><description>MajorGridlines &lt;c:majorGridlines></description></item>
///<item><description>MinorGridlines &lt;c:minorGridlines></description></item>
///<item><description>Title &lt;c:title></description></item>
///<item><description>NumberingFormat &lt;c:numFmt></description></item>
///<item><description>MajorTickMark &lt;c:majorTickMark></description></item>
///<item><description>MinorTickMark &lt;c:minorTickMark></description></item>
///<item><description>TickLabelPosition &lt;c:tickLblPos></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>CrossingAxis &lt;c:crossAx></description></item>
///<item><description>Crosses &lt;c:crosses></description></item>
///<item><description>CrossesAt &lt;c:crossesAt></description></item>
///<item><description>AutoLabeled &lt;c:auto></description></item>
///<item><description>LabelOffset &lt;c:lblOffset></description></item>
///<item><description>BaseTimeUnit &lt;c:baseTimeUnit></description></item>
///<item><description>MajorUnit &lt;c:majorUnit></description></item>
///<item><description>MajorTimeUnit &lt;c:majorTimeUnit></description></item>
///<item><description>MinorUnit &lt;c:minorUnit></description></item>
///<item><description>MinorTimeUnit &lt;c:minorTimeUnit></description></item>
///<item><description>DateAxExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(Scaling))]
    [ChildElementInfo(typeof(Delete))]
    [ChildElementInfo(typeof(AxisPosition))]
    [ChildElementInfo(typeof(MajorGridlines))]
    [ChildElementInfo(typeof(MinorGridlines))]
    [ChildElementInfo(typeof(Title))]
    [ChildElementInfo(typeof(NumberingFormat))]
    [ChildElementInfo(typeof(MajorTickMark))]
    [ChildElementInfo(typeof(MinorTickMark))]
    [ChildElementInfo(typeof(TickLabelPosition))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(CrossingAxis))]
    [ChildElementInfo(typeof(Crosses))]
    [ChildElementInfo(typeof(CrossesAt))]
    [ChildElementInfo(typeof(AutoLabeled))]
    [ChildElementInfo(typeof(LabelOffset))]
    [ChildElementInfo(typeof(BaseTimeUnit))]
    [ChildElementInfo(typeof(MajorUnit))]
    [ChildElementInfo(typeof(MajorTimeUnit))]
    [ChildElementInfo(typeof(MinorUnit))]
    [ChildElementInfo(typeof(MinorTimeUnit))]
    [ChildElementInfo(typeof(DateAxExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DateAxis : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10527;
    /// <inheritdoc/>
    public override string LocalName => "dateAx";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DateAxis class.
    /// </summary>
    public DateAxis():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DateAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DateAxis(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DateAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DateAxis(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DateAxis class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DateAxis(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "scaling" == name)
    return new Scaling();
    
if( 11 == namespaceId && "delete" == name)
    return new Delete();
    
if( 11 == namespaceId && "axPos" == name)
    return new AxisPosition();
    
if( 11 == namespaceId && "majorGridlines" == name)
    return new MajorGridlines();
    
if( 11 == namespaceId && "minorGridlines" == name)
    return new MinorGridlines();
    
if( 11 == namespaceId && "title" == name)
    return new Title();
    
if( 11 == namespaceId && "numFmt" == name)
    return new NumberingFormat();
    
if( 11 == namespaceId && "majorTickMark" == name)
    return new MajorTickMark();
    
if( 11 == namespaceId && "minorTickMark" == name)
    return new MinorTickMark();
    
if( 11 == namespaceId && "tickLblPos" == name)
    return new TickLabelPosition();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "crossAx" == name)
    return new CrossingAxis();
    
if( 11 == namespaceId && "crosses" == name)
    return new Crosses();
    
if( 11 == namespaceId && "crossesAt" == name)
    return new CrossesAt();
    
if( 11 == namespaceId && "auto" == name)
    return new AutoLabeled();
    
if( 11 == namespaceId && "lblOffset" == name)
    return new LabelOffset();
    
if( 11 == namespaceId && "baseTimeUnit" == name)
    return new BaseTimeUnit();
    
if( 11 == namespaceId && "majorUnit" == name)
    return new MajorUnit();
    
if( 11 == namespaceId && "majorTimeUnit" == name)
    return new MajorTimeUnit();
    
if( 11 == namespaceId && "minorUnit" == name)
    return new MinorUnit();
    
if( 11 == namespaceId && "minorTimeUnit" == name)
    return new MinorTimeUnit();
    
if( 11 == namespaceId && "extLst" == name)
    return new DateAxExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "axId","scaling","delete","axPos","majorGridlines","minorGridlines","title","numFmt","majorTickMark","minorTickMark","tickLblPos","spPr","txPr","crossAx","crosses","crossesAt","auto","lblOffset","baseTimeUnit","majorUnit","majorTimeUnit","minorUnit","minorTimeUnit","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Axis ID.</para>
    /// <para> Represents the following element tag in the schema: c:axId </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public AxisId AxisId
    {
        get => GetElement<AxisId>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Scaling.</para>
    /// <para> Represents the following element tag in the schema: c:scaling </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Scaling Scaling
    {
        get => GetElement<Scaling>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Delete.</para>
    /// <para> Represents the following element tag in the schema: c:delete </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Delete Delete
    {
        get => GetElement<Delete>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Axis Position.</para>
    /// <para> Represents the following element tag in the schema: c:axPos </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public AxisPosition AxisPosition
    {
        get => GetElement<AxisPosition>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Major Gridlines.</para>
    /// <para> Represents the following element tag in the schema: c:majorGridlines </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MajorGridlines MajorGridlines
    {
        get => GetElement<MajorGridlines>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Minor Gridlines.</para>
    /// <para> Represents the following element tag in the schema: c:minorGridlines </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MinorGridlines MinorGridlines
    {
        get => GetElement<MinorGridlines>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Title.</para>
    /// <para> Represents the following element tag in the schema: c:title </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Title Title
    {
        get => GetElement<Title>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Number Format.</para>
    /// <para> Represents the following element tag in the schema: c:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumberingFormat NumberingFormat
    {
        get => GetElement<NumberingFormat>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Major Tick Mark.</para>
    /// <para> Represents the following element tag in the schema: c:majorTickMark </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MajorTickMark MajorTickMark
    {
        get => GetElement<MajorTickMark>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Minor Tick Mark.</para>
    /// <para> Represents the following element tag in the schema: c:minorTickMark </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MinorTickMark MinorTickMark
    {
        get => GetElement<MinorTickMark>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> Tick Label Position.</para>
    /// <para> Represents the following element tag in the schema: c:tickLblPos </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TickLabelPosition TickLabelPosition
    {
        get => GetElement<TickLabelPosition>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(11);
        set => SetElement(11, value);
    }
    /// <summary>
    /// <para> TextProperties.</para>
    /// <para> Represents the following element tag in the schema: c:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TextProperties TextProperties
    {
        get => GetElement<TextProperties>(12);
        set => SetElement(12, value);
    }
    /// <summary>
    /// <para> Crossing Axis ID.</para>
    /// <para> Represents the following element tag in the schema: c:crossAx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public CrossingAxis CrossingAxis
    {
        get => GetElement<CrossingAxis>(13);
        set => SetElement(13, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DateAxis>(deep);

}
/// <summary>
/// <para>Series Axis.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:serAx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AxisId &lt;c:axId></description></item>
///<item><description>Scaling &lt;c:scaling></description></item>
///<item><description>Delete &lt;c:delete></description></item>
///<item><description>AxisPosition &lt;c:axPos></description></item>
///<item><description>MajorGridlines &lt;c:majorGridlines></description></item>
///<item><description>MinorGridlines &lt;c:minorGridlines></description></item>
///<item><description>Title &lt;c:title></description></item>
///<item><description>NumberingFormat &lt;c:numFmt></description></item>
///<item><description>MajorTickMark &lt;c:majorTickMark></description></item>
///<item><description>MinorTickMark &lt;c:minorTickMark></description></item>
///<item><description>TickLabelPosition &lt;c:tickLblPos></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>CrossingAxis &lt;c:crossAx></description></item>
///<item><description>Crosses &lt;c:crosses></description></item>
///<item><description>CrossesAt &lt;c:crossesAt></description></item>
///<item><description>TickLabelSkip &lt;c:tickLblSkip></description></item>
///<item><description>TickMarkSkip &lt;c:tickMarkSkip></description></item>
///<item><description>SerAxExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AxisId))]
    [ChildElementInfo(typeof(Scaling))]
    [ChildElementInfo(typeof(Delete))]
    [ChildElementInfo(typeof(AxisPosition))]
    [ChildElementInfo(typeof(MajorGridlines))]
    [ChildElementInfo(typeof(MinorGridlines))]
    [ChildElementInfo(typeof(Title))]
    [ChildElementInfo(typeof(NumberingFormat))]
    [ChildElementInfo(typeof(MajorTickMark))]
    [ChildElementInfo(typeof(MinorTickMark))]
    [ChildElementInfo(typeof(TickLabelPosition))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(CrossingAxis))]
    [ChildElementInfo(typeof(Crosses))]
    [ChildElementInfo(typeof(CrossesAt))]
    [ChildElementInfo(typeof(TickLabelSkip))]
    [ChildElementInfo(typeof(TickMarkSkip))]
    [ChildElementInfo(typeof(SerAxExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SeriesAxis : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10528;
    /// <inheritdoc/>
    public override string LocalName => "serAx";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SeriesAxis class.
    /// </summary>
    public SeriesAxis():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SeriesAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesAxis(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesAxis class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SeriesAxis(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SeriesAxis class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SeriesAxis(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "axId" == name)
    return new AxisId();
    
if( 11 == namespaceId && "scaling" == name)
    return new Scaling();
    
if( 11 == namespaceId && "delete" == name)
    return new Delete();
    
if( 11 == namespaceId && "axPos" == name)
    return new AxisPosition();
    
if( 11 == namespaceId && "majorGridlines" == name)
    return new MajorGridlines();
    
if( 11 == namespaceId && "minorGridlines" == name)
    return new MinorGridlines();
    
if( 11 == namespaceId && "title" == name)
    return new Title();
    
if( 11 == namespaceId && "numFmt" == name)
    return new NumberingFormat();
    
if( 11 == namespaceId && "majorTickMark" == name)
    return new MajorTickMark();
    
if( 11 == namespaceId && "minorTickMark" == name)
    return new MinorTickMark();
    
if( 11 == namespaceId && "tickLblPos" == name)
    return new TickLabelPosition();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "crossAx" == name)
    return new CrossingAxis();
    
if( 11 == namespaceId && "crosses" == name)
    return new Crosses();
    
if( 11 == namespaceId && "crossesAt" == name)
    return new CrossesAt();
    
if( 11 == namespaceId && "tickLblSkip" == name)
    return new TickLabelSkip();
    
if( 11 == namespaceId && "tickMarkSkip" == name)
    return new TickMarkSkip();
    
if( 11 == namespaceId && "extLst" == name)
    return new SerAxExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "axId","scaling","delete","axPos","majorGridlines","minorGridlines","title","numFmt","majorTickMark","minorTickMark","tickLblPos","spPr","txPr","crossAx","crosses","crossesAt","tickLblSkip","tickMarkSkip","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Axis ID.</para>
    /// <para> Represents the following element tag in the schema: c:axId </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public AxisId AxisId
    {
        get => GetElement<AxisId>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Scaling.</para>
    /// <para> Represents the following element tag in the schema: c:scaling </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Scaling Scaling
    {
        get => GetElement<Scaling>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Delete.</para>
    /// <para> Represents the following element tag in the schema: c:delete </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Delete Delete
    {
        get => GetElement<Delete>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Axis Position.</para>
    /// <para> Represents the following element tag in the schema: c:axPos </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public AxisPosition AxisPosition
    {
        get => GetElement<AxisPosition>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Major Gridlines.</para>
    /// <para> Represents the following element tag in the schema: c:majorGridlines </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MajorGridlines MajorGridlines
    {
        get => GetElement<MajorGridlines>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Minor Gridlines.</para>
    /// <para> Represents the following element tag in the schema: c:minorGridlines </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MinorGridlines MinorGridlines
    {
        get => GetElement<MinorGridlines>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Title.</para>
    /// <para> Represents the following element tag in the schema: c:title </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Title Title
    {
        get => GetElement<Title>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Number Format.</para>
    /// <para> Represents the following element tag in the schema: c:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumberingFormat NumberingFormat
    {
        get => GetElement<NumberingFormat>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Major Tick Mark.</para>
    /// <para> Represents the following element tag in the schema: c:majorTickMark </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MajorTickMark MajorTickMark
    {
        get => GetElement<MajorTickMark>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Minor Tick Mark.</para>
    /// <para> Represents the following element tag in the schema: c:minorTickMark </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MinorTickMark MinorTickMark
    {
        get => GetElement<MinorTickMark>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> Tick Label Position.</para>
    /// <para> Represents the following element tag in the schema: c:tickLblPos </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TickLabelPosition TickLabelPosition
    {
        get => GetElement<TickLabelPosition>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(11);
        set => SetElement(11, value);
    }
    /// <summary>
    /// <para> TextProperties.</para>
    /// <para> Represents the following element tag in the schema: c:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TextProperties TextProperties
    {
        get => GetElement<TextProperties>(12);
        set => SetElement(12, value);
    }
    /// <summary>
    /// <para> Crossing Axis ID.</para>
    /// <para> Represents the following element tag in the schema: c:crossAx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public CrossingAxis CrossingAxis
    {
        get => GetElement<CrossingAxis>(13);
        set => SetElement(13, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesAxis>(deep);

}
/// <summary>
/// <para>Data Table.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dTable.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShowHorizontalBorder &lt;c:showHorzBorder></description></item>
///<item><description>ShowVerticalBorder &lt;c:showVertBorder></description></item>
///<item><description>ShowOutlineBorder &lt;c:showOutline></description></item>
///<item><description>ShowKeys &lt;c:showKeys></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TextProperties &lt;c:txPr></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShowHorizontalBorder))]
    [ChildElementInfo(typeof(ShowVerticalBorder))]
    [ChildElementInfo(typeof(ShowOutlineBorder))]
    [ChildElementInfo(typeof(ShowKeys))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TextProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DataTable : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10529;
    /// <inheritdoc/>
    public override string LocalName => "dTable";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DataTable class.
    /// </summary>
    public DataTable():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DataTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataTable(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataTable class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataTable(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataTable class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataTable(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "showHorzBorder" == name)
    return new ShowHorizontalBorder();
    
if( 11 == namespaceId && "showVertBorder" == name)
    return new ShowVerticalBorder();
    
if( 11 == namespaceId && "showOutline" == name)
    return new ShowOutlineBorder();
    
if( 11 == namespaceId && "showKeys" == name)
    return new ShowKeys();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new TextProperties();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "showHorzBorder","showVertBorder","showOutline","showKeys","spPr","txPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Show Horizontal Border.</para>
    /// <para> Represents the following element tag in the schema: c:showHorzBorder </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ShowHorizontalBorder ShowHorizontalBorder
    {
        get => GetElement<ShowHorizontalBorder>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Show Vertical Border.</para>
    /// <para> Represents the following element tag in the schema: c:showVertBorder </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ShowVerticalBorder ShowVerticalBorder
    {
        get => GetElement<ShowVerticalBorder>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Show Outline Border.</para>
    /// <para> Represents the following element tag in the schema: c:showOutline </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ShowOutlineBorder ShowOutlineBorder
    {
        get => GetElement<ShowOutlineBorder>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Show Legend Keys.</para>
    /// <para> Represents the following element tag in the schema: c:showKeys </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ShowKeys ShowKeys
    {
        get => GetElement<ShowKeys>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Text Properties.</para>
    /// <para> Represents the following element tag in the schema: c:txPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TextProperties TextProperties
    {
        get => GetElement<TextProperties>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(6);
        set => SetElement(6, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataTable>(deep);

}
/// <summary>
/// <para>First Slice Angle.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:firstSliceAng.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FirstSliceAngle : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10530;
    /// <inheritdoc/>
    public override string LocalName => "firstSliceAng";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt16Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> First Slice Angle Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt16Value Val
    {
        get { return (UInt16Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FirstSliceAngle class.
    /// </summary>
    public FirstSliceAngle():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstSliceAngle>(deep);

}
/// <summary>
/// <para>Hole Size.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:holeSize.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HoleSize : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10531;
    /// <inheritdoc/>
    public override string LocalName => "holeSize";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<ByteValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Hole Size Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public ByteValue Val
    {
        get { return (ByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the HoleSize class.
    /// </summary>
    public HoleSize():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HoleSize>(deep);

}
/// <summary>
/// <para>String Point.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pt.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumericValue &lt;c:v></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NumericValue))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StringPoint : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10532;
    /// <inheritdoc/>
    public override string LocalName => "pt";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "idx")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Index.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    public UInt32Value Index
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StringPoint class.
    /// </summary>
    public StringPoint():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StringPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringPoint(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StringPoint class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringPoint(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StringPoint class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StringPoint(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "v" == name)
    return new NumericValue();
    

    return null;
}

        private static readonly string[] eleTagNames = { "v" };
    private static readonly byte[] eleNamespaceIds = { 11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Text Value.</para>
    /// <para> Represents the following element tag in the schema: c:v </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumericValue NumericValue
    {
        get => GetElement<NumericValue>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringPoint>(deep);

}
/// <summary>
/// <para>Thickness.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:thickness.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Thickness : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10534;
    /// <inheritdoc/>
    public override string LocalName => "thickness";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<ByteValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public ByteValue Val
    {
        get { return (ByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Thickness class.
    /// </summary>
    public Thickness():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Thickness>(deep);

}
/// <summary>
/// <para>Defines the StockChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension &lt;c15:filteredLineSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StockChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10535;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StockChartExtension class.
    /// </summary>
    public StockChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StockChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StockChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StockChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StockChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StockChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StockChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredLineSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StockChartExtension>(deep);

}
/// <summary>
/// <para>Defines the PieChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries &lt;c15:filteredPieSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PieChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10536;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PieChartExtension class.
    /// </summary>
    public PieChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PieChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PieChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredPieSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChartExtension>(deep);

}
/// <summary>
/// <para>Defines the Pie3DChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries &lt;c15:filteredPieSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Pie3DChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10537;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Pie3DChartExtension class.
    /// </summary>
    public Pie3DChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Pie3DChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Pie3DChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Pie3DChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Pie3DChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Pie3DChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Pie3DChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredPieSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Pie3DChartExtension>(deep);

}
/// <summary>
/// <para>Defines the NumRefExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference &lt;c15:fullRef></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference &lt;c15:levelRef></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference &lt;c15:formulaRef></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NumRefExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10538;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NumRefExtension class.
    /// </summary>
    public NumRefExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NumRefExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumRefExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumRefExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumRefExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumRefExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumRefExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "fullRef" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference();
    
if( 64 == namespaceId && "levelRef" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference();
    
if( 64 == namespaceId && "formulaRef" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumRefExtension>(deep);

}
/// <summary>
/// <para>Defines the StrDataExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories &lt;c15:autoCat></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrDataExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10539;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StrDataExtension class.
    /// </summary>
    public StrDataExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StrDataExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrDataExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StrDataExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrDataExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StrDataExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StrDataExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "autoCat" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrDataExtension>(deep);

}
/// <summary>
/// <para>Defines the StrRefExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference &lt;c15:fullRef></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference &lt;c15:levelRef></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference &lt;c15:formulaRef></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrRefExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10540;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the StrRefExtension class.
    /// </summary>
    public StrRefExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StrRefExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrRefExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StrRefExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrRefExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StrRefExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StrRefExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "fullRef" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference();
    
if( 64 == namespaceId && "levelRef" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference();
    
if( 64 == namespaceId && "formulaRef" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrRefExtension>(deep);

}
/// <summary>
/// <para>Defines the MultiLvlStrRefExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference &lt;c15:fullRef></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference &lt;c15:levelRef></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference &lt;c15:formulaRef></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MultiLvlStrRefExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10541;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MultiLvlStrRefExtension class.
    /// </summary>
    public MultiLvlStrRefExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MultiLvlStrRefExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrRefExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrRefExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrRefExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrRefExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MultiLvlStrRefExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "fullRef" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference();
    
if( 64 == namespaceId && "levelRef" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference();
    
if( 64 == namespaceId && "formulaRef" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrRefExtension>(deep);

}
/// <summary>
/// <para>Defines the DLblExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable &lt;c15:dlblFieldTable></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ExceptionForSave &lt;c15:xForSave></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange &lt;c15:showDataLabelsRange></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties &lt;c15:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout &lt;c15:layout></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ExceptionForSave), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DLblExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10542;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DLblExtension class.
    /// </summary>
    public DLblExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DLblExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLblExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DLblExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLblExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DLblExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DLblExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "dlblFieldTable" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable();
    
if( 64 == namespaceId && "xForSave" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ExceptionForSave();
    
if( 64 == namespaceId && "showDataLabelsRange" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange();
    
if( 64 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties();
    
if( 64 == namespaceId && "layout" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLblExtension>(deep);

}
/// <summary>
/// <para>Defines the DLblsExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText &lt;c15:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable &lt;c15:dlblFieldTable></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange &lt;c15:showDataLabelsRange></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties &lt;c15:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout &lt;c15:layout></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines &lt;c15:showLeaderLines></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines &lt;c15:leaderLines></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DLblsExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10543;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DLblsExtension class.
    /// </summary>
    public DLblsExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DLblsExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLblsExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DLblsExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLblsExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DLblsExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DLblsExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText();
    
if( 64 == namespaceId && "dlblFieldTable" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable();
    
if( 64 == namespaceId && "showDataLabelsRange" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange();
    
if( 64 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties();
    
if( 64 == namespaceId && "layout" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout();
    
if( 64 == namespaceId && "showLeaderLines" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines();
    
if( 64 == namespaceId && "leaderLines" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLblsExtension>(deep);

}
/// <summary>
/// <para>Defines the LineSerExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LineSerExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10544;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LineSerExtension class.
    /// </summary>
    public LineSerExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LineSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineSerExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LineSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineSerExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LineSerExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LineSerExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredSeriesTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle();
    
if( 64 == namespaceId && "filteredCategoryTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle();
    
if( 64 == namespaceId && "datalabelsRange" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange();
    
if( 64 == namespaceId && "categoryFilterExceptions" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSerExtension>(deep);

}
/// <summary>
/// <para>Defines the ScatterSerExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ScatterSerExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10545;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ScatterSerExtension class.
    /// </summary>
    public ScatterSerExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ScatterSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterSerExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterSerExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterSerExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ScatterSerExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredSeriesTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle();
    
if( 64 == namespaceId && "filteredCategoryTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle();
    
if( 64 == namespaceId && "datalabelsRange" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange();
    
if( 64 == namespaceId && "categoryFilterExceptions" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterSerExtension>(deep);

}
/// <summary>
/// <para>Defines the RadarSerExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RadarSerExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10546;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RadarSerExtension class.
    /// </summary>
    public RadarSerExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RadarSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarSerExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarSerExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarSerExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadarSerExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredSeriesTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle();
    
if( 64 == namespaceId && "filteredCategoryTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle();
    
if( 64 == namespaceId && "datalabelsRange" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange();
    
if( 64 == namespaceId && "categoryFilterExceptions" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarSerExtension>(deep);

}
/// <summary>
/// <para>Defines the AreaSerExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AreaSerExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10547;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the AreaSerExtension class.
    /// </summary>
    public AreaSerExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AreaSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaSerExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaSerExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaSerExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AreaSerExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredSeriesTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle();
    
if( 64 == namespaceId && "filteredCategoryTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle();
    
if( 64 == namespaceId && "datalabelsRange" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange();
    
if( 64 == namespaceId && "categoryFilterExceptions" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaSerExtension>(deep);

}
/// <summary>
/// <para>Defines the PieSerExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PieSerExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10548;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PieSerExtension class.
    /// </summary>
    public PieSerExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PieSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieSerExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PieSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieSerExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PieSerExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PieSerExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredSeriesTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle();
    
if( 64 == namespaceId && "filteredCategoryTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle();
    
if( 64 == namespaceId && "datalabelsRange" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange();
    
if( 64 == namespaceId && "categoryFilterExceptions" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieSerExtension>(deep);

}
/// <summary>
/// <para>Defines the SurfaceSerExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SurfaceSerExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10549;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SurfaceSerExtension class.
    /// </summary>
    public SurfaceSerExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SurfaceSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceSerExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceSerExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceSerExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurfaceSerExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredSeriesTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle();
    
if( 64 == namespaceId && "filteredCategoryTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle();
    
if( 64 == namespaceId && "categoryFilterExceptions" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceSerExtension>(deep);

}
/// <summary>
/// <para>Defines the LineChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension &lt;c15:filteredLineSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LineChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10550;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LineChartExtension class.
    /// </summary>
    public LineChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LineChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LineChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredLineSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChartExtension>(deep);

}
/// <summary>
/// <para>Defines the Line3DChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension &lt;c15:filteredLineSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Line3DChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10551;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Line3DChartExtension class.
    /// </summary>
    public Line3DChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Line3DChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Line3DChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Line3DChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Line3DChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Line3DChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Line3DChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredLineSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Line3DChartExtension>(deep);

}
/// <summary>
/// <para>Defines the ScatterChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries &lt;c15:filteredScatterSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ScatterChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10552;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ScatterChartExtension class.
    /// </summary>
    public ScatterChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ScatterChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ScatterChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredScatterSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChartExtension>(deep);

}
/// <summary>
/// <para>Defines the RadarChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries &lt;c15:filteredRadarSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RadarChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10553;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RadarChartExtension class.
    /// </summary>
    public RadarChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RadarChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadarChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredRadarSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChartExtension>(deep);

}
/// <summary>
/// <para>Defines the BarChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries &lt;c15:filteredBarSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BarChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10554;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BarChartExtension class.
    /// </summary>
    public BarChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BarChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BarChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredBarSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChartExtension>(deep);

}
/// <summary>
/// <para>Defines the Bar3DChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries &lt;c15:filteredBarSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Bar3DChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10555;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Bar3DChartExtension class.
    /// </summary>
    public Bar3DChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Bar3DChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Bar3DChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Bar3DChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Bar3DChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Bar3DChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Bar3DChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredBarSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bar3DChartExtension>(deep);

}
/// <summary>
/// <para>Defines the AreaChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries &lt;c15:filteredAreaSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AreaChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10556;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the AreaChartExtension class.
    /// </summary>
    public AreaChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AreaChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AreaChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredAreaSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChartExtension>(deep);

}
/// <summary>
/// <para>Defines the Area3DChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries &lt;c15:filteredAreaSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Area3DChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10557;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Area3DChartExtension class.
    /// </summary>
    public Area3DChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Area3DChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Area3DChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Area3DChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Area3DChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Area3DChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Area3DChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredAreaSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Area3DChartExtension>(deep);

}
/// <summary>
/// <para>Defines the BubbleChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries &lt;c15:filteredBubbleSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BubbleChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10558;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BubbleChartExtension class.
    /// </summary>
    public BubbleChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BubbleChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BubbleChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredBubbleSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChartExtension>(deep);

}
/// <summary>
/// <para>Defines the SurfaceChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries &lt;c15:filteredSurfaceSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SurfaceChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10559;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SurfaceChartExtension class.
    /// </summary>
    public SurfaceChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SurfaceChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurfaceChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredSurfaceSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChartExtension>(deep);

}
/// <summary>
/// <para>Defines the Surface3DChartExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries &lt;c15:filteredSurfaceSeries></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Surface3DChartExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10560;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Surface3DChartExtension class.
    /// </summary>
    public Surface3DChartExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Surface3DChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Surface3DChartExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Surface3DChartExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Surface3DChartExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Surface3DChartExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Surface3DChartExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "filteredSurfaceSeries" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Surface3DChartExtension>(deep);

}
/// <summary>
/// <para>Defines the CatAxExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat &lt;c15:numFmt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CatAxExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10561;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CatAxExtension class.
    /// </summary>
    public CatAxExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CatAxExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CatAxExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CatAxExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CatAxExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CatAxExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CatAxExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "numFmt" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CatAxExtension>(deep);

}
/// <summary>
/// <para>Defines the DateAxExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat &lt;c15:numFmt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DateAxExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10562;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DateAxExtension class.
    /// </summary>
    public DateAxExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DateAxExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DateAxExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DateAxExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DateAxExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DateAxExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DateAxExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "numFmt" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DateAxExtension>(deep);

}
/// <summary>
/// <para>Defines the SerAxExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat &lt;c15:numFmt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SerAxExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10563;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SerAxExtension class.
    /// </summary>
    public SerAxExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SerAxExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SerAxExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SerAxExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SerAxExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SerAxExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SerAxExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "numFmt" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SerAxExtension>(deep);

}
/// <summary>
/// <para>Defines the ValAxExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat &lt;c15:numFmt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ValAxExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10564;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ValAxExtension class.
    /// </summary>
    public ValAxExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ValAxExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ValAxExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ValAxExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ValAxExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ValAxExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ValAxExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 64 == namespaceId && "numFmt" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValAxExtension>(deep);

}
/// <summary>
/// <para>Defines the UpDownBars Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:upDownBars.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>GapWidth &lt;c:gapWidth></description></item>
///<item><description>UpBars &lt;c:upBars></description></item>
///<item><description>DownBars &lt;c:downBars></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(GapWidth))]
    [ChildElementInfo(typeof(UpBars))]
    [ChildElementInfo(typeof(DownBars))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class UpDownBars : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10566;
    /// <inheritdoc/>
    public override string LocalName => "upDownBars";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the UpDownBars class.
    /// </summary>
    public UpDownBars():base(){}
    
        /// <summary>
    ///Initializes a new instance of the UpDownBars class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UpDownBars(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UpDownBars class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UpDownBars(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UpDownBars class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public UpDownBars(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "gapWidth" == name)
    return new GapWidth();
    
if( 11 == namespaceId && "upBars" == name)
    return new UpBars();
    
if( 11 == namespaceId && "downBars" == name)
    return new DownBars();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "gapWidth","upBars","downBars","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Gap Width.</para>
    /// <para> Represents the following element tag in the schema: c:gapWidth </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public GapWidth GapWidth
    {
        get => GetElement<GapWidth>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Up Bars.</para>
    /// <para> Represents the following element tag in the schema: c:upBars </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public UpBars UpBars
    {
        get => GetElement<UpBars>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Down Bars.</para>
    /// <para> Represents the following element tag in the schema: c:downBars </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DownBars DownBars
    {
        get => GetElement<DownBars>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UpDownBars>(deep);

}
/// <summary>
/// <para>Defines the StockChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StockChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StockChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StockChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10567;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the StockChartExtensionList class.
    /// </summary>
    public StockChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StockChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StockChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StockChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StockChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StockChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StockChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new StockChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StockChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the PieChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PieChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PieChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PieChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10568;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PieChartExtensionList class.
    /// </summary>
    public PieChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PieChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PieChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PieChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new PieChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the Pie3DChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Pie3DChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Pie3DChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Pie3DChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10569;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Pie3DChartExtensionList class.
    /// </summary>
    public Pie3DChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Pie3DChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Pie3DChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Pie3DChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Pie3DChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Pie3DChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Pie3DChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new Pie3DChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Pie3DChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the NumRefExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumRefExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NumRefExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NumRefExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10572;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NumRefExtensionList class.
    /// </summary>
    public NumRefExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NumRefExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumRefExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumRefExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumRefExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumRefExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumRefExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new NumRefExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumRefExtensionList>(deep);

}
/// <summary>
/// <para>Defines the StrDataExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StrDataExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StrDataExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrDataExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10573;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the StrDataExtensionList class.
    /// </summary>
    public StrDataExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StrDataExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrDataExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StrDataExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrDataExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StrDataExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StrDataExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new StrDataExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrDataExtensionList>(deep);

}
/// <summary>
/// <para>Defines the StrRefExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StrRefExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StrRefExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrRefExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10575;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the StrRefExtensionList class.
    /// </summary>
    public StrRefExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StrRefExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrRefExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StrRefExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrRefExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StrRefExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StrRefExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new StrRefExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrRefExtensionList>(deep);

}
/// <summary>
/// <para>Defines the MultiLevelStringCache Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:multiLvlStrCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PointCount &lt;c:ptCount></description></item>
///<item><description>Level &lt;c:lvl></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PointCount))]
    [ChildElementInfo(typeof(Level))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MultiLevelStringCache : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10576;
    /// <inheritdoc/>
    public override string LocalName => "multiLvlStrCache";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MultiLevelStringCache class.
    /// </summary>
    public MultiLevelStringCache():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MultiLevelStringCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLevelStringCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLevelStringCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLevelStringCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLevelStringCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MultiLevelStringCache(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ptCount" == name)
    return new PointCount();
    
if( 11 == namespaceId && "lvl" == name)
    return new Level();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ptCount","lvl","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PointCount.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PointCount PointCount
    {
        get => GetElement<PointCount>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLevelStringCache>(deep);

}
/// <summary>
/// <para>Defines the MultiLvlStrRefExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MultiLvlStrRefExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(MultiLvlStrRefExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MultiLvlStrRefExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10577;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrRefExtensionList class.
    /// </summary>
    public MultiLvlStrRefExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MultiLvlStrRefExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrRefExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrRefExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrRefExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrRefExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MultiLvlStrRefExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new MultiLvlStrRefExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrRefExtensionList>(deep);

}
/// <summary>
/// <para>Defines the DLblExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DLblExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DLblExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DLblExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10578;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DLblExtensionList class.
    /// </summary>
    public DLblExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DLblExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLblExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DLblExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLblExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DLblExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DLblExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new DLblExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLblExtensionList>(deep);

}
/// <summary>
/// <para>Defines the DLblsExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DLblsExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DLblsExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DLblsExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10579;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DLblsExtensionList class.
    /// </summary>
    public DLblsExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DLblsExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLblsExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DLblsExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLblsExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DLblsExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DLblsExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new DLblsExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLblsExtensionList>(deep);

}
/// <summary>
/// <para>Defines the DataPoint Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dPt.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>InvertIfNegative &lt;c:invertIfNegative></description></item>
///<item><description>Marker &lt;c:marker></description></item>
///<item><description>Bubble3D &lt;c:bubble3D></description></item>
///<item><description>Explosion &lt;c:explosion></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(InvertIfNegative))]
    [ChildElementInfo(typeof(Marker))]
    [ChildElementInfo(typeof(Bubble3D))]
    [ChildElementInfo(typeof(Explosion))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(PictureOptions))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DataPoint : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10580;
    /// <inheritdoc/>
    public override string LocalName => "dPt";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "invertIfNegative" == name)
    return new InvertIfNegative();
    
if( 11 == namespaceId && "marker" == name)
    return new Marker();
    
if( 11 == namespaceId && "bubble3D" == name)
    return new Bubble3D();
    
if( 11 == namespaceId && "explosion" == name)
    return new Explosion();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new PictureOptions();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","invertIfNegative","marker","bubble3D","explosion","spPr","pictureOptions","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Invert if Negative.</para>
    /// <para> Represents the following element tag in the schema: c:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public InvertIfNegative InvertIfNegative
    {
        get => GetElement<InvertIfNegative>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Marker Marker
    {
        get => GetElement<Marker>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> 3D Bubble.</para>
    /// <para> Represents the following element tag in the schema: c:bubble3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Bubble3D Bubble3D
    {
        get => GetElement<Bubble3D>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Explosion.</para>
    /// <para> Represents the following element tag in the schema: c:explosion </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Explosion Explosion
    {
        get => GetElement<Explosion>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureOptions PictureOptions
    {
        get => GetElement<PictureOptions>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(7);
        set => SetElement(7, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint>(deep);

}
/// <summary>
/// <para>Defines the Trendline Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:trendline.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TrendlineName &lt;c:name></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>TrendlineType &lt;c:trendlineType></description></item>
///<item><description>PolynomialOrder &lt;c:order></description></item>
///<item><description>Period &lt;c:period></description></item>
///<item><description>Forward &lt;c:forward></description></item>
///<item><description>Backward &lt;c:backward></description></item>
///<item><description>Intercept &lt;c:intercept></description></item>
///<item><description>DisplayRSquaredValue &lt;c:dispRSqr></description></item>
///<item><description>DisplayEquation &lt;c:dispEq></description></item>
///<item><description>TrendlineLabel &lt;c:trendlineLbl></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TrendlineName))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(TrendlineType))]
    [ChildElementInfo(typeof(PolynomialOrder))]
    [ChildElementInfo(typeof(Period))]
    [ChildElementInfo(typeof(Forward))]
    [ChildElementInfo(typeof(Backward))]
    [ChildElementInfo(typeof(Intercept))]
    [ChildElementInfo(typeof(DisplayRSquaredValue))]
    [ChildElementInfo(typeof(DisplayEquation))]
    [ChildElementInfo(typeof(TrendlineLabel))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Trendline : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10581;
    /// <inheritdoc/>
    public override string LocalName => "trendline";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Trendline class.
    /// </summary>
    public Trendline():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Trendline class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Trendline(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Trendline class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Trendline(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Trendline class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Trendline(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "name" == name)
    return new TrendlineName();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "trendlineType" == name)
    return new TrendlineType();
    
if( 11 == namespaceId && "order" == name)
    return new PolynomialOrder();
    
if( 11 == namespaceId && "period" == name)
    return new Period();
    
if( 11 == namespaceId && "forward" == name)
    return new Forward();
    
if( 11 == namespaceId && "backward" == name)
    return new Backward();
    
if( 11 == namespaceId && "intercept" == name)
    return new Intercept();
    
if( 11 == namespaceId && "dispRSqr" == name)
    return new DisplayRSquaredValue();
    
if( 11 == namespaceId && "dispEq" == name)
    return new DisplayEquation();
    
if( 11 == namespaceId && "trendlineLbl" == name)
    return new TrendlineLabel();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "name","spPr","trendlineType","order","period","forward","backward","intercept","dispRSqr","dispEq","trendlineLbl","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Trendline Name.</para>
    /// <para> Represents the following element tag in the schema: c:name </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TrendlineName TrendlineName
    {
        get => GetElement<TrendlineName>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Trendline Type.</para>
    /// <para> Represents the following element tag in the schema: c:trendlineType </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TrendlineType TrendlineType
    {
        get => GetElement<TrendlineType>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Polynomial Trendline Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PolynomialOrder PolynomialOrder
    {
        get => GetElement<PolynomialOrder>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Period.</para>
    /// <para> Represents the following element tag in the schema: c:period </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Period Period
    {
        get => GetElement<Period>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Forward.</para>
    /// <para> Represents the following element tag in the schema: c:forward </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Forward Forward
    {
        get => GetElement<Forward>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Backward.</para>
    /// <para> Represents the following element tag in the schema: c:backward </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Backward Backward
    {
        get => GetElement<Backward>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Intercept.</para>
    /// <para> Represents the following element tag in the schema: c:intercept </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Intercept Intercept
    {
        get => GetElement<Intercept>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Display R Squared Value.</para>
    /// <para> Represents the following element tag in the schema: c:dispRSqr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DisplayRSquaredValue DisplayRSquaredValue
    {
        get => GetElement<DisplayRSquaredValue>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Display Equation.</para>
    /// <para> Represents the following element tag in the schema: c:dispEq </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DisplayEquation DisplayEquation
    {
        get => GetElement<DisplayEquation>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> Trendline Label.</para>
    /// <para> Represents the following element tag in the schema: c:trendlineLbl </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public TrendlineLabel TrendlineLabel
    {
        get => GetElement<TrendlineLabel>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(11);
        set => SetElement(11, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Trendline>(deep);

}
/// <summary>
/// <para>Defines the ErrorBars Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:errBars.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ErrorDirection &lt;c:errDir></description></item>
///<item><description>ErrorBarType &lt;c:errBarType></description></item>
///<item><description>ErrorBarValueType &lt;c:errValType></description></item>
///<item><description>NoEndCap &lt;c:noEndCap></description></item>
///<item><description>Plus &lt;c:plus></description></item>
///<item><description>Minus &lt;c:minus></description></item>
///<item><description>ErrorBarValue &lt;c:val></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ErrorDirection))]
    [ChildElementInfo(typeof(ErrorBarType))]
    [ChildElementInfo(typeof(ErrorBarValueType))]
    [ChildElementInfo(typeof(NoEndCap))]
    [ChildElementInfo(typeof(Plus))]
    [ChildElementInfo(typeof(Minus))]
    [ChildElementInfo(typeof(ErrorBarValue))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ErrorBars : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10582;
    /// <inheritdoc/>
    public override string LocalName => "errBars";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ErrorBars class.
    /// </summary>
    public ErrorBars():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ErrorBars class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ErrorBars(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ErrorBars class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ErrorBars(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ErrorBars class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ErrorBars(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "errDir" == name)
    return new ErrorDirection();
    
if( 11 == namespaceId && "errBarType" == name)
    return new ErrorBarType();
    
if( 11 == namespaceId && "errValType" == name)
    return new ErrorBarValueType();
    
if( 11 == namespaceId && "noEndCap" == name)
    return new NoEndCap();
    
if( 11 == namespaceId && "plus" == name)
    return new Plus();
    
if( 11 == namespaceId && "minus" == name)
    return new Minus();
    
if( 11 == namespaceId && "val" == name)
    return new ErrorBarValue();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "errDir","errBarType","errValType","noEndCap","plus","minus","val","spPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Error Bar Direction.</para>
    /// <para> Represents the following element tag in the schema: c:errDir </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ErrorDirection ErrorDirection
    {
        get => GetElement<ErrorDirection>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Error Bar Type.</para>
    /// <para> Represents the following element tag in the schema: c:errBarType </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ErrorBarType ErrorBarType
    {
        get => GetElement<ErrorBarType>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Error Bar Value Type.</para>
    /// <para> Represents the following element tag in the schema: c:errValType </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ErrorBarValueType ErrorBarValueType
    {
        get => GetElement<ErrorBarValueType>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> No End Cap.</para>
    /// <para> Represents the following element tag in the schema: c:noEndCap </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NoEndCap NoEndCap
    {
        get => GetElement<NoEndCap>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Plus.</para>
    /// <para> Represents the following element tag in the schema: c:plus </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Plus Plus
    {
        get => GetElement<Plus>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Minus.</para>
    /// <para> Represents the following element tag in the schema: c:minus </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Minus Minus
    {
        get => GetElement<Minus>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Error Bar Value.</para>
    /// <para> Represents the following element tag in the schema: c:val </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ErrorBarValue ErrorBarValue
    {
        get => GetElement<ErrorBarValue>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(8);
        set => SetElement(8, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBars>(deep);

}
/// <summary>
/// <para>Defines the CategoryAxisData Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:cat.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MultiLevelStringReference &lt;c:multiLvlStrRef></description></item>
///<item><description>NumberReference &lt;c:numRef></description></item>
///<item><description>NumberLiteral &lt;c:numLit></description></item>
///<item><description>StringReference &lt;c:strRef></description></item>
///<item><description>StringLiteral &lt;c:strLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CategoryAxisData : AxisDataSourceType
{
    internal const int ElementTypeIdConst = 10583;
    /// <inheritdoc/>
    public override string LocalName => "cat";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the CategoryAxisData class.
    /// </summary>
    public CategoryAxisData():base(){}
        /// <summary>
    ///Initializes a new instance of the CategoryAxisData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryAxisData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryAxisData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryAxisData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryAxisData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryAxisData(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxisData>(deep);

}
/// <summary>
/// <para>Defines the XValues Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:xVal.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MultiLevelStringReference &lt;c:multiLvlStrRef></description></item>
///<item><description>NumberReference &lt;c:numRef></description></item>
///<item><description>NumberLiteral &lt;c:numLit></description></item>
///<item><description>StringReference &lt;c:strRef></description></item>
///<item><description>StringLiteral &lt;c:strLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class XValues : AxisDataSourceType
{
    internal const int ElementTypeIdConst = 10587;
    /// <inheritdoc/>
    public override string LocalName => "xVal";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the XValues class.
    /// </summary>
    public XValues():base(){}
        /// <summary>
    ///Initializes a new instance of the XValues class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public XValues(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the XValues class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public XValues(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the XValues class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public XValues(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<XValues>(deep);

}
/// <summary>
/// Defines the AxisDataSourceType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MultiLevelStringReference &lt;c:multiLvlStrRef></description></item>
///<item><description>NumberReference &lt;c:numRef></description></item>
///<item><description>NumberLiteral &lt;c:numLit></description></item>
///<item><description>StringReference &lt;c:strRef></description></item>
///<item><description>StringLiteral &lt;c:strLit></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(MultiLevelStringReference))]
    [ChildElementInfo(typeof(NumberReference))]
    [ChildElementInfo(typeof(NumberLiteral))]
    [ChildElementInfo(typeof(StringReference))]
    [ChildElementInfo(typeof(StringLiteral))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class AxisDataSourceType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "multiLvlStrRef" == name)
    return new MultiLevelStringReference();
    
if( 11 == namespaceId && "numRef" == name)
    return new NumberReference();
    
if( 11 == namespaceId && "numLit" == name)
    return new NumberLiteral();
    
if( 11 == namespaceId && "strRef" == name)
    return new StringReference();
    
if( 11 == namespaceId && "strLit" == name)
    return new StringLiteral();
    

    return null;
}

        private static readonly string[] eleTagNames = { "multiLvlStrRef","numRef","numLit","strRef","strLit" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Multi Level String Reference.</para>
    /// <para> Represents the following element tag in the schema: c:multiLvlStrRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public MultiLevelStringReference MultiLevelStringReference
    {
        get => GetElement<MultiLevelStringReference>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Number Reference.</para>
    /// <para> Represents the following element tag in the schema: c:numRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumberReference NumberReference
    {
        get => GetElement<NumberReference>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Number Literal.</para>
    /// <para> Represents the following element tag in the schema: c:numLit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public NumberLiteral NumberLiteral
    {
        get => GetElement<NumberLiteral>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> StringReference.</para>
    /// <para> Represents the following element tag in the schema: c:strRef </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public StringReference StringReference
    {
        get => GetElement<StringReference>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> String Literal.</para>
    /// <para> Represents the following element tag in the schema: c:strLit </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public StringLiteral StringLiteral
    {
        get => GetElement<StringLiteral>(4);
        set => SetElement(4, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the AxisDataSourceType class.
    /// </summary>
    protected AxisDataSourceType(){}
    
        /// <summary>
    ///Initializes a new instance of the AxisDataSourceType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected AxisDataSourceType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisDataSourceType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected AxisDataSourceType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AxisDataSourceType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected AxisDataSourceType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the LineSerExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineSerExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LineSerExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LineSerExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10586;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LineSerExtensionList class.
    /// </summary>
    public LineSerExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LineSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineSerExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LineSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LineSerExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LineSerExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new LineSerExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSerExtensionList>(deep);

}
/// <summary>
/// <para>Defines the ScatterSerExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ScatterSerExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ScatterSerExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ScatterSerExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10589;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ScatterSerExtensionList class.
    /// </summary>
    public ScatterSerExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ScatterSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterSerExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterSerExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ScatterSerExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new ScatterSerExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterSerExtensionList>(deep);

}
/// <summary>
/// <para>Defines the RadarSerExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RadarSerExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RadarSerExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RadarSerExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10590;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RadarSerExtensionList class.
    /// </summary>
    public RadarSerExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RadarSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarSerExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarSerExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadarSerExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new RadarSerExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarSerExtensionList>(deep);

}
/// <summary>
/// <para>Defines the Shape Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:shape.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Shape : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10591;
    /// <inheritdoc/>
    public override string LocalName => "shape";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Shape Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Shape class.
    /// </summary>
    public Shape():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);

}
/// <summary>
/// <para>Defines the BarSerExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BarSerExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BarSerExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BarSerExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10592;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BarSerExtensionList class.
    /// </summary>
    public BarSerExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BarSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarSerExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BarSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BarSerExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BarSerExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new BarSerExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarSerExtensionList>(deep);

}
/// <summary>
/// <para>Defines the BarSerExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat &lt;c14:invertSolidFillFmt></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BarSerExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10593;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BarSerExtension class.
    /// </summary>
    public BarSerExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BarSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarSerExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BarSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarSerExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BarSerExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BarSerExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 46 == namespaceId && "invertSolidFillFmt" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat();
    
if( 64 == namespaceId && "filteredSeriesTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle();
    
if( 64 == namespaceId && "filteredCategoryTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle();
    
if( 64 == namespaceId && "datalabelsRange" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange();
    
if( 64 == namespaceId && "categoryFilterExceptions" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarSerExtension>(deep);

}
/// <summary>
/// <para>Defines the AreaSerExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AreaSerExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AreaSerExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AreaSerExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10594;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AreaSerExtensionList class.
    /// </summary>
    public AreaSerExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AreaSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaSerExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaSerExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AreaSerExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new AreaSerExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaSerExtensionList>(deep);

}
/// <summary>
/// <para>Defines the PieSerExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PieSerExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PieSerExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PieSerExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10595;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PieSerExtensionList class.
    /// </summary>
    public PieSerExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PieSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieSerExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PieSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PieSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PieSerExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PieSerExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new PieSerExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieSerExtensionList>(deep);

}
/// <summary>
/// <para>Defines the BubbleSerExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BubbleSerExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BubbleSerExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BubbleSerExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10597;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BubbleSerExtensionList class.
    /// </summary>
    public BubbleSerExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BubbleSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleSerExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleSerExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BubbleSerExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new BubbleSerExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleSerExtensionList>(deep);

}
/// <summary>
/// <para>Defines the BubbleSerExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat &lt;c14:invertSolidFillFmt></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BubbleSerExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10598;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BubbleSerExtension class.
    /// </summary>
    public BubbleSerExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BubbleSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleSerExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleSerExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleSerExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleSerExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BubbleSerExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 46 == namespaceId && "invertSolidFillFmt" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat();
    
if( 64 == namespaceId && "filteredCategoryTitle" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle();
    
if( 64 == namespaceId && "datalabelsRange" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange();
    
if( 64 == namespaceId && "categoryFilterExceptions" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleSerExtension>(deep);

}
/// <summary>
/// <para>Defines the SurfaceSerExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SurfaceSerExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SurfaceSerExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SurfaceSerExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10599;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SurfaceSerExtensionList class.
    /// </summary>
    public SurfaceSerExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SurfaceSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceSerExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceSerExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceSerExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurfaceSerExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new SurfaceSerExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceSerExtensionList>(deep);

}
/// <summary>
/// <para>Defines the LineChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LineChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LineChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LineChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10601;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LineChartExtensionList class.
    /// </summary>
    public LineChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LineChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LineChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LineChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LineChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new LineChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the Line3DChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Line3DChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Line3DChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Line3DChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10603;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Line3DChartExtensionList class.
    /// </summary>
    public Line3DChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Line3DChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Line3DChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Line3DChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Line3DChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Line3DChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Line3DChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new Line3DChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Line3DChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the ScatterStyle Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:scatterStyle.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ScatterStyle : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10604;
    /// <inheritdoc/>
    public override string LocalName => "scatterStyle";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Scatter Style Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ScatterStyle class.
    /// </summary>
    public ScatterStyle():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterStyle>(deep);

}
/// <summary>
/// <para>Defines the ScatterChartSeries Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>Order &lt;c:order></description></item>
///<item><description>SeriesText &lt;c:tx></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>Marker &lt;c:marker></description></item>
///<item><description>DataPoint &lt;c:dPt></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>Trendline &lt;c:trendline></description></item>
///<item><description>ErrorBars &lt;c:errBars></description></item>
///<item><description>XValues &lt;c:xVal></description></item>
///<item><description>YValues &lt;c:yVal></description></item>
///<item><description>Smooth &lt;c:smooth></description></item>
///<item><description>ScatterSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(Order))]
    [ChildElementInfo(typeof(SeriesText))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(Marker))]
    [ChildElementInfo(typeof(DataPoint))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(Trendline))]
    [ChildElementInfo(typeof(ErrorBars))]
    [ChildElementInfo(typeof(XValues))]
    [ChildElementInfo(typeof(YValues))]
    [ChildElementInfo(typeof(Smooth))]
    [ChildElementInfo(typeof(ScatterSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ScatterChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10605;
    /// <inheritdoc/>
    public override string LocalName => "ser";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartSeries class.
    /// </summary>
    public ScatterChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ScatterChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ScatterChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "order" == name)
    return new Order();
    
if( 11 == namespaceId && "tx" == name)
    return new SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "marker" == name)
    return new Marker();
    
if( 11 == namespaceId && "dPt" == name)
    return new DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "trendline" == name)
    return new Trendline();
    
if( 11 == namespaceId && "errBars" == name)
    return new ErrorBars();
    
if( 11 == namespaceId && "xVal" == name)
    return new XValues();
    
if( 11 == namespaceId && "yVal" == name)
    return new YValues();
    
if( 11 == namespaceId && "smooth" == name)
    return new Smooth();
    
if( 11 == namespaceId && "extLst" == name)
    return new ScatterSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","marker","dPt","dLbls","trendline","errBars","xVal","yVal","smooth","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Order Order
    {
        get => GetElement<Order>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public SeriesText SeriesText
    {
        get => GetElement<SeriesText>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Marker Marker
    {
        get => GetElement<Marker>(4);
        set => SetElement(4, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChartSeries>(deep);

}
/// <summary>
/// <para>Defines the ScatterChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ScatterChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ScatterChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ScatterChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10606;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartExtensionList class.
    /// </summary>
    public ScatterChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ScatterChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ScatterChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ScatterChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ScatterChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new ScatterChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the RadarStyle Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:radarStyle.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RadarStyle : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10607;
    /// <inheritdoc/>
    public override string LocalName => "radarStyle";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Radar Style Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RadarStyle class.
    /// </summary>
    public RadarStyle():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarStyle>(deep);

}
/// <summary>
/// <para>Defines the RadarChartSeries Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>Order &lt;c:order></description></item>
///<item><description>SeriesText &lt;c:tx></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>Marker &lt;c:marker></description></item>
///<item><description>DataPoint &lt;c:dPt></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>CategoryAxisData &lt;c:cat></description></item>
///<item><description>Values &lt;c:val></description></item>
///<item><description>RadarSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(Order))]
    [ChildElementInfo(typeof(SeriesText))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(PictureOptions))]
    [ChildElementInfo(typeof(Marker))]
    [ChildElementInfo(typeof(DataPoint))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(CategoryAxisData))]
    [ChildElementInfo(typeof(Values))]
    [ChildElementInfo(typeof(RadarSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RadarChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10608;
    /// <inheritdoc/>
    public override string LocalName => "ser";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RadarChartSeries class.
    /// </summary>
    public RadarChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RadarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadarChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "order" == name)
    return new Order();
    
if( 11 == namespaceId && "tx" == name)
    return new SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new PictureOptions();
    
if( 11 == namespaceId && "marker" == name)
    return new Marker();
    
if( 11 == namespaceId && "dPt" == name)
    return new DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "cat" == name)
    return new CategoryAxisData();
    
if( 11 == namespaceId && "val" == name)
    return new Values();
    
if( 11 == namespaceId && "extLst" == name)
    return new RadarSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","pictureOptions","marker","dPt","dLbls","cat","val","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Order Order
    {
        get => GetElement<Order>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public SeriesText SeriesText
    {
        get => GetElement<SeriesText>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureOptions PictureOptions
    {
        get => GetElement<PictureOptions>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Marker Marker
    {
        get => GetElement<Marker>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChartSeries>(deep);

}
/// <summary>
/// <para>Defines the RadarChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RadarChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RadarChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RadarChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10609;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RadarChartExtensionList class.
    /// </summary>
    public RadarChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RadarChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadarChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadarChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadarChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new RadarChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the Overlap Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:overlap.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Overlap : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10610;
    /// <inheritdoc/>
    public override string LocalName => "overlap";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<SByteValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Overlap Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public SByteValue Val
    {
        get { return (SByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Overlap class.
    /// </summary>
    public Overlap():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Overlap>(deep);

}
/// <summary>
/// <para>Defines the BarChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BarChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BarChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BarChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10611;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BarChartExtensionList class.
    /// </summary>
    public BarChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BarChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BarChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BarChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new BarChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the Bar3DChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Bar3DChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Bar3DChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Bar3DChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10612;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Bar3DChartExtensionList class.
    /// </summary>
    public Bar3DChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Bar3DChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Bar3DChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Bar3DChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Bar3DChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Bar3DChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Bar3DChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new Bar3DChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bar3DChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the AreaChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AreaChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AreaChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AreaChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10613;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AreaChartExtensionList class.
    /// </summary>
    public AreaChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AreaChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AreaChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AreaChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AreaChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new AreaChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the Area3DChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Area3DChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Area3DChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Area3DChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10614;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Area3DChartExtensionList class.
    /// </summary>
    public Area3DChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Area3DChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Area3DChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Area3DChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Area3DChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Area3DChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Area3DChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new Area3DChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Area3DChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the BubbleChartSeries Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ser.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Index &lt;c:idx></description></item>
///<item><description>Order &lt;c:order></description></item>
///<item><description>SeriesText &lt;c:tx></description></item>
///<item><description>ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>PictureOptions &lt;c:pictureOptions></description></item>
///<item><description>InvertIfNegative &lt;c:invertIfNegative></description></item>
///<item><description>DataPoint &lt;c:dPt></description></item>
///<item><description>DataLabels &lt;c:dLbls></description></item>
///<item><description>Trendline &lt;c:trendline></description></item>
///<item><description>ErrorBars &lt;c:errBars></description></item>
///<item><description>XValues &lt;c:xVal></description></item>
///<item><description>YValues &lt;c:yVal></description></item>
///<item><description>BubbleSize &lt;c:bubbleSize></description></item>
///<item><description>Bubble3D &lt;c:bubble3D></description></item>
///<item><description>BubbleSerExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Index))]
    [ChildElementInfo(typeof(Order))]
    [ChildElementInfo(typeof(SeriesText))]
    [ChildElementInfo(typeof(ChartShapeProperties))]
    [ChildElementInfo(typeof(PictureOptions))]
    [ChildElementInfo(typeof(InvertIfNegative))]
    [ChildElementInfo(typeof(DataPoint))]
    [ChildElementInfo(typeof(DataLabels))]
    [ChildElementInfo(typeof(Trendline))]
    [ChildElementInfo(typeof(ErrorBars))]
    [ChildElementInfo(typeof(XValues))]
    [ChildElementInfo(typeof(YValues))]
    [ChildElementInfo(typeof(BubbleSize))]
    [ChildElementInfo(typeof(Bubble3D))]
    [ChildElementInfo(typeof(BubbleSerExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BubbleChartSeries : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10615;
    /// <inheritdoc/>
    public override string LocalName => "ser";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartSeries class.
    /// </summary>
    public BubbleChartSeries():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BubbleChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChartSeries(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartSeries class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChartSeries(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartSeries class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BubbleChartSeries(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new Index();
    
if( 11 == namespaceId && "order" == name)
    return new Order();
    
if( 11 == namespaceId && "tx" == name)
    return new SeriesText();
    
if( 11 == namespaceId && "spPr" == name)
    return new ChartShapeProperties();
    
if( 11 == namespaceId && "pictureOptions" == name)
    return new PictureOptions();
    
if( 11 == namespaceId && "invertIfNegative" == name)
    return new InvertIfNegative();
    
if( 11 == namespaceId && "dPt" == name)
    return new DataPoint();
    
if( 11 == namespaceId && "dLbls" == name)
    return new DataLabels();
    
if( 11 == namespaceId && "trendline" == name)
    return new Trendline();
    
if( 11 == namespaceId && "errBars" == name)
    return new ErrorBars();
    
if( 11 == namespaceId && "xVal" == name)
    return new XValues();
    
if( 11 == namespaceId && "yVal" == name)
    return new YValues();
    
if( 11 == namespaceId && "bubbleSize" == name)
    return new BubbleSize();
    
if( 11 == namespaceId && "bubble3D" == name)
    return new Bubble3D();
    
if( 11 == namespaceId && "extLst" == name)
    return new BubbleSerExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","order","tx","spPr","pictureOptions","invertIfNegative","dPt","dLbls","trendline","errBars","xVal","yVal","bubbleSize","bubble3D","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Index Index
    {
        get => GetElement<Index>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Order.</para>
    /// <para> Represents the following element tag in the schema: c:order </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Order Order
    {
        get => GetElement<Order>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Series Text.</para>
    /// <para> Represents the following element tag in the schema: c:tx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public SeriesText SeriesText
    {
        get => GetElement<SeriesText>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<ChartShapeProperties>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> PictureOptions.</para>
    /// <para> Represents the following element tag in the schema: c:pictureOptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PictureOptions PictureOptions
    {
        get => GetElement<PictureOptions>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> InvertIfNegative.</para>
    /// <para> Represents the following element tag in the schema: c:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public InvertIfNegative InvertIfNegative
    {
        get => GetElement<InvertIfNegative>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChartSeries>(deep);

}
/// <summary>
/// <para>Defines the BubbleScale Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:bubbleScale.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BubbleScale : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10616;
    /// <inheritdoc/>
    public override string LocalName => "bubbleScale";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Bubble Scale Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BubbleScale class.
    /// </summary>
    public BubbleScale():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleScale>(deep);

}
/// <summary>
/// <para>Defines the SizeRepresents Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:sizeRepresents.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SizeRepresents : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10618;
    /// <inheritdoc/>
    public override string LocalName => "sizeRepresents";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Size Represents Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SizeRepresents class.
    /// </summary>
    public SizeRepresents():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SizeRepresents>(deep);

}
/// <summary>
/// <para>Defines the BubbleChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BubbleChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BubbleChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BubbleChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10619;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartExtensionList class.
    /// </summary>
    public BubbleChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BubbleChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BubbleChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BubbleChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BubbleChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new BubbleChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the SurfaceChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SurfaceChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SurfaceChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SurfaceChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10620;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartExtensionList class.
    /// </summary>
    public SurfaceChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SurfaceChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SurfaceChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SurfaceChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SurfaceChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new SurfaceChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the Surface3DChartExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Surface3DChartExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Surface3DChartExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Surface3DChartExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10621;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Surface3DChartExtensionList class.
    /// </summary>
    public Surface3DChartExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Surface3DChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Surface3DChartExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Surface3DChartExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Surface3DChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Surface3DChartExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Surface3DChartExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new Surface3DChartExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Surface3DChartExtensionList>(deep);

}
/// <summary>
/// <para>Defines the LabelAlignment Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:lblAlgn.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LabelAlignment : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10623;
    /// <inheritdoc/>
    public override string LocalName => "lblAlgn";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Label Alignment Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LabelAlignment class.
    /// </summary>
    public LabelAlignment():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LabelAlignment>(deep);

}
/// <summary>
/// <para>Defines the LabelOffset Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:lblOffset.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LabelOffset : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10624;
    /// <inheritdoc/>
    public override string LocalName => "lblOffset";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt16Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Label Offset Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt16Value Val
    {
        get { return (UInt16Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LabelOffset class.
    /// </summary>
    public LabelOffset():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LabelOffset>(deep);

}
/// <summary>
/// <para>Defines the TickLabelSkip Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:tickLblSkip.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TickLabelSkip : SkipType
{
    internal const int ElementTypeIdConst = 10625;
    /// <inheritdoc/>
    public override string LocalName => "tickLblSkip";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the TickLabelSkip class.
    /// </summary>
    public TickLabelSkip():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TickLabelSkip>(deep);

}
/// <summary>
/// <para>Defines the TickMarkSkip Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:tickMarkSkip.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TickMarkSkip : SkipType
{
    internal const int ElementTypeIdConst = 10626;
    /// <inheritdoc/>
    public override string LocalName => "tickMarkSkip";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the TickMarkSkip class.
    /// </summary>
    public TickMarkSkip():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TickMarkSkip>(deep);

}
/// <summary>
/// Defines the SkipType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class SkipType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Tick Skip Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public Int32Value Val
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SkipType class.
    /// </summary>
    protected SkipType(){}
    
    
    
}
/// <summary>
/// <para>Defines the CatAxExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CatAxExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(CatAxExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CatAxExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10628;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the CatAxExtensionList class.
    /// </summary>
    public CatAxExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CatAxExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CatAxExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CatAxExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CatAxExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CatAxExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CatAxExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new CatAxExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CatAxExtensionList>(deep);

}
/// <summary>
/// <para>Defines the BaseTimeUnit Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:baseTimeUnit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BaseTimeUnit : TimeUnitType
{
    internal const int ElementTypeIdConst = 10629;
    /// <inheritdoc/>
    public override string LocalName => "baseTimeUnit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the BaseTimeUnit class.
    /// </summary>
    public BaseTimeUnit():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BaseTimeUnit>(deep);

}
/// <summary>
/// <para>Defines the MajorTimeUnit Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:majorTimeUnit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MajorTimeUnit : TimeUnitType
{
    internal const int ElementTypeIdConst = 10631;
    /// <inheritdoc/>
    public override string LocalName => "majorTimeUnit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MajorTimeUnit class.
    /// </summary>
    public MajorTimeUnit():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorTimeUnit>(deep);

}
/// <summary>
/// <para>Defines the MinorTimeUnit Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:minorTimeUnit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MinorTimeUnit : TimeUnitType
{
    internal const int ElementTypeIdConst = 10633;
    /// <inheritdoc/>
    public override string LocalName => "minorTimeUnit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MinorTimeUnit class.
    /// </summary>
    public MinorTimeUnit():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorTimeUnit>(deep);

}
/// <summary>
/// Defines the TimeUnitType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class TimeUnitType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Time Unit Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TimeUnitType class.
    /// </summary>
    protected TimeUnitType(){}
    
    
    
}
/// <summary>
/// <para>Defines the MajorUnit Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:majorUnit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MajorUnit : AxisUnitType
{
    internal const int ElementTypeIdConst = 10630;
    /// <inheritdoc/>
    public override string LocalName => "majorUnit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MajorUnit class.
    /// </summary>
    public MajorUnit():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorUnit>(deep);

}
/// <summary>
/// <para>Defines the MinorUnit Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:minorUnit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MinorUnit : AxisUnitType
{
    internal const int ElementTypeIdConst = 10632;
    /// <inheritdoc/>
    public override string LocalName => "minorUnit";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MinorUnit class.
    /// </summary>
    public MinorUnit():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorUnit>(deep);

}
/// <summary>
/// Defines the AxisUnitType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class AxisUnitType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<DoubleValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Major Unit Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public DoubleValue Val
    {
        get { return (DoubleValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AxisUnitType class.
    /// </summary>
    protected AxisUnitType(){}
    
    
    
}
/// <summary>
/// <para>Defines the DateAxExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DateAxExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DateAxExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DateAxExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10634;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DateAxExtensionList class.
    /// </summary>
    public DateAxExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DateAxExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DateAxExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DateAxExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DateAxExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DateAxExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DateAxExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new DateAxExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DateAxExtensionList>(deep);

}
/// <summary>
/// <para>Defines the SerAxExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SerAxExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SerAxExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SerAxExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10635;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SerAxExtensionList class.
    /// </summary>
    public SerAxExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SerAxExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SerAxExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SerAxExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SerAxExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SerAxExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SerAxExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new SerAxExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SerAxExtensionList>(deep);

}
/// <summary>
/// <para>Defines the CrossBetween Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:crossBetween.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CrossBetween : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10636;
    /// <inheritdoc/>
    public override string LocalName => "crossBetween";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues>>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Cross Between Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CrossBetween class.
    /// </summary>
    public CrossBetween():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CrossBetween>(deep);

}
/// <summary>
/// <para>Defines the DisplayUnits Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:dispUnits.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CustomDisplayUnit &lt;c:custUnit></description></item>
///<item><description>BuiltInUnit &lt;c:builtInUnit></description></item>
///<item><description>DisplayUnitsLabel &lt;c:dispUnitsLbl></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(CustomDisplayUnit))]
    [ChildElementInfo(typeof(BuiltInUnit))]
    [ChildElementInfo(typeof(DisplayUnitsLabel))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DisplayUnits : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10637;
    /// <inheritdoc/>
    public override string LocalName => "dispUnits";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DisplayUnits class.
    /// </summary>
    public DisplayUnits():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DisplayUnits class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DisplayUnits(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DisplayUnits class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DisplayUnits(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DisplayUnits class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DisplayUnits(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "custUnit" == name)
    return new CustomDisplayUnit();
    
if( 11 == namespaceId && "builtInUnit" == name)
    return new BuiltInUnit();
    
if( 11 == namespaceId && "dispUnitsLbl" == name)
    return new DisplayUnitsLabel();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayUnits>(deep);

}
/// <summary>
/// <para>Defines the ValAxExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ValAxExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ValAxExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ValAxExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10638;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ValAxExtensionList class.
    /// </summary>
    public ValAxExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ValAxExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ValAxExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ValAxExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ValAxExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ValAxExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ValAxExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new ValAxExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValAxExtensionList>(deep);

}
/// <summary>
/// <para>Defines the EditingLanguage Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:lang.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EditingLanguage : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10640;
    /// <inheritdoc/>
    public override string LocalName => "lang";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Language Code.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the EditingLanguage class.
    /// </summary>
    public EditingLanguage():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EditingLanguage>(deep);

}
/// <summary>
/// <para>Defines the Style Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:style.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Style : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10642;
    /// <inheritdoc/>
    public override string LocalName => "style";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<ByteValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Style Type.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public ByteValue Val
    {
        get { return (ByteValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Style class.
    /// </summary>
    public Style():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);

}
/// <summary>
/// <para>Defines the ColorMapOverride Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:clrMapOvr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColorMapOverride : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10643;
    /// <inheritdoc/>
    public override string LocalName => "clrMapOvr";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "bg1"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "tx1"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "bg2"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "tx2"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "accent1"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "accent2"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "accent3"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "accent4"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "accent5"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "accent6"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "hlink"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>(0, "folHlink")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Background 1.</para>
    /// <para>Represents the following attribute in the schema: bg1 </para>
    /// </summary>
    [SchemaAttr(0, "bg1")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background1
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Text 1.</para>
    /// <para>Represents the following attribute in the schema: tx1 </para>
    /// </summary>
    [SchemaAttr(0, "tx1")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text1
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Background 2.</para>
    /// <para>Represents the following attribute in the schema: bg2 </para>
    /// </summary>
    [SchemaAttr(0, "bg2")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background2
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Text 2.</para>
    /// <para>Represents the following attribute in the schema: tx2 </para>
    /// </summary>
    [SchemaAttr(0, "tx2")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text2
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Accent 1.</para>
    /// <para>Represents the following attribute in the schema: accent1 </para>
    /// </summary>
    [SchemaAttr(0, "accent1")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent1
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Accent 2.</para>
    /// <para>Represents the following attribute in the schema: accent2 </para>
    /// </summary>
    [SchemaAttr(0, "accent2")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent2
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Accent 3.</para>
    /// <para>Represents the following attribute in the schema: accent3 </para>
    /// </summary>
    [SchemaAttr(0, "accent3")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent3
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Accent 4.</para>
    /// <para>Represents the following attribute in the schema: accent4 </para>
    /// </summary>
    [SchemaAttr(0, "accent4")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent4
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Accent 5.</para>
    /// <para>Represents the following attribute in the schema: accent5 </para>
    /// </summary>
    [SchemaAttr(0, "accent5")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent5
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Accent 6.</para>
    /// <para>Represents the following attribute in the schema: accent6 </para>
    /// </summary>
    [SchemaAttr(0, "accent6")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent6
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Hyperlink.</para>
    /// <para>Represents the following attribute in the schema: hlink </para>
    /// </summary>
    [SchemaAttr(0, "hlink")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Hyperlink
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Followed Hyperlink.</para>
    /// <para>Represents the following attribute in the schema: folHlink </para>
    /// </summary>
    [SchemaAttr(0, "folHlink")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> FollowedHyperlink
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColorMapOverride class.
    /// </summary>
    public ColorMapOverride():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ColorMapOverride class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorMapOverride(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorMapOverride class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorMapOverride(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorMapOverride class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorMapOverride(string outerXml)
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
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMapOverride>(deep);

}
/// <summary>
/// <para>Defines the PivotSource Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:pivotSource.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotTableName &lt;c:name></description></item>
///<item><description>FormatId &lt;c:fmtId></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotTableName))]
    [ChildElementInfo(typeof(FormatId))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PivotSource : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10644;
    /// <inheritdoc/>
    public override string LocalName => "pivotSource";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotSource class.
    /// </summary>
    public PivotSource():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotSource class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotSource(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotSource class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotSource(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotSource class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotSource(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "name" == name)
    return new PivotTableName();
    
if( 11 == namespaceId && "fmtId" == name)
    return new FormatId();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "name","fmtId","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Pivot Name.</para>
    /// <para> Represents the following element tag in the schema: c:name </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PivotTableName PivotTableName
    {
        get => GetElement<PivotTableName>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Format ID.</para>
    /// <para> Represents the following element tag in the schema: c:fmtId </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public FormatId FormatId
    {
        get => GetElement<FormatId>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotSource>(deep);

}
/// <summary>
/// <para>Defines the Protection Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:protection.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartObject &lt;c:chartObject></description></item>
///<item><description>Data &lt;c:data></description></item>
///<item><description>Formatting &lt;c:formatting></description></item>
///<item><description>Selection &lt;c:selection></description></item>
///<item><description>UserInterface &lt;c:userInterface></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ChartObject))]
    [ChildElementInfo(typeof(Data))]
    [ChildElementInfo(typeof(Formatting))]
    [ChildElementInfo(typeof(Selection))]
    [ChildElementInfo(typeof(UserInterface))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Protection : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10645;
    /// <inheritdoc/>
    public override string LocalName => "protection";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Protection class.
    /// </summary>
    public Protection():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Protection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Protection(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Protection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Protection(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Protection class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Protection(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "chartObject" == name)
    return new ChartObject();
    
if( 11 == namespaceId && "data" == name)
    return new Data();
    
if( 11 == namespaceId && "formatting" == name)
    return new Formatting();
    
if( 11 == namespaceId && "selection" == name)
    return new Selection();
    
if( 11 == namespaceId && "userInterface" == name)
    return new UserInterface();
    

    return null;
}

        private static readonly string[] eleTagNames = { "chartObject","data","formatting","selection","userInterface" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Chart Object.</para>
    /// <para> Represents the following element tag in the schema: c:chartObject </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ChartObject ChartObject
    {
        get => GetElement<ChartObject>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Data Cannot Be Changed.</para>
    /// <para> Represents the following element tag in the schema: c:data </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Data Data
    {
        get => GetElement<Data>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Formatting.</para>
    /// <para> Represents the following element tag in the schema: c:formatting </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Formatting Formatting
    {
        get => GetElement<Formatting>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Selection.</para>
    /// <para> Represents the following element tag in the schema: c:selection </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Selection Selection
    {
        get => GetElement<Selection>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> User Interface.</para>
    /// <para> Represents the following element tag in the schema: c:userInterface </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public UserInterface UserInterface
    {
        get => GetElement<UserInterface>(4);
        set => SetElement(4, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Protection>(deep);

}
/// <summary>
/// <para>Defines the Chart Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:chart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Title &lt;c:title></description></item>
///<item><description>AutoTitleDeleted &lt;c:autoTitleDeleted></description></item>
///<item><description>PivotFormats &lt;c:pivotFmts></description></item>
///<item><description>View3D &lt;c:view3D></description></item>
///<item><description>Floor &lt;c:floor></description></item>
///<item><description>SideWall &lt;c:sideWall></description></item>
///<item><description>BackWall &lt;c:backWall></description></item>
///<item><description>PlotArea &lt;c:plotArea></description></item>
///<item><description>Legend &lt;c:legend></description></item>
///<item><description>PlotVisibleOnly &lt;c:plotVisOnly></description></item>
///<item><description>DisplayBlanksAs &lt;c:dispBlanksAs></description></item>
///<item><description>ShowDataLabelsOverMaximum &lt;c:showDLblsOverMax></description></item>
///<item><description>ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Title))]
    [ChildElementInfo(typeof(AutoTitleDeleted))]
    [ChildElementInfo(typeof(PivotFormats))]
    [ChildElementInfo(typeof(View3D))]
    [ChildElementInfo(typeof(Floor))]
    [ChildElementInfo(typeof(SideWall))]
    [ChildElementInfo(typeof(BackWall))]
    [ChildElementInfo(typeof(PlotArea))]
    [ChildElementInfo(typeof(Legend))]
    [ChildElementInfo(typeof(PlotVisibleOnly))]
    [ChildElementInfo(typeof(DisplayBlanksAs))]
    [ChildElementInfo(typeof(ShowDataLabelsOverMaximum))]
    [ChildElementInfo(typeof(ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Chart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10646;
    /// <inheritdoc/>
    public override string LocalName => "chart";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    if( 11 == namespaceId && "title" == name)
    return new Title();
    
if( 11 == namespaceId && "autoTitleDeleted" == name)
    return new AutoTitleDeleted();
    
if( 11 == namespaceId && "pivotFmts" == name)
    return new PivotFormats();
    
if( 11 == namespaceId && "view3D" == name)
    return new View3D();
    
if( 11 == namespaceId && "floor" == name)
    return new Floor();
    
if( 11 == namespaceId && "sideWall" == name)
    return new SideWall();
    
if( 11 == namespaceId && "backWall" == name)
    return new BackWall();
    
if( 11 == namespaceId && "plotArea" == name)
    return new PlotArea();
    
if( 11 == namespaceId && "legend" == name)
    return new Legend();
    
if( 11 == namespaceId && "plotVisOnly" == name)
    return new PlotVisibleOnly();
    
if( 11 == namespaceId && "dispBlanksAs" == name)
    return new DisplayBlanksAs();
    
if( 11 == namespaceId && "showDLblsOverMax" == name)
    return new ShowDataLabelsOverMaximum();
    
if( 11 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "title","autoTitleDeleted","pivotFmts","view3D","floor","sideWall","backWall","plotArea","legend","plotVisOnly","dispBlanksAs","showDLblsOverMax","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Title.</para>
    /// <para> Represents the following element tag in the schema: c:title </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Title Title
    {
        get => GetElement<Title>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Auto Title Is Deleted.</para>
    /// <para> Represents the following element tag in the schema: c:autoTitleDeleted </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public AutoTitleDeleted AutoTitleDeleted
    {
        get => GetElement<AutoTitleDeleted>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Pivot Formats.</para>
    /// <para> Represents the following element tag in the schema: c:pivotFmts </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PivotFormats PivotFormats
    {
        get => GetElement<PivotFormats>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> View In 3D.</para>
    /// <para> Represents the following element tag in the schema: c:view3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public View3D View3D
    {
        get => GetElement<View3D>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Floor.</para>
    /// <para> Represents the following element tag in the schema: c:floor </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Floor Floor
    {
        get => GetElement<Floor>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Side Wall.</para>
    /// <para> Represents the following element tag in the schema: c:sideWall </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public SideWall SideWall
    {
        get => GetElement<SideWall>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Back Wall.</para>
    /// <para> Represents the following element tag in the schema: c:backWall </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public BackWall BackWall
    {
        get => GetElement<BackWall>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Plot Area.</para>
    /// <para> Represents the following element tag in the schema: c:plotArea </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PlotArea PlotArea
    {
        get => GetElement<PlotArea>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Legend.</para>
    /// <para> Represents the following element tag in the schema: c:legend </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public Legend Legend
    {
        get => GetElement<Legend>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Plot Visible Only.</para>
    /// <para> Represents the following element tag in the schema: c:plotVisOnly </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PlotVisibleOnly PlotVisibleOnly
    {
        get => GetElement<PlotVisibleOnly>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> Display Blanks As.</para>
    /// <para> Represents the following element tag in the schema: c:dispBlanksAs </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DisplayBlanksAs DisplayBlanksAs
    {
        get => GetElement<DisplayBlanksAs>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> Show Data Labels over Maximum.</para>
    /// <para> Represents the following element tag in the schema: c:showDLblsOverMax </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ShowDataLabelsOverMaximum ShowDataLabelsOverMaximum
    {
        get => GetElement<ShowDataLabelsOverMaximum>(11);
        set => SetElement(11, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(12);
        set => SetElement(12, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Chart>(deep);

}
/// <summary>
/// <para>Defines the ExternalData Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:externalData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AutoUpdate &lt;c:autoUpdate></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AutoUpdate))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ExternalData : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10647;
    /// <inheritdoc/>
    public override string LocalName => "externalData";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(19, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Relationship Reference.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ExternalData class.
    /// </summary>
    public ExternalData():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ExternalData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExternalData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ExternalData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExternalData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ExternalData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ExternalData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "autoUpdate" == name)
    return new AutoUpdate();
    

    return null;
}

        private static readonly string[] eleTagNames = { "autoUpdate" };
    private static readonly byte[] eleNamespaceIds = { 11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Update Automatically.</para>
    /// <para> Represents the following element tag in the schema: c:autoUpdate </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public AutoUpdate AutoUpdate
    {
        get => GetElement<AutoUpdate>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExternalData>(deep);

}
/// <summary>
/// <para>Defines the PrintSettings Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:printSettings.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>HeaderFooter &lt;c:headerFooter></description></item>
///<item><description>PageMargins &lt;c:pageMargins></description></item>
///<item><description>PageSetup &lt;c:pageSetup></description></item>
///<item><description>LegacyDrawingHeaderFooter &lt;c:legacyDrawingHF></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(HeaderFooter))]
    [ChildElementInfo(typeof(PageMargins))]
    [ChildElementInfo(typeof(PageSetup))]
    [ChildElementInfo(typeof(LegacyDrawingHeaderFooter))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PrintSettings : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10648;
    /// <inheritdoc/>
    public override string LocalName => "printSettings";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    if( 11 == namespaceId && "headerFooter" == name)
    return new HeaderFooter();
    
if( 11 == namespaceId && "pageMargins" == name)
    return new PageMargins();
    
if( 11 == namespaceId && "pageSetup" == name)
    return new PageSetup();
    
if( 11 == namespaceId && "legacyDrawingHF" == name)
    return new LegacyDrawingHeaderFooter();
    

    return null;
}

        private static readonly string[] eleTagNames = { "headerFooter","pageMargins","pageSetup","legacyDrawingHF" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Header and Footer.</para>
    /// <para> Represents the following element tag in the schema: c:headerFooter </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public HeaderFooter HeaderFooter
    {
        get => GetElement<HeaderFooter>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Page Margins.</para>
    /// <para> Represents the following element tag in the schema: c:pageMargins </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PageMargins PageMargins
    {
        get => GetElement<PageMargins>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Page Setup.</para>
    /// <para> Represents the following element tag in the schema: c:pageSetup </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public PageSetup PageSetup
    {
        get => GetElement<PageSetup>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Legacy Drawing for Headers and Footers.</para>
    /// <para> Represents the following element tag in the schema: c:legacyDrawingHF </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public LegacyDrawingHeaderFooter LegacyDrawingHeaderFooter
    {
        get => GetElement<LegacyDrawingHeaderFooter>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrintSettings>(deep);

}
/// <summary>
/// <para>Defines the ChartSpaceExtensionList Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartSpaceExtension &lt;c:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ChartSpaceExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ChartSpaceExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10650;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ChartSpaceExtensionList class.
    /// </summary>
    public ChartSpaceExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ChartSpaceExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartSpaceExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartSpaceExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartSpaceExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartSpaceExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartSpaceExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ext" == name)
    return new ChartSpaceExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartSpaceExtensionList>(deep);

}
/// <summary>
/// <para>Defines the ChartSpaceExtension Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c:ext.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions &lt;c14:pivotOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions &lt;c14:sketchOptions></description></item>
///<item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource &lt;c15:pivotSource></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ChartSpaceExtension : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10651;
    /// <inheritdoc/>
    public override string LocalName => "ext";
    
    internal override byte NamespaceId => 11;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> URI.</para>
    /// <para>Represents the following attribute in the schema: uri </para>
    /// </summary>
    [SchemaAttr(0, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ChartSpaceExtension class.
    /// </summary>
    public ChartSpaceExtension():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ChartSpaceExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartSpaceExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartSpaceExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartSpaceExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartSpaceExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartSpaceExtension(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 46 == namespaceId && "pivotOptions" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions();
    
if( 46 == namespaceId && "sketchOptions" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions();
    
if( 64 == namespaceId && "pivotSource" == name)
    return new DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartSpaceExtension>(deep);

}
/// <summary>
/// Layout Target 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LayoutTargetValues
{  
	///<summary>
///Inner.
///<para>When the item is serialized out as xml, its value is "inner".</para>
///</summary>
[EnumString("inner")]
Inner,
///<summary>
///Outer.
///<para>When the item is serialized out as xml, its value is "outer".</para>
///</summary>
[EnumString("outer")]
Outer,
 
}
/// <summary>
/// Layout Mode 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LayoutModeValues
{  
	///<summary>
///Edge.
///<para>When the item is serialized out as xml, its value is "edge".</para>
///</summary>
[EnumString("edge")]
Edge,
///<summary>
///Factor.
///<para>When the item is serialized out as xml, its value is "factor".</para>
///</summary>
[EnumString("factor")]
Factor,
 
}
/// <summary>
/// Size Represents 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SizeRepresentsValues
{  
	///<summary>
///Bubble Size Represents Area.
///<para>When the item is serialized out as xml, its value is "area".</para>
///</summary>
[EnumString("area")]
Area,
///<summary>
///Bubble Size Represents Width.
///<para>When the item is serialized out as xml, its value is "w".</para>
///</summary>
[EnumString("w")]
Width,
 
}
/// <summary>
/// Label Alignment 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LabelAlignmentValues
{  
	///<summary>
///Center.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
 
}
/// <summary>
/// Data Label Position 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DataLabelPositionValues
{  
	///<summary>
///Best Fit.
///<para>When the item is serialized out as xml, its value is "bestFit".</para>
///</summary>
[EnumString("bestFit")]
BestFit,
///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
///<summary>
///Center.
///<para>When the item is serialized out as xml, its value is "ctr".</para>
///</summary>
[EnumString("ctr")]
Center,
///<summary>
///Inside Base.
///<para>When the item is serialized out as xml, its value is "inBase".</para>
///</summary>
[EnumString("inBase")]
InsideBase,
///<summary>
///Inside End.
///<para>When the item is serialized out as xml, its value is "inEnd".</para>
///</summary>
[EnumString("inEnd")]
InsideEnd,
///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Outside End.
///<para>When the item is serialized out as xml, its value is "outEnd".</para>
///</summary>
[EnumString("outEnd")]
OutsideEnd,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
 
}
/// <summary>
/// Trendline Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TrendlineValues
{  
	///<summary>
///Exponential.
///<para>When the item is serialized out as xml, its value is "exp".</para>
///</summary>
[EnumString("exp")]
Exponential,
///<summary>
///Linear.
///<para>When the item is serialized out as xml, its value is "linear".</para>
///</summary>
[EnumString("linear")]
Linear,
///<summary>
///Logarithmic.
///<para>When the item is serialized out as xml, its value is "log".</para>
///</summary>
[EnumString("log")]
Logarithmic,
///<summary>
///Moving Average.
///<para>When the item is serialized out as xml, its value is "movingAvg".</para>
///</summary>
[EnumString("movingAvg")]
MovingAverage,
///<summary>
///Polynomial.
///<para>When the item is serialized out as xml, its value is "poly".</para>
///</summary>
[EnumString("poly")]
Polynomial,
///<summary>
///Power.
///<para>When the item is serialized out as xml, its value is "power".</para>
///</summary>
[EnumString("power")]
Power,
 
}
/// <summary>
/// Error Bar Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ErrorBarDirectionValues
{  
	///<summary>
///X.
///<para>When the item is serialized out as xml, its value is "x".</para>
///</summary>
[EnumString("x")]
X,
///<summary>
///Y.
///<para>When the item is serialized out as xml, its value is "y".</para>
///</summary>
[EnumString("y")]
Y,
 
}
/// <summary>
/// Error Bar Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ErrorBarValues
{  
	///<summary>
///Both.
///<para>When the item is serialized out as xml, its value is "both".</para>
///</summary>
[EnumString("both")]
Both,
///<summary>
///Minus.
///<para>When the item is serialized out as xml, its value is "minus".</para>
///</summary>
[EnumString("minus")]
Minus,
///<summary>
///Plus.
///<para>When the item is serialized out as xml, its value is "plus".</para>
///</summary>
[EnumString("plus")]
Plus,
 
}
/// <summary>
/// Error Value Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ErrorValues
{  
	///<summary>
///Custom Error Bars.
///<para>When the item is serialized out as xml, its value is "cust".</para>
///</summary>
[EnumString("cust")]
Custom,
///<summary>
///Fixed Value.
///<para>When the item is serialized out as xml, its value is "fixedVal".</para>
///</summary>
[EnumString("fixedVal")]
FixedValue,
///<summary>
///Percentage.
///<para>When the item is serialized out as xml, its value is "percentage".</para>
///</summary>
[EnumString("percentage")]
Percentage,
///<summary>
///Standard Deviation.
///<para>When the item is serialized out as xml, its value is "stdDev".</para>
///</summary>
[EnumString("stdDev")]
StandardDeviation,
///<summary>
///Standard Error.
///<para>When the item is serialized out as xml, its value is "stdErr".</para>
///</summary>
[EnumString("stdErr")]
StandardError,
 
}
/// <summary>
/// Grouping 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum GroupingValues
{  
	///<summary>
///100% Stacked.
///<para>When the item is serialized out as xml, its value is "percentStacked".</para>
///</summary>
[EnumString("percentStacked")]
PercentStacked,
///<summary>
///Standard.
///<para>When the item is serialized out as xml, its value is "standard".</para>
///</summary>
[EnumString("standard")]
Standard,
///<summary>
///Stacked.
///<para>When the item is serialized out as xml, its value is "stacked".</para>
///</summary>
[EnumString("stacked")]
Stacked,
 
}
/// <summary>
/// Radar Style 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum RadarStyleValues
{  
	///<summary>
///Standard.
///<para>When the item is serialized out as xml, its value is "standard".</para>
///</summary>
[EnumString("standard")]
Standard,
///<summary>
///Marker.
///<para>When the item is serialized out as xml, its value is "marker".</para>
///</summary>
[EnumString("marker")]
Marker,
///<summary>
///Filled.
///<para>When the item is serialized out as xml, its value is "filled".</para>
///</summary>
[EnumString("filled")]
Filled,
 
}
/// <summary>
/// Bar Grouping 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BarGroupingValues
{  
	///<summary>
///100% Stacked.
///<para>When the item is serialized out as xml, its value is "percentStacked".</para>
///</summary>
[EnumString("percentStacked")]
PercentStacked,
///<summary>
///Clustered.
///<para>When the item is serialized out as xml, its value is "clustered".</para>
///</summary>
[EnumString("clustered")]
Clustered,
///<summary>
///Standard.
///<para>When the item is serialized out as xml, its value is "standard".</para>
///</summary>
[EnumString("standard")]
Standard,
///<summary>
///Stacked.
///<para>When the item is serialized out as xml, its value is "stacked".</para>
///</summary>
[EnumString("stacked")]
Stacked,
 
}
/// <summary>
/// Bar Direction 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BarDirectionValues
{  
	///<summary>
///Bar.
///<para>When the item is serialized out as xml, its value is "bar".</para>
///</summary>
[EnumString("bar")]
Bar,
///<summary>
///Column.
///<para>When the item is serialized out as xml, its value is "col".</para>
///</summary>
[EnumString("col")]
Column,
 
}
/// <summary>
/// Shape 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ShapeValues
{  
	///<summary>
///Cone.
///<para>When the item is serialized out as xml, its value is "cone".</para>
///</summary>
[EnumString("cone")]
Cone,
///<summary>
///Cone to Max.
///<para>When the item is serialized out as xml, its value is "coneToMax".</para>
///</summary>
[EnumString("coneToMax")]
ConeToMax,
///<summary>
///Box.
///<para>When the item is serialized out as xml, its value is "box".</para>
///</summary>
[EnumString("box")]
Box,
///<summary>
///Cylinder.
///<para>When the item is serialized out as xml, its value is "cylinder".</para>
///</summary>
[EnumString("cylinder")]
Cylinder,
///<summary>
///Pyramid.
///<para>When the item is serialized out as xml, its value is "pyramid".</para>
///</summary>
[EnumString("pyramid")]
Pyramid,
///<summary>
///Pyramid to Maximum.
///<para>When the item is serialized out as xml, its value is "pyramidToMax".</para>
///</summary>
[EnumString("pyramidToMax")]
PyramidToMaximum,
 
}
/// <summary>
/// Pie of Pie or Bar of Pie Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OfPieValues
{  
	///<summary>
///Pie.
///<para>When the item is serialized out as xml, its value is "pie".</para>
///</summary>
[EnumString("pie")]
Pie,
///<summary>
///Bar.
///<para>When the item is serialized out as xml, its value is "bar".</para>
///</summary>
[EnumString("bar")]
Bar,
 
}
/// <summary>
/// Axis Position 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AxisPositionValues
{  
	///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
 
}
/// <summary>
/// Crosses 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum CrossesValues
{  
	///<summary>
///Axis Crosses at Zero.
///<para>When the item is serialized out as xml, its value is "autoZero".</para>
///</summary>
[EnumString("autoZero")]
AutoZero,
///<summary>
///Maximum.
///<para>When the item is serialized out as xml, its value is "max".</para>
///</summary>
[EnumString("max")]
Maximum,
///<summary>
///Minimum.
///<para>When the item is serialized out as xml, its value is "min".</para>
///</summary>
[EnumString("min")]
Minimum,
 
}
/// <summary>
/// Cross Between 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum CrossBetweenValues
{  
	///<summary>
///Between.
///<para>When the item is serialized out as xml, its value is "between".</para>
///</summary>
[EnumString("between")]
Between,
///<summary>
///Midpoint of Category.
///<para>When the item is serialized out as xml, its value is "midCat".</para>
///</summary>
[EnumString("midCat")]
MidpointCategory,
 
}
/// <summary>
/// Tick Mark 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TickMarkValues
{  
	///<summary>
///Cross.
///<para>When the item is serialized out as xml, its value is "cross".</para>
///</summary>
[EnumString("cross")]
Cross,
///<summary>
///Inside.
///<para>When the item is serialized out as xml, its value is "in".</para>
///</summary>
[EnumString("in")]
Inside,
///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Outside.
///<para>When the item is serialized out as xml, its value is "out".</para>
///</summary>
[EnumString("out")]
Outside,
 
}
/// <summary>
/// Tick Label Position 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TickLabelPositionValues
{  
	///<summary>
///High.
///<para>When the item is serialized out as xml, its value is "high".</para>
///</summary>
[EnumString("high")]
High,
///<summary>
///Low.
///<para>When the item is serialized out as xml, its value is "low".</para>
///</summary>
[EnumString("low")]
Low,
///<summary>
///Next To.
///<para>When the item is serialized out as xml, its value is "nextTo".</para>
///</summary>
[EnumString("nextTo")]
NextTo,
///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
 
}
/// <summary>
/// Time Unit 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TimeUnitValues
{  
	///<summary>
///Days.
///<para>When the item is serialized out as xml, its value is "days".</para>
///</summary>
[EnumString("days")]
Days,
///<summary>
///Months.
///<para>When the item is serialized out as xml, its value is "months".</para>
///</summary>
[EnumString("months")]
Months,
///<summary>
///Years.
///<para>When the item is serialized out as xml, its value is "years".</para>
///</summary>
[EnumString("years")]
Years,
 
}
/// <summary>
/// Built-In Unit 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BuiltInUnitValues
{  
	///<summary>
///Hundreds.
///<para>When the item is serialized out as xml, its value is "hundreds".</para>
///</summary>
[EnumString("hundreds")]
Hundreds,
///<summary>
///Thousands.
///<para>When the item is serialized out as xml, its value is "thousands".</para>
///</summary>
[EnumString("thousands")]
Thousands,
///<summary>
///Ten Thousands.
///<para>When the item is serialized out as xml, its value is "tenThousands".</para>
///</summary>
[EnumString("tenThousands")]
TenThousands,
///<summary>
///Hundred Thousands.
///<para>When the item is serialized out as xml, its value is "hundredThousands".</para>
///</summary>
[EnumString("hundredThousands")]
HundredThousands,
///<summary>
///Millions.
///<para>When the item is serialized out as xml, its value is "millions".</para>
///</summary>
[EnumString("millions")]
Millions,
///<summary>
///Ten Millions.
///<para>When the item is serialized out as xml, its value is "tenMillions".</para>
///</summary>
[EnumString("tenMillions")]
TenMillions,
///<summary>
///Hundred Millions.
///<para>When the item is serialized out as xml, its value is "hundredMillions".</para>
///</summary>
[EnumString("hundredMillions")]
HundredMillions,
///<summary>
///Billions.
///<para>When the item is serialized out as xml, its value is "billions".</para>
///</summary>
[EnumString("billions")]
Billions,
///<summary>
///Trillions.
///<para>When the item is serialized out as xml, its value is "trillions".</para>
///</summary>
[EnumString("trillions")]
Trillions,
 
}
/// <summary>
/// Picture Format 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PictureFormatValues
{  
	///<summary>
///Stretch.
///<para>When the item is serialized out as xml, its value is "stretch".</para>
///</summary>
[EnumString("stretch")]
Stretch,
///<summary>
///Stack.
///<para>When the item is serialized out as xml, its value is "stack".</para>
///</summary>
[EnumString("stack")]
Stack,
///<summary>
///Stack and Scale.
///<para>When the item is serialized out as xml, its value is "stackScale".</para>
///</summary>
[EnumString("stackScale")]
StackScale,
 
}
/// <summary>
/// Orientation 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OrientationValues
{  
	///<summary>
///Maximum to Minimum.
///<para>When the item is serialized out as xml, its value is "maxMin".</para>
///</summary>
[EnumString("maxMin")]
MaxMin,
///<summary>
///Minimum to Maximum.
///<para>When the item is serialized out as xml, its value is "minMax".</para>
///</summary>
[EnumString("minMax")]
MinMax,
 
}
/// <summary>
/// Legend Position 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LegendPositionValues
{  
	///<summary>
///Bottom.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bottom,
///<summary>
///Top Right.
///<para>When the item is serialized out as xml, its value is "tr".</para>
///</summary>
[EnumString("tr")]
TopRight,
///<summary>
///Left.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
Top,
 
}
/// <summary>
/// Display Blanks As 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DisplayBlanksAsValues
{  
	///<summary>
///Span.
///<para>When the item is serialized out as xml, its value is "span".</para>
///</summary>
[EnumString("span")]
Span,
///<summary>
///Gap.
///<para>When the item is serialized out as xml, its value is "gap".</para>
///</summary>
[EnumString("gap")]
Gap,
///<summary>
///Zero.
///<para>When the item is serialized out as xml, its value is "zero".</para>
///</summary>
[EnumString("zero")]
Zero,
 
}
/// <summary>
/// Printed Page Orientation 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PageSetupOrientationValues
{  
	///<summary>
///Default Page Orientation.
///<para>When the item is serialized out as xml, its value is "default".</para>
///</summary>
[EnumString("default")]
Default,
///<summary>
///Portrait Page.
///<para>When the item is serialized out as xml, its value is "portrait".</para>
///</summary>
[EnumString("portrait")]
Portrait,
///<summary>
///Landscape Page.
///<para>When the item is serialized out as xml, its value is "landscape".</para>
///</summary>
[EnumString("landscape")]
Landscape,
 
}
/// <summary>
/// Scatter Style 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ScatterStyleValues
{  
	///<summary>
///Line.
///<para>When the item is serialized out as xml, its value is "line".</para>
///</summary>
[EnumString("line")]
Line,
///<summary>
///Line with Markers.
///<para>When the item is serialized out as xml, its value is "lineMarker".</para>
///</summary>
[EnumString("lineMarker")]
LineMarker,
///<summary>
///Marker.
///<para>When the item is serialized out as xml, its value is "marker".</para>
///</summary>
[EnumString("marker")]
Marker,
///<summary>
///Smooth.
///<para>When the item is serialized out as xml, its value is "smooth".</para>
///</summary>
[EnumString("smooth")]
Smooth,
///<summary>
///Smooth with Markers.
///<para>When the item is serialized out as xml, its value is "smoothMarker".</para>
///</summary>
[EnumString("smoothMarker")]
SmoothMarker,
 
}
/// <summary>
/// Marker Style 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum MarkerStyleValues
{  
	///<summary>
///auto.
///<para>When the item is serialized out as xml, its value is "auto".</para>
///</summary>
[EnumString("auto")]
Auto,
///<summary>
///Circle.
///<para>When the item is serialized out as xml, its value is "circle".</para>
///</summary>
[EnumString("circle")]
Circle,
///<summary>
///Dash.
///<para>When the item is serialized out as xml, its value is "dash".</para>
///</summary>
[EnumString("dash")]
Dash,
///<summary>
///Diamond.
///<para>When the item is serialized out as xml, its value is "diamond".</para>
///</summary>
[EnumString("diamond")]
Diamond,
///<summary>
///Dot.
///<para>When the item is serialized out as xml, its value is "dot".</para>
///</summary>
[EnumString("dot")]
Dot,
///<summary>
///None.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///Picture.
///<para>When the item is serialized out as xml, its value is "picture".</para>
///</summary>
[EnumString("picture")]
Picture,
///<summary>
///Plus.
///<para>When the item is serialized out as xml, its value is "plus".</para>
///</summary>
[EnumString("plus")]
Plus,
///<summary>
///Square.
///<para>When the item is serialized out as xml, its value is "square".</para>
///</summary>
[EnumString("square")]
Square,
///<summary>
///Star.
///<para>When the item is serialized out as xml, its value is "star".</para>
///</summary>
[EnumString("star")]
Star,
///<summary>
///Triangle.
///<para>When the item is serialized out as xml, its value is "triangle".</para>
///</summary>
[EnumString("triangle")]
Triangle,
///<summary>
///X.
///<para>When the item is serialized out as xml, its value is "x".</para>
///</summary>
[EnumString("x")]
X,
 
}
/// <summary>
/// Split Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SplitValues
{  
	///<summary>
///Custom Split.
///<para>When the item is serialized out as xml, its value is "cust".</para>
///</summary>
[EnumString("cust")]
Custom,
///<summary>
///Split by Percentage.
///<para>When the item is serialized out as xml, its value is "percent".</para>
///</summary>
[EnumString("percent")]
Percent,
///<summary>
///Split by Position.
///<para>When the item is serialized out as xml, its value is "pos".</para>
///</summary>
[EnumString("pos")]
Position,
///<summary>
///Split by Value.
///<para>When the item is serialized out as xml, its value is "val".</para>
///</summary>
[EnumString("val")]
Value,
 
}
}
 
 
