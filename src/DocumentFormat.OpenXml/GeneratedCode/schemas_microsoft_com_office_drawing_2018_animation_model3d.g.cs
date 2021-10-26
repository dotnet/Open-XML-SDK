// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2019.Drawing.Animation;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D
{
    /// <summary>
    /// <para>Defines the EmbeddedAnimation Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a3danim:embedAnim.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AnimationProperties &lt;a3danim:animPr></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;a3danim:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(114, "embedAnim")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EmbeddedAnimation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EmbeddedAnimation class.
        /// </summary>
        public EmbeddedAnimation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedAnimation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EmbeddedAnimation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedAnimation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EmbeddedAnimation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedAnimation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EmbeddedAnimation(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>animId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: animId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "animId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? AnimId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(114, "embedAnim");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<AnimationProperties>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.AddElement<EmbeddedAnimation>()
.AddAttribute(0, "animId", a => a.AnimId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.AnimationProperties), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>AnimationProperties.</para>
        /// <para>Represents the following element tag in the schema: a3danim:animPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a3danim = http://schemas.microsoft.com/office/drawing/2018/animation/model3d
        /// </remark>
        public AnimationProperties? AnimationProperties
        {
            get => GetElement<AnimationProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a3danim:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a3danim = http://schemas.microsoft.com/office/drawing/2018/animation/model3d
        /// </remark>
        public OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EmbeddedAnimation>(deep);
    }

    /// <summary>
    /// <para>Defines the PosterFrame Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a3danim:posterFrame.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(114, "posterFrame")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PosterFrame : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PosterFrame class.
        /// </summary>
        public PosterFrame() : base()
        {
        }

        /// <summary>
        /// <para>animId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: animId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "animId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? AnimId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>frame, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: frame</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "frame")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Frame
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(114, "posterFrame");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<PosterFrame>()
.AddAttribute(0, "animId", a => a.AnimId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "frame", a => a.Frame, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PosterFrame>(deep);
    }

    /// <summary>
    /// <para>Defines the AnimationProperties Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a3danim:animPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2019.Drawing.Animation.OfficeArtExtensionList &lt;aanim:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(114, "animPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AnimationProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimationProperties class.
        /// </summary>
        public AnimationProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimationProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimationProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimationProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimationProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimationProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnimationProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>length, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: length</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "length")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Length
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "count")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Count
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>auto, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: auto</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "auto")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Auto
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: offset</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "offset")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Offset
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>st, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "st")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? St
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: end</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "end")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? End
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(114, "animPr");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Animation.OfficeArtExtensionList>();
            builder.AddElement<AnimationProperties>()
.AddAttribute(0, "name", a => a.Name)
.AddAttribute(0, "length", a => a.Length, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<UInt32Value>(NumberValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Office2019.Drawing.Animation.Indefinite>>(EnumValidator.Instance);
});
})
.AddAttribute(0, "auto", a => a.Auto)
.AddAttribute(0, "offset", a => a.Offset)
.AddAttribute(0, "st", a => a.St)
.AddAttribute(0, "end", a => a.End);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Animation.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: aanim:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:aanim = http://schemas.microsoft.com/office/drawing/2018/animation
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Animation.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Animation.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimationProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a3danim:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(114, "extLst")]
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
            builder.SetSchema(114, "extLst");
            builder.Availability = FileFormatVersions.Office2019;
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
}