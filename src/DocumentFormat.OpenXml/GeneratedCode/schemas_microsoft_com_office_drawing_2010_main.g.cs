// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
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
        public StringValue CellRange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>spid, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        public StringValue ShapeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "cameraTool");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<CameraTool>()
.AddAttribute(0, "cellRange", a => a.CellRange)
.AddAttribute(0, "spid", a => a.ShapeId);
            builder.AddConstraint(new AttributeValuePatternConstraint(1 /*:spid*/, @"_x0000_s(102[5-9]|10[3-9][0-9]|1[1-9][0-9]{2}|[1-9][0-9]{3,7}|1[0-9]{8}|2[0-5][0-9]{7}|26[0-7][0-9]{6}|268[0-3][0-9]{5}|2684[0-2][0-9]{4}|26843[0-4][0-9]{3}|268435[0-3][0-9]{2}|2684354[0-4][0-9]|26843545[0-6])") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CameraTool>(deep);
    }

    /// <summary>
    /// <para>Defines the CompatExtension Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:compatExt.</para>
    /// </summary>
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
        public StringValue ShapeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "compatExt");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<CompatExtension>()
.AddAttribute(0, "spid", a => a.ShapeId);
            builder.AddConstraint(new AttributeValuePatternConstraint(0 /*:spid*/, @"_x0000_s(102[5-9]|10[3-9][0-9]|1[1-9][0-9]{2}|[1-9][0-9]{3,7}|1[0-9]{8}|2[0-5][0-9]{7}|26[0-7][0-9]{6}|268[0-3][0-9]{5}|2684[0-2][0-9]{4}|26843[0-4][0-9]{3}|268435[0-3][0-9]{2}|2684354[0-4][0-9]|26843545[0-6])") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CompatExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the IsCanvas Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:isCanvas.</para>
    /// </summary>
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
        public BooleanValue Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "isCanvas");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<IsCanvas>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

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
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue RelationshipId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "contentPart");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<NonVisualContentPartProperties>();
            builder.AddChild<Transform2D>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<GvmlContentPart>()
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(19, "id", a => a.RelationshipId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.NonVisualContentPartProperties), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Transform2D), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GvmlContentPart>(deep);
    }

    /// <summary>
    /// <para>Defines the ShadowObscured Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:shadowObscured.</para>
    /// </summary>
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
        public BooleanValue Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "shadowObscured");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ShadowObscured>()
.AddAttribute(0, "val", a => a.Val);
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "hiddenFill");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
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
        public Int32Value Width
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Ending Cap Type</para>
        /// <para>Represents the following attribute in the schema: cap</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues> CapType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Compound Line Type</para>
        /// <para>Represents the following attribute in the schema: cmpd</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues> CompoundLineType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Alignment</para>
        /// <para>Represents the following attribute in the schema: algn</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues> Alignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "hiddenLine");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomDash>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Round>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Miter>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HeadEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TailEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<HiddenLineProperties>()
.AddAttribute(0, "w", a => a.Width, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (20116800L) });
})
.AddAttribute(0, "cap", a => a.CapType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "cmpd", a => a.CompoundLineType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "algn", a => a.Alignment, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "hiddenEffects");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                }
            };
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "hiddenScene3d");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Camera>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LightRig>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Backdrop>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Camera), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LightRig), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Backdrop), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
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
        public Int64Value Z
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Height</para>
        /// <para>Represents the following attribute in the schema: extrusionH</para>
        /// </summary>
        public Int64Value ExtrusionHeight
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Contour Width</para>
        /// <para>Represents the following attribute in the schema: contourW</para>
        /// </summary>
        public Int64Value ContourWidth
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Preset Material Type</para>
        /// <para>Represents the following attribute in the schema: prstMaterial</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues> PresetMaterial
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "hiddenSp3d");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BevelTop>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BevelBottom>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<HiddenShape3D>()
.AddAttribute(0, "z", a => a.Z, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "extrusionH", a => a.ExtrusionHeight, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "contourW", a => a.ContourWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "prstMaterial", a => a.PresetMaterial, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BevelTop), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BevelBottom), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtrusionColor), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ContourColor), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "imgProps");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ImageLayer>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer), 1, 1, version: FileFormatVersions.Office2010)
            };
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the UseLocalDpi Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:useLocalDpi.</para>
    /// </summary>
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
        public BooleanValue Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "useLocalDpi");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<UseLocalDpi>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UseLocalDpi>(deep);
    }

    /// <summary>
    /// <para>Defines the TextMath Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:m.</para>
    /// </summary>
    public partial class TextMath : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextMath class.
        /// </summary>
        public TextMath() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "m");
            builder.Availability = FileFormatVersions.Office2010;
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "extLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                    }
                }
            };
        }

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
        public BooleanValue NoGrouping
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Selection</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>
        public BooleanValue NoSelection
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Rotation</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>
        public BooleanValue NoRotation
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Aspect Ratio Change</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>
        public BooleanValue NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Movement</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>
        public BooleanValue NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Resize</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>
        public BooleanValue NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Point Editing</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>
        public BooleanValue NoEditPoints
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Showing Adjust Handles</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>
        public BooleanValue NoAdjustHandles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Arrowhead Changes</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>
        public BooleanValue NoChangeArrowheads
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Type Change</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>
        public BooleanValue NoChangeShapeType
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "cpLocks");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<ContentPartLocks>()
.AddAttribute(0, "noGrp", a => a.NoGrouping)
.AddAttribute(0, "noSelect", a => a.NoSelection)
.AddAttribute(0, "noRot", a => a.NoRotation)
.AddAttribute(0, "noChangeAspect", a => a.NoChangeAspect)
.AddAttribute(0, "noMove", a => a.NoMove)
.AddAttribute(0, "noResize", a => a.NoResize)
.AddAttribute(0, "noEditPoints", a => a.NoEditPoints)
.AddAttribute(0, "noAdjustHandles", a => a.NoAdjustHandles)
.AddAttribute(0, "noChangeArrowheads", a => a.NoChangeArrowheads)
.AddAttribute(0, "noChangeShapeType", a => a.NoChangeShapeType);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentPartLocks>(deep);
    }

    /// <summary>
    /// <para>Defines the ForegroundMark Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:foregroundMark.</para>
    /// </summary>
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
        public Int32Value FirstXCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y1, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: y1</para>
        /// </summary>
        public Int32Value FirstYCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x2, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: x2</para>
        /// </summary>
        public Int32Value SecondXCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y2, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: y2</para>
        /// </summary>
        public Int32Value SecondYCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "foregroundMark");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ForegroundMark>()
.AddAttribute(0, "x1", a => a.FirstXCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "y1", a => a.FirstYCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "x2", a => a.SecondXCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "y2", a => a.SecondYCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ForegroundMark>(deep);
    }

    /// <summary>
    /// <para>Defines the BackgroundMark Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:backgroundMark.</para>
    /// </summary>
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
        public Int32Value FirstXCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y1, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: y1</para>
        /// </summary>
        public Int32Value FirstYCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x2, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: x2</para>
        /// </summary>
        public Int32Value SecondXCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y2, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: y2</para>
        /// </summary>
        public Int32Value SecondYCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "backgroundMark");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackgroundMark>()
.AddAttribute(0, "x1", a => a.FirstXCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "y1", a => a.FirstYCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "x2", a => a.SecondXCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "y2", a => a.SecondYCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundMark>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticBlur Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticBlur.</para>
    /// </summary>
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
        public Int32Value Radius
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticBlur");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticBlur>()
.AddAttribute(0, "radius", a => a.Radius, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticBlur>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticCement Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticCement.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>crackSpacing, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: crackSpacing</para>
        /// </summary>
        public Int32Value CrackSpacing
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticCement");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticCement>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "crackSpacing", a => a.CrackSpacing, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCement>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticChalkSketch Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticChalkSketch.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pressure, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>
        public Int32Value Pressure
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticChalkSketch");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticChalkSketch>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "pressure", a => a.Pressure, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (4L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticChalkSketch>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticCrisscrossEtching Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticCrisscrossEtching.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pressure, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>
        public Int32Value Pressure
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticCrisscrossEtching");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticCrisscrossEtching>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "pressure", a => a.Pressure, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCrisscrossEtching>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticCutout Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticCutout.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>numberOfShades, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: numberOfShades</para>
        /// </summary>
        public Int32Value NumberOfShades
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticCutout");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticCutout>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "numberOfShades", a => a.NumberOfShades, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (6L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCutout>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticFilmGrain Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticFilmGrain.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grainSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: grainSize</para>
        /// </summary>
        public Int32Value GrainSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticFilmGrain");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticFilmGrain>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "grainSize", a => a.GrainSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticFilmGrain>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticGlass Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticGlass.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scaling, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: scaling</para>
        /// </summary>
        public Int32Value Scaling
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticGlass");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticGlass>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "scaling", a => a.Scaling, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlass>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticGlowDiffused Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticGlowDiffused.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>intensity, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: intensity</para>
        /// </summary>
        public Int32Value Intensity
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticGlowDiffused");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticGlowDiffused>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "intensity", a => a.Intensity, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlowDiffused>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticGlowEdges Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticGlowEdges.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>smoothness, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: smoothness</para>
        /// </summary>
        public Int32Value Smoothness
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticGlowEdges");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticGlowEdges>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "smoothness", a => a.Smoothness, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlowEdges>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticLightScreen Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticLightScreen.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>gridSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: gridSize</para>
        /// </summary>
        public Int32Value GridSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticLightScreen");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticLightScreen>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "gridSize", a => a.GridSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticLightScreen>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticLineDrawing Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticLineDrawing.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pencilSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pencilSize</para>
        /// </summary>
        public Int32Value PencilSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticLineDrawing");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticLineDrawing>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "pencilSize", a => a.PencilSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticLineDrawing>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticMarker Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticMarker.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>size, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        public Int32Value Size
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticMarker");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticMarker>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "size", a => a.Size, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticMarker>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticMosaicBubbles Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticMosiaicBubbles.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pressure, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>
        public Int32Value Pressure
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticMosiaicBubbles");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticMosaicBubbles>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "pressure", a => a.Pressure, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticMosaicBubbles>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPaintStrokes Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPaintStrokes.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>intensity, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: intensity</para>
        /// </summary>
        public Int32Value Intensity
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticPaintStrokes");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPaintStrokes>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "intensity", a => a.Intensity, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPaintStrokes>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPaintBrush Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPaintBrush.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: brushSize</para>
        /// </summary>
        public Int32Value BrushSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticPaintBrush");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPaintBrush>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "brushSize", a => a.BrushSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPaintBrush>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPastelsSmooth Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPastelsSmooth.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scaling, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: scaling</para>
        /// </summary>
        public Int32Value BrushSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticPastelsSmooth");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPastelsSmooth>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "scaling", a => a.BrushSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPastelsSmooth>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPencilGrayscale Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPencilGrayscale.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pencilSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pencilSize</para>
        /// </summary>
        public Int32Value BrushSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticPencilGrayscale");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPencilGrayscale>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "pencilSize", a => a.BrushSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPencilGrayscale>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPencilSketch Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPencilSketch.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pressure, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>
        public Int32Value Pressure
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticPencilSketch");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPencilSketch>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "pressure", a => a.Pressure, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPencilSketch>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPhotocopy Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPhotocopy.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>detail, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: detail</para>
        /// </summary>
        public Int32Value Detail
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticPhotocopy");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPhotocopy>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "detail", a => a.Detail, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPhotocopy>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPlasticWrap Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPlasticWrap.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>smoothness, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: smoothness</para>
        /// </summary>
        public Int32Value Smoothness
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticPlasticWrap");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPlasticWrap>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "smoothness", a => a.Smoothness, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPlasticWrap>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticTexturizer Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticTexturizer.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scaling, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: scaling</para>
        /// </summary>
        public Int32Value Scaling
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticTexturizer");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticTexturizer>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "scaling", a => a.Scaling, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticTexturizer>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticWatercolorSponge Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticWatercolorSponge.</para>
    /// </summary>
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
        public Int32Value Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushSize, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: brushSize</para>
        /// </summary>
        public Int32Value BrushSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "artisticWatercolorSponge");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticWatercolorSponge>()
.AddAttribute(0, "trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "brushSize", a => a.BrushSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

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
        public Int32Value MarqueeTop
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>
        public Int32Value MarqueeBottom
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>l, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>
        public Int32Value MarqueeLeft
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        public Int32Value MarqueeRight
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "backgroundRemoval");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ForegroundMark>();
            builder.AddChild<BackgroundMark>();
            builder.AddElement<BackgroundRemoval>()
.AddAttribute(0, "t", a => a.MarqueeTop, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "b", a => a.MarqueeBottom, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "l", a => a.MarqueeLeft, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "r", a => a.MarqueeRight, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark), 0, 0, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundRemoval>(deep);
    }

    /// <summary>
    /// <para>Defines the BrightnessContrast Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:brightnessContrast.</para>
    /// </summary>
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
        public Int32Value Bright
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contrast, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: contrast</para>
        /// </summary>
        public Int32Value Contrast
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "brightnessContrast");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BrightnessContrast>()
.AddAttribute(0, "bright", a => a.Bright, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-100000L), MaxInclusive = (100000L) });
})
.AddAttribute(0, "contrast", a => a.Contrast, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-100000L), MaxInclusive = (100000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BrightnessContrast>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorTemperature Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:colorTemperature.</para>
    /// </summary>
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
        public Int32Value ColorTemperatureValue
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "colorTemperature");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ColorTemperature>()
.AddAttribute(0, "colorTemp", a => a.ColorTemperatureValue, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1500L), MaxInclusive = (11500L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTemperature>(deep);
    }

    /// <summary>
    /// <para>Defines the Saturation Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:saturation.</para>
    /// </summary>
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
        public Int32Value SaturationAmount
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "saturation");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Saturation>()
.AddAttribute(0, "sat", a => a.SaturationAmount, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (400000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Saturation>(deep);
    }

    /// <summary>
    /// <para>Defines the SharpenSoften Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:sharpenSoften.</para>
    /// </summary>
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
        public Int32Value Amount
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "sharpenSoften");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SharpenSoften>()
.AddAttribute(0, "amount", a => a.Amount, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-100000L), MaxInclusive = (100000L) });
});
        }

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
        public BooleanValue Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "imgEffect");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ArtisticBlur>();
            builder.AddChild<ArtisticCement>();
            builder.AddChild<ArtisticChalkSketch>();
            builder.AddChild<ArtisticCrisscrossEtching>();
            builder.AddChild<ArtisticCutout>();
            builder.AddChild<ArtisticFilmGrain>();
            builder.AddChild<ArtisticGlass>();
            builder.AddChild<ArtisticGlowDiffused>();
            builder.AddChild<ArtisticGlowEdges>();
            builder.AddChild<ArtisticLightScreen>();
            builder.AddChild<ArtisticLineDrawing>();
            builder.AddChild<ArtisticMarker>();
            builder.AddChild<ArtisticMosaicBubbles>();
            builder.AddChild<ArtisticPaintStrokes>();
            builder.AddChild<ArtisticPaintBrush>();
            builder.AddChild<ArtisticPastelsSmooth>();
            builder.AddChild<ArtisticPencilGrayscale>();
            builder.AddChild<ArtisticPencilSketch>();
            builder.AddChild<ArtisticPhotocopy>();
            builder.AddChild<ArtisticPlasticWrap>();
            builder.AddChild<ArtisticTexturizer>();
            builder.AddChild<ArtisticWatercolorSponge>();
            builder.AddChild<BackgroundRemoval>();
            builder.AddChild<BrightnessContrast>();
            builder.AddChild<ColorTemperature>();
            builder.AddChild<Saturation>();
            builder.AddChild<SharpenSoften>();
            builder.AddElement<ImageEffect>()
.AddAttribute(0, "visible", a => a.Visible);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
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
            };
        }

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
        public StringValue Embed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "imgLayer");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ImageEffect>();
            builder.AddElement<ImageLayer>()
.AddAttribute(19, "embed", a => a.Embed);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

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
        public UInt32Value Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>descr</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        public BooleanValue Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "cNvPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            builder.AddElement<NonVisualDrawingProperties>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "descr", a => a.Description)
.AddAttribute(0, "hidden", a => a.Hidden)
.AddAttribute(0, "title", a => a.Title);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
            };
        }

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
        public BooleanValue IsComment
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "cNvContentPartPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<ContentPartLocks>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<NonVisualInkContentPartProperties>()
.AddAttribute(0, "isComment", a => a.IsComment);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "nvContentPartPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<NonVisualDrawingProperties>();
            builder.AddChild<NonVisualInkContentPartProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.NonVisualDrawingProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.NonVisualInkContentPartProperties), 0, 1, version: FileFormatVersions.Office2010)
            };
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
        public Int32Value Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>
        public BooleanValue HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>
        public BooleanValue VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(48, "xfrm");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Offset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extents>();
            builder.AddElement<Transform2D>()
.AddAttribute(0, "rot", a => a.Rotation)
.AddAttribute(0, "flipH", a => a.HorizontalFlip)
.AddAttribute(0, "flipV", a => a.VerticalFlip);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Offset), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extents), 0, 1)
            };
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);
    }
}