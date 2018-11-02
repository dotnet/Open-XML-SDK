// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2010.Drawing
{
/// <summary>
/// <para>Defines the CameraTool Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:cameraTool.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CameraTool : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12781;
    /// <inheritdoc/>
    public override string LocalName => "cameraTool";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "cellRange"),
		AttributeTag.Create<StringValue>(0, "spid")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> cellRange.</para>
    /// <para>Represents the following attribute in the schema: cellRange </para>
    /// </summary>
    [SchemaAttr(0, "cellRange")]
    public StringValue CellRange
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> spid.</para>
    /// <para>Represents the following attribute in the schema: spid </para>
    /// </summary>
    [SchemaAttr(0, "spid")]
    public StringValue ShapeId
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CameraTool class.
    /// </summary>
    public CameraTool():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CameraTool>(deep);

}
/// <summary>
/// <para>Defines the CompatExtension Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:compatExt.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CompatExtension : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12782;
    /// <inheritdoc/>
    public override string LocalName => "compatExt";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "spid")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> spid.</para>
    /// <para>Represents the following attribute in the schema: spid </para>
    /// </summary>
    [SchemaAttr(0, "spid")]
    public StringValue ShapeId
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CompatExtension class.
    /// </summary>
    public CompatExtension():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CompatExtension>(deep);

}
/// <summary>
/// <para>Defines the IsCanvas Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:isCanvas.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class IsCanvas : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12783;
    /// <inheritdoc/>
    public override string LocalName => "isCanvas";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the IsCanvas class.
    /// </summary>
    public IsCanvas():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<IsCanvas>(deep);

}
/// <summary>
/// <para>Defines the GvmlContentPart Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:contentPart.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualContentPartProperties &lt;a14:nvContentPartPr></description></item>
///<item><description>Transform2D &lt;a14:xfrm></description></item>
///<item><description>OfficeArtExtensionList &lt;a14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualContentPartProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Transform2D), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class GvmlContentPart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12784;
    /// <inheritdoc/>
    public override string LocalName => "contentPart";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>(0, "bwMode"),
		AttributeTag.Create<StringValue>(19, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> bwMode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue RelationshipId
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the GvmlContentPart class.
    /// </summary>
    public GvmlContentPart():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GvmlContentPart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GvmlContentPart(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GvmlContentPart class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GvmlContentPart(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GvmlContentPart class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GvmlContentPart(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 48 == namespaceId && "nvContentPartPr" == name)
    return new NonVisualContentPartProperties();
    
if( 48 == namespaceId && "xfrm" == name)
    return new Transform2D();
    
if( 48 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvContentPartPr","xfrm","extLst" };
    private static readonly byte[] eleNamespaceIds = { 48,48,48 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualContentPartProperties.</para>
    /// <para> Represents the following element tag in the schema: a14:nvContentPartPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public NonVisualContentPartProperties NonVisualContentPartProperties
    {
        get => GetElement<NonVisualContentPartProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Transform2D.</para>
    /// <para> Represents the following element tag in the schema: a14:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public Transform2D Transform2D
    {
        get => GetElement<Transform2D>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<OfficeArtExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GvmlContentPart>(deep);

}
/// <summary>
/// <para>Defines the ShadowObscured Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:shadowObscured.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ShadowObscured : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12785;
    /// <inheritdoc/>
    public override string LocalName => "shadowObscured";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShadowObscured class.
    /// </summary>
    public ShadowObscured():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShadowObscured>(deep);

}
/// <summary>
/// <para>Defines the HiddenFillProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:hiddenFill.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class HiddenFillProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12786;
    /// <inheritdoc/>
    public override string LocalName => "hiddenFill";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the HiddenFillProperties class.
    /// </summary>
    public HiddenFillProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the HiddenFillProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiddenFillProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HiddenFillProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiddenFillProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HiddenFillProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HiddenFillProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
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
    

    return null;
}

        private static readonly string[] eleTagNames = { "noFill","solidFill","gradFill","blipFill","pattFill","grpFill" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> NoFill.</para>
    /// <para> Represents the following element tag in the schema: a:noFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.NoFill NoFill
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.NoFill>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> SolidFill.</para>
    /// <para> Represents the following element tag in the schema: a:solidFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.SolidFill SolidFill
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.SolidFill>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> GradientFill.</para>
    /// <para> Represents the following element tag in the schema: a:gradFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.GradientFill GradientFill
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.GradientFill>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> BlipFill.</para>
    /// <para> Represents the following element tag in the schema: a:blipFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.BlipFill BlipFill
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.BlipFill>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Pattern Fill.</para>
    /// <para> Represents the following element tag in the schema: a:pattFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.PatternFill PatternFill
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.PatternFill>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Group Fill.</para>
    /// <para> Represents the following element tag in the schema: a:grpFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.GroupFill GroupFill
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.GroupFill>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenFillProperties>(deep);

}
/// <summary>
/// <para>Defines the HiddenLineProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:hiddenLine.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetDash &lt;a:prstDash></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.CustomDash &lt;a:custDash></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Round &lt;a:round></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.LineJoinBevel &lt;a:bevel></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Miter &lt;a:miter></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HeadEnd &lt;a:headEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.TailEnd &lt;a:tailEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetDash))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.CustomDash))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Round))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LineJoinBevel))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Miter))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HeadEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.TailEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class HiddenLineProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12787;
    /// <inheritdoc/>
    public override string LocalName => "hiddenLine";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "w"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues>>(0, "cap"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues>>(0, "cmpd"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues>>(0, "algn")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Line Width.</para>
    /// <para>Represents the following attribute in the schema: w </para>
    /// </summary>
    [SchemaAttr(0, "w")]
    public Int32Value Width
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Line Ending Cap Type.</para>
    /// <para>Represents the following attribute in the schema: cap </para>
    /// </summary>
    [SchemaAttr(0, "cap")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues> CapType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Compound Line Type.</para>
    /// <para>Represents the following attribute in the schema: cmpd </para>
    /// </summary>
    [SchemaAttr(0, "cmpd")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues> CompoundLineType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Stroke Alignment.</para>
    /// <para>Represents the following attribute in the schema: algn </para>
    /// </summary>
    [SchemaAttr(0, "algn")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues> Alignment
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the HiddenLineProperties class.
    /// </summary>
    public HiddenLineProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the HiddenLineProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiddenLineProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HiddenLineProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiddenLineProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HiddenLineProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HiddenLineProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "noFill" == name)
    return new DocumentFormat.OpenXml.Drawing.NoFill();
    
if( 10 == namespaceId && "solidFill" == name)
    return new DocumentFormat.OpenXml.Drawing.SolidFill();
    
if( 10 == namespaceId && "gradFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GradientFill();
    
if( 10 == namespaceId && "pattFill" == name)
    return new DocumentFormat.OpenXml.Drawing.PatternFill();
    
if( 10 == namespaceId && "prstDash" == name)
    return new DocumentFormat.OpenXml.Drawing.PresetDash();
    
if( 10 == namespaceId && "custDash" == name)
    return new DocumentFormat.OpenXml.Drawing.CustomDash();
    
if( 10 == namespaceId && "round" == name)
    return new DocumentFormat.OpenXml.Drawing.Round();
    
if( 10 == namespaceId && "bevel" == name)
    return new DocumentFormat.OpenXml.Drawing.LineJoinBevel();
    
if( 10 == namespaceId && "miter" == name)
    return new DocumentFormat.OpenXml.Drawing.Miter();
    
if( 10 == namespaceId && "headEnd" == name)
    return new DocumentFormat.OpenXml.Drawing.HeadEnd();
    
if( 10 == namespaceId && "tailEnd" == name)
    return new DocumentFormat.OpenXml.Drawing.TailEnd();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenLineProperties>(deep);

}
/// <summary>
/// <para>Defines the HiddenEffectsProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:hiddenEffects.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class HiddenEffectsProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12788;
    /// <inheritdoc/>
    public override string LocalName => "hiddenEffects";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the HiddenEffectsProperties class.
    /// </summary>
    public HiddenEffectsProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the HiddenEffectsProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiddenEffectsProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HiddenEffectsProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiddenEffectsProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HiddenEffectsProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HiddenEffectsProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "effectLst" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectList();
    
if( 10 == namespaceId && "effectDag" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectDag();
    

    return null;
}

        private static readonly string[] eleTagNames = { "effectLst","effectDag" };
    private static readonly byte[] eleNamespaceIds = { 10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Effect Container.</para>
    /// <para> Represents the following element tag in the schema: a:effectLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.EffectList EffectList
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.EffectList>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Effect Container.</para>
    /// <para> Represents the following element tag in the schema: a:effectDag </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.EffectDag EffectDag
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.EffectDag>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenEffectsProperties>(deep);

}
/// <summary>
/// <para>Defines the HiddenScene3D Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:hiddenScene3d.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Camera &lt;a:camera></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.LightRig &lt;a:lightRig></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Backdrop &lt;a:backdrop></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Camera))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LightRig))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Backdrop))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class HiddenScene3D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12789;
    /// <inheritdoc/>
    public override string LocalName => "hiddenScene3d";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the HiddenScene3D class.
    /// </summary>
    public HiddenScene3D():base(){}
    
        /// <summary>
    ///Initializes a new instance of the HiddenScene3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiddenScene3D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HiddenScene3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiddenScene3D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HiddenScene3D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HiddenScene3D(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "camera" == name)
    return new DocumentFormat.OpenXml.Drawing.Camera();
    
if( 10 == namespaceId && "lightRig" == name)
    return new DocumentFormat.OpenXml.Drawing.LightRig();
    
if( 10 == namespaceId && "backdrop" == name)
    return new DocumentFormat.OpenXml.Drawing.Backdrop();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "camera","lightRig","backdrop","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Camera.</para>
    /// <para> Represents the following element tag in the schema: a:camera </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Camera Camera
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Camera>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Light Rig.</para>
    /// <para> Represents the following element tag in the schema: a:lightRig </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.LightRig LightRig
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.LightRig>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Backdrop Plane.</para>
    /// <para> Represents the following element tag in the schema: a:backdrop </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Backdrop Backdrop
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Backdrop>(2);
        set => SetElement(2, value);
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
        get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenScene3D>(deep);

}
/// <summary>
/// <para>Defines the HiddenShape3D Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:hiddenSp3d.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.BevelTop &lt;a:bevelT></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BevelBottom &lt;a:bevelB></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtrusionColor &lt;a:extrusionClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ContourColor &lt;a:contourClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BevelTop))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BevelBottom))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtrusionColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ContourColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class HiddenShape3D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12790;
    /// <inheritdoc/>
    public override string LocalName => "hiddenSp3d";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int64Value>(0, "z"),
		AttributeTag.Create<Int64Value>(0, "extrusionH"),
		AttributeTag.Create<Int64Value>(0, "contourW"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues>>(0, "prstMaterial")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Shape Depth.</para>
    /// <para>Represents the following attribute in the schema: z </para>
    /// </summary>
    [SchemaAttr(0, "z")]
    public Int64Value Z
    {
        get { return (Int64Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Extrusion Height.</para>
    /// <para>Represents the following attribute in the schema: extrusionH </para>
    /// </summary>
    [SchemaAttr(0, "extrusionH")]
    public Int64Value ExtrusionHeight
    {
        get { return (Int64Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Contour Width.</para>
    /// <para>Represents the following attribute in the schema: contourW </para>
    /// </summary>
    [SchemaAttr(0, "contourW")]
    public Int64Value ContourWidth
    {
        get { return (Int64Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Preset Material Type.</para>
    /// <para>Represents the following attribute in the schema: prstMaterial </para>
    /// </summary>
    [SchemaAttr(0, "prstMaterial")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues> PresetMaterial
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the HiddenShape3D class.
    /// </summary>
    public HiddenShape3D():base(){}
    
        /// <summary>
    ///Initializes a new instance of the HiddenShape3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiddenShape3D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HiddenShape3D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HiddenShape3D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HiddenShape3D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HiddenShape3D(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "bevelT" == name)
    return new DocumentFormat.OpenXml.Drawing.BevelTop();
    
if( 10 == namespaceId && "bevelB" == name)
    return new DocumentFormat.OpenXml.Drawing.BevelBottom();
    
if( 10 == namespaceId && "extrusionClr" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtrusionColor();
    
if( 10 == namespaceId && "contourClr" == name)
    return new DocumentFormat.OpenXml.Drawing.ContourColor();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "bevelT","bevelB","extrusionClr","contourClr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Top Bevel.</para>
    /// <para> Represents the following element tag in the schema: a:bevelT </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.BevelTop BevelTop
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.BevelTop>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Bottom Bevel.</para>
    /// <para> Represents the following element tag in the schema: a:bevelB </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.BevelBottom BevelBottom
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.BevelBottom>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Extrusion Color.</para>
    /// <para> Represents the following element tag in the schema: a:extrusionClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.ExtrusionColor ExtrusionColor
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.ExtrusionColor>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Contour Color.</para>
    /// <para> Represents the following element tag in the schema: a:contourClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.ContourColor ContourColor
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.ContourColor>(3);
        set => SetElement(3, value);
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
        get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(4);
        set => SetElement(4, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenShape3D>(deep);

}
/// <summary>
/// <para>Defines the ImageProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:imgProps.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ImageLayer &lt;a14:imgLayer></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ImageLayer), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ImageProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12791;
    /// <inheritdoc/>
    public override string LocalName => "imgProps";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ImageProperties class.
    /// </summary>
    public ImageProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ImageProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ImageProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ImageProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ImageProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ImageProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ImageProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 48 == namespaceId && "imgLayer" == name)
    return new ImageLayer();
    

    return null;
}

        private static readonly string[] eleTagNames = { "imgLayer" };
    private static readonly byte[] eleNamespaceIds = { 48 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ImageLayer.</para>
    /// <para> Represents the following element tag in the schema: a14:imgLayer </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ImageLayer ImageLayer
    {
        get => GetElement<ImageLayer>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageProperties>(deep);

}
/// <summary>
/// <para>Defines the UseLocalDpi Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:useLocalDpi.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class UseLocalDpi : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12792;
    /// <inheritdoc/>
    public override string LocalName => "useLocalDpi";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the UseLocalDpi class.
    /// </summary>
    public UseLocalDpi():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UseLocalDpi>(deep);

}
/// <summary>
/// <para>Defines the TextMath Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:m.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TextMath : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12793;
    /// <inheritdoc/>
    public override string LocalName => "m";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TextMath class.
    /// </summary>
    public TextMath():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextMath>(deep);

}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12794;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
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

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);

}
/// <summary>
/// <para>Defines the ContentPartLocks Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:cpLocks.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfficeArtExtensionList &lt;a14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContentPartLocks : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12795;
    /// <inheritdoc/>
    public override string LocalName => "cpLocks";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "noGrp"),
		AttributeTag.Create<BooleanValue>(0, "noSelect"),
		AttributeTag.Create<BooleanValue>(0, "noRot"),
		AttributeTag.Create<BooleanValue>(0, "noChangeAspect"),
		AttributeTag.Create<BooleanValue>(0, "noMove"),
		AttributeTag.Create<BooleanValue>(0, "noResize"),
		AttributeTag.Create<BooleanValue>(0, "noEditPoints"),
		AttributeTag.Create<BooleanValue>(0, "noAdjustHandles"),
		AttributeTag.Create<BooleanValue>(0, "noChangeArrowheads"),
		AttributeTag.Create<BooleanValue>(0, "noChangeShapeType")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Disallow Shape Grouping.</para>
    /// <para>Represents the following attribute in the schema: noGrp </para>
    /// </summary>
    [SchemaAttr(0, "noGrp")]
    public BooleanValue NoGrouping
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Disallow Shape Selection.</para>
    /// <para>Represents the following attribute in the schema: noSelect </para>
    /// </summary>
    [SchemaAttr(0, "noSelect")]
    public BooleanValue NoSelection
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Disallow Shape Rotation.</para>
    /// <para>Represents the following attribute in the schema: noRot </para>
    /// </summary>
    [SchemaAttr(0, "noRot")]
    public BooleanValue NoRotation
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Disallow Aspect Ratio Change.</para>
    /// <para>Represents the following attribute in the schema: noChangeAspect </para>
    /// </summary>
    [SchemaAttr(0, "noChangeAspect")]
    public BooleanValue NoChangeAspect
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Disallow Shape Movement.</para>
    /// <para>Represents the following attribute in the schema: noMove </para>
    /// </summary>
    [SchemaAttr(0, "noMove")]
    public BooleanValue NoMove
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Disallow Shape Resize.</para>
    /// <para>Represents the following attribute in the schema: noResize </para>
    /// </summary>
    [SchemaAttr(0, "noResize")]
    public BooleanValue NoResize
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Disallow Shape Point Editing.</para>
    /// <para>Represents the following attribute in the schema: noEditPoints </para>
    /// </summary>
    [SchemaAttr(0, "noEditPoints")]
    public BooleanValue NoEditPoints
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Disallow Showing Adjust Handles.</para>
    /// <para>Represents the following attribute in the schema: noAdjustHandles </para>
    /// </summary>
    [SchemaAttr(0, "noAdjustHandles")]
    public BooleanValue NoAdjustHandles
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Disallow Arrowhead Changes.</para>
    /// <para>Represents the following attribute in the schema: noChangeArrowheads </para>
    /// </summary>
    [SchemaAttr(0, "noChangeArrowheads")]
    public BooleanValue NoChangeArrowheads
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Disallow Shape Type Change.</para>
    /// <para>Represents the following attribute in the schema: noChangeShapeType </para>
    /// </summary>
    [SchemaAttr(0, "noChangeShapeType")]
    public BooleanValue NoChangeShapeType
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ContentPartLocks class.
    /// </summary>
    public ContentPartLocks():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ContentPartLocks class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContentPartLocks(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContentPartLocks class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContentPartLocks(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContentPartLocks class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContentPartLocks(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 48 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 48 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<OfficeArtExtensionList>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentPartLocks>(deep);

}
/// <summary>
/// <para>Defines the ForegroundMark Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:foregroundMark.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ForegroundMark : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12796;
    /// <inheritdoc/>
    public override string LocalName => "foregroundMark";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "x1"),
		AttributeTag.Create<Int32Value>(0, "y1"),
		AttributeTag.Create<Int32Value>(0, "x2"),
		AttributeTag.Create<Int32Value>(0, "y2")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> x1.</para>
    /// <para>Represents the following attribute in the schema: x1 </para>
    /// </summary>
    [SchemaAttr(0, "x1")]
    public Int32Value FirstXCoordinate
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> y1.</para>
    /// <para>Represents the following attribute in the schema: y1 </para>
    /// </summary>
    [SchemaAttr(0, "y1")]
    public Int32Value FirstYCoordinate
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> x2.</para>
    /// <para>Represents the following attribute in the schema: x2 </para>
    /// </summary>
    [SchemaAttr(0, "x2")]
    public Int32Value SecondXCoordinate
    {
        get { return (Int32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> y2.</para>
    /// <para>Represents the following attribute in the schema: y2 </para>
    /// </summary>
    [SchemaAttr(0, "y2")]
    public Int32Value SecondYCoordinate
    {
        get { return (Int32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ForegroundMark class.
    /// </summary>
    public ForegroundMark():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ForegroundMark>(deep);

}
/// <summary>
/// <para>Defines the BackgroundMark Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:backgroundMark.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackgroundMark : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12797;
    /// <inheritdoc/>
    public override string LocalName => "backgroundMark";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "x1"),
		AttributeTag.Create<Int32Value>(0, "y1"),
		AttributeTag.Create<Int32Value>(0, "x2"),
		AttributeTag.Create<Int32Value>(0, "y2")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> x1.</para>
    /// <para>Represents the following attribute in the schema: x1 </para>
    /// </summary>
    [SchemaAttr(0, "x1")]
    public Int32Value FirstXCoordinate
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> y1.</para>
    /// <para>Represents the following attribute in the schema: y1 </para>
    /// </summary>
    [SchemaAttr(0, "y1")]
    public Int32Value FirstYCoordinate
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> x2.</para>
    /// <para>Represents the following attribute in the schema: x2 </para>
    /// </summary>
    [SchemaAttr(0, "x2")]
    public Int32Value SecondXCoordinate
    {
        get { return (Int32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> y2.</para>
    /// <para>Represents the following attribute in the schema: y2 </para>
    /// </summary>
    [SchemaAttr(0, "y2")]
    public Int32Value SecondYCoordinate
    {
        get { return (Int32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackgroundMark class.
    /// </summary>
    public BackgroundMark():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundMark>(deep);

}
/// <summary>
/// <para>Defines the ArtisticBlur Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticBlur.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticBlur : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12798;
    /// <inheritdoc/>
    public override string LocalName => "artisticBlur";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "radius")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> radius.</para>
    /// <para>Represents the following attribute in the schema: radius </para>
    /// </summary>
    [SchemaAttr(0, "radius")]
    public Int32Value Radius
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticBlur class.
    /// </summary>
    public ArtisticBlur():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticBlur>(deep);

}
/// <summary>
/// <para>Defines the ArtisticCement Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticCement.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticCement : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12799;
    /// <inheritdoc/>
    public override string LocalName => "artisticCement";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "crackSpacing")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> crackSpacing.</para>
    /// <para>Represents the following attribute in the schema: crackSpacing </para>
    /// </summary>
    [SchemaAttr(0, "crackSpacing")]
    public Int32Value CrackSpacing
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticCement class.
    /// </summary>
    public ArtisticCement():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCement>(deep);

}
/// <summary>
/// <para>Defines the ArtisticChalkSketch Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticChalkSketch.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticChalkSketch : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12800;
    /// <inheritdoc/>
    public override string LocalName => "artisticChalkSketch";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "pressure")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> pressure.</para>
    /// <para>Represents the following attribute in the schema: pressure </para>
    /// </summary>
    [SchemaAttr(0, "pressure")]
    public Int32Value Pressure
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticChalkSketch class.
    /// </summary>
    public ArtisticChalkSketch():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticChalkSketch>(deep);

}
/// <summary>
/// <para>Defines the ArtisticCrisscrossEtching Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticCrisscrossEtching.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticCrisscrossEtching : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12801;
    /// <inheritdoc/>
    public override string LocalName => "artisticCrisscrossEtching";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "pressure")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> pressure.</para>
    /// <para>Represents the following attribute in the schema: pressure </para>
    /// </summary>
    [SchemaAttr(0, "pressure")]
    public Int32Value Pressure
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticCrisscrossEtching class.
    /// </summary>
    public ArtisticCrisscrossEtching():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCrisscrossEtching>(deep);

}
/// <summary>
/// <para>Defines the ArtisticCutout Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticCutout.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticCutout : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12802;
    /// <inheritdoc/>
    public override string LocalName => "artisticCutout";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "numberOfShades")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> numberOfShades.</para>
    /// <para>Represents the following attribute in the schema: numberOfShades </para>
    /// </summary>
    [SchemaAttr(0, "numberOfShades")]
    public Int32Value NumberOfShades
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticCutout class.
    /// </summary>
    public ArtisticCutout():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCutout>(deep);

}
/// <summary>
/// <para>Defines the ArtisticFilmGrain Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticFilmGrain.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticFilmGrain : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12803;
    /// <inheritdoc/>
    public override string LocalName => "artisticFilmGrain";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "grainSize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> grainSize.</para>
    /// <para>Represents the following attribute in the schema: grainSize </para>
    /// </summary>
    [SchemaAttr(0, "grainSize")]
    public Int32Value GrainSize
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticFilmGrain class.
    /// </summary>
    public ArtisticFilmGrain():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticFilmGrain>(deep);

}
/// <summary>
/// <para>Defines the ArtisticGlass Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticGlass.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticGlass : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12804;
    /// <inheritdoc/>
    public override string LocalName => "artisticGlass";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "scaling")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> scaling.</para>
    /// <para>Represents the following attribute in the schema: scaling </para>
    /// </summary>
    [SchemaAttr(0, "scaling")]
    public Int32Value Scaling
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticGlass class.
    /// </summary>
    public ArtisticGlass():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlass>(deep);

}
/// <summary>
/// <para>Defines the ArtisticGlowDiffused Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticGlowDiffused.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticGlowDiffused : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12805;
    /// <inheritdoc/>
    public override string LocalName => "artisticGlowDiffused";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "intensity")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> intensity.</para>
    /// <para>Represents the following attribute in the schema: intensity </para>
    /// </summary>
    [SchemaAttr(0, "intensity")]
    public Int32Value Intensity
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticGlowDiffused class.
    /// </summary>
    public ArtisticGlowDiffused():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlowDiffused>(deep);

}
/// <summary>
/// <para>Defines the ArtisticGlowEdges Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticGlowEdges.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticGlowEdges : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12806;
    /// <inheritdoc/>
    public override string LocalName => "artisticGlowEdges";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "smoothness")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> smoothness.</para>
    /// <para>Represents the following attribute in the schema: smoothness </para>
    /// </summary>
    [SchemaAttr(0, "smoothness")]
    public Int32Value Smoothness
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticGlowEdges class.
    /// </summary>
    public ArtisticGlowEdges():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlowEdges>(deep);

}
/// <summary>
/// <para>Defines the ArtisticLightScreen Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticLightScreen.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticLightScreen : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12807;
    /// <inheritdoc/>
    public override string LocalName => "artisticLightScreen";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "gridSize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> gridSize.</para>
    /// <para>Represents the following attribute in the schema: gridSize </para>
    /// </summary>
    [SchemaAttr(0, "gridSize")]
    public Int32Value GridSize
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticLightScreen class.
    /// </summary>
    public ArtisticLightScreen():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticLightScreen>(deep);

}
/// <summary>
/// <para>Defines the ArtisticLineDrawing Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticLineDrawing.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticLineDrawing : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12808;
    /// <inheritdoc/>
    public override string LocalName => "artisticLineDrawing";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "pencilSize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> pencilSize.</para>
    /// <para>Represents the following attribute in the schema: pencilSize </para>
    /// </summary>
    [SchemaAttr(0, "pencilSize")]
    public Int32Value PencilSize
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticLineDrawing class.
    /// </summary>
    public ArtisticLineDrawing():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticLineDrawing>(deep);

}
/// <summary>
/// <para>Defines the ArtisticMarker Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticMarker.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticMarker : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12809;
    /// <inheritdoc/>
    public override string LocalName => "artisticMarker";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "size")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public Int32Value Size
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticMarker class.
    /// </summary>
    public ArtisticMarker():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticMarker>(deep);

}
/// <summary>
/// <para>Defines the ArtisticMosaicBubbles Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticMosiaicBubbles.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticMosaicBubbles : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12810;
    /// <inheritdoc/>
    public override string LocalName => "artisticMosiaicBubbles";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "pressure")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> pressure.</para>
    /// <para>Represents the following attribute in the schema: pressure </para>
    /// </summary>
    [SchemaAttr(0, "pressure")]
    public Int32Value Pressure
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticMosaicBubbles class.
    /// </summary>
    public ArtisticMosaicBubbles():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticMosaicBubbles>(deep);

}
/// <summary>
/// <para>Defines the ArtisticPaintStrokes Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticPaintStrokes.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticPaintStrokes : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12811;
    /// <inheritdoc/>
    public override string LocalName => "artisticPaintStrokes";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "intensity")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> intensity.</para>
    /// <para>Represents the following attribute in the schema: intensity </para>
    /// </summary>
    [SchemaAttr(0, "intensity")]
    public Int32Value Intensity
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticPaintStrokes class.
    /// </summary>
    public ArtisticPaintStrokes():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPaintStrokes>(deep);

}
/// <summary>
/// <para>Defines the ArtisticPaintBrush Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticPaintBrush.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticPaintBrush : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12812;
    /// <inheritdoc/>
    public override string LocalName => "artisticPaintBrush";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "brushSize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> brushSize.</para>
    /// <para>Represents the following attribute in the schema: brushSize </para>
    /// </summary>
    [SchemaAttr(0, "brushSize")]
    public Int32Value BrushSize
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticPaintBrush class.
    /// </summary>
    public ArtisticPaintBrush():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPaintBrush>(deep);

}
/// <summary>
/// <para>Defines the ArtisticPastelsSmooth Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticPastelsSmooth.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticPastelsSmooth : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12813;
    /// <inheritdoc/>
    public override string LocalName => "artisticPastelsSmooth";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "scaling")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> scaling.</para>
    /// <para>Represents the following attribute in the schema: scaling </para>
    /// </summary>
    [SchemaAttr(0, "scaling")]
    public Int32Value BrushSize
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticPastelsSmooth class.
    /// </summary>
    public ArtisticPastelsSmooth():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPastelsSmooth>(deep);

}
/// <summary>
/// <para>Defines the ArtisticPencilGrayscale Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticPencilGrayscale.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticPencilGrayscale : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12814;
    /// <inheritdoc/>
    public override string LocalName => "artisticPencilGrayscale";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "pencilSize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> pencilSize.</para>
    /// <para>Represents the following attribute in the schema: pencilSize </para>
    /// </summary>
    [SchemaAttr(0, "pencilSize")]
    public Int32Value BrushSize
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticPencilGrayscale class.
    /// </summary>
    public ArtisticPencilGrayscale():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPencilGrayscale>(deep);

}
/// <summary>
/// <para>Defines the ArtisticPencilSketch Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticPencilSketch.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticPencilSketch : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12815;
    /// <inheritdoc/>
    public override string LocalName => "artisticPencilSketch";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "pressure")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> pressure.</para>
    /// <para>Represents the following attribute in the schema: pressure </para>
    /// </summary>
    [SchemaAttr(0, "pressure")]
    public Int32Value Pressure
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticPencilSketch class.
    /// </summary>
    public ArtisticPencilSketch():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPencilSketch>(deep);

}
/// <summary>
/// <para>Defines the ArtisticPhotocopy Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticPhotocopy.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticPhotocopy : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12816;
    /// <inheritdoc/>
    public override string LocalName => "artisticPhotocopy";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "detail")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> detail.</para>
    /// <para>Represents the following attribute in the schema: detail </para>
    /// </summary>
    [SchemaAttr(0, "detail")]
    public Int32Value Detail
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticPhotocopy class.
    /// </summary>
    public ArtisticPhotocopy():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPhotocopy>(deep);

}
/// <summary>
/// <para>Defines the ArtisticPlasticWrap Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticPlasticWrap.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticPlasticWrap : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12817;
    /// <inheritdoc/>
    public override string LocalName => "artisticPlasticWrap";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "smoothness")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> smoothness.</para>
    /// <para>Represents the following attribute in the schema: smoothness </para>
    /// </summary>
    [SchemaAttr(0, "smoothness")]
    public Int32Value Smoothness
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticPlasticWrap class.
    /// </summary>
    public ArtisticPlasticWrap():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPlasticWrap>(deep);

}
/// <summary>
/// <para>Defines the ArtisticTexturizer Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticTexturizer.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticTexturizer : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12818;
    /// <inheritdoc/>
    public override string LocalName => "artisticTexturizer";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "scaling")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> scaling.</para>
    /// <para>Represents the following attribute in the schema: scaling </para>
    /// </summary>
    [SchemaAttr(0, "scaling")]
    public Int32Value Scaling
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticTexturizer class.
    /// </summary>
    public ArtisticTexturizer():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticTexturizer>(deep);

}
/// <summary>
/// <para>Defines the ArtisticWatercolorSponge Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:artisticWatercolorSponge.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArtisticWatercolorSponge : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12819;
    /// <inheritdoc/>
    public override string LocalName => "artisticWatercolorSponge";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "trans"),
		AttributeTag.Create<Int32Value>(0, "brushSize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    public Int32Value Transparancy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> brushSize.</para>
    /// <para>Represents the following attribute in the schema: brushSize </para>
    /// </summary>
    [SchemaAttr(0, "brushSize")]
    public Int32Value BrushSize
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArtisticWatercolorSponge class.
    /// </summary>
    public ArtisticWatercolorSponge():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticWatercolorSponge>(deep);

}
/// <summary>
/// <para>Defines the BackgroundRemoval Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:backgroundRemoval.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ForegroundMark &lt;a14:foregroundMark></description></item>
///<item><description>BackgroundMark &lt;a14:backgroundMark></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ForegroundMark), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackgroundMark), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackgroundRemoval : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12820;
    /// <inheritdoc/>
    public override string LocalName => "backgroundRemoval";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "t"),
		AttributeTag.Create<Int32Value>(0, "b"),
		AttributeTag.Create<Int32Value>(0, "l"),
		AttributeTag.Create<Int32Value>(0, "r")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    public Int32Value MarqueeTop
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> b.</para>
    /// <para>Represents the following attribute in the schema: b </para>
    /// </summary>
    [SchemaAttr(0, "b")]
    public Int32Value MarqueeBottom
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> l.</para>
    /// <para>Represents the following attribute in the schema: l </para>
    /// </summary>
    [SchemaAttr(0, "l")]
    public Int32Value MarqueeLeft
    {
        get { return (Int32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    public Int32Value MarqueeRight
    {
        get { return (Int32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackgroundRemoval class.
    /// </summary>
    public BackgroundRemoval():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BackgroundRemoval class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackgroundRemoval(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackgroundRemoval class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackgroundRemoval(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackgroundRemoval class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackgroundRemoval(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 48 == namespaceId && "foregroundMark" == name)
    return new ForegroundMark();
    
if( 48 == namespaceId && "backgroundMark" == name)
    return new BackgroundMark();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundRemoval>(deep);

}
/// <summary>
/// <para>Defines the BrightnessContrast Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:brightnessContrast.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BrightnessContrast : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12821;
    /// <inheritdoc/>
    public override string LocalName => "brightnessContrast";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "bright"),
		AttributeTag.Create<Int32Value>(0, "contrast")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> bright.</para>
    /// <para>Represents the following attribute in the schema: bright </para>
    /// </summary>
    [SchemaAttr(0, "bright")]
    public Int32Value Bright
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> contrast.</para>
    /// <para>Represents the following attribute in the schema: contrast </para>
    /// </summary>
    [SchemaAttr(0, "contrast")]
    public Int32Value Contrast
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BrightnessContrast class.
    /// </summary>
    public BrightnessContrast():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BrightnessContrast>(deep);

}
/// <summary>
/// <para>Defines the ColorTemperature Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:colorTemperature.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ColorTemperature : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12822;
    /// <inheritdoc/>
    public override string LocalName => "colorTemperature";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "colorTemp")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> colorTemp.</para>
    /// <para>Represents the following attribute in the schema: colorTemp </para>
    /// </summary>
    [SchemaAttr(0, "colorTemp")]
    public Int32Value ColorTemperatureValue
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ColorTemperature class.
    /// </summary>
    public ColorTemperature():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTemperature>(deep);

}
/// <summary>
/// <para>Defines the Saturation Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:saturation.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Saturation : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12823;
    /// <inheritdoc/>
    public override string LocalName => "saturation";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "sat")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> sat.</para>
    /// <para>Represents the following attribute in the schema: sat </para>
    /// </summary>
    [SchemaAttr(0, "sat")]
    public Int32Value SaturationAmount
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Saturation class.
    /// </summary>
    public Saturation():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Saturation>(deep);

}
/// <summary>
/// <para>Defines the SharpenSoften Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:sharpenSoften.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SharpenSoften : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12824;
    /// <inheritdoc/>
    public override string LocalName => "sharpenSoften";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "amount")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> amount.</para>
    /// <para>Represents the following attribute in the schema: amount </para>
    /// </summary>
    [SchemaAttr(0, "amount")]
    public Int32Value Amount
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SharpenSoften class.
    /// </summary>
    public SharpenSoften():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharpenSoften>(deep);

}
/// <summary>
/// <para>Defines the ImageEffect Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:imgEffect.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArtisticBlur &lt;a14:artisticBlur></description></item>
///<item><description>ArtisticCement &lt;a14:artisticCement></description></item>
///<item><description>ArtisticChalkSketch &lt;a14:artisticChalkSketch></description></item>
///<item><description>ArtisticCrisscrossEtching &lt;a14:artisticCrisscrossEtching></description></item>
///<item><description>ArtisticCutout &lt;a14:artisticCutout></description></item>
///<item><description>ArtisticFilmGrain &lt;a14:artisticFilmGrain></description></item>
///<item><description>ArtisticGlass &lt;a14:artisticGlass></description></item>
///<item><description>ArtisticGlowDiffused &lt;a14:artisticGlowDiffused></description></item>
///<item><description>ArtisticGlowEdges &lt;a14:artisticGlowEdges></description></item>
///<item><description>ArtisticLightScreen &lt;a14:artisticLightScreen></description></item>
///<item><description>ArtisticLineDrawing &lt;a14:artisticLineDrawing></description></item>
///<item><description>ArtisticMarker &lt;a14:artisticMarker></description></item>
///<item><description>ArtisticMosaicBubbles &lt;a14:artisticMosiaicBubbles></description></item>
///<item><description>ArtisticPaintStrokes &lt;a14:artisticPaintStrokes></description></item>
///<item><description>ArtisticPaintBrush &lt;a14:artisticPaintBrush></description></item>
///<item><description>ArtisticPastelsSmooth &lt;a14:artisticPastelsSmooth></description></item>
///<item><description>ArtisticPencilGrayscale &lt;a14:artisticPencilGrayscale></description></item>
///<item><description>ArtisticPencilSketch &lt;a14:artisticPencilSketch></description></item>
///<item><description>ArtisticPhotocopy &lt;a14:artisticPhotocopy></description></item>
///<item><description>ArtisticPlasticWrap &lt;a14:artisticPlasticWrap></description></item>
///<item><description>ArtisticTexturizer &lt;a14:artisticTexturizer></description></item>
///<item><description>ArtisticWatercolorSponge &lt;a14:artisticWatercolorSponge></description></item>
///<item><description>BackgroundRemoval &lt;a14:backgroundRemoval></description></item>
///<item><description>BrightnessContrast &lt;a14:brightnessContrast></description></item>
///<item><description>ColorTemperature &lt;a14:colorTemperature></description></item>
///<item><description>Saturation &lt;a14:saturation></description></item>
///<item><description>SharpenSoften &lt;a14:sharpenSoften></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ArtisticBlur), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticCement), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticChalkSketch), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticCrisscrossEtching), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticCutout), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticFilmGrain), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticGlass), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticGlowDiffused), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticGlowEdges), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticLightScreen), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticLineDrawing), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticMarker), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticMosaicBubbles), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticPaintStrokes), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticPaintBrush), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticPastelsSmooth), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticPencilGrayscale), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticPencilSketch), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticPhotocopy), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticPlasticWrap), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticTexturizer), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ArtisticWatercolorSponge), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackgroundRemoval), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BrightnessContrast), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ColorTemperature), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Saturation), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SharpenSoften), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ImageEffect : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12825;
    /// <inheritdoc/>
    public override string LocalName => "imgEffect";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "visible")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ImageEffect class.
    /// </summary>
    public ImageEffect():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ImageEffect class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ImageEffect(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ImageEffect class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ImageEffect(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ImageEffect class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ImageEffect(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 48 == namespaceId && "artisticBlur" == name)
    return new ArtisticBlur();
    
if( 48 == namespaceId && "artisticCement" == name)
    return new ArtisticCement();
    
if( 48 == namespaceId && "artisticChalkSketch" == name)
    return new ArtisticChalkSketch();
    
if( 48 == namespaceId && "artisticCrisscrossEtching" == name)
    return new ArtisticCrisscrossEtching();
    
if( 48 == namespaceId && "artisticCutout" == name)
    return new ArtisticCutout();
    
if( 48 == namespaceId && "artisticFilmGrain" == name)
    return new ArtisticFilmGrain();
    
if( 48 == namespaceId && "artisticGlass" == name)
    return new ArtisticGlass();
    
if( 48 == namespaceId && "artisticGlowDiffused" == name)
    return new ArtisticGlowDiffused();
    
if( 48 == namespaceId && "artisticGlowEdges" == name)
    return new ArtisticGlowEdges();
    
if( 48 == namespaceId && "artisticLightScreen" == name)
    return new ArtisticLightScreen();
    
if( 48 == namespaceId && "artisticLineDrawing" == name)
    return new ArtisticLineDrawing();
    
if( 48 == namespaceId && "artisticMarker" == name)
    return new ArtisticMarker();
    
if( 48 == namespaceId && "artisticMosiaicBubbles" == name)
    return new ArtisticMosaicBubbles();
    
if( 48 == namespaceId && "artisticPaintStrokes" == name)
    return new ArtisticPaintStrokes();
    
if( 48 == namespaceId && "artisticPaintBrush" == name)
    return new ArtisticPaintBrush();
    
if( 48 == namespaceId && "artisticPastelsSmooth" == name)
    return new ArtisticPastelsSmooth();
    
if( 48 == namespaceId && "artisticPencilGrayscale" == name)
    return new ArtisticPencilGrayscale();
    
if( 48 == namespaceId && "artisticPencilSketch" == name)
    return new ArtisticPencilSketch();
    
if( 48 == namespaceId && "artisticPhotocopy" == name)
    return new ArtisticPhotocopy();
    
if( 48 == namespaceId && "artisticPlasticWrap" == name)
    return new ArtisticPlasticWrap();
    
if( 48 == namespaceId && "artisticTexturizer" == name)
    return new ArtisticTexturizer();
    
if( 48 == namespaceId && "artisticWatercolorSponge" == name)
    return new ArtisticWatercolorSponge();
    
if( 48 == namespaceId && "backgroundRemoval" == name)
    return new BackgroundRemoval();
    
if( 48 == namespaceId && "brightnessContrast" == name)
    return new BrightnessContrast();
    
if( 48 == namespaceId && "colorTemperature" == name)
    return new ColorTemperature();
    
if( 48 == namespaceId && "saturation" == name)
    return new Saturation();
    
if( 48 == namespaceId && "sharpenSoften" == name)
    return new SharpenSoften();
    

    return null;
}

        private static readonly string[] eleTagNames = { "artisticBlur","artisticCement","artisticChalkSketch","artisticCrisscrossEtching","artisticCutout","artisticFilmGrain","artisticGlass","artisticGlowDiffused","artisticGlowEdges","artisticLightScreen","artisticLineDrawing","artisticMarker","artisticMosiaicBubbles","artisticPaintStrokes","artisticPaintBrush","artisticPastelsSmooth","artisticPencilGrayscale","artisticPencilSketch","artisticPhotocopy","artisticPlasticWrap","artisticTexturizer","artisticWatercolorSponge","backgroundRemoval","brightnessContrast","colorTemperature","saturation","sharpenSoften" };
    private static readonly byte[] eleNamespaceIds = { 48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48,48 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> ArtisticBlur.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticBlur </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticBlur ArtisticBlur
    {
        get => GetElement<ArtisticBlur>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ArtisticCement.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticCement </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticCement ArtisticCement
    {
        get => GetElement<ArtisticCement>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ArtisticChalkSketch.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticChalkSketch </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticChalkSketch ArtisticChalkSketch
    {
        get => GetElement<ArtisticChalkSketch>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ArtisticCrisscrossEtching.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticCrisscrossEtching </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticCrisscrossEtching ArtisticCrisscrossEtching
    {
        get => GetElement<ArtisticCrisscrossEtching>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> ArtisticCutout.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticCutout </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticCutout ArtisticCutout
    {
        get => GetElement<ArtisticCutout>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> ArtisticFilmGrain.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticFilmGrain </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticFilmGrain ArtisticFilmGrain
    {
        get => GetElement<ArtisticFilmGrain>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> ArtisticGlass.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticGlass </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticGlass ArtisticGlass
    {
        get => GetElement<ArtisticGlass>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> ArtisticGlowDiffused.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticGlowDiffused </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticGlowDiffused ArtisticGlowDiffused
    {
        get => GetElement<ArtisticGlowDiffused>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> ArtisticGlowEdges.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticGlowEdges </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticGlowEdges ArtisticGlowEdges
    {
        get => GetElement<ArtisticGlowEdges>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> ArtisticLightScreen.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticLightScreen </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticLightScreen ArtisticLightScreen
    {
        get => GetElement<ArtisticLightScreen>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> ArtisticLineDrawing.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticLineDrawing </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticLineDrawing ArtisticLineDrawing
    {
        get => GetElement<ArtisticLineDrawing>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> ArtisticMarker.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticMarker </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticMarker ArtisticMarker
    {
        get => GetElement<ArtisticMarker>(11);
        set => SetElement(11, value);
    }
    /// <summary>
    /// <para> ArtisticMosaicBubbles.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticMosiaicBubbles </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticMosaicBubbles ArtisticMosaicBubbles
    {
        get => GetElement<ArtisticMosaicBubbles>(12);
        set => SetElement(12, value);
    }
    /// <summary>
    /// <para> ArtisticPaintStrokes.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticPaintStrokes </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticPaintStrokes ArtisticPaintStrokes
    {
        get => GetElement<ArtisticPaintStrokes>(13);
        set => SetElement(13, value);
    }
    /// <summary>
    /// <para> ArtisticPaintBrush.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticPaintBrush </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticPaintBrush ArtisticPaintBrush
    {
        get => GetElement<ArtisticPaintBrush>(14);
        set => SetElement(14, value);
    }
    /// <summary>
    /// <para> ArtisticPastelsSmooth.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticPastelsSmooth </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticPastelsSmooth ArtisticPastelsSmooth
    {
        get => GetElement<ArtisticPastelsSmooth>(15);
        set => SetElement(15, value);
    }
    /// <summary>
    /// <para> ArtisticPencilGrayscale.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticPencilGrayscale </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticPencilGrayscale ArtisticPencilGrayscale
    {
        get => GetElement<ArtisticPencilGrayscale>(16);
        set => SetElement(16, value);
    }
    /// <summary>
    /// <para> ArtisticPencilSketch.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticPencilSketch </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticPencilSketch ArtisticPencilSketch
    {
        get => GetElement<ArtisticPencilSketch>(17);
        set => SetElement(17, value);
    }
    /// <summary>
    /// <para> ArtisticPhotocopy.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticPhotocopy </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticPhotocopy ArtisticPhotocopy
    {
        get => GetElement<ArtisticPhotocopy>(18);
        set => SetElement(18, value);
    }
    /// <summary>
    /// <para> ArtisticPlasticWrap.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticPlasticWrap </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticPlasticWrap ArtisticPlasticWrap
    {
        get => GetElement<ArtisticPlasticWrap>(19);
        set => SetElement(19, value);
    }
    /// <summary>
    /// <para> ArtisticTexturizer.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticTexturizer </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticTexturizer ArtisticTexturizer
    {
        get => GetElement<ArtisticTexturizer>(20);
        set => SetElement(20, value);
    }
    /// <summary>
    /// <para> ArtisticWatercolorSponge.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticWatercolorSponge </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ArtisticWatercolorSponge ArtisticWatercolorSponge
    {
        get => GetElement<ArtisticWatercolorSponge>(21);
        set => SetElement(21, value);
    }
    /// <summary>
    /// <para> BackgroundRemoval.</para>
    /// <para> Represents the following element tag in the schema: a14:backgroundRemoval </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public BackgroundRemoval BackgroundRemoval
    {
        get => GetElement<BackgroundRemoval>(22);
        set => SetElement(22, value);
    }
    /// <summary>
    /// <para> BrightnessContrast.</para>
    /// <para> Represents the following element tag in the schema: a14:brightnessContrast </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public BrightnessContrast BrightnessContrast
    {
        get => GetElement<BrightnessContrast>(23);
        set => SetElement(23, value);
    }
    /// <summary>
    /// <para> ColorTemperature.</para>
    /// <para> Represents the following element tag in the schema: a14:colorTemperature </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ColorTemperature ColorTemperature
    {
        get => GetElement<ColorTemperature>(24);
        set => SetElement(24, value);
    }
    /// <summary>
    /// <para> Saturation.</para>
    /// <para> Represents the following element tag in the schema: a14:saturation </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public Saturation Saturation
    {
        get => GetElement<Saturation>(25);
        set => SetElement(25, value);
    }
    /// <summary>
    /// <para> SharpenSoften.</para>
    /// <para> Represents the following element tag in the schema: a14:sharpenSoften </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public SharpenSoften SharpenSoften
    {
        get => GetElement<SharpenSoften>(26);
        set => SetElement(26, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageEffect>(deep);

}
/// <summary>
/// <para>Defines the ImageLayer Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:imgLayer.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ImageEffect &lt;a14:imgEffect></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ImageEffect), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ImageLayer : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12826;
    /// <inheritdoc/>
    public override string LocalName => "imgLayer";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(19, "embed")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> embed.</para>
    /// <para>Represents the following attribute in the schema: r:embed </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "embed")]
    public StringValue Embed
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ImageLayer class.
    /// </summary>
    public ImageLayer():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ImageLayer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ImageLayer(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ImageLayer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ImageLayer(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ImageLayer class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ImageLayer(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 48 == namespaceId && "imgEffect" == name)
    return new ImageEffect();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageLayer>(deep);

}
/// <summary>
/// <para>Defines the NonVisualDrawingProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:cNvPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnHover &lt;a:hlinkHover></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12827;
    /// <inheritdoc/>
    public override string LocalName => "cNvPr";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "id"),
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<StringValue>(0, "descr"),
		AttributeTag.Create<BooleanValue>(0, "hidden"),
		AttributeTag.Create<StringValue>(0, "title")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public UInt32Value Id
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> descr.</para>
    /// <para>Represents the following attribute in the schema: descr </para>
    /// </summary>
    [SchemaAttr(0, "descr")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    public BooleanValue Hidden
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class.
    /// </summary>
    public NonVisualDrawingProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualDrawingProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualDrawingProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "hlinkClick" == name)
    return new DocumentFormat.OpenXml.Drawing.HyperlinkOnClick();
    
if( 10 == namespaceId && "hlinkHover" == name)
    return new DocumentFormat.OpenXml.Drawing.HyperlinkOnHover();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "hlinkClick","hlinkHover","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> HyperlinkOnClick.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkClick </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick HyperlinkOnClick
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> HyperlinkOnHover.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkHover </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover HyperlinkOnHover
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> NonVisualDrawingPropertiesExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList NonVisualDrawingPropertiesExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);

}
/// <summary>
/// <para>Defines the NonVisualInkContentPartProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:cNvContentPartPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ContentPartLocks &lt;a14:cpLocks></description></item>
///<item><description>OfficeArtExtensionList &lt;a14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ContentPartLocks), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NonVisualInkContentPartProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12828;
    /// <inheritdoc/>
    public override string LocalName => "cNvContentPartPr";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "isComment")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> isComment.</para>
    /// <para>Represents the following attribute in the schema: isComment </para>
    /// </summary>
    [SchemaAttr(0, "isComment")]
    public BooleanValue IsComment
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class.
    /// </summary>
    public NonVisualInkContentPartProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualInkContentPartProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualInkContentPartProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualInkContentPartProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 48 == namespaceId && "cpLocks" == name)
    return new ContentPartLocks();
    
if( 48 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cpLocks","extLst" };
    private static readonly byte[] eleNamespaceIds = { 48,48 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ContentPartLocks.</para>
    /// <para> Represents the following element tag in the schema: a14:cpLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public ContentPartLocks ContentPartLocks
    {
        get => GetElement<ContentPartLocks>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<OfficeArtExtensionList>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualInkContentPartProperties>(deep);

}
/// <summary>
/// <para>Defines the NonVisualContentPartProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:nvContentPartPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;a14:cNvPr></description></item>
///<item><description>NonVisualInkContentPartProperties &lt;a14:cNvContentPartPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NonVisualInkContentPartProperties), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NonVisualContentPartProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12829;
    /// <inheritdoc/>
    public override string LocalName => "nvContentPartPr";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualContentPartProperties class.
    /// </summary>
    public NonVisualContentPartProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualContentPartProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualContentPartProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualContentPartProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualContentPartProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 48 == namespaceId && "cNvPr" == name)
    return new NonVisualDrawingProperties();
    
if( 48 == namespaceId && "cNvContentPartPr" == name)
    return new NonVisualInkContentPartProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvContentPartPr" };
    private static readonly byte[] eleNamespaceIds = { 48,48 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: a14:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> NonVisualInkContentPartProperties.</para>
    /// <para> Represents the following element tag in the schema: a14:cNvContentPartPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
    public NonVisualInkContentPartProperties NonVisualInkContentPartProperties
    {
        get => GetElement<NonVisualInkContentPartProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualContentPartProperties>(deep);

}
/// <summary>
/// <para>Defines the Transform2D Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:xfrm.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Offset &lt;a:off></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Extents &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Offset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extents))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Transform2D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12830;
    /// <inheritdoc/>
    public override string LocalName => "xfrm";
    
    internal override byte NamespaceId => 48;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "rot"),
		AttributeTag.Create<BooleanValue>(0, "flipH"),
		AttributeTag.Create<BooleanValue>(0, "flipV")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Rotation.</para>
    /// <para>Represents the following attribute in the schema: rot </para>
    /// </summary>
    [SchemaAttr(0, "rot")]
    public Int32Value Rotation
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Horizontal Flip.</para>
    /// <para>Represents the following attribute in the schema: flipH </para>
    /// </summary>
    [SchemaAttr(0, "flipH")]
    public BooleanValue HorizontalFlip
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Vertical Flip.</para>
    /// <para>Represents the following attribute in the schema: flipV </para>
    /// </summary>
    [SchemaAttr(0, "flipV")]
    public BooleanValue VerticalFlip
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Transform2D class.
    /// </summary>
    public Transform2D():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Transform2D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Transform2D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Transform2D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Transform2D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Transform2D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Transform2D(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "off" == name)
    return new DocumentFormat.OpenXml.Drawing.Offset();
    
if( 10 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Drawing.Extents();
    

    return null;
}

        private static readonly string[] eleTagNames = { "off","ext" };
    private static readonly byte[] eleNamespaceIds = { 10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Offset.</para>
    /// <para> Represents the following element tag in the schema: a:off </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Offset Offset
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Extents.</para>
    /// <para> Represents the following element tag in the schema: a:ext </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Extents Extents
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);

}
}
 
 
