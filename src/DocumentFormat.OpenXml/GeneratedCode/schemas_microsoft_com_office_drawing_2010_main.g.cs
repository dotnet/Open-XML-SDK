// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "cameraTool")]
[Id(ElementTypeIdConst)]
public partial class CameraTool : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12781;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> cellRange.</para>
    /// <para>Represents the following attribute in the schema: cellRange </para>
    /// </summary>
    [SchemaAttr(0, "cellRange")]
    [Index(0)]
    public StringValue CellRange { get; set; }
	
    /// <summary>
    /// <para> spid.</para>
    /// <para>Represents the following attribute in the schema: spid </para>
    /// </summary>
    [SchemaAttr(0, "spid")]
    [Index(1)]
    public StringValue ShapeId { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "compatExt")]
[Id(ElementTypeIdConst)]
public partial class CompatExtension : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12782;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> spid.</para>
    /// <para>Represents the following attribute in the schema: spid </para>
    /// </summary>
    [SchemaAttr(0, "spid")]
    [Index(0)]
    public StringValue ShapeId { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "isCanvas")]
[Id(ElementTypeIdConst)]
public partial class IsCanvas : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12783;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "contentPart")]
[Id(ElementTypeIdConst)]
public partial class GvmlContentPart : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12784;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> bwMode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }
	
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [Index(1)]
    public StringValue RelationshipId { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualContentPartProperties.</para>
    /// <para> Represents the following element tag in the schema: a14:nvContentPartPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "shadowObscured")]
[Id(ElementTypeIdConst)]
public partial class ShadowObscured : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12785;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "hiddenFill")]
[Id(ElementTypeIdConst)]
public partial class HiddenFillProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12786;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> NoFill.</para>
    /// <para> Represents the following element tag in the schema: a:noFill </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "hiddenLine")]
[Id(ElementTypeIdConst)]
public partial class HiddenLineProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12787;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Line Width.</para>
    /// <para>Represents the following attribute in the schema: w </para>
    /// </summary>
    [SchemaAttr(0, "w")]
    [Index(0)]
    public Int32Value Width { get; set; }
	
    /// <summary>
    /// <para> Line Ending Cap Type.</para>
    /// <para>Represents the following attribute in the schema: cap </para>
    /// </summary>
    [SchemaAttr(0, "cap")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues> CapType { get; set; }
	
    /// <summary>
    /// <para> Compound Line Type.</para>
    /// <para>Represents the following attribute in the schema: cmpd </para>
    /// </summary>
    [SchemaAttr(0, "cmpd")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues> CompoundLineType { get; set; }
	
    /// <summary>
    /// <para> Stroke Alignment.</para>
    /// <para>Represents the following attribute in the schema: algn </para>
    /// </summary>
    [SchemaAttr(0, "algn")]
    [Index(3)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues> Alignment { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "hiddenEffects")]
[Id(ElementTypeIdConst)]
public partial class HiddenEffectsProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12788;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Effect Container.</para>
    /// <para> Represents the following element tag in the schema: a:effectLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "hiddenScene3d")]
[Id(ElementTypeIdConst)]
public partial class HiddenScene3D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12789;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Camera.</para>
    /// <para> Represents the following element tag in the schema: a:camera </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "hiddenSp3d")]
[Id(ElementTypeIdConst)]
public partial class HiddenShape3D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12790;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Shape Depth.</para>
    /// <para>Represents the following attribute in the schema: z </para>
    /// </summary>
    [SchemaAttr(0, "z")]
    [Index(0)]
    public Int64Value Z { get; set; }
	
    /// <summary>
    /// <para> Extrusion Height.</para>
    /// <para>Represents the following attribute in the schema: extrusionH </para>
    /// </summary>
    [SchemaAttr(0, "extrusionH")]
    [Index(1)]
    public Int64Value ExtrusionHeight { get; set; }
	
    /// <summary>
    /// <para> Contour Width.</para>
    /// <para>Represents the following attribute in the schema: contourW </para>
    /// </summary>
    [SchemaAttr(0, "contourW")]
    [Index(2)]
    public Int64Value ContourWidth { get; set; }
	
    /// <summary>
    /// <para> Preset Material Type.</para>
    /// <para>Represents the following attribute in the schema: prstMaterial </para>
    /// </summary>
    [SchemaAttr(0, "prstMaterial")]
    [Index(3)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues> PresetMaterial { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Top Bevel.</para>
    /// <para> Represents the following element tag in the schema: a:bevelT </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "imgProps")]
[Id(ElementTypeIdConst)]
public partial class ImageProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12791;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ImageLayer.</para>
    /// <para> Represents the following element tag in the schema: a14:imgLayer </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
	[Index(0)]
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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "useLocalDpi")]
[Id(ElementTypeIdConst)]
public partial class UseLocalDpi : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12792;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "m")]
[Id(ElementTypeIdConst)]
public partial class TextMath : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12793;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "extLst")]
[Id(ElementTypeIdConst)]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12794;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "cpLocks")]
[Id(ElementTypeIdConst)]
public partial class ContentPartLocks : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12795;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Disallow Shape Grouping.</para>
    /// <para>Represents the following attribute in the schema: noGrp </para>
    /// </summary>
    [SchemaAttr(0, "noGrp")]
    [Index(0)]
    public BooleanValue NoGrouping { get; set; }
	
    /// <summary>
    /// <para> Disallow Shape Selection.</para>
    /// <para>Represents the following attribute in the schema: noSelect </para>
    /// </summary>
    [SchemaAttr(0, "noSelect")]
    [Index(1)]
    public BooleanValue NoSelection { get; set; }
	
    /// <summary>
    /// <para> Disallow Shape Rotation.</para>
    /// <para>Represents the following attribute in the schema: noRot </para>
    /// </summary>
    [SchemaAttr(0, "noRot")]
    [Index(2)]
    public BooleanValue NoRotation { get; set; }
	
    /// <summary>
    /// <para> Disallow Aspect Ratio Change.</para>
    /// <para>Represents the following attribute in the schema: noChangeAspect </para>
    /// </summary>
    [SchemaAttr(0, "noChangeAspect")]
    [Index(3)]
    public BooleanValue NoChangeAspect { get; set; }
	
    /// <summary>
    /// <para> Disallow Shape Movement.</para>
    /// <para>Represents the following attribute in the schema: noMove </para>
    /// </summary>
    [SchemaAttr(0, "noMove")]
    [Index(4)]
    public BooleanValue NoMove { get; set; }
	
    /// <summary>
    /// <para> Disallow Shape Resize.</para>
    /// <para>Represents the following attribute in the schema: noResize </para>
    /// </summary>
    [SchemaAttr(0, "noResize")]
    [Index(5)]
    public BooleanValue NoResize { get; set; }
	
    /// <summary>
    /// <para> Disallow Shape Point Editing.</para>
    /// <para>Represents the following attribute in the schema: noEditPoints </para>
    /// </summary>
    [SchemaAttr(0, "noEditPoints")]
    [Index(6)]
    public BooleanValue NoEditPoints { get; set; }
	
    /// <summary>
    /// <para> Disallow Showing Adjust Handles.</para>
    /// <para>Represents the following attribute in the schema: noAdjustHandles </para>
    /// </summary>
    [SchemaAttr(0, "noAdjustHandles")]
    [Index(7)]
    public BooleanValue NoAdjustHandles { get; set; }
	
    /// <summary>
    /// <para> Disallow Arrowhead Changes.</para>
    /// <para>Represents the following attribute in the schema: noChangeArrowheads </para>
    /// </summary>
    [SchemaAttr(0, "noChangeArrowheads")]
    [Index(8)]
    public BooleanValue NoChangeArrowheads { get; set; }
	
    /// <summary>
    /// <para> Disallow Shape Type Change.</para>
    /// <para>Represents the following attribute in the schema: noChangeShapeType </para>
    /// </summary>
    [SchemaAttr(0, "noChangeShapeType")]
    [Index(9)]
    public BooleanValue NoChangeShapeType { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
	[Index(0)]
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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "foregroundMark")]
[Id(ElementTypeIdConst)]
public partial class ForegroundMark : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12796;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> x1.</para>
    /// <para>Represents the following attribute in the schema: x1 </para>
    /// </summary>
    [SchemaAttr(0, "x1")]
    [Index(0)]
    public Int32Value FirstXCoordinate { get; set; }
	
    /// <summary>
    /// <para> y1.</para>
    /// <para>Represents the following attribute in the schema: y1 </para>
    /// </summary>
    [SchemaAttr(0, "y1")]
    [Index(1)]
    public Int32Value FirstYCoordinate { get; set; }
	
    /// <summary>
    /// <para> x2.</para>
    /// <para>Represents the following attribute in the schema: x2 </para>
    /// </summary>
    [SchemaAttr(0, "x2")]
    [Index(2)]
    public Int32Value SecondXCoordinate { get; set; }
	
    /// <summary>
    /// <para> y2.</para>
    /// <para>Represents the following attribute in the schema: y2 </para>
    /// </summary>
    [SchemaAttr(0, "y2")]
    [Index(3)]
    public Int32Value SecondYCoordinate { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "backgroundMark")]
[Id(ElementTypeIdConst)]
public partial class BackgroundMark : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12797;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> x1.</para>
    /// <para>Represents the following attribute in the schema: x1 </para>
    /// </summary>
    [SchemaAttr(0, "x1")]
    [Index(0)]
    public Int32Value FirstXCoordinate { get; set; }
	
    /// <summary>
    /// <para> y1.</para>
    /// <para>Represents the following attribute in the schema: y1 </para>
    /// </summary>
    [SchemaAttr(0, "y1")]
    [Index(1)]
    public Int32Value FirstYCoordinate { get; set; }
	
    /// <summary>
    /// <para> x2.</para>
    /// <para>Represents the following attribute in the schema: x2 </para>
    /// </summary>
    [SchemaAttr(0, "x2")]
    [Index(2)]
    public Int32Value SecondXCoordinate { get; set; }
	
    /// <summary>
    /// <para> y2.</para>
    /// <para>Represents the following attribute in the schema: y2 </para>
    /// </summary>
    [SchemaAttr(0, "y2")]
    [Index(3)]
    public Int32Value SecondYCoordinate { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticBlur")]
[Id(ElementTypeIdConst)]
public partial class ArtisticBlur : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12798;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> radius.</para>
    /// <para>Represents the following attribute in the schema: radius </para>
    /// </summary>
    [SchemaAttr(0, "radius")]
    [Index(0)]
    public Int32Value Radius { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticCement")]
[Id(ElementTypeIdConst)]
public partial class ArtisticCement : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12799;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> crackSpacing.</para>
    /// <para>Represents the following attribute in the schema: crackSpacing </para>
    /// </summary>
    [SchemaAttr(0, "crackSpacing")]
    [Index(1)]
    public Int32Value CrackSpacing { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticChalkSketch")]
[Id(ElementTypeIdConst)]
public partial class ArtisticChalkSketch : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12800;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> pressure.</para>
    /// <para>Represents the following attribute in the schema: pressure </para>
    /// </summary>
    [SchemaAttr(0, "pressure")]
    [Index(1)]
    public Int32Value Pressure { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticCrisscrossEtching")]
[Id(ElementTypeIdConst)]
public partial class ArtisticCrisscrossEtching : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12801;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> pressure.</para>
    /// <para>Represents the following attribute in the schema: pressure </para>
    /// </summary>
    [SchemaAttr(0, "pressure")]
    [Index(1)]
    public Int32Value Pressure { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticCutout")]
[Id(ElementTypeIdConst)]
public partial class ArtisticCutout : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12802;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> numberOfShades.</para>
    /// <para>Represents the following attribute in the schema: numberOfShades </para>
    /// </summary>
    [SchemaAttr(0, "numberOfShades")]
    [Index(1)]
    public Int32Value NumberOfShades { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticFilmGrain")]
[Id(ElementTypeIdConst)]
public partial class ArtisticFilmGrain : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12803;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> grainSize.</para>
    /// <para>Represents the following attribute in the schema: grainSize </para>
    /// </summary>
    [SchemaAttr(0, "grainSize")]
    [Index(1)]
    public Int32Value GrainSize { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticGlass")]
[Id(ElementTypeIdConst)]
public partial class ArtisticGlass : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12804;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> scaling.</para>
    /// <para>Represents the following attribute in the schema: scaling </para>
    /// </summary>
    [SchemaAttr(0, "scaling")]
    [Index(1)]
    public Int32Value Scaling { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticGlowDiffused")]
[Id(ElementTypeIdConst)]
public partial class ArtisticGlowDiffused : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12805;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> intensity.</para>
    /// <para>Represents the following attribute in the schema: intensity </para>
    /// </summary>
    [SchemaAttr(0, "intensity")]
    [Index(1)]
    public Int32Value Intensity { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticGlowEdges")]
[Id(ElementTypeIdConst)]
public partial class ArtisticGlowEdges : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12806;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> smoothness.</para>
    /// <para>Represents the following attribute in the schema: smoothness </para>
    /// </summary>
    [SchemaAttr(0, "smoothness")]
    [Index(1)]
    public Int32Value Smoothness { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticLightScreen")]
[Id(ElementTypeIdConst)]
public partial class ArtisticLightScreen : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12807;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> gridSize.</para>
    /// <para>Represents the following attribute in the schema: gridSize </para>
    /// </summary>
    [SchemaAttr(0, "gridSize")]
    [Index(1)]
    public Int32Value GridSize { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticLineDrawing")]
[Id(ElementTypeIdConst)]
public partial class ArtisticLineDrawing : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12808;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> pencilSize.</para>
    /// <para>Represents the following attribute in the schema: pencilSize </para>
    /// </summary>
    [SchemaAttr(0, "pencilSize")]
    [Index(1)]
    public Int32Value PencilSize { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticMarker")]
[Id(ElementTypeIdConst)]
public partial class ArtisticMarker : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12809;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    [Index(1)]
    public Int32Value Size { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticMosiaicBubbles")]
[Id(ElementTypeIdConst)]
public partial class ArtisticMosaicBubbles : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12810;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> pressure.</para>
    /// <para>Represents the following attribute in the schema: pressure </para>
    /// </summary>
    [SchemaAttr(0, "pressure")]
    [Index(1)]
    public Int32Value Pressure { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticPaintStrokes")]
[Id(ElementTypeIdConst)]
public partial class ArtisticPaintStrokes : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12811;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> intensity.</para>
    /// <para>Represents the following attribute in the schema: intensity </para>
    /// </summary>
    [SchemaAttr(0, "intensity")]
    [Index(1)]
    public Int32Value Intensity { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticPaintBrush")]
[Id(ElementTypeIdConst)]
public partial class ArtisticPaintBrush : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12812;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> brushSize.</para>
    /// <para>Represents the following attribute in the schema: brushSize </para>
    /// </summary>
    [SchemaAttr(0, "brushSize")]
    [Index(1)]
    public Int32Value BrushSize { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticPastelsSmooth")]
[Id(ElementTypeIdConst)]
public partial class ArtisticPastelsSmooth : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12813;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> scaling.</para>
    /// <para>Represents the following attribute in the schema: scaling </para>
    /// </summary>
    [SchemaAttr(0, "scaling")]
    [Index(1)]
    public Int32Value BrushSize { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticPencilGrayscale")]
[Id(ElementTypeIdConst)]
public partial class ArtisticPencilGrayscale : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12814;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> pencilSize.</para>
    /// <para>Represents the following attribute in the schema: pencilSize </para>
    /// </summary>
    [SchemaAttr(0, "pencilSize")]
    [Index(1)]
    public Int32Value BrushSize { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticPencilSketch")]
[Id(ElementTypeIdConst)]
public partial class ArtisticPencilSketch : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12815;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> pressure.</para>
    /// <para>Represents the following attribute in the schema: pressure </para>
    /// </summary>
    [SchemaAttr(0, "pressure")]
    [Index(1)]
    public Int32Value Pressure { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticPhotocopy")]
[Id(ElementTypeIdConst)]
public partial class ArtisticPhotocopy : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12816;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> detail.</para>
    /// <para>Represents the following attribute in the schema: detail </para>
    /// </summary>
    [SchemaAttr(0, "detail")]
    [Index(1)]
    public Int32Value Detail { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticPlasticWrap")]
[Id(ElementTypeIdConst)]
public partial class ArtisticPlasticWrap : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12817;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> smoothness.</para>
    /// <para>Represents the following attribute in the schema: smoothness </para>
    /// </summary>
    [SchemaAttr(0, "smoothness")]
    [Index(1)]
    public Int32Value Smoothness { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticTexturizer")]
[Id(ElementTypeIdConst)]
public partial class ArtisticTexturizer : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12818;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> scaling.</para>
    /// <para>Represents the following attribute in the schema: scaling </para>
    /// </summary>
    [SchemaAttr(0, "scaling")]
    [Index(1)]
    public Int32Value Scaling { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "artisticWatercolorSponge")]
[Id(ElementTypeIdConst)]
public partial class ArtisticWatercolorSponge : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12819;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> trans.</para>
    /// <para>Represents the following attribute in the schema: trans </para>
    /// </summary>
    [SchemaAttr(0, "trans")]
    [Index(0)]
    public Int32Value Transparancy { get; set; }
	
    /// <summary>
    /// <para> brushSize.</para>
    /// <para>Represents the following attribute in the schema: brushSize </para>
    /// </summary>
    [SchemaAttr(0, "brushSize")]
    [Index(1)]
    public Int32Value BrushSize { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "backgroundRemoval")]
[Id(ElementTypeIdConst)]
public partial class BackgroundRemoval : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12820;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    [Index(0)]
    public Int32Value MarqueeTop { get; set; }
	
    /// <summary>
    /// <para> b.</para>
    /// <para>Represents the following attribute in the schema: b </para>
    /// </summary>
    [SchemaAttr(0, "b")]
    [Index(1)]
    public Int32Value MarqueeBottom { get; set; }
	
    /// <summary>
    /// <para> l.</para>
    /// <para>Represents the following attribute in the schema: l </para>
    /// </summary>
    [SchemaAttr(0, "l")]
    [Index(2)]
    public Int32Value MarqueeLeft { get; set; }
	
    /// <summary>
    /// <para> r.</para>
    /// <para>Represents the following attribute in the schema: r </para>
    /// </summary>
    [SchemaAttr(0, "r")]
    [Index(3)]
    public Int32Value MarqueeRight { get; set; }
	

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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundRemoval>(deep);

}
/// <summary>
/// <para>Defines the BrightnessContrast Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a14:brightnessContrast.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "brightnessContrast")]
[Id(ElementTypeIdConst)]
public partial class BrightnessContrast : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12821;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> bright.</para>
    /// <para>Represents the following attribute in the schema: bright </para>
    /// </summary>
    [SchemaAttr(0, "bright")]
    [Index(0)]
    public Int32Value Bright { get; set; }
	
    /// <summary>
    /// <para> contrast.</para>
    /// <para>Represents the following attribute in the schema: contrast </para>
    /// </summary>
    [SchemaAttr(0, "contrast")]
    [Index(1)]
    public Int32Value Contrast { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "colorTemperature")]
[Id(ElementTypeIdConst)]
public partial class ColorTemperature : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12822;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> colorTemp.</para>
    /// <para>Represents the following attribute in the schema: colorTemp </para>
    /// </summary>
    [SchemaAttr(0, "colorTemp")]
    [Index(0)]
    public Int32Value ColorTemperatureValue { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "saturation")]
[Id(ElementTypeIdConst)]
public partial class Saturation : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12823;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> sat.</para>
    /// <para>Represents the following attribute in the schema: sat </para>
    /// </summary>
    [SchemaAttr(0, "sat")]
    [Index(0)]
    public Int32Value SaturationAmount { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "sharpenSoften")]
[Id(ElementTypeIdConst)]
public partial class SharpenSoften : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12824;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> amount.</para>
    /// <para>Represents the following attribute in the schema: amount </para>
    /// </summary>
    [SchemaAttr(0, "amount")]
    [Index(0)]
    public Int32Value Amount { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "imgEffect")]
[Id(ElementTypeIdConst)]
public partial class ImageEffect : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12825;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    [Index(0)]
    public BooleanValue Visible { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> ArtisticBlur.</para>
    /// <para> Represents the following element tag in the schema: a14:artisticBlur </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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
	[Index(6)]
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
	[Index(7)]
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
	[Index(8)]
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
	[Index(9)]
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
	[Index(10)]
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
	[Index(11)]
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
	[Index(12)]
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
	[Index(13)]
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
	[Index(14)]
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
	[Index(15)]
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
	[Index(16)]
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
	[Index(17)]
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
	[Index(18)]
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
	[Index(19)]
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
	[Index(20)]
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
	[Index(21)]
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
	[Index(22)]
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
	[Index(23)]
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
	[Index(24)]
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
	[Index(25)]
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
	[Index(26)]
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "imgLayer")]
[Id(ElementTypeIdConst)]
public partial class ImageLayer : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12826;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> embed.</para>
    /// <para>Represents the following attribute in the schema: r:embed </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "embed")]
    [Index(0)]
    public StringValue Embed { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "cNvPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12827;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public UInt32Value Id { get; set; }
	
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(1)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> descr.</para>
    /// <para>Represents the following attribute in the schema: descr </para>
    /// </summary>
    [SchemaAttr(0, "descr")]
    [Index(2)]
    public StringValue Description { get; set; }
	
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    [Index(3)]
    public BooleanValue Hidden { get; set; }
	
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [Index(4)]
    public StringValue Title { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> HyperlinkOnClick.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkClick </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "cNvContentPartPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualInkContentPartProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12828;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> isComment.</para>
    /// <para>Represents the following attribute in the schema: isComment </para>
    /// </summary>
    [SchemaAttr(0, "isComment")]
    [Index(0)]
    public BooleanValue IsComment { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ContentPartLocks.</para>
    /// <para> Represents the following element tag in the schema: a14:cpLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "nvContentPartPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualContentPartProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12829;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: a14:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(48, "xfrm")]
[Id(ElementTypeIdConst)]
public partial class Transform2D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12830;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Rotation.</para>
    /// <para>Represents the following attribute in the schema: rot </para>
    /// </summary>
    [SchemaAttr(0, "rot")]
    [Index(0)]
    public Int32Value Rotation { get; set; }
	
    /// <summary>
    /// <para> Horizontal Flip.</para>
    /// <para>Represents the following attribute in the schema: flipH </para>
    /// </summary>
    [SchemaAttr(0, "flipH")]
    [Index(1)]
    public BooleanValue HorizontalFlip { get; set; }
	
    /// <summary>
    /// <para> Vertical Flip.</para>
    /// <para>Represents the following attribute in the schema: flipV </para>
    /// </summary>
    [SchemaAttr(0, "flipV")]
    [Index(2)]
    public BooleanValue VerticalFlip { get; set; }
	

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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Offset.</para>
    /// <para> Represents the following element tag in the schema: a:off </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Extents Extents
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);

}
}
 
 
