// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Drawing
{
    /// <summary>
    /// <para>Defines the CameraTool Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:cameraTool.</para>
    /// </summary>
    [SchemaAttr(48, "cameraTool")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class CameraTool : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CameraTool class.
        /// </summary>
        public CameraTool() : base()
        {
        }

        /// <summary>
        /// <para>cellRange, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: cellRange</para>
        /// </summary>
        [SchemaAttr(0, "cellRange")]
        [Index(0)]
        public StringValue CellRange { get; set; }

        /// <summary>
        /// <para>spid, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [SchemaAttr(0, "spid")]
        [Index(1)]
        public StringValue ShapeId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CameraTool>(deep);
    }

    /// <summary>
    /// <para>Defines the CompatExtension Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:compatExt.</para>
    /// </summary>
    [SchemaAttr(48, "compatExt")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class CompatExtension : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CompatExtension class.
        /// </summary>
        public CompatExtension() : base()
        {
        }

        /// <summary>
        /// <para>spid, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CompatExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the IsCanvas Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:isCanvas.</para>
    /// </summary>
    [SchemaAttr(48, "isCanvas")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class IsCanvas : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the IsCanvas class.
        /// </summary>
        public IsCanvas() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "val")]
        [Index(0)]
        public BooleanValue Val { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IsCanvas>(deep);
    }

    /// <summary>
    /// <para>Defines the GvmlContentPart Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:contentPart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualContentPartProperties &lt;a14:nvContentPartPr></description></item>
    ///   <item><description>Transform2D &lt;a14:xfrm></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;a14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualContentPartProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Transform2D), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(48, "contentPart")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class GvmlContentPart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GvmlContentPart class.
        /// </summary>
        public GvmlContentPart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GvmlContentPart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GvmlContentPart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public GvmlContentPart(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>bwMode, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bwMode")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [RequiredValidator()]
        [SchemaAttr(19, "id")]
        [Index(1)]
        public StringValue RelationshipId { get; set; }

        /// <summary>
        /// <para>NonVisualContentPartProperties.</para>
        /// <para>Represents the following element tag in the schema: a14:nvContentPartPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public NonVisualContentPartProperties NonVisualContentPartProperties
        {
            get => GetElement<NonVisualContentPartProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transform2D.</para>
        /// <para>Represents the following element tag in the schema: a14:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public Transform2D Transform2D
        {
            get => GetElement<Transform2D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.NonVisualContentPartProperties), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Transform2D), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GvmlContentPart>(deep);
    }

    /// <summary>
    /// <para>Defines the ShadowObscured Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:shadowObscured.</para>
    /// </summary>
    [SchemaAttr(48, "shadowObscured")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ShadowObscured : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShadowObscured class.
        /// </summary>
        public ShadowObscured() : base()
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShadowObscured>(deep);
    }

    /// <summary>
    /// <para>Defines the HiddenFillProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:hiddenFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [SchemaAttr(48, "hiddenFill")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class HiddenFillProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HiddenFillProperties class.
        /// </summary>
        public HiddenFillProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiddenFillProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HiddenFillProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public HiddenFillProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>NoFill.</para>
        /// <para>Represents the following element tag in the schema: a:noFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NoFill NoFill
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NoFill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SolidFill.</para>
        /// <para>Represents the following element tag in the schema: a:solidFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SolidFill SolidFill
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SolidFill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>GradientFill.</para>
        /// <para>Represents the following element tag in the schema: a:gradFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GradientFill GradientFill
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GradientFill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BlipFill.</para>
        /// <para>Represents the following element tag in the schema: a:blipFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BlipFill BlipFill
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BlipFill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Pattern Fill.</para>
        /// <para>Represents the following element tag in the schema: a:pattFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PatternFill PatternFill
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PatternFill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Group Fill.</para>
        /// <para>Represents the following element tag in the schema: a:grpFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GroupFill GroupFill
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GroupFill>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
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
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenFillProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the HiddenLineProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:hiddenLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetDash &lt;a:prstDash></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.CustomDash &lt;a:custDash></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Round &lt;a:round></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LineJoinBevel &lt;a:bevel></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Miter &lt;a:miter></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HeadEnd &lt;a:headEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.TailEnd &lt;a:tailEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(48, "hiddenLine")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class HiddenLineProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HiddenLineProperties class.
        /// </summary>
        public HiddenLineProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiddenLineProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HiddenLineProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public HiddenLineProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Line Width</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 20116800L)]
        [SchemaAttr(0, "w")]
        [Index(0)]
        public Int32Value Width { get; set; }

        /// <summary>
        /// <para>Line Ending Cap Type</para>
        /// <para>Represents the following attribute in the schema: cap</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "cap")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues> CapType { get; set; }

        /// <summary>
        /// <para>Compound Line Type</para>
        /// <para>Represents the following attribute in the schema: cmpd</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "cmpd")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues> CompoundLineType { get; set; }

        /// <summary>
        /// <para>Stroke Alignment</para>
        /// <para>Represents the following attribute in the schema: algn</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "algn")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues> Alignment { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1)
                }
            },
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetDash), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomDash), 1, 1)
                }
            },
            new CompositeParticle(ParticleType.Group, 0, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Round), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineJoinBevel), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Miter), 1, 1)
                }
            },
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HeadEnd), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TailEnd), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenLineProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the HiddenEffectsProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:hiddenEffects.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [SchemaAttr(48, "hiddenEffects")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class HiddenEffectsProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HiddenEffectsProperties class.
        /// </summary>
        public HiddenEffectsProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiddenEffectsProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HiddenEffectsProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public HiddenEffectsProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Effect Container.</para>
        /// <para>Represents the following element tag in the schema: a:effectLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EffectList EffectList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EffectList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Effect Container.</para>
        /// <para>Represents the following element tag in the schema: a:effectDag.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EffectDag EffectDag
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EffectDag>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenEffectsProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the HiddenScene3D Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:hiddenScene3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Camera &lt;a:camera></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LightRig &lt;a:lightRig></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Backdrop &lt;a:backdrop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Camera))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LightRig))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Backdrop))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
    [SchemaAttr(48, "hiddenScene3d")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class HiddenScene3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HiddenScene3D class.
        /// </summary>
        public HiddenScene3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiddenScene3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HiddenScene3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public HiddenScene3D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Camera.</para>
        /// <para>Represents the following element tag in the schema: a:camera.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Camera Camera
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Camera>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Light Rig.</para>
        /// <para>Represents the following element tag in the schema: a:lightRig.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LightRig LightRig
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LightRig>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Backdrop Plane.</para>
        /// <para>Represents the following element tag in the schema: a:backdrop.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Backdrop Backdrop
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Backdrop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Camera), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LightRig), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Backdrop), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenScene3D>(deep);
    }

    /// <summary>
    /// <para>Defines the HiddenShape3D Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:hiddenSp3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BevelTop &lt;a:bevelT></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BevelBottom &lt;a:bevelB></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtrusionColor &lt;a:extrusionClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ContourColor &lt;a:contourClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BevelTop))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BevelBottom))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtrusionColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ContourColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList))]
    [SchemaAttr(48, "hiddenSp3d")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class HiddenShape3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HiddenShape3D class.
        /// </summary>
        public HiddenShape3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiddenShape3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HiddenShape3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public HiddenShape3D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Shape Depth</para>
        /// <para>Represents the following attribute in the schema: z</para>
        /// </summary>
        [NumberValidator(MinInclusive = -27273042329600L, MaxInclusive = 27273042316900L)]
        [SchemaAttr(0, "z")]
        [Index(0)]
        public Int64Value Z { get; set; }

        /// <summary>
        /// <para>Extrusion Height</para>
        /// <para>Represents the following attribute in the schema: extrusionH</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 2147483647L)]
        [SchemaAttr(0, "extrusionH")]
        [Index(1)]
        public Int64Value ExtrusionHeight { get; set; }

        /// <summary>
        /// <para>Contour Width</para>
        /// <para>Represents the following attribute in the schema: contourW</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 2147483647L)]
        [SchemaAttr(0, "contourW")]
        [Index(2)]
        public Int64Value ContourWidth { get; set; }

        /// <summary>
        /// <para>Preset Material Type</para>
        /// <para>Represents the following attribute in the schema: prstMaterial</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "prstMaterial")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues> PresetMaterial { get; set; }

        /// <summary>
        /// <para>Top Bevel.</para>
        /// <para>Represents the following element tag in the schema: a:bevelT.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BevelTop BevelTop
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BevelTop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bottom Bevel.</para>
        /// <para>Represents the following element tag in the schema: a:bevelB.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BevelBottom BevelBottom
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BevelBottom>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extrusion Color.</para>
        /// <para>Represents the following element tag in the schema: a:extrusionClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtrusionColor ExtrusionColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Contour Color.</para>
        /// <para>Represents the following element tag in the schema: a:contourClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ContourColor ContourColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ContourColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BevelTop), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BevelBottom), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtrusionColor), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ContourColor), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenShape3D>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:imgProps.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ImageLayer &lt;a14:imgLayer></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ImageLayer), FileFormatVersions.Office2010)]
    [SchemaAttr(48, "imgProps")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ImageProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ImageProperties class.
        /// </summary>
        public ImageProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImageProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ImageProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ImageProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ImageLayer.</para>
        /// <para>Represents the following element tag in the schema: a14:imgLayer.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ImageLayer ImageLayer
        {
            get => GetElement<ImageLayer>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the UseLocalDpi Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:useLocalDpi.</para>
    /// </summary>
    [SchemaAttr(48, "useLocalDpi")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class UseLocalDpi : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UseLocalDpi class.
        /// </summary>
        public UseLocalDpi() : base()
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UseLocalDpi>(deep);
    }

    /// <summary>
    /// <para>Defines the TextMath Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:m.</para>
    /// </summary>
    [SchemaAttr(48, "m")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class TextMath : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextMath class.
        /// </summary>
        public TextMath() : base()
        {
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextMath>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
    [SchemaAttr(48, "extLst")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class OfficeArtExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new CompositeParticle(ParticleType.Group, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                }
            }
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ContentPartLocks Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:cpLocks.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OfficeArtExtensionList &lt;a14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(48, "cpLocks")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ContentPartLocks : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContentPartLocks class.
        /// </summary>
        public ContentPartLocks() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPartLocks class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContentPartLocks(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ContentPartLocks(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Disallow Shape Grouping</para>
        /// <para>Represents the following attribute in the schema: noGrp</para>
        /// </summary>
        [SchemaAttr(0, "noGrp")]
        [Index(0)]
        public BooleanValue NoGrouping { get; set; }

        /// <summary>
        /// <para>Disallow Shape Selection</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>
        [SchemaAttr(0, "noSelect")]
        [Index(1)]
        public BooleanValue NoSelection { get; set; }

        /// <summary>
        /// <para>Disallow Shape Rotation</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>
        [SchemaAttr(0, "noRot")]
        [Index(2)]
        public BooleanValue NoRotation { get; set; }

        /// <summary>
        /// <para>Disallow Aspect Ratio Change</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>
        [SchemaAttr(0, "noChangeAspect")]
        [Index(3)]
        public BooleanValue NoChangeAspect { get; set; }

        /// <summary>
        /// <para>Disallow Shape Movement</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>
        [SchemaAttr(0, "noMove")]
        [Index(4)]
        public BooleanValue NoMove { get; set; }

        /// <summary>
        /// <para>Disallow Shape Resize</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>
        [SchemaAttr(0, "noResize")]
        [Index(5)]
        public BooleanValue NoResize { get; set; }

        /// <summary>
        /// <para>Disallow Shape Point Editing</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>
        [SchemaAttr(0, "noEditPoints")]
        [Index(6)]
        public BooleanValue NoEditPoints { get; set; }

        /// <summary>
        /// <para>Disallow Showing Adjust Handles</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>
        [SchemaAttr(0, "noAdjustHandles")]
        [Index(7)]
        public BooleanValue NoAdjustHandles { get; set; }

        /// <summary>
        /// <para>Disallow Arrowhead Changes</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>
        [SchemaAttr(0, "noChangeArrowheads")]
        [Index(8)]
        public BooleanValue NoChangeArrowheads { get; set; }

        /// <summary>
        /// <para>Disallow Shape Type Change</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>
        [SchemaAttr(0, "noChangeShapeType")]
        [Index(9)]
        public BooleanValue NoChangeShapeType { get; set; }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentPartLocks>(deep);
    }

    /// <summary>
    /// <para>Defines the ForegroundMark Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:foregroundMark.</para>
    /// </summary>
    [SchemaAttr(48, "foregroundMark")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ForegroundMark : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ForegroundMark class.
        /// </summary>
        public ForegroundMark() : base()
        {
        }

        /// <summary>
        /// <para>x1, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: x1</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "x1")]
        [Index(0)]
        public Int32Value FirstXCoordinate { get; set; }

        /// <summary>
        /// <para>y1, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: y1</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "y1")]
        [Index(1)]
        public Int32Value FirstYCoordinate { get; set; }

        /// <summary>
        /// <para>x2, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: x2</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "x2")]
        [Index(2)]
        public Int32Value SecondXCoordinate { get; set; }

        /// <summary>
        /// <para>y2, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: y2</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "y2")]
        [Index(3)]
        public Int32Value SecondYCoordinate { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ForegroundMark>(deep);
    }

    /// <summary>
    /// <para>Defines the BackgroundMark Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:backgroundMark.</para>
    /// </summary>
    [SchemaAttr(48, "backgroundMark")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackgroundMark : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundMark class.
        /// </summary>
        public BackgroundMark() : base()
        {
        }

        /// <summary>
        /// <para>x1, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: x1</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "x1")]
        [Index(0)]
        public Int32Value FirstXCoordinate { get; set; }

        /// <summary>
        /// <para>y1, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: y1</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "y1")]
        [Index(1)]
        public Int32Value FirstYCoordinate { get; set; }

        /// <summary>
        /// <para>x2, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: x2</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "x2")]
        [Index(2)]
        public Int32Value SecondXCoordinate { get; set; }

        /// <summary>
        /// <para>y2, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: y2</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "y2")]
        [Index(3)]
        public Int32Value SecondYCoordinate { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundMark>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticBlur Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticBlur.</para>
    /// </summary>
    [SchemaAttr(48, "artisticBlur")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticBlur : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticBlur class.
        /// </summary>
        public ArtisticBlur() : base()
        {
        }

        /// <summary>
        /// <para>radius, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: radius</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "radius")]
        [Index(0)]
        public Int32Value Radius { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticBlur>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticCement Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticCement.</para>
    /// </summary>
    [SchemaAttr(48, "artisticCement")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticCement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticCement class.
        /// </summary>
        public ArtisticCement() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>crackSpacing, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: crackSpacing</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "crackSpacing")]
        [Index(1)]
        public Int32Value CrackSpacing { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCement>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticChalkSketch Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticChalkSketch.</para>
    /// </summary>
    [SchemaAttr(48, "artisticChalkSketch")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticChalkSketch : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticChalkSketch class.
        /// </summary>
        public ArtisticChalkSketch() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>pressure, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 4L)]
        [SchemaAttr(0, "pressure")]
        [Index(1)]
        public Int32Value Pressure { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticChalkSketch>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticCrisscrossEtching Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticCrisscrossEtching.</para>
    /// </summary>
    [SchemaAttr(48, "artisticCrisscrossEtching")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticCrisscrossEtching : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticCrisscrossEtching class.
        /// </summary>
        public ArtisticCrisscrossEtching() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>pressure, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "pressure")]
        [Index(1)]
        public Int32Value Pressure { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCrisscrossEtching>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticCutout Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticCutout.</para>
    /// </summary>
    [SchemaAttr(48, "artisticCutout")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticCutout : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticCutout class.
        /// </summary>
        public ArtisticCutout() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>numberOfShades, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: numberOfShades</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 6L)]
        [SchemaAttr(0, "numberOfShades")]
        [Index(1)]
        public Int32Value NumberOfShades { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCutout>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticFilmGrain Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticFilmGrain.</para>
    /// </summary>
    [SchemaAttr(48, "artisticFilmGrain")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticFilmGrain : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticFilmGrain class.
        /// </summary>
        public ArtisticFilmGrain() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>grainSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: grainSize</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "grainSize")]
        [Index(1)]
        public Int32Value GrainSize { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticFilmGrain>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticGlass Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticGlass.</para>
    /// </summary>
    [SchemaAttr(48, "artisticGlass")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticGlass : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticGlass class.
        /// </summary>
        public ArtisticGlass() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>scaling, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: scaling</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "scaling")]
        [Index(1)]
        public Int32Value Scaling { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlass>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticGlowDiffused Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticGlowDiffused.</para>
    /// </summary>
    [SchemaAttr(48, "artisticGlowDiffused")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticGlowDiffused : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticGlowDiffused class.
        /// </summary>
        public ArtisticGlowDiffused() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>intensity, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: intensity</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 10L)]
        [SchemaAttr(0, "intensity")]
        [Index(1)]
        public Int32Value Intensity { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlowDiffused>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticGlowEdges Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticGlowEdges.</para>
    /// </summary>
    [SchemaAttr(48, "artisticGlowEdges")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticGlowEdges : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticGlowEdges class.
        /// </summary>
        public ArtisticGlowEdges() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>smoothness, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: smoothness</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 10L)]
        [SchemaAttr(0, "smoothness")]
        [Index(1)]
        public Int32Value Smoothness { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlowEdges>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticLightScreen Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticLightScreen.</para>
    /// </summary>
    [SchemaAttr(48, "artisticLightScreen")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticLightScreen : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticLightScreen class.
        /// </summary>
        public ArtisticLightScreen() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>gridSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: gridSize</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 10L)]
        [SchemaAttr(0, "gridSize")]
        [Index(1)]
        public Int32Value GridSize { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticLightScreen>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticLineDrawing Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticLineDrawing.</para>
    /// </summary>
    [SchemaAttr(48, "artisticLineDrawing")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticLineDrawing : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticLineDrawing class.
        /// </summary>
        public ArtisticLineDrawing() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>pencilSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pencilSize</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "pencilSize")]
        [Index(1)]
        public Int32Value PencilSize { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticLineDrawing>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticMarker Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticMarker.</para>
    /// </summary>
    [SchemaAttr(48, "artisticMarker")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticMarker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticMarker class.
        /// </summary>
        public ArtisticMarker() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "size")]
        [Index(1)]
        public Int32Value Size { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticMarker>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticMosaicBubbles Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticMosiaicBubbles.</para>
    /// </summary>
    [SchemaAttr(48, "artisticMosiaicBubbles")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticMosaicBubbles : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticMosaicBubbles class.
        /// </summary>
        public ArtisticMosaicBubbles() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>pressure, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "pressure")]
        [Index(1)]
        public Int32Value Pressure { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticMosaicBubbles>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPaintStrokes Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPaintStrokes.</para>
    /// </summary>
    [SchemaAttr(48, "artisticPaintStrokes")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticPaintStrokes : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPaintStrokes class.
        /// </summary>
        public ArtisticPaintStrokes() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>intensity, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: intensity</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 10L)]
        [SchemaAttr(0, "intensity")]
        [Index(1)]
        public Int32Value Intensity { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPaintStrokes>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPaintBrush Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPaintBrush.</para>
    /// </summary>
    [SchemaAttr(48, "artisticPaintBrush")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticPaintBrush : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPaintBrush class.
        /// </summary>
        public ArtisticPaintBrush() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>brushSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: brushSize</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 10L)]
        [SchemaAttr(0, "brushSize")]
        [Index(1)]
        public Int32Value BrushSize { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPaintBrush>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPastelsSmooth Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPastelsSmooth.</para>
    /// </summary>
    [SchemaAttr(48, "artisticPastelsSmooth")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticPastelsSmooth : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPastelsSmooth class.
        /// </summary>
        public ArtisticPastelsSmooth() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>scaling, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: scaling</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "scaling")]
        [Index(1)]
        public Int32Value BrushSize { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPastelsSmooth>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPencilGrayscale Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPencilGrayscale.</para>
    /// </summary>
    [SchemaAttr(48, "artisticPencilGrayscale")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticPencilGrayscale : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPencilGrayscale class.
        /// </summary>
        public ArtisticPencilGrayscale() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>pencilSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pencilSize</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "pencilSize")]
        [Index(1)]
        public Int32Value BrushSize { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPencilGrayscale>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPencilSketch Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPencilSketch.</para>
    /// </summary>
    [SchemaAttr(48, "artisticPencilSketch")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticPencilSketch : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPencilSketch class.
        /// </summary>
        public ArtisticPencilSketch() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>pressure, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "pressure")]
        [Index(1)]
        public Int32Value Pressure { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPencilSketch>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPhotocopy Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPhotocopy.</para>
    /// </summary>
    [SchemaAttr(48, "artisticPhotocopy")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticPhotocopy : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPhotocopy class.
        /// </summary>
        public ArtisticPhotocopy() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>detail, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: detail</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 10L)]
        [SchemaAttr(0, "detail")]
        [Index(1)]
        public Int32Value Detail { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPhotocopy>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPlasticWrap Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPlasticWrap.</para>
    /// </summary>
    [SchemaAttr(48, "artisticPlasticWrap")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticPlasticWrap : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPlasticWrap class.
        /// </summary>
        public ArtisticPlasticWrap() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>smoothness, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: smoothness</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 10L)]
        [SchemaAttr(0, "smoothness")]
        [Index(1)]
        public Int32Value Smoothness { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPlasticWrap>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticTexturizer Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticTexturizer.</para>
    /// </summary>
    [SchemaAttr(48, "artisticTexturizer")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticTexturizer : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticTexturizer class.
        /// </summary>
        public ArtisticTexturizer() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>scaling, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: scaling</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100L)]
        [SchemaAttr(0, "scaling")]
        [Index(1)]
        public Int32Value Scaling { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticTexturizer>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticWatercolorSponge Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticWatercolorSponge.</para>
    /// </summary>
    [SchemaAttr(48, "artisticWatercolorSponge")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ArtisticWatercolorSponge : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticWatercolorSponge class.
        /// </summary>
        public ArtisticWatercolorSponge() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "trans")]
        [Index(0)]
        public Int32Value Transparancy { get; set; }

        /// <summary>
        /// <para>brushSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: brushSize</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 10L)]
        [SchemaAttr(0, "brushSize")]
        [Index(1)]
        public Int32Value BrushSize { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticWatercolorSponge>(deep);
    }

    /// <summary>
    /// <para>Defines the BackgroundRemoval Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:backgroundRemoval.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ForegroundMark &lt;a14:foregroundMark></description></item>
    ///   <item><description>BackgroundMark &lt;a14:backgroundMark></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ForegroundMark), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BackgroundMark), FileFormatVersions.Office2010)]
    [SchemaAttr(48, "backgroundRemoval")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BackgroundRemoval : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundRemoval class.
        /// </summary>
        public BackgroundRemoval() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundRemoval class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundRemoval(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public BackgroundRemoval(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>t, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "t")]
        [Index(0)]
        public Int32Value MarqueeTop { get; set; }

        /// <summary>
        /// <para>b, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "b")]
        [Index(1)]
        public Int32Value MarqueeBottom { get; set; }

        /// <summary>
        /// <para>l, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "l")]
        [Index(2)]
        public Int32Value MarqueeLeft { get; set; }

        /// <summary>
        /// <para>r, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        [RequiredValidator()]
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "r")]
        [Index(3)]
        public Int32Value MarqueeRight { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark), 0, 0, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark), 0, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundRemoval>(deep);
    }

    /// <summary>
    /// <para>Defines the BrightnessContrast Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:brightnessContrast.</para>
    /// </summary>
    [SchemaAttr(48, "brightnessContrast")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class BrightnessContrast : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BrightnessContrast class.
        /// </summary>
        public BrightnessContrast() : base()
        {
        }

        /// <summary>
        /// <para>bright, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bright</para>
        /// </summary>
        [NumberValidator(MinInclusive = -100000L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "bright")]
        [Index(0)]
        public Int32Value Bright { get; set; }

        /// <summary>
        /// <para>contrast, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: contrast</para>
        /// </summary>
        [NumberValidator(MinInclusive = -100000L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "contrast")]
        [Index(1)]
        public Int32Value Contrast { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BrightnessContrast>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorTemperature Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:colorTemperature.</para>
    /// </summary>
    [SchemaAttr(48, "colorTemperature")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ColorTemperature : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorTemperature class.
        /// </summary>
        public ColorTemperature() : base()
        {
        }

        /// <summary>
        /// <para>colorTemp, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: colorTemp</para>
        /// </summary>
        [NumberValidator(MinInclusive = 1500L, MaxInclusive = 11500L)]
        [SchemaAttr(0, "colorTemp")]
        [Index(0)]
        public Int32Value ColorTemperatureValue { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTemperature>(deep);
    }

    /// <summary>
    /// <para>Defines the Saturation Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:saturation.</para>
    /// </summary>
    [SchemaAttr(48, "saturation")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Saturation : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Saturation class.
        /// </summary>
        public Saturation() : base()
        {
        }

        /// <summary>
        /// <para>sat, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sat</para>
        /// </summary>
        [NumberValidator(MinInclusive = 0L, MaxInclusive = 400000L)]
        [SchemaAttr(0, "sat")]
        [Index(0)]
        public Int32Value SaturationAmount { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Saturation>(deep);
    }

    /// <summary>
    /// <para>Defines the SharpenSoften Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:sharpenSoften.</para>
    /// </summary>
    [SchemaAttr(48, "sharpenSoften")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class SharpenSoften : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SharpenSoften class.
        /// </summary>
        public SharpenSoften() : base()
        {
        }

        /// <summary>
        /// <para>amount, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: amount</para>
        /// </summary>
        [NumberValidator(MinInclusive = -100000L, MaxInclusive = 100000L)]
        [SchemaAttr(0, "amount")]
        [Index(0)]
        public Int32Value Amount { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharpenSoften>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageEffect Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:imgEffect.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArtisticBlur &lt;a14:artisticBlur></description></item>
    ///   <item><description>ArtisticCement &lt;a14:artisticCement></description></item>
    ///   <item><description>ArtisticChalkSketch &lt;a14:artisticChalkSketch></description></item>
    ///   <item><description>ArtisticCrisscrossEtching &lt;a14:artisticCrisscrossEtching></description></item>
    ///   <item><description>ArtisticCutout &lt;a14:artisticCutout></description></item>
    ///   <item><description>ArtisticFilmGrain &lt;a14:artisticFilmGrain></description></item>
    ///   <item><description>ArtisticGlass &lt;a14:artisticGlass></description></item>
    ///   <item><description>ArtisticGlowDiffused &lt;a14:artisticGlowDiffused></description></item>
    ///   <item><description>ArtisticGlowEdges &lt;a14:artisticGlowEdges></description></item>
    ///   <item><description>ArtisticLightScreen &lt;a14:artisticLightScreen></description></item>
    ///   <item><description>ArtisticLineDrawing &lt;a14:artisticLineDrawing></description></item>
    ///   <item><description>ArtisticMarker &lt;a14:artisticMarker></description></item>
    ///   <item><description>ArtisticMosaicBubbles &lt;a14:artisticMosiaicBubbles></description></item>
    ///   <item><description>ArtisticPaintStrokes &lt;a14:artisticPaintStrokes></description></item>
    ///   <item><description>ArtisticPaintBrush &lt;a14:artisticPaintBrush></description></item>
    ///   <item><description>ArtisticPastelsSmooth &lt;a14:artisticPastelsSmooth></description></item>
    ///   <item><description>ArtisticPencilGrayscale &lt;a14:artisticPencilGrayscale></description></item>
    ///   <item><description>ArtisticPencilSketch &lt;a14:artisticPencilSketch></description></item>
    ///   <item><description>ArtisticPhotocopy &lt;a14:artisticPhotocopy></description></item>
    ///   <item><description>ArtisticPlasticWrap &lt;a14:artisticPlasticWrap></description></item>
    ///   <item><description>ArtisticTexturizer &lt;a14:artisticTexturizer></description></item>
    ///   <item><description>ArtisticWatercolorSponge &lt;a14:artisticWatercolorSponge></description></item>
    ///   <item><description>BackgroundRemoval &lt;a14:backgroundRemoval></description></item>
    ///   <item><description>BrightnessContrast &lt;a14:brightnessContrast></description></item>
    ///   <item><description>ColorTemperature &lt;a14:colorTemperature></description></item>
    ///   <item><description>Saturation &lt;a14:saturation></description></item>
    ///   <item><description>SharpenSoften &lt;a14:sharpenSoften></description></item>
    /// </list>
    /// </remark>
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
    [SchemaAttr(48, "imgEffect")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ImageEffect : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ImageEffect class.
        /// </summary>
        public ImageEffect() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImageEffect class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ImageEffect(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ImageEffect(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>visible, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr(0, "visible")]
        [Index(0)]
        public BooleanValue Visible { get; set; }

        /// <summary>
        /// <para>ArtisticBlur.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticBlur.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticBlur ArtisticBlur
        {
            get => GetElement<ArtisticBlur>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticCement.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticCement.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticCement ArtisticCement
        {
            get => GetElement<ArtisticCement>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticChalkSketch.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticChalkSketch.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticChalkSketch ArtisticChalkSketch
        {
            get => GetElement<ArtisticChalkSketch>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticCrisscrossEtching.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticCrisscrossEtching.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticCrisscrossEtching ArtisticCrisscrossEtching
        {
            get => GetElement<ArtisticCrisscrossEtching>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticCutout.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticCutout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticCutout ArtisticCutout
        {
            get => GetElement<ArtisticCutout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticFilmGrain.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticFilmGrain.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticFilmGrain ArtisticFilmGrain
        {
            get => GetElement<ArtisticFilmGrain>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticGlass.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticGlass.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticGlass ArtisticGlass
        {
            get => GetElement<ArtisticGlass>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticGlowDiffused.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticGlowDiffused.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticGlowDiffused ArtisticGlowDiffused
        {
            get => GetElement<ArtisticGlowDiffused>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticGlowEdges.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticGlowEdges.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticGlowEdges ArtisticGlowEdges
        {
            get => GetElement<ArtisticGlowEdges>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticLightScreen.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticLightScreen.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticLightScreen ArtisticLightScreen
        {
            get => GetElement<ArtisticLightScreen>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticLineDrawing.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticLineDrawing.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticLineDrawing ArtisticLineDrawing
        {
            get => GetElement<ArtisticLineDrawing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticMarker.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticMarker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticMarker ArtisticMarker
        {
            get => GetElement<ArtisticMarker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticMosaicBubbles.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticMosiaicBubbles.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticMosaicBubbles ArtisticMosaicBubbles
        {
            get => GetElement<ArtisticMosaicBubbles>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPaintStrokes.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPaintStrokes.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticPaintStrokes ArtisticPaintStrokes
        {
            get => GetElement<ArtisticPaintStrokes>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPaintBrush.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPaintBrush.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticPaintBrush ArtisticPaintBrush
        {
            get => GetElement<ArtisticPaintBrush>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPastelsSmooth.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPastelsSmooth.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticPastelsSmooth ArtisticPastelsSmooth
        {
            get => GetElement<ArtisticPastelsSmooth>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPencilGrayscale.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPencilGrayscale.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticPencilGrayscale ArtisticPencilGrayscale
        {
            get => GetElement<ArtisticPencilGrayscale>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPencilSketch.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPencilSketch.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticPencilSketch ArtisticPencilSketch
        {
            get => GetElement<ArtisticPencilSketch>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPhotocopy.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPhotocopy.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticPhotocopy ArtisticPhotocopy
        {
            get => GetElement<ArtisticPhotocopy>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPlasticWrap.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPlasticWrap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticPlasticWrap ArtisticPlasticWrap
        {
            get => GetElement<ArtisticPlasticWrap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticTexturizer.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticTexturizer.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticTexturizer ArtisticTexturizer
        {
            get => GetElement<ArtisticTexturizer>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticWatercolorSponge.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticWatercolorSponge.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ArtisticWatercolorSponge ArtisticWatercolorSponge
        {
            get => GetElement<ArtisticWatercolorSponge>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BackgroundRemoval.</para>
        /// <para>Represents the following element tag in the schema: a14:backgroundRemoval.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public BackgroundRemoval BackgroundRemoval
        {
            get => GetElement<BackgroundRemoval>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BrightnessContrast.</para>
        /// <para>Represents the following element tag in the schema: a14:brightnessContrast.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public BrightnessContrast BrightnessContrast
        {
            get => GetElement<BrightnessContrast>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColorTemperature.</para>
        /// <para>Represents the following element tag in the schema: a14:colorTemperature.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ColorTemperature ColorTemperature
        {
            get => GetElement<ColorTemperature>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Saturation.</para>
        /// <para>Represents the following element tag in the schema: a14:saturation.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public Saturation Saturation
        {
            get => GetElement<Saturation>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SharpenSoften.</para>
        /// <para>Represents the following element tag in the schema: a14:sharpenSoften.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public SharpenSoften SharpenSoften
        {
            get => GetElement<SharpenSoften>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Choice, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Saturation), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften), 1, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageEffect>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageLayer Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:imgLayer.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ImageEffect &lt;a14:imgEffect></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ImageEffect), FileFormatVersions.Office2010)]
    [SchemaAttr(48, "imgLayer")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class ImageLayer : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ImageLayer class.
        /// </summary>
        public ImageLayer() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImageLayer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ImageLayer(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public ImageLayer(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>embed, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r:embed</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr(19, "embed")]
        [Index(0)]
        public StringValue Embed { get; set; }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect), 0, 0, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageLayer>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualDrawingProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnHover &lt;a:hlinkHover></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList))]
    [SchemaAttr(48, "cNvPr")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class.
        /// </summary>
        public NonVisualDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public NonVisualDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "id")]
        [Index(0)]
        public UInt32Value Id { get; set; }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(1)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>descr</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>
        [SchemaAttr(0, "descr")]
        [Index(2)]
        public StringValue Description { get; set; }

        /// <summary>
        /// <para>hidden</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        [SchemaAttr(0, "hidden")]
        [Index(3)]
        public BooleanValue Hidden { get; set; }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr(0, "title")]
        [Index(4)]
        public StringValue Title { get; set; }

        /// <summary>
        /// <para>HyperlinkOnClick.</para>
        /// <para>Represents the following element tag in the schema: a:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick HyperlinkOnClick
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HyperlinkOnHover.</para>
        /// <para>Represents the following element tag in the schema: a:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover HyperlinkOnHover
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualDrawingPropertiesExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList NonVisualDrawingPropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualInkContentPartProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:cNvContentPartPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ContentPartLocks &lt;a14:cpLocks></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;a14:extLst></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(ContentPartLocks), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2010)]
    [SchemaAttr(48, "cNvContentPartPr")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class NonVisualInkContentPartProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualInkContentPartProperties class.
        /// </summary>
        public NonVisualInkContentPartProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualInkContentPartProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public NonVisualInkContentPartProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>isComment, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isComment</para>
        /// </summary>
        [SchemaAttr(0, "isComment")]
        [Index(0)]
        public BooleanValue IsComment { get; set; }

        /// <summary>
        /// <para>ContentPartLocks.</para>
        /// <para>Represents the following element tag in the schema: a14:cpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public ContentPartLocks ContentPartLocks
        {
            get => GetElement<ContentPartLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks), 0, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualInkContentPartProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualContentPartProperties Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:nvContentPartPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;a14:cNvPr></description></item>
    ///   <item><description>NonVisualInkContentPartProperties &lt;a14:cNvContentPartPr></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(NonVisualDrawingProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NonVisualInkContentPartProperties), FileFormatVersions.Office2010)]
    [SchemaAttr(48, "nvContentPartPr")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class NonVisualContentPartProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualContentPartProperties class.
        /// </summary>
        public NonVisualContentPartProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualContentPartProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualContentPartProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public NonVisualContentPartProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: a14:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualInkContentPartProperties.</para>
        /// <para>Represents the following element tag in the schema: a14:cNvContentPartPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public NonVisualInkContentPartProperties NonVisualInkContentPartProperties
        {
            get => GetElement<NonVisualInkContentPartProperties>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.NonVisualDrawingProperties), 1, 1, version: FileFormatVersions.Office2010),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.NonVisualInkContentPartProperties), 0, 1, version: FileFormatVersions.Office2010)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualContentPartProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the Transform2D Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:xfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Offset &lt;a:off></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extents &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Offset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extents))]
    [SchemaAttr(48, "xfrm")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class Transform2D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transform2D class.
        /// </summary>
        public Transform2D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform2D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Transform2D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>
        [SchemaAttr(0, "rot")]
        [Index(0)]
        public Int32Value Rotation { get; set; }

        /// <summary>
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>
        [SchemaAttr(0, "flipH")]
        [Index(1)]
        public BooleanValue HorizontalFlip { get; set; }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>
        [SchemaAttr(0, "flipV")]
        [Index(2)]
        public BooleanValue VerticalFlip { get; set; }

        /// <summary>
        /// <para>Offset.</para>
        /// <para>Represents the following element tag in the schema: a:off.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Offset Offset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extents.</para>
        /// <para>Represents the following element tag in the schema: a:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Extents Extents
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>();
            set => SetElement(value);
        }

        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Offset), 0, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extents), 0, 1)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);
    }
}