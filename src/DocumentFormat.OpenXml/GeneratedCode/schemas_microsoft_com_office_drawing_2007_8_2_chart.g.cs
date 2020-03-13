// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Drawing.Charts
{
    /// <summary>
    /// <para>Defines the PivotOptions Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:pivotOptions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DropZoneFilter &lt;c14:dropZoneFilter></description></item>
    ///   <item><description>DropZoneCategories &lt;c14:dropZoneCategories></description></item>
    ///   <item><description>DropZoneData &lt;c14:dropZoneData></description></item>
    ///   <item><description>DropZoneSeries &lt;c14:dropZoneSeries></description></item>
    ///   <item><description>DropZonesVisible &lt;c14:dropZonesVisible></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DropZoneFilter), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropZoneCategories), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropZoneData), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropZoneSeries), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DropZonesVisible), FileFormatVersions.Office2010)]
    [SchemaAttr(46, "pivotOptions")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class PivotOptions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotOptions class.
        /// </summary>
        public PivotOptions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotOptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotOptions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotOptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotOptions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotOptions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotOptions(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>DropZoneFilter.</para>
        /// <para>Represents the following element tag in the schema: c14:dropZoneFilter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DropZoneFilter DropZoneFilter
        {
            get => GetElement<DropZoneFilter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DropZoneCategories.</para>
        /// <para>Represents the following element tag in the schema: c14:dropZoneCategories.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DropZoneCategories DropZoneCategories
        {
            get => GetElement<DropZoneCategories>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DropZoneData.</para>
        /// <para>Represents the following element tag in the schema: c14:dropZoneData.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DropZoneData DropZoneData
        {
            get => GetElement<DropZoneData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DropZoneSeries.</para>
        /// <para>Represents the following element tag in the schema: c14:dropZoneSeries.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DropZoneSeries DropZoneSeries
        {
            get => GetElement<DropZoneSeries>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DropZonesVisible.</para>
        /// <para>Represents the following element tag in the schema: c14:dropZonesVisible.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public DropZonesVisible DropZonesVisible
        {
            get => GetElement<DropZonesVisible>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotOptions>(deep);
    }

    /// <summary>
    /// <para>Defines the SketchOptions Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:sketchOptions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>InSketchMode &lt;c14:inSketchMode></description></item>
    ///   <item><description>ShowSketchButton &lt;c14:showSketchBtn></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(InSketchMode), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ShowSketchButton), FileFormatVersions.Office2010)]
    [SchemaAttr(46, "sketchOptions")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SketchOptions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SketchOptions class.
        /// </summary>
        public SketchOptions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SketchOptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SketchOptions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SketchOptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SketchOptions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SketchOptions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SketchOptions(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>InSketchMode.</para>
        /// <para>Represents the following element tag in the schema: c14:inSketchMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public InSketchMode InSketchMode
        {
            get => GetElement<InSketchMode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShowSketchButton.</para>
        /// <para>Represents the following element tag in the schema: c14:showSketchBtn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public ShowSketchButton ShowSketchButton
        {
            get => GetElement<ShowSketchButton>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SketchOptions>(deep);
    }

    /// <summary>
    /// <para>Defines the InvertSolidFillFormat Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:invertSolidFillFmt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShapeProperties &lt;c14:spPr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2010)]
    [SchemaAttr(46, "invertSolidFillFmt")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class InvertSolidFillFormat : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the InvertSolidFillFormat class.
        /// </summary>
        public InvertSolidFillFormat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvertSolidFillFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InvertSolidFillFormat(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvertSolidFillFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InvertSolidFillFormat(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InvertSolidFillFormat class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public InvertSolidFillFormat(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c14:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c14 = http://schemas.microsoft.com/office/drawing/2007/8/2/chart
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertSolidFillFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the Style Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:style.</para>
    /// </summary>
    [SchemaAttr(46, "style")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Style : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 101L, MaxInclusive = 148L)]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public ByteValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Transform2D &lt;a:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(46, "spPr")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeProperties class.
        /// </summary>
        public ShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bwMode")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }

        /// <summary>
        /// <para>2D Transform for Individual Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the DropZoneFilter Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:dropZoneFilter.</para>
    /// </summary>
    [SchemaAttr(46, "dropZoneFilter")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DropZoneFilter : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the DropZoneFilter class.
        /// </summary>
        public DropZoneFilter() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the DropZoneCategories Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:dropZoneCategories.</para>
    /// </summary>
    [SchemaAttr(46, "dropZoneCategories")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DropZoneCategories : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the DropZoneCategories class.
        /// </summary>
        public DropZoneCategories() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneCategories>(deep);
    }

    /// <summary>
    /// <para>Defines the DropZoneData Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:dropZoneData.</para>
    /// </summary>
    [SchemaAttr(46, "dropZoneData")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DropZoneData : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the DropZoneData class.
        /// </summary>
        public DropZoneData() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneData>(deep);
    }

    /// <summary>
    /// <para>Defines the DropZoneSeries Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:dropZoneSeries.</para>
    /// </summary>
    [SchemaAttr(46, "dropZoneSeries")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DropZoneSeries : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the DropZoneSeries class.
        /// </summary>
        public DropZoneSeries() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZoneSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the DropZonesVisible Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:dropZonesVisible.</para>
    /// </summary>
    [SchemaAttr(46, "dropZonesVisible")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class DropZonesVisible : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the DropZonesVisible class.
        /// </summary>
        public DropZonesVisible() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropZonesVisible>(deep);
    }

    /// <summary>
    /// <para>Defines the InSketchMode Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:inSketchMode.</para>
    /// </summary>
    [SchemaAttr(46, "inSketchMode")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class InSketchMode : BooleanFalseType
    {
        /// <summary>
        /// Initializes a new instance of the InSketchMode class.
        /// </summary>
        public InSketchMode() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InSketchMode>(deep);
    }

    /// <summary>
    /// <para>Defines the BooleanFalseType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class BooleanFalseType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BooleanFalseType class.
        /// </summary>
        protected BooleanFalseType() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr(0, "val")]
        [Index(0)]
        public BooleanValue Val { get; set; }
    }

    /// <summary>
    /// <para>Defines the ShowSketchButton Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c14:showSketchBtn.</para>
    /// </summary>
    [SchemaAttr(46, "showSketchBtn")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ShowSketchButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShowSketchButton class.
        /// </summary>
        public ShowSketchButton() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr(0, "val")]
        [Index(0)]
        public BooleanValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowSketchButton>(deep);
    }
}