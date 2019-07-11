// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentFormat.OpenXml.Office2016.Drawing.Charts
{
/// <summary>
/// <para>Defines the ShapeProperties Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:spPr.</para>
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

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "spPr")]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
[StringValidator(IsToken = true)]
    [SchemaAttr(0, "bwMode")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }

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

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
    new CompositeParticle(ParticleType.Group, 0, 1)
    {
        new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
        }
    },
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
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
    new CompositeParticle(ParticleType.Group, 0, 1)
    {
        new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
        }
    },
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> 2D Transform for Individual Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);

}
/// <summary>
/// <para>Defines the UnsignedIntegerType Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:explosion.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "explosion")]
public partial class UnsignedIntegerType : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> Integer Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "val")]
    [Index(0)]
    public UInt32Value Val { get; set; }

    /// <summary>
    /// Initializes a new instance of the UnsignedIntegerType class.
    /// </summary>
    public UnsignedIntegerType():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsignedIntegerType>(deep);

}
/// <summary>
/// <para>Defines the InvertIfNegativeBoolean Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:invertIfNegative.</para>
/// </summary>

[SchemaAttr(82, "invertIfNegative")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class InvertIfNegativeBoolean : BooleanType
{
    /// <summary>
    /// Initializes a new instance of the InvertIfNegativeBoolean class.
    /// </summary>
    public InvertIfNegativeBoolean():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertIfNegativeBoolean>(deep);


}
/// <summary>
/// <para>Defines the Bubble3DBoolean Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:bubble3D.</para>
/// </summary>

[SchemaAttr(82, "bubble3D")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Bubble3DBoolean : BooleanType
{
    /// <summary>
    /// Initializes a new instance of the Bubble3DBoolean class.
    /// </summary>
    public Bubble3DBoolean():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bubble3DBoolean>(deep);


}
/// <summary>
/// Defines the BooleanType class.
/// </summary>


public abstract partial class BooleanType : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> Boolean Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }

    
    
    /// <summary>
    /// Initializes a new instance of the BooleanType class.
    /// </summary>
    protected BooleanType(){}
    
    
}
/// <summary>
/// <para>Defines the Marker Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:marker.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Symbol &lt;c:symbol></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Size &lt;c:size></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Symbol))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Size))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "marker")]
public partial class Marker : OpenXmlCompositeElement
{
    
    
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

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Symbol), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Size), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Symbol.</para>
    /// <para> Represents the following element tag in the schema: c:symbol </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Symbol Symbol
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Symbol>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> Size.</para>
    /// <para> Represents the following element tag in the schema: c:size </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.Size Size
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Size>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(3);
        set => SetElement(3, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Marker>(deep);

}
/// <summary>
/// <para>Defines the DLbl Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:dLbl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Delete &lt;c:delete></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Layout &lt;c:layout></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat &lt;c:numFmt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.TextProperties &lt;c:txPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition &lt;c:dLblPos></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey &lt;c:showLegendKey></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowValue &lt;c:showVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName &lt;c:showCatName></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName &lt;c:showSerName></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowPercent &lt;c:showPercent></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize &lt;c:showBubbleSize></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Separator &lt;c:separator></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowValue))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowPercent))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Separator))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "dLbl")]
public partial class DLbl : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the DLbl class.
    /// </summary>
    public DLbl():base(){}
        /// <summary>
    ///Initializes a new instance of the DLbl class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLbl(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the DLbl class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLbl(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the DLbl class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DLbl(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
    new CompositeParticle(ParticleType.Choice, 1, 1)
    {
        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete), 1, 1),
        new CompositeParticle(ParticleType.Group, 1, 1)
        {
            new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText), 0, 1),
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowValue), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowPercent), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Separator), 0, 1)
                    }
                }
            }
        }
    },
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLbl>(deep);

}
/// <summary>
/// <para>Defines the CategoryFilterExceptions Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:categoryFilterExceptions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CategoryFilterException &lt;c16:categoryFilterException></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(CategoryFilterException), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "categoryFilterExceptions")]
public partial class CategoryFilterExceptions : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class.
    /// </summary>
    public CategoryFilterExceptions():base(){}
        /// <summary>
    ///Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterExceptions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterExceptions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryFilterExceptions(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.CategoryFilterException), 1, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterExceptions>(deep);

}
/// <summary>
/// <para>Defines the PivotOptions16 Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:pivotOptions16.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BooleanFalse &lt;c16:showExpandCollapseFieldButtons></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BooleanFalse), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "pivotOptions16")]
public partial class PivotOptions16 : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the PivotOptions16 class.
    /// </summary>
    public PivotOptions16():base(){}
        /// <summary>
    ///Initializes a new instance of the PivotOptions16 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotOptions16(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the PivotOptions16 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotOptions16(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the PivotOptions16 class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotOptions16(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.BooleanFalse), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> BooleanFalse.</para>
    /// <para> Represents the following element tag in the schema: c16:showExpandCollapseFieldButtons </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(0)]
    public BooleanFalse BooleanFalse
	{
        get => GetElement<BooleanFalse>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotOptions16>(deep);

}
/// <summary>
/// <para>Defines the ChartDataPointUniqueIDMap Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:datapointuniqueidmap.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartDataPointUniqueIDMapEntry &lt;c16:ptentry></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ChartDataPointUniqueIDMapEntry), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "datapointuniqueidmap")]
public partial class ChartDataPointUniqueIDMap : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMap class.
    /// </summary>
    public ChartDataPointUniqueIDMap():base(){}
        /// <summary>
    ///Initializes a new instance of the ChartDataPointUniqueIDMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartDataPointUniqueIDMap(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartDataPointUniqueIDMap(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMap class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartDataPointUniqueIDMap(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.ChartDataPointUniqueIDMapEntry), 0, 0, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartDataPointUniqueIDMap>(deep);

}
/// <summary>
/// <para>Defines the UniqueIdChartUniqueID Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:uniqueId.</para>
/// </summary>

[SchemaAttr(82, "uniqueId")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class UniqueIdChartUniqueID : UniqueIDChart
{
    /// <summary>
    /// Initializes a new instance of the UniqueIdChartUniqueID class.
    /// </summary>
    public UniqueIdChartUniqueID():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UniqueIdChartUniqueID>(deep);


}
/// <summary>
/// <para>Defines the UniqueID Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:uniqueID.</para>
/// </summary>

[SchemaAttr(82, "uniqueID")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class UniqueID : UniqueIDChart
{
    /// <summary>
    /// Initializes a new instance of the UniqueID class.
    /// </summary>
    public UniqueID():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UniqueID>(deep);


}
/// <summary>
/// Defines the UniqueIDChart class.
/// </summary>


public abstract partial class UniqueIDChart : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> val, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "val")]
    [Index(0)]
    public StringValue Val { get; set; }

    
    
    /// <summary>
    /// Initializes a new instance of the UniqueIDChart class.
    /// </summary>
    protected UniqueIDChart(){}
    
    
}
/// <summary>
/// <para>Defines the CategoryFilterException Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:categoryFilterException.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UniqueIdChartUniqueID &lt;c16:uniqueId></description></item>
///<item><description>ShapeProperties &lt;c16:spPr></description></item>
///<item><description>UnsignedIntegerType &lt;c16:explosion></description></item>
///<item><description>InvertIfNegativeBoolean &lt;c16:invertIfNegative></description></item>
///<item><description>Bubble3DBoolean &lt;c16:bubble3D></description></item>
///<item><description>Marker &lt;c16:marker></description></item>
///<item><description>DLbl &lt;c16:dLbl></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(UniqueIdChartUniqueID), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(UnsignedIntegerType), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(InvertIfNegativeBoolean), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Bubble3DBoolean), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Marker), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(DLbl), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "categoryFilterException")]
public partial class CategoryFilterException : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class.
    /// </summary>
    public CategoryFilterException():base(){}
        /// <summary>
    ///Initializes a new instance of the CategoryFilterException class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterException(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterException(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryFilterException(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.UniqueIdChartUniqueID), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.UnsignedIntegerType), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.InvertIfNegativeBoolean), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.Bubble3DBoolean), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.Marker), 0, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.DLbl), 0, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> UniqueIdChartUniqueID.</para>
    /// <para> Represents the following element tag in the schema: c16:uniqueId </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(0)]
    public UniqueIdChartUniqueID UniqueIdChartUniqueID
	{
        get => GetElement<UniqueIdChartUniqueID>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c16:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(1)]
    public ShapeProperties ShapeProperties
	{
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
	}
    /// <summary>
    /// <para> UnsignedIntegerType.</para>
    /// <para> Represents the following element tag in the schema: c16:explosion </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(2)]
    public UnsignedIntegerType UnsignedIntegerType
	{
        get => GetElement<UnsignedIntegerType>(2);
        set => SetElement(2, value);
	}
    /// <summary>
    /// <para> InvertIfNegativeBoolean.</para>
    /// <para> Represents the following element tag in the schema: c16:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(3)]
    public InvertIfNegativeBoolean InvertIfNegativeBoolean
	{
        get => GetElement<InvertIfNegativeBoolean>(3);
        set => SetElement(3, value);
	}
    /// <summary>
    /// <para> Bubble3DBoolean.</para>
    /// <para> Represents the following element tag in the schema: c16:bubble3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(4)]
    public Bubble3DBoolean Bubble3DBoolean
	{
        get => GetElement<Bubble3DBoolean>(4);
        set => SetElement(4, value);
	}
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c16:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(5)]
    public Marker Marker
	{
        get => GetElement<Marker>(5);
        set => SetElement(5, value);
	}
    /// <summary>
    /// <para> DLbl.</para>
    /// <para> Represents the following element tag in the schema: c16:dLbl </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(6)]
    public DLbl DLbl
	{
        get => GetElement<DLbl>(6);
        set => SetElement(6, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterException>(deep);

}
/// <summary>
/// <para>Defines the NumberDataType Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:numCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.FormatCode &lt;c:formatCode></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.NumericPoint &lt;c:pt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatCode))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "numCache")]
public partial class NumberDataType : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the NumberDataType class.
    /// </summary>
    public NumberDataType():base(){}
        /// <summary>
    ///Initializes a new instance of the NumberDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumberDataType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the NumberDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumberDataType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the NumberDataType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumberDataType(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatCode), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint), 0, 0),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Format Code.</para>
    /// <para> Represents the following element tag in the schema: c:formatCode </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.FormatCode FormatCode
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> Point Count.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberDataType>(deep);

}
/// <summary>
/// <para>Defines the NumFilteredLiteralCache Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:filteredLitCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberDataType &lt;c16:numCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NumberDataType), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "filteredLitCache")]
public partial class NumFilteredLiteralCache : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the NumFilteredLiteralCache class.
    /// </summary>
    public NumFilteredLiteralCache():base(){}
        /// <summary>
    ///Initializes a new instance of the NumFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumFilteredLiteralCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the NumFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumFilteredLiteralCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the NumFilteredLiteralCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumFilteredLiteralCache(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.NumberDataType), 1, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> NumberDataType.</para>
    /// <para> Represents the following element tag in the schema: c16:numCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(0)]
    public NumberDataType NumberDataType
	{
        get => GetElement<NumberDataType>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumFilteredLiteralCache>(deep);

}
/// <summary>
/// <para>Defines the StringDataType Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:strCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "strCache")]
public partial class StringDataType : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class.
    /// </summary>
    public StringDataType():base(){}
        /// <summary>
    ///Initializes a new instance of the StringDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringDataType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the StringDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringDataType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the StringDataType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StringDataType(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint), 0, 0),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> PointCount.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringDataType>(deep);

}
/// <summary>
/// <para>Defines the StrFilteredLiteralCache Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:filteredLitCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StringDataType &lt;c16:strCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StringDataType), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "filteredLitCache")]
public partial class StrFilteredLiteralCache : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the StrFilteredLiteralCache class.
    /// </summary>
    public StrFilteredLiteralCache():base(){}
        /// <summary>
    ///Initializes a new instance of the StrFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrFilteredLiteralCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the StrFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrFilteredLiteralCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the StrFilteredLiteralCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StrFilteredLiteralCache(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.StringDataType), 1, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> StringDataType.</para>
    /// <para> Represents the following element tag in the schema: c16:strCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(0)]
    public StringDataType StringDataType
	{
        get => GetElement<StringDataType>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrFilteredLiteralCache>(deep);

}
/// <summary>
/// <para>Defines the MultiLvlStrData Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:multiLvlStrCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Level &lt;c:lvl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Level))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "multiLvlStrCache")]
public partial class MultiLvlStrData : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrData class.
    /// </summary>
    public MultiLvlStrData():base(){}
        /// <summary>
    ///Initializes a new instance of the MultiLvlStrData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MultiLvlStrData(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Level), 0, 0),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> PointCount.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrData>(deep);

}
/// <summary>
/// <para>Defines the MultiLvlStrFilteredLiteralCache Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:filteredLitCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MultiLvlStrData &lt;c16:multiLvlStrCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(MultiLvlStrData), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "filteredLitCache")]
public partial class MultiLvlStrFilteredLiteralCache : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrFilteredLiteralCache class.
    /// </summary>
    public MultiLvlStrFilteredLiteralCache():base(){}
        /// <summary>
    ///Initializes a new instance of the MultiLvlStrFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrFilteredLiteralCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrFilteredLiteralCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrFilteredLiteralCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MultiLvlStrFilteredLiteralCache(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.MultiLvlStrData), 1, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> MultiLvlStrData.</para>
    /// <para> Represents the following element tag in the schema: c16:multiLvlStrCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(0)]
    public MultiLvlStrData MultiLvlStrData
	{
        get => GetElement<MultiLvlStrData>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrFilteredLiteralCache>(deep);

}
/// <summary>
/// <para>Defines the LiteralDataChart Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:literalDataChart.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "literalDataChart")]
public partial class LiteralDataChart : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> val, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
[RequiredValidator]
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }

    /// <summary>
    /// Initializes a new instance of the LiteralDataChart class.
    /// </summary>
    public LiteralDataChart():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LiteralDataChart>(deep);

}
/// <summary>
/// <para>Defines the BooleanFalse Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:showExpandCollapseFieldButtons.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "showExpandCollapseFieldButtons")]
public partial class BooleanFalse : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> val, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }

    /// <summary>
    /// Initializes a new instance of the BooleanFalse class.
    /// </summary>
    public BooleanFalse():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BooleanFalse>(deep);

}
/// <summary>
/// <para>Defines the XsdunsignedInt Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:ptidx.</para>
/// </summary>

[NumberValidator(SimpleType = typeof(UInt32Value))]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "ptidx")]
public partial class XsdunsignedInt : OpenXmlLeafTextElement
{
    
    
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


    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<XsdunsignedInt>(deep);

}
/// <summary>
/// <para>Defines the ChartDataPointUniqueIDMapEntry Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:ptentry.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>XsdunsignedInt &lt;c16:ptidx></description></item>
///<item><description>UniqueID &lt;c16:uniqueID></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(XsdunsignedInt), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(UniqueID), FileFormatVersions.Office2016)]

[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(82, "ptentry")]
public partial class ChartDataPointUniqueIDMapEntry : OpenXmlCompositeElement
{
    
    
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMapEntry class.
    /// </summary>
    public ChartDataPointUniqueIDMapEntry():base(){}
        /// <summary>
    ///Initializes a new instance of the ChartDataPointUniqueIDMapEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartDataPointUniqueIDMapEntry(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMapEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartDataPointUniqueIDMapEntry(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMapEntry class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartDataPointUniqueIDMapEntry(string outerXml)
        : base(outerXml)
    {
    }

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.XsdunsignedInt), 1, 1, version: FileFormatVersions.Office2016),
    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.UniqueID), 1, 1, version: FileFormatVersions.Office2016)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> XsdunsignedInt.</para>
    /// <para> Represents the following element tag in the schema: c16:ptidx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(0)]
    public XsdunsignedInt XsdunsignedInt
	{
        get => GetElement<XsdunsignedInt>(0);
        set => SetElement(0, value);
	}
    /// <summary>
    /// <para> UniqueID.</para>
    /// <para> Represents the following element tag in the schema: c16:uniqueID </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
	[Index(1)]
    public UniqueID UniqueID
	{
        get => GetElement<UniqueID>(1);
        set => SetElement(1, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartDataPointUniqueIDMapEntry>(deep);

}
}
