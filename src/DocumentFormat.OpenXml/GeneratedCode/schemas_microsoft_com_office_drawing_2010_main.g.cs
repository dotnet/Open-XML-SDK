﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:cameraTool.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:cameraTool")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CameraTool : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CameraTool class.
        /// </summary>
        public CameraTool() : base()
        {
        }

        /// <summary>
        /// <para>cellRange, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: cellRange</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cellRange")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? CellRange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>spid, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ShapeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:cameraTool");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<CameraTool>()
.AddAttribute("cellRange", a => a.CellRange)
.AddAttribute("spid", a => a.ShapeId);
            builder.AddConstraint(new AttributeValuePatternConstraint(":spid", @"_x0000_s(102[5-9]|10[3-9][0-9]|1[1-9][0-9]{2}|[1-9][0-9]{3,7}|1[0-9]{8}|2[0-5][0-9]{7}|26[0-7][0-9]{6}|268[0-3][0-9]{5}|2684[0-2][0-9]{4}|26843[0-4][0-9]{3}|268435[0-3][0-9]{2}|2684354[0-4][0-9]|26843545[0-6])") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CameraTool>(deep);
    }

    /// <summary>
    /// <para>Defines the CompatExtension Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:compatExt.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:compatExt")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CompatExtension : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CompatExtension class.
        /// </summary>
        public CompatExtension() : base()
        {
        }

        /// <summary>
        /// <para>spid, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("spid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ShapeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:compatExt");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<CompatExtension>()
.AddAttribute("spid", a => a.ShapeId);
            builder.AddConstraint(new AttributeValuePatternConstraint(":spid", @"_x0000_s(102[5-9]|10[3-9][0-9]|1[1-9][0-9]{2}|[1-9][0-9]{3,7}|1[0-9]{8}|2[0-5][0-9]{7}|26[0-7][0-9]{6}|268[0-3][0-9]{5}|2684[0-2][0-9]{4}|26843[0-4][0-9]{3}|268435[0-3][0-9]{2}|2684354[0-4][0-9]|26843545[0-6])") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CompatExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the IsCanvas Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:isCanvas.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:isCanvas")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class IsCanvas : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the IsCanvas class.
        /// </summary>
        public IsCanvas() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:isCanvas");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<IsCanvas>()
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IsCanvas>(deep);
    }

    /// <summary>
    /// <para>Defines the GvmlContentPart Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:contentPart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList" /> <c>&lt;a14:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Transform2D" /> <c>&lt;a14:xfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.NonVisualContentPartProperties" /> <c>&lt;a14:nvContentPartPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:contentPart")]
#pragma warning restore CS0618 // Type or member is obsolete
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
        /// <para>bwMode, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? RelationshipId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:contentPart");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Transform2D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.NonVisualContentPartProperties>();
            builder.AddElement<GvmlContentPart>()
.AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("r:id", a => a.RelationshipId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2010.Drawing.NonVisualContentPartProperties? NonVisualContentPartProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.NonVisualContentPartProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transform2D.</para>
        /// <para>Represents the following element tag in the schema: a14:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GvmlContentPart>(deep);
    }

    /// <summary>
    /// <para>Defines the ShadowObscured Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:shadowObscured.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:shadowObscured")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShadowObscured : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShadowObscured class.
        /// </summary>
        public ShadowObscured() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:shadowObscured");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ShadowObscured>()
.AddAttribute("val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShadowObscured>(deep);
    }

    /// <summary>
    /// <para>Defines the HiddenFillProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:hiddenFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:hiddenFill")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("a14:hiddenFill");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
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
        public DocumentFormat.OpenXml.Drawing.NoFill? NoFill
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
        public DocumentFormat.OpenXml.Drawing.SolidFill? SolidFill
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
        public DocumentFormat.OpenXml.Drawing.GradientFill? GradientFill
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
        public DocumentFormat.OpenXml.Drawing.BlipFill? BlipFill
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
        public DocumentFormat.OpenXml.Drawing.PatternFill? PatternFill
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
        public DocumentFormat.OpenXml.Drawing.GroupFill? GroupFill
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GroupFill>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenFillProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the HiddenLineProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:hiddenLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CustomDash" /> <c>&lt;a:custDash></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HeadEnd" /> <c>&lt;a:headEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.TailEnd" /> <c>&lt;a:tailEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LineJoinBevel" /> <c>&lt;a:bevel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Miter" /> <c>&lt;a:miter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Round" /> <c>&lt;a:round></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetDash" /> <c>&lt;a:prstDash></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:hiddenLine")]
#pragma warning restore CS0618 // Type or member is obsolete
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
        /// <para>line width</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("w")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Width
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>line cap</para>
        /// <para>Represents the following attribute in the schema: cap</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues>? CapType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>compound line type</para>
        /// <para>Represents the following attribute in the schema: cmpd</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cmpd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues>? CompoundLineType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pen alignment</para>
        /// <para>Represents the following attribute in the schema: algn</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("algn")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues>? Alignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:hiddenLine");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomDash>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HeadEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TailEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Miter>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Round>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddElement<HiddenLineProperties>()
.AddAttribute("w", a => a.Width, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (20116800L) });
})
.AddAttribute("cap", a => a.CapType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("cmpd", a => a.CompoundLineType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("algn", a => a.Alignment, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetDash), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomDash), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Round), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineJoinBevel), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Miter), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HeadEnd), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TailEnd), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenLineProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the HiddenEffectsProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:hiddenEffects.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:hiddenEffects")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("a14:hiddenEffects");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
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
        public DocumentFormat.OpenXml.Drawing.EffectList? EffectList
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
        public DocumentFormat.OpenXml.Drawing.EffectDag? EffectDag
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EffectDag>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenEffectsProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the HiddenScene3D Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:hiddenScene3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Backdrop" /> <c>&lt;a:backdrop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Camera" /> <c>&lt;a:camera></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LightRig" /> <c>&lt;a:lightRig></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:hiddenScene3d")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("a14:hiddenScene3d");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Backdrop>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Camera>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LightRig>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Drawing.Camera? Camera
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
        public DocumentFormat.OpenXml.Drawing.LightRig? LightRig
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
        public DocumentFormat.OpenXml.Drawing.Backdrop? Backdrop
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
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenScene3D>(deep);
    }

    /// <summary>
    /// <para>Defines the HiddenShape3D Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:hiddenSp3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BevelTop" /> <c>&lt;a:bevelT></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BevelBottom" /> <c>&lt;a:bevelB></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtrusionColor" /> <c>&lt;a:extrusionClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ContourColor" /> <c>&lt;a:contourClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:hiddenSp3d")]
#pragma warning restore CS0618 // Type or member is obsolete
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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("z")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Z
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Height</para>
        /// <para>Represents the following attribute in the schema: extrusionH</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("extrusionH")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? ExtrusionHeight
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Contour Width</para>
        /// <para>Represents the following attribute in the schema: contourW</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("contourW")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? ContourWidth
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Preset Material Type</para>
        /// <para>Represents the following attribute in the schema: prstMaterial</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("prstMaterial")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues>? PresetMaterial
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:hiddenSp3d");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BevelTop>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BevelBottom>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<HiddenShape3D>()
.AddAttribute("z", a => a.Z, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute("extrusionH", a => a.ExtrusionHeight, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute("contourW", a => a.ContourWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute("prstMaterial", a => a.PresetMaterial, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Drawing.BevelTop? BevelTop
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
        public DocumentFormat.OpenXml.Drawing.BevelBottom? BevelBottom
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
        public DocumentFormat.OpenXml.Drawing.ExtrusionColor? ExtrusionColor
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
        public DocumentFormat.OpenXml.Drawing.ContourColor? ContourColor
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
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenShape3D>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:imgProps.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer" /> <c>&lt;a14:imgLayer></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:imgProps")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("a14:imgProps");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? ImageLayer
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the UseLocalDpi Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:useLocalDpi.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:useLocalDpi")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class UseLocalDpi : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UseLocalDpi class.
        /// </summary>
        public UseLocalDpi() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:useLocalDpi");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<UseLocalDpi>()
.AddAttribute("val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UseLocalDpi>(deep);
    }

    /// <summary>
    /// <para>Defines the TextMath Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:m.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:m")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("a14:m");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextMath>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("a14:extLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:cpLocks.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList" /> <c>&lt;a14:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:cpLocks")]
#pragma warning restore CS0618 // Type or member is obsolete
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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noGrp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoGrouping
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Selection</para>
        /// <para>Represents the following attribute in the schema: noSelect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noSelect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoSelection
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Rotation</para>
        /// <para>Represents the following attribute in the schema: noRot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noRot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoRotation
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Aspect Ratio Change</para>
        /// <para>Represents the following attribute in the schema: noChangeAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeAspect
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Movement</para>
        /// <para>Represents the following attribute in the schema: noMove</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noMove")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoMove
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Resize</para>
        /// <para>Represents the following attribute in the schema: noResize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noResize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Point Editing</para>
        /// <para>Represents the following attribute in the schema: noEditPoints</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noEditPoints")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoEditPoints
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Showing Adjust Handles</para>
        /// <para>Represents the following attribute in the schema: noAdjustHandles</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noAdjustHandles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoAdjustHandles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Arrowhead Changes</para>
        /// <para>Represents the following attribute in the schema: noChangeArrowheads</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeArrowheads")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeArrowheads
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Disallow Shape Type Change</para>
        /// <para>Represents the following attribute in the schema: noChangeShapeType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("noChangeShapeType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? NoChangeShapeType
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:cpLocks");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
            builder.AddElement<ContentPartLocks>()
.AddAttribute("noGrp", a => a.NoGrouping)
.AddAttribute("noSelect", a => a.NoSelection)
.AddAttribute("noRot", a => a.NoRotation)
.AddAttribute("noChangeAspect", a => a.NoChangeAspect)
.AddAttribute("noMove", a => a.NoMove)
.AddAttribute("noResize", a => a.NoResize)
.AddAttribute("noEditPoints", a => a.NoEditPoints)
.AddAttribute("noAdjustHandles", a => a.NoAdjustHandles)
.AddAttribute("noChangeArrowheads", a => a.NoChangeArrowheads)
.AddAttribute("noChangeShapeType", a => a.NoChangeShapeType);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentPartLocks>(deep);
    }

    /// <summary>
    /// <para>Defines the ForegroundMark Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:foregroundMark.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:foregroundMark")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ForegroundMark : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ForegroundMark class.
        /// </summary>
        public ForegroundMark() : base()
        {
        }

        /// <summary>
        /// <para>x1, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: x1</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("x1")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? FirstXCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y1, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: y1</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("y1")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? FirstYCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x2, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: x2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("x2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? SecondXCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y2, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: y2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("y2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? SecondYCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:foregroundMark");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ForegroundMark>()
.AddAttribute("x1", a => a.FirstXCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("y1", a => a.FirstYCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("x2", a => a.SecondXCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("y2", a => a.SecondYCoordinate, aBuilder =>
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:backgroundMark.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:backgroundMark")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BackgroundMark : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundMark class.
        /// </summary>
        public BackgroundMark() : base()
        {
        }

        /// <summary>
        /// <para>x1, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: x1</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("x1")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? FirstXCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y1, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: y1</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("y1")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? FirstYCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x2, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: x2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("x2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? SecondXCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y2, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: y2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("y2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? SecondYCoordinate
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:backgroundMark");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackgroundMark>()
.AddAttribute("x1", a => a.FirstXCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("y1", a => a.FirstYCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("x2", a => a.SecondXCoordinate, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("y2", a => a.SecondYCoordinate, aBuilder =>
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticBlur.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticBlur")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticBlur : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticBlur class.
        /// </summary>
        public ArtisticBlur() : base()
        {
        }

        /// <summary>
        /// <para>radius, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: radius</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("radius")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Radius
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticBlur");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticBlur>()
.AddAttribute("radius", a => a.Radius, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticBlur>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticCement Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticCement.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticCement")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticCement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticCement class.
        /// </summary>
        public ArtisticCement() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>crackSpacing, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: crackSpacing</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("crackSpacing")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? CrackSpacing
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticCement");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticCement>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("crackSpacing", a => a.CrackSpacing, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCement>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticChalkSketch Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticChalkSketch.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticChalkSketch")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticChalkSketch : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticChalkSketch class.
        /// </summary>
        public ArtisticChalkSketch() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pressure, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("pressure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Pressure
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticChalkSketch");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticChalkSketch>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("pressure", a => a.Pressure, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (4L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticChalkSketch>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticCrisscrossEtching Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticCrisscrossEtching.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticCrisscrossEtching")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticCrisscrossEtching : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticCrisscrossEtching class.
        /// </summary>
        public ArtisticCrisscrossEtching() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pressure, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("pressure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Pressure
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticCrisscrossEtching");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticCrisscrossEtching>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("pressure", a => a.Pressure, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCrisscrossEtching>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticCutout Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticCutout.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticCutout")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticCutout : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticCutout class.
        /// </summary>
        public ArtisticCutout() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>numberOfShades, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: numberOfShades</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("numberOfShades")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? NumberOfShades
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticCutout");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticCutout>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("numberOfShades", a => a.NumberOfShades, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (6L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticCutout>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticFilmGrain Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticFilmGrain.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticFilmGrain")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticFilmGrain : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticFilmGrain class.
        /// </summary>
        public ArtisticFilmGrain() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grainSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: grainSize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("grainSize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? GrainSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticFilmGrain");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticFilmGrain>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("grainSize", a => a.GrainSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticFilmGrain>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticGlass Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticGlass.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticGlass")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticGlass : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticGlass class.
        /// </summary>
        public ArtisticGlass() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scaling, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: scaling</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("scaling")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Scaling
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticGlass");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticGlass>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("scaling", a => a.Scaling, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlass>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticGlowDiffused Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticGlowDiffused.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticGlowDiffused")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticGlowDiffused : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticGlowDiffused class.
        /// </summary>
        public ArtisticGlowDiffused() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>intensity, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: intensity</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("intensity")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Intensity
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticGlowDiffused");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticGlowDiffused>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("intensity", a => a.Intensity, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlowDiffused>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticGlowEdges Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticGlowEdges.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticGlowEdges")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticGlowEdges : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticGlowEdges class.
        /// </summary>
        public ArtisticGlowEdges() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>smoothness, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: smoothness</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("smoothness")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Smoothness
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticGlowEdges");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticGlowEdges>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("smoothness", a => a.Smoothness, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticGlowEdges>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticLightScreen Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticLightScreen.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticLightScreen")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticLightScreen : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticLightScreen class.
        /// </summary>
        public ArtisticLightScreen() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>gridSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: gridSize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("gridSize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? GridSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticLightScreen");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticLightScreen>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("gridSize", a => a.GridSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticLightScreen>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticLineDrawing Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticLineDrawing.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticLineDrawing")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticLineDrawing : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticLineDrawing class.
        /// </summary>
        public ArtisticLineDrawing() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pencilSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: pencilSize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("pencilSize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? PencilSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticLineDrawing");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticLineDrawing>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("pencilSize", a => a.PencilSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticLineDrawing>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticMarker Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticMarker.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticMarker")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticMarker : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticMarker class.
        /// </summary>
        public ArtisticMarker() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>size, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("size")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Size
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticMarker");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticMarker>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("size", a => a.Size, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticMarker>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticMosaicBubbles Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticMosiaicBubbles.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticMosiaicBubbles")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticMosaicBubbles : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticMosaicBubbles class.
        /// </summary>
        public ArtisticMosaicBubbles() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pressure, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("pressure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Pressure
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticMosiaicBubbles");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticMosaicBubbles>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("pressure", a => a.Pressure, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticMosaicBubbles>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPaintStrokes Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPaintStrokes.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticPaintStrokes")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticPaintStrokes : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPaintStrokes class.
        /// </summary>
        public ArtisticPaintStrokes() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>intensity, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: intensity</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("intensity")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Intensity
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticPaintStrokes");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPaintStrokes>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("intensity", a => a.Intensity, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPaintStrokes>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPaintBrush Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPaintBrush.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticPaintBrush")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticPaintBrush : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPaintBrush class.
        /// </summary>
        public ArtisticPaintBrush() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: brushSize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("brushSize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? BrushSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticPaintBrush");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPaintBrush>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("brushSize", a => a.BrushSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPaintBrush>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPastelsSmooth Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPastelsSmooth.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticPastelsSmooth")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticPastelsSmooth : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPastelsSmooth class.
        /// </summary>
        public ArtisticPastelsSmooth() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scaling, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: scaling</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("scaling")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? BrushSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticPastelsSmooth");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPastelsSmooth>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("scaling", a => a.BrushSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPastelsSmooth>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPencilGrayscale Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPencilGrayscale.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticPencilGrayscale")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticPencilGrayscale : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPencilGrayscale class.
        /// </summary>
        public ArtisticPencilGrayscale() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pencilSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: pencilSize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("pencilSize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? BrushSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticPencilGrayscale");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPencilGrayscale>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("pencilSize", a => a.BrushSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPencilGrayscale>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPencilSketch Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPencilSketch.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticPencilSketch")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticPencilSketch : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPencilSketch class.
        /// </summary>
        public ArtisticPencilSketch() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pressure, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: pressure</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("pressure")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Pressure
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticPencilSketch");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPencilSketch>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("pressure", a => a.Pressure, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPencilSketch>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPhotocopy Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPhotocopy.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticPhotocopy")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticPhotocopy : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPhotocopy class.
        /// </summary>
        public ArtisticPhotocopy() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>detail, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: detail</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("detail")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Detail
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticPhotocopy");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPhotocopy>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("detail", a => a.Detail, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPhotocopy>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticPlasticWrap Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticPlasticWrap.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticPlasticWrap")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticPlasticWrap : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticPlasticWrap class.
        /// </summary>
        public ArtisticPlasticWrap() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>smoothness, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: smoothness</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("smoothness")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Smoothness
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticPlasticWrap");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticPlasticWrap>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("smoothness", a => a.Smoothness, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticPlasticWrap>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticTexturizer Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticTexturizer.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticTexturizer")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticTexturizer : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticTexturizer class.
        /// </summary>
        public ArtisticTexturizer() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scaling, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: scaling</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("scaling")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Scaling
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticTexturizer");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticTexturizer>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("scaling", a => a.Scaling, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticTexturizer>(deep);
    }

    /// <summary>
    /// <para>Defines the ArtisticWatercolorSponge Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:artisticWatercolorSponge.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:artisticWatercolorSponge")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArtisticWatercolorSponge : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArtisticWatercolorSponge class.
        /// </summary>
        public ArtisticWatercolorSponge() : base()
        {
        }

        /// <summary>
        /// <para>trans, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: trans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("trans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Transparancy
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: brushSize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("brushSize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? BrushSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:artisticWatercolorSponge");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ArtisticWatercolorSponge>()
.AddAttribute("trans", a => a.Transparancy, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("brushSize", a => a.BrushSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArtisticWatercolorSponge>(deep);
    }

    /// <summary>
    /// <para>Defines the BackgroundRemoval Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:backgroundRemoval.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark" /> <c>&lt;a14:backgroundMark></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark" /> <c>&lt;a14:foregroundMark></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:backgroundRemoval")]
#pragma warning restore CS0618 // Type or member is obsolete
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
        /// <para>t, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? MarqueeTop
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("b")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? MarqueeBottom
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>l, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("l")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? MarqueeLeft
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? MarqueeRight
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:backgroundRemoval");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundMark>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark>();
            builder.AddElement<BackgroundRemoval>()
.AddAttribute("t", a => a.MarqueeTop, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("b", a => a.MarqueeBottom, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("l", a => a.MarqueeLeft, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
})
.AddAttribute("r", a => a.MarqueeRight, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:brightnessContrast.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:brightnessContrast")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BrightnessContrast : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BrightnessContrast class.
        /// </summary>
        public BrightnessContrast() : base()
        {
        }

        /// <summary>
        /// <para>bright, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: bright</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("bright")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Bright
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contrast, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: contrast</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("contrast")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Contrast
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:brightnessContrast");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BrightnessContrast>()
.AddAttribute("bright", a => a.Bright, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-100000L), MaxInclusive = (100000L) });
})
.AddAttribute("contrast", a => a.Contrast, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-100000L), MaxInclusive = (100000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BrightnessContrast>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorTemperature Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:colorTemperature.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:colorTemperature")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorTemperature : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorTemperature class.
        /// </summary>
        public ColorTemperature() : base()
        {
        }

        /// <summary>
        /// <para>colorTemp, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: colorTemp</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("colorTemp")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? ColorTemperatureValue
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:colorTemperature");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ColorTemperature>()
.AddAttribute("colorTemp", a => a.ColorTemperatureValue, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1500L), MaxInclusive = (11500L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTemperature>(deep);
    }

    /// <summary>
    /// <para>Defines the Saturation Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:saturation.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:saturation")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Saturation : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Saturation class.
        /// </summary>
        public Saturation() : base()
        {
        }

        /// <summary>
        /// <para>sat, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sat</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("sat")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? SaturationAmount
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:saturation");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Saturation>()
.AddAttribute("sat", a => a.SaturationAmount, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (400000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Saturation>(deep);
    }

    /// <summary>
    /// <para>Defines the SharpenSoften Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:sharpenSoften.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:sharpenSoften")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SharpenSoften : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SharpenSoften class.
        /// </summary>
        public SharpenSoften() : base()
        {
        }

        /// <summary>
        /// <para>amount, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: amount</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("amount")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Amount
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:sharpenSoften");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SharpenSoften>()
.AddAttribute("amount", a => a.Amount, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-100000L), MaxInclusive = (100000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharpenSoften>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageEffect Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:imgEffect.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval" /> <c>&lt;a14:backgroundRemoval></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur" /> <c>&lt;a14:artisticBlur></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast" /> <c>&lt;a14:brightnessContrast></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement" /> <c>&lt;a14:artisticCement></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch" /> <c>&lt;a14:artisticChalkSketch></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature" /> <c>&lt;a14:colorTemperature></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching" /> <c>&lt;a14:artisticCrisscrossEtching></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout" /> <c>&lt;a14:artisticCutout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain" /> <c>&lt;a14:artisticFilmGrain></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass" /> <c>&lt;a14:artisticGlass></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused" /> <c>&lt;a14:artisticGlowDiffused></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges" /> <c>&lt;a14:artisticGlowEdges></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen" /> <c>&lt;a14:artisticLightScreen></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing" /> <c>&lt;a14:artisticLineDrawing></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker" /> <c>&lt;a14:artisticMarker></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles" /> <c>&lt;a14:artisticMosiaicBubbles></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush" /> <c>&lt;a14:artisticPaintBrush></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes" /> <c>&lt;a14:artisticPaintStrokes></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth" /> <c>&lt;a14:artisticPastelsSmooth></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale" /> <c>&lt;a14:artisticPencilGrayscale></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch" /> <c>&lt;a14:artisticPencilSketch></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy" /> <c>&lt;a14:artisticPhotocopy></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap" /> <c>&lt;a14:artisticPlasticWrap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Saturation" /> <c>&lt;a14:saturation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften" /> <c>&lt;a14:sharpenSoften></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer" /> <c>&lt;a14:artisticTexturizer></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge" /> <c>&lt;a14:artisticWatercolorSponge></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:imgEffect")]
#pragma warning restore CS0618 // Type or member is obsolete
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
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("visible")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:imgEffect");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Saturation>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>();
            builder.AddElement<ImageEffect>()
.AddAttribute("visible", a => a.Visible);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
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
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur? ArtisticBlur
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticBlur>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticCement.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticCement.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement? ArtisticCement
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticChalkSketch.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticChalkSketch.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch? ArtisticChalkSketch
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticCrisscrossEtching.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticCrisscrossEtching.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching? ArtisticCrisscrossEtching
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticCutout.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticCutout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout? ArtisticCutout
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticFilmGrain.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticFilmGrain.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain? ArtisticFilmGrain
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticGlass.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticGlass.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass? ArtisticGlass
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticGlowDiffused.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticGlowDiffused.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused? ArtisticGlowDiffused
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticGlowEdges.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticGlowEdges.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges? ArtisticGlowEdges
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticLightScreen.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticLightScreen.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen? ArtisticLightScreen
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticLineDrawing.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticLineDrawing.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing? ArtisticLineDrawing
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticMarker.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticMarker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker? ArtisticMarker
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMarker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticMosaicBubbles.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticMosiaicBubbles.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles? ArtisticMosaicBubbles
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticMosaicBubbles>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPaintStrokes.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPaintStrokes.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes? ArtisticPaintStrokes
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPaintBrush.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPaintBrush.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush? ArtisticPaintBrush
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPastelsSmooth.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPastelsSmooth.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth? ArtisticPastelsSmooth
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPencilGrayscale.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPencilGrayscale.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale? ArtisticPencilGrayscale
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPencilSketch.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPencilSketch.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch? ArtisticPencilSketch
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPhotocopy.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPhotocopy.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy? ArtisticPhotocopy
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticPlasticWrap.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticPlasticWrap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap? ArtisticPlasticWrap
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticTexturizer.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticTexturizer.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer? ArtisticTexturizer
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ArtisticWatercolorSponge.</para>
        /// <para>Represents the following element tag in the schema: a14:artisticWatercolorSponge.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge? ArtisticWatercolorSponge
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BackgroundRemoval.</para>
        /// <para>Represents the following element tag in the schema: a14:backgroundRemoval.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval? BackgroundRemoval
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BrightnessContrast.</para>
        /// <para>Represents the following element tag in the schema: a14:brightnessContrast.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast? BrightnessContrast
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.BrightnessContrast>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColorTemperature.</para>
        /// <para>Represents the following element tag in the schema: a14:colorTemperature.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature? ColorTemperature
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ColorTemperature>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Saturation.</para>
        /// <para>Represents the following element tag in the schema: a14:saturation.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Saturation? Saturation
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Saturation>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SharpenSoften.</para>
        /// <para>Represents the following element tag in the schema: a14:sharpenSoften.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften? SharpenSoften
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageEffect>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageLayer Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:imgLayer.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect" /> <c>&lt;a14:imgEffect></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:imgLayer")]
#pragma warning restore CS0618 // Type or member is obsolete
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
        /// <para>embed, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: r:embed</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:embed")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Embed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:imgLayer");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>();
            builder.AddElement<ImageLayer>()
.AddAttribute("r:embed", a => a.Embed);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageLayer>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualDrawingProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnClick" /> <c>&lt;a:hlinkClick></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnHover" /> <c>&lt;a:hlinkHover></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:cNvPr")]
#pragma warning restore CS0618 // Type or member is obsolete
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
        /// <para>Application defined unique identifier.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Name compatible with Object Model (non-unique).</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description of the drawing element.</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("descr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Flag determining to show or hide this element.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("hidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("title")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:cNvPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            builder.AddElement<NonVisualDrawingProperties>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("descr", a => a.Description)
.AddAttribute("hidden", a => a.Hidden)
.AddAttribute("title", a => a.Title);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Hyperlink associated with clicking or selecting the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick? HyperlinkOnClick
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hyperlink associated with hovering over the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover? HyperlinkOnHover
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future extension.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualInkContentPartProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:cNvContentPartPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList" /> <c>&lt;a14:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks" /> <c>&lt;a14:cpLocks></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:cNvContentPartPr")]
#pragma warning restore CS0618 // Type or member is obsolete
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
        /// <para>isComment, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: isComment</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("isComment")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? IsComment
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:cNvContentPartPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>();
            builder.AddElement<NonVisualInkContentPartProperties>()
.AddAttribute("isComment", a => a.IsComment);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks? ContentPartLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualInkContentPartProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualContentPartProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:nvContentPartPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.NonVisualDrawingProperties" /> <c>&lt;a14:cNvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.NonVisualInkContentPartProperties" /> <c>&lt;a14:cNvContentPartPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:nvContentPartPr")]
#pragma warning restore CS0618 // Type or member is obsolete
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
            builder.SetSchema("a14:nvContentPartPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.NonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.NonVisualInkContentPartProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Office2010.Drawing.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualInkContentPartProperties.</para>
        /// <para>Represents the following element tag in the schema: a14:cNvContentPartPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.NonVisualInkContentPartProperties? NonVisualInkContentPartProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.NonVisualInkContentPartProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualContentPartProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the Transform2D Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a14:xfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Offset" /> <c>&lt;a:off></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extents" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("a14:xfrm")]
#pragma warning restore CS0618 // Type or member is obsolete
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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("flipH")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("flipV")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a14:xfrm");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Offset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extents>();
            builder.AddElement<Transform2D>()
.AddAttribute("rot", a => a.Rotation)
.AddAttribute("flipH", a => a.HorizontalFlip)
.AddAttribute("flipV", a => a.VerticalFlip);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
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
        public DocumentFormat.OpenXml.Drawing.Offset? Offset
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
        public DocumentFormat.OpenXml.Drawing.Extents? Extents
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);
    }
}