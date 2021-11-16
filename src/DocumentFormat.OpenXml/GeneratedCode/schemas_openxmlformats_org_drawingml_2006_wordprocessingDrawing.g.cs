// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Word.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Drawing.Wordprocessing
{
    /// <summary>
    /// <para>No Text Wrapping.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:wrapNone.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "wrapNone")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class WrapNone : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WrapNone class.
        /// </summary>
        public WrapNone() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "wrapNone");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapNone>(deep);
    }

    /// <summary>
    /// <para>Square Wrapping.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:wrapSquare.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent" /> <c>&lt;wp:effectExtent></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "wrapSquare")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class WrapSquare : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WrapSquare class.
        /// </summary>
        public WrapSquare() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapSquare class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WrapSquare(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapSquare class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WrapSquare(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapSquare class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WrapSquare(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Text Wrapping Location</para>
        /// <para>Represents the following attribute in the schema: wrapText</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "wrapText")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>? WrapText
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text (Top)</para>
        /// <para>Represents the following attribute in the schema: distT</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distT")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromTop
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Bottom Edge</para>
        /// <para>Represents the following attribute in the schema: distB</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distB")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromBottom
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Left Edge</para>
        /// <para>Represents the following attribute in the schema: distL</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distL")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromLeft
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Right Edge</para>
        /// <para>Represents the following attribute in the schema: distR</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distR")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromRight
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "wrapSquare");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
            builder.AddElement<WrapSquare>()
.AddAttribute(0, "wrapText", a => a.WrapText, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "distT", a => a.DistanceFromTop)
.AddAttribute(0, "distB", a => a.DistanceFromBottom)
.AddAttribute(0, "distL", a => a.DistanceFromLeft)
.AddAttribute(0, "distR", a => a.DistanceFromRight);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent), 0, 1)
            };
        }

        /// <summary>
        /// <para>Object Extents Including Effects.</para>
        /// <para>Represents the following element tag in the schema: wp:effectExtent.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? EffectExtent
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapSquare>(deep);
    }

    /// <summary>
    /// <para>Tight Wrapping.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:wrapTight.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon" /> <c>&lt;wp:wrapPolygon></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "wrapTight")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class WrapTight : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WrapTight class.
        /// </summary>
        public WrapTight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapTight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WrapTight(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapTight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WrapTight(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapTight class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WrapTight(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Text Wrapping Location</para>
        /// <para>Represents the following attribute in the schema: wrapText</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "wrapText")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>? WrapText
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Test on Left Edge</para>
        /// <para>Represents the following attribute in the schema: distL</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distL")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromLeft
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Right Edge</para>
        /// <para>Represents the following attribute in the schema: distR</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distR")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromRight
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "wrapTight");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>();
            builder.AddElement<WrapTight>()
.AddAttribute(0, "wrapText", a => a.WrapText, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "distL", a => a.DistanceFromLeft)
.AddAttribute(0, "distR", a => a.DistanceFromRight);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon), 1, 1)
            };
        }

        /// <summary>
        /// <para>Tight Wrapping Extents Polygon.</para>
        /// <para>Represents the following element tag in the schema: wp:wrapPolygon.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon? WrapPolygon
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapTight>(deep);
    }

    /// <summary>
    /// <para>Through Wrapping.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:wrapThrough.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon" /> <c>&lt;wp:wrapPolygon></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "wrapThrough")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class WrapThrough : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WrapThrough class.
        /// </summary>
        public WrapThrough() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapThrough class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WrapThrough(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapThrough class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WrapThrough(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapThrough class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WrapThrough(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Text Wrapping Location</para>
        /// <para>Represents the following attribute in the schema: wrapText</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "wrapText")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>? WrapText
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Left Edge</para>
        /// <para>Represents the following attribute in the schema: distL</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distL")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromLeft
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Right Edge</para>
        /// <para>Represents the following attribute in the schema: distR</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distR")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromRight
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "wrapThrough");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>();
            builder.AddElement<WrapThrough>()
.AddAttribute(0, "wrapText", a => a.WrapText, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "distL", a => a.DistanceFromLeft)
.AddAttribute(0, "distR", a => a.DistanceFromRight);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon), 1, 1)
            };
        }

        /// <summary>
        /// <para>Wrapping Polygon.</para>
        /// <para>Represents the following element tag in the schema: wp:wrapPolygon.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon? WrapPolygon
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapThrough>(deep);
    }

    /// <summary>
    /// <para>Top and Bottom Wrapping.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:wrapTopAndBottom.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent" /> <c>&lt;wp:effectExtent></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "wrapTopAndBottom")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class WrapTopBottom : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WrapTopBottom class.
        /// </summary>
        public WrapTopBottom() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapTopBottom class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WrapTopBottom(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapTopBottom class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WrapTopBottom(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapTopBottom class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WrapTopBottom(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Distance From Text on Top Edge</para>
        /// <para>Represents the following attribute in the schema: distT</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distT")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromTop
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Bottom Edge</para>
        /// <para>Represents the following attribute in the schema: distB</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distB")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromBottom
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "wrapTopAndBottom");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
            builder.AddElement<WrapTopBottom>()
.AddAttribute(0, "distT", a => a.DistanceFromTop)
.AddAttribute(0, "distB", a => a.DistanceFromBottom);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent), 0, 1)
            };
        }

        /// <summary>
        /// <para>Wrapping Boundaries.</para>
        /// <para>Represents the following element tag in the schema: wp:effectExtent.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? EffectExtent
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapTopBottom>(deep);
    }

    /// <summary>
    /// <para>Inline DrawingML Object.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:inline.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Graphic" /> <c>&lt;a:graphic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties" /> <c>&lt;wp:docPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties" /> <c>&lt;wp:cNvGraphicFramePr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent" /> <c>&lt;wp:extent></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent" /> <c>&lt;wp:effectExtent></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "inline")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Inline : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Inline class.
        /// </summary>
        public Inline() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Inline class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Inline(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Inline class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Inline(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Inline class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Inline(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Distance From Text on Top Edge</para>
        /// <para>Represents the following attribute in the schema: distT</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distT")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromTop
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Bottom Edge</para>
        /// <para>Represents the following attribute in the schema: distB</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distB")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromBottom
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Left Edge</para>
        /// <para>Represents the following attribute in the schema: distL</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distL")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromLeft
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Right Edge</para>
        /// <para>Represents the following attribute in the schema: distR</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distR")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromRight
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>anchorId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: wp14:anchorId</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(51, "anchorId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public HexBinaryValue? AnchorId
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>editId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: wp14:editId</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(51, "editId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public HexBinaryValue? EditId
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "inline");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Graphic>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
            builder.AddElement<Inline>()
.AddAttribute(0, "distT", a => a.DistanceFromTop)
.AddAttribute(0, "distB", a => a.DistanceFromBottom)
.AddAttribute(0, "distL", a => a.DistanceFromLeft)
.AddAttribute(0, "distR", a => a.DistanceFromRight)
.AddAttribute(51, "anchorId", a => a.AnchorId, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
})
.AddAttribute(51, "editId", a => a.EditId, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Graphic), 1, 1)
            };
        }

        /// <summary>
        /// <para>Drawing Object Size.</para>
        /// <para>Represents the following element tag in the schema: wp:extent.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent? Extent
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Inline Wrapping Extent.</para>
        /// <para>Represents the following element tag in the schema: wp:effectExtent.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? EffectExtent
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Drawing Object Non-Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: wp:docPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties? DocProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Common DrawingML Non-Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: wp:cNvGraphicFramePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Graphic.</para>
        /// <para>Represents the following element tag in the schema: a:graphic.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Graphic? Graphic
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Graphic>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Inline>(deep);
    }

    /// <summary>
    /// <para>Anchor for Floating DrawingML Object.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:anchor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Graphic" /> <c>&lt;a:graphic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties" /> <c>&lt;wp:docPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties" /> <c>&lt;wp:cNvGraphicFramePr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.SimplePosition" /> <c>&lt;wp:simplePos></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent" /> <c>&lt;wp:extent></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent" /> <c>&lt;wp:effectExtent></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition" /> <c>&lt;wp:positionH></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition" /> <c>&lt;wp:positionV></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapNone" /> <c>&lt;wp:wrapNone></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare" /> <c>&lt;wp:wrapSquare></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough" /> <c>&lt;wp:wrapThrough></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight" /> <c>&lt;wp:wrapTight></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom" /> <c>&lt;wp:wrapTopAndBottom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth" /> <c>&lt;wp14:sizeRelH></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight" /> <c>&lt;wp14:sizeRelV></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "anchor")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Anchor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Anchor class.
        /// </summary>
        public Anchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Anchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Anchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Anchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Anchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Anchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Anchor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Distance From Text on Top Edge</para>
        /// <para>Represents the following attribute in the schema: distT</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distT")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromTop
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Bottom Edge</para>
        /// <para>Represents the following attribute in the schema: distB</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distB")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromBottom
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Left Edge</para>
        /// <para>Represents the following attribute in the schema: distL</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distL")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromLeft
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance From Text on Right Edge</para>
        /// <para>Represents the following attribute in the schema: distR</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distR")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DistanceFromRight
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Page Positioning</para>
        /// <para>Represents the following attribute in the schema: simplePos</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "simplePos")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? SimplePos
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Z-Ordering Position</para>
        /// <para>Represents the following attribute in the schema: relativeHeight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "relativeHeight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? RelativeHeight
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Display Behind Document Text</para>
        /// <para>Represents the following attribute in the schema: behindDoc</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "behindDoc")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? BehindDoc
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Lock Anchor</para>
        /// <para>Represents the following attribute in the schema: locked</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "locked")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Locked
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Layout In Table Cell</para>
        /// <para>Represents the following attribute in the schema: layoutInCell</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "layoutInCell")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? LayoutInCell
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hidden</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "hidden")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Objects to Overlap</para>
        /// <para>Represents the following attribute in the schema: allowOverlap</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "allowOverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? AllowOverlap
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>editId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: wp14:editId</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(51, "editId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public HexBinaryValue? EditId
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>anchorId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: wp14:anchorId</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp14=http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(51, "anchorId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public HexBinaryValue? AnchorId
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "anchor");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Graphic>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.SimplePosition>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapNone>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight>();
            builder.AddElement<Anchor>()
.AddAttribute(0, "distT", a => a.DistanceFromTop)
.AddAttribute(0, "distB", a => a.DistanceFromBottom)
.AddAttribute(0, "distL", a => a.DistanceFromLeft)
.AddAttribute(0, "distR", a => a.DistanceFromRight)
.AddAttribute(0, "simplePos", a => a.SimplePos)
.AddAttribute(0, "relativeHeight", a => a.RelativeHeight, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "behindDoc", a => a.BehindDoc, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "locked", a => a.Locked, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "layoutInCell", a => a.LayoutInCell, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "hidden", a => a.Hidden)
.AddAttribute(0, "allowOverlap", a => a.AllowOverlap, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(51, "editId", a => a.EditId, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
})
.AddAttribute(51, "anchorId", a => a.AnchorId, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
aBuilder.AddValidator(new StringValidator() { Length = (4L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.SimplePosition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapNone), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTight), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom), 1, 1)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Graphic), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeWidth), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.RelativeHeight), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>Simple Positioning Coordinates.</para>
        /// <para>Represents the following element tag in the schema: wp:simplePos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.SimplePosition? SimplePosition
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.SimplePosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Horizontal Positioning.</para>
        /// <para>Represents the following element tag in the schema: wp:positionH.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? HorizontalPosition
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Vertical Positioning.</para>
        /// <para>Represents the following element tag in the schema: wp:positionV.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? VerticalPosition
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Inline Drawing Object Extents.</para>
        /// <para>Represents the following element tag in the schema: wp:extent.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent? Extent
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectExtent.</para>
        /// <para>Represents the following element tag in the schema: wp:effectExtent.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? EffectExtent
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Anchor>(deep);
    }

    /// <summary>
    /// <para>Wrapping Polygon Start.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:start.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "start")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StartPoint : Point2DType
    {
        /// <summary>
        /// Initializes a new instance of the StartPoint class.
        /// </summary>
        public StartPoint() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "start");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StartPoint>(deep);
    }

    /// <summary>
    /// <para>Wrapping Polygon Line End Position.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:lineTo.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "lineTo")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LineTo : Point2DType
    {
        /// <summary>
        /// Initializes a new instance of the LineTo class.
        /// </summary>
        public LineTo() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "lineTo");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineTo>(deep);
    }

    /// <summary>
    /// <para>Simple Positioning Coordinates.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:simplePos.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "simplePos")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SimplePosition : Point2DType
    {
        /// <summary>
        /// Initializes a new instance of the SimplePosition class.
        /// </summary>
        public SimplePosition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "simplePos");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SimplePosition>(deep);
    }

    /// <summary>
    /// <para>Defines the Point2DType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class Point2DType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Point2DType class.
        /// </summary>
        protected Point2DType() : base()
        {
        }

        /// <summary>
        /// <para>X-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "x")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? X
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Y-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "y")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Y
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<Point2DType>()
                           .AddAttribute(0, "x", a => a.X, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                           })
                           .AddAttribute(0, "y", a => a.Y, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                           });
        }
    }

    /// <summary>
    /// <para>Object Extents Including Effects.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:effectExtent.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "effectExtent")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EffectExtent : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EffectExtent class.
        /// </summary>
        public EffectExtent() : base()
        {
        }

        /// <summary>
        /// <para>Additional Extent on Left Edge</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "l")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? LeftEdge
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Additional Extent on Top Edge</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? TopEdge
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Additional Extent on Right Edge</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "r")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? RightEdge
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Additional Extent on Bottom Edge</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "b")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? BottomEdge
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "effectExtent");
            builder.AddElement<EffectExtent>()
.AddAttribute(0, "l", a => a.LeftEdge, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "t", a => a.TopEdge, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "r", a => a.RightEdge, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "b", a => a.BottomEdge, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectExtent>(deep);
    }

    /// <summary>
    /// <para>Tight Wrapping Extents Polygon.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:wrapPolygon.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.StartPoint" /> <c>&lt;wp:start></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.LineTo" /> <c>&lt;wp:lineTo></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "wrapPolygon")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class WrapPolygon : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WrapPolygon class.
        /// </summary>
        public WrapPolygon() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapPolygon class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WrapPolygon(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapPolygon class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WrapPolygon(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WrapPolygon class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WrapPolygon(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Wrapping Points Modified</para>
        /// <para>Represents the following attribute in the schema: edited</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "edited")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Edited
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "wrapPolygon");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.StartPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.LineTo>();
            builder.AddElement<WrapPolygon>()
.AddAttribute(0, "edited", a => a.Edited);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.StartPoint), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.LineTo), 2, 0)
            };
        }

        /// <summary>
        /// <para>Wrapping Polygon Start.</para>
        /// <para>Represents the following element tag in the schema: wp:start.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.StartPoint? StartPoint
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.StartPoint>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapPolygon>(deep);
    }

    /// <summary>
    /// <para>Horizontal Positioning.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:positionH.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset" /> <c>&lt;wp14:pctPosHOffset></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment" /> <c>&lt;wp:align></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset" /> <c>&lt;wp:posOffset></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "positionH")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HorizontalPosition : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HorizontalPosition class.
        /// </summary>
        public HorizontalPosition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HorizontalPosition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HorizontalPosition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HorizontalPosition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HorizontalPosition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HorizontalPosition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HorizontalPosition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Horizontal Position Relative Base</para>
        /// <para>Represents the following attribute in the schema: relativeFrom</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "relativeFrom")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues>? RelativeFrom
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "positionH");
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset>();
            builder.AddElement<HorizontalPosition>()
.AddAttribute(0, "relativeFrom", a => a.RelativeFrom, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset), 0, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <summary>
        /// <para>Relative Horizontal Alignment.</para>
        /// <para>Represents the following element tag in the schema: wp:align.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment? HorizontalAlignment
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Absolute Position Offset.</para>
        /// <para>Represents the following element tag in the schema: wp:posOffset.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset? PositionOffset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PercentagePositionHeightOffset, this property is only available in Office 2010 and later..</para>
        /// <para>Represents the following element tag in the schema: wp14:pctPosHOffset.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp14 = http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset? PercentagePositionHeightOffset
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HorizontalPosition>(deep);
    }

    /// <summary>
    /// <para>Vertical Positioning.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:positionV.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset" /> <c>&lt;wp14:pctPosVOffset></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignment" /> <c>&lt;wp:align></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset" /> <c>&lt;wp:posOffset></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "positionV")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class VerticalPosition : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the VerticalPosition class.
        /// </summary>
        public VerticalPosition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VerticalPosition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VerticalPosition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VerticalPosition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VerticalPosition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VerticalPosition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public VerticalPosition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Vertical Position Relative Base</para>
        /// <para>Represents the following attribute in the schema: relativeFrom</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "relativeFrom")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues>? RelativeFrom
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "positionV");
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignment>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset>();
            builder.AddElement<VerticalPosition>()
.AddAttribute(0, "relativeFrom", a => a.RelativeFrom, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignment), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset), 0, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <summary>
        /// <para>Relative Vertical Alignment.</para>
        /// <para>Represents the following element tag in the schema: wp:align.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignment? VerticalAlignment
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignment>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PositionOffset.</para>
        /// <para>Represents the following element tag in the schema: wp:posOffset.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp = http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset? PositionOffset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..</para>
        /// <para>Represents the following element tag in the schema: wp14:pctPosVOffset.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wp14 = http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset? PercentagePositionVerticalOffset
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalPosition>(deep);
    }

    /// <summary>
    /// <para>Inline Drawing Object Extents.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:extent.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "extent")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Extent : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Extent class.
        /// </summary>
        public Extent() : base()
        {
        }

        /// <summary>
        /// <para>Extent Length</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "cx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Cx
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extent Width</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "cy")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Cy
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "extent");
            builder.AddElement<Extent>()
.AddAttribute(0, "cx", a => a.Cx, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "cy", a => a.Cy, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extent>(deep);
    }

    /// <summary>
    /// <para>Drawing Object Non-Visual Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:docPr.</para>
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
    [SchemaAttr(16, "docPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DocProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DocProperties class.
        /// </summary>
        public DocProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DocProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Application defined unique identifier.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
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

        [SchemaAttr(0, "name")]
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

        [SchemaAttr(0, "descr")]
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

        [SchemaAttr(0, "hidden")]
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

        [SchemaAttr(0, "title")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "docPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            builder.AddElement<DocProperties>()
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
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualGraphicFrameDrawingProperties Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:cNvGraphicFramePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GraphicFrameLocks" /> <c>&lt;a:graphicFrameLocks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "cNvGraphicFramePr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NonVisualGraphicFrameDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class.
        /// </summary>
        public NonVisualGraphicFrameDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGraphicFrameDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(16, "cNvGraphicFramePr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Graphic Frame Locks.</para>
        /// <para>Represents the following element tag in the schema: a:graphicFrameLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? GraphicFrameLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Relative Vertical Alignment.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:align.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "align")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class VerticalAlignment : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the VerticalAlignment class.
        /// </summary>
        public VerticalAlignment() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VerticalAlignment class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public VerticalAlignment(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignmentValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { IsToken = (true) });
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignmentValues>>(EnumValidator.Instance);
            builder.SetSchema(16, "align");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalAlignment>(deep);
    }

    /// <summary>
    /// <para>Defines the PositionOffset Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:posOffset.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "posOffset")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PositionOffset : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PositionOffset class.
        /// </summary>
        public PositionOffset() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PositionOffset class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PositionOffset(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(16, "posOffset");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PositionOffset>(deep);
    }

    /// <summary>
    /// <para>Relative Horizontal Alignment.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp:align.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(16, "align")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HorizontalAlignment : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the HorizontalAlignment class.
        /// </summary>
        public HorizontalAlignment() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HorizontalAlignment class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public HorizontalAlignment(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignmentValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { IsToken = (true) });
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignmentValues>>(EnumValidator.Instance);
            builder.SetSchema(16, "align");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HorizontalAlignment>(deep);
    }

    /// <summary>
    /// Text Wrapping Location
    /// </summary>
    public enum WrapTextValues
    {
        /// <summary>
        /// Both Sides.
        /// <para>When the item is serialized out as xml, its value is "bothSides".</para>
        /// </summary>
        [EnumString("bothSides")]
        BothSides,
        /// <summary>
        /// Left Side Only.
        /// <para>When the item is serialized out as xml, its value is "left".</para>
        /// </summary>
        [EnumString("left")]
        Left,
        /// <summary>
        /// Right Side Only.
        /// <para>When the item is serialized out as xml, its value is "right".</para>
        /// </summary>
        [EnumString("right")]
        Right,
        /// <summary>
        /// Largest Side Only.
        /// <para>When the item is serialized out as xml, its value is "largest".</para>
        /// </summary>
        [EnumString("largest")]
        Largest
    }

    /// <summary>
    /// Relative Horizontal Alignment Positions
    /// </summary>
    public enum HorizontalAlignmentValues
    {
        /// <summary>
        /// Left Alignment.
        /// <para>When the item is serialized out as xml, its value is "left".</para>
        /// </summary>
        [EnumString("left")]
        Left,
        /// <summary>
        /// Right Alignment.
        /// <para>When the item is serialized out as xml, its value is "right".</para>
        /// </summary>
        [EnumString("right")]
        Right,
        /// <summary>
        /// Center Alignment.
        /// <para>When the item is serialized out as xml, its value is "center".</para>
        /// </summary>
        [EnumString("center")]
        Center,
        /// <summary>
        /// Inside.
        /// <para>When the item is serialized out as xml, its value is "inside".</para>
        /// </summary>
        [EnumString("inside")]
        Inside,
        /// <summary>
        /// Outside.
        /// <para>When the item is serialized out as xml, its value is "outside".</para>
        /// </summary>
        [EnumString("outside")]
        Outside
    }

    /// <summary>
    /// Horizontal Relative Positioning
    /// </summary>
    public enum HorizontalRelativePositionValues
    {
        /// <summary>
        /// Page Margin.
        /// <para>When the item is serialized out as xml, its value is "margin".</para>
        /// </summary>
        [EnumString("margin")]
        Margin,
        /// <summary>
        /// Page Edge.
        /// <para>When the item is serialized out as xml, its value is "page".</para>
        /// </summary>
        [EnumString("page")]
        Page,
        /// <summary>
        /// Column.
        /// <para>When the item is serialized out as xml, its value is "column".</para>
        /// </summary>
        [EnumString("column")]
        Column,
        /// <summary>
        /// Character.
        /// <para>When the item is serialized out as xml, its value is "character".</para>
        /// </summary>
        [EnumString("character")]
        Character,
        /// <summary>
        /// Left Margin.
        /// <para>When the item is serialized out as xml, its value is "leftMargin".</para>
        /// </summary>
        [EnumString("leftMargin")]
        LeftMargin,
        /// <summary>
        /// Right Margin.
        /// <para>When the item is serialized out as xml, its value is "rightMargin".</para>
        /// </summary>
        [EnumString("rightMargin")]
        RightMargin,
        /// <summary>
        /// Inside Margin.
        /// <para>When the item is serialized out as xml, its value is "insideMargin".</para>
        /// </summary>
        [EnumString("insideMargin")]
        InsideMargin,
        /// <summary>
        /// Outside Margin.
        /// <para>When the item is serialized out as xml, its value is "outsideMargin".</para>
        /// </summary>
        [EnumString("outsideMargin")]
        OutsideMargin
    }

    /// <summary>
    /// Vertical Alignment Definition
    /// </summary>
    public enum VerticalAlignmentValues
    {
        /// <summary>
        /// Top.
        /// <para>When the item is serialized out as xml, its value is "top".</para>
        /// </summary>
        [EnumString("top")]
        Top,
        /// <summary>
        /// Bottom.
        /// <para>When the item is serialized out as xml, its value is "bottom".</para>
        /// </summary>
        [EnumString("bottom")]
        Bottom,
        /// <summary>
        /// Center Alignment.
        /// <para>When the item is serialized out as xml, its value is "center".</para>
        /// </summary>
        [EnumString("center")]
        Center,
        /// <summary>
        /// Inside.
        /// <para>When the item is serialized out as xml, its value is "inside".</para>
        /// </summary>
        [EnumString("inside")]
        Inside,
        /// <summary>
        /// Outside.
        /// <para>When the item is serialized out as xml, its value is "outside".</para>
        /// </summary>
        [EnumString("outside")]
        Outside
    }

    /// <summary>
    /// Vertical Relative Positioning
    /// </summary>
    public enum VerticalRelativePositionValues
    {
        /// <summary>
        /// Page Margin.
        /// <para>When the item is serialized out as xml, its value is "margin".</para>
        /// </summary>
        [EnumString("margin")]
        Margin,
        /// <summary>
        /// Page Edge.
        /// <para>When the item is serialized out as xml, its value is "page".</para>
        /// </summary>
        [EnumString("page")]
        Page,
        /// <summary>
        /// Paragraph.
        /// <para>When the item is serialized out as xml, its value is "paragraph".</para>
        /// </summary>
        [EnumString("paragraph")]
        Paragraph,
        /// <summary>
        /// Line.
        /// <para>When the item is serialized out as xml, its value is "line".</para>
        /// </summary>
        [EnumString("line")]
        Line,
        /// <summary>
        /// Top Margin.
        /// <para>When the item is serialized out as xml, its value is "topMargin".</para>
        /// </summary>
        [EnumString("topMargin")]
        TopMargin,
        /// <summary>
        /// Bottom Margin.
        /// <para>When the item is serialized out as xml, its value is "bottomMargin".</para>
        /// </summary>
        [EnumString("bottomMargin")]
        BottomMargin,
        /// <summary>
        /// Inside Margin.
        /// <para>When the item is serialized out as xml, its value is "insideMargin".</para>
        /// </summary>
        [EnumString("insideMargin")]
        InsideMargin,
        /// <summary>
        /// Outside Margin.
        /// <para>When the item is serialized out as xml, its value is "outsideMargin".</para>
        /// </summary>
        [EnumString("outsideMargin")]
        OutsideMargin
    }
}