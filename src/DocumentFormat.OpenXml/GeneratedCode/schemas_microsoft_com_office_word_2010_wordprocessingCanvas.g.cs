// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2010.Word.DrawingGroup;
using DocumentFormat.OpenXml.Office2010.Word.DrawingShape;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Drawing.Pictures;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas
{
/// <summary>
/// <para>Defines the WordprocessingCanvas Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wpc:wpc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackgroundFormatting &lt;wpc:bg></description></item>
///<item><description>WholeFormatting &lt;wpc:whole></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape &lt;wps:wsp></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Pictures.Picture &lt;pic:pic></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.ContentPart &lt;w14:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup &lt;wpg:wgp></description></item>
///<item><description>GraphicFrameType &lt;wpc:graphicFrame></description></item>
///<item><description>OfficeArtExtensionList &lt;wpc:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BackgroundFormatting), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(WholeFormatting), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Pictures.Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.ContentPart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(GraphicFrameType), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(59, "wpc")]
[Id(ElementTypeIdConst)]
public partial class WordprocessingCanvas : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13182;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    /// <summary>
    /// Initializes a new instance of the WordprocessingCanvas class.
    /// </summary>
    public WordprocessingCanvas():base(){}
        /// <summary>
    ///Initializes a new instance of the WordprocessingCanvas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WordprocessingCanvas(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the WordprocessingCanvas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WordprocessingCanvas(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the WordprocessingCanvas class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WordprocessingCanvas(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.BackgroundFormatting), 0, 1, version: FileFormatVersions.Office2010),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.WholeFormatting), 0, 1, version: FileFormatVersions.Office2010),
    new CompositeParticle(ParticleType.Choice, 0, 0)
    {
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape), 1, 1, version: FileFormatVersions.Office2010),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Pictures.Picture), 1, 1),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.ContentPart), 1, 1, version: FileFormatVersions.Office2010),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup), 1, 1, version: FileFormatVersions.Office2010),
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.GraphicFrameType), 1, 1, version: FileFormatVersions.Office2010)
    },
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneAll;
        /// <summary>
    /// <para> BackgroundFormatting.</para>
    /// <para> Represents the following element tag in the schema: wpc:bg </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpc = http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas
    /// </remark>
	[Index(0)]
    public BackgroundFormatting BackgroundFormatting
	{
        get => GetElement<BackgroundFormatting>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> WholeFormatting.</para>
    /// <para> Represents the following element tag in the schema: wpc:whole </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpc = http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas
    /// </remark>
	[Index(1)]
    public WholeFormatting WholeFormatting
	{
        get => GetElement<WholeFormatting>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> WordprocessingShape.</para>
    /// <para> Represents the following element tag in the schema: wps:wsp </para>
    /// </summary>
    /// <remark>
    /// xmlns:wps = http://schemas.microsoft.com/office/word/2010/wordprocessingShape
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape WordprocessingShape
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> Picture.</para>
    /// <para> Represents the following element tag in the schema: pic:pic </para>
    /// </summary>
    /// <remark>
    /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Pictures.Picture Picture
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Pictures.Picture>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> ContentPart.</para>
    /// <para> Represents the following element tag in the schema: w14:contentPart </para>
    /// </summary>
    /// <remark>
    /// xmlns:w14 = http://schemas.microsoft.com/office/word/2010/wordml
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Office2010.Word.ContentPart ContentPart
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Word.ContentPart>(4);
        set => SetElement(4, value);
	}
    /// <summary>
    /// <para> WordprocessingGroup.</para>
    /// <para> Represents the following element tag in the schema: wpg:wgp </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup WordprocessingGroup
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup>(5);
        set => SetElement(5, value);
	}
    /// <summary>
    /// <para> GraphicFrameType.</para>
    /// <para> Represents the following element tag in the schema: wpc:graphicFrame </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpc = http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas
    /// </remark>
	[Index(6)]
    public GraphicFrameType GraphicFrameType
	{
        get => GetElement<GraphicFrameType>(6);
        set => SetElement(6, value);
	}
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: wpc:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpc = http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas
    /// </remark>
	[Index(7)]
    public OfficeArtExtensionList OfficeArtExtensionList
	{
        get => GetElement<OfficeArtExtensionList>(7);
        set => SetElement(7, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WordprocessingCanvas>(deep);

}
/// <summary>
/// <para>Defines the BackgroundFormatting Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wpc:bg.</para>
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
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(59, "bg")]
[Id(ElementTypeIdConst)]
public partial class BackgroundFormatting : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13183;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    /// <summary>
    /// Initializes a new instance of the BackgroundFormatting class.
    /// </summary>
    public BackgroundFormatting():base(){}
        /// <summary>
    ///Initializes a new instance of the BackgroundFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackgroundFormatting(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the BackgroundFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackgroundFormatting(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the BackgroundFormatting class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackgroundFormatting(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new CompositeParticle(ParticleType.Group, 0, 1)
    {
        new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
        }
    },
    new CompositeParticle(ParticleType.Group, 0, 1)
    {
        new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
        }
    }
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
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
    /// <summary>
    /// <para> Effect Container.</para>
    /// <para> Represents the following element tag in the schema: a:effectLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(6)]
    public DocumentFormat.OpenXml.Drawing.EffectList EffectList
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.EffectList>(6);
        set => SetElement(6, value);
	}
    /// <summary>
    /// <para> Effect Container.</para>
    /// <para> Represents the following element tag in the schema: a:effectDag </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(7)]
    public DocumentFormat.OpenXml.Drawing.EffectDag EffectDag
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.EffectDag>(7);
        set => SetElement(7, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundFormatting>(deep);

}
/// <summary>
/// <para>Defines the WholeFormatting Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wpc:whole.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(59, "whole")]
[Id(ElementTypeIdConst)]
public partial class WholeFormatting : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13184;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    /// <summary>
    /// Initializes a new instance of the WholeFormatting class.
    /// </summary>
    public WholeFormatting():base(){}
        /// <summary>
    ///Initializes a new instance of the WholeFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WholeFormatting(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the WholeFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WholeFormatting(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the WholeFormatting class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WholeFormatting(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
    new CompositeParticle(ParticleType.Group, 0, 1)
    {
        new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
        }
    }
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
        /// <summary>
    /// <para> Outline.</para>
    /// <para> Represents the following element tag in the schema: a:ln </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Outline Outline
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Outline>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> Effect Container.</para>
    /// <para> Represents the following element tag in the schema: a:effectLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.EffectList EffectList
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.EffectList>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> Effect Container.</para>
    /// <para> Represents the following element tag in the schema: a:effectDag </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.EffectDag EffectDag
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.EffectDag>(2);
        set => SetElement(2, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WholeFormatting>(deep);

}
/// <summary>
/// <para>Defines the GraphicFrameType Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wpc:graphicFrame.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties &lt;wpg:cNvPr></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties &lt;wpg:cNvFrPr></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D &lt;wpg:xfrm></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Graphic &lt;a:graphic></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList &lt;wpg:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Graphic))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(59, "graphicFrame")]
[Id(ElementTypeIdConst)]
public partial class GraphicFrameType : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13185;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    /// <summary>
    /// Initializes a new instance of the GraphicFrameType class.
    /// </summary>
    public GraphicFrameType():base(){}
        /// <summary>
    ///Initializes a new instance of the GraphicFrameType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GraphicFrameType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the GraphicFrameType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GraphicFrameType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the GraphicFrameType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GraphicFrameType(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties), 1, 1, version: FileFormatVersions.Office2010),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties), 1, 1, version: FileFormatVersions.Office2010),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D), 1, 1, version: FileFormatVersions.Office2010),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Graphic), 1, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: wpg:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties NonVisualDrawingProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> NonVisualGraphicFrameProperties.</para>
    /// <para> Represents the following element tag in the schema: wpg:cNvFrPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties NonVisualGraphicFrameProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> Transform2D.</para>
    /// <para> Represents the following element tag in the schema: wpg:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D Transform2D
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> Graphic.</para>
    /// <para> Represents the following element tag in the schema: a:graphic </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Graphic Graphic
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Graphic>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: wpg:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList OfficeArtExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList>(4);
        set => SetElement(4, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrameType>(deep);

}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wpc:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(59, "extLst")]
[Id(ElementTypeIdConst)]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13186;
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

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new CompositeParticle(ParticleType.Group, 1, 1)
    {
        new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
        }
    }
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);

}
}
